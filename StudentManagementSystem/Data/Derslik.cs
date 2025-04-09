using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Data
{
    public class Derslik
    {
        [Key]
        public int DerslikID { get; set; }

        [Required]
        public string DerslikAdi { get; set; } = null!;

        [Required]
        public int Kapasite { get; set; }

        public ICollection<DersProgrami>? DersProgramlari { get; set; }
        public ICollection<Sinav>? Sinavlar { get; set; }
    }
}
