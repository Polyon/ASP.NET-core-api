using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class WorkExp
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Title")]
        [Column(TypeName = "nvarchar(200)")]
        public string JobTitle {get; set;}

        [Display(Name = "Description")]
        [Column(TypeName = "nvarchar(300)")]
        public string JobDescription {get; set;}

        [Display(Name = "Timeline")]
        [Column(TypeName = "nvarchar(100)")]
        public string JobTimeline {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserID {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0, 1)]
        public int IsActive {get; set;}
    }
}