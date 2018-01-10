namespace StudentExam
{
    partial class FRM_Login
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
            this.PNL_Main = new Telerik.WinControls.UI.RadPanel();
            this.LBL_Password = new Telerik.WinControls.UI.RadLabel();
            this.LBL_UserName = new Telerik.WinControls.UI.RadLabel();
            this.TXT_Password = new Telerik.WinControls.UI.RadTextBox();
            this.TXT_UserName = new Telerik.WinControls.UI.RadTextBox();
            this.PNL_Status = new Telerik.WinControls.UI.RadPanel();
            this.STS_Login = new Telerik.WinControls.UI.RadStatusStrip();
            this.BTN_Cancel = new Telerik.WinControls.UI.RadButtonElement();
            this.BTN_Login = new Telerik.WinControls.UI.RadButtonElement();
            this.Msg = new Telerik.WinControls.UI.RadLabelElement();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.Timer_MSgCleaner = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).BeginInit();
            this.PNL_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Status)).BeginInit();
            this.PNL_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Main
            // 
            this.PNL_Main.Controls.Add(this.LBL_Password);
            this.PNL_Main.Controls.Add(this.LBL_UserName);
            this.PNL_Main.Controls.Add(this.TXT_Password);
            this.PNL_Main.Controls.Add(this.TXT_UserName);
            this.PNL_Main.Controls.Add(this.PNL_Status);
            this.PNL_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Main.Location = new System.Drawing.Point(0, 0);
            this.PNL_Main.Name = "PNL_Main";
            this.PNL_Main.Size = new System.Drawing.Size(322, 156);
            this.PNL_Main.TabIndex = 0;
            // 
            // LBL_Password
            // 
            this.LBL_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Password.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Password.Location = new System.Drawing.Point(239, 75);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(77, 23);
            this.LBL_Password.TabIndex = 0;
            this.LBL_Password.Text = "كلمة المرور";
            // 
            // LBL_UserName
            // 
            this.LBL_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_UserName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserName.Location = new System.Drawing.Point(230, 47);
            this.LBL_UserName.Name = "LBL_UserName";
            this.LBL_UserName.Size = new System.Drawing.Size(86, 23);
            this.LBL_UserName.TabIndex = 3;
            this.LBL_UserName.Text = "اسم المستخدم";
            // 
            // TXT_Password
            // 
            this.TXT_Password.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Location = new System.Drawing.Point(24, 73);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_Password.Size = new System.Drawing.Size(203, 24);
            this.TXT_Password.TabIndex = 1;
            this.TXT_Password.TabStop = false;
            this.TXT_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TXT_UserName
            // 
            this.TXT_UserName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_UserName.Location = new System.Drawing.Point(24, 47);
            this.TXT_UserName.Name = "TXT_UserName";
            this.TXT_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_UserName.Size = new System.Drawing.Size(203, 24);
            this.TXT_UserName.TabIndex = 0;
            this.TXT_UserName.TabStop = false;
            this.TXT_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PNL_Status
            // 
            this.PNL_Status.Controls.Add(this.STS_Login);
            this.PNL_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_Status.Location = new System.Drawing.Point(0, 124);
            this.PNL_Status.Name = "PNL_Status";
            this.PNL_Status.Size = new System.Drawing.Size(322, 32);
            this.PNL_Status.TabIndex = 0;
            // 
            // STS_Login
            // 
            this.STS_Login.AutoSize = true;
            this.STS_Login.ForeColor = System.Drawing.Color.SlateGray;
            this.STS_Login.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.BTN_Cancel,
            this.BTN_Login,
            this.Msg});
            this.STS_Login.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.STS_Login.Location = new System.Drawing.Point(0, 3);
            this.STS_Login.Name = "STS_Login";
            this.STS_Login.Size = new System.Drawing.Size(322, 29);
            this.STS_Login.TabIndex = 0;
            this.STS_Login.Text = "radStatusStrip1";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AccessibleDescription = "الغاء";
            this.BTN_Cancel.AccessibleName = "الغاء";
            this.BTN_Cancel.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Cancel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.RightToLeft = true;
            this.STS_Login.SetSpring(this.BTN_Cancel, false);
            this.BTN_Cancel.Text = "الغاء";
            this.BTN_Cancel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Login
            // 
            this.BTN_Login.AccessibleDescription = "دخول";
            this.BTN_Login.AccessibleName = "دخول";
            this.BTN_Login.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Login.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.RightToLeft = true;
            this.STS_Login.SetSpring(this.BTN_Login, false);
            this.BTN_Login.Text = "دخول";
            this.BTN_Login.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // Msg
            // 
            this.Msg.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Msg.Name = "Msg";
            this.Msg.RightToLeft = true;
            this.STS_Login.SetSpring(this.Msg, true);
            this.Msg.Text = "";
            this.Msg.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.Msg.TextWrap = true;
            this.Msg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Timer_MSgCleaner
            // 
            this.Timer_MSgCleaner.Interval = 5000;
            this.Timer_MSgCleaner.Tick += new System.EventHandler(this.Timer_MSgCleaner_Tick);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 156);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تسجيل الدخول";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).EndInit();
            this.PNL_Main.ResumeLayout(false);
            this.PNL_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Status)).EndInit();
            this.PNL_Status.ResumeLayout(false);
            this.PNL_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STS_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNL_Main;
        private Telerik.WinControls.UI.RadPanel PNL_Status;
        private Telerik.WinControls.UI.RadLabel LBL_Password;
        private Telerik.WinControls.UI.RadLabel LBL_UserName;
        private Telerik.WinControls.UI.RadTextBox TXT_Password;
        private Telerik.WinControls.UI.RadTextBox TXT_UserName;
        private Telerik.WinControls.UI.RadStatusStrip STS_Login;
        private Telerik.WinControls.UI.RadButtonElement BTN_Cancel;
        private Telerik.WinControls.UI.RadButtonElement BTN_Login;
        private Telerik.WinControls.UI.RadLabelElement Msg;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        internal System.Windows.Forms.Timer Timer_MSgCleaner;
    }
}