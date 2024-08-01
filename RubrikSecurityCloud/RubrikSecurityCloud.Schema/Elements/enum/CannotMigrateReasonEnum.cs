// CannotMigrateReasonEnum.cs
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
    public enum CannotMigrateReasonEnum
    {
        [EnumMember(Value = "CANNOT_MIGRATE_REASON_UNSPECIFIED")]
        CANNOT_MIGRATE_REASON_UNSPECIFIED,

        [EnumMember(Value = "ROLE_HAS_NO_RULES")]
        ROLE_HAS_NO_RULES,

        [EnumMember(Value = "ROLE_MIGRATION_ERROR")]
        ROLE_MIGRATION_ERROR,

        [EnumMember(Value = "ROLE_NOT_SUPPORTED")]
        ROLE_NOT_SUPPORTED,

        [EnumMember(Value = "RULE_NOT_SUPPORTED")]
        RULE_NOT_SUPPORTED,

        [EnumMember(Value = "SSO_GROUP_NO_ROLES")]
        SSO_GROUP_NO_ROLES,

        [EnumMember(Value = "SSO_GROUP_WRONG_AUTH_DOMAIN")]
        SSO_GROUP_WRONG_AUTH_DOMAIN,

        [EnumMember(Value = "USER_DUPLICATE_EMAIL")]
        USER_DUPLICATE_EMAIL,

        [EnumMember(Value = "USER_INVALID_EMAIL")]
        USER_INVALID_EMAIL,

        [EnumMember(Value = "USER_NOT_LOCAL")]
        USER_NOT_LOCAL,

        [EnumMember(Value = "USER_NO_ROLES")]
        USER_NO_ROLES,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CannotMigrateReasonEnum

} // namespace RubrikSecurityCloud.Types