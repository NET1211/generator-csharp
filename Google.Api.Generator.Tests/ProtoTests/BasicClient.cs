﻿using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using sys = System;

namespace Testing
{
    /// <summary>Settings for a <see cref="BasicClient"/>.</summary>
    public sealed partial class BasicSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BasicSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BasicSettings"/>.</returns>
        public static BasicSettings GetDefault() => new BasicSettings();

        /// <summary>Constructs a new <see cref="BasicSettings"/> object with default settings.</summary>
        public BasicSettings()
        {
        }

        private BasicSettings(BasicSettings existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            IdempotentMethodSettings = existing.IdempotentMethodSettings;
            NonIdempotentMethodSettings = existing.NonIdempotentMethodSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BasicSettings existing);

        private static readonly gaxgrpc::CallSettings _defaultIdempotentCallSettings = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromSeconds(60), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromSeconds(20), maxDelay: sys::TimeSpan.FromSeconds(20), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromSeconds(20)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable))));

        private static readonly gaxgrpc::CallSettings _defaultNonIdempotentCallSettings = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromSeconds(20)));

        /// <summary><see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to<c>BasicClient.IdempotentMethod</c> and <c>BasicClient.IdempotentMethodAsync</c>.</summary>
        /// <remarks>The default <c>BasicClient.IdempotentMethod</c> and <c>BasicClient.IdempotentMethodAsync</c> <see cref="gaxgrpc::RetrySettings"/>are:<list type="bullet"><item><description>Initial retry delay: 100 milliseconds.</description></item><item><description>Retry delay multiplier: 1.3</description></item><item><description>Retry maximum delay: 60 seconds.</description></item><item><description>Initial timeout: 20 seconds.</description></item><item><description>Timeout multiplier: 1</description></item><item><description>Timeout maximum delay: 20 seconds.</description></item><item><description>Total timeout: 20 seconds.</description></item></list>By default retry will be attempted on the following response status codes:<list type="bullet"><item><description><see cref="grpccore::StatusCode.Internal"/></description></item><item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item></list></remarks>
        public gaxgrpc::CallSettings IdempotentMethodSettings { get; set; } = _defaultIdempotentCallSettings;

        /// <summary><see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to<c>BasicClient.NonIdempotentMethod</c> and <c>BasicClient.NonIdempotentMethodAsync</c>.</summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings NonIdempotentMethodSettings { get; set; } = _defaultNonIdempotentCallSettings;

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BasicSettings"/> object.</returns>
        public BasicSettings Clone() => new BasicSettings(this);
    }
}
