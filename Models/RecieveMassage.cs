using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class RecieveMassage
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Sender Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string SenderName {get; set;}

        [Display(Name = "Email ID")]
        [Column(TypeName = "nvarchar(256)")]
        public string SenderEmail {get; set;}

        [Display(Name = "Massage")]
        [Column(TypeName = "varchar(max)")]
        public string MassageBody {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}

        [Display(Name = "Reply Status")]
        [Column(TypeName = "int")]
        [Range(0,1)]
        public int Reply {get; set;}
    }
}