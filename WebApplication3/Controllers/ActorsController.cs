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
            var data = await _service.GetAll();
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
            _service.Add(actor);

            return RedirectToAction(nameof(Index));
        }



    }
}
