// ProviderType.cs
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
    public enum ProviderType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "LOGSCALE")]
        LOGSCALE,

        [EnumMember(Value = "MICROSOFT_SENTINEL")]
        MICROSOFT_SENTINEL,

        [EnumMember(Value = "PAGERDUTY")]
        PAGERDUTY,

        [EnumMember(Value = "PROVIDER_TYPE_UNSPECIFIED")]
        PROVIDER_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SPLUNK")]
        SPLUNK


    } // enum ProviderType

} // namespace RubrikSecurityCloud.Types