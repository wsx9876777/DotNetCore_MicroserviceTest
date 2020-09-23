using Microservice.Controllers;
using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ILogger<AnnouncementController> _logger;
        private readonly IAnnouncementProvider _announcementProvider;

        [TestMethod]
        public void TestMethod1()
        {

            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = new Logger<AnnouncementController>(loggerFactory);
     
            var announcementProvider = new Mock<IAnnouncementProvider>();
            announcementProvider
                .Setup(x => x.GetList())
                .ReturnsAsync(Enumerable.Repeat(new Announcement(),1));


            var controller = new AnnouncementController(logger, announcementProvider.Object);
            var test = controller.Get("abc");


        }
    }
}
