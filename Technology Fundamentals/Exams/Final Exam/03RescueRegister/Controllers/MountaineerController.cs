using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineers = db.Mountaineers.ToList();
                return this.View(mountaineers);
            }

        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            if (string.IsNullOrEmpty(mountaineer.Name)
                || mountaineer.Age.Equals(null)
                || string.IsNullOrEmpty(mountaineer.Gender)
                || string.IsNullOrEmpty(mountaineer.LastSeenDate))
            {
                return RedirectToAction("Index");
            }

            using (var db = new RescueRegisterDbContext())
            {
                Mountaineer b = new Mountaineer
                {
                    Name = mountaineer.Name,
                    Age = mountaineer.Age,
                    Gender = mountaineer.Gender,
                    LastSeenDate = mountaineer.LastSeenDate
                };

                db.Mountaineers.Add(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToEdit = db.Mountaineers.Find(id);

                return View(mountaineerToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Update(mountaineer);
                db.SaveChanges();
            }

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new RescueRegisterDbContext())
            {
                var mountaineerToDelete = db.Mountaineers.Find(id);

                return View(mountaineerToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db = new RescueRegisterDbContext())
            {
                db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}