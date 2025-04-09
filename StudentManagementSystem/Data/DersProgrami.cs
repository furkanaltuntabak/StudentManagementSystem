using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Data
{
    public class DersProgrami
    {
        [Key]
        public int DersProgramiID { get; set; }

        [Required]
        public int DersID { get; set; }

        [Required]
        public int DerslikID { get; set; }

        [Required]
        public string Gun { get; set; } = null!;

        [Required]
        public string Saat { get; set; } = null!;

        [ForeignKey("DersID")]
        public Ders? Ders { get; set; }

        [ForeignKey("DerslikID")]
        public Derslik? Derslik { get; set; }
    }
}
