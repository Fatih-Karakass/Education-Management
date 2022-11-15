using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            IEnumerable<Lesson> list = unitOfWork.Lesson.GetAllAsync().Result;
            return View(list);
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TeacherList = unitOfWork.Teacher.GetAllAsync().Result
                .Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });

            ViewBag.ListOfTeachers = TeacherList;

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
            unitOfWork.Lesson.AddAsync(lesson);
            unitOfWork.Save();
            TempData["success"] = "Lesson created succesffully";

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Remove(int? id)
        {
            if(id==null|| id == 0)
            {
                return NotFound();
            }
            Lesson lesson = unitOfWork.Lesson.GetAsync(x => x.Id == id).Result;
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
            
            Lesson lesson = unitOfWork.Lesson.GetAsync(x => x.Id == id).Result;
            if (lesson == null)
            {
                return NotFound();
            }
            unitOfWork.Lesson.Remove(lesson);
            unitOfWork.Save();
            TempData["success"] = "Lesson Remove succesffully";

            return RedirectToAction(nameof(Index));

        }
        
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Lesson lesson = unitOfWork.Lesson.GetAsync(x => x.Id == id).Result;

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
            TempData["success"] = "Lesson updated succesffully";

            return RedirectToAction(nameof(Index));
        }

        /*
        [HttpGet]
        public IActionResult Aaa ()
        {

            IEnumerable<Lesson> list = unitOfWork.Lesson.Aaa();
            return Json(list);
        }
        */
    }
}
