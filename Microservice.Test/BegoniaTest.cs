using MicroService.Begonia.Controllers;
using MicroService.Begonia.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NFluent;
using Repository.Begonia.Db;
using Repository.Begonia.Interface;
using Repository.Db;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.Test
{
    [TestClass]
    public class BegoniaTest
    {
        private static IConfiguration _configuration;
        private static ILogger<WeatherForecastController> _logger;
        private static SqlConnectionDeveloperDb _sqlConnectionBegonia;
        private static IANNOUNCEMENT_GROUPRepository _aNNOUNCEMENT_GROUPRepository;
        private static IANNOUNCEMENTRepository _aNNOUNCEMENTRepository;
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            _logger = new Logger<WeatherForecastController>(logFactory);

            IConfigurationBuilder configuration = new ConfigurationBuilder();

            var connstr = testContext.Properties["begoniaConnStr"];
            Assert.IsTrue(connstr != null);

            var configDic = new Dictionary<string, string>() {
                { "ConnectionStrings:begonia",$"{connstr}"}
            };
            configuration.AddInMemoryCollection(configDic);

            _configuration = configuration.Build();

            var checkstr = _configuration.GetConnectionString("begonia");

            Check.That(checkstr).IsNotEmpty();

            _sqlConnectionBegonia = new SqlConnectionDeveloperDb(_configuration);

            _aNNOUNCEMENT_GROUPRepository = new ANNOUNCEMENT_GROUPRepository(_sqlConnectionBegonia);

            _aNNOUNCEMENTRepository = new GradesRepository(_sqlConnectionBegonia);

            /*
            var announcementProvider = new Mock<IAnnouncementProvider>();
            announcementProvider
                .Setup(x => x.GetList())
                .ReturnsAsync(Enumerable.Repeat(new Announcement(), 1));
            */
        }

        [TestMethod]
        public void Test_WeatherForecastController_Get()
        {
            var controller = new WeatherForecastController(
                configuration: _configuration,
                logger: _logger,
                sqlConnectionBegonia: _sqlConnectionBegonia,
                aNNOUNCEMENT_GROUPRepository: _aNNOUNCEMENT_GROUPRepository,
                aNNOUNCEMENTRepository: _aNNOUNCEMENTRepository);


            var data = controller.Get();
            var count = data.Count();
            Check.That(count).IsNotZero();
            /*
            var announcementProvider = new Mock<IAnnouncementProvider>();
            announcementProvider
                .Setup(x => x.GetList())
                .ReturnsAsync(Enumerable.Repeat(new Announcement(),1));


            
            */

        }
    }
}
