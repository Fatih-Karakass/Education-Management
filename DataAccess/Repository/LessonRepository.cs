using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using Ders1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        private readonly AppDbContext _db;
        public LessonRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Lesson lesson)
        {
            var lessonFromDb = _db.Lesson.FirstOrDefault(x => x.Id == lesson.Id);

            if (lessonFromDb != null && lesson.Id > 0)
            {
                _db.Update(lesson);
            }
        }
    }
}
