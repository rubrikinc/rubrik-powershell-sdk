// HierarchySortByField.cs
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
    public enum HierarchySortByField
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_NAME")]
        ACTIVE_DIRECTORY_DOMAIN_NAME,

        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_NAME")]
        AWS_NATIVE_ACCOUNT_NAME,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_ENGINE")]
        AWS_NATIVE_RDS_DB_ENGINE,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_INSTANCE_CLASS")]
        AWS_NATIVE_RDS_DB_INSTANCE_CLASS,

        [EnumMember(Value = "AWS_REGION")]
        AWS_REGION,

        [EnumMember(Value = "AWS_VPC_ID")]
        AWS_VPC_ID,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_CAPACITY_USED")]
        AZURE_BLOB_STORAGE_ACCOUNT_CAPACITY_USED,

        [EnumMember(Value = "AZURE_BLOB_STORAGE_ACCOUNT_CONTAINER_COUNT")]
        AZURE_BLOB_STORAGE_ACCOUNT_CONTAINER_COUNT,

        [EnumMember(Value = "AZURE_DISK_ATTACHED_VM")]
        AZURE_DISK_ATTACHED_VM,

        [EnumMember(Value = "AZURE_DISK_CRG_NAME")]
        AZURE_DISK_CRG_NAME,

        [EnumMember(Value = "AZURE_DISK_CRG_SUBSCRIPTION_NAME")]
        AZURE_DISK_CRG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_DISK_SIZE")]
        AZURE_DISK_SIZE,

        [EnumMember(Value = "AZURE_DISK_TYPE")]
        AZURE_DISK_TYPE,

        [EnumMember(Value = "AZURE_REGION")]
        AZURE_REGION,

        [EnumMember(Value = "AZURE_RG_DISKCOUNT")]
        AZURE_RG_DISKCOUNT,

        [EnumMember(Value = "AZURE_RG_DISK_EFFECTIVE_SLA")]
        AZURE_RG_DISK_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SQL_DATABASE_DB_EFFECTIVE_SLA")]
        AZURE_RG_SQL_DATABASE_DB_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SQL_MANAGED_INSTANCE_DB_EFFECTIVE_SLA")]
        AZURE_RG_SQL_MANAGED_INSTANCE_DB_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_RG_SUBSCRIPTION_NAME")]
        AZURE_RG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_RG_VMCOUNT")]
        AZURE_RG_VMCOUNT,

        [EnumMember(Value = "AZURE_RG_VM_EFFECTIVE_SLA")]
        AZURE_RG_VM_EFFECTIVE_SLA,

        [EnumMember(Value = "AZURE_SQL_DATABASE_DB_REGION")]
        AZURE_SQL_DATABASE_DB_REGION,

        [EnumMember(Value = "AZURE_SQL_DATABASE_SERVER_REGION")]
        AZURE_SQL_DATABASE_SERVER_REGION,

        [EnumMember(Value = "AZURE_SQL_DB_RESOURCE_GROUP")]
        AZURE_SQL_DB_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_DB_REGION")]
        AZURE_SQL_MANAGED_INSTANCE_DB_REGION,

        [EnumMember(Value = "AZURE_SQL_MANAGED_INSTANCE_SERVER_REGION")]
        AZURE_SQL_MANAGED_INSTANCE_SERVER_REGION,

        [EnumMember(Value = "AZURE_SQL_SERVER_RESOURCE_GROUP")]
        AZURE_SQL_SERVER_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_SUBNET_NAME")]
        AZURE_SUBNET_NAME,

        [EnumMember(Value = "AZURE_SUBSCRIPTION_DISKCOUNT")]
        AZURE_SUBSCRIPTION_DISKCOUNT,

        [EnumMember(Value = "AZURE_SUBSCRIPTION_VMCOUNT")]
        AZURE_SUBSCRIPTION_VMCOUNT,

        [EnumMember(Value = "AZURE_TENANT_ID")]
        AZURE_TENANT_ID,

        [EnumMember(Value = "AZURE_VM_CRG_NAME")]
        AZURE_VM_CRG_NAME,

        [EnumMember(Value = "AZURE_VM_CRG_SUBSCRIPTION_NAME")]
        AZURE_VM_CRG_SUBSCRIPTION_NAME,

        [EnumMember(Value = "AZURE_VM_SIZE")]
        AZURE_VM_SIZE,

        [EnumMember(Value = "AZURE_VNET_NAME")]
        AZURE_VNET_NAME,

        [EnumMember(Value = "CDM_CLUSTER_NAME")]
        CDM_CLUSTER_NAME,

        [EnumMember(Value = "CDP_IO_FILTER_STATUS")]
        CDP_IO_FILTER_STATUS,

        [EnumMember(Value = "CDP_LATEST_SNAPSHOT_TIME")]
        CDP_LATEST_SNAPSHOT_TIME,

        [EnumMember(Value = "CDP_LOCAL_STATUS")]
        CDP_LOCAL_STATUS,

        [EnumMember(Value = "CDP_REPLICATION_CLUSTER_NAME")]
        CDP_REPLICATION_CLUSTER_NAME,

        [EnumMember(Value = "CDP_REPLICATION_STATUS")]
        CDP_REPLICATION_STATUS,

        [EnumMember(Value = "CDP_VM_CLUSTER_NAME")]
        CDP_VM_CLUSTER_NAME,

        [EnumMember(Value = "CDP_VM_EFFECTIVE_SLA_NAME")]
        CDP_VM_EFFECTIVE_SLA_NAME,

        [EnumMember(Value = "CDP_VM_NAME")]
        CDP_VM_NAME,

        [EnumMember(Value = "CDP_VM_VCENTER_LOCATION")]
        CDP_VM_VCENTER_LOCATION,

        [EnumMember(Value = "DB2_INSTANCE_ID")]
        DB2_INSTANCE_ID,

        [EnumMember(Value = "EBS_VOLUME_COUNT")]
        EBS_VOLUME_COUNT,

        [EnumMember(Value = "EBS_VOLUME_ID")]
        EBS_VOLUME_ID,

        [EnumMember(Value = "EBS_VOLUME_NAME")]
        EBS_VOLUME_NAME,

        [EnumMember(Value = "EBS_VOLUME_SIZE")]
        EBS_VOLUME_SIZE,

        [EnumMember(Value = "EBS_VOLUME_TYPE")]
        EBS_VOLUME_TYPE,

        [EnumMember(Value = "EC2_INSTANCE_COUNT")]
        EC2_INSTANCE_COUNT,

        [EnumMember(Value = "EC2_INSTANCE_ID")]
        EC2_INSTANCE_ID,

        [EnumMember(Value = "EC2_INSTANCE_NAME")]
        EC2_INSTANCE_NAME,

        [EnumMember(Value = "EC2_INSTANCE_TYPE")]
        EC2_INSTANCE_TYPE,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "EFFECTIVE_SLA_FREQUENCY")]
        EFFECTIVE_SLA_FREQUENCY,

        [EnumMember(Value = "EFFECTIVE_SLA_MAX_RETENTION")]
        EFFECTIVE_SLA_MAX_RETENTION,

        [EnumMember(Value = "EMAIL_ADDRESS")]
        EMAIL_ADDRESS,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_CONNECTION_STATUS")]
        FAILOVER_CLUSTER_APP_CONNECTION_STATUS,

        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS")]
        FAILOVER_CLUSTER_CONNECTION_STATUS,

        [EnumMember(Value = "FILESET_TEMPLATE_DOES_NOT_EXCLUDE")]
        FILESET_TEMPLATE_DOES_NOT_EXCLUDE,

        [EnumMember(Value = "FILESET_TEMPLATE_EXCLUDES")]
        FILESET_TEMPLATE_EXCLUDES,

        [EnumMember(Value = "FILESET_TEMPLATE_INCLUDES")]
        FILESET_TEMPLATE_INCLUDES,

        [EnumMember(Value = "GCP_DISK_LOCATION")]
        GCP_DISK_LOCATION,

        [EnumMember(Value = "GCP_DISK_NATIVE_ID")]
        GCP_DISK_NATIVE_ID,

        [EnumMember(Value = "GCP_DISK_NATIVE_NAME")]
        GCP_DISK_NATIVE_NAME,

        [EnumMember(Value = "GCP_DISK_PROJECT_NAME")]
        GCP_DISK_PROJECT_NAME,

        [EnumMember(Value = "GCP_DISK_SIZE")]
        GCP_DISK_SIZE,

        [EnumMember(Value = "GCP_INSTANCE_NATIVE_ID")]
        GCP_INSTANCE_NATIVE_ID,

        [EnumMember(Value = "GCP_INSTANCE_NATIVE_NAME")]
        GCP_INSTANCE_NATIVE_NAME,

        [EnumMember(Value = "GCP_INSTANCE_NETWORK_NAME")]
        GCP_INSTANCE_NETWORK_NAME,

        [EnumMember(Value = "GCP_INSTANCE_PROJECT_NAME")]
        GCP_INSTANCE_PROJECT_NAME,

        [EnumMember(Value = "GCP_INSTANCE_REGION")]
        GCP_INSTANCE_REGION,

        [EnumMember(Value = "GCP_INSTANCE_TYPE")]
        GCP_INSTANCE_TYPE,

        [EnumMember(Value = "GCP_PROJECT_DISK_COUNT")]
        GCP_PROJECT_DISK_COUNT,

        [EnumMember(Value = "GCP_PROJECT_INSTANCE_COUNT")]
        GCP_PROJECT_INSTANCE_COUNT,

        [EnumMember(Value = "GCP_PROJECT_NATIVE_ID")]
        GCP_PROJECT_NATIVE_ID,

        [EnumMember(Value = "GCP_PROJECT_NUMBER")]
        GCP_PROJECT_NUMBER,

        [EnumMember(Value = "GCP_PROJECT_ORG_NAME")]
        GCP_PROJECT_ORG_NAME,

        [EnumMember(Value = "ID")]
        ID,

        [EnumMember(Value = "K8S_CLUSTER_NAME")]
        K8S_CLUSTER_NAME,

        [EnumMember(Value = "MSSQL_AVAILABILITY_GROUP_COPY_ONLY")]
        MSSQL_AVAILABILITY_GROUP_COPY_ONLY,

        [EnumMember(Value = "MSSQL_DATABASE_COPY_ONLY")]
        MSSQL_DATABASE_COPY_ONLY,

        [EnumMember(Value = "MSSQL_FAILOVER_DATABASE_COUNT")]
        MSSQL_FAILOVER_DATABASE_COUNT,

        [EnumMember(Value = "MSSQL_HOST_DB_COUNT")]
        MSSQL_HOST_DB_COUNT,

        [EnumMember(Value = "MSSQL_HOST_INSTANCE_COUNT")]
        MSSQL_HOST_INSTANCE_COUNT,

        [EnumMember(Value = "MSSQL_INSTANCE_DB_COUNT")]
        MSSQL_INSTANCE_DB_COUNT,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "PHYSICAL_HOST_CONNECTION_STATUS")]
        PHYSICAL_HOST_CONNECTION_STATUS,

        [EnumMember(Value = "PHYSICAL_HOST_OS_NAME")]
        PHYSICAL_HOST_OS_NAME,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SID")]
        SAP_HANA_SYSTEM_SID,

        [EnumMember(Value = "SAP_HANA_SYSTEM_STATUS")]
        SAP_HANA_SYSTEM_STATUS,

        [EnumMember(Value = "SENSITIVITY_HITS")]
        SENSITIVITY_HITS,

        [EnumMember(Value = "SENSITIVITY_STATUS")]
        SENSITIVITY_STATUS,

        [EnumMember(Value = "UNMANAGED_OBJECTS_ARCHIVAL_STORAGE_BYTES")]
        UNMANAGED_OBJECTS_ARCHIVAL_STORAGE_BYTES,

        [EnumMember(Value = "UNMANAGED_OBJECTS_LOCAL_STORAGE_BYTES")]
        UNMANAGED_OBJECTS_LOCAL_STORAGE_BYTES,

        [EnumMember(Value = "UNMANAGED_OBJECTS_LOCATION")]
        UNMANAGED_OBJECTS_LOCATION,

        [EnumMember(Value = "UNMANAGED_OBJECTS_STATUS")]
        UNMANAGED_OBJECTS_STATUS,

        [EnumMember(Value = "UNMANAGED_OBJECTS_UNEXPIRED_SNAPSHOT_COUNT")]
        UNMANAGED_OBJECTS_UNEXPIRED_SNAPSHOT_COUNT,

        [EnumMember(Value = "VMWARE_VCENTER_NAME_AND_VM_NAME")]
        VMWARE_VCENTER_NAME_AND_VM_NAME,

        [EnumMember(Value = "VMWARE_VM_AGENT_STATUS")]
        VMWARE_VM_AGENT_STATUS,

        [EnumMember(Value = "VSPHERE_DATASTORE_CAPACITY")]
        VSPHERE_DATASTORE_CAPACITY,

        [EnumMember(Value = "VSPHERE_DATASTORE_FREE_SPACE")]
        VSPHERE_DATASTORE_FREE_SPACE,

        [EnumMember(Value = "VSPHERE_DATASTORE_TYPE")]
        VSPHERE_DATASTORE_TYPE


    } // enum HierarchySortByField

} // namespace RubrikSecurityCloud.Types