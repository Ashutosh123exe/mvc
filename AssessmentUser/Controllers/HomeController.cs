﻿using AssessmentUser.Context;
using AssessmentUser.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssessmentUser.Controllers
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

        // LoginController
       


            public IActionResult Privacy()
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