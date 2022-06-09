using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    public class SliderController : Controller
    {
        private AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


        //public IActionResult Edit(int id)
        //{
        //    _context.Sliders.FirstOrDefault(x => x.Id == id);
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    _context
        //}



    }
}
