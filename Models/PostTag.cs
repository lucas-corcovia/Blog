using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostTag
    {       
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}