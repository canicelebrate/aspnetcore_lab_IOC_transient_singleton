using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestIocContainer
{
    public class TestService2 : ITestService
    {
        private string TAG = Guid.NewGuid().ToString();

        public void DoSomething()
        {
            Console.WriteLine($"Do something 2, tag:{TAG}");
        }
    }
}
