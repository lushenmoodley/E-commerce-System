using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.Base;
using WebApplication3.Models;

namespace WebApplication3.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>,IActorsServices
    {
        public ActorsService(AppDbContext context) : base(context) { }
               
    }
}
