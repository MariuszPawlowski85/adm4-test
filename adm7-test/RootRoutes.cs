using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace hosting_on_IP
{
    public class RootRoutes : NancyModule
    {
        public RootRoutes()
        {
            Get["/"] = parameters => "Hello World 2";

        }

    }
}
