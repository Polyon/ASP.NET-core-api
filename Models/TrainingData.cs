using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class TrainingData
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Title")]
        [Column(TypeName = "nvarchar(300)")]
        public string TrainingTitle {get; set;}

        [Display(Name = "Duration")]
        [Column(TypeName = "nvarchar(200)")]
        public string TrainingDuration {get; set;}

        [Display(Name = "Details")]
        [Column(TypeName = "nvarchar(1000)")]
        public string TrainingDetails {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserID {get; set;}

        [Display(Name = "Status")]
        [Range(0,1)]
        public int IsActive {get; set;}
    }
}