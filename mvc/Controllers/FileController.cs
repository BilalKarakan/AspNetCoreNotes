using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Mvc.Controllers
{
    public class FileController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwroot", "files"));

            var files = info.GetFiles();
            return View(files);
        }
    }
}
