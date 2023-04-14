// ManagedObjectType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ManagedObjectType
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "APP_BLUEPRINT")]
        APP_BLUEPRINT,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AWS_NATIVE_EBS_VOLUME")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AWS_NATIVE_EC2_INSTANCE")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_RDS_INSTANCE")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_TENANT")]
        AZURE_AD_TENANT,

        [EnumMember(Value = "AZURE_MANAGED_DISK")]
        AZURE_MANAGED_DISK,

        [EnumMember(Value = "AZURE_RESOURCE_GROUP")]
        AZURE_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_RESOURCE_GROUP_FOR_DISK_HIERARCHY")]
        AZURE_RESOURCE_GROUP_FOR_DISK_HIERARCHY,

        [EnumMember(Value = "AZURE_RESOURCE_GROUP_FOR_VM_HIERARCHY")]
        AZURE_RESOURCE_GROUP_FOR_VM_HIERARCHY,

        [EnumMember(Value = "AZURE_SQL_DATABASE_DB")]
        AZURE_SQL_DATABASE_DB,

        [EnumMember(Value = "AZURE_SQL_DATABASE_SERVER")]
        AZURE_SQL_DATABASE_SERVER,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_DB")]
        AZURE_SQL_MANAGED_INSTANCE_DB,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_SERVER")]
        AZURE_SQL_MANAGED_INSTANCE_SERVER,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "AZURE_SUBSCRIPTION")]
        AZURE_SUBSCRIPTION,

        [EnumMember(Value = "AZURE_UNMANAGED_DISK")]
        AZURE_UNMANAGED_DISK,

        [EnumMember(Value = "AZURE_VIRTUAL_MACHINE")]
        AZURE_VIRTUAL_MACHINE,

        [EnumMember(Value = "BLUEPRINT")]
        BLUEPRINT,

        [EnumMember(Value = "CASSANDRA_COLUMN_FAMILY")]
        CASSANDRA_COLUMN_FAMILY,

        [EnumMember(Value = "CASSANDRA_KEYSPACE")]
        CASSANDRA_KEYSPACE,

        [EnumMember(Value = "CASSANDRA_SOURCE")]
        CASSANDRA_SOURCE,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

        [EnumMember(Value = "CLOUD_NATIVE_TAG_RULE")]
        CLOUD_NATIVE_TAG_RULE,

        [EnumMember(Value = "DB2_DATABASE")]
        DB2_DATABASE,

        [EnumMember(Value = "DB2_INSTANCE")]
        DB2_INSTANCE,

        [EnumMember(Value = "EXCHANGE_DAG")]
        EXCHANGE_DAG,

        [EnumMember(Value = "EXCHANGE_DATABASE")]
        EXCHANGE_DATABASE,

        [EnumMember(Value = "EXCHANGE_SERVER")]
        EXCHANGE_SERVER,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "FELDSPAR_SITE")]
        FELDSPAR_SITE,

        [EnumMember(Value = "FILESET_TEMPLATE")]
        FILESET_TEMPLATE,

        [EnumMember(Value = "GCP_NATIVE_DISK")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GCP_NATIVE_GCE_INSTANCE")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GCP_NATIVE_PROJECT")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "HOST_FAILOVER_CLUSTER")]
        HOST_FAILOVER_CLUSTER,

        [EnumMember(Value = "HOST_SHARE")]
        HOST_SHARE,

        [EnumMember(Value = "HYPERV_CLUSTER")]
        HYPERV_CLUSTER,

        [EnumMember(Value = "HYPERV_SCVMM")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HYPERV_SERVER")]
        HYPERV_SERVER,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE")]
        HYPERV_VIRTUAL_MACHINE,

        [EnumMember(Value = "KUPR_CLUSTER")]
        KUPR_CLUSTER,

        [EnumMember(Value = "KUPR_NAMESPACE")]
        KUPR_NAMESPACE,

        [EnumMember(Value = "LINUX_FILESET")]
        LINUX_FILESET,

        [EnumMember(Value = "MANAGED_VOLUME")]
        MANAGED_VOLUME,

        [EnumMember(Value = "MANAGED_VOLUME_EXPORT")]
        MANAGED_VOLUME_EXPORT,

        [EnumMember(Value = "MONGODB_COLLECTION")]
        MONGODB_COLLECTION,

        [EnumMember(Value = "MONGODB_DATABASE")]
        MONGODB_DATABASE,

        [EnumMember(Value = "MONGODB_SOURCE")]
        MONGODB_SOURCE,

        [EnumMember(Value = "MONGO_COLLECTION")]
        MONGO_COLLECTION,

        [EnumMember(Value = "MONGO_COLLECTION_SET")]
        MONGO_COLLECTION_SET,

        [EnumMember(Value = "MONGO_DATABASE")]
        MONGO_DATABASE,

        [EnumMember(Value = "MONGO_DB")]
        MONGO_DB,

        [EnumMember(Value = "MONGO_SOURCE")]
        MONGO_SOURCE,

        [EnumMember(Value = "MSSQL_AVAILABILITY_GROUP")]
        MSSQL_AVAILABILITY_GROUP,

        [EnumMember(Value = "MSSQL_DAG")]
        MSSQL_DAG,

        [EnumMember(Value = "MSSQL_DATABASE")]
        MSSQL_DATABASE,

        [EnumMember(Value = "MSSQL_INSTANCE")]
        MSSQL_INSTANCE,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NAS_NAMESPACE")]
        NAS_NAMESPACE,

        [EnumMember(Value = "NAS_SHARE")]
        NAS_SHARE,

        [EnumMember(Value = "NAS_SYSTEM")]
        NAS_SYSTEM,

        [EnumMember(Value = "NAS_VOLUME")]
        NAS_VOLUME,

        [EnumMember(Value = "NUTANIX_CLUSTER")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "NUTANIX_VIRTUAL_MACHINE")]
        NUTANIX_VIRTUAL_MACHINE,

        [EnumMember(Value = "O365_CALENDAR")]
        O365_CALENDAR,

        [EnumMember(Value = "O365_GROUP")]
        O365_GROUP,

        [EnumMember(Value = "O365_INDIVIDUAL_MAILBOX")]
        O365_INDIVIDUAL_MAILBOX,

        [EnumMember(Value = "O365_INDIVIDUAL_USER")]
        O365_INDIVIDUAL_USER,

        [EnumMember(Value = "O365_MAILBOX")]
        O365_MAILBOX,

        [EnumMember(Value = "O365_ONEDRIVE")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365_ORGANIZATION")]
        O365_ORGANIZATION,

        [EnumMember(Value = "O365_SHARED_MAILBOX")]
        O365_SHARED_MAILBOX,

        [EnumMember(Value = "O365_SHARED_USER")]
        O365_SHARED_USER,

        [EnumMember(Value = "O365_SHAREPOINT_DRIVE")]
        O365_SHAREPOINT_DRIVE,

        [EnumMember(Value = "O365_SHAREPOINT_LIST")]
        O365_SHAREPOINT_LIST,

        [EnumMember(Value = "O365_SITE")]
        O365_SITE,

        [EnumMember(Value = "O365_TEAMS")]
        O365_TEAMS,

        [EnumMember(Value = "O365_USER")]
        O365_USER,

        [EnumMember(Value = "ORACLE_DATABASE")]
        ORACLE_DATABASE,

        [EnumMember(Value = "ORACLE_DATA_GUARD_GROUP")]
        ORACLE_DATA_GUARD_GROUP,

        [EnumMember(Value = "ORACLE_HOST")]
        ORACLE_HOST,

        [EnumMember(Value = "ORACLE_RAC")]
        ORACLE_RAC,

        [EnumMember(Value = "PHYSICAL_HOST")]
        PHYSICAL_HOST,

        [EnumMember(Value = "RECOVERY_PLAN")]
        RECOVERY_PLAN,

        [EnumMember(Value = "SAP_HANA_DATABASE")]
        SAP_HANA_DATABASE,

        [EnumMember(Value = "SAP_HANA_SYSTEM")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "SHARE_FILESET")]
        SHARE_FILESET,

        [EnumMember(Value = "SNAPMIRROR_CLOUD")]
        SNAPMIRROR_CLOUD,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "VCD")]
        VCD,

        [EnumMember(Value = "VCD_CATALOG")]
        VCD_CATALOG,

        [EnumMember(Value = "VCD_ORG")]
        VCD_ORG,

        [EnumMember(Value = "VCD_ORG_VDC")]
        VCD_ORG_VDC,

        [EnumMember(Value = "VCD_VAPP")]
        VCD_VAPP,

        [EnumMember(Value = "VCD_VIM_SERVER")]
        VCD_VIM_SERVER,

        [EnumMember(Value = "VOLUME_GROUP")]
        VOLUME_GROUP,

        [EnumMember(Value = "VSPHERE_COMPUTE_CLUSTER")]
        VSPHERE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VSPHERE_DATACENTER")]
        VSPHERE_DATACENTER,

        [EnumMember(Value = "VSPHERE_DATASTORE")]
        VSPHERE_DATASTORE,

        [EnumMember(Value = "VSPHERE_DATASTORE_CLUSTER")]
        VSPHERE_DATASTORE_CLUSTER,

        [EnumMember(Value = "VSPHERE_FOLDER")]
        VSPHERE_FOLDER,

        [EnumMember(Value = "VSPHERE_HOST")]
        VSPHERE_HOST,

        [EnumMember(Value = "VSPHERE_NETWORK")]
        VSPHERE_NETWORK,

        [EnumMember(Value = "VSPHERE_RESOURCE_POOL")]
        VSPHERE_RESOURCE_POOL,

        [EnumMember(Value = "VSPHERE_TAG")]
        VSPHERE_TAG,

        [EnumMember(Value = "VSPHERE_TAG_CATEGORY")]
        VSPHERE_TAG_CATEGORY,

        [EnumMember(Value = "VSPHERE_VCENTER")]
        VSPHERE_VCENTER,

        [EnumMember(Value = "VSPHERE_VIRTUAL_DISK")]
        VSPHERE_VIRTUAL_DISK,

        [EnumMember(Value = "VSPHERE_VIRTUAL_MACHINE")]
        VSPHERE_VIRTUAL_MACHINE,

        [EnumMember(Value = "WINDOWS_CLUSTER")]
        WINDOWS_CLUSTER,

        [EnumMember(Value = "WINDOWS_FILESET")]
        WINDOWS_FILESET


    } // enum ManagedObjectType

} // namespace Rubrik.SecurityCloud.Types