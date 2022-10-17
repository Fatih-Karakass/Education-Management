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
        public IActionResult Create()
        {
            Lesson lesson = new Lesson();
            return View(lesson);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
            return View(lesson);

            }
            _db.Lesson.Add(lesson);
            _db.SaveChanges();
            
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Remove(int? id)
        {
            if(id==null|| id == 0)
            {
                return NotFound();
            }
            Lesson lesson = _db.Find<Lesson>(id);
            if (lesson == null)
            {
                return NotFound();
            }
            return View(lesson);
        }
        [HttpPost, ActionName("Remove")]
        [AutoValidateAntiforgeryToken]
        public IActionResult RemovePost(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Lesson lesson = _db.Find<Lesson>(id);
            if (lesson == null)
            {
                return NotFound();
            }
            _db.Lesson.Remove(lesson);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Lesson lesson = _db.Find<Lesson>(id);
            return View(lesson);

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return View(lesson);
            }
            _db.Update(lesson);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
