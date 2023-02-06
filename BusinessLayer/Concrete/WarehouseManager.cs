using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WarehouseManager
    {
        GenericRepository<Warehouse> repository =new GenericRepository<Warehouse>();

          public List<Warehouse> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }

        public void WarehouseAddBL(Warehouse warehouse)
        {
            repository.Insert(warehouse);
        }

        public void WarehouseDeleteBL(int id)
        {
           repository.Delete(id);
        }

        public void WarehouseUpdateBL(Warehouse warehouse)
        {
            repository.Update(warehouse , warehouse.Id);
        }    
    }
}
