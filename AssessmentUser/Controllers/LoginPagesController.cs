using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssessmentUser.Context;
using AssessmentUser.Models;

namespace AssessmentUser.Controllers
{
    public class LoginPagesController : Controller
    {
        private readonly DContext _context;

        public LoginPagesController(DContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Login(LoginPage model)
        {

            
            
            if (model.Username == "admin" && model.Password == "password")
                {
                    
                    return RedirectToAction("Index", "Home"); 
                }
                else
                {
                    
                    ModelState.AddModelError("", "Invalid username or password");
                }
            

            
            return View(model);
        }
    }
}
