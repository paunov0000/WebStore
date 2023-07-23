using WebStore.Common;

namespace AspNetCoreTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static EntityValidationConstants.SubCategory;

    public class SubCategory
    {
        public SubCategory()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string SubCategoryImageURL { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

    }
}
