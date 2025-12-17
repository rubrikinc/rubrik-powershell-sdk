// AuditType.cs
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
    public enum AuditType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_MANAGEMENT")]
        ACCESS_MANAGEMENT,

        [EnumMember(Value = "ANOMALY")]
        ANOMALY,

        [EnumMember(Value = "AUDIT")]
        AUDIT,

        [EnumMember(Value = "AUDIT_TYPE_UNSPECIFIED")]
        AUDIT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "BACKUP")]
        BACKUP,

        [EnumMember(Value = "BULK_RECOVERY")]
        BULK_RECOVERY,

        [EnumMember(Value = "CLASSIFICATION")]
        CLASSIFICATION,

        [EnumMember(Value = "CONFIGURATION")]
        CONFIGURATION,

        [EnumMember(Value = "DATA_RISKS")]
        DATA_RISKS,

        [EnumMember(Value = "DIAGNOSTIC")]
        DIAGNOSTIC,

        [EnumMember(Value = "DOWNLOAD")]
        DOWNLOAD,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT_OPERATION")]
        ENCRYPTION_MANAGEMENT_OPERATION,

        [EnumMember(Value = "FAILOVER")]
        FAILOVER,

        [EnumMember(Value = "FILE_DOWNLOAD")]
        FILE_DOWNLOAD,

        [EnumMember(Value = "IDENTITY_ACTIVITY")]
        IDENTITY_ACTIVITY,

        [EnumMember(Value = "IDENTITY_ALERT")]
        IDENTITY_ALERT,

        [EnumMember(Value = "IDENTITY_VIOLATION")]
        IDENTITY_VIOLATION,

        [EnumMember(Value = "INDEX")]
        INDEX,

        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "LEGAL_HOLD")]
        LEGAL_HOLD,

        [EnumMember(Value = "LOCAL_RECOVERY")]
        LOCAL_RECOVERY,

        [EnumMember(Value = "LOGIN")]
        LOGIN,

        [EnumMember(Value = "QUARANTINE")]
        QUARANTINE,

        [EnumMember(Value = "RECOVERY")]
        RECOVERY,

        [EnumMember(Value = "RECOVERY_SCHEDULE")]
        RECOVERY_SCHEDULE,

        [EnumMember(Value = "RUBY_AI")]
        RUBY_AI,

        [EnumMember(Value = "SEARCH")]
        SEARCH,

        [EnumMember(Value = "SLA_ASSIGNMENT")]
        SLA_ASSIGNMENT,

        [EnumMember(Value = "SLA_MODIFICATION")]
        SLA_MODIFICATION,

        [EnumMember(Value = "STAGED_UPGRADE")]
        STAGED_UPGRADE,

        [EnumMember(Value = "SYNC")]
        SYNC,

        [EnumMember(Value = "THREAT_FEED")]
        THREAT_FEED,

        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "TPR")]
        TPR


    } // enum AuditType

} // namespace RubrikSecurityCloud.Types