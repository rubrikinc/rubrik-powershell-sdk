// SchemaMeta.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

using System;
using System.Collections;
using System.Collections.Generic;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    public static class SchemaMeta
    {
        /// <summary>
        /// The version of the schema used to generate the SDK.
        /// </summary>
        public static string GraphqlSchemaVersion = "v20230830-14" ;

        /// <summary>
        /// Given the name of an interface type, return the names of the types that implement it.
        /// </summary>
        public static HashSet<string> InterfaceImpls( string interfaceName )
        {
            var InterfaceImplsDict = new Dictionary<string, HashSet<string>> {
                {
                    "AwsNativeAccountDescendantType",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AwsNativeAccountLogicalChildType",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AwsNativeHierarchyObject",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AzureNativeHierarchyObjectType",
                    new HashSet<string> {
                    "AzureNativeHierarchyObjectType",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    "AzureStorageAccount",
                    }
                },
                {
                    "CassandraKeyspaceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    }
                },
                {
                    "CassandraKeyspacePhysicalChildType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    }
                },
                {
                    "CassandraSourceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    }
                },
                {
                    "CassandraSourcePhysicalChildType",
                    new HashSet<string> {
                    "CassandraKeyspace",
                    "CassandraSourcePhysicalChildType",
                    }
                },
                {
                    "CdmHierarchyObject",
                    new HashSet<string> {
                    "Db2Database",
                    "Db2Instance",
                    "ExchangeDag",
                    "ExchangeDatabase",
                    "ExchangeServer",
                    "FailoverClusterApp",
                    "FilesetTemplate",
                    "HostFailoverCluster",
                    "HostShare",
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    "LinuxFileset",
                    "ManagedVolume",
                    "ManagedVolumeMount",
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "MongoSource",
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasSystem",
                    "NasVolume",
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    "NutanixVm",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    "PhysicalHost",
                    "SapHanaDatabase",
                    "SapHanaSystem",
                    "ShareFileset",
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVcenter",
                    "VsphereVm",
                    "WindowsCluster",
                    "WindowsFileset",
                    }
                },
                {
                    "CdmHierarchySnappableNew",
                    new HashSet<string> {
                    "CdmHierarchySnappableNew",
                    "Db2Database",
                    "ExchangeDatabase",
                    "HyperVvirtualMachine",
                    "LinuxFileset",
                    "ManagedVolume",
                    "MongoCollectionSet",
                    "MssqlDatabase",
                    "NasFileset",
                    "NutanixVm",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "SapHanaDatabase",
                    "ShareFileset",
                    "VcdVapp",
                    "VsphereVm",
                    "WindowsFileset",
                    }
                },
                {
                    "CloudAccount",
                    new HashSet<string> {
                    "AwsAccount",
                    "AwsRoleBasedAccount",
                    "AzureAccount",
                    "AzureRoleBasedAccount",
                    }
                },
                {
                    "CloudDirectHierarchyObject",
                    new HashSet<string> {
                    "CloudDirectNasExport",
                    }
                },
                {
                    "CloudDirectHierarchyWorkload",
                    new HashSet<string> {
                    "CloudDirectNasExport",
                    }
                },
                {
                    "Db2InstanceDescendantType",
                    new HashSet<string> {
                    "Db2Database",
                    "PhysicalHost",
                    }
                },
                {
                    "Db2InstancePhysicalChildType",
                    new HashSet<string> {
                    "Db2Database",
                    "PhysicalHost",
                    }
                },
                {
                    "DisplayableValue",
                    new HashSet<string> {
                    "DisplayableValueBoolean",
                    "DisplayableValueDateRange",
                    "DisplayableValueDateTime",
                    "DisplayableValueFloat",
                    "DisplayableValueInteger",
                    "DisplayableValueLong",
                    "DisplayableValueNull",
                    "DisplayableValueString",
                    }
                },
                {
                    "ExchangeDagDescendantType",
                    new HashSet<string> {
                    "ExchangeDagDescendantType",
                    "ExchangeDatabase",
                    }
                },
                {
                    "ExchangeServerDescendantType",
                    new HashSet<string> {
                    "ExchangeDatabase",
                    }
                },
                {
                    "FailoverClusterAppDescendantType",
                    new HashSet<string> {
                    "FailoverClusterAppDescendantType",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FailoverClusterAppPhysicalChildType",
                    new HashSet<string> {
                    "FailoverClusterAppPhysicalChildType",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FailoverClusterTopLevelDescendantType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "HostFailoverCluster",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FilesetTemplateDescendantType",
                    new HashSet<string> {
                    "FilesetTemplateDescendantType",
                    "LinuxFileset",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FilesetTemplatePhysicalChildType",
                    new HashSet<string> {
                    "FilesetTemplatePhysicalChildType",
                    "LinuxFileset",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "GcpNativeProjectDescendantType",
                    new HashSet<string> {
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    }
                },
                {
                    "GcpNativeProjectLogicalChildType",
                    new HashSet<string> {
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    }
                },
                {
                    "GenericSnapshot",
                    new HashSet<string> {
                    "CdmSnapshot",
                    "PolarisSnapshot",
                    }
                },
                {
                    "HierarchyObject",
                    new HashSet<string> {
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureNativeManagedDisk",
                    "AzureNativeResourceGroup",
                    "AzureNativeSubscription",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlDatabaseServer",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureSqlManagedInstanceServer",
                    "AzureStorageAccount",
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    "CassandraSource",
                    "CloudDirectNasExport",
                    "Db2Database",
                    "Db2Instance",
                    "ExchangeDag",
                    "ExchangeDatabase",
                    "ExchangeServer",
                    "FailoverClusterApp",
                    "FilesetTemplate",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "GcpNativeProject",
                    "HostFailoverCluster",
                    "HostShare",
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    "K8sCluster",
                    "K8sNamespace",
                    "LinuxFileset",
                    "ManagedVolume",
                    "ManagedVolumeMount",
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "MongodbCollection",
                    "MongodbDatabase",
                    "MongodbSource",
                    "MongoSource",
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasSystem",
                    "NasVolume",
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    "NutanixVm",
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365Org",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    "PhysicalHost",
                    "SapHanaDatabase",
                    "SapHanaSystem",
                    "ShareFileset",
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVcenter",
                    "VsphereVm",
                    "WindowsCluster",
                    "WindowsFileset",
                    }
                },
                {
                    "HierarchySnappable",
                    new HashSet<string> {
                    "HierarchySnappable",
                    "K8sNamespace",
                    "LinuxFileset",
                    "NasFileset",
                    "NutanixVm",
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "ShareFileset",
                    "VcdVapp",
                    "VsphereVm",
                    "WindowsFileset",
                    }
                },
                {
                    "HostFailoverClusterDescendantType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "HostFailoverClusterPhysicalChildType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "HostShareDescendantType",
                    new HashSet<string> {
                    "HostShareDescendantType",
                    "ShareFileset",
                    }
                },
                {
                    "HostSharePhysicalChildType",
                    new HashSet<string> {
                    "HostSharePhysicalChildType",
                    "ShareFileset",
                    }
                },
                {
                    "HyperVclusterDescendantType",
                    new HashSet<string> {
                    "HyperVclusterDescendantType",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HyperVclusterLogicalChildType",
                    new HashSet<string> {
                    "HyperVclusterLogicalChildType",
                    "HypervServer",
                    }
                },
                {
                    "HyperVscvmmDescendantType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmmDescendantType",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HyperVscvmmLogicalChildType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmmLogicalChildType",
                    "HypervServer",
                    }
                },
                {
                    "HypervServerDescendantType",
                    new HashSet<string> {
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HypervServerLogicalChildType",
                    new HashSet<string> {
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HypervTopLevelDescendantType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "K8sClusterDescendant",
                    new HashSet<string> {
                    "K8sClusterDescendant",
                    "K8sNamespace",
                    }
                },
                {
                    "ManagedVolumeDescendantType",
                    new HashSet<string> {
                    "ManagedVolumeMount",
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumeMountDescendantType",
                    new HashSet<string> {
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumeMountPhysicalChildType",
                    new HashSet<string> {
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumePhysicalChildType",
                    new HashSet<string> {
                    "ManagedVolumeMount",
                    "ManagedVolumePhysicalChildType",
                    }
                },
                {
                    "MongoCollectionSetDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    }
                },
                {
                    "MongoCollectionSetPhysicalChildType",
                    new HashSet<string> {
                    "MongoCollection",
                    }
                },
                {
                    "MongoDatabaseDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    "MongoCollectionSet",
                    }
                },
                {
                    "MongoDatabasePhysicalChildType",
                    new HashSet<string> {
                    "MongoCollectionSet",
                    "MongoDatabasePhysicalChildType",
                    }
                },
                {
                    "MongoSourceDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "PhysicalHost",
                    }
                },
                {
                    "MongoSourcePhysicalChildType",
                    new HashSet<string> {
                    "MongoDatabase",
                    "PhysicalHost",
                    }
                },
                {
                    "MongodbDatabaseDescendantType",
                    new HashSet<string> {
                    "MongodbCollection",
                    }
                },
                {
                    "MongodbDatabasePhysicalChildType",
                    new HashSet<string> {
                    "MongodbCollection",
                    }
                },
                {
                    "MongodbSourceDescendantType",
                    new HashSet<string> {
                    "MongodbCollection",
                    "MongodbDatabase",
                    }
                },
                {
                    "MongodbSourcePhysicalChildType",
                    new HashSet<string> {
                    "MongodbDatabase",
                    "MongodbSourcePhysicalChildType",
                    }
                },
                {
                    "MssqlAvailabilityGroupDescendantType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroupDescendantType",
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlAvailabilityGroupLogicalChildType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroupLogicalChildType",
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlInstanceDescendantType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstanceDescendantType",
                    }
                },
                {
                    "MssqlInstanceLogicalChildType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstanceLogicalChildType",
                    }
                },
                {
                    "MssqlTopLevelDescendantType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "PhysicalHost",
                    "WindowsCluster",
                    }
                },
                {
                    "NasNamespaceDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasNamespaceDescendantType",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasNamespaceLogicalChildType",
                    new HashSet<string> {
                    "NasNamespaceLogicalChildType",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasShareDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasShareDescendantType",
                    }
                },
                {
                    "NasShareLogicalChildType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasShareLogicalChildType",
                    }
                },
                {
                    "NasSystemDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasSystemLogicalChildType",
                    new HashSet<string> {
                    "NasNamespace",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasVolumeDescendantType",
                    new HashSet<string> {
                    "NasShare",
                    "NasVolumeDescendantType",
                    }
                },
                {
                    "NasVolumeLogicalChildType",
                    new HashSet<string> {
                    "NasShare",
                    "NasVolumeLogicalChildType",
                    }
                },
                {
                    "NutanixCategoryDescendantType",
                    new HashSet<string> {
                    "NutanixCategoryDescendantType",
                    "NutanixCategoryValue",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixCategoryLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategoryLogicalChildType",
                    "NutanixCategoryValue",
                    }
                },
                {
                    "NutanixCategoryValueDescendantType",
                    new HashSet<string> {
                    "NutanixCategoryValueDescendantType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixCategoryValueLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategoryValueLogicalChildType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixClusterDescendantType",
                    new HashSet<string> {
                    "NutanixClusterDescendantType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixClusterLogicalChildType",
                    new HashSet<string> {
                    "NutanixClusterLogicalChildType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixPrismCentralDescendantType",
                    new HashSet<string> {
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixPrismCentralLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategory",
                    "NutanixCluster",
                    }
                },
                {
                    "NutanixTopLevelDescendantType",
                    new HashSet<string> {
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    }
                },
                {
                    "O365AppObject",
                    new HashSet<string> {
                    "O365App",
                    }
                },
                {
                    "O365ExchangeObject",
                    new HashSet<string> {
                    "O365CalendarEvent",
                    "O365CalendarFolder",
                    "O365Contact",
                    "O365ContactFolder",
                    "O365Email",
                    "O365ExchangeObject",
                    "O365Folder",
                    }
                },
                {
                    "O365FullSpObject",
                    new HashSet<string> {
                    "O365FullSpDescendant",
                    "O365FullSpObject",
                    }
                },
                {
                    "O365OnedriveObject",
                    new HashSet<string> {
                    "O365OnedriveFile",
                    "O365OnedriveFolder",
                    "O365OnedriveObject",
                    }
                },
                {
                    "O365OrgDescendant",
                    new HashSet<string> {
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    }
                },
                {
                    "O365SharepointObject",
                    new HashSet<string> {
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    }
                },
                {
                    "O365TeamsChannelObject",
                    new HashSet<string> {
                    "O365TeamsChannel",
                    }
                },
                {
                    "O365UserDescendant",
                    new HashSet<string> {
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    }
                },
                {
                    "O365UserDescendantMetadata",
                    new HashSet<string> {
                    "O365Mailbox",
                    "O365Onedrive",
                    }
                },
                {
                    "OracleDataGuardGroupDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroupDescendantType",
                    }
                },
                {
                    "OracleDataGuardGroupLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroupLogicalChildType",
                    }
                },
                {
                    "OracleHostDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleHostLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleRacDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleRacLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleTopLevelDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    }
                },
                {
                    "PhysicalHostDescendantType",
                    new HashSet<string> {
                    "ExchangeServer",
                    "HostShare",
                    "HyperVscvmm",
                    "HypervServer",
                    "LinuxFileset",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "PhysicalHostDescendantType",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "PhysicalHostPhysicalChildType",
                    new HashSet<string> {
                    "ExchangeServer",
                    "HostShare",
                    "HyperVscvmm",
                    "HypervServer",
                    "LinuxFileset",
                    "MssqlInstance",
                    "PhysicalHostPhysicalChildType",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "PolarisHierarchyObject",
                    new HashSet<string> {
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureNativeManagedDisk",
                    "AzureNativeResourceGroup",
                    "AzureNativeSubscription",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlDatabaseServer",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureSqlManagedInstanceServer",
                    "AzureStorageAccount",
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    "CassandraSource",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "GcpNativeProject",
                    "K8sCluster",
                    "K8sNamespace",
                    "MongodbCollection",
                    "MongodbDatabase",
                    "MongodbSource",
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365Org",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    }
                },
                {
                    "PolarisHierarchySnappable",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureStorageAccount",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "K8sNamespace",
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    }
                },
                {
                    "PolarisSpecificSnapshot",
                    new HashSet<string> {
                    "AwsNativeEc2InstanceSpecificSnapshot",
                    "AzureNativeVmSpecificSnapshot",
                    "M365Snapshot",
                    "O365SiteSpecificSnapshot",
                    }
                },
                {
                    "ProtectedObjectSummary",
                    new HashSet<string> {
                    "ProtectedObjects",
                    }
                },
                {
                    "SapHanaSystemDescendantType",
                    new HashSet<string> {
                    "SapHanaDatabase",
                    }
                },
                {
                    "SapHanaSystemPhysicalChildType",
                    new HashSet<string> {
                    "SapHanaDatabase",
                    }
                },
                {
                    "SlaDomain",
                    new HashSet<string> {
                    "ClusterSlaDomain",
                    "GlobalSlaReply",
                    }
                },
                {
                    "Target",
                    new HashSet<string> {
                    "CdmManagedAwsTarget",
                    "CdmManagedAzureTarget",
                    "CdmManagedGcpTarget",
                    "CdmManagedGlacierTarget",
                    "CdmManagedNfsTarget",
                    "CdmManagedS3CompatibleTarget",
                    "CdmManagedTapeTarget",
                    "CdmTarget",
                    "RubrikManagedAwsTarget",
                    "RubrikManagedAzureTarget",
                    "RubrikManagedGcpTarget",
                    "RubrikManagedGlacierTarget",
                    "RubrikManagedNfsTarget",
                    "RubrikManagedRcsTarget",
                    "RubrikManagedS3CompatibleTarget",
                    "RubrikManagedTapeTargetType",
                    "Target",
                    }
                },
                {
                    "TargetTemplate",
                    new HashSet<string> {
                    "AwsTargetTemplate",
                    "AzureTargetTemplate",
                    "RcsAzureTargetTemplate",
                    }
                },
                {
                    "Value",
                    new HashSet<string> {
                    "ValueBoolean",
                    "ValueDateTime",
                    "ValueFloat",
                    "ValueInteger",
                    "ValueLong",
                    "ValueNull",
                    "ValueString",
                    }
                },
                {
                    "VcdCatalogDescendantType",
                    new HashSet<string> {
                    "VcdVapp",
                    }
                },
                {
                    "VcdCatalogLogicalChildType",
                    new HashSet<string> {
                    "VcdVapp",
                    }
                },
                {
                    "VcdDescendantType",
                    new HashSet<string> {
                    "VcdDescendantType",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdLogicalChildType",
                    new HashSet<string> {
                    "VcdLogicalChildType",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgDescendantType",
                    new HashSet<string> {
                    "VcdOrgDescendantType",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgLogicalChildType",
                    new HashSet<string> {
                    "VcdOrgLogicalChildType",
                    "VcdOrgVdc",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcDescendantType",
                    new HashSet<string> {
                    "VcdOrgVdcDescendantType",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcLogicalChildType",
                    new HashSet<string> {
                    "VcdOrgVdcLogicalChildType",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdTopLevelDescendantType",
                    new HashSet<string> {
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdVappDescendantType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VcdVappLogicalChildType",
                    new HashSet<string> {
                    "VcdVappLogicalChildType",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereComputeClusterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeClusterDescendantType",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereComputeClusterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeClusterPhysicalChildType",
                    "VsphereHost",
                    "VsphereResourcePool",
                    }
                },
                {
                    "VsphereDatacenterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereDatacenterFolderDescendantType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereDatacenterFolderLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereDatacenterLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenterLogicalChildType",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereDatacenterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    }
                },
                {
                    "VsphereDatastoreClusterDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreClusterDescendantType",
                    }
                },
                {
                    "VsphereDatastoreClusterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreClusterPhysicalChildType",
                    }
                },
                {
                    "VsphereFolderDescendantType",
                    new HashSet<string> {
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereFolderLogicalChildType",
                    new HashSet<string> {
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereHostDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereHostPhysicalChildType",
                    new HashSet<string> {
                    "VsphereHostPhysicalChildType",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereResourcePoolDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    }
                },
                {
                    "VsphereResourcePoolPhysicalChildType",
                    new HashSet<string> {
                    "VsphereResourcePool",
                    "VsphereResourcePoolPhysicalChildType",
                    }
                },
                {
                    "VsphereTagCategoryDescendantType",
                    new HashSet<string> {
                    "VsphereTag",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereTagCategoryTagChildType",
                    new HashSet<string> {
                    "VsphereTag",
                    "VsphereTagCategoryTagChildType",
                    }
                },
                {
                    "VsphereTagDescendantType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VsphereTagTagChildType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VsphereVcenterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereVcenterLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereVcenterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    }
                },
                {
                    "VsphereVcenterTagChildType",
                    new HashSet<string> {
                    "VsphereTagCategory",
                    "VsphereVcenterTagChildType",
                    }
                },
                {
                    "WindowsClusterDescendantType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstance",
                    }
                },
                {
                    "WindowsClusterLogicalChildType",
                    new HashSet<string> {
                    "MssqlInstance",
                    }
                },
            };
            if (InterfaceImplsDict.TryGetValue(interfaceName, out var implNames))
            {
                return implNames;
            }
            return new HashSet<string>();
        }
        
        /// <summary>
        /// Given the name of a type, return the names of the unions that include it.
        /// </summary>
        public static HashSet<string> UnionMembership( string typeName )
        {
            var UnionMembershipDict = new Dictionary<string, HashSet<string>> {
                {
                    "ActivityChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "ActivitySeverityLevel",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                {
                    "ActivityTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "AnomalyChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "AnomalyStatus",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    }
                },
                {
                    "AnomalyTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "AzureSnappableLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                {
                    "CdmSnappableLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                {
                    "Cluster",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "ClusterSlaDomain",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ClusterType",
                    new HashSet<string> {
                    "ClusterGroupByInfo",
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ComplianceStatus",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "FailoverChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "FailoverTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "InfrastructureChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "InfrastructureTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "ObjectType",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ProtectionStatus",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "Snappable",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    }
                },
                {
                    "SnappableChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SnappableTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "SonarContentReportChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SonarContentReportTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "SonarReportChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SonarReportTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "Status",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "TaskDetailClusterType",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailObjectType",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "TaskSummaryChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "TaskSummaryTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "TimeRangeWithUnit",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "CdmSnapshotGroupByInfo",
                    "ClusterGroupByInfo",
                    "ClusterMetricGroupByInfo",
                    "ManagedVolumeQueuedSnapshotGroupByInfo",
                    "MissedSnapshotGroupByInfo",
                    "MongoSnapshotGroupByInfo",
                    "MosaicSnapshotGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "PolarisSnapshotGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "UserAuditChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "UserAuditTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "WorkloadLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
            };
            if (UnionMembershipDict.TryGetValue(typeName, out var unionNames))
            {
                return unionNames;
            }
            return new HashSet<string>();
        }

        /// <summary>
        /// All GraphQL root field names (for both queries and mutations).
        /// </summary>
        public enum GqlRootFieldName
        {
            Unknown,
            accountId,
            accountSettings,
            activitySeries,
            activitySeriesConnection,
            addAwsAuthenticationServerBasedCloudAccount,
            addAwsIamUserBasedCloudAccount,
            addAzureCloudAccount,
            addAzureCloudAccountExocomputeConfigurations,
            addAzureCloudAccountWithoutOauth,
            addDb2Instance,
            addMongoSource,
            addNodesToCloudCluster,
            addO365Org,
            allAccountOwners,
            allAccountProducts,
            allAccountsWithExocomputeMappings,
            allAvailabilityZonesByRegionFromAws,
            allAwsCdmVersions,
            allAwsCloudAccountConfigs,
            allAwsCloudAccountsWithFeatures,
            allAwsComputeSettings,
            allAwsExocomputeConfigs,
            allAwsInstanceProfileNames,
            allAwsPermissionPolicies,
            allAwsRegions,
            allAzureArmTemplatesByFeature,
            allAzureCdmVersions,
            allAzureCloudAccountMissingPermissions,
            allAzureCloudAccountSubnetsByRegion,
            allAzureCloudAccountSubscriptionsByFeature,
            allAzureCloudAccountTenants,
            allAzureDiskEncryptionSetsByRegion,
            allAzureEncryptionKeys,
            allAzureExocomputeConfigsInAccount,
            allAzureKeyVaultsByRegion,
            allAzureManagedIdentities,
            allAzureNativeAvailabilitySetsByRegionFromAzure,
            allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
            allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
            allAzureNativeResourceGroupsInfoIfExist,
            allAzureNativeSecurityGroupsByRegionFromAzure,
            allAzureNativeStorageAccountsFromAzure,
            allAzureNativeSubnetsByRegionFromAzure,
            allAzureNativeVirtualMachineSizes,
            allAzureNativeVirtualNetworks,
            allAzureNsgs,
            allAzureRegions,
            allAzureResourceGroups,
            allAzureSqlDatabaseServerElasticPools,
            allAzureStorageAccounts,
            allAzureSubnets,
            allAzureSubscriptionWithExocomputeMappings,
            allAzureVnets,
            allClusterGlobalSlas,
            allClusterReplicationTargets,
            allClusterWebCertsAndIpmis,
            allClustersTotpAckStatus,
            allConnectedClusters,
            allDbParameterGroupsByRegionFromAws,
            allDbSubnetGroupsByRegionFromAws,
            allEc2KeyPairsByRegionFromAws,
            allHostedAzureRegions,
            allKmsEncryptionKeysByRegionFromAws,
            allMssqlDatabaseRestoreFiles,
            allNcdSlaComplianceData,
            allO365AdGroups,
            allO365OrgStatuses,
            allO365SubscriptionsAppTypeCounts,
            allOptionGroupsByRegionFromAws,
            allResourceGroupsFromAzure,
            allS3BucketsDetailsFromAws,
            allS3BucketsFromAws,
            allSlaSummariesByIds,
            allSupportedAwsRdsDatabaseInstanceClasses,
            allVcenterHotAddProxyVms,
            allVpcsByRegionFromAws,
            allVpcsFromAws,
            amiTypeForAwsNativeArchivedSnapshotExport,
            archiveK8sCluster,
            assignMssqlSlaDomainProperties,
            assignMssqlSlaDomainPropertiesAsync,
            assignRetentionSLAToSnappables,
            assignRetentionSLAToSnapshots,
            assignSla,
            assignSlaToMongoDbCollection,
            assignSlasForSnappableHierarchies,
            awsArtifactsToDelete,
            awsCloudAccountListSecurityGroups,
            awsCloudAccountListSubnets,
            awsCloudAccountListVpcs,
            awsCloudAccountWithFeatures,
            awsComputeSettings,
            awsNativeAccount,
            awsNativeAccounts,
            awsNativeEbsVolume,
            awsNativeEbsVolumes,
            awsNativeEbsVolumesByName,
            awsNativeEc2Instance,
            awsNativeEc2Instances,
            awsNativeEc2InstancesByName,
            awsNativeRdsExportDefaults,
            awsNativeRdsInstance,
            awsNativeRdsInstances,
            awsNativeRdsPointInTimeRestoreWindow,
            awsNativeRoot,
            awsNativeS3Bucket,
            awsTrustPolicy,
            azureCloudAccountPermissionConfig,
            azureCloudAccountSubscriptionWithFeatures,
            azureCloudAccountTenant,
            azureCloudAccountTenantWithExoConfigs,
            azureNativeManagedDisk,
            azureNativeManagedDisks,
            azureNativeResourceGroup,
            azureNativeResourceGroups,
            azureNativeRoot,
            azureNativeSubscription,
            azureNativeSubscriptions,
            azureNativeVirtualMachine,
            azureNativeVirtualMachines,
            azureO365CheckNSGOutboundRules,
            azureO365CheckNetworkSubnet,
            azureO365CheckResourceGroupName,
            azureO365CheckStorageAccountAccessibility,
            azureO365CheckStorageAccountName,
            azureO365CheckSubscriptionQuota,
            azureO365CheckVirtualNetworkName,
            azureO365Exocompute,
            azureO365GetAzureHostType,
            azureO365GetNetworkSubnetUnusedAddr,
            azureO365ValidateUserRoles,
            azureOauthConsentComplete,
            azureOauthConsentKickoff,
            azureRegions,
            azureResourceGroups,
            azureSqlDatabase,
            azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
            azureSqlDatabaseServer,
            azureSqlDatabaseServers,
            azureSqlDatabases,
            azureSqlManagedInstanceDatabase,
            azureSqlManagedInstanceDatabases,
            azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
            azureSqlManagedInstanceServer,
            azureSqlManagedInstanceServers,
            azureStorageAccounts,
            azureSubnets,
            azureSubscriptions,
            azureVNets,
            backupO365Mailbox,
            backupO365Onedrive,
            backupO365SharePointSite,
            backupO365SharepointDrive,
            backupO365SharepointList,
            backupO365Team,
            batchExportHypervVm,
            batchExportNutanixVm,
            batchInstantRecoverHypervVm,
            batchMountHypervVm,
            batchMountNutanixVm,
            batchOnDemandBackupHypervVm,
            browseMssqlDatabaseSnapshot,
            browseO365TeamConvChannels,
            bulkCreateOnDemandMssqlBackup,
            bulkDeleteAwsCloudAccountWithoutCft,
            bulkDeleteCassandraSources,
            bulkDeleteFailoverCluster,
            bulkDeleteMongodbSources,
            bulkOnDemandSnapshotNutanixVm,
            bulkUpdateMssqlDbs,
            bulkUpdateOracleDatabases,
            bulkUpdateOracleHosts,
            bulkUpdateOracleRacs,
            cancelActivitySeries,
            cassandraColumnFamilies,
            cassandraColumnFamily,
            cassandraColumnFamilyRecoverableRange,
            cassandraColumnFamilySchema,
            cassandraKeyspace,
            cassandraKeyspaces,
            cassandraSource,
            cassandraSources,
            cdmMssqlLogShippingTarget,
            cdmMssqlLogShippingTargets,
            checkAzurePersistentStorageSubscriptionCanUnmap,
            cluster,
            clusterCertificates,
            clusterConnection,
            clusterCsr,
            clusterDefaultGateway,
            clusterDns,
            clusterFloatingIps,
            clusterGroupByConnection,
            clusterIpmi,
            clusterIpv6Mode,
            clusterNetworkInterfaces,
            clusterNodes,
            clusterNtpServers,
            clusterOperationJobProgress,
            clusterProxy,
            clusterRegistrationProductInfo,
            clusterReportMigrationCount,
            clusterReportMigrationJobStatus,
            clusterReportMigrationStatus,
            clusterSlaDomains,
            clusterTypeList,
            clusterVlans,
            clusterWebSignedCertificate,
            clusterWithUpgradesInfo,
            completeAzureCloudAccountOauth,
            countOfObjectsProtectedBySlas,
            createAutomaticAwsTargetMapping,
            createAutomaticAzureTargetMapping,
            createAwsAccount,
            createAwsCluster,
            createAwsComputeSetting,
            createAwsExocomputeConfigs,
            createAwsReaderTarget,
            createAwsTarget,
            createAzureAccount,
            createAzureCluster,
            createAzureReaderTarget,
            createAzureSaasAppAad,
            createAzureTarget,
            createCassandraSource,
            createCloudNativeAwsStorageSetting,
            createCloudNativeAzureStorageSetting,
            createCloudNativeRcvAzureStorageSetting,
            createFailoverCluster,
            createGlobalSla,
            createHypervVirtualMachineSnapshotMount,
            createK8sCluster,
            createMongodbSource,
            createMssqlLiveMount,
            createMssqlLogShippingConfiguration,
            createNutanixCluster,
            createNutanixPrismCentral,
            createO365AppComplete,
            createO365AppKickoff,
            createOnDemandDb2Backup,
            createOnDemandMssqlBackup,
            createOnDemandNutanixBackup,
            createOraclePdbRestore,
            createVsphereAdvancedTag,
            createVsphereVcenter,
            databaseLogReportForCluster,
            databaseLogReportingPropertiesForCluster,
            db2Database,
            db2Databases,
            db2Instance,
            db2Instances,
            db2LogSnapshot,
            db2LogSnapshots,
            db2RecoverableRange,
            db2RecoverableRanges,
            deleteAllOracleDatabaseSnapshots,
            deleteAwsCluster,
            deleteAwsComputeSetting,
            deleteAwsExocomputeConfigs,
            deleteAzureCloudAccount,
            deleteAzureCloudAccountExocomputeConfigurations,
            deleteAzureCloudAccountWithoutOauth,
            deleteAzureCluster,
            deleteCassandraSource,
            deleteDb2Database,
            deleteDb2Instance,
            deleteFailoverCluster,
            deleteHypervVirtualMachineSnapshot,
            deleteHypervVirtualMachineSnapshotMount,
            deleteLdapPrincipals,
            deleteMongoSource,
            deleteMongodbSource,
            deleteMssqlDbSnapshots,
            deleteMssqlLiveMount,
            deleteNutanixCluster,
            deleteNutanixMountV1,
            deleteNutanixPrismCentral,
            deleteNutanixSnapshot,
            deleteNutanixSnapshots,
            deleteO365AzureApp,
            deleteO365Org,
            deleteO365ServiceAccount,
            deleteOracleMount,
            deleteVsphereAdvancedTag,
            deleteVsphereLiveMount,
            discoverDb2Instance,
            discoverMongoSource,
            doesAzureNativeResourceGroupExist,
            downloadDb2Snapshot,
            downloadDb2SnapshotsForPointInTimeRecovery,
            downloadFilesNutanixSnapshot,
            downloadHypervSnapshotFromLocation,
            downloadHypervVirtualMachineSnapshot,
            downloadHypervVirtualMachineSnapshotFiles,
            downloadMssqlDatabaseBackupFiles,
            downloadMssqlDatabaseFilesFromArchivalLocation,
            downloadNutanixSnapshot,
            downloadNutanixVmFromLocation,
            downloadOracleDatabaseSnapshot,
            downloadVsphereVirtualMachineFiles,
            enableO365SharePoint,
            enableO365Teams,
            excludeAwsNativeEbsVolumesFromSnapshot,
            excludeAzureNativeManagedDisksFromSnapshot,
            expireDownloadedDb2Snapshots,
            exportHypervVirtualMachine,
            exportMssqlDatabase,
            exportNutanixSnapshot,
            exportO365Mailbox,
            exportOracleDatabase,
            exportOracleTablespace,
            exportSlaManagedVolumeSnapshot,
            finalizeAwsCloudAccountDeletion,
            finalizeAwsCloudAccountProtection,
            getPendingSlaAssignments,
            globalSlaFilterConnection,
            globalSlaStatuses,
            hostFailoverCluster,
            hypervCluster,
            hypervDeleteAllSnapshots,
            hypervHostAsyncRequestStatus,
            hypervMounts,
            hypervOnDemandSnapshot,
            hypervScvmm,
            hypervScvmmAsyncRequestStatus,
            hypervScvmmDelete,
            hypervScvmmUpdate,
            hypervScvmms,
            hypervServer,
            hypervServers,
            hypervTopLevelDescendants,
            hypervVirtualMachine,
            hypervVirtualMachineAsyncRequestStatus,
            hypervVirtualMachines,
            hypervVmDetail,
            insertCustomerO365App,
            instantRecoverHypervVirtualMachineSnapshot,
            instantRecoverOracleSnapshot,
            isAwsNativeEbsVolumeSnapshotRestorable,
            isAwsNativeRdsInstanceLaunchConfigurationValid,
            isAwsS3BucketNameAvailable,
            isAzureNativeManagedDiskSnapshotRestorable,
            isAzureNativeSqlDatabaseSnapshotPersistent,
            isAzureStorageAccountNameAvailable,
            isTotpAckNecessaryForCluster,
            k8sClusters,
            ldapAuthorizedPrincipalConnection,
            ldapIntegrationConnection,
            ldapPrincipalConnection,
            listO365Apps,
            mapAzureCloudAccountExocomputeSubscription,
            mapAzureCloudAccountToPersistentStorageLocation,
            migrateNutanixMountV1,
            mongoBulkRecoverableRanges,
            mongoCollection,
            mongoCollections,
            mongoDatabase,
            mongoDatabases,
            mongoRecoverableRanges,
            mongoSource,
            mongoSources,
            mongodbBulkRecoverableRange,
            mongodbCollection,
            mongodbCollectionRecoverableRange,
            mongodbCollections,
            mongodbDatabase,
            mongodbDatabases,
            mongodbSource,
            mongodbSources,
            mountNutanixSnapshotV1,
            mountOracleDatabase,
            mssqlAvailabilityGroup,
            mssqlCompatibleInstances,
            mssqlDatabase,
            mssqlDatabaseLiveMounts,
            mssqlDatabaseMissedRecoverableRanges,
            mssqlDatabaseMissedSnapshots,
            mssqlDatabaseRestoreEstimate,
            mssqlDatabases,
            mssqlDefaultProperties,
            mssqlInstance,
            mssqlLogShippingTargets,
            mssqlRecoverableRanges,
            mssqlTopLevelDescendants,
            nutanixBrowseSnapshot,
            nutanixCategory,
            nutanixCategoryValue,
            nutanixCluster,
            nutanixClusterAsyncRequestStatus,
            nutanixClusterContainers,
            nutanixClusterNetworks,
            nutanixClusters,
            nutanixMounts,
            nutanixPrismCentral,
            nutanixPrismCentrals,
            nutanixSnapshotDetail,
            nutanixTopLevelDescendants,
            nutanixVm,
            nutanixVmAsyncRequestStatus,
            nutanixVmMissedSnapshots,
            nutanixVms,
            o365Calendar,
            o365Groups,
            o365License,
            o365Mailbox,
            o365Mailboxes,
            o365OauthConsentComplete,
            o365OauthConsentKickoff,
            o365ObjectAncestors,
            o365Onedrive,
            o365Onedrives,
            o365Org,
            o365OrgAtSnappableLevel,
            o365OrgSummaries,
            o365Orgs,
            o365PdlGroups,
            o365SaaSSetupKickoff,
            o365SaasSetupComplete,
            o365ServiceAccount,
            o365ServiceStatus,
            o365SetupKickoff,
            o365SharepointDrive,
            o365SharepointDrives,
            o365SharepointList,
            o365SharepointLists,
            o365SharepointObjectList,
            o365SharepointObjects,
            o365SharepointSite,
            o365SharepointSites,
            o365Site,
            o365Sites,
            o365StorageStats,
            o365Team,
            o365TeamChannels,
            o365TeamConversationsFolderID,
            o365TeamPostedBy,
            o365Teams,
            o365User,
            o365UserObjects,
            oracleAcoExampleDownloadLink,
            oracleAcoParameters,
            oracleDataGuardGroup,
            oracleDatabase,
            oracleDatabaseLogBackupConfig,
            oracleDatabases,
            oracleHost,
            oracleHostLogBackupConfig,
            oracleLiveMounts,
            oracleMissedRecoverableRanges,
            oracleMissedSnapshots,
            oraclePdbDetails,
            oracleRac,
            oracleRacLogBackupConfig,
            oracleRecoverableRanges,
            oracleTopLevelDescendants,
            patchAwsAuthenticationServerBasedCloudAccount,
            patchAwsIamUserBasedCloudAccount,
            patchDb2Database,
            patchDb2Instance,
            patchMongoSource,
            patchNutanixMountV1,
            pauseSla,
            prepareAwsCloudAccountDeletion,
            prepareFeatureUpdateForAwsCloudAccount,
            rdsInstanceDetailsFromAws,
            recoverCassandraSource,
            recoverCloudCluster,
            recoverMongoSource,
            recoverMongodbSource,
            refreshDb2Database,
            refreshHypervScvmm,
            refreshHypervServer,
            refreshK8sCluster,
            refreshNutanixCluster,
            refreshNutanixPrismCentral,
            refreshO365Org,
            refreshOracleDatabase,
            refreshVsphereVcenter,
            registerAgentHypervVirtualMachine,
            registerAgentNutanixVm,
            registerAwsFeatureArtifacts,
            registerCloudCluster,
            registerHypervScvmm,
            removeCdmCluster,
            removeLdapIntegration,
            restoreFilesNutanixSnapshot,
            restoreHypervVirtualMachineSnapshotFiles,
            restoreMssqlDatabase,
            restoreO365Mailbox,
            restoreO365Snappable,
            restoreO365TeamsConversations,
            restoreO365TeamsFiles,
            restoreOracleLogs,
            retryAddMongoSource,
            searchNutanixVm,
            setAzureCloudAccountCustomerAppCredentials,
            setLdapMfaSetting,
            setO365ServiceAccount,
            setupAzureO365Exocompute,
            slaAuditDetail,
            slaConflictObjects,
            slaDomain,
            slaDomains,
            slaManagedVolume,
            slaManagedVolumes,
            startAwsExocomputeDisableJob,
            startAwsNativeAccountDisableJob,
            startAwsNativeEc2InstanceSnapshotsJob,
            startAwsNativeRdsInstanceSnapshotsJob,
            startAzureCloudAccountOauth,
            startCreateAwsNativeEbsVolumeSnapshotsJob,
            startCreateAzureNativeManagedDiskSnapshotsJob,
            startCreateAzureNativeVirtualMachineSnapshotsJob,
            startDisableAzureCloudAccountJob,
            startDisableAzureNativeSubscriptionProtectionJob,
            startExportAwsNativeEbsVolumeSnapshotJob,
            startExportAzureNativeManagedDiskJob,
            startExportAzureNativeVirtualMachineJob,
            startExportAzureSqlDatabaseDbJob,
            startExportAzureSqlManagedInstanceDbJob,
            startRefreshAwsNativeAccountsJob,
            startRefreshAzureNativeSubscriptionsJob,
            startRestoreAwsNativeEc2InstanceSnapshotJob,
            startRestoreAzureNativeVirtualMachineJob,
            takeMssqlLogBackup,
            takeOnDemandOracleDatabaseSnapshot,
            takeOnDemandOracleLogSnapshot,
            uniqueHypervServersCount,
            unmapAzureCloudAccountExocomputeSubscription,
            unmapAzurePersistentStorageSubscription,
            updateAutomaticAwsTargetMapping,
            updateAutomaticAzureTargetMapping,
            updateAwsAccount,
            updateAwsCloudAccount,
            updateAwsCloudAccountFeature,
            updateAwsComputeSetting,
            updateAwsExocomputeConfigs,
            updateAwsTarget,
            updateAzureAccount,
            updateAzureCloudAccount,
            updateAzureTarget,
            updateCassandraSource,
            updateCloudNativeAwsStorageSetting,
            updateCloudNativeAzureStorageSetting,
            updateCloudNativeRcvAzureStorageSetting,
            updateCustomerAppPermissionForAzureSql,
            updateDatabaseLogReportingPropertiesForCluster,
            updateFailoverCluster,
            updateGlobalSla,
            updateHypervVirtualMachine,
            updateHypervVirtualMachineSnapshotMount,
            updateLdapIntegration,
            updateMongodbSource,
            updateMssqlDefaultProperties,
            updateMssqlLogShippingConfiguration,
            updateNutanixCluster,
            updateNutanixPrismCentral,
            updateNutanixVm,
            updateO365AppAuthStatus,
            updateO365AppPermissions,
            updateO365OrgCustomName,
            updateOracleDataGuardGroup,
            updateVcenter,
            updateVcenterHotAddBandwidth,
            updateVcenterHotAddNetwork,
            updateVsphereAdvancedTag,
            updateVsphereVm,
            upgradeAwsCloudAccountFeaturesWithoutCft,
            upgradeAwsIamUserBasedCloudAccountPermissions,
            upgradeAzureCloudAccount,
            upgradeAzureCloudAccountPermissionsWithoutOauth,
            vCenterAdvancedTagPreview,
            vCenterHotAddBandwidth,
            vCenterHotAddNetwork,
            vCenterNetworks,
            vCenterNumProxiesNeeded,
            vCenterPreAddInfo,
            vSphereComputeCluster,
            vSphereComputeClusters,
            vSphereDatacenter,
            vSphereDatastore,
            vSphereDatastoreCluster,
            vSphereDatastoreClusters,
            vSphereDatastoreConnection,
            vSphereFolder,
            vSphereFolders,
            vSphereHost,
            vSphereHostConnection,
            vSphereHostDetails,
            vSphereHostsByFids,
            vSphereLiveMounts,
            vSphereMount,
            vSphereMountConnection,
            vSphereNetwork,
            vSphereResourcePool,
            vSphereRootRecoveryHierarchy,
            vSphereTag,
            vSphereTagCategory,
            vSphereTopLevelDescendantsConnection,
            vSphereVCenter,
            vSphereVCenterConnection,
            vSphereVMAsyncRequestStatus,
            vSphereVmNew,
            vSphereVmNewConnection,
            validateAndCreateAwsCloudAccount,
            validateAwsNativeRdsClusterNameForExport,
            validateAwsNativeRdsInstanceNameForExport,
            validateAzureCloudAccountExocomputeConfigurations,
            validateAzureNativeSqlDatabaseDbNameForExport,
            validateAzureNativeSqlManagedInstanceDbNameForExport,
            validateOracleAcoFile,
            validateOracleDatabaseBackups,
            verifySlaWithReplicationToCluster,
            vsphereBulkOnDemandSnapshot,
            vsphereDeleteVcenter,
            vsphereExcludeVmDisks,
            vsphereExportSnapshotToStandaloneHostV2,
            vsphereOnDemandSnapshot,
            vsphereVMMissedRecoverableRange,
            vsphereVMRecoverableRange,
            vsphereVMRecoverableRangeInBatch,
            vsphereVmBatchExport,
            vsphereVmBatchExportV3,
            vsphereVmBatchInPlaceRecovery,
            vsphereVmDeleteSnapshot,
            vsphereVmDownloadSnapshot,
            vsphereVmDownloadSnapshotFiles,
            vsphereVmExportSnapshotV2,
            vsphereVmExportSnapshotV3,
            vsphereVmExportSnapshotWithDownloadFromCloud,
            vsphereVmInitiateBatchInstantRecovery,
            vsphereVmInitiateBatchLiveMountV2,
            vsphereVmInitiateDiskMount,
            vsphereVmInitiateInPlaceRecovery,
            vsphereVmInitiateInstantRecoveryV2,
            vsphereVmInitiateLiveMountV2,
            vsphereVmListEsxiDatastores,
            vsphereVmMountRelocate,
            vsphereVmMountRelocateV2,
            vsphereVmPowerOnOffLiveMount,
            vsphereVmRecoverFiles,
            vsphereVmRecoverFilesNew,
            vsphereVmRegisterAgent,
            vsphereVmwareCdpLiveInfo,
            windowsCluster,
        }

        /// <summary>
        /// Given a GraphQL root field name, return the corresponding RSC operation.
        /// </summary>
        public static RscOp RscOpLookupByGqlRootField(
            GqlRootFieldName rootField)
        {
            var lookupDict = new Dictionary<GqlRootFieldName, RscOp> {
                {
                    GqlRootFieldName.accountId,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAccount",
                        CmdletSwitchName = "Id",
                        GqlRootFieldName = "accountId"
                    }
                },
                {
                    GqlRootFieldName.accountSettings,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAccount",
                        CmdletSwitchName = "Settings",
                        GqlRootFieldName = "accountSettings"
                    }
                },
                {
                    GqlRootFieldName.activitySeries,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryActivitySeries",
                        CmdletSwitchName = "ActivitySeries",
                        GqlRootFieldName = "activitySeries"
                    }
                },
                {
                    GqlRootFieldName.activitySeriesConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryActivitySeries",
                        CmdletSwitchName = "List",
                        GqlRootFieldName = "activitySeriesConnection"
                    }
                },
                {
                    GqlRootFieldName.addAwsAuthenticationServerBasedCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "AddAuthenticationServerBasedCloudAccount",
                        GqlRootFieldName = "addAwsAuthenticationServerBasedCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.addAwsIamUserBasedCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "AddIamUserBasedCloudAccount",
                        GqlRootFieldName = "addAwsIamUserBasedCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.addAzureCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "AddCloudAccount",
                        GqlRootFieldName = "addAzureCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.addAzureCloudAccountExocomputeConfigurations,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "AddCloudAccountExocomputeConfigurations",
                        GqlRootFieldName = "addAzureCloudAccountExocomputeConfigurations"
                    }
                },
                {
                    GqlRootFieldName.addAzureCloudAccountWithoutOauth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "AddCloudAccountWithoutOauth",
                        GqlRootFieldName = "addAzureCloudAccountWithoutOauth"
                    }
                },
                {
                    GqlRootFieldName.addDb2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "AddInstance",
                        GqlRootFieldName = "addDb2Instance"
                    }
                },
                {
                    GqlRootFieldName.addMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "AddSource",
                        GqlRootFieldName = "addMongoSource"
                    }
                },
                {
                    GqlRootFieldName.addNodesToCloudCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "AddNodesToCloud",
                        GqlRootFieldName = "addNodesToCloudCluster"
                    }
                },
                {
                    GqlRootFieldName.addO365Org,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "AddOrg",
                        GqlRootFieldName = "addO365Org"
                    }
                },
                {
                    GqlRootFieldName.allAccountOwners,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAccount",
                        CmdletSwitchName = "Owners",
                        GqlRootFieldName = "allAccountOwners"
                    }
                },
                {
                    GqlRootFieldName.allAccountProducts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAccount",
                        CmdletSwitchName = "Products",
                        GqlRootFieldName = "allAccountProducts"
                    }
                },
                {
                    GqlRootFieldName.allAccountsWithExocomputeMappings,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAccount",
                        CmdletSwitchName = "SWithExocomputeMappings",
                        GqlRootFieldName = "allAccountsWithExocomputeMappings"
                    }
                },
                {
                    GqlRootFieldName.allAvailabilityZonesByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllAvailabilityZonesByRegion",
                        GqlRootFieldName = "allAvailabilityZonesByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allAwsCdmVersions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllCdmVersions",
                        GqlRootFieldName = "allAwsCdmVersions"
                    }
                },
                {
                    GqlRootFieldName.allAwsCloudAccountConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllCloudAccountConfigs",
                        GqlRootFieldName = "allAwsCloudAccountConfigs"
                    }
                },
                {
                    GqlRootFieldName.allAwsCloudAccountsWithFeatures,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllCloudAccountsWithFeatures",
                        GqlRootFieldName = "allAwsCloudAccountsWithFeatures"
                    }
                },
                {
                    GqlRootFieldName.allAwsComputeSettings,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllComputeSettings",
                        GqlRootFieldName = "allAwsComputeSettings"
                    }
                },
                {
                    GqlRootFieldName.allAwsExocomputeConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllExocomputeConfigs",
                        GqlRootFieldName = "allAwsExocomputeConfigs"
                    }
                },
                {
                    GqlRootFieldName.allAwsInstanceProfileNames,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllInstanceProfileNames",
                        GqlRootFieldName = "allAwsInstanceProfileNames"
                    }
                },
                {
                    GqlRootFieldName.allAwsPermissionPolicies,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllPermissionPolicies",
                        GqlRootFieldName = "allAwsPermissionPolicies"
                    }
                },
                {
                    GqlRootFieldName.allAwsRegions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllRegions",
                        GqlRootFieldName = "allAwsRegions"
                    }
                },
                {
                    GqlRootFieldName.allAzureArmTemplatesByFeature,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllArmTemplatesByFeature",
                        GqlRootFieldName = "allAzureArmTemplatesByFeature"
                    }
                },
                {
                    GqlRootFieldName.allAzureCdmVersions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllCdmVersions",
                        GqlRootFieldName = "allAzureCdmVersions"
                    }
                },
                {
                    GqlRootFieldName.allAzureCloudAccountMissingPermissions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllCloudAccountMissingPermissions",
                        GqlRootFieldName = "allAzureCloudAccountMissingPermissions"
                    }
                },
                {
                    GqlRootFieldName.allAzureCloudAccountSubnetsByRegion,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllCloudAccountSubnetsByRegion",
                        GqlRootFieldName = "allAzureCloudAccountSubnetsByRegion"
                    }
                },
                {
                    GqlRootFieldName.allAzureCloudAccountSubscriptionsByFeature,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllCloudAccountSubscriptionsByFeature",
                        GqlRootFieldName = "allAzureCloudAccountSubscriptionsByFeature"
                    }
                },
                {
                    GqlRootFieldName.allAzureCloudAccountTenants,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllCloudAccountTenants",
                        GqlRootFieldName = "allAzureCloudAccountTenants"
                    }
                },
                {
                    GqlRootFieldName.allAzureDiskEncryptionSetsByRegion,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllDiskEncryptionSetsByRegion",
                        GqlRootFieldName = "allAzureDiskEncryptionSetsByRegion"
                    }
                },
                {
                    GqlRootFieldName.allAzureEncryptionKeys,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllEncryptionKeys",
                        GqlRootFieldName = "allAzureEncryptionKeys"
                    }
                },
                {
                    GqlRootFieldName.allAzureExocomputeConfigsInAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllExocomputeConfigsInAccount",
                        GqlRootFieldName = "allAzureExocomputeConfigsInAccount"
                    }
                },
                {
                    GqlRootFieldName.allAzureKeyVaultsByRegion,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllKeyVaultsByRegion",
                        GqlRootFieldName = "allAzureKeyVaultsByRegion"
                    }
                },
                {
                    GqlRootFieldName.allAzureManagedIdentities,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllManagedIdentities",
                        GqlRootFieldName = "allAzureManagedIdentities"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeAvailabilitySetsByRegionFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeAvailabilitySetsByRegionFromAzure",
                        GqlRootFieldName = "allAzureNativeAvailabilitySetsByRegionFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeExportCompatibleDiskTypesByRegionFromAzure",
                        GqlRootFieldName = "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeExportCompatibleVmSizesByRegionFromAzure",
                        GqlRootFieldName = "allAzureNativeExportCompatibleVmSizesByRegionFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeResourceGroupsInfoIfExist,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeResourceGroupsInfoIfExist",
                        GqlRootFieldName = "allAzureNativeResourceGroupsInfoIfExist"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeSecurityGroupsByRegionFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeSecurityGroupsByRegionFromAzure",
                        GqlRootFieldName = "allAzureNativeSecurityGroupsByRegionFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeStorageAccountsFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeStorageAccountsFromAzure",
                        GqlRootFieldName = "allAzureNativeStorageAccountsFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeSubnetsByRegionFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeSubnetsByRegionFromAzure",
                        GqlRootFieldName = "allAzureNativeSubnetsByRegionFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeVirtualMachineSizes,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeVirtualMachineSizes",
                        GqlRootFieldName = "allAzureNativeVirtualMachineSizes"
                    }
                },
                {
                    GqlRootFieldName.allAzureNativeVirtualNetworks,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNativeVirtualNetworks",
                        GqlRootFieldName = "allAzureNativeVirtualNetworks"
                    }
                },
                {
                    GqlRootFieldName.allAzureNsgs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllNsgs",
                        GqlRootFieldName = "allAzureNsgs"
                    }
                },
                {
                    GqlRootFieldName.allAzureRegions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllRegions",
                        GqlRootFieldName = "allAzureRegions"
                    }
                },
                {
                    GqlRootFieldName.allAzureResourceGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllResourceGroups",
                        GqlRootFieldName = "allAzureResourceGroups"
                    }
                },
                {
                    GqlRootFieldName.allAzureSqlDatabaseServerElasticPools,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllSqlDatabaseServerElasticPools",
                        GqlRootFieldName = "allAzureSqlDatabaseServerElasticPools"
                    }
                },
                {
                    GqlRootFieldName.allAzureStorageAccounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllStorageAccounts",
                        GqlRootFieldName = "allAzureStorageAccounts"
                    }
                },
                {
                    GqlRootFieldName.allAzureSubnets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllSubnets",
                        GqlRootFieldName = "allAzureSubnets"
                    }
                },
                {
                    GqlRootFieldName.allAzureSubscriptionWithExocomputeMappings,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllSubscriptionWithExocomputeMappings",
                        GqlRootFieldName = "allAzureSubscriptionWithExocomputeMappings"
                    }
                },
                {
                    GqlRootFieldName.allAzureVnets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllVnets",
                        GqlRootFieldName = "allAzureVnets"
                    }
                },
                {
                    GqlRootFieldName.allClusterGlobalSlas,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "AllClusterGlobals",
                        GqlRootFieldName = "allClusterGlobalSlas"
                    }
                },
                {
                    GqlRootFieldName.allClusterReplicationTargets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "ReplicationTargets",
                        GqlRootFieldName = "allClusterReplicationTargets"
                    }
                },
                {
                    GqlRootFieldName.allClusterWebCertsAndIpmis,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "WebCertsAndIpmis",
                        GqlRootFieldName = "allClusterWebCertsAndIpmis"
                    }
                },
                {
                    GqlRootFieldName.allClustersTotpAckStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "TotpAckStatus",
                        GqlRootFieldName = "allClustersTotpAckStatus"
                    }
                },
                {
                    GqlRootFieldName.allConnectedClusters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Connected",
                        GqlRootFieldName = "allConnectedClusters"
                    }
                },
                {
                    GqlRootFieldName.allDbParameterGroupsByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllDbParameterGroupsByRegion",
                        GqlRootFieldName = "allDbParameterGroupsByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allDbSubnetGroupsByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllDbSubnetGroupsByRegion",
                        GqlRootFieldName = "allDbSubnetGroupsByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allEc2KeyPairsByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllEc2KeyPairsByRegion",
                        GqlRootFieldName = "allEc2KeyPairsByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allHostedAzureRegions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllHostedRegions",
                        GqlRootFieldName = "allHostedAzureRegions"
                    }
                },
                {
                    GqlRootFieldName.allKmsEncryptionKeysByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllKmsEncryptionKeysByRegion",
                        GqlRootFieldName = "allKmsEncryptionKeysByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allMssqlDatabaseRestoreFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "AllDatabaseRestoreFiles",
                        GqlRootFieldName = "allMssqlDatabaseRestoreFiles"
                    }
                },
                {
                    GqlRootFieldName.allNcdSlaComplianceData,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "AllNcdComplianceData",
                        GqlRootFieldName = "allNcdSlaComplianceData"
                    }
                },
                {
                    GqlRootFieldName.allO365AdGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "AllAdGroups",
                        GqlRootFieldName = "allO365AdGroups"
                    }
                },
                {
                    GqlRootFieldName.allO365OrgStatuses,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "AllOrgStatuses",
                        GqlRootFieldName = "allO365OrgStatuses"
                    }
                },
                {
                    GqlRootFieldName.allO365SubscriptionsAppTypeCounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "AllSubscriptionsAppTypeCounts",
                        GqlRootFieldName = "allO365SubscriptionsAppTypeCounts"
                    }
                },
                {
                    GqlRootFieldName.allOptionGroupsByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllOptionGroupsByRegion",
                        GqlRootFieldName = "allOptionGroupsByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allResourceGroupsFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "AllResourceGroupsFrom",
                        GqlRootFieldName = "allResourceGroupsFromAzure"
                    }
                },
                {
                    GqlRootFieldName.allS3BucketsDetailsFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllS3BucketsDetails",
                        GqlRootFieldName = "allS3BucketsDetailsFromAws"
                    }
                },
                {
                    GqlRootFieldName.allS3BucketsFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllS3Buckets",
                        GqlRootFieldName = "allS3BucketsFromAws"
                    }
                },
                {
                    GqlRootFieldName.allSlaSummariesByIds,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "AllSummariesByIds",
                        GqlRootFieldName = "allSlaSummariesByIds"
                    }
                },
                {
                    GqlRootFieldName.allSupportedAwsRdsDatabaseInstanceClasses,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllSupportedRdsDatabaseInstanceClasses",
                        GqlRootFieldName = "allSupportedAwsRdsDatabaseInstanceClasses"
                    }
                },
                {
                    GqlRootFieldName.allVcenterHotAddProxyVms,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "HotAddProxy",
                        GqlRootFieldName = "allVcenterHotAddProxyVms"
                    }
                },
                {
                    GqlRootFieldName.allVpcsByRegionFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllVpcsByRegion",
                        GqlRootFieldName = "allVpcsByRegionFromAws"
                    }
                },
                {
                    GqlRootFieldName.allVpcsFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AllVpcs",
                        GqlRootFieldName = "allVpcsFromAws"
                    }
                },
                {
                    GqlRootFieldName.amiTypeForAwsNativeArchivedSnapshotExport,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "AmiTypeForNativeArchivedSnapshotExport",
                        GqlRootFieldName = "amiTypeForAwsNativeArchivedSnapshotExport"
                    }
                },
                {
                    GqlRootFieldName.archiveK8sCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "ArchiveK8s",
                        GqlRootFieldName = "archiveK8sCluster"
                    }
                },
                {
                    GqlRootFieldName.assignMssqlSlaDomainProperties,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "AssignSlaDomainProperties",
                        GqlRootFieldName = "assignMssqlSlaDomainProperties"
                    }
                },
                {
                    GqlRootFieldName.assignMssqlSlaDomainPropertiesAsync,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "AssignSlaDomainPropertiesAsync",
                        GqlRootFieldName = "assignMssqlSlaDomainPropertiesAsync"
                    }
                },
                {
                    GqlRootFieldName.assignRetentionSLAToSnappables,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "AssignRetentionToSnappables",
                        GqlRootFieldName = "assignRetentionSLAToSnappables"
                    }
                },
                {
                    GqlRootFieldName.assignRetentionSLAToSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "AssignRetentionToSnapshots",
                        GqlRootFieldName = "assignRetentionSLAToSnapshots"
                    }
                },
                {
                    GqlRootFieldName.assignSla,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "Assign",
                        GqlRootFieldName = "assignSla"
                    }
                },
                {
                    GqlRootFieldName.assignSlaToMongoDbCollection,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "AssignSlaToDbCollection",
                        GqlRootFieldName = "assignSlaToMongoDbCollection"
                    }
                },
                {
                    GqlRootFieldName.assignSlasForSnappableHierarchies,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "AssignsForSnappableHierarchies",
                        GqlRootFieldName = "assignSlasForSnappableHierarchies"
                    }
                },
                {
                    GqlRootFieldName.awsArtifactsToDelete,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "ArtifactsToDelete",
                        GqlRootFieldName = "awsArtifactsToDelete"
                    }
                },
                {
                    GqlRootFieldName.awsCloudAccountListSecurityGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "CloudAccountListSecurityGroups",
                        GqlRootFieldName = "awsCloudAccountListSecurityGroups"
                    }
                },
                {
                    GqlRootFieldName.awsCloudAccountListSubnets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "CloudAccountListSubnets",
                        GqlRootFieldName = "awsCloudAccountListSubnets"
                    }
                },
                {
                    GqlRootFieldName.awsCloudAccountListVpcs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "CloudAccountListVpcs",
                        GqlRootFieldName = "awsCloudAccountListVpcs"
                    }
                },
                {
                    GqlRootFieldName.awsCloudAccountWithFeatures,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "CloudAccountWithFeatures",
                        GqlRootFieldName = "awsCloudAccountWithFeatures"
                    }
                },
                {
                    GqlRootFieldName.awsComputeSettings,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "ComputeSettings",
                        GqlRootFieldName = "awsComputeSettings"
                    }
                },
                {
                    GqlRootFieldName.awsNativeAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeAccount",
                        GqlRootFieldName = "awsNativeAccount"
                    }
                },
                {
                    GqlRootFieldName.awsNativeAccounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeAccounts",
                        GqlRootFieldName = "awsNativeAccounts"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEbsVolume,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEbsVolume",
                        GqlRootFieldName = "awsNativeEbsVolume"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEbsVolumes,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEbsVolumes",
                        GqlRootFieldName = "awsNativeEbsVolumes"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEbsVolumesByName,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEbsVolumesByName",
                        GqlRootFieldName = "awsNativeEbsVolumesByName"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEc2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEc2Instance",
                        GqlRootFieldName = "awsNativeEc2Instance"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEc2Instances,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEc2Instances",
                        GqlRootFieldName = "awsNativeEc2Instances"
                    }
                },
                {
                    GqlRootFieldName.awsNativeEc2InstancesByName,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeEc2InstancesByName",
                        GqlRootFieldName = "awsNativeEc2InstancesByName"
                    }
                },
                {
                    GqlRootFieldName.awsNativeRdsExportDefaults,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeRdsExportDefaults",
                        GqlRootFieldName = "awsNativeRdsExportDefaults"
                    }
                },
                {
                    GqlRootFieldName.awsNativeRdsInstance,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeRdsInstance",
                        GqlRootFieldName = "awsNativeRdsInstance"
                    }
                },
                {
                    GqlRootFieldName.awsNativeRdsInstances,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeRdsInstances",
                        GqlRootFieldName = "awsNativeRdsInstances"
                    }
                },
                {
                    GqlRootFieldName.awsNativeRdsPointInTimeRestoreWindow,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeRdsPointInTimeRestoreWindow",
                        GqlRootFieldName = "awsNativeRdsPointInTimeRestoreWindow"
                    }
                },
                {
                    GqlRootFieldName.awsNativeRoot,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeRoot",
                        GqlRootFieldName = "awsNativeRoot"
                    }
                },
                {
                    GqlRootFieldName.awsNativeS3Bucket,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "NativeS3Bucket",
                        GqlRootFieldName = "awsNativeS3Bucket"
                    }
                },
                {
                    GqlRootFieldName.awsTrustPolicy,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "TrustPolicy",
                        GqlRootFieldName = "awsTrustPolicy"
                    }
                },
                {
                    GqlRootFieldName.azureCloudAccountPermissionConfig,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "CloudAccountPermissionConfig",
                        GqlRootFieldName = "azureCloudAccountPermissionConfig"
                    }
                },
                {
                    GqlRootFieldName.azureCloudAccountSubscriptionWithFeatures,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "CloudAccountSubscriptionWithFeatures",
                        GqlRootFieldName = "azureCloudAccountSubscriptionWithFeatures"
                    }
                },
                {
                    GqlRootFieldName.azureCloudAccountTenant,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "CloudAccountTenant",
                        GqlRootFieldName = "azureCloudAccountTenant"
                    }
                },
                {
                    GqlRootFieldName.azureCloudAccountTenantWithExoConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "CloudAccountTenantWithExoConfigs",
                        GqlRootFieldName = "azureCloudAccountTenantWithExoConfigs"
                    }
                },
                {
                    GqlRootFieldName.azureNativeManagedDisk,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeManagedDisk",
                        GqlRootFieldName = "azureNativeManagedDisk"
                    }
                },
                {
                    GqlRootFieldName.azureNativeManagedDisks,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeManagedDisks",
                        GqlRootFieldName = "azureNativeManagedDisks"
                    }
                },
                {
                    GqlRootFieldName.azureNativeResourceGroup,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeResourceGroup",
                        GqlRootFieldName = "azureNativeResourceGroup"
                    }
                },
                {
                    GqlRootFieldName.azureNativeResourceGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeResourceGroups",
                        GqlRootFieldName = "azureNativeResourceGroups"
                    }
                },
                {
                    GqlRootFieldName.azureNativeRoot,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeRoot",
                        GqlRootFieldName = "azureNativeRoot"
                    }
                },
                {
                    GqlRootFieldName.azureNativeSubscription,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeSubscription",
                        GqlRootFieldName = "azureNativeSubscription"
                    }
                },
                {
                    GqlRootFieldName.azureNativeSubscriptions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeSubscriptions",
                        GqlRootFieldName = "azureNativeSubscriptions"
                    }
                },
                {
                    GqlRootFieldName.azureNativeVirtualMachine,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeVirtualMachine",
                        GqlRootFieldName = "azureNativeVirtualMachine"
                    }
                },
                {
                    GqlRootFieldName.azureNativeVirtualMachines,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "NativeVirtualMachines",
                        GqlRootFieldName = "azureNativeVirtualMachines"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckNSGOutboundRules,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckNSGOutboundRules",
                        GqlRootFieldName = "azureO365CheckNSGOutboundRules"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckNetworkSubnet,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckNetworkSubnet",
                        GqlRootFieldName = "azureO365CheckNetworkSubnet"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckResourceGroupName,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckResourceGroupName",
                        GqlRootFieldName = "azureO365CheckResourceGroupName"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckStorageAccountAccessibility,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckStorageAccountAccessibility",
                        GqlRootFieldName = "azureO365CheckStorageAccountAccessibility"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckStorageAccountName,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckStorageAccountName",
                        GqlRootFieldName = "azureO365CheckStorageAccountName"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckSubscriptionQuota,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckSubscriptionQuota",
                        GqlRootFieldName = "azureO365CheckSubscriptionQuota"
                    }
                },
                {
                    GqlRootFieldName.azureO365CheckVirtualNetworkName,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "CheckVirtualNetworkName",
                        GqlRootFieldName = "azureO365CheckVirtualNetworkName"
                    }
                },
                {
                    GqlRootFieldName.azureO365Exocompute,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "Exocompute",
                        GqlRootFieldName = "azureO365Exocompute"
                    }
                },
                {
                    GqlRootFieldName.azureO365GetAzureHostType,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "GetAzureHostType",
                        GqlRootFieldName = "azureO365GetAzureHostType"
                    }
                },
                {
                    GqlRootFieldName.azureO365GetNetworkSubnetUnusedAddr,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "GetNetworkSubnetUnusedAddr",
                        GqlRootFieldName = "azureO365GetNetworkSubnetUnusedAddr"
                    }
                },
                {
                    GqlRootFieldName.azureO365ValidateUserRoles,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzureO365",
                        CmdletSwitchName = "ValidateUserRoles",
                        GqlRootFieldName = "azureO365ValidateUserRoles"
                    }
                },
                {
                    GqlRootFieldName.azureOauthConsentComplete,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "OauthConsentComplete",
                        GqlRootFieldName = "azureOauthConsentComplete"
                    }
                },
                {
                    GqlRootFieldName.azureOauthConsentKickoff,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "OauthConsentKickoff",
                        GqlRootFieldName = "azureOauthConsentKickoff"
                    }
                },
                {
                    GqlRootFieldName.azureRegions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "Regions",
                        GqlRootFieldName = "azureRegions"
                    }
                },
                {
                    GqlRootFieldName.azureResourceGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "ResourceGroups",
                        GqlRootFieldName = "azureResourceGroups"
                    }
                },
                {
                    GqlRootFieldName.azureSqlDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlDatabase",
                        GqlRootFieldName = "azureSqlDatabase"
                    }
                },
                {
                    GqlRootFieldName.azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                        GqlRootFieldName = "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure"
                    }
                },
                {
                    GqlRootFieldName.azureSqlDatabaseServer,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlDatabaseServer",
                        GqlRootFieldName = "azureSqlDatabaseServer"
                    }
                },
                {
                    GqlRootFieldName.azureSqlDatabaseServers,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlDatabaseServers",
                        GqlRootFieldName = "azureSqlDatabaseServers"
                    }
                },
                {
                    GqlRootFieldName.azureSqlDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlDatabases",
                        GqlRootFieldName = "azureSqlDatabases"
                    }
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlManagedInstanceDatabase",
                        GqlRootFieldName = "azureSqlManagedInstanceDatabase"
                    }
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlManagedInstanceDatabases",
                        GqlRootFieldName = "azureSqlManagedInstanceDatabases"
                    }
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                        GqlRootFieldName = "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure"
                    }
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceServer,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlManagedInstanceServer",
                        GqlRootFieldName = "azureSqlManagedInstanceServer"
                    }
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceServers,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "SqlManagedInstanceServers",
                        GqlRootFieldName = "azureSqlManagedInstanceServers"
                    }
                },
                {
                    GqlRootFieldName.azureStorageAccounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "StorageAccounts",
                        GqlRootFieldName = "azureStorageAccounts"
                    }
                },
                {
                    GqlRootFieldName.azureSubnets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "Subnets",
                        GqlRootFieldName = "azureSubnets"
                    }
                },
                {
                    GqlRootFieldName.azureSubscriptions,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "Subscriptions",
                        GqlRootFieldName = "azureSubscriptions"
                    }
                },
                {
                    GqlRootFieldName.azureVNets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "VNets",
                        GqlRootFieldName = "azureVNets"
                    }
                },
                {
                    GqlRootFieldName.backupO365Mailbox,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupMailbox",
                        GqlRootFieldName = "backupO365Mailbox"
                    }
                },
                {
                    GqlRootFieldName.backupO365Onedrive,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupOnedrive",
                        GqlRootFieldName = "backupO365Onedrive"
                    }
                },
                {
                    GqlRootFieldName.backupO365SharePointSite,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupSharePointSite",
                        GqlRootFieldName = "backupO365SharePointSite"
                    }
                },
                {
                    GqlRootFieldName.backupO365SharepointDrive,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupSharepointDrive",
                        GqlRootFieldName = "backupO365SharepointDrive"
                    }
                },
                {
                    GqlRootFieldName.backupO365SharepointList,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupSharepointList",
                        GqlRootFieldName = "backupO365SharepointList"
                    }
                },
                {
                    GqlRootFieldName.backupO365Team,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "BackupTeam",
                        GqlRootFieldName = "backupO365Team"
                    }
                },
                {
                    GqlRootFieldName.batchExportHypervVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "BatchExportVm",
                        GqlRootFieldName = "batchExportHypervVm"
                    }
                },
                {
                    GqlRootFieldName.batchExportNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "BatchExportVm",
                        GqlRootFieldName = "batchExportNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.batchInstantRecoverHypervVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "BatchInstantRecoverVm",
                        GqlRootFieldName = "batchInstantRecoverHypervVm"
                    }
                },
                {
                    GqlRootFieldName.batchMountHypervVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "BatchMountVm",
                        GqlRootFieldName = "batchMountHypervVm"
                    }
                },
                {
                    GqlRootFieldName.batchMountNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "BatchMountVm",
                        GqlRootFieldName = "batchMountNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.batchOnDemandBackupHypervVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "BatchOnDemandBackupVm",
                        GqlRootFieldName = "batchOnDemandBackupHypervVm"
                    }
                },
                {
                    GqlRootFieldName.browseMssqlDatabaseSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "BrowseDatabaseSnapshot",
                        GqlRootFieldName = "browseMssqlDatabaseSnapshot"
                    }
                },
                {
                    GqlRootFieldName.browseO365TeamConvChannels,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "BrowseTeamConvChannels",
                        GqlRootFieldName = "browseO365TeamConvChannels"
                    }
                },
                {
                    GqlRootFieldName.bulkCreateOnDemandMssqlBackup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "BulkCreateOnDemandBackup",
                        GqlRootFieldName = "bulkCreateOnDemandMssqlBackup"
                    }
                },
                {
                    GqlRootFieldName.bulkDeleteAwsCloudAccountWithoutCft,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "BulkDeleteCloudAccountWithoutCft",
                        GqlRootFieldName = "bulkDeleteAwsCloudAccountWithoutCft"
                    }
                },
                {
                    GqlRootFieldName.bulkDeleteCassandraSources,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCassandra",
                        CmdletSwitchName = "BulkDeleteSources",
                        GqlRootFieldName = "bulkDeleteCassandraSources"
                    }
                },
                {
                    GqlRootFieldName.bulkDeleteFailoverCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "BulkDeleteFailover",
                        GqlRootFieldName = "bulkDeleteFailoverCluster"
                    }
                },
                {
                    GqlRootFieldName.bulkDeleteMongodbSources,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "BulkDeletedbSources",
                        GqlRootFieldName = "bulkDeleteMongodbSources"
                    }
                },
                {
                    GqlRootFieldName.bulkOnDemandSnapshotNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "BulkOnDemandSnapshotVm",
                        GqlRootFieldName = "bulkOnDemandSnapshotNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.bulkUpdateMssqlDbs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "BulkUpdateDbs",
                        GqlRootFieldName = "bulkUpdateMssqlDbs"
                    }
                },
                {
                    GqlRootFieldName.bulkUpdateOracleDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "BulkUpdateDatabases",
                        GqlRootFieldName = "bulkUpdateOracleDatabases"
                    }
                },
                {
                    GqlRootFieldName.bulkUpdateOracleHosts,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "BulkUpdateHosts",
                        GqlRootFieldName = "bulkUpdateOracleHosts"
                    }
                },
                {
                    GqlRootFieldName.bulkUpdateOracleRacs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "BulkUpdateRacs",
                        GqlRootFieldName = "bulkUpdateOracleRacs"
                    }
                },
                {
                    GqlRootFieldName.cancelActivitySeries,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateActivitySeries",
                        CmdletSwitchName = "Cancel",
                        GqlRootFieldName = "cancelActivitySeries"
                    }
                },
                {
                    GqlRootFieldName.cassandraColumnFamilies,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "ColumnFamilies",
                        GqlRootFieldName = "cassandraColumnFamilies"
                    }
                },
                {
                    GqlRootFieldName.cassandraColumnFamily,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "ColumnFamily",
                        GqlRootFieldName = "cassandraColumnFamily"
                    }
                },
                {
                    GqlRootFieldName.cassandraColumnFamilyRecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "ColumnFamilyRecoverableRange",
                        GqlRootFieldName = "cassandraColumnFamilyRecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.cassandraColumnFamilySchema,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "ColumnFamilySchema",
                        GqlRootFieldName = "cassandraColumnFamilySchema"
                    }
                },
                {
                    GqlRootFieldName.cassandraKeyspace,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "Keyspace",
                        GqlRootFieldName = "cassandraKeyspace"
                    }
                },
                {
                    GqlRootFieldName.cassandraKeyspaces,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "Keyspaces",
                        GqlRootFieldName = "cassandraKeyspaces"
                    }
                },
                {
                    GqlRootFieldName.cassandraSource,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "Source",
                        GqlRootFieldName = "cassandraSource"
                    }
                },
                {
                    GqlRootFieldName.cassandraSources,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCassandra",
                        CmdletSwitchName = "Sources",
                        GqlRootFieldName = "cassandraSources"
                    }
                },
                {
                    GqlRootFieldName.cdmMssqlLogShippingTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "CdmLogShippingTarget",
                        GqlRootFieldName = "cdmMssqlLogShippingTarget"
                    }
                },
                {
                    GqlRootFieldName.cdmMssqlLogShippingTargets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "CdmLogShippingTargets",
                        GqlRootFieldName = "cdmMssqlLogShippingTargets"
                    }
                },
                {
                    GqlRootFieldName.checkAzurePersistentStorageSubscriptionCanUnmap,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "CheckPersistentStorageSubscriptionCanUnmap",
                        GqlRootFieldName = "checkAzurePersistentStorageSubscriptionCanUnmap"
                    }
                },
                {
                    GqlRootFieldName.cluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Cluster",
                        GqlRootFieldName = "cluster"
                    }
                },
                {
                    GqlRootFieldName.clusterCertificates,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Certificates",
                        GqlRootFieldName = "clusterCertificates"
                    }
                },
                {
                    GqlRootFieldName.clusterConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "List",
                        GqlRootFieldName = "clusterConnection"
                    }
                },
                {
                    GqlRootFieldName.clusterCsr,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Csr",
                        GqlRootFieldName = "clusterCsr"
                    }
                },
                {
                    GqlRootFieldName.clusterDefaultGateway,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "DefaultGateway",
                        GqlRootFieldName = "clusterDefaultGateway"
                    }
                },
                {
                    GqlRootFieldName.clusterDns,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Dns",
                        GqlRootFieldName = "clusterDns"
                    }
                },
                {
                    GqlRootFieldName.clusterFloatingIps,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "FloatingIps",
                        GqlRootFieldName = "clusterFloatingIps"
                    }
                },
                {
                    GqlRootFieldName.clusterGroupByConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "GroupByList",
                        GqlRootFieldName = "clusterGroupByConnection"
                    }
                },
                {
                    GqlRootFieldName.clusterIpmi,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Ipmi",
                        GqlRootFieldName = "clusterIpmi"
                    }
                },
                {
                    GqlRootFieldName.clusterIpv6Mode,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Ipv6Mode",
                        GqlRootFieldName = "clusterIpv6Mode"
                    }
                },
                {
                    GqlRootFieldName.clusterNetworkInterfaces,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "NetworkInterfaces",
                        GqlRootFieldName = "clusterNetworkInterfaces"
                    }
                },
                {
                    GqlRootFieldName.clusterNodes,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Nodes",
                        GqlRootFieldName = "clusterNodes"
                    }
                },
                {
                    GqlRootFieldName.clusterNtpServers,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "NtpServers",
                        GqlRootFieldName = "clusterNtpServers"
                    }
                },
                {
                    GqlRootFieldName.clusterOperationJobProgress,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "OperationJobProgress",
                        GqlRootFieldName = "clusterOperationJobProgress"
                    }
                },
                {
                    GqlRootFieldName.clusterProxy,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Proxy",
                        GqlRootFieldName = "clusterProxy"
                    }
                },
                {
                    GqlRootFieldName.clusterRegistrationProductInfo,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "RegistrationProductInfo",
                        GqlRootFieldName = "clusterRegistrationProductInfo"
                    }
                },
                {
                    GqlRootFieldName.clusterReportMigrationCount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "ReportMigrationCount",
                        GqlRootFieldName = "clusterReportMigrationCount"
                    }
                },
                {
                    GqlRootFieldName.clusterReportMigrationJobStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "ReportMigrationJobStatus",
                        GqlRootFieldName = "clusterReportMigrationJobStatus"
                    }
                },
                {
                    GqlRootFieldName.clusterReportMigrationStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "ReportMigrationStatus",
                        GqlRootFieldName = "clusterReportMigrationStatus"
                    }
                },
                {
                    GqlRootFieldName.clusterSlaDomains,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "ClusterDomains",
                        GqlRootFieldName = "clusterSlaDomains"
                    }
                },
                {
                    GqlRootFieldName.clusterTypeList,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "TypeList",
                        GqlRootFieldName = "clusterTypeList"
                    }
                },
                {
                    GqlRootFieldName.clusterVlans,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Vlans",
                        GqlRootFieldName = "clusterVlans"
                    }
                },
                {
                    GqlRootFieldName.clusterWebSignedCertificate,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "WebSignedCertificate",
                        GqlRootFieldName = "clusterWebSignedCertificate"
                    }
                },
                {
                    GqlRootFieldName.clusterWithUpgradesInfo,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "WithUpgradesInfo",
                        GqlRootFieldName = "clusterWithUpgradesInfo"
                    }
                },
                {
                    GqlRootFieldName.completeAzureCloudAccountOauth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CompleteCloudAccountOauth",
                        GqlRootFieldName = "completeAzureCloudAccountOauth"
                    }
                },
                {
                    GqlRootFieldName.countOfObjectsProtectedBySlas,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "CountOfObjectsProtected",
                        GqlRootFieldName = "countOfObjectsProtectedBySlas"
                    }
                },
                {
                    GqlRootFieldName.createAutomaticAwsTargetMapping,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateAutomaticTargetMapping",
                        GqlRootFieldName = "createAutomaticAwsTargetMapping"
                    }
                },
                {
                    GqlRootFieldName.createAutomaticAzureTargetMapping,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateAutomaticTargetMapping",
                        GqlRootFieldName = "createAutomaticAzureTargetMapping"
                    }
                },
                {
                    GqlRootFieldName.createAwsAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateAccount",
                        GqlRootFieldName = "createAwsAccount"
                    }
                },
                {
                    GqlRootFieldName.createAwsCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateCluster",
                        GqlRootFieldName = "createAwsCluster"
                    }
                },
                {
                    GqlRootFieldName.createAwsComputeSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateComputeSetting",
                        GqlRootFieldName = "createAwsComputeSetting"
                    }
                },
                {
                    GqlRootFieldName.createAwsExocomputeConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateExocomputeConfigs",
                        GqlRootFieldName = "createAwsExocomputeConfigs"
                    }
                },
                {
                    GqlRootFieldName.createAwsReaderTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateReaderTarget",
                        GqlRootFieldName = "createAwsReaderTarget"
                    }
                },
                {
                    GqlRootFieldName.createAwsTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateTarget",
                        GqlRootFieldName = "createAwsTarget"
                    }
                },
                {
                    GqlRootFieldName.createAzureAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateAccount",
                        GqlRootFieldName = "createAzureAccount"
                    }
                },
                {
                    GqlRootFieldName.createAzureCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateCluster",
                        GqlRootFieldName = "createAzureCluster"
                    }
                },
                {
                    GqlRootFieldName.createAzureReaderTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateReaderTarget",
                        GqlRootFieldName = "createAzureReaderTarget"
                    }
                },
                {
                    GqlRootFieldName.createAzureSaasAppAad,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateSaasAppAad",
                        GqlRootFieldName = "createAzureSaasAppAad"
                    }
                },
                {
                    GqlRootFieldName.createAzureTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateTarget",
                        GqlRootFieldName = "createAzureTarget"
                    }
                },
                {
                    GqlRootFieldName.createCassandraSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCassandra",
                        CmdletSwitchName = "CreateSource",
                        GqlRootFieldName = "createCassandraSource"
                    }
                },
                {
                    GqlRootFieldName.createCloudNativeAwsStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "CreateCloudNativeStorageSetting",
                        GqlRootFieldName = "createCloudNativeAwsStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.createCloudNativeAzureStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateCloudNativeStorageSetting",
                        GqlRootFieldName = "createCloudNativeAzureStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.createCloudNativeRcvAzureStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "CreateCloudNativeRcvStorageSetting",
                        GqlRootFieldName = "createCloudNativeRcvAzureStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.createFailoverCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "CreateFailover",
                        GqlRootFieldName = "createFailoverCluster"
                    }
                },
                {
                    GqlRootFieldName.createGlobalSla,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "CreateGlobal",
                        GqlRootFieldName = "createGlobalSla"
                    }
                },
                {
                    GqlRootFieldName.createHypervVirtualMachineSnapshotMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "CreateVirtualMachineSnapshotMount",
                        GqlRootFieldName = "createHypervVirtualMachineSnapshotMount"
                    }
                },
                {
                    GqlRootFieldName.createK8sCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "CreateK8s",
                        GqlRootFieldName = "createK8sCluster"
                    }
                },
                {
                    GqlRootFieldName.createMongodbSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "CreatedbSource",
                        GqlRootFieldName = "createMongodbSource"
                    }
                },
                {
                    GqlRootFieldName.createMssqlLiveMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "CreateLiveMount",
                        GqlRootFieldName = "createMssqlLiveMount"
                    }
                },
                {
                    GqlRootFieldName.createMssqlLogShippingConfiguration,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "CreateLogShippingConfiguration",
                        GqlRootFieldName = "createMssqlLogShippingConfiguration"
                    }
                },
                {
                    GqlRootFieldName.createNutanixCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "CreateCluster",
                        GqlRootFieldName = "createNutanixCluster"
                    }
                },
                {
                    GqlRootFieldName.createNutanixPrismCentral,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "CreatePrismCentral",
                        GqlRootFieldName = "createNutanixPrismCentral"
                    }
                },
                {
                    GqlRootFieldName.createO365AppComplete,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "CreateAppComplete",
                        GqlRootFieldName = "createO365AppComplete"
                    }
                },
                {
                    GqlRootFieldName.createO365AppKickoff,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "CreateAppKickoff",
                        GqlRootFieldName = "createO365AppKickoff"
                    }
                },
                {
                    GqlRootFieldName.createOnDemandDb2Backup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "CreateOnDemandBackup",
                        GqlRootFieldName = "createOnDemandDb2Backup"
                    }
                },
                {
                    GqlRootFieldName.createOnDemandMssqlBackup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "CreateOnDemandBackup",
                        GqlRootFieldName = "createOnDemandMssqlBackup"
                    }
                },
                {
                    GqlRootFieldName.createOnDemandNutanixBackup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "CreateOnDemandBackup",
                        GqlRootFieldName = "createOnDemandNutanixBackup"
                    }
                },
                {
                    GqlRootFieldName.createOraclePdbRestore,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "CreatePdbRestore",
                        GqlRootFieldName = "createOraclePdbRestore"
                    }
                },
                {
                    GqlRootFieldName.createVsphereAdvancedTag,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "CreateAdvancedTag",
                        GqlRootFieldName = "createVsphereAdvancedTag"
                    }
                },
                {
                    GqlRootFieldName.createVsphereVcenter,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "Create",
                        GqlRootFieldName = "createVsphereVcenter"
                    }
                },
                {
                    GqlRootFieldName.databaseLogReportForCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "DatabaseLogReport",
                        GqlRootFieldName = "databaseLogReportForCluster"
                    }
                },
                {
                    GqlRootFieldName.databaseLogReportingPropertiesForCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "DatabaseLogReportingProperties",
                        GqlRootFieldName = "databaseLogReportingPropertiesForCluster"
                    }
                },
                {
                    GqlRootFieldName.db2Database,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "Database",
                        GqlRootFieldName = "db2Database"
                    }
                },
                {
                    GqlRootFieldName.db2Databases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "Databases",
                        GqlRootFieldName = "db2Databases"
                    }
                },
                {
                    GqlRootFieldName.db2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "Instance",
                        GqlRootFieldName = "db2Instance"
                    }
                },
                {
                    GqlRootFieldName.db2Instances,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "Instances",
                        GqlRootFieldName = "db2Instances"
                    }
                },
                {
                    GqlRootFieldName.db2LogSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "LogSnapshot",
                        GqlRootFieldName = "db2LogSnapshot"
                    }
                },
                {
                    GqlRootFieldName.db2LogSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "LogSnapshots",
                        GqlRootFieldName = "db2LogSnapshots"
                    }
                },
                {
                    GqlRootFieldName.db2RecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "RecoverableRange",
                        GqlRootFieldName = "db2RecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.db2RecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryDb2",
                        CmdletSwitchName = "RecoverableRanges",
                        GqlRootFieldName = "db2RecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.deleteAllOracleDatabaseSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "DeleteAllDatabaseSnapshots",
                        GqlRootFieldName = "deleteAllOracleDatabaseSnapshots"
                    }
                },
                {
                    GqlRootFieldName.deleteAwsCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "DeleteCluster",
                        GqlRootFieldName = "deleteAwsCluster"
                    }
                },
                {
                    GqlRootFieldName.deleteAwsComputeSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "DeleteComputeSetting",
                        GqlRootFieldName = "deleteAwsComputeSetting"
                    }
                },
                {
                    GqlRootFieldName.deleteAwsExocomputeConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "DeleteExocomputeConfigs",
                        GqlRootFieldName = "deleteAwsExocomputeConfigs"
                    }
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "DeleteCloudAccount",
                        GqlRootFieldName = "deleteAzureCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccountExocomputeConfigurations,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "DeleteCloudAccountExocomputeConfigurations",
                        GqlRootFieldName = "deleteAzureCloudAccountExocomputeConfigurations"
                    }
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccountWithoutOauth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "DeleteCloudAccountWithoutOauth",
                        GqlRootFieldName = "deleteAzureCloudAccountWithoutOauth"
                    }
                },
                {
                    GqlRootFieldName.deleteAzureCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "DeleteCluster",
                        GqlRootFieldName = "deleteAzureCluster"
                    }
                },
                {
                    GqlRootFieldName.deleteCassandraSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCassandra",
                        CmdletSwitchName = "DeleteSource",
                        GqlRootFieldName = "deleteCassandraSource"
                    }
                },
                {
                    GqlRootFieldName.deleteDb2Database,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "DeleteDatabase",
                        GqlRootFieldName = "deleteDb2Database"
                    }
                },
                {
                    GqlRootFieldName.deleteDb2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "DeleteInstance",
                        GqlRootFieldName = "deleteDb2Instance"
                    }
                },
                {
                    GqlRootFieldName.deleteFailoverCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "DeleteFailover",
                        GqlRootFieldName = "deleteFailoverCluster"
                    }
                },
                {
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DeleteVirtualMachineSnapshot",
                        GqlRootFieldName = "deleteHypervVirtualMachineSnapshot"
                    }
                },
                {
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshotMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DeleteVirtualMachineSnapshotMount",
                        GqlRootFieldName = "deleteHypervVirtualMachineSnapshotMount"
                    }
                },
                {
                    GqlRootFieldName.deleteLdapPrincipals,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateLdap",
                        CmdletSwitchName = "DeletePrincipals",
                        GqlRootFieldName = "deleteLdapPrincipals"
                    }
                },
                {
                    GqlRootFieldName.deleteMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "DeleteSource",
                        GqlRootFieldName = "deleteMongoSource"
                    }
                },
                {
                    GqlRootFieldName.deleteMongodbSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "DeletedbSource",
                        GqlRootFieldName = "deleteMongodbSource"
                    }
                },
                {
                    GqlRootFieldName.deleteMssqlDbSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "DeleteDbSnapshots",
                        GqlRootFieldName = "deleteMssqlDbSnapshots"
                    }
                },
                {
                    GqlRootFieldName.deleteMssqlLiveMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "DeleteLiveMount",
                        GqlRootFieldName = "deleteMssqlLiveMount"
                    }
                },
                {
                    GqlRootFieldName.deleteNutanixCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DeleteCluster",
                        GqlRootFieldName = "deleteNutanixCluster"
                    }
                },
                {
                    GqlRootFieldName.deleteNutanixMountV1,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DeleteMountV1",
                        GqlRootFieldName = "deleteNutanixMountV1"
                    }
                },
                {
                    GqlRootFieldName.deleteNutanixPrismCentral,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DeletePrismCentral",
                        GqlRootFieldName = "deleteNutanixPrismCentral"
                    }
                },
                {
                    GqlRootFieldName.deleteNutanixSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DeleteSnapshot",
                        GqlRootFieldName = "deleteNutanixSnapshot"
                    }
                },
                {
                    GqlRootFieldName.deleteNutanixSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DeleteSnapshots",
                        GqlRootFieldName = "deleteNutanixSnapshots"
                    }
                },
                {
                    GqlRootFieldName.deleteO365AzureApp,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "DeleteAzureApp",
                        GqlRootFieldName = "deleteO365AzureApp"
                    }
                },
                {
                    GqlRootFieldName.deleteO365Org,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "DeleteOrg",
                        GqlRootFieldName = "deleteO365Org"
                    }
                },
                {
                    GqlRootFieldName.deleteO365ServiceAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "DeleteServiceAccount",
                        GqlRootFieldName = "deleteO365ServiceAccount"
                    }
                },
                {
                    GqlRootFieldName.deleteOracleMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "DeleteMount",
                        GqlRootFieldName = "deleteOracleMount"
                    }
                },
                {
                    GqlRootFieldName.deleteVsphereAdvancedTag,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "DeleteAdvancedTag",
                        GqlRootFieldName = "deleteVsphereAdvancedTag"
                    }
                },
                {
                    GqlRootFieldName.deleteVsphereLiveMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "DeleteLiveMount",
                        GqlRootFieldName = "deleteVsphereLiveMount"
                    }
                },
                {
                    GqlRootFieldName.discoverDb2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "DiscoverInstance",
                        GqlRootFieldName = "discoverDb2Instance"
                    }
                },
                {
                    GqlRootFieldName.discoverMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "DiscoverSource",
                        GqlRootFieldName = "discoverMongoSource"
                    }
                },
                {
                    GqlRootFieldName.doesAzureNativeResourceGroupExist,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "DoesNativeResourceGroupExist",
                        GqlRootFieldName = "doesAzureNativeResourceGroupExist"
                    }
                },
                {
                    GqlRootFieldName.downloadDb2Snapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "DownloadSnapshot",
                        GqlRootFieldName = "downloadDb2Snapshot"
                    }
                },
                {
                    GqlRootFieldName.downloadDb2SnapshotsForPointInTimeRecovery,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "DownloadSnapshotsForPointInTimeRecovery",
                        GqlRootFieldName = "downloadDb2SnapshotsForPointInTimeRecovery"
                    }
                },
                {
                    GqlRootFieldName.downloadFilesNutanixSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DownloadFilesSnapshot",
                        GqlRootFieldName = "downloadFilesNutanixSnapshot"
                    }
                },
                {
                    GqlRootFieldName.downloadHypervSnapshotFromLocation,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DownloadSnapshotFromLocation",
                        GqlRootFieldName = "downloadHypervSnapshotFromLocation"
                    }
                },
                {
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DownloadVirtualMachineSnapshot",
                        GqlRootFieldName = "downloadHypervVirtualMachineSnapshot"
                    }
                },
                {
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshotFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DownloadVirtualMachineSnapshotFiles",
                        GqlRootFieldName = "downloadHypervVirtualMachineSnapshotFiles"
                    }
                },
                {
                    GqlRootFieldName.downloadMssqlDatabaseBackupFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "DownloadDatabaseBackupFiles",
                        GqlRootFieldName = "downloadMssqlDatabaseBackupFiles"
                    }
                },
                {
                    GqlRootFieldName.downloadMssqlDatabaseFilesFromArchivalLocation,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "DownloadDatabaseFilesFromArchivalLocation",
                        GqlRootFieldName = "downloadMssqlDatabaseFilesFromArchivalLocation"
                    }
                },
                {
                    GqlRootFieldName.downloadNutanixSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DownloadSnapshot",
                        GqlRootFieldName = "downloadNutanixSnapshot"
                    }
                },
                {
                    GqlRootFieldName.downloadNutanixVmFromLocation,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "DownloadVmFromLocation",
                        GqlRootFieldName = "downloadNutanixVmFromLocation"
                    }
                },
                {
                    GqlRootFieldName.downloadOracleDatabaseSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "DownloadDatabaseSnapshot",
                        GqlRootFieldName = "downloadOracleDatabaseSnapshot"
                    }
                },
                {
                    GqlRootFieldName.downloadVsphereVirtualMachineFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "DownloadVirtualMachineFiles",
                        GqlRootFieldName = "downloadVsphereVirtualMachineFiles"
                    }
                },
                {
                    GqlRootFieldName.enableO365SharePoint,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "EnableSharePoint",
                        GqlRootFieldName = "enableO365SharePoint"
                    }
                },
                {
                    GqlRootFieldName.enableO365Teams,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "EnableTeams",
                        GqlRootFieldName = "enableO365Teams"
                    }
                },
                {
                    GqlRootFieldName.excludeAwsNativeEbsVolumesFromSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "ExcludeNativeEbsVolumesFromSnapshot",
                        GqlRootFieldName = "excludeAwsNativeEbsVolumesFromSnapshot"
                    }
                },
                {
                    GqlRootFieldName.excludeAzureNativeManagedDisksFromSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "ExcludeNativeManagedDisksFromSnapshot",
                        GqlRootFieldName = "excludeAzureNativeManagedDisksFromSnapshot"
                    }
                },
                {
                    GqlRootFieldName.expireDownloadedDb2Snapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "ExpireDownloadedSnapshots",
                        GqlRootFieldName = "expireDownloadedDb2Snapshots"
                    }
                },
                {
                    GqlRootFieldName.exportHypervVirtualMachine,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "ExportVirtualMachine",
                        GqlRootFieldName = "exportHypervVirtualMachine"
                    }
                },
                {
                    GqlRootFieldName.exportMssqlDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "ExportDatabase",
                        GqlRootFieldName = "exportMssqlDatabase"
                    }
                },
                {
                    GqlRootFieldName.exportNutanixSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "ExportSnapshot",
                        GqlRootFieldName = "exportNutanixSnapshot"
                    }
                },
                {
                    GqlRootFieldName.exportO365Mailbox,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "ExportMailbox",
                        GqlRootFieldName = "exportO365Mailbox"
                    }
                },
                {
                    GqlRootFieldName.exportOracleDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "ExportDatabase",
                        GqlRootFieldName = "exportOracleDatabase"
                    }
                },
                {
                    GqlRootFieldName.exportOracleTablespace,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "ExportTablespace",
                        GqlRootFieldName = "exportOracleTablespace"
                    }
                },
                {
                    GqlRootFieldName.exportSlaManagedVolumeSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "ExportManagedVolumeSnapshot",
                        GqlRootFieldName = "exportSlaManagedVolumeSnapshot"
                    }
                },
                {
                    GqlRootFieldName.finalizeAwsCloudAccountDeletion,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "FinalizeCloudAccountDeletion",
                        GqlRootFieldName = "finalizeAwsCloudAccountDeletion"
                    }
                },
                {
                    GqlRootFieldName.finalizeAwsCloudAccountProtection,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "FinalizeCloudAccountProtection",
                        GqlRootFieldName = "finalizeAwsCloudAccountProtection"
                    }
                },
                {
                    GqlRootFieldName.getPendingSlaAssignments,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "GetPendingAssignments",
                        GqlRootFieldName = "getPendingSlaAssignments"
                    }
                },
                {
                    GqlRootFieldName.globalSlaFilterConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "GlobalFilterList",
                        GqlRootFieldName = "globalSlaFilterConnection"
                    }
                },
                {
                    GqlRootFieldName.globalSlaStatuses,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "GlobalStatuses",
                        GqlRootFieldName = "globalSlaStatuses"
                    }
                },
                {
                    GqlRootFieldName.hostFailoverCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "HostFailover",
                        GqlRootFieldName = "hostFailoverCluster"
                    }
                },
                {
                    GqlRootFieldName.hypervCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Cluster",
                        GqlRootFieldName = "hypervCluster"
                    }
                },
                {
                    GqlRootFieldName.hypervDeleteAllSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "DeleteAllSnapshots",
                        GqlRootFieldName = "hypervDeleteAllSnapshots"
                    }
                },
                {
                    GqlRootFieldName.hypervHostAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "HostAsyncRequestStatus",
                        GqlRootFieldName = "hypervHostAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.hypervMounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Mounts",
                        GqlRootFieldName = "hypervMounts"
                    }
                },
                {
                    GqlRootFieldName.hypervOnDemandSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "OnDemandSnapshot",
                        GqlRootFieldName = "hypervOnDemandSnapshot"
                    }
                },
                {
                    GqlRootFieldName.hypervScvmm,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Scvmm",
                        GqlRootFieldName = "hypervScvmm"
                    }
                },
                {
                    GqlRootFieldName.hypervScvmmAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "ScvmmAsyncRequestStatus",
                        GqlRootFieldName = "hypervScvmmAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.hypervScvmmDelete,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "ScvmmDelete",
                        GqlRootFieldName = "hypervScvmmDelete"
                    }
                },
                {
                    GqlRootFieldName.hypervScvmmUpdate,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "ScvmmUpdate",
                        GqlRootFieldName = "hypervScvmmUpdate"
                    }
                },
                {
                    GqlRootFieldName.hypervScvmms,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Scvmms",
                        GqlRootFieldName = "hypervScvmms"
                    }
                },
                {
                    GqlRootFieldName.hypervServer,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Server",
                        GqlRootFieldName = "hypervServer"
                    }
                },
                {
                    GqlRootFieldName.hypervServers,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "Servers",
                        GqlRootFieldName = "hypervServers"
                    }
                },
                {
                    GqlRootFieldName.hypervTopLevelDescendants,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "TopLevelDescendants",
                        GqlRootFieldName = "hypervTopLevelDescendants"
                    }
                },
                {
                    GqlRootFieldName.hypervVirtualMachine,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "VirtualMachine",
                        GqlRootFieldName = "hypervVirtualMachine"
                    }
                },
                {
                    GqlRootFieldName.hypervVirtualMachineAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "VirtualMachineAsyncRequestStatus",
                        GqlRootFieldName = "hypervVirtualMachineAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.hypervVirtualMachines,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "VirtualMachines",
                        GqlRootFieldName = "hypervVirtualMachines"
                    }
                },
                {
                    GqlRootFieldName.hypervVmDetail,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "VmDetail",
                        GqlRootFieldName = "hypervVmDetail"
                    }
                },
                {
                    GqlRootFieldName.insertCustomerO365App,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "InsertCustomerApp",
                        GqlRootFieldName = "insertCustomerO365App"
                    }
                },
                {
                    GqlRootFieldName.instantRecoverHypervVirtualMachineSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "InstantRecoverVirtualMachineSnapshot",
                        GqlRootFieldName = "instantRecoverHypervVirtualMachineSnapshot"
                    }
                },
                {
                    GqlRootFieldName.instantRecoverOracleSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "InstantRecoverSnapshot",
                        GqlRootFieldName = "instantRecoverOracleSnapshot"
                    }
                },
                {
                    GqlRootFieldName.isAwsNativeEbsVolumeSnapshotRestorable,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "IsNativeEbsVolumeSnapshotRestorable",
                        GqlRootFieldName = "isAwsNativeEbsVolumeSnapshotRestorable"
                    }
                },
                {
                    GqlRootFieldName.isAwsNativeRdsInstanceLaunchConfigurationValid,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "IsNativeRdsInstanceLaunchConfigurationValid",
                        GqlRootFieldName = "isAwsNativeRdsInstanceLaunchConfigurationValid"
                    }
                },
                {
                    GqlRootFieldName.isAwsS3BucketNameAvailable,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "IsS3BucketNameAvailable",
                        GqlRootFieldName = "isAwsS3BucketNameAvailable"
                    }
                },
                {
                    GqlRootFieldName.isAzureNativeManagedDiskSnapshotRestorable,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "IsNativeManagedDiskSnapshotRestorable",
                        GqlRootFieldName = "isAzureNativeManagedDiskSnapshotRestorable"
                    }
                },
                {
                    GqlRootFieldName.isAzureNativeSqlDatabaseSnapshotPersistent,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "IsNativeSqlDatabaseSnapshotPersistent",
                        GqlRootFieldName = "isAzureNativeSqlDatabaseSnapshotPersistent"
                    }
                },
                {
                    GqlRootFieldName.isAzureStorageAccountNameAvailable,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "IsStorageAccountNameAvailable",
                        GqlRootFieldName = "isAzureStorageAccountNameAvailable"
                    }
                },
                {
                    GqlRootFieldName.isTotpAckNecessaryForCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "IsTotpAckNecessary",
                        GqlRootFieldName = "isTotpAckNecessaryForCluster"
                    }
                },
                {
                    GqlRootFieldName.k8sClusters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "K8s",
                        GqlRootFieldName = "k8sClusters"
                    }
                },
                {
                    GqlRootFieldName.ldapAuthorizedPrincipalConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryLdap",
                        CmdletSwitchName = "AuthorizedPrincipalList",
                        GqlRootFieldName = "ldapAuthorizedPrincipalConnection"
                    }
                },
                {
                    GqlRootFieldName.ldapIntegrationConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryLdap",
                        CmdletSwitchName = "IntegrationList",
                        GqlRootFieldName = "ldapIntegrationConnection"
                    }
                },
                {
                    GqlRootFieldName.ldapPrincipalConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryLdap",
                        CmdletSwitchName = "PrincipalList",
                        GqlRootFieldName = "ldapPrincipalConnection"
                    }
                },
                {
                    GqlRootFieldName.listO365Apps,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "ListApps",
                        GqlRootFieldName = "listO365Apps"
                    }
                },
                {
                    GqlRootFieldName.mapAzureCloudAccountExocomputeSubscription,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "MapCloudAccountExocomputeSubscription",
                        GqlRootFieldName = "mapAzureCloudAccountExocomputeSubscription"
                    }
                },
                {
                    GqlRootFieldName.mapAzureCloudAccountToPersistentStorageLocation,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "MapCloudAccountToPersistentStorageLocation",
                        GqlRootFieldName = "mapAzureCloudAccountToPersistentStorageLocation"
                    }
                },
                {
                    GqlRootFieldName.migrateNutanixMountV1,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "MigrateMountV1",
                        GqlRootFieldName = "migrateNutanixMountV1"
                    }
                },
                {
                    GqlRootFieldName.mongoBulkRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "BulkRecoverableRanges",
                        GqlRootFieldName = "mongoBulkRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.mongoCollection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Collection",
                        GqlRootFieldName = "mongoCollection"
                    }
                },
                {
                    GqlRootFieldName.mongoCollections,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Collections",
                        GqlRootFieldName = "mongoCollections"
                    }
                },
                {
                    GqlRootFieldName.mongoDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Database",
                        GqlRootFieldName = "mongoDatabase"
                    }
                },
                {
                    GqlRootFieldName.mongoDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Databases",
                        GqlRootFieldName = "mongoDatabases"
                    }
                },
                {
                    GqlRootFieldName.mongoRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "RecoverableRanges",
                        GqlRootFieldName = "mongoRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.mongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Source",
                        GqlRootFieldName = "mongoSource"
                    }
                },
                {
                    GqlRootFieldName.mongoSources,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "Sources",
                        GqlRootFieldName = "mongoSources"
                    }
                },
                {
                    GqlRootFieldName.mongodbBulkRecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbBulkRecoverableRange",
                        GqlRootFieldName = "mongodbBulkRecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.mongodbCollection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbCollection",
                        GqlRootFieldName = "mongodbCollection"
                    }
                },
                {
                    GqlRootFieldName.mongodbCollectionRecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbCollectionRecoverableRange",
                        GqlRootFieldName = "mongodbCollectionRecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.mongodbCollections,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbCollections",
                        GqlRootFieldName = "mongodbCollections"
                    }
                },
                {
                    GqlRootFieldName.mongodbDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbDatabase",
                        GqlRootFieldName = "mongodbDatabase"
                    }
                },
                {
                    GqlRootFieldName.mongodbDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbDatabases",
                        GqlRootFieldName = "mongodbDatabases"
                    }
                },
                {
                    GqlRootFieldName.mongodbSource,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbSource",
                        GqlRootFieldName = "mongodbSource"
                    }
                },
                {
                    GqlRootFieldName.mongodbSources,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMongo",
                        CmdletSwitchName = "DbSources",
                        GqlRootFieldName = "mongodbSources"
                    }
                },
                {
                    GqlRootFieldName.mountNutanixSnapshotV1,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "MountSnapshotV1",
                        GqlRootFieldName = "mountNutanixSnapshotV1"
                    }
                },
                {
                    GqlRootFieldName.mountOracleDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "MountDatabase",
                        GqlRootFieldName = "mountOracleDatabase"
                    }
                },
                {
                    GqlRootFieldName.mssqlAvailabilityGroup,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "AvailabilityGroup",
                        GqlRootFieldName = "mssqlAvailabilityGroup"
                    }
                },
                {
                    GqlRootFieldName.mssqlCompatibleInstances,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "CompatibleInstances",
                        GqlRootFieldName = "mssqlCompatibleInstances"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "Database",
                        GqlRootFieldName = "mssqlDatabase"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabaseLiveMounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "DatabaseLiveMounts",
                        GqlRootFieldName = "mssqlDatabaseLiveMounts"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabaseMissedRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "DatabaseMissedRecoverableRanges",
                        GqlRootFieldName = "mssqlDatabaseMissedRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabaseMissedSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "DatabaseMissedSnapshots",
                        GqlRootFieldName = "mssqlDatabaseMissedSnapshots"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabaseRestoreEstimate,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "DatabaseRestoreEstimate",
                        GqlRootFieldName = "mssqlDatabaseRestoreEstimate"
                    }
                },
                {
                    GqlRootFieldName.mssqlDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "Databases",
                        GqlRootFieldName = "mssqlDatabases"
                    }
                },
                {
                    GqlRootFieldName.mssqlDefaultProperties,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "DefaultProperties",
                        GqlRootFieldName = "mssqlDefaultProperties"
                    }
                },
                {
                    GqlRootFieldName.mssqlInstance,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "Instance",
                        GqlRootFieldName = "mssqlInstance"
                    }
                },
                {
                    GqlRootFieldName.mssqlLogShippingTargets,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "LogShippingTargets",
                        GqlRootFieldName = "mssqlLogShippingTargets"
                    }
                },
                {
                    GqlRootFieldName.mssqlRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "RecoverableRanges",
                        GqlRootFieldName = "mssqlRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.mssqlTopLevelDescendants,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryMssql",
                        CmdletSwitchName = "TopLevelDescendants",
                        GqlRootFieldName = "mssqlTopLevelDescendants"
                    }
                },
                {
                    GqlRootFieldName.nutanixBrowseSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "BrowseSnapshot",
                        GqlRootFieldName = "nutanixBrowseSnapshot"
                    }
                },
                {
                    GqlRootFieldName.nutanixCategory,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Category",
                        GqlRootFieldName = "nutanixCategory"
                    }
                },
                {
                    GqlRootFieldName.nutanixCategoryValue,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "CategoryValue",
                        GqlRootFieldName = "nutanixCategoryValue"
                    }
                },
                {
                    GqlRootFieldName.nutanixCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Cluster",
                        GqlRootFieldName = "nutanixCluster"
                    }
                },
                {
                    GqlRootFieldName.nutanixClusterAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "ClusterAsyncRequestStatus",
                        GqlRootFieldName = "nutanixClusterAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.nutanixClusterContainers,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "ClusterContainers",
                        GqlRootFieldName = "nutanixClusterContainers"
                    }
                },
                {
                    GqlRootFieldName.nutanixClusterNetworks,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "ClusterNetworks",
                        GqlRootFieldName = "nutanixClusterNetworks"
                    }
                },
                {
                    GqlRootFieldName.nutanixClusters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Clusters",
                        GqlRootFieldName = "nutanixClusters"
                    }
                },
                {
                    GqlRootFieldName.nutanixMounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Mounts",
                        GqlRootFieldName = "nutanixMounts"
                    }
                },
                {
                    GqlRootFieldName.nutanixPrismCentral,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "PrismCentral",
                        GqlRootFieldName = "nutanixPrismCentral"
                    }
                },
                {
                    GqlRootFieldName.nutanixPrismCentrals,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "PrismCentrals",
                        GqlRootFieldName = "nutanixPrismCentrals"
                    }
                },
                {
                    GqlRootFieldName.nutanixSnapshotDetail,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "SnapshotDetail",
                        GqlRootFieldName = "nutanixSnapshotDetail"
                    }
                },
                {
                    GqlRootFieldName.nutanixTopLevelDescendants,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "TopLevelDescendants",
                        GqlRootFieldName = "nutanixTopLevelDescendants"
                    }
                },
                {
                    GqlRootFieldName.nutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Vm",
                        GqlRootFieldName = "nutanixVm"
                    }
                },
                {
                    GqlRootFieldName.nutanixVmAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "VmAsyncRequestStatus",
                        GqlRootFieldName = "nutanixVmAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.nutanixVmMissedSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "VmMissedSnapshots",
                        GqlRootFieldName = "nutanixVmMissedSnapshots"
                    }
                },
                {
                    GqlRootFieldName.nutanixVms,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "Vms",
                        GqlRootFieldName = "nutanixVms"
                    }
                },
                {
                    GqlRootFieldName.o365Calendar,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Calendar",
                        GqlRootFieldName = "o365Calendar"
                    }
                },
                {
                    GqlRootFieldName.o365Groups,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Groups",
                        GqlRootFieldName = "o365Groups"
                    }
                },
                {
                    GqlRootFieldName.o365License,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "License",
                        GqlRootFieldName = "o365License"
                    }
                },
                {
                    GqlRootFieldName.o365Mailbox,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Mailbox",
                        GqlRootFieldName = "o365Mailbox"
                    }
                },
                {
                    GqlRootFieldName.o365Mailboxes,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Mailboxes",
                        GqlRootFieldName = "o365Mailboxes"
                    }
                },
                {
                    GqlRootFieldName.o365OauthConsentComplete,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "OauthConsentComplete",
                        GqlRootFieldName = "o365OauthConsentComplete"
                    }
                },
                {
                    GqlRootFieldName.o365OauthConsentKickoff,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "OauthConsentKickoff",
                        GqlRootFieldName = "o365OauthConsentKickoff"
                    }
                },
                {
                    GqlRootFieldName.o365ObjectAncestors,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "ObjectAncestors",
                        GqlRootFieldName = "o365ObjectAncestors"
                    }
                },
                {
                    GqlRootFieldName.o365Onedrive,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Onedrive",
                        GqlRootFieldName = "o365Onedrive"
                    }
                },
                {
                    GqlRootFieldName.o365Onedrives,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Onedrives",
                        GqlRootFieldName = "o365Onedrives"
                    }
                },
                {
                    GqlRootFieldName.o365Org,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Org",
                        GqlRootFieldName = "o365Org"
                    }
                },
                {
                    GqlRootFieldName.o365OrgAtSnappableLevel,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "OrgAtSnappableLevel",
                        GqlRootFieldName = "o365OrgAtSnappableLevel"
                    }
                },
                {
                    GqlRootFieldName.o365OrgSummaries,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "OrgSummaries",
                        GqlRootFieldName = "o365OrgSummaries"
                    }
                },
                {
                    GqlRootFieldName.o365Orgs,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Orgs",
                        GqlRootFieldName = "o365Orgs"
                    }
                },
                {
                    GqlRootFieldName.o365PdlGroups,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "PdlGroups",
                        GqlRootFieldName = "o365PdlGroups"
                    }
                },
                {
                    GqlRootFieldName.o365SaaSSetupKickoff,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "SaaSSetupKickoff",
                        GqlRootFieldName = "o365SaaSSetupKickoff"
                    }
                },
                {
                    GqlRootFieldName.o365SaasSetupComplete,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "SaasSetupComplete",
                        GqlRootFieldName = "o365SaasSetupComplete"
                    }
                },
                {
                    GqlRootFieldName.o365ServiceAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "ServiceAccount",
                        GqlRootFieldName = "o365ServiceAccount"
                    }
                },
                {
                    GqlRootFieldName.o365ServiceStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "ServiceStatus",
                        GqlRootFieldName = "o365ServiceStatus"
                    }
                },
                {
                    GqlRootFieldName.o365SetupKickoff,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "SetupKickoff",
                        GqlRootFieldName = "o365SetupKickoff"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointDrive,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointDrive",
                        GqlRootFieldName = "o365SharepointDrive"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointDrives,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointDrives",
                        GqlRootFieldName = "o365SharepointDrives"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointList,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointList",
                        GqlRootFieldName = "o365SharepointList"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointLists,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointLists",
                        GqlRootFieldName = "o365SharepointLists"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointObjectList,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointObjectList",
                        GqlRootFieldName = "o365SharepointObjectList"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointObjects,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointObjects",
                        GqlRootFieldName = "o365SharepointObjects"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointSite,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointSite",
                        GqlRootFieldName = "o365SharepointSite"
                    }
                },
                {
                    GqlRootFieldName.o365SharepointSites,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "SharepointSites",
                        GqlRootFieldName = "o365SharepointSites"
                    }
                },
                {
                    GqlRootFieldName.o365Site,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Site",
                        GqlRootFieldName = "o365Site"
                    }
                },
                {
                    GqlRootFieldName.o365Sites,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Sites",
                        GqlRootFieldName = "o365Sites"
                    }
                },
                {
                    GqlRootFieldName.o365StorageStats,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "StorageStats",
                        GqlRootFieldName = "o365StorageStats"
                    }
                },
                {
                    GqlRootFieldName.o365Team,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Team",
                        GqlRootFieldName = "o365Team"
                    }
                },
                {
                    GqlRootFieldName.o365TeamChannels,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "TeamChannels",
                        GqlRootFieldName = "o365TeamChannels"
                    }
                },
                {
                    GqlRootFieldName.o365TeamConversationsFolderID,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "TeamConversationsFolderID",
                        GqlRootFieldName = "o365TeamConversationsFolderID"
                    }
                },
                {
                    GqlRootFieldName.o365TeamPostedBy,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "TeamPostedBy",
                        GqlRootFieldName = "o365TeamPostedBy"
                    }
                },
                {
                    GqlRootFieldName.o365Teams,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "Teams",
                        GqlRootFieldName = "o365Teams"
                    }
                },
                {
                    GqlRootFieldName.o365User,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "User",
                        GqlRootFieldName = "o365User"
                    }
                },
                {
                    GqlRootFieldName.o365UserObjects,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryO365",
                        CmdletSwitchName = "UserObjects",
                        GqlRootFieldName = "o365UserObjects"
                    }
                },
                {
                    GqlRootFieldName.oracleAcoExampleDownloadLink,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "AcoExampleDownloadLink",
                        GqlRootFieldName = "oracleAcoExampleDownloadLink"
                    }
                },
                {
                    GqlRootFieldName.oracleAcoParameters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "AcoParameters",
                        GqlRootFieldName = "oracleAcoParameters"
                    }
                },
                {
                    GqlRootFieldName.oracleDataGuardGroup,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "DataGuardGroup",
                        GqlRootFieldName = "oracleDataGuardGroup"
                    }
                },
                {
                    GqlRootFieldName.oracleDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "Database",
                        GqlRootFieldName = "oracleDatabase"
                    }
                },
                {
                    GqlRootFieldName.oracleDatabaseLogBackupConfig,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "DatabaseLogBackupConfig",
                        GqlRootFieldName = "oracleDatabaseLogBackupConfig"
                    }
                },
                {
                    GqlRootFieldName.oracleDatabases,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "Databases",
                        GqlRootFieldName = "oracleDatabases"
                    }
                },
                {
                    GqlRootFieldName.oracleHost,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "Host",
                        GqlRootFieldName = "oracleHost"
                    }
                },
                {
                    GqlRootFieldName.oracleHostLogBackupConfig,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "HostLogBackupConfig",
                        GqlRootFieldName = "oracleHostLogBackupConfig"
                    }
                },
                {
                    GqlRootFieldName.oracleLiveMounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "LiveMounts",
                        GqlRootFieldName = "oracleLiveMounts"
                    }
                },
                {
                    GqlRootFieldName.oracleMissedRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "MissedRecoverableRanges",
                        GqlRootFieldName = "oracleMissedRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.oracleMissedSnapshots,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "MissedSnapshots",
                        GqlRootFieldName = "oracleMissedSnapshots"
                    }
                },
                {
                    GqlRootFieldName.oraclePdbDetails,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "PdbDetails",
                        GqlRootFieldName = "oraclePdbDetails"
                    }
                },
                {
                    GqlRootFieldName.oracleRac,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "Rac",
                        GqlRootFieldName = "oracleRac"
                    }
                },
                {
                    GqlRootFieldName.oracleRacLogBackupConfig,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "RacLogBackupConfig",
                        GqlRootFieldName = "oracleRacLogBackupConfig"
                    }
                },
                {
                    GqlRootFieldName.oracleRecoverableRanges,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "RecoverableRanges",
                        GqlRootFieldName = "oracleRecoverableRanges"
                    }
                },
                {
                    GqlRootFieldName.oracleTopLevelDescendants,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryOracle",
                        CmdletSwitchName = "TopLevelDescendants",
                        GqlRootFieldName = "oracleTopLevelDescendants"
                    }
                },
                {
                    GqlRootFieldName.patchAwsAuthenticationServerBasedCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "PatchAuthenticationServerBasedCloudAccount",
                        GqlRootFieldName = "patchAwsAuthenticationServerBasedCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.patchAwsIamUserBasedCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "PatchIamUserBasedCloudAccount",
                        GqlRootFieldName = "patchAwsIamUserBasedCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.patchDb2Database,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "PatchDatabase",
                        GqlRootFieldName = "patchDb2Database"
                    }
                },
                {
                    GqlRootFieldName.patchDb2Instance,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "PatchInstance",
                        GqlRootFieldName = "patchDb2Instance"
                    }
                },
                {
                    GqlRootFieldName.patchMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "PatchSource",
                        GqlRootFieldName = "patchMongoSource"
                    }
                },
                {
                    GqlRootFieldName.patchNutanixMountV1,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "PatchMountV1",
                        GqlRootFieldName = "patchNutanixMountV1"
                    }
                },
                {
                    GqlRootFieldName.pauseSla,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "Pause",
                        GqlRootFieldName = "pauseSla"
                    }
                },
                {
                    GqlRootFieldName.prepareAwsCloudAccountDeletion,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "PrepareCloudAccountDeletion",
                        GqlRootFieldName = "prepareAwsCloudAccountDeletion"
                    }
                },
                {
                    GqlRootFieldName.prepareFeatureUpdateForAwsCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "PrepareFeatureUpdateForCloudAccount",
                        GqlRootFieldName = "prepareFeatureUpdateForAwsCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.rdsInstanceDetailsFromAws,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "RdsInstanceDetails",
                        GqlRootFieldName = "rdsInstanceDetailsFromAws"
                    }
                },
                {
                    GqlRootFieldName.recoverCassandraSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCassandra",
                        CmdletSwitchName = "RecoverSource",
                        GqlRootFieldName = "recoverCassandraSource"
                    }
                },
                {
                    GqlRootFieldName.recoverCloudCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "RecoverCloud",
                        GqlRootFieldName = "recoverCloudCluster"
                    }
                },
                {
                    GqlRootFieldName.recoverMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "RecoverSource",
                        GqlRootFieldName = "recoverMongoSource"
                    }
                },
                {
                    GqlRootFieldName.recoverMongodbSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "RecoverdbSource",
                        GqlRootFieldName = "recoverMongodbSource"
                    }
                },
                {
                    GqlRootFieldName.refreshDb2Database,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateDb2",
                        CmdletSwitchName = "RefreshDatabase",
                        GqlRootFieldName = "refreshDb2Database"
                    }
                },
                {
                    GqlRootFieldName.refreshHypervScvmm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "RefreshScvmm",
                        GqlRootFieldName = "refreshHypervScvmm"
                    }
                },
                {
                    GqlRootFieldName.refreshHypervServer,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "RefreshServer",
                        GqlRootFieldName = "refreshHypervServer"
                    }
                },
                {
                    GqlRootFieldName.refreshK8sCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "RefreshK8s",
                        GqlRootFieldName = "refreshK8sCluster"
                    }
                },
                {
                    GqlRootFieldName.refreshNutanixCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "RefreshCluster",
                        GqlRootFieldName = "refreshNutanixCluster"
                    }
                },
                {
                    GqlRootFieldName.refreshNutanixPrismCentral,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "RefreshPrismCentral",
                        GqlRootFieldName = "refreshNutanixPrismCentral"
                    }
                },
                {
                    GqlRootFieldName.refreshO365Org,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "RefreshOrg",
                        GqlRootFieldName = "refreshO365Org"
                    }
                },
                {
                    GqlRootFieldName.refreshOracleDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "RefreshDatabase",
                        GqlRootFieldName = "refreshOracleDatabase"
                    }
                },
                {
                    GqlRootFieldName.refreshVsphereVcenter,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "Refresh",
                        GqlRootFieldName = "refreshVsphereVcenter"
                    }
                },
                {
                    GqlRootFieldName.registerAgentHypervVirtualMachine,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "RegisterAgentVirtualMachine",
                        GqlRootFieldName = "registerAgentHypervVirtualMachine"
                    }
                },
                {
                    GqlRootFieldName.registerAgentNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "RegisterAgentVm",
                        GqlRootFieldName = "registerAgentNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.registerAwsFeatureArtifacts,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "RegisterFeatureArtifacts",
                        GqlRootFieldName = "registerAwsFeatureArtifacts"
                    }
                },
                {
                    GqlRootFieldName.registerCloudCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "RegisterCloud",
                        GqlRootFieldName = "registerCloudCluster"
                    }
                },
                {
                    GqlRootFieldName.registerHypervScvmm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "RegisterScvmm",
                        GqlRootFieldName = "registerHypervScvmm"
                    }
                },
                {
                    GqlRootFieldName.removeCdmCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "RemoveCdm",
                        GqlRootFieldName = "removeCdmCluster"
                    }
                },
                {
                    GqlRootFieldName.removeLdapIntegration,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateLdap",
                        CmdletSwitchName = "RemoveIntegration",
                        GqlRootFieldName = "removeLdapIntegration"
                    }
                },
                {
                    GqlRootFieldName.restoreFilesNutanixSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "RestoreFilesSnapshot",
                        GqlRootFieldName = "restoreFilesNutanixSnapshot"
                    }
                },
                {
                    GqlRootFieldName.restoreHypervVirtualMachineSnapshotFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "RestoreVirtualMachineSnapshotFiles",
                        GqlRootFieldName = "restoreHypervVirtualMachineSnapshotFiles"
                    }
                },
                {
                    GqlRootFieldName.restoreMssqlDatabase,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "RestoreDatabase",
                        GqlRootFieldName = "restoreMssqlDatabase"
                    }
                },
                {
                    GqlRootFieldName.restoreO365Mailbox,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "RestoreMailbox",
                        GqlRootFieldName = "restoreO365Mailbox"
                    }
                },
                {
                    GqlRootFieldName.restoreO365Snappable,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "RestoreSnappable",
                        GqlRootFieldName = "restoreO365Snappable"
                    }
                },
                {
                    GqlRootFieldName.restoreO365TeamsConversations,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "RestoreTeamsConversations",
                        GqlRootFieldName = "restoreO365TeamsConversations"
                    }
                },
                {
                    GqlRootFieldName.restoreO365TeamsFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "RestoreTeamsFiles",
                        GqlRootFieldName = "restoreO365TeamsFiles"
                    }
                },
                {
                    GqlRootFieldName.restoreOracleLogs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "RestoreLogs",
                        GqlRootFieldName = "restoreOracleLogs"
                    }
                },
                {
                    GqlRootFieldName.retryAddMongoSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "RetryAddSource",
                        GqlRootFieldName = "retryAddMongoSource"
                    }
                },
                {
                    GqlRootFieldName.searchNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryNutanix",
                        CmdletSwitchName = "SearchVm",
                        GqlRootFieldName = "searchNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.setAzureCloudAccountCustomerAppCredentials,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "SetCloudAccountCustomerAppCredentials",
                        GqlRootFieldName = "setAzureCloudAccountCustomerAppCredentials"
                    }
                },
                {
                    GqlRootFieldName.setLdapMfaSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateLdap",
                        CmdletSwitchName = "SetMfaSetting",
                        GqlRootFieldName = "setLdapMfaSetting"
                    }
                },
                {
                    GqlRootFieldName.setO365ServiceAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "SetServiceAccount",
                        GqlRootFieldName = "setO365ServiceAccount"
                    }
                },
                {
                    GqlRootFieldName.setupAzureO365Exocompute,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzureO365",
                        CmdletSwitchName = "SetupExocompute",
                        GqlRootFieldName = "setupAzureO365Exocompute"
                    }
                },
                {
                    GqlRootFieldName.slaAuditDetail,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "AuditDetail",
                        GqlRootFieldName = "slaAuditDetail"
                    }
                },
                {
                    GqlRootFieldName.slaConflictObjects,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "ConflictObjects",
                        GqlRootFieldName = "slaConflictObjects"
                    }
                },
                {
                    GqlRootFieldName.slaDomain,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "Domain",
                        GqlRootFieldName = "slaDomain"
                    }
                },
                {
                    GqlRootFieldName.slaDomains,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "Domains",
                        GqlRootFieldName = "slaDomains"
                    }
                },
                {
                    GqlRootFieldName.slaManagedVolume,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "ManagedVolume",
                        GqlRootFieldName = "slaManagedVolume"
                    }
                },
                {
                    GqlRootFieldName.slaManagedVolumes,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "ManagedVolumes",
                        GqlRootFieldName = "slaManagedVolumes"
                    }
                },
                {
                    GqlRootFieldName.startAwsExocomputeDisableJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartExocomputeDisableJob",
                        GqlRootFieldName = "startAwsExocomputeDisableJob"
                    }
                },
                {
                    GqlRootFieldName.startAwsNativeAccountDisableJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartNativeAccountDisableJob",
                        GqlRootFieldName = "startAwsNativeAccountDisableJob"
                    }
                },
                {
                    GqlRootFieldName.startAwsNativeEc2InstanceSnapshotsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartNativeEc2InstanceSnapshotsJob",
                        GqlRootFieldName = "startAwsNativeEc2InstanceSnapshotsJob"
                    }
                },
                {
                    GqlRootFieldName.startAwsNativeRdsInstanceSnapshotsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartNativeRdsInstanceSnapshotsJob",
                        GqlRootFieldName = "startAwsNativeRdsInstanceSnapshotsJob"
                    }
                },
                {
                    GqlRootFieldName.startAzureCloudAccountOauth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartCloudAccountOauth",
                        GqlRootFieldName = "startAzureCloudAccountOauth"
                    }
                },
                {
                    GqlRootFieldName.startCreateAwsNativeEbsVolumeSnapshotsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartCreateNativeEbsVolumeSnapshotsJob",
                        GqlRootFieldName = "startCreateAwsNativeEbsVolumeSnapshotsJob"
                    }
                },
                {
                    GqlRootFieldName.startCreateAzureNativeManagedDiskSnapshotsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartCreateNativeManagedDiskSnapshotsJob",
                        GqlRootFieldName = "startCreateAzureNativeManagedDiskSnapshotsJob"
                    }
                },
                {
                    GqlRootFieldName.startCreateAzureNativeVirtualMachineSnapshotsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartCreateNativeVirtualMachineSnapshotsJob",
                        GqlRootFieldName = "startCreateAzureNativeVirtualMachineSnapshotsJob"
                    }
                },
                {
                    GqlRootFieldName.startDisableAzureCloudAccountJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartDisableCloudAccountJob",
                        GqlRootFieldName = "startDisableAzureCloudAccountJob"
                    }
                },
                {
                    GqlRootFieldName.startDisableAzureNativeSubscriptionProtectionJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartDisableNativeSubscriptionProtectionJob",
                        GqlRootFieldName = "startDisableAzureNativeSubscriptionProtectionJob"
                    }
                },
                {
                    GqlRootFieldName.startExportAwsNativeEbsVolumeSnapshotJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartExportNativeEbsVolumeSnapshotJob",
                        GqlRootFieldName = "startExportAwsNativeEbsVolumeSnapshotJob"
                    }
                },
                {
                    GqlRootFieldName.startExportAzureNativeManagedDiskJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartExportNativeManagedDiskJob",
                        GqlRootFieldName = "startExportAzureNativeManagedDiskJob"
                    }
                },
                {
                    GqlRootFieldName.startExportAzureNativeVirtualMachineJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartExportNativeVirtualMachineJob",
                        GqlRootFieldName = "startExportAzureNativeVirtualMachineJob"
                    }
                },
                {
                    GqlRootFieldName.startExportAzureSqlDatabaseDbJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartExportSqlDatabaseDbJob",
                        GqlRootFieldName = "startExportAzureSqlDatabaseDbJob"
                    }
                },
                {
                    GqlRootFieldName.startExportAzureSqlManagedInstanceDbJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartExportSqlManagedInstanceDbJob",
                        GqlRootFieldName = "startExportAzureSqlManagedInstanceDbJob"
                    }
                },
                {
                    GqlRootFieldName.startRefreshAwsNativeAccountsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartRefreshNativeAccountsJob",
                        GqlRootFieldName = "startRefreshAwsNativeAccountsJob"
                    }
                },
                {
                    GqlRootFieldName.startRefreshAzureNativeSubscriptionsJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartRefreshNativeSubscriptionsJob",
                        GqlRootFieldName = "startRefreshAzureNativeSubscriptionsJob"
                    }
                },
                {
                    GqlRootFieldName.startRestoreAwsNativeEc2InstanceSnapshotJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "StartRestoreNativeEc2InstanceSnapshotJob",
                        GqlRootFieldName = "startRestoreAwsNativeEc2InstanceSnapshotJob"
                    }
                },
                {
                    GqlRootFieldName.startRestoreAzureNativeVirtualMachineJob,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "StartRestoreNativeVirtualMachineJob",
                        GqlRootFieldName = "startRestoreAzureNativeVirtualMachineJob"
                    }
                },
                {
                    GqlRootFieldName.takeMssqlLogBackup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "TakeLogBackup",
                        GqlRootFieldName = "takeMssqlLogBackup"
                    }
                },
                {
                    GqlRootFieldName.takeOnDemandOracleDatabaseSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "TakeOnDemandDatabaseSnapshot",
                        GqlRootFieldName = "takeOnDemandOracleDatabaseSnapshot"
                    }
                },
                {
                    GqlRootFieldName.takeOnDemandOracleLogSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "TakeOnDemandLogSnapshot",
                        GqlRootFieldName = "takeOnDemandOracleLogSnapshot"
                    }
                },
                {
                    GqlRootFieldName.uniqueHypervServersCount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryHyperv",
                        CmdletSwitchName = "UniqueServersCount",
                        GqlRootFieldName = "uniqueHypervServersCount"
                    }
                },
                {
                    GqlRootFieldName.unmapAzureCloudAccountExocomputeSubscription,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UnmapCloudAccountExocomputeSubscription",
                        GqlRootFieldName = "unmapAzureCloudAccountExocomputeSubscription"
                    }
                },
                {
                    GqlRootFieldName.unmapAzurePersistentStorageSubscription,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UnmapPersistentStorageSubscription",
                        GqlRootFieldName = "unmapAzurePersistentStorageSubscription"
                    }
                },
                {
                    GqlRootFieldName.updateAutomaticAwsTargetMapping,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateAutomaticTargetMapping",
                        GqlRootFieldName = "updateAutomaticAwsTargetMapping"
                    }
                },
                {
                    GqlRootFieldName.updateAutomaticAzureTargetMapping,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateAutomaticTargetMapping",
                        GqlRootFieldName = "updateAutomaticAzureTargetMapping"
                    }
                },
                {
                    GqlRootFieldName.updateAwsAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateAccount",
                        GqlRootFieldName = "updateAwsAccount"
                    }
                },
                {
                    GqlRootFieldName.updateAwsCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateCloudAccount",
                        GqlRootFieldName = "updateAwsCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.updateAwsCloudAccountFeature,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateCloudAccountFeature",
                        GqlRootFieldName = "updateAwsCloudAccountFeature"
                    }
                },
                {
                    GqlRootFieldName.updateAwsComputeSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateComputeSetting",
                        GqlRootFieldName = "updateAwsComputeSetting"
                    }
                },
                {
                    GqlRootFieldName.updateAwsExocomputeConfigs,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateExocomputeConfigs",
                        GqlRootFieldName = "updateAwsExocomputeConfigs"
                    }
                },
                {
                    GqlRootFieldName.updateAwsTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateTarget",
                        GqlRootFieldName = "updateAwsTarget"
                    }
                },
                {
                    GqlRootFieldName.updateAzureAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateAccount",
                        GqlRootFieldName = "updateAzureAccount"
                    }
                },
                {
                    GqlRootFieldName.updateAzureCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateCloudAccount",
                        GqlRootFieldName = "updateAzureCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.updateAzureTarget,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateTarget",
                        GqlRootFieldName = "updateAzureTarget"
                    }
                },
                {
                    GqlRootFieldName.updateCassandraSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCassandra",
                        CmdletSwitchName = "UpdateSource",
                        GqlRootFieldName = "updateCassandraSource"
                    }
                },
                {
                    GqlRootFieldName.updateCloudNativeAwsStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpdateCloudNativeStorageSetting",
                        GqlRootFieldName = "updateCloudNativeAwsStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.updateCloudNativeAzureStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateCloudNativeStorageSetting",
                        GqlRootFieldName = "updateCloudNativeAzureStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.updateCloudNativeRcvAzureStorageSetting,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateCloudNativeRcvStorageSetting",
                        GqlRootFieldName = "updateCloudNativeRcvAzureStorageSetting"
                    }
                },
                {
                    GqlRootFieldName.updateCustomerAppPermissionForAzureSql,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpdateCustomerAppPermissionForSql",
                        GqlRootFieldName = "updateCustomerAppPermissionForAzureSql"
                    }
                },
                {
                    GqlRootFieldName.updateDatabaseLogReportingPropertiesForCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "UpdateDatabaseLogReportingProperties",
                        GqlRootFieldName = "updateDatabaseLogReportingPropertiesForCluster"
                    }
                },
                {
                    GqlRootFieldName.updateFailoverCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateCluster",
                        CmdletSwitchName = "UpdateFailover",
                        GqlRootFieldName = "updateFailoverCluster"
                    }
                },
                {
                    GqlRootFieldName.updateGlobalSla,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateSla",
                        CmdletSwitchName = "UpdateGlobal",
                        GqlRootFieldName = "updateGlobalSla"
                    }
                },
                {
                    GqlRootFieldName.updateHypervVirtualMachine,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "UpdateVirtualMachine",
                        GqlRootFieldName = "updateHypervVirtualMachine"
                    }
                },
                {
                    GqlRootFieldName.updateHypervVirtualMachineSnapshotMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateHyperv",
                        CmdletSwitchName = "UpdateVirtualMachineSnapshotMount",
                        GqlRootFieldName = "updateHypervVirtualMachineSnapshotMount"
                    }
                },
                {
                    GqlRootFieldName.updateLdapIntegration,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateLdap",
                        CmdletSwitchName = "UpdateIntegration",
                        GqlRootFieldName = "updateLdapIntegration"
                    }
                },
                {
                    GqlRootFieldName.updateMongodbSource,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMongo",
                        CmdletSwitchName = "UpdatedbSource",
                        GqlRootFieldName = "updateMongodbSource"
                    }
                },
                {
                    GqlRootFieldName.updateMssqlDefaultProperties,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "UpdateDefaultProperties",
                        GqlRootFieldName = "updateMssqlDefaultProperties"
                    }
                },
                {
                    GqlRootFieldName.updateMssqlLogShippingConfiguration,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateMssql",
                        CmdletSwitchName = "UpdateLogShippingConfiguration",
                        GqlRootFieldName = "updateMssqlLogShippingConfiguration"
                    }
                },
                {
                    GqlRootFieldName.updateNutanixCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "UpdateCluster",
                        GqlRootFieldName = "updateNutanixCluster"
                    }
                },
                {
                    GqlRootFieldName.updateNutanixPrismCentral,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "UpdatePrismCentral",
                        GqlRootFieldName = "updateNutanixPrismCentral"
                    }
                },
                {
                    GqlRootFieldName.updateNutanixVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateNutanix",
                        CmdletSwitchName = "UpdateVm",
                        GqlRootFieldName = "updateNutanixVm"
                    }
                },
                {
                    GqlRootFieldName.updateO365AppAuthStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "UpdateAppAuthStatus",
                        GqlRootFieldName = "updateO365AppAuthStatus"
                    }
                },
                {
                    GqlRootFieldName.updateO365AppPermissions,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "UpdateAppPermissions",
                        GqlRootFieldName = "updateO365AppPermissions"
                    }
                },
                {
                    GqlRootFieldName.updateO365OrgCustomName,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateO365",
                        CmdletSwitchName = "UpdateOrgCustomName",
                        GqlRootFieldName = "updateO365OrgCustomName"
                    }
                },
                {
                    GqlRootFieldName.updateOracleDataGuardGroup,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "UpdateDataGuardGroup",
                        GqlRootFieldName = "updateOracleDataGuardGroup"
                    }
                },
                {
                    GqlRootFieldName.updateVcenter,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "Update",
                        GqlRootFieldName = "updateVcenter"
                    }
                },
                {
                    GqlRootFieldName.updateVcenterHotAddBandwidth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "UpdateHotAddBandwidth",
                        GqlRootFieldName = "updateVcenterHotAddBandwidth"
                    }
                },
                {
                    GqlRootFieldName.updateVcenterHotAddNetwork,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "UpdateHotAddNetwork",
                        GqlRootFieldName = "updateVcenterHotAddNetwork"
                    }
                },
                {
                    GqlRootFieldName.updateVsphereAdvancedTag,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "UpdateAdvancedTag",
                        GqlRootFieldName = "updateVsphereAdvancedTag"
                    }
                },
                {
                    GqlRootFieldName.updateVsphereVm,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "Update",
                        GqlRootFieldName = "updateVsphereVm"
                    }
                },
                {
                    GqlRootFieldName.upgradeAwsCloudAccountFeaturesWithoutCft,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpgradeCloudAccountFeaturesWithoutCft",
                        GqlRootFieldName = "upgradeAwsCloudAccountFeaturesWithoutCft"
                    }
                },
                {
                    GqlRootFieldName.upgradeAwsIamUserBasedCloudAccountPermissions,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "UpgradeIamUserBasedCloudAccountPermissions",
                        GqlRootFieldName = "upgradeAwsIamUserBasedCloudAccountPermissions"
                    }
                },
                {
                    GqlRootFieldName.upgradeAzureCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpgradeCloudAccount",
                        GqlRootFieldName = "upgradeAzureCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.upgradeAzureCloudAccountPermissionsWithoutOauth,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAzure",
                        CmdletSwitchName = "UpgradeCloudAccountPermissionsWithoutOauth",
                        GqlRootFieldName = "upgradeAzureCloudAccountPermissionsWithoutOauth"
                    }
                },
                {
                    GqlRootFieldName.vCenterAdvancedTagPreview,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "AdvancedTagPreview",
                        GqlRootFieldName = "vCenterAdvancedTagPreview"
                    }
                },
                {
                    GqlRootFieldName.vCenterHotAddBandwidth,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "HotAddBandwidth",
                        GqlRootFieldName = "vCenterHotAddBandwidth"
                    }
                },
                {
                    GqlRootFieldName.vCenterHotAddNetwork,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "HotAddNetwork",
                        GqlRootFieldName = "vCenterHotAddNetwork"
                    }
                },
                {
                    GqlRootFieldName.vCenterNetworks,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "Networks",
                        GqlRootFieldName = "vCenterNetworks"
                    }
                },
                {
                    GqlRootFieldName.vCenterNumProxiesNeeded,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "NumProxiesNeeded",
                        GqlRootFieldName = "vCenterNumProxiesNeeded"
                    }
                },
                {
                    GqlRootFieldName.vCenterPreAddInfo,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "PreAddInfo",
                        GqlRootFieldName = "vCenterPreAddInfo"
                    }
                },
                {
                    GqlRootFieldName.vSphereComputeCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "ComputeCluster",
                        GqlRootFieldName = "vSphereComputeCluster"
                    }
                },
                {
                    GqlRootFieldName.vSphereComputeClusters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "ComputeClusters",
                        GqlRootFieldName = "vSphereComputeClusters"
                    }
                },
                {
                    GqlRootFieldName.vSphereDatacenter,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Datacenter",
                        GqlRootFieldName = "vSphereDatacenter"
                    }
                },
                {
                    GqlRootFieldName.vSphereDatastore,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Datastore",
                        GqlRootFieldName = "vSphereDatastore"
                    }
                },
                {
                    GqlRootFieldName.vSphereDatastoreCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "DatastoreCluster",
                        GqlRootFieldName = "vSphereDatastoreCluster"
                    }
                },
                {
                    GqlRootFieldName.vSphereDatastoreClusters,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "DatastoreClusters",
                        GqlRootFieldName = "vSphereDatastoreClusters"
                    }
                },
                {
                    GqlRootFieldName.vSphereDatastoreConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "DatastoreList",
                        GqlRootFieldName = "vSphereDatastoreConnection"
                    }
                },
                {
                    GqlRootFieldName.vSphereFolder,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Folder",
                        GqlRootFieldName = "vSphereFolder"
                    }
                },
                {
                    GqlRootFieldName.vSphereFolders,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Folders",
                        GqlRootFieldName = "vSphereFolders"
                    }
                },
                {
                    GqlRootFieldName.vSphereHost,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Host",
                        GqlRootFieldName = "vSphereHost"
                    }
                },
                {
                    GqlRootFieldName.vSphereHostConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "HostList",
                        GqlRootFieldName = "vSphereHostConnection"
                    }
                },
                {
                    GqlRootFieldName.vSphereHostDetails,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "HostDetails",
                        GqlRootFieldName = "vSphereHostDetails"
                    }
                },
                {
                    GqlRootFieldName.vSphereHostsByFids,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "HostsByFids",
                        GqlRootFieldName = "vSphereHostsByFids"
                    }
                },
                {
                    GqlRootFieldName.vSphereLiveMounts,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "LiveMounts",
                        GqlRootFieldName = "vSphereLiveMounts"
                    }
                },
                {
                    GqlRootFieldName.vSphereMount,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Mount",
                        GqlRootFieldName = "vSphereMount"
                    }
                },
                {
                    GqlRootFieldName.vSphereMountConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "MountList",
                        GqlRootFieldName = "vSphereMountConnection"
                    }
                },
                {
                    GqlRootFieldName.vSphereNetwork,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Network",
                        GqlRootFieldName = "vSphereNetwork"
                    }
                },
                {
                    GqlRootFieldName.vSphereResourcePool,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "ResourcePool",
                        GqlRootFieldName = "vSphereResourcePool"
                    }
                },
                {
                    GqlRootFieldName.vSphereRootRecoveryHierarchy,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "RootRecoveryHierarchy",
                        GqlRootFieldName = "vSphereRootRecoveryHierarchy"
                    }
                },
                {
                    GqlRootFieldName.vSphereTag,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "Tag",
                        GqlRootFieldName = "vSphereTag"
                    }
                },
                {
                    GqlRootFieldName.vSphereTagCategory,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "TagCategory",
                        GqlRootFieldName = "vSphereTagCategory"
                    }
                },
                {
                    GqlRootFieldName.vSphereTopLevelDescendantsConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "TopLevelDescendantsList",
                        GqlRootFieldName = "vSphereTopLevelDescendantsConnection"
                    }
                },
                {
                    GqlRootFieldName.vSphereVCenter,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "Vcenter",
                        GqlRootFieldName = "vSphereVCenter"
                    }
                },
                {
                    GqlRootFieldName.vSphereVCenterConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVcenter",
                        CmdletSwitchName = "List",
                        GqlRootFieldName = "vSphereVCenterConnection"
                    }
                },
                {
                    GqlRootFieldName.vSphereVMAsyncRequestStatus,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "AsyncRequestStatus",
                        GqlRootFieldName = "vSphereVMAsyncRequestStatus"
                    }
                },
                {
                    GqlRootFieldName.vSphereVmNew,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "New",
                        GqlRootFieldName = "vSphereVmNew"
                    }
                },
                {
                    GqlRootFieldName.vSphereVmNewConnection,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "NewList",
                        GqlRootFieldName = "vSphereVmNewConnection"
                    }
                },
                {
                    GqlRootFieldName.validateAndCreateAwsCloudAccount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateAws",
                        CmdletSwitchName = "ValidateAndCreateCloudAccount",
                        GqlRootFieldName = "validateAndCreateAwsCloudAccount"
                    }
                },
                {
                    GqlRootFieldName.validateAwsNativeRdsClusterNameForExport,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "ValidateNativeRdsClusterNameForExport",
                        GqlRootFieldName = "validateAwsNativeRdsClusterNameForExport"
                    }
                },
                {
                    GqlRootFieldName.validateAwsNativeRdsInstanceNameForExport,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAws",
                        CmdletSwitchName = "ValidateNativeRdsInstanceNameForExport",
                        GqlRootFieldName = "validateAwsNativeRdsInstanceNameForExport"
                    }
                },
                {
                    GqlRootFieldName.validateAzureCloudAccountExocomputeConfigurations,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "ValidateCloudAccountExocomputeConfigurations",
                        GqlRootFieldName = "validateAzureCloudAccountExocomputeConfigurations"
                    }
                },
                {
                    GqlRootFieldName.validateAzureNativeSqlDatabaseDbNameForExport,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "ValidateNativeSqlDatabaseDbNameForExport",
                        GqlRootFieldName = "validateAzureNativeSqlDatabaseDbNameForExport"
                    }
                },
                {
                    GqlRootFieldName.validateAzureNativeSqlManagedInstanceDbNameForExport,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryAzure",
                        CmdletSwitchName = "ValidateNativeSqlManagedInstanceDbNameForExport",
                        GqlRootFieldName = "validateAzureNativeSqlManagedInstanceDbNameForExport"
                    }
                },
                {
                    GqlRootFieldName.validateOracleAcoFile,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "ValidateAcoFile",
                        GqlRootFieldName = "validateOracleAcoFile"
                    }
                },
                {
                    GqlRootFieldName.validateOracleDatabaseBackups,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateOracle",
                        CmdletSwitchName = "ValidateDatabaseBackups",
                        GqlRootFieldName = "validateOracleDatabaseBackups"
                    }
                },
                {
                    GqlRootFieldName.verifySlaWithReplicationToCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQuerySla",
                        CmdletSwitchName = "VerifyWithReplicationToCluster",
                        GqlRootFieldName = "verifySlaWithReplicationToCluster"
                    }
                },
                {
                    GqlRootFieldName.vsphereBulkOnDemandSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "BulkOnDemandSnapshot",
                        GqlRootFieldName = "vsphereBulkOnDemandSnapshot"
                    }
                },
                {
                    GqlRootFieldName.vsphereDeleteVcenter,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVcenter",
                        CmdletSwitchName = "Delete",
                        GqlRootFieldName = "vsphereDeleteVcenter"
                    }
                },
                {
                    GqlRootFieldName.vsphereExcludeVmDisks,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "ExcludeVmDisks",
                        GqlRootFieldName = "vsphereExcludeVmDisks"
                    }
                },
                {
                    GqlRootFieldName.vsphereExportSnapshotToStandaloneHostV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "ExportSnapshotToStandaloneHostV2",
                        GqlRootFieldName = "vsphereExportSnapshotToStandaloneHostV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereOnDemandSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphere",
                        CmdletSwitchName = "OnDemandSnapshot",
                        GqlRootFieldName = "vsphereOnDemandSnapshot"
                    }
                },
                {
                    GqlRootFieldName.vsphereVMMissedRecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "MissedRecoverableRange",
                        GqlRootFieldName = "vsphereVMMissedRecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.vsphereVMRecoverableRange,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "RecoverableRange",
                        GqlRootFieldName = "vsphereVMRecoverableRange"
                    }
                },
                {
                    GqlRootFieldName.vsphereVMRecoverableRangeInBatch,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphereVm",
                        CmdletSwitchName = "RecoverableRangeInBatch",
                        GqlRootFieldName = "vsphereVMRecoverableRangeInBatch"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmBatchExport,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "BatchExport",
                        GqlRootFieldName = "vsphereVmBatchExport"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmBatchExportV3,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "BatchExportV3",
                        GqlRootFieldName = "vsphereVmBatchExportV3"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmBatchInPlaceRecovery,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "BatchInPlaceRecovery",
                        GqlRootFieldName = "vsphereVmBatchInPlaceRecovery"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmDeleteSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "DeleteSnapshot",
                        GqlRootFieldName = "vsphereVmDeleteSnapshot"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmDownloadSnapshot,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "DownloadSnapshot",
                        GqlRootFieldName = "vsphereVmDownloadSnapshot"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmDownloadSnapshotFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "DownloadSnapshotFiles",
                        GqlRootFieldName = "vsphereVmDownloadSnapshotFiles"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "ExportSnapshotV2",
                        GqlRootFieldName = "vsphereVmExportSnapshotV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotV3,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "ExportSnapshotV3",
                        GqlRootFieldName = "vsphereVmExportSnapshotV3"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotWithDownloadFromCloud,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "ExportSnapshotWithDownloadFromCloud",
                        GqlRootFieldName = "vsphereVmExportSnapshotWithDownloadFromCloud"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateBatchInstantRecovery,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateBatchInstantRecovery",
                        GqlRootFieldName = "vsphereVmInitiateBatchInstantRecovery"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateBatchLiveMountV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateBatchLiveMountV2",
                        GqlRootFieldName = "vsphereVmInitiateBatchLiveMountV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateDiskMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateDiskMount",
                        GqlRootFieldName = "vsphereVmInitiateDiskMount"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateInPlaceRecovery,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateInPlaceRecovery",
                        GqlRootFieldName = "vsphereVmInitiateInPlaceRecovery"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateInstantRecoveryV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateInstantRecoveryV2",
                        GqlRootFieldName = "vsphereVmInitiateInstantRecoveryV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmInitiateLiveMountV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "InitiateLiveMountV2",
                        GqlRootFieldName = "vsphereVmInitiateLiveMountV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmListEsxiDatastores,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "ListEsxiDatastores",
                        GqlRootFieldName = "vsphereVmListEsxiDatastores"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmMountRelocate,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "MountRelocate",
                        GqlRootFieldName = "vsphereVmMountRelocate"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmMountRelocateV2,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "MountRelocateV2",
                        GqlRootFieldName = "vsphereVmMountRelocateV2"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmPowerOnOffLiveMount,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "PowerOnOffLiveMount",
                        GqlRootFieldName = "vsphereVmPowerOnOffLiveMount"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmRecoverFiles,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "RecoverFiles",
                        GqlRootFieldName = "vsphereVmRecoverFiles"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmRecoverFilesNew,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "RecoverFilesNew",
                        GqlRootFieldName = "vsphereVmRecoverFilesNew"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmRegisterAgent,
                    new RscOp {
                        CmdletName = "Invoke-RscMutateVsphereVm",
                        CmdletSwitchName = "RegisterAgent",
                        GqlRootFieldName = "vsphereVmRegisterAgent"
                    }
                },
                {
                    GqlRootFieldName.vsphereVmwareCdpLiveInfo,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryVsphere",
                        CmdletSwitchName = "VmwareCdpLiveInfo",
                        GqlRootFieldName = "vsphereVmwareCdpLiveInfo"
                    }
                },
                {
                    GqlRootFieldName.windowsCluster,
                    new RscOp {
                        CmdletName = "Invoke-RscQueryCluster",
                        CmdletSwitchName = "Windows",
                        GqlRootFieldName = "windowsCluster"
                    }
                },
            };
            if (lookupDict.TryGetValue(rootField, out var rscOp))
            {
                return rscOp;
            }
            return new RscOp{
                GqlRootFieldName = rootField.ToString()
            };
        }

        /// <summary>
        /// Given a GraphQL root field name, return the corresponding RSC operation.
        /// </summary>
        public static RscOp RscOpLookupByGqlRootField(string rootField)
        {
            if (Enum.TryParse<GqlRootFieldName>(rootField, out GqlRootFieldName rootFieldEnumVal))
            {
                // The provided operation is a valid enum member.
                return RscOpLookupByGqlRootField(rootFieldEnumVal);
            }
            return new RscOp{
                GqlRootFieldName = rootField
            };
        }

        /// <summary>
        /// Given a GraphQL return type, return the list of root field names that return that type.
        /// </summary>
        public static List<string> GqlRootFieldLookupByReturnType(
            string returnTypeName
        )
        {
            var lookupDict = new Dictionary<string, List<string>> {
                {   "AccessGroupConnection", new List<string> {
                        "sonarUserGroups",
                    }
                },
                {   "AccessUserConnection", new List<string> {
                        "sonarUsers",
                    }
                },
                {   "AccountSetting", new List<string> {
                        "accountSettings",
                    }
                },
                {   "ActivitySeries", new List<string> {
                        "activitySeries",
                    }
                },
                {   "ActivitySeriesConnection", new List<string> {
                        "activitySeriesConnection",
                    }
                },
                {   "ActivityTimelineResultConnection", new List<string> {
                        "userActivityTimeline",
                        "userFileActivityTimeline",
                    }
                },
                {   "AddAndJoinSmbDomainReply", new List<string> {
                        "addAndJoinSmbDomain",
                    }
                },
                {   "AddAwsAuthenticationServerBasedCloudAccountReply", new List<string> {
                        "addAwsAuthenticationServerBasedCloudAccount",
                    }
                },
                {   "AddAwsIamUserBasedCloudAccountReply", new List<string> {
                        "addAwsIamUserBasedCloudAccount",
                    }
                },
                {   "AddAzureCloudAccountExocomputeConfigurationsReply", new List<string> {
                        "addAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "AddAzureCloudAccountReply", new List<string> {
                        "addAzureCloudAccount",
                    }
                },
                {   "AddAzureCloudAccountWithoutOauthReply", new List<string> {
                        "addAzureCloudAccountWithoutOauth",
                    }
                },
                {   "AddCloudNativeSqlServerBackupCredentialsReply", new List<string> {
                        "addCloudNativeSqlServerBackupCredentials",
                    }
                },
                {   "AddClusterCertificateReply", new List<string> {
                        "addClusterCertificate",
                    }
                },
                {   "AddClusterNodesReply", new List<string> {
                        "addClusterNodes",
                    }
                },
                {   "AddConfiguredGroupToHierarchyReply", new List<string> {
                        "addConfiguredGroupToHierarchy",
                    }
                },
                {   "AddDb2InstanceReply", new List<string> {
                        "addDb2Instance",
                    }
                },
                {   "AddManagedVolumeReply", new List<string> {
                        "addManagedVolume",
                    }
                },
                {   "AddMongoSourceReply", new List<string> {
                        "addMongoSource",
                    }
                },
                {   "AddO365OrgResponse", new List<string> {
                        "addO365Org",
                        "o365SaasSetupComplete",
                    }
                },
                {   "AddSapHanaSystemReply", new List<string> {
                        "addSapHanaSystem",
                    }
                },
                {   "AddStorageArraysReply", new List<string> {
                        "addStorageArrays",
                    }
                },
                {   "AddSyslogExportRuleReply", new List<string> {
                        "addSyslogExportRule",
                    }
                },
                {   "AddVmAppConsistentSpecsReply", new List<string> {
                        "addVmAppConsistentSpecs",
                    }
                },
                {   "AllEnabledFeaturesForAccountReply", new List<string> {
                        "allEnabledFeaturesForAccount",
                    }
                },
                {   "AllStorageArraysReply", new List<string> {
                        "allStorageArrays",
                    }
                },
                {   "AmiTypeForAwsNativeArchivedSnapshotExportReply", new List<string> {
                        "amiTypeForAwsNativeArchivedSnapshotExport",
                    }
                },
                {   "Analyzer", new List<string> {
                        "createCustomAnalyzer",
                        "customAnalyzer",
                        "updateCustomAnalyzer",
                    }
                },
                {   "AnalyzerAccessUsageConnection", new List<string> {
                        "userAnalyzerAccess",
                    }
                },
                {   "AnalyzerConnection", new List<string> {
                        "activeCustomAnalyzers",
                    }
                },
                {   "AnalyzerGroupConnection", new List<string> {
                        "analyzerGroups",
                    }
                },
                {   "AnalyzerUsageConnection", new List<string> {
                        "analyzerUsages",
                    }
                },
                {   "AnomalyResultConnection", new List<string> {
                        "anomalyResults",
                    }
                },
                {   "AnomalyResultGroupedDataConnection", new List<string> {
                        "anomalyResultsGrouped",
                    }
                },
                {   "ArchiveK8sClusterReply", new List<string> {
                        "archiveK8sCluster",
                    }
                },
                {   "AssignMssqlSlaDomainPropertiesAsyncReply", new List<string> {
                        "assignMssqlSlaDomainPropertiesAsync",
                    }
                },
                {   "AsyncDownloadReply", new List<string> {
                        "downloadAuditLogCsvAsync",
                        "downloadReportCsvAsync",
                        "downloadReportPdfAsync",
                        "sendScheduledReportAsync",
                    }
                },
                {   "AsyncJobStatus", new List<string> {
                        "gcpNativeDisableProject",
                        "gcpNativeExportDisk",
                        "gcpNativeExportGceInstance",
                        "gcpNativeRestoreGceInstance",
                        "startAwsExocomputeDisableJob",
                        "startAwsNativeAccountDisableJob",
                        "startDisableAzureNativeSubscriptionProtectionJob",
                        "startEc2InstanceSnapshotExportJob",
                        "startExportAwsNativeEbsVolumeSnapshotJob",
                        "startExportAzureNativeManagedDiskJob",
                        "startExportAzureNativeVirtualMachineJob",
                        "startExportAzureSqlDatabaseDbJob",
                        "startExportAzureSqlManagedInstanceDbJob",
                        "startExportRdsInstanceJob",
                        "startRecoverS3SnapshotJob",
                        "startRestoreAwsNativeEc2InstanceSnapshotJob",
                        "startRestoreAzureNativeVirtualMachineJob",
                        "uploadDatabaseSnapshotToBlobstore",
                    }
                },
                {   "AsyncRequestStatus", new List<string> {
                        "assignSlaToMongoDbCollection",
                        "bulkCreateOnDemandMssqlBackup",
                        "bulkTierExistingSnapshots",
                        "checkCloudComputeConnectivityJobProgress",
                        "configureSapHanaRestore",
                        "createDownloadSnapshotForVolumeGroup",
                        "createExchangeMount",
                        "createFilesetSnapshot",
                        "createHypervVirtualMachineSnapshotMount",
                        "createMssqlLiveMount",
                        "createMssqlLogShippingConfiguration",
                        "createNutanixCluster",
                        "createOnDemandDb2Backup",
                        "createOnDemandExchangeBackup",
                        "createOnDemandMssqlBackup",
                        "createOnDemandNutanixBackup",
                        "createOnDemandSapHanaBackup",
                        "createOnDemandVolumeGroupBackup",
                        "createOraclePdbRestore",
                        "createSapHanaSystemRefresh",
                        "deleteDb2Database",
                        "deleteDb2Instance",
                        "deleteExchangeSnapshotMount",
                        "deleteHypervVirtualMachineSnapshotMount",
                        "deleteLogShipping",
                        "deleteManagedVolumeSnapshotExport",
                        "deleteMongoSource",
                        "deleteMssqlLiveMount",
                        "deleteNasSystem",
                        "deleteNutanixCluster",
                        "deleteNutanixMountV1",
                        "deleteOracleMount",
                        "deleteSapHanaSystem",
                        "deleteVolumeGroupMount",
                        "deleteVsphereLiveMount",
                        "discoverDb2Instance",
                        "discoverMongoSource",
                        "downloadDb2Snapshot",
                        "downloadDb2SnapshotsForPointInTimeRecovery",
                        "downloadExchangeSnapshot",
                        "downloadFilesetSnapshot",
                        "downloadFilesetSnapshotFromLocation",
                        "downloadFilesNutanixSnapshot",
                        "downloadHypervSnapshotFromLocation",
                        "downloadHypervVirtualMachineSnapshot",
                        "downloadHypervVirtualMachineSnapshotFiles",
                        "downloadManagedVolumeFiles",
                        "downloadManagedVolumeFromLocation",
                        "downloadMssqlDatabaseBackupFiles",
                        "downloadMssqlDatabaseFilesFromArchivalLocation",
                        "downloadNutanixSnapshot",
                        "downloadNutanixVmFromLocation",
                        "downloadOracleDatabaseSnapshot",
                        "downloadSapHanaSnapshot",
                        "downloadSapHanaSnapshotFromLocation",
                        "downloadSapHanaSnapshotsForPointInTimeRecovery",
                        "downloadVolumeGroupSnapshotFiles",
                        "downloadVolumeGroupSnapshotFromLocation",
                        "downloadVsphereVirtualMachineFiles",
                        "expireDownloadedDb2Snapshots",
                        "expireDownloadedSapHanaSnapshots",
                        "exportHypervVirtualMachine",
                        "exportManagedVolumeSnapshot",
                        "exportMssqlDatabase",
                        "exportNutanixSnapshot",
                        "exportOracleDatabase",
                        "exportOracleTablespace",
                        "exportSlaManagedVolumeSnapshot",
                        "filesetDownloadSnapshotFiles",
                        "filesetExportSnapshotFiles",
                        "filesetRecoverFiles",
                        "filesetRequestStatus",
                        "generateSupportBundle",
                        "hypervHostAsyncRequestStatus",
                        "hypervOnDemandSnapshot",
                        "hypervScvmmAsyncRequestStatus",
                        "hypervVirtualMachineAsyncRequestStatus",
                        "instantRecoverHypervVirtualMachineSnapshot",
                        "instantRecoverOracleSnapshot",
                        "migrateNutanixMountV1",
                        "mountNutanixSnapshotV1",
                        "mountOracleDatabase",
                        "nutanixClusterAsyncRequestStatus",
                        "nutanixVmAsyncRequestStatus",
                        "patchMongoSource",
                        "recoverCloudDirectMultiPaths",
                        "recoverCloudDirectPath",
                        "recoverMongoSource",
                        "refreshDb2Database",
                        "refreshHypervScvmm",
                        "refreshHypervServer",
                        "refreshNutanixCluster",
                        "refreshOracleDatabase",
                        "refreshVsphereVcenter",
                        "registerHypervScvmm",
                        "reseedLogShippingSecondary",
                        "resizeManagedVolume",
                        "restoreFilesNutanixSnapshot",
                        "restoreHypervVirtualMachineSnapshotFiles",
                        "restoreMssqlDatabase",
                        "restoreOracleLogs",
                        "restoreVolumeGroupSnapshotFiles",
                        "retryAddMongoSource",
                        "setWebSignedCertificate",
                        "startVolumeGroupMount",
                        "supportBundle",
                        "takeManagedVolumeOnDemandSnapshot",
                        "takeMssqlLogBackup",
                        "takeOnDemandOracleDatabaseSnapshot",
                        "takeOnDemandOracleLogSnapshot",
                        "triggerCloudComputeConnectivityCheck",
                        "unconfigureSapHanaRestore",
                        "validateOracleDatabaseBackups",
                        "vmwareDownloadSnapshotFromLocation",
                        "vsphereDeleteVcenter",
                        "vsphereExportSnapshotToStandaloneHostV2",
                        "vsphereOnDemandSnapshot",
                        "vSphereVMAsyncRequestStatus",
                        "vsphereVmDownloadSnapshot",
                        "vsphereVmDownloadSnapshotFiles",
                        "vsphereVmExportSnapshotV2",
                        "vsphereVmExportSnapshotV3",
                        "vsphereVmExportSnapshotWithDownloadFromCloud",
                        "vsphereVmInitiateDiskMount",
                        "vsphereVmInitiateInPlaceRecovery",
                        "vsphereVmInitiateInstantRecoveryV2",
                        "vsphereVmInitiateLiveMountV2",
                        "vsphereVmMountRelocate",
                        "vsphereVmMountRelocateV2",
                        "vsphereVmRecoverFilesNew",
                    }
                },
                {   "AuthorizedPrincipalConnection", new List<string> {
                        "ldapAuthorizedPrincipalConnection",
                    }
                },
                {   "AwsArtifactsToDelete", new List<string> {
                        "awsArtifactsToDelete",
                    }
                },
                {   "AwsCloudAccountListSecurityGroupsResponse", new List<string> {
                        "awsCloudAccountListSecurityGroups",
                    }
                },
                {   "AwsCloudAccountListSubnetsResponse", new List<string> {
                        "awsCloudAccountListSubnets",
                    }
                },
                {   "AwsCloudAccountListVpcResponse", new List<string> {
                        "awsCloudAccountListVpcs",
                    }
                },
                {   "AwsCloudAccountWithFeatures", new List<string> {
                        "awsCloudAccountWithFeatures",
                    }
                },
                {   "AwsComputeSettings", new List<string> {
                        "awsComputeSettings",
                        "createAwsComputeSetting",
                        "updateAwsComputeSetting",
                    }
                },
                {   "AwsNativeAccount", new List<string> {
                        "awsNativeAccount",
                    }
                },
                {   "AwsNativeAccountConnection", new List<string> {
                        "awsNativeAccounts",
                    }
                },
                {   "AwsNativeEbsVolume", new List<string> {
                        "awsNativeEbsVolume",
                    }
                },
                {   "AwsNativeEbsVolumeConnection", new List<string> {
                        "awsNativeEbsVolumes",
                        "awsNativeEbsVolumesByName",
                    }
                },
                {   "AwsNativeEc2Instance", new List<string> {
                        "awsNativeEc2Instance",
                    }
                },
                {   "AwsNativeEc2InstanceConnection", new List<string> {
                        "awsNativeEc2Instances",
                        "awsNativeEc2InstancesByName",
                    }
                },
                {   "AwsNativeRdsInstance", new List<string> {
                        "awsNativeRdsInstance",
                    }
                },
                {   "AwsNativeRdsInstanceConnection", new List<string> {
                        "awsNativeRdsInstances",
                    }
                },
                {   "AwsNativeRdsPointInTimeRestoreWindow", new List<string> {
                        "awsNativeRdsPointInTimeRestoreWindow",
                    }
                },
                {   "AwsNativeRoot", new List<string> {
                        "awsNativeRoot",
                    }
                },
                {   "AwsNativeS3Bucket", new List<string> {
                        "awsNativeS3Bucket",
                    }
                },
                {   "AwsTrustPolicy", new List<string> {
                        "awsTrustPolicy",
                    }
                },
                {   "AzureCloudAccountPermissionConfigResponse", new List<string> {
                        "azureCloudAccountPermissionConfig",
                    }
                },
                {   "AzureCloudAccountSubscriptionWithFeatures", new List<string> {
                        "azureCloudAccountSubscriptionWithFeatures",
                    }
                },
                {   "AzureCloudAccountTenant", new List<string> {
                        "azureCloudAccountTenant",
                    }
                },
                {   "AzureCloudAccountTenantWithExoConfigs", new List<string> {
                        "azureCloudAccountTenantWithExoConfigs",
                    }
                },
                {   "AzureNativeManagedDisk", new List<string> {
                        "azureNativeManagedDisk",
                    }
                },
                {   "AzureNativeManagedDiskConnection", new List<string> {
                        "azureNativeManagedDisks",
                    }
                },
                {   "AzureNativeResourceGroup", new List<string> {
                        "azureNativeResourceGroup",
                    }
                },
                {   "AzureNativeResourceGroupConnection", new List<string> {
                        "azureNativeResourceGroups",
                    }
                },
                {   "AzureNativeRoot", new List<string> {
                        "azureNativeRoot",
                    }
                },
                {   "AzureNativeSqlDatabasePointInTimeRestoreWindow", new List<string> {
                        "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                        "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                    }
                },
                {   "AzureNativeSubscription", new List<string> {
                        "azureNativeSubscription",
                    }
                },
                {   "AzureNativeSubscriptionConnection", new List<string> {
                        "azureNativeSubscriptions",
                    }
                },
                {   "AzureNativeVirtualMachine", new List<string> {
                        "azureNativeVirtualMachine",
                    }
                },
                {   "AzureNativeVirtualMachineConnection", new List<string> {
                        "azureNativeVirtualMachines",
                    }
                },
                {   "AzureNetworkSecurityGroupResp", new List<string> {
                        "azureO365CheckNSGOutboundRules",
                    }
                },
                {   "AzureNetworkSubnetResp", new List<string> {
                        "azureO365CheckNetworkSubnet",
                    }
                },
                {   "AzureNetworkSubnetUnusedAddrResp", new List<string> {
                        "azureO365GetNetworkSubnetUnusedAddr",
                    }
                },
                {   "AzureOauthConsentKickoffReply", new List<string> {
                        "azureOauthConsentKickoff",
                    }
                },
                {   "AzureRegionsResp", new List<string> {
                        "allHostedAzureRegions",
                    }
                },
                {   "AzureResourceAvailabilityResp", new List<string> {
                        "azureO365CheckResourceGroupName",
                        "azureO365CheckStorageAccountAccessibility",
                        "azureO365CheckStorageAccountName",
                        "azureO365CheckSubscriptionQuota",
                        "azureO365CheckVirtualNetworkName",
                    }
                },
                {   "AzureSqlDatabaseDb", new List<string> {
                        "azureSqlDatabase",
                    }
                },
                {   "AzureSqlDatabaseDbConnection", new List<string> {
                        "azureSqlDatabases",
                    }
                },
                {   "AzureSqlDatabaseServer", new List<string> {
                        "azureSqlDatabaseServer",
                    }
                },
                {   "AzureSqlDatabaseServerConnection", new List<string> {
                        "azureSqlDatabaseServers",
                    }
                },
                {   "AzureSqlManagedInstanceDatabase", new List<string> {
                        "azureSqlManagedInstanceDatabase",
                    }
                },
                {   "AzureSqlManagedInstanceDatabaseConnection", new List<string> {
                        "azureSqlManagedInstanceDatabases",
                    }
                },
                {   "AzureSqlManagedInstanceServer", new List<string> {
                        "azureSqlManagedInstanceServer",
                    }
                },
                {   "AzureSqlManagedInstanceServerConnection", new List<string> {
                        "azureSqlManagedInstanceServers",
                    }
                },
                {   "AzureSubscriptionConnection", new List<string> {
                        "azureSubscriptions",
                    }
                },
                {   "AzureUserRoleResp", new List<string> {
                        "azureO365ValidateUserRoles",
                    }
                },
                {   "BatchAsyncJobStatus", new List<string> {
                        "backupO365Mailbox",
                        "backupO365Onedrive",
                        "backupO365SharepointDrive",
                        "backupO365Team",
                        "gcpNativeRefreshProjects",
                        "setupCloudNativeSqlServerBackup",
                        "startAwsNativeEc2InstanceSnapshotsJob",
                        "startAwsNativeRdsInstanceSnapshotsJob",
                        "startCloudNativeSnapshotsIndexJob",
                        "startCreateAwsNativeEbsVolumeSnapshotsJob",
                        "startCreateAzureNativeManagedDiskSnapshotsJob",
                        "startCreateAzureNativeVirtualMachineSnapshotsJob",
                        "startDisableAzureCloudAccountJob",
                        "startRefreshAwsNativeAccountsJob",
                        "startRefreshAzureNativeSubscriptionsJob",
                    }
                },
                {   "BatchAsyncRequestStatus", new List<string> {
                        "bulkDeleteNasSystems",
                        "createNutanixPrismCentral",
                        "deleteNutanixPrismCentral",
                        "refreshNutanixPrismCentral",
                        "vsphereBulkOnDemandSnapshot",
                        "vsphereVmBatchExport",
                        "vsphereVmBatchExportV3",
                        "vsphereVmBatchInPlaceRecovery",
                        "vsphereVmInitiateBatchInstantRecovery",
                        "vsphereVmInitiateBatchLiveMountV2",
                    }
                },
                {   "BatchExportHypervVmReply", new List<string> {
                        "batchExportHypervVm",
                    }
                },
                {   "BatchExportNutanixVmReply", new List<string> {
                        "batchExportNutanixVm",
                    }
                },
                {   "BatchInstantRecoverHypervVmReply", new List<string> {
                        "batchInstantRecoverHypervVm",
                    }
                },
                {   "BatchMountHypervVmReply", new List<string> {
                        "batchMountHypervVm",
                    }
                },
                {   "BatchMountNutanixVmReply", new List<string> {
                        "batchMountNutanixVm",
                    }
                },
                {   "BatchOnDemandBackupHypervVmReply", new List<string> {
                        "batchOnDemandBackupHypervVm",
                    }
                },
                {   "BatchQuarantineSnapshotReply", new List<string> {
                        "batchQuarantineSnapshot",
                    }
                },
                {   "BatchReleaseFromQuarantineSnapshotReply", new List<string> {
                        "batchReleaseFromQuarantineSnapshot",
                    }
                },
                {   "BatchVmwareCdpLiveInfo", new List<string> {
                        "vsphereVmwareCdpLiveInfo",
                    }
                },
                {   "BatchVmwareVmRecoverableRanges", new List<string> {
                        "vsphereVMRecoverableRangeInBatch",
                    }
                },
                {   "BeginManagedVolumeSnapshotReply", new List<string> {
                        "beginManagedVolumeSnapshot",
                    }
                },
                {   "Boolean", new List<string> {
                        "addInventoryWorkloads",
                        "addRoleAssignments",
                        "areMultiGeoBackupsEnabled",
                        "batchDeassignRoleFromUserGroups",
                        "cancelActivitySeries",
                        "changePassword",
                        "cloudNativeCheckRequiredPermissionsForFeature",
                        "deleteCertificate",
                        "deleteCloudWorkloadSnapshot",
                        "deleteGuestCredentialById",
                        "deleteLdapPrincipals",
                        "deleteOrg",
                        "deleteRole",
                        "deleteServiceAccountsFromAccount",
                        "deleteTotpConfig",
                        "deleteTotpConfigs",
                        "deleteUsersFromAccount",
                        "doesAzureNativeResourceGroupExist",
                        "dummyFieldWithAdminOnlyTag",
                        "gcpCloudAccountAddManualAuthProject",
                        "gcpSetDefaultServiceAccountJwtConfig",
                        "hasIdpConfigured",
                        "inviteSsoGroup",
                        "isAwsNativeRdsInstanceLaunchConfigurationValid",
                        "isAwsS3BucketNameAvailable",
                        "isAzureNativeManagedDiskSnapshotRestorable",
                        "isAzureNativeSqlDatabaseSnapshotPersistent",
                        "isAzureStorageAccountNameAvailable",
                        "isSfdcReachable",
                        "isTotpAckNecessaryForCluster",
                        "isTotpMandatoryInTargetVersion",
                        "isVMwareManagementEnabled",
                        "patchAwsAuthenticationServerBasedCloudAccount",
                        "patchAwsIamUserBasedCloudAccount",
                        "removeCdmCluster",
                        "removeInventoryWorkloads",
                        "removeLdapIntegration",
                        "setAzureCloudAccountCustomerAppCredentials",
                        "setIpWhitelistEnabled",
                        "setLdapMfaSetting",
                        "setMfaSetting",
                        "setTotpConfig",
                        "setUserLevelTotpEnforcement",
                        "teamChannelNameAvailable",
                        "updateAccountOwner",
                        "updateCertificate",
                        "updateIpWhitelist",
                        "updateRole",
                        "updateRoleAssignments",
                        "upgradeAwsCloudAccountFeaturesWithoutCft",
                        "upgradeAwsIamUserBasedCloudAccountPermissions",
                        "warmSearchCache",
                    }
                },
                {   "BootstrappableNodeInfoListResponse", new List<string> {
                        "discoverNodes",
                    }
                },
                {   "BrowseMssqlDatabaseSnapshotReply", new List<string> {
                        "browseMssqlDatabaseSnapshot",
                    }
                },
                {   "BrowseResponseListResponse", new List<string> {
                        "filesetSnapshotFiles",
                        "nutanixBrowseSnapshot",
                    }
                },
                {   "BulkCreateFilesetTemplatesReply", new List<string> {
                        "bulkCreateFilesetTemplates",
                    }
                },
                {   "BulkCreateFilesetsReply", new List<string> {
                        "bulkCreateFilesets",
                    }
                },
                {   "BulkCreateNasFilesetsReply", new List<string> {
                        "bulkCreateNasFilesets",
                    }
                },
                {   "BulkDeleteAwsCloudAccountWithoutCftReply", new List<string> {
                        "bulkDeleteAwsCloudAccountWithoutCft",
                    }
                },
                {   "BulkOnDemandSnapshotNutanixVmReply", new List<string> {
                        "bulkOnDemandSnapshotNutanixVm",
                    }
                },
                {   "BulkRefreshHostsReply", new List<string> {
                        "bulkRefreshHosts",
                    }
                },
                {   "BulkRegisterHostReply", new List<string> {
                        "bulkRegisterHost",
                    }
                },
                {   "BulkUpdateFilesetTemplateReply", new List<string> {
                        "bulkUpdateFilesetTemplate",
                    }
                },
                {   "BulkUpdateHostReply", new List<string> {
                        "bulkUpdateHost",
                    }
                },
                {   "BulkUpdateMssqlDbsReply", new List<string> {
                        "bulkUpdateMssqlDbs",
                    }
                },
                {   "BulkUpdateOracleDatabasesReply", new List<string> {
                        "bulkUpdateOracleDatabases",
                    }
                },
                {   "BulkUpdateOracleHostsReply", new List<string> {
                        "bulkUpdateOracleHosts",
                    }
                },
                {   "BulkUpdateOracleRacsReply", new List<string> {
                        "bulkUpdateOracleRacs",
                    }
                },
                {   "CancelJobReply", new List<string> {
                        "cancelDownloadPackage",
                        "cancelScheduledUpgrade",
                    }
                },
                {   "CassandraColumnFamily", new List<string> {
                        "cassandraColumnFamily",
                    }
                },
                {   "CassandraColumnFamilyConnection", new List<string> {
                        "cassandraColumnFamilies",
                    }
                },
                {   "CassandraKeyspace", new List<string> {
                        "cassandraKeyspace",
                    }
                },
                {   "CassandraKeyspaceConnection", new List<string> {
                        "cassandraKeyspaces",
                    }
                },
                {   "CassandraSource", new List<string> {
                        "cassandraSource",
                    }
                },
                {   "CassandraSourceConnection", new List<string> {
                        "cassandraSources",
                    }
                },
                {   "CcProvisionJobReply", new List<string> {
                        "addNodesToCloudCluster",
                        "createAwsCluster",
                        "createAzureCluster",
                        "deleteAwsCluster",
                        "deleteAzureCluster",
                        "recoverCloudCluster",
                        "removeCloudClusterNodes",
                        "removeClusterNodes",
                    }
                },
                {   "CdmHierarchyObjectConnection", new List<string> {
                        "nasTopLevelDescendants",
                        "nutanixTopLevelDescendants",
                        "vSphereRootRecoveryHierarchy",
                        "vSphereTopLevelDescendantsConnection",
                    }
                },
                {   "CdmHierarchySnappableNew", new List<string> {
                        "cdmHierarchySnappableNew",
                    }
                },
                {   "CdmInventorySubHierarchyRoot", new List<string> {
                        "cdmInventorySubHierarchyRoot",
                    }
                },
                {   "CdmSnapshot", new List<string> {
                        "snapshot",
                    }
                },
                {   "CdmUpgradeAvailabilityReply", new List<string> {
                        "isUpgradeAvailable",
                    }
                },
                {   "CdmUpgradeRecommendationReply", new List<string> {
                        "isUpgradeRecommended",
                    }
                },
                {   "CdmUpgradeReleaseDetailsFromSupportPortalReply", new List<string> {
                        "getCdmReleaseDetailsForClusterFromSupportPortal",
                        "getCdmReleaseDetailsForVersionFromSupportPortal",
                        "getCdmReleaseDetailsFromSupportPortal",
                    }
                },
                {   "CdpVmInfoConnection", new List<string> {
                        "allCdpVmsInfos",
                    }
                },
                {   "CertificateConnection", new List<string> {
                        "certificates",
                        "certificatesWithKey",
                    }
                },
                {   "CertificateSummaryListResponse", new List<string> {
                        "clusterCertificates",
                    }
                },
                {   "ChangeVfdOnHostReply", new List<string> {
                        "changeVfdOnHost",
                    }
                },
                {   "CheckArchivedSnapshotsLockedReply", new List<string> {
                        "cloudNativeCheckArchivedSnapshotsLocked",
                    }
                },
                {   "CheckAzurePersistentStorageSubscriptionCanUnmapReply", new List<string> {
                        "checkAzurePersistentStorageSubscriptionCanUnmap",
                    }
                },
                {   "ClassificationPolicyDetail", new List<string> {
                        "createPolicy",
                        "policy",
                        "updatePolicy",
                    }
                },
                {   "ClassificationPolicyDetailConnection", new List<string> {
                        "policies",
                    }
                },
                {   "ClearCloudNativeSqlServerBackupCredentialsReply", new List<string> {
                        "clearCloudNativeSqlServerBackupCredentials",
                    }
                },
                {   "CloudAccount", new List<string> {
                        "cloudAccount",
                        "createAwsAccount",
                        "createAzureAccount",
                        "updateAwsAccount",
                        "updateAzureAccount",
                    }
                },
                {   "CloudDirectNasExport", new List<string> {
                        "cloudDirectNasExport",
                    }
                },
                {   "CloudDirectSystems", new List<string> {
                        "cloudDirectSystems",
                    }
                },
                {   "CloudNativeCheckRbaConnectivityReply", new List<string> {
                        "cloudNativeCheckRbaConnectivity",
                    }
                },
                {   "CloudNativeCustomerTagsReply", new List<string> {
                        "cloudNativeCustomerTags",
                    }
                },
                {   "CloudNativeSnapshotDetailsForRecoveryReply", new List<string> {
                        "cloudNativeSnapshotDetailsForRecovery",
                    }
                },
                {   "CloudNativeSqlServerSetupScript", new List<string> {
                        "cloudNativeSqlServerSetupScript",
                    }
                },
                {   "CloudNativeVersionedFileConnection", new List<string> {
                        "cloudNativeWorkloadVersionedFiles",
                    }
                },
                {   "Cluster", new List<string> {
                        "cluster",
                        "updateClusterLocation",
                        "updatePreviewerClusterConfig",
                    }
                },
                {   "ClusterConnection", new List<string> {
                        "allClusterConnection",
                        "clusterConnection",
                        "clusterWithUpgradesInfo",
                        "radarClusterConnection",
                    }
                },
                {   "ClusterCsr", new List<string> {
                        "clusterCsr",
                    }
                },
                {   "ClusterDnsReply", new List<string> {
                        "clusterDns",
                    }
                },
                {   "ClusterGroupByConnection", new List<string> {
                        "clusterGroupByConnection",
                    }
                },
                {   "ClusterIpv6ModeReply", new List<string> {
                        "clusterIpv6Mode",
                    }
                },
                {   "ClusterLicenseCapacityValidations", new List<string> {
                        "validateClusterLicenseCapacity",
                    }
                },
                {   "ClusterOperationJobProgress", new List<string> {
                        "clusterOperationJobProgress",
                    }
                },
                {   "ClusterProxyReply", new List<string> {
                        "clusterProxy",
                    }
                },
                {   "ClusterRegistrationProductInfoType", new List<string> {
                        "clusterRegistrationProductInfo",
                    }
                },
                {   "ClusterRegistrationToken", new List<string> {
                        "generateClusterRegistrationToken",
                    }
                },
                {   "ClusterReportMigrationJobStatus", new List<string> {
                        "clusterReportMigrationJobStatus",
                    }
                },
                {   "ClusterSlaDomainConnection", new List<string> {
                        "clusterSlaDomains",
                    }
                },
                {   "ClusterWebSignedCertificateReply", new List<string> {
                        "clusterWebSignedCertificate",
                    }
                },
                {   "CompleteAzureCloudAccountOauthReply", new List<string> {
                        "completeAzureCloudAccountOauth",
                    }
                },
                {   "ComputeClusterDetail", new List<string> {
                        "computeClusterStatus",
                    }
                },
                {   "CountOfObjectsProtectedBySLAsResult", new List<string> {
                        "countOfObjectsProtectedBySlas",
                    }
                },
                {   "Crawl", new List<string> {
                        "crawl",
                    }
                },
                {   "CrawlConnection", new List<string> {
                        "crawls",
                    }
                },
                {   "CreateAwsExocomputeConfigsReply", new List<string> {
                        "createAwsExocomputeConfigs",
                    }
                },
                {   "CreateAzureSaasAppAadReply", new List<string> {
                        "createAzureSaasAppAad",
                    }
                },
                {   "CreateCloudNativeAwsStorageSettingReply", new List<string> {
                        "createCloudNativeAwsStorageSetting",
                    }
                },
                {   "CreateCloudNativeAzureStorageSettingReply", new List<string> {
                        "createCloudNativeAzureStorageSetting",
                    }
                },
                {   "CreateCloudNativeLabelRuleReply", new List<string> {
                        "createCloudNativeLabelRule",
                    }
                },
                {   "CreateCloudNativeRcvAzureStorageSettingReply", new List<string> {
                        "createCloudNativeRcvAzureStorageSetting",
                    }
                },
                {   "CreateCloudNativeTagRuleReply", new List<string> {
                        "createCloudNativeTagRule",
                    }
                },
                {   "CreateCustomReportReply", new List<string> {
                        "createCustomReport",
                    }
                },
                {   "CreateFailoverClusterAppReply", new List<string> {
                        "createFailoverClusterApp",
                    }
                },
                {   "CreateFailoverClusterReply", new List<string> {
                        "createFailoverCluster",
                    }
                },
                {   "CreateGuestCredentialReply", new List<string> {
                        "createGuestCredential",
                    }
                },
                {   "CreateIntegrationReply", new List<string> {
                        "createIntegration",
                    }
                },
                {   "CreateIntegrationsReply", new List<string> {
                        "createIntegrations",
                    }
                },
                {   "CreateK8sAgentManifestReply", new List<string> {
                        "createK8sAgentManifest",
                    }
                },
                {   "CreateK8sClusterReply", new List<string> {
                        "createK8sCluster",
                    }
                },
                {   "CreateO365AppKickoffResp", new List<string> {
                        "createO365AppKickoff",
                    }
                },
                {   "CreateOnDemandJobReply", new List<string> {
                        "backupO365SharepointList",
                        "backupO365SharePointSite",
                        "deleteO365Org",
                        "exportK8sNamespace",
                        "exportO365Mailbox",
                        "refreshK8sCluster",
                        "refreshO365Org",
                        "restoreK8sNamespace",
                        "restoreO365Mailbox",
                        "restoreO365Snappable",
                        "restoreO365TeamsConversations",
                        "restoreO365TeamsFiles",
                    }
                },
                {   "CreateOrgReply", new List<string> {
                        "createOrg",
                    }
                },
                {   "CreateOrgSwitchSessionReply", new List<string> {
                        "createOrgSwitchSession",
                    }
                },
                {   "CreateRcvPrivateEndpointApprovalRequestReply", new List<string> {
                        "createRcvPrivateEndpointApprovalRequest",
                    }
                },
                {   "CreateScheduledReportReply", new List<string> {
                        "createScheduledReport",
                    }
                },
                {   "CreateServiceAccountReply", new List<string> {
                        "createServiceAccount",
                    }
                },
                {   "CreateVappsInstantRecoveryReply", new List<string> {
                        "createVappsInstantRecovery",
                    }
                },
                {   "CreateVsphereAdvancedTagReply", new List<string> {
                        "createVsphereAdvancedTag",
                    }
                },
                {   "CreateVsphereVcenterReply", new List<string> {
                        "createVsphereVcenter",
                    }
                },
                {   "CreateWebhookReply", new List<string> {
                        "createWebhook",
                    }
                },
                {   "Csr", new List<string> {
                        "certificateSigningRequest",
                        "generateCsr",
                    }
                },
                {   "CsrConnection", new List<string> {
                        "certificateSigningRequests",
                    }
                },
                {   "Db2Database", new List<string> {
                        "db2Database",
                    }
                },
                {   "Db2DatabaseConnection", new List<string> {
                        "db2Databases",
                    }
                },
                {   "Db2Instance", new List<string> {
                        "db2Instance",
                    }
                },
                {   "Db2InstanceConnection", new List<string> {
                        "db2Instances",
                    }
                },
                {   "Db2LogSnapshot", new List<string> {
                        "db2LogSnapshot",
                    }
                },
                {   "Db2LogSnapshotConnection", new List<string> {
                        "db2LogSnapshots",
                    }
                },
                {   "Db2RecoverableRange", new List<string> {
                        "db2RecoverableRange",
                    }
                },
                {   "Db2RecoverableRangeConnection", new List<string> {
                        "db2RecoverableRanges",
                    }
                },
                {   "DbLogReportProperties", new List<string> {
                        "databaseLogReportingPropertiesForCluster",
                        "updateDatabaseLogReportingPropertiesForCluster",
                    }
                },
                {   "DbLogReportSummaryListReply", new List<string> {
                        "databaseLogReportForCluster",
                    }
                },
                {   "DeleteAwsExocomputeConfigsReply", new List<string> {
                        "deleteAwsExocomputeConfigs",
                    }
                },
                {   "DeleteAzureCloudAccountExocomputeConfigurationsReply", new List<string> {
                        "deleteAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "DeleteAzureCloudAccountReply", new List<string> {
                        "deleteAzureCloudAccount",
                    }
                },
                {   "DeleteAzureCloudAccountWithoutOauthReply", new List<string> {
                        "deleteAzureCloudAccountWithoutOauth",
                    }
                },
                {   "DeleteManagedVolumeReply", new List<string> {
                        "deleteManagedVolume",
                    }
                },
                {   "DeleteStorageArraysReply", new List<string> {
                        "deleteStorageArrays",
                    }
                },
                {   "DiffResult", new List<string> {
                        "diffFmd",
                        "searchFileByPrefix",
                    }
                },
                {   "DisableTargetReply", new List<string> {
                        "disableTarget",
                    }
                },
                {   "DiskInfo", new List<string> {
                        "setupDisk",
                    }
                },
                {   "DownloadCdmUpgradesPdfReply", new List<string> {
                        "downloadCdmUpgradesPdf",
                    }
                },
                {   "DownloadCsvReply", new List<string> {
                        "downloadObjectFilesCsv",
                        "downloadObjectsListCsv",
                        "downloadSnapshotResultsCsv",
                        "downloadUserActivityCsv",
                        "downloadUserFileActivityCsv",
                    }
                },
                {   "DownloadFilesReply", new List<string> {
                        "cloudNativeDownloadFiles",
                    }
                },
                {   "DownloadPackageReply", new List<string> {
                        "retryDownloadPackageJob",
                    }
                },
                {   "DownloadPackageStatusReply", new List<string> {
                        "downloadPackageStatus",
                    }
                },
                {   "DownloadResultsCsvReply", new List<string> {
                        "downloadResultsCsv",
                    }
                },
                {   "DownloadThreatHuntCsvReply", new List<string> {
                        "downloadThreatHuntCsv",
                    }
                },
                {   "EdgeWindowsToolLink", new List<string> {
                        "edgeWindowsToolLink",
                    }
                },
                {   "EnableAutomaticFmdUploadReply", new List<string> {
                        "enableAutomaticFmdUpload",
                    }
                },
                {   "EnableDisableAppConsistencyReply", new List<string> {
                        "enableDisableAppConsistency",
                    }
                },
                {   "EnableTargetReply", new List<string> {
                        "enableTarget",
                    }
                },
                {   "EndManagedVolumeSnapshotReply", new List<string> {
                        "endManagedVolumeSnapshot",
                    }
                },
                {   "ExchangeDag", new List<string> {
                        "exchangeDag",
                    }
                },
                {   "ExchangeDagConnection", new List<string> {
                        "exchangeDags",
                    }
                },
                {   "ExchangeDatabase", new List<string> {
                        "exchangeDatabase",
                    }
                },
                {   "ExchangeDatabaseConnection", new List<string> {
                        "exchangeDatabases",
                    }
                },
                {   "ExchangeLiveMountConnection", new List<string> {
                        "exchangeLiveMounts",
                    }
                },
                {   "ExchangeServer", new List<string> {
                        "exchangeServer",
                    }
                },
                {   "ExchangeServerConnection", new List<string> {
                        "exchangeServers",
                    }
                },
                {   "ExportUrlSpecs", new List<string> {
                        "decryptExportUrl",
                    }
                },
                {   "FailoverClusterApp", new List<string> {
                        "failoverClusterApp",
                    }
                },
                {   "FailoverClusterAppConnection", new List<string> {
                        "failoverClusterApps",
                    }
                },
                {   "FailoverClusterTopLevelDescendantTypeConnection", new List<string> {
                        "failoverClusterTopLevelDescendants",
                    }
                },
                {   "FeatureCdmVersionReply", new List<string> {
                        "cdmVersionCheck",
                    }
                },
                {   "FeatureListMinimumCdmVersionReply", new List<string> {
                        "minimumCdmVersionForFeatureSet",
                    }
                },
                {   "FederatedLoginStatus", new List<string> {
                        "federatedLoginStatus",
                    }
                },
                {   "FileResultConnection", new List<string> {
                        "objectFiles",
                        "userActivities",
                    }
                },
                {   "FilesetSnapshotDetail", new List<string> {
                        "filesetSnapshot",
                    }
                },
                {   "FilesetTemplate", new List<string> {
                        "filesetTemplate",
                    }
                },
                {   "FilesetTemplateConnection", new List<string> {
                        "filesetTemplates",
                    }
                },
                {   "FinalizeAwsCloudAccountDeletionReply", new List<string> {
                        "finalizeAwsCloudAccountDeletion",
                    }
                },
                {   "FinalizeAwsCloudAccountProtectionReply", new List<string> {
                        "finalizeAwsCloudAccountProtection",
                    }
                },
                {   "GcpCloudAccountAddProjectsReply", new List<string> {
                        "gcpCloudAccountAddProjects",
                    }
                },
                {   "GcpCloudAccountDeleteProjectsReply", new List<string> {
                        "gcpCloudAccountDeleteProjects",
                    }
                },
                {   "GcpCloudAccountOauthCompleteReply", new List<string> {
                        "gcpCloudAccountOauthComplete",
                    }
                },
                {   "GcpCloudAccountOauthInitiateReply", new List<string> {
                        "gcpCloudAccountOauthInitiate",
                    }
                },
                {   "GcpCloudAccountUpgradeProjectsReply", new List<string> {
                        "gcpCloudAccountUpgradeProjects",
                    }
                },
                {   "GcpNativeDisk", new List<string> {
                        "gcpNativeDisk",
                    }
                },
                {   "GcpNativeDiskConnection", new List<string> {
                        "gcpNativeDisks",
                    }
                },
                {   "GcpNativeGceInstance", new List<string> {
                        "gcpNativeGceInstance",
                    }
                },
                {   "GcpNativeGceInstanceConnection", new List<string> {
                        "gcpNativeGceInstances",
                    }
                },
                {   "GcpNativeProject", new List<string> {
                        "gcpNativeProject",
                    }
                },
                {   "GcpNativeProjectConnection", new List<string> {
                        "gcpNativeProjects",
                    }
                },
                {   "GenerateConfigProtectionRestoreFormReply", new List<string> {
                        "generateConfigProtectionRestoreForm",
                    }
                },
                {   "GenerateTotpSecretReply", new List<string> {
                        "generateTotpSecret",
                    }
                },
                {   "GenericSnapshotConnection", new List<string> {
                        "snapshotOfASnappableConnection",
                        "snapshotOfSnappablesConnection",
                    }
                },
                {   "GetAnomalyDetailsReply", new List<string> {
                        "anomalyResultOpt",
                    }
                },
                {   "GetAzureHostTypeResp", new List<string> {
                        "azureO365GetAzureHostType",
                    }
                },
                {   "GetAzureO365ExocomputeResp", new List<string> {
                        "azureO365Exocompute",
                    }
                },
                {   "GetCloudNativeLabelRulesReply", new List<string> {
                        "cloudNativeLabelRules",
                    }
                },
                {   "GetCloudNativeTagRulesReply", new List<string> {
                        "cloudNativeTagRules",
                    }
                },
                {   "GetDashboardSummaryReply", new List<string> {
                        "dashboardSummary",
                    }
                },
                {   "GetHealthMonitorPolicyStatusReply", new List<string> {
                        "getHealthMonitorPolicyStatus",
                    }
                },
                {   "GetImplicitlyAuthorizedAncestorSummariesResponse", new List<string> {
                        "o365ObjectAncestors",
                    }
                },
                {   "GetImplicitlyAuthorizedObjectSummariesResponse", new List<string> {
                        "o365OrgSummaries",
                    }
                },
                {   "GetLicensedProductsInfoReply", new List<string> {
                        "allLicensedProducts",
                    }
                },
                {   "GetMfaSettingReply", new List<string> {
                        "globalMfaSetting",
                        "mfaSetting",
                    }
                },
                {   "GetMosaicRecoverableRangeResponse", new List<string> {
                        "cassandraColumnFamilyRecoverableRange",
                        "mongodbCollectionRecoverableRange",
                    }
                },
                {   "GetO365ServiceStatusResp", new List<string> {
                        "o365ServiceStatus",
                    }
                },
                {   "GetO365StorageStatsResp", new List<string> {
                        "o365StorageStats",
                    }
                },
                {   "GetPendingSlaAssignmentsReply", new List<string> {
                        "getPendingSlaAssignments",
                    }
                },
                {   "GetPipelineHealthReply", new List<string> {
                        "pipelineHealthForTimeRange",
                    }
                },
                {   "GetPoliciesTimelineReply", new List<string> {
                        "discoveryTimeline",
                    }
                },
                {   "GetS3BucketStateForRecoveryReply", new List<string> {
                        "s3BucketStateForRecovery",
                    }
                },
                {   "GetSchemaResponse", new List<string> {
                        "cassandraColumnFamilySchema",
                    }
                },
                {   "GetSmbConfigurationReply", new List<string> {
                        "smbConfiguration",
                    }
                },
                {   "GetTaskchainStatusReply", new List<string> {
                        "getKorgTaskchainStatus",
                    }
                },
                {   "GetTotpStatusReply", new List<string> {
                        "totpConfigStatus",
                    }
                },
                {   "GetUserDetailReply", new List<string> {
                        "userDetail",
                    }
                },
                {   "GetUserSessionManagementConfigReply", new List<string> {
                        "userSessionManagementConfig",
                    }
                },
                {   "GetWhitelistReply", new List<string> {
                        "ipWhitelist",
                    }
                },
                {   "GetWorkloadAlertSettingReply", new List<string> {
                        "workloadAlertSetting",
                    }
                },
                {   "GlobalFileSearchReply", new List<string> {
                        "globalFileSearch",
                    }
                },
                {   "GlobalManagerConnectivity", new List<string> {
                        "refreshGlobalManagerConnectivityStatus",
                    }
                },
                {   "GlobalSlaForFilterConnection", new List<string> {
                        "globalSlaFilterConnection",
                    }
                },
                {   "GlobalSlaReply", new List<string> {
                        "createGlobalSla",
                        "updateGlobalSla",
                    }
                },
                {   "GlobalSlaStatusConnection", new List<string> {
                        "globalSlaStatuses",
                    }
                },
                {   "GroupConnection", new List<string> {
                        "groupsInCurrentAndDescendantOrganization",
                    }
                },
                {   "GroupCountListWithTotal", new List<string> {
                        "getGroupCountByCdmClusterStatus",
                    }
                },
                {   "GuestCredentialDetailListResponse", new List<string> {
                        "guestCredentials",
                    }
                },
                {   "GuestOsCredentialConnection", new List<string> {
                        "guestCredentialsV2",
                    }
                },
                {   "HelpContentSnippetConnection", new List<string> {
                        "helpContentSnippets",
                    }
                },
                {   "HierarchyObject", new List<string> {
                        "hierarchyObject",
                    }
                },
                {   "HierarchyObjectConnection", new List<string> {
                        "globalSearchResults",
                    }
                },
                {   "HierarchySnappableConnection", new List<string> {
                        "hierarchySnappables",
                    }
                },
                {   "HostDiagnosisSummary", new List<string> {
                        "hostDiagnosis",
                    }
                },
                {   "HostFailoverCluster", new List<string> {
                        "hostFailoverCluster",
                    }
                },
                {   "HostFailoverClusterConnection", new List<string> {
                        "hostFailoverClusters",
                    }
                },
                {   "HostShare", new List<string> {
                        "hostShare",
                    }
                },
                {   "HostShareConnection", new List<string> {
                        "hostShares",
                    }
                },
                {   "HotAddBandwidthInfo", new List<string> {
                        "vCenterHotAddBandwidth",
                    }
                },
                {   "HotAddNetworkConfigWithName", new List<string> {
                        "vCenterHotAddNetwork",
                    }
                },
                {   "HyperVCluster", new List<string> {
                        "hypervCluster",
                    }
                },
                {   "HyperVLiveMountConnection", new List<string> {
                        "hypervMounts",
                    }
                },
                {   "HyperVSCVMM", new List<string> {
                        "hypervScvmm",
                    }
                },
                {   "HyperVSCVMMConnection", new List<string> {
                        "hypervScvmms",
                    }
                },
                {   "HyperVVirtualMachine", new List<string> {
                        "hypervVirtualMachine",
                    }
                },
                {   "HyperVVirtualMachineConnection", new List<string> {
                        "hypervVirtualMachines",
                    }
                },
                {   "HypervHostSummaryListResponse", new List<string> {
                        "hypervServers",
                    }
                },
                {   "HypervScvmmUpdateReply", new List<string> {
                        "hypervScvmmUpdate",
                    }
                },
                {   "HypervServer", new List<string> {
                        "hypervServer",
                    }
                },
                {   "HypervTopLevelDescendantTypeConnection", new List<string> {
                        "hypervTopLevelDescendants",
                    }
                },
                {   "HypervVirtualMachineDetail", new List<string> {
                        "hypervVmDetail",
                    }
                },
                {   "Int", new List<string> {
                        "maxProtectedAppsCount",
                        "uniqueHypervServersCount",
                        "uniqueVcdCount",
                        "vCenterNumProxiesNeeded",
                    }
                },
                {   "InternalGetClusterIpsResponse", new List<string> {
                        "clusterFloatingIps",
                    }
                },
                {   "InternalGetDefaultGatewayResponse", new List<string> {
                        "clusterDefaultGateway",
                    }
                },
                {   "InternalReplicationBandwidthIncomingResponse", new List<string> {
                        "replicationIncomingStats",
                    }
                },
                {   "InternalReplicationBandwidthOutgoingResponse", new List<string> {
                        "replicationOutgoingStats",
                    }
                },
                {   "InventoryRoot", new List<string> {
                        "inventoryRoot",
                    }
                },
                {   "InventorySubHierarchyRoot", new List<string> {
                        "inventorySubHierarchyRoot",
                    }
                },
                {   "InvestigationCsvDownloadLinkReply", new List<string> {
                        "investigationCsvDownloadLink",
                    }
                },
                {   "IsCloudNativeTagRuleNameUniqueReply", new List<string> {
                        "checkCloudNativeLabelRuleNameUniqueness",
                        "checkCloudNativeTagRuleNameUniqueness",
                    }
                },
                {   "IsVolumeSnapshotRestorableReply", new List<string> {
                        "isAwsNativeEbsVolumeSnapshotRestorable",
                    }
                },
                {   "Issue", new List<string> {
                        "issue",
                    }
                },
                {   "IssueConnection", new List<string> {
                        "issues",
                    }
                },
                {   "K8sAppManifest", new List<string> {
                        "k8sAppManifest",
                    }
                },
                {   "K8sCluster", new List<string> {
                        "k8sCluster",
                    }
                },
                {   "K8sClusterConnection", new List<string> {
                        "k8sClusters",
                    }
                },
                {   "K8sNamespace", new List<string> {
                        "k8sNamespace",
                    }
                },
                {   "K8sNamespaceConnection", new List<string> {
                        "k8sNamespaces",
                    }
                },
                {   "K8sSnapshotInfo", new List<string> {
                        "k8sSnapshotInfo",
                    }
                },
                {   "KnowledgeBaseArticle", new List<string> {
                        "knowledgeBaseArticle",
                    }
                },
                {   "LambdaSettings", new List<string> {
                        "lambdaSettings",
                        "updateLambdaSettings",
                    }
                },
                {   "LdapIntegrationConnection", new List<string> {
                        "ldapIntegrationConnection",
                    }
                },
                {   "LegalHoldSnappableDetailConnection", new List<string> {
                        "snappablesWithLegalHoldSnapshotsSummary",
                    }
                },
                {   "LegalHoldSnapshotDetailConnection", new List<string> {
                        "legalHoldSnapshotsForSnappable",
                    }
                },
                {   "LicensesForClusterProductReply", new List<string> {
                        "licensesForClusterProductSummary",
                    }
                },
                {   "LinuxFileset", new List<string> {
                        "linuxFileset",
                    }
                },
                {   "ListCidrsForComputeSettingReply", new List<string> {
                        "listCidrsForComputeSetting",
                    }
                },
                {   "ListIntegrationsReply", new List<string> {
                        "allIntegrations",
                    }
                },
                {   "ListLocationsReply", new List<string> {
                        "ransomwareDetectionWorkloadLocations",
                    }
                },
                {   "ListStoreResponse", new List<string> {
                        "mosaicStores",
                    }
                },
                {   "ListStoredDiskLocationsReply", new List<string> {
                        "gcpNativeStoredDiskLocations",
                    }
                },
                {   "ListVersionResponse", new List<string> {
                        "mosaicSnapshots",
                        "mosaicVersions",
                    }
                },
                {   "LockoutConfig", new List<string> {
                        "globalLockoutConfig",
                        "lockoutConfig",
                    }
                },
                {   "LookupAccountReply", new List<string> {
                        "lookupAccount",
                    }
                },
                {   "M365RegionsResp", new List<string> {
                        "m365Regions",
                    }
                },
                {   "ManagedVolume", new List<string> {
                        "managedVolume",
                        "slaManagedVolume",
                    }
                },
                {   "ManagedVolumeConnection", new List<string> {
                        "managedVolumes",
                        "slaManagedVolumes",
                    }
                },
                {   "ManagedVolumeInventoryStats", new List<string> {
                        "managedVolumeInventoryStats",
                    }
                },
                {   "ManagedVolumeMountConnection", new List<string> {
                        "managedVolumeLiveMounts",
                    }
                },
                {   "MapAzureCloudAccountExocomputeSubscriptionReply", new List<string> {
                        "mapAzureCloudAccountExocomputeSubscription",
                    }
                },
                {   "MapAzureCloudAccountToPersistentStorageLocationReply", new List<string> {
                        "mapAzureCloudAccountToPersistentStorageLocation",
                    }
                },
                {   "MapCloudAccountExocomputeAccountReply", new List<string> {
                        "mapCloudAccountExocomputeAccount",
                    }
                },
                {   "MissedSnapshotListResponse", new List<string> {
                        "mssqlDatabaseMissedSnapshots",
                        "nutanixVmMissedSnapshots",
                        "oracleMissedSnapshots",
                    }
                },
                {   "ModifyIpmiReply", new List<string> {
                        "clusterIpmi",
                        "modifyIpmi",
                    }
                },
                {   "MongoCollection", new List<string> {
                        "mongoCollection",
                    }
                },
                {   "MongoCollectionConnection", new List<string> {
                        "mongoCollections",
                    }
                },
                {   "MongoDatabase", new List<string> {
                        "mongoDatabase",
                    }
                },
                {   "MongoDatabaseConnection", new List<string> {
                        "mongoDatabases",
                    }
                },
                {   "MongoRecoverableRanges", new List<string> {
                        "mongoBulkRecoverableRanges",
                        "mongoRecoverableRanges",
                    }
                },
                {   "MongoSource", new List<string> {
                        "mongoSource",
                    }
                },
                {   "MongoSourceConnection", new List<string> {
                        "mongoSources",
                    }
                },
                {   "MongodbCollection", new List<string> {
                        "mongodbCollection",
                    }
                },
                {   "MongodbCollectionConnection", new List<string> {
                        "mongodbCollections",
                    }
                },
                {   "MongodbDatabase", new List<string> {
                        "mongodbDatabase",
                    }
                },
                {   "MongodbDatabaseConnection", new List<string> {
                        "mongodbDatabases",
                    }
                },
                {   "MongodbSource", new List<string> {
                        "mongodbSource",
                    }
                },
                {   "MongodbSourceConnection", new List<string> {
                        "mongodbSources",
                    }
                },
                {   "MosaicAsyncResponse", new List<string> {
                        "addMosaicStore",
                        "bulkDeleteCassandraSources",
                        "bulkDeleteMongodbSources",
                        "createCassandraSource",
                        "createMongodbSource",
                        "deleteCassandraSource",
                        "deleteMongodbSource",
                        "deleteMosaicStore",
                        "recoverCassandraSource",
                        "recoverMongodbSource",
                        "updateCassandraSource",
                        "updateMongodbSource",
                        "updateMosaicStore",
                    }
                },
                {   "MosaicRecoveryRangeResponse", new List<string> {
                        "mongodbBulkRecoverableRange",
                        "mosaicBulkRecoveryRange",
                    }
                },
                {   "MountDiskReply", new List<string> {
                        "mountDisk",
                    }
                },
                {   "MssqlAvailabilityGroup", new List<string> {
                        "mssqlAvailabilityGroup",
                    }
                },
                {   "MssqlDatabase", new List<string> {
                        "mssqlDatabase",
                    }
                },
                {   "MssqlDatabaseConnection", new List<string> {
                        "mssqlDatabases",
                    }
                },
                {   "MssqlDatabaseLiveMountConnection", new List<string> {
                        "mssqlDatabaseLiveMounts",
                    }
                },
                {   "MssqlInstance", new List<string> {
                        "mssqlInstance",
                    }
                },
                {   "MssqlInstanceSummaryListResponse", new List<string> {
                        "mssqlCompatibleInstances",
                    }
                },
                {   "MssqlLogShippingSummaryV2ListResponse", new List<string> {
                        "mssqlLogShippingTargets",
                    }
                },
                {   "MssqlLogShippingTarget", new List<string> {
                        "cdmMssqlLogShippingTarget",
                    }
                },
                {   "MssqlLogShippingTargetConnection", new List<string> {
                        "cdmMssqlLogShippingTargets",
                    }
                },
                {   "MssqlMissedRecoverableRangeListResponse", new List<string> {
                        "mssqlDatabaseMissedRecoverableRanges",
                    }
                },
                {   "MssqlRecoverableRangeListResponse", new List<string> {
                        "mssqlRecoverableRanges",
                    }
                },
                {   "MssqlRestoreEstimateResult", new List<string> {
                        "mssqlDatabaseRestoreEstimate",
                    }
                },
                {   "MssqlTopLevelDescendantTypeConnection", new List<string> {
                        "mssqlTopLevelDescendants",
                    }
                },
                {   "NasFileset", new List<string> {
                        "nasFileset",
                    }
                },
                {   "NasNamespace", new List<string> {
                        "nasNamespace",
                    }
                },
                {   "NasNamespaceConnection", new List<string> {
                        "nasNamespaces",
                    }
                },
                {   "NasShare", new List<string> {
                        "nasShare",
                    }
                },
                {   "NasSystem", new List<string> {
                        "nasSystem",
                    }
                },
                {   "NasSystemConnection", new List<string> {
                        "nasSystems",
                    }
                },
                {   "NasVolume", new List<string> {
                        "nasVolume",
                    }
                },
                {   "NcdBackEndCapacity", new List<string> {
                        "ncdBackEndCapacity",
                    }
                },
                {   "NcdFrontEndCapacity", new List<string> {
                        "ncdFrontEndCapacity",
                    }
                },
                {   "NcdObjectProtectionStatus", new List<string> {
                        "ncdObjectProtectionStatus",
                    }
                },
                {   "NetworkInfoListResponse", new List<string> {
                        "vCenterNetworks",
                    }
                },
                {   "NetworkInterfaceListResponse", new List<string> {
                        "clusterNetworkInterfaces",
                    }
                },
                {   "NetworkThrottleSummaryListResponse", new List<string> {
                        "networkThrottle",
                    }
                },
                {   "NfAnomalyResultConnection", new List<string> {
                        "nfAnomalyResults",
                    }
                },
                {   "NfAnomalyResultGroupedDataConnection", new List<string> {
                        "nfAnomalyResultsGrouped",
                    }
                },
                {   "NodeRemovalCancelPermissionReply", new List<string> {
                        "nodeRemovalCancelPermission",
                    }
                },
                {   "NodeStatusListResponse", new List<string> {
                        "clusterNodes",
                    }
                },
                {   "NodeToReplaceReply", new List<string> {
                        "nodeToReplace",
                    }
                },
                {   "NotificationForGetLicenseReply", new List<string> {
                        "notificationForGetLicense",
                    }
                },
                {   "NtpServerConfigurationListResponse", new List<string> {
                        "clusterNtpServers",
                    }
                },
                {   "NutanixCategory", new List<string> {
                        "nutanixCategory",
                    }
                },
                {   "NutanixCategoryValue", new List<string> {
                        "nutanixCategoryValue",
                    }
                },
                {   "NutanixCluster", new List<string> {
                        "nutanixCluster",
                    }
                },
                {   "NutanixClusterConnection", new List<string> {
                        "nutanixClusters",
                    }
                },
                {   "NutanixContainerListResponse", new List<string> {
                        "nutanixClusterContainers",
                    }
                },
                {   "NutanixLiveMountConnection", new List<string> {
                        "nutanixMounts",
                    }
                },
                {   "NutanixNetworkListResponse", new List<string> {
                        "nutanixClusterNetworks",
                    }
                },
                {   "NutanixPrismCentral", new List<string> {
                        "nutanixPrismCentral",
                    }
                },
                {   "NutanixPrismCentralConnection", new List<string> {
                        "nutanixPrismCentrals",
                    }
                },
                {   "NutanixVm", new List<string> {
                        "nutanixVm",
                    }
                },
                {   "NutanixVmConnection", new List<string> {
                        "nutanixVms",
                    }
                },
                {   "NutanixVmSnapshotDetail", new List<string> {
                        "nutanixSnapshotDetail",
                    }
                },
                {   "O365AppConnection", new List<string> {
                        "listO365Apps",
                    }
                },
                {   "O365Calendar", new List<string> {
                        "o365Calendar",
                    }
                },
                {   "O365ConfiguredGroupMemberConnection", new List<string> {
                        "configuredGroupMembers",
                    }
                },
                {   "O365ExchangeObjectConnection", new List<string> {
                        "browseCalendar",
                        "browseContacts",
                        "browseFolder",
                        "snappableContactSearch",
                        "snappableEmailSearch",
                        "snappableEventSearch",
                        "snapshotEmailSearch",
                        "snapshotEventSearch",
                    }
                },
                {   "O365FullSpObjectConnection", new List<string> {
                        "sharepointSiteDescendants",
                        "sharepointSiteSearch",
                    }
                },
                {   "O365GroupConnection", new List<string> {
                        "o365Groups",
                    }
                },
                {   "O365License", new List<string> {
                        "o365License",
                    }
                },
                {   "O365Mailbox", new List<string> {
                        "o365Mailbox",
                    }
                },
                {   "O365MailboxConnection", new List<string> {
                        "o365Mailboxes",
                    }
                },
                {   "O365OauthConsentCompleteReply", new List<string> {
                        "o365OauthConsentComplete",
                    }
                },
                {   "O365OauthConsentKickoffReply", new List<string> {
                        "o365OauthConsentKickoff",
                    }
                },
                {   "O365Onedrive", new List<string> {
                        "o365Onedrive",
                    }
                },
                {   "O365OnedriveConnection", new List<string> {
                        "o365Onedrives",
                    }
                },
                {   "O365OnedriveObjectConnection", new List<string> {
                        "browseOnedrive",
                        "browseSharepointDrive",
                        "browseSharepointList",
                        "browseTeamsDrive",
                        "snappableOnedriveSearch",
                        "snappableSharepointDriveSearch",
                        "snappableSharepointListSearch",
                        "snappableTeamsDriveSearch",
                        "snapshotOnedriveSearch",
                        "snapshotSharepointDriveSearch",
                    }
                },
                {   "O365Org", new List<string> {
                        "o365Org",
                        "o365OrgAtSnappableLevel",
                    }
                },
                {   "O365OrgConnection", new List<string> {
                        "o365Orgs",
                    }
                },
                {   "O365PdlGroupsReply", new List<string> {
                        "o365PdlGroups",
                    }
                },
                {   "O365SaasSetupKickoffReply", new List<string> {
                        "o365SaaSSetupKickoff",
                    }
                },
                {   "O365ServiceAccountStatusResp", new List<string> {
                        "o365ServiceAccount",
                    }
                },
                {   "O365SetupKickoffResp", new List<string> {
                        "o365SetupKickoff",
                    }
                },
                {   "O365SharepointDrive", new List<string> {
                        "o365SharepointDrive",
                    }
                },
                {   "O365SharepointDriveConnection", new List<string> {
                        "o365SharepointDrives",
                    }
                },
                {   "O365SharepointList", new List<string> {
                        "o365SharepointList",
                    }
                },
                {   "O365SharepointListConnection", new List<string> {
                        "o365SharepointLists",
                    }
                },
                {   "O365SharepointObjectConnection", new List<string> {
                        "o365SharepointObjectList",
                        "o365SharepointObjects",
                    }
                },
                {   "O365Site", new List<string> {
                        "o365SharepointSite",
                        "o365Site",
                    }
                },
                {   "O365SiteConnection", new List<string> {
                        "o365SharepointSites",
                        "o365Sites",
                    }
                },
                {   "O365TeamConvChannelConnection", new List<string> {
                        "browseO365TeamConvChannels",
                    }
                },
                {   "O365TeamConversationsSenderConnection", new List<string> {
                        "o365TeamPostedBy",
                    }
                },
                {   "O365Teams", new List<string> {
                        "o365Team",
                    }
                },
                {   "O365TeamsChannelConnection", new List<string> {
                        "browseTeamsChannels",
                        "o365TeamChannels",
                    }
                },
                {   "O365TeamsConnection", new List<string> {
                        "o365Teams",
                    }
                },
                {   "O365TeamsConversationsConnection", new List<string> {
                        "snappableTeamsConversationsSearch",
                    }
                },
                {   "O365User", new List<string> {
                        "o365User",
                    }
                },
                {   "O365UserDescendantMetadataConnection", new List<string> {
                        "o365UserObjects",
                    }
                },
                {   "OauthCodesForEdgeRegReply", new List<string> {
                        "oauthCodesForEdgeReg",
                    }
                },
                {   "OracleAcoParameterList", new List<string> {
                        "oracleAcoParameters",
                    }
                },
                {   "OracleDataGuardGroup", new List<string> {
                        "oracleDataGuardGroup",
                    }
                },
                {   "OracleDatabase", new List<string> {
                        "oracleDatabase",
                    }
                },
                {   "OracleDatabaseConnection", new List<string> {
                        "oracleDatabases",
                    }
                },
                {   "OracleDbDetail", new List<string> {
                        "updateOracleDataGuardGroup",
                    }
                },
                {   "OracleFileDownloadLink", new List<string> {
                        "oracleAcoExampleDownloadLink",
                    }
                },
                {   "OracleHost", new List<string> {
                        "oracleHost",
                    }
                },
                {   "OracleLiveMountConnection", new List<string> {
                        "oracleLiveMounts",
                    }
                },
                {   "OracleLogBackupConfig", new List<string> {
                        "oracleDatabaseLogBackupConfig",
                        "oracleHostLogBackupConfig",
                        "oracleRacLogBackupConfig",
                    }
                },
                {   "OracleMissedRecoverableRangeListResponse", new List<string> {
                        "oracleMissedRecoverableRanges",
                    }
                },
                {   "OraclePdbDetails", new List<string> {
                        "oraclePdbDetails",
                    }
                },
                {   "OracleRac", new List<string> {
                        "oracleRac",
                    }
                },
                {   "OracleRecoverableRangeListResponse", new List<string> {
                        "oracleRecoverableRanges",
                    }
                },
                {   "OracleTopLevelDescendantTypeConnection", new List<string> {
                        "oracleTopLevelDescendants",
                    }
                },
                {   "Org", new List<string> {
                        "currentOrg",
                        "org",
                    }
                },
                {   "OrgConnection", new List<string> {
                        "orgs",
                    }
                },
                {   "OrgSecurityPolicy", new List<string> {
                        "orgSecurityPolicy",
                    }
                },
                {   "OrgsForPrincipalReply", new List<string> {
                        "orgsForPrincipal",
                    }
                },
                {   "OverallRansomwareInvestigationSummary", new List<string> {
                        "overallRansomwareInvestigationSummary",
                    }
                },
                {   "PasswordComplexityPolicy", new List<string> {
                        "passwordComplexityPolicy",
                    }
                },
                {   "PatchDb2DatabaseReply", new List<string> {
                        "patchDb2Database",
                    }
                },
                {   "PatchDb2InstanceReply", new List<string> {
                        "patchDb2Instance",
                    }
                },
                {   "PatchNutanixMountV1Reply", new List<string> {
                        "patchNutanixMountV1",
                    }
                },
                {   "PatchSapHanaSystemReply", new List<string> {
                        "patchSapHanaSystem",
                    }
                },
                {   "PauseSlaReply", new List<string> {
                        "pauseSla",
                    }
                },
                {   "PauseTargetReply", new List<string> {
                        "pauseTarget",
                    }
                },
                {   "PendingEvaluationResultsReply", new List<string> {
                        "pendingRansomwareInvestigationResultsCount",
                    }
                },
                {   "PhoenixRolloutProgress", new List<string> {
                        "phoenixRolloutProgress",
                    }
                },
                {   "PhysicalHost", new List<string> {
                        "physicalHost",
                    }
                },
                {   "PhysicalHostConnection", new List<string> {
                        "physicalHosts",
                    }
                },
                {   "PolarisInventorySubHierarchyRoot", new List<string> {
                        "polarisInventorySubHierarchyRoot",
                    }
                },
                {   "PolarisSnapshot", new List<string> {
                        "polarisSnapshot",
                    }
                },
                {   "PolicyDetailConnection", new List<string> {
                        "policyDetails",
                    }
                },
                {   "PolicyObj", new List<string> {
                        "policyObj",
                    }
                },
                {   "PolicyObjConnection", new List<string> {
                        "policyObjs",
                    }
                },
                {   "PolicyObjectUsageConnection", new List<string> {
                        "policyObjectUsages",
                    }
                },
                {   "PrechecksJobReply", new List<string> {
                        "startPeriodicUpgradePrechecksOnDemandJob",
                    }
                },
                {   "PrechecksStatusReply", new List<string> {
                        "prechecksStatus",
                        "prechecksStatusWithNextJobInfo",
                    }
                },
                {   "PrepareAwsCloudAccountDeletionReply", new List<string> {
                        "prepareAwsCloudAccountDeletion",
                    }
                },
                {   "PrepareFeatureUpdateForAwsCloudAccountReply", new List<string> {
                        "prepareFeatureUpdateForAwsCloudAccount",
                    }
                },
                {   "PrincipalConnection", new List<string> {
                        "ldapPrincipalConnection",
                    }
                },
                {   "ProcessedRansomwareInvestigationWorkloadCountReply", new List<string> {
                        "processedRansomwareInvestigationWorkloadCount",
                    }
                },
                {   "ProductDocumentation", new List<string> {
                        "productDocumentation",
                    }
                },
                {   "ProtectedObjectsConnection", new List<string> {
                        "protectedObjectsConnection",
                    }
                },
                {   "ProtectedRansomwareInvestigationWorkloadCountReply", new List<string> {
                        "protectedRansomwareInvestigationWorkloadCount",
                    }
                },
                {   "PutSmbConfigurationReply", new List<string> {
                        "putSmbConfiguration",
                    }
                },
                {   "QueryDatastoreFreespaceThresholdsReply", new List<string> {
                        "queryDatastoreFreespaceThresholds",
                    }
                },
                {   "QuerySDDLReply", new List<string> {
                        "datagovSecDesc",
                    }
                },
                {   "RansomwareInvestigationAnalysisSummaryReply", new List<string> {
                        "ransomwareInvestigationAnalysisSummary",
                    }
                },
                {   "RansomwareInvestigationEnablementReply", new List<string> {
                        "ransomwareInvestigationEnablement",
                    }
                },
                {   "RansomwareInvestigationWorkloadScannedCountReply", new List<string> {
                        "ransomwareInvestigationWorkloadScannedCount",
                    }
                },
                {   "RansomwareResult", new List<string> {
                        "ransomwareResult",
                        "ransomwareResultOpt",
                    }
                },
                {   "RansomwareResultConnection", new List<string> {
                        "ransomwareResults",
                    }
                },
                {   "RansomwareResultGroupedDataConnection", new List<string> {
                        "ransomwareResultsGrouped",
                    }
                },
                {   "RbaInstallerUrls", new List<string> {
                        "cloudNativeRbaInstallers",
                    }
                },
                {   "RcsAzureArchivalLocationsConsumptionStatsOutput", new List<string> {
                        "rcsArchivalLocationsConsumptionStats",
                    }
                },
                {   "RcvAccountEntitlement", new List<string> {
                        "rcvAccountEntitlement",
                    }
                },
                {   "RdsInstanceDetailsFromAws", new List<string> {
                        "rdsInstanceDetailsFromAws",
                    }
                },
                {   "RdsInstanceExportDefaults", new List<string> {
                        "awsNativeRdsExportDefaults",
                    }
                },
                {   "ReadIntegrationReply", new List<string> {
                        "integration",
                    }
                },
                {   "RecoverableRangeResponse", new List<string> {
                        "vsphereVMMissedRecoverableRange",
                        "vsphereVMRecoverableRange",
                    }
                },
                {   "RefreshHostReply", new List<string> {
                        "refreshHost",
                    }
                },
                {   "RefreshNasSystemsReply", new List<string> {
                        "refreshNasSystems",
                    }
                },
                {   "RefreshStorageArraysReply", new List<string> {
                        "refreshStorageArrays",
                    }
                },
                {   "RegionConnection", new List<string> {
                        "azureRegions",
                    }
                },
                {   "RegisterAwsFeatureArtifactsReply", new List<string> {
                        "registerAwsFeatureArtifacts",
                    }
                },
                {   "RegisterCloudClusterReply", new List<string> {
                        "registerCloudCluster",
                    }
                },
                {   "RegisterNasSystemReply", new List<string> {
                        "registerNasSystem",
                    }
                },
                {   "RemoveNodeForReplacementReply", new List<string> {
                        "removeNodeForReplacement",
                    }
                },
                {   "RemoveVlansReply", new List<string> {
                        "removeVlans",
                    }
                },
                {   "ReplaceClusterNodeReply", new List<string> {
                        "replaceClusterNode",
                    }
                },
                {   "ReplicationPairConnection", new List<string> {
                        "replicationPairs",
                    }
                },
                {   "ReportMigrationStatusConnection", new List<string> {
                        "clusterReportMigrationStatus",
                    }
                },
                {   "ReportsMigrationCount", new List<string> {
                        "clusterReportMigrationCount",
                    }
                },
                {   "RequestStatus", new List<string> {
                        "addAdGroupsToHierarchy",
                        "azureOauthConsentComplete",
                        "cancelTaskchain",
                        "createO365AppComplete",
                        "deleteAdGroupsFromHierarchy",
                        "deleteO365AzureApp",
                        "deleteO365ServiceAccount",
                        "enableO365SharePoint",
                        "enableO365Teams",
                        "insertCustomerO365App",
                        "setO365ServiceAccount",
                    }
                },
                {   "RequestSuccess", new List<string> {
                        "deleteHypervVirtualMachineSnapshot",
                        "deleteNutanixSnapshot",
                        "deleteNutanixSnapshots",
                        "deleteVsphereAdvancedTag",
                        "excludeVmDisks",
                        "hypervDeleteAllSnapshots",
                        "installIoFilter",
                        "registerAgentHypervVirtualMachine",
                        "registerAgentNutanixVm",
                        "resolveVolumeGroupsConflict",
                        "uninstallIoFilter",
                        "updateVcenterHotAddBandwidth",
                        "updateVcenterHotAddNetwork",
                        "updateVsphereVm",
                        "upgradeIoFilter",
                        "vsphereExcludeVmDisks",
                        "vsphereVmRegisterAgent",
                    }
                },
                {   "ResourceGroupConnection", new List<string> {
                        "azureResourceGroups",
                    }
                },
                {   "ResponseSuccess", new List<string> {
                        "addVlan",
                        "assignMssqlSlaDomainProperties",
                        "bulkDeleteFailoverCluster",
                        "bulkDeleteFailoverClusterApp",
                        "bulkDeleteFileset",
                        "bulkDeleteFilesetTemplate",
                        "bulkDeleteHost",
                        "deleteFailoverCluster",
                        "deleteFailoverClusterApp",
                        "deleteFilesetSnapshots",
                        "deleteMssqlDbSnapshots",
                        "deleteSapHanaDbSnapshot",
                        "disableReplicationPause",
                        "enableReplicationPause",
                        "hideRevealNasShares",
                        "hypervScvmmDelete",
                        "removeDisk",
                        "removeProxyConfig",
                        "resizeDisk",
                        "updateClusterNtpServers",
                        "updateDnsServersAndSearchDomains",
                    }
                },
                {   "ResumeTargetReply", new List<string> {
                        "resumeTarget",
                    }
                },
                {   "RetryBackupResp", new List<string> {
                        "retryBackup",
                    }
                },
                {   "RoleConnection", new List<string> {
                        "getAllRolesInOrgConnection",
                    }
                },
                {   "RoleTemplateConnection", new List<string> {
                        "roleTemplates",
                    }
                },
                {   "RotateServiceAccountSecretReply", new List<string> {
                        "rotateServiceAccountSecret",
                    }
                },
                {   "RowConnection", new List<string> {
                        "reportData",
                    }
                },
                {   "RunCustomAnalyzerReply", new List<string> {
                        "runCustomAnalyzer",
                    }
                },
                {   "SapHanaDatabase", new List<string> {
                        "sapHanaDatabase",
                    }
                },
                {   "SapHanaDatabaseConnection", new List<string> {
                        "sapHanaDatabases",
                    }
                },
                {   "SapHanaLogSnapshot", new List<string> {
                        "sapHanaLogSnapshot",
                    }
                },
                {   "SapHanaLogSnapshotConnection", new List<string> {
                        "sapHanaLogSnapshots",
                    }
                },
                {   "SapHanaRecoverableRange", new List<string> {
                        "sapHanaRecoverableRange",
                    }
                },
                {   "SapHanaRecoverableRangeConnection", new List<string> {
                        "sapHanaRecoverableRanges",
                    }
                },
                {   "SapHanaSystem", new List<string> {
                        "sapHanaSystem",
                    }
                },
                {   "SapHanaSystemConnection", new List<string> {
                        "sapHanaSystems",
                    }
                },
                {   "ScheduledReport", new List<string> {
                        "scheduledReport",
                    }
                },
                {   "ScheduledReportConnection", new List<string> {
                        "scheduledReports",
                    }
                },
                {   "SearchResponseListResponse", new List<string> {
                        "searchHost",
                        "searchNutanixVm",
                    }
                },
                {   "SeedEnabledPoliciesReply", new List<string> {
                        "seedEnabledPolicies",
                    }
                },
                {   "SeedInitialPoliciesReply", new List<string> {
                        "seedInitialPolicies",
                    }
                },
                {   "SendPdfReportReply", new List<string> {
                        "sendPdfReport",
                    }
                },
                {   "ServiceAccountConnection", new List<string> {
                        "serviceAccounts",
                    }
                },
                {   "SetAnalyzerRisksReply", new List<string> {
                        "setAnalyzerRisks",
                    }
                },
                {   "SetDatastoreFreespaceThresholdsReply", new List<string> {
                        "setDatastoreFreespaceThresholds",
                    }
                },
                {   "SetUpgradeTypeReply", new List<string> {
                        "setUpgradeType",
                    }
                },
                {   "SetWorkloadAlertSettingReply", new List<string> {
                        "setWorkloadAlertSetting",
                    }
                },
                {   "SetupAzureO365ExocomputeResp", new List<string> {
                        "setupAzureO365Exocompute",
                    }
                },
                {   "ShareFileset", new List<string> {
                        "shareFileset",
                    }
                },
                {   "SlaAssignResult", new List<string> {
                        "assignProtection",
                        "assignRetentionSLAToSnappables",
                        "assignRetentionSLAToSnapshots",
                        "assignSla",
                    }
                },
                {   "SlaDomain", new List<string> {
                        "slaDomain",
                    }
                },
                {   "SlaDomainConnection", new List<string> {
                        "slaDomains",
                    }
                },
                {   "SmbDomainConnection", new List<string> {
                        "smbDomains",
                    }
                },
                {   "SnappableConnection", new List<string> {
                        "searchSnappableConnection",
                        "snappableConnection",
                    }
                },
                {   "SnappableGroupByConnection", new List<string> {
                        "snappableGroupByConnection",
                    }
                },
                {   "SnapshotFileConnection", new List<string> {
                        "browseSnapshotFileConnection",
                        "cloudNativeSnapshots",
                    }
                },
                {   "SnapshotFileDeltaConnection", new List<string> {
                        "snapshotFilesDelta",
                    }
                },
                {   "SnapshotFileDeltaV2Connection", new List<string> {
                        "snapshotFilesDeltaV2",
                    }
                },
                {   "SnapshotResultConnection", new List<string> {
                        "snapshotResults",
                    }
                },
                {   "SnapshotSummaryConnection", new List<string> {
                        "snapshotsForUnmanagedObject",
                    }
                },
                {   "SnmpConfiguration", new List<string> {
                        "snmpConfigurations",
                    }
                },
                {   "SonarContentReportConnection", new List<string> {
                        "sonarContentReport",
                    }
                },
                {   "SonarReportConnection", new List<string> {
                        "sonarReport",
                    }
                },
                {   "SonarReportRowConnection", new List<string> {
                        "sonarReportRow",
                    }
                },
                {   "StartAzureCloudAccountOauthReply", new List<string> {
                        "startAzureCloudAccountOauth",
                    }
                },
                {   "StartClusterReportMigrationJobReply", new List<string> {
                        "startClusterReportMigrationJob",
                    }
                },
                {   "StartCrawlReply", new List<string> {
                        "startCrawl",
                    }
                },
                {   "StartThreatHuntReply", new List<string> {
                        "startThreatHunt",
                    }
                },
                {   "StopJobInstanceReply", new List<string> {
                        "stopJobInstance",
                    }
                },
                {   "StorageAccountConnection", new List<string> {
                        "azureStorageAccounts",
                    }
                },
                {   "String", new List<string> {
                        "accountId",
                        "addPolicyObjects",
                        "archiveCrawl",
                        "createUser",
                        "createUserWithPassword",
                        "currentIpAddress",
                        "deactivateCustomAnalyzer",
                        "deploymentVersion",
                        "externalDeploymentName",
                        "gcpGetDefaultCredentialsServiceAccount",
                        "o365TeamConversationsFolderID",
                        "updateLdapIntegration",
                        "updateWhitelistedAnalyzers",
                    }
                },
                {   "SubnetConnection", new List<string> {
                        "azureSubnets",
                    }
                },
                {   "SupportPortalLoginReply", new List<string> {
                        "supportPortalLogin",
                    }
                },
                {   "SupportPortalLogoutReply", new List<string> {
                        "logoutFromRubrikSupportPortal",
                    }
                },
                {   "SupportPortalStatusReply", new List<string> {
                        "isLoggedIntoRubrikSupportPortal",
                    }
                },
                {   "SupportTunnelInfo", new List<string> {
                        "tunnelStatus",
                    }
                },
                {   "SupportUserAccessConnection", new List<string> {
                        "supportUserAccesses",
                    }
                },
                {   "SyslogExportRuleSummaryListResponse", new List<string> {
                        "syslogExportRules",
                    }
                },
                {   "TableFilters", new List<string> {
                        "tableFilters",
                    }
                },
                {   "TakeOnDemandSnapshotReply", new List<string> {
                        "takeOnDemandSnapshot",
                    }
                },
                {   "Target", new List<string> {
                        "createAwsReaderTarget",
                        "createAwsTarget",
                        "createAzureReaderTarget",
                        "createAzureTarget",
                        "createGcpReaderTarget",
                        "createGcpTarget",
                        "createGlacierReaderTarget",
                        "createNfsReaderTarget",
                        "createNfsTarget",
                        "createRcsReaderTarget",
                        "createRcsTarget",
                        "createS3CompatibleReaderTarget",
                        "createS3CompatibleTarget",
                        "createTapeReaderTarget",
                        "createTapeTarget",
                        "target",
                        "updateAwsTarget",
                        "updateAzureTarget",
                        "updateGcpTarget",
                        "updateGlacierTarget",
                        "updateNfsTarget",
                        "updateRcvTarget",
                        "updateS3CompatibleTarget",
                        "updateTapeTarget",
                    }
                },
                {   "TargetConnection", new List<string> {
                        "targets",
                    }
                },
                {   "TargetMapping", new List<string> {
                        "createAutomaticAwsTargetMapping",
                        "createAutomaticAzureTargetMapping",
                        "createAutomaticRcsTargetMapping",
                        "createManualTargetMapping",
                        "targetMapping",
                        "updateAutomaticAwsTargetMapping",
                        "updateAutomaticAzureTargetMapping",
                        "updateManualTargetMapping",
                        "updateRcsAutomaticTargetMapping",
                    }
                },
                {   "TaskDetailConnection", new List<string> {
                        "taskDetailConnection",
                    }
                },
                {   "TaskDetailGroupByConnection", new List<string> {
                        "taskDetailGroupByConnection",
                    }
                },
                {   "TenantAuthDomainConfig", new List<string> {
                        "currentOrgAuthDomainConfig",
                    }
                },
                {   "TestExistingWebhookReply", new List<string> {
                        "testExistingWebhook",
                    }
                },
                {   "TestSyslogExportRuleReply", new List<string> {
                        "testSyslogExportRule",
                    }
                },
                {   "TestWebhookReply", new List<string> {
                        "testWebhook",
                    }
                },
                {   "ThreatHunt", new List<string> {
                        "threatHuntDetail",
                    }
                },
                {   "ThreatHuntConnection", new List<string> {
                        "threatHunts",
                    }
                },
                {   "ThreatHuntResult", new List<string> {
                        "threatHuntResult",
                    }
                },
                {   "ThreatHuntSummaryReply", new List<string> {
                        "threatHuntSummary",
                    }
                },
                {   "TriggerExocomputeHealthCheckReply", new List<string> {
                        "triggerExocomputeHealthCheck",
                    }
                },
                {   "TriggerRansomwareDetectionReply", new List<string> {
                        "triggerRansomwareDetection",
                    }
                },
                {   "UUID", new List<string> {
                        "createRole",
                        "mutateRole",
                    }
                },
                {   "UnmanagedObjectDetailConnection", new List<string> {
                        "unmanagedObjects",
                    }
                },
                {   "UnmapAzureCloudAccountExocomputeSubscriptionReply", new List<string> {
                        "unmapAzureCloudAccountExocomputeSubscription",
                    }
                },
                {   "UnmapCloudAccountExocomputeAccountReply", new List<string> {
                        "unmapCloudAccountExocomputeAccount",
                    }
                },
                {   "UpdateAutoEnablePolicyClusterConfigReply", new List<string> {
                        "updateAutoEnablePolicyClusterConfig",
                    }
                },
                {   "UpdateAwsCloudAccountFeatureReply", new List<string> {
                        "updateAwsCloudAccountFeature",
                    }
                },
                {   "UpdateAwsExocomputeConfigsReply", new List<string> {
                        "updateAwsExocomputeConfigs",
                    }
                },
                {   "UpdateAzureCloudAccountReply", new List<string> {
                        "updateAzureCloudAccount",
                    }
                },
                {   "UpdateBadDiskLedStatusReply", new List<string> {
                        "updateBadDiskLedStatus",
                    }
                },
                {   "UpdateCertificateHostReply", new List<string> {
                        "updateCertificateHost",
                    }
                },
                {   "UpdateCloudNativeAwsStorageSettingReply", new List<string> {
                        "updateCloudNativeAwsStorageSetting",
                    }
                },
                {   "UpdateCloudNativeAzureStorageSettingReply", new List<string> {
                        "updateCloudNativeAzureStorageSetting",
                    }
                },
                {   "UpdateCloudNativeIndexingStatusReply", new List<string> {
                        "updateCloudNativeIndexingStatus",
                    }
                },
                {   "UpdateCloudNativeRcvAzureStorageSettingReply", new List<string> {
                        "updateCloudNativeRcvAzureStorageSetting",
                    }
                },
                {   "UpdateClusterDefaultAddressReply", new List<string> {
                        "updateClusterDefaultAddress",
                    }
                },
                {   "UpdateClusterSettingsReply", new List<string> {
                        "updateClusterSettings",
                    }
                },
                {   "UpdateCustomReportReply", new List<string> {
                        "updateCustomReport",
                    }
                },
                {   "UpdateEventDigestReply", new List<string> {
                        "updateEventDigest",
                    }
                },
                {   "UpdateFailoverClusterAppReply", new List<string> {
                        "updateFailoverClusterApp",
                    }
                },
                {   "UpdateFailoverClusterReply", new List<string> {
                        "updateFailoverCluster",
                    }
                },
                {   "UpdateFloatingIpsReply", new List<string> {
                        "updateFloatingIps",
                    }
                },
                {   "UpdateGuestCredentialReply", new List<string> {
                        "updateGuestCredential",
                    }
                },
                {   "UpdateHealthMonitorPolicyStatusReply", new List<string> {
                        "updateHealthMonitorPolicyStatus",
                    }
                },
                {   "UpdateHypervVirtualMachineReply", new List<string> {
                        "updateHypervVirtualMachine",
                    }
                },
                {   "UpdateHypervVirtualMachineSnapshotMountReply", new List<string> {
                        "updateHypervVirtualMachineSnapshotMount",
                    }
                },
                {   "UpdateInsightStateReply", new List<string> {
                        "updateInsightState",
                    }
                },
                {   "UpdateLockoutConfigReply", new List<string> {
                        "updateLockoutConfig",
                    }
                },
                {   "UpdateManagedVolumeReply", new List<string> {
                        "updateManagedVolume",
                    }
                },
                {   "UpdateMssqlDefaultPropertiesReply", new List<string> {
                        "mssqlDefaultProperties",
                        "updateMssqlDefaultProperties",
                    }
                },
                {   "UpdateMssqlLogShippingConfigurationReply", new List<string> {
                        "updateMssqlLogShippingConfiguration",
                    }
                },
                {   "UpdateNasSystemReply", new List<string> {
                        "updateNasSystem",
                    }
                },
                {   "UpdateNetworkThrottleReply", new List<string> {
                        "updateNetworkThrottle",
                    }
                },
                {   "UpdateNutanixClusterReply", new List<string> {
                        "updateNutanixCluster",
                    }
                },
                {   "UpdateNutanixPrismCentralReply", new List<string> {
                        "updateNutanixPrismCentral",
                    }
                },
                {   "UpdateO365AppAuthStatusReply", new List<string> {
                        "updateO365AppAuthStatus",
                    }
                },
                {   "UpdateO365OrgCustomNameReply", new List<string> {
                        "updateO365OrgCustomName",
                    }
                },
                {   "UpdateOrgReply", new List<string> {
                        "updateOrg",
                    }
                },
                {   "UpdateProxyConfigReply", new List<string> {
                        "updateProxyConfig",
                    }
                },
                {   "UpdateScheduledReportReply", new List<string> {
                        "updateScheduledReport",
                    }
                },
                {   "UpdateServiceAccountReply", new List<string> {
                        "updateServiceAccount",
                    }
                },
                {   "UpdateSnmpConfigReply", new List<string> {
                        "updateSnmpConfig",
                    }
                },
                {   "UpdateStorageArraysReply", new List<string> {
                        "updateStorageArrays",
                    }
                },
                {   "UpdateSyslogExportRuleReply", new List<string> {
                        "updateSyslogExportRule",
                    }
                },
                {   "UpdateTunnelStatusReply", new List<string> {
                        "updateTunnelStatus",
                    }
                },
                {   "UpdateVcenterReply", new List<string> {
                        "updateVcenter",
                    }
                },
                {   "UpdateVolumeGroupReply", new List<string> {
                        "updateVolumeGroup",
                    }
                },
                {   "UpdateVsphereAdvancedTagReply", new List<string> {
                        "updateVsphereAdvancedTag",
                    }
                },
                {   "UpdateWebhookReply", new List<string> {
                        "updateWebhook",
                    }
                },
                {   "UpgradeAzureCloudAccountPermissionsWithoutOauthReply", new List<string> {
                        "upgradeAzureCloudAccountPermissionsWithoutOauth",
                    }
                },
                {   "UpgradeAzureCloudAccountReply", new List<string> {
                        "upgradeAzureCloudAccount",
                    }
                },
                {   "UpgradeGcpCloudAccountPermissionsWithoutOauthReply", new List<string> {
                        "upgradeGcpCloudAccountPermissionsWithoutOauth",
                    }
                },
                {   "UpgradeStatusReply", new List<string> {
                        "upgradeStatus",
                    }
                },
                {   "User", new List<string> {
                        "currentUser",
                    }
                },
                {   "UserActivityResultConnection", new List<string> {
                        "allFileActivities",
                    }
                },
                {   "UserAuditConnection", new List<string> {
                        "userAuditConnection",
                    }
                },
                {   "UserConnection", new List<string> {
                        "allUsersOnAccountConnection",
                        "usersInCurrentAndDescendantOrganization",
                    }
                },
                {   "UserDownloadUrl", new List<string> {
                        "getDownloadUrl",
                    }
                },
                {   "UserLoginContext", new List<string> {
                        "currentUserLoginContext",
                    }
                },
                {   "UserNotifications", new List<string> {
                        "userNotifications",
                    }
                },
                {   "UserSettings", new List<string> {
                        "userSettings",
                    }
                },
                {   "V1BulkUpdateExchangeDagResponse", new List<string> {
                        "bulkUpdateExchangeDag",
                    }
                },
                {   "V1MssqlGetRestoreFilesV1Response", new List<string> {
                        "allMssqlDatabaseRestoreFiles",
                    }
                },
                {   "ValidReplicationTargetConnection", new List<string> {
                        "allValidReplicationTargets",
                    }
                },
                {   "ValidateAndCreateAwsCloudAccountReply", new List<string> {
                        "validateAndCreateAwsCloudAccount",
                    }
                },
                {   "ValidateAndSaveCustomerKmsInfoReply", new List<string> {
                        "validateAndSaveCustomerKmsInfo",
                    }
                },
                {   "ValidateAwsNativeRdsClusterNameForExportReply", new List<string> {
                        "validateAwsNativeRdsClusterNameForExport",
                    }
                },
                {   "ValidateAwsNativeRdsInstanceNameForExportReply", new List<string> {
                        "validateAwsNativeRdsInstanceNameForExport",
                    }
                },
                {   "ValidateAzureNativeSqlDatabaseDbNameForExportReply", new List<string> {
                        "validateAzureNativeSqlDatabaseDbNameForExport",
                    }
                },
                {   "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply", new List<string> {
                        "validateAzureNativeSqlManagedInstanceDbNameForExport",
                    }
                },
                {   "ValidateAzureSubnetsForCloudAccountExocomputeReply", new List<string> {
                        "validateAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "ValidateCloudNativeFileRecoveryFeasibilityReply", new List<string> {
                        "isCloudNativeFileRecoveryFeasible",
                    }
                },
                {   "ValidateOracleAcoFileReply", new List<string> {
                        "validateOracleAcoFile",
                    }
                },
                {   "ValidateOrgNameReply", new List<string> {
                        "validateOrgName",
                    }
                },
                {   "VappInstantRecoveryOptions", new List<string> {
                        "vappSnapshotInstantRecoveryOptions",
                    }
                },
                {   "VappTemplateExportOptionsUnion", new List<string> {
                        "vappTemplateSnapshotExportOptions",
                    }
                },
                {   "VcenterAdvancedTagPreviewReply", new List<string> {
                        "vCenterAdvancedTagPreview",
                    }
                },
                {   "VcenterPreAddInfo", new List<string> {
                        "vCenterPreAddInfo",
                    }
                },
                {   "VerifySlaWithReplicationToClusterResponse", new List<string> {
                        "verifySlaWithReplicationToCluster",
                    }
                },
                {   "VersionedFileConnection", new List<string> {
                        "searchSnappableVersionedFiles",
                    }
                },
                {   "VirtualMachineFilesReply", new List<string> {
                        "allVirtualMachineFiles",
                    }
                },
                {   "VlanConfigListResponse", new List<string> {
                        "clusterVlans",
                    }
                },
                {   "VmwareHostDetail", new List<string> {
                        "vSphereHostDetails",
                    }
                },
                {   "VnetConnection", new List<string> {
                        "azureVNets",
                    }
                },
                {   "Void", new List<string> {
                        "cancelThreatHunt",
                        "createReplicationPair",
                        "deleteAllOracleDatabaseSnapshots",
                        "deleteAwsComputeSetting",
                        "deleteCloudNativeLabelRule",
                        "deleteCloudNativeTagRule",
                        "deleteCsr",
                        "deleteCustomReport",
                        "deleteEventDigest",
                        "deleteIntegration",
                        "deleteIntegrations",
                        "deleteReplicationPair",
                        "deleteScheduledReport",
                        "deleteSmbDomain",
                        "deleteSyslogExportRule",
                        "deleteTarget",
                        "deleteTargetMapping",
                        "deleteWebhook",
                        "disableSupportUserAccess",
                        "enableSupportUserAccess",
                        "enableThreatMonitoring",
                        "excludeAwsNativeEbsVolumesFromSnapshot",
                        "excludeAzureNativeManagedDisksFromSnapshot",
                        "excludeSharepointObjectsFromProtection",
                        "gcpNativeExcludeDisksFromInstanceSnapshot",
                        "hideRevealNasNamespaces",
                        "joinSmbDomain",
                        "lockUsersByAdmin",
                        "promoteReaderTarget",
                        "refreshReaderTarget",
                        "removePrivateEndpointConnection",
                        "resetAllOrgUsersPasswords",
                        "resetUsersPasswordsWithUserIds",
                        "revokeAllOrgRoles",
                        "setCustomerTags",
                        "setPasswordComplexityPolicy",
                        "setSsoCertificate",
                        "stopJobInstanceFromEventSeries",
                        "unlockUsersByAdmin",
                        "unmapAzurePersistentStorageSubscription",
                        "unmountDisk",
                        "updateAuthDomainUsersHiddenStatus",
                        "updateAwsCloudAccount",
                        "updateCloudNativeLabelRule",
                        "updateCloudNativeTagRule",
                        "updateConfiguredGroup",
                        "updateCustomerAppPermissionForAzureSql",
                        "updateIntegration",
                        "updateIntegrations",
                        "updateNasShares",
                        "updateNutanixVm",
                        "updateO365AppPermissions",
                        "updateOrgSecurityPolicy",
                        "updateReplicationTarget",
                        "updateSupportUserAccess",
                        "upgradeCdmManagedTarget",
                        "upgradeToRsc",
                        "vsphereVmDeleteSnapshot",
                    }
                },
                {   "VolumeGroupLiveMountConnection", new List<string> {
                        "volumeGroupMounts",
                    }
                },
                {   "VsphereAsyncRequestStatus", new List<string> {
                        "vsphereVmRecoverFiles",
                    }
                },
                {   "VsphereComputeCluster", new List<string> {
                        "vSphereComputeCluster",
                    }
                },
                {   "VsphereComputeClusterConnection", new List<string> {
                        "vSphereComputeClusters",
                    }
                },
                {   "VsphereDatacenter", new List<string> {
                        "vSphereDatacenter",
                    }
                },
                {   "VsphereDatastore", new List<string> {
                        "vSphereDatastore",
                    }
                },
                {   "VsphereDatastoreCluster", new List<string> {
                        "vSphereDatastoreCluster",
                    }
                },
                {   "VsphereDatastoreClusterConnection", new List<string> {
                        "vSphereDatastoreClusters",
                    }
                },
                {   "VsphereDatastoreConnection", new List<string> {
                        "vSphereDatastoreConnection",
                    }
                },
                {   "VsphereFolder", new List<string> {
                        "vSphereFolder",
                    }
                },
                {   "VsphereFolderConnection", new List<string> {
                        "vSphereFolders",
                    }
                },
                {   "VsphereHost", new List<string> {
                        "vSphereHost",
                    }
                },
                {   "VsphereHostConnection", new List<string> {
                        "vSphereHostConnection",
                    }
                },
                {   "VsphereLiveMountConnection", new List<string> {
                        "vSphereLiveMounts",
                    }
                },
                {   "VsphereMount", new List<string> {
                        "vSphereMount",
                    }
                },
                {   "VsphereMountConnection", new List<string> {
                        "vSphereMountConnection",
                    }
                },
                {   "VsphereNetwork", new List<string> {
                        "vSphereNetwork",
                    }
                },
                {   "VsphereResourcePool", new List<string> {
                        "vSphereResourcePool",
                    }
                },
                {   "VsphereTag", new List<string> {
                        "vSphereTag",
                    }
                },
                {   "VsphereTagCategory", new List<string> {
                        "vSphereTagCategory",
                    }
                },
                {   "VsphereVcenter", new List<string> {
                        "vSphereVCenter",
                    }
                },
                {   "VsphereVcenterConnection", new List<string> {
                        "vSphereVCenterConnection",
                    }
                },
                {   "VsphereVm", new List<string> {
                        "vSphereVmNew",
                    }
                },
                {   "VsphereVmConnection", new List<string> {
                        "vcdVappVms",
                        "vSphereVmNewConnection",
                    }
                },
                {   "VsphereVmListEsxiDatastoresReply", new List<string> {
                        "vsphereVmListEsxiDatastores",
                    }
                },
                {   "VsphereVmPowerOnOffLiveMountReply", new List<string> {
                        "vsphereVmPowerOnOffLiveMount",
                    }
                },
                {   "WebhookConnection", new List<string> {
                        "allWebhooks",
                    }
                },
                {   "WindowsCluster", new List<string> {
                        "windowsCluster",
                    }
                },
                {   "WindowsFileset", new List<string> {
                        "windowsFileset",
                    }
                },
                {   "WorkloadAnomalyConnection", new List<string> {
                        "workloadAnomalies",
                    }
                },
                {   "ZrsAvailabilityReply", new List<string> {
                        "isZrsAvailableForLocation",
                    }
                },
                {   "[AccountProduct]", new List<string> {
                        "allAccountProducts",
                    }
                },
                {   "[AdGroup]", new List<string> {
                        "allO365AdGroups",
                    }
                },
                {   "[ArchivalStorageUsage]", new List<string> {
                        "archivalStorageUsage",
                    }
                },
                {   "[AuthorizedOperations]", new List<string> {
                        "allAuthorizationsForObjects",
                    }
                },
                {   "[AwsCdmVersion]", new List<string> {
                        "allAwsCdmVersions",
                    }
                },
                {   "[AwsCloudAccountRegion]", new List<string> {
                        "allAwsRegions",
                    }
                },
                {   "[AwsCloudAccountWithFeatures]", new List<string> {
                        "allAwsCloudAccountsWithFeatures",
                    }
                },
                {   "[AwsComputeSettings]", new List<string> {
                        "allAwsComputeSettings",
                    }
                },
                {   "[AwsExocomputeConfig]", new List<string> {
                        "allAwsExocomputeConfigs",
                    }
                },
                {   "[AwsFeatureConfig]", new List<string> {
                        "allAwsCloudAccountConfigs",
                    }
                },
                {   "[AwsVpc]", new List<string> {
                        "allVpcsByRegionFromAws",
                        "allVpcsFromAws",
                    }
                },
                {   "[AzureArmTemplateByFeature]", new List<string> {
                        "allAzureArmTemplatesByFeature",
                    }
                },
                {   "[AzureCdmVersion]", new List<string> {
                        "allAzureCdmVersions",
                    }
                },
                {   "[AzureCloudAccountRegion]", new List<string> {
                        "allAzureRegions",
                    }
                },
                {   "[AzureCloudAccountTenant]", new List<string> {
                        "allAzureCloudAccountTenants",
                    }
                },
                {   "[AzureEncryptionKey]", new List<string> {
                        "allAzureEncryptionKeys",
                    }
                },
                {   "[AzureExocomputeConfigsInAccount]", new List<string> {
                        "allAzureExocomputeConfigsInAccount",
                    }
                },
                {   "[AzureKeyVault]", new List<string> {
                        "allAzureKeyVaultsByRegion",
                    }
                },
                {   "[AzureManagedIdentity]", new List<string> {
                        "allAzureManagedIdentities",
                    }
                },
                {   "[AzureNativeAvailabilitySet]", new List<string> {
                        "allAzureNativeAvailabilitySetsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeDiskEncryptionSet]", new List<string> {
                        "allAzureDiskEncryptionSetsByRegion",
                    }
                },
                {   "[AzureNativeExportCompatibleDiskTypes]", new List<string> {
                        "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                    }
                },
                {   "[AzureNativeExportCompatibleVmSizes]", new List<string> {
                        "allAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                    }
                },
                {   "[AzureNativeSecurityGroup]", new List<string> {
                        "allAzureNativeSecurityGroupsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeStorageAccount]", new List<string> {
                        "allAzureNativeStorageAccountsFromAzure",
                    }
                },
                {   "[AzureNativeSubnet]", new List<string> {
                        "allAzureCloudAccountSubnetsByRegion",
                        "allAzureNativeSubnetsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeVirtualNetwork]", new List<string> {
                        "allAzureNativeVirtualNetworks",
                    }
                },
                {   "[AzureResourceGroupInfo]", new List<string> {
                        "allAzureNativeResourceGroupsInfoIfExist",
                    }
                },
                {   "[AzureResourceGroup]", new List<string> {
                        "allResourceGroupsFromAzure",
                    }
                },
                {   "[AzureSqlDatabaseServerElasticPool]", new List<string> {
                        "allAzureSqlDatabaseServerElasticPools",
                    }
                },
                {   "[AzureSubscriptionMissingPermissions]", new List<string> {
                        "allAzureCloudAccountMissingPermissions",
                    }
                },
                {   "[AzureSubscriptionWithExocomputeMapping]", new List<string> {
                        "allAzureSubscriptionWithExocomputeMappings",
                    }
                },
                {   "[AzureSubscriptionWithFeaturesType]", new List<string> {
                        "allAzureCloudAccountSubscriptionsByFeature",
                    }
                },
                {   "[Boolean]", new List<string> {
                        "allClustersTotpAckStatus",
                    }
                },
                {   "[CdmGuestCredential]", new List<string> {
                        "allCdmGuestCredentials",
                    }
                },
                {   "[CdmHierarchySnappableNew]", new List<string> {
                        "cdmHierarchySnappablesNew",
                    }
                },
                {   "[CdmOvaDetail]", new List<string> {
                        "allCdmOvaDetails",
                    }
                },
                {   "[ClosestSnapshotSearchResult]", new List<string> {
                        "allSnapshotsClosestToPointInTime",
                    }
                },
                {   "[CloudAccountFeaturePermission]", new List<string> {
                        "allCurrentFeaturePermissionsForCloudAccounts",
                        "allLatestFeaturePermissionsForCloudAccounts",
                    }
                },
                {   "[CloudAccountWithExocomputeMapping]", new List<string> {
                        "allAccountsWithExocomputeMappings",
                    }
                },
                {   "[CloudAccount]", new List<string> {
                        "allCloudAccounts",
                    }
                },
                {   "[CloudAccountsExocomputeAccountMapping]", new List<string> {
                        "allCloudAccountExocomputeMappings",
                    }
                },
                {   "[CloudDirectSite]", new List<string> {
                        "allCloudDirectSites",
                    }
                },
                {   "[ClusterReplicationTarget]", new List<string> {
                        "allClusterReplicationTargets",
                    }
                },
                {   "[ClusterWebCertAndIpmi]", new List<string> {
                        "allClusterWebCertsAndIpmis",
                    }
                },
                {   "[CreateOnDemandJobReply]", new List<string> {
                        "backupM365Mailbox",
                        "backupM365Onedrive",
                        "backupM365SharepointDrive",
                        "backupM365Team",
                        "createK8sNamespaceSnapshots",
                    }
                },
                {   "[DataLocationSupportedCluster]", new List<string> {
                        "allConnectedClusters",
                    }
                },
                {   "[DbParameterGroup]", new List<string> {
                        "allDbParameterGroupsByRegionFromAws",
                    }
                },
                {   "[DhrcActiveRecommendation]", new List<string> {
                        "allDhrcActiveRecommendations",
                    }
                },
                {   "[DhrcCollectedMetric]", new List<string> {
                        "allDhrcLatestMetrics",
                    }
                },
                {   "[DhrcScore]", new List<string> {
                        "allDhrcScores",
                    }
                },
                {   "[DownloadPackageReplyWithUuid]", new List<string> {
                        "startDownloadPackageBatchJob",
                    }
                },
                {   "[EventDigest]", new List<string> {
                        "allEventDigests",
                    }
                },
                {   "[FullSpSiteExclusions]", new List<string> {
                        "allSharepointSiteExclusions",
                    }
                },
                {   "[GcpCloudAccountMissingPermissionsForAddition]", new List<string> {
                        "allGcpCloudAccountMissingPermissionsForAddition",
                    }
                },
                {   "[GcpCloudAccountProjectDetail]", new List<string> {
                        "allGcpCloudAccountProjectsByFeature",
                    }
                },
                {   "[GcpCloudAccountProjectForOauth]", new List<string> {
                        "allGcpCloudAccountProjectsForOauth",
                    }
                },
                {   "[GcpNativeKmsCryptoKey]", new List<string> {
                        "allGcpNativeAvailableKmsCryptoKeys",
                    }
                },
                {   "[GcpNativeNetwork]", new List<string> {
                        "allGcpNativeNetworks",
                    }
                },
                {   "[GcpNativeRegion]", new List<string> {
                        "allGcpNativeRegions",
                    }
                },
                {   "[GcpPermission]", new List<string> {
                        "allFeaturePermissionsForGcpCloudAccount",
                    }
                },
                {   "[GroupCount]", new List<string> {
                        "clusterTypeList",
                        "downloadedVersionList",
                        "geoLocationList",
                        "getGroupCountByPrechecksStatus",
                        "getGroupCountByUpgradeJobStatus",
                        "getGroupCountByVersionStatus",
                    }
                },
                {   "[Group]", new List<string> {
                        "userGroups",
                    }
                },
                {   "[HierarchyObject]", new List<string> {
                        "hierarchyObjects",
                        "slaConflictObjects",
                    }
                },
                {   "[IdentityProvider]", new List<string> {
                        "allCurrentOrgIdentityProviders",
                    }
                },
                {   "[InstalledVersionGroupCount]", new List<string> {
                        "installedVersionList",
                    }
                },
                {   "[InventoryCard]", new List<string> {
                        "allInventoryWorkloads",
                    }
                },
                {   "[KmsEncryptionKey]", new List<string> {
                        "allKmsEncryptionKeysByRegionFromAws",
                    }
                },
                {   "[ManagedObjectType]", new List<string> {
                        "allUnmanagedObjectsSupportedTypes",
                    }
                },
                {   "[MosaicStorageLocation]", new List<string> {
                        "allNosqlStorageLocations",
                    }
                },
                {   "[NcdObjectsOverTimeData]", new List<string> {
                        "allNcdObjectsOverTimeData",
                    }
                },
                {   "[NcdSlaComplianceData]", new List<string> {
                        "allNcdSlaComplianceData",
                    }
                },
                {   "[NcdTaskData]", new List<string> {
                        "allNcdTaskData",
                    }
                },
                {   "[NcdUsageOverTimeData]", new List<string> {
                        "allNcdUsageOverTimeData",
                    }
                },
                {   "[NetworkHostProject]", new List<string> {
                        "allGcpNativeProjectsWithAccessibleNetworks",
                    }
                },
                {   "[O365OrgInfo]", new List<string> {
                        "allO365OrgStatuses",
                    }
                },
                {   "[O365SubscriptionAppTypeCounts]", new List<string> {
                        "allO365SubscriptionsAppTypeCounts",
                    }
                },
                {   "[ObjectIdsForHierarchyType]", new List<string> {
                        "allObjectsAlreadyAssignedToOrgs",
                    }
                },
                {   "[Operation]", new List<string> {
                        "allAllowedOrgAdminOperations",
                        "allAuthorizationsForGlobalResource",
                        "allAuthorizationsForObject",
                    }
                },
                {   "[OptionGroup]", new List<string> {
                        "allOptionGroupsByRegionFromAws",
                    }
                },
                {   "[Org]", new List<string> {
                        "allOrgsByIds",
                    }
                },
                {   "[PermissionPolicy]", new List<string> {
                        "allAwsPermissionPolicies",
                    }
                },
                {   "[Permission]", new List<string> {
                        "getPermissions",
                    }
                },
                {   "[PolicySummary]", new List<string> {
                        "allTopRiskPolicySummaries",
                    }
                },
                {   "[PvcInformation]", new List<string> {
                        "allSnapshotPvcs",
                    }
                },
                {   "[QuarantineSpec]", new List<string> {
                        "allQuarantinedDetailsForSnapshots",
                        "allQuarantinedDetailsForWorkload",
                    }
                },
                {   "[RbacPermission]", new List<string> {
                        "allEffectiveRbacPermissions",
                    }
                },
                {   "[ReplicatedSnapshotInfo]", new List<string> {
                        "allK8sReplicaSnapshotInfos",
                    }
                },
                {   "[Role]", new List<string> {
                        "getRolesByIds",
                    }
                },
                {   "[S3BucketDetails]", new List<string> {
                        "allS3BucketsDetailsFromAws",
                    }
                },
                {   "[ShareExportIdPair]", new List<string> {
                        "allCloudDirectShares",
                    }
                },
                {   "[SlaAssignResult]", new List<string> {
                        "assignSlasForSnappableHierarchies",
                    }
                },
                {   "[SlaAuditDetail]", new List<string> {
                        "slaAuditDetail",
                    }
                },
                {   "[SlaDomain]", new List<string> {
                        "allSlaSummariesByIds",
                    }
                },
                {   "[SlaInfo]", new List<string> {
                        "allClusterGlobalSlas",
                    }
                },
                {   "[String]", new List<string> {
                        "allAvailabilityZonesByRegionFromAws",
                        "allAwsInstanceProfileNames",
                        "allAzureNativeVirtualMachineSizes",
                        "allAzureNsgs",
                        "allAzureResourceGroups",
                        "allAzureStorageAccounts",
                        "allAzureSubnets",
                        "allAzureVnets",
                        "allCloudNativeFileRecoveryEligibleSnapshots",
                        "allCloudNativeLabelKeys",
                        "allCloudNativeLabelValues",
                        "allCloudNativeTagKeys",
                        "allCloudNativeTagValues",
                        "allDeploymentIpAddresses",
                        "allEc2KeyPairsByRegionFromAws",
                        "allGcpNativeCompatibleMachineTypes",
                        "allGcpNativeStoredMachineTypes",
                        "allGcpNativeStoredMachineTypesInProject",
                        "allGcpNativeStoredNetworkNames",
                        "allGcpNativeStoredNetworkNamesInProject",
                        "allGcpNativeStoredRegions",
                        "allGcpNativeStoredRegionsInProject",
                        "allIssuesJobIds",
                        "allS3BucketsFromAws",
                        "allSupportedAwsRdsDatabaseInstanceClasses",
                        "deactivatePolicy",
                        "removePolicyObjects",
                    }
                },
                {   "[SubnetGroup]", new List<string> {
                        "allDbSubnetGroupsByRegionFromAws",
                    }
                },
                {   "[TargetMapping]", new List<string> {
                        "allTargetMappings",
                    }
                },
                {   "[Target]", new List<string> {
                        "allTargets",
                        "createRcvLocationsFromTemplate",
                    }
                },
                {   "[UpgradeJobReplyWithUuid]", new List<string> {
                        "scheduleUpgradeBatchJob",
                        "startUpgradeBatchJob",
                    }
                },
                {   "[UserDownload]", new List<string> {
                        "getUserDownloads",
                    }
                },
                {   "[User]", new List<string> {
                        "allAccountOwners",
                        "allUsersOnAccount",
                    }
                },
                {   "[VcenterHotAddProxyVmInfo]", new List<string> {
                        "allVcenterHotAddProxyVms",
                    }
                },
                {   "[VmRecoveryJobInfo]", new List<string> {
                        "allVmRecoveryJobsInfo",
                    }
                },
                {   "[VmwareCdpStateInfo]", new List<string> {
                        "allVmwareCdpStateInfos",
                    }
                },
                {   "[VsphereHost]", new List<string> {
                        "vSphereHostsByFids",
                    }
                },
                {   "[pendingAction]", new List<string> {
                        "allPendingActions",
                    }
                },
                {   "pendingAction", new List<string> {
                        "pendingAction",
                    }
                },
            };
            if (lookupDict.TryGetValue(returnTypeName, out var rootFieldNames))
            {
                return rootFieldNames;
            }
            return new List<string>();
        }
    }
}