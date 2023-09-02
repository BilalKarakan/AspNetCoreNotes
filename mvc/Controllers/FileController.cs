using Microsoft.AspNetCore.Mvc;
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
    }
}
