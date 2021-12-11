namespace TSP
{
    partial class frmHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.cbxStart = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
			this.lblResult = new System.Windows.Forms.Label();
			this.pnlResult = new Bunifu.UI.WinForms.BunifuPanel();
			this.btnDel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.txtInfo = new Bunifu.UI.WinForms.BunifuTextBox();
			this.btnFind = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			this.btnHelp = new Bunifu.UI.WinForms.BunifuImageButton();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
			this.bunifuPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbxStart
			// 
			this.cbxStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxStart.FormattingEnabled = true;
			this.cbxStart.ItemHeight = 21;
			this.cbxStart.Items.AddRange(new object[] {
            "--Chọn đảo bắt đầu--"});
			this.cbxStart.Location = new System.Drawing.Point(40, 282);
			this.cbxStart.Name = "cbxStart";
			this.cbxStart.Size = new System.Drawing.Size(306, 29);
			this.cbxStart.TabIndex = 10;
			this.cbxStart.SelectedIndexChanged += new System.EventHandler(this.cbxStart_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(36, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nhập thông tin các đảo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(36, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Chọn đảo bắt đầu";
			// 
			// numericUpDownScale
			// 
			this.numericUpDownScale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownScale.Location = new System.Drawing.Point(191, 333);
			this.numericUpDownScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownScale.Name = "numericUpDownScale";
			this.numericUpDownScale.Size = new System.Drawing.Size(155, 29);
			this.numericUpDownScale.TabIndex = 16;
			this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownScale.ValueChanged += new System.EventHandler(this.numericUpDownScale_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(36, 337);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 19);
			this.label1.TabIndex = 17;
			this.label1.Text = "Phóng to/Thu nhỏ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(36, 385);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 19);
			this.label4.TabIndex = 18;
			this.label4.Text = "Hiển thị kết quả";
			// 
			// btnSave
			// 
			this.btnSave.AllowAnimations = true;
			this.btnSave.AllowMouseEffects = true;
			this.btnSave.AllowToggling = false;
			this.btnSave.AnimationSpeed = 200;
			this.btnSave.AutoGenerateColors = false;
			this.btnSave.AutoRoundBorders = false;
			this.btnSave.AutoSizeLeftIcon = true;
			this.btnSave.AutoSizeRightIcon = true;
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
			this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnSave.ButtonText = "Lưu";
			this.btnSave.ButtonTextMarginLeft = 0;
			this.btnSave.ColorContrastOnClick = 45;
			this.btnSave.ColorContrastOnHover = 45;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges21.BottomLeft = true;
			borderEdges21.BottomRight = true;
			borderEdges21.TopLeft = true;
			borderEdges21.TopRight = true;
			this.btnSave.CustomizableEdges = borderEdges21;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnSave.Enabled = false;
			this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnSave.IconMarginLeft = 11;
			this.btnSave.IconPadding = 10;
			this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnSave.IconSize = 25;
			this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.IdleBorderRadius = 10;
			this.btnSave.IdleBorderThickness = 1;
			this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.IdleIconLeftImage = null;
			this.btnSave.IdleIconRightImage = null;
			this.btnSave.IndicateFocus = false;
			this.btnSave.Location = new System.Drawing.Point(367, 652);
			this.btnSave.Name = "btnSave";
			this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnSave.OnDisabledState.BorderRadius = 10;
			this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnSave.OnDisabledState.BorderThickness = 1;
			this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnSave.OnDisabledState.IconLeftImage = null;
			this.btnSave.OnDisabledState.IconRightImage = null;
			this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
			this.btnSave.onHoverState.BorderRadius = 10;
			this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnSave.onHoverState.BorderThickness = 1;
			this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
			this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnSave.onHoverState.IconLeftImage = null;
			this.btnSave.onHoverState.IconRightImage = null;
			this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.OnIdleState.BorderRadius = 10;
			this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnSave.OnIdleState.BorderThickness = 1;
			this.btnSave.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnSave.OnIdleState.IconLeftImage = null;
			this.btnSave.OnIdleState.IconRightImage = null;
			this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.OnPressedState.BorderRadius = 10;
			this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnSave.OnPressedState.BorderThickness = 1;
			this.btnSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnSave.OnPressedState.IconLeftImage = null;
			this.btnSave.OnPressedState.IconRightImage = null;
			this.btnSave.Size = new System.Drawing.Size(140, 55);
			this.btnSave.TabIndex = 19;
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnSave.TextMarginLeft = 0;
			this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnSave.UseDefaultRadiusAndThickness = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// bunifuPanel1
			// 
			this.bunifuPanel1.AutoScroll = true;
			this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
			this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
			this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuPanel1.BorderColor = System.Drawing.Color.Gray;
			this.bunifuPanel1.BorderRadius = 0;
			this.bunifuPanel1.BorderThickness = 1;
			this.bunifuPanel1.Controls.Add(this.lblResult);
			this.bunifuPanel1.Location = new System.Drawing.Point(40, 418);
			this.bunifuPanel1.Name = "bunifuPanel1";
			this.bunifuPanel1.ShowBorders = true;
			this.bunifuPanel1.Size = new System.Drawing.Size(306, 289);
			this.bunifuPanel1.TabIndex = 16;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.ForeColor = System.Drawing.Color.White;
			this.lblResult.Location = new System.Drawing.Point(12, 12);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 21);
			this.lblResult.TabIndex = 0;
			// 
			// pnlResult
			// 
			this.pnlResult.BackgroundColor = System.Drawing.Color.Transparent;
			this.pnlResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlResult.BackgroundImage")));
			this.pnlResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlResult.BorderColor = System.Drawing.Color.Gray;
			this.pnlResult.BorderRadius = 0;
			this.pnlResult.BorderThickness = 1;
			this.pnlResult.Location = new System.Drawing.Point(584, 18);
			this.pnlResult.Name = "pnlResult";
			this.pnlResult.ShowBorders = true;
			this.pnlResult.Size = new System.Drawing.Size(683, 689);
			this.pnlResult.TabIndex = 15;
			this.pnlResult.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResult_Paint);
			// 
			// btnDel
			// 
			this.btnDel.AllowAnimations = true;
			this.btnDel.AllowMouseEffects = true;
			this.btnDel.AllowToggling = false;
			this.btnDel.AnimationSpeed = 200;
			this.btnDel.AutoGenerateColors = false;
			this.btnDel.AutoRoundBorders = false;
			this.btnDel.AutoSizeLeftIcon = true;
			this.btnDel.AutoSizeRightIcon = true;
			this.btnDel.BackColor = System.Drawing.Color.Transparent;
			this.btnDel.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
			this.btnDel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnDel.ButtonText = "Xóa";
			this.btnDel.ButtonTextMarginLeft = 0;
			this.btnDel.ColorContrastOnClick = 45;
			this.btnDel.ColorContrastOnHover = 45;
			this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges22.BottomLeft = true;
			borderEdges22.BottomRight = true;
			borderEdges22.TopLeft = true;
			borderEdges22.TopRight = true;
			this.btnDel.CustomizableEdges = borderEdges22;
			this.btnDel.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnDel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnDel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnDel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnDel.Enabled = false;
			this.btnDel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.ForeColor = System.Drawing.Color.White;
			this.btnDel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.btnDel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnDel.IconMarginLeft = 11;
			this.btnDel.IconPadding = 10;
			this.btnDel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDel.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.btnDel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnDel.IconSize = 25;
			this.btnDel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.IdleBorderRadius = 10;
			this.btnDel.IdleBorderThickness = 1;
			this.btnDel.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.IdleIconLeftImage = null;
			this.btnDel.IdleIconRightImage = null;
			this.btnDel.IndicateFocus = false;
			this.btnDel.Location = new System.Drawing.Point(367, 183);
			this.btnDel.Name = "btnDel";
			this.btnDel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnDel.OnDisabledState.BorderRadius = 10;
			this.btnDel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnDel.OnDisabledState.BorderThickness = 1;
			this.btnDel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnDel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnDel.OnDisabledState.IconLeftImage = null;
			this.btnDel.OnDisabledState.IconRightImage = null;
			this.btnDel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnDel.onHoverState.BorderRadius = 10;
			this.btnDel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnDel.onHoverState.BorderThickness = 1;
			this.btnDel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnDel.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnDel.onHoverState.IconLeftImage = null;
			this.btnDel.onHoverState.IconRightImage = null;
			this.btnDel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.OnIdleState.BorderRadius = 10;
			this.btnDel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnDel.OnIdleState.BorderThickness = 1;
			this.btnDel.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnDel.OnIdleState.IconLeftImage = null;
			this.btnDel.OnIdleState.IconRightImage = null;
			this.btnDel.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.OnPressedState.BorderRadius = 10;
			this.btnDel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnDel.OnPressedState.BorderThickness = 1;
			this.btnDel.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnDel.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnDel.OnPressedState.IconLeftImage = null;
			this.btnDel.OnPressedState.IconRightImage = null;
			this.btnDel.Size = new System.Drawing.Size(140, 55);
			this.btnDel.TabIndex = 13;
			this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnDel.TextMarginLeft = 0;
			this.btnDel.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnDel.UseDefaultRadiusAndThickness = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.AllowAnimations = true;
			this.btnAdd.AllowMouseEffects = true;
			this.btnAdd.AllowToggling = false;
			this.btnAdd.AnimationSpeed = 200;
			this.btnAdd.AutoGenerateColors = false;
			this.btnAdd.AutoRoundBorders = false;
			this.btnAdd.AutoSizeLeftIcon = true;
			this.btnAdd.AutoSizeRightIcon = true;
			this.btnAdd.BackColor = System.Drawing.Color.Transparent;
			this.btnAdd.BackColor1 = System.Drawing.Color.DodgerBlue;
			this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
			this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAdd.ButtonText = "Thêm";
			this.btnAdd.ButtonTextMarginLeft = 0;
			this.btnAdd.ColorContrastOnClick = 45;
			this.btnAdd.ColorContrastOnHover = 45;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges23.BottomLeft = true;
			borderEdges23.BottomRight = true;
			borderEdges23.TopLeft = true;
			borderEdges23.TopRight = true;
			this.btnAdd.CustomizableEdges = borderEdges23;
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnAdd.IconMarginLeft = 11;
			this.btnAdd.IconPadding = 10;
			this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnAdd.IconSize = 25;
			this.btnAdd.IdleBorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.IdleBorderRadius = 10;
			this.btnAdd.IdleBorderThickness = 1;
			this.btnAdd.IdleFillColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.IdleIconLeftImage = null;
			this.btnAdd.IdleIconRightImage = null;
			this.btnAdd.IndicateFocus = false;
			this.btnAdd.Location = new System.Drawing.Point(367, 110);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnAdd.OnDisabledState.BorderRadius = 10;
			this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAdd.OnDisabledState.BorderThickness = 1;
			this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnAdd.OnDisabledState.IconLeftImage = null;
			this.btnAdd.OnDisabledState.IconRightImage = null;
			this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnAdd.onHoverState.BorderRadius = 10;
			this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAdd.onHoverState.BorderThickness = 1;
			this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnAdd.onHoverState.IconLeftImage = null;
			this.btnAdd.onHoverState.IconRightImage = null;
			this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.OnIdleState.BorderRadius = 10;
			this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAdd.OnIdleState.BorderThickness = 1;
			this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnAdd.OnIdleState.IconLeftImage = null;
			this.btnAdd.OnIdleState.IconRightImage = null;
			this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.OnPressedState.BorderRadius = 10;
			this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnAdd.OnPressedState.BorderThickness = 1;
			this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnAdd.OnPressedState.IconLeftImage = null;
			this.btnAdd.OnPressedState.IconRightImage = null;
			this.btnAdd.Size = new System.Drawing.Size(140, 55);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnAdd.TextMarginLeft = 0;
			this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnAdd.UseDefaultRadiusAndThickness = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtInfo
			// 
			this.txtInfo.AcceptsReturn = false;
			this.txtInfo.AcceptsTab = false;
			this.txtInfo.AnimationSpeed = 200;
			this.txtInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtInfo.BackColor = System.Drawing.Color.Transparent;
			this.txtInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtInfo.BackgroundImage")));
			this.txtInfo.BorderColorActive = System.Drawing.Color.White;
			this.txtInfo.BorderColorDisabled = System.Drawing.Color.White;
			this.txtInfo.BorderColorHover = System.Drawing.Color.White;
			this.txtInfo.BorderColorIdle = System.Drawing.Color.White;
			this.txtInfo.BorderRadius = 5;
			this.txtInfo.BorderThickness = 1;
			this.txtInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtInfo.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
			this.txtInfo.DefaultText = "";
			this.txtInfo.FillColor = System.Drawing.Color.White;
			this.txtInfo.HideSelection = true;
			this.txtInfo.IconLeft = null;
			this.txtInfo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txtInfo.IconPadding = 10;
			this.txtInfo.IconRight = null;
			this.txtInfo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txtInfo.Lines = new string[0];
			this.txtInfo.Location = new System.Drawing.Point(40, 44);
			this.txtInfo.MaxLength = 32767;
			this.txtInfo.MinimumSize = new System.Drawing.Size(1, 1);
			this.txtInfo.Modified = false;
			this.txtInfo.Multiline = true;
			this.txtInfo.Name = "txtInfo";
			stateProperties21.BorderColor = System.Drawing.Color.White;
			stateProperties21.FillColor = System.Drawing.Color.Empty;
			stateProperties21.ForeColor = System.Drawing.Color.Empty;
			stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtInfo.OnActiveState = stateProperties21;
			stateProperties22.BorderColor = System.Drawing.Color.White;
			stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtInfo.OnDisabledState = stateProperties22;
			stateProperties23.BorderColor = System.Drawing.Color.White;
			stateProperties23.FillColor = System.Drawing.Color.Empty;
			stateProperties23.ForeColor = System.Drawing.Color.Empty;
			stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtInfo.OnHoverState = stateProperties23;
			stateProperties24.BorderColor = System.Drawing.Color.White;
			stateProperties24.FillColor = System.Drawing.Color.White;
			stateProperties24.ForeColor = System.Drawing.Color.Empty;
			stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtInfo.OnIdleState = stateProperties24;
			this.txtInfo.Padding = new System.Windows.Forms.Padding(3);
			this.txtInfo.PasswordChar = '\0';
			this.txtInfo.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txtInfo.PlaceholderText = "";
			this.txtInfo.ReadOnly = false;
			this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtInfo.SelectedText = "";
			this.txtInfo.SelectionLength = 0;
			this.txtInfo.SelectionStart = 0;
			this.txtInfo.ShortcutsEnabled = true;
			this.txtInfo.Size = new System.Drawing.Size(306, 194);
			this.txtInfo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txtInfo.TabIndex = 10;
			this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtInfo.TextMarginBottom = 0;
			this.txtInfo.TextMarginLeft = 0;
			this.txtInfo.TextMarginTop = 10;
			this.txtInfo.TextPlaceholder = "";
			this.txtInfo.UseSystemPasswordChar = false;
			this.txtInfo.WordWrap = false;
			// 
			// btnFind
			// 
			this.btnFind.AllowAnimations = true;
			this.btnFind.AllowMouseEffects = true;
			this.btnFind.AllowToggling = false;
			this.btnFind.AnimationSpeed = 200;
			this.btnFind.AutoGenerateColors = false;
			this.btnFind.AutoRoundBorders = false;
			this.btnFind.AutoSizeLeftIcon = true;
			this.btnFind.AutoSizeRightIcon = true;
			this.btnFind.BackColor = System.Drawing.Color.Transparent;
			this.btnFind.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
			this.btnFind.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnFind.ButtonText = "Tìm";
			this.btnFind.ButtonTextMarginLeft = 0;
			this.btnFind.ColorContrastOnClick = 45;
			this.btnFind.ColorContrastOnHover = 45;
			this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
			borderEdges24.BottomLeft = true;
			borderEdges24.BottomRight = true;
			borderEdges24.TopLeft = true;
			borderEdges24.TopRight = true;
			this.btnFind.CustomizableEdges = borderEdges24;
			this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnFind.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnFind.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnFind.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnFind.Enabled = false;
			this.btnFind.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFind.ForeColor = System.Drawing.Color.White;
			this.btnFind.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFind.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
			this.btnFind.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.btnFind.IconMarginLeft = 11;
			this.btnFind.IconPadding = 10;
			this.btnFind.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFind.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.btnFind.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.btnFind.IconSize = 25;
			this.btnFind.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.IdleBorderRadius = 10;
			this.btnFind.IdleBorderThickness = 1;
			this.btnFind.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.IdleIconLeftImage = null;
			this.btnFind.IdleIconRightImage = null;
			this.btnFind.IndicateFocus = false;
			this.btnFind.Location = new System.Drawing.Point(367, 257);
			this.btnFind.Name = "btnFind";
			this.btnFind.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.btnFind.OnDisabledState.BorderRadius = 10;
			this.btnFind.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnFind.OnDisabledState.BorderThickness = 1;
			this.btnFind.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.btnFind.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.btnFind.OnDisabledState.IconLeftImage = null;
			this.btnFind.OnDisabledState.IconRightImage = null;
			this.btnFind.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
			this.btnFind.onHoverState.BorderRadius = 10;
			this.btnFind.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnFind.onHoverState.BorderThickness = 1;
			this.btnFind.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
			this.btnFind.onHoverState.ForeColor = System.Drawing.Color.White;
			this.btnFind.onHoverState.IconLeftImage = null;
			this.btnFind.onHoverState.IconRightImage = null;
			this.btnFind.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.OnIdleState.BorderRadius = 10;
			this.btnFind.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnFind.OnIdleState.BorderThickness = 1;
			this.btnFind.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.btnFind.OnIdleState.IconLeftImage = null;
			this.btnFind.OnIdleState.IconRightImage = null;
			this.btnFind.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.OnPressedState.BorderRadius = 10;
			this.btnFind.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.btnFind.OnPressedState.BorderThickness = 1;
			this.btnFind.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
			this.btnFind.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.btnFind.OnPressedState.IconLeftImage = null;
			this.btnFind.OnPressedState.IconRightImage = null;
			this.btnFind.Size = new System.Drawing.Size(140, 55);
			this.btnFind.TabIndex = 7;
			this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnFind.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnFind.TextMarginLeft = 0;
			this.btnFind.TextPadding = new System.Windows.Forms.Padding(0);
			this.btnFind.UseDefaultRadiusAndThickness = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.ActiveImage = null;
			this.btnHelp.AllowAnimations = true;
			this.btnHelp.AllowBuffering = false;
			this.btnHelp.AllowToggling = false;
			this.btnHelp.AllowZooming = true;
			this.btnHelp.AllowZoomingOnFocus = false;
			this.btnHelp.BackColor = System.Drawing.Color.Transparent;
			this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ErrorImage")));
			this.btnHelp.FadeWhenInactive = false;
			this.btnHelp.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
			this.btnHelp.Image = global::TSP.Properties.Resources.icon_help;
			this.btnHelp.ImageActive = null;
			this.btnHelp.ImageLocation = null;
			this.btnHelp.ImageMargin = 0;
			this.btnHelp.ImageSize = new System.Drawing.Size(29, 29);
			this.btnHelp.ImageZoomSize = new System.Drawing.Size(30, 30);
			this.btnHelp.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.InitialImage")));
			this.btnHelp.Location = new System.Drawing.Point(1292, 18);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Rotation = 0;
			this.btnHelp.ShowActiveImage = true;
			this.btnHelp.ShowCursorChanges = true;
			this.btnHelp.ShowImageBorders = true;
			this.btnHelp.ShowSizeMarkers = false;
			this.btnHelp.Size = new System.Drawing.Size(30, 30);
			this.btnHelp.TabIndex = 3;
			this.btnHelp.ToolTipText = "Hướng dẫn sử dụng";
			this.btnHelp.WaitOnLoad = false;
			this.btnHelp.Zoom = 0;
			this.btnHelp.ZoomSpeed = 10;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(130)))));
			this.ClientSize = new System.Drawing.Size(1349, 728);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.bunifuPanel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownScale);
			this.Controls.Add(this.pnlResult);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.cbxStart);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnHelp);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmHome";
			this.Text = "TSP Application";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
			this.bunifuPanel1.ResumeLayout(false);
			this.bunifuPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btnHelp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFind;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuTextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStart;
        private Bunifu.UI.WinForms.BunifuPanel pnlResult;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
		private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
		private System.Windows.Forms.Label lblResult;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
	}
}

