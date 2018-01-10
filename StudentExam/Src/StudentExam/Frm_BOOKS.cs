using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using System.Linq;
using MainLibrary;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace StudentExam
{
    public partial class Frm_BOOKS : Telerik.WinControls.UI.RadForm
    {
        public Frm_BOOKS()
        {
            InitializeComponent();
        }

        string[] vSqlStatment = new string[1];
        public string vFormMode = "NI";
        public string vBookCode = "";
        public bool isFormLoaded = false;
        public int vFRM_recPos = 0;
        private string fGetBookCode(string Type)
        {
            string studentCode = "";
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                vSqlCommand.CommandText = "\n" +
                                   "SELECT ISNULL(Max(convert(decimal , substring(Code,5,11))),0) +1 " + "\n" +
                                   "FROM [Book]" + "\n";
                sqlConnection1.Open();
                studentCode = vSqlCommand.ExecuteScalar().ToString();
                sqlConnection1.Close();
                // vSQLReader.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "fGetStudentCode");
            }
            studentCode = Type + "." + (int.Parse(studentCode) + 1).ToString().PadLeft(6, '0');
            return studentCode;
        }

        private void sSave()
        {
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                string vIsWorking = "";
                string vPersonStatment = null;
                string vPersonAbrev = "";
                
                if (vFormMode == "N")
                {
                    return;
                }
                else if (vFormMode == "U")
                {

                    vPersonStatment = "  Update [Book] Set                                         " + "\n" +
                                                "  Title                 ='" + Strings.Trim(TXT_Title.Text) + "' " + "\n" +
                                                " ,Author             ='" + Strings.Trim(TXT_Author.Text) + "'                   " + "\n" +
                                                " ,Publisher            = '" + Strings.Trim(TXT_Publisher.Text) + "'                               " + "\n" +
                                                " ,SubTitle               ='" + Strings.Trim(TXT_Subtitle.Text) + "' " + "\n" +
                                                " ,Category             ='" + Strings.Trim(TXT_Categ.Text) + "'                   " + "\n" +
                                                " ,Remarks                ='" + Strings.Trim(TXT_Notes.Text) + "'                      " + "\n" +
                                                " ,LastUpdate           = GetDate()                                         " + "\n" +
                                                " ,ProcessID           = '" + Process.GetCurrentProcess().Id.ToString() + "'" + "\n" +
                                                " ,MachineName         ='" + Strings.Trim(System.Environment.MachineName) + "' ";

                    vPersonStatment = vPersonStatment + " Where   Code        ='" + vBookCode + "'";
                }
                else if (vFormMode == "I")
                {
                    string vIsActive = null;
                    string vIsSalesMan = null;
                    vBookCode = string.Format(fGetBookCode("BOK"));
                    this.TXT_Title.Tag = vBookCode.ToString().Trim();
                    TXT_CodeBook .Text = vBookCode;
                    vPersonStatment = "INSERT INTO [Book] " + "( [Code]        ,                [Title]      ,                    [Publisher]                  ,       [SubTitle]          ,          [Category]                  ,        [Remarks]      , LastUpdate  ,               MachineName              ,ProcessID       )" + "\n" +
                        "VALUES " + "                   ( '" + vBookCode + "','" + TXT_Author.Text.Trim() + "','" + TXT_Publisher.Text.Trim() + "','" + TXT_Subtitle.Text.Trim() + "','" + this.TXT_Categ.Text.Trim() + "','" + this.TXT_Notes.Text + "', getDate() ,'" + System.Environment.MachineName.Trim() + "','"+ Process.GetCurrentProcess().Id +"') ";
                }
                sFillSqlStatmentArray(vPersonStatment);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "sSave");
            }
            finally
            {
                if (BasicClass.vSqlConn.State == ConnectionState.Broken || BasicClass.vSqlConn.State == ConnectionState.Open)
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

        
        private void sHandleMessage(int pType)
        {
            try
            {
                //Critical
                if (pType == 1)
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
                vBookCode = "";
                TXT_Title.Tag = "";
                TXT_CodeBook .Text = "";
                isFormLoaded = false;
                vFormMode = "NI";
                TXT_Title.Text = "";
                TXT_Author.Text = "";
                TXT_Publisher.Text = "";
                TXT_Subtitle.Text = "";
                TXT_Categ.Text = "";
                TXT_Notes.Text = "";
                STS_Message.Items["LBL_Msg"].Text = "";
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "New");
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
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "sResetFormMode");
            }
        }

        private bool fValidatePerson()
        {
            bool vReult = false;
            try
            {
                Timer_MSgCleaner.Stop();
                if (TXT_Title.Text.Trim() == "")
                {
                    STS_Message.Items["Msg"].Text = "من فضلك ادخل اسم الكتاب";
                    STS_Message.Items["Msg"].ForeColor = Color.Red;
                    Timer_MSgCleaner.Start();
                    TXT_Title.SelectAll();
                    TXT_Title.Focus();
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
            bool vIsSaved = false;
            long rowsAffected = 0;
            string vGender = "";

            try
            {
                if (pMessage == true)
                {
                    if (MessageBox.Show("هل تريد الحفظ ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (fValidatePerson() == false)
                        {
                            return false;
                        }
                        else
                        {
                            sSave();
                            rowsAffected = BasicClass.fDMLData(vSqlStatment, "Frm_BOOKS");
                            if (rowsAffected > 0)
                            {
                                vIsSaved = true;
                                sNew();
                                sResetFormMode();
                            }
                        }


                    }
                }
                else
                {
                    if (fValidatePerson() == false)
                    {
                        return false;
                    }
                    else
                    {
                        sSave();
                        rowsAffected = BasicClass.fDMLData(vSqlStatment, "Frm_BOOKS");
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
                ExceptionHandler.HandleException(Ex.Message, "Frm_BOOKS", "fSaveData");
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

                if (fIsDataChanged() == true)
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
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "fIsDataChanged");
                return false;
            }

        }
        private void Frm_BOOKS_Load(object sender, EventArgs e)
        {
            try
            {
                sNew();

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "Frm_BOOKS_Load");
            }
        }
        private void Toolbar_Options_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {

                switch (e.Tool.Key)
                {
                    case "BTN_Exit":
                        if (fCancelTransaction() == true)
                        {
                            this.Close();

                        }
                        break;
                    case "BTN_Delete":
                        if (fCancelTransaction() == true)
                        {
                            //Delete();
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
                        if (fSaveData(false) == true)
                        {
                            STS_Message.Items["Msg"].Text = "تم الحفظ بنجاح";
                            STS_Message.Items["Msg"].ForeColor = Color.Green;
                            Timer_MSgCleaner.Start();
                        }
                        break;

                    case "BTN_Next":
                        if (fCancelTransaction() == true)
                        {
                            sNextRecord();
                        }

                        break;
                    case "BTN_Previous":
                        if (fCancelTransaction() == true)
                        {
                            sPreviousRecord();
                        }

                        break;
                }

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "Toolbar_Options_ToolClick");
            }
        }

        private void sNextRecord()
        {

            bool isQueried = false;
            try
            {
               isQueried = sFind(1, false);
                if (isQueried == true)
                {
                    sHandleMessage(7);
                    Timer_MSgCleaner.Start();
                }


            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "Toolbar_Options_ToolClick");
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

                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "Toolbar_Options_ToolClick");
            }
        }



        private void TXT_Title_TextChanged(object sender, EventArgs e)
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

        }
        private string sGetMaxCode()
        {
            string result = "";
            string statment = "";
            try
            {
                statment = "SELECT ISNULL(Max(convert(decimal , substring(Code,5,11))),0) " + "\n" +
                           "FROM [Book]" + "\n";
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
                           "FROM [Book]" + "\n";
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
                string vWhereStmt = "";
                int vfetchRec = 0;
                if (pIsGoTo == false)
                {
                    if (pRecordPosition == 0)
                    {
                        vfetchRec = 1;
                    }
                    else
                    {
                        if (pRecordPosition == -2)
                        {
                            vfetchRec = 1;
                        }
                        else
                        {
                            vfetchRec = pRecordPosition + vFRM_recPos;
                            if (vfetchRec == 0)
                            {
                                vfetchRec = 1;
                            }
                        }

                    }
                }
                else
                {
                    if (pRecordPosition <= BasicClass.fCount_Rec("From [Book]"))
                    {
                        vfetchRec = pRecordPosition;
                    }
                    else
                    {
                        vfetchRec = BasicClass.fCount_Rec("From [Book]");
                    }
                }
                if (vfetchRec == -2)
                {
                    vfetchRec = BasicClass.fCount_Rec("From [Book]");
                }
                vWhereStmt = " And RecPos='" + vfetchRec + "' ";
                vSqlCommand.CommandText = "\n" +
                                   " With MyItems as " + "\n" +
                                   " ( " + "\n" +
                                    "SELECT [ID],[Code],[Title],[Author]										" + "\n" +
                                    "      ,[Publisher],[YER_ID],[SubTitle],[Category],[Remarks]" + "\n" +
                                    ", ROW_NUMBER() over(Order  By [Book].ID) RecPos" + "\n" +
                                    "  FROM [StudentExam].[dbo].[Book]" + "\n" +
                                    " )" + "\n" +
                                    " Select * From MyItems " + "\n" +
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
                       
                            vBookCode = vSQLReader["Code"].ToString();
                            TXT_CodeBook .Text = vSQLReader["Code"].ToString();
                        }

                        else
                        {
                           
                            vBookCode = "";
                            TXT_CodeBook .Text = "";
                        }
                        if (vSQLReader["Title"] != System.DBNull.Value)
                        {
                            TXT_Title.Text = vSQLReader["Title"].ToString();
                        }

                        else
                        {
                            TXT_Title.Text = "";
                        }
                        if (vSQLReader["Author"] != System.DBNull.Value)
                        {
                            TXT_Author.Text = vSQLReader["Author"].ToString();
                        }

                        else
                        {
                            TXT_Author.Text = "";
                        }

                        if (vSQLReader["Publisher"] != System.DBNull.Value)
                        {
                            TXT_Publisher.Text = vSQLReader["Publisher"].ToString();
                        }

                        else
                        {
                            TXT_Publisher.Text = "";
                        }
                        if (vSQLReader["SubTitle"] != System.DBNull.Value)
                        {
                            TXT_Subtitle.Text = vSQLReader["SubTitle"].ToString();
                        }

                        else
                        {
                            TXT_Subtitle.Text = "";
                        }
                        if (vSQLReader["Category"] != System.DBNull.Value)
                        {
                            TXT_Categ.Text = vSQLReader["Category"].ToString();
                        }

                        else
                        {
                            TXT_Categ.Text = "";
                        }
                        if (vSQLReader["Remarks"] != System.DBNull.Value)
                        {
                            TXT_Notes.Text = vSQLReader["Remarks"].ToString();
                        }

                        else
                        {
                            TXT_Notes.Text = "";
                        }

                        if (vSQLReader["ID"] != System.DBNull.Value)
                        {
                            TXT_FindByCode.Text = vSQLReader["ID"].ToString();
                        }

                        else
                        {
                            TXT_FindByCode.Text = "";
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
                ExceptionHandler.HandleException(ex.Message, "Frm_BOOKS", "TXT_FindByCode_Enter");
            }
            return vResult;
        }



        private void Timer_MSgCleaner_Tick(object sender, EventArgs e)
        {
            STS_Message.Items["Msg"].Text = "";
        }

        private void TXT_FindByCode_KeyUp(object sender, KeyEventArgs e)
        {

        }


        //change label Maichael 23 / 8 /2016
        
        private void TXT_Categ_TextChanging(object sender, TextChangingEventArgs e)
        {
            ultraLabel2.Text = TXT_Categ.Text;
        }

        private void TXT_Title_TextChanging(object sender, TextChangingEventArgs e)
        {
            ultraLabel3.Text = TXT_Title.Text;
        }

        private void TXT_Subtitle_TextChanging(object sender, TextChangingEventArgs e)
        {
            ultraLabel4.Text = TXT_Subtitle.Text;
        }

        private void TXT_Publisher_TextChanging(object sender, TextChangingEventArgs e)
        {
            ultraLabel6.Text = TXT_Publisher.Text;
        }

        private void TXT_Author_TextChanging(object sender, TextChangingEventArgs e)
        {
            ultraLabel5.Text = TXT_Author.Text;
        }

      

     
    }
}
