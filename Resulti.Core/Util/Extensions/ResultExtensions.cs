using Resulti.Core.Notifications;
using Resulti.Core.Results;

namespace Resulti.Core.Util.Extensions
{
    /// <summary>
    /// Collection of common utility extension methods dealing with results
    /// </summary>
    public static class ResultExtensions
    {
        /// <summary>
        /// Utility to set a result to successful in a builder pattern
        /// </summary>
        /// <param name="r">The result to set to success</param>
        /// <returns>Self</returns>
        public static Result Success(this Result r)
        {
            r.Status = ResultStatus.Success;
            return r;
        }

        /// <summary>
        /// Utility to set a result to successful in a builder pattern
        /// </summary>
        /// <param name="r">The result to set to success</param>
        /// <param name="data">The data related to the successful result</param>
        /// <returns>Self</returns>
        public static Result<T> Success<T>(this Result<T> r, T data)
        {
            r.Status = ResultStatus.Success;
            r.Data = data;
            return r;
        }
        
        /// <summary>
        /// Utility to set a result to failure in a builder pattern
        /// </summary>
        /// <param name="r">The result to set to failed</param>
        /// <returns>Self</returns>
        public static Result Failure(this Result r)
        {
            r.Status = ResultStatus.Failure;
            return r;
        }

        /// <summary>
        /// Utility to set a result to failure in a builder pattern
        /// </summary>
        /// <param name="r">The result to set to failure</param>
        /// <returns>Self</returns>
        public static Result<T> Failure<T>(this Result<T> r)
        {
            r.Status = ResultStatus.Success;
            r.Data = default;
            return r;
        }
        
        /// <summary>
        /// Appends a new notification to the result
        /// </summary>
        /// <param name="r">The result to add a notification to</param>
        /// <param name="displayMessage">The end user visible display message</param>
        /// <param name="type">The notification type</param>
        /// <param name="developerMessage">The development message</param>
        /// <param name="code">A specific unique code that identifies the type of the result</param>
        /// <returns>The self result to build upon</returns>
        public static Result AddNotification(this Result r, string displayMessage,
            string type = NotificationType.Success,
            string developerMessage = null, string code = null)
        {
            r.Notifications.Add(new Notification
                {DisplayMessage = displayMessage, DeveloperMessage = developerMessage, Type = type, Code = code});
            return r;
        }

        /// <summary>
        /// Appends a new notification to the result
        /// </summary>
        /// <param name="r">The result to add a notification to</param>
        /// <param name="displayMessage">The end user visible display message</param>
        /// <param name="type">The notification type</param>
        /// <param name="developerMessage">The development message</param>
        /// <param name="code">A specific unique code that identifies the type of the result</param>
        /// <returns>The self result to build upon</returns>
        public static Result<T> AddNotification<T>(this Result<T> r, string displayMessage,
            string type = NotificationType.Success, string developerMessage = null, string code = null)
        {
            r.Notifications.Add(new Notification
                {DisplayMessage = displayMessage, DeveloperMessage = developerMessage, Type = type, Code = code});
            return r;
        }
    }
}