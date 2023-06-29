﻿using Basecode.Main.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Basecode.Main.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult JobsList(){
            return View();
        }

        public IActionResult HRScheduler(){
            return View();
        }

        public IActionResult ASchedule(){
            return View();
        }

        public IActionResult ApplicationForm()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}