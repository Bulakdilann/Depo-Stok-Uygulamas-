using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyManager
    {
        GenericRepository<Company> repository =new GenericRepository<Company>();

         public List<Company> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }

         public List<Company> AdaGoreAra(string isim)
        {
           return repository.List(x=>x.FirmaAdi.Contains(isim));
        }

        public void CompanyAddBL(Company company)
        {
            repository.Insert(company);
        }

        public void CompanyDeleteBL(int id)
        {
           repository.Delete(id);
        }

        public void CompanyUpdateBL(Company company)
        {
            repository.Update(company, company.Id);
        }    
    }
}
