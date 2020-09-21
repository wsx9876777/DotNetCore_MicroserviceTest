using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class AddHeaderAttribute: ActionFilterAttribute
    {
        private readonly string _author;
        private readonly string _value;

        public AddHeaderAttribute(string author,string value)
        {
            this._author = author;
            this._value = value;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "Resource unavailable - header not set."
            };

            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            //var data = _announcementProvider.GetList();
            var a = 123;
            base.OnResultExecuting(context);
        }
    }
}
