using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace teamAkshay_Aquarium_p1.Models
{
    public class User
    {
        public int id { get; set; }

        [DisplayName("role")]
        public int? roleId { get; set; }
        
        public string name { get; set; }
        [DisplayName("gender")]
        public int? genderId { get; set; }
        public string email { get; set; }
        public string phone_Number { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}