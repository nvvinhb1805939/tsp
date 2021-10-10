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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnHelp = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlInput = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.cbxStart = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtInfo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlResult = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnlInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHelp.Location = new System.Drawing.Point(1305, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Rotation = 0;
            this.btnHelp.ShowActiveImage = true;
            this.btnHelp.ShowCursorChanges = true;
            this.btnHelp.ShowImageBorders = true;
            this.btnHelp.ShowSizeMarkers = false;
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.ToolTipText = "";
            this.btnHelp.WaitOnLoad = false;
            this.btnHelp.Zoom = 0;
            this.btnHelp.ZoomSpeed = 10;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.Transparent;
            this.pnlInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInput.BackgroundImage")));
            this.pnlInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInput.BorderRadius = 30;
            this.pnlInput.Controls.Add(this.cbxStart);
            this.pnlInput.Controls.Add(this.groupBox1);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.btnFind);
            this.pnlInput.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(88)))), ((int)(((byte)(208)))));
            this.pnlInput.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(192)))));
            this.pnlInput.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(192)))));
            this.pnlInput.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.pnlInput.Location = new System.Drawing.Point(17, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Quality = 10;
            this.pnlInput.Size = new System.Drawing.Size(512, 328);
            this.pnlInput.TabIndex = 1;
            // 
            // cbxStart
            // 
            this.cbxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStart.FormattingEnabled = true;
            this.cbxStart.ItemHeight = 21;
            this.cbxStart.Location = new System.Drawing.Point(22, 288);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(306, 29);
            this.cbxStart.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 244);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDel.CustomizableEdges = borderEdges1;
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
            this.btnDel.Location = new System.Drawing.Point(338, 120);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges2;
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
            this.btnAdd.Location = new System.Drawing.Point(338, 43);
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
            this.txtInfo.Location = new System.Drawing.Point(11, 120);
            this.txtInfo.MaxLength = 32767;
            this.txtInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtInfo.Modified = false;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtInfo.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtInfo.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtInfo.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtInfo.OnIdleState = stateProperties4;
            this.txtInfo.Padding = new System.Windows.Forms.Padding(3);
            this.txtInfo.PasswordChar = '\0';
            this.txtInfo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtInfo.PlaceholderText = "[tọa độ x] [tọa độ y] [tên đảo]";
            this.txtInfo.ReadOnly = false;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.SelectedText = "";
            this.txtInfo.SelectionLength = 0;
            this.txtInfo.SelectionStart = 0;
            this.txtInfo.ShortcutsEnabled = true;
            this.txtInfo.Size = new System.Drawing.Size(306, 113);
            this.txtInfo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtInfo.TabIndex = 10;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInfo.TextMarginBottom = 0;
            this.txtInfo.TextMarginLeft = 0;
            this.txtInfo.TextMarginTop = 10;
            this.txtInfo.TextPlaceholder = "[tọa độ x] [tọa độ y] [tên đảo]";
            this.txtInfo.UseSystemPasswordChar = false;
            this.txtInfo.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập thông tin các đảo";
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.AnimationSpeed = 200;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.White;
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.White;
            this.txtAmount.BorderColorHover = System.Drawing.Color.White;
            this.txtAmount.BorderColorIdle = System.Drawing.Color.White;
            this.txtAmount.BorderRadius = 5;
            this.txtAmount.BorderThickness = 1;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.White;
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(11, 43);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAmount.Modified = false;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.White;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.White;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnIdleState = stateProperties8;
            this.txtAmount.Padding = new System.Windows.Forms.Padding(3);
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmount.PlaceholderText = "Nhập số đảo";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(306, 42);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 8;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.TextMarginBottom = 0;
            this.txtAmount.TextMarginLeft = 3;
            this.txtAmount.TextMarginTop = 0;
            this.txtAmount.TextPlaceholder = "Nhập số đảo";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập số đảo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chọn đảo bắt đầu";
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnFind.CustomizableEdges = borderEdges3;
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
            this.btnFind.Location = new System.Drawing.Point(349, 262);
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
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.Transparent;
            this.pnlResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlResult.BackgroundImage")));
            this.pnlResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResult.BorderRadius = 0;
            this.pnlResult.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(233)))));
            this.pnlResult.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(233)))));
            this.pnlResult.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.pnlResult.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(199)))));
            this.pnlResult.Location = new System.Drawing.Point(547, 12);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Quality = 10;
            this.pnlResult.Size = new System.Drawing.Size(743, 704);
            this.pnlResult.TabIndex = 4;
            this.pnlResult.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResult_Paint);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1349, 728);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlInput);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "TSP Application";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlInput;
        private Bunifu.UI.WinForms.BunifuImageButton btnHelp;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlResult;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuTextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStart;
    }
}

