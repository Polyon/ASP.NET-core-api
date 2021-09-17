using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class AuthAdmin
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Username")]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName {get; set;}

        [Display(Name = "Email ID")]
        [Column(TypeName = "nvarchar(256)")]
        public string EmailId {get; set;}

        [Display(Name = "Password")]
        [Column(TypeName = "nvarchar(20)")]
        public string PassWord {get; set;}
    }
}