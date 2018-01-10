using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace StudentExam
{
    public partial class Attention : Telerik.WinControls.UI.RadForm
    {
        public Attention()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string visExamTaken = BasicClass.fReturnScalar("SELECT ISNULL(IsExamTaken,'N') from [User] WHERE ID =" + BasicClass.vUsrID + " ", this.Name);
            if (visExamTaken.Trim().ToUpper() == "Y")
            {
                MessageBox.Show("هذا المستخدم قام بتأدية ذلك الامتحان من قبل", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
             }
            else
            {
                this.IsMdiContainer = true;
                FRM_Exam vFrm_Exam = new FRM_Exam();
                vFrm_Exam.ShowDialog();
            }
        }
    }
}
