// AccountState.cs
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
    public enum AccountState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_STATE")]
        ACTIVE_STATE,

        [EnumMember(Value = "DELETED_STATE")]
        DELETED_STATE,

        [EnumMember(Value = "FAILED_CREATION")]
        FAILED_CREATION,

        [EnumMember(Value = "GRACE_STATE")]
        GRACE_STATE,

        [EnumMember(Value = "HOLD_STATE")]
        HOLD_STATE,

        [EnumMember(Value = "MARKED_FOR_DELETION_STATE")]
        MARKED_FOR_DELETION_STATE,

        [EnumMember(Value = "PENDING_CREATION")]
        PENDING_CREATION,

        [EnumMember(Value = "PENDING_MIGRATION")]
        PENDING_MIGRATION,

        [EnumMember(Value = "PENDING_POST_PROCESSING")]
        PENDING_POST_PROCESSING,

        [EnumMember(Value = "SUSPENDED_STATE")]
        SUSPENDED_STATE


    } // enum AccountState

} // namespace RubrikSecurityCloud.Types