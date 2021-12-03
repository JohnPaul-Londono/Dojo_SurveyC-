using Microsoft.AspNetCore.Mvc;
using System;

namespace Dojo_Survey.Controllers
{
    public class FormController : Controller
    {

        public static string dName;
        public static string dLocation;
        public static string dLanguage;
        public static string dComments;

        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult  Process (string Name, string Location, string Language, string Comments)
        {
            // Console.WriteLine($"Name : {Name} Location : {Location} Language: {Language} Comments : {Comments}");
            dName = Name;
            dLocation = Location;
            dLanguage = Language;
            dComments = Comments;
            return RedirectToAction("Result");
        }
        [HttpGet("Result")]
        public IActionResult Result()
        {
            ViewBag.Name = dName;
            ViewBag.Location = dLocation;
            ViewBag.Language = dLanguage;
            ViewBag.Comments = dComments;
            return View ("Result");
        }

        [HttpPost("process2")]
        public RedirectToActionResult Submit()
        {
            return RedirectToAction("Index");
        }

    }


}