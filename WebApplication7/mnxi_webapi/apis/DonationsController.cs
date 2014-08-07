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
using mnxi_db;

namespace mnxi_webapi.apis
{
    public class DonationsController : ApiController
    {
        private MTSTXEntities db = new MTSTXEntities();

        // GET api/Donations
        public IQueryable<vw_donationsummary> Getvw_donationsummary()
        {
            return db.vw_donationsummary;
        }

        public IQueryable<vw_donationsummary> Getvw_donationsummary(object Pparams)
        {
            return db.vw_donationsummary;
        }
        // GET api/Donations/5
        [ResponseType(typeof(vw_donationsummary))]
        public IHttpActionResult Getvw_donationsummary(string id)
        {
            vw_donationsummary vw_donationsummary = db.vw_donationsummary.Find(id);
            if (vw_donationsummary == null)
            {
                return NotFound();
            }

            return Ok(vw_donationsummary);
        }

        // PUT api/Donations/5
        public IHttpActionResult Putvw_donationsummary(string id, vw_donationsummary vw_donationsummary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vw_donationsummary.OnBehalfOf)
            {
                return BadRequest();
            }

            db.Entry(vw_donationsummary).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!vw_donationsummaryExists(id))
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

        // POST api/Donations
        [ResponseType(typeof(vw_donationsummary))]
        public IHttpActionResult Postvw_donationsummary(vw_donationsummary vw_donationsummary)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.vw_donationsummary.Add(vw_donationsummary);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (vw_donationsummaryExists(vw_donationsummary.OnBehalfOf))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vw_donationsummary.OnBehalfOf }, vw_donationsummary);
        }

        // DELETE api/Donations/5
        [ResponseType(typeof(vw_donationsummary))]
        public IHttpActionResult Deletevw_donationsummary(string id)
        {
            vw_donationsummary vw_donationsummary = db.vw_donationsummary.Find(id);
            if (vw_donationsummary == null)
            {
                return NotFound();
            }

            db.vw_donationsummary.Remove(vw_donationsummary);
            db.SaveChanges();

            return Ok(vw_donationsummary);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_donationsummaryExists(string id)
        {
            return db.vw_donationsummary.Count(e => e.OnBehalfOf == id) > 0;
        }
    }
}