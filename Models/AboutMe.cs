using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class AboutMe
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "About Me")]
        [Column(TypeName = "nvarchar(max)")]
        public string About {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0,1)]
        public int IsActive {get; set;}
    }
}