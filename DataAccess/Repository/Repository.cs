
using Dershane.DataAccsess.DataAccess;
using Dershane.DataAccsess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Dershane.DataAccsess.Repository
{

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;
        private readonly DbSet<T> dbSet;

        public Repository(AppDbContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }

        public async void AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);

        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter)
        {
            IQueryable<T> query = dbSet;

            if (filter == null)
            {
                return query.FirstOrDefault();
            }

            return await query.Where(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet;

            if (filter == null)
            {
                return query.ToList();
            }

            return await query.Where(filter).ToListAsync();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
