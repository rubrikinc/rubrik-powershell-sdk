// AzureAdRoleAssignmentScopeType.cs
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
    public enum AzureAdRoleAssignmentScopeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SCOPE_TYPE_ADMINISTRATIVE_UNIT")]
        SCOPE_TYPE_ADMINISTRATIVE_UNIT,

        [EnumMember(Value = "SCOPE_TYPE_APPLICATION")]
        SCOPE_TYPE_APPLICATION,

        [EnumMember(Value = "SCOPE_TYPE_DIRECTORY")]
        SCOPE_TYPE_DIRECTORY,

        [EnumMember(Value = "SCOPE_TYPE_GROUP")]
        SCOPE_TYPE_GROUP,

        [EnumMember(Value = "SCOPE_TYPE_SERVICE_PRINCIPAL")]
        SCOPE_TYPE_SERVICE_PRINCIPAL,

        [EnumMember(Value = "SCOPE_TYPE_UNKNOWN")]
        SCOPE_TYPE_UNKNOWN,

        [EnumMember(Value = "SCOPE_TYPE_USER")]
        SCOPE_TYPE_USER


    } // enum AzureAdRoleAssignmentScopeType

} // namespace RubrikSecurityCloud.Types