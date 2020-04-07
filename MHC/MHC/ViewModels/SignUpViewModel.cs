using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MHC.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "学号")]
        [Required]
        public string StudentNum { get; set; }

        [Display(Name = "用户名")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Display(Name = "生日")]
        [Required]
        public DateTime Birthday { get; set; }

        [Display(Name = "邮件")]
        [Required]
        public string Email { get; set; }
    }
}