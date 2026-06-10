// AzureAdPimEligibilityMemberType.cs
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
    public enum AzureAdPimEligibilityMemberType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PIM_MEMBER_TYPE_DIRECT")]
        PIM_MEMBER_TYPE_DIRECT,

        [EnumMember(Value = "PIM_MEMBER_TYPE_GROUP")]
        PIM_MEMBER_TYPE_GROUP,

        [EnumMember(Value = "PIM_MEMBER_TYPE_INHERITED")]
        PIM_MEMBER_TYPE_INHERITED,

        [EnumMember(Value = "PIM_MEMBER_TYPE_UNSPECIFIED")]
        PIM_MEMBER_TYPE_UNSPECIFIED


    } // enum AzureAdPimEligibilityMemberType

} // namespace RubrikSecurityCloud.Types