﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductWebApp.Models
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }





    }
}
