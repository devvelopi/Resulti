namespace Resulti.Core.Results
{
    /// <summary>
    /// A web specific result used for pagination and other useful REST attributes
    /// </summary>
    /// <inheritdoc />
    public class HttpResult : Result
    {
        /// <inheritdoc />
        public HttpResult()
        {
        }

        /// <inheritdoc />
        public HttpResult(Result result) : base(result)
        {
        }

        /// <inheritdoc />
        public HttpResult(HttpResult result) : base(result)
        {
            HttpCode = result.HttpCode;
            InformationUri = result.InformationUri;
            Count = result.Count;
            TotalCount = result.Count;
            Page = result.Page;
            PageSize = result.PageSize;
            PreviousPage = result.PreviousPage;
            NextPage = result.NextPage;
        }

        /// <summary>
        /// Status code of the web result
        /// </summary>
        public int HttpCode { get; set; }
        
        /// <summary>
        /// Additional information metadata to describe the contents of the result
        /// </summary>
        public string InformationUri { get; set; }
        
        /// <summary>
        /// Count of elements returned with the result
        /// </summary>
        public long? Count { get; set; }
        
        /// <summary>
        /// Total amount of elements possible to paginate through
        /// </summary>
        public long? TotalCount { get; set; }
        
        /// <summary>
        /// Current retrieved page of paginated data
        /// </summary>
        public long? Page { get; set; }
        
        /// <summary>
        /// Size of the page of data retrieved
        /// </summary>
        public long? PageSize { get; set; }

        /// <summary>
        /// Query string / endpoint to move to the previous page of results
        /// </summary>
        public string PreviousPage { get; set; }
        
        /// <summary>
        /// Query string /endpoint to move to the next page of results
        /// </summary>
        public string NextPage { get; set; }
    }

    /// <summary>
    /// A web specific result used for pagination and other useful REST attributes with a data bag
    /// <typeparam name="T">The databag type</typeparam>
    /// </summary>
    /// <inheritdoc />
    public class HttpResult<T> : HttpResult
    {
        /// <inheritdoc />
        public HttpResult(Result result) : base(result)
        {
        }

        /// <inheritdoc />
        public HttpResult(HttpResult result) : base(result)
        {
        }

        /// <inheritdoc />
        public HttpResult(Result<T> result) : base(result)
        {
            Data = result.Data;
        }

        /// <inheritdoc />
        public HttpResult(HttpResult<T> result) : base(result)
        {
            Data = result.Data;
        }
        
        /// <inheritdoc />
        public HttpResult(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Databag used to contain result data
        /// </summary>
        public T Data { get; set; }
    }
}