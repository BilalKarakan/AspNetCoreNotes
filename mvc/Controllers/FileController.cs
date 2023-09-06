using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Mvc.Controllers
{
    public class FileController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files"));

            var files = info.GetFiles();
            return View(files);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string fileName)
        {
            FileInfo fileInfo = new(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName));
            if (!fileInfo.Exists)
                fileInfo.Create();

            return RedirectToAction("List");
        }

        public IActionResult Remove(string fileName)
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName));
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            return RedirectToAction("List");
        }

        public IActionResult CreateWithData()
        {
            FileInfo info = new(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", Guid.NewGuid().ToString()+".txt"));

            StreamWriter writer = info.CreateText();

            writer.Write("Hello World!");

            writer.Close();

            return RedirectToAction("List");
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile formFile)
        {
            
            var extension = Path.GetExtension(formFile.FileName);
            var path = $"{Directory.GetCurrentDirectory()}/wwwroot/images/{Guid.NewGuid().ToString()}{extension}";
            FileStream stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);

            TempData["message"] = "Upload işlemi başarı ile gerçekleşmiştir.";


            return RedirectToAction("Upload");
        }
    }
}
