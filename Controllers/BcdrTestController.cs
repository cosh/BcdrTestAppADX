using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BcdrTestAppADX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BcdrTestController : ControllerBase
    {
        private readonly ILogger<BcdrTestController> _logger;

        public BcdrTestController(ILogger<BcdrTestController> logger)
        {
            _logger = logger;
        }

        private TelemetryClient telemetry;

        // Use constructor injection to get a TelemetryClient instance.
        public BcdrTestController(TelemetryClient telemetry)
        {
            this.telemetry = telemetry;
        }

        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}
