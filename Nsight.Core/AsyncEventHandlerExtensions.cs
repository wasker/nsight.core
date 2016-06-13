using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Sourced from http://stackoverflow.com/a/35280607

namespace Nsight.Core
{
    /// <summary>
    /// Asynchronous event handler delegate.
    /// </summary>
    /// <typeparam name="TEventArgs">Event argument type.</typeparam>
    /// <param name="sender">Source of event.</param>
    /// <param name="e">Event arguments.</param>
    public delegate Task AsyncEventHandler<TEventArgs>(object sender, TEventArgs e)
        where TEventArgs : EventArgs;

    /// <summary>
    /// Extensions for asynchronous event invocation.
    /// </summary>
    public static class AsyncEventHandlerExtensions
    {
        /// <summary>
        /// Invokes all event handlers one-by-one, asynchronously.
        /// </summary>
        /// <typeparam name="TEventArgs">Event argument type.</typeparam>
        /// <param name="handler">Event to invoke.</param>
        /// <param name="sender">Source of event.</param>
        /// <param name="e">Event arguments.</param>
        /// <returns>List of tasks for each invoked handler.</returns>
        public static IEnumerable<Task> InvokeAll<TEventArgs>(this AsyncEventHandler<TEventArgs> handler, object sender, TEventArgs e)
            where TEventArgs : EventArgs => (from AsyncEventHandler<TEventArgs> h in handler.GetInvocationList() select h(sender, e)).ToArray();

        /// <summary>
        /// Implements <see cref="Task.WhenAll(Task[])"/> for <see cref="InvokeAll{TEventArgs}(AsyncEventHandler{TEventArgs}, object, TEventArgs)"/>.
        /// </summary>
        /// <typeparam name="TEventArgs">Event argument type.</typeparam>
        /// <param name="handler">Event to invoke.</param>
        /// <param name="sender">Source of event.</param>
        /// <param name="e">Event arguments.</param>
        /// <returns>Task to wait on.</returns>
        public static Task WhenInvokeAll<TEventArgs>(this AsyncEventHandler<TEventArgs> handler, object sender, TEventArgs e)
            where TEventArgs : EventArgs => Task.WhenAll(handler.InvokeAll(sender, e));

        /// <summary>
        /// Calls <see cref="WhenInvokeAll{TEventArgs}(AsyncEventHandler{TEventArgs}, object, TEventArgs)"/>, if event was subscribed to.
        /// </summary>
        /// <typeparam name="TEventArgs">Event argument type.</typeparam>
        /// <param name="handler">Event to invoke.</param>
        /// <param name="sender">Source of event.</param>
        /// <param name="e">Event arguments.</param>
        /// <returns>Task to wait on.</returns>
        public static async Task SafeInvokeAsync<TEventArgs>(this AsyncEventHandler<TEventArgs> handler, object sender, TEventArgs e)
            where TEventArgs : EventArgs
        {
            if (null != handler)
            {
                await handler.WhenInvokeAll(sender, e).ConfigureAwait(false);
            }
        }
    }
}
