// See https://aka.ms/new-console-template for more information
using hafta2.ödev.Arabalar;
using System.Diagnostics.Metrics;
using System.Numerics;

Console.WriteLine("Hello, World!");




Araba ar = new Araba();
ar.markamodelGit("BMW", " E36");
ar.markamodelGit("Mercedes", " c63 amg");
ar.markamodelGit("Porsche", " Gt3 rs");
ar.markamodelGit("Togg", " T10 F");







Bmw bm = new Bmw();
bm.marka = "BMW";
bm.model = "e36";
bm.sifat = "düz vitestir";
bm.cins = "coupe dir ";


Mercedes mc = new Mercedes();
mc.marka = "Mercedes";
mc.model = "c63 amg";
mc.sifat = "otomatiktir";
mc.cins = "coupe dir";


Porsche pc = new Porsche();
pc.marka = "Porsche";
pc.model = "Gt3 rs";
pc.sifat = "otomatiktir";
pc.cins = "sedan dır";


Togg tg = new Togg();
tg.marka = "Togg";
tg.model = "T10 F";
tg.sifat = "düz vitestir";
tg.cins = "sedan dır";

DüzVites dz = new DüzVites();
dz.DüzVitesOku(bm.marka, bm.model, bm.sifat,bm.cins);
dz.DüzVitesOku(tg.marka, tg.model, tg.sifat,tg.cins);



Otomatik ot = new Otomatik();

ot.OtomatikVitesOku(mc.marka, mc.model, mc.sifat, mc.cins);
ot.OtomatikVitesOku(pc.marka, pc.model, pc.sifat, pc.cins);





//ABSTRACT CLASS(SOYUT SINIFI) NEDİR? Abstract Class (Soyut Sınıf), nesne yönelimli programlamada (OOP) kullanılan ve genellikle diğer sınıflar için bir temel sınıf görevi gören bir sınıf türüdür. Soyut sınıflar tamamlanmamış (incomplete) sınıflardır ve genellikle alt sınıflar (subclasses) için bir şablon (template) görevi görürler. Soyut sınıflar, en az bir tane soyut (abstract) metot içermek zorundadır. Soyut metotlar, sadece tanımlanır ama içi doldurulmaz. Alt sınıflar, bu soyut metotları kendilerine göre yeniden tanımlamak (override) zorundadır.

//ABSTRACTİON ( SOYUTLAMA ) NEDİR ? Abstraction (Soyutlama), nesne yönelimli programlamada (OOP) kullanılan temel prensiplerden biridir. Gereksiz detayları gizleyerek, yalnızca ilgili bilgileri ortaya çıkarma işlemidir. • Kullanıcıya sadece gerekli olan fonksiyonları gösterir ve karmaşıklığı gizler. • İç uygulama detaylarını bilmeye gerek kalmadan bir nesneyi veya sistemi kullanmamızı sağlar. • Soyut sınıflar (abstract class) veya arayüzler(interface) kullanılarak gerçekleştirilir.

//POLYMORPHİSM(ÇOK BİÇİMLİLİK) NEDİR? Polymorphism(Çok Biçimlilik), nesne yönelimli programlamada (OOP) aynı isimdeki bir metodun farklı şekillerde davranabilmesini sağlayan bir kavramdır. ✔ Metotların farklı sınıflarda farklı şekillerde uygulanmasını sağlar. ✔ Kod tekrarını azaltır ve esnek bir yapı oluşturur. ✔ İki şekilde uygulanabilir: • Metot Overriding(Ezme – Runtime Polymorphism) → Kalıtım(Inheritance) ile olur. • Metot Overloading(Aşırı Yükleme – Compile-time Polymorphism) → Aynı isimli metodun farklı parametrelerle kullanılmasıdır.




