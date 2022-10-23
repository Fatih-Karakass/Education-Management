using Ders1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface ILessonRepository : IRepository<Lesson>
    {
        void Update(Lesson lesson);
    }
}
