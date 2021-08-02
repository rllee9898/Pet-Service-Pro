using GroupAPI.Data;
using GroupAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Service
{
    public class LocationService
    {
        public bool CreateLocation(LocationCreate model)
        {
            var entity =
                new Location()
                {
                    LocationId = model.LocationId,
                    LocationStart = model.LocationStart,
                    LocationEnd = model.LocationEnd,
                    City = model.City,
                    State = model.State
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Locations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get

        //This method will allow us to see all the locations.
        public IEnumerable<LocationListItem> GetLocations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Locations
                        .Select(
                            e =>
                                new LocationListItem
                                {
                                    LocationId = e.LocationId,
                                    LocationStart = e.LocationStart,
                                    LocationEnd = e.LocationEnd,
                                    City = e.City,
                                    State = e.State
                                }
                        );
                return query.ToArray();
            }

        }

        public LocationDetail GetLocationById(int LocationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var enity =
                    ctx
                        .Locations
                        .Single(e => e.LocationId == LocationId);
                return
                    new LocationDetail
                    {
                        LocationId = enity.LocationId,
                        LocationStart = enity.LocationStart,
                        LocationEnd = enity.LocationEnd,
                        City = enity.City,
                        State = enity.State
                    };
            }


        }

        //Put or Update

        //Update Method
        public bool UpdateLocation(LocationEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Locations.Single(e => e.LocationId == model.LocationId);

                entity.LocationId = model.LocationId;
                entity.LocationStart = model.LocationStart;
                entity.LocationEnd = model.LocationEnd;
                entity.City = model.City;
                entity.State = model.State;

                return ctx.SaveChanges() == 1;

            }
        }

        //Delete Method

        //Delete
        public bool DeleteLocation(int LocationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Locations
                    .Single(e => e.LocationId == LocationId);

                ctx.Locations.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
