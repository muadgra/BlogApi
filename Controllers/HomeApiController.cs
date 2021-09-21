using BlogApiChallange.Context;
using BlogApiChallange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlogApiChallange.Controllers
{
    public class HomeApiController : ApiController
    {
        private readonly DatabaseContext db = new DatabaseContext();
        [HttpGet]
        public IEnumerable<Paylasim> PaylasimlariCek()
        {
            return db.Paylasimlar.ToList();
        }

        [HttpPost]
        public void PaylasimEkle([FromBody] Paylasim paylasim)
        {
            db.Paylasimlar.Add(paylasim);
            db.SaveChanges();
            Console.WriteLine("Ekledi");
        }
        [HttpGet]
        public Paylasim PaylasimGetir(int id)
        {
            var paylasim = db.Paylasimlar.Where(x => x.Id == id).FirstOrDefault();
            return paylasim;
        }
        [HttpPost]
        public void YorumEkle([FromBody] Yorum yorum)
        {
            db.Yorumlar.Add(yorum);
            db.SaveChanges();
        }
    }
}
