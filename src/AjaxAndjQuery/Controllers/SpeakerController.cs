using System;
using System.Collections.Generic;
using System.Linq;
using AjaxAndjQuery.Models.Domain;
using AjaxAndjQuery.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AjaxAndjQuery.Controllers
{
    public class SpeakerController : Controller
    {
        private readonly ISpeakerRepository _repository;

        public SpeakerController(ISpeakerRepository repository)
        {
           _repository = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Speaker> speakers = _repository.GetAll();
            return View(speakers.Select(s=>new SpeakerViewModel(s)));
        }

        public IActionResult Details(Guid id)
        {
            var speaker = _repository.GetById(id);
           return Json(new SpeakerViewModel(speaker));
        }
    
    }
}
