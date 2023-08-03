using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Mvc.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
            var folders = directoryInfo.GetDirectories();
            return View(folders);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string folderName)
        {
            DirectoryInfo info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (!info.Exists)
            {
                info.Create();
                return RedirectToAction("List");
            }
            else
            {
                TempData["key"] = "Aynı isimde klasör mevcur";
            }
            return View();
        }
    }
}
