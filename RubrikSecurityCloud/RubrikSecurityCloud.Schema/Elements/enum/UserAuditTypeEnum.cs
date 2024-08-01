// UserAuditTypeEnum.cs
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
    public enum UserAuditTypeEnum
    {
        [EnumMember(Value = "ANOMALY")]
        ANOMALY,

        [EnumMember(Value = "AccessManagement")]
        ACCESS_MANAGEMENT,

        [EnumMember(Value = "Audit")]
        AUDIT,

        [EnumMember(Value = "BULK_RECOVERY")]
        BULK_RECOVERY,

        [EnumMember(Value = "Backup")]
        BACKUP,

        [EnumMember(Value = "Classification")]
        CLASSIFICATION,

        [EnumMember(Value = "Configuration")]
        CONFIGURATION,

        [EnumMember(Value = "Diagnostic")]
        DIAGNOSTIC,

        [EnumMember(Value = "Download")]
        DOWNLOAD,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT_OPERATION")]
        ENCRYPTION_MANAGEMENT_OPERATION,

        [EnumMember(Value = "FILE_DOWNLOAD")]
        FILE_DOWNLOAD,

        [EnumMember(Value = "Failover")]
        FAILOVER,

        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "Index")]
        INDEX,

        [EnumMember(Value = "LOCAL_RECOVERY")]
        LOCAL_RECOVERY,

        [EnumMember(Value = "LegalHold")]
        LEGAL_HOLD,

        [EnumMember(Value = "Login")]
        LOGIN,

        [EnumMember(Value = "QUARANTINE")]
        QUARANTINE,

        [EnumMember(Value = "RECOVERY_SCHEDULE")]
        RECOVERY_SCHEDULE,

        [EnumMember(Value = "RUBY_AI")]
        RUBY_AI,

        [EnumMember(Value = "Recovery")]
        RECOVERY,

        [EnumMember(Value = "Search")]
        SEARCH,

        [EnumMember(Value = "SlaAssignment")]
        SLA_ASSIGNMENT,

        [EnumMember(Value = "SlaModification")]
        SLA_MODIFICATION,

        [EnumMember(Value = "Sync")]
        SYNC,

        [EnumMember(Value = "THREAT_FEED")]
        THREAT_FEED,

        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "UnknownUserAuditType")]
        UNKNOWN_USER_AUDIT_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserAuditTypeEnum

} // namespace RubrikSecurityCloud.Types