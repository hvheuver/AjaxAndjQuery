using System.Collections.Generic;
using AjaxAndjQuery.Models.Domain;
using AjaxAndjQuery.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            IEnumerable<Speaker> speakers = _speakerRepository.GetAll();
            return Json(speakers.Select(s => new SpeakerViewModel(s)));
        }

        public IActionResult GetHtml()
        {
            IEnumerable<Speaker> speakers = _speakerRepository.GetAll();
            return PartialView("_GetHtml", speakers.Select(s => new SpeakerViewModel(s)));
        }

        public IActionResult Search(string searchTerm)
        {
            IEnumerable<Speaker> speakers = _speakerRepository.GetByName(searchTerm);
            return PartialView("_GetHtml", speakers.Select(s => new SpeakerViewModel(s)));
        }

    }


}

