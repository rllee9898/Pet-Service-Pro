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
    public class WalkerController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public WalkerController()
        {
            _context.Walkers.Add(new Walker { WalkerName = "James" });
            _context.Walkers.Add(new Walker { WalkerName = "Mary" });
            _context.Walkers.Add(new Walker { WalkerName = "Robert" });
            _context.Walkers.Add(new Walker { WalkerName = "Susan" });
            _context.Walkers.Add(new Walker { WalkerName = "Jennifer" });
            _context.Walkers.Add(new Walker { WalkerName = "Richard" });
            _context.Walkers.Add(new Walker { WalkerName = "Ashley" });
            _context.Walkers.Add(new Walker { WalkerName = "Paul" });
            _context.Walkers.Add(new Walker { WalkerName = "Emily" });
            _context.Walkers.Add(new Walker { WalkerName = "Michael" });
            _context.Walkers.Add(new Walker { WalkerName = "Kathleen" });
        }

            //CRUD / PGPD
            //Post

            [HttpPost]
        public async Task<IHttpActionResult> Post(Walker walker)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Walkers.Add(walker);
            await _context.SaveChangesAsync();
            return Ok($"{walker.WalkerName} was added");
        }

        //Get
        //Get All

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Walker> genres = await _context.Walkers.ToListAsync();
            return Ok(genres);
        }

        //Get by SKU
        [HttpGet]
        public async Task<IHttpActionResult> GetByID([FromUri] int id)
        {
            Walker walker = await _context.Walkers.FindAsync(id);

            if (walker != null)
            {
                return Ok(walker);
            }
            return NotFound();
        }
    }
}
