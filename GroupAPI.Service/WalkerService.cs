using GroupAPI.Data;
using GroupAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Service
{
    public class WalkerService
    {
        //PGPD

        //Post 

        // This will create a instance of Walker
        public bool CreateWalker(WalkerCreate model)
        {
            var entity =
                new Walker()
                {
                    WalkerId = model.WalkerId,
                    WalkerName = model.WalkerName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Walkers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get

        //This method will allow us to see all the walkers that belong to a specific user.
        public IEnumerable<WalkerListItem> GetWalkers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Walkers
                        //.Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new WalkerListItem
                                {
                                    WalkerId = e.WalkerId,
                                    WalkerName = e.WalkerName
                                }
                        );
                return query.ToArray();
            }

        }

        public WalkerDetail GetWalkerById(int WalkerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var enity =
                    ctx
                        .Walkers
                        .Single(e => e.WalkerId == WalkerId);
                        //== id && e.OwnerId == _userId);
                return
                    new WalkerDetail
                    {
                        WalkerId = enity.WalkerId,
                        WalkerName = enity.WalkerName
                    };
            }


        }

        //Put or Update

        //Update Method
        public bool UpdateWalker(WalkerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Walkers.Single(e => e.WalkerId == model.WalkerId); 
                    //&& e.OwnerId == _userId);

                entity.WalkerId = model.WalkerId;
                entity.WalkerName = model.WalkerName;

                return ctx.SaveChanges() == 1;

            }
        }

        //Delete Method

        //Delete
        public bool DeleteWalker(int walkerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Walkers
                        .Single(e => e.WalkerId == walkerId);
                //.Single(e => e.WalkerId == walkerId && e.OwnerId == _userId);

                ctx.Walkers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

