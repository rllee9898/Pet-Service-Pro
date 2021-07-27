﻿using GroupAPI.Data;
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
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //CRUD / PGPD
        //Post

        [HttpPost]
        public async Task<IHttpActionResult> Post(Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return Ok($"{location.City} was added");
        }

        //Get
        //Get All

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Location> location = await _context.Locations.ToListAsync();
            return Ok(location);
        }

        //Get by SKU
        [HttpGet]
        public async Task<IHttpActionResult> GetByID([FromUri] int LocationId)
        {
            Location location = await _context.Locations.FindAsync(LocationId);

            if (location != null)
            {
                return Ok(location);
            }
            return NotFound();
        }



        //Update = Put
        [HttpPut]
        public async Task<IHttpActionResult> UpdateLocation([FromUri] int LocationId, [FromBody] Location model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Location location = await _context.Locations.FindAsync(LocationId);
            if (location == null)
            {
                return NotFound();
            }

            if (location.LocationId != model.LocationId)
            {
                return BadRequest("Location Missmatch");
            }

            location.LocationId = model.LocationId;
            location.LocationStart = model.LocationStart;
            location.LocationEnd = model.LocationEnd;
            location.City = model.City;
            location.State = model.State;

            await _context.SaveChangesAsync();
            return Ok();

        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> Delete([FromUri] int LocationId)
        {
            Location location = await _context.Locations.FindAsync(LocationId);

            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return Ok($"{location.City} was removed from the DB");
        }
    }
}