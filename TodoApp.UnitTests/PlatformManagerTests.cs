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
    public class PlatformManagerTests
    {
        private EntityRepository entityRepository;
        private PlatformManager platformManager;

        [TestInitialize]
        public void SetUp()
        {
            // create collection of test platforms
            var platforms = new List<Platform>
            {

            };

            // mock entity context
            var mockContext = new Mock<IEntityContext>();

            // set test doubles
            mockContext.Setup(m => m.Platforms).Returns(platforms.SetDbSet<Platform, int>((p, id) => p.PlatformId == id));

            // set repository
            entityRepository = new EntityRepository(mockContext.Object);

            // initialize platform Manager
            platformManager = new PlatformManager(entityRepository);
        }

        [TestMethod]
        public void PlatfromManager_AddPlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_AddExistingPlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_GetPlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_ExistPlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_RemovePlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_UpdatePlatform()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void PlatfromManager_GetPlatforms()
        {
            Assert.Fail();
        }

    }
}
