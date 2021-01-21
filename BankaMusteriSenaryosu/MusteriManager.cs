using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteriSenaryosu
{
    class MusteriManager
    {
        List<Musteri> musteriList;
        public MusteriManager()
        {
            musteriList = new List<Musteri>();
        }

        public void Add(Musteri item)
        {
            musteriList.Add(item);
        }

        public void Delete(int id)
        {
            Musteri wanted = musteriList.Find(x => x.ID == id);

            if (wanted != null)
            {
                musteriList.Remove(wanted);
            }
            else
                Console.WriteLine("Belirtilen id'ye sahip müşteri bulunamadı");
        }

        public void Listele()
        {
            foreach (var item in musteriList)
            {
                Console.WriteLine("Müşteri Adı: "+item.Name+"\tHesap totali: "+item.AccountTotal );
            }
        }
    }
}
