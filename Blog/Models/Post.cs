using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public virtual ICollection<WidgetItem> WidgetItems { get; set; }
    }
}