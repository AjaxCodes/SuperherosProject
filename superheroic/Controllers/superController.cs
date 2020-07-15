using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using superheroic.Data;
using superheroic.Models;

namespace superheroic.Controllers
{
    public class superController : Controller
    {
        private ApplicationDbContext _context;

        // GET: superController
        public superController(ApplicationDbContext context) 
        {
            _context = context;
        
        }        
        public ActionResult Index()
        {
            var superheroes = _context.Supers.ToList();
            return View(superheroes);
        }

        // GET: superController/Details/5
        public ActionResult Details(int id)     // all info here
        {
            return View();
        }

        // GET: superController/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: superController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Super super)
        {
            try
            {
                _context.Supers.Add(super);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: superController/Edit/5
        public ActionResult Edit(int id) // object you are editing   
        {

            return View();
        }

        // POST: superController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Super super)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: superController/Delete/5
        public ActionResult Delete(int id) // stuff goes here too  
        {
            return View();
        }

        // POST: superController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Super super)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
