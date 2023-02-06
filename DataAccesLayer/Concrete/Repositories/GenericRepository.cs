using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T:class
        // bizim buraya göndereceğimiz parametre Entity class'ları olacağı için T değerine "class" kısıt uygulamış olduk.
    {
        // Bir önceki yapı normalde çalışır. Şu aşamada biz sadece 3 tabloyu temsil eden işlemler için bu yapıyı kurduk. Farklı tablolarımız içinde benzer kodları tekrar takrar yazmak zorunda kalacagız. ve bir noktada yapılan bir değişiklik, birden çok classı etkileyecek. Örnegimizde parmetreli List() metodununda bunu gördük. Bu yapı yönetilebilir bir yapı değil ve yazılımcının üzerinde çok fazla kod yükü oluşturacak. Yani çok daha fazla kod yazmak zorunda kalacak.
        // Bu yapı yerine GenericRepository isminde oluşturduğum bu class ile bu kod yükünden kurtulacağız ve CategoryRepository, ProductRepositor vb sınıfların yerine bu sınıf kullanılacak.
        // Genel olarak Database işlemleri hemen hemen bütün tablolar/Entity sınıflar için aynıdır. bu kodları tekrar tekrar yazmak yerine Generic dediğimiz bu yapılar ile çözüyoruz. yani Design Pattern'lardan Generic Repository Design Pattern'ı ile çözüyor.

       // Context context = new Context();  
        
        Context context = Context.ContextVer(); // BU sayede bir tane nesne oluşturdum ve kimin ihtıyacı varsa o kullanıyor. veri tabannı baglantıları için kullanılır. static oldugu için contextVer metoduna ulaşıyoruz
        DbSet<T> _object;   // sadece bu sekilde yaparsam objenin içi boş döner o yuzden ctor olusturmalıyım. yani(yapıcı metod)
        public GenericRepository() //yapıcı metod oluşturmalıyız yoksa hata olur. contextle baglantı yapıcam
        {
            _object=context.Set<T>();    //CONTEXTTEN GELEN SETİ(HANGİ TİPTEYSE) _OBJEYE BAGLADIK
        }
       public void Delete(int id)
        {
            try
            {
                var result = _object.Find(id);
                _object.Remove(result);
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(" güncelleme hatası.." + Ex.Message);
            }
            //_object.Remove(p);            
            //context.SaveChanges();
        }

        public T Find(int id)
        {
            return _object.Find(id);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            T result = _object.Where(filter).FirstOrDefault();
            return result;
        }

        public void Insert(T p)
        {
            _object.Add(p);  //hangi entityi göndericeksem ona göre işlem yapacak.
            context.SaveChanges();
        }

        public List<T> List()  //geriye değer döndüren returnü yazarız.
        {
            return _object.ToList(); // object ne yolladıysak onu alıcak o olacak depo yollarsam depo turunde dbset olacak.
        }

        public List<T> List(Expression<Func<T, bool>> filter) //list turunde değer dönduruyorum return
        {
            return _object.Where(filter).ToList(); 
        }

        public void Update(T p, int id) //id ile o nesneyi buluyoruz.
        {
            // Güncellenecek neseyi buluyoruz.
            T guncelleneceknNesne=_object.Find(id);
            // Bu nesneye ait bütün propertileri bir değişkene atıyoruz.
            var tumPropertyler=typeof(T).GetProperties();
            //Döngü ile ilgili property lere parametre gönderdiğimin nesnenin içindeki değerleri atıyoruz. Id'yi bunun dışında tutuuyoruz.
            foreach (var property in tumPropertyler)
            {
                if (property.Name!="Id")
                    property.SetValue
                        (guncelleneceknNesne,property.GetValue(p));
                
            }

            context.SaveChanges();  //değişiklikler database kaydedilmiş olacak
        }


    }
}
