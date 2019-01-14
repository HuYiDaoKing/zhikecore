using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("Categories")]
    public class Category : Base
    {
        [DisplayName("领域")]
        public string FieldId { get; set; }
        [ForeignKey("FieldId")]
        public virtual Field Field { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }

        [DisplayName("领域")]
        [NotMapped]
        public string FiledName { get; set; }
    }
}
