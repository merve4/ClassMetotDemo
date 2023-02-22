// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Musteri musteri1 = new Musteri();

musteri1.MusteriTcNo = 12659245360;
musteri1.MusteriAdSoyad = "Hakan Bahadır";
musteri1.Yasadigiİl = "İstanbul";
musteri1.HesapNumarasi = 654123;

Musteri musteri2 = new Musteri();

musteri2.MusteriTcNo = 16324126961;
musteri2.MusteriAdSoyad = "Feride Kozan";
musteri2.Yasadigiİl = "Ankara";
musteri2.HesapNumarasi = 412345;

Musteri musteri3 = new Musteri();

musteri3.MusteriTcNo = 45651023985;
musteri3.MusteriAdSoyad = "Yunus Demir";
musteri3.Yasadigiİl = "İzmir";
musteri3.HesapNumarasi = 169456;

Musteri musteri4 = new Musteri();

musteri4.MusteriTcNo = 16324126961;
musteri4.MusteriAdSoyad = "Hasan Mükül";
musteri4.Yasadigiİl = "Aydın";
musteri4.HesapNumarasi = 818321;

Musteri musteri5 = new Musteri();

musteri5.MusteriTcNo = 46376448650;
musteri5.MusteriAdSoyad = "Leyla Ardıl";
musteri5.Yasadigiİl = "Ankara";
musteri5.HesapNumarasi = 654267;

//Musteri[] musteriler = new Musteri[]
//{
//    musteri1,musteri2,musteri3,musteri4,musteri5
//};

//foreach (var musteri in musteriler)
//{
//    Console.WriteLine(musteri.MusteriTcNo+" "+musteri.MusteriAdSoyad+" "+musteri.Yasadigiİl+" "+musteri.HesapNumarasi);
//}

MusteriManager musterimanager = new MusteriManager();

musterimanager.MusteriEkle(musteri1);
musterimanager.MusteriEkle(musteri2);
musterimanager.MusteriEkle(musteri3);
musterimanager.MusteriEkle(musteri4);
musterimanager.MusteriEkle(musteri5);

Console.WriteLine("   ");
Console.WriteLine("---------Müşteriler Listesi--------");

Musteri[] musterilerliste = new Musteri[]
{
    musteri1,musteri2,musteri3,musteri4,musteri5
};
musterimanager.MusteriListele(musterilerliste);
Console.WriteLine("    ");
Console.WriteLine("---------Silinen Müşteriler-------");

musterimanager.MusteriSil(musteri1);
musterimanager.MusteriSil(musteri2);
musterimanager.MusteriSil(musteri3);
musterimanager.MusteriSil(musteri4);
musterimanager.MusteriSil(musteri5);





