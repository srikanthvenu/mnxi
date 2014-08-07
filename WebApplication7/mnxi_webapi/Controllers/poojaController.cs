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

namespace mnxi_webapi.Controllers
{
    public class poojaController : ApiController
    {
        private MTSTXEntities db = new MTSTXEntities();

        // GET api/pooja
        public IQueryable<vw_PoojaBooking> Getvw_PoojaBooking()
        {
            return db.vw_PoojaBooking;
        }

        // GET api/pooja/5
        [ResponseType(typeof(vw_PoojaBooking))]
        public IHttpActionResult Getvw_PoojaBooking(DateTime id)
        {
            vw_PoojaBooking vw_poojabooking = db.vw_PoojaBooking.Find(id);
            if (vw_poojabooking == null)
            {
                return NotFound();
            }

            return Ok(vw_poojabooking);
        }

        // PUT api/pooja/5
        public IHttpActionResult Putvw_PoojaBooking(DateTime id, vw_PoojaBooking vw_poojabooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vw_poojabooking.business_date)
            {
                return BadRequest();
            }

            db.Entry(vw_poojabooking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!vw_PoojaBookingExists(id))
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

        // POST api/pooja
        [ResponseType(typeof(vw_PoojaBooking))]
        public IHttpActionResult Postvw_PoojaBooking(vw_PoojaBooking vw_poojabooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.vw_PoojaBooking.Add(vw_poojabooking);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (vw_PoojaBookingExists(vw_poojabooking.business_date))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vw_poojabooking.business_date }, vw_poojabooking);
        }

        // DELETE api/pooja/5
        [ResponseType(typeof(vw_PoojaBooking))]
        public IHttpActionResult Deletevw_PoojaBooking(DateTime id)
        {
            vw_PoojaBooking vw_poojabooking = db.vw_PoojaBooking.Find(id);
            if (vw_poojabooking == null)
            {
                return NotFound();
            }

            db.vw_PoojaBooking.Remove(vw_poojabooking);
            db.SaveChanges();

            return Ok(vw_poojabooking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_PoojaBookingExists(DateTime id)
        {
            return db.vw_PoojaBooking.Count(e => e.business_date == id) > 0;
        }
    }
}