using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// View information.
    /// </summary>
    public class ViewInfo : EventArgs
    {
        /// <summary>
        /// Gets or sets absolute path of the view (e.g. "/this/is/view/path").
        /// </summary>
        public string AbsolutePath { get; set; }

        /// <summary>
        /// Gets or sets view title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets amount of time spent to generate the view.
        /// </summary>
        public TimeSpan? Time { get; set; }
    }
}
