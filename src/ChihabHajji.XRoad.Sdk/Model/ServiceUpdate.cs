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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChihabHajji.XRoad.Sdk.Client.OpenAPIDateConverter;

namespace ChihabHajji.XRoad.Sdk.Model
{
    /// <summary>
    /// object for updating a service or all services within service description
    /// </summary>
    [DataContract(Name = "ServiceUpdate")]
    public partial class ServiceUpdate : IEquatable<ServiceUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUpdate" /> class.
        /// </summary>
        /// <param name="url">service url (required).</param>
        /// <param name="timeout">service time out value (required).</param>
        /// <param name="sslAuth">service ssl auth (required).</param>
        /// <param name="urlAll">url is applied for all services (default to false).</param>
        /// <param name="timeoutAll">timeout value is applied for all services (default to false).</param>
        /// <param name="sslAuthAll">ssl authentication is applied for all services (default to false).</param>
        /// <param name="ignoreWarnings">if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail (default to false).</param>
        public ServiceUpdate(string url = default(string), int timeout = default(int), bool sslAuth = default(bool), bool urlAll = false, bool timeoutAll = false, bool sslAuthAll = false, bool ignoreWarnings = false)
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for ServiceUpdate and cannot be null");
            }
            this.Url = url;
            this.Timeout = timeout;
            this.SslAuth = sslAuth;
            this.UrlAll = urlAll;
            this.TimeoutAll = timeoutAll;
            this.SslAuthAll = sslAuthAll;
            this.IgnoreWarnings = ignoreWarnings;
        }

        /// <summary>
        /// service url
        /// </summary>
        /// <value>service url</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// service time out value
        /// </summary>
        /// <value>service time out value</value>
        [DataMember(Name = "timeout", IsRequired = true, EmitDefaultValue = false)]
        public int Timeout { get; set; }

        /// <summary>
        /// service ssl auth
        /// </summary>
        /// <value>service ssl auth</value>
        [DataMember(Name = "ssl_auth", IsRequired = true, EmitDefaultValue = true)]
        public bool SslAuth { get; set; }

        /// <summary>
        /// url is applied for all services
        /// </summary>
        /// <value>url is applied for all services</value>
        [DataMember(Name = "url_all", EmitDefaultValue = true)]
        public bool UrlAll { get; set; }

        /// <summary>
        /// timeout value is applied for all services
        /// </summary>
        /// <value>timeout value is applied for all services</value>
        [DataMember(Name = "timeout_all", EmitDefaultValue = true)]
        public bool TimeoutAll { get; set; }

        /// <summary>
        /// ssl authentication is applied for all services
        /// </summary>
        /// <value>ssl authentication is applied for all services</value>
        [DataMember(Name = "ssl_auth_all", EmitDefaultValue = true)]
        public bool SslAuthAll { get; set; }

        /// <summary>
        /// if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail
        /// </summary>
        /// <value>if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail</value>
        [DataMember(Name = "ignore_warnings", EmitDefaultValue = true)]
        public bool IgnoreWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceUpdate {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  SslAuth: ").Append(SslAuth).Append("\n");
            sb.Append("  UrlAll: ").Append(UrlAll).Append("\n");
            sb.Append("  TimeoutAll: ").Append(TimeoutAll).Append("\n");
            sb.Append("  SslAuthAll: ").Append(SslAuthAll).Append("\n");
            sb.Append("  IgnoreWarnings: ").Append(IgnoreWarnings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceUpdate);
        }

        /// <summary>
        /// Returns true if ServiceUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.SslAuth == input.SslAuth ||
                    this.SslAuth.Equals(input.SslAuth)
                ) && 
                (
                    this.UrlAll == input.UrlAll ||
                    this.UrlAll.Equals(input.UrlAll)
                ) && 
                (
                    this.TimeoutAll == input.TimeoutAll ||
                    this.TimeoutAll.Equals(input.TimeoutAll)
                ) && 
                (
                    this.SslAuthAll == input.SslAuthAll ||
                    this.SslAuthAll.Equals(input.SslAuthAll)
                ) && 
                (
                    this.IgnoreWarnings == input.IgnoreWarnings ||
                    this.IgnoreWarnings.Equals(input.IgnoreWarnings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                hashCode = (hashCode * 59) + this.SslAuth.GetHashCode();
                hashCode = (hashCode * 59) + this.UrlAll.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeoutAll.GetHashCode();
                hashCode = (hashCode * 59) + this.SslAuthAll.GetHashCode();
                hashCode = (hashCode * 59) + this.IgnoreWarnings.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 255.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            // Timeout (int) maximum
            if (this.Timeout > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value less than or equal to 1000.", new [] { "Timeout" });
            }

            // Timeout (int) minimum
            if (this.Timeout < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 0.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}