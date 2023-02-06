using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class UnitManager
    {
        GenericRepository<Unit> repository =new GenericRepository<Unit>();

          public List<Unit> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }

        public void UnitAddBL(Unit unit)
        {
            repository.Insert(unit);
        }

        public void UnitDeleteBL(int id)
        {
           repository.Delete(id);
        }

        public void UnitUpdateBL(Unit unit)
        {
            repository.Update(unit, unit.Id);
        }    
    }
}
