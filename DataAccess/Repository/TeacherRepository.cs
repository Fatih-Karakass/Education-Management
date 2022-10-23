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
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly AppDbContext _db;
        public TeacherRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Teacher teacher)
        {

            if (teacher != null && teacher.Id > 0)
            {
                _db.Teachers.Update(teacher);
            }
        }
    }
}
