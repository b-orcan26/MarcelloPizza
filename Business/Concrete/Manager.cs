using Business.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Manager<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;
        public Manager(IRepository<T> _repository)
        {
            repository = _repository;
        }

        public async Task Add(T entity)
        {
            await repository.Add(entity);
        }

        public async Task<List<T>> All()
        {
           return await repository.All();
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(T entity)
        {
           await repository.Update(entity);
        }
    }
}
