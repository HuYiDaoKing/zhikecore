using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("Fields")]
    public class Field:Base
    {
       public virtual ICollection<Category> Categories { get; set; }
    }
}
