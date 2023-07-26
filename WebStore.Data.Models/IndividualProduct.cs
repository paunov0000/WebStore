using WebStore.Common;

namespace AspNetCoreTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static EntityValidationConstants.IndividualProduct;

    public class IndividualProduct
    {
        public IndividualProduct()
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
        public string ProductImageURL { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(SubCategory))]
        public Guid SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUser))]
        public Guid? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
