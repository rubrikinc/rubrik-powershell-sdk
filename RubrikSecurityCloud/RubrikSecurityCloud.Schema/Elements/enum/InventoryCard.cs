// InventoryCard.cs
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
    public enum InventoryCard
    {
        [EnumMember(Value = "AHV_VMS_CDM")]
        AHV_VMS_CDM,

        [EnumMember(Value = "ATLASSIAN")]
        ATLASSIAN,

        [EnumMember(Value = "AWS_EC2")]
        AWS_EC2,

        [EnumMember(Value = "AWS_RDS")]
        AWS_RDS,

        [EnumMember(Value = "AWS_S3")]
        AWS_S3,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "AZURE_AD")]
        AZURE_AD,

        [EnumMember(Value = "AZURE_BLOB_STORAGE")]
        AZURE_BLOB_STORAGE,

        [EnumMember(Value = "AZURE_SQL_DB")]
        AZURE_SQL_DB,

        [EnumMember(Value = "AZURE_SQL_MI")]
        AZURE_SQL_MI,

        [EnumMember(Value = "CASSANDRA")]
        CASSANDRA,

        [EnumMember(Value = "DB2")]
        DB2,

        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,

        [EnumMember(Value = "GCP")]
        GCP,

        [EnumMember(Value = "HYPERV")]
        HYPERV,

        [EnumMember(Value = "HYPERV_VMS_CDM")]
        HYPERV_VMS_CDM,

        [EnumMember(Value = "KUBERNETES")]
        KUBERNETES,

        [EnumMember(Value = "KUBERNETES_V2")]
        KUBERNETES_V2,

        [EnumMember(Value = "LINUX_UNIX_FILESETS")]
        LINUX_UNIX_FILESETS,

        [EnumMember(Value = "LINUX_UNIX_HOSTS_CDM")]
        LINUX_UNIX_HOSTS_CDM,

        [EnumMember(Value = "M365_BACKUP_STORAGE")]
        M365_BACKUP_STORAGE,

        [EnumMember(Value = "MANAGED_VOLUMES")]
        MANAGED_VOLUMES,

        [EnumMember(Value = "MANAGED_VOLUMES_CDM")]
        MANAGED_VOLUMES_CDM,

        [EnumMember(Value = "MICROSOFT_365")]
        MICROSOFT_365,

        [EnumMember(Value = "MONGO")]
        MONGO,

        [EnumMember(Value = "MONGODB")]
        MONGODB,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "MYSQL")]
        MYSQL,

        [EnumMember(Value = "NAS_SHARES")]
        NAS_SHARES,

        [EnumMember(Value = "NAS_SHARES_CDM")]
        NAS_SHARES_CDM,

        [EnumMember(Value = "NUTANIX_AHV")]
        NUTANIX_AHV,

        [EnumMember(Value = "ON_PREM_AD")]
        ON_PREM_AD,

        [EnumMember(Value = "ORACLE")]
        ORACLE,

        [EnumMember(Value = "ORACLE_DBS_CDM")]
        ORACLE_DBS_CDM,

        [EnumMember(Value = "POSTGRESQL")]
        POSTGRESQL,

        [EnumMember(Value = "SALESFORCE")]
        SALESFORCE,

        [EnumMember(Value = "SAP_HANA")]
        SAP_HANA,

        [EnumMember(Value = "SNAPMIRROR")]
        SNAPMIRROR,

        [EnumMember(Value = "SQL_SERVER_DBS_CDM")]
        SQL_SERVER_DBS_CDM,

        [EnumMember(Value = "VCD_VAPPS")]
        VCD_VAPPS,

        [EnumMember(Value = "VCD_VAPPS_CDM")]
        VCD_VAPPS_CDM,

        [EnumMember(Value = "VSPHERE")]
        VSPHERE,

        [EnumMember(Value = "VSPHERE_VMS_CDM")]
        VSPHERE_VMS_CDM,

        [EnumMember(Value = "WINDOWS_FILESETS")]
        WINDOWS_FILESETS,

        [EnumMember(Value = "WINDOWS_HOSTS_CDM")]
        WINDOWS_HOSTS_CDM,

        [EnumMember(Value = "WINDOWS_VOLUME_GROUP")]
        WINDOWS_VOLUME_GROUP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InventoryCard

} // namespace RubrikSecurityCloud.Types