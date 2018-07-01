using System.Collections.Generic;

namespace Blog.Models
{
    public class WidgetItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Style { get; set; }

        public int WidgetId { get; set; }
        public virtual Widget Widget { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}