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
        /// List of measures for this example web app
        /// </summary>
        private static List<MeasureModel> _measureList = new List<MeasureModel>();


        //
        // GET: /Measure/

        public ActionResult Index()
        {
            return View(_measureList);
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
                _measureList.Add(measureModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Measure/Edit/5

        public ActionResult Edit(string measureName)
        {
            return View(_measureList.Where(c => c.name == measureName).FirstOrDefault());
        }

        //
        // POST: /Measure/Edit/5

        [HttpPost]
        public ActionResult Edit(string measureName, MeasureModel measureModel)
        {
            try
            {
                _measureList.Find(c => c.name == measureName).performanceImpact = measureModel.performanceImpact;
                _measureList.Find(c => c.name == measureName).quickToImplement = measureModel.quickToImplement;
                _measureList.Find(c => c.name == measureName).name = measureModel.name;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Measure/Delete/5

        public ActionResult Delete(string measureName)
        {
            try
            {
                _measureList.RemoveAll(c => c.name == measureName);
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
        public ActionResult Delete(string measureName, MeasureModel measureModel)
        {
            try
            {
                _measureList.RemoveAll(c => c.name == measureName);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
