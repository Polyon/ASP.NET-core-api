using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MineApi.Models
{
    public class SkillsData
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Skill")]
        [Column(TypeName = "nvarchar(50)")]
        public string Skill {get; set;}

        [Display(Name = "Technology")]
        [Column(TypeName = "nvarchar(20)")]
        public string Technology{get; set;}

        [Display(Name = "Level")]
        [Column(TypeName = "int")]
        [Range(0, 100)]
        public int SkillLevel {get; set;}

        [Display(Name = "About")]
        [Column(TypeName = "nvarchar(1000)")]
        public string AboutSkill {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0, 1)]
        public int IsActive {get; set;}
    }
}