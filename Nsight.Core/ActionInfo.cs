using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsight.Core
{
    /// <summary>
    /// Action information.
    /// </summary>
    public class ActionInfo : EventArgs
    {
        /// <summary>
        /// Gets or sets name of the action (e.g. "BuyButton").
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets verb of the action (e.g. "Click").
        /// </summary>
        public string Verb { get; set; }

        /// <summary>
        /// Gets or sets action category.
        /// </summary>
        public string Category { get; set; }
    }
}
