using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.Demo.Hosting.Docker
{
    public class HelloModule : NancyModule
    {

        public HelloModule()
            : base("Hello")
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }

    }
}
