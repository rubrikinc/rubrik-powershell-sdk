// PendingActionSubGroupTypeEnum.cs
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
    public enum PendingActionSubGroupTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADD_CLUSTER_AS_REPLICATION_TARGET")]
        ADD_CLUSTER_AS_REPLICATION_TARGET,

        [EnumMember(Value = "ARCHIVAL_LOCATION_DELETE")]
        ARCHIVAL_LOCATION_DELETE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_DISABLE")]
        ARCHIVAL_LOCATION_DISABLE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_ENABLE")]
        ARCHIVAL_LOCATION_ENABLE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_PAUSE")]
        ARCHIVAL_LOCATION_PAUSE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_RESUME")]
        ARCHIVAL_LOCATION_RESUME,

        [EnumMember(Value = "AWS_COMPUTE_SETTING_UPSERT")]
        AWS_COMPUTE_SETTING_UPSERT,

        [EnumMember(Value = "AWS_IAM_CUSTOMER_ACCOUNT_UPSERT")]
        AWS_IAM_CUSTOMER_ACCOUNT_UPSERT,

        [EnumMember(Value = "AWS_ROLE_BASED_ARCHIVAL_LOCATION")]
        AWS_ROLE_BASED_ARCHIVAL_LOCATION,

        [EnumMember(Value = "AZURE_CUSTOMER_FEATURE_UPSERT")]
        AZURE_CUSTOMER_FEATURE_UPSERT,

        [EnumMember(Value = "BLUEPRINT_CREATE")]
        BLUEPRINT_CREATE,

        [EnumMember(Value = "BLUEPRINT_DELETE")]
        BLUEPRINT_DELETE,

        [EnumMember(Value = "BLUEPRINT_DEPRECATE")]
        BLUEPRINT_DEPRECATE,

        [EnumMember(Value = "BLUEPRINT_UPDATE")]
        BLUEPRINT_UPDATE,

        [EnumMember(Value = "CLOUD_ACCOUNT_UPDATE")]
        CLOUD_ACCOUNT_UPDATE,

        [EnumMember(Value = "CLUSTER_PEER_TOKEN_GET")]
        CLUSTER_PEER_TOKEN_GET,

        [EnumMember(Value = "CLUSTER_PEER_TOKEN_GET_AND_SET")]
        CLUSTER_PEER_TOKEN_GET_AND_SET,

        [EnumMember(Value = "CLUSTER_PEER_TOKEN_SET")]
        CLUSTER_PEER_TOKEN_SET,

        [EnumMember(Value = "DCA_LOCATION_PUT")]
        DCA_LOCATION_PUT,

        [EnumMember(Value = "DCA_LOCATION_READER_POST")]
        DCA_LOCATION_READER_POST,

        [EnumMember(Value = "DISABLE_REPLICATION_LOCATION_PUT")]
        DISABLE_REPLICATION_LOCATION_PUT,

        [EnumMember(Value = "ENABLE_LOCATION_AS_REPLICATION_TARGET")]
        ENABLE_LOCATION_AS_REPLICATION_TARGET,

        [EnumMember(Value = "ENABLE_POLARIS_AS_REPLICATION_SOURCE")]
        ENABLE_POLARIS_AS_REPLICATION_SOURCE,

        [EnumMember(Value = "FEDERATED_LOGIN")]
        FEDERATED_LOGIN,

        [EnumMember(Value = "GLOBAL_SLA_ASSIGN")]
        GLOBAL_SLA_ASSIGN,

        [EnumMember(Value = "GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPPABLE")]
        GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPPABLE,

        [EnumMember(Value = "GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPSHOT")]
        GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPSHOT,

        [EnumMember(Value = "GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPSHOT_V2")]
        GLOBAL_SLA_ASSIGN_RETENTION_SLA_TO_SNAPSHOT_V2,

        [EnumMember(Value = "GLOBAL_SLA_DELETE")]
        GLOBAL_SLA_DELETE,

        [EnumMember(Value = "GLOBAL_SLA_PUT")]
        GLOBAL_SLA_PUT,

        [EnumMember(Value = "GRANT_AUTHZ")]
        GRANT_AUTHZ,

        [EnumMember(Value = "LCK_LOCATION_PUT")]
        LCK_LOCATION_PUT,

        [EnumMember(Value = "LCK_LOCATION_READER_POST")]
        LCK_LOCATION_READER_POST,

        [EnumMember(Value = "NFS_LOCATION_PUT")]
        NFS_LOCATION_PUT,

        [EnumMember(Value = "NFS_LOCATION_READER_POST")]
        NFS_LOCATION_READER_POST,

        [EnumMember(Value = "OBJECT_STORE_LOCATION_PUT")]
        OBJECT_STORE_LOCATION_PUT,

        [EnumMember(Value = "OBJECT_STORE_LOCATION_READER_POST")]
        OBJECT_STORE_LOCATION_READER_POST,

        [EnumMember(Value = "QSTAR_LOCATION_PUT")]
        QSTAR_LOCATION_PUT,

        [EnumMember(Value = "QSTAR_LOCATION_READER_POST")]
        QSTAR_LOCATION_READER_POST,

        [EnumMember(Value = "REVOKE_AUTHZ")]
        REVOKE_AUTHZ,

        [EnumMember(Value = "ROLE_CREATION")]
        ROLE_CREATION,

        [EnumMember(Value = "ROLE_DELETION")]
        ROLE_DELETION,

        [EnumMember(Value = "ROLE_UPDATION")]
        ROLE_UPDATION,

        [EnumMember(Value = "S3COMPATIBLE_LOCATION_PUT")]
        S3COMPATIBLE_LOCATION_PUT,

        [EnumMember(Value = "S3COMPATIBLE_LOCATION_READER_POST")]
        S3COMPATIBLE_LOCATION_READER_POST,

        [EnumMember(Value = "SECURITY_SETTING_ADD_KMIP_SERVER")]
        SECURITY_SETTING_ADD_KMIP_SERVER,

        [EnumMember(Value = "SECURITY_SETTING_DELETE_KMIP_SERVER")]
        SECURITY_SETTING_DELETE_KMIP_SERVER,

        [EnumMember(Value = "SECURITY_SETTING_EDIT_KMIP_SERVER")]
        SECURITY_SETTING_EDIT_KMIP_SERVER,

        [EnumMember(Value = "SECURITY_SETTING_EDIT_KMS_KEY_VAULT")]
        SECURITY_SETTING_EDIT_KMS_KEY_VAULT,

        [EnumMember(Value = "SERVICE_ACCOUNT_DELETE")]
        SERVICE_ACCOUNT_DELETE,

        [EnumMember(Value = "SERVICE_ACCOUNT_SYNC")]
        SERVICE_ACCOUNT_SYNC,

        [EnumMember(Value = "UNMANAGED_OBJECT_DELETE_SNAPSHOTS")]
        UNMANAGED_OBJECT_DELETE_SNAPSHOTS,

        [EnumMember(Value = "UNMANAGED_OBJECT_DELETE_SNAPSHOTS_OF_OBJECT")]
        UNMANAGED_OBJECT_DELETE_SNAPSHOTS_OF_OBJECT


    } // enum PendingActionSubGroupTypeEnum

} // namespace RubrikSecurityCloud.Types