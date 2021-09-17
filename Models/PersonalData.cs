using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class PersonalData
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Profile Picture")]
        [Column(TypeName = "nvarchar(1000)")]
        public string imagePath {get; set;}

        [Display(Name = "Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string MyName {get; set;}

        [Display(Name = "Address")]
        [Column(TypeName = "nvarchar(500)")]
        public string MyAddress {get; set;}

        [Display(Name = "District")]
        [Column(TypeName = "nvarchar(100)")]
        public string District {get; set;}

        [Display(Name = "State")]
        [Column(TypeName = "nvarchar(100)")]
        public string State {get; set;}

        [Display(Name = "PIN")]
        [Column(TypeName = "bigint")]
        public long PIN {get; set;}

        [Display(Name = "Email ID")]
        [Column(TypeName = "nvarchar(256)")]
        public string MyEmail {get; set;}

        [Display(Name = "Contect No.")]
        [Column(TypeName = "bigint")]
        public long ContectNo {get; set;}

        [Display(Name = "Authentication ID")]
        [Column(TypeName = "bigint")]
        public int AuthId {get; set;}

    }
}