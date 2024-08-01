// EnvoyConnectionField.cs
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
    public enum EnvoyConnectionField
    {
        [EnumMember(Value = "ENVOY_CONNECTION_ALL_CONNECTED")]
        ENVOY_CONNECTION_ALL_CONNECTED,

        [EnumMember(Value = "ENVOY_CONNECTION_SOME_DISCONNECTED")]
        ENVOY_CONNECTION_SOME_DISCONNECTED,

        [EnumMember(Value = "ENVOY_CONNECTION_UNSPECIFIED")]
        ENVOY_CONNECTION_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum EnvoyConnectionField

} // namespace RubrikSecurityCloud.Types