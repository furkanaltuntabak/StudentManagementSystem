using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class DersDerslik
    {
        [Key]
        public int DersDerslikID { get; set; }

        [ForeignKey("Ders")]
        public int DersID { get; set; }
        public Ders? Ders { get; set; }

        [ForeignKey("Derslik")]
        public int DerslikID { get; set; }
        public Derslik? Derslik { get; set; }

        public int OgrenciSayisi { get; set; }  // Derslikteki öğrenci sayısı
    }
}
