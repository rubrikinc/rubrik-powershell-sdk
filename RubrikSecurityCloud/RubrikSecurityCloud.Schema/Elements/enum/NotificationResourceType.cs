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
        [EnumMember(Value = "CROSS_ACCOUNT")]
        CROSS_ACCOUNT,

        [EnumMember(Value = "LICENSE")]
        LICENSE,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "QUORUM_AUTH_REQUEST")]
        QUORUM_AUTH_REQUEST,

        [EnumMember(Value = "RESOURCE_TYPE_UNSPECIFIED")]
        RESOURCE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RUBRIK_CLUSTER")]
        RUBRIK_CLUSTER,

        [EnumMember(Value = "SAAS_APPS_ORGANIZATION")]
        SAAS_APPS_ORGANIZATION,

        [EnumMember(Value = "SLA_AUTO_MIGRATION")]
        SLA_AUTO_MIGRATION,

        [EnumMember(Value = "THREAT_MONITORING_MATCH")]
        THREAT_MONITORING_MATCH,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NotificationResourceType

} // namespace RubrikSecurityCloud.Types