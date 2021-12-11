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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(668, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ứng dụng tìm đường đi ngắn nhất từ một đảo đến các đảo còn lại (mỗi đảo chỉ đến m" +
    "ột lần) và quay trở về đảo ban đầu.\r\n";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(668, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Trước hết, người dùng cần nhập thông tin các đảo vào ô textbox theo đúng quy định" +
    " sau:\r\n";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(648, 46);
			this.label3.TabIndex = 2;
			this.label3.Text = "- Mỗi dòng chứa thông tin của một đảo bao gồm: tọa độ x, tọa độ y, tên đảo. Những" +
    " thông tin này phải được nhập theo đúng thứ tự và cách nhau bằng dấu phẩy (\",\")." +
    "\r\n";
			// 
			// frmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(693, 532);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hướng dẫn sử dụng";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}