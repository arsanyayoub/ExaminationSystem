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
    public partial class FRM_Login : RadForm
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentExamDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.studentExamDataSet.User);
            TXT_UserName.Select();
            FRM_Login frmLogin = new FRM_Login();
            FRM_Main frmMain = new FRM_Main();
            //frmLogin.MdiParent = frmMain;
            
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, this.Name, "BTN_Cancel_Click");
            }
            
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_UserName.Text.ToString() =="")
                {
                    STS_Login.Items["Msg"].Text = "من فضلك ادخل اسم المستخدم";
                    TXT_UserName.SelectAllText();
                    Timer_MSgCleaner.Start();
                }
                else
                {
                    sFillUserdata(TXT_UserName.Text.ToString(), TXT_Password.Text.ToString());
                    if (BasicClass.vUsrID ==0)
                    {
                          STS_Login.Items["Msg"].Text = "اسم المستخدم / كلمة المرور غير صحيح";
                            TXT_UserName.SelectAllText();

                    }
                    else
                    {
                        BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
                        Close();
                    }
                }

                
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "BTN_Login_Click");
            }
        }
        private void sFillUserdata(string userName, string password)
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                

                vSqlCommand.CommandText = "\n" +
                                   "select [User].ID as USR_ID , [User].UserName as UserName  " + "\n" +
                                   ", Roles.ID as RoleID  " + "\n" +
                                   ",Roles.RoleName as RoleName" + "\n" +
                                   "from  [User] " + "\n" +
                                   "INNER JOIN Roles" +"\n"+
                                   "ON  Roles.ID = [User].RoleID" +"\n"+
                                   "where UserName ='" + userName + "' " + "\n" +
                                   "and   Password ='" + password + "' OR Password IS NULL" + "\n";
                sqlConnection1.Open();
             vSQLReader=   vSqlCommand.ExecuteReader();
                while (vSQLReader.Read())
                {
                    if (vSQLReader["USR_ID"] !=System.DBNull.Value)
                    {
                        BasicClass.vUsrID = int.Parse(vSQLReader["USR_ID"].ToString());
                    }
                    if (vSQLReader["UserName"] != System.DBNull.Value)
                    {
                        BasicClass.vUsrName = vSQLReader["UserName"].ToString();
                    }
                    if (vSQLReader["RoleID"] != System.DBNull.Value)
                    {
                        BasicClass.vRoleID = int.Parse(vSQLReader["RoleID"].ToString());
                    }
                    if (vSQLReader["RoleName"] != System.DBNull.Value)
                    {
                        BasicClass.vRoleName = vSQLReader["RoleName"].ToString();
                    }
                    
                }
                vSQLReader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "sFillUserdata");
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Broken || sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }

        private void Timer_MSgCleaner_Tick(object sender, EventArgs e)
        {
            STS_Login.Items["Msg"].Text = "";
        }
    }
}
