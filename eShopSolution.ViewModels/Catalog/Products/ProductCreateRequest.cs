using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }

        [Display(Name = "Giá gốc")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Số lượng")]
        public int Stock { set; get; }

        [Display(Name = "Tên sản phẩm")]
        public string Name { set; get; }

        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Chi tiết")]
        public string Details { set; get; }

        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }

        [Display(Name = "Hình ảnh sản phẩm")]
        public IFormFile ThumbnailImage { get; set; }
    }
}