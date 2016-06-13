using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Contract for activity telemetry source.
    /// </summary>
    public interface IActivityTelemetrySource
    {
        /// <summary>
        /// Occurs when session begins.
        /// </summary>
        event AsyncEventHandler<SessionInfo> OnBeginSessionAsync;

        /// <summary>
        /// Occurs when session ends.
        /// </summary>
        event AsyncEventHandler<SessionInfo> OnEndSessionAsync;

        /// <summary>
        /// Occurs when environment information is available.
        /// </summary>
        event AsyncEventHandler<EnvironmentInfo> OnSetEnvironmentInfoAsync;

        /// <summary>
        /// Occurs when view is reported.
        /// </summary>
        event AsyncEventHandler<ViewInfo> OnReportViewAsync;

        /// <summary>
        /// Occurs when action is reported.
        /// </summary>
        event AsyncEventHandler<ActionInfo> OnReportActionAsync;
    }
}
