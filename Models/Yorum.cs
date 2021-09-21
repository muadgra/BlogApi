using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApiChallange.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int PaylasimId {get; set;}
        public virtual Paylasim YorumPaylasimi { get; set; }
    }
}