using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("Comments")]
    public class Comment:Base
    {
        public string ArticleId { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }

        public string Content { get; set; }

        public CommentStatus Status { get; set; }
    }

    /// <summary>
    /// 课程周期
    /// </summary>
    public enum CommentStatus
    {
        /// <summary>
        /// 开放
        /// </summary>
        Open,

        /// <summary>
        /// 关闭
        /// </summary>
        Closed
    }
}
