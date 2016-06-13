using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Health telemetry contract.
    /// </summary>
    public interface IHealthTelemetry
    {
        /// <summary>
        /// Reports crash.
        /// </summary>
        /// <param name="crashInfo">Crash information.</param>
        Task ReportCrashAsync(CrashInfo crashInfo);
    }
}
