using System;
using AjaxAndjQuery.Models.Domain;

namespace AjaxAndjQuery.Models.ViewModels
{
    public class SpeakerViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PictureUrl { get; set; }
        public string Bio { get; set; }

        public SpeakerViewModel(Speaker s)
        {
            Id = s.Id;
            FullName = s.FullName;
            PictureUrl = s.PictureUrl;
            Bio = s.Bio;
        }

    }
}