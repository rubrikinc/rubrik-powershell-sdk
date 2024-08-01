// DhrcRecommendationKey.cs
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
    public enum DhrcRecommendationKey
    {
        [EnumMember(Value = "CONNECT_RSC_TO_SUPPORT_PORTAL")]
        CONNECT_RSC_TO_SUPPORT_PORTAL,

        [EnumMember(Value = "INCREASE_NUMBER_OF_DATA_DISCOVERY_ENABLED_CLUSTERS")]
        INCREASE_NUMBER_OF_DATA_DISCOVERY_ENABLED_CLUSTERS,

        [EnumMember(Value = "INCREASE_NUMBER_OF_ENCRYPTED_CDM_NODES")]
        INCREASE_NUMBER_OF_ENCRYPTED_CDM_NODES,

        [EnumMember(Value = "INCREASE_NUMBER_OF_PROTECTED_OBJECTS")]
        INCREASE_NUMBER_OF_PROTECTED_OBJECTS,

        [EnumMember(Value = "INCREASE_NUMBER_OF_RADAR_ENABLED_CLUSTERS")]
        INCREASE_NUMBER_OF_RADAR_ENABLED_CLUSTERS,

        [EnumMember(Value = "INCREASE_NUMBER_OF_SLAS_USING_RETENTION_LOCK")]
        INCREASE_NUMBER_OF_SLAS_USING_RETENTION_LOCK,

        [EnumMember(Value = "INCREASE_NUMBER_OF_SLA_COMPLIANT_OBJECTS")]
        INCREASE_NUMBER_OF_SLA_COMPLIANT_OBJECTS,

        [EnumMember(Value = "INCREASE_NUMBER_OF_USERS_USING_TOTP")]
        INCREASE_NUMBER_OF_USERS_USING_TOTP,

        [EnumMember(Value = "INCREASE_RUNWAY_REMAINING_ON_CDM_CLUSTERS")]
        INCREASE_RUNWAY_REMAINING_ON_CDM_CLUSTERS,

        [EnumMember(Value = "INVESTIGATE_ANOMALY_EVENTS")]
        INVESTIGATE_ANOMALY_EVENTS,

        [EnumMember(Value = "KEY_UNSPECIFIED")]
        KEY_UNSPECIFIED,

        [EnumMember(Value = "SECURE_OPEN_ACCESS_SENSITIVE_FILES")]
        SECURE_OPEN_ACCESS_SENSITIVE_FILES,

        [EnumMember(Value = "UPGRADE_CDM_CLUSTERS_SOFTWARE_VERSION")]
        UPGRADE_CDM_CLUSTERS_SOFTWARE_VERSION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DhrcRecommendationKey

} // namespace RubrikSecurityCloud.Types