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
    public class ScheduledWalksController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //CRUD / PGPD
        //Post

        [HttpPost]
        public async Task<IHttpActionResult> Post(ScheduledWalks scheduledWalks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ScheduledWalkss.Add(scheduledWalks);
            await _context.SaveChangesAsync();
            return Ok($"{scheduledWalks.EventName} was added");
        }

        //Get
        //Get All

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<ScheduledWalks> scheduledWalks = await _context.ScheduledWalkss.ToListAsync();
            return Ok(scheduledWalks);
        }

        //Get by SKU
        [HttpGet]
        public async Task<IHttpActionResult> GetByID([FromUri] int LocationId)
        {
            ScheduledWalks scheduledWalks = await _context.ScheduledWalkss.FindAsync(LocationId);

            if (scheduledWalks != null)
            {
                return Ok(scheduledWalks);
            }
            return NotFound();
        }



        //Update = Put
        [HttpPut]
        public async Task<IHttpActionResult> UpdateLocation([FromUri] int LocationId, [FromBody] ScheduledWalks model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ScheduledWalks scheduledWalks = await _context.ScheduledWalkss.FindAsync(LocationId);
            if (scheduledWalks == null)
            {
                return NotFound();
            }

            if (scheduledWalks.EventId != model.EventId)
            {
                return BadRequest("ScheduledWalks Missmatch");
            }

            scheduledWalks.EventId = model.EventId;
            scheduledWalks.EventName = model.EventName;
            scheduledWalks.ServiceId = model.ServiceId;
            scheduledWalks.WalkerId = model.WalkerId;
            scheduledWalks.PetId = model.PetId;
            scheduledWalks.Price = model.Price;


            await _context.SaveChangesAsync();
            return Ok();

        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> Delete([FromUri] int LocationId)
        {
            ScheduledWalks scheduledWalks = await _context.ScheduledWalkss.FindAsync(LocationId);

            if (scheduledWalks == null)
            {
                return NotFound();
            }

            _context.ScheduledWalkss.Remove(scheduledWalks);
            await _context.SaveChangesAsync();
            return Ok($"{scheduledWalks.EventName} was removed from the DB");
        }
    }
}
