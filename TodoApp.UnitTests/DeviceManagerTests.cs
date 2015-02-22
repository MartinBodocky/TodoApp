using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;
using TodoApp.DataRepository;
using TodoApp.Framework;
using TodoApp.OperationContracts;

namespace TodoApp.UnitTests
{
    [TestClass]
    public class DeviceManagerTests
    {
        private DeviceManager deviceManager;
        private EntityRepository entityRepository;

        [TestInitialize]
        public void SetUp()
        {
            // working with device manager we need to set up only test collection of devices and mock platform manager
            var devices = new List<Device>
            {

            };

            // mock IEntityContext
            var mockContext = new Mock<IEntityContext>();

            // set test doubles
            mockContext.Setup(m => m.Devices).Returns(devices.SetDbSet<Device, long>((d, id) => d.DeviceId == id));

            // set entity repository
            entityRepository = new EntityRepository(mockContext.Object);

            // mock platform manager
            var platformManager = new Mock<IPlatformManager>();

            // set device manager
            deviceManager = new DeviceManager(entityRepository, platformManager.Object);
        }

        [TestMethod]
        public void DeviceManager_RegisterDevice()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeviceManager_UpdateDevice()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeviceManager_UpdateDeviceAfterLogging()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeviceManager_GetDevice()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeviceManager_CreateDeviceToken()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeviceManager_ValidateDeviceToken()
        {
            Assert.Fail();
        }
    }
}
