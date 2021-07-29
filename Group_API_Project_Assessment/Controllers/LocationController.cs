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
    public class LocationController : ApiController
    {

        private LocationService CreateLocationService()
        {
            var locationService = new LocationService();
            return locationService;
        }

        //Get Method
        public IHttpActionResult Get()
        {
            LocationService locationService = CreateLocationService();
            var location = locationService.GetLocations();
            return Ok(location);
        }

        public IHttpActionResult Get(int id)
        {
            LocationService locationService = CreateLocationService();
            var location = locationService.GetLocationById(id);
            return Ok(location);
        }

        //Post Method
        public IHttpActionResult Post(LocationCreate location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLocationService();

            if (!service.CreateLocation(location))
                return InternalServerError();

            return Ok();
        }


        //Put or Update Method

        //Put
        public IHttpActionResult Put(LocationEdit location)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLocationService();

            if (!service.UpdateLocation(location))
                return InternalServerError();

            return Ok();
        }

        //Delete method

        //Delete
        public IHttpActionResult Delete(int id)
        {
            var service = CreateLocationService();
            if (!service.DeleteLocation(id))
                return InternalServerError();

            return Ok();
        }
    }
}
