using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class Ders
    {
        [Key]
        public int DersID { get; set; }

        [Required]
        public string DersAdi { get; set; } = null!;

        [Required]
        public int Kredi { get; set; }

        public int? OgretimElemaniID { get; set; }

        [ForeignKey("OgretimElemaniID")]
        public Kullanici? OgretimElemani { get; set; }

        public ICollection<DersProgrami>? DersProgramlari { get; set; }
        
        public int? DonemID { get; set; }
        public Donem? Donem { get; set; } // ← bu satır eklenecek
        public int? SinifID { get; set; }  // Zorunlu değil
        public Sinif? Sinif { get; set; }

      
    }
}
