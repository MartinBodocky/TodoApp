using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    public interface IPlatformManager
    {
        Task<Platform> GetPlatform(long id);
        Task<bool> Exist(long id);
        Task<IEnumerable<Platform>> GetList();
        Task AddPlatform(Platform platform);
        Task RemovePlatform(Platform platform);
        Task UpdatePlatform(Platform platform);
    }
}
