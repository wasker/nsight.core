using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nsight.Core.Tests
{
    [TestClass]
    public class ActivityTelemetrySourceTests
    {
        [TestMethod]
        public async Task BeginSession_RaisesEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var sessionInfo = new SessionInfo()
            {
                UniqueVisitorId = "1234"
            };

            var raised = false;
            telemetrySink.Activity.OnBeginSessionAsync += async (sender, session) => raised = sessionInfo == session;

            await telemetry.Activity.BeginSessionAsync(sessionInfo);
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public async Task EndSession_RaisesEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var raised = false;
            telemetrySink.Activity.OnEndSessionAsync += async (sender, session) => raised = true;

            await telemetry.Activity.EndSessionAsync(new SessionInfo());
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public async Task SetEnvironmentInfo_RaisesEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var environmentInfo = new EnvironmentInfo()
            {
                DeviceName = "some device"
            };

            var raised = false;
            telemetrySink.Activity.OnSetEnvironmentInfoAsync += async (sender, environment) => raised = environmentInfo == environment;

            await telemetry.Activity.SetEnvironmentInfoAsync(environmentInfo);
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public async Task ReportView_RaisesEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var viewInfo = new ViewInfo();

            var raised = false;
            telemetrySink.Activity.OnReportViewAsync += async (sender, view) => raised = viewInfo == view;

            await telemetry.Activity.ReportViewAsync(viewInfo);
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public async Task ReportAction_RaisesEvent()
        {
            var telemetry = new Impl.TelemetryProvider();
            var telemetrySink = (Impl.ITelemetrySource)telemetry;

            var actionInfo = new ActionInfo();

            var raised = false;
            telemetrySink.Activity.OnReportActionAsync += async (sender, action) => raised = actionInfo == action;

            await telemetry.Activity.ReportActionAsync(actionInfo);
            Assert.IsTrue(raised);
        }

        [TestMethod]
        public async Task DoesNotCrashWithoutEventHandlers()
        {
            var telemetry = new Impl.TelemetryProvider();

            await telemetry.Activity.BeginSessionAsync(new SessionInfo());
            await telemetry.Activity.SetEnvironmentInfoAsync(new EnvironmentInfo());
            await telemetry.Activity.ReportViewAsync(new ViewInfo());
            await telemetry.Activity.ReportActionAsync(new ActionInfo());
            await telemetry.Activity.EndSessionAsync(new SessionInfo());

            Assert.IsTrue(true, "This test should not throw.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task BeginSession_Throws_InvalidArguments()
        {
            var telemetry = new Impl.TelemetryProvider();
            await telemetry.Activity.BeginSessionAsync(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task SetEnvironmentInfo_Throws_InvalidArguments()
        {
            var telemetry = new Impl.TelemetryProvider();
            await telemetry.Activity.SetEnvironmentInfoAsync(null);
        }
    }
}
