using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    
    public class AccountController : Controller
    {
       private readonly AppDbContext _context;

    public AccountController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var kullanici = _context.Kullanicilar
            .Include(k => k.Rol)
            .FirstOrDefault(k => k.Eposta == model.Eposta && k.Sifre == model.Sifre);

        if (kullanici != null)  
        {
            HttpContext.Session.SetInt32("KullaniciID", kullanici.KullaniciID);
            HttpContext.Session.SetString("AdSoyad", kullanici.AdSoyad);
            HttpContext.Session.SetString("KullaniciRol", kullanici.Rol!.RolAdi);

            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "E-posta veya şifre hatalı.");
        return View(model);
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }



    }
}