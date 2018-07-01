using System.Collections.Generic;

namespace Blog.Models
{
    public class Widget
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<WidgetItem> WidgetItems { get; set; }
    }
}