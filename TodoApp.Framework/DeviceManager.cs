using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.DataContracts.Entities;
using TodoApp.DataRepository;
using TodoApp.OperationContracts;

namespace TodoApp.Framework
{
    public class DeviceManager : IDeviceManager
    {
        private IEntityRepository entityRepository;
        private IPlatformManager platformManager;

        public DeviceManager(IEntityRepository entityRepository, IPlatformManager platformManager)
        {
            this.entityRepository = entityRepository;
            this.platformManager = platformManager;
        }
        public Task<RegisterDeviceOutcome> RegisterDevice(Guid deviceGuid, string platform)
        {
            throw new NotImplementedException();
        }

        public Task<DeviceActionResultType> Update(Guid deviceGuid, GeolocationDto location, string pusToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDevice(Guid deviceGuid, long customerId, bool isLoggedIn)
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetDevice(Guid deviceGuid)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateDeviceToken(Platform platform, string uniqueCode, Guid deviceGuid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateToken(string token, Guid deviceGuid)
        {
            throw new NotImplementedException();
        }
    }
}
