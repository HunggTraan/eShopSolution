using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateValidator : AbstractValidator<ProductCreateRequest>
    {
        public ProductCreateValidator()
        {
            //Tên sản phẩm
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bắt buộc phải điền tên sản phẩm!")
                 .MaximumLength(200).WithMessage("Tên sản phẩm không thể quá 200 ký tự");
            //Giá bán
            RuleFor(x => x.Price).NotEmpty().WithMessage("Bắt buộc phải điền giá bán!");
            //Giá gốc
            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage("Bắt buộc phải điền giá gốc!");
            //Số lượng
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Bắt buộc phải điền số lượng!");
            //Mô tả
            RuleFor(x => x.Description)
                 .MaximumLength(2000).WithMessage("Mô tả không thể quá 2000 ký tự");
            //Chi tiết
            RuleFor(x => x.Details)
                 .MaximumLength(2000).WithMessage("Chi tiết không thể quá 2000 ký tự");
        }
    }
}