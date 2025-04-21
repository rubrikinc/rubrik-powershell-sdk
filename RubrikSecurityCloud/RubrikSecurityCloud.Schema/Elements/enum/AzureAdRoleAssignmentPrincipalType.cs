// AzureAdRoleAssignmentPrincipalType.cs
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
    public enum AzureAdRoleAssignmentPrincipalType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PRINCIPAL_TYPE_GROUP")]
        PRINCIPAL_TYPE_GROUP,

        [EnumMember(Value = "PRINCIPAL_TYPE_SERVICE_PRINCIPAL")]
        PRINCIPAL_TYPE_SERVICE_PRINCIPAL,

        [EnumMember(Value = "PRINCIPAL_TYPE_UNKNOWN")]
        PRINCIPAL_TYPE_UNKNOWN,

        [EnumMember(Value = "PRINCIPAL_TYPE_USER")]
        PRINCIPAL_TYPE_USER


    } // enum AzureAdRoleAssignmentPrincipalType

} // namespace RubrikSecurityCloud.Types