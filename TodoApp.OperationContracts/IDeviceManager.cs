using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    /// <summary>
    /// Device interface defines functions on device and manage devices
    /// </summary>
    public interface IDeviceManager
    {
        Task<RegisterDeviceOutcome> RegisterDevice(Guid deviceGuid, string platform);
        Task<DeviceActionResultType> Update(Guid deviceGuid, GeolocationDto location, string pusToken);
        Task<bool> UpdateDevice(Guid deviceGuid, long customerId, bool isLoggedIn);
        Task<Device> GetDevice(Guid deviceGuid);

        Task<string> CreateDeviceToken(Platform platform, string uniqueCode, Guid deviceGuid);
        Task<bool> ValidateToken(string token, Guid deviceGuid);
    }
}
