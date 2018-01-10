namespace StudentExam
{
    partial class FRM_Exam
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool1 = new Infragistics.Win.UltraWinToolbars.LabelTool("LabelTool1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Next");
            Infragistics.Win.UltraWinToolbars.LabelTool labelTool2 = new Infragistics.Win.UltraWinToolbars.LabelTool("LabelTool1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool8 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Next");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.PNL_StatusBar = new Telerik.WinControls.UI.RadPanel();
            this.STS_Message = new Telerik.WinControls.UI.RadStatusStrip();
            this.Msg = new Telerik.WinControls.UI.RadLabelElement();
            this.PNL_Main = new Telerik.WinControls.UI.RadPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.LBL_CorrectAnswer = new System.Windows.Forms.Label();
            this.LBL_ExamRemainingTime = new System.Windows.Forms.Label();
            this.LBL_QuestionTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHK_Option4 = new System.Windows.Forms.CheckBox();
            this.CHK_Option3 = new System.Windows.Forms.CheckBox();
            this.CHK_Option2 = new System.Windows.Forms.CheckBox();
            this.CHK_Option1 = new System.Windows.Forms.CheckBox();
            this.LBL_Option4 = new System.Windows.Forms.Label();
            this.LBL_Option3 = new System.Windows.Forms.Label();
            this.LBL_Option2 = new System.Windows.Forms.Label();
            this.TXT_Description = new Telerik.WinControls.UI.RadLabel();
            this.LBL_Option1 = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.TXT_Code = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.panel2 = new System.Windows.Forms.Panel();
            this._panel2_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.Toolbar_Options = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._panel2_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel2_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel2_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.Timer_ExamTime = new System.Windows.Forms.Timer(this.components);
            this.ultraToolbarsDockArea1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraToolbarsDockArea2 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraToolbarsDockArea4 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.OpnDlg_Picture = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.TMR_Question = new System.Windows.Forms.Timer(this.components);
            this.TMR_ChangeQuestion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_StatusBar)).BeginInit();
            this.PNL_StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).BeginInit();
            this.PNL_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Code)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toolbar_Options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_StatusBar
            // 
            this.PNL_StatusBar.Controls.Add(this.STS_Message);
            this.PNL_StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_StatusBar.Location = new System.Drawing.Point(0, 417);
            this.PNL_StatusBar.Name = "PNL_StatusBar";
            this.PNL_StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PNL_StatusBar.Size = new System.Drawing.Size(786, 24);
            this.PNL_StatusBar.TabIndex = 2;
            // 
            // STS_Message
            // 
            this.STS_Message.AutoSize = true;
            this.STS_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STS_Message.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.Msg});
            this.STS_Message.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.STS_Message.Location = new System.Drawing.Point(0, 0);
            this.STS_Message.Name = "STS_Message";
            this.STS_Message.Size = new System.Drawing.Size(786, 24);
            this.STS_Message.TabIndex = 0;
            this.STS_Message.Text = "radStatusStrip1";
            // 
            // Msg
            // 
            this.Msg.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.Msg.Name = "Msg";
            this.STS_Message.SetSpring(this.Msg, false);
            this.Msg.Text = "";
            this.Msg.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.Msg.TextWrap = true;
            this.Msg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // PNL_Main
            // 
            this.PNL_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Main.Controls.Add(this.panel1);
            this.PNL_Main.Controls.Add(this.panel2);
            this.PNL_Main.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.PNL_Main.Location = new System.Drawing.Point(0, 0);
            this.PNL_Main.Name = "PNL_Main";
            this.PNL_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PNL_Main.Size = new System.Drawing.Size(786, 411);
            this.PNL_Main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radGroupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 321);
            this.panel1.TabIndex = 8;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.LBL_CorrectAnswer);
            this.radGroupBox1.Controls.Add(this.LBL_ExamRemainingTime);
            this.radGroupBox1.Controls.Add(this.LBL_QuestionTime);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.CHK_Option4);
            this.radGroupBox1.Controls.Add(this.CHK_Option3);
            this.radGroupBox1.Controls.Add(this.CHK_Option2);
            this.radGroupBox1.Controls.Add(this.CHK_Option1);
            this.radGroupBox1.Controls.Add(this.LBL_Option4);
            this.radGroupBox1.Controls.Add(this.LBL_Option3);
            this.radGroupBox1.Controls.Add(this.LBL_Option2);
            this.radGroupBox1.Controls.Add(this.TXT_Description);
            this.radGroupBox1.Controls.Add(this.LBL_Option1);
            this.radGroupBox1.Controls.Add(this.LBL_Description);
            this.radGroupBox1.Controls.Add(this.TXT_Code);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "السؤال";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 14);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(779, 300);
            this.radGroupBox1.TabIndex = 79;
            this.radGroupBox1.Text = "السؤال";
            // 
            // LBL_CorrectAnswer
            // 
            this.LBL_CorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CorrectAnswer.Location = new System.Drawing.Point(131, 255);
            this.LBL_CorrectAnswer.Name = "LBL_CorrectAnswer";
            this.LBL_CorrectAnswer.Size = new System.Drawing.Size(99, 17);
            this.LBL_CorrectAnswer.TabIndex = 105;
            this.LBL_CorrectAnswer.Visible = false;
            // 
            // LBL_ExamRemainingTime
            // 
            this.LBL_ExamRemainingTime.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExamRemainingTime.ForeColor = System.Drawing.Color.Red;
            this.LBL_ExamRemainingTime.Location = new System.Drawing.Point(20, 45);
            this.LBL_ExamRemainingTime.Name = "LBL_ExamRemainingTime";
            this.LBL_ExamRemainingTime.Size = new System.Drawing.Size(160, 17);
            this.LBL_ExamRemainingTime.TabIndex = 104;
            this.LBL_ExamRemainingTime.Text = "00:55:00";
            // 
            // LBL_QuestionTime
            // 
            this.LBL_QuestionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_QuestionTime.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_QuestionTime.Location = new System.Drawing.Point(531, 45);
            this.LBL_QuestionTime.Name = "LBL_QuestionTime";
            this.LBL_QuestionTime.Size = new System.Drawing.Size(55, 17);
            this.LBL_QuestionTime.TabIndex = 103;
            this.LBL_QuestionTime.Text = "30";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "الزمن المتبقى للأمتحان";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "الزمن المتبقى للسؤال";
            // 
            // CHK_Option4
            // 
            this.CHK_Option4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_Option4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Option4.Location = new System.Drawing.Point(12, 275);
            this.CHK_Option4.Name = "CHK_Option4";
            this.CHK_Option4.Size = new System.Drawing.Size(312, 20);
            this.CHK_Option4.TabIndex = 3;
            this.CHK_Option4.UseVisualStyleBackColor = true;
            this.CHK_Option4.CheckedChanged += new System.EventHandler(this.CHK_Option1_CheckedChanged);
            // 
            // CHK_Option3
            // 
            this.CHK_Option3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_Option3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Option3.Location = new System.Drawing.Point(389, 272);
            this.CHK_Option3.Name = "CHK_Option3";
            this.CHK_Option3.Size = new System.Drawing.Size(361, 20);
            this.CHK_Option3.TabIndex = 2;
            this.CHK_Option3.UseVisualStyleBackColor = true;
            this.CHK_Option3.CheckedChanged += new System.EventHandler(this.CHK_Option1_CheckedChanged);
            // 
            // CHK_Option2
            // 
            this.CHK_Option2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_Option2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Option2.Location = new System.Drawing.Point(12, 211);
            this.CHK_Option2.Name = "CHK_Option2";
            this.CHK_Option2.Size = new System.Drawing.Size(312, 20);
            this.CHK_Option2.TabIndex = 1;
            this.CHK_Option2.UseVisualStyleBackColor = true;
            this.CHK_Option2.CheckedChanged += new System.EventHandler(this.CHK_Option1_CheckedChanged);
            // 
            // CHK_Option1
            // 
            this.CHK_Option1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHK_Option1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Option1.Location = new System.Drawing.Point(389, 211);
            this.CHK_Option1.Name = "CHK_Option1";
            this.CHK_Option1.Size = new System.Drawing.Size(361, 20);
            this.CHK_Option1.TabIndex = 0;
            this.CHK_Option1.UseVisualStyleBackColor = true;
            this.CHK_Option1.CheckedChanged += new System.EventHandler(this.CHK_Option1_CheckedChanged);
            // 
            // LBL_Option4
            // 
            this.LBL_Option4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Option4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Option4.Location = new System.Drawing.Point(317, 272);
            this.LBL_Option4.Name = "LBL_Option4";
            this.LBL_Option4.Size = new System.Drawing.Size(29, 17);
            this.LBL_Option4.TabIndex = 94;
            this.LBL_Option4.Text = "4";
            // 
            // LBL_Option3
            // 
            this.LBL_Option3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Option3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Option3.Location = new System.Drawing.Point(744, 271);
            this.LBL_Option3.Name = "LBL_Option3";
            this.LBL_Option3.Size = new System.Drawing.Size(29, 17);
            this.LBL_Option3.TabIndex = 94;
            this.LBL_Option3.Text = "3";
            // 
            // LBL_Option2
            // 
            this.LBL_Option2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Option2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Option2.Location = new System.Drawing.Point(317, 211);
            this.LBL_Option2.Name = "LBL_Option2";
            this.LBL_Option2.Size = new System.Drawing.Size(29, 17);
            this.LBL_Option2.TabIndex = 92;
            this.LBL_Option2.Text = "2";
            // 
            // TXT_Description
            // 
            this.TXT_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Description.AutoSize = false;
            this.TXT_Description.BorderVisible = true;
            this.TXT_Description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Description.Location = new System.Drawing.Point(12, 107);
            this.TXT_Description.Name = "TXT_Description";
            this.TXT_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_Description.Size = new System.Drawing.Size(650, 98);
            this.TXT_Description.TabIndex = 90;
            this.TXT_Description.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TXT_Description.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // LBL_Option1
            // 
            this.LBL_Option1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Option1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Option1.Location = new System.Drawing.Point(742, 213);
            this.LBL_Option1.Name = "LBL_Option1";
            this.LBL_Option1.Size = new System.Drawing.Size(29, 17);
            this.LBL_Option1.TabIndex = 85;
            this.LBL_Option1.Text = "1";
            // 
            // LBL_Description
            // 
            this.LBL_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Description.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Description.Location = new System.Drawing.Point(672, 112);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(99, 17);
            this.LBL_Description.TabIndex = 69;
            this.LBL_Description.Text = "السؤال";
            // 
            // TXT_Code
            // 
            this.TXT_Code.Location = new System.Drawing.Point(70, 136);
            this.TXT_Code.Name = "TXT_Code";
            this.TXT_Code.Size = new System.Drawing.Size(100, 29);
            this.TXT_Code.TabIndex = 96;
            this.TXT_Code.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this._panel2_Toolbars_Dock_Area_Left);
            this.panel2.Controls.Add(this._panel2_Toolbars_Dock_Area_Right);
            this.panel2.Controls.Add(this._panel2_Toolbars_Dock_Area_Bottom);
            this.panel2.Controls.Add(this._panel2_Toolbars_Dock_Area_Top);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 88);
            this.panel2.TabIndex = 7;
            // 
            // _panel2_Toolbars_Dock_Area_Left
            // 
            this._panel2_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel2_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel2_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._panel2_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black;
            this._panel2_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 75);
            this._panel2_Toolbars_Dock_Area_Left.Name = "_panel2_Toolbars_Dock_Area_Left";
            this._panel2_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 9);
            this._panel2_Toolbars_Dock_Area_Left.ToolbarsManager = this.Toolbar_Options;
            // 
            // Toolbar_Options
            // 
            this.Toolbar_Options.AlwaysShowMenusExpanded = Infragistics.Win.DefaultableBoolean.True;
            this.Toolbar_Options.DesignerFlags = 1;
            this.Toolbar_Options.DockWithinContainer = this.panel2;
            this.Toolbar_Options.ImageSizeLarge = new System.Drawing.Size(64, 64);
            this.Toolbar_Options.ShowFullMenusDelay = 500;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.FloatingLocation = new System.Drawing.Point(314, 451);
            ultraToolbar1.FloatingSize = new System.Drawing.Size(231, 296);
            ultraToolbar1.IsMainMenuBar = true;
            labelTool1.InstanceProps.Width = 511;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            labelTool1,
            buttonTool6});
            ultraToolbar1.Text = "UltraToolbar1";
            this.Toolbar_Options.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            this.Toolbar_Options.ToolbarSettings.AllowFloating = Infragistics.Win.DefaultableBoolean.True;
            this.Toolbar_Options.ToolbarSettings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            this.Toolbar_Options.ToolbarSettings.ToolOrientation = Infragistics.Win.UltraWinToolbars.ToolOrientation.Horizontal;
            this.Toolbar_Options.ToolbarSettings.UseLargeImages = Infragistics.Win.DefaultableBoolean.True;
            appearance15.FontData.BoldAsString = "True";
            appearance15.FontData.Name = "Impact";
            appearance15.FontData.SizeInPoints = 30F;
            appearance15.Image = global::StudentExam.Properties.Resources._1471660815_forward;
            buttonTool8.SharedPropsInternal.AppearancesLarge.Appearance = appearance15;
            appearance11.FontData.BoldAsString = "True";
            appearance11.FontData.Name = "Impact";
            appearance11.FontData.SizeInPoints = 30F;
            buttonTool8.SharedPropsInternal.AppearancesLarge.AppearanceOnMenu = appearance11;
            appearance12.FontData.BoldAsString = "True";
            appearance12.FontData.Name = "Impact";
            appearance12.FontData.SizeInPoints = 30F;
            buttonTool8.SharedPropsInternal.AppearancesLarge.AppearanceOnToolbar = appearance12;
            buttonTool8.SharedPropsInternal.Caption = "التالى";
            buttonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            this.Toolbar_Options.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            labelTool2,
            buttonTool8});
            this.Toolbar_Options.UseLargeImagesOnMenu = true;
            this.Toolbar_Options.UseLargeImagesOnToolbar = true;
            this.Toolbar_Options.Visible = false;
            this.Toolbar_Options.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.Toolbar_Options_ToolClick);
            // 
            // _panel2_Toolbars_Dock_Area_Right
            // 
            this._panel2_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel2_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel2_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._panel2_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black;
            this._panel2_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(782, 75);
            this._panel2_Toolbars_Dock_Area_Right.Name = "_panel2_Toolbars_Dock_Area_Right";
            this._panel2_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 9);
            this._panel2_Toolbars_Dock_Area_Right.ToolbarsManager = this.Toolbar_Options;
            // 
            // _panel2_Toolbars_Dock_Area_Bottom
            // 
            this._panel2_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel2_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel2_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._panel2_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black;
            this._panel2_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 84);
            this._panel2_Toolbars_Dock_Area_Bottom.Name = "_panel2_Toolbars_Dock_Area_Bottom";
            this._panel2_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(782, 0);
            this._panel2_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.Toolbar_Options;
            // 
            // _panel2_Toolbars_Dock_Area_Top
            // 
            this._panel2_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel2_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel2_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._panel2_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black;
            this._panel2_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._panel2_Toolbars_Dock_Area_Top.Name = "_panel2_Toolbars_Dock_Area_Top";
            this._panel2_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(782, 75);
            this._panel2_Toolbars_Dock_Area_Top.ToolbarsManager = this.Toolbar_Options;
            // 
            // Timer_ExamTime
            // 
            this.Timer_ExamTime.Interval = 1000;
            this.Timer_ExamTime.Tick += new System.EventHandler(this.Timer_ExamTime_Tick);
            // 
            // ultraToolbarsDockArea1
            // 
            this.ultraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ultraToolbarsDockArea1.BackColor = System.Drawing.SystemColors.Control;
            this.ultraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this.ultraToolbarsDockArea1.ForeColor = System.Drawing.Color.Black;
            this.ultraToolbarsDockArea1.Location = new System.Drawing.Point(0, 0);
            this.ultraToolbarsDockArea1.Name = "ultraToolbarsDockArea1";
            this.ultraToolbarsDockArea1.Size = new System.Drawing.Size(786, 0);
            // 
            // ultraToolbarsDockArea2
            // 
            this.ultraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ultraToolbarsDockArea2.BackColor = System.Drawing.SystemColors.Control;
            this.ultraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this.ultraToolbarsDockArea2.ForeColor = System.Drawing.Color.Black;
            this.ultraToolbarsDockArea2.Location = new System.Drawing.Point(0, 417);
            this.ultraToolbarsDockArea2.Name = "ultraToolbarsDockArea2";
            this.ultraToolbarsDockArea2.Size = new System.Drawing.Size(786, 0);
            // 
            // ultraToolbarsDockArea4
            // 
            this.ultraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ultraToolbarsDockArea4.BackColor = System.Drawing.SystemColors.Control;
            this.ultraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this.ultraToolbarsDockArea4.ForeColor = System.Drawing.Color.Black;
            this.ultraToolbarsDockArea4.Location = new System.Drawing.Point(786, 0);
            this.ultraToolbarsDockArea4.Name = "ultraToolbarsDockArea4";
            this.ultraToolbarsDockArea4.Size = new System.Drawing.Size(0, 417);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel Sheets |*.xls";
            this.SaveFileDialog.RestoreDirectory = true;
            this.SaveFileDialog.Title = "Export To Excel";
            // 
            // TMR_Question
            // 
            this.TMR_Question.Interval = 1000;
            this.TMR_Question.Tick += new System.EventHandler(this.TMR_Question_Tick);
            // 
            // TMR_ChangeQuestion
            // 
            this.TMR_ChangeQuestion.Interval = 400;
            this.TMR_ChangeQuestion.Tick += new System.EventHandler(this.TMR_ChangeQuestion_Tick);
            // 
            // FRM_Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 441);
            this.ControlBox = false;
            this.Controls.Add(this.ultraToolbarsDockArea1);
            this.Controls.Add(this.ultraToolbarsDockArea2);
            this.Controls.Add(this.ultraToolbarsDockArea4);
            this.Controls.Add(this.PNL_StatusBar);
            this.Controls.Add(this.PNL_Main);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Exam";
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الامتحان";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FRM_Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_StatusBar)).EndInit();
            this.PNL_StatusBar.ResumeLayout(false);
            this.PNL_StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).EndInit();
            this.PNL_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Code)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Toolbar_Options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNL_Main;
        private Telerik.WinControls.UI.RadPanel PNL_StatusBar;
        private Telerik.WinControls.UI.RadStatusStrip STS_Message;
        private Telerik.WinControls.UI.RadLabelElement Msg;
        internal System.Windows.Forms.Timer Timer_ExamTime;
        private System.Windows.Forms.Panel panel2;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea ultraToolbarsDockArea1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea ultraToolbarsDockArea2;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea ultraToolbarsDockArea4;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.OpenFileDialog OpnDlg_Picture;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor TXT_Code;
        internal System.Windows.Forms.Label LBL_Description;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel2_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager Toolbar_Options;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel2_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel2_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel2_Toolbars_Dock_Area_Top;
        private Telerik.WinControls.UI.RadLabel TXT_Description;
        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        internal System.Windows.Forms.Label LBL_Option4;
        internal System.Windows.Forms.Label LBL_Option3;
        internal System.Windows.Forms.Label LBL_Option2;
        internal System.Windows.Forms.Label LBL_Option1;
        private System.Windows.Forms.CheckBox CHK_Option1;
        private System.Windows.Forms.CheckBox CHK_Option4;
        private System.Windows.Forms.CheckBox CHK_Option3;
        private System.Windows.Forms.CheckBox CHK_Option2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Timer TMR_Question;
        internal System.Windows.Forms.Label LBL_QuestionTime;
        internal System.Windows.Forms.Label LBL_ExamRemainingTime;
        internal System.Windows.Forms.Label LBL_CorrectAnswer;
        internal System.Windows.Forms.Timer TMR_ChangeQuestion;
    }
}

