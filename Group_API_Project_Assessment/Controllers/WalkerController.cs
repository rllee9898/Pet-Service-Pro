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
    public class WalkerController : ApiController
    {
        private WalkerService CreateWalkerService()
        {
            var walkerService = new WalkerService();
            return walkerService;
        }

        //Get Method
        public IHttpActionResult Get()
        {
            WalkerService walkerService = CreateWalkerService();
            var walker = walkerService.GetWalkers();
            return Ok(walker);
        }

        public IHttpActionResult Get(int id)
        {
            WalkerService walkerService = CreateWalkerService();
            var walker = walkerService.GetWalkerById(id);
            return Ok(walker);
        }

        //Post Method
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
        public IHttpActionResult Delete(int id)
        {
            var service = CreateWalkerService();
            if (!service.DeleteWalker(id))
                return InternalServerError();

            return Ok();
        }
    }
}
