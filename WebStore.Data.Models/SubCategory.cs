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
        public string ImageURL { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

    }
}
