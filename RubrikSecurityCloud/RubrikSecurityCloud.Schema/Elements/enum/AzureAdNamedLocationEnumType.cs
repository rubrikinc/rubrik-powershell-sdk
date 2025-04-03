// AzureAdNamedLocationEnumType.cs
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
    public enum AzureAdNamedLocationEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AD_NAMED_LOCATION_TYPE_UNKNOWN")]
        AZURE_AD_NAMED_LOCATION_TYPE_UNKNOWN,

        [EnumMember(Value = "COUNTRIES_GPS")]
        COUNTRIES_GPS,

        [EnumMember(Value = "COUNTRIES_IP")]
        COUNTRIES_IP,

        [EnumMember(Value = "IP_RANGES")]
        IP_RANGES


    } // enum AzureAdNamedLocationEnumType

} // namespace RubrikSecurityCloud.Types