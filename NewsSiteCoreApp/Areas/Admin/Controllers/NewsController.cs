using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using NewsSiteCoreApp.Abstractions;
using NewsSiteCoreApp.Models;


namespace NewsSiteCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;
        private readonly IWebHostEnvironment _webhost;
        public NewsController(INewsRepository newsRepository, IWebHostEnvironment webHost)
        {
            _newsRepository = newsRepository;
            _webhost = webHost;
        }
        public IActionResult Index()
        {

            return View(_newsRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(News news)
        {

            if (ModelState.IsValid)
            {
                CopyToImageFolder(news);


                _newsRepository.Create(news);
                return RedirectToAction("Index");
            }
            return View(news);
        }

        public IActionResult Edit(int id)
        {
            News news = _newsRepository.GetNewsById(id);
            if (news != null)
            {
                return View(news);
            }
            return StatusCode(400);
        }
        [HttpPost]
        public IActionResult Edit(News news)
        {

            if (ModelState.IsValid)
            {
                News news_ = _newsRepository.GetNewsById(news.Id);
                if (news_ != null)
                {
                    if (news.FormFile != null)
                    {
                        CopyToImageFolder(news);
                    }
                    _newsRepository.Edit(news);
                    return RedirectToAction("Index");
                }
            }

            return View(news);
        }
        public IActionResult Delete(int id)
        {
            News news = _newsRepository.GetNewsById(id);
            if (news != null)
            {
                return View(news);
            }
            return StatusCode(400);
        }   
        [HttpPost]
        public IActionResult Delete(News news)
        {
            
            if (news!= null)
            {
                _newsRepository.Remove(news);
                return RedirectToAction("Index");
            }
            return StatusCode(400);
        }
        private void CopyToImageFolder(News news)
        {
            //var fileNameWithoutEx = Path.GetFileNameWithoutExtension(news.FormFile.FileName);
            //var fileNameEx = Path.GetExtension(news.FormFile.FileName);
            //var date = DateTime.Now.ToString("MM dd yyyy, hh mm ss tt");
            //$"{fileNameWithoutEx}{fileNameEx}"
            var fileName = news.FormFile.FileName;
            var rootPath = Path.Combine(_webhost.WebRootPath, "news-images", fileName);
            news.FileName = fileName;
            using (var fileStream = new FileStream(rootPath, FileMode.Create))
            {
                news.FormFile.CopyTo(fileStream);
            }
        }
    }
}