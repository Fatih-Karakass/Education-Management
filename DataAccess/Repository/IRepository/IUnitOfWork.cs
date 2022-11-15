using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dershane.DataAccsess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILessonRepository Lesson { get; }

        ITeacherRepository Teacher { get; }

        void Save();
    }
}
