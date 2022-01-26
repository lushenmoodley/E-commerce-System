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
    public class ProducersController : Controller
    {
        private readonly IProducersService _service; //calling appdbcontext to access the context
        private readonly IMoviesService _serviceMovie;

        //to access the context a constructor is required
        public ProducersController(IProducersService service, IMoviesService serviceMovie)
        {
            _service = service;
            _serviceMovie = serviceMovie;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails=await _service.GetByIdAsync(id);

            if (producerDetails==null)

                return View("Not Found");

            return View(producerDetails);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }


        //GET: producers/Update
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails= await _service.GetByIdAsync(id);

            if(producerDetails==null)
            {
                return View("Not Found");
            }
            
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }

            return View(producer);
        }

        //GET: producers/Update
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("Not Found");
            }

            return View(producerDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            var allMovies = await _serviceMovie.GetAllAsync(n => n.Cinema); //Ordering movies by their names          
            int filterResult = allMovies.Where(n => n.ProducerId.Equals(id)).ToList().Count;

            if (producerDetails == null)
            {
                return View("Not Found");
            }


            if (filterResult > 0)
            {
                return View("AssignedProducers");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
