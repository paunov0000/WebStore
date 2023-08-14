using AspNetCoreTemplate.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebStore.Common.EntityValidationConstants.Product;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Web.ViewModels.Product
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsOnSale { get; set; }

        [Required]
        public string ImageURL { get; set; } = null!;

        //[Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public Guid SubCategoryId { get; set; }

        [Required]
        public Guid? ApplicationUserId { get; set; }

        public IEnumerable<SubCategoryViewModel> SubCategories { get; set; } = new List<SubCategoryViewModel>();
    }
}
