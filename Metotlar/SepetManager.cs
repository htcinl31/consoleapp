using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //name convention
        //syntax-yazım şekilleri
        public void Ekle(Urun urun)                                  //urun ekleme fonksiyonu
        {

            Console.WriteLine("Sepete Eklendi: "+ urun.Adi);
        }

        public void Ekle2(string urunAdi,string Aciklama,double Fiyat,int StokAdedi)
        {

            Console.WriteLine("Tebrikler,Sepete eklendi:" + urunAdi); ;
        
        }
    }
}
