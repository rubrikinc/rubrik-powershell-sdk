// DhrcMetric.cs
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
    public enum DhrcMetric
    {
        [EnumMember(Value = "ANOMALIES_DETECTED_PAST_WEEK")]
        ANOMALIES_DETECTED_PAST_WEEK,

        [EnumMember(Value = "CDM_LOW_RUNWAY_REMAINING")]
        CDM_LOW_RUNWAY_REMAINING,

        [EnumMember(Value = "CDM_NEXT_RELEASE_UPGRADE_AVAILABLE")]
        CDM_NEXT_RELEASE_UPGRADE_AVAILABLE,

        [EnumMember(Value = "CDM_NODE_ENCRYPTION")]
        CDM_NODE_ENCRYPTION,

        [EnumMember(Value = "CDM_SAME_RELEASE_UPGRADE_AVAILABLE")]
        CDM_SAME_RELEASE_UPGRADE_AVAILABLE,

        [EnumMember(Value = "CDM_VERSION_UNSUPPORTED")]
        CDM_VERSION_UNSUPPORTED,

        [EnumMember(Value = "DATA_DISCOVERY_ENABLED_CLUSTERS")]
        DATA_DISCOVERY_ENABLED_CLUSTERS,

        [EnumMember(Value = "DO_NOT_PROTECT_OBJECTS")]
        DO_NOT_PROTECT_OBJECTS,

        [EnumMember(Value = "LOGGED_IN_TO_SUPPORT_PORTAL")]
        LOGGED_IN_TO_SUPPORT_PORTAL,

        [EnumMember(Value = "METRIC_UNSPECIFIED")]
        METRIC_UNSPECIFIED,

        [EnumMember(Value = "OPEN_ACCESS_SENSITIVE_FILES")]
        OPEN_ACCESS_SENSITIVE_FILES,

        [EnumMember(Value = "PROTECTED_OBJECTS")]
        PROTECTED_OBJECTS,

        [EnumMember(Value = "RADAR_ENABLED_CLUSTERS")]
        RADAR_ENABLED_CLUSTERS,

        [EnumMember(Value = "SLA_COMPLIANCE")]
        SLA_COMPLIANCE,

        [EnumMember(Value = "SLA_USING_RETENTION_LOCK")]
        SLA_USING_RETENTION_LOCK,

        [EnumMember(Value = "USERS_USING_TOTP")]
        USERS_USING_TOTP


    } // enum DhrcMetric

} // namespace RubrikSecurityCloud.Types