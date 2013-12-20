using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlogMotoru00.Models
{
    public class Page
    {
        public int PageId { get; set; }
        [DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("İçerik")]
        public string Body { get; set; }
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }
    }
}