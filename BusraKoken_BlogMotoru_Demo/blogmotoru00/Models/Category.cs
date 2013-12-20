using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogMotoru00.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [DisplayName("İsim")]
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}