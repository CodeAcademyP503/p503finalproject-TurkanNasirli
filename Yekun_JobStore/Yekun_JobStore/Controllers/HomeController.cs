using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yekun_JobStore.Models;


namespace Yekun_JobStore.Controllers
{
  
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {      
            return View();
        }
        public IActionResult Advert()
        {
        
            return View();

        }
        public IActionResult Announcement()
        {
           
            return View();
        }
        public IActionResult Blog()
        {
          
            return View();
        }
        public IActionResult Download()
        {
        
            return View();
        }
        public IActionResult Question()
        {
         
            return View();
        }
        public IActionResult Wrong()
        {
           
            return View();
        }
        public IActionResult Jobseeker()
        {
       
            return View();
        }
    

        public IActionResult Advertising()
        {
    
            return View();
        }
        public IActionResult Selection()
        {

            return View();
        }


    }
}
