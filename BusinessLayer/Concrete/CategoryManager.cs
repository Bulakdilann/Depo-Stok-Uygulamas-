using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAllBL()  //nerden geldiğini anlamak için BL yi yazdık
        {
            return repository.List();
        }
        public string CategoryAddBL(Category category) //void di string yaptık
        {
            string durum="Kaydetme İşlemi Başarılı";  //ilerde farklı bir yöntemle yönetecegiz
            if (category.Name!=null && category.Name!="")  //name alanı boşsa bu işlemi yapma bunun kontrolunu yaptık
            {
                repository.Insert(category); //doluysa işlemi yap genericrepositoryde insert metoduna yolla
            }
            else
            {
                durum="Categori Name Alanı Boş Geçilemez";
            }
            return durum;  //durum nesnesini geriye döndürüyoruz
        }

        public void CategoryUpdateBL(Category category)
        {
            if(category.Id !=0 && category.Name!= "")
            {
                repository.Update(category,category.Id);
            }
        }

         public void CategoryDeleteBL(int id)
        {
            if (id !=0)
            {
                repository.Delete(id);
            }
        }
    }
}
