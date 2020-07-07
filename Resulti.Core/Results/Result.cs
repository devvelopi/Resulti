using System.Collections.Generic;
using Resulti.Core.Notifications;
using Resulti.Core.Util;

namespace Resulti.Core.Results
{
    /// <summary>
    /// A global app-wide container for effects of actions
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Default constructor creating an empty result
        /// </summary>
        public Result()
        {
            Status = ResultStatus.Failure;
        }

        /// <summary>
        /// Constructor used for cloning one result to another
        /// </summary>
        /// <param name="result">Result to clone from</param>
        public Result(Result result) : this()
        {
            Id = result.Id;
            Status = result.Status;
            Notifications = new List<Notification>(result.Notifications);
        }

        /// <summary>
        /// Generic ID used for debugging, logging and error handling
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Status of the result
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Collection of messages relating to the outcome of the result
        /// </summary>
        public List<Notification> Notifications { get; set; } = new List<Notification>();
    }

    /// <summary>
    /// A global app-wide container for effects of actions with a data bag
    /// </summary>
    /// <typeparam name="T">The databag type</typeparam>
    public class Result<T> : Result
    {
        /// <inheritdoc />
        public Result()
        {
        }

        /// <inheritdoc />
        public Result(Result result) : base(result)
        {
        }

        /// <inheritdoc />
        public Result(Result<T> result) : base(result)
        {
            Data = result.Data;
        }

        /// <summary>
        /// Constructor used for generating a result with data
        /// </summary>
        /// <param name="data"></param>
        public Result(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Databag used to contain result data
        /// </summary>
        public T Data { get; set; }
    }
}