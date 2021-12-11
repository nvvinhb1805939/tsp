using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

		private const string V = @"C:\your.xlsx";
		List<PointF> points = new List<PointF>();

		List<PointF> lines = new List<PointF>();

		List<string> names = new List<string>();
        Edge[,] edges;
        Edge[] results;
        Edge[] tempResults;
        int startPoint;
        int amount;
        bool isPaint = false;
		bool isSuccess = false;
        string filePath = @"D:\Programs\CT239\TSP\TSP\point.txt";
        string info = "";
        int selectedIndex;
        int row = 0;
        int scale = 10;
		int lineWidth = 1;

        private void btnAdd_Click(object sender, EventArgs e)
        {
			info = txtInfo.Text.Trim();

			if (info.Length == 0)
			{
				handleInput("Vui lòng nhập thông tin!", 
					"Thông tin không được bỏ trống",
					MessageBoxButtons.OK, MessageBoxIcon.Warning, txtInfo);
				return;
			}
			for (int index = 0; index < txtInfo.Lines.Length; index++) {
				string[] line = txtInfo.Lines[index].Trim().Split(new char[] { ',' },
					StringSplitOptions.RemoveEmptyEntries);
				if (line.Length == 0 || line == null) {
					continue;
				} else if (line.Length > 3 || !isNumber(line[0]) || !isNumber(line[1])) {
					handleInput("Vui lòng xem lại hướng dẫn và nhập lại!", 
						"Thông tin không hợp lệ",
						MessageBoxButtons.OK, MessageBoxIcon.Warning, txtInfo);
					return;
				}
			}
			using (StreamWriter file = new StreamWriter(filePath))
			{
				file.WriteLine(info);
			}
			showMessage("Thêm thông tin thành công!!!", "Thông  báo",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			clearData();
			cbxStart.Items.Add("--Chọn đảo bắt đầu--");
			cbxStart.SelectedIndex = 0;
			btnDel.Enabled = true;
			isPaint = true;
			pnlResult.Controls.Clear();
			pnlResult.Refresh();
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            clearData();
			btnDel.Enabled = false;
			txtInfo.Text = "";
            isPaint = false;
            cbxStart.Text = "";
            cbxStart.Items.Add("--Chọn đảo bắt đầu--");
            cbxStart.SelectedIndex = 0;
            this.pnlResult.Controls.Clear();
            this.pnlResult.Refresh();
        }

        void clearData()
        {
			btnSave.Enabled = false;
			isSuccess = false;
            row = 0;
			selectedIndex = -100;
            cbxStart.Items.Clear();
            points.Clear();
			lines.Clear();
            names.Clear();
            lblResult.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
		{
			if (amount > 2)
			{
				float total = 0, lowerBound = 0, minTempResult = 999999999;

				edges = new Edge[amount, amount];
				results = new Edge[amount];
				tempResults = new Edge[amount];

				fillEdge(edges, amount);

				tsp(edges, results, tempResults, ref total,
					ref lowerBound, ref minTempResult, amount, 0, startPoint);
				showMessage("Tìm kiếm thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				displayResult(results, amount);

				isSuccess = true;
				this.pnlResult.Refresh();
				btnSave.Enabled = true;
			}
			else {
				showMessage("Tìm kiếm thất bại!\nSố đảo phải lớn hơn 2!", 
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        bool isNumber(string str)
        {
            bool check = false;
            Regex regex = new Regex(@"^-?[0-9]+[0-9]*(\.[0-9]+)?$");
            
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
				isSuccess = false;
            } else
            {
                btnFind.Enabled = false;
                //selectedIndex = -100;
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
			try
			{

				if (isPaint)
				{
					points.Clear();
					lines.Clear();
					row = 0;

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
						if (part == null || part.Length == 0)
						{
							continue;
						}
						else
						{
							xCoordinate = (float.Parse(part[0], CultureInfo.InvariantCulture.NumberFormat)
							* scale + xOrigin);
							yCoordinate = (float.Parse(part[1], CultureInfo.InvariantCulture.NumberFormat)
								* scale * -1 + yOrigin);
							lines.Add(new PointF(xCoordinate, yCoordinate));

							points.Add(new PointF(float.Parse(part[0], CultureInfo.InvariantCulture.NumberFormat),
								float.Parse(part[1], CultureInfo.InvariantCulture.NumberFormat)));
							e.Graphics.FillEllipse(color, xCoordinate, yCoordinate, round, round);

							if (hasExistItem(cbxStart, (part[2].Trim())))
							{
								cbxStart.Items.Add(part[2].Trim());
							}
							names.Add(part[2].Trim());

							Label name = new Label();
							name.Text = part[2];
							name.Location = new Point((int)(xCoordinate + scale / 2), (int)(yCoordinate - scale / 2));
							name.ForeColor = Color.White;
							name.BackColor = Color.Transparent;
							name.AutoSize = true;
							name.Padding = new Padding(0);
							pnlResult.Controls.Add(name);
						}
					}

					startPoint = selectedIndex - 1;
					amount = points.Count;

					file.Close();

					//draw line
					if (isSuccess)
					{
						for (int i = 0; i < amount; i++)
						{
							Pen pen = new Pen(Color.DeepPink, lineWidth);
							e.Graphics.DrawLine(pen, lines[results[i].getStartPoint()],
								lines[results[i].getEndPoint()]);
						}

					}
				}
			}
			catch (Exception ex) {
				string content = "Vui lòng kiểm tra lại thông tin các đảo và thử lại!";
				showMessage(content, "Có lỗi xảy ra", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
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
            lblResult.Text = "";
            for (int i = 0; i < amount; i++)
            {
                sum += results[i].getLength();
                lblResult.Text += names[results[i].getStartPoint()] + " - "
                    + names[results[i].getEndPoint()] + " = "
                    + results[i].getLength().ToString() + "\n";
            }
            lblResult.Text += "\nTổng khoảng cách = " + sum + " hải lý";
        }
		
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
			for (int nextPoint = 0; nextPoint < amount; nextPoint++)
			{
				if (startPoint != nextPoint &&
					!edges[startPoint, nextPoint].getIsVisited() &&
					!hasCycle(tempResults, rank, nextPoint))
				{

					edges[startPoint, nextPoint].setIsVisited(true);
					edges[nextPoint, startPoint].setIsVisited(true);
					total += edges[startPoint, nextPoint].getLength();
					lowerBound = findLowerBound(edges, total, amount, rank + 1);
					if (lowerBound < minTempResult)
					{
						tempResults[rank] = edges[startPoint, nextPoint].Clone();
						if (rank == amount - 2)
							updateTemporaryResult(edges, results, tempResults, total,
								ref minTempResult, amount);
						else
							tsp(edges, results, tempResults, ref total, ref lowerBound,
								ref minTempResult, amount, rank + 1, nextPoint);
					}
					total -= edges[startPoint, nextPoint].getLength();
					edges[startPoint, nextPoint].setIsVisited(false);
					edges[nextPoint, startPoint].setIsVisited(false);
				}
			}
		}

		bool hasExistItem(ComboBox cbx, string item) {
			return cbx.FindString(item) == -1;
		}
		// copy point
		List<PointF> copyPoints(List<PointF> currentPoints) {
			List<PointF> tempPoints = new List<PointF>();
			for (int index = 0; index < currentPoints.Count; index++) {
				tempPoints[index] = currentPoints[index];
			}
			return tempPoints;
		}

		private void numericUpDownScale_ValueChanged(object sender, EventArgs e)
        {
			lineWidth = (int)numericUpDownScale.Value;
			scale = 10 * (int)numericUpDownScale.Value;
            this.pnlResult.Controls.Clear();
            this.pnlResult.Refresh();
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Text File | *.txt";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.FileName = "result.txt";
			saveFileDialog.Title = "Lưu kết quả tìm kiếm";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter file = new StreamWriter(saveFileDialog.OpenFile()))
				{
					file.WriteLine(lblResult.Text);
					file.Close();
				}

				string content = "Lưu kết quả tìm kiếm thành công!" +
					"\nBạn có muốn mở file " + saveFileDialog.FileName + " không?";


				DialogResult dialogResult = MessageBox.Show(content, "Thông báo",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (dialogResult == DialogResult.Yes)
				{
					Process.Start(saveFileDialog.FileName);
				}
			}
		}
	}
}
