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

        [EnumMember(Value = "MEMBER")]
        MEMBER,

        [EnumMember(Value = "OWNER")]
        OWNER,

        [EnumMember(Value = "POLICY_APPLIED_TO")]
        POLICY_APPLIED_TO,

        [EnumMember(Value = "POLICY_INCLUDES")]
        POLICY_INCLUDES,

        [EnumMember(Value = "PRINCIPAL_ROLE_ASSIGNMENT")]
        PRINCIPAL_ROLE_ASSIGNMENT,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "SCOPE_ROLE_ASSIGNMENT")]
        SCOPE_ROLE_ASSIGNMENT


    } // enum AzureAdRelationshipEnumType

} // namespace RubrikSecurityCloud.Types