using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;
using TodoApp.OperationContracts;

namespace TodoApp.Framework
{
    public class PlatformManager : IPlatformManager
    {
        private IEntityRepository entityRepository;

        public PlatformManager(IEntityRepository entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public Task<Platform> GetPlatform(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Platform>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task AddPlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Task RemovePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }
    }
}
