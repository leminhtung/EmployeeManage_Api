﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMange.API.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "mời nhập LoginID")]
        public string AdminId { set; get; }
        [Required(ErrorMessage = "mời nhập Password")]
        public string Password { set; get; }
    }
}