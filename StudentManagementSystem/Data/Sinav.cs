using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class Sinav
    {
        [Key]
        public int SinavID { get; set; }

        [Required]
        public int DersID { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        public string Saat { get; set; } = null!;

        [Required]
        public int DerslikID { get; set; }
         
        [Required]
        public int OgretimElemaniID { get; set; }  // Öğretim Elemanı (Gözetmen)

        [ForeignKey("DersID")]
        public Ders? Ders { get; set; }

        [ForeignKey("DerslikID")]
        public Derslik? Derslik { get; set; }

        [ForeignKey("OgretimElemaniID")]
        public Kullanici? OgretimElemani { get; set; }  // Öğretim Elemanıyla ilişki
      
    }
}
