using DAL.Concrete;
using DAL.EFCoreContext;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IletisimManager
    {
        private IletisimRepository repository;
        public IletisimManager(MyDbContext context)
        {
            repository = new IletisimRepository(context);
        }
        public Iletisim GetIletisim()
        {
            return repository.GetIletisim();
        }

        public void Update(Iletisim i)
        {
            repository.Update(i);
        }
    }
}
