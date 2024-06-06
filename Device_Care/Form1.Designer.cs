namespace Device_Care
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hTabControl1 = new HeCopUI_Framework.Controls.HTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hProgressBar1 = new HeCopUI_Framework.Controls.Progress.HProgressBar();
            this.hButton1 = new HeCopUI_Framework.Controls.HButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hCheckBox3 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox2 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox1 = new HeCopUI_Framework.Controls.HCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.hProgressBar2 = new HeCopUI_Framework.Controls.Progress.HProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.hButton2 = new HeCopUI_Framework.Controls.HButton();
            this.LB_NumberOfDisk = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hCheckBox7 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox8 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox9 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox10 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox11 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox12 = new HeCopUI_Framework.Controls.HCheckBox();
            this.list_drives = new System.Windows.Forms.FlowLayoutPanel();
            this.hCheckBox4 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox5 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hCheckBox6 = new HeCopUI_Framework.Controls.HCheckBox();
            this.hRichTextBox1 = new HeCopUI_Framework.Controls.HRichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LB_CntStartupApps = new System.Windows.Forms.Label();
            this.btn_reloadlistappstartup = new HeCopUI_Framework.Controls.HButton();
            this.btn_disappstartup = new HeCopUI_Framework.Controls.HButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CH_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.hTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.list_drives.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hTabControl1
            // 
            this.hTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hTabControl1.ApplyTabPagesColor = true;
            this.hTabControl1.BackgroundColor = System.Drawing.Color.Transparent;
            this.hTabControl1.BorderTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hTabControl1.BorderThickness = 1;
            this.hTabControl1.Controls.Add(this.tabPage1);
            this.hTabControl1.Controls.Add(this.tabPage2);
            this.hTabControl1.Controls.Add(this.tabPage3);
            this.hTabControl1.Controls.Add(this.tabPage4);
            this.hTabControl1.CursorTabPages = System.Windows.Forms.Cursors.Default;
            this.hTabControl1.ItemSize = new System.Drawing.Size(73, 30);
            this.hTabControl1.Location = new System.Drawing.Point(15, 15);
            this.hTabControl1.Name = "hTabControl1";
            this.hTabControl1.SelectedIndex = 0;
            this.hTabControl1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hTabControl1.SelectedTextColor = System.Drawing.Color.WhiteSmoke;
            this.hTabControl1.Size = new System.Drawing.Size(580, 356);
            this.hTabControl1.TabIndex = 0;
            this.hTabControl1.TabsColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.hTabControl1.TabStyle = HeCopUI_Framework.Enums.TabStyle.Style2;
            this.hTabControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.hTabControl1.TextPadding = new System.Windows.Forms.Padding(0);
            this.hTabControl1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hTabControl1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hTabControl1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hTabControl1.UnSelectedBorderTabColor = System.Drawing.Color.Silver;
            this.hTabControl1.UnSelectedTabColor = System.Drawing.Color.Transparent;
            this.hTabControl1.UnselectedTextColor = System.Drawing.Color.LightGray;
            this.hTabControl1.UseAnimation = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.hProgressBar1);
            this.tabPage1.Controls.Add(this.hButton1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hCheckBox3);
            this.tabPage1.Controls.Add(this.hCheckBox2);
            this.tabPage1.Controls.Add(this.hCheckBox1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.tabPage1.Size = new System.Drawing.Size(572, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quick Clean";
            // 
            // hProgressBar1
            // 
            this.hProgressBar1.AnimationMode = HeCopUI_Framework.Enums.ProgressAnimationMode.Indeterminate;
            this.hProgressBar1.BaseProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hProgressBar1.BaseProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hProgressBar1.BorderColor = System.Drawing.Color.Silver;
            this.hProgressBar1.BorderWidth = 0;
            this.hProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hProgressBar1.ForeColor = System.Drawing.Color.White;
            this.hProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.hProgressBar1.Location = new System.Drawing.Point(8, 304);
            this.hProgressBar1.MaximumValue = 100;
            this.hProgressBar1.MinimumValue = 0;
            this.hProgressBar1.Name = "hProgressBar1";
            this.hProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.hProgressBar1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.hProgressBar1.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.hProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hProgressBar1.ProgressValue = 12;
            this.hProgressBar1.Radius = new HeCopUI_Framework.Struct.CornerRadius(2F, 2F, 2F, 2F);
            this.hProgressBar1.Size = new System.Drawing.Size(556, 6);
            this.hProgressBar1.TabIndex = 7;
            this.hProgressBar1.Text = "hProgressBar1";
            // 
            // hButton1
            // 
            this.hButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hButton1.AnimationMode = HeCopUI_Framework.Enums.AnimationMode.None;
            this.hButton1.BackHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.hButton1.BackHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.hButton1.BackPressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hButton1.BackPressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.hButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.hButton1.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hButton1.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hButton1.BorderThickness = 0;
            this.hButton1.ButtonColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hButton1.ButtonColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.hButton1.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hButton1.ClipRegion = false;
            this.hButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hButton1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hButton1.FocusBorderColor = System.Drawing.Color.White;
            this.hButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hButton1.Image = null;
            this.hButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hButton1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.hButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.hButton1.IsAutoSize = false;
            this.hButton1.Location = new System.Drawing.Point(433, 268);
            this.hButton1.Name = "hButton1";
            this.hButton1.Radius = new HeCopUI_Framework.Struct.CornerRadius(0F, 0F, 0F, 0F);
            this.hButton1.RippleColor = System.Drawing.Color.Black;
            this.hButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hButton1.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.hButton1.ShadowRadius = 5;
            this.hButton1.ShapeButtonType = HeCopUI_Framework.Enums.ShapeType.Rectangle;
            this.hButton1.Size = new System.Drawing.Size(120, 25);
            this.hButton1.SupportImageGif = false;
            this.hButton1.TabIndex = 6;
            this.hButton1.Text = "Start";
            this.hButton1.TextDownColor = System.Drawing.Color.White;
            this.hButton1.TextHoverColor = System.Drawing.Color.White;
            this.hButton1.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.hButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.hButton1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hButton1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hButton1_MouseClick);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(48, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clearing cache files deletes temporary app data, freeing up space and potentially" +
    " improving performance.";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(48, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cleaning history files removes records of past activities, like browsing history " +
    "or recent documents, enhancing privacy and freeing up space.";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clearing temporary files deletes files made by the system or apps during operatio" +
    "ns, like cache and logs. It frees up space and can boost system performance.";
            // 
            // hCheckBox3
            // 
            this.hCheckBox3.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox3.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox3.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox3.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox3.CheckColor = System.Drawing.Color.White;
            this.hCheckBox3.Checked = true;
            this.hCheckBox3.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox3.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox3.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox3.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox3.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox3.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox3.Location = new System.Drawing.Point(19, 163);
            this.hCheckBox3.Name = "hCheckBox3";
            this.hCheckBox3.RippleAlpha = 60;
            this.hCheckBox3.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox3.Size = new System.Drawing.Size(169, 28);
            this.hCheckBox3.TabIndex = 2;
            this.hCheckBox3.Text = "Clean up cache files";
            this.hCheckBox3.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox3.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox3.UnCheckedBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox3.CheckedChanged += new System.EventHandler(this.hCheckBox3_CheckedChanged);
            // 
            // hCheckBox2
            // 
            this.hCheckBox2.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox2.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox2.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox2.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox2.CheckColor = System.Drawing.Color.White;
            this.hCheckBox2.Checked = true;
            this.hCheckBox2.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox2.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox2.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox2.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox2.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox2.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox2.Location = new System.Drawing.Point(19, 93);
            this.hCheckBox2.Name = "hCheckBox2";
            this.hCheckBox2.RippleAlpha = 60;
            this.hCheckBox2.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox2.Size = new System.Drawing.Size(178, 28);
            this.hCheckBox2.TabIndex = 1;
            this.hCheckBox2.Text = "Clean up history files";
            this.hCheckBox2.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox2.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox2.UnCheckedBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox2.CheckedChanged += new System.EventHandler(this.hCheckBox2_CheckedChanged);
            // 
            // hCheckBox1
            // 
            this.hCheckBox1.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox1.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox1.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox1.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox1.CheckColor = System.Drawing.Color.White;
            this.hCheckBox1.Checked = true;
            this.hCheckBox1.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox1.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox1.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox1.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox1.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox1.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox1.Location = new System.Drawing.Point(19, 19);
            this.hCheckBox1.Name = "hCheckBox1";
            this.hCheckBox1.RippleAlpha = 60;
            this.hCheckBox1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox1.Size = new System.Drawing.Size(204, 28);
            this.hCheckBox1.TabIndex = 0;
            this.hCheckBox1.Text = "Clean up temporary files";
            this.hCheckBox1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox1.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox1.UnCheckedBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox1.CheckedChanged += new System.EventHandler(this.hCheckBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.hProgressBar2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.hButton2);
            this.tabPage2.Controls.Add(this.LB_NumberOfDisk);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Controls.Add(this.list_drives);
            this.tabPage2.Controls.Add(this.hRichTextBox1);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.tabPage2.Size = new System.Drawing.Size(572, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disk Defrag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(25, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "This tool uses \'defrag.exe\' of Windows command line.";
            // 
            // hProgressBar2
            // 
            this.hProgressBar2.AnimationMode = HeCopUI_Framework.Enums.ProgressAnimationMode.Indeterminate;
            this.hProgressBar2.BaseProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hProgressBar2.BaseProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hProgressBar2.BorderColor = System.Drawing.Color.Silver;
            this.hProgressBar2.BorderWidth = 0;
            this.hProgressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hProgressBar2.ForeColor = System.Drawing.Color.White;
            this.hProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.hProgressBar2.Location = new System.Drawing.Point(8, 304);
            this.hProgressBar2.MaximumValue = 100;
            this.hProgressBar2.MinimumValue = 0;
            this.hProgressBar2.Name = "hProgressBar2";
            this.hProgressBar2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.hProgressBar2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.hProgressBar2.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.hProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hProgressBar2.ProgressValue = 12;
            this.hProgressBar2.Radius = new HeCopUI_Framework.Struct.CornerRadius(2F, 2F, 2F, 2F);
            this.hProgressBar2.Size = new System.Drawing.Size(556, 6);
            this.hProgressBar2.TabIndex = 9;
            this.hProgressBar2.Text = "hProgressBar2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(171, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Action:";
            // 
            // hButton2
            // 
            this.hButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hButton2.AnimationMode = HeCopUI_Framework.Enums.AnimationMode.None;
            this.hButton2.BackHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.hButton2.BackHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.hButton2.BackPressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hButton2.BackPressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.hButton2.BorderColor = System.Drawing.Color.DarkGray;
            this.hButton2.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hButton2.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hButton2.BorderThickness = 0;
            this.hButton2.ButtonColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hButton2.ButtonColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.hButton2.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hButton2.ClipRegion = false;
            this.hButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hButton2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hButton2.FocusBorderColor = System.Drawing.Color.White;
            this.hButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hButton2.Image = null;
            this.hButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hButton2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.hButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.hButton2.IsAutoSize = false;
            this.hButton2.Location = new System.Drawing.Point(433, 268);
            this.hButton2.Name = "hButton2";
            this.hButton2.Radius = new HeCopUI_Framework.Struct.CornerRadius(0F, 0F, 0F, 0F);
            this.hButton2.RippleColor = System.Drawing.Color.Black;
            this.hButton2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hButton2.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.hButton2.ShadowRadius = 5;
            this.hButton2.ShapeButtonType = HeCopUI_Framework.Enums.ShapeType.Rectangle;
            this.hButton2.Size = new System.Drawing.Size(120, 25);
            this.hButton2.SupportImageGif = false;
            this.hButton2.TabIndex = 7;
            this.hButton2.Text = "Start";
            this.hButton2.TextDownColor = System.Drawing.Color.White;
            this.hButton2.TextHoverColor = System.Drawing.Color.White;
            this.hButton2.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.hButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.hButton2.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hButton2.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            // 
            // LB_NumberOfDisk
            // 
            this.LB_NumberOfDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_NumberOfDisk.AutoSize = true;
            this.LB_NumberOfDisk.BackColor = System.Drawing.Color.Transparent;
            this.LB_NumberOfDisk.Location = new System.Drawing.Point(22, 185);
            this.LB_NumberOfDisk.Name = "LB_NumberOfDisk";
            this.LB_NumberOfDisk.Size = new System.Drawing.Size(66, 17);
            this.LB_NumberOfDisk.TabIndex = 4;
            this.LB_NumberOfDisk.Text = "Drive(s): 0";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox7);
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox8);
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox9);
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox10);
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox11);
            this.flowLayoutPanel2.Controls.Add(this.hCheckBox12);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 209);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(239, 84);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // hCheckBox7
            // 
            this.hCheckBox7.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox7.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox7.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox7.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox7.CheckColor = System.Drawing.Color.White;
            this.hCheckBox7.Checked = true;
            this.hCheckBox7.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox7.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox7.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox7.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox7.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox7.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox7.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox7.Location = new System.Drawing.Point(3, 3);
            this.hCheckBox7.Name = "hCheckBox7";
            this.hCheckBox7.RippleAlpha = 60;
            this.hCheckBox7.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox7.Size = new System.Drawing.Size(90, 30);
            this.hCheckBox7.TabIndex = 1;
            this.hCheckBox7.Text = "Analyze";
            this.hCheckBox7.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox7.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox7.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // hCheckBox8
            // 
            this.hCheckBox8.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox8.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox8.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox8.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox8.CheckColor = System.Drawing.Color.White;
            this.hCheckBox8.Checked = true;
            this.hCheckBox8.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox8.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox8.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox8.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox8.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox8.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox8.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox8.Location = new System.Drawing.Point(99, 3);
            this.hCheckBox8.Name = "hCheckBox8";
            this.hCheckBox8.RippleAlpha = 60;
            this.hCheckBox8.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox8.Size = new System.Drawing.Size(118, 30);
            this.hCheckBox8.TabIndex = 2;
            this.hCheckBox8.Text = "BootOptimize";
            this.hCheckBox8.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox8.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox8.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // hCheckBox9
            // 
            this.hCheckBox9.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox9.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox9.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox9.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox9.CheckColor = System.Drawing.Color.White;
            this.hCheckBox9.Checked = true;
            this.hCheckBox9.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox9.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox9.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox9.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox9.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox9.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox9.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox9.Location = new System.Drawing.Point(3, 39);
            this.hCheckBox9.Name = "hCheckBox9";
            this.hCheckBox9.RippleAlpha = 60;
            this.hCheckBox9.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox9.Size = new System.Drawing.Size(90, 30);
            this.hCheckBox9.TabIndex = 3;
            this.hCheckBox9.Text = "Defrag";
            this.hCheckBox9.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox9.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox9.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // hCheckBox10
            // 
            this.hCheckBox10.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox10.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox10.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox10.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox10.CheckColor = System.Drawing.Color.White;
            this.hCheckBox10.Checked = true;
            this.hCheckBox10.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox10.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox10.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox10.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox10.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox10.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox10.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox10.Location = new System.Drawing.Point(99, 39);
            this.hCheckBox10.Name = "hCheckBox10";
            this.hCheckBox10.RippleAlpha = 60;
            this.hCheckBox10.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox10.Size = new System.Drawing.Size(90, 30);
            this.hCheckBox10.TabIndex = 4;
            this.hCheckBox10.Text = "Retrim";
            this.hCheckBox10.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox10.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox10.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // hCheckBox11
            // 
            this.hCheckBox11.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox11.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox11.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox11.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox11.CheckColor = System.Drawing.Color.White;
            this.hCheckBox11.Checked = true;
            this.hCheckBox11.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox11.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox11.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox11.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox11.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox11.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox11.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox11.Location = new System.Drawing.Point(3, 75);
            this.hCheckBox11.Name = "hCheckBox11";
            this.hCheckBox11.RippleAlpha = 60;
            this.hCheckBox11.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox11.Size = new System.Drawing.Size(90, 30);
            this.hCheckBox11.TabIndex = 5;
            this.hCheckBox11.Text = "Optimize";
            this.hCheckBox11.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox11.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox11.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // hCheckBox12
            // 
            this.hCheckBox12.BorderBox = System.Drawing.Color.Transparent;
            this.hCheckBox12.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox12.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox12.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox12.CheckColor = System.Drawing.Color.White;
            this.hCheckBox12.Checked = true;
            this.hCheckBox12.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox12.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox12.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox12.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox12.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox12.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox12.FocusBorderColor = System.Drawing.Color.Transparent;
            this.hCheckBox12.Location = new System.Drawing.Point(99, 75);
            this.hCheckBox12.Name = "hCheckBox12";
            this.hCheckBox12.RippleAlpha = 60;
            this.hCheckBox12.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox12.Size = new System.Drawing.Size(118, 30);
            this.hCheckBox12.TabIndex = 6;
            this.hCheckBox12.Text = "TierOptimize";
            this.hCheckBox12.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox12.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox12.UnCheckedBoxColor = System.Drawing.Color.Gray;
            // 
            // list_drives
            // 
            this.list_drives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.list_drives.AutoScroll = true;
            this.list_drives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.list_drives.Controls.Add(this.hCheckBox4);
            this.list_drives.Controls.Add(this.hCheckBox5);
            this.list_drives.Controls.Add(this.hCheckBox6);
            this.list_drives.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.list_drives.Location = new System.Drawing.Point(25, 209);
            this.list_drives.Name = "list_drives";
            this.list_drives.Size = new System.Drawing.Size(137, 84);
            this.list_drives.TabIndex = 1;
            this.list_drives.WrapContents = false;
            // 
            // hCheckBox4
            // 
            this.hCheckBox4.BorderBox = System.Drawing.Color.Gray;
            this.hCheckBox4.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox4.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox4.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox4.CheckColor = System.Drawing.Color.White;
            this.hCheckBox4.Checked = true;
            this.hCheckBox4.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox4.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox4.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox4.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox4.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox4.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox4.FocusBorderColor = System.Drawing.Color.Gray;
            this.hCheckBox4.Location = new System.Drawing.Point(3, 3);
            this.hCheckBox4.Name = "hCheckBox4";
            this.hCheckBox4.RippleAlpha = 60;
            this.hCheckBox4.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox4.Size = new System.Drawing.Size(48, 30);
            this.hCheckBox4.TabIndex = 1;
            this.hCheckBox4.Text = "C:";
            this.hCheckBox4.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox4.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox4.UnCheckedBoxColor = System.Drawing.Color.Transparent;
            // 
            // hCheckBox5
            // 
            this.hCheckBox5.BorderBox = System.Drawing.Color.Gray;
            this.hCheckBox5.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox5.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox5.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox5.CheckColor = System.Drawing.Color.White;
            this.hCheckBox5.Checked = true;
            this.hCheckBox5.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox5.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox5.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox5.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox5.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox5.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox5.FocusBorderColor = System.Drawing.Color.Gray;
            this.hCheckBox5.Location = new System.Drawing.Point(3, 39);
            this.hCheckBox5.Name = "hCheckBox5";
            this.hCheckBox5.RippleAlpha = 60;
            this.hCheckBox5.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox5.Size = new System.Drawing.Size(48, 30);
            this.hCheckBox5.TabIndex = 2;
            this.hCheckBox5.Text = "C:";
            this.hCheckBox5.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox5.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox5.UnCheckedBoxColor = System.Drawing.Color.Transparent;
            // 
            // hCheckBox6
            // 
            this.hCheckBox6.BorderBox = System.Drawing.Color.Gray;
            this.hCheckBox6.CheckBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox6.CheckBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox6.CheckBoxGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.hCheckBox6.CheckColor = System.Drawing.Color.White;
            this.hCheckBox6.Checked = true;
            this.hCheckBox6.CheckedBoxColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox6.CheckedBoxColor2 = System.Drawing.Color.DodgerBlue;
            this.hCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hCheckBox6.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hCheckBox6.DisabledCheckBoxColor = System.Drawing.Color.Gray;
            this.hCheckBox6.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hCheckBox6.EnabledTextColor = System.Drawing.Color.WhiteSmoke;
            this.hCheckBox6.FocusBorderColor = System.Drawing.Color.Gray;
            this.hCheckBox6.Location = new System.Drawing.Point(3, 75);
            this.hCheckBox6.Name = "hCheckBox6";
            this.hCheckBox6.RippleAlpha = 60;
            this.hCheckBox6.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hCheckBox6.Size = new System.Drawing.Size(48, 30);
            this.hCheckBox6.TabIndex = 3;
            this.hCheckBox6.Text = "C:";
            this.hCheckBox6.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hCheckBox6.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.hCheckBox6.UnCheckedBoxColor = System.Drawing.Color.Transparent;
            // 
            // hRichTextBox1
            // 
            this.hRichTextBox1.AcceptsTab = false;
            this.hRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hRichTextBox1.AutoWordSelection = false;
            this.hRichTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.hRichTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.hRichTextBox1.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.hRichTextBox1.BorderThickness = 1;
            this.hRichTextBox1.BulletIndent = 0;
            this.hRichTextBox1.DetectUrls = true;
            this.hRichTextBox1.EnableAutoDragDrop = false;
            this.hRichTextBox1.HideSelection = false;
            this.hRichTextBox1.Lines = new string[] {
        "hRichTextBox1"};
            this.hRichTextBox1.Location = new System.Drawing.Point(25, 48);
            this.hRichTextBox1.MaxLength = 2147483647;
            this.hRichTextBox1.MultiLine = true;
            this.hRichTextBox1.Name = "hRichTextBox1";
            this.hRichTextBox1.Radius = 5;
            this.hRichTextBox1.ReadOnly = false;
            this.hRichTextBox1.RichTextBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.hRichTextBox1.RichTextBoxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.hRichTextBox1.RichTextBoxScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.hRichTextBox1.SelectionRightIndent = 0;
            this.hRichTextBox1.ShorcutEnabled = false;
            this.hRichTextBox1.ShowSelectionMargin = false;
            this.hRichTextBox1.Size = new System.Drawing.Size(528, 128);
            this.hRichTextBox1.TabIndex = 0;
            this.hRichTextBox1.Text = "hRichTextBox1";
            this.hRichTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.hRichTextBox1.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hRichTextBox1.WordWrap = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.LB_CntStartupApps);
            this.tabPage3.Controls.Add(this.btn_reloadlistappstartup);
            this.tabPage3.Controls.Add(this.btn_disappstartup);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.tabPage3.Size = new System.Drawing.Size(572, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Startup Apps";
            // 
            // LB_CntStartupApps
            // 
            this.LB_CntStartupApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_CntStartupApps.AutoSize = true;
            this.LB_CntStartupApps.Location = new System.Drawing.Point(22, 276);
            this.LB_CntStartupApps.Name = "LB_CntStartupApps";
            this.LB_CntStartupApps.Size = new System.Drawing.Size(96, 17);
            this.LB_CntStartupApps.TabIndex = 10;
            this.LB_CntStartupApps.Text = "0 startup apps.";
            // 
            // btn_reloadlistappstartup
            // 
            this.btn_reloadlistappstartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reloadlistappstartup.AnimationMode = HeCopUI_Framework.Enums.AnimationMode.None;
            this.btn_reloadlistappstartup.BackHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btn_reloadlistappstartup.BackHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btn_reloadlistappstartup.BackPressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_reloadlistappstartup.BackPressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.btn_reloadlistappstartup.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reloadlistappstartup.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.btn_reloadlistappstartup.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.btn_reloadlistappstartup.BorderThickness = 0;
            this.btn_reloadlistappstartup.ButtonColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_reloadlistappstartup.ButtonColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.btn_reloadlistappstartup.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reloadlistappstartup.ClipRegion = false;
            this.btn_reloadlistappstartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reloadlistappstartup.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_reloadlistappstartup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reloadlistappstartup.FocusBorderColor = System.Drawing.Color.White;
            this.btn_reloadlistappstartup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_reloadlistappstartup.Image = null;
            this.btn_reloadlistappstartup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reloadlistappstartup.ImagePadding = new System.Windows.Forms.Padding(0);
            this.btn_reloadlistappstartup.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_reloadlistappstartup.IsAutoSize = false;
            this.btn_reloadlistappstartup.Location = new System.Drawing.Point(296, 268);
            this.btn_reloadlistappstartup.Name = "btn_reloadlistappstartup";
            this.btn_reloadlistappstartup.Radius = new HeCopUI_Framework.Struct.CornerRadius(0F, 0F, 0F, 0F);
            this.btn_reloadlistappstartup.RippleColor = System.Drawing.Color.Black;
            this.btn_reloadlistappstartup.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reloadlistappstartup.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_reloadlistappstartup.ShadowRadius = 5;
            this.btn_reloadlistappstartup.ShapeButtonType = HeCopUI_Framework.Enums.ShapeType.Rectangle;
            this.btn_reloadlistappstartup.Size = new System.Drawing.Size(120, 25);
            this.btn_reloadlistappstartup.SupportImageGif = false;
            this.btn_reloadlistappstartup.TabIndex = 9;
            this.btn_reloadlistappstartup.Text = "Renew";
            this.btn_reloadlistappstartup.TextDownColor = System.Drawing.Color.White;
            this.btn_reloadlistappstartup.TextHoverColor = System.Drawing.Color.White;
            this.btn_reloadlistappstartup.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reloadlistappstartup.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_reloadlistappstartup.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_reloadlistappstartup.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_reloadlistappstartup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_reloadlistappstartup_MouseClick);
            // 
            // btn_disappstartup
            // 
            this.btn_disappstartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disappstartup.AnimationMode = HeCopUI_Framework.Enums.AnimationMode.None;
            this.btn_disappstartup.BackHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.btn_disappstartup.BackHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btn_disappstartup.BackPressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_disappstartup.BackPressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.btn_disappstartup.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_disappstartup.BorderDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.btn_disappstartup.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(148)))));
            this.btn_disappstartup.BorderThickness = 0;
            this.btn_disappstartup.ButtonColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btn_disappstartup.ButtonColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.btn_disappstartup.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_disappstartup.ClipRegion = false;
            this.btn_disappstartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disappstartup.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_disappstartup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_disappstartup.FocusBorderColor = System.Drawing.Color.White;
            this.btn_disappstartup.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_disappstartup.Image = null;
            this.btn_disappstartup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_disappstartup.ImagePadding = new System.Windows.Forms.Padding(0);
            this.btn_disappstartup.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_disappstartup.IsAutoSize = false;
            this.btn_disappstartup.Location = new System.Drawing.Point(433, 268);
            this.btn_disappstartup.Name = "btn_disappstartup";
            this.btn_disappstartup.Radius = new HeCopUI_Framework.Struct.CornerRadius(0F, 0F, 0F, 0F);
            this.btn_disappstartup.RippleColor = System.Drawing.Color.Black;
            this.btn_disappstartup.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_disappstartup.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_disappstartup.ShadowRadius = 5;
            this.btn_disappstartup.ShapeButtonType = HeCopUI_Framework.Enums.ShapeType.Rectangle;
            this.btn_disappstartup.Size = new System.Drawing.Size(120, 25);
            this.btn_disappstartup.SupportImageGif = false;
            this.btn_disappstartup.TabIndex = 8;
            this.btn_disappstartup.Text = "Disable";
            this.btn_disappstartup.TextDownColor = System.Drawing.Color.White;
            this.btn_disappstartup.TextHoverColor = System.Drawing.Color.White;
            this.btn_disappstartup.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_disappstartup.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_disappstartup.TextRenderHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_disappstartup.TextTrim = System.Drawing.StringTrimming.EllipsisCharacter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CH_Name,
            this.CH_Path,
            this.CH_Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(528, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // CH_Name
            // 
            this.CH_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CH_Name.HeaderText = "Name";
            this.CH_Name.Name = "CH_Name";
            this.CH_Name.ReadOnly = true;
            // 
            // CH_Path
            // 
            this.CH_Path.HeaderText = "Location";
            this.CH_Path.Name = "CH_Path";
            this.CH_Path.ReadOnly = true;
            // 
            // CH_Type
            // 
            this.CH_Type.HeaderText = "Type";
            this.CH_Type.Name = "CH_Type";
            this.CH_Type.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.tabPage4.Size = new System.Drawing.Size(572, 318);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Processes";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.hTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.list_drives.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HeCopUI_Framework.Controls.HTabControl hTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox2;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HeCopUI_Framework.Controls.HButton hButton1;
        private HeCopUI_Framework.Controls.Progress.HProgressBar hProgressBar1;
        private HeCopUI_Framework.Controls.HRichTextBox hRichTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel list_drives;
        private System.Windows.Forms.Label LB_NumberOfDisk;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox4;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox5;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox6;
        private HeCopUI_Framework.Controls.HButton hButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox7;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox8;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox9;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox10;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox11;
        private HeCopUI_Framework.Controls.HCheckBox hCheckBox12;
        private HeCopUI_Framework.Controls.Progress.HProgressBar hProgressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Type;
        private HeCopUI_Framework.Controls.HButton btn_disappstartup;
        private HeCopUI_Framework.Controls.HButton btn_reloadlistappstartup;
        private System.Windows.Forms.Label LB_CntStartupApps;
    }
}

