// HierarchyObjectTypeEnum.cs
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
    public enum HierarchyObjectTypeEnum
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "ACTIVE_DIRECTORY_FOREST")]
        ACTIVE_DIRECTORY_FOREST,

        [EnumMember(Value = "ATLASSIAN_SITE")]
        ATLASSIAN_SITE,

        [EnumMember(Value = "AWS_NATIVE_S3_BUCKET")]
        AWS_NATIVE_S3_BUCKET,

        [EnumMember(Value = "AZURE_AD_DIRECTORY")]
        AZURE_AD_DIRECTORY,

        [EnumMember(Value = "AZURE_SQL_DATABASE_DB")]
        AZURE_SQL_DATABASE_DB,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_DB")]
        AZURE_SQL_MANAGED_INSTANCE_DB,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT")]
        AZURE_STORAGE_ACCOUNT,

        [EnumMember(Value = "AllSubHierarchyType")]
        ALL_SUB_HIERARCHY_TYPE,

        [EnumMember(Value = "AppBlueprint")]
        APP_BLUEPRINT,

        [EnumMember(Value = "AwsNativeAccount")]
        AWS_NATIVE_ACCOUNT,

        [EnumMember(Value = "AwsNativeEbsVolume")]
        AWS_NATIVE_EBS_VOLUME,

        [EnumMember(Value = "AwsNativeEc2Instance")]
        AWS_NATIVE_EC2_INSTANCE,

        [EnumMember(Value = "AwsNativeRdsInstance")]
        AWS_NATIVE_RDS_INSTANCE,

        [EnumMember(Value = "AzureNativeManagedDisk")]
        AZURE_NATIVE_MANAGED_DISK,

        [EnumMember(Value = "AzureNativeResourceGroup")]
        AZURE_NATIVE_RESOURCE_GROUP,

        [EnumMember(Value = "AzureNativeSubscription")]
        AZURE_NATIVE_SUBSCRIPTION,

        [EnumMember(Value = "AzureNativeVm")]
        AZURE_NATIVE_VM,

        [EnumMember(Value = "AzureSqlDatabaseServer")]
        AZURE_SQL_DATABASE_SERVER,

        [EnumMember(Value = "AzureSqlManagedInstanceServer")]
        AZURE_SQL_MANAGED_INSTANCE_SERVER,

        [EnumMember(Value = "Blueprint")]
        BLUEPRINT,

        [EnumMember(Value = "CASSANDRA_COLUMN_FAMILY")]
        CASSANDRA_COLUMN_FAMILY,

        [EnumMember(Value = "CASSANDRA_KEYSPACE")]
        CASSANDRA_KEYSPACE,

        [EnumMember(Value = "CASSANDRA_SOURCE")]
        CASSANDRA_SOURCE,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

        [EnumMember(Value = "CloudNativeTagRule")]
        CLOUD_NATIVE_TAG_RULE,

        [EnumMember(Value = "Db2Database")]
        DB2_DATABASE,

        [EnumMember(Value = "Db2Instance")]
        DB2_INSTANCE,

        [EnumMember(Value = "EXCHANGE_DAG")]
        EXCHANGE_DAG,

        [EnumMember(Value = "EXCHANGE_SERVER")]
        EXCHANGE_SERVER,

        [EnumMember(Value = "Ec2Instance")]
        EC2_INSTANCE,

        [EnumMember(Value = "ExchangeDatabase")]
        EXCHANGE_DATABASE,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP")]
        FAILOVER_CLUSTER_APP,

        [EnumMember(Value = "FeldsparSite")]
        FELDSPAR_SITE,

        [EnumMember(Value = "Fileset")]
        FILESET,

        [EnumMember(Value = "FilesetTemplate")]
        FILESET_TEMPLATE,

        [EnumMember(Value = "GcpNativeDisk")]
        GCP_NATIVE_DISK,

        [EnumMember(Value = "GcpNativeGCEInstance")]
        GCP_NATIVE_GCE_INSTANCE,

        [EnumMember(Value = "GcpNativeProject")]
        GCP_NATIVE_PROJECT,

        [EnumMember(Value = "HOST_FAILOVER_CLUSTER")]
        HOST_FAILOVER_CLUSTER,

        [EnumMember(Value = "Hdfs")]
        HDFS,

        [EnumMember(Value = "HostShare")]
        HOST_SHARE,

        [EnumMember(Value = "HypervCluster")]
        HYPERV_CLUSTER,

        [EnumMember(Value = "HypervSCVMM")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HypervServer")]
        HYPERV_SERVER,

        [EnumMember(Value = "HypervVirtualMachine")]
        HYPERV_VIRTUAL_MACHINE,

        [EnumMember(Value = "JIRA_FIXED_OBJECT")]
        JIRA_FIXED_OBJECT,

        [EnumMember(Value = "JIRA_PROJECT")]
        JIRA_PROJECT,

        [EnumMember(Value = "K8S_CLUSTER")]
        K8S_CLUSTER,

        [EnumMember(Value = "K8S_PROTECTION_SET")]
        K8S_PROTECTION_SET,

        [EnumMember(Value = "KuprCluster")]
        KUPR_CLUSTER,

        [EnumMember(Value = "KuprNamespace")]
        KUPR_NAMESPACE,

        [EnumMember(Value = "LinuxFileset")]
        LINUX_FILESET,

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

        [EnumMember(Value = "ManagedVolume")]
        MANAGED_VOLUME,

        [EnumMember(Value = "Mssql")]
        MSSQL,

        [EnumMember(Value = "MssqlAvailabilityGroup")]
        MSSQL_AVAILABILITY_GROUP,

        [EnumMember(Value = "MssqlDatabaseBatchMaintenance")]
        MSSQL_DATABASE_BATCH_MAINTENANCE,

        [EnumMember(Value = "MssqlInstance")]
        MSSQL_INSTANCE,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NUTANIX_CATEGORY")]
        NUTANIX_CATEGORY,

        [EnumMember(Value = "NUTANIX_CATEGORY_VALUE")]
        NUTANIX_CATEGORY_VALUE,

        [EnumMember(Value = "NUTANIX_ERA")]
        NUTANIX_ERA,

        [EnumMember(Value = "NUTANIX_PRISM_CENTRAL")]
        NUTANIX_PRISM_CENTRAL,

        [EnumMember(Value = "NasNamespace")]
        NAS_NAMESPACE,

        [EnumMember(Value = "NasShare")]
        NAS_SHARE,

        [EnumMember(Value = "NasSystem")]
        NAS_SYSTEM,

        [EnumMember(Value = "NasVolume")]
        NAS_VOLUME,

        [EnumMember(Value = "NutanixCluster")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "NutanixVirtualMachine")]
        NUTANIX_VIRTUAL_MACHINE,

        [EnumMember(Value = "O365Calendar")]
        O365_CALENDAR,

        [EnumMember(Value = "O365File")]
        O365_FILE,

        [EnumMember(Value = "O365Group")]
        O365_GROUP,

        [EnumMember(Value = "O365Mailbox")]
        O365_MAILBOX,

        [EnumMember(Value = "O365Onedrive")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365Org")]
        O365_ORG,

        [EnumMember(Value = "O365SharePointDrive")]
        O365_SHARE_POINT_DRIVE,

        [EnumMember(Value = "O365SharePointList")]
        O365_SHARE_POINT_LIST,

        [EnumMember(Value = "O365Site")]
        O365_SITE,

        [EnumMember(Value = "O365Teams")]
        O365_TEAMS,

        [EnumMember(Value = "O365User")]
        O365_USER,

        [EnumMember(Value = "ORACLE_DATA_GUARD_GROUP")]
        ORACLE_DATA_GUARD_GROUP,

        [EnumMember(Value = "ORCHESTRATED_APPLICATION_RECOVERY_BLUEPRINT")]
        ORCHESTRATED_APPLICATION_RECOVERY_BLUEPRINT,

        [EnumMember(Value = "ORCHESTRATED_APPLICATION_RECOVERY_PLAN")]
        ORCHESTRATED_APPLICATION_RECOVERY_PLAN,

        [EnumMember(Value = "OracleDatabase")]
        ORACLE_DATABASE,

        [EnumMember(Value = "OracleHost")]
        ORACLE_HOST,

        [EnumMember(Value = "OracleRac")]
        ORACLE_RAC,

        [EnumMember(Value = "POSTGRES_DATABASE")]
        POSTGRES_DATABASE,

        [EnumMember(Value = "POSTGRES_DB_CLUSTER")]
        POSTGRES_DB_CLUSTER,

        [EnumMember(Value = "PhysicalHost")]
        PHYSICAL_HOST,

        [EnumMember(Value = "RubrikEbsVolume")]
        RUBRIK_EBS_VOLUME,

        [EnumMember(Value = "RubrikEc2Instance")]
        RUBRIK_EC2_INSTANCE,

        [EnumMember(Value = "SALESFORCE_FIXED_OBJECT")]
        SALESFORCE_FIXED_OBJECT,

        [EnumMember(Value = "SALESFORCE_OBJECT")]
        SALESFORCE_OBJECT,

        [EnumMember(Value = "SALESFORCE_ORGANIZATION")]
        SALESFORCE_ORGANIZATION,

        [EnumMember(Value = "SAP_HANA_SYSTEM")]
        SAP_HANA_SYSTEM,

        [EnumMember(Value = "SapHanaDatabase")]
        SAP_HANA_DATABASE,

        [EnumMember(Value = "ShareFileset")]
        SHARE_FILESET,

        [EnumMember(Value = "SnapMirrorCloud")]
        SNAP_MIRROR_CLOUD,

        [EnumMember(Value = "StorageArrayVolumeGroup")]
        STORAGE_ARRAY_VOLUME_GROUP,

        [EnumMember(Value = "VSPHERE_CONTENT_LIBRARY")]
        VSPHERE_CONTENT_LIBRARY,

        [EnumMember(Value = "VSPHERE_DATACENTER_FOLDER")]
        VSPHERE_DATACENTER_FOLDER,

        [EnumMember(Value = "VSPHERE_DATASTORE_CLUSTER")]
        VSPHERE_DATASTORE_CLUSTER,

        [EnumMember(Value = "VSPHERE_VIRTUAL_DISK")]
        VSPHERE_VIRTUAL_DISK,

        [EnumMember(Value = "VSphereComputeCluster")]
        VSPHERE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VSphereDatacenter")]
        VSPHERE_DATACENTER,

        [EnumMember(Value = "VSphereDatastore")]
        VSPHERE_DATASTORE,

        [EnumMember(Value = "VSphereFolder")]
        VSPHERE_FOLDER,

        [EnumMember(Value = "VSphereHost")]
        VSPHERE_HOST,

        [EnumMember(Value = "VSphereNetwork")]
        VSPHERE_NETWORK,

        [EnumMember(Value = "VSphereResourcePool")]
        VSPHERE_RESOURCE_POOL,

        [EnumMember(Value = "VSphereTag")]
        VSPHERE_TAG,

        [EnumMember(Value = "VSphereTagCategory")]
        VSPHERE_TAG_CATEGORY,

        [EnumMember(Value = "VSphereVCenter")]
        VSPHERE_VCENTER,

        [EnumMember(Value = "Vcd")]
        VCD,

        [EnumMember(Value = "VcdCatalog")]
        VCD_CATALOG,

        [EnumMember(Value = "VcdOrg")]
        VCD_ORG,

        [EnumMember(Value = "VcdOrgVdc")]
        VCD_ORG_VDC,

        [EnumMember(Value = "VcdVapp")]
        VCD_VAPP,

        [EnumMember(Value = "VcdVimServer")]
        VCD_VIM_SERVER,

        [EnumMember(Value = "VmwareVirtualMachine")]
        VMWARE_VIRTUAL_MACHINE,

        [EnumMember(Value = "VolumeGroup")]
        VOLUME_GROUP,

        [EnumMember(Value = "WindowsCluster")]
        WINDOWS_CLUSTER,

        [EnumMember(Value = "WindowsFileset")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WindowsVolumeGroup")]
        WINDOWS_VOLUME_GROUP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HierarchyObjectTypeEnum

} // namespace RubrikSecurityCloud.Types