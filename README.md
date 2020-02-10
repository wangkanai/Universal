## Google Universal Analytics

This old project my was developed back long time ago in the days of ASP.NET Full Framework around 2013. If you like me to upgrade this project using the design pattern my [Detection library](https://github.com/wangkanai/Detection). 

**Please give me appreciation and click stars, when this project reach 100 stars. I will rebuild project for ASP.NET Core 3.0**.
But you wanna contract me to get start development of the a migration to ASP.NET Core for your production requirement and long term support. Please contact me personally and we can discuss the details.  

[![Build status](https://ci.appveyor.com/api/projects/status/k7vt83ntq336pvid?svg=true)](https://ci.appveyor.com/project/wangkanai/universal)
[![GitHub](https://img.shields.io/github/license/wangkanai/universal)](https://github.com/wangkanai/universal/blob/master/LICENSE)
[![Open Collective](https://img.shields.io/badge/open%20collective-support%20me-3385FF.svg)](https://opencollective.com/wangkanai)
[![Patreon](https://img.shields.io/badge/patreon-support%20me-d9643a.svg)](https://www.patreon.com/wangkanai)

[![NuGet Badge](https://buildstats.info/nuget/wangkanai.universal)](https://www.nuget.org/packages/wangkanai.universal)
[![NuGet Badge](https://buildstats.info/nuget/wangkanai.universal?includePreReleases=true)](https://www.nuget.org/packages/wangkanai.universal)
[![MyGet Badge](https://buildstats.info/myget/wangkanai/wangkanai.universal)](https://www.myget.org/feed/wangkanai/package/nuget/wangkanai.universal)

[![Build history](https://buildstats.info/appveyor/chart/wangkanai/universal)](https://ci.appveyor.com/project/wangkanai/universal/history)

### What is Google Universal Analytics?

Wangkanai Analytics is a [.NET Framework](https://docs.microsoft.com/en-gb/aspnet/overview) lightweight server-side code that generator library that JavaScript client-side on the fly for [Google Analytics **analytics.js**](https://developers.google.com/analytics/devguides/collection/analyticsjs/). The goal of the framework is to stay out of the way as much as possible and provide a super interaction with Google all from C#.

#### How do i use it?

Add the NuGet package to your project.

```console
Install-Package Wangkanai.Universal
```

Add the service to your web app.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add application services.
    services.AddGoogleAnalytics("UA-XXXXXX-Y");

    // Add framework services.
    services.AddMvc();    
}
```

#### Official Plugins extensions
- [Display Features](https://developers.google.com/analytics/devguides/collection/analyticsjs/display-features)
- [Enhanced link attribution](https://developers.google.com/analytics/devguides/collection/analyticsjs/enhanced-link-attribution)
- [Linker](https://developers.google.com/analytics/devguides/collection/analyticsjs/linker)

#### Where it originated from?
This original library that was introduced in [CodePlex](https://archive.codeplex.com/?p=universalanalytics). The library was for .NET Framework web application to render **analytics.js** javascript client-side to interact with Google API from .NET language web application within the server-side code environment. Both ASP.NET WebForm and ASP.NET MVC. Its was good, but we would like to see a much more extensible and ambust platform, so we are rewriting the entire framework.

#### How do i contribute?
Universal Analytics is a powerful and continuous improving platform. We would like to invite developers to help maintain and add features so that this library is keep aligned with most of the popular web analytics out there. 

