using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Merhaba!" + " " + musteri.Adi + " " + musteri.Soyadi + " Id'niz " + musteri.Id);
            Console.WriteLine("bizi tercih ettiğiniz için teşekkür ederiz :)");

            Console.ReadLine();
        }
      public void Deleted(Musteri musteri)
        {
            Console.WriteLine("Merhaba!" + " " + musteri.Adi + " " + musteri.Soyadi + " Id'niz " + musteri.Id);
            Console.WriteLine( "Ayılma işleminiz tamamlanmıştır");
            Console.ReadLine();
        }
    
    }
}        
    

