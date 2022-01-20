using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data.Services
{
    public interface IActorsServices //An interface is a contract 
    {
        Task<IEnumerable<Actor>> GetAll();//returning a task Ienumerable
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id,Actor newActor);
        void Delete(int id);
    }
}
