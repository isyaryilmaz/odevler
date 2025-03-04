// See https://aka.ms/new-console-template for more information
using erişimbelirleyiciler_ve_Değişkenler;

Console.WriteLine("Hello, World!");




   
        // User sınıfından bir nesne oluşturuyoruz
        User kullanici = new User("Ahmet Yılmaz", 30, "ahmet.yilmaz@example.com");

        // Bilgileri gösteriyoruz
        kullanici.BilgileriGoster();

        // Getter ve Setter metotlarıyla ad soyad ve yaş değiştiriyoruz
        kullanici.SetAdSoyad("Mehmet Yılmaz");
        kullanici.SetYas(35);

        // Güncellenmiş bilgileri tekrar gösteriyoruz
        Console.WriteLine("\nGüncellenmiş Bilgiler:");
        kullanici.BilgileriGoster();

//C# dilinde kullanılan erişim belirleyiciler (access modifiers), bir sınıf, özellik, metot veya alanın diğer sınıflardan, metodlardan ve dış dünyadan nasıl erişilebileceğini belirleyen anahtar kelimelerdir. Bu erişim belirleyiciler, nesne yönelimli programlama (OOP) ilkeleriyle bağlantılı olarak, kapsülleme, veri güvenliği, ve yazılımın daha modüler olmasını sağlar.

//C#’ta Kullanılan Erişim Belirleyiciler: public private protected internal Bu erişim belirleyicilerin her biri farklı erişim seviyeleri sağlar.

//public (Herkese Açık) public erişim belirleyicisi, o sınıfın, metodun veya özelliğin herkes tarafından erişilebilir olduğunu belirtir. Yani, başka sınıflardan veya projelerden herhangi bir kısıtlama olmadan erişilebilir.
//Gerçek Hayattan Örnek: Bir kamu parkı düşünün. Herkes parka gelip oyun oynayabilir, yürüyüş yapabilir. Yani park public bir yer gibidir.Kimseye özel bir erişim kısıtlaması yoktur. 2. private (Özel) private erişim belirleyicisi, o sınıfın, metodun veya özelliğin sadece bulunduğu sınıf içinde erişilebilir olduğunu belirtir. Başka bir sınıftan erişilemez.

//Gerçek Hayattan Örnek: Bir özel oda düşünün. Bu odaya sadece oda sahibinin erişimi vardır. Diğer insanlar bu odaya giremezler. 3. protected (Korunmuş) protected erişim belirleyicisi, o sınıfın ve o sınıftan türetilmiş (inheritance) alt sınıfların erişebileceği bir özelliktir veya metoddur. Yani, yalnızca o sınıfın ve türetilmiş sınıfların içinde erişilebilir.

//Gerçek Hayattan Örnek: Bir şirketin yönetim odası düşünün. Bu oda, yönetici ve yöneticilerin altındaki çalışanlar için erişilebilir. Yani, sadece bazı kişiler bu odada bulunabilir. 4. internal (Dahili) internal erişim belirleyicisi, o sınıfın, metodun veya özelliğin aynı proje (assembly) içinde erişilebilir olduğunu belirtir. Farklı projelerden erişilemez.

//Gerçek Hayattan Örnek: Bir fabrika düşünün. Fabrikadaki makineler sadece fabrikadaki çalışanlar tarafından kullanılabilir. Diğer fabrikalardan veya dışarıdan kimse bu makinelere erişemez. Erişim Belirleyicilerin Nesne Yönelimli Programlamadaki Rolü Erişim belirleyicilerin nesne yönelimli programlamadaki (OOP) rolü çok önemlidir. OOP'nin temel ilkelerinden biri olan kapsülleme (encapsulation), verilerin dışarıdan erişimini kontrol etmeyi sağlar. Bu, verilerin ve işlevlerin yalnızca gerekli yerlerde ve doğru bir şekilde kullanılmasını sağlar.

//Kapsülleme (Encapsulation):

//Private erişim belirleyicisi, veri gizliliği sağlar. Verilerin dışarıdan doğrudan erişilememesi, sadece belirli metotlar üzerinden erişilmesini sağlamak, hata riskini azaltır ve yazılımın güvenliğini artırır. Public erişim belirleyicisi ise dış dünyadan sınıfın işlevlerine ve verilerine serbestçe erişimi sağlar. Miras (Inheritance):

//Protected erişim belirleyicisi, türetilmiş sınıfların üst sınıfın özelliklerine ve metotlarına erişebilmesini sağlar. Bu da OOP’nin miras (inheritance) özelliğini kullanarak yeni sınıflar oluşturulmasını ve eski sınıflardaki işlevlerin genişletilmesini mümkün kılar. Modülerlik:

//Internal erişim belirleyicisi, sınıfların yalnızca belirli bir projede (assembly) kullanılmasına olanak tanır. Bu, yazılımın modüler olmasını ve farklı projelerde tekrar kullanılabilmesini sağlar. Veri Güvenliği:

//Private erişim belirleyicisi, dışarıdan veri manipülasyonuna karşı koruma sağlar ve getter/setter metotları kullanılarak verilere sadece kontrol edilen şekilde erişilmesini sağlar. Özetle: Erişim belirleyiciler, yazılım geliştirme sürecinde kontrollü erişim sağlamak için kullanılır. Bu belirleyiciler:

//public dış dünyaya açık erişim sağlar. private sadece sınıf içinden erişim sağlar. protected sadece sınıf içinden ve türetilmiş sınıflardan erişim sağlar. internal yalnızca aynı projede(assembly) erişim sağlar. Nesne yönelimli programlamada (OOP), bu erişim belirleyiciler kapsülleme, miras ve modülerlik gibi ilkeleri destekler ve yazılımın güvenli, düzenli ve genişletilebilir olmasına katkı sağlar.