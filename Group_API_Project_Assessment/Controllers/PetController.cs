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
    public class PetController : ApiController
    {
        [Authorize]
        private PetService CreatePetService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var petService = new PetService(userId);
            return petService;
        }

        //Get Method
        public IHttpActionResult Get()
        {
            PetService petService = CreatePetService();
            var pets = petService.GetPets();
            return Ok(pets);
        }

        public IHttpActionResult Get(int id)
        {
            PetService petService = CreatePetService();
            var pet = petService.GetPetById(id);
            return Ok(pet);
        }

        //Post Method
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
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePetService();
            if (!service.DeletePet(id))
                return InternalServerError();

            return Ok();
        }
    }
}
