using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBLShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Department { set; get; }
        public string Skype { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Facebook { set; get; }
        public bool Status { set; get; }
    }
}