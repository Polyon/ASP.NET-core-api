using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MineApi.Models
{
    public class SendMassage
    {
        [Key]
        [Display(Name = "ID")]
        [Column(TypeName = "bigint")]
        public int ID {get; set;}

        [Display(Name = "Recipient Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string RecipientName {get; set;}

        [Display(Name = "Email ID")]
        [Column(TypeName = "nvarchar(256)")]
        public string RecipientEmail {get; set;}

        [Display(Name = "Subject")]
        [Column(TypeName = "varchar(max)")]
        public string MassageSubject {get; set;}

        [Display(Name = "Massage")]
        [Column(TypeName = "varchar(max)")]
        public string MassageBody {get; set;}

        [Display(Name = "User ID")]
        [Column(TypeName = "bigint")]
        public int UserId {get; set;}
    }
}