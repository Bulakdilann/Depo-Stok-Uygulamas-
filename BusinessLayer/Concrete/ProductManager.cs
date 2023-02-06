using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ProductManager
    {
        GenericRepository<Product> repository =new GenericRepository<Product>();

          public List<Product> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }

        public List<Product> AdaGoreAra(string isim)
        {
           return repository.List(x=>x.Adi.Contains(isim));
        }

        public void ProductAddBL(Product product)
        {
            repository.Insert(product);
        }

        public void ProductDeleteBL(int id)
        {
           repository.Delete(id);
        }

        public void ProductUpdateBL(Product product)
        {
            repository.Update(product, product.Id);
        }    

        public void StokGuncelleBL(ICollection<StockOperationDetail>stocks, string stokGirisTipi)
        {
            foreach (var stock in stocks)
            {
              Product product= repository.Get(x=>x.Id ==stock.ProductId);
                if (stokGirisTipi=="Giriş İşlemi")
                {
                     product.StokMiktari= product.StokMiktari + stock.Quantity;
                }
                else if(stokGirisTipi =="Çıkış İşlemi")
                {
                    product.StokMiktari= product.StokMiktari - stock.Quantity;
                }
                
                ProductUpdateBL(product);
               
            }
        }

        public Product Find(int id)
        {
            return repository.Find(id);
        }
    }
}
