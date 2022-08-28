using FakeItEasy;
using Order.BLL.Interfaces;
using Order.Common.Models;
using Order.Server.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Order.Tests
{
    public class ProviderControllerTests
    {
        [Fact]
        public async Task Get_Providers()
        {
            var providerName = "Test";
            var dataStore = A.Fake<IProviderService>();
            var controller = new ProviderController(dataStore);

            var actionResult = await controller.Get(1);

            Assert.Equal(providerName, actionResult.FirstOrDefault()?.Name);
        }
    }
}
