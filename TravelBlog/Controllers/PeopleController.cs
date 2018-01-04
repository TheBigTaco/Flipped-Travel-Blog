using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

namespace TravelBlog.Controllers
{
    public class PeopleController : Controller
    {

        private TravelBlogDbContext db = new TravelBlogDbContext();

        public IActionResult Index()
        {
            return View(db.People.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisPerson = db.People.FirstOrDefault(Persons => Persons.Id == id);
            return View(thisPerson);
        }

        public IActionResult Create()
        {
            ViewBag.ExperiencesId = new SelectList(db.Experiences, "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person Person)
        {
            db.People.Add(Person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisPerson = db.People.FirstOrDefault(Persons => Persons.Id == id);
            ViewBag.ExperiencesId = new SelectList(db.Experiences, "Id", "Name");
            return View(thisPerson);
            
        }

        [HttpPost]
        public IActionResult Edit(Person Person)
        {
            db.Entry(Person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
			var thisPerson = db.People.FirstOrDefault(Persons => Persons.Id == id);
			return View(thisPerson);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPerson = db.People.FirstOrDefault(Persons => Persons.Id == id);
            db.People.Remove(thisPerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
