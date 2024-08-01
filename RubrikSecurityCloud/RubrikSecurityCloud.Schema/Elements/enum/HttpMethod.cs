// HttpMethod.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum HttpMethod
    {
        [EnumMember(Value = "CONNECT")]
        CONNECT,

        [EnumMember(Value = "DELETE")]
        DELETE,

        [EnumMember(Value = "GET")]
        GET,

        [EnumMember(Value = "HEAD")]
        HEAD,

        [EnumMember(Value = "OPTIONS")]
        OPTIONS,

        [EnumMember(Value = "PATCH")]
        PATCH,

        [EnumMember(Value = "POST")]
        POST,

        [EnumMember(Value = "PUT")]
        PUT,

        [EnumMember(Value = "TRACE")]
        TRACE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HttpMethod

} // namespace RubrikSecurityCloud.Types