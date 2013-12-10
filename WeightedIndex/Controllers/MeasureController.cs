using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeightedIndex.Models;

namespace WeightedIndex.Controllers
{
    public class MeasureController : Controller
    {
        /// <summary>
        /// ID representing "all measures" instead of a specific measure
        /// </summary>
        private const String ALL_MEAUSRES_ID = "All";

        /// <summary>
        /// List of measures for this example web app
        /// </summary>
        private static List<MeasureModel> measureList = new List<MeasureModel>();


        //
        // GET: /Measure/

        public ActionResult Index()
        {
            return View(measureList);
        }

        //
        // GET: /Measure/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Measure/Create

        [HttpPost]
        public ActionResult Create(MeasureModel measureModel)
        {
            try
            {
                measureList.Add(measureModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Measure/Edit/5

        public ActionResult Edit(Guid id)
        {
            return View(measureList.Where(c => c.id == id).FirstOrDefault());
        }

        //
        // POST: /Measure/Edit/5

        [HttpPost]
        public ActionResult Edit(Guid id, MeasureModel measureModel)
        {
            try
            {
                measureList.Find(c => c.id == id).performanceImpact = measureModel.performanceImpact;
                measureList.Find(c => c.id == id).quickToImplement = measureModel.quickToImplement;
                measureList.Find(c => c.id == id).name = measureModel.name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Measure/Delete/5

        public ActionResult Delete(Guid id)
        {
            try
            {
                measureList.RemoveAll(c => c.id == id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Measure/Delete/5

        [HttpPost]
        public ActionResult Delete(Guid id, MeasureModel measureModel)
        {
            try
            {
                measureList.RemoveAll(c => c.id == id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Measure/getAllAsJson/

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult getAllAsJson()
        {
            // all of the measures in JSON
            return Json(measureList);
        }
    }
}
