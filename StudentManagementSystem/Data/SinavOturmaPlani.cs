using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class SinavOturmaPlani
    {
        [Key]
        public int SinavOturmaPlaniID { get; set; }

        [Required]
        public int SinifID { get; set; }
        public Sinif Sinif { get; set; } = null!;  // Sınıf bilgisi - navigation property

        [Required]
        public int DerslikID { get; set; }
        public Derslik Derslik { get; set; } = null!; // Derslik bilgisi - navigation property

        [Required]
        public int OgrenciID { get; set; }
        public Kullanici Ogrenci { get; set; } = null!;  // Öğrenci bilgisi - navigation property

        [Required]
        public int SiraNo { get; set; }    // Sıra numarası

        [Required]
        public int KoltukNo { get; set; }  // Koltuk numarası
       

    }
}