﻿using System.ComponentModel.DataAnnotations;
using static WebStore.Core.Constants.ErrorMessageConstants.General;
using static WebStore.Core.Constants.ErrorMessageConstants.Product;
using static WebStore.Core.Constants.DisplayAttributeNameConstants.Product;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Product;
using WebStore.Infrastructure.Data.Constants;

namespace WebStore.Core.Model.Product
{
    public class ProductAddViewModel
    {

        [Required]
        public Guid Id { get; set; }

        [Display(Name = DisplayName)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = InvalidFieldLengthMessage)]
        public string Name { get; set; } = null!;

        [Display(Name = DisplayDescription)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = InvalidFieldLengthMessage)]
        public string Description { get; set; } = null!;

        [Display(Name = DisplayPrice)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(typeof(decimal),PriceMinValue, PriceMaxValue, ErrorMessage = InvalidPriceRangeMessage)]
        //[RegularExpression(@"^\d+$", ErrorMessage = "Please enter a valid number.")]
        public decimal Price { get; set; }

        [Display(Name = "Оригинална Цена")]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public decimal OriginalPrice { get; set; }

        [Required(ErrorMessage = RequiredFieldMessage)]
        [Range(0, 5000, ErrorMessage = InvalidQuantityRangeMessage)]
        public int Quantity { get; set; }

        [Display(Name = DisplayImage)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = DisplayOnSale)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public bool OnSale { get; set; } 

        [Display(Name = DisplayIsActive)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public bool IsActive { get; set; }

        [Display(Name = DisplayBrand)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public Guid BrandId { get; set; }

        [Display(Name = DisplayCategory)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public Guid CategoryId { get; set; }

        [Display(Name = DisplaySubcategory)]
        [Required(ErrorMessage = RequiredFieldMessage)]
        public Guid? SubcategoryId { get; set; }
    }
}
