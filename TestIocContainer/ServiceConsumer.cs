using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestIocContainer
{
    public class ServiceConsumer : IServiceConsumer
    {
        IList<ITestService> _testServices;
        public ServiceConsumer(IEnumerable<ITestService> testServices)
        {
            _testServices = testServices.ToList();
        }
        public void UseService()
        {
            foreach(var aSvc in _testServices)
            {
                aSvc.DoSomething();
            }
        }
    }
}
