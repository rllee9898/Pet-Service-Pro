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
    public class ScheduledWalksController : ApiController
    {
        private ScheduledWalkService CreateScheduledWalksService()
        {
            var scheduledWalksService = new ScheduledWalkService();
            return scheduledWalksService;
        }

        //Get Method
        public IHttpActionResult Get()
        {
            ScheduledWalkService scheduledWalksService = CreateScheduledWalksService();
            var scheduledWalks = scheduledWalksService.GetScheduledWalks();
            return Ok(scheduledWalks);
        }

        public IHttpActionResult Get(int id)
        {
            ScheduledWalkService scheduledWalksService = CreateScheduledWalksService();
            var scheduledWalks = scheduledWalksService.GetScheduledWalksById(id);
            return Ok(scheduledWalks);
        }

        //Post Method
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
        public IHttpActionResult Delete(int id)
        {
            var service = CreateScheduledWalksService();
            if (!service.DeleteScheduledWalks(id))
                return InternalServerError();

            return Ok();
        }
    }
}
