// AuditType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    public enum AuditType
    {
        [EnumMember(Value = "ACCESS_MANAGEMENT")]
        ACCESS_MANAGEMENT,

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

        [EnumMember(Value = "DIAGNOSTIC")]
        DIAGNOSTIC,

        [EnumMember(Value = "DOWNLOAD")]
        DOWNLOAD,

        [EnumMember(Value = "FAILOVER")]
        FAILOVER,

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

        [EnumMember(Value = "SEARCH")]
        SEARCH,

        [EnumMember(Value = "SLA_ASSIGNMENT")]
        SLA_ASSIGNMENT,

        [EnumMember(Value = "SLA_MODIFICATION")]
        SLA_MODIFICATION,

        [EnumMember(Value = "SYNC")]
        SYNC,

        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "TPR")]
        TPR


    } // enum AuditType

} // namespace Rubrik.SecurityCloud.Types