using System;
using System.Collections.Generic;
namespace AjaxAndjQuery.Models.Domain
{
    public interface ISessionRepository
    {
        IEnumerable<Session> GetAll();
        void Delete(Guid id);
        void Add(Session session);
    }
}
