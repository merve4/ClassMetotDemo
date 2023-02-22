using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriTcNo+" "+musteri.MusteriAdSoyad +" "+"Adlı müşteri sisteme eklendi! ");
          
        }

            
        public void MusteriSil(Musteri musteri)
        {
            
            Console.WriteLine(musteri.MusteriTcNo + " " + musteri.MusteriAdSoyad+" " + "Adlı müşteri sistemden silindi! ");
        }

       
        public void MusteriListele(params Musteri[] musteriler)
        {

            foreach (var Musteri in musteriler)
            {
               
                Console.WriteLine(Musteri.MusteriTcNo + " " + Musteri.MusteriAdSoyad + " " + Musteri.Yasadigiİl + " " + Musteri.HesapNumarasi);
            }
        }
    }
}
