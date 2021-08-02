using GroupAPI.Data;
using GroupAPI.Models;
using GroupAPI.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Group_API_Project_Assessment.Controllers
{

    /// <summary>
    /// This is where the user can find information about Pets
    /// </summary>

        [Authorize]

    public class PetController : ApiController
    {
        private PetService CreatePetService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var petService = new PetService(userId);
            return petService;
        }

        //Get Method
        /// <summary>
        /// Gets a list of the Pets
        /// </summary>
        /// <returns>A list of Pets</returns>
        public IHttpActionResult Get()
        {
            PetService petService = CreatePetService();
            var pets = petService.GetPets();
            return Ok(pets);
        }
        /// <summary>
        /// Gets a specific Pet based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A singular Pet</returns>
        public IHttpActionResult Get(int id)
        {
            PetService petService = CreatePetService();
            var pet = petService.GetPetById(id);
            return Ok(pet);
        }

        //Post Method
        /// <summary>
        /// Allows User to add a new Pet
        /// </summary>
        /// <param name="pet"></param>
        /// <returns>A success or failure message</returns>
        public IHttpActionResult Post(PetCreate pet)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePetService();

            if (!service.CreatePet(pet))
                return InternalServerError();

            return Ok();
        }


        //Put or Update Method

        //Put
        /// <summary>
        /// Allows User or Admin to edit a Pet
        /// </summary>
        /// <param name="pet"></param>
        /// <returns>A Success or failure message</returns>
        public IHttpActionResult Put(PetEdit pet)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePetService();

            if (!service.UpdatePet(pet))
                return InternalServerError();

            return Ok();
        }

        //Delete method
        //Delete
        /// <summary>
        /// Allows User or Admin to delete a Pet
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A confirmation or denial that the Pet has been deleted</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePetService();
            if (!service.DeletePet(id))
                return InternalServerError();

            return Ok();
        }
    }
}

