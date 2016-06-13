using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Screen resolution information.
    /// </summary>
    public sealed class ScreenResolution
    {
        /// <summary>
        /// Gets or sets screen width.
        /// </summary>
        public ushort Width { get; set; }

        /// <summary>
        /// Gets or sets screen height.
        /// </summary>
        public ushort Height { get; set; }

        /// <summary>
        /// Gets or sets screen DPI.
        /// </summary>
        public ushort Dpi { get; set; }
    }
}
