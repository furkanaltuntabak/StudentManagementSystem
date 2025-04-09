using StudentManagementSystem.Data;

public class Sinif
{
    public int SinifID { get; set; }
    public string SinifAdi { get; set; }=null!;

    public ICollection<Kullanici>? Kullanicilar { get; set; }
    public ICollection<Ders>? Dersler { get; set; }
}
