using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{Id=101,CountryName="Spain",CountryCapital="Madrid"},
            new Country{Id=102,CountryName="India",CountryCapital="Delhi"},
            new Country{Id=103,CountryName="Italy",CountryCapital="Rome"},
            new Country{Id=104,CountryName="Japan",CountryCapital="Tokyo"},
            new Country{Id=105,CountryName="US",CountryCapital="Washington"},
            new Country{Id=106,CountryName="France",CountryCapital="Paris"},
        };

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(countrylist);
        }

        public IHttpActionResult Get(int id)
        {
            Country countryobj = countrylist.Find(item => item.Id == id);
            if (countryobj != null)
                return Ok(countryobj);
            return NotFound();
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            Country countryobj = countrylist.Find(item => item.Id == id);
            if (countryobj != null)
            {
                bool Isremoved = countrylist.Remove(countryobj);
                if (Isremoved) return Ok(countryobj);
            }
            return NotFound();

        }


        [HttpPut]

        public IHttpActionResult Put(int id, [FromBody] Country countryobj)
        {
            if (countrylist[id - 1] != null)
            {
                countrylist[id - 1] = countryobj;
                return Ok(countrylist);
            }
            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] Country countryobj)
        {
            countrylist.Add(countryobj);
            return Ok(countrylist);
        }

    }
}
