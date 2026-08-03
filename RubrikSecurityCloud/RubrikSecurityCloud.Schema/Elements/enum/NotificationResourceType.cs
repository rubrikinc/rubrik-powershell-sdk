// NotificationResourceType.cs
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
    public enum NotificationResourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_PRIVATE_CONTAINER_REGISTRY")]
        AWS_PRIVATE_CONTAINER_REGISTRY,

        [EnumMember(Value = "CROSS_ACCOUNT")]
        CROSS_ACCOUNT,

        [EnumMember(Value = "DEFAULT_AUDIT_EVENT")]
        DEFAULT_AUDIT_EVENT,

        [EnumMember(Value = "DEFAULT_CDM_EVENT")]
        DEFAULT_CDM_EVENT,

        [EnumMember(Value = "DEFAULT_EVENT")]
        DEFAULT_EVENT,

        [EnumMember(Value = "ENTRA_ID")]
        ENTRA_ID,

        [EnumMember(Value = "EXOCOMPUTE_CLUSTER")]
        EXOCOMPUTE_CLUSTER,

        [EnumMember(Value = "HIGH_IMPACT_CHANGE")]
        HIGH_IMPACT_CHANGE,

        [EnumMember(Value = "IDENTITY_PROVIDER")]
        IDENTITY_PROVIDER,

        [EnumMember(Value = "LICENSE")]
        LICENSE,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "NEW_DEVICE_LOGIN")]
        NEW_DEVICE_LOGIN,

        [EnumMember(Value = "NUTANIX_CLUSTER")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "QUORUM_AUTH_CONFIGURATION")]
        QUORUM_AUTH_CONFIGURATION,

        [EnumMember(Value = "QUORUM_AUTH_REQUEST")]
        QUORUM_AUTH_REQUEST,

        [EnumMember(Value = "RESOURCE_TYPE_UNSPECIFIED")]
        RESOURCE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RUBRIK_CLUSTER")]
        RUBRIK_CLUSTER,

        [EnumMember(Value = "SAAS_APPS_ORGANIZATION")]
        SAAS_APPS_ORGANIZATION,

        [EnumMember(Value = "SENTRY_AI_INSIGHT")]
        SENTRY_AI_INSIGHT,

        [EnumMember(Value = "SLA_AUTO_MIGRATION")]
        SLA_AUTO_MIGRATION,

        [EnumMember(Value = "THREAT_MONITORING_MATCH")]
        THREAT_MONITORING_MATCH,

        [EnumMember(Value = "TPR_BREAK_GLASS_ENROLLMENT")]
        TPR_BREAK_GLASS_ENROLLMENT,

        [EnumMember(Value = "USER_ACCOUNT")]
        USER_ACCOUNT


    } // enum NotificationResourceType

} // namespace RubrikSecurityCloud.Types