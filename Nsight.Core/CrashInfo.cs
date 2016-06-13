using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Crash information.
    /// </summary>
    public class CrashInfo : EventArgs
    {
        /// <summary>
        /// Gets or sets an exception that had occurred.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
