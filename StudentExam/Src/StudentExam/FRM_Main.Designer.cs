namespace StudentExam
{
    partial class FRM_Main
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
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar2 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool15 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Students");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool16 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Books");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool14 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Exams");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool17 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Reports");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_CreateQuestion");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool19 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Students");
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool20 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Exams");
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool21 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Books");
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool22 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_Reports");
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BTN_CreateQuestion");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.PNL_StatusBar = new Telerik.WinControls.UI.RadPanel();
            this.STS_Message = new Telerik.WinControls.UI.RadStatusStrip();
            this.LBL_Msg = new Telerik.WinControls.UI.RadLabelElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this._panel1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ToolBar_Application = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._panel1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PIC_picture = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.Timer_MSgCleaner = new System.Windows.Forms.Timer(this.components);
            this.PNL_Main = new Telerik.WinControls.UI.RadPanel();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_StatusBar)).BeginInit();
            this.PNL_StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Message)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar_Application)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_StatusBar
            // 
            this.PNL_StatusBar.Controls.Add(this.STS_Message);
            this.PNL_StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_StatusBar.Location = new System.Drawing.Point(0, 623);
            this.PNL_StatusBar.Name = "PNL_StatusBar";
            this.PNL_StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PNL_StatusBar.Size = new System.Drawing.Size(918, 24);
            this.PNL_StatusBar.TabIndex = 2;
            // 
            // STS_Message
            // 
            this.STS_Message.AutoSize = true;
            this.STS_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STS_Message.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LBL_Msg});
            this.STS_Message.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.STS_Message.Location = new System.Drawing.Point(0, 0);
            this.STS_Message.Name = "STS_Message";
            this.STS_Message.Size = new System.Drawing.Size(918, 24);
            this.STS_Message.TabIndex = 0;
            this.STS_Message.Text = "radStatusStrip1";
            // 
            // LBL_Msg
            // 
            this.LBL_Msg.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.LBL_Msg.Name = "LBL_Msg";
            this.STS_Message.SetSpring(this.LBL_Msg, false);
            this.LBL_Msg.Text = "";
            this.LBL_Msg.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.LBL_Msg.TextWrap = true;
            this.LBL_Msg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Left);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Right);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Bottom);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(762, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 623);
            this.panel1.TabIndex = 4;
            // 
            // _panel1_Toolbars_Dock_Area_Left
            // 
            this._panel1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._panel1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 0);
            this._panel1_Toolbars_Dock_Area_Left.Name = "_panel1_Toolbars_Dock_Area_Left";
            this._panel1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(144, 619);
            this._panel1_Toolbars_Dock_Area_Left.ToolbarsManager = this.ToolBar_Application;
            // 
            // ToolBar_Application
            // 
            this.ToolBar_Application.DesignerFlags = 1;
            this.ToolBar_Application.DockWithinContainer = this.panel1;
            this.ToolBar_Application.ImageSizeLarge = new System.Drawing.Size(64, 64);
            this.ToolBar_Application.ShowFullMenusDelay = 500;
            ultraToolbar2.DockedColumn = 0;
            ultraToolbar2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            ultraToolbar2.DockedRow = 0;
            ultraToolbar2.FloatingSize = new System.Drawing.Size(176, 592);
            ultraToolbar2.IsMainMenuBar = true;
            ultraToolbar2.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool15,
            buttonTool16,
            buttonTool14,
            buttonTool17,
            buttonTool6});
            ultraToolbar2.Text = "UltraToolbar1";
            this.ToolBar_Application.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar2});
            this.ToolBar_Application.ToolbarSettings.AllowFloating = Infragistics.Win.DefaultableBoolean.True;
            this.ToolBar_Application.ToolbarSettings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            this.ToolBar_Application.ToolbarSettings.ToolOrientation = Infragistics.Win.UltraWinToolbars.ToolOrientation.Horizontal;
            this.ToolBar_Application.ToolbarSettings.UseLargeImages = Infragistics.Win.DefaultableBoolean.True;
            appearance27.FontData.BoldAsString = "True";
            appearance27.FontData.Name = "Arial Black";
            appearance27.FontData.SizeInPoints = 11F;
            appearance27.Image = global::StudentExam.Properties.Resources._1466812458_Graduate_male_24;
            buttonTool19.SharedPropsInternal.AppearancesLarge.Appearance = appearance27;
            buttonTool19.SharedPropsInternal.Caption = "الطلاب";
            appearance28.FontData.BoldAsString = "True";
            appearance28.FontData.Name = "Arial Black";
            appearance28.FontData.SizeInPoints = 11F;
            appearance28.Image = global::StudentExam.Properties.Resources._64_64_3476edfd6b73aa6bfab2f866025de64e;
            buttonTool20.SharedPropsInternal.AppearancesLarge.Appearance = appearance28;
            buttonTool20.SharedPropsInternal.Caption = "الاختبارات";
            appearance29.FontData.BoldAsString = "True";
            appearance29.FontData.Name = "Arial Black";
            appearance29.FontData.SizeInPoints = 11F;
            appearance29.Image = global::StudentExam.Properties.Resources._1468179640_emblem_library;
            buttonTool21.SharedPropsInternal.AppearancesLarge.Appearance = appearance29;
            buttonTool21.SharedPropsInternal.Caption = "الكتب";
            appearance30.FontData.BoldAsString = "True";
            appearance30.FontData.Name = "Arial Black";
            appearance30.FontData.SizeInPoints = 11F;
            appearance30.Image = global::StudentExam.Properties.Resources._1468174590_gnumeric;
            buttonTool22.SharedPropsInternal.AppearancesLarge.Appearance = appearance30;
            buttonTool22.SharedPropsInternal.Caption = "التقارير";
            appearance25.FontData.BoldAsString = "True";
            appearance25.FontData.Name = "Arial Black";
            appearance25.FontData.SizeInPoints = 11F;
            appearance25.Image = global::StudentExam.Properties.Resources._1468606799_tests;
            buttonTool7.SharedPropsInternal.AppearancesLarge.Appearance = appearance25;
            buttonTool7.SharedPropsInternal.Caption = "انشاء أسئلة";
            this.ToolBar_Application.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool19,
            buttonTool20,
            buttonTool21,
            buttonTool22,
            buttonTool7});
            this.ToolBar_Application.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.Toolbar_Application_ToolClick);
            // 
            // _panel1_Toolbars_Dock_Area_Right
            // 
            this._panel1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._panel1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(152, 0);
            this._panel1_Toolbars_Dock_Area_Right.Name = "_panel1_Toolbars_Dock_Area_Right";
            this._panel1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 619);
            this._panel1_Toolbars_Dock_Area_Right.ToolbarsManager = this.ToolBar_Application;
            // 
            // _panel1_Toolbars_Dock_Area_Bottom
            // 
            this._panel1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._panel1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 619);
            this._panel1_Toolbars_Dock_Area_Bottom.Name = "_panel1_Toolbars_Dock_Area_Bottom";
            this._panel1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(152, 0);
            this._panel1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ToolBar_Application;
            // 
            // _panel1_Toolbars_Dock_Area_Top
            // 
            this._panel1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._panel1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._panel1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._panel1_Toolbars_Dock_Area_Top.Name = "_panel1_Toolbars_Dock_Area_Top";
            this._panel1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(152, 0);
            this._panel1_Toolbars_Dock_Area_Top.ToolbarsManager = this.ToolBar_Application;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.PIC_picture);
            this.panel2.Controls.Add(this.radClock1);
            this.panel2.Controls.Add(this.radCalendar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 135);
            this.panel2.TabIndex = 6;
            // 
            // PIC_picture
            // 
            this.PIC_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PIC_picture.BorderShadowColor = System.Drawing.SystemColors.ActiveCaption;
            this.PIC_picture.Image = ((object)(resources.GetObject("PIC_picture.Image")));
            this.PIC_picture.Location = new System.Drawing.Point(270, 5);
            this.PIC_picture.Name = "PIC_picture";
            this.PIC_picture.ScaleImage = Infragistics.Win.ScaleImage.Always;
            this.PIC_picture.Size = new System.Drawing.Size(186, 125);
            this.PIC_picture.TabIndex = 45;
            // 
            // radClock1
            // 
            this.radClock1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.radClock1.Location = new System.Drawing.Point(3, -3);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(136, 136);
            this.radClock1.TabIndex = 5;
            this.radClock1.Text = "radClock1";
            this.radClock1.Value = null;
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.CellMargin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.CellPadding = new System.Windows.Forms.Padding(0);
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(574, 5);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.radCalendar1.Size = new System.Drawing.Size(178, 123);
            this.radCalendar1.TabIndex = 4;
            this.radCalendar1.Text = "radCalendar1";
            // 
            // Timer_MSgCleaner
            // 
            this.Timer_MSgCleaner.Interval = 5000;
            // 
            // PNL_Main
            // 
            this.PNL_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_Main.BackgroundImage")));
            this.PNL_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_Main.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.PNL_Main.Location = new System.Drawing.Point(0, 136);
            this.PNL_Main.Name = "PNL_Main";
            this.PNL_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PNL_Main.Size = new System.Drawing.Size(762, 486);
            this.PNL_Main.TabIndex = 1;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PNL_StatusBar);
            this.Controls.Add(this.PNL_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "FRM_Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "الشاشة الرئيسية";
            this.ThemeName = "Office2010Black";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_StatusBar)).EndInit();
            this.PNL_StatusBar.ResumeLayout(false);
            this.PNL_StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Message)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar_Application)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNL_Main;
        private Telerik.WinControls.UI.RadPanel PNL_StatusBar;
        private Telerik.WinControls.UI.RadStatusStrip STS_Message;
        private Telerik.WinControls.UI.RadLabelElement LBL_Msg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ToolBar_Application;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Top;
        internal System.Windows.Forms.Timer Timer_MSgCleaner;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadClock radClock1;
        internal Infragistics.Win.UltraWinEditors.UltraPictureBox PIC_picture;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
    }
}

