// Copyright 2016, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="SpeechClient"/>.
    /// </summary>
    public sealed partial class SpeechSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SpeechSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SpeechSettings"/>.
        /// </returns>
        public static SpeechSettings GetDefault() => new SpeechSettings();

        /// <summary>
        /// Constructs a new <see cref="SpeechSettings"/> object with default settings.
        /// </summary>
        public SpeechSettings() { }

        private SpeechSettings(SpeechSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SyncRecognizeSettings = existing.SyncRecognizeSettings;
            AsyncRecognizeSettings = existing.AsyncRecognizeSettings;
            StreamingRecognizeSettings = existing.StreamingRecognizeSettings;
            StreamingRecognizeStreamingSettings = existing.StreamingRecognizeStreamingSettings;
            LongRunningOperationsSettings = existing.LongRunningOperationsSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SpeechClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.SyncRecognize</c> and <c>SpeechClient.SyncRecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpeechClient.SyncRecognize</c> and
        /// <c>SpeechClient.SyncRecognizeAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SyncRecognizeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.AsyncRecognize</c> and <c>SpeechClient.AsyncRecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpeechClient.AsyncRecognize</c> and
        /// <c>SpeechClient.AsyncRecognizeAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AsyncRecognizeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>SpeechClient.StreamingRecognize</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings StreamingRecognizeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="BidirectionalStreamingSettings"/> for calls to
        /// <c>SpeechClient.StreamingRecognize</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public BidirectionalStreamingSettings StreamingRecognizeStreamingSettings { get; set; } =
            new BidirectionalStreamingSettings(100);

        /// <summary>
        /// Settings used for long running operations.
        /// </summary>
        public OperationsSettings LongRunningOperationsSettings { get; set; }

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SpeechSettings"/> object.</returns>
        public SpeechSettings Clone() => new SpeechSettings(this);
    }

    /// <summary>
    /// Speech client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SpeechClient
    {
        /// <summary>
        /// The default endpoint for the Speech service, which is a host of "speech.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("speech.googleapis.com", 443);

        /// <summary>
        /// The default Speech scopes.
        /// </summary>
        /// <remarks>
        /// The default Speech scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SpeechClient"/>.</returns>
        public static async Task<SpeechClient> CreateAsync(ServiceEndpoint endpoint = null, SpeechSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(ServiceEndpoint endpoint = null, SpeechSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SpeechClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(Channel channel, SpeechSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Speech.SpeechClient grpcClient = new Speech.SpeechClient(channel);
            return new SpeechClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, SpeechSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SpeechSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, SpeechSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SpeechSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Speech client.
        /// </summary>
        public virtual Speech.SpeechClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// The client for long-running operations.
        /// </summary>
        public virtual OperationsClient LongRunningOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<SyncRecognizeResponse> SyncRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            CallSettings callSettings = null) => SyncRecognizeAsync(
                new SyncRecognizeRequest
                {
                    Config = config,
                    Audio = audio,
                },
                callSettings);

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<SyncRecognizeResponse> SyncRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            CancellationToken cancellationToken) => SyncRecognizeAsync(
                config,
                audio,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SyncRecognizeResponse SyncRecognize(
            RecognitionConfig config,
            RecognitionAudio audio,
            CallSettings callSettings = null) => SyncRecognize(
                new SyncRecognizeRequest
                {
                    Config = config,
                    Audio = audio,
                },
                callSettings);

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<SyncRecognizeResponse> SyncRecognizeAsync(
            SyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SyncRecognizeResponse SyncRecognize(
            SyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<AsyncRecognizeResponse>> AsyncRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            CallSettings callSettings = null) => AsyncRecognizeAsync(
                new AsyncRecognizeRequest
                {
                    Config = config,
                    Audio = audio,
                },
                callSettings);

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<AsyncRecognizeResponse>> AsyncRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            CancellationToken cancellationToken) => AsyncRecognizeAsync(
                new AsyncRecognizeRequest
                {
                    Config = config,
                    Audio = audio,
                },
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// [Required] The `config` message provides information to the recognizer
        /// that specifies how to process the request.
        /// </param>
        /// <param name="audio">
        /// [Required] The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<AsyncRecognizeResponse> AsyncRecognize(
            RecognitionConfig config,
            RecognitionAudio audio,
            CallSettings callSettings = null) => AsyncRecognize(
                new AsyncRecognizeRequest
                {
                    Config = config,
                    Audio = audio,
                },
                callSettings);

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<AsyncRecognizeResponse>> AsyncRecognizeAsync(
            AsyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AsyncRecognizeAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<AsyncRecognizeResponse>> PollOnceAsyncRecognizeAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<AsyncRecognizeResponse>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                LongRunningOperationsClient,
                callSettings);

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<AsyncRecognizeResponse> AsyncRecognize(
            AsyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AsyncRecognize</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<AsyncRecognizeResponse> PollOnceAsyncRecognize(
            string operationName,
            CallSettings callSettings = null) => Operation<AsyncRecognizeResponse>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                LongRunningOperationsClient,
                callSettings);

        /// <summary>
        /// Perform bidirectional streaming speech-recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual StreamingRecognizeStream StreamingRecognize(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingRecognize</c>.
        /// </summary>
        public abstract class StreamingRecognizeStream : BidirectionalStreamingBase<StreamingRecognizeRequest, StreamingRecognizeResponse>
        {
        }

    }

    /// <summary>
    /// Speech client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SpeechClientImpl : SpeechClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<SyncRecognizeRequest, SyncRecognizeResponse> _callSyncRecognize;
        private readonly ApiCall<AsyncRecognizeRequest, Operation> _callAsyncRecognize;
        private readonly ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> _callStreamingRecognize;

        /// <summary>
        /// Constructs a client wrapper for the Speech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpeechSettings"/> used within this client </param>
        public SpeechClientImpl(Speech.SpeechClient grpcClient, SpeechSettings settings)
        {
            this.GrpcClient = grpcClient;
            SpeechSettings effectiveSettings = settings ?? SpeechSettings.GetDefault();
            LongRunningOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.LongRunningOperationsSettings);
            _clientHelper = new ClientHelper(effectiveSettings);
            _callSyncRecognize = _clientHelper.BuildApiCall<SyncRecognizeRequest, SyncRecognizeResponse>(
                GrpcClient.SyncRecognizeAsync, GrpcClient.SyncRecognize, effectiveSettings.SyncRecognizeSettings);
            _callAsyncRecognize = _clientHelper.BuildApiCall<AsyncRecognizeRequest, Operation>(
                GrpcClient.AsyncRecognizeAsync, GrpcClient.AsyncRecognize, effectiveSettings.AsyncRecognizeSettings);
            _callStreamingRecognize = _clientHelper.BuildApiCall<StreamingRecognizeRequest, StreamingRecognizeResponse>(
                GrpcClient.StreamingRecognize, effectiveSettings.StreamingRecognizeSettings, effectiveSettings.StreamingRecognizeStreamingSettings);
        }

        /// <summary>
        /// The underlying gRPC Speech client.
        /// </summary>
        public override Speech.SpeechClient GrpcClient { get; }

        /// <summary>
        /// The client for long-running operations.
        /// </summary>
        public override OperationsClient LongRunningOperationsClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_SyncRecognizeRequest(ref SyncRecognizeRequest request, ref CallSettings settings);
        partial void Modify_AsyncRecognizeRequest(ref AsyncRecognizeRequest request, ref CallSettings settings);
        partial void Modify_StreamingRecognizeRequestCallSettings(ref CallSettings settings);
        partial void Modify_StreamingRecognizeRequestRequest(ref StreamingRecognizeRequest request);

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<SyncRecognizeResponse> SyncRecognizeAsync(
            SyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_SyncRecognizeRequest(ref request, ref callSettings);
            return _callSyncRecognize.Async(request, callSettings);
        }

        /// <summary>
        /// Perform synchronous speech-recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override SyncRecognizeResponse SyncRecognize(
            SyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_SyncRecognizeRequest(ref request, ref callSettings);
            return _callSyncRecognize.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<AsyncRecognizeResponse>> AsyncRecognizeAsync(
            AsyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_AsyncRecognizeRequest(ref request, ref callSettings);
            return new Operation<AsyncRecognizeResponse>(
                await _callAsyncRecognize.Async(request, callSettings), LongRunningOperationsClient);
        }

        /// <summary>
        /// Perform asynchronous speech-recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// an `AsyncRecognizeResponse` message.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<AsyncRecognizeResponse> AsyncRecognize(
            AsyncRecognizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_AsyncRecognizeRequest(ref request, ref callSettings);
            return new Operation<AsyncRecognizeResponse>(
                _callAsyncRecognize.Sync(request, callSettings), LongRunningOperationsClient);
        }

        /// <summary>
        /// Perform bidirectional streaming speech-recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override StreamingRecognizeStream StreamingRecognize(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingRecognizeRequestCallSettings(ref callSettings);
            BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callStreamingRecognize.StreamingSettings;
            AsyncDuplexStreamingCall<StreamingRecognizeRequest,StreamingRecognizeResponse> call =
                _callStreamingRecognize.Call(callSettings);
            BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer =
                new BufferedClientStreamWriter<StreamingRecognizeRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingRecognizeStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingRecognize</c>.
        /// </summary>
        public sealed class StreamingRecognizeStreamImpl : StreamingRecognizeStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamingRecognize</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="BufferedClientStreamWriter{StreamingRecognizeRequest}"/>
            /// instance associated with this streaming call.</param>
            public StreamingRecognizeStreamImpl(
                SpeechClientImpl service,
                AsyncDuplexStreamingCall<StreamingRecognizeRequest,StreamingRecognizeResponse> call,
                BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SpeechClientImpl _service;
            private BufferedClientStreamWriter<StreamingRecognizeRequest> _writeBuffer;

            private StreamingRecognizeRequest ModifyRequest(StreamingRecognizeRequest request)
            {
                _service.Modify_StreamingRecognizeRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override AsyncDuplexStreamingCall<StreamingRecognizeRequest,StreamingRecognizeResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override Task TryWriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task WriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task TryWriteAsync(StreamingRecognizeRequest message, WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task WriteAsync(StreamingRecognizeRequest message, WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override IAsyncEnumerator<StreamingRecognizeResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

    }

    // Partial classes to enable page-streaming

}
