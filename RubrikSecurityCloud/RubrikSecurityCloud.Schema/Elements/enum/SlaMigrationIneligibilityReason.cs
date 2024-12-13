// SlaMigrationIneligibilityReason.cs
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
    public enum SlaMigrationIneligibilityReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CASCADED_ARCHIVAL_CONFIGURED")]
        CASCADED_ARCHIVAL_CONFIGURED,

        [EnumMember(Value = "CLUSTER_DISCONNECTED")]
        CLUSTER_DISCONNECTED,

        [EnumMember(Value = "COMPLIANCE_RETENTION_LOCK_CONFIGURED")]
        COMPLIANCE_RETENTION_LOCK_CONFIGURED,

        [EnumMember(Value = "GOVERNANCE_RETENTION_LOCK_CONFIGURED")]
        GOVERNANCE_RETENTION_LOCK_CONFIGURED,

        [EnumMember(Value = "GOVERNANCE_RETENTION_LOCK_UNSUPPORTED_CLUSTER_VERSION")]
        GOVERNANCE_RETENTION_LOCK_UNSUPPORTED_CLUSTER_VERSION,

        [EnumMember(Value = "GOV_CLOUD_ARCHIVAL_LOCATION_REGISTERED_ON_CLUSTER")]
        GOV_CLOUD_ARCHIVAL_LOCATION_REGISTERED_ON_CLUSTER,

        [EnumMember(Value = "INVALID_CASCADING_ARCHIVAL_VERSION")]
        INVALID_CASCADING_ARCHIVAL_VERSION,

        [EnumMember(Value = "INVALID_CLUSTER_VERSION")]
        INVALID_CLUSTER_VERSION,

        [EnumMember(Value = "INVALID_LOCAL_SLA")]
        INVALID_LOCAL_SLA,

        [EnumMember(Value = "INVALID_REPLICATION_TARGET")]
        INVALID_REPLICATION_TARGET,

        [EnumMember(Value = "INVALID_REPLICATION_TARGET_VERSION")]
        INVALID_REPLICATION_TARGET_VERSION,

        [EnumMember(Value = "MINUTE_FREQUENCY_CONFIGURED")]
        MINUTE_FREQUENCY_CONFIGURED,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "RECOVERED_FROM_ARCHIVAL_LOCATION")]
        RECOVERED_FROM_ARCHIVAL_LOCATION,

        [EnumMember(Value = "REPLICATION_TARGET_DISCONNECTED")]
        REPLICATION_TARGET_DISCONNECTED,

        [EnumMember(Value = "RETENTION_LOCKED_SLA_WITH_CROSS_ACCOUNT_REPLICATION_TARGETS")]
        RETENTION_LOCKED_SLA_WITH_CROSS_ACCOUNT_REPLICATION_TARGETS,

        [EnumMember(Value = "RETENTION_LOCK_CONFIGURED")]
        RETENTION_LOCK_CONFIGURED,

        [EnumMember(Value = "SLA_OUT_OF_SYNC_ON_RSC")]
        SLA_OUT_OF_SYNC_ON_RSC,

        [EnumMember(Value = "TPR_ENABLED_ON_CLUSTER")]
        TPR_ENABLED_ON_CLUSTER,

        [EnumMember(Value = "UNSUPPORTED_PROTECTED_OBJECTS")]
        UNSUPPORTED_PROTECTED_OBJECTS,

        [EnumMember(Value = "UNSUPPORTED_PROTECTED_OBJECTS_MINUTE_FREQUENCY_CONFIGURED")]
        UNSUPPORTED_PROTECTED_OBJECTS_MINUTE_FREQUENCY_CONFIGURED,

        [EnumMember(Value = "UNSUPPORTED_PROTECTED_OBJECTS_SHARE_FILESET")]
        UNSUPPORTED_PROTECTED_OBJECTS_SHARE_FILESET


    } // enum SlaMigrationIneligibilityReason

} // namespace RubrikSecurityCloud.Types