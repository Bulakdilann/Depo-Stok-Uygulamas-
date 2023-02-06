using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class StockOperationDetailManager
    {
          GenericRepository<StockOperationDetail> repository=new GenericRepository<StockOperationDetail>();

        public List<StockOperationDetail> GetAllBL()
        {
            return repository.List();
        }

         public void StockOperationDetailAddBL(StockOperationDetail stockOperationDetail) 
        {
          
                repository.Insert(stockOperationDetail);
                
            
            
        }
    }
}
