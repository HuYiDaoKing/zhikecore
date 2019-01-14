using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("Articles")]
    public class Article:Base
    {
        [DisplayName("分类")]
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [DisplayName("子类")]
        public string SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
        
        [DisplayName("作者")]
        public string AdminUserId { get; set; }
        [ForeignKey("AdminUserId")]
        public AdminUser AdminUser { get; set; }

        [DisplayName("权重")]
        public int Weight { get; set; }

        [DisplayName("内容")]
        public string Content { get; set; }

        [DisplayName("封面")]
        public string Cover { get; set; }

        [DisplayName("标签")]
        public string Tags { get; set; }
    }
}
