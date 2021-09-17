using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class ProjectData
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Title")]
        [Column(TypeName = "nvarchar(100)")]
        public string ProjectTitle {get; set;}

        [Display(Name = "About")]
        [Column(TypeName = "nvarchar(1000)")]
        public string AboutProject {get; set;}

        [Display(Name = "Link")]
        [Column(TypeName = "nvarchar(1000)")]
        public string ProjectLink {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int AuthUser {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0, 1)]
        public int IsActive {get; set;}
    }
}