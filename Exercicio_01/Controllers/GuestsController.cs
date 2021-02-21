using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_01.Models;
namespace Exercicio_01.Controllers {
    public class GuestsController : Controller {
        private static IList<Guest> ListGuests = new List<Guest>
            {
                new Guest()
                {
                    Id = 1,
                    Nome = "Notebooks",
                    Email = "Teste",
                    Telefone = "teste"
                },

                new Guest()
                {
                    Id = 2,
                    Nome = "Monitores",
                    Email = "Teste",
                    Telefone = "teste"
                },

                new Guest()
                {
                    Id = 3,
                    Nome = "Impressoras",
                    Email = "Teste",
                    Telefone = "teste"
                },

                new Guest()
                {
                    Id = 4,
                    Nome = "Mouses",
                    Email = "Teste",
                    Telefone = "teste"
                },

                new Guest()
                {
                    Id = 5,
                    Nome = "Desktops",
                    Email = "Teste",
                    Telefone = "teste"

                }
        };
        public IActionResult Index() {
            return View(ListGuests);
        }
        public IActionResult Create() {
            return View();
        }
        public IActionResult Details(long id) {
            return View(ListGuests.Where(m => m.Id == id).First());
        }
        public IActionResult Edit(long id) {
            return View(ListGuests.Where(m => m.Id == id).First()); ;
        }
        public IActionResult Delete(long id) {
            return View(ListGuests.Where(m => m.Id == id).First());
        }

        [HttpPost]
        public ActionResult Edit(Guest guest) {
            ListGuests.Remove(ListGuests.Where(c => c.Id == guest.Id).First());
            ListGuests.Add(guest);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(Guest guest) {
            ListGuests.Remove(ListGuests.Where(c => c.Id == guest.Id).First());
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Create(Guest guest) {
            ListGuests.Add(guest);
            guest.Id = ListGuests.Select(m => m.Id).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}
