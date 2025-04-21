// AzureAdAdminUnitMembershipEnumType.cs
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
    public enum AzureAdAdminUnitMembershipEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ASSIGNED")]
        ASSIGNED,

        [EnumMember(Value = "DYNAMIC")]
        DYNAMIC,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum AzureAdAdminUnitMembershipEnumType

} // namespace RubrikSecurityCloud.Types