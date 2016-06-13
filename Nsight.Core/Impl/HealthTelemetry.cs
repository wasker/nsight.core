using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Implements health telemetry contracts.
    /// </summary>
    internal sealed class HealthTelemetry : IHealthTelemetry, IHealthTelemetrySource
    {
        #region IHealthTelemetrySource Members

        public event AsyncEventHandler<CrashInfo> OnReportCrashAsync;

        #endregion

        #region IHealthTelemetry Members

        public Task ReportCrashAsync(CrashInfo crash)
        {
            if (null == crash)
            {
                throw new ArgumentNullException(nameof(crash));
            }

            return OnReportCrashAsync.SafeInvokeAsync(this, crash);
        }

        #endregion
    }
}
