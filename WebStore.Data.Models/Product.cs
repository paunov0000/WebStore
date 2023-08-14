using WebStore.Common;

namespace AspNetCoreTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static EntityValidationConstants.Product;

    public class Product
    {
        public Product()
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

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [ForeignKey(nameof(SubCategory))]
        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUser))]
        public Guid? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
