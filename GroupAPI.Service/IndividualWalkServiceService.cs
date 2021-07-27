using GroupAPI.Data;
using GroupAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Service
{
    class IndividualWalkServiceService
    {
        public bool CreateIndividualWalkServiceService(IndividualWalkServiceCreate model)
        {
            var entity =
                new IndividualWalkService()
                {
                    ServiceId = model.ServiceId,
                    ServiceName = model.ServiceName,
                    WalkLength = model.WalkLength,
                    LocationId = model.LocationId,
                    Price = model.Price
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.IndividualWalkServices.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //Get
        //This method will allow us to see all the pets that belong to a specific user.
        public IEnumerable<IndividualWalkServiceListItem> GetIndividualWalkServiceService()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .IndividualWalkServices
                        .Select(
                            e =>
                                new IndividualWalkServiceListItem
                                {
                                    ServiceId = e.ServiceId,
                                    ServiceName = e.ServiceName,
                                    WalkLength = e.WalkLength,
                                    LocationId = e.LocationId,
                                    Price = e.Price                                 
                                }
                        );
                return query.ToArray();
            }
        }
        public IndividualWalkServiceDetail GetIndividualWalkServiceServiceById(int ServiceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var enity =
                    ctx
                        .IndividualWalkServices
                        .Single(e => e.ServiceId == ServiceId);
                return
                    new IndividualWalkServiceDetail
                    {
                        ServiceId = enity.ServiceId,
                        ServiceName = enity.ServiceName,
                        WalkLength = enity.WalkLength,
                        LocationId = enity.LocationId,
                        Price = enity.Price
                    };
            }
        }
        //Put or Update
        //Update Method
        public bool UpdateLocation(IndividualWalkServiceEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.IndividualWalkServices.Single(e => e.ServiceId == model.ServiceId);
                entity.ServiceId = model.ServiceId;

                entity.ServiceName = model.ServiceName;
                entity.WalkLength = model.WalkLength;
                entity.LocationId = model.LocationId;
                entity.Price = model.Price;                
                return ctx.SaveChanges() == 1;
            }
        }
        //Delete Method
        //Delete
        public bool DeleteLocation(int ServiceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .IndividualWalkServices
                  
                    .Single(e => e.ServiceId == ServiceId);
                
                ctx.IndividualWalkServices.Remove(entity);
               
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
