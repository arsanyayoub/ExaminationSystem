using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MainLibrary;
using Telerik.WinControls.UI;
namespace StudentExam
{
    public partial class FRM_Finish : RadForm
    {
        public string message = "";
        public string Username = "";
        public FRM_Finish()
        {
            InitializeComponent();
        }

        private void FRM_Finish_Load(object sender, EventArgs e)
        {
            LBL_UserName.Text = BasicClass.vUsrName;
            LBL_Message.ForeColor = Color.Blue;
            LBL_Message.Text = message;
            Timer_FormTime.Start();
        }

        private void Timer_FormTime_Tick(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

       
    }
}
