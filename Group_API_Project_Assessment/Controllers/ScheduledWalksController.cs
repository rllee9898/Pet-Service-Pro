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
    /// This is where the user can find information about Scheduled Walks
    /// </summary>
    public class ScheduledWalksController : ApiController
    {
        private ScheduledWalkService CreateScheduledWalksService()
        {
            var scheduledWalksService = new ScheduledWalkService();
            return scheduledWalksService;
        }

        //Get Method
        /// <summary>
        /// Gets a list of the Scheduled Walks available
        /// </summary>
        /// <returns>A list of Scheduled Walks</returns>
        public IHttpActionResult Get()
        {
            ScheduledWalkService scheduledWalksService = CreateScheduledWalksService();
            var scheduledWalks = scheduledWalksService.GetScheduledWalks();
            return Ok(scheduledWalks);
        }
        /// <summary>
        /// Gets a specific Scheduled Walk based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A singular Scheduled Walk</returns>
        public IHttpActionResult Get(int id)
        {
            ScheduledWalkService scheduledWalksService = CreateScheduledWalksService();
            var scheduledWalks = scheduledWalksService.GetScheduledWalksById(id);
            return Ok(scheduledWalks);
        }

        //Post Method
        /// <summary>
        /// Allows Admin to add a new Scheduled Walk
        /// </summary>
        /// <param name="scheduledWalks"></param>
        /// <returns>A success or failure message</returns>
        public IHttpActionResult Post(ScheduledWalksCreate scheduledWalks)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateScheduledWalksService();

            if (!service.CreateScheduledWalks(scheduledWalks))
                return InternalServerError();

            return Ok();
        }


        //Put or Update Method

        //Put
        /// <summary>
        /// Allows Admin to edit a Scheduled Walk
        /// </summary>
        /// <param name="scheduledWalks"></param>
        /// <returns>A Success or failure message</returns>
        public IHttpActionResult Put(ScheduledWalksEdit scheduledWalks)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateScheduledWalksService();

            if (!service.UpdateScheduledWalks(scheduledWalks))
                return InternalServerError();

            return Ok();
        }

        //Delete method

        //Delete
        /// <summary>
        /// Allows Admin to delete a Scheduled Walk
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A confirmation or denial that the Scheduled Walk has been deleted</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateScheduledWalksService();
            if (!service.DeleteScheduledWalks(id))
                return InternalServerError();

            return Ok();
        }
    }
}
