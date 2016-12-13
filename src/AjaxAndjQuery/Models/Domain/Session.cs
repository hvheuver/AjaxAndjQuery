using System;

namespace AjaxAndjQuery.Models.Domain
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
     
    }
}