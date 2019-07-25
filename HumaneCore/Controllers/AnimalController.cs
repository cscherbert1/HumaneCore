using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumaneCore.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimal _animalService;

        public AnimalController(IAnimal animalService)
        {
            _animalService = animalService;
        }

        public IActionResult Index()
        {
            IEnumerable<Animal> animals = _animalService.GetAll();
            return View();
        }
    }
}