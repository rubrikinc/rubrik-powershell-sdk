// ServerRoles.cs
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
    public enum ServerRoles
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DHCP")]
        DHCP,

        [EnumMember(Value = "DNS")]
        DNS,

        [EnumMember(Value = "UNKNOWN_SERVER_ROLE")]
        UNKNOWN_SERVER_ROLE


    } // enum ServerRoles

} // namespace RubrikSecurityCloud.Types