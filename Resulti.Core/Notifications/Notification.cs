namespace Resulti.Core
{
    /// <summary>
    /// Used to contain short codes, display and developer messages
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// A short unique code designating an error or result
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// A user friendly message to display
        /// </summary>
        public string DisplayMessage { get; set; }

        /// <summary>
        /// A developer friendly message for debugging
        /// </summary>
        public string DeveloperMessage { get; set; }

        /// <summary>
        /// Stack trace for detailed debugging
        /// </summary>
        public string Trace { get; set; }
    }
}