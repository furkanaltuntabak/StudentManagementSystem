using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data
{
    public class SinavNot
    {

        public int SinavNotID { get; set; }

        public int SinavID { get; set; }
        public Sinav? Sinav { get; set; }

        public string? NotMetni { get; set; }

        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
    
         // 👇 Eklenen Kısım
        public int? OgretimElemaniID { get; set; }
        public Kullanici? OgretimElemani { get; set; }
    }

    
}