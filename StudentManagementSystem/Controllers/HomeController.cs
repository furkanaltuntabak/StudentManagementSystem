using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers;

public class HomeController : Controller
{
 public IActionResult Index()
{
    var kullaniciAdi = HttpContext.Session.GetString("AdSoyad");
    if (string.IsNullOrEmpty(kullaniciAdi))
    {
        kullaniciAdi = "Misafir";
    }

    ViewData["KullaniciAdi"] = kullaniciAdi;
    return View();
}


    public IActionResult Privacy()
    {
        return View();
    }

}
