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
    /// This is where the user can find information about the Location of a walk
    /// </summary>
    
    public class LocationController : ApiController
    {

        private LocationService CreateLocationService()
        {
            var locationService = new LocationService();
            return locationService;
        }

        //Get Method
        /// <summary>
        /// Gets a list of the Locations available for walks
        /// </summary>
        /// <returns>A list of locations</returns>
        
        public IHttpActionResult Get()
        {
            LocationService locationService = CreateLocationService();
            var location = locationService.GetLocations();
            return Ok(location);
        }

        /// <summary>
        /// Gets a specific Location based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A singular Location</returns>
        public IHttpActionResult Get(int id)
        {
            LocationService locationService = CreateLocationService();
            var location = locationService.GetLocationById(id);
            return Ok(location);
        }

        //Post Method
        /// <summary>
        /// Allows Admin to add a new Location
        /// </summary>
        /// <param name="location"></param>
        /// <returns>A success or failure message</returns>
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
        /// <summary>
        /// Allows Admin to edit the Location of a walk
        /// </summary>
        /// <param name="location"></param>
        /// <returns>A Success or failure message</returns>
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
        /// <summary>
        /// Allows Admin to delete a Location
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A confirmation or denial that the Location has been deleted</returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateLocationService();
            if (!service.DeleteLocation(id))
                return InternalServerError();

            return Ok();
        }
    }
}
