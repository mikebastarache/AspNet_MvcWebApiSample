using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApiSample.Controllers
{
    public class Person{
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class PersonController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {
            return new List<Person> { 
                new Person{ ID=1, First="Mike", Last="Bastarache"},
                new Person{ ID=2, First="Liette", Last="Bastarache"},
                new Person{ ID=3, First="Jenna", Last="Bastarache"},
                new Person{ ID=4, First="Cameron", Last="Bastarache"}
            };
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return null;
        }

        // POST api/values
        public void Post([FromBody]Person value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Person value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}