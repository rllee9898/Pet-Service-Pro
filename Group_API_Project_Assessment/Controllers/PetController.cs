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
    public class PetController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public PetController()
        {
            _context.Pets.Add(new Pet { PetType = "Dog", PetName = "Bailey" });
            _context.Pets.Add(new Pet { PetType = "Cat", PetName = "Max" });
            _context.Pets.Add(new Pet { PetType = "Bird", PetName = "Bella" });
            _context.Pets.Add(new Pet { PetType = "Fish", PetName = "Charlie" });
            _context.Pets.Add(new Pet { PetType = "Chinchilla", PetName = "Roxy" });
            _context.Pets.Add(new Pet { PetType = "Turtle", PetName = "Sam" });
            _context.Pets.Add(new Pet { PetType = "Hermit Crab", PetName = "Oscar" });
            _context.Pets.Add(new Pet { PetType = "Parrot", PetName = "Lily" });
            _context.Pets.Add(new Pet { PetType = "Guinea Pig", PetName = "Maggie" });
            _context.Pets.Add(new Pet { PetType = "Ferret", PetName = "Daisy" });
            _context.Pets.Add(new Pet { PetType = "Giraffe", PetName = "Rocky" });
        }

            //CRUD / PGPD
            //Post

            [HttpPost]
        public async Task<IHttpActionResult> Post(Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return Ok($"{pet.PetName} was added");
        }

        //Get
        //Get All

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Pet> genres = await _context.Pets.ToListAsync();
            return Ok(genres);
        }

        //Get by SKU
        [HttpGet]
        public async Task<IHttpActionResult> GetByID([FromUri] int id)
        {
            Pet pet = await _context.Pets.FindAsync(id);

            if (pet != null)
            {
                return Ok(pet);
            }
            return NotFound();
        }



        /*            //Update = Put
                    [HttpPut]
                    public async Task<IHttpActionResult> UpdateProduct([FromUri] string sku, [FromBody] Product model)
                    {
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        Pet product = await _context.Pets.FindAsync(sku);
                        if (product == null)
                        {
                            return NotFound();
                        }

                        if (product.SKU != model.SKU)
                        {
                            return BadRequest("Product SKU Missmatch");
                        }

                        //_context.Entry(model).State = EntityState.Modified;
                        //Does the same thing as setting properties individually
                        product.PetName = model.PetName;
                        product.NumberInStock = model.NumberInStock;
                        product.Cost = model.Cost;
                        //product.IsInStock = model.IsInStock;

                        await _context.SaveChangesAsync();
                        return Ok();

                    }

                    //Delete
                    [HttpDelete]
                    public async Task<IHttpActionResult> Delete([FromUri] string sku)
                    {
                        Product product = await _context.Products.FindAsync(sku);

                        if (product == null)
                        {
                            return NotFound();
                        }

                        _context.Products.Remove(product);
                        await _context.SaveChangesAsync();
                        return Ok($"{product.PetName} was removed from the DB");
                    }

                }*/
    }
}