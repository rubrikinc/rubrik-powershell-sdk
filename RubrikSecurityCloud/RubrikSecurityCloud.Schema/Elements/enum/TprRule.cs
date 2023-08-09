// TprRule.cs
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
    public enum TprRule
    {
        [EnumMember(Value = "ASSIGN_TPR_ROLE")]
        ASSIGN_TPR_ROLE,

        [EnumMember(Value = "DELETE_SNAPSHOT")]
        DELETE_SNAPSHOT,

        [EnumMember(Value = "DELETE_TPR_POLICY")]
        DELETE_TPR_POLICY,

        [EnumMember(Value = "DELETE_TPR_ROLE")]
        DELETE_TPR_ROLE,

        [EnumMember(Value = "DELETE_TPR_USER")]
        DELETE_TPR_USER,

        [EnumMember(Value = "DISABLE_GLOBAL_TOTP")]
        DISABLE_GLOBAL_TOTP,

        [EnumMember(Value = "DISABLE_TPR")]
        DISABLE_TPR,

        [EnumMember(Value = "EDIT_SLA")]
        EDIT_SLA,

        [EnumMember(Value = "EDIT_TPR_POLICY")]
        EDIT_TPR_POLICY,

        [EnumMember(Value = "EDIT_TPR_ROLE")]
        EDIT_TPR_ROLE,

        [EnumMember(Value = "LEGAL_HOLD")]
        LEGAL_HOLD,

        [EnumMember(Value = "PAUSE_CLUSTER")]
        PAUSE_CLUSTER,

        [EnumMember(Value = "PAUSE_SLA")]
        PAUSE_SLA,

        [EnumMember(Value = "RESET_USER_TOTP_CONFIG")]
        RESET_USER_TOTP_CONFIG,

        [EnumMember(Value = "RETENTION_LOCK_OBJECT")]
        RETENTION_LOCK_OBJECT,

        [EnumMember(Value = "RETENTION_LOCK_SLA")]
        RETENTION_LOCK_SLA,

        [EnumMember(Value = "REVOKE_TPR_ROLE")]
        REVOKE_TPR_ROLE,

        [EnumMember(Value = "SLA_ASSIGNMENT")]
        SLA_ASSIGNMENT,

        [EnumMember(Value = "TPR_RULE_UNSPECIFIED")]
        TPR_RULE_UNSPECIFIED,

        [EnumMember(Value = "UNLOCK_TPR_USER")]
        UNLOCK_TPR_USER


    } // enum TprRule

} // namespace RubrikSecurityCloud.Types