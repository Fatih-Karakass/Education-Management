using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using Ders1.Models;
using Microsoft.EntityFrameworkCore;
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

        //public IEnumerable<Lesson> Aaa()
        //{
        //    return _db.Lesson.Include(u => u.Teacher).ToList();
        //}

    }
}
