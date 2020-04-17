using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExample.Dependencies
{
    public class ChuckDependency : IChuckDependency
    {
        public ChuckDependency()
        {
            Console.WriteLine(Environment.StackTrace);
        }
    }
}