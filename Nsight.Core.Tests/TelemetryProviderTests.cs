using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nsight.Core.Tests
{
    [TestClass]
    public class TelemetryProviderTests
    {
        [TestMethod]
        public void ConfiguresTelemetrySources()
        {
            var telemetry = new Impl.TelemetryProvider();

            Assert.IsNotNull(telemetry.Activity);
            Assert.IsNotNull(telemetry.Health);

            var telemetrySink = (Impl.ITelemetrySource)telemetry;
            Assert.IsNotNull(telemetrySink.Activity);
            Assert.IsNotNull(telemetrySink.Health);
        }
    }
}
