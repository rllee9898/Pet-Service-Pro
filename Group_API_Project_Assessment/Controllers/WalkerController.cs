using GroupAPI.Data;
using GroupAPI.Models;
using GroupAPI.Service;
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
    /// This is where the user can find information about the Walkers
    /// </summary>
    public class WalkerController : ApiController
    {
        private WalkerService CreateWalkerService()
        {
            var walkerService = new WalkerService();
            return walkerService;
        }

        //Get Method
        /// <summary>
        /// Gets a list of the Walkers available
        /// </summary>
        /// <returns>A list of Walkers</returns>
        public IHttpActionResult Get()
        {
            WalkerService walkerService = CreateWalkerService();
            var walker = walkerService.GetWalkers();
            return Ok(walker);
        }
        /// <summary>
        /// Gets a specific Walker based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A singular Walker</returns>
        public IHttpActionResult Get(int id)
        {
            WalkerService walkerService = CreateWalkerService();
            var walker = walkerService.GetWalkerById(id);
            return Ok(walker);
        }

        //Post Method
        /// <summary>
        /// Allows Admin to add a new Walker
        /// </summary>
        /// <param name="walker"></param>
        /// <returns>A success or failure message</returns>
        public IHttpActionResult Post(WalkerCreate walker)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateWalkerService();

            if (!service.CreateWalker(walker))
                return InternalServerError();

            return Ok();
        }


        //Put or Update Method

        //Put
        /// <summary>
        /// Allows Admin to edit a Walker
        /// </summary>
        /// <param name="walker"></param>
        /// <returns>A Success or failure message</returns>
        public IHttpActionResult Put(WalkerEdit walker)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateWalkerService();

            if (!service.UpdateWalker(walker))
                return InternalServerError();

            return Ok();
        }

        //Delete method

        //Delete
        /// <summary>
        /// Allows Admin to delete a Walker
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A confirmation or denial that the Walker has been deleted</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateWalkerService();
            if (!service.DeleteWalker(id))
                return InternalServerError();

            return Ok();
        }
    }
}
