using System;
using System.Collections.Generic;
using System.Linq;
using MikeRobbins.EntityServicePaging.Interfaces;
using MikeRobbins.EntityServicePaging.Models;

namespace MikeRobbins.EntityServicePaging.Repositories
{
    public class EntityRespository : ICustomRepository<Entity>
    {
        public IQueryable<Entity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entity FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(Entity entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public List<Entity> GetAll(int pageSize, int page)
        {
            throw new NotImplementedException();
        }
    }
}