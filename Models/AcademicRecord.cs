using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class AcademicRecord
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Level")]
        [Column(TypeName = "nvarchar(50)")]
        public string QualificationLevel {get; set;}

        [Display(Name = "Institute / College")]
        [Column(TypeName = "nvarchar(200)")]
        public string Organisation {get; set;}

        [Display(Name = "Board / University")]
        [Column(TypeName = "nvarchar(500)")]
        public string CenterBoard {get; set;}

        [Display(Name = "Percentage / CGPA")]
        [Column(TypeName = "float")]
        [Range(0, 100)]
        public float Marks {get; set;}

        [Display(Name = "Completed at")]
        [Column(TypeName = "int")]
        public int PassingYear {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0, 1)]
        public int IsActive {get; set;}
    }
}