using PBLShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PBLShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImage { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool? Homeflag { set; get; }
        public bool? Hotflag { set; get; }
        public int? Viewcount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}