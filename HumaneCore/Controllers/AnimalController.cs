using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumaneCore.Data.Interfaces;
using HumaneCore.Data.Models;
using HumaneCore.Models;
using HumaneCore.Models.Animal;
using Microsoft.AspNetCore.Mvc;

namespace HumaneCore.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimal _animalService;
        private readonly ISpecies _speciesService;
        private readonly IBreed _breedService;
        private readonly IColor _colorService;
        private readonly IAnimalRestriction _animalRestrictionService;

        public AnimalController(IAnimal animalService, 
            ISpecies speciesService, 
            IBreed breedService, 
            IColor colorService, 
            IAnimalRestriction animalRestrictionService)
        {
            _animalService = animalService;
            _speciesService = speciesService;
            _breedService = breedService;
            _colorService = colorService;
            _animalRestrictionService = animalRestrictionService;
        }

        public IActionResult Index()
        {
            try
            {
                IEnumerable<AnimalListingViewModel> animals = _animalService.GetAll()
                .Select(animal => new AnimalListingViewModel
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Age = animal.Age,
                    Gender = animal.Gender,
                    Species = animal.Species,
                    Breed = animal.Breed,
                    Color = animal.Color,
                    AnimalRestrictions = animal.AnimalRestrictions,
                    Media = animal.Media
                });
                var model = new AnimalIndexViewModel
                {
                    AnimalList = animals
                };
                return View(model);
            } catch(Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.Message = ex.Message;
                return RedirectToAction("Error", "Home", error);
            }   
        }

        public IActionResult Species(int Id)
        {
            try
            {
                IEnumerable<AnimalListingViewModel> animals = _animalService.GetBySpecies(Id)
                .Select(animal => new AnimalListingViewModel
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Age = animal.Age,
                    Gender = animal.Gender,
                    Species = animal.Species,
                    Breed = animal.Breed,
                    Color = animal.Color,
                    AnimalRestrictions = animal.AnimalRestrictions,
                    Media = animal.Media
                });
                var species = _speciesService.GetById(Id);
                var model = new AnimalSpeciesViewModel
                {
                    Species = species,
                    AnimalList = animals
                };
                return View(model);
            } catch(Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.Message = ex.Message;
                return RedirectToAction("Error", "Home", error);
            }
            
        }

        public IActionResult Visit(long id)
        {
            try
            {
                Animal animal = _animalService.GetById(id);
                return View(BuildAnimalListing(animal));
            } catch(Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.Message = ex.Message;
                return RedirectToAction("Error", "Home", error);
            }
        }

        [HttpGet]
        public IActionResult Intake()
        {
            AnimalIntakeViewModel model = new AnimalIntakeViewModel();
            try
            {
                model.SpeciesCollection = _speciesService.GetAll();
                model.BreedCollection = _breedService.GetAll();
                model.ColorCollection = _colorService.GetAll();
                model.AnimalRestrictions = _animalRestrictionService.GetAll();
            } catch(Exception ex){
                ErrorViewModel error = new ErrorViewModel();
                error.Message = ex.Message;
                return RedirectToAction("Error", "Home", error);
            }         
            return View(model);
        }

        [HttpPost]
        public IActionResult Intake(AnimalIntakeViewModel animal)
        {
            try
            {
                //call animal service's create method to add a new animal to the database
            } catch (Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel();
                error.Message = ex.Message;
                return RedirectToAction("Error", "Home", error);
            }
            //on success redirect to Thank you/ sucess page
            return View();
        }

        /// <summary>
        /// Creates an animal listing view model with properties that match those of the provided Animal object.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>An AnimalListingViewModel</returns>
        private AnimalListingViewModel BuildAnimalListing(Animal animal)
        {
            AnimalListingViewModel model = new AnimalListingViewModel();
            model.Id = animal.Id;
            model.Name = animal.Name;
            model.Age = animal.Age;
            model.Gender = animal.Gender;
            model.IntakeDate = animal.IntakeDate;
            model.Bio = animal.Bio;
            model.SpayedNeutered = animal.SpayedNeutered;

            model.Species = animal.Species;
            model.Breed = animal.Breed;
            model.Color = animal.Color;
            model.AnimalRestrictions = animal.AnimalRestrictions;
            model.Media = animal.Media;

            return model;
        }
    }
}