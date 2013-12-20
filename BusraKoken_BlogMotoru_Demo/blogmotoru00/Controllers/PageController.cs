﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMotoru00.Models;

namespace BlogMotoru00.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class PageController : Controller
    {
        private Entities db = new Entities();

        [AllowAnonymous]
        [ChildActionOnly]
        public ActionResult PageMenu()
        {
            var pages = db.Pages.ToList();
            return PartialView(pages);
        }

        //
        // GET: /Page/
        
        public ActionResult Index()
        {
            return View(db.Pages.ToList());
        }

        //
        // GET: /Page/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id = 0)
        {
            Page page = db.Pages.Find(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        //
        // GET: /Page/Create
        
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Page/Create
       
        [HttpPost]
        public ActionResult Create(Page page)
        {
            if (ModelState.IsValid)
            {
                db.Pages.Add(page);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(page);
        }

        //
        // GET: /Page/Edit/5
        
        public ActionResult Edit(int id = 0)
        {
            Page page = db.Pages.Find(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        //
        // POST: /Page/Edit/5
        
        [HttpPost]
        public ActionResult Edit(Page page)
        {
            if (ModelState.IsValid)
            {
                db.Entry(page).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(page);
        }

        //
        // GET: /Page/Delete/5
        
        public ActionResult Delete(int id = 0)
        {
            Page page = db.Pages.Find(id);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        //
        // POST: /Page/Delete/5
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Page page = db.Pages.Find(id);
            db.Pages.Remove(page);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}