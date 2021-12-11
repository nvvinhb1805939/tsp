namespace TSP
{
    partial class frmHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(695, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ứng dụng tìm đường đi ngắn nhất từ một đảo đến các đảo còn lại (mỗi đảo chỉ đến m" +
    "ột lần) và quay trở về đảo ban đầu.\r\n";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(695, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "1. Trước hết, người dùng cần nhập thông tin các đảo vào ô textbox theo đúng quy đ" +
    "ịnh sau:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(675, 46);
			this.label3.TabIndex = 2;
			this.label3.Text = "- Mỗi dòng chứa thông tin của một đảo bao gồm: tọa độ x, tọa độ y, tên đảo. Những" +
    " thông tin này phải được nhập theo đúng thứ tự và cách nhau bằng dấu phẩy (\",\")." +
    "\r\n";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(675, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "- Tọa độ x, y phải là số.";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(675, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "- Mỗi đảo chỉ gồm đúng 3 thông tin trên, không được thiếu hoặc thừa thông tin.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(226, 464);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(185, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "Hình 1.1 Thông tin hợp lệ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(128, 765);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(434, 21);
			this.label7.TabIndex = 8;
			this.label7.Text = "Hình 1.2 Thông tin không hợp lệ do tọa độ x không phải là số";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(128, 1066);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(416, 21);
			this.label8.TabIndex = 10;
			this.label8.Text = "Hình 1.3 Thông tin không hợp lệ do dư một phần thông tin";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::TSP.Properties.Resources.invalid_input1;
			this.pictureBox3.Location = new System.Drawing.Point(70, 801);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(548, 250);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::TSP.Properties.Resources.invalid_input;
			this.pictureBox2.Location = new System.Drawing.Point(70, 499);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(548, 250);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TSP.Properties.Resources.valid_input;
			this.pictureBox1.Location = new System.Drawing.Point(70, 198);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(548, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// frmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(724, 619);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHelp";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hướng dẫn sử dụng";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}