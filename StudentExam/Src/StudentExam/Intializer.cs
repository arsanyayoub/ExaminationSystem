using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace StudentExam
{
   public class Intializer
    {
       public bool sRaiseLoginForm()
       {
           bool result = false;
           try
           {
               
               FRM_Login vFrm_Login = new FRM_Login();
               vFrm_Login.ShowDialog();

               if (BasicClass.vUsrID > 0)
               {
                   result = true;
               }
               else
               {
                   result = false;
               }
           }
           catch (Exception)
           {
               result = false;
               throw;
           }
           return result;
       }
       //public string sEncrypt(string pText )
       //{
       //    return Encrypt(pText, "&%#@?,:*");
       //}
       //    public string sDecrypt(string pText){
       //        return Decrypt(pText, "&%#@?,:*");
       //    }
        
  
       //public string Encrypt(string pStrText, string pstrEncrKey)
       //{
       //    try
       //    {
       //         Byte  [] byKey =  new Byte[100];
       //        Byte[] IV = new Byte { &H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF };
       //        byKey = System.Text.Encoding.UTF8.GetBytes(BasicClass.Left(pstrEncrKey, 8));

       //        System.Security.Cryptography.DESCryptoServiceProvider des = new System.Security.Cryptography.DESCryptoServiceProvider();
       //        MemoryStream ms = new MemoryStream();
       //        Byte[] inputByteArray = Encoding.UTF8.GetBytes(pStrText);
       //        CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
       //        cs.Write(inputByteArray, 0, inputByteArray.Length);
       //        cs.FlushFinalBlock();
       //        return Convert.ToBase64String(ms.ToArray());
       //    }
       //    catch (Exception ex)
       //    {
               
       //       return ex.Message;
       //    }
          
          
       //}

       //public string Decrypt(string pStrText, string sDecrKey)
       //{
       //    try
       //    {
       //        Byte[] byKey = new Byte[100];
       //        Byte[] IV = new Byte {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF };
       //        Byte[] inputByteArray = new byte[pStrText.Length];
       //       byKey = System.Text.Encoding.UTF8.GetBytes(BasicClass.Left(sDecrKey, 8));
       //    DESCryptoServiceProvider des = new DESCryptoServiceProvider();
       //     inputByteArray = Convert.FromBase64String(pStrText);
       //     MemoryStream ms = new MemoryStream();
       //     CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
       //     cs.Write(inputByteArray, 0, inputByteArray.Length);
       //     cs.FlushFinalBlock();
       //     System.Text.Encoding encoding = System.Text.Encoding.UTF8;
       //     return encoding.GetString(ms.ToArray());
       //    }
       //    catch (Exception ex)
       //    {

       //        return ex.Message;
       //    }


       //}
    }
}
