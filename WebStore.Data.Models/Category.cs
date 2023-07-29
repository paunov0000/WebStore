using WebStore.Common;

namespace AspNetCoreTemplate.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static EntityValidationConstants.Category;

    public class Category
    {
        public Category()
        {
            this.Id = Guid.NewGuid();
            this.SubCategories = new HashSet<SubCategory>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string CategoryImageURL { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        public virtual IEnumerable<SubCategory> SubCategories { get; set; }
    }
}