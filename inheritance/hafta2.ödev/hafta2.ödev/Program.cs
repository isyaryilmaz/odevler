// See https://aka.ms/new-console-template for more information
using hafta2.ödev.Arabalar;

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





