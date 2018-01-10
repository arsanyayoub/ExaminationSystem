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
    public partial class FRM_Exam : RadForm
    {
        public FRM_Exam()
        {
            InitializeComponent();
        }
        string[] vSqlStatment = new string[1];
        public List<cQuestion> questionsList = new List<cQuestion>(); 
        public bool isChecked = false;
        public TimeSpan VoteTime;
        public int QuestionIndex = 0;
        private void sSave()
        {
            BasicClass.vSqlConn = new SqlConnection(BasicClass.vConectionString);
            try
            {
                string vIsWorking = "";
                string vQuestionStatment = null;
                string vBook = "";
                int vSTD_ID = BasicClass.vUsrID;
                int vQST_ID = int.Parse(TXT_Code.Tag.ToString());
                int vGrade = 0;
                int vAnswer = 0;
                int vCorrectAnswer = int.Parse(LBL_CorrectAnswer.Text);
                if (CHK_Option1.Checked ==true && vCorrectAnswer ==1)
                {
                    vGrade = 1;
                   
                }
                else if (CHK_Option2.Checked ==true && vCorrectAnswer ==2)
                {
                     vGrade = 1;
                    
                }
                else if (CHK_Option3.Checked == true && vCorrectAnswer == 3)
                {
                    vGrade = 1;
                   
                }
                else if (CHK_Option4.Checked == true && vCorrectAnswer == 4)
                {
                    vGrade = 1;
                   
                }

                if (CHK_Option1.Checked == true)
                {
                    vAnswer = 1;
                }
                else if (CHK_Option2.Checked == true)
                {
                    vAnswer = 2;
                }
                else if (CHK_Option3.Checked == true)
                {
                    vAnswer = 3;
                }
                else if (CHK_Option4.Checked == true)
                {
                    vAnswer = 4;
                }

                vQuestionStatment = "INSERT INTO [Student_Answers]																		" + "\n" +
                                    "           ([STD_ID]          ,  [QST_ID]     ,[Answer]     ,[Grade]     ,[Lastupdate],             [ProcessID]                     ,                     [MachineName]             ,    [USR_ID]   )	" + "\n" +
                                    "     VALUES(" + vSTD_ID + "  ," + vQST_ID + ","+vAnswer+"  ,"+ vGrade +" ,GETDATE()  ,'" + Process.GetCurrentProcess().Id + "'  ,'" + System.Environment.MachineName.Trim() + "'  ," + vSTD_ID + ")		" + "\n";
                vQuestionStatment += "UPDATE [User]										" + "\n" +
                                    "   SET [IsExamTaken] = 'Y'							" + "\n" +
                                    "      ,[Lastupdate]  = GETDATE()					" + "\n" +
                                    "      ,[ProcessID]   = '" + Process.GetCurrentProcess().Id + "' " + "\n" +
                                    "      ,[MachineName] = '" + System.Environment.MachineName.Trim() + "'" + "\n" +
                                    "  WHERE ID =" + vSTD_ID + "\n";
                Int64 saved = BasicClass.fDMLData(vQuestionStatment, this.Name);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sSave");
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
        private void sSaveStudentTotalGrade()
        {
            try
            {
                string vStdGradesStatment = "";
                vStdGradesStatment = "INSERT INTO [StudentExam].[dbo].[Student_Grades]																" + "\n" +
                                        "           ([TValue],			[Desca]				,[TDate],[STD_ID],[Lastupdate],[ProcessID],[MachineName])	" + "\n" +
                                        " SELECT     SUM(Grade) , 'اجمالى مجموع درجات الطالب',GETDATE(),STD_ID ,GETDATE()   ,   '"+Process.GetCurrentProcess().Id +"'      ,'"+ System.Environment.MachineName +"'" + "\n" +
                                        " FROM		Student_Answers																						" + "\n" +
                                        " WHERE		STD_ID = 11																							" + "\n" +
                                        " GROUP BY	STD_ID																								";
                Int64 saved = BasicClass.fDMLData(vStdGradesStatment, this.Name);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sSaveStudentTotalGrade");
            }
            finally
            {
                if (BasicClass.vSqlConn.State == ConnectionState.Broken || BasicClass.vSqlConn.State == ConnectionState.Open)
                {
                    BasicClass.vSqlConn.Close();
                }
            }
        }

        private void sFillSqlStatmentArray(string pStatment)
        {
            //FK 16/4/2005
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
                 Timer_ExamTime.Stop();
                    isChecked = false;
                    questionsList.Clear();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sNew");
            }
        }
        
       
        private void sEmptySqlStatmentArray()
        {
            vSqlStatment = new string[1];
        }

    

        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================

        private void FRM_Exam_Load(object sender, EventArgs e)
        {
            try

            {

                QuestionIndex = 0;
               sFillQuestionList();
               sGetNextQuestion(QuestionIndex);

               LBL_QuestionTime.Text = "30";
               TMR_Question.Start();
               Timer_ExamTime.Enabled = true;
               Timer_ExamTime.Start();
               VoteTime = new TimeSpan(0, 1, 0, 0);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "FRM_Exam_Load");
            }
        }
     
        private void sFillQuestionList()
        {
            SqlConnection sqlConnection1 = new SqlConnection(BasicClass.vConectionString);
            SqlCommand vSqlCommand = new SqlCommand();
            try
            {
                // Here i open connection to databse and execute command to get roles to fill dropdown list
                SqlDataReader vSQLReader;
                vSqlCommand.Connection = sqlConnection1;
                vSqlCommand.CommandText = "\n" +
                                   "EXEC	 [dbo].[GenerateExamNew]";
                sqlConnection1.Open();
                vSQLReader = vSqlCommand.ExecuteReader();
                while (vSQLReader.Read())
                {
                    cQuestion question = new cQuestion();
                    if (vSQLReader["Row"] != System.DBNull.Value)
                    {
                        question.vRow = int.Parse(vSQLReader["Row"].ToString());
                    }
                    else
                    {
                        question.vRow = 0;
                    }
                    if (vSQLReader["ID"] != System.DBNull.Value)
                    {
                        question.vID = int.Parse(vSQLReader["ID"].ToString());
                    }
                    else
                    {
                        question.vID = 0;
                    }

                    if (vSQLReader["BOK_ID"] != System.DBNull.Value)
                    {
                        question.vBOK_ID = int.Parse(vSQLReader["BOK_ID"].ToString());
                    }
                    else
                    {
                        question.vBOK_ID = 0;
                    }
                    if (vSQLReader["BookTitle"] != System.DBNull.Value)
                    {
                        question.vBookTitle = vSQLReader["BookTitle"].ToString();
                    }
                    else
                    {
                        question.vBookTitle = "";
                    }
                    if (vSQLReader["Code"] != System.DBNull.Value)
                    {
                        question.vCode = vSQLReader["Code"].ToString();
                    }
                    else
                    {
                        question.vCode = "";
                    }
                    if (vSQLReader["Description"] != System.DBNull.Value)
                    {
                        question.vDescription = vSQLReader["Description"].ToString();
                    }
                    else
                    {
                        question.vDescription = "";
                    }
                    if (vSQLReader["Option1"] != System.DBNull.Value)
                    {
                        question.vOption1 = vSQLReader["Option1"].ToString();
                    }
                    else
                    {
                        question.vOption1 = "";
                    }
                    if (vSQLReader["Option2"] != System.DBNull.Value)
                    {
                        question.vOption2 = vSQLReader["Option2"].ToString();
                    }
                    else
                    {
                        question.vOption2 = "";
                    }
                    if (vSQLReader["Option3"] != System.DBNull.Value)
                    {
                        question.vOption3 = vSQLReader["Option3"].ToString();
                    }
                    else
                    {
                        question.vOption3 = "";
                    }
                    if (vSQLReader["Option4"] != System.DBNull.Value)
                    {
                        question.vOption4 = vSQLReader["Option4"].ToString();
                    }
                    else
                    {
                        question.vOption4 = "";
                    }
                    if (vSQLReader["CorrectAnswer"] != System.DBNull.Value)
                    {
                        question.vCorrectAnswer = int.Parse(vSQLReader["CorrectAnswer"].ToString());
                    }
                    else
                    {
                        question.vCorrectAnswer = 0;
                    }
                    questionsList.Add(question);
                }
                vSQLReader.Close();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sFillBooks");
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Broken || sqlConnection1.State == ConnectionState.Open)
                {
                    sqlConnection1.Close();
                }
            }

        }
        private void sClearOptionSelect()
        {
            try
            {
                isChecked = true;
                CHK_Option1.Checked = false;
                CHK_Option2.Checked = false;
                CHK_Option3.Checked = false;
                CHK_Option4.Checked = false;
                isChecked = false;
            }
            catch (Exception ex)
            {
                
                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sClearOptionSelect");
            }
            }
        private void sGetNextQuestion(int index)
        {
            try
            {
                if (questionsList.Count > 0)
                {
                    if (index < questionsList.Count )
                    {
                        LBL_QuestionTime.Text = "30";
                        LBL_QuestionTime.ForeColor = Color.Black;
                        string vQno = "";
                        //if (index == 0)
                        //{
                            vQno = (index + 1).ToString();
                        //}
                        //else
                        //{
                        //    vQno = (index).ToString();
                        //}
                        
                        TXT_Description.Text = questionsList[index].vDescription;
                        LBL_Description.Text = "رقم السؤال" + " " + vQno; 
                    TXT_Code.Text = questionsList[index].vCode;
                    TXT_Code.Tag = questionsList[index].vID;
                    LBL_CorrectAnswer.Text = questionsList[index].vCorrectAnswer.ToString();
                    CHK_Option1.Text = questionsList[index].vOption1;
                    CHK_Option2.Text = questionsList[index].vOption2;
                    if (questionsList[index].vOption3 !="")
                    {
                      CHK_Option3.Text = questionsList[index].vOption3;
                      CHK_Option3.Visible = true;
                      LBL_Option3.Visible = true;
                    }
                    else
                    {
                        CHK_Option3.Visible = false;
                        LBL_Option3.Visible = false;
                    }
                    if (questionsList[index].vOption4 != "")
                    {
                        CHK_Option4.Text = questionsList[index].vOption4;
                        CHK_Option4.Visible = true;
                        LBL_Option4.Visible = true;
                    }
                    else
                    {
                        CHK_Option4.Visible = false;
                        LBL_Option4.Visible = false;
                    }
                   sClearOptionSelect();
                    }
                    else
                {
                    sSaveStudentTotalGrade();
                     TMR_ChangeQuestion.Enabled = false;
                    TMR_ChangeQuestion.Stop();
                    TMR_Question.Enabled = false;
                    TMR_Question.Stop();
                    Timer_ExamTime.Enabled = false;
                    Timer_ExamTime.Stop();
                    FRM_Finish vFrm = new FRM_Finish();
                    vFrm.message = "تهانينا ..... لقد انهيت الأمتحان بنجاح";
                    vFrm.ShowDialog();
                } 
                }
               

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "sGetNextQuestion");
            }
          }

        private void Toolbar_Options_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {

                switch (e.Tool.Key)
                {
                    case "BTN_Next":
                        QuestionIndex += 1;
                        sSave();
                        sGetNextQuestion(QuestionIndex);
                        break;
                    }

            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, "FRM_Exam", "Toolbar_Options_ToolClick");
            }
        }

        private void TMR_Question_Tick(object sender, EventArgs e)
        {
            int remainingTime = int.Parse(LBL_QuestionTime.Text);
            if (remainingTime >= 0)
            {
               if (remainingTime<=5)
            {
                LBL_QuestionTime.ForeColor = Color.Red;
                if (remainingTime == 0)
                {    
                    TMR_Question.Stop();
                    sSave();
                QuestionIndex += 1;
                sGetNextQuestion(QuestionIndex);
                TMR_Question.Start();
                }
                else
                {
                    LBL_QuestionTime.Text = (remainingTime - 1).ToString();
                }
            }
               else
               {
                   LBL_QuestionTime.Text = (remainingTime - 1).ToString();
               }
            
            }
           
            
        }

        private void CHK_Option1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                TMR_ChangeQuestion.Enabled = true;
                TMR_ChangeQuestion.Start();
            }
            catch (Exception ex)
            {
                
                ExceptionHandler.HandleException(ex.Message,this.Name,"CHK_Option1_CheckedChanged");
            }
        }
        //private void sChangeQuestion(object sender)
        //{
        //    try
        //    {
        //        if (sender.Equals(CHK_Option1))
        //        {
        //            if (CHK_Option1.Checked == true)
        //            {
        //                sSave();
        //                QuestionIndex += 1;
        //                sGetNextQuestion(QuestionIndex);
        //            }
        //        }
        //        else if (sender.Equals(CHK_Option2))
        //        {
        //            if (CHK_Option2.Checked == true)
        //            {
        //                sSave();
        //                QuestionIndex += 1;
        //                sGetNextQuestion(QuestionIndex);
        //            }
        //        }
        //        else if (sender.Equals(CHK_Option3))
        //        {
        //            if (CHK_Option3.Checked == true)
        //            {
        //                sSave();
        //                QuestionIndex += 1;
        //                sGetNextQuestion(QuestionIndex);
        //            }
        //        }
        //        else if (sender.Equals(CHK_Option4))
        //        {
        //            if (CHK_Option4.Checked == true)
        //            {
        //                sSave();
        //                QuestionIndex += 1;
        //                sGetNextQuestion(QuestionIndex);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
                
        //         ExceptionHandler.HandleException(ex.Message,this.Name,"sChangeQuestion");
        //    }
        //}

        private void Timer_ExamTime_Tick(object sender, EventArgs e)
        {
            VoteTime = VoteTime - new TimeSpan(0, 0, 1);
            TimeSpan TimeRemaining = VoteTime;
            LBL_ExamRemainingTime.Text = TimeRemaining.Seconds + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Hours;
        }

        private void TMR_ChangeQuestion_Tick(object sender, EventArgs e)
        {
            try
            {
                if (QuestionIndex <= questionsList.Count)
                {
                     sSave();
                QuestionIndex += 1;
                sGetNextQuestion(QuestionIndex);
                TMR_ChangeQuestion.Enabled = false;
                TMR_ChangeQuestion.Stop();
                }
               
            }
            catch (Exception ex)
            {

                ExceptionHandler.HandleException(ex.Message, this.Name, "TMR_ChangeQuestion_Tick");
            }
        }

           
    }
}
