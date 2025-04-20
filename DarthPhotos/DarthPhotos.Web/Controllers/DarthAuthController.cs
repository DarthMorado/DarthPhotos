using DarthPhotos.Web.Models;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DarthPhotos.Web.Controllers
{
    public class DarthAuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DarthAuthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

    }
}
