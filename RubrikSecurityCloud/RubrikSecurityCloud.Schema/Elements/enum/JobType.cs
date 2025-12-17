// JobType.cs
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
    public enum JobType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOWNLOAD_SNAPSHOT_FROM_LOCATION")]
        ACTIVE_DIRECTORY_DOWNLOAD_SNAPSHOT_FROM_LOCATION,

        [EnumMember(Value = "ACTIVE_DIRECTORY_LIVE_MOUNT_POLLER")]
        ACTIVE_DIRECTORY_LIVE_MOUNT_POLLER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_REFRESH_DOMAIN")]
        ACTIVE_DIRECTORY_REFRESH_DOMAIN,

        [EnumMember(Value = "ADD_MANAGED_VOLUME")]
        ADD_MANAGED_VOLUME,

        [EnumMember(Value = "ADD_MONGO_SOURCE")]
        ADD_MONGO_SOURCE,

        [EnumMember(Value = "ADD_OR_REMOVE_OPENSTACK_ENVIRONMENT")]
        ADD_OR_REMOVE_OPENSTACK_ENVIRONMENT,

        [EnumMember(Value = "ADD_OR_REMOVE_VCENTER")]
        ADD_OR_REMOVE_VCENTER,

        [EnumMember(Value = "ADD_REMOVE_OR_REFRESH_VCD")]
        ADD_REMOVE_OR_REFRESH_VCD,

        [EnumMember(Value = "ADD_REMOVE_SCVMM")]
        ADD_REMOVE_SCVMM,

        [EnumMember(Value = "ARCHIVAL_LOCATION")]
        ARCHIVAL_LOCATION,

        [EnumMember(Value = "ASSIGN_SLA_MONGO_COLLECTION")]
        ASSIGN_SLA_MONGO_COLLECTION,

        [EnumMember(Value = "BEGIN_MANAGED_VOLUME_SNAPSHOT")]
        BEGIN_MANAGED_VOLUME_SNAPSHOT,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_SYSTEM_CRUD")]
        CLOUD_DIRECT_NAS_SYSTEM_CRUD,

        [EnumMember(Value = "CLUSTER_WEB_CERT")]
        CLUSTER_WEB_CERT,

        [EnumMember(Value = "CONFIGURE_MANAGED_VOLUME_LOG_EXPORT")]
        CONFIGURE_MANAGED_VOLUME_LOG_EXPORT,

        [EnumMember(Value = "DARE_OPERATION_POLLER")]
        DARE_OPERATION_POLLER,

        [EnumMember(Value = "DB2_DATABASE")]
        DB2_DATABASE,

        [EnumMember(Value = "DB2_INSTANCE")]
        DB2_INSTANCE,

        [EnumMember(Value = "DELETE_MONGO_SOURCE")]
        DELETE_MONGO_SOURCE,

        [EnumMember(Value = "DELETE_MOSAIC_SOURCE")]
        DELETE_MOSAIC_SOURCE,

        [EnumMember(Value = "DELETE_MOSAIC_STORAGE_LOCATION")]
        DELETE_MOSAIC_STORAGE_LOCATION,

        [EnumMember(Value = "DISCOVERED_MSSQL_OBJECTS_NOTIFICATIONS_POLLER")]
        DISCOVERED_MSSQL_OBJECTS_NOTIFICATIONS_POLLER,

        [EnumMember(Value = "DISCOVERED_MSSQL_OBJECTS_SYNC_METRIC_POLLER")]
        DISCOVERED_MSSQL_OBJECTS_SYNC_METRIC_POLLER,

        [EnumMember(Value = "DISCOVERED_ORACLE_OBJECTS_SYNC_METRIC_POLLER")]
        DISCOVERED_ORACLE_OBJECTS_SYNC_METRIC_POLLER,

        [EnumMember(Value = "DOWNLOAD_SNAPSHOT_FILES")]
        DOWNLOAD_SNAPSHOT_FILES,

        [EnumMember(Value = "DOWNLOAD_SNAPSHOT_FROM_LOCATION")]
        DOWNLOAD_SNAPSHOT_FROM_LOCATION,

        [EnumMember(Value = "END_MANAGED_VOLUME_SNAPSHOT")]
        END_MANAGED_VOLUME_SNAPSHOT,

        [EnumMember(Value = "EXCHANGE_MOUNT")]
        EXCHANGE_MOUNT,

        [EnumMember(Value = "EXCHANGE_UNMOUNT")]
        EXCHANGE_UNMOUNT,

        [EnumMember(Value = "EXPORT_MANAGED_VOLUME_SNAPSHOT")]
        EXPORT_MANAGED_VOLUME_SNAPSHOT,

        [EnumMember(Value = "EXPORT_ORACLE")]
        EXPORT_ORACLE,

        [EnumMember(Value = "EXPORT_VCD_VAPP_SNAPSHOT")]
        EXPORT_VCD_VAPP_SNAPSHOT,

        [EnumMember(Value = "HOST_BULK_REGISTER_ASYNC")]
        HOST_BULK_REGISTER_ASYNC,

        [EnumMember(Value = "HOST_MAKE_PRIMARY_POLLER")]
        HOST_MAKE_PRIMARY_POLLER,

        [EnumMember(Value = "HYPERV_LIVE_MOUNT")]
        HYPERV_LIVE_MOUNT,

        [EnumMember(Value = "HYPERV_SERVER")]
        HYPERV_SERVER,

        [EnumMember(Value = "HYPERV_VM_SNAPSHOT")]
        HYPERV_VM_SNAPSHOT,

        [EnumMember(Value = "HYPERV_VM_V1")]
        HYPERV_VM_V1,

        [EnumMember(Value = "INFORMIX_INSTANCE")]
        INFORMIX_INSTANCE,

        [EnumMember(Value = "INSTANT_RECOVER_VCD_VAPP")]
        INSTANT_RECOVER_VCD_VAPP,

        [EnumMember(Value = "K8S_CLUSTER_REFRESH")]
        K8S_CLUSTER_REFRESH,

        [EnumMember(Value = "K8S_DOWNLOAD_SNAPSHOT_FROM_LOCATION")]
        K8S_DOWNLOAD_SNAPSHOT_FROM_LOCATION,

        [EnumMember(Value = "K8S_VM_DOWNLOAD_SNAPSHOT_FROM_LOCATION")]
        K8S_VM_DOWNLOAD_SNAPSHOT_FROM_LOCATION,

        [EnumMember(Value = "K8S_VM_MOUNT")]
        K8S_VM_MOUNT,

        [EnumMember(Value = "K8S_VM_UNMOUNT")]
        K8S_VM_UNMOUNT,

        [EnumMember(Value = "KEY_ROTATION")]
        KEY_ROTATION,

        [EnumMember(Value = "KOSMOS_RECOVERY")]
        KOSMOS_RECOVERY,

        [EnumMember(Value = "LIVE_MOUNT_ORACLE")]
        LIVE_MOUNT_ORACLE,

        [EnumMember(Value = "LLM_FUNCTION_CALL")]
        LLM_FUNCTION_CALL,

        [EnumMember(Value = "MOSAIC_SOURCE")]
        MOSAIC_SOURCE,

        [EnumMember(Value = "MOSAIC_STORAGE_LOCATION")]
        MOSAIC_STORAGE_LOCATION,

        [EnumMember(Value = "MSSQL_BULK_EXPORT")]
        MSSQL_BULK_EXPORT,

        [EnumMember(Value = "MSSQL_CREATE_LOG_SHIPPING")]
        MSSQL_CREATE_LOG_SHIPPING,

        [EnumMember(Value = "MSSQL_DELETE_LOG_SHIPPING")]
        MSSQL_DELETE_LOG_SHIPPING,

        [EnumMember(Value = "MSSQL_EXPORT")]
        MSSQL_EXPORT,

        [EnumMember(Value = "MSSQL_LIVE_MOUNT")]
        MSSQL_LIVE_MOUNT,

        [EnumMember(Value = "MSSQL_RESTORE")]
        MSSQL_RESTORE,

        [EnumMember(Value = "MSSQL_SNAPSHOT")]
        MSSQL_SNAPSHOT,

        [EnumMember(Value = "MSSQL_UNMOUNT")]
        MSSQL_UNMOUNT,

        [EnumMember(Value = "MYSQLDB_INSTANCE")]
        MYSQLDB_INSTANCE,

        [EnumMember(Value = "NAS_SYSTEM_CRUD")]
        NAS_SYSTEM_CRUD,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "NUTANIX_CLUSTER_OPS")]
        NUTANIX_CLUSTER_OPS,

        [EnumMember(Value = "NUTANIX_LIVE_MOUNT")]
        NUTANIX_LIVE_MOUNT,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL_OPS")]
        NUTANIX_PRISM_CENTRAL_OPS,

        [EnumMember(Value = "NUTANIX_SNAPSHOT_OPS")]
        NUTANIX_SNAPSHOT_OPS,

        [EnumMember(Value = "NUTANIX_VM_V1")]
        NUTANIX_VM_V1,

        [EnumMember(Value = "PENDING_SLA")]
        PENDING_SLA,

        [EnumMember(Value = "POLARIS_INFO")]
        POLARIS_INFO,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER")]
        POSTGRES_DB_CLUSTER,

        [EnumMember(Value = "RESIZE_MANAGED_VOLUME")]
        RESIZE_MANAGED_VOLUME,

        [EnumMember(Value = "SAP_HANA_DATABASE")]
        SAP_HANA_DATABASE,

        [EnumMember(Value = "SAP_HANA_SYSTEM")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "TAKE_MANAGED_VOLUME_ON_DEMAND_SNAPSHOT")]
        TAKE_MANAGED_VOLUME_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "UNMOUNT_ORACLE")]
        UNMOUNT_ORACLE,

        [EnumMember(Value = "VCENTER_DIAGNOSTIC_REFRESH")]
        VCENTER_DIAGNOSTIC_REFRESH,

        [EnumMember(Value = "VOLUME_GROUP_MOUNT")]
        VOLUME_GROUP_MOUNT,

        [EnumMember(Value = "VOLUME_GROUP_UNMOUNT")]
        VOLUME_GROUP_UNMOUNT,

        [EnumMember(Value = "VSPHERE_EXPORT_VM")]
        VSPHERE_EXPORT_VM,

        [EnumMember(Value = "VSPHERE_LIVE_MOUNT")]
        VSPHERE_LIVE_MOUNT,

        [EnumMember(Value = "VSPHERE_LIVE_MOUNT_RELOCATE")]
        VSPHERE_LIVE_MOUNT_RELOCATE,

        [EnumMember(Value = "VSPHERE_QUERY_MOUNT")]
        VSPHERE_QUERY_MOUNT,

        [EnumMember(Value = "VSPHERE_RESTORE_FILE_TO_VM")]
        VSPHERE_RESTORE_FILE_TO_VM,

        [EnumMember(Value = "VSPHERE_SNAPSHOT")]
        VSPHERE_SNAPSHOT,

        [EnumMember(Value = "VSPHERE_UNMOUNT")]
        VSPHERE_UNMOUNT,

        [EnumMember(Value = "VSPHERE_VM_MAKE_PRIMARY")]
        VSPHERE_VM_MAKE_PRIMARY


    } // enum JobType

} // namespace RubrikSecurityCloud.Types