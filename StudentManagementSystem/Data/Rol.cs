using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Data
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required]
        public string RolAdi { get; set; }=null!;

        public ICollection<Kullanici>? Kullanicilar { get; set; }
    }
}
