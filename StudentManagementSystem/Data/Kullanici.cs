using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        [Required]
        public string AdSoyad { get; set; } = null!;

        [Required]
        public string Eposta { get; set; } = null!;

        [Required]
        public string Sifre { get; set; } = null!;

        public string? Numara { get; set; }

        [ForeignKey("Rol")]
        public int RolID { get; set; }
        public Rol? Rol { get; set; }

        public int? SinifID { get; set; }  // Zorunlu değil
        public Sinif? Sinif { get; set; }
      
    }
}
