using Asp.NetWebAPI.Areas.HelpPage.Models;
using Asp.NetWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.NetWebAPI.Controllers
{
    public class PersonelController : ApiController
    {
        private List<Personel> listPersoneller = new List<Personel>
        {
             new Personel
             {
                  Id=1,
                   Ad="Kubilay",
                    Soyad="Yazı"
             },
             new Personel
             {
                  Id=2,
                   Ad="Alper",
                    Soyad="Hancı"
             },
              new Personel
             {
                  Id=3,
                   Ad="Berk",
                    Soyad="Gürsoy"
             }
        };

        public IEnumerable<Personel> GetPersoneller()
        {
            return listPersoneller;
        }

        public IHttpActionResult GetPersonel(int id)
        {
            var arananPersonel = (from p in listPersoneller
                                  where p.Id == id
                                  select p).FirstOrDefault();

            return Ok(arananPersonel);
        }

        public IHttpActionResult PostPersonel(Personel per)
        {
            if (listPersoneller.Where(p=>p.Id==per.Id).Count()==0)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }
    }
}
