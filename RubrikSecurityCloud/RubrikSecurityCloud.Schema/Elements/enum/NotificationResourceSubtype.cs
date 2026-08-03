// NotificationResourceSubtype.cs
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
    public enum NotificationResourceSubtype
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CROSS_ACCOUNT_CLUSTER")]
        CROSS_ACCOUNT_CLUSTER,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "EXOCOMPUTE_CLUSTER_READY")]
        EXOCOMPUTE_CLUSTER_READY,

        [EnumMember(Value = "MSSQL_DISCOVERY")]
        MSSQL_DISCOVERY,

        [EnumMember(Value = "MVB_RECOVERY_ANALYSIS")]
        MVB_RECOVERY_ANALYSIS,

        [EnumMember(Value = "MVC_RECOVERY_ANALYSIS")]
        MVC_RECOVERY_ANALYSIS,

        [EnumMember(Value = "RESOURCE_SUBTYPE_UNSPECIFIED")]
        RESOURCE_SUBTYPE_UNSPECIFIED,

        [EnumMember(Value = "RESTORE_IMPACT_ANALYSIS")]
        RESTORE_IMPACT_ANALYSIS,

        [EnumMember(Value = "SENTRY_AI_ACCOUNT_INSIGHT")]
        SENTRY_AI_ACCOUNT_INSIGHT,

        [EnumMember(Value = "SENTRY_AI_CLUSTER_INSIGHT")]
        SENTRY_AI_CLUSTER_INSIGHT


    } // enum NotificationResourceSubtype

} // namespace RubrikSecurityCloud.Types