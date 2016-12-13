using System;
using System.Collections.Generic;
namespace AjaxAndjQuery.Models.Domain
{
    public interface ISpeakerRepository
    {
       IEnumerable<Speaker> GetAll();
       IEnumerable<Speaker> GetByName(string name);
       Speaker GetById(Guid id);
    }
}
