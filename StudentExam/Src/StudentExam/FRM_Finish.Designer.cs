namespace StudentExam
{
    partial class FRM_Finish
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_Message = new Telerik.WinControls.UI.RadLabel();
            this.LBL_UserName = new Telerik.WinControls.UI.RadLabel();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.Timer_FormTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).BeginInit();
            this.PNL_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Main
            // 
            this.PNL_Main.Controls.Add(this.pictureBox1);
            this.PNL_Main.Controls.Add(this.LBL_Message);
            this.PNL_Main.Controls.Add(this.LBL_UserName);
            this.PNL_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Main.Location = new System.Drawing.Point(0, 0);
            this.PNL_Main.Name = "PNL_Main";
            this.PNL_Main.Size = new System.Drawing.Size(322, 156);
            this.PNL_Main.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::StudentExam.Properties.Resources._1448740697_Check;
            this.pictureBox1.Location = new System.Drawing.Point(263, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 56);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_Message
            // 
            this.LBL_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Message.AutoSize = false;
            this.LBL_Message.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Message.Location = new System.Drawing.Point(2, 48);
            this.LBL_Message.Name = "LBL_Message";
            this.LBL_Message.Size = new System.Drawing.Size(246, 42);
            this.LBL_Message.TabIndex = 4;
            this.LBL_Message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_UserName
            // 
            this.LBL_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_UserName.AutoSize = false;
            this.LBL_UserName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserName.Location = new System.Drawing.Point(2, 3);
            this.LBL_UserName.Name = "LBL_UserName";
            this.LBL_UserName.Size = new System.Drawing.Size(316, 34);
            this.LBL_UserName.TabIndex = 3;
            this.LBL_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_FormTime
            // 
            this.Timer_FormTime.Interval = 5000;
            this.Timer_FormTime.Tick += new System.EventHandler(this.Timer_FormTime_Tick);
            // 
            // FRM_Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 156);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Finish";
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "معلومات";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.FRM_Finish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PNL_Main)).EndInit();
            this.PNL_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNL_Main;
        private Telerik.WinControls.UI.RadLabel LBL_UserName;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel LBL_Message;
        internal System.Windows.Forms.Timer Timer_FormTime;
    }
}