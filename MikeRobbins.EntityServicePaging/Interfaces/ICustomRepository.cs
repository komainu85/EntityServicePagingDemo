using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikeRobbins.EntityServicePaging.Models;
using Sitecore.Services.Core;

namespace MikeRobbins.EntityServicePaging.Interfaces
{
    public interface ICustomRepository<T> : Sitecore.Services.Core.IRepository<T> where T : IEntityIdentity
    {
        List<Entity> GetAll(int pageSize, int page);
    }
}
