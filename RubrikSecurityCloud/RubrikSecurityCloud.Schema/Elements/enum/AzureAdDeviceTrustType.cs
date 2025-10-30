// AzureAdDeviceTrustType.cs
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
    public enum AzureAdDeviceTrustType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AD")]
        AZURE_AD,

        [EnumMember(Value = "DEVICE_TRUST_TYPE_UNKNOWN")]
        DEVICE_TRUST_TYPE_UNKNOWN,

        [EnumMember(Value = "SERVER_AD")]
        SERVER_AD,

        [EnumMember(Value = "WORKPLACE")]
        WORKPLACE


    } // enum AzureAdDeviceTrustType

} // namespace RubrikSecurityCloud.Types