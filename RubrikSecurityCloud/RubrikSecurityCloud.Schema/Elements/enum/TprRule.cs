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
        [EnumMember(Value = "DELETE_SNAPSHOT")]
        DELETE_SNAPSHOT,

        [EnumMember(Value = "DISABLE_GLOBAL_TOTP")]
        DISABLE_GLOBAL_TOTP,

        [EnumMember(Value = "DISABLE_TPR")]
        DISABLE_TPR,

        [EnumMember(Value = "EDIT_SLA")]
        EDIT_SLA,

        [EnumMember(Value = "LEGAL_HOLD")]
        LEGAL_HOLD,

        [EnumMember(Value = "PAUSE_CLUSTER")]
        PAUSE_CLUSTER,

        [EnumMember(Value = "PAUSE_SLA")]
        PAUSE_SLA,

        [EnumMember(Value = "RETENTION_LOCK_OBJECT")]
        RETENTION_LOCK_OBJECT,

        [EnumMember(Value = "RETENTION_LOCK_SLA")]
        RETENTION_LOCK_SLA,

        [EnumMember(Value = "SLA_ASSIGNMENT")]
        SLA_ASSIGNMENT,

        [EnumMember(Value = "TPR_RULE_UNSPECIFIED")]
        TPR_RULE_UNSPECIFIED


    } // enum TprRule

} // namespace RubrikSecurityCloud.Types