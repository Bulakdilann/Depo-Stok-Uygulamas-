using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class StockOperationManager
    {
        GenericRepository<StockOperation> repository=new GenericRepository<StockOperation>();

        public List<StockOperation> GetAllBL()
        {
            return repository.List();
        }

         public void StockOperationAddBL(StockOperation stockOperation) 
        {
            if (stockOperation.OperationDate!=null && stockOperation.CompanyId!=0 && stockOperation.StockOperationType!="")
            {
                repository.Insert(stockOperation);
                ProductManager manager=new ProductManager();
                manager.StokGuncelleBL(stockOperation.stockOperationDetails, stockOperation.StockOperationType);
            }
            
        }
         public List<StockOperation> Girisİslemi()
        {
           return repository.List(x=>x.StockOperationType=="Giriş İşlemi");
        }

        public List<StockOperation> Cikisİslemi()
        {
           return repository.List(x=>x.StockOperationType=="Çıkış İşlemi");
        }

         public void StockOperationUpdateBL(StockOperation stockOperation) 
        { 
             if(stockOperation.Id!=0 && stockOperation.OperationDate!=null && stockOperation.CompanyId!=0 && stockOperation.StockOperationType!="")
            {
                repository.Update(stockOperation,stockOperation.Id);
            }
            
        }

        public void StockOperationDeleteBL(int id) 
        { 
            //Stock Operation tablosundan bir veri silmek istiyorsak, bu metoda sadece ıd'sini göndermemiz yeterli. repository delete(id) he stockoperatıon tablosundan heöde ilişiki tablo olan stockoperationdetails tablosundan ilgili kayıtları siliyor. fakat, bu tablolarda yapılan ekleme ve silme işlemi OperationType türüne göre Product tablosundaki ürün miktarı da değişmelidir. asağıdaki kodlarla stockopertion tablosundan silme işlemi yapılmadan önce stock miktari düzeltiliyor.

            //bunun için öncelikle stockoperation tablosundan hangi Product'ların olduğu bulunuyor. buna göre product tablosundan ilgili product getiriliyor. işlem türüne göre product tablosu güncelleniyor.
            //son olarak da stockoperation ve stockoperationDetails tablosundan ilgili kayıtlar siliniyor.
             if (id !=0)
            {
                StockOperation stockOperation=Find(id);
               

                foreach (var sod in  stockOperation.stockOperationDetails)
                {
                    ProductManager manager=new ProductManager();
                    Product p= manager.Find(sod.ProductId);
                     if (stockOperation.StockOperationType=="Giriş İşlemi")
                {
                        p.StokMiktari=p.StokMiktari+sod.Quantity;
                }
                    else if(stockOperation.StockOperationType=="Çıkış İşlemi")
                    {
                         p.StokMiktari=p.StokMiktari-sod.Quantity;
                    }
                 
                   manager.ProductUpdateBL(p);
                } 
                 
                
                

                 //manager.StokGuncelleBL(stockOperation.stockOperationDetails, stockOperation.StockOperationType);
                 repository.Delete(id);
            }
            
        }

        public StockOperation Find(int id)
        {
            return repository.Find(id);
        }
    }
}
