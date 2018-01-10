using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainLibrary;

namespace StudentExam
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Intializer init = new Intializer();
                if (init.sRaiseLoginForm() == false)
                {
                    Application.Exit();
                }
                else
                {
                    if (BasicClass.vUsrID != 0 && BasicClass.vRoleID != 0)
                    {
                        // IF Admin Enable All except Exams & create Exam
                        if (BasicClass.vRoleID == 1)
                        {
                            sEnableApplications(true, false, true, false, true);
                        }
                        // IF intructor Enable  Exams & create Exam , Reports
                        else if (BasicClass.vRoleID == 2)
                        {
                            sEnableApplications(false, true, false, true, true);
                        }
                        // IF Student
                        // Enable Exam Only
                        else if (BasicClass.vRoleID == 3)
                        {
                            sEnableApplications(false, false, true, false, false);
                        }
                        sEnableOptions(false, false, false, false);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, this.Name, "FRM_Main_Load");
            }
        }

        private void Toolbar_Options_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {
                Object vFRM_Active = this.ActiveMdiChild;
                if (vFRM_Active != null)
                {
                    switch (e.Tool.Key)
                    {
                        case "BTN_Exit":
                            Application.Exit();
                            break;
                        case "BTN_Delete":
                            ((ICommon)this.ActiveMdiChild).Delete();
                            break;
                        case "BTN_New":
                            ((ICommon)this.ActiveMdiChild).sNew();
                            break;
                        case "BTN_Save":
                            ((ICommon)this.ActiveMdiChild).sSave();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "Toolbar_Options_ToolClick");
            }
        }
        private void Toolbar_Application_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {

            try
            {

                switch (e.Tool.Key)
                {
                    case "BTN_Users":
                    case "BTN_Books":
                        this.IsMdiContainer = true;
                        FRM_Students Form2 = new FRM_Students();
                        Form2.MdiParent = this;
                        Form2.Show();
                        break;
                    case "BTN_Students":
                        this.IsMdiContainer = true;
                        Form1 Form = new Form1();
                        Form.MdiParent = this;
                        Form.Show();
                        break;
                    case "BTN_Reports":
                        break;
                }
            }

            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, this.Name, "Toolbar_Application_ToolClick");
            }
        }
        public void sEnableOptions(bool pNew, bool pDelete, bool pSave, bool pExit)
        {
            try
            {
                Toolbar_Options.Tools["BTN_New"].SharedProps.Enabled = pNew;
                Toolbar_Options.Tools["BTN_Save"].SharedProps.Enabled = pSave;
                Toolbar_Options.Tools["BTN_Delete"].SharedProps.Enabled = pNew;
                Toolbar_Options.Tools["BTN_Exit"].SharedProps.Enabled = pExit;


            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sEnableTool");
            }
        }

        public void sEnableApplications(bool pBooks, bool pStudents, bool pExams, bool pCreateExams, bool pReports)
        {
            try
            {
                ToolBar_Application.Tools["BTN_Books"].SharedProps.Enabled = pBooks;
                ToolBar_Application.Tools["BTN_Students"].SharedProps.Enabled = pStudents;
                ToolBar_Application.Tools["BTN_Exams"].SharedProps.Enabled = pExams;
                ToolBar_Application.Tools["BTN_CreateExam"].SharedProps.Enabled = pCreateExams;
                ToolBar_Application.Tools["BTN_Reports"].SharedProps.Enabled = pReports;

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sEnableTool");
            }
        }
    }
}
