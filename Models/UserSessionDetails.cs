using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewsSiteTest.Models
{
    public class UserSessionDetails
    {
        

        [Display(Name = "Harshu")]
        public string UserName { get; set; }
        


        public int NotificationsNum { get; set; }


        public List<string> Notifications { get; set; }
    }
}