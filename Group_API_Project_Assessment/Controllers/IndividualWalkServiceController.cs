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
    public class IndividualWalkServiceController : ApiController
    {
        private IndividualWalkServiceService CreateIndividualWalkServiceService()
        {
            var individualWalkServiceService = new IndividualWalkServiceService();
            return individualWalkServiceService;
        }

        //Get Method
        public IHttpActionResult Get()
        {
            IndividualWalkServiceService individualWalkServiceService = CreateIndividualWalkServiceService();
            var individualWalkService = individualWalkServiceService.GetIndividualWalkServiceService();
            return Ok(individualWalkService);
        }

        public IHttpActionResult Get(int id)
        {
            IndividualWalkServiceService individualWalkServiceService = CreateIndividualWalkServiceService();
            var individualWalkService = individualWalkServiceService.GetIndividualWalkServiceServiceById(id);
            return Ok(individualWalkService);
        }

        //Post Method
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
        public IHttpActionResult Delete(int id)
        {
            var service = CreateIndividualWalkServiceService();
            if (!service.DeleteIndividualWalkService(id))
                return InternalServerError();

            return Ok();
        }
    }
}
