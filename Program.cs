using System;

namespace ClasMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Aslan";
            musteri1.Soyad = "Akbey";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Candan";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Kurtoğlu";
            musteri3.Id = 3;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Nesrin";
            musteri4.Soyad = "Çakır";
            musteri4.Id = 4;





            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            musteriManager.List();

            Console.WriteLine("Müşteri Listesi Güncellendi");
            musteriManager.Delete(musteri3);
            musteriManager.List();

        }
    }
}
