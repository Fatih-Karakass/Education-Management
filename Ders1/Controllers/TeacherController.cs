using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;

        public TeacherController(AppDbContext _db)
        {
            this._db = _db;
        }

        // Index Action
        public IActionResult Index()
        {
            IEnumerable<Teacher> list = _db.Teachers.ToList();
            return View(list);
        }

        // Get
        public IActionResult Create()
        {
            Teacher teacher = new Teacher();
            return View(teacher);
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            _db.Add(teacher);
            _db.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Teacher teacher = _db.Find<Teacher>(id);

            return View(teacher);
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            _db.Update(teacher);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Teacher teacher = _db.Find<Teacher>(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Teacher teacher = _db.Find<Teacher>(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _db.Remove(teacher);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
