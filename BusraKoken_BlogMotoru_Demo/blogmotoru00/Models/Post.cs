using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogMotoru00.Models
{
   public class Post
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
       [DisplayName("Başlık")]
        public string Title { get; set; }
       [DisplayName("İçerik")]
        public string Body { get; set; }
       [DisplayName("Özet")]
        public string Abstract { get; set; }
       [DisplayName("Tarih")]
       [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public virtual Category Categories { get; set; } 
    }
}
