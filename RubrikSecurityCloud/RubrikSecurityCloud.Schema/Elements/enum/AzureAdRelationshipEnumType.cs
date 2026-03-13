// AzureAdRelationshipEnumType.cs
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
    public enum AzureAdRelationshipEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_ROLE_ASSIGNED_TO")]
        APP_ROLE_ASSIGNED_TO,

        [EnumMember(Value = "APP_ROLE_ASSIGNMENT")]
        APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "FILTER_POLICY_ASSIGNMENT")]
        FILTER_POLICY_ASSIGNMENT,

        [EnumMember(Value = "GROUP_ELIGIBLE_ASSIGNMENT")]
        GROUP_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "GROUP_POLICY_ACTION")]
        GROUP_POLICY_ACTION,

        [EnumMember(Value = "GROUP_POLICY_ASSIGNMENT")]
        GROUP_POLICY_ASSIGNMENT,

        [EnumMember(Value = "MEMBER")]
        MEMBER,

        [EnumMember(Value = "NOTIFICATION_POLICY_ACTION")]
        NOTIFICATION_POLICY_ACTION,

        [EnumMember(Value = "OWNER")]
        OWNER,

        [EnumMember(Value = "POLICY_ACTION")]
        POLICY_ACTION,

        [EnumMember(Value = "POLICY_APPLIED_TO")]
        POLICY_APPLIED_TO,

        [EnumMember(Value = "POLICY_ASSIGNMENT")]
        POLICY_ASSIGNMENT,

        [EnumMember(Value = "POLICY_INCLUDES")]
        POLICY_INCLUDES,

        [EnumMember(Value = "POLICY_SCRIPT")]
        POLICY_SCRIPT,

        [EnumMember(Value = "PRINCIPAL_ROLE_ASSIGNMENT")]
        PRINCIPAL_ROLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_ELIGIBLE_ASSIGNMENT")]
        ROLE_ELIGIBLE_ASSIGNMENT,

        [EnumMember(Value = "SCOPE_ROLE_ASSIGNMENT")]
        SCOPE_ROLE_ASSIGNMENT


    } // enum AzureAdRelationshipEnumType

} // namespace RubrikSecurityCloud.Types