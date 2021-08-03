using GroupAPI.Data;
using GroupAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAPI.Service
{
    public class PetService
    {
        private readonly Guid _userId;

        public PetService(Guid userId)
        {
            _userId = userId;
        }

        //PGPD

        //Post 

        // This will create a instance of Pet
        public bool CreatePet(PetCreate model)
        {
            var entity =
                new Pet()
                {
                    OwnerId = _userId,
                    PetId = model.PetId,
                    PetType = model.PetType,
                    PetName = model.PetName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Pets.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get

        //This method will allow us to see the pets that belong to a specific user.
        public IEnumerable<PetListItem> GetPetsByUserId()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Pets
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PetListItem
                                {
                                    OwnerId = e.OwnerId,
                                    PetId = e.PetId,
                                    PetType = e.PetType,
                                    PetName = e.PetName
                                }
                        );
                return query.ToArray();
            }
            
        }

        //This method will allow us to see the pets that belong to a specific user.
        public IEnumerable<PetListItem> GetPets()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Pets
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PetListItem
                                {
                                    OwnerId = e.OwnerId,
                                    PetId = e.PetId,
                                    PetType = e.PetType,
                                    PetName = e.PetName
                                }
                        );
                return query.ToArray();
            }

        }

        public PetDetail GetPetById(int Petid)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var enity =
                    ctx
                        .Pets
                        .Single(e => e.PetId == Petid && e.OwnerId == _userId);
                return
                    new PetDetail
                    {
                        OwnerId = enity.OwnerId,
                        PetId = enity.PetId,
                        PetType = enity.PetType,
                        PetName = enity.PetName
                    };
            }


        }

        //Put or Update

        //Update Method
        public bool UpdatePet(PetEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Pets.Single(e => e.PetId == model.PetId && e.OwnerId == _userId);

                entity.OwnerId = model.OwnerId;
                entity.PetId = model.PetId;
                entity.PetType = model.PetType;
                entity.PetName = model.PetName;

                return ctx.SaveChanges() == 1;

            }
        }

        //Delete Method

        //Delete
        public bool DeletePet(int petId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Pets
                    .Single(e => e.PetId == petId && e.OwnerId == _userId);

                ctx.Pets.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}