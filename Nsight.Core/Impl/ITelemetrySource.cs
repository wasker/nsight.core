using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Contract for telemetry source.
    /// </summary>
    public interface ITelemetrySource
    {
        /// <summary>
        /// Gets activity telemetry source.
        /// </summary>
        IActivityTelemetrySource Activity { get; }

        /// <summary>
        /// Gets health telemetry source.
        /// </summary>
        IHealthTelemetrySource Health { get; }
    }
}
