using System;

namespace BankaMusteriSenaryosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri {ID =1, Name ="Enes", AccountTotal=1000 };
            Musteri musteri2 = new Musteri { ID = 2, Name = "Deniz", AccountTotal = 2000 };
            Musteri musteri3 = new Musteri { ID = 3, Name = "Serdar", AccountTotal = 3000 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("\nMüşteriler eklendikten sonra\n");
            musteriManager.Listele();


            musteriManager.Delete(musteri3.ID);
            Console.WriteLine("\nSerdar müşterisi silindikten sonra\n");
            musteriManager.Listele();
        }
    }
}
