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
    /// &lt;p&gt;The enum can have three different values&lt;/p&gt; &lt;ul&gt; &lt;li&gt;PRIMARY, which is the primary node in a high availability setup&lt;/li&gt; &lt;li&gt;SECONDARY, which is a secondary node in a high availability setup – a read-only server&lt;/li&gt; &lt;li&gt;STANDALONE,when there are no load balancer or high availability configured&lt;/li&gt; &lt;/ul&gt;
    /// </summary>
    /// <value>&lt;p&gt;The enum can have three different values&lt;/p&gt; &lt;ul&gt; &lt;li&gt;PRIMARY, which is the primary node in a high availability setup&lt;/li&gt; &lt;li&gt;SECONDARY, which is a secondary node in a high availability setup – a read-only server&lt;/li&gt; &lt;li&gt;STANDALONE,when there are no load balancer or high availability configured&lt;/li&gt; &lt;/ul&gt;</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NodeType
    {
        /// <summary>
        /// Enum PRIMARY for value: PRIMARY
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        PRIMARY = 1,

        /// <summary>
        /// Enum SECONDARY for value: SECONDARY
        /// </summary>
        [EnumMember(Value = "SECONDARY")]
        SECONDARY = 2,

        /// <summary>
        /// Enum STANDALONE for value: STANDALONE
        /// </summary>
        [EnumMember(Value = "STANDALONE")]
        STANDALONE = 3

    }

}