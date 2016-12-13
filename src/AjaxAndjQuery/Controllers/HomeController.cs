using System;
using AjaxAndjQuery.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AjaxAndjQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpeakerRepository _speakerRepository;

        public HomeController(ISpeakerRepository repository)
        {
            _speakerRepository = repository;
        }

        public IActionResult Index()
        {  
            return View();
        }

        public IActionResult GetMessage()
        {
            return Content("Hello world");
        }

        
        public IActionResult GetJson()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetHtml()
        {
            throw new NotImplementedException();
        }

        public IActionResult Search(string searchTerm)
        {
           throw new NotImplementedException();
        }

  

    }
}
