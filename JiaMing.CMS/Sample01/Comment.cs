using System;
using System.Collections.Generic;
using System.Text;

namespace Sample01
{
    public class Comment
    {  /// <summary>
       /// 主键
       /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 文章id
        /// </summary>
        public int Content_id { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime Add_time { get; set; } = DateTime.Now;
    }
}
