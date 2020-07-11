namespace Resulti.Core.Notifications
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
        /// A type designation of the notification
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A user friendly message to display
        /// </summary>
        public string DisplayMessage { get; set; }

        /// <summary>
        /// A developer friendly message for debugging
        /// </summary>
        public string DeveloperMessage { get; set; }
    }
}