using System;
using AjaxAndjQuery.Models.Domain;

namespace AjaxAndjQuery.Models.ViewModels
{
    public class SessionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }

        public SessionViewModel()
        {
            
        }

        public SessionViewModel(Session session)
        {
            Id = session.Id;
            Name = session.Title;
            Description = session.Description;
            Level = session.Level;
        }
    }
}