using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentManagementSystem.Data{

public class KapiIsimligi
{
        [Key]
        public int KapiIsimligiID { get; set; }

        [Required]
        public string KapiIsimligiAdi { get; set; } // Kapı isimliği adı

        public string? SinifAdi { get; set; } // İsteğe bağlı sınıf adı

        public int OgretimElemaniID { get; set; } // Öğretim elemanının ID'si
        [ForeignKey("OgretimElemaniID")]
        public Kullanici OgretimElemani { get; set; } // Öğretim elemanı ile ilişki
}


}
