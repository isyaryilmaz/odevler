// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // MatematikIslemleri namespace'inden Hesaplama sınıfının nesnesini oluşturuyoruz
            MatematikIslemleri.Hesaplama hesaplama = new MatematikIslemleri.Hesaplama();

            // Toplama işlemi yapıyoruz
            hesaplama.Topla(5, 7);

            // Çarpma işlemi yapıyoruz
            hesaplama.Carp(4, 6);
        }
    }
}


//Namespace(ad alanı), C# ve diğer programlama dillerinde, sınıfların, metodların, özelliklerin ve diğer türlerin isim çakışmalarını önlemek için gruplanmasını sağlayan bir yapıdır. Bir namespace, belirli bir işlevi yerine getiren sınıfları, metodları ve diğer yapı taşlarını mantıklı bir şekilde düzenlemeye yardımcı olur. Bu, büyük projelerde kodun daha düzenli, yönetilebilir ve anlaşılır olmasını sağlar. Namespace Kullanmanın Avantajları: Ad Çakışmalarını Önleme: Farklı projelerde veya kütüphanelerde benzer isimlere sahip sınıflar olabilir. Namespace kullanarak, aynı isme sahip sınıflar bile farklı namespace’lerde tanımlanarak çakışma engellenebilir. Bu sayede, her iki sınıf da Employee ismiyle tanımlanabilir, ancak bunlar farklı namespace’lerde oldukları için herhangi bir çakışma meydana gelmez.

//Kodun Düzenlenmesi: Kodun farklı işlevleri için ayrı namespace’ler kullanmak, kodu daha modüler hale getirir.Böylece, bir projede farklı özellikleri veya işlevleri gruplayarak, kodun yönetimi daha kolay hale gelir.

//Bakım ve Genişletilebilirlik (Extensibility): Kodun daha açık bir şekilde düzenlenmesi, bakım ve geliştirme süreçlerini kolaylaştırır.Özellikle büyük projelerde, işlevselliği genişletmek daha az karmaşık hale gelir.

//Kodun Tekrar Kullanılabilirliği: Farklı projelerde kullanılacak genel sınıflar ve metotlar için bir namespace oluşturmak, bu sınıfların ve metotların başka projelerde kolayca yeniden kullanılmasına olanak tanır.

//Genişletilebilirlik(Extensibility) Nedir? Genişletilebilirlik(Extensibility), bir yazılımın yeni özellikler eklenerek veya mevcut özellikleri değiştirerek kolayca geliştirilebilmesi veya uzatılabilmesi anlamına gelir.Genişletilebilir bir yazılım, yeni işlevler eklendiğinde mevcut yapıya zarar vermez, bu da yazılımın daha sürdürülebilir ve esnek olmasını sağlar.

//Genişletilebilirlik, yazılımın gelişen gereksinimlere uygun olarak kolayca uyarlanabilmesi için kritik bir özelliktir.Bir yazılımı genişletilebilir hale getirmek, genellikle aşağıdaki yöntemlerle sağlanır:

//Bir Yazılımın Genişletilebilir Olmasını Nasıl Sağlarız? Modüler Tasarım: Yazılımı modüller halinde tasarlamak, her bir bileşenin bağımsız bir şekilde geliştirilmesini ve değiştirilmesini sağlar.Böylece, yeni özellikler eklemek, mevcut işlevleri değiştirmek veya kaldırmak daha kolay hale gelir.

//Örneğin, bir e-ticaret yazılımında ödeme işlemleri, sipariş yönetimi, kullanıcı yönetimi gibi her bir işlevin farklı modüllerde yer alması, bu modüllerin bağımsız olarak genişletilmesini sağlar.

//Interface(Arayüz) Kullanmak: Yazılımın temel işlevlerini interface ile tanımlayarak, farklı implementasyonlar ekleyebiliriz.Bu sayede, bir sınıfın işlevselliği değiştirilmeden, yeni işlevler eklemek mümkün hale gelir.Inheritance(Miras) Kullanmak: Nesne yönelimli programlamanın temel ilkelerinden biri olan miras, bir sınıfın başka bir sınıfın işlevselliğini devralmasını sağlar.Alt sınıflar, üst sınıfların özelliklerini ve metotlarını kullanarak genişletilebilir.Bu, yazılımın temel yapısını değiştirmeden yeni özellikler eklemeyi sağlar. Polymorphism (Çok Biçimlilik): Polymorphism (çok biçimlilik), bir nesnenin farklı şekillerde davranabilmesini sağlar. Bu özellik, yazılımın genişletilebilirliğini artırır çünkü aynı metot farklı şekillerde çalışabilir.Dependency Injection (Bağımlılık Enjeksiyonu): Dependency Injection, bir sınıfın dış bağımlılıklarının dışarıdan verilmesini sağlar.Bu sayede, sınıfların birbirine bağımlılığı azaltılır ve yazılımın genişletilmesi daha kolay hale gelir.

//Örneğin, bir sınıfın veritabanı bağlantısına olan bağımlılığı dışarıdan sağlanabilir. Design Patterns (Tasarım Desenleri): Yazılım geliştirme sırasında yaygın kullanılan tasarım desenleri (design patterns) yazılımın genişletilebilirliğini artırmak için kullanılır. Örneğin, Factory Pattern, Strategy Pattern gibi desenler, yazılımın daha esnek ve genişletilebilir olmasına yardımcı olur.

//Namespace kullanımı, projede kodun düzenlenmesi ve isim çakışmalarının engellenmesi için çok önemlidir. Genişletilebilirlik, bir yazılımın gelecekteki ihtiyaçlara uygun olarak kolayca geliştirilmesi ve yeniliklerin eklenmesi yeteneğidir. Bir yazılımın genişletilebilir olmasını sağlamak için modüler tasarım, interface kullanımı, miras, polimorfizm, bağımlılık enjeksiyonu ve tasarım desenleri gibi yöntemler kullanılabilir.