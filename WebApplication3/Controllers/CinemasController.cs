using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.Services;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service; //calling appdbcontext to access the context
        private readonly IMoviesService _serviceMovie;

        //to access the context a constructor is required
        public CinemasController(ICinemaService service, IMoviesService serviceMovie)
        {
            _service = service;
            _serviceMovie = serviceMovie;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
    
        
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            var allMovies = await _serviceMovie.GetAllAsync(n => n.Cinema); //Ordering movies by their names          
            int filterResult = allMovies.Where(n => n.CinemaId.Equals(id)).ToList().Count;

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            if (filterResult > 0)
            {
                return View("AssignedCinema");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
