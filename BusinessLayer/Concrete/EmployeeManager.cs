using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager
    {
         GenericRepository<Employee> repository =new GenericRepository<Employee>();

         public List<Employee> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }

        public void EmployeeAddBL(Employee employee)
        {
            repository.Insert(employee);
        }
         public List<Employee> AdaGoreAra(string isim)
        {
           return repository.List(x=>x.Adi.Contains(isim));
        }

         public List<Employee> AktifOlanlar()
        {
           return repository.List(x=>x.AktifMi==true);
        }

           public List<Employee> AktifOlmayanlar()
        {
           return repository.List(x=>x.AktifMi==false);
        }

        public void EmployeeDeleteBL(int id)
        {
           repository.Delete(id);
        }

        public void EmployeeUpdateBL(Employee employee)
        {
            repository.Update(employee , employee.Id);
        }    

        public bool IsUserExist(string kullaniciAdi, string sifre)
        {
            bool result =false;

            Employee employee=repository.Get(x=>x.KullaniciAdi==kullaniciAdi && x.Sifre==sifre && x.AktifMi==true);

            if (employee !=null)
            {
                result=true;
            }
            

            return result;
        }

    }
}
