using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Environment information.
    /// </summary>
    public class EnvironmentInfo : EventArgs
    {
        /// <summary>
        /// Gets or sets operating system name and version.
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets device name.
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Gets or sets device type.
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or sets device screen resolution.
        /// </summary>
        public ScreenResolution DeviceScreen { get; set; }
    }
}
