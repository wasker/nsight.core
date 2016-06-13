using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Contract for health telemetry source.
    /// </summary>
    public interface IHealthTelemetrySource
    {
        /// <summary>
        /// Occurs when crash needs to be reported.
        /// </summary>
        event AsyncEventHandler<CrashInfo> OnReportCrashAsync;
    }
}
