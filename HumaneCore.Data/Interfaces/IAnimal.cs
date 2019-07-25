using HumaneCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneCore.Data.Interfaces
{
    public interface IAnimal
    {
        /// <summary>
        /// Gets a single animal based on its Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>An Animal</returns>
        Animal GetById(Guid Id);
        /// <summary>
        /// Gets all animals
        /// </summary>
        /// <returns>A collection of animals</returns>
        IEnumerable<Animal> GetAll();
    /// <summary>
    /// Gets all animals of a certain species
    /// </summary>
    /// <param name="speciesId"></param>
    /// <returns>A collection of animals</returns>
        IEnumerable<Animal> GetBySpecies(int speciesId);

        /// <summary>
        /// Creates a new animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        Task Create(Animal animal);
        /// <summary>
        /// Deletes an animal
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(Guid id);
        /// <summary>
        /// Updates all properties of an existing animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        Task Update(Animal animal);
        /// <summary>
        /// Updates an animal Name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        Task UpdateName(Guid id, string newName);
        /// <summary>
        /// Updates an animal age
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newAge"></param>
        /// <returns></returns>
        Task UpdateAge(Guid id, int newAge);
        /// <summary>
        /// Updates an animal Bio
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newBio"></param>
        /// <returns></returns>
        Task UpdateBio(Guid id, string newBio);
        /// <summary>
        /// Updates whether an animal has been spayed or neutered
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newSpayedNeutered"></param>
        /// <returns></returns>
        Task UpdateSpayNeut(Guid id, bool newSpayedNeutered);
    }
}
