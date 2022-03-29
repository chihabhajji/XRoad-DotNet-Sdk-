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
    /// security server initial configuration
    /// </summary>
    [DataContract(Name = "InitialServerConf")]
    public partial class InitialServerConf : IEquatable<InitialServerConf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialServerConf" /> class.
        /// </summary>
        /// <param name="ownerMemberClass">member class.</param>
        /// <param name="ownerMemberCode">member code.</param>
        /// <param name="securityServerCode">security server code.</param>
        /// <param name="softwareTokenPin">pin code for the initial software token.</param>
        /// <param name="ignoreWarnings">if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail (default to false).</param>
        public InitialServerConf(string ownerMemberClass = default(string), string ownerMemberCode = default(string), string securityServerCode = default(string), string softwareTokenPin = default(string), bool ignoreWarnings = false)
        {
            this.OwnerMemberClass = ownerMemberClass;
            this.OwnerMemberCode = ownerMemberCode;
            this.SecurityServerCode = securityServerCode;
            this.SoftwareTokenPin = softwareTokenPin;
            this.IgnoreWarnings = ignoreWarnings;
        }

        /// <summary>
        /// member class
        /// </summary>
        /// <value>member class</value>
        [DataMember(Name = "owner_member_class", EmitDefaultValue = false)]
        public string OwnerMemberClass { get; set; }

        /// <summary>
        /// member code
        /// </summary>
        /// <value>member code</value>
        [DataMember(Name = "owner_member_code", EmitDefaultValue = false)]
        public string OwnerMemberCode { get; set; }

        /// <summary>
        /// security server code
        /// </summary>
        /// <value>security server code</value>
        [DataMember(Name = "security_server_code", EmitDefaultValue = false)]
        public string SecurityServerCode { get; set; }

        /// <summary>
        /// pin code for the initial software token
        /// </summary>
        /// <value>pin code for the initial software token</value>
        [DataMember(Name = "software_token_pin", EmitDefaultValue = false)]
        public string SoftwareTokenPin { get; set; }

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
            sb.Append("class InitialServerConf {\n");
            sb.Append("  OwnerMemberClass: ").Append(OwnerMemberClass).Append("\n");
            sb.Append("  OwnerMemberCode: ").Append(OwnerMemberCode).Append("\n");
            sb.Append("  SecurityServerCode: ").Append(SecurityServerCode).Append("\n");
            sb.Append("  SoftwareTokenPin: ").Append(SoftwareTokenPin).Append("\n");
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
            return this.Equals(input as InitialServerConf);
        }

        /// <summary>
        /// Returns true if InitialServerConf instances are equal
        /// </summary>
        /// <param name="input">Instance of InitialServerConf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialServerConf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OwnerMemberClass == input.OwnerMemberClass ||
                    (this.OwnerMemberClass != null &&
                    this.OwnerMemberClass.Equals(input.OwnerMemberClass))
                ) && 
                (
                    this.OwnerMemberCode == input.OwnerMemberCode ||
                    (this.OwnerMemberCode != null &&
                    this.OwnerMemberCode.Equals(input.OwnerMemberCode))
                ) && 
                (
                    this.SecurityServerCode == input.SecurityServerCode ||
                    (this.SecurityServerCode != null &&
                    this.SecurityServerCode.Equals(input.SecurityServerCode))
                ) && 
                (
                    this.SoftwareTokenPin == input.SoftwareTokenPin ||
                    (this.SoftwareTokenPin != null &&
                    this.SoftwareTokenPin.Equals(input.SoftwareTokenPin))
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
                if (this.OwnerMemberClass != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerMemberClass.GetHashCode();
                }
                if (this.OwnerMemberCode != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerMemberCode.GetHashCode();
                }
                if (this.SecurityServerCode != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityServerCode.GetHashCode();
                }
                if (this.SoftwareTokenPin != null)
                {
                    hashCode = (hashCode * 59) + this.SoftwareTokenPin.GetHashCode();
                }
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
            // OwnerMemberClass (string) maxLength
            if (this.OwnerMemberClass != null && this.OwnerMemberClass.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OwnerMemberClass, length must be less than 255.", new [] { "OwnerMemberClass" });
            }

            // OwnerMemberClass (string) minLength
            if (this.OwnerMemberClass != null && this.OwnerMemberClass.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OwnerMemberClass, length must be greater than 1.", new [] { "OwnerMemberClass" });
            }

            // OwnerMemberCode (string) maxLength
            if (this.OwnerMemberCode != null && this.OwnerMemberCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OwnerMemberCode, length must be less than 255.", new [] { "OwnerMemberCode" });
            }

            // OwnerMemberCode (string) minLength
            if (this.OwnerMemberCode != null && this.OwnerMemberCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OwnerMemberCode, length must be greater than 1.", new [] { "OwnerMemberCode" });
            }

            // SecurityServerCode (string) maxLength
            if (this.SecurityServerCode != null && this.SecurityServerCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityServerCode, length must be less than 255.", new [] { "SecurityServerCode" });
            }

            // SecurityServerCode (string) minLength
            if (this.SecurityServerCode != null && this.SecurityServerCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityServerCode, length must be greater than 1.", new [] { "SecurityServerCode" });
            }

            // SoftwareTokenPin (string) maxLength
            if (this.SoftwareTokenPin != null && this.SoftwareTokenPin.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SoftwareTokenPin, length must be less than 255.", new [] { "SoftwareTokenPin" });
            }

            // SoftwareTokenPin (string) minLength
            if (this.SoftwareTokenPin != null && this.SoftwareTokenPin.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SoftwareTokenPin, length must be greater than 1.", new [] { "SoftwareTokenPin" });
            }

            yield break;
        }
    }

}