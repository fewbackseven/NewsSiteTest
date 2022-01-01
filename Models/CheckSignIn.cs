using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace NewsSiteTest.Models
{
    
    public class CheckSignIn
    {
        
        
        


        [Required(ErrorMessage ="Please Enter your Name")]
        [Display( Name= "ಪೂರ್ಣ ಹೆಸರು")]
        public string sFullName { get; set; }


        [Required(ErrorMessage ="Please enter your Email-ID")]
        [Display(Name = "Email ID")]
        public string sEmailId { get; set; }

        

        [RegularExpression(@"^[0-9]{10}$",ErrorMessage = "Please enter a valid Mobile number") ]
        [Display(Name ="Mobile Number")]
        public string sMobileNumber { get; set; }

        [Required(ErrorMessage ="Please enter Password")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string sPassWord { get; set; }

        [Compare("sPassWord",ErrorMessage = "Passwords didnt Match")]
        [Required(ErrorMessage ="Please enter password again for confirmation")]
        [DataType(DataType.Password)]
        public string sCnfPassWord { get; set; }



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