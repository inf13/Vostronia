using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vostronia.Core;
using Vostronia.Models;

namespace Vostronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDefaultService _defaultService;

        public delegate void ResultCallBack(int respone);

        public HomeController(IDefaultService defaultService)
        {
            _defaultService = defaultService;
        }

        public async Task<IActionResult> Index()
        {
            var defaultService = await _defaultService.GetDefaultService();

            return View(new HomeModel() { Name = defaultService.Name });
        }
    }
}
