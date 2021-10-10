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

        string filePath = @"D:\Programs\CT239\TSP\TSP\point.txt";

        double x;
        double y;
        string line;
        float scale = 1;
        // List<Point> plot = new List<Point>();

        int amount = 0;
        string info = "";

        private void pnlResult_Paint(object sender, PaintEventArgs e)
        {
            StreamReader file = new StreamReader(filePath);
            float round = 30;
            scale = round;
            float xOrigin = (pnlResult.Width / 2) - (round / 2) ;
            float yOrigin = (pnlResult.Height / 2) - (round / 2);
            int row = 0;
            while ((line = file.ReadLine()) != null)
            {
                row++;
                if(row == 1)
                {
                    amount = Int32.Parse(File.ReadLines(filePath).First());
                } else
                {
                    string[] part = line.Split(' ');
                    x = (Convert.ToDouble(part[0]) * scale + xOrigin);
                    y = (Convert.ToDouble(part[1]) * scale + yOrigin);
                    //plot.Add(new Point((Int32)x, (Int32)y));
                    e.Graphics.FillEllipse(Brushes.Black, Convert.ToInt32(x),
                        Convert.ToInt32(y), round, round);
                }
                
            }
            file.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!isNumber(txtAmount.Text.Trim(), "integer"))
            {
                handleInput("Số đảo phải là số!!!", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, txtAmount);
                return;
            }
            amount = Int32.Parse(txtAmount.Text.Trim());
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
                    string[] part = point.Split(' ');
                    if (!isNumber(part[0], "number") || !isNumber(part[1], "number"))
                    {
                        handleInput("Tọa độ đảo phải là số!!!", "Dữ liệu không hợp lệ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, txtInfo);
                        return;
                    }
                }
                if(points.Length != amount)
                {
                    handleInput("Dữ liệu không khớp với số đảo!!!", "Dữ liệu không hợp lệ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, txtInfo);
                    return;
                }
            }
            info = txtInfo.Text.Trim();
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.WriteLine(amount);
                file.WriteLine(info);
                file.Close();
            }
            showMessage("Thêm thông tin thành công!!!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDel.Enabled = true;
            this.Refresh();
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtInfo.Text = "";
            btnDel.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        bool isNumber(string str, string type)
        {
            Regex regex = new Regex("");
            bool check = false;
            switch (type)
            {
                case "integer":
                    regex = new Regex("^[0-9]+$");
                    break;
                case "number":
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
    }
}
