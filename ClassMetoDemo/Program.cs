using System;

namespace ClassMetoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 100;
            musteri1.Adi = "kemal";
            musteri1.Soyadi = "Başaran";


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ömer";
            musteri2.Soyadi = "Başaran";
            musteri2.Id = 101;

            Musteri[] musteris = new Musteri[] {musteri1,musteri2 };

            Console.ReadLine();

            foreach(var t in musteris)
            {
                Console.WriteLine(t.Adi);
                Console.WriteLine(t.Soyadi);
                Console.WriteLine(t.Id);
                Console.ReadKey();
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

            Console.ReadLine();

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Deleted(musteri2);
        
        }
    }
}
