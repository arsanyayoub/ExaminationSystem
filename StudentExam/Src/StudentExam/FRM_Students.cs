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
   public partial class FRM_Students : RadForm
    {
        public FRM_Students()
        {
            InitializeComponent();
        }
        string[] vSqlStatment = new string[1];
        public string vFormMode = "NI";
        public string vPersonCode = "";
        public bool isFormLoaded = false;
        public int vFRM_recPos = 0;
        private string fGetUserCode(string Type)
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
                                   "FROM [User]" + "\n";
                sqlConnection1.Open();
                studentCode = vSqlCommand.ExecuteScalar().ToString();
                sqlConnection1.Close();
               // vSQLReader.Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "fGetStudentCode");
            }
            studentCode = Type + "." + (int.Parse(studentCode) + 1).ToString().PadLeft(6, '0');
          return  studentCode;
        }

        private void sSave()
        {
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                string vIsWorking = "";
                string vPersonStatment = null;
                string vGeder = "";
                string vYear = "";
                string vRole = "";
                string vPersonAbrev ="";
                if (TXT_Gender.SelectedIndex !=-1)
                {
                    vGeder = "'" + TXT_Gender.SelectedItem.DataValue.ToString().Trim() + "'";
                }
                else
                {
                    vGeder = "NULL";
                }
                if (TXT_Year.SelectedIndex != -1)
                {
                    vYear = "'" + TXT_Year.SelectedItem.DataValue.ToString().Trim() + "'";
                }
                else
                {
                    vYear = "NULL";
                }
                if (TXT_Role.SelectedIndex != -1)
                {
                    vRole = "'" + TXT_Role.SelectedItem.DataValue.ToString().Trim() + "'";
                    if (TXT_Role.SelectedItem.DataValue.ToString() == "3")
                    {
                        vPersonAbrev = "ST";
                    }
                    else
                    {
                        vPersonAbrev = "PR";
                    }
                }
                else
                {
                    vRole = "NULL";
                }
                if (vFormMode == "N")
                {
                    return;
                }
                else if (vFormMode == "U")
                {
                    vPersonStatment = "  Update [User] Set                                         " + "\n" +
                                                "  Name                 ='" + Strings.Trim(TXT_Name.Text) + "' " + "\n" +
                                                " ,UserName             ='" + Strings.Trim(TXT_UseName.Text) + "'                   " + "\n" +
                                                " ,Password             ='" + TXT_Password.Text + "'" + "\n" +
                                                " ,Education            = '" + Strings.Trim(TXT_Education.Text) + "'                               " + "\n" +
                                                " ,EMail               ='" + Strings.Trim(TXT_Email.Text) + "' " + "\n" +
                                                " ,Facebook             ='" + Strings.Trim(TXT_Facebook.Text) + "'                   " + "\n" +
                                                " ,YER_ID               =" + vYear + "                   " + "\n" +
                                                " ,City                 ='" + Strings.Trim(TXT_City.Text) + "'                      " + "\n" +
                                                " ,RoleID               =" + vRole + "                      " + "\n" +
                                                " ,Address              ='" + Strings.Trim(TXT_Address.Text) + "'                   " + "\n" +
                                                " ,Gender               =" + vGeder + "                     " + "\n" +
                                                " ,Age                  =" + TXT_Age.Value + "                     " + "\n" +
                                                " ,Status               ='Y'                     " + "\n" +
                                                " ,LastUpdate           = GetDate()                                         " + "\n" +
                                                " ,ProcessID           = '"+ Process.GetCurrentProcess().Id.ToString()    +"'" + "\n" +
                                                " , MachineName         ='" + Strings.Trim(System.Environment.MachineName) + "' ";

                    vPersonStatment = vPersonStatment + " Where   Code        ='" + vPersonCode + "'";
                }
                else if (vFormMode == "I")
                {
                    string vIsActive = null;
                    string vIsSalesMan = null;
                    vPersonCode =string.Format(fGetUserCode("USR"));
                    this.TXT_Name.Tag = vPersonCode.ToString().Trim();
                    TXT_Code.Text = vPersonCode;
                    vPersonStatment = "INSERT INTO [User] " + "( [Code]        ,                [Name]      ,                    [UserName]                  ,       [Education]          ,          [City]                   ,               [Address]      ,         [Facebook]                 ,        [Email]         ,          [Password]          ,LastUpdate  ,               MachineName                     ,       RoleID ,       YER_ID   , Gender   ,   Age    , Type ,Status,IsInstructor)" + "\n" +
                        "VALUES " + "                           ( '" + vPersonCode + "','" + TXT_Name.Text.Trim() + "','" + TXT_UseName.Text.Trim() + "','" + TXT_Education.Text.Trim() + "','" + this.TXT_City.Text.Trim() + "','" + this.TXT_Address.Text + "','" + this.TXT_Facebook.Text + "','" + this.TXT_Email.Text + "','" + TXT_Password.Text + "', getDate() ,'" + System.Environment.MachineName.Trim() + "'," +  vRole     + "," +  vYear  + ","+ vGeder + ","+ TXT_Age.Value+ ",'S' ,'Y','N') ";
                }
                sFillSqlStatmentArray(vPersonStatment);

            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "sSave");
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
                 vPersonCode = "";
                 TXT_Name.Tag = "";
                 TXT_Code.Text = "";
                isFormLoaded = false;
                vFormMode = "NI";
                TXT_FindByCode.Text="";
                TXT_Name.Text = "";
                TXT_UseName.Text = "";
                TXT_Password.Text = "";
                TXT_Age.Value = 0;
                TXT_City.Text = "";
                TXT_ConfirmPassword.Text = "";
                TXT_Education.Text = "";
                TXT_Facebook.Text = "";
                TXT_Email.Text = "";
                TXT_Address.Text = "";
                TXT_Gender.SelectedIndex = -1;
                TXT_Role.SelectedIndex = -1;
                TXT_Year.SelectedIndex = -1;
                STS_Message.Items["Msg"].Text = "";
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "New");
            }
        }
        public void sFillGender()
        {
            try
            {
                TXT_Gender.Items.Clear();
                TXT_Gender.Items.Add("M", "ذكر");
                TXT_Gender.Items.Add("F", "انثى");
            }
            catch (Exception ex)
            {
              ExceptionHandler.HandleException(ex.Message, "FRM_Students", "sFillGender");
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
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "sResetFormMode");
            }
        }
        private bool fValidatePerson()
        {
            bool vReult = false;
            try 
	            {
                    Regex regEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?
      \^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                    Timer_MSgCleaner.Stop();
                    if (TXT_Name.Text.Trim()=="")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل الاسم";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Name.SelectAll(); 
                        TXT_Name.Focus();
                        return false;
                    }
                    //if (TXT_Address.Text.Trim() == "")
                    //{
                    //    STS_Message.Items["Msg"].Text = "من فضلك ادخل العنوان";
                    //    STS_Message.Items["Msg"].ForeColor = Color.Red;
                    //    Timer_MSgCleaner.Start();
                    //    TXT_Address.SelectAll();
                    //    TXT_Address.Focus();
                    //    return false;
                    //}

                    //if (TXT_City.Text.Trim() == "")
                    //{
                    //    STS_Message.Items["Msg"].Text = "من فضلك ادخل المحافظة";
                    //    STS_Message.Items["Msg"].ForeColor = Color.Red;
                    //    Timer_MSgCleaner.Start();
                    //    TXT_Name.SelectAll();
                    //    TXT_Name.Focus();
                    //    return false;
                    //}
                    //if (TXT_Year.SelectedIndex == -1)
                    //{
                    //    STS_Message.Items["Msg"].Text = "من فضلك اختار السنة الدراسية";
                    //    STS_Message.Items["Msg"].ForeColor = Color.Red;
                    //    Timer_MSgCleaner.Start();
                    //    TXT_Year.SelectAll();
                    //    TXT_Year.Focus();
                    //    return false;
                    //}
                    //if (TXT_Age.Value == "")
                    //{
                    //    STS_Message.Items["Msg"].Text = "من فضلك اختار السن";
                    //    STS_Message.Items["Msg"].ForeColor = Color.Red;
                    //    Timer_MSgCleaner.Start();
                    //    TXT_Age.SelectAll();
                    //    TXT_Age.Focus();
                    //    return false;
                    //}
                    if (TXT_Role.SelectedIndex == -1)
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك اختار طبيعة العمل";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Role.SelectAll();
                        TXT_Role.Focus();
                        return false;
                    }
                    if (TXT_UseName.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل اسم المستخدم";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_UseName.SelectAll();
                        TXT_UseName.Focus();
                        return false;
                    }
                    if (TXT_Password.Text.Trim() == "")
                    {
                        STS_Message.Items["Msg"].Text = "من فضلك ادخل كلمة المرور";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_Password.SelectAll();
                        TXT_Password.Focus();
                        return false;
                    }
                    if (TXT_Password.Text.Trim() != TXT_ConfirmPassword.Text.Trim())
                    {
                        STS_Message.Items["Msg"].Text = "كلمة المرور / تأكيد كلمة المرور غير متطابقين ";
                        STS_Message.Items["Msg"].ForeColor = Color.Red;
                        Timer_MSgCleaner.Start();
                        TXT_ConfirmPassword.SelectAll();
                        TXT_ConfirmPassword.Focus();
                        return false;
                    }
                    if (TXT_Email.Text.Trim() != "")
                    {
                       if (!regEmail.IsMatch(TXT_Email.Text.Trim()))
                        {
                            STS_Message.Items["Msg"].Text = "من فضلك ادخل بريداكترونى مناسب";
                            STS_Message.Items["Msg"].ForeColor = Color.Red;
                            Timer_MSgCleaner.Start();
                            TXT_Email.SelectAll();
                            TXT_Email.Focus();
                            return false;
                        }
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
                            if (fValidatePerson()==false)
                            {
                                return false;
                            }
                            else
                            {
                                sSave();
                                rowsAffected = BasicClass.fDMLData(vSqlStatment, "FRM_Students");
                                if (rowsAffected > 0)
                                {

                                    if (Strings.Trim(this.OpnDlg_Picture.FileName).Length > 0)
                                    {
                                        rowsAffected += BasicClass.fAttachImage(Strings.Trim(this.OpnDlg_Picture.FileName), "[User]", "Picture", " Where Code           ='" + Strings.Trim(vPersonCode) + "'", this.Name);
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
                        if (fValidatePerson() == false)
                        {
                            return false;
                        }
                        else
                        {
                            sSave();
                            rowsAffected = BasicClass.fDMLData(vSqlStatment, "FRM_Students");
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
                ExceptionHandler.HandleException(Ex.Message, "FRM_Students", "fSaveData");
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
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "fIsDataChanged");
                return false;
            }

        }
        private void FRM_Students_Load(object sender, EventArgs e)
        {
            try

            {
                sEnableOptions();
                sNew();
                sFillGender();
                sFillRoles();
                sFillYears();
                if (BasicClass.vRoleID ==3)
                {
                     sQueryUserByID(BasicClass.vUsrID);
                }
               
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "FRM_Students_Load");
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
                        if (BasicClass.vRoleID == 3)
                        {
                            Attention vfrm = new Attention();
                            vfrm.ShowDialog();

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

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "Toolbar_Options_ToolClick");
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

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "Toolbar_Options_ToolClick");
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

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "Toolbar_Options_ToolClick");
            }
        }
        private void sFillRoles()
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                // Here i open connection to databse and execute command to get roles to fill dropdown list
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                vSqlCommand.CommandText = "\n" +
                                   "select Roles.ID as RoleID , Roles.RoleName as RoleName" + "\n" +
                                   "from Roles";
                sqlConnection1.Open();
                vSQLReader = vSqlCommand.ExecuteReader();
                while (vSQLReader.Read())
                {
                    if (vSQLReader["RoleID"] != System.DBNull.Value)
                    {
                        TXT_Role.Items.Add(vSQLReader["RoleID"].ToString(), vSQLReader["RoleName"].ToString());
                    }
                   
                }
                vSQLReader.Close();
                sqlConnection1.Close();
                if (BasicClass.vRoleID==3)
                {
                    foreach (var item in TXT_Role.Items)
                    {
                        if (item.DataValue.ToString().Trim() == BasicClass.vRoleID.ToString().Trim())
                        {
                            TXT_Role.SelectedItem = item;
                            TXT_Role.ReadOnly = true;
                            TXT_Role.Enabled = false;
                            continue;
                        }
                    }
               
                }
                else

                {
                    TXT_Role.SelectedIndex = -1;
                    TXT_Role.ReadOnly = false;
                    TXT_Role.Enabled = true;
                            
                }
                
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "sFillRoles");
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Broken || sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }
        private void sFillYears()
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {

                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;


                vSqlCommand.CommandText = "\n" +
                                   "select SchoolYear.ID as YearID , SchoolYear.YearName as YearName" + "\n" +
                                   "from SchoolYear";
                sqlConnection1.Open();
                vSQLReader = vSqlCommand.ExecuteReader();
                while (vSQLReader.Read())
                {
                    if (vSQLReader["YearID"] != System.DBNull.Value)
                    {
                        TXT_Year.Items.Add(vSQLReader["YearID"].ToString(), vSQLReader["YearName"].ToString());
                    }

                }
                vSQLReader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "sFillYears");
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Broken || sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }

        private void TXT_Name_TextChanged(object sender, EventArgs e)
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
                
                ExceptionHandler.HandleException(ex.Message,"FRM_Students","TXT_FindByCode_Enter");
            }
        }
        private string sGetMaxCode()
        {
            string result = "";
            string statment = "";
            try
            {
                statment = "SELECT ISNULL(Max(convert(decimal , substring(Code,5,11))),0) " + "\n" +
                           "FROM [User]" + "\n";
                result = BasicClass.fReturnScalar(statment, this.Name);
              
                
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sGetMaxCode");
                result = "";
            }
            return result;
        }
        public void sEnableOptions()
        {
            try
            {
                if (BasicClass.vRoleID ==1)
                {
                    Toolbar_Options.Tools["BTN_New"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Delete"].SharedProps.Enabled = false;
                    Toolbar_Options.Tools["BTN_Exit"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Previous"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Next"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Caption = "حفظ ";
                }
                else if (BasicClass.vRoleID == 2)
                {
                    Toolbar_Options.Tools["BTN_New"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Delete"].SharedProps.Enabled = false;
                    Toolbar_Options.Tools["BTN_Exit"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Previous"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Next"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Caption = "حفظ ";
                }
                else if (BasicClass.vRoleID == 3)
                {
                    Toolbar_Options.Tools["BTN_New"].SharedProps.Enabled = false;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Save"].SharedProps.Caption = "حفظ وبدأ الامتحان";
                    Toolbar_Options.Tools["BTN_Delete"].SharedProps.Enabled = false;
                    Toolbar_Options.Tools["BTN_Exit"].SharedProps.Enabled = true;
                    Toolbar_Options.Tools["BTN_Previous"].SharedProps.Enabled = false;
                    Toolbar_Options.Tools["BTN_Next"].SharedProps.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sEnableTool");
            }
        }
        private string sGetMinCode()
        {
            string result = "";
            string statment = "";
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                statment = "SELECT ISNULL(Min(convert(decimal , substring(Code,5,11))),0) " + "\n" +
                           "FROM [User]" + "\n";
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
            string UserStmt = "";
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
                       if ( pRecordPosition <= BasicClass.fCount_Rec("From [User]"))
	                {
		                     vfetchRec = pRecordPosition;
	                }
                    else
	                    {
                                               vfetchRec = BasicClass.fCount_Rec("From [User]");
	                    }
	                }
                if (vfetchRec == -2) {
                vfetchRec = BasicClass.fCount_Rec("From [User]");
                }
               vWhereStmt = " And RecPos='" + vfetchRec + "' ";
                     vSqlCommand.CommandText = "\n" +
                                        " With MyItems as " +"\n" +
                                        " ( " +"\n" +
                                         "SELECT [ID],[Code],[Name],[UserName],[RoleID]										" + "\n" +
                                         "      ,[Email],[Facebook],[YER_ID],[Address],[Education],[City] ,[Gender]" + "\n" +
                                         "      ,[IsInstructor],[Status],[Picture],[Age],[Type]" + "\n" +
                                         ", ROW_NUMBER() over(Order  By [User].ID) RecPos" + "\n" +
                                         "  FROM [StudentExam].[dbo].[User]" + "\n" +
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
                TXT_Name.Tag = vSQLReader["Code"].ToString().Trim();
                vPersonCode = vSQLReader["Code"].ToString().Trim();
                TXT_Code.Text = vSQLReader["Code"].ToString().Trim();
            }

            else
            {
                TXT_Name.Tag = "";
                vPersonCode = "";
                TXT_Code.Text = "";
            }
            if (vSQLReader["Name"] != System.DBNull.Value)
            {
                TXT_Name.Text = vSQLReader["Name"].ToString().Trim();
            }

            else
            {
                TXT_Name.Text = "";
            }
            if (vSQLReader["UserName"] != System.DBNull.Value)
            {
                TXT_UseName.Text = vSQLReader["UserName"].ToString().Trim();
            }

            else
            {
                TXT_UseName.Text = "";
            }

            if (vSQLReader["Address"] != System.DBNull.Value)
            {
                TXT_Address.Text = vSQLReader["Address"].ToString().Trim();
            }

            else
            {
                TXT_Address.Text = "";
            }
            if (vSQLReader["City"] != System.DBNull.Value)
            {
                TXT_City.Text = vSQLReader["City"].ToString().Trim();
            }

            else
            {
                TXT_City.Text = "";
            }
            if (vSQLReader["Education"] != System.DBNull.Value)
            {
                TXT_Education.Text = vSQLReader["Education"].ToString().Trim();
            }

            else
            {
                TXT_Education.Text = "";
            }
            if (vSQLReader["Email"] != System.DBNull.Value)
            {
                TXT_Email.Text = vSQLReader["Email"].ToString().Trim();
            }

            else
            {
                TXT_Email.Text = "";
            }

            if (vSQLReader["ID"] != System.DBNull.Value)
            {
                TXT_FindByCode.Text = vSQLReader["ID"].ToString().Trim();
            }

            else
            {
                TXT_Email.Text = "";
            }
            if (vSQLReader["Facebook"] != System.DBNull.Value)
            {
                TXT_Facebook.Text = vSQLReader["Facebook"].ToString().Trim();
            }

            else
            {
                TXT_Facebook.Text = "";
            }

            if (vSQLReader["Age"] != System.DBNull.Value)
            {
                TXT_Age.Value = int.Parse(vSQLReader["Age"].ToString());
            }

            else
            {
                TXT_Age.Value = 0;
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



            if (vSQLReader["RoleID"] != System.DBNull.Value)
            {
                foreach (var item in TXT_Role.Items)
                {
                    if (item.DataValue.ToString().Trim() == vSQLReader["RoleID"].ToString().Trim())
                    {
                        TXT_Role.SelectedItem = item;
                        break;
                    }
                }
            }

            else
            {
                TXT_Role.SelectedIndex = -1;
            }
            if (vSQLReader["YER_ID"] != System.DBNull.Value)
            {
                foreach (var item in TXT_Year.Items)
                {
                    if (item.DataValue.ToString().Trim() == vSQLReader["YER_ID"].ToString().Trim())
                    {
                        TXT_Year.SelectedItem = item;
                        break;
                    }
                }
            }

            else
            {
                TXT_Year.SelectedIndex = -1;
            }
            if (vSQLReader["Gender"] != System.DBNull.Value)
            {
                foreach (var item in TXT_Gender.Items)
                {
                    if (item.DataValue.ToString().Trim() == vSQLReader["Gender"].ToString().Trim())
                    {
                        TXT_Gender.SelectedItem = item;
                        break;
                    }
                }
            }

            else
            {
                TXT_Gender.SelectedIndex = -1;
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
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "TXT_FindByCode_Enter");
            }
            return vResult;
        }
        private bool sQueryUserByID(int pUserID)
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
                vWhereStmt = " And MyItems.ID =" + pUserID + "";
                vSqlCommand.CommandText = "\n" +
                                   " With MyItems as " + "\n" +
                                   " ( " + "\n" +
                                    "SELECT [ID],[Code],[Name],[UserName],[RoleID]										" + "\n" +
                                    "      ,[Email],[Facebook],[YER_ID],[Address],[Education],[City] ,[Gender]" + "\n" +
                                    "      ,[IsInstructor],[Status],[Picture],[Age],[Type]" + "\n" +
                                    ", ROW_NUMBER() over(Order  By [User].ID) RecPos , Password" + "\n" +
                                    "  FROM [StudentExam].[dbo].[User]" + "\n" +
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
                            TXT_Name.Tag = vSQLReader["Code"].ToString().Trim();
                            vPersonCode = vSQLReader["Code"].ToString().Trim();
                            TXT_Code.Text = vSQLReader["Code"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Name.Tag = "";
                            vPersonCode = "";
                            TXT_Code.Text = "";
                        }
                        if (vSQLReader["Name"] != System.DBNull.Value)
                        {
                            TXT_Name.Text = vSQLReader["Name"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Name.Text = "";
                        }
                        if (vSQLReader["UserName"] != System.DBNull.Value)
                        {
                            TXT_UseName.Text = vSQLReader["UserName"].ToString().Trim();
                        }

                        else
                        {
                            TXT_UseName.Text = "";
                        }

                        if (vSQLReader["Password"] != System.DBNull.Value)
                        {
                            TXT_Password.Text = vSQLReader["Password"].ToString().Trim();
                            TXT_ConfirmPassword.Text = vSQLReader["Password"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Password.Text = "";
                            TXT_ConfirmPassword.Text = "";
                        }


                        if (vSQLReader["Address"] != System.DBNull.Value)
                        {
                            TXT_Address.Text = vSQLReader["Address"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Address.Text = "";
                        }
                        if (vSQLReader["City"] != System.DBNull.Value)
                        {
                            TXT_City.Text = vSQLReader["City"].ToString().Trim();
                        }

                        else
                        {
                            TXT_City.Text = "";
                        }
                        if (vSQLReader["Education"] != System.DBNull.Value)
                        {
                            TXT_Education.Text = vSQLReader["Education"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Education.Text = "";
                        }
                        if (vSQLReader["Email"] != System.DBNull.Value)
                        {
                            TXT_Email.Text = vSQLReader["Email"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Email.Text = "";
                        }

                        if (vSQLReader["ID"] != System.DBNull.Value)
                        {
                            TXT_FindByCode.Text = vSQLReader["ID"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Email.Text = "";
                        }
                        if (vSQLReader["Facebook"] != System.DBNull.Value)
                        {
                            TXT_Facebook.Text = vSQLReader["Facebook"].ToString().Trim();
                        }

                        else
                        {
                            TXT_Facebook.Text = "";
                        }

                        if (vSQLReader["Age"] != System.DBNull.Value)
                        {
                            TXT_Age.Value = int.Parse(vSQLReader["Age"].ToString());
                        }

                        else
                        {
                            TXT_Age.Value = 0;
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



                        if (vSQLReader["RoleID"] != System.DBNull.Value)
                        {
                            foreach (var item in TXT_Role.Items)
                            {
                                if (item.DataValue.ToString().Trim() == vSQLReader["RoleID"].ToString().Trim())
                                {
                                    TXT_Role.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        else
                        {
                            TXT_Role.SelectedIndex = -1;
                        }
                        if (vSQLReader["YER_ID"] != System.DBNull.Value)
                        {
                            foreach (var item in TXT_Year.Items)
                            {
                                if (item.DataValue.ToString().Trim() == vSQLReader["YER_ID"].ToString().Trim())
                                {
                                    TXT_Year.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        else
                        {
                            TXT_Year.SelectedIndex = -1;
                        }
                        if (vSQLReader["Gender"] != System.DBNull.Value)
                        {
                            foreach (var item in TXT_Gender.Items)
                            {
                                if (item.DataValue.ToString().Trim() == vSQLReader["Gender"].ToString().Trim())
                                {
                                    TXT_Gender.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        else
                        {
                            TXT_Gender.SelectedIndex = -1;
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
                ExceptionHandler.HandleException(ex.Message, "FRM_Students", "TXT_FindByCode_Enter");
            }
            return vResult;
        }
        private void BTN_Picture_Click(object sender, EventArgs e)
        {

            this.OpnDlg_Picture.Filter = "GIF files (*.gif)|*.gif|BMP files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            this.OpnDlg_Picture.ShowDialog();
            if (Strings.Trim(this.OpnDlg_Picture.FileName).Length > 0)
            {
                System.IO.FileStream vBLOBFile = new System.IO.FileStream(this.OpnDlg_Picture.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] vBLOBData = new byte[vBLOBFile.Length];
                vBLOBFile.Read(vBLOBData, 0, vBLOBData.Length);
                System.IO.MemoryStream stmBLOBData = new System.IO.MemoryStream(vBLOBData);
                this.PIC_picture.Image = System.Drawing.Image.FromStream(stmBLOBData);
                this.PIC_picture.Visible = true;
            }

            //=======================================================
            //Service provided by Telerik (www.telerik.com)
            //Conversion powered by NRefactory.
            //Twitter: @telerik
            //Facebook: facebook.com/telerik
            //=======================================================

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

        private void TXT_Password_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
