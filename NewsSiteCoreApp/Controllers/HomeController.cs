using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsSiteCoreApp.Abstractions;
using NewsSiteCoreApp.Models;

namespace NewsSiteCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsRepository _newsRepository;
        public HomeController(ILogger<HomeController> logger,INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_newsRepository.GetAll());
        }
        [Authorize]
        public IActionResult Details(int id)
        {
            News news = _newsRepository.GetNewsById(id);
            if (news != null)
            {
                if (_newsRepository.GetView(id))
                {
                    return View(news);
                }
               
            }
            return RedirectToAction("Error");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public JsonResult AddLike(int id)
        {

            if (_newsRepository.AddLike(id))
            {
                return Json(200);
            }
            return Json(400);
        }
        [HttpPost]
        public JsonResult AddDislike(int id)
        {

            if (_newsRepository.AddDislike(id))
            {
                return Json(200);
            }
            return Json(400);
        }

    }
}
