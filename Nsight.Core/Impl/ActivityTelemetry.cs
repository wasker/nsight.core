using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core.Impl
{
    /// <summary>
    /// Implements activity telemetry contracts.
    /// </summary>
    internal sealed class ActivityTelemetry : IActivityTelemetry, IActivityTelemetrySource
    {
        #region IActivityTelemetrySource Members

        public event AsyncEventHandler<SessionInfo> OnBeginSessionAsync;

        public event AsyncEventHandler<SessionInfo> OnEndSessionAsync;

        public event AsyncEventHandler<EnvironmentInfo> OnSetEnvironmentInfoAsync;

        public event AsyncEventHandler<ActionInfo> OnReportActionAsync;

        public event AsyncEventHandler<ViewInfo> OnReportViewAsync;

        #endregion

        #region IActivityTelemetry Members

        public Task BeginSessionAsync(SessionInfo session)
        {
            if (null == session)
            {
                throw new ArgumentNullException(nameof(session));
            }

            return OnBeginSessionAsync.SafeInvokeAsync(this, session);
        }

        public Task EndSessionAsync(SessionInfo session)
        {
            if (null == session)
            {
                throw new ArgumentNullException(nameof(session));
            }

            return OnEndSessionAsync.SafeInvokeAsync(this, session);
        }

        public Task ReportActionAsync(ActionInfo action)
        {
            if (null == action)
            {
                throw new ArgumentNullException(nameof(action));
            }

            return OnReportActionAsync.SafeInvokeAsync(this, action);
        }

        public Task ReportViewAsync(ViewInfo view)
        {
            if (null == view)
            {
                throw new ArgumentNullException(nameof(view));
            }

            return OnReportViewAsync.SafeInvokeAsync(this, view);
        }

        public Task SetEnvironmentInfoAsync(EnvironmentInfo environment)
        {
            if (null == environment)
            {
                throw new ArgumentNullException(nameof(environment));
            }

            return OnSetEnvironmentInfoAsync.SafeInvokeAsync(this, environment);
        }

        #endregion
    }
}
