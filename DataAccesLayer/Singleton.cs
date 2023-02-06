//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccesLayer
//{
//   public class Singleton
//    {
//        //Singleton dizaynda amaç her istenildiğinde nesne üretmenin önüne geçmektir. istenilen nesneden bir tane üretilir. Daha sonra ihtiyaç duyuldugunda bu nesne tekrar tekrar gönderilir
//        //Bu classdan yeni bir nesne üretmenin önüne geçmek için Constructor/Yapıcı Metodu private olarak işaretliyorum. bu durumda Singleton Class'ından bir nesne üretilemeyecek.
//        private Singleton()  //sadece burda ulaşılır. singletondan class uretilmesin
//            //bana bir tane nesne üretecek.
//        {

//        }

//        private static Context context;  //disarıdan erişimini engellemiş oldum.
        
//        public static Context ContextVer()  //newlemeden direk içindeki metoda ulaşabiliyorum
//        {
//            if (context==null) //null ise yeni nesne yarat
//            {
//                context=new Context(); // varsa var olan nesneyi döndürecek.
//            }
//            return context;
//        }
//    }
//}
