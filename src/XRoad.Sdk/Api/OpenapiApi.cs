/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using XRoad.Sdk.Client;

namespace XRoad.Sdk.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOpenapiApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// download security server&#39;s openapi definition
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>System.IO.Stream</returns>
    Stream DownloadOpenApi();

    /// <summary>
    /// download security server&#39;s openapi definition
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of System.IO.Stream</returns>
    ApiResponse<Stream> DownloadOpenApiWithHttpInfo();

    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOpenapiApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    /// download security server&#39;s openapi definition
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of System.IO.Stream</returns>
    Task<Stream> DownloadOpenApiAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// download security server&#39;s openapi definition
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    Task<ApiResponse<Stream>> DownloadOpenApiWithHttpInfoAsync(CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOpenapiApi : IOpenapiApiSync, IOpenapiApiAsync
{
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class OpenapiApi : IOpenapiApi
{
    private ExceptionFactory _exceptionFactory = (_, _) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenapiApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OpenapiApi() : this((string) null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenapiApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OpenapiApi(string basePath)
    {
        Configuration = Sdk.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            new Configuration {BasePath = basePath}
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenapiApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public OpenapiApi(Configuration configuration)
    {
        if (configuration == null) throw new ArgumentNullException(nameof(configuration));

        Configuration = Sdk.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            configuration
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenapiApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public OpenapiApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
    {
        Client = client ?? throw new ArgumentNullException(nameof(client));
        AsynchronousClient = asyncClient ?? throw new ArgumentNullException(nameof(asyncClient));
        Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// The client for accessing this underlying API asynchronously.
    /// </summary>
    public IAsynchronousClient AsynchronousClient { get; set; }

    /// <summary>
    /// The client for accessing this underlying API synchronously.
    /// </summary>
    public ISynchronousClient Client { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.BasePath;
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public IReadableConfiguration Configuration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            return _exceptionFactory;
        }
        set => _exceptionFactory = value;
    }

    /// <summary>
    /// download security server&#39;s openapi definition &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>System.IO.Stream</returns>
    public Stream DownloadOpenApi()
    {
        var localVarResponse = DownloadOpenApiWithHttpInfo();
        return localVarResponse.Data;
    }

    /// <summary>
    /// download security server&#39;s openapi definition &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of System.IO.Stream</returns>
    public ApiResponse<Stream> DownloadOpenApiWithHttpInfo()
    {
        var localVarRequestOptions = new RequestOptions();
        var localVarContentType = ClientUtils.SelectHeaderContentType(Array.Empty<string>());
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
        var localVarAccept = ClientUtils.SelectHeaderAccept(new []{"application/json"});
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));
        // make the HTTP request
        var localVarResponse = Client.Get<Stream>("/openapi.yaml", localVarRequestOptions, Configuration);
        if (ExceptionFactory?.Invoke("DownloadOpenApi", localVarResponse) is { } exception) throw exception;
        return localVarResponse;
    }

    /// <summary>
    /// download security server&#39;s openapi definition &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of System.IO.Stream</returns>
    public async Task<Stream> DownloadOpenApiAsync(CancellationToken cancellationToken = default)
    {
        var localVarResponse = await DownloadOpenApiWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// download security server&#39;s openapi definition &lt;h3&gt;Administrator downloads the security server&#39;s OpenAPI definition.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
    public async Task<ApiResponse<Stream>> DownloadOpenApiWithHttpInfoAsync(
        CancellationToken cancellationToken = default)
    {
        var localVarRequestOptions = new RequestOptions();
        var localVarContentType = ClientUtils.SelectHeaderContentType(Array.Empty<string>());
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
        var localVarAccept = ClientUtils.SelectHeaderAccept(new []{"application/json"});
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));
        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<Stream>("/openapi.yaml", localVarRequestOptions, Configuration, cancellationToken)
            .ConfigureAwait(false);
        if (ExceptionFactory?.Invoke("DownloadOpenApi", localVarResponse) is { } exception) throw exception;
        return localVarResponse;
    }
}