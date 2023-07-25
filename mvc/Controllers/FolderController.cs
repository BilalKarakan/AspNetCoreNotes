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
    }
}
