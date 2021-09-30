using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class SocialMedia
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Filepath")]
        [Column(TypeName = "varchar(max)")]
        public string FilePath {get; set;}

        [Display(Name = "Title")]
        [Column(TypeName = "nvarchar(50)")]
        public string MediaTitle {get; set;}

        [Display(Name = "Link")]
        [Column(TypeName = "varchar(max)")]
        public string MediaLink {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Status")]
        [Range(0,1)]
        public int IsActive {get; set;}
    }
}