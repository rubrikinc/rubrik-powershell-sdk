// SaasAppApiType.cs
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
    public enum SaasAppApiType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "API_TYPE_UNSPECIFIED")]
        API_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SALESFORCE_BULK_V2_API")]
        SALESFORCE_BULK_V2_API,

        [EnumMember(Value = "SALESFORCE_REST_API")]
        SALESFORCE_REST_API


    } // enum SaasAppApiType

} // namespace RubrikSecurityCloud.Types