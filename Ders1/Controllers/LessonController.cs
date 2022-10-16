using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class LessonController : Controller
    {
        private readonly AppDbContext _db;
        public LessonController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Lesson> list = _db.Lesson.ToList();
            return View(list);
        }
    }
}
