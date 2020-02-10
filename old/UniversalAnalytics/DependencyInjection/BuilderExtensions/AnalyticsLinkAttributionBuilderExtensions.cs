﻿﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalAnalytics.Core.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AnalyticsLinkAttributionBuilderExtensions
    {
        public static IAnalyticsBuilder AddLinkAttribution(this IAnalyticsBuilder builder)
        {
            return builder;
        }
    }
}