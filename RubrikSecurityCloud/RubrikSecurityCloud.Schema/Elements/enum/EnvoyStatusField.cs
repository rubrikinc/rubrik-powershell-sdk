// EnvoyStatusField.cs
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
    public enum EnvoyStatusField
    {
        [EnumMember(Value = "ENVOY_STATUS_OFFLINE")]
        ENVOY_STATUS_OFFLINE,

        [EnumMember(Value = "ENVOY_STATUS_ONLINE")]
        ENVOY_STATUS_ONLINE,

        [EnumMember(Value = "ENVOY_STATUS_UNSPECIFIED")]
        ENVOY_STATUS_UNSPECIFIED


    } // enum EnvoyStatusField

} // namespace RubrikSecurityCloud.Types