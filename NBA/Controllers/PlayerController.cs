using LinqToExcel;
using NBA.Data;
using NBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBA.Controllers
{
    public class PlayerController : Controller
    {
        protected ExcelQueryFactory excel;

        // GET: Players
        public ActionResult Index()
        {
            using (var context=new NBAContext())
            {
                var Players = from c in context.Players
                              select c;
                return View(Players);
            }

        }

        // GET: Players/Details/5
        public ActionResult Details(int id)
        {
            using (var context = new NBAContext())
            { 
                var Players = from c in context.Players
                          where c.playerId == id
                          select c;
                return View(Players);
            }
            
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
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

        // GET: Players/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Players/Edit/5
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

        // GET: Players/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Players/Delete/5
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
