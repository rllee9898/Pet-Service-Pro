using GroupAPI.Data;
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
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //CRUD / PGPD
        //Post

        [HttpPost]
        public async Task<IHttpActionResult> Post(IndividualWalkService individualWalkService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.IndividualWalkServices.Add(individualWalkService);
            await _context.SaveChangesAsync();
            return Ok($"{individualWalkService.ServiceName} was added");
        }

        //Get
        //Get All

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<IndividualWalkService> individualWalkService = await _context.IndividualWalkServices.ToListAsync();
            return Ok(individualWalkService);
        }

        //Get by serviceID
        [HttpGet]
        public async Task<IHttpActionResult> GetByID([FromUri] int ServiceId)
        {
            IndividualWalkService individualWalkService = await _context.IndividualWalkServices.FindAsync(ServiceId);

            if (individualWalkService != null)
            {
                return Ok(individualWalkService);
            }
            return NotFound();
        }



        //Update = Put
        [HttpPut]
        public async Task<IHttpActionResult> UpdateLocation([FromUri] int ServiceId, [FromBody] IndividualWalkService model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IndividualWalkService individualWalkService = await _context.IndividualWalkServices.FindAsync(ServiceId);
            if (individualWalkService == null)
            {
                return NotFound();
            }

            if (individualWalkService.ServiceId != model.ServiceId)
            {
                return BadRequest("IndividualWalkService Missmatch");
            }

            individualWalkService.ServiceId = model.ServiceId;
            individualWalkService.ServiceName = model.ServiceName;
            individualWalkService.WalkLength = model.WalkLength;
            individualWalkService.LocationId = model.LocationId;
            individualWalkService.Price = model.Price;

            await _context.SaveChangesAsync();
            return Ok();

        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> Delete([FromUri] int ServiceId)
        {
            IndividualWalkService individualWalkService = await _context.IndividualWalkServices.FindAsync(ServiceId);

            if (individualWalkService == null)
            {
                return NotFound();
            }

            _context.IndividualWalkServices.Remove(individualWalkService);
            await _context.SaveChangesAsync();
            return Ok($"{individualWalkService.ServiceName} was removed from the DB");
        }
    }
}