// CdmFeatureFlagType.cs
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
    public enum CdmFeatureFlagType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AHV_BULK_TAKE_ON_DEMAND_SNAPSHOT")]
        AHV_BULK_TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "AHV_CHANGE_RETENTION")]
        AHV_CHANGE_RETENTION,

        [EnumMember(Value = "AHV_DELETE_SNAPSHOTS")]
        AHV_DELETE_SNAPSHOTS,

        [EnumMember(Value = "AHV_LEGAL_HOLD_ALL_ACTIONS")]
        AHV_LEGAL_HOLD_ALL_ACTIONS,

        [EnumMember(Value = "AHV_LIVEMOUNT_ALL_ACTIONS")]
        AHV_LIVEMOUNT_ALL_ACTIONS,

        [EnumMember(Value = "AHV_MANAGE_PROTECTION")]
        AHV_MANAGE_PROTECTION,

        [EnumMember(Value = "AHV_NETWORK_RESTORE")]
        AHV_NETWORK_RESTORE,

        [EnumMember(Value = "AHV_RADAR_RECOVERY")]
        AHV_RADAR_RECOVERY,

        [EnumMember(Value = "AHV_RECOVER_SNAPSHOTS")]
        AHV_RECOVER_SNAPSHOTS,

        [EnumMember(Value = "AHV_TAKE_ON_DEMAND_SNAPSHOT")]
        AHV_TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "ARCHIVAL_AWS_BYPASS_PROXY")]
        ARCHIVAL_AWS_BYPASS_PROXY,

        [EnumMember(Value = "ARCHIVAL_AWS_GIR")]
        ARCHIVAL_AWS_GIR,

        [EnumMember(Value = "ARCHIVAL_AWS_IMMUTABLE")]
        ARCHIVAL_AWS_IMMUTABLE,

        [EnumMember(Value = "ARCHIVAL_AWS_JAKARTA")]
        ARCHIVAL_AWS_JAKARTA,

        [EnumMember(Value = "ARCHIVAL_AWS_PRIVATE_ENDPOINT")]
        ARCHIVAL_AWS_PRIVATE_ENDPOINT,

        [EnumMember(Value = "ARCHIVAL_AWS_ZURICH")]
        ARCHIVAL_AWS_ZURICH,

        [EnumMember(Value = "ARCHIVAL_AZURE_BYPASS_PROXY")]
        ARCHIVAL_AZURE_BYPASS_PROXY,

        [EnumMember(Value = "ARCHIVAL_AZURE_HIGH_PRIORITY_REHYDRATION")]
        ARCHIVAL_AZURE_HIGH_PRIORITY_REHYDRATION,

        [EnumMember(Value = "ARCHIVAL_AZURE_IMMUTABLE")]
        ARCHIVAL_AZURE_IMMUTABLE,

        [EnumMember(Value = "ARCHIVAL_CASCADE_LOCATION")]
        ARCHIVAL_CASCADE_LOCATION,

        [EnumMember(Value = "ARCHIVAL_CLOUD_COMPUTE_CONNECTIVITY_CHECK")]
        ARCHIVAL_CLOUD_COMPUTE_CONNECTIVITY_CHECK,

        [EnumMember(Value = "ARCHIVAL_DELL_ECS")]
        ARCHIVAL_DELL_ECS,

        [EnumMember(Value = "ARCHIVAL_IBM_COS")]
        ARCHIVAL_IBM_COS,

        [EnumMember(Value = "ARCHIVAL_MULTIPLE_LOCATION")]
        ARCHIVAL_MULTIPLE_LOCATION,

        [EnumMember(Value = "ARCHIVAL_NETAPP_SG")]
        ARCHIVAL_NETAPP_SG,

        [EnumMember(Value = "ARCHIVAL_QSTAR")]
        ARCHIVAL_QSTAR,

        [EnumMember(Value = "ASSIGN_SLA_FOR_CDM_ARCHIVAL_SNAPSHOT_DOWNLOAD")]
        ASSIGN_SLA_FOR_CDM_ARCHIVAL_SNAPSHOT_DOWNLOAD,

        [EnumMember(Value = "CDM_LOCATION_UPGRADE")]
        CDM_LOCATION_UPGRADE,

        [EnumMember(Value = "DOWNLOAD_REPLICATED_SNAPSHOT")]
        DOWNLOAD_REPLICATED_SNAPSHOT,

        [EnumMember(Value = "HYPERV_BATCH_ON_DEMAND_BACKUP")]
        HYPERV_BATCH_ON_DEMAND_BACKUP,

        [EnumMember(Value = "HYPERV_CHANGE_RETENTION")]
        HYPERV_CHANGE_RETENTION,

        [EnumMember(Value = "HYPERV_DELETE_SNAPSHOTS")]
        HYPERV_DELETE_SNAPSHOTS,

        [EnumMember(Value = "HYPERV_EXCLUDE_VHD")]
        HYPERV_EXCLUDE_VHD,

        [EnumMember(Value = "HYPERV_LEGAL_HOLD_ALL_ACTIONS")]
        HYPERV_LEGAL_HOLD_ALL_ACTIONS,

        [EnumMember(Value = "HYPERV_LIVEMOUNT_ALL_ACTIONS")]
        HYPERV_LIVEMOUNT_ALL_ACTIONS,

        [EnumMember(Value = "HYPERV_MANAGE_PROTECTION")]
        HYPERV_MANAGE_PROTECTION,

        [EnumMember(Value = "HYPERV_RADAR_RECOVERY")]
        HYPERV_RADAR_RECOVERY,

        [EnumMember(Value = "HYPERV_RECOVER_SNAPSHOTS")]
        HYPERV_RECOVER_SNAPSHOTS,

        [EnumMember(Value = "HYPERV_RUBRIK_BACKUP_SERVICE")]
        HYPERV_RUBRIK_BACKUP_SERVICE,

        [EnumMember(Value = "HYPERV_TAKE_ON_DEMAND_SNAPSHOT")]
        HYPERV_TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "MSSQL_ADD_LOG_SHIPPING_SECONDARY")]
        MSSQL_ADD_LOG_SHIPPING_SECONDARY,

        [EnumMember(Value = "MSSQL_CHANGE_RETENTION")]
        MSSQL_CHANGE_RETENTION,

        [EnumMember(Value = "MSSQL_DELETE_HOST")]
        MSSQL_DELETE_HOST,

        [EnumMember(Value = "MSSQL_DELETE_SNAPSHOTS")]
        MSSQL_DELETE_SNAPSHOTS,

        [EnumMember(Value = "MSSQL_EDIT_CBT")]
        MSSQL_EDIT_CBT,

        [EnumMember(Value = "MSSQL_EDIT_HOST")]
        MSSQL_EDIT_HOST,

        [EnumMember(Value = "MSSQL_EDIT_LOG_BACKUP_PROPERTIES")]
        MSSQL_EDIT_LOG_BACKUP_PROPERTIES,

        [EnumMember(Value = "MSSQL_LEGAL_HOLD_ALL_ACTIONS")]
        MSSQL_LEGAL_HOLD_ALL_ACTIONS,

        [EnumMember(Value = "MSSQL_LIVEMOUNT_ALL_ACTIONS")]
        MSSQL_LIVEMOUNT_ALL_ACTIONS,

        [EnumMember(Value = "MSSQL_MANAGE_PROTECTION")]
        MSSQL_MANAGE_PROTECTION,

        [EnumMember(Value = "MSSQL_RECOVER_SNAPSHOTS")]
        MSSQL_RECOVER_SNAPSHOTS,

        [EnumMember(Value = "MSSQL_REFRESH_HOST")]
        MSSQL_REFRESH_HOST,

        [EnumMember(Value = "MSSQL_REMOVE_LOG_SHIPPING")]
        MSSQL_REMOVE_LOG_SHIPPING,

        [EnumMember(Value = "MSSQL_RESEED_LOG_SHIPPING")]
        MSSQL_RESEED_LOG_SHIPPING,

        [EnumMember(Value = "MSSQL_TAKE_ON_DEMAND_SNAPSHOT")]
        MSSQL_TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "MSSQL_TAKE_TLOG_BACKUP")]
        MSSQL_TAKE_TLOG_BACKUP,

        [EnumMember(Value = "MSSQL_UPDATE_HOST")]
        MSSQL_UPDATE_HOST,

        [EnumMember(Value = "MV_LIVEMOUNT_ALL_ACTIONS")]
        MV_LIVEMOUNT_ALL_ACTIONS,

        [EnumMember(Value = "NUTANIX_CONFIGURE_PRE_POST_SCRIPTS")]
        NUTANIX_CONFIGURE_PRE_POST_SCRIPTS,

        [EnumMember(Value = "NUTANIX_EXCLUDE_DISK")]
        NUTANIX_EXCLUDE_DISK,

        [EnumMember(Value = "NUTANIX_RUBRIK_BACKUP_SERVICE")]
        NUTANIX_RUBRIK_BACKUP_SERVICE,

        [EnumMember(Value = "ON_PREM_AD")]
        ON_PREM_AD,

        [EnumMember(Value = "ORACLEDB_CHANGE_RETENTION")]
        ORACLEDB_CHANGE_RETENTION,

        [EnumMember(Value = "ORACLEDB_DELETE_HOST")]
        ORACLEDB_DELETE_HOST,

        [EnumMember(Value = "ORACLEDB_DELETE_SNAPSHOTS")]
        ORACLEDB_DELETE_SNAPSHOTS,

        [EnumMember(Value = "ORACLEDB_EDIT_HOST")]
        ORACLEDB_EDIT_HOST,

        [EnumMember(Value = "ORACLEDB_LEGAL_HOLD_ALL_ACTIONS")]
        ORACLEDB_LEGAL_HOLD_ALL_ACTIONS,

        [EnumMember(Value = "ORACLEDB_LIVEMOUNT_ALL_ACTIONS")]
        ORACLEDB_LIVEMOUNT_ALL_ACTIONS,

        [EnumMember(Value = "ORACLEDB_MANAGE_PROTECTION")]
        ORACLEDB_MANAGE_PROTECTION,

        [EnumMember(Value = "ORACLEDB_RECOVER_SNAPSHOTS")]
        ORACLEDB_RECOVER_SNAPSHOTS,

        [EnumMember(Value = "ORACLEDB_REFRESH_HOST")]
        ORACLEDB_REFRESH_HOST,

        [EnumMember(Value = "ORACLEDB_TAKE_ON_DEMAND_SNAPSHOT")]
        ORACLEDB_TAKE_ON_DEMAND_SNAPSHOT,

        [EnumMember(Value = "ORACLEDB_TAKE_TLOG_BACKUP")]
        ORACLEDB_TAKE_TLOG_BACKUP,

        [EnumMember(Value = "REPLICATION_TARGET_SETUP_UPDATE")]
        REPLICATION_TARGET_SETUP_UPDATE,

        [EnumMember(Value = "SAP_HANA_STATIC_RETENTION")]
        SAP_HANA_STATIC_RETENTION


    } // enum CdmFeatureFlagType

} // namespace RubrikSecurityCloud.Types