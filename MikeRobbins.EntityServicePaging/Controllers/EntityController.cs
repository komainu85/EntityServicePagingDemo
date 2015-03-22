using System.Collections.Generic;
using System.Web.Http;
using MikeRobbins.EntityServicePaging.Interfaces;
using MikeRobbins.EntityServicePaging.Models;
using MikeRobbins.EntityServicePaging.Repositories;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace MikeRobbins.EntityServicePaging.Controllers
{
    [ServicesController]
    public class EntityController : EntityService<Entity>
    {
        private ICustomRepository<Entity> _customRepository;

        public EntityController(ICustomRepository<Entity> repository)
            : base(repository)
        {
            _customRepository = repository;
        }

        public EntityController()
            : this(new EntityRespository())
        {
        }

        [HttpGet]
        [ActionName("GetAllPaged")]
        public List<Entity> Get(int pageSize, int page)
        {
            return _customRepository.GetAll(pageSize,page);
        }
    }
}