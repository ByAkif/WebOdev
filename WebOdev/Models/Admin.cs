﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web12412412.Models
{
    [Table("AdminTbl")]
    public class Admin
    {

        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        [Display(Name = "Kullanıcı Adı")]
        public string AdminName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
