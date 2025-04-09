using StudentManagementSystem.Data;

public class Donem
{
    public int DonemID { get; set; }
    public string DonemAdi { get; set; } = null!; // Örnek: "Güz 2024", "Bahar 2025"

    public ICollection<Ders>? Dersler { get; set; }
}
