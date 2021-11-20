using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        List<PointF> points = new List<PointF>();
        Edge[,] edges;
        Edge[] results;
        Edge[] tempResults;
        float total = 0, lowerBound = 0, minTempResult = 999999999;
        int startPoint;
        int amount;
        bool isPaint = false;
        string filePath = @"D:\Programs\CT239\TSP\TSP\point.txt";
        string info = "";
        int selectedIndex = -100;
        int row = 0;
        int scale = 10;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearData();
            cbxStart.Items.Add("--Chọn đảo bắt đầu--");
            
            if (txtInfo.Text.Trim().Length == 0)
            {
                handleInput("Vui lòng nhập thông tin!!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, txtInfo);
                return;
            }
            else
            {
                string[] points = txtInfo.Text.Trim().Split(new[] { Environment.NewLine },
                    StringSplitOptions.None);
                foreach (string point in points)
                {
                    string[] part = point.Trim().Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                    if (!isNumber(part[0].Trim()) || !isNumber(part[1].Trim()))
                    {
                        handleInput("Tọa độ đảo phải là số!!!", "Dữ liệu không hợp lệ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, txtInfo);
                        return;
                    }
                    cbxStart.Items.Add(part[2].Trim());
                }
            }
            info = txtInfo.Text.Trim();
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine(info);
                file.Close();
            }
            showMessage("Thêm thông tin thành công!!!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbxStart.SelectedIndex = 0;
            selectedIndex = -100;
            btnDel.Enabled = true;
            isPaint = true;
            this.pnlResult.Controls.Clear();
            this.pnlResult.Refresh();
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            clearData();
            txtInfo.Text = "";
            btnDel.Enabled = false;
            isPaint = false;
            cbxStart.Text = "";
            cbxStart.Items.Add("--Chọn đảo bắt đầu--");
            cbxStart.SelectedIndex = 0;
            this.pnlResult.Controls.Clear();
            this.pnlResult.Refresh();
        }

        void clearData()
        {
            row = 0;
            cbxStart.Items.Clear();
            points.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        { 
            tsp(edges, results, tempResults, ref total,
                ref lowerBound, ref minTempResult, amount, 0, startPoint);
            displayResult(results, amount);
            //pnlResultText.set
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        bool isNumber(string str, string type = "number")
        {
            Regex regex = new Regex("");
            bool check = false;
            switch (type)
            {
                case "integer":
                    regex = new Regex("^[0-9]+$");
                    break;
                default:
                    regex = new Regex(@"^-?[0-9]+[0-9]*(\.[0-9]+)?$");
                    break;
            }
            if (regex.IsMatch(str))
            {
                check = true;
            }
            return check;
        }

        void showMessage(string content, string caption, 
            MessageBoxButtons btn, MessageBoxIcon icon)
        {
            MessageBox.Show(content, caption, btn, icon);
        }

        void handleInput(string content, string caption,
            MessageBoxButtons btn, MessageBoxIcon icon, Bunifu.UI.WinForms.BunifuTextBox txt)
        {
            showMessage(content, caption, btn, icon);
            txt.Focus();
        }

        private void cbxStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxStart.SelectedIndex != 0)
            {
                selectedIndex = cbxStart.SelectedIndex;
                btnFind.Enabled = true;
            } else
            {
                btnFind.Enabled = false;
                selectedIndex = -100;
            }
            this.pnlResult.Refresh();
        }

        private void btnInputRule_Click(object sender, EventArgs e)
        {
            frmInputRule frm = new frmInputRule();
            frm.ShowDialog();
        }

        private void pnlResult_Paint(object sender, PaintEventArgs e)
        {
            points.Clear();
            row = 0; 
            if (isPaint)
            {
                StreamReader file = new StreamReader(filePath);
                Brush color;
                Pen pinkPen = new Pen(Color.DeepPink, 3);
                string line;
                float round = scale;
                float xCoordinate;
                float yCoordinate;
                float xOrigin = (pnlResult.Width / 2) - (round / 2);
                float yOrigin = (pnlResult.Height / 2) - (round / 2);

                while ((line = file.ReadLine()) != null)
                {
                    row++;
                    if (row == selectedIndex)
                    {
                        color = Brushes.Orange;
                    }
                    else
                    {
                        color = Brushes.Black;
                    }
                    string[] part = line.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    xCoordinate = (float.Parse(part[0]) * scale + xOrigin);
                    yCoordinate = (float.Parse(part[1]) * scale * -1 + yOrigin);
                    points.Add(new PointF(float.Parse(part[0]), float.Parse(part[1])));
                    e.Graphics.FillEllipse(color, xCoordinate, yCoordinate, round, round);

                    Label name = new Label();
                    name.Text = part[2];
                    name.Location = new Point((int)(xCoordinate + scale/2) , (int)(yCoordinate - scale/2));
                    name.ForeColor = Color.White;
                    name.BackColor = Color.Transparent;
                    pnlResult.Controls.Add(name);
                }


                amount = points.Count;

                edges = new Edge[amount, amount];
                results = new Edge[amount];
                tempResults = new Edge[amount];

                fillEdge(edges, amount);

                startPoint = selectedIndex == -100 ? 1 : selectedIndex - 1;

                file.Close(); 
            }
        }
        
        void fillEdge(Edge[, ] edges, int amountPoint)
        {
            for (int i = 0; i < amountPoint; i++)
            {
                for (int j = 0; j < amountPoint; j++)
                {
                    if(i == j)
                    {
                        edges[i, j] = new Edge
                        (0, i, j, false);
                    } else
                    {
                        edges[i, j] = new Edge
                        (caculateDistanceTwoPoint(points[i], points[j]), i, j, false);
                    }
                }
            }
        }
        
        float caculateDistanceTwoPoint(PointF point1, PointF point2)
        {
            float x1 = point1.X;
            float x2 = point2.X;
            float y1 = point1.Y;
            float y2 = point2.Y;

            return (float)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        }

        void displayMatrix(Edge[,] edges, int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                    Console.Write(edges[i, j].getStartPoint() + ""
                        + edges[i, j].getEndPoint() + " = " 
                        + edges[i, j].getLength() + "   ");
                Console.WriteLine();
            }

        }
        
        void displayResult(Edge[] results, int amount)
        {
            float sum = 0;
            Console.WriteLine("phuong an tim duoc la");
            for(int i = 0; i < amount; i++)
            {
                sum += results[i].getLength();
                Console.WriteLine(results[i].getStartPoint() + ""
                        + results[i].getEndPoint() + " = "
                        + results[i].getLength() + "   ");
            }
            Console.WriteLine("Tong khoang cach = "  + sum);
        }

        //Brand and Bound for TSP
        float findMinEdge(Edge[, ] edges, int amount)
        {
            float min = 999999999;
            for (int i = 0; i < amount; i++)
                for (int j = 0; j < amount; j++)
                    if (i != j && !edges[i, j].getIsVisited()
                        && edges[i, j].getLength() < min)
                        min = edges[i, j].getLength();
            return min;
        }

        float findLowerBound(Edge[, ] edges, float total, int amount, int rank)
        {
            return total + (amount - rank) * findMinEdge(edges, amount);
        }

        void updateTemporaryResult(Edge[, ] edges, Edge[] results, Edge[] tempResults, 
             float total, ref float minTempResult, int amount)
        {
            tempResults[amount - 1] = edges[tempResults[amount - 2].getEndPoint(),
                tempResults[0].getStartPoint()].Clone();
            total += tempResults[amount - 1].getLength();
            if(minTempResult > total)
            {
                minTempResult = total;
                for (int i = 0; i < amount; i++)
                    results[i] = tempResults[i].Clone();
            }
        }

        bool hasCycle(Edge[] tempResults, int amount, int nextPoint)
        {
            bool isCircle = false;
            int i = 0;
            while (i < amount && !isCircle)
            {
                if (nextPoint == tempResults[i].getStartPoint())
                    isCircle = true;
                else
                    i++;        
            }
            return isCircle;
        }

        void tsp(Edge[, ] edges, Edge[] results, Edge[] tempResults, ref float total,
            ref float lowerBound, ref float minTempResult, int amount, int rank, int startPoint)
        {
            
            for(int nextPoint = 0; nextPoint < amount; nextPoint++)
                if(startPoint != nextPoint && 
                    !edges[startPoint, nextPoint].getIsVisited() && 
                    !hasCycle(tempResults, rank, nextPoint))
                {

                    edges[startPoint, nextPoint].setIsVisited(true);
                    edges[nextPoint, startPoint].setIsVisited(true);
                    total += edges[startPoint, nextPoint].getLength();
                    lowerBound = findLowerBound(edges, total, amount, rank+1);
                    if(lowerBound < minTempResult)
                    {
                        tempResults[rank] = edges[startPoint, nextPoint].Clone();
                        if (rank == amount - 2)
                            updateTemporaryResult(edges, results, tempResults, total, 
                                ref minTempResult, amount);
                        else
                            tsp(edges, results, tempResults, ref total, ref lowerBound,
                                ref minTempResult, amount, rank+1, nextPoint);
                    }
                    total -= edges[startPoint, nextPoint].getLength();
                    edges[startPoint, nextPoint].setIsVisited(false);
                    edges[nextPoint, startPoint].setIsVisited(false);
                }
        }

        private void numericUpDownScale_ValueChanged(object sender, EventArgs e)
        {
            scale = 10 * (int)numericUpDownScale.Value;
            this.pnlResult.Controls.Clear();
            this.pnlResult.Refresh();
        }
    }
}
