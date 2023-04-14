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

namespace Rubrik.SecurityCloud.Types
{
    public enum UserAuditTypeEnum
    {
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

        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "UnknownUserAuditType")]
        UNKNOWN_USER_AUDIT_TYPE


    } // enum UserAuditTypeEnum

} // namespace Rubrik.SecurityCloud.Types