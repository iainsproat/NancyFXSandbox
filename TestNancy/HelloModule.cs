using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;

namespace TestNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
            Get["/index"] = parameters =>
                {
                    return View["views/Index.cshtml"];
                };
            Get["/miserables.json"] = parameters =>
                {
                    return Response.AsFile("data/miserables.json");
                };
        }
    }
}