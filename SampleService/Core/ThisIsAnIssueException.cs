
namespace Core
{
    using System;

    /// <summary>
    /// Implements an exception when 'this' is an issue!
    /// </summary>
    public class ThisIsAnIssueException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThisIsAnIssueException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public ThisIsAnIssueException(string message)
            : base(message)
        {          
        }
    }
}
