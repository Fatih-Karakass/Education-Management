using Dershane.DataAccsess.DataAccess;
using Dershane.DataAccsess.Repository.IRepository;
using Dershane.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dershane.DataAccsess.Repository
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
