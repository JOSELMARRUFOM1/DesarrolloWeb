using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using WebAPIDEMO.Models;

namespace WebAPIDEMO.Controllers
{
    [EnableCors(origins: "http://localhost:8082", headers: "*", methods: "*")]
    public class EVALUACION_TEDController : ApiController
    {
        private BetaSqlEntities db = new BetaSqlEntities();

        // GET: api/EVALUACION_TED
        public IQueryable<EVALUACION_TED> GetEVALUACION_TED()
        {
            return db.EVALUACION_TED;
        }

        // GET: api/EVALUACION_TED/5
        [ResponseType(typeof(EVALUACION_TED))]
        public IHttpActionResult GetEVALUACION_TED(decimal id)
        {
            EVALUACION_TED eVALUACION_TED = db.EVALUACION_TED.Find(id);
            if (eVALUACION_TED == null)
            {
                return NotFound();
            }

            return Ok(eVALUACION_TED);
        }

        // PUT: api/EVALUACION_TED/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEVALUACION_TED(decimal id, EVALUACION_TED eVALUACION_TED)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eVALUACION_TED.CODEVALUACION)
            {
                return BadRequest();
            }

            db.Entry(eVALUACION_TED).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EVALUACION_TEDExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EVALUACION_TED
        [ResponseType(typeof(EVALUACION_TED))]
        public IHttpActionResult PostEVALUACION_TED(EVALUACION_TED eVALUACION_TED)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EVALUACION_TED.Add(eVALUACION_TED);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EVALUACION_TEDExists(eVALUACION_TED.CODEVALUACION))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eVALUACION_TED.CODEVALUACION }, eVALUACION_TED);
        }

        // DELETE: api/EVALUACION_TED/5
        [ResponseType(typeof(EVALUACION_TED))]
        public IHttpActionResult DeleteEVALUACION_TED(decimal id)
        {
            EVALUACION_TED eVALUACION_TED = db.EVALUACION_TED.Find(id);
            if (eVALUACION_TED == null)
            {
                return NotFound();
            }

            db.EVALUACION_TED.Remove(eVALUACION_TED);
            db.SaveChanges();

            return Ok(eVALUACION_TED);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EVALUACION_TEDExists(decimal id)
        {
            return db.EVALUACION_TED.Count(e => e.CODEVALUACION == id) > 0;
        }
    }
}