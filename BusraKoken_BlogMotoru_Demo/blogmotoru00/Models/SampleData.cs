using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMotoru00.Models
{
        public class SampleData : DropCreateDatabaseIfModelChanges<Entities> // DropCreateDatabaseIfModelChanges DropCreateDatabaseAlways
    {
            protected override void Seed(Entities context)
            {


                new List<Page>
            {
                new Page{ Title="Hakkimizda" , Body="Sanalkurs.Net", Date=DateTime.Now},
                new Page{ Title="İletişim" , Body="Sanalkurs@gmail.com", Date=DateTime.Now}

            }.ForEach(a => context.Pages.Add(a));


            var categories= new List<Category>
            {
                new Category { Name = "ASP.NET" },
                new Category { Name = "Java" },
                new Category { Name = "PHP" },
                
            };
                categories.ForEach(c => context.Categories.Add(c));

                new List<Post>
                {
                new Post {Categories=categories.Single(c=> c.Name=="ASP.NET"),Title="ASP Nedir ?",Body="ASP.NET, Microsoft tarafından geliştirilmiş bir web uygulama gelişimi teknolojisidir. Özdevinimli (dinamik) web sayfaları, web uygulamaları ve XML tabanlı web hizmetleri yaratılmasına olanak sağlar. Aynı işletme tarafından geliştirilen .Net çatısı'nın (framework) parçası, ve artık işletmece desteklenmeyen ASP teknolojisinin devamını teşkil etmiştir.Her ne kadar isim benzerliği olsa da ASP.NET, ASP'ye oranla çok ciddi bir değişim geçirmiştir. ASP.NET kodu ortak dil çalışma zamanı (ingilizce - common language runtime) altyapısına dayalı çalışır, diğer bir deyişle, yazılımcılar .Net çatısı tarafından desteklenen tüm dilleri ASP.NET uygulamaları geliştirmek için kullanabilirler. Yani, Java teknolojisinde olduğu gibi, yazılımcı tarafından yazılan kod, çalıştırılmadan önce sanal bir yazılım katmanı tarafından ortak bir dile çevirilmektedir.",Abstract="ASP.NET, Microsoft tarafından geliştirilmiş bir web uygulama gelişimi teknolojisidir. Özdevinimli (dinamik) web sayfaları, web uygulamaları ve XML tabanlı web hizmetleri yaratılmasına olanak sağlar. Aynı işletme tarafından geliştirilen .Net çatısı'nın (framework) parçası, ve artık işletmece desteklenmeyen ASP teknolojisinin devamını teşkil etmiştir.Her ne kadar isim benzerliği olsa da ASP.NET, ASP'ye oranla çok ciddi bir değişim geçirmiştir. ASP.NET kodu ortak dil çalışma zamanı (ingilizce - common language runtime) altyapısına dayalı çalışır, diğer bir deyişle, yazılımcılar .Net çatısı tarafından desteklenen tüm dilleri ASP.NET uygulamaları geliştirmek için kullanabilirler.",Date=DateTime.Now},
                new Post {Categories=categories.Single(c=> c.Name=="Java"),Title="Java Nedir ?",Body="Java, Sun Microsystems mühendislerinden James Gosling tarafından geliştirilmeye başlanmış açık kodlu, nesneye yönelik, zeminden bağımsız, yüksek verimli, çok işlevli, yüksek seviye, adım adım işletilen (yorumlanan-interpreted) bir dildir.Java, Sun Microsystems'den James Gosling tarafından geliştirilen bir programlama dilidir (Sun Microsystem'in şu anda Oracle Corporation ile bağlı ortaklığı bulunmaktadır) ve 1995 yılında Sun Microsystems'in çekirdek bileşeni olarak piyasaya sürülmüştür. Bu dil C ve C++'dan birçok sözdizim türetmesine rağmen bu türevler daha basit nesne modeli ve daha az düşük seviye olanaklar içerir",Abstract="Java, Sun Microsystems mühendislerinden James Gosling tarafından geliştirilmeye başlanmış açık kodlu, nesneye yönelik, zeminden bağımsız, yüksek verimli, çok işlevli, yüksek seviye, adım adım işletilen (yorumlanan-interpreted) bir dildir.",Date=DateTime.Now},
                new Post {Categories=categories.Single(c=> c.Name=="PHP"),Title="PHP Nedir ?",Body="PHP : Hypertext Preprocessor (Aslen: Personal Home Page - Kişisel Ana Sayfa) , internet için yaratılmış, sunucu taraflı, çok geniş kullanımlı, genel amaçlı, HTML içerisine gömülebilen betik ve programlama dilidir[1]. İlk kez 1995 ylında Rasmus Lerdorf tarafından yaratılan PHP'nin geliştirilmesi bugün PHP topluluğu tarafından sürüdürülmektedir. Ocak 2013 itibariyle 244 milyondan fazla web sitesi PHP ile çalışırken, 2.1 milyon web sunucusunda PHP kurulumu bulunmaktadır.PHP kodları PHP işleme modülü bulunan bir web sunucusu tarafından yorumlanır ve çıktı olarak web sayfası üretilir. Bu kodlar veriyi işlemek üzere harici bir dosyaya kaydedilerek çağırılabildiği gibi doğrudan HTML kodunun içine de gömülebilir. PHP zaman içinde bir komut satırı arayüzü sunacak şekilde evrilmiştir, PHP-GTK yardımıyla grafiksel masaüstü uygulaması geliştirmek de mümkündür.",Abstract="PHP : Hypertext Preprocessor (Aslen: Personal Home Page - Kişisel Ana Sayfa) , internet için yaratılmış, sunucu taraflı, çok geniş kullanımlı, genel amaçlı, HTML içerisine gömülebilen betik ve programlama dilidir.",Date=DateTime.Now}
 
                }.ForEach(p=> context.Posts.Add(p));

            }
    }
}