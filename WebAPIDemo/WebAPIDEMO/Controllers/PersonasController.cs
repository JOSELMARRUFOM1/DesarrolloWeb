using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDEMO.Models;

namespace WebAPIDEMO.Controllers
{
    public class PersonasController : ApiController
    {
        List<Persona> listapersonas = new List<Persona>();

        public PersonasController()
        {
            Persona p = new Persona { IdPersona = 1, Nombre = "Lucia", Email = "lucia@gmail.com", Edad = 19 };

            this.listapersonas.Add(p);

            p = new Persona { IdPersona = 2, Nombre = "Adrian", Email = "adrian@gmail.com", Edad = 24 };

            this.listapersonas.Add(p);

        }

        // GET api/<controller>
        public List<Persona> GetPersonas()

        {

            return this.listapersonas;

        }

        // GET api/<controller>/9
        public Persona GetPersona(int id)
        {

            Persona p = this.listapersonas.Find(z => z.IdPersona == id);

            return p;

        }



    }
}
