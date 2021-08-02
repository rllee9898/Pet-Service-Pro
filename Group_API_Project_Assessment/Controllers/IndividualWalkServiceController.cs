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
    /// This is where the user can find information about the Walk Serivces
    /// </summary>
    public class IndividualWalkServiceController : ApiController
    {
        private IndividualWalkServiceService CreateIndividualWalkServiceService()
        {
            var individualWalkServiceService = new IndividualWalkServiceService();
            return individualWalkServiceService;
        }

        //Get Method
        /// <summary>
        /// Gets a list of the Services available
        /// </summary>
        /// <returns>A list of services</returns>
        public IHttpActionResult Get()
        {
            IndividualWalkServiceService individualWalkServiceService = CreateIndividualWalkServiceService();
            var individualWalkService = individualWalkServiceService.GetIndividualWalkServiceService();
            return Ok(individualWalkService);
        }

        /// <summary>
        /// Gets a specific Service based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A singular Service</returns>
        public IHttpActionResult Get(int id)
        {
            IndividualWalkServiceService individualWalkServiceService = CreateIndividualWalkServiceService();
            var individualWalkService = individualWalkServiceService.GetIndividualWalkServiceServiceById(id);
            return Ok(individualWalkService);
        }

        //Post Method
        /// <summary>
        /// Allows Admin to add a new Service
        /// </summary>
        /// <param name="individualWalkService"></param>
        /// <returns>A success or failure message</returns>
        public IHttpActionResult Post(IndividualWalkServiceCreate individualWalkService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateIndividualWalkServiceService();

            if (!service.CreateIndividualWalkServiceService(individualWalkService))
                return InternalServerError();

            return Ok();
        }


        //Put or Update Method

        //Put
        /// <summary>
        /// Allows Admin to edit a Service
        /// </summary>
        /// <param name="individualWalkService"></param>
        /// <returns>A Success or failure message</returns>
        public IHttpActionResult Put(IndividualWalkServiceEdit individualWalkService)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateIndividualWalkServiceService();

            if (!service.UpdateIndividualWalkService(individualWalkService))
                return InternalServerError();

            return Ok();
        }

        //Delete method

        //Delete
        /// <summary>
        /// Allows Admin to delete a Service
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A confirmation or denial that the Service has been deleted</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateIndividualWalkServiceService();
            if (!service.DeleteIndividualWalkService(id))
                return InternalServerError();

            return Ok();
        }
    }
}
