using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context; //calling appdbcontext to access the context

        //to access the context a constructor is required
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync(); //Ordering movies by their names           
            return View(allMovies);
        }
    }
}
