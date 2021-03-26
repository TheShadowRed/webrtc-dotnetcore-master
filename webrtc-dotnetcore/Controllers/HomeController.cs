using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webrtc_dotnetcore.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Register()
        {
            return View("Register");
        }

        public IActionResult WebRTC()
        {
            return View();
        }
        public IActionResult GuestHost()
        {
            return View("WebRTCGuestHost");
        }
        public IActionResult GuestJoin()
        {
            return View("WebRTCGuestJoin");
        }
        [HttpPost]
        public IActionResult FormOne(string UserEmail, string UserPassword, string UserPasswordr, bool RemeberMe)
        {
            //Do something
            if (UserPassword == UserPasswordr && UserPassword != null && UserPassword != "")
            {
                return View("WebRTC");
            }
            else 
            {
                //fail
                return View("Register");
            }
        }
    }
}
