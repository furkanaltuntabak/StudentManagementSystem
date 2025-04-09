using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.ViewModels
{
    public class DersProgramiListeViewModel
    {
        public int? SinifID { get; set; }
        public int? DonemID { get; set; }
        
        public List<DersProgrami> DersProgramlari { get; set; } = new();
        public List<SelectListItem> Siniflar { get; set; } = new();
        public List<SelectListItem> Donemler { get; set; } = new();
    }
}
