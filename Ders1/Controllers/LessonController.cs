using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class LessonController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public LessonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Lesson> list = unitOfWork.Lesson.GetAll();
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
            unitOfWork.Lesson.Add(lesson);
            unitOfWork.Save();
            
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Remove(int? id)
        {
            if(id==null|| id == 0)
            {
                return NotFound();
            }
            Lesson lesson = unitOfWork.Lesson.Get(x => x.Id == id);
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
            
            Lesson lesson = unitOfWork.Lesson.Get(x => x.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }
            unitOfWork.Lesson.Remove(lesson);
            unitOfWork.Save();

            return RedirectToAction(nameof(Index));

        }
        
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Lesson lesson = unitOfWork.Lesson.Get(x => x.Id == id);
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
            unitOfWork.Lesson.Update(lesson);
            unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
