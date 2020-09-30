using DAL.EFCoreContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Table;
        protected MyDbContext db;
        public Repository(MyDbContext context)
        {
            Table = context.Set<T>();
            db = context;
        }

        public async Task Add(T entity)
        {
            Table.Add(entity);
            await Save();
        }

        public async Task<List<T>> All()
        {
            return await Table.ToListAsync();
        }

        public async Task Delete(int id)
        {
            T temp = await GetById(id);
            Table.Remove(temp);
            await Save();
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            Table.Update(entity);
            await Save();
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
    }
}
