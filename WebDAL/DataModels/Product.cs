using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
   public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string AuthorId { get; set; }
        public string PublisherId { get; set; }
        public string SubcategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
        [ForeignKey("SubcategoryId")]
        public virtual Subcategory Subcategory { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
