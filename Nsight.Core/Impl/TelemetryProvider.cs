using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Implements telemetry contracts.
    /// </summary>
    public sealed class TelemetryProvider : ITelemetryProvider, ITelemetrySource
    {
        private readonly ActivityTelemetry activity = new ActivityTelemetry();

        private readonly HealthTelemetry health = new HealthTelemetry();

        #region ITelemetryProvider Members

        public IActivityTelemetry Activity => activity;

        public IHealthTelemetry Health => health;

        #endregion

        #region ITelemetrySource Members

        IActivityTelemetrySource ITelemetrySource.Activity => activity;

        IHealthTelemetrySource ITelemetrySource.Health => health;

        #endregion
    }
}
