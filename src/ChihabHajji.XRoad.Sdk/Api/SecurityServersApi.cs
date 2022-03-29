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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace ChihabHajji.XRoad.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityServersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get security server information
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <returns>SecurityServer</returns>
        SecurityServer GetSecurityServer(string id);

        /// <summary>
        /// get security server information
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <returns>ApiResponse of SecurityServer</returns>
        ApiResponse<SecurityServer> GetSecurityServerWithHttpInfo(string id);
        /// <summary>
        /// get all security servers
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <returns>List&lt;SecurityServer&gt;</returns>
        List<SecurityServer> GetSecurityServers(bool? currentServer = default(bool?));

        /// <summary>
        /// get all security servers
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityServer&gt;</returns>
        ApiResponse<List<SecurityServer>> GetSecurityServersWithHttpInfo(bool? currentServer = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityServersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get security server information
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SecurityServer</returns>
        System.Threading.Tasks.Task<SecurityServer> GetSecurityServerAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get security server information
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SecurityServer)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecurityServer>> GetSecurityServerWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get all security servers
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SecurityServer&gt;</returns>
        System.Threading.Tasks.Task<List<SecurityServer>> GetSecurityServersAsync(bool? currentServer = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get all security servers
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityServer&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SecurityServer>>> GetSecurityServersWithHttpInfoAsync(bool? currentServer = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityServersApi : ISecurityServersApiSync, ISecurityServersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecurityServersApi : ISecurityServersApi
    {
        private ChihabHajji.XRoad.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityServersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityServersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityServersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityServersApi(string basePath)
        {
            this.Configuration = ChihabHajji.XRoad.Sdk.Client.Configuration.MergeConfigurations(
                ChihabHajji.XRoad.Sdk.Client.GlobalConfiguration.Instance,
                new ChihabHajji.XRoad.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityServersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecurityServersApi(ChihabHajji.XRoad.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ChihabHajji.XRoad.Sdk.Client.Configuration.MergeConfigurations(
                ChihabHajji.XRoad.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityServersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SecurityServersApi(ChihabHajji.XRoad.Sdk.Client.ISynchronousClient client, ChihabHajji.XRoad.Sdk.Client.IAsynchronousClient asyncClient, ChihabHajji.XRoad.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChihabHajji.XRoad.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// get security server information &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <returns>SecurityServer</returns>
        public SecurityServer GetSecurityServer(string id)
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<SecurityServer> localVarResponse = GetSecurityServerWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get security server information &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <returns>ApiResponse of SecurityServer</returns>
        public ChihabHajji.XRoad.Sdk.Client.ApiResponse<SecurityServer> GetSecurityServerWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling SecurityServersApi->GetSecurityServer");
            }

            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SecurityServer>("/security-servers/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSecurityServer", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get security server information &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SecurityServer</returns>
        public async System.Threading.Tasks.Task<SecurityServer> GetSecurityServerAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<SecurityServer> localVarResponse = await GetSecurityServerWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get security server information &lt;h3&gt;Administrator views the details of a security server.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the security server</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SecurityServer)</returns>
        public async System.Threading.Tasks.Task<ChihabHajji.XRoad.Sdk.Client.ApiResponse<SecurityServer>> GetSecurityServerWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling SecurityServersApi->GetSecurityServer");
            }


            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SecurityServer>("/security-servers/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSecurityServer", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get all security servers &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <returns>List&lt;SecurityServer&gt;</returns>
        public List<SecurityServer> GetSecurityServers(bool? currentServer = default(bool?))
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<List<SecurityServer>> localVarResponse = GetSecurityServersWithHttpInfo(currentServer);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get all security servers &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityServer&gt;</returns>
        public ChihabHajji.XRoad.Sdk.Client.ApiResponse<List<SecurityServer>> GetSecurityServersWithHttpInfo(bool? currentServer = default(bool?))
        {
            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (currentServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "current_server", currentServer));
            }

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<SecurityServer>>("/security-servers", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSecurityServers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get all security servers &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;SecurityServer&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityServer>> GetSecurityServersAsync(bool? currentServer = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<List<SecurityServer>> localVarResponse = await GetSecurityServersWithHttpInfoAsync(currentServer, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get all security servers &lt;h3&gt;Administrator views the details of all security servers.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentServer">whether to only get the current server&#39;s identifier (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityServer&gt;)</returns>
        public async System.Threading.Tasks.Task<ChihabHajji.XRoad.Sdk.Client.ApiResponse<List<SecurityServer>>> GetSecurityServersWithHttpInfoAsync(bool? currentServer = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (currentServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "current_server", currentServer));
            }

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<SecurityServer>>("/security-servers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSecurityServers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}