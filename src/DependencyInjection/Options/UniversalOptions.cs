namespace Wangkanai.Universal.Configuration
{
    /// <summary>
    /// Provides programmatic configuration for the Google Universal Analytics library.
    /// </summary>
    public class UniversalOptions
    {
        /// <summary>
        /// Gets or set the default <see cref="TrackingId"/> used by this application.
        /// </summary>
        public string TrackingId { get; set; } = "UA-XXXXXX-Y";

        /// <summary>
        /// Gets or sets the default <see cref="Async"/> used by this application.
        /// </summary>
        public bool Async { get; set; } = false;
    }
}