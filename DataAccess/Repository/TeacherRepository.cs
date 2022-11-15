using Dershane.DataAccsess.DataAccess;
using Dershane.DataAccsess.Repository.IRepository;
using Dershane.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dershane.DataAccsess.Repository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        private readonly AppDbContext _db;
        public TeacherRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
