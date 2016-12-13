using System;
using System.Collections.Generic;
using System.Linq;
using AjaxAndjQuery.Models.Domain;

namespace AjaxAndjQuery.Data.Repositories
{
    public class SessionRepository : ISessionRepository
    {
        private static readonly IList<Session> Sessions = new List<Session>();

        public IEnumerable<Session> GetAll()
        {
            return Sessions;
        }

        public void Add(Session session)
        {
            if (session.Id == Guid.Empty)
                session.Id = Guid.NewGuid();

            Sessions.Add(session);
        }

        public void Delete(Guid id)
        {
            Session item = Sessions.Single(session => session.Id == id);
            Sessions.Remove(item);
        }
    }
}