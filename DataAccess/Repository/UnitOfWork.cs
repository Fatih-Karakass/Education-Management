using DataAccess.Repository.IRepository;
using Ders1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _db;
        public ILessonRepository Lesson { get; private set; }

        public ITeacherRepository Teacher { get; private set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Lesson = new LessonRepository(_db);
            Teacher = new TeacherRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
