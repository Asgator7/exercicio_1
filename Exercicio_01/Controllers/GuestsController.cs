using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_01.Models;
namespace Exercicio_01.Controllers {
    public class GuestsController : Controller {
        private List<Guest> guests = new List<Guest>();
        public IActionResult Index() {
            return View();
        }
        public IActionResult Create() {
            return View();
        }
        public IActionResult Details() {
            return View();
        }
        public IActionResult Edit() {
            return View();
        }
        public IActionResult Delete() {
            return View();
        }

        //[HttpPost]
        //public ActionResult Details(Guest guest) {

        //}
        //[HttpPost]
        //public ActionResult Edit(Guest guest) {

        //}
        //[HttpPost]
        //public ActionResult Delete(Guest guest) {

        //}
        [HttpPost]
        public IActionResult Create(Guest guest) {
            guests.Add(guest);
            return RedirectToAction("Index");
        }
    }
}
