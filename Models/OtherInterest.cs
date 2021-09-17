using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class OtherInterest
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Others")]
        [Column(TypeName = "nvarchar(1000)")]
        public string Text {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Status")]
        [Column(TypeName = "int")]
        [Range(0, 1)]
        public int IsActive {get; set;}
    }
}