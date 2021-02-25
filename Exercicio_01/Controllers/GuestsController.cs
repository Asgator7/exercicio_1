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
                    Nome = "João Marciano",
                    Email = "joaomarciano@hotmail.com",
                    Telefone = "1123252325",
                    Comparecimento = true
                },

                new Guest()
                {
                    Id = 2,
                    Nome = "José Carvalho",
                    Email = "josecarvalho@gmail.com",
                    Telefone = "1225325262",
                    Comparecimento = false
                },

                new Guest()
                {
                    Id = 3,
                    Nome = "Maria Antonieta",
                    Email = "mariaantonieta@bol.com.br",
                    Telefone = "3132226523",
                    Comparecimento = true
                },

                new Guest()
                {
                    Id = 4,
                    Nome = "Carlos Cardoso",
                    Email = "carloscardoso@yahoo.com.br",
                    Telefone = "3432525268",
                    Comparecimento = false
                },

                new Guest()
                {
                    Id = 5,
                    Nome = "Joana Silva",
                    Email = "joanasilva@outlook.com",
                    Telefone = "2023523252"
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
