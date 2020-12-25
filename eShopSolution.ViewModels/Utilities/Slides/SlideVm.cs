
using eShopSolution.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Utilities.Slides
{
        public class SlideVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
