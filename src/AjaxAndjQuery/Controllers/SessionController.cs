using System;
using System.Collections.Generic;
using System.Linq;
using AjaxAndjQuery.Models.Domain;
using AjaxAndjQuery.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AjaxAndjQuery.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionRepository _repository;

        public SessionController(ISessionRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Session> sessions = _repository.GetAll();
            IEnumerable<SessionViewModel> sessionViewModels = sessions.Select(s => new SessionViewModel(s)).ToList();
            if (IsAjaxRequest())
                return PartialView("_SessionList", sessionViewModels);
            return View("Index", sessionViewModels);
        }

        [HttpPost]
        public IActionResult Add(SessionViewModel session)
        {
            _repository.Add(
                new Session(){Level = session.Level, Description = session.Description, Title = session.Name});
            return Index();
        }

        [HttpPost]
        public IActionResult Remove(Guid id)
        {
            _repository.Delete(id);
            return Index();
        }

        private bool IsAjaxRequest()
        {
            return Request != null && Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }

    }
}
