using GroupAPI.Data;
using GroupAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Service
{
    class ScheduledWalkService
    {
        public bool CreateIndividualWalkServiceService(ScheduledWalksCreate model)
        {
            var entity =
                new ScheduledWalks()
                {
                    EventId = model.EventId,
                    EventName = model.EventName,
                    ServiceId = model.ServiceId,
                    PetId = model.PetId,
                    Price = model.Price
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.ScheduledWalkss.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //Get
        //This method will allow us to see all the events.
        public IEnumerable<ScheduledWalksListItem> GetScheduledWalks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .ScheduledWalkss
                        .Select(
                            e =>
                                new ScheduledWalksListItem
                                {
                                    EventId = e.EventId,
                                    EventName = e.EventName,
                                    ServiceId = e.ServiceId,
                                    PetId = e.PetId,
                                    Price = e.Price
                                }
                        );
                return query.ToArray();
            }
        }
        public ScheduledWalksDetail GetScheduledWalksById(int EventId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var enity =
                    ctx
                        .ScheduledWalkss
                        .Single(e => e.EventId == EventId);
                return
                    new ScheduledWalksDetail
                    {
                        EventId = enity.EventId,
                        EventName = enity.EventName,
                        ServiceId = enity.ServiceId,
                        PetId = enity.PetId,
                        Price = enity.Price
                    };
            }
        }
        //Put or Update
        //Update Method
        public bool UpdateScheduledWalks(ScheduledWalksEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.ScheduledWalkss.Single(e => e.EventId == model.EventId);


                entity.EventId = model.EventId;
                entity.EventName = model.EventName;
                entity.ServiceId = model.ServiceId;
                entity.PetId = model.PetId;
                entity.Price = model.Price;



                return ctx.SaveChanges() == 1;
            }
        }
        //Delete Method
        //Delete
        public bool DeleteScheduledWalks(int EventId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .ScheduledWalkss

                    .Single(e => e.EventId == EventId);

                ctx.ScheduledWalkss.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
