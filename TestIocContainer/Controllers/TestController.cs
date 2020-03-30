using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestIocContainer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly IServiceConsumer _svcConsumer;

        public TestController(ILogger<TestController> logger,IServiceConsumer serviceConsumer)
        {
            _logger = logger;
            _svcConsumer = serviceConsumer;
        }

        [HttpGet]
        public void Get()
        {
            _svcConsumer.UseService();
        }
    }
}
