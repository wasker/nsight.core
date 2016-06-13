using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Contract for telemetry provider.
    /// </summary>
    public interface ITelemetryProvider
    {
        /// <summary>
        /// Gets activity telemetry provider.
        /// </summary>
        IActivityTelemetry Activity { get; }

        /// <summary>
        /// Gets health telemetry provider.
        /// </summary>
        IHealthTelemetry Health { get; }
    }
}
