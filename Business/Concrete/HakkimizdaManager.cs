using DAL.Concrete;
using DAL.EFCoreContext;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HakkimizdaManager
    {
        private HakkimizdaRepository repository;
        public HakkimizdaManager(MyDbContext context)
        {
            repository = new HakkimizdaRepository(context);
        }
        public Hakkimizda GetHakkimizda()
        {
            return repository.GetHakkimizda();
        }

        public void Update(Hakkimizda h)
        {
            repository.Update(h);
        }
    }
}
