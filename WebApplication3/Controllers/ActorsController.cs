using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Data.Services;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _service; //calling appdbcontext to access the context

        //to access the context a constructor is required
        public ActorsController(IActorsServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()//the task in the method is used for data-manipulation
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get request
        public IActionResult Create()
        {
            return View();
        }

        //Get request
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)//bind is a property we are sending to the actor model
        {

            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
           
            if(actorDetails==null)
            {
                return View("Not Found");
            }

            return View(actorDetails);
        
        }

        //Get request
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }

            return View(actorDetails);
        }

        //Get request
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("FullName,ProfilePictureURL,Bio")] Actor actor)//check the updated id against the parameter values
        {
            actor.Id = id;

            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("Not Found");
            }

            return View(actorDetails);
        }

        //Get request
        [HttpPost,ActionName("Delete")]//Delete can be used instead of deleteconfirmed with the http post
        public async Task<IActionResult> DeleteConfirmed(int id)//check the updated id against the parameter values
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            
                return View("Not Found");
            
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
