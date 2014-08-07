using mnxi_db;
using mnxi_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Newtonsoft.Json;
namespace mnxi_webapi.Controllers
{
    public class DonationMVCController : Controller
    {
        MTSTXEntities _db = new MTSTXEntities();
        //
        // GET: /DonationMVC/
        public ActionResult Index()
        {


            return View();
        }



        [HttpGet]

        public JsonResult getCategorieType(string req)
        {
            //  if (req == "cat")
            //{

            // var cat1s = _db.vw_donationsummary.Select(n => n.CategoryName).Distinct().ToList() ; 
            var catType = _db.m_category_type.Select(n => n.cate_type_name).ToList();
            var cats = _db.m_category.Select(n => n.cate_name).ToList();
            // Distinct();

            var json = Json(new { RecCatype = catType , RecCat= cats },  JsonRequestBehavior.AllowGet);
            return json;
            //   }


        }

        [HttpGet]

        public JsonResult getCategories(string req)
        {
          //  if (req == "cat")
            //{

        // var cat1s = _db.vw_donationsummary.Select(n => n.CategoryName).Distinct().ToList() ; 
            var cats = _db.m_category.Select(n => n.cate_name).ToList();
         
         // Distinct();

            var json = Json(new { Records = cats }, JsonRequestBehavior.AllowGet);
                return json;
         //   }


        }
        [HttpPost]
        public JsonResult GetResults(string CategoryName, string CategoryTypeName ,string StartDate, string EndDate)
        {
          //  DoantaionParams d
            try
            {
                //jtStartIndex, int jtPageSize
                var start = Request.QueryString["jtStartIndex"];

                string end = Request.QueryString["jtPageSize"];

                int take, skip;
                int.TryParse(start, out skip );
                int.TryParse(end, out take); 

                //07/03/2014

                DateTime dtStart, dtEnd;
                dtStart = DateTime.Today;
                dtEnd = DateTime.Today.AddDays(-1) ;

                if (!string.IsNullOrWhiteSpace(StartDate))
                {
                    dtStart = DateTime.ParseExact(StartDate, "MM/dd/yyyy", null);
                }

                if (!string.IsNullOrWhiteSpace(EndDate))
                {
                    dtEnd = DateTime.ParseExact(EndDate, "MM/dd/yyyy", null);
                }



              //  var dt = new DateTime(2014, 07, 25, 0, 0 ,0);
                var res = from m in _db.vw_donationsummary where (m.tran_date > dtStart && m.tran_date < dtEnd) select m;
                //  res = from n in _db.vw_donationsummary where (n.tran_date < dtEnd) select n;
                //if (CategoryName != "") {

                //    res = from k in res where k.CategoryName == CategoryName select k;
                //}

                if (CategoryTypeName != "")
                {

                    res = from k in res where k.CategoryTypeName == CategoryTypeName select k;
                }

                //{

                //   

                //}

                var res2 = res;
                var count = res2.ToList().Count();
                var results = res.Distinct().OrderBy(n=>n.tran_date).Skip(skip ).Take(take).ToList();


                return Json(new { Result = "OK", TotalRecordCount = count, Records = results }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }

             
        }
        //
        // GET: /DonationMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DonationMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DonationMVC/Create
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
        // GET: /DonationMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DonationMVC/Edit/5
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
        // GET: /DonationMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DonationMVC/Delete/5
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
