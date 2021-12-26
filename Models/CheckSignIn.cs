using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace NewsSiteTest.Models
{
    
    public class CheckSignIn
    {
        public string sFullName { get; set; }
        public string sEmailId { get; set; }
        public string sMobileNumber { get; set; }
        public string sPassWord { get; set; }



        string sConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public bool CreateUser(CheckSignIn objUser)
        {
            try
            {
                OleDbParameter[] objParam = new OleDbParameter[5];
                int iParCount = 0;

                objParam[iParCount] = new OleDbParameter("@UserFullName", OleDbType.VarChar);
                objParam[iParCount].Value = objUser.sFullName;
                objParam[iParCount].Direction = ParameterDirection.Input;
                iParCount += 1;

                objParam[iParCount] = new OleDbParameter("@EmailId", OleDbType.VarChar);
                objParam[iParCount].Value = objUser.sEmailId;
                objParam[iParCount].Direction = ParameterDirection.Input;
                iParCount += 1;

                objParam[iParCount] = new OleDbParameter("@MobileNumber", OleDbType.VarChar);
                objParam[iParCount].Value = objUser.sMobileNumber;
                objParam[iParCount].Direction = ParameterDirection.Input;
                iParCount += 1;

                objParam[iParCount] = new OleDbParameter("@PassWord", OleDbType.VarChar);
                objParam[iParCount].Value = objUser.sPassWord;
                objParam[iParCount].Direction = ParameterDirection.Input;
                iParCount += 1;

                if (objUser.sFullName != "")
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}