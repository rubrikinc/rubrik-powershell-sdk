// FailoverStatusEnum.cs
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
    public enum FailoverStatusEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_CLEANUP_STARTED")]
        FAILOVER_CLEANUP_STARTED,

        [EnumMember(Value = "FAILOVER_FAILED")]
        FAILOVER_FAILED,

        [EnumMember(Value = "FAILOVER_JOB_FAILED")]
        FAILOVER_JOB_FAILED,

        [EnumMember(Value = "FAILOVER_JOB_SUCCEEDED")]
        FAILOVER_JOB_SUCCEEDED,

        [EnumMember(Value = "ISOLATED_RECOVERY_CLEANUP_STARTED")]
        ISOLATED_RECOVERY_CLEANUP_STARTED,

        [EnumMember(Value = "ISOLATED_RECOVERY_FAILED")]
        ISOLATED_RECOVERY_FAILED,

        [EnumMember(Value = "ISOLATED_RECOVERY_FAILED_AND_CLEANED")]
        ISOLATED_RECOVERY_FAILED_AND_CLEANED,

        [EnumMember(Value = "ISOLATED_RECOVERY_LOCKED")]
        ISOLATED_RECOVERY_LOCKED,

        [EnumMember(Value = "ISOLATED_RECOVERY_ONGOING")]
        ISOLATED_RECOVERY_ONGOING,

        [EnumMember(Value = "ISOLATED_RECOVERY_PAUSED")]
        ISOLATED_RECOVERY_PAUSED,

        [EnumMember(Value = "ISOLATED_RECOVERY_PROMOTION_FAILED")]
        ISOLATED_RECOVERY_PROMOTION_FAILED,

        [EnumMember(Value = "ISOLATED_RECOVERY_PROMOTION_STARTED")]
        ISOLATED_RECOVERY_PROMOTION_STARTED,

        [EnumMember(Value = "ISOLATED_RECOVERY_PROMOTION_SUCCEEDED")]
        ISOLATED_RECOVERY_PROMOTION_SUCCEEDED,

        [EnumMember(Value = "ISOLATED_RECOVERY_QUEUED")]
        ISOLATED_RECOVERY_QUEUED,

        [EnumMember(Value = "ISOLATED_RECOVERY_SUCCEEDED")]
        ISOLATED_RECOVERY_SUCCEEDED,

        [EnumMember(Value = "ISOLATED_RECOVERY_SUCCEEDED_AND_CLEANED")]
        ISOLATED_RECOVERY_SUCCEEDED_AND_CLEANED,

        [EnumMember(Value = "LOCAL_RECOVERY_SUCCEEDED")]
        LOCAL_RECOVERY_SUCCEEDED,

        [EnumMember(Value = "NOT_SUPPORTED")]
        NOT_SUPPORTED,

        [EnumMember(Value = "ONGOING")]
        ONGOING,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "TEST_FAILOVER_SUCCEEDED")]
        TEST_FAILOVER_SUCCEEDED


    } // enum FailoverStatusEnum

} // namespace RubrikSecurityCloud.Types