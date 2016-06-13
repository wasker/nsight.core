using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Activity telemetry contract.
    /// </summary>
    public interface IActivityTelemetry
    {
        /// <summary>
        /// Notifies about start of a new activity session.
        /// </summary>
        /// <param name="session">Session information.</param>
        Task BeginSessionAsync(SessionInfo session);

        /// <summary>
        /// Notifies about end of an activity session.
        /// </summary>
        /// <param name="session">Session information.</param>
        Task EndSessionAsync(SessionInfo session);

        /// <summary>
        /// Configures environment information.
        /// </summary>
        /// <param name="environment">Environment information.</param>
        Task SetEnvironmentInfoAsync(EnvironmentInfo environment);

        /// <summary>
        /// Reports view.
        /// </summary>
        /// <param name="view">View information.</param>
        Task ReportViewAsync(ViewInfo view);

        /// <summary>
        /// Reports action.
        /// </summary>
        /// <param name="action">Action information.</param>
        Task ReportActionAsync(ActionInfo action);
    }
}
