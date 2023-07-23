using WebStore.Common;

namespace AspNetCoreTemplate.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static EntityValidationConstants.Category;

    public class Category
    {
        public Category()
        {
         this.SubCategories = new HashSet<SubCategory>();   
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string CategoryImageURL { get; set; } = null!;

        [Required]
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}