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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace XRoad.Sdk.Model;

/// <summary>
/// OCSP responder diagnostics
/// </summary>
[DataContract(Name = "OcspResponder")]
public class OcspResponder : IEquatable<OcspResponder>, IValidatableObject
{
    /// <summary>
    /// Gets or Sets StatusClass
    /// </summary>
    [DataMember(Name = "status_class", IsRequired = true, EmitDefaultValue = false)]
    public DiagnosticStatusClass StatusClass { get; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [DataMember(Name = "status_code", IsRequired = true, EmitDefaultValue = false)]
    public OcspStatus StatusCode { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OcspResponder" /> class.
    /// </summary>
    [JsonConstructor]
    protected OcspResponder()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OcspResponder" /> class.
    /// </summary>
    /// <param name="statusClass">statusClass (required).</param>
    /// <param name="statusCode">statusCode (required).</param>
    public OcspResponder(DiagnosticStatusClass statusClass = default, OcspStatus statusCode = default)
    {
        StatusClass = statusClass;
        StatusCode = statusCode;
    }

    /// <summary>
    /// url of the OCSP responder
    /// </summary>
    /// <value>url of the OCSP responder</value>
    [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
    public string Url { get; }

    /// <summary>
    /// Returns false as Url should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeUrl()
    {
        return false;
    }

    /// <summary>
    /// last time updated
    /// </summary>
    /// <value>last time updated</value>
    [DataMember(Name = "prev_update_at", EmitDefaultValue = false)]
    public DateTime PrevUpdateAt { get; }

    /// <summary>
    /// Returns false as PrevUpdateAt should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializePrevUpdateAt()
    {
        return false;
    }

    /// <summary>
    /// next time updated
    /// </summary>
    /// <value>next time updated</value>
    [DataMember(Name = "next_update_at", IsRequired = true, EmitDefaultValue = false)]
    public DateTime NextUpdateAt { get; }

    /// <summary>
    /// Returns false as NextUpdateAt should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeNextUpdateAt()
    {
        return false;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OcspResponder {\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  StatusClass: ").Append(StatusClass).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  PrevUpdateAt: ").Append(PrevUpdateAt).Append("\n");
        sb.Append("  NextUpdateAt: ").Append(NextUpdateAt).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return Equals(input as OcspResponder);
    }

    /// <summary>
    /// Returns true if OcspResponder instances are equal
    /// </summary>
    /// <param name="input">Instance of OcspResponder to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OcspResponder input)
    {
        if (input == null) return false;
        return
            (
                Url == input.Url ||
                (Url != null &&
                 Url.Equals(input.Url))
            ) &&
            (
                StatusClass == input.StatusClass ||
                StatusClass.Equals(input.StatusClass)
            ) &&
            (
                StatusCode == input.StatusCode ||
                StatusCode.Equals(input.StatusCode)
            ) &&
            (
                PrevUpdateAt == input.PrevUpdateAt ||
                PrevUpdateAt.Equals(input.PrevUpdateAt)
            ) &&
            (
                NextUpdateAt == input.NextUpdateAt ||
                NextUpdateAt.Equals(input.NextUpdateAt)
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
            var hashCode = 41;
            if (Url != null) hashCode = hashCode * 59 + Url.GetHashCode();
            hashCode = hashCode * 59 + StatusClass.GetHashCode();
            hashCode = hashCode * 59 + StatusCode.GetHashCode();
            hashCode = hashCode * 59 + PrevUpdateAt.GetHashCode();
            hashCode = hashCode * 59 + NextUpdateAt.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Url (string) maxLength
        if (Url is {Length: > 255})
            yield return new ValidationResult("Invalid value for Url, length must be less than 255.", new[] {"Url"});

        // Url (string) minLength
        if (Url is {Length: < 1})
            yield return new ValidationResult("Invalid value for Url, length must be greater than 1.", new[] {"Url"});
        // TODO
        // // PrevUpdateAt (DateTime) maxLength
        // if (PrevUpdateAt != null && PrevUpdateAt.Length > 24)
        // {
        //     yield return new ValidationResult("Invalid value for PrevUpdateAt, length must be less than 24.", new [] { "PrevUpdateAt" });
        // }
        //
        // // PrevUpdateAt (DateTime) minLength
        // if (PrevUpdateAt != null && PrevUpdateAt.Length < 24)
        // {
        //     yield return new ValidationResult("Invalid value for PrevUpdateAt, length must be greater than 24.", new [] { "PrevUpdateAt" });
        // }
        //
        // // NextUpdateAt (DateTime) maxLength
        // if (NextUpdateAt != null && NextUpdateAt.Length > 24)
        // {
        //     yield return new ValidationResult("Invalid value for NextUpdateAt, length must be less than 24.", new [] { "NextUpdateAt" });
        // }
        //
        // // NextUpdateAt (DateTime) minLength
        // if (NextUpdateAt != null && NextUpdateAt.Length < 24)
        // {
        //     yield return new ValidationResult("Invalid value for NextUpdateAt, length must be greater than 24.", new [] { "NextUpdateAt" });
        // }
    }
}