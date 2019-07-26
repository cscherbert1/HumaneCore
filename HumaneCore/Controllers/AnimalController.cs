﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using HumaneCore.Models.Animal;
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
            IEnumerable<AnimalListingViewModel> animals = _animalService.GetAll()
                .Select(animal => new AnimalListingViewModel
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Age = animal.Age,
                    Gender = animal.Gender,
                    Species = animal.Species,
                    Color = animal.Color,
                    Restriction = animal.Restriction,
                    Media = animal.Media
                });
            var model = new AnimalIndexViewModel
            {
                AnimalList = animals
            };
            return View(model);
        }
    }
}