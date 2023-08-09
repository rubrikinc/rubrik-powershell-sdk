### HierarchyFilterField
- IS_ARCHIVED - Filters archived workloads.
- NAME - Filter by name. For an exact match, use NAME_EXACT_MATCH.
- IS_RELIC - Filters workloads that are relics.
- EC2_INSTANCE_ID - Filter by EC2Instance native ID.
- EC2_INSTANCE_NAME - Filter by EC2Instance.name.
- EBS_VOLUME_ID - Filter by EBSVolume native ID.
- EBS_VOLUME_NAME - Filter by EBSVolume.name.
- AWS_REGION - Filter by AWSAccount.aws_region_spec.region, EC2Instance.region, and
 EBSVolume.region.
- EFFECTIVE_SLA - Filter by effective SLA Domain.
- NAME_OR_EMAIL_ADDRESS - Filter by name or email-address of O365 user.
- CLUSTER_ID - Filter Rubrik CDM objects by cluster ID.
- IS_GHOST - Filter archived and non-relic managed-objects.
- AZURE_REGION - Filter by AzureSubscription.region_spec.region, AzureResourceGroup.region,
 AzureVm.Region and AzureDisk.region.
- EC2_INSTANCE_TYPE - Filter by Ec2Instance.type.
- EBS_VOLUME_TYPE - Filter by EbsVolume.type.
- AWS_VPC_ID - Filter by VPC ID.
- AWS_NATIVE_ACCOUNT_ID - Filter by AWS account ID.
- EC2_INSTANCE_NAME_OR_INSTANCE_ID - Filter by EC2 instance name or instance ID.
- EBS_VOLUME_NAME_OR_VOLUME_ID - Filter by EBS volume name or volume ID.
- IS_REPLICATED - Filters replicated workloads.
- IS_PROTECTED - Filter by whether object is protected by an SLA Domain.
- AWS_TAG - Filter by aws_native_tags.
- ON_OR_ABOVE_CLUSTER_VERSION - Filter by software version of the cluster.
- AZURE_VM_SUBSCRIPTION_ID - Filter Azure virtual machines on subscription ID.
 todo (SPARK-88655): remove usage of VMRG and DiskRG
- AZURE_VNET_NAME - Filter Azure virtual machines on VNet name.
- AZURE_VM_SIZE - Filter Azure virtual machines on virtual machine size.
- AWS_NATIVE_EC2_INSTANCE_ID - ID of the AWS native EC2 instance (Rubrik ID), applicable for filtering
 EBS volumes with their EC2 instance IDs. Applicable only if the object
 type is AwsNativeEbsVolume.
- OS_TYPE - Filter physical hosts by OS type.
- OS_NAME - Filter physical hosts by OS name.
- O365_SPECIFIC_TYPE - O365 specific type: O365_SHARED_USER, O365_SHARED_MAILBOX...This filter is
 introduced to support api-server since it is not convenient to add object-specific
 subtype knowledge there. To query for shared users, we can either:
 1. Specify O365_USER in object type AND this filter with value O365_SHARED_USER
 (api-server way)
 2. Specify O365_SHARED_USER in object type, ignore this filter
 (others should do this).
- NAME_EXACT_MATCH - There is already a filter called NAME which filters for all the rows
 where name is "LIKE" the provided string. We have a use-case in
 Azure where we would like to Filter by name but exact-match, not just
 similar match. The use case is that resource groups are identified by
 the tuple of subscription ID and resource group name, similarity
 measure will not distinguish between two similar names.
- FILESET_SLA - Filter physical hosts by SLAs attached to their filesets.
- FILESET_TEMPLATE_ID - Filter physical hosts by which fileset templates are attached
 to them.
- FILESET_TEMPLATE_OS_TYPE - Filter fileset templates by OS Type.
- AZURE_DISK_SUBSCRIPTION_ID - Filter Azure disks by subscription ID.
 todo (SPARK-88655): remove usage of VMRG and DiskRG
- AZURE_DISK_SIZE - Filter Azure disks on Disk size.
- AZURE_DISK_ATTACHED_VM - Filter Azure disks by ID of the attached virtual machine.
- EC2_INSTANCE_INDEXING_STATUS - Filter EC2 Instances by status of indexing. Possible values for
 filter are generated strings from AwsIndexingStatusFilter enum.
- EBS_VOLUME_INDEXING_STATUS - Filter EBS Volumes by status of indexing.
- AZURE_DISK_TYPE - Filter Azure disks on Disk type.
- HAS_PARENT_SNAPPABLE - Filter if a workload has parent workload.
- CLUSTER_TYPE - Filter clusters by the ClusterTypeEnum.
- GCP_NATIVE_PROJECT_ID - Filter by GCP project ID for GCE instances.
- AWS_NATIVE_ACCOUNT_ENABLED_FEATURE - Filter AWS native accounts based on the features enabled for them.
- AWS_NATIVE_RDS_DB_ENGINE - Filter by RDS Instace DB Engine.
- AWS_NATIVE_RDS_DB_INSTANCE_CLASS - Filter by RDS Instance DB Instance Class.
- EFFECTIVE_SLA_SOURCE_OBJECT - Filter to include or exclude objects with a specific effective SLA
 source object.
- GCP_NATIVE_INSTANCE_NAME_OR_NATIVE_ID - Filter by GCP instance native ID or name.
- GCP_NATIVE_PROJECT_NAME_OR_PROJECT_NUMBER - Filter by GCP project name or project number.
- GCP_NATIVE_REGION - Filter by GCP region.
- GCP_NATIVE_INSTANCE_TYPE - Filter by GCP instance type.
- GCP_NATIVE_INSTANCE_NETWORK_NAME - Filter by GCP Instance Network Name.
- AZURE_TAG - Filter by azure_native_tags.
- PHYSICAL_HOST_ID - tag_filter_params field.
 Filter by the ID of a Physical Host.
- EFFECTIVE_SLA_TYPE - Filter by the SLA type of the effective SLA.
- SAP_HANA_SYSTEM_ID - Filter by the ID of parent SAP HANA system.
- PHYSICAL_HOST_CONNECTION_STATUS - Filter by the RBS status of the physical host.
- GCP_LABEL - Filter by gcp_native_labels.
- SAP_HANA_SYSTEM_STATUS - Filter by status of SapHanaSystem.
- GCP_NATIVE_DISK_NAME_OR_NATIVE_ID - Filter by GCP Disk name or native ID.
- GCP_NATIVE_DISK_LOCATION - Filter by GCP Disk location (for regional disk: location=region, for zonal disk: location=zone).
- GCP_NATIVE_DISK_PROJECT - Filter by GCP Disk project name.
- PHYSICAL_HOST_EFFECTIVE_SLA - Filter by the SLA Domain of the host filesets.
- SAP_HANA_SYSTEM_SID - Filter by SID of SapHanaSystem.
- GCP_NATIVE_DISK_TYPE - Filter by GCP Disk type.
 Text of the GCP_DISK_TYPE can have one of the following values:
 regional-pd-ssd regional-pd-standard regional-pd-balanced
 zonal-pd-ssd zonal-pd-standard zonal-pd-balanced.
- DOES_PHYSICAL_HOST_HAVE_RELIC_FILESETS - Filter by relic filesets of a physical host.
- LOCATION - Filter by location or path of an object.
- AZURE_RG_SUBSCRIPTION_ID - Filter Azure resource groups by subscription ID.
- GCP_NATIVE_PROJECT_NATIVE_ID - Filter GCP projects by their native ID.
- AZURE_DISK_CRG_NAME - Filter Azure disks by common resource group name.
- AZURE_VM_CRG_NAME - Filter Azure virtual machines on common resource group name.
- AZURE_DISK_CRG_SUBSCRIPTION_ID - Filter Azure disks on subscription ID of common resource group.
- AZURE_VM_CRG_SUBSCRIPTION_ID - Filter Azure virtual machines on subscription ID of common resource group.
- KUPR_CLUSTER_STATUS - Filter Kubernetes clusters based on connection status.
- KUPR_CDM_CLUSTER_ID - Filter Kubernetes clusters based on associated Rubrik cluster.
 Since the Kubernetes cluster is natively managed by Rubrik SaaS, a separate filter is used.
- KUPR_NAMESPACE_CLUSTER_STATUS - Filter Kubernetes namespace based on the connection status of the parent.
- KUPR_NAMESPACE_CDM_CLUSTER_ID - Filter Kubernetes namespaces based on the associated Rubrik cluster of the parent Kubernetes cluster.
 Since Kubernetes namespace is natively managed by Rubrik SaaS, a separate filter is used.
- GUEST_OS_TYPE_FOR_FILE_RESTORE - Filter VSphere and Hyper-V virtual machines by guest OS type for file export.
- FAILOVER_CLUSTER_ID - Filter by ID of parent of Failover Cluster.
- AZURE_RG_DISK_OR_VM_SLA - Filter Azure resource groups by disk SLA or virtual machine SLA.
- IS_ACTIVE - Return only the workloads that are active.
 An active workload is a workload that is without a workload group or
 workload with the highest primary sequence number in the workload group.
- IS_NOT_BLUEPRINT_CHILD - Workload must not be a member of any active Blueprint.
- DOES_SHAREPOINT_HAVE_RELIC_OBJECTS - Filter whether the sharepoint is relic or contains relic object.
- FAILOVER_CLUSTER_APP_ID - Filter by the ID of Failover cluster app.
- AZURE_NATIVE_VM_EXOCOMPUTE_CONNECTED - Filters Azure virtual machines whose regions have a "CONNECTED" exocompute.
- AZURE_NATIVE_DISK_EXOCOMPUTE_CONNECTED - Filters Azure disks whose regions have a "CONNECTED" exocompute.
- AZURE_NATIVE_VM_INDEXING_STATUS - Filter by the "indexing status" of Azure VMs.
- AZURE_NATIVE_DISK_INDEXING_STATUS - Filter by the "indexing status" of Azure disks.
- REGEX - Filter by the name by a given regex expression.
- CASSANDRA_SOURCE_ID - Filter by ID of parent Cassandra Source.
- CASSANDRA_KEYSPACE_ID - Filter by ID of parent Cassandra Keyspace.
- VSPHERE_GET_ROOT_RESTORE_HIERARCHY - Filter for the the root level of compute resources for the restore
 hierarchy, which includes compute clusters and standalone hosts.
- DOES_PHYSICAL_HOST_HAVE_RELIC_VOLUME_GROUP - Filter by relic volume group of a physical host.
- PHYSICAL_HOST_BY_VOLUME_GROUP_EFFECTIVE_SLA - Filter by the SLA Domain of the volume group of the physical host.
- AZURE_SQL_DB_RG_NAME - Filter Azure SQL Databases on resource group name.
- AZURE_SQL_DB_SUBSCRIPTION_ID - Filter Azure SQL Databases on subscription ID.
- AZURE_SQL_DB_SERVER_RG_NAME - Filter Azure SQL Database Servers on resource group name.
- AZURE_SQL_DB_SERVER_SUBSCRIPTION_ID - Filter Azure SQL Database Servers on subscription ID.
- AZURE_SQL_MI_DB_RG_NAME - Filter Azure SQL Managed Instance Databases on resource group name.
- AZURE_SQL_MI_DB_SUBSCRIPTION_ID - Filter Azure SQL Managed Instances Databases on subscription ID.
- AZURE_SQL_MI_SERVER_RG_NAME - Filter Azure SQL Managed Instance Database Servers on resource group name.
- AZURE_SQL_MI_SERVER_SUBSCRIPTION_ID - Filter Azure SQL Managed Instances Database Servers on subscription ID.
- AZURE_RG_WORKLOAD_TYPES_SLA_DOMAIN - Filter Azure Resource Groups by SLAs of given workload types.
 SLAs need to be passed as "texts" and workload types need to be
 passed as "object_type_filter_params".
 Note: When using this filter for more than two types of workloads,
 test the performance for large data sizes because internally the operation performs
 some heavy joins to filter the results.
- HOST_OPERATING_SYSTEM - Filter the hosts by their Operating System.
- UDF_DATABASE_TYPE - Filter based on type of database in UDF schema.
- CLOUD_NATIVE_SERVER_NAME_FILTER - Filter cloud native databases using server name.
- DOES_PHYSICAL_HOST_HAVE_PROTECTED_VOLUME_GROUP - Filter physical hosts that have protected volume group.
- DB2_INSTANCE_ID - Filter based on fid of DB2 instance.
- DB2_INSTANCE_STATUS - Filter by status of Db2Instance.
- CASSANDRA_SOURCE_STATUS - Filter by status of CassandraSource.
- AZURE_NATIVE_SUBSCRIPTION_ENABLED_FEATURE - Filter Azure native subscriptions based on the features enabled for them.
- MONGODB_SOURCE_ID - Filter by ID of parent MongoDB Source.
- MONGODB_DATABASE_ID - Filter by ID of parent MongoDB Keyspace.
- MONGODB_SOURCE_STATUS - Filter by status of MongoDB Source.
- HOST_CBT_STATUS - Filter hosts based on CBT status.
- IS_HOST_PROTECTED - Filter physical hosts that have protected filesets.
- PHYSICAL_HOST_BY_CLOUD_INSTANCE_ID - Filter physical host by cloud instance id.
- CLOUD_INSTANCE_HOST_DESCENDANT_OBJECT_TYPE - Filter cloud instance physical host by descendant object type.
- DOES_NAS_VOLUME_HAVE_SMC - Filter NAS volumes based on whether they are associated
 with a SnapMirror Cloud object.
- NAS_VOLUME_EFFECTIVE_SLA - Filter by the SLA Domain of the SnapMirror Cloud objects under
 the NAS volume.
- NAS_NAMESPACE_ID - Filter by the ID of the NAS namespace.
- EXCHANGE_DATABASE_BY_DAG_ID - Filter Exchange Databases by the ID of the Exchange Dag.
- EXCHANGE_DATABASE_BY_SERVER_ID - Filter Exchange Databases by the ID of the Exchange Server.
- EXCHANGE_DATABASE_BY_HOST_ID - Filter Exchange Databases by the ID of the Exchange Host.
- MANAGED_VOLUME_TYPE - Filter Managed Volume Type.
- VSPHERE_DATASTORE_IS_LOCAL - Filter isLocal of virtualhost.descendant.
- IS_ACTIVE_AMONG_DUPLICATED_OBJECTS - Filters active object from a group of duplicated objects.
- RUBRIK_NATIVE_HAS_UNINDEXED_OR_EXPIRED_SNAPSHOT - Filter by whether Rubrik SaaS native workload object
 has an unindexed snapshot or it has a snapshot that is expired
 and has an unmerged index.
- IS_UNMANAGED_OBJECT - Filter unmanaged objects.
- NUTANIX_VM_BY_AGENT_STATUS - Filter Nutanix virtual machines by the agent's connection status.
- NUTANIX_VM_BY_NUTANIX_CLUSTER_CDMID - Filter Nutanix virtual machines by the Nutanix cluster CDMID.
- IS_MAIN_MOUNT - Filter Live Mounts from Managed Volume Exports.
- MANAGED_VOLUME_ID - Filter Managed Volume Exports for a given Managed Volume ID.
- EXCHANGE_SERVER_BY_DAG_ID - Filter Exchange Server by the ID of the Exchange Dag.
- EFFECTIVE_RETENTION_SLA - Filter managed objects by the SLA Domain ID. Objects returned are
 either retained or protected by the SLA Domain.
- NAS_VENDOR_TYPE - Filter by the vendor type of the NAS System.
- ORGANIZATION_ID - Filter by organization ID.
- EXCLUDED_SHAREPOINT_LIBRARY_TYPE - Filter SharePoint Libraries by excluding list template types.
- NAS_SHARE_TYPE - Filter by the type of the NAS Share.
- NAS_SHARE_HIDDEN - Filter by hidden shares.
- NAS_SHARE_SLA - Filter by the effective SLA Domain ID of the NAS Share.
- NAS_SHARE_STALE - Filter by stale shares.
- CLOUD_INSTANCE_CDM_APP_PROTECTION_SETUP - Filter cloud instances based on whether CDM App Protection
 is setup through a cloud cluster.
- AWS_INSTANCE_CC_OR_CNP_RBS_CONNECTION_STATUS - Filter AWS EC2 instances based on RBS connection status.
- AZURE_VM_CC_OR_CNP_RBS_CONNECTION_STATUS - Filter Azure Virtual Machines based on RBS connection status.
- NAS_SHARE_NAMESPACE_ID - Filter by the Namespace ID of the NAS Share.
- MANAGED_VOLUME_EXPORT_ID - Filter by Managed Volume Export ID.
- IS_NAS_SHARE_PROTECTED - Filter by the protection status of a NAS share.
- DOES_NAS_SHARE_HAVE_RELIC_FILESETS - Filter by relic filesets of a NAS Share.
- PHYSICAL_HOST_BY_MSSQL_EFFECTIVE_SLA - Filter by SLA domain of the Microsoft SQL (MSSQL) hosts.
- IS_MANAGED_VOLUME_ARCHIVED - Filter child objects by Managed Volume archival status.
- EFFECTIVE_SLA_WITH_RETENTION_SLA - The behavior of this filter is similar to the EFFECTIVE_SLA filter,
 except, the behavior when it returns objects that have a
 retention SLA Domain assigned along with the DoNotProtect SLA Domain.
- SAP_HANA_DATABASE_CDM_ID - Filter by the Rubrik CDM ID of the SAP HANA database.
- CDP_VM_NAME - Filter by name of CDP Virtual Machine.
- CDP_VM_EFFECTIVE_SLA_ID - Filter by effective SLA Domain name of CDP Virtual Machine.
- CDP_VM_SOURCE_CLUSTER_ID - Filter by source cluster of the CDP Virtual Machine.
- CDP_LOCAL_STATUS - Filter by CDP state of CDP Virtual Machine.
- CDP_REPLICATION_STATUS - Filter by CDP replication state of CDP Virtual Machine.
- CDP_IO_FILTER_STATUS - Filter by IO filter installation status of CDP Virtual Machine.
- CDP_VMS - Filter by CDP Virtual Machines.
- VCD_VAPP_TYPE - Filter vCD vApps by type.
- AWS_NATIVE_CLOUD_TYPE - Filter by the AWS Cloud Type.
- IS_KUPR_HOST - Filter the kooper hosts from the host list.
- M365_PREFERRED_DATA_LOCATION - Filter by preferred data location. Applicable for M365 workloads.
- IS_MOUNT - Filter MSSQL databases that are Live Mounts.
- IS_LOG_SHIPPING_SECONDARY - Filter MSSQL databases that are log shipping secondaries.
- O365_GROUP_TYPE - Filter by group type. Applicable to Microsoft 365 group workloads.
- FAILOVER_CLUSTERS_BY_MSSQL_EFFECTIVE_SLA - Filter by SLA domain of the Microsoft SQL (MSSQL) Failover Clusters.
- MONGO_SOURCE_ID - Filter by ID of parent Mongo Source.
- MONGO_DATABASE_ID - Filter by ID of parent Mongo Database.
- DB2_DB_TYPE - Filter the Db2 databases by database type.
- RECOVERY_PLAN_NAME - Filter by recovery plan name.
- RECOVERY_PLAN_TYPE - Filter by recovery plan type.
- IS_RECOVERY_PLAN_VISIBLE - Filter by recovery plan visibility.
- FAILOVER_CLUSTER_CONNECTION_STATUS - Filter by failover cluster connection status.
- FAILOVER_CLUSTER_APP_CONNECTION_STATUS - Filter by failover cluster app connection status.
- HAS_UNEXPIRED_SNAPSHOTS - Filter objects with unexpired snapshots.
- O365_ORGANIZATION_ID - Filter objects by Microsoft Office 365 organization ID.
- RECOVERY_STATUS - Filter by recovery status.
- DOES_PHYSICAL_HOST_HAVE_PROTECTED_FILESETS - Filter physical hosts that have protected filesets.
- IS_DELETED_IN_CDM - Filter workloads deleted from the Rubrik cluster.
- HOST_VENDOR_TYPE - Filter by the vendor type of the NAS Host.
- NUTANIX_PRISM_CENTRAL_ID - Filter Nutanix clusters by the Nutanix Prism Central ID.
- MONGO_COLLECTION_PROTECTED - Filter protected MongoDB collections.
- TOP_LEVEL_SITES_OF_O365_ORG - Filter objects that are top level sites of all the O365 Orgs.
 Note that an org ID is not passed as a filter here so the top level
 sites under all the O365 orgs are returned.
- HOST_MIGRATION_STATUS - Filter according to the migration status of the physical hosts.
- HOST_SHARE_MIGRATION_STATUS - Filter according to the migration status of the host shares.
- FILESET_MIGRATION_STATUS - Filter according to the migration status of the filesets.
- DOMAIN_CONTROLLER_FSMO_ROLE - Filter by FSMO role of a domain controller.
- ACTIVE_DIRECTORY_DOMAIN_NAME - Filter by name of an Active Directory domain.
- NAS_SYSTEM_FOR_NAS_MIGRATION - Filter by NAS System.
- SAASAPPS_NATURAL_ID - Filter according to the natural ID field of the SaaS app resource.
- HYPERV_VM_BY_AGENT_STATUS - Filter Hyper-V virtual machines by the agent's connection status.
- JIRA_PROJECT_TYPE - Filter by the Jira project type.
- JIRA_PROJECT_KEY - Filter by the Jira project key.
- JIRA_PROJECT_LEAD - Filter by the Jira project lead.
- NUTANIX_SHOW_ONLY_STANDALONE_CLUSTERS - Filter out the standalone Nutanix cluster objects that are not
 associated with any Prism Central object.
- DOMAIN_CONTROLLER_CONNECTION_STATUS - Filter by the Active Directory domain controller connection status.
- MIGRATED_HOSTS_WITH_GHOST_OBJECTS - Filter to show all migrated hosts, including ghost objects.
- MSSQL_IS_HOST_PROTECTED - Filter Microsoft SQL Server hosts that are protected by an SLA Domain.
- MSSQL_IS_FAILOVER_CLUSTER_PROTECTED - Filter Microsoft SQL Server failover clusters that are protected by an SLA Domain.
- HAS_EXPIRED_INDEXED_SNAPSHOTS - Filter objects if they have snapshots that are expired and indexed.
- MANAGED_VOLUME_EXPORT_MOUNT_TYPE - Filter according to the Managed Volume export mount type.
- MIGRATED_HOST_SHARES_WITH_GHOST_OBJECTS - Filter to show all migrated host shares, including ghost objects.
