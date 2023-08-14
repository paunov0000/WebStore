using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebStore.Common.EntityValidationConstants.Product;


namespace WebStore.Web.ViewModels.Product
{
    public class ProductFormModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public bool IsOnSale { get; set; }

        //[Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public Guid SubCategoryId { get; set; }
    }
}
