using System;
using System.Collections.Generic;
using System.Linq;
using AjaxAndjQuery.Models.Domain;

namespace AjaxAndjQuery.Data.Repositories
{
    public class SpeakerRepository : ISpeakerRepository
    {
        //simulate an in memory database
        private static readonly IDictionary<Guid, Speaker> Speakers = new Dictionary<Guid, Speaker>();

        static SpeakerRepository()
        {
            var speaker1 = new Speaker
            {
                Id = Guid.NewGuid(),
                FullName = "Mickey",
                PictureUrl = "mickey.jpg",
                Bio = "Mickey Mouse is een animatie- en stripfiguur. Hij werd in 1928 door Walt Disney ontworpen samen met Ub Iwerks. Mickey is een antropomorfe muis waarvan het gezicht kan worden getekend als drie zwarte cirkels. Mickey Mouse is een icoon voor The Walt Disney Company en een van de meest herkenbare symbolen in de wereld."
            };
            var speaker2 = new Speaker
            {
                Id = Guid.NewGuid(),
                FullName = "Goofy",
                PictureUrl = "goofy.jpg",
                Bio = "Goofy is een fictieve antropomorfe dingo. Goofy is in 1932 bedacht door Art Babbitt en de eerste concepten werden uitgewerkt door Frank Webb. Goofy is de beste vriend van Mickey Mouse. In de tekenfilmpjes van Walt Disney werd de stem van Goofy jarenlang gedaan door de stemmenkunstenaar Pinto Colvig."
            };
            var speaker3 = new Speaker
            {
                Id = Guid.NewGuid(),
                FullName = "Pluto",
                PictureUrl = "pluto.jpg",
                Bio = "Pluto is een fictieve hond in de tekenfilms van Disney, gecreëerd door Walt Disney. Pluto verscheen voor het eerst in 1930 in de cartoon 'The Chain Gang' als een bloodhound die op het spoor was van een ontsnapte gevangene. Pluto is vernoemd naar de gelijknamige dwergplaneet Pluto die in datzelfde jaar werd ontdekt."
            };
            Speakers.Add(speaker1.Id, speaker1);
            Speakers.Add(speaker2.Id, speaker2);
            Speakers.Add(speaker3.Id, speaker3);
        }
        public IEnumerable<Speaker> GetAll()
        {
            return Speakers.Values;
        }

        public Speaker GetById(Guid id)
        {
            return Speakers[id];
        }

        public IEnumerable<Speaker> GetByName(string name)
        {
            return Speakers.Values.Where(s => s.FullName.ToLower().Contains(name.ToLower()));
        }
    }
}