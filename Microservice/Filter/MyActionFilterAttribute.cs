using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyActionFilterAttribute:ActionFilterAttribute
    {
        private readonly ILogger<MyActionFilterAttribute> _logger;
        private readonly IAnnouncementProvider _announcementProvider;
        private readonly Position _position;
        private long aa = DateTime.Now.Ticks;

        public MyActionFilterAttribute(
            ILogger<MyActionFilterAttribute> logger,
            IOptions<Position> options,
            IAnnouncementProvider announcementProvider)
        {
            this._logger = logger;
            this._announcementProvider = announcementProvider;
            this._position = options.Value;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var data = _announcementProvider.GetList().GetAwaiter().GetResult();
            context.Result = new ContentResult()
            {
                Content = JsonConvert.SerializeObject(data),
                StatusCode = (int)HttpStatusCode.BadRequest
            };
            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var a = 123;
            base.OnResultExecuting(context);
        }

    }
}
