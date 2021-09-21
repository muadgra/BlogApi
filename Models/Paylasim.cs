using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApiChallange.Models
{
    public class Paylasim
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Yorum> Yorumlar { get; set; }

    }
}