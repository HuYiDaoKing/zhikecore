using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("SubCategories")]
    public class SubCategory:Base
    {
        [DisplayName("分类")]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        
        [DisplayName("分类名称")]
        [NotMapped]
        public string CategoryName { get; set; }

    }
}
