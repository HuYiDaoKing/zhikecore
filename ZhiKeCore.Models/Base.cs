using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZhiKeCore.Models
{
    public class Base
    {
        [Key]
        public string Id { get; set; }

        [DisplayName("名称")]
        [MaxLength(30),Required]
        public string Name { get; set; }

        [DisplayName("描述")]
        public string  Description { get; set; }

        [DisplayName("创建人")]
        public string Creator { get; set; }

        [DisplayName("修改人")]
        public string Modifier { get; set; }

        [DisplayName("创建日期")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("创建日期")]
        public DateTimeOffset Modified { get; set; }

        public virtual void Create(ZhikeDbContext db)
        {
            Id = Guid.NewGuid().ToString();
            Created = Modified = DateTimeOffset.Now;
        }

        public virtual void Modify(ZhikeDbContext db)
        {
            Modified = DateTimeOffset.Now;
            db.Entry(this).State = EntityState.Modified;
        }

    }
}
