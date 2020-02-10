using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Wangkanai.Universal.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Pipeline extension methods for adding Google Universal Analytics
    /// </summary>
    public static class UniversalApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds Google Universal Analytics to <see cref="IApplicationBuilder" /> request execution pipeline.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <returns>Return the <see cref="IApplicationBuilder" /> for further pipeline</returns>
        public static IApplicationBuilder UseGoogleAnalytics(this IApplicationBuilder app)
        {
            if (app is null) 
                throw new ArgumentNullException(nameof(app));

            app.Validate();
            
            VerifyMarkerIsRegistered(app);
            
            return app;
        }

        private static void Validate(this IApplicationBuilder app)
        {
            var loggerFactory = app.ApplicationServices.GetService(typeof(ILoggerFactory)) as ILoggerFactory;
            if (loggerFactory is null)
                throw new ArgumentNullException(nameof(loggerFactory));
        }

        private static void VerifyMarkerIsRegistered(IApplicationBuilder app)
        {
            if(app.ApplicationServices.GetService(typeof(UniversalMarkerService)) == null)
                throw new InvalidOperationException("AddGoogleAnalytics() is not added to ConfigureServices(...)");
        }
    }
}