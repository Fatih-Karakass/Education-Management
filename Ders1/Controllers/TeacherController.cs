using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // Index Action
        public IActionResult Index()
        {
            IEnumerable<Teacher> list = unitOfWork.Teacher.GetAllAsync().Result;
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
            // Server side Validation
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }

            unitOfWork.Teacher.AddAsync(teacher);
            unitOfWork.Save();

            TempData["success"] = "Teacher created succeffully";
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                
                return NotFound();
            }
            Teacher teacher = unitOfWork.Teacher.GetAsync(x => x.Id == id).Result;

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

            unitOfWork.Teacher.Update(teacher);
            unitOfWork.Save();

            TempData["success"] = "Teacher updated succeffully";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Teacher teacher = unitOfWork.Teacher.GetAsync(x => x.Id == id).Result;

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

            Teacher teacher = unitOfWork.Teacher.GetAsync(x => x.Id == id).Result;
            if (teacher == null)
            {
                return NotFound();
            }

            unitOfWork.Teacher.Remove(teacher);
            unitOfWork.Save();

            TempData["success"] = "Teacher deleted succeffully";

            return RedirectToAction(nameof(Index));
        }
    }
}
