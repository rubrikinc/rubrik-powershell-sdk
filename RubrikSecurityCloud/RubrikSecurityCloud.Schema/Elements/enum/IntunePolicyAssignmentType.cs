// IntunePolicyAssignmentType.cs
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
    public enum IntunePolicyAssignmentType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_TYPE_ALL_DEVICES")]
        INTUNE_POLICY_ASSIGNMENT_TYPE_ALL_DEVICES,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_TYPE_ALL_LICENSED_USERS")]
        INTUNE_POLICY_ASSIGNMENT_TYPE_ALL_LICENSED_USERS,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_TYPE_EXCLUDE_GROUP")]
        INTUNE_POLICY_ASSIGNMENT_TYPE_EXCLUDE_GROUP,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_TYPE_INCLUDE_GROUP")]
        INTUNE_POLICY_ASSIGNMENT_TYPE_INCLUDE_GROUP,

        [EnumMember(Value = "INTUNE_POLICY_ASSIGNMENT_TYPE_UNKNOWN")]
        INTUNE_POLICY_ASSIGNMENT_TYPE_UNKNOWN


    } // enum IntunePolicyAssignmentType

} // namespace RubrikSecurityCloud.Types