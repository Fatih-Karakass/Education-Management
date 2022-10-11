using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            
            return RedirectToAction("Index");
        }
    }
}
