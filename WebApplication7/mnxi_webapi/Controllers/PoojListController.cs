using mnxi_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mnxi_webapi.Controllers
{
    public class PoojListController : Controller
    {

        MTSTXEntities _db = new MTSTXEntities();
        //
        // GET: /PoojList/
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public JsonResult GetPoojResults(string StartDate, string EndDate)
        {
            //jtStartIndex, int jtPageSize
            var start = Request.QueryString["jtStartIndex"];
            string end = Request.QueryString["jtPageSize"];

            DateTime dtStart, dtEnd;
            dtStart = DateTime.Today;
            dtEnd = DateTime.Today.AddDays(-1);

            if (!string.IsNullOrWhiteSpace(StartDate))
            {
                dtStart = DateTime.ParseExact(StartDate, "MM/dd/yyyy", null);
            }

            if (!string.IsNullOrWhiteSpace(EndDate))
            {
                dtEnd = DateTime.ParseExact(EndDate, "MM/dd/yyyy", null);
            }

            int take, skip;
            int.TryParse(start, out skip);
            int.TryParse(end, out take); 
            var res = _db.vw_PoojaBooking.ToList();
            var results = res.Distinct().OrderBy(n => n.sche_date).Skip(skip).Take(take).ToList();


            return Json(new { Result = "OK", TotalRecordCount = res.Count, Records = results }, JsonRequestBehavior.AllowGet);

        }
        //
        // GET: /PoojList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PoojList/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PoojList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PoojList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PoojList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PoojList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PoojList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
