using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nsight.Core.Tests
{
    [TestClass]
    public class HealthTelemetrySourceTests
    {
        [TestMethod]
        public async Task RaisesReportCrashEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var raised = false;
            telemetrySink.Health.OnReportCrashAsync += async (sender, e) => raised = true;

            await telemetry.Health.ReportCrashAsync(new CrashInfo());
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public void DoesNotCrashWithoutEventHandlers()
        {
            var telemetry = new Impl.TelemetryProvider();

            telemetry.Health.ReportCrashAsync(new CrashInfo());

            Assert.IsTrue(true, "This test should not throw.");
        }
    }
}
