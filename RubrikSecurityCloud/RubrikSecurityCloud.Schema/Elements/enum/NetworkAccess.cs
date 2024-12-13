// NetworkAccess.cs
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
    public enum NetworkAccess
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NETWORK_ACCESS_INTERNAL")]
        NETWORK_ACCESS_INTERNAL,

        [EnumMember(Value = "NETWORK_ACCESS_INTERNET_FACING")]
        NETWORK_ACCESS_INTERNET_FACING,

        [EnumMember(Value = "NETWORK_ACCESS_UNSPECIFIED")]
        NETWORK_ACCESS_UNSPECIFIED


    } // enum NetworkAccess

} // namespace RubrikSecurityCloud.Types