using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainLibrary;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;
namespace StudentExam
{
    public partial class FRM_Questions : RadForm
    {
        public FRM_Questions()
        {
            InitializeComponent();
        }
        string[] vSqlStatment = new string[1];
        public string vFormMode = "NI";
        public string vQuestionCode = "";
        public bool isFormLoaded = false;
        public int vFRM_recPos = 0;
        private string fGetQuestionCode(string Type)
        {
            string questCode = "";
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                vSqlCommand.CommandText = "\n" +
                                   "SELECT ISNULL(Max(convert(decimal , substring(Code,5,11))),0) +1 " + "\n" +
                                   "FROM [Question]" + "\n";
                sqlConnection1.Open();
                questCode = vSqlCommand.ExecuteScalar().ToString();
                sqlConnection1.Close();
               // vSQLReader.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "fGetQuestionCode");
            }
            questCode = Type + "." + (int.Parse(questCode) + 1).ToString().PadLeft(6, '0');
          return  questCode;
        }

        private void sSave()
        {
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                string vIsWorking = "";
                string vQuestionStatment = null;
                string vBook = "";
                string vCorrectAnswer = "";
                string vQuestionAbrev ="";
                if (TXT_Book.SelectedIndex !=-1)
                {
                    vBook = "'" + TXT_Book.SelectedItem.DataValue.ToString().Trim() + "'";
                }
                else
                {
                    vBook = "NULL";
                }
                if (TXT_Book.SelectedIndex != -1)
                {
                    vBook = "'" + TXT_Book.SelectedItem.DataValue.ToString().Trim() + "'";
                }
                else
                {
                    vBook = "NULL";
                }

                if (TXT_CorrectAnswer.SelectedIndex != -1)
                {
                    vCorrectAnswer = "'" + TXT_CorrectAnswer.SelectedItem.DataValue.ToString().Trim() + "'";
                }
                else
                {
                    vCorrectAnswer = "NULL";
                }
                if (vFormMode == "N")
                {
                    return;
                }
                else if (vFormMode == "U")
                {
                    vQuestionStatment = "  Update [Question] Set                                         " + "\n" +
                                                "  Description          ='" + Strings.Trim(TXT_Description.Text) + "' " + "\n" +
                                                " ,Option1             ='" + Strings.Trim(TXT_Option1.Text) + "'                   " + "\n" +
                                                " ,Option2             ='" + Strings.Trim(TXT_Option2.Text) + "'                   " + "\n" +
                                                " ,Option3             ='" + Strings.Trim(TXT_Option3.Text) + "'                   " + "\n" +
                                                " ,Option4             ='" + Strings.Trim(TXT_Option4.Text) + "'                   " + "\n" +
                                                " ,CorrectAnswer       =" + vCorrectAnswer + "                   " + "\n" +
                                                " ,BOK_ID               =" + vBook + "                   " + "\n" +
                                                " ,LastUpdate           = GetDate()                                         " + "\n" +
                                                " ,ProcessID           = '"+ Process.GetCurrentProcess().Id.ToString()    +"'" + "\n" +
                                                " , MachineName         ='" + Strings.Trim(System.Environment.MachineName) + "' ";

                    vQuestionStatment = vQuestionStatment + " Where   Code        ='" + vQuestionCode + "'";
                }
                else if (vFormMode == "I")
                {
                    string vIsActive = null;
                    string vIsSalesMan = null;
                    vQuestionCode =string.Format(fGetQuestionCode("QST"));
                    this.TXT_Code.Tag = vQuestionCode.ToString().Trim();
                    TXT_Code.Text = vQuestionCode;
                    vQuestionStatment = "INSERT INTO [Question] " + "( [Code]        ,                [Description]      ,                    [Option1]                  ,       [Option2]          ,          [Option3]                   ,               [Option4]      ,         [CorrectAnswer]     ,LastUpdate  ,               MachineName                   ,       BOK_ID )" + "\n" +
                        "VALUES " + "                           ( '" + vQuestionCode + "','" + TXT_Description.Text.Trim() + "','" + TXT_Option1.Text.Trim() + "','" + TXT_Option2.Text.Trim() + "','" + this.TXT_Option3.Text.Trim() + "','" + this.TXT_Option4.Text.Trim() + "'," + vCorrectAnswer + ", getDate() ,'" + System.Environment.MachineName.Trim() + "'," + vBook +") ";
                }
                sFillSqlStatmentArray(vQuestionStatment);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "sSave");
            }
            finally
            {
                if (BasicClass.vSqlConn.State ==ConnectionState.Broken || BasicClass.vSqlConn.State == ConnectionState.Open)
                {
                    BasicClass.vSqlConn.Close();
                }
            }
        }

        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================


        private void sFillSqlStatmentArray(string pStatment)
        {
            //here I fill the Array to send it to transaction
            if (string.IsNullOrEmpty(vSqlStatment[Information.UBound(vSqlStatment)]))
            {
                vSqlStatment[Information.UBound(vSqlStatment)] = pStatment;
            }
            else
            {
                Array.Resize(ref vSqlStatment, Information.UBound(vSqlStatment) + 2);
                vSqlStatment[Information.UBound(vSqlStatment)] = pStatment;
            }
        }

        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================


        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================

        public void Delete()
        {
            MessageBox.Show("Delete``````");
        }
        public void Find()
        {
            MessageBox.Show("Find``````");
        }
        private void sHandleMessage(int pType)
        {
            try
            {
                //Critical
                if (pType ==1)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Red;
                }
                //Warning
                else if (pType == 2)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Navy;
                }
                //Done
                else if (pType == 3)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Green;
                }
                //'Save
                else if (pType == 4)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Blue;
                    this.STS_Message.Items["Msg"].Text = "....... تم الحفظ بنجاح";
                }
                //''Assistant
                else if (pType == 5)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Black;
                }


                else if (pType == 6)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Red;
                    this.STS_Message.Items["Msg"].Text = "";
                }

                //''QUERY
                else if (pType == 7)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Blue;
                    this.STS_Message.Items["Msg"].Text = "....... تم الاستعلام بنجاح";
                }

               //''FirstRecord
                else if (pType == 8)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Blue;
                    this.STS_Message.Items["Msg"].Text = "....... اول سجل";
                }
                 //''LastRecord
                else if (pType == 9)
                {
                    this.STS_Message.Items["Msg"].ForeColor = System.Drawing.Color.Blue;
                    this.STS_Message.Items["Msg"].Text = "....... اخر سجل";
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        public void sNew()
        {
            try
             {
                 Timer_MSgCleaner.Stop();
                 vQuestionCode = "";
                 TXT_Code.Tag = "";
                 TXT_Code.Text = "";
                isFormLoaded = false;
                vFormMode = "NI";
                TXT_FindByCode.Text="";
                TXT_Code.Text = "";
                TXT_Description.Text = "";
                TXT_Option1.Text = "";
                TXT_Option2.Text = "";
                TXT_Option3.Text = "";
                TXT_Option4.Text = "";
                TXT_CorrectAnswer.SelectedIndex =-1;
               TXT_Book.SelectedIndex = -1;
                STS_Message.Items["Msg"].Text = "";
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "sNew");
            }
        }
        private void sResetFormMode()
        {
            try
            {
                vFormMode = "N";
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "sResetFormMode");
            }
        }
        private bool fValidateQuestion()
        {
            bool vReult = false;
            try 
	            {
                   
                    Timer_MSgCleaner.Stop();                    
                    
                    if (TXT_Book.SelectedIndex == -1)
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك اختار الكتاب";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Book.SelectAll();
                        TXT_Book.Focus();
                        return false;
                    }
                    if (TXT_Description.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل بيانات السؤال";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Description.SelectAll();
                        TXT_Description.Focus();
                        return false;
                    }
                    if (TXT_Option1.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل بيانات الإجابة الاولى";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Option1.SelectAll();
                        TXT_Option1.Focus();
                        return false;
                    }
                    if (TXT_Option2.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل بيانات الإجابة الثانية";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Option2.SelectAll();
                        TXT_Option2.Focus();
                        return false;
                    }
                    if (TXT_CorrectAnswer.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك اختار الاجابة الصحيحة";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_CorrectAnswer.SelectAll();
                        TXT_CorrectAnswer.Focus();
                        return false;
                    }
                   
                   	            }
	            catch (Exception ex)
	            {
                    ExceptionHandler.HandleException(ex.Message, this.Name, "fValidatePerson");
	            }
            return true;
        }
        private bool fSaveData(bool pMessage)
        {
            bool vIsSaved  =false;
            long rowsAffected = 0;
            string vGender = "";

            try
            {
                if (pMessage == true)
	            {
		             if (MessageBox.Show("هل تريد الحفظ ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.Yes)
	                    {
                            if (fValidateQuestion()==false)
                            {
                                return false;
                            }
                            else
                            {
                                sSave();
                                rowsAffected = BasicClass.fDMLData(vSqlStatment, "FRM_Questions");
                                if (rowsAffected > 0)
                                {

                                    if (Strings.Trim(this.OpnDlg_Picture.FileName).Length > 0)
                                    {
                                        rowsAffected += BasicClass.fAttachImage(Strings.Trim(this.OpnDlg_Picture.FileName), "[Question]", "Picture", " Where Code           ='" + Strings.Trim(vQuestionCode) + "'", this.Name);
                                        this.OpnDlg_Picture.FileName = null;
                                    }
                                    vIsSaved = true;
                                    sNew();
                                    sResetFormMode();
                                }
                            }
                               
           
	                    }
	            }
                    else
                	{
                        if (fValidateQuestion() == false)
                        {
                            return false;
                        }
                        else
                        {
                            sSave();
                            rowsAffected = BasicClass.fDMLData(vSqlStatment, "FRM_Questions");
                            if (rowsAffected > 0)
                            {
                                vIsSaved = true;
                                sNew();
                                sResetFormMode();
                            }
                        }
	               }
                sEmptySqlStatmentArray();
                
            }
            catch (Exception Ex)
            {
                ExceptionHandler.HandleException(Ex.Message, "FRM_Questions", "fSaveData");
            }
            return vIsSaved;
        }
        private void sEmptySqlStatmentArray()
        {
            vSqlStatment = new string[1];
        }
        private bool fCancelTransaction()
        {
    try
            {
              
                if (fIsDataChanged() ==true)
                {
                    if (MessageBox.Show("هل تريد إلغاء التغييرات الحالية", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.Yes)
                    {
                        sNew();
                        return true;
                    }
                    else
                    {
                        return false;
                    }   
                }
                
                    //End If
                  return true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, this.Name, "fAppExitValidation");
                return false;
            }
        }
        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================
        private bool fIsDataChanged()
        {
            try
            {
                if (vFormMode == "I" || vFormMode.Trim().ToUpper() == "U")
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "fIsDataChanged");
                return false;
            }

        }
        private void FRM_Questions_Load(object sender, EventArgs e)
        {
            try

            {
                sNew();
                 sFillBooks();
                              
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "FRM_Questions_Load");
            }
        }
        private void Toolbar_Options_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {

                switch (e.Tool.Key)
                {
                    case "BTN_Exit":
                        if (fCancelTransaction() ==true)
                        {
                            this.Close();
                       
                        }
                        break;
                    case "BTN_Delete":
                        if (fCancelTransaction()==true)
                        {
                          Delete();  
                        }
                       
                        break;
                    case "BTN_New":
                        if (fCancelTransaction() == true)
                        {
                           sNew(); 
                        }
                        
                        break;
                    case "BTN_Save":
                        Timer_MSgCleaner.Stop();
                        if (fSaveData(false) ==true)
                        {
                            STS_Message.Items["Msg"].Text = "تم الحفظ بنجاح";
                            STS_Message.Items["Msg"].ForeColor = Color.Green;
                            Timer_MSgCleaner.Start();
                        }
                        //////else
                        //////{
                        //////    STS_Message.Items["Msg"].Text = "خطأ فى الحفظ";
                        //////    STS_Message.Items["Msg"].ForeColor = Color.Red;
                        //////    Timer_MSgCleaner.Start();
                        //////}
                        break;

                    case "BTN_Next":
                        if (fCancelTransaction()==true)
                        {
                            sNextRecord();
                        }
                        
                        break;
                    case "BTN_Previous":
                        if (fCancelTransaction()==true)
                        {
                            sPreviousRecord();
                        }
                       
                        break;
                       }

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "Toolbar_Options_ToolClick");
            }
        }
        private void sNextRecord()
        {
            
            bool isQueried = false;
            try
            {
                     sFind(1,false);
                    if (isQueried ==true)
                    {
                        sHandleMessage(7);
                        Timer_MSgCleaner.Start();
                    }
                    
               
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "Toolbar_Options_ToolClick");
            }
        }
        private void sPreviousRecord()
        {

            bool isQueried = false;
            try
            {
                sFind(-1, false);
                if (isQueried == true)
                {
                    sHandleMessage(7);
                    Timer_MSgCleaner.Start();
                }


            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "Toolbar_Options_ToolClick");
            }
        }
        private void sFillBooks()
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                // Here i open connection to databse and execute command to get roles to fill dropdown list
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                vSqlCommand.CommandText = "\n" +
                                   "select Book.ID as BookID , Book.Title as Title" + "\n" +
                                   "from Book";
                sqlConnection1.Open();
                vSQLReader = vSqlCommand.ExecuteReader();
                while (vSQLReader.Read())
                {
                    if (vSQLReader["BookID"] != System.DBNull.Value)
                    {
                        TXT_Book.Items.Add(vSQLReader["BookID"].ToString(), vSQLReader["Title"].ToString());
                    }
                   
                }
                vSQLReader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "sFillBooks");
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Broken || sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }
        private void TXT_Description_TextChanged(object sender, EventArgs e)
        {
            if (vFormMode.Trim().ToUpper() == "NI")
            {
                vFormMode = "I";
            }
            else if (vFormMode.Trim().ToUpper() == "N")
            {
                vFormMode = "U";
            }
        }

        private void TXT_FindByCode_Enter(object sender, EventArgs e)
        {
            try
            {
                if (TXT_FindByCode.Text.Trim()!="" && TXT_FindByCode.Text.Trim().Length == 8)
                {
                    sFind(int.Parse(TXT_FindByCode.Text.Trim()),true);
                }
            }
            catch (Exception ex)
            {
                
                ExceptionHandler.HandleException(ex.Message,"FRM_Questions","TXT_FindByCode_Enter");
            }
        }
        private string sGetMaxCode()
        {
            string result = "";
            string statment = "";
            try
            {
                statment = "SELECT ISNULL(Max(convert(decimal , substring(Code,5,11))),0) " + "\n" +
                           "FROM [Question]" + "\n";
                result = BasicClass.fReturnScalar(statment, this.Name);
              
                
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sGetMaxCode");
                result = "";
            }
            return result;
        }
        private string sGetMinCode()
        {
            string result = "";
            string statment = "";
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                statment = "SELECT ISNULL(Min(convert(decimal , substring(Code,5,11))),0) " + "\n" +
                           "FROM [Question]" + "\n";
                result = BasicClass.fReturnScalar(statment, this.Name);
                

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sGetMinCode");
                result = "";
            }
            return result;
        }
        private bool sFind(int pRecordPosition, bool pIsGoTo)
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            string vRoleID = "";
            string vYearID = "";
            string vGender = "";
            bool vResult = false;

            try
            {
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                string vWhereStmt ="";
                int vfetchRec =0 ;
                if (pIsGoTo ==false)
	            {
		             if ( pRecordPosition == 0)
	                    {
		                    vfetchRec =1;
	                    } 
                    else
	                    {
                         if (pRecordPosition==-2)
	                    {
		                      vfetchRec =1;
	                    }
                         else
	                    {
                            vfetchRec = pRecordPosition + vFRM_recPos;
                            if (vfetchRec ==0)
	                    {
		                     vfetchRec=1;
	                    }
	                    }

	                    }
	            }
                else
	                {
                       if ( pRecordPosition <= BasicClass.fCount_Rec("FROM [Question]"))
	                {
		                     vfetchRec = pRecordPosition;
	                }
                    else
	                    {
                                               vfetchRec = BasicClass.fCount_Rec("FROM [Question]");
	                    }
	                }
                if (vfetchRec == -2) {
                vfetchRec = BasicClass.fCount_Rec("FROM [Question]");
                }
                vWhereStmt = " And RecPos='" + vfetchRec + "' ";
                     vSqlCommand.CommandText = "\n" +
                                        " With MyItems as " +"\n" +
                                        " ( " +"\n" +
                                         "SELECT [ID],[Code],[Description],[BOK_ID]										" + "\n" +
                                         "      ,[Option1],[Option2],[Option3],[Option4],[CorrectAnswer]" + "\n" +
                                         ", ROW_NUMBER() over(Order  By [Question].ID) RecPos" + "\n" +
                                         "  FROM [dbo].[Question]" + "\n" +
                                         " )" + "\n" +
                                         " Select * From MyItems " +"\n"+
                                         "  WHERE 1=1" + "\n" +
                                         vWhereStmt;

                     sqlConnection1.Open();
                     vSQLReader = vSqlCommand.ExecuteReader();
                if (vSQLReader.HasRows == true)
	{
        while (vSQLReader.Read())
        {
            if (vSQLReader["Code"] != System.DBNull.Value)
            {
                
                vQuestionCode = vSQLReader["Code"].ToString();
                TXT_Code.Text = vSQLReader["Code"].ToString();
            }

            else
            {
                vQuestionCode = "";
                TXT_Code.Text = "";
            }
            if (vSQLReader["Description"] != System.DBNull.Value)
            {
                TXT_Description.Text = vSQLReader["Description"].ToString();
            }

            else
            {
                TXT_Description.Text = "";
            }
            if (vSQLReader["Option1"] != System.DBNull.Value)
            {
                TXT_Option1.Text = vSQLReader["Option1"].ToString();
            }

            else
            {
                TXT_Option1.Text = "";
            }

            if (vSQLReader["Option2"] != System.DBNull.Value)
            {
                TXT_Option2.Text = vSQLReader["Option2"].ToString();
            }

            else
            {
                TXT_Option2.Text = "";
            }

            if (vSQLReader["Option3"] != System.DBNull.Value)
            {
                TXT_Option3.Text = vSQLReader["Option3"].ToString();
            }

            else
            {
                TXT_Option3.Text = "";
            }
            if (vSQLReader["Option4"] != System.DBNull.Value)
            {
                TXT_Option4.Text = vSQLReader["Option4"].ToString();
            }

            else
            {
                TXT_Option4.Text = "";
            }
            if (vSQLReader["BOK_ID"] != System.DBNull.Value)
            {
                foreach (var item in TXT_Book.Items)
                {
                    if (item.DataValue.ToString().Trim() == vSQLReader["BOK_ID"].ToString().Trim())
                    {
                        TXT_Book.SelectedItem = item;
                        break;
                    }
                }
            }

            else
            {
                TXT_Book.SelectedIndex = -1;
            }
            if (vSQLReader["CorrectAnswer"] != System.DBNull.Value)
            {
                TXT_CorrectAnswer.SelectedIndex =int.Parse( vSQLReader["CorrectAnswer"].ToString()) -1;
            }

            else
            {
                TXT_CorrectAnswer.SelectedIndex = -1;
            }

            if (vSQLReader["ID"] != System.DBNull.Value)
            {
                TXT_FindByCode.Text = vSQLReader["ID"].ToString();
                TXT_Code.Tag = vSQLReader["ID"].ToString();
            }

            else
            {
                TXT_FindByCode.Text = "";
                TXT_Code.Tag = "";
            }
                      

            if (vSQLReader["RecPos"] != System.DBNull.Value)
            {
                vFRM_recPos = int.Parse(vSQLReader["RecPos"].ToString());
                TXT_FindByCode.Text = vFRM_recPos.ToString();
            }

            else
            {
                TXT_FindByCode.Text = "0";
                vFRM_recPos = 0;
            }



            if (vSQLReader["BOK_ID"] != System.DBNull.Value)
            {
                foreach (var item in TXT_Book.Items)
                {
                    if (item.DataValue.ToString().Trim() == vSQLReader["BOK_ID"].ToString().Trim())
                    {
                        TXT_Book.SelectedItem = item;
                        break;
                    }
                }
            }

            else
            {
                TXT_Book.SelectedIndex = -1;
            }
           
        }
        vSQLReader.Close();
        sqlConnection1.Close();
        vResult = true;
        vFormMode = "N";
	}
                   
                else
                {
                    sNew();
                }
                
            }
            catch (Exception ex)
            {
                vResult = false;
                ExceptionHandler.HandleException(ex.Message, "FRM_Questions", "TXT_FindByCode_Enter");
            }
            return vResult;
        }


        private void Timer_MSgCleaner_Tick(object sender, EventArgs e)
        {
            STS_Message.Items["Msg"].Text = "";
        }

        private void TXT_FindByCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TXT_FindByCode.Text.Trim() !="" )
                {
                    sFind(int.Parse(TXT_FindByCode.Text.Trim()),true);
                }
                
            }
        }

      
    }
}
