using System;
using System.Collections.Generic;
using System.Text;

namespace ClasMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void Add(Musteri musteri)
        {
            musteriler.Add(musteri);
        }
        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
        }

        public void List()
        {
            foreach (var musteri in musteriler)
            {

                Console.WriteLine(musteri.Id + "-" + musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
