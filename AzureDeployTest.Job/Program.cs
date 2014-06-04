using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Loggly;
using Serilog;

namespace AzureDeployTest.Job
{
    class Program
    {
        static void Main(string[] args)
        {
            



            while (true)
            {
                var logger = new Logger("72797290-0fb1-46cb-b33b-c45c191b6e5f");
                logger.LogInfo("Hello World!");


            }
        }
    }
}
