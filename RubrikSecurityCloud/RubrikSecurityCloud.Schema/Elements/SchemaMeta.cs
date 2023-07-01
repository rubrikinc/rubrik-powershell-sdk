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
        public static string GraphqlSchemaVersion = "v20230621-28" ;

        public static HashSet<string> InterfaceImpls( string interfaceName )
        {
            var InterfaceImplsDict = new Dictionary<string, HashSet<string>> {
                {
                    "ActiveDirectoryDomainDescendantType",
                    new HashSet<string> {
                    "ActiveDirectoryDomainController",
                    "ActiveDirectoryDomainDescendantType",
                    }
                },
                {
                    "ActiveDirectoryDomainPhysicalChildType",
                    new HashSet<string> {
                    "ActiveDirectoryDomainController",
                    "ActiveDirectoryDomainPhysicalChildType",
                    }
                },
                {
                    "ArchivalEntity",
                    new HashSet<string> {
                    "ArchivalEntity",
                    "ArchivalEntityTarget",
                    "ArchivalEntityTargetMapping",
                    }
                },
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
                    "BlueprintChild",
                    new HashSet<string> {
                    "BlueprintChild",
                    "VsphereVmChild",
                    }
                },
                {
                    "BlueprintFailoverInstance",
                    new HashSet<string> {
                    "VsphereBlueprintChildFailoverInstance",
                    }
                },
                {
                    "BlueprintLocation",
                    new HashSet<string> {
                    "BlueprintCdmLocation",
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
                    "ActiveDirectoryDomain",
                    "ActiveDirectoryDomainController",
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
                    "SnapMirrorCloud",
                    "Vcd",
                    "VcdCatalog",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VolumeGroup",
                    "VsphereBlueprint",
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
                    "ActiveDirectoryDomainController",
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
                    "SnapMirrorCloud",
                    "VcdVapp",
                    "VolumeGroup",
                    "VsphereBlueprint",
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
                    "CloudDirectHierarchyWorkload",
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
                    "CloudDirectSnapshot",
                    "PolarisSnapshot",
                    }
                },
                {
                    "HierarchyObject",
                    new HashSet<string> {
                    "ActiveDirectoryDomain",
                    "ActiveDirectoryDomainController",
                    "AtlassianSite",
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureAdDirectory",
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
                    "JiraProject",
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
                    "SnapMirrorCloud",
                    "Vcd",
                    "VcdCatalog",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VolumeGroup",
                    "VsphereBlueprint",
                    "VsphereBlueprintNew",
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
                    "ActiveDirectoryDomainController",
                    "AzureAdDirectory",
                    "JiraProject",
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
                    "SnapMirrorCloud",
                    "VcdVapp",
                    "VolumeGroup",
                    "VsphereBlueprint",
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
                    "SnapMirrorCloud",
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
                    "SnapMirrorCloud",
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
                    "SnapMirrorCloud",
                    }
                },
                {
                    "NasVolumeLogicalChildType",
                    new HashSet<string> {
                    "NasShare",
                    "NasVolumeLogicalChildType",
                    "SnapMirrorCloud",
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
                    "NutanixCluster",
                    }
                },
                {
                    "NutanixPrismCentralLogicalChildType",
                    new HashSet<string> {
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
                    "VolumeGroup",
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
                    "VolumeGroup",
                    "WindowsFileset",
                    }
                },
                {
                    "PolarisHierarchyObject",
                    new HashSet<string> {
                    "AtlassianSite",
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureAdDirectory",
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
                    "JiraProject",
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
                    "AzureAdDirectory",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureStorageAccount",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "JiraProject",
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
                    "RecoverySpec",
                    new HashSet<string> {
                    "RecoverySpec",
                    "VsphereRecoverySpec",
                    }
                },
                {
                    "RequestedChangesTemplate",
                    new HashSet<string> {
                    "CategorizedTprReqChangesTemplate",
                    "RequestedChangesTemplate",
                    "StandardTprReqChangesTemplate",
                    }
                },
                {
                    "ResourceSpec",
                    new HashSet<string> {
                    "Ec2InstanceResourceSpec",
                    "VmwareResourceSpec",
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
                    "SlaArchivalWarningsDetails",
                    new HashSet<string> {
                    "NonCompliantArchivalRetentionForTierWarningDetails",
                    "NonCompliantArchivalRetentionWithCommonRangeWarningsDetails",
                    "NonCompliantArchivalRetentionWithoutCommonRangeWarningsDetails",
                    "NonCompliantArchivalTierWarningDetails",
                    "SingleFrequencyArchivalWarningsDetails",
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
                    "SpecificArchivalLocationWarningDetails",
                    new HashSet<string> {
                    "HighArchivalRetentionWarningsDetails",
                    "NonCompliantArchivalRetentionWarningsDetails",
                    "NonCompliantArchivalTierSpecificWarningsDetails",
                    "SpecificArchivalLocationWarningDetails",
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
                    "VcdCatalog",
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
                    "VcdCatalog",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgDescendantType",
                    new HashSet<string> {
                    "VcdCatalog",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgLogicalChildType",
                    new HashSet<string> {
                    "VcdCatalog",
                    "VcdOrgVdc",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcDescendantType",
                    new HashSet<string> {
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcLogicalChildType",
                    new HashSet<string> {
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdTopLevelDescendantType",
                    new HashSet<string> {
                    "Vcd",
                    "VcdCatalog",
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
                    "VsphereVm",
                    }
                },
                {
                    "VsphereComputeClusterDescendantType",
                    new HashSet<string> {
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
                    }
                },
                {
                    "VsphereDatastoreClusterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereDatastore",
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
                    "VsphereVcenterLogicalChildType",
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
                    "ActivityObjectType",
                    new HashSet<string> {
                    "ActivitySeriesGroupByInfo",
                    }
                },
                {
                    "ActivitySeverityLevel",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                {
                    "ActivityStatus",
                    new HashSet<string> {
                    "ActivitySeriesGroupByInfo",
                    }
                },
                {
                    "ActivityTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "ActivityType",
                    new HashSet<string> {
                    "ActivitySeriesGroupByInfo",
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
                    "ActivitySeriesGroupByInfo",
                    "AnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    "TaskSummaryGroupByInfo",
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
                    "ActivitySeriesGroupByInfo",
                    "ClusterGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskSummaryGroupByInfo",
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
                    "FailoverStatus",
                    new HashSet<string> {
                    "FailoverGroupByInfo",
                    }
                },
                {
                    "FailoverTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "FailoverType",
                    new HashSet<string> {
                    "FailoverGroupByInfo",
                    }
                },
                {
                    "GlobalSlaReply",
                    new HashSet<string> {
                    "TaskSummaryGroupByInfo",
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
                    "LastTestStatus",
                    new HashSet<string> {
                    "FailoverGroupByInfo",
                    }
                },
                {
                    "ObjectType",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    "TaskSummaryGroupByInfo",
                    }
                },
                {
                    "PolarisHierarchySnappableObject",
                    new HashSet<string> {
                    "TaskSummaryGroupByInfo",
                    }
                },
                {
                    "ProtectionStatus",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ReportFocus",
                    new HashSet<string> {
                    "CustomReportGroupByInfo",
                    }
                },
                {
                    "Snappable",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
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
                    "Source",
                    new HashSet<string> {
                    "FailoverGroupByInfo",
                    }
                },
                {
                    "Status",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TargetSite",
                    new HashSet<string> {
                    "FailoverGroupByInfo",
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
                    "ActivitySeriesGroupByInfo",
                    "AnomalyResultGroupByInfo",
                    "CdmSnapshotGroupByInfo",
                    "ClusterGroupByInfo",
                    "ClusterMetricGroupByInfo",
                    "FailoverGroupByInfo",
                    "ManagedVolumeQueuedSnapshotGroupByInfo",
                    "MissedSnapshotGroupByInfo",
                    "MongoSnapshotGroupByInfo",
                    "MosaicSnapshotGroupByInfo",
                    "PolarisSnapshotGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    "TaskSummaryGroupByInfo",
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

        public enum GqlOperationName
        {
            Unknown,
            AwsCloudAccountListKMSKeys,
            accountId,
            accountSettings,
            activitySeries,
            activitySeriesConnection,
            activitySeriesGroupByConnection,
            addAwsAuthenticationServerBasedCloudAccount,
            addAwsIamUserBasedCloudAccount,
            addAzureCloudAccount,
            addAzureCloudAccountExocomputeConfigurations,
            addAzureCloudAccountWithoutOauth,
            addMongoSource,
            addNodesToCloudCluster,
            addO365Org,
            allAccountOwners,
            allAccountProducts,
            allAccountsWithExocomputeMappings,
            allAvailabilityZonesByRegionFromAws,
            allAwsCdmVersions,
            allAwsCloudAccountConfigs,
            allAwsCloudAccountsFeaturesWithExoConfigs,
            allAwsCloudAccountsWithFeatures,
            allAwsComputeSettings,
            allAwsExocomputeConfigs,
            allAwsInstanceProfileNames,
            allAwsRdsAuroraInstanceClasses,
            allAwsRegions,
            allAzureArmTemplatesByFeature,
            allAzureCdmVersions,
            allAzureCloudAccountMissingPermissions,
            allAzureCloudAccountSubnetsByRegion,
            allAzureCloudAccountSubscriptionsByFeature,
            allAzureCloudAccountTenants,
            allAzureCloudAccountTenantsWithExoConfigs,
            allAzureDiskEncryptionSetsByRegion,
            allAzureEncryptionKeys,
            allAzureExocomputeConfigsInAccount,
            allAzureKeyVaultsByRegion,
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
            allCdpSlaVmNames,
            allCloudClusters,
            allClusterGlobalSlas,
            allClusterReplicationTargets,
            allClusterWebCertsAndIpmis,
            allClustersTotpAckStatus,
            allConnectedClusters,
            allDbParameterGroupsByRegionFromAws,
            allDbSubnetGroupsByRegionFromAws,
            allEc2KeyPairsByRegionFromAws,
            allGlobalFileSearchMultipleClusters,
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
            allSlaIofilterStatuses,
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
            awsCloudAccountInitiate,
            awsCloudAccountListSecurityGroups,
            awsCloudAccountListSubnets,
            awsCloudAccountListVpcs,
            awsCloudAccountUpdateFeature,
            awsCloudAccountValidate,
            awsCloudAccountWithFeatures,
            awsComputeSettings,
            awsNativeAccount,
            awsNativeEbsVolume,
            awsNativeEbsVolumesByName,
            awsNativeEc2Instance,
            awsNativeEc2InstancesByName,
            awsNativeProtectionAccountAdd,
            awsNativeRdsExportDefaults,
            awsNativeRdsInstance,
            awsNativeRdsPointInTimeRestoreWindow,
            awsNativeRoot,
            awsNativeS3Bucket,
            azureAdDirectories,
            azureAdDirectory,
            azureCloudAccountPermissionConfig,
            azureCloudAccountSubscriptionWithFeatures,
            azureCloudAccountTenant,
            azureCloudAccountTenantWithExoConfigs,
            azureNativeManagedDisk,
            azureNativeResourceGroup,
            azureNativeRoot,
            azureNativeSubscription,
            azureNativeVirtualMachine,
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
            azureSqlManagedInstanceDatabase,
            azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
            azureSqlManagedInstanceServer,
            azureStorageAccounts,
            azureSubnets,
            azureSubscriptions,
            azureVNets,
            backupAzureAdDirectory,
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
            cassandraColumnFamilyRecoverableRange,
            cassandraColumnFamilySchema,
            cassandraKeyspaces,
            cassandraSources,
            cdmMssqlLogShippingTargets,
            cluster,
            clusterCertificates,
            clusterConnection,
            clusterCsr,
            clusterDefaultGateway,
            clusterDns,
            clusterEncryptionInfo,
            clusterFloatingIps,
            clusterGroupByConnection,
            clusterIpmi,
            clusterIpv6Mode,
            clusterNetworkInterfaces,
            clusterNodes,
            clusterNtpServers,
            clusterOperationJobProgress,
            clusterProxy,
            clusterRcvLocations,
            clusterRegistrationProductInfo,
            clusterSlaDomainConnection,
            clusterSlaDomainFilterConnection,
            clusterTypeList,
            clusterVlans,
            clusterWebSignedCertificate,
            clusterWithConfigProtectionInfo,
            clusterWithUpgradesInfo,
            completeAzureAdAppSetup,
            completeAzureAdAppUpdate,
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
            createOnDemandMssqlBackup,
            createOnDemandNutanixBackup,
            createOraclePdbRestore,
            createVsphereAdvancedTag,
            deleteAllOracleDatabaseSnapshots,
            deleteAwsCloudAccountWithoutCft,
            deleteAwsCluster,
            deleteAwsComputeSetting,
            deleteAwsExocomputeConfigs,
            deleteAwsIamUserBasedCloudAccount,
            deleteAzureAdDirectory,
            deleteAzureCloudAccount,
            deleteAzureCloudAccountExocomputeConfigurations,
            deleteAzureCloudAccountWithoutOauth,
            deleteAzureCluster,
            deleteCassandraSource,
            deleteFailoverCluster,
            deleteGlobalSla,
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
            deleteNutanixSnapshots,
            deleteO365AzureApp,
            deleteO365Org,
            deleteO365ServiceAccount,
            deleteOracleMount,
            deleteVsphereAdvancedTag,
            deleteVsphereLiveMount,
            discoverMongoSource,
            doesAzureNativeResourceGroupExist,
            downloadFilesNutanixSnapshot,
            downloadHypervSnapshotFromLocation,
            downloadHypervVirtualMachineSnapshot,
            downloadHypervVirtualMachineSnapshotFiles,
            downloadMssqlDatabaseBackupFiles,
            downloadMssqlDatabaseFilesFromArchivalLocation,
            downloadNutanixSnapshot,
            downloadNutanixVmFromLocation,
            downloadOracleDatabaseSnapshot,
            downloadSlaWithReplicationCsv,
            downloadVsphereVirtualMachineFiles,
            editGlobalSla,
            enableO365SharePoint,
            enableO365Teams,
            excludeAwsNativeEbsVolumesFromSnapshot,
            excludeAzureNativeManagedDisksFromSnapshot,
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
            hypervServer,
            hypervTopLevelDescendants,
            hypervVirtualMachineAsyncRequestStatus,
            hypervVirtualMachines,
            hypervVmDetail,
            initiateAzureAdAppUpdate,
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
            kickoffAzureAdAppSetup,
            ldapAuthorizedPrincipalConnection,
            ldapIntegrationConnection,
            ldapPrincipalConnection,
            listO365Apps,
            mapAzureCloudAccountExocomputeSubscription,
            mapAzureCloudAccountToPersistentStorageLocation,
            migrateNutanixMountV1,
            mongoCollections,
            mongoDatabases,
            mongoRecoverableRanges,
            mongoSources,
            mongodbBulkRecoverableRange,
            mongodbCollectionRecoverableRange,
            mongodbCollections,
            mongodbDatabases,
            mongodbSources,
            mountNutanixSnapshotV1,
            mountOracleDatabase,
            mssqlAvailabilityGroup,
            mssqlCompatibleInstances,
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
            nutanixCategories,
            nutanixCategoryValueVms,
            nutanixCategoryValues,
            nutanixCluster,
            nutanixClusterAsyncRequestStatus,
            nutanixClusterContainers,
            nutanixClusterNetworks,
            nutanixMounts,
            nutanixPrismCentrals,
            nutanixSnapshotDetail,
            nutanixTopLevelDescendants,
            nutanixTopLevelDescendantsV2,
            nutanixVm,
            nutanixVmAsyncRequestStatus,
            nutanixVmMissedSnapshots,
            o365Calendar,
            o365Groups,
            o365License,
            o365Mailbox,
            o365Mailboxes,
            o365OauthConsentComplete,
            o365OauthConsentKickoff,
            o365ObjectAncestors,
            o365Onedrive,
            o365Org,
            o365OrgAtSnappableLevel,
            o365OrgSummaries,
            o365PdlGroups,
            o365SaaSSetupKickoff,
            o365SaasSetupComplete,
            o365ServiceAccount,
            o365ServiceStatus,
            o365SetupKickoff,
            o365SharepointDrive,
            o365SharepointList,
            o365SharepointObjectList,
            o365SharepointObjects,
            o365SharepointSite,
            o365Site,
            o365StorageStats,
            o365Team,
            o365TeamChannels,
            o365TeamConversationsFolderID,
            o365TeamPostedBy,
            o365User,
            o365UserObjects,
            oracleAcoExampleDownloadLink,
            oracleAcoParameters,
            oracleDataGuardGroup,
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
            patchMongoSource,
            patchNutanixMountV1,
            pauseSla,
            prepareAwsCloudAccountDeletion,
            prepareFeatureUpdateForAwsCloudAccount,
            protectedClustersForGlobalSla,
            rdsInstanceDetailsFromAws,
            recoverCassandraSource,
            recoverCloudCluster,
            recoverMongoSource,
            recoverMongodbSource,
            refreshHypervScvmm,
            refreshHypervServer,
            refreshK8sCluster,
            refreshNutanixCluster,
            refreshNutanixPrismCentral,
            refreshO365Org,
            refreshOracleDatabase,
            registerAgentHypervVirtualMachine,
            registerAgentNutanixVm,
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
            slaArchivalValidationWarnings,
            slaAuditDetail,
            slaConflictObjects,
            slaDomainWithWarnings,
            slaDomainWithWarningsList,
            slaDomains,
            slaManagedVolumes,
            slaSummariesByIds,
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
            uniqueVSphereVCenterCount,
            unmapAzureCloudAccountExocomputeSubscription,
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
            upgradeAwsCloudAccountFeaturesWithoutCft,
            upgradeAwsIamUserBasedCloudAccountPermissions,
            upgradeAzureCloudAccount,
            upgradeAzureCloudAccountPermissionsWithoutOauth,
            upgradeSlas,
            vCenterAdvancedTagPreview,
            vCenterHotAddBandwidth,
            vCenterHotAddNetwork,
            vCenterNetworks,
            vCenterNumProxiesNeeded,
            vCenterPreAddInfo,
            vSphereBlueprint,
            vSphereComputeCluster,
            vSphereDatacenter,
            vSphereDatastore,
            vSphereDatastoreCluster,
            vSphereDatastoreConnection,
            vSphereFolder,
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
            vSphereVMBatchLiveMount,
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
            vcdClusters,
            verifySLAWithReplicationToCluster,
            vsphereBulkOnDemandSnapshot,
            vsphereCreateVCenter,
            vsphereDeleteVcenter,
            vsphereEditVCenter,
            vsphereExcludeVmDisks,
            vsphereExportSnapshotToStandaloneHost,
            vsphereExportSnapshotToStandaloneHostV2,
            vsphereOnDemandSnapshot,
            vsphereRefreshVCenter,
            vsphereVMDeleteLiveMount,
            vsphereVMExportSnapshot,
            vsphereVMInitiateInstantRecovery,
            vsphereVMInitiateLiveMount,
            vsphereVMMissedRecoverableRange,
            vsphereVMRecoverableRange,
            vsphereVMRecoverableRangeInBatch,
            vsphereVMUpdate,
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

        public static string OperationLookup( GqlOperationName gqlOpName)
        {
            var OperationLookupDict = new Dictionary<GqlOperationName, string> {
                {
                    GqlOperationName.AwsCloudAccountListKMSKeys,
                    "Invoke-RscQueryAws -CloudAccountListKMSKey"
                },
                {
                    GqlOperationName.accountId,
                    "Invoke-RscQueryAccount -Id"
                },
                {
                    GqlOperationName.accountSettings,
                    "Invoke-RscQueryAccount -Setting"
                },
                {
                    GqlOperationName.activitySeries,
                    "Invoke-RscQueryActivitySeries -ActivitySeries"
                },
                {
                    GqlOperationName.activitySeriesConnection,
                    "Invoke-RscQueryActivitySeries -List"
                },
                {
                    GqlOperationName.activitySeriesGroupByConnection,
                    "Invoke-RscQueryActivitySeries -GroupByList"
                },
                {
                    GqlOperationName.addAwsAuthenticationServerBasedCloudAccount,
                    "Invoke-RscMutateAws -AddAuthenticationServerBasedCloudAccount"
                },
                {
                    GqlOperationName.addAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -AddIamUserBasedCloudAccount"
                },
                {
                    GqlOperationName.addAzureCloudAccount,
                    "Invoke-RscMutateAzure -AddCloudAccount"
                },
                {
                    GqlOperationName.addAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscMutateAzure -AddCloudAccountExocomputeConfiguration"
                },
                {
                    GqlOperationName.addAzureCloudAccountWithoutOauth,
                    "Invoke-RscMutateAzure -AddCloudAccountWithoutOauth"
                },
                {
                    GqlOperationName.addMongoSource,
                    "Invoke-RscMutateMongo -AddSource"
                },
                {
                    GqlOperationName.addNodesToCloudCluster,
                    "Invoke-RscMutateCluster -AddNodesToCloud"
                },
                {
                    GqlOperationName.addO365Org,
                    "Invoke-RscMutateO365 -AddOrg"
                },
                {
                    GqlOperationName.allAccountOwners,
                    "Invoke-RscQueryAccount -Owner"
                },
                {
                    GqlOperationName.allAccountProducts,
                    "Invoke-RscQueryAccount -Product"
                },
                {
                    GqlOperationName.allAccountsWithExocomputeMappings,
                    "Invoke-RscQueryAccount -SWithExocomputeMapping"
                },
                {
                    GqlOperationName.allAvailabilityZonesByRegionFromAws,
                    "Invoke-RscQueryAws -AllAvailabilityZonesByRegion"
                },
                {
                    GqlOperationName.allAwsCdmVersions,
                    "Invoke-RscQueryAws -AllCdmVersion"
                },
                {
                    GqlOperationName.allAwsCloudAccountConfigs,
                    "Invoke-RscQueryAws -AllCloudAccountConfig"
                },
                {
                    GqlOperationName.allAwsCloudAccountsFeaturesWithExoConfigs,
                    "Invoke-RscQueryAws -AllCloudAccountsFeaturesWithExoConfig"
                },
                {
                    GqlOperationName.allAwsCloudAccountsWithFeatures,
                    "Invoke-RscQueryAws -AllCloudAccountsWithFeature"
                },
                {
                    GqlOperationName.allAwsComputeSettings,
                    "Invoke-RscQueryAws -AllComputeSetting"
                },
                {
                    GqlOperationName.allAwsExocomputeConfigs,
                    "Invoke-RscQueryAws -AllExocomputeConfig"
                },
                {
                    GqlOperationName.allAwsInstanceProfileNames,
                    "Invoke-RscQueryAws -AllInstanceProfileName"
                },
                {
                    GqlOperationName.allAwsRdsAuroraInstanceClasses,
                    "Invoke-RscQueryAws -AllRdsAuroraInstanceClass"
                },
                {
                    GqlOperationName.allAwsRegions,
                    "Invoke-RscQueryAws -AllRegion"
                },
                {
                    GqlOperationName.allAzureArmTemplatesByFeature,
                    "Invoke-RscQueryAzure -AllArmTemplatesByFeature"
                },
                {
                    GqlOperationName.allAzureCdmVersions,
                    "Invoke-RscQueryAzure -AllCdmVersion"
                },
                {
                    GqlOperationName.allAzureCloudAccountMissingPermissions,
                    "Invoke-RscQueryAzure -AllCloudAccountMissingPermission"
                },
                {
                    GqlOperationName.allAzureCloudAccountSubnetsByRegion,
                    "Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion"
                },
                {
                    GqlOperationName.allAzureCloudAccountSubscriptionsByFeature,
                    "Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature"
                },
                {
                    GqlOperationName.allAzureCloudAccountTenants,
                    "Invoke-RscQueryAzure -AllCloudAccountTenant"
                },
                {
                    GqlOperationName.allAzureCloudAccountTenantsWithExoConfigs,
                    "Invoke-RscQueryAzure -AllCloudAccountTenantsWithExoConfig"
                },
                {
                    GqlOperationName.allAzureDiskEncryptionSetsByRegion,
                    "Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion"
                },
                {
                    GqlOperationName.allAzureEncryptionKeys,
                    "Invoke-RscQueryAzure -AllEncryptionKey"
                },
                {
                    GqlOperationName.allAzureExocomputeConfigsInAccount,
                    "Invoke-RscQueryAzure -AllExocomputeConfigsInAccount"
                },
                {
                    GqlOperationName.allAzureKeyVaultsByRegion,
                    "Invoke-RscQueryAzure -AllKeyVaultsByRegion"
                },
                {
                    GqlOperationName.allAzureNativeAvailabilitySetsByRegionFromAzure,
                    "Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
                    "Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
                    "Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeResourceGroupsInfoIfExist,
                    "Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist"
                },
                {
                    GqlOperationName.allAzureNativeSecurityGroupsByRegionFromAzure,
                    "Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeStorageAccountsFromAzure,
                    "Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeSubnetsByRegionFromAzure,
                    "Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure"
                },
                {
                    GqlOperationName.allAzureNativeVirtualMachineSizes,
                    "Invoke-RscQueryAzure -AllNativeVirtualMachineSize"
                },
                {
                    GqlOperationName.allAzureNativeVirtualNetworks,
                    "Invoke-RscQueryAzure -AllNativeVirtualNetwork"
                },
                {
                    GqlOperationName.allAzureNsgs,
                    "Invoke-RscQueryAzure -AllNsg"
                },
                {
                    GqlOperationName.allAzureRegions,
                    "Invoke-RscQueryAzure -AllRegion"
                },
                {
                    GqlOperationName.allAzureResourceGroups,
                    "Invoke-RscQueryAzure -AllResourceGroup"
                },
                {
                    GqlOperationName.allAzureSqlDatabaseServerElasticPools,
                    "Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPool"
                },
                {
                    GqlOperationName.allAzureStorageAccounts,
                    "Invoke-RscQueryAzure -AllStorageAccount"
                },
                {
                    GqlOperationName.allAzureSubnets,
                    "Invoke-RscQueryAzure -AllSubnet"
                },
                {
                    GqlOperationName.allAzureSubscriptionWithExocomputeMappings,
                    "Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMapping"
                },
                {
                    GqlOperationName.allAzureVnets,
                    "Invoke-RscQueryAzure -AllVnet"
                },
                {
                    GqlOperationName.allCdpSlaVmNames,
                    "Invoke-RscQuerySla -AllCdpVmName"
                },
                {
                    GqlOperationName.allCloudClusters,
                    "Invoke-RscQueryCluster -Cloud"
                },
                {
                    GqlOperationName.allClusterGlobalSlas,
                    "Invoke-RscQuerySla -AllClusterGlobal"
                },
                {
                    GqlOperationName.allClusterReplicationTargets,
                    "Invoke-RscQueryCluster -ReplicationTarget"
                },
                {
                    GqlOperationName.allClusterWebCertsAndIpmis,
                    "Invoke-RscQueryCluster -WebCertsAndIpmi"
                },
                {
                    GqlOperationName.allClustersTotpAckStatus,
                    "Invoke-RscQueryCluster -TotpAckStatus"
                },
                {
                    GqlOperationName.allConnectedClusters,
                    "Invoke-RscQueryCluster -Connected"
                },
                {
                    GqlOperationName.allDbParameterGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -AllDbParameterGroupsByRegion"
                },
                {
                    GqlOperationName.allDbSubnetGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -AllDbSubnetGroupsByRegion"
                },
                {
                    GqlOperationName.allEc2KeyPairsByRegionFromAws,
                    "Invoke-RscQueryAws -AllEc2KeyPairsByRegion"
                },
                {
                    GqlOperationName.allGlobalFileSearchMultipleClusters,
                    "Invoke-RscQueryCluster -GlobalFileSearchMultiple"
                },
                {
                    GqlOperationName.allHostedAzureRegions,
                    "Invoke-RscQueryAzure -AllHostedRegion"
                },
                {
                    GqlOperationName.allKmsEncryptionKeysByRegionFromAws,
                    "Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion"
                },
                {
                    GqlOperationName.allMssqlDatabaseRestoreFiles,
                    "Invoke-RscQueryMssql -AllDatabaseRestoreFile"
                },
                {
                    GqlOperationName.allNcdSlaComplianceData,
                    "Invoke-RscQuerySla -AllNcdComplianceData"
                },
                {
                    GqlOperationName.allO365AdGroups,
                    "Invoke-RscQueryO365 -AllAdGroup"
                },
                {
                    GqlOperationName.allO365OrgStatuses,
                    "Invoke-RscQueryO365 -AllOrgStatus"
                },
                {
                    GqlOperationName.allO365SubscriptionsAppTypeCounts,
                    "Invoke-RscQueryO365 -AllSubscriptionsAppTypeCount"
                },
                {
                    GqlOperationName.allOptionGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -AllOptionGroupsByRegion"
                },
                {
                    GqlOperationName.allResourceGroupsFromAzure,
                    "Invoke-RscQueryAzure -AllResourceGroupsFrom"
                },
                {
                    GqlOperationName.allS3BucketsDetailsFromAws,
                    "Invoke-RscQueryAws -AllS3BucketsDetail"
                },
                {
                    GqlOperationName.allS3BucketsFromAws,
                    "Invoke-RscQueryAws -AllS3Bucket"
                },
                {
                    GqlOperationName.allSlaIofilterStatuses,
                    "Invoke-RscQuerySla -AllIofilterStatus"
                },
                {
                    GqlOperationName.allSupportedAwsRdsDatabaseInstanceClasses,
                    "Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClass"
                },
                {
                    GqlOperationName.allVcenterHotAddProxyVms,
                    "Invoke-RscQueryVcenter -HotAddProxy"
                },
                {
                    GqlOperationName.allVpcsByRegionFromAws,
                    "Invoke-RscQueryAws -AllVpcsByRegion"
                },
                {
                    GqlOperationName.allVpcsFromAws,
                    "Invoke-RscQueryAws -AllVpc"
                },
                {
                    GqlOperationName.amiTypeForAwsNativeArchivedSnapshotExport,
                    "Invoke-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport"
                },
                {
                    GqlOperationName.archiveK8sCluster,
                    "Invoke-RscMutateCluster -ArchiveK8s"
                },
                {
                    GqlOperationName.assignMssqlSlaDomainProperties,
                    "Invoke-RscMutateMssql -AssignSlaDomainPropertie"
                },
                {
                    GqlOperationName.assignMssqlSlaDomainPropertiesAsync,
                    "Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnappables,
                    "Invoke-RscMutateSla -AssignRetentionToSnappable"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnapshots,
                    "Invoke-RscMutateSla -AssignRetentionToSnapshot"
                },
                {
                    GqlOperationName.assignSla,
                    "Invoke-RscMutateSla -Assign"
                },
                {
                    GqlOperationName.assignSlaToMongoDbCollection,
                    "Invoke-RscMutateMongo -AssignSlaToDbCollection"
                },
                {
                    GqlOperationName.assignSlasForSnappableHierarchies,
                    "Invoke-RscMutateSla -AssignsForSnappableHierarchie"
                },
                {
                    GqlOperationName.awsCloudAccountInitiate,
                    "Invoke-RscMutateAws -CloudAccountInitiate"
                },
                {
                    GqlOperationName.awsCloudAccountListSecurityGroups,
                    "Invoke-RscQueryAws -CloudAccountListSecurityGroup"
                },
                {
                    GqlOperationName.awsCloudAccountListSubnets,
                    "Invoke-RscQueryAws -CloudAccountListSubnet"
                },
                {
                    GqlOperationName.awsCloudAccountListVpcs,
                    "Invoke-RscQueryAws -CloudAccountListVpc"
                },
                {
                    GqlOperationName.awsCloudAccountUpdateFeature,
                    "Invoke-RscMutateAws -CloudAccountUpdateFeature"
                },
                {
                    GqlOperationName.awsCloudAccountValidate,
                    "Invoke-RscMutateAws -CloudAccountValidate"
                },
                {
                    GqlOperationName.awsCloudAccountWithFeatures,
                    "Invoke-RscQueryAws -CloudAccountWithFeature"
                },
                {
                    GqlOperationName.awsComputeSettings,
                    "Invoke-RscQueryAws -ComputeSetting"
                },
                {
                    GqlOperationName.awsNativeAccount,
                    "Invoke-RscQueryAws -NativeAccount"
                },
                {
                    GqlOperationName.awsNativeEbsVolume,
                    "Invoke-RscQueryAws -NativeEbsVolume"
                },
                {
                    GqlOperationName.awsNativeEbsVolumesByName,
                    "Invoke-RscQueryAws -NativeEbsVolumesByName"
                },
                {
                    GqlOperationName.awsNativeEc2Instance,
                    "Invoke-RscQueryAws -NativeEc2Instance"
                },
                {
                    GqlOperationName.awsNativeEc2InstancesByName,
                    "Invoke-RscQueryAws -NativeEc2InstancesByName"
                },
                {
                    GqlOperationName.awsNativeProtectionAccountAdd,
                    "Invoke-RscMutateAws -NativeProtectionAccountAdd"
                },
                {
                    GqlOperationName.awsNativeRdsExportDefaults,
                    "Invoke-RscQueryAws -NativeRdsExportDefault"
                },
                {
                    GqlOperationName.awsNativeRdsInstance,
                    "Invoke-RscQueryAws -NativeRdsInstance"
                },
                {
                    GqlOperationName.awsNativeRdsPointInTimeRestoreWindow,
                    "Invoke-RscQueryAws -NativeRdsPointInTimeRestoreWindow"
                },
                {
                    GqlOperationName.awsNativeRoot,
                    "Invoke-RscQueryAws -NativeRoot"
                },
                {
                    GqlOperationName.awsNativeS3Bucket,
                    "Invoke-RscQueryAws -NativeS3Bucket"
                },
                {
                    GqlOperationName.azureAdDirectories,
                    "Invoke-RscQueryAzure -AdDirectorie"
                },
                {
                    GqlOperationName.azureAdDirectory,
                    "Invoke-RscQueryAzure -AdDirectory"
                },
                {
                    GqlOperationName.azureCloudAccountPermissionConfig,
                    "Invoke-RscQueryAzure -CloudAccountPermissionConfig"
                },
                {
                    GqlOperationName.azureCloudAccountSubscriptionWithFeatures,
                    "Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeature"
                },
                {
                    GqlOperationName.azureCloudAccountTenant,
                    "Invoke-RscQueryAzure -CloudAccountTenant"
                },
                {
                    GqlOperationName.azureCloudAccountTenantWithExoConfigs,
                    "Invoke-RscQueryAzure -CloudAccountTenantWithExoConfig"
                },
                {
                    GqlOperationName.azureNativeManagedDisk,
                    "Invoke-RscQueryAzure -NativeManagedDisk"
                },
                {
                    GqlOperationName.azureNativeResourceGroup,
                    "Invoke-RscQueryAzure -NativeResourceGroup"
                },
                {
                    GqlOperationName.azureNativeRoot,
                    "Invoke-RscQueryAzure -NativeRoot"
                },
                {
                    GqlOperationName.azureNativeSubscription,
                    "Invoke-RscQueryAzure -NativeSubscription"
                },
                {
                    GqlOperationName.azureNativeVirtualMachine,
                    "Invoke-RscQueryAzure -NativeVirtualMachine"
                },
                {
                    GqlOperationName.azureO365CheckNSGOutboundRules,
                    "Invoke-RscQueryAzureO365 -CheckNSGOutboundRule"
                },
                {
                    GqlOperationName.azureO365CheckNetworkSubnet,
                    "Invoke-RscQueryAzureO365 -CheckNetworkSubnet"
                },
                {
                    GqlOperationName.azureO365CheckResourceGroupName,
                    "Invoke-RscQueryAzureO365 -CheckResourceGroupName"
                },
                {
                    GqlOperationName.azureO365CheckStorageAccountAccessibility,
                    "Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility"
                },
                {
                    GqlOperationName.azureO365CheckStorageAccountName,
                    "Invoke-RscQueryAzureO365 -CheckStorageAccountName"
                },
                {
                    GqlOperationName.azureO365CheckSubscriptionQuota,
                    "Invoke-RscQueryAzureO365 -CheckSubscriptionQuota"
                },
                {
                    GqlOperationName.azureO365CheckVirtualNetworkName,
                    "Invoke-RscQueryAzureO365 -CheckVirtualNetworkName"
                },
                {
                    GqlOperationName.azureO365Exocompute,
                    "Invoke-RscQueryAzureO365 -Exocompute"
                },
                {
                    GqlOperationName.azureO365GetAzureHostType,
                    "Invoke-RscQueryAzureO365 -GetAzureHostType"
                },
                {
                    GqlOperationName.azureO365GetNetworkSubnetUnusedAddr,
                    "Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr"
                },
                {
                    GqlOperationName.azureO365ValidateUserRoles,
                    "Invoke-RscQueryAzureO365 -ValidateUserRole"
                },
                {
                    GqlOperationName.azureOauthConsentComplete,
                    "Invoke-RscMutateAzure -OauthConsentComplete"
                },
                {
                    GqlOperationName.azureOauthConsentKickoff,
                    "Invoke-RscMutateAzure -OauthConsentKickoff"
                },
                {
                    GqlOperationName.azureRegions,
                    "Invoke-RscQueryAzure -Region"
                },
                {
                    GqlOperationName.azureResourceGroups,
                    "Invoke-RscQueryAzure -ResourceGroup"
                },
                {
                    GqlOperationName.azureSqlDatabase,
                    "Invoke-RscQueryAzure -SqlDatabase"
                },
                {
                    GqlOperationName.azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
                    "Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure"
                },
                {
                    GqlOperationName.azureSqlDatabaseServer,
                    "Invoke-RscQueryAzure -SqlDatabaseServer"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDatabase,
                    "Invoke-RscQueryAzure -SqlManagedInstanceDatabase"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
                    "Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceServer,
                    "Invoke-RscQueryAzure -SqlManagedInstanceServer"
                },
                {
                    GqlOperationName.azureStorageAccounts,
                    "Invoke-RscQueryAzure -StorageAccount"
                },
                {
                    GqlOperationName.azureSubnets,
                    "Invoke-RscQueryAzure -Subnet"
                },
                {
                    GqlOperationName.azureSubscriptions,
                    "Invoke-RscQueryAzure -Subscription"
                },
                {
                    GqlOperationName.azureVNets,
                    "Invoke-RscQueryAzure -VNet"
                },
                {
                    GqlOperationName.backupAzureAdDirectory,
                    "Invoke-RscMutateAzure -BackupAdDirectory"
                },
                {
                    GqlOperationName.backupO365Mailbox,
                    "Invoke-RscMutateO365 -BackupMailbox"
                },
                {
                    GqlOperationName.backupO365Onedrive,
                    "Invoke-RscMutateO365 -BackupOnedrive"
                },
                {
                    GqlOperationName.backupO365SharePointSite,
                    "Invoke-RscMutateO365 -BackupSharePointSite"
                },
                {
                    GqlOperationName.backupO365SharepointDrive,
                    "Invoke-RscMutateO365 -BackupSharepointDrive"
                },
                {
                    GqlOperationName.backupO365SharepointList,
                    "Invoke-RscMutateO365 -BackupSharepointList"
                },
                {
                    GqlOperationName.backupO365Team,
                    "Invoke-RscMutateO365 -BackupTeam"
                },
                {
                    GqlOperationName.batchExportHypervVm,
                    "Invoke-RscMutateHyperv -BatchExportVm"
                },
                {
                    GqlOperationName.batchExportNutanixVm,
                    "Invoke-RscMutateNutanix -BatchExportVm"
                },
                {
                    GqlOperationName.batchInstantRecoverHypervVm,
                    "Invoke-RscMutateHyperv -BatchInstantRecoverVm"
                },
                {
                    GqlOperationName.batchMountHypervVm,
                    "Invoke-RscMutateHyperv -BatchMountVm"
                },
                {
                    GqlOperationName.batchMountNutanixVm,
                    "Invoke-RscMutateNutanix -BatchMountVm"
                },
                {
                    GqlOperationName.batchOnDemandBackupHypervVm,
                    "Invoke-RscMutateHyperv -BatchOnDemandBackupVm"
                },
                {
                    GqlOperationName.browseMssqlDatabaseSnapshot,
                    "Invoke-RscMutateMssql -BrowseDatabaseSnapshot"
                },
                {
                    GqlOperationName.browseO365TeamConvChannels,
                    "Invoke-RscQueryO365 -BrowseTeamConvChannel"
                },
                {
                    GqlOperationName.bulkCreateOnDemandMssqlBackup,
                    "Invoke-RscMutateMssql -BulkCreateOnDemandBackup"
                },
                {
                    GqlOperationName.bulkDeleteCassandraSources,
                    "Invoke-RscMutateCassandra -BulkDeleteSource"
                },
                {
                    GqlOperationName.bulkDeleteFailoverCluster,
                    "Invoke-RscMutateCluster -BulkDeleteFailover"
                },
                {
                    GqlOperationName.bulkDeleteMongodbSources,
                    "Invoke-RscMutateMongo -BulkDeletedbSource"
                },
                {
                    GqlOperationName.bulkOnDemandSnapshotNutanixVm,
                    "Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm"
                },
                {
                    GqlOperationName.bulkUpdateMssqlDbs,
                    "Invoke-RscMutateMssql -BulkUpdateDb"
                },
                {
                    GqlOperationName.bulkUpdateOracleDatabases,
                    "Invoke-RscMutateOracle -BulkUpdateDatabase"
                },
                {
                    GqlOperationName.bulkUpdateOracleHosts,
                    "Invoke-RscMutateOracle -BulkUpdateHost"
                },
                {
                    GqlOperationName.bulkUpdateOracleRacs,
                    "Invoke-RscMutateOracle -BulkUpdateRac"
                },
                {
                    GqlOperationName.cancelActivitySeries,
                    "Invoke-RscMutateActivitySeries -Cancel"
                },
                {
                    GqlOperationName.cassandraColumnFamilies,
                    "Invoke-RscQueryCassandra -ColumnFamily"
                },
                {
                    GqlOperationName.cassandraColumnFamilyRecoverableRange,
                    "Invoke-RscQueryCassandra -ColumnFamilyRecoverableRange"
                },
                {
                    GqlOperationName.cassandraColumnFamilySchema,
                    "Invoke-RscQueryCassandra -ColumnFamilySchema"
                },
                {
                    GqlOperationName.cassandraKeyspaces,
                    "Invoke-RscQueryCassandra -Keyspace"
                },
                {
                    GqlOperationName.cassandraSources,
                    "Invoke-RscQueryCassandra -Source"
                },
                {
                    GqlOperationName.cdmMssqlLogShippingTargets,
                    "Invoke-RscQueryMssql -CdmLogShippingTarget"
                },
                {
                    GqlOperationName.cluster,
                    "Invoke-RscQueryCluster -Cluster"
                },
                {
                    GqlOperationName.clusterCertificates,
                    "Invoke-RscQueryCluster -Certificate"
                },
                {
                    GqlOperationName.clusterConnection,
                    "Invoke-RscQueryCluster -List"
                },
                {
                    GqlOperationName.clusterCsr,
                    "Invoke-RscQueryCluster -Csr"
                },
                {
                    GqlOperationName.clusterDefaultGateway,
                    "Invoke-RscQueryCluster -DefaultGateway"
                },
                {
                    GqlOperationName.clusterDns,
                    "Invoke-RscQueryCluster -Dns"
                },
                {
                    GqlOperationName.clusterEncryptionInfo,
                    "Invoke-RscQueryCluster -EncryptionInfo"
                },
                {
                    GqlOperationName.clusterFloatingIps,
                    "Invoke-RscQueryCluster -FloatingIp"
                },
                {
                    GqlOperationName.clusterGroupByConnection,
                    "Invoke-RscQueryCluster -GroupByList"
                },
                {
                    GqlOperationName.clusterIpmi,
                    "Invoke-RscQueryCluster -Ipmi"
                },
                {
                    GqlOperationName.clusterIpv6Mode,
                    "Invoke-RscQueryCluster -Ipv6Mode"
                },
                {
                    GqlOperationName.clusterNetworkInterfaces,
                    "Invoke-RscQueryCluster -NetworkInterface"
                },
                {
                    GqlOperationName.clusterNodes,
                    "Invoke-RscQueryCluster -Node"
                },
                {
                    GqlOperationName.clusterNtpServers,
                    "Invoke-RscQueryCluster -NtpServer"
                },
                {
                    GqlOperationName.clusterOperationJobProgress,
                    "Invoke-RscQueryCluster -OperationJobProgress"
                },
                {
                    GqlOperationName.clusterProxy,
                    "Invoke-RscQueryCluster -Proxy"
                },
                {
                    GqlOperationName.clusterRcvLocations,
                    "Invoke-RscQueryCluster -RcvLocation"
                },
                {
                    GqlOperationName.clusterRegistrationProductInfo,
                    "Invoke-RscQueryCluster -RegistrationProductInfo"
                },
                {
                    GqlOperationName.clusterSlaDomainConnection,
                    "Invoke-RscQuerySla -ClusterDomainList"
                },
                {
                    GqlOperationName.clusterSlaDomainFilterConnection,
                    "Invoke-RscQuerySla -ClusterDomainFilterList"
                },
                {
                    GqlOperationName.clusterTypeList,
                    "Invoke-RscQueryCluster -TypeList"
                },
                {
                    GqlOperationName.clusterVlans,
                    "Invoke-RscQueryCluster -Vlan"
                },
                {
                    GqlOperationName.clusterWebSignedCertificate,
                    "Invoke-RscQueryCluster -WebSignedCertificate"
                },
                {
                    GqlOperationName.clusterWithConfigProtectionInfo,
                    "Invoke-RscQueryCluster -WithConfigProtectionInfo"
                },
                {
                    GqlOperationName.clusterWithUpgradesInfo,
                    "Invoke-RscQueryCluster -WithUpgradesInfo"
                },
                {
                    GqlOperationName.completeAzureAdAppSetup,
                    "Invoke-RscMutateAzure -CompleteAdAppSetup"
                },
                {
                    GqlOperationName.completeAzureAdAppUpdate,
                    "Invoke-RscMutateAzure -CompleteAdAppUpdate"
                },
                {
                    GqlOperationName.completeAzureCloudAccountOauth,
                    "Invoke-RscMutateAzure -CompleteCloudAccountOauth"
                },
                {
                    GqlOperationName.countOfObjectsProtectedBySlas,
                    "Invoke-RscQuerySla -CountOfObjectsProtected"
                },
                {
                    GqlOperationName.createAutomaticAwsTargetMapping,
                    "Invoke-RscMutateAws -CreateAutomaticTargetMapping"
                },
                {
                    GqlOperationName.createAutomaticAzureTargetMapping,
                    "Invoke-RscMutateAzure -CreateAutomaticTargetMapping"
                },
                {
                    GqlOperationName.createAwsAccount,
                    "Invoke-RscMutateAws -CreateAccount"
                },
                {
                    GqlOperationName.createAwsCluster,
                    "Invoke-RscMutateAws -CreateCluster"
                },
                {
                    GqlOperationName.createAwsComputeSetting,
                    "Invoke-RscMutateAws -CreateComputeSetting"
                },
                {
                    GqlOperationName.createAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -CreateExocomputeConfig"
                },
                {
                    GqlOperationName.createAwsReaderTarget,
                    "Invoke-RscMutateAws -CreateReaderTarget"
                },
                {
                    GqlOperationName.createAwsTarget,
                    "Invoke-RscMutateAws -CreateTarget"
                },
                {
                    GqlOperationName.createAzureAccount,
                    "Invoke-RscMutateAzure -CreateAccount"
                },
                {
                    GqlOperationName.createAzureCluster,
                    "Invoke-RscMutateAzure -CreateCluster"
                },
                {
                    GqlOperationName.createAzureReaderTarget,
                    "Invoke-RscMutateAzure -CreateReaderTarget"
                },
                {
                    GqlOperationName.createAzureSaasAppAad,
                    "Invoke-RscMutateAzure -CreateSaasAppAad"
                },
                {
                    GqlOperationName.createAzureTarget,
                    "Invoke-RscMutateAzure -CreateTarget"
                },
                {
                    GqlOperationName.createCassandraSource,
                    "Invoke-RscMutateCassandra -CreateSource"
                },
                {
                    GqlOperationName.createCloudNativeAwsStorageSetting,
                    "Invoke-RscMutateAws -CreateCloudNativeStorageSetting"
                },
                {
                    GqlOperationName.createCloudNativeAzureStorageSetting,
                    "Invoke-RscMutateAzure -CreateCloudNativeStorageSetting"
                },
                {
                    GqlOperationName.createCloudNativeRcvAzureStorageSetting,
                    "Invoke-RscMutateAzure -CreateCloudNativeRcvStorageSetting"
                },
                {
                    GqlOperationName.createFailoverCluster,
                    "Invoke-RscMutateCluster -CreateFailover"
                },
                {
                    GqlOperationName.createGlobalSla,
                    "Invoke-RscMutateSla -CreateGlobal"
                },
                {
                    GqlOperationName.createHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -CreateVirtualMachineSnapshotMount"
                },
                {
                    GqlOperationName.createK8sCluster,
                    "Invoke-RscMutateCluster -CreateK8s"
                },
                {
                    GqlOperationName.createMongodbSource,
                    "Invoke-RscMutateMongo -CreatedbSource"
                },
                {
                    GqlOperationName.createMssqlLiveMount,
                    "Invoke-RscMutateMssql -CreateLiveMount"
                },
                {
                    GqlOperationName.createMssqlLogShippingConfiguration,
                    "Invoke-RscMutateMssql -CreateLogShippingConfiguration"
                },
                {
                    GqlOperationName.createNutanixCluster,
                    "Invoke-RscMutateNutanix -CreateCluster"
                },
                {
                    GqlOperationName.createNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -CreatePrismCentral"
                },
                {
                    GqlOperationName.createO365AppComplete,
                    "Invoke-RscMutateO365 -CreateAppComplete"
                },
                {
                    GqlOperationName.createO365AppKickoff,
                    "Invoke-RscMutateO365 -CreateAppKickoff"
                },
                {
                    GqlOperationName.createOnDemandMssqlBackup,
                    "Invoke-RscMutateMssql -CreateOnDemandBackup"
                },
                {
                    GqlOperationName.createOnDemandNutanixBackup,
                    "Invoke-RscMutateNutanix -CreateOnDemandBackup"
                },
                {
                    GqlOperationName.createOraclePdbRestore,
                    "Invoke-RscMutateOracle -CreatePdbRestore"
                },
                {
                    GqlOperationName.createVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -CreateAdvancedTag"
                },
                {
                    GqlOperationName.deleteAllOracleDatabaseSnapshots,
                    "Invoke-RscMutateOracle -DeleteAllDatabaseSnapshot"
                },
                {
                    GqlOperationName.deleteAwsCloudAccountWithoutCft,
                    "Invoke-RscMutateAws -DeleteCloudAccountWithoutCft"
                },
                {
                    GqlOperationName.deleteAwsCluster,
                    "Invoke-RscMutateAws -DeleteCluster"
                },
                {
                    GqlOperationName.deleteAwsComputeSetting,
                    "Invoke-RscMutateAws -DeleteComputeSetting"
                },
                {
                    GqlOperationName.deleteAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -DeleteExocomputeConfig"
                },
                {
                    GqlOperationName.deleteAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -DeleteIamUserBasedCloudAccount"
                },
                {
                    GqlOperationName.deleteAzureAdDirectory,
                    "Invoke-RscMutateAzure -DeleteAdDirectory"
                },
                {
                    GqlOperationName.deleteAzureCloudAccount,
                    "Invoke-RscMutateAzure -DeleteCloudAccount"
                },
                {
                    GqlOperationName.deleteAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfiguration"
                },
                {
                    GqlOperationName.deleteAzureCloudAccountWithoutOauth,
                    "Invoke-RscMutateAzure -DeleteCloudAccountWithoutOauth"
                },
                {
                    GqlOperationName.deleteAzureCluster,
                    "Invoke-RscMutateAzure -DeleteCluster"
                },
                {
                    GqlOperationName.deleteCassandraSource,
                    "Invoke-RscMutateCassandra -DeleteSource"
                },
                {
                    GqlOperationName.deleteFailoverCluster,
                    "Invoke-RscMutateCluster -DeleteFailover"
                },
                {
                    GqlOperationName.deleteGlobalSla,
                    "Invoke-RscMutateSla -DeleteGlobal"
                },
                {
                    GqlOperationName.deleteHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshot"
                },
                {
                    GqlOperationName.deleteHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshotMount"
                },
                {
                    GqlOperationName.deleteLdapPrincipals,
                    "Invoke-RscMutateLdap -DeletePrincipal"
                },
                {
                    GqlOperationName.deleteMongoSource,
                    "Invoke-RscMutateMongo -DeleteSource"
                },
                {
                    GqlOperationName.deleteMongodbSource,
                    "Invoke-RscMutateMongo -DeletedbSource"
                },
                {
                    GqlOperationName.deleteMssqlDbSnapshots,
                    "Invoke-RscMutateMssql -DeleteDbSnapshot"
                },
                {
                    GqlOperationName.deleteMssqlLiveMount,
                    "Invoke-RscMutateMssql -DeleteLiveMount"
                },
                {
                    GqlOperationName.deleteNutanixCluster,
                    "Invoke-RscMutateNutanix -DeleteCluster"
                },
                {
                    GqlOperationName.deleteNutanixMountV1,
                    "Invoke-RscMutateNutanix -DeleteMountV1"
                },
                {
                    GqlOperationName.deleteNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -DeletePrismCentral"
                },
                {
                    GqlOperationName.deleteNutanixSnapshots,
                    "Invoke-RscMutateNutanix -DeleteSnapshot"
                },
                {
                    GqlOperationName.deleteO365AzureApp,
                    "Invoke-RscMutateO365 -DeleteAzureApp"
                },
                {
                    GqlOperationName.deleteO365Org,
                    "Invoke-RscMutateO365 -DeleteOrg"
                },
                {
                    GqlOperationName.deleteO365ServiceAccount,
                    "Invoke-RscMutateO365 -DeleteServiceAccount"
                },
                {
                    GqlOperationName.deleteOracleMount,
                    "Invoke-RscMutateOracle -DeleteMount"
                },
                {
                    GqlOperationName.deleteVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -DeleteAdvancedTag"
                },
                {
                    GqlOperationName.deleteVsphereLiveMount,
                    "Invoke-RscMutateVsphere -DeleteLiveMount"
                },
                {
                    GqlOperationName.discoverMongoSource,
                    "Invoke-RscMutateMongo -DiscoverSource"
                },
                {
                    GqlOperationName.doesAzureNativeResourceGroupExist,
                    "Invoke-RscQueryAzure -DoesNativeResourceGroupExist"
                },
                {
                    GqlOperationName.downloadFilesNutanixSnapshot,
                    "Invoke-RscMutateNutanix -DownloadFilesSnapshot"
                },
                {
                    GqlOperationName.downloadHypervSnapshotFromLocation,
                    "Invoke-RscMutateHyperv -DownloadSnapshotFromLocation"
                },
                {
                    GqlOperationName.downloadHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshot"
                },
                {
                    GqlOperationName.downloadHypervVirtualMachineSnapshotFiles,
                    "Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFile"
                },
                {
                    GqlOperationName.downloadMssqlDatabaseBackupFiles,
                    "Invoke-RscMutateMssql -DownloadDatabaseBackupFile"
                },
                {
                    GqlOperationName.downloadMssqlDatabaseFilesFromArchivalLocation,
                    "Invoke-RscMutateMssql -DownloadDatabaseFilesFromArchivalLocation"
                },
                {
                    GqlOperationName.downloadNutanixSnapshot,
                    "Invoke-RscMutateNutanix -DownloadSnapshot"
                },
                {
                    GqlOperationName.downloadNutanixVmFromLocation,
                    "Invoke-RscMutateNutanix -DownloadVmFromLocation"
                },
                {
                    GqlOperationName.downloadOracleDatabaseSnapshot,
                    "Invoke-RscMutateOracle -DownloadDatabaseSnapshot"
                },
                {
                    GqlOperationName.downloadSlaWithReplicationCsv,
                    "Invoke-RscQuerySla -DownloadWithReplicationCsv"
                },
                {
                    GqlOperationName.downloadVsphereVirtualMachineFiles,
                    "Invoke-RscMutateVsphere -DownloadVirtualMachineFile"
                },
                {
                    GqlOperationName.editGlobalSla,
                    "Invoke-RscMutateSla -EditGlobal"
                },
                {
                    GqlOperationName.enableO365SharePoint,
                    "Invoke-RscMutateO365 -EnableSharePoint"
                },
                {
                    GqlOperationName.enableO365Teams,
                    "Invoke-RscMutateO365 -EnableTeam"
                },
                {
                    GqlOperationName.excludeAwsNativeEbsVolumesFromSnapshot,
                    "Invoke-RscMutateAws -ExcludeNativeEbsVolumesFromSnapshot"
                },
                {
                    GqlOperationName.excludeAzureNativeManagedDisksFromSnapshot,
                    "Invoke-RscMutateAzure -ExcludeNativeManagedDisksFromSnapshot"
                },
                {
                    GqlOperationName.exportHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -ExportVirtualMachine"
                },
                {
                    GqlOperationName.exportMssqlDatabase,
                    "Invoke-RscMutateMssql -ExportDatabase"
                },
                {
                    GqlOperationName.exportNutanixSnapshot,
                    "Invoke-RscMutateNutanix -ExportSnapshot"
                },
                {
                    GqlOperationName.exportO365Mailbox,
                    "Invoke-RscMutateO365 -ExportMailbox"
                },
                {
                    GqlOperationName.exportOracleDatabase,
                    "Invoke-RscMutateOracle -ExportDatabase"
                },
                {
                    GqlOperationName.exportOracleTablespace,
                    "Invoke-RscMutateOracle -ExportTablespace"
                },
                {
                    GqlOperationName.exportSlaManagedVolumeSnapshot,
                    "Invoke-RscMutateSla -ExportManagedVolumeSnapshot"
                },
                {
                    GqlOperationName.finalizeAwsCloudAccountDeletion,
                    "Invoke-RscMutateAws -FinalizeCloudAccountDeletion"
                },
                {
                    GqlOperationName.finalizeAwsCloudAccountProtection,
                    "Invoke-RscMutateAws -FinalizeCloudAccountProtection"
                },
                {
                    GqlOperationName.getPendingSlaAssignments,
                    "Invoke-RscMutateSla -GetPendingAssignment"
                },
                {
                    GqlOperationName.globalSlaFilterConnection,
                    "Invoke-RscQuerySla -GlobalFilterList"
                },
                {
                    GqlOperationName.globalSlaStatuses,
                    "Invoke-RscQuerySla -GlobalStatus"
                },
                {
                    GqlOperationName.hostFailoverCluster,
                    "Invoke-RscQueryCluster -HostFailover"
                },
                {
                    GqlOperationName.hypervCluster,
                    "Invoke-RscQueryHyperv -Cluster"
                },
                {
                    GqlOperationName.hypervDeleteAllSnapshots,
                    "Invoke-RscMutateHyperv -DeleteAllSnapshot"
                },
                {
                    GqlOperationName.hypervHostAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -HostAsyncRequestStatus"
                },
                {
                    GqlOperationName.hypervMounts,
                    "Invoke-RscQueryHyperv -Mount"
                },
                {
                    GqlOperationName.hypervOnDemandSnapshot,
                    "Invoke-RscMutateHyperv -OnDemandSnapshot"
                },
                {
                    GqlOperationName.hypervScvmm,
                    "Invoke-RscQueryHyperv -Scvmm"
                },
                {
                    GqlOperationName.hypervScvmmAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus"
                },
                {
                    GqlOperationName.hypervScvmmDelete,
                    "Invoke-RscMutateHyperv -ScvmmDelete"
                },
                {
                    GqlOperationName.hypervScvmmUpdate,
                    "Invoke-RscMutateHyperv -ScvmmUpdate"
                },
                {
                    GqlOperationName.hypervServer,
                    "Invoke-RscQueryHyperv -Server"
                },
                {
                    GqlOperationName.hypervTopLevelDescendants,
                    "Invoke-RscQueryHyperv -TopLevelDescendant"
                },
                {
                    GqlOperationName.hypervVirtualMachineAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus"
                },
                {
                    GqlOperationName.hypervVirtualMachines,
                    "Invoke-RscQueryHyperv -VirtualMachine"
                },
                {
                    GqlOperationName.hypervVmDetail,
                    "Invoke-RscQueryHyperv -VmDetail"
                },
                {
                    GqlOperationName.initiateAzureAdAppUpdate,
                    "Invoke-RscMutateAzure -InitiateAdAppUpdate"
                },
                {
                    GqlOperationName.insertCustomerO365App,
                    "Invoke-RscMutateO365 -InsertCustomerApp"
                },
                {
                    GqlOperationName.instantRecoverHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -InstantRecoverVirtualMachineSnapshot"
                },
                {
                    GqlOperationName.instantRecoverOracleSnapshot,
                    "Invoke-RscMutateOracle -InstantRecoverSnapshot"
                },
                {
                    GqlOperationName.isAwsNativeEbsVolumeSnapshotRestorable,
                    "Invoke-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable"
                },
                {
                    GqlOperationName.isAwsNativeRdsInstanceLaunchConfigurationValid,
                    "Invoke-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid"
                },
                {
                    GqlOperationName.isAwsS3BucketNameAvailable,
                    "Invoke-RscQueryAws -IsS3BucketNameAvailable"
                },
                {
                    GqlOperationName.isAzureNativeManagedDiskSnapshotRestorable,
                    "Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable"
                },
                {
                    GqlOperationName.isAzureNativeSqlDatabaseSnapshotPersistent,
                    "Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent"
                },
                {
                    GqlOperationName.isAzureStorageAccountNameAvailable,
                    "Invoke-RscQueryAzure -IsStorageAccountNameAvailable"
                },
                {
                    GqlOperationName.isTotpAckNecessaryForCluster,
                    "Invoke-RscQueryCluster -IsTotpAckNecessary"
                },
                {
                    GqlOperationName.k8sClusters,
                    "Invoke-RscQueryCluster -K8s"
                },
                {
                    GqlOperationName.kickoffAzureAdAppSetup,
                    "Invoke-RscMutateAzure -KickoffAdAppSetup"
                },
                {
                    GqlOperationName.ldapAuthorizedPrincipalConnection,
                    "Invoke-RscQueryLdap -AuthorizedPrincipalList"
                },
                {
                    GqlOperationName.ldapIntegrationConnection,
                    "Invoke-RscQueryLdap -IntegrationList"
                },
                {
                    GqlOperationName.ldapPrincipalConnection,
                    "Invoke-RscQueryLdap -PrincipalList"
                },
                {
                    GqlOperationName.listO365Apps,
                    "Invoke-RscQueryO365 -ListApp"
                },
                {
                    GqlOperationName.mapAzureCloudAccountExocomputeSubscription,
                    "Invoke-RscMutateAzure -MapCloudAccountExocomputeSubscription"
                },
                {
                    GqlOperationName.mapAzureCloudAccountToPersistentStorageLocation,
                    "Invoke-RscMutateAzure -MapCloudAccountToPersistentStorageLocation"
                },
                {
                    GqlOperationName.migrateNutanixMountV1,
                    "Invoke-RscMutateNutanix -MigrateMountV1"
                },
                {
                    GqlOperationName.mongoCollections,
                    "Invoke-RscQueryMongo -Collection"
                },
                {
                    GqlOperationName.mongoDatabases,
                    "Invoke-RscQueryMongo -Database"
                },
                {
                    GqlOperationName.mongoRecoverableRanges,
                    "Invoke-RscQueryMongo -RecoverableRange"
                },
                {
                    GqlOperationName.mongoSources,
                    "Invoke-RscQueryMongo -Source"
                },
                {
                    GqlOperationName.mongodbBulkRecoverableRange,
                    "Invoke-RscQueryMongo -DbBulkRecoverableRange"
                },
                {
                    GqlOperationName.mongodbCollectionRecoverableRange,
                    "Invoke-RscQueryMongo -DbCollectionRecoverableRange"
                },
                {
                    GqlOperationName.mongodbCollections,
                    "Invoke-RscQueryMongo -DbCollection"
                },
                {
                    GqlOperationName.mongodbDatabases,
                    "Invoke-RscQueryMongo -DbDatabase"
                },
                {
                    GqlOperationName.mongodbSources,
                    "Invoke-RscQueryMongo -DbSource"
                },
                {
                    GqlOperationName.mountNutanixSnapshotV1,
                    "Invoke-RscMutateNutanix -MountSnapshotV1"
                },
                {
                    GqlOperationName.mountOracleDatabase,
                    "Invoke-RscMutateOracle -MountDatabase"
                },
                {
                    GqlOperationName.mssqlAvailabilityGroup,
                    "Invoke-RscQueryMssql -AvailabilityGroup"
                },
                {
                    GqlOperationName.mssqlCompatibleInstances,
                    "Invoke-RscQueryMssql -CompatibleInstance"
                },
                {
                    GqlOperationName.mssqlDatabaseLiveMounts,
                    "Invoke-RscQueryMssql -DatabaseLiveMount"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedRecoverableRanges,
                    "Invoke-RscQueryMssql -DatabaseMissedRecoverableRange"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedSnapshots,
                    "Invoke-RscQueryMssql -DatabaseMissedSnapshot"
                },
                {
                    GqlOperationName.mssqlDatabaseRestoreEstimate,
                    "Invoke-RscQueryMssql -DatabaseRestoreEstimate"
                },
                {
                    GqlOperationName.mssqlDatabases,
                    "Invoke-RscQueryMssql -Database"
                },
                {
                    GqlOperationName.mssqlDefaultProperties,
                    "Invoke-RscQueryMssql -DefaultPropertie"
                },
                {
                    GqlOperationName.mssqlInstance,
                    "Invoke-RscQueryMssql -Instance"
                },
                {
                    GqlOperationName.mssqlLogShippingTargets,
                    "Invoke-RscQueryMssql -LogShippingTarget"
                },
                {
                    GqlOperationName.mssqlRecoverableRanges,
                    "Invoke-RscQueryMssql -RecoverableRange"
                },
                {
                    GqlOperationName.mssqlTopLevelDescendants,
                    "Invoke-RscQueryMssql -TopLevelDescendant"
                },
                {
                    GqlOperationName.nutanixBrowseSnapshot,
                    "Invoke-RscQueryNutanix -BrowseSnapshot"
                },
                {
                    GqlOperationName.nutanixCategories,
                    "Invoke-RscQueryNutanix -Categorie"
                },
                {
                    GqlOperationName.nutanixCategoryValueVms,
                    "Invoke-RscQueryNutanix -CategoryValueVm"
                },
                {
                    GqlOperationName.nutanixCategoryValues,
                    "Invoke-RscQueryNutanix -CategoryValue"
                },
                {
                    GqlOperationName.nutanixCluster,
                    "Invoke-RscQueryNutanix -Cluster"
                },
                {
                    GqlOperationName.nutanixClusterAsyncRequestStatus,
                    "Invoke-RscQueryNutanix -ClusterAsyncRequestStatus"
                },
                {
                    GqlOperationName.nutanixClusterContainers,
                    "Invoke-RscQueryNutanix -ClusterContainer"
                },
                {
                    GqlOperationName.nutanixClusterNetworks,
                    "Invoke-RscQueryNutanix -ClusterNetwork"
                },
                {
                    GqlOperationName.nutanixMounts,
                    "Invoke-RscQueryNutanix -Mount"
                },
                {
                    GqlOperationName.nutanixPrismCentrals,
                    "Invoke-RscQueryNutanix -PrismCentral"
                },
                {
                    GqlOperationName.nutanixSnapshotDetail,
                    "Invoke-RscQueryNutanix -SnapshotDetail"
                },
                {
                    GqlOperationName.nutanixTopLevelDescendants,
                    "Invoke-RscQueryNutanix -TopLevelDescendant"
                },
                {
                    GqlOperationName.nutanixTopLevelDescendantsV2,
                    "Invoke-RscQueryNutanix -TopLevelDescendantsV2"
                },
                {
                    GqlOperationName.nutanixVm,
                    "Invoke-RscQueryNutanix -Vm"
                },
                {
                    GqlOperationName.nutanixVmAsyncRequestStatus,
                    "Invoke-RscQueryNutanix -VmAsyncRequestStatus"
                },
                {
                    GqlOperationName.nutanixVmMissedSnapshots,
                    "Invoke-RscQueryNutanix -VmMissedSnapshot"
                },
                {
                    GqlOperationName.o365Calendar,
                    "Invoke-RscQueryO365 -Calendar"
                },
                {
                    GqlOperationName.o365Groups,
                    "Invoke-RscQueryO365 -Group"
                },
                {
                    GqlOperationName.o365License,
                    "Invoke-RscQueryO365 -License"
                },
                {
                    GqlOperationName.o365Mailbox,
                    "Invoke-RscQueryO365 -Mailbox"
                },
                {
                    GqlOperationName.o365Mailboxes,
                    "Invoke-RscQueryO365 -Mailboxe"
                },
                {
                    GqlOperationName.o365OauthConsentComplete,
                    "Invoke-RscMutateO365 -OauthConsentComplete"
                },
                {
                    GqlOperationName.o365OauthConsentKickoff,
                    "Invoke-RscMutateO365 -OauthConsentKickoff"
                },
                {
                    GqlOperationName.o365ObjectAncestors,
                    "Invoke-RscQueryO365 -ObjectAncestor"
                },
                {
                    GqlOperationName.o365Onedrive,
                    "Invoke-RscQueryO365 -Onedrive"
                },
                {
                    GqlOperationName.o365Org,
                    "Invoke-RscQueryO365 -Org"
                },
                {
                    GqlOperationName.o365OrgAtSnappableLevel,
                    "Invoke-RscQueryO365 -OrgAtSnappableLevel"
                },
                {
                    GqlOperationName.o365OrgSummaries,
                    "Invoke-RscQueryO365 -OrgSummarie"
                },
                {
                    GqlOperationName.o365PdlGroups,
                    "Invoke-RscMutateO365 -PdlGroup"
                },
                {
                    GqlOperationName.o365SaaSSetupKickoff,
                    "Invoke-RscMutateO365 -SaaSSetupKickoff"
                },
                {
                    GqlOperationName.o365SaasSetupComplete,
                    "Invoke-RscMutateO365 -SaasSetupComplete"
                },
                {
                    GqlOperationName.o365ServiceAccount,
                    "Invoke-RscQueryO365 -ServiceAccount"
                },
                {
                    GqlOperationName.o365ServiceStatus,
                    "Invoke-RscQueryO365 -ServiceStatus"
                },
                {
                    GqlOperationName.o365SetupKickoff,
                    "Invoke-RscMutateO365 -SetupKickoff"
                },
                {
                    GqlOperationName.o365SharepointDrive,
                    "Invoke-RscQueryO365 -SharepointDrive"
                },
                {
                    GqlOperationName.o365SharepointList,
                    "Invoke-RscQueryO365 -SharepointList"
                },
                {
                    GqlOperationName.o365SharepointObjectList,
                    "Invoke-RscQueryO365 -SharepointObjectList"
                },
                {
                    GqlOperationName.o365SharepointObjects,
                    "Invoke-RscQueryO365 -SharepointObject"
                },
                {
                    GqlOperationName.o365SharepointSite,
                    "Invoke-RscQueryO365 -SharepointSite"
                },
                {
                    GqlOperationName.o365Site,
                    "Invoke-RscQueryO365 -Site"
                },
                {
                    GqlOperationName.o365StorageStats,
                    "Invoke-RscQueryO365 -StorageStat"
                },
                {
                    GqlOperationName.o365Team,
                    "Invoke-RscQueryO365 -Team"
                },
                {
                    GqlOperationName.o365TeamChannels,
                    "Invoke-RscQueryO365 -TeamChannel"
                },
                {
                    GqlOperationName.o365TeamConversationsFolderID,
                    "Invoke-RscQueryO365 -TeamConversationsFolderID"
                },
                {
                    GqlOperationName.o365TeamPostedBy,
                    "Invoke-RscQueryO365 -TeamPostedBy"
                },
                {
                    GqlOperationName.o365User,
                    "Invoke-RscQueryO365 -User"
                },
                {
                    GqlOperationName.o365UserObjects,
                    "Invoke-RscQueryO365 -UserObject"
                },
                {
                    GqlOperationName.oracleAcoExampleDownloadLink,
                    "Invoke-RscQueryOracle -AcoExampleDownloadLink"
                },
                {
                    GqlOperationName.oracleAcoParameters,
                    "Invoke-RscQueryOracle -AcoParameter"
                },
                {
                    GqlOperationName.oracleDataGuardGroup,
                    "Invoke-RscQueryOracle -DataGuardGroup"
                },
                {
                    GqlOperationName.oracleDatabaseLogBackupConfig,
                    "Invoke-RscQueryOracle -DatabaseLogBackupConfig"
                },
                {
                    GqlOperationName.oracleDatabases,
                    "Invoke-RscQueryOracle -Database"
                },
                {
                    GqlOperationName.oracleHost,
                    "Invoke-RscQueryOracle -Host"
                },
                {
                    GqlOperationName.oracleHostLogBackupConfig,
                    "Invoke-RscQueryOracle -HostLogBackupConfig"
                },
                {
                    GqlOperationName.oracleLiveMounts,
                    "Invoke-RscQueryOracle -LiveMount"
                },
                {
                    GqlOperationName.oracleMissedRecoverableRanges,
                    "Invoke-RscQueryOracle -MissedRecoverableRange"
                },
                {
                    GqlOperationName.oracleMissedSnapshots,
                    "Invoke-RscQueryOracle -MissedSnapshot"
                },
                {
                    GqlOperationName.oraclePdbDetails,
                    "Invoke-RscQueryOracle -PdbDetail"
                },
                {
                    GqlOperationName.oracleRac,
                    "Invoke-RscQueryOracle -Rac"
                },
                {
                    GqlOperationName.oracleRacLogBackupConfig,
                    "Invoke-RscQueryOracle -RacLogBackupConfig"
                },
                {
                    GqlOperationName.oracleRecoverableRanges,
                    "Invoke-RscQueryOracle -RecoverableRange"
                },
                {
                    GqlOperationName.oracleTopLevelDescendants,
                    "Invoke-RscQueryOracle -TopLevelDescendant"
                },
                {
                    GqlOperationName.patchAwsAuthenticationServerBasedCloudAccount,
                    "Invoke-RscMutateAws -PatchAuthenticationServerBasedCloudAccount"
                },
                {
                    GqlOperationName.patchAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -PatchIamUserBasedCloudAccount"
                },
                {
                    GqlOperationName.patchMongoSource,
                    "Invoke-RscMutateMongo -PatchSource"
                },
                {
                    GqlOperationName.patchNutanixMountV1,
                    "Invoke-RscMutateNutanix -PatchMountV1"
                },
                {
                    GqlOperationName.pauseSla,
                    "Invoke-RscMutateSla -Pause"
                },
                {
                    GqlOperationName.prepareAwsCloudAccountDeletion,
                    "Invoke-RscMutateAws -PrepareCloudAccountDeletion"
                },
                {
                    GqlOperationName.prepareFeatureUpdateForAwsCloudAccount,
                    "Invoke-RscMutateAws -PrepareFeatureUpdateForCloudAccount"
                },
                {
                    GqlOperationName.protectedClustersForGlobalSla,
                    "Invoke-RscQuerySla -ProtectedClustersForGlobal"
                },
                {
                    GqlOperationName.rdsInstanceDetailsFromAws,
                    "Invoke-RscQueryAws -RdsInstanceDetail"
                },
                {
                    GqlOperationName.recoverCassandraSource,
                    "Invoke-RscMutateCassandra -RecoverSource"
                },
                {
                    GqlOperationName.recoverCloudCluster,
                    "Invoke-RscMutateCluster -RecoverCloud"
                },
                {
                    GqlOperationName.recoverMongoSource,
                    "Invoke-RscMutateMongo -RecoverSource"
                },
                {
                    GqlOperationName.recoverMongodbSource,
                    "Invoke-RscMutateMongo -RecoverdbSource"
                },
                {
                    GqlOperationName.refreshHypervScvmm,
                    "Invoke-RscMutateHyperv -RefreshScvmm"
                },
                {
                    GqlOperationName.refreshHypervServer,
                    "Invoke-RscMutateHyperv -RefreshServer"
                },
                {
                    GqlOperationName.refreshK8sCluster,
                    "Invoke-RscMutateCluster -RefreshK8s"
                },
                {
                    GqlOperationName.refreshNutanixCluster,
                    "Invoke-RscMutateNutanix -RefreshCluster"
                },
                {
                    GqlOperationName.refreshNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -RefreshPrismCentral"
                },
                {
                    GqlOperationName.refreshO365Org,
                    "Invoke-RscMutateO365 -RefreshOrg"
                },
                {
                    GqlOperationName.refreshOracleDatabase,
                    "Invoke-RscMutateOracle -RefreshDatabase"
                },
                {
                    GqlOperationName.registerAgentHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -RegisterAgentVirtualMachine"
                },
                {
                    GqlOperationName.registerAgentNutanixVm,
                    "Invoke-RscMutateNutanix -RegisterAgentVm"
                },
                {
                    GqlOperationName.registerCloudCluster,
                    "Invoke-RscMutateCluster -RegisterCloud"
                },
                {
                    GqlOperationName.registerHypervScvmm,
                    "Invoke-RscMutateHyperv -RegisterScvmm"
                },
                {
                    GqlOperationName.removeCdmCluster,
                    "Invoke-RscMutateCluster -RemoveCdm"
                },
                {
                    GqlOperationName.removeLdapIntegration,
                    "Invoke-RscMutateLdap -RemoveIntegration"
                },
                {
                    GqlOperationName.restoreFilesNutanixSnapshot,
                    "Invoke-RscMutateNutanix -RestoreFilesSnapshot"
                },
                {
                    GqlOperationName.restoreHypervVirtualMachineSnapshotFiles,
                    "Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFile"
                },
                {
                    GqlOperationName.restoreMssqlDatabase,
                    "Invoke-RscMutateMssql -RestoreDatabase"
                },
                {
                    GqlOperationName.restoreO365Mailbox,
                    "Invoke-RscMutateO365 -RestoreMailbox"
                },
                {
                    GqlOperationName.restoreO365Snappable,
                    "Invoke-RscMutateO365 -RestoreSnappable"
                },
                {
                    GqlOperationName.restoreO365TeamsConversations,
                    "Invoke-RscMutateO365 -RestoreTeamsConversation"
                },
                {
                    GqlOperationName.restoreO365TeamsFiles,
                    "Invoke-RscMutateO365 -RestoreTeamsFile"
                },
                {
                    GqlOperationName.restoreOracleLogs,
                    "Invoke-RscMutateOracle -RestoreLog"
                },
                {
                    GqlOperationName.retryAddMongoSource,
                    "Invoke-RscMutateMongo -RetryAddSource"
                },
                {
                    GqlOperationName.searchNutanixVm,
                    "Invoke-RscQueryNutanix -SearchVm"
                },
                {
                    GqlOperationName.setAzureCloudAccountCustomerAppCredentials,
                    "Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredential"
                },
                {
                    GqlOperationName.setLdapMfaSetting,
                    "Invoke-RscMutateLdap -SetMfaSetting"
                },
                {
                    GqlOperationName.setO365ServiceAccount,
                    "Invoke-RscMutateO365 -SetServiceAccount"
                },
                {
                    GqlOperationName.setupAzureO365Exocompute,
                    "Invoke-RscMutateAzureO365 -SetupExocompute"
                },
                {
                    GqlOperationName.slaArchivalValidationWarnings,
                    "Invoke-RscQuerySla -ArchivalValidationWarning"
                },
                {
                    GqlOperationName.slaAuditDetail,
                    "Invoke-RscQuerySla -AuditDetail"
                },
                {
                    GqlOperationName.slaConflictObjects,
                    "Invoke-RscQuerySla -ConflictObject"
                },
                {
                    GqlOperationName.slaDomainWithWarnings,
                    "Invoke-RscQuerySla -DomainWithWarning"
                },
                {
                    GqlOperationName.slaDomainWithWarningsList,
                    "Invoke-RscQuerySla -DomainWithWarningsList"
                },
                {
                    GqlOperationName.slaDomains,
                    "Invoke-RscQuerySla -Domain"
                },
                {
                    GqlOperationName.slaManagedVolumes,
                    "Invoke-RscQuerySla -ManagedVolume"
                },
                {
                    GqlOperationName.slaSummariesByIds,
                    "Invoke-RscQuerySla -SummariesById"
                },
                {
                    GqlOperationName.startAwsExocomputeDisableJob,
                    "Invoke-RscMutateAws -StartExocomputeDisableJob"
                },
                {
                    GqlOperationName.startAwsNativeAccountDisableJob,
                    "Invoke-RscMutateAws -StartNativeAccountDisableJob"
                },
                {
                    GqlOperationName.startAwsNativeEc2InstanceSnapshotsJob,
                    "Invoke-RscMutateAws -StartNativeEc2InstanceSnapshotsJob"
                },
                {
                    GqlOperationName.startAwsNativeRdsInstanceSnapshotsJob,
                    "Invoke-RscMutateAws -StartNativeRdsInstanceSnapshotsJob"
                },
                {
                    GqlOperationName.startAzureCloudAccountOauth,
                    "Invoke-RscMutateAzure -StartCloudAccountOauth"
                },
                {
                    GqlOperationName.startCreateAwsNativeEbsVolumeSnapshotsJob,
                    "Invoke-RscMutateAws -StartCreateNativeEbsVolumeSnapshotsJob"
                },
                {
                    GqlOperationName.startCreateAzureNativeManagedDiskSnapshotsJob,
                    "Invoke-RscMutateAzure -StartCreateNativeManagedDiskSnapshotsJob"
                },
                {
                    GqlOperationName.startCreateAzureNativeVirtualMachineSnapshotsJob,
                    "Invoke-RscMutateAzure -StartCreateNativeVirtualMachineSnapshotsJob"
                },
                {
                    GqlOperationName.startDisableAzureCloudAccountJob,
                    "Invoke-RscMutateAzure -StartDisableCloudAccountJob"
                },
                {
                    GqlOperationName.startDisableAzureNativeSubscriptionProtectionJob,
                    "Invoke-RscMutateAzure -StartDisableNativeSubscriptionProtectionJob"
                },
                {
                    GqlOperationName.startExportAwsNativeEbsVolumeSnapshotJob,
                    "Invoke-RscMutateAws -StartExportNativeEbsVolumeSnapshotJob"
                },
                {
                    GqlOperationName.startExportAzureNativeManagedDiskJob,
                    "Invoke-RscMutateAzure -StartExportNativeManagedDiskJob"
                },
                {
                    GqlOperationName.startExportAzureNativeVirtualMachineJob,
                    "Invoke-RscMutateAzure -StartExportNativeVirtualMachineJob"
                },
                {
                    GqlOperationName.startExportAzureSqlDatabaseDbJob,
                    "Invoke-RscMutateAzure -StartExportSqlDatabaseDbJob"
                },
                {
                    GqlOperationName.startExportAzureSqlManagedInstanceDbJob,
                    "Invoke-RscMutateAzure -StartExportSqlManagedInstanceDbJob"
                },
                {
                    GqlOperationName.startRefreshAwsNativeAccountsJob,
                    "Invoke-RscMutateAws -StartRefreshNativeAccountsJob"
                },
                {
                    GqlOperationName.startRefreshAzureNativeSubscriptionsJob,
                    "Invoke-RscMutateAzure -StartRefreshNativeSubscriptionsJob"
                },
                {
                    GqlOperationName.startRestoreAwsNativeEc2InstanceSnapshotJob,
                    "Invoke-RscMutateAws -StartRestoreNativeEc2InstanceSnapshotJob"
                },
                {
                    GqlOperationName.startRestoreAzureNativeVirtualMachineJob,
                    "Invoke-RscMutateAzure -StartRestoreNativeVirtualMachineJob"
                },
                {
                    GqlOperationName.takeMssqlLogBackup,
                    "Invoke-RscMutateMssql -TakeLogBackup"
                },
                {
                    GqlOperationName.takeOnDemandOracleDatabaseSnapshot,
                    "Invoke-RscMutateOracle -TakeOnDemandDatabaseSnapshot"
                },
                {
                    GqlOperationName.takeOnDemandOracleLogSnapshot,
                    "Invoke-RscMutateOracle -TakeOnDemandLogSnapshot"
                },
                {
                    GqlOperationName.uniqueHypervServersCount,
                    "Invoke-RscQueryHyperv -UniqueServersCount"
                },
                {
                    GqlOperationName.uniqueVSphereVCenterCount,
                    "Invoke-RscQueryVcenter -UniqueCount"
                },
                {
                    GqlOperationName.unmapAzureCloudAccountExocomputeSubscription,
                    "Invoke-RscMutateAzure -UnmapCloudAccountExocomputeSubscription"
                },
                {
                    GqlOperationName.updateAutomaticAwsTargetMapping,
                    "Invoke-RscMutateAws -UpdateAutomaticTargetMapping"
                },
                {
                    GqlOperationName.updateAutomaticAzureTargetMapping,
                    "Invoke-RscMutateAzure -UpdateAutomaticTargetMapping"
                },
                {
                    GqlOperationName.updateAwsAccount,
                    "Invoke-RscMutateAws -UpdateAccount"
                },
                {
                    GqlOperationName.updateAwsCloudAccount,
                    "Invoke-RscMutateAws -UpdateCloudAccount"
                },
                {
                    GqlOperationName.updateAwsCloudAccountFeature,
                    "Invoke-RscMutateAws -UpdateCloudAccountFeature"
                },
                {
                    GqlOperationName.updateAwsComputeSetting,
                    "Invoke-RscMutateAws -UpdateComputeSetting"
                },
                {
                    GqlOperationName.updateAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -UpdateExocomputeConfig"
                },
                {
                    GqlOperationName.updateAwsTarget,
                    "Invoke-RscMutateAws -UpdateTarget"
                },
                {
                    GqlOperationName.updateAzureAccount,
                    "Invoke-RscMutateAzure -UpdateAccount"
                },
                {
                    GqlOperationName.updateAzureCloudAccount,
                    "Invoke-RscMutateAzure -UpdateCloudAccount"
                },
                {
                    GqlOperationName.updateAzureTarget,
                    "Invoke-RscMutateAzure -UpdateTarget"
                },
                {
                    GqlOperationName.updateCassandraSource,
                    "Invoke-RscMutateCassandra -UpdateSource"
                },
                {
                    GqlOperationName.updateCloudNativeAwsStorageSetting,
                    "Invoke-RscMutateAws -UpdateCloudNativeStorageSetting"
                },
                {
                    GqlOperationName.updateCloudNativeAzureStorageSetting,
                    "Invoke-RscMutateAzure -UpdateCloudNativeStorageSetting"
                },
                {
                    GqlOperationName.updateCloudNativeRcvAzureStorageSetting,
                    "Invoke-RscMutateAzure -UpdateCloudNativeRcvStorageSetting"
                },
                {
                    GqlOperationName.updateCustomerAppPermissionForAzureSql,
                    "Invoke-RscMutateAzure -UpdateCustomerAppPermissionForSql"
                },
                {
                    GqlOperationName.updateFailoverCluster,
                    "Invoke-RscMutateCluster -UpdateFailover"
                },
                {
                    GqlOperationName.updateGlobalSla,
                    "Invoke-RscMutateSla -UpdateGlobal"
                },
                {
                    GqlOperationName.updateHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -UpdateVirtualMachine"
                },
                {
                    GqlOperationName.updateHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -UpdateVirtualMachineSnapshotMount"
                },
                {
                    GqlOperationName.updateLdapIntegration,
                    "Invoke-RscMutateLdap -UpdateIntegration"
                },
                {
                    GqlOperationName.updateMongodbSource,
                    "Invoke-RscMutateMongo -UpdatedbSource"
                },
                {
                    GqlOperationName.updateMssqlDefaultProperties,
                    "Invoke-RscMutateMssql -UpdateDefaultPropertie"
                },
                {
                    GqlOperationName.updateMssqlLogShippingConfiguration,
                    "Invoke-RscMutateMssql -UpdateLogShippingConfiguration"
                },
                {
                    GqlOperationName.updateNutanixCluster,
                    "Invoke-RscMutateNutanix -UpdateCluster"
                },
                {
                    GqlOperationName.updateNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -UpdatePrismCentral"
                },
                {
                    GqlOperationName.updateNutanixVm,
                    "Invoke-RscMutateNutanix -UpdateVm"
                },
                {
                    GqlOperationName.updateO365AppAuthStatus,
                    "Invoke-RscMutateO365 -UpdateAppAuthStatus"
                },
                {
                    GqlOperationName.updateO365AppPermissions,
                    "Invoke-RscMutateO365 -UpdateAppPermission"
                },
                {
                    GqlOperationName.updateO365OrgCustomName,
                    "Invoke-RscMutateO365 -UpdateOrgCustomName"
                },
                {
                    GqlOperationName.updateOracleDataGuardGroup,
                    "Invoke-RscMutateOracle -UpdateDataGuardGroup"
                },
                {
                    GqlOperationName.updateVcenter,
                    "Invoke-RscMutateVcenter -Update"
                },
                {
                    GqlOperationName.updateVcenterHotAddBandwidth,
                    "Invoke-RscMutateVcenter -UpdateHotAddBandwidth"
                },
                {
                    GqlOperationName.updateVcenterHotAddNetwork,
                    "Invoke-RscMutateVcenter -UpdateHotAddNetwork"
                },
                {
                    GqlOperationName.updateVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -UpdateAdvancedTag"
                },
                {
                    GqlOperationName.upgradeAwsCloudAccountFeaturesWithoutCft,
                    "Invoke-RscMutateAws -UpgradeCloudAccountFeaturesWithoutCft"
                },
                {
                    GqlOperationName.upgradeAwsIamUserBasedCloudAccountPermissions,
                    "Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermission"
                },
                {
                    GqlOperationName.upgradeAzureCloudAccount,
                    "Invoke-RscMutateAzure -UpgradeCloudAccount"
                },
                {
                    GqlOperationName.upgradeAzureCloudAccountPermissionsWithoutOauth,
                    "Invoke-RscMutateAzure -UpgradeCloudAccountPermissionsWithoutOauth"
                },
                {
                    GqlOperationName.upgradeSlas,
                    "Invoke-RscMutateSla -Upgrade"
                },
                {
                    GqlOperationName.vCenterAdvancedTagPreview,
                    "Invoke-RscQueryVcenter -AdvancedTagPreview"
                },
                {
                    GqlOperationName.vCenterHotAddBandwidth,
                    "Invoke-RscQueryVcenter -HotAddBandwidth"
                },
                {
                    GqlOperationName.vCenterHotAddNetwork,
                    "Invoke-RscQueryVcenter -HotAddNetwork"
                },
                {
                    GqlOperationName.vCenterNetworks,
                    "Invoke-RscQueryVcenter -Network"
                },
                {
                    GqlOperationName.vCenterNumProxiesNeeded,
                    "Invoke-RscQueryVcenter -NumProxiesNeeded"
                },
                {
                    GqlOperationName.vCenterPreAddInfo,
                    "Invoke-RscQueryVcenter -PreAddInfo"
                },
                {
                    GqlOperationName.vSphereBlueprint,
                    "Invoke-RscQueryVsphere -Blueprint"
                },
                {
                    GqlOperationName.vSphereComputeCluster,
                    "Invoke-RscQueryVsphere -ComputeCluster"
                },
                {
                    GqlOperationName.vSphereDatacenter,
                    "Invoke-RscQueryVsphere -Datacenter"
                },
                {
                    GqlOperationName.vSphereDatastore,
                    "Invoke-RscQueryVsphere -Datastore"
                },
                {
                    GqlOperationName.vSphereDatastoreCluster,
                    "Invoke-RscQueryVsphere -DatastoreCluster"
                },
                {
                    GqlOperationName.vSphereDatastoreConnection,
                    "Invoke-RscQueryVsphere -DatastoreList"
                },
                {
                    GqlOperationName.vSphereFolder,
                    "Invoke-RscQueryVsphere -Folder"
                },
                {
                    GqlOperationName.vSphereHost,
                    "Invoke-RscQueryVsphere -Host"
                },
                {
                    GqlOperationName.vSphereHostConnection,
                    "Invoke-RscQueryVsphere -HostList"
                },
                {
                    GqlOperationName.vSphereHostDetails,
                    "Invoke-RscQueryVsphere -HostDetail"
                },
                {
                    GqlOperationName.vSphereHostsByFids,
                    "Invoke-RscQueryVsphere -HostsByFid"
                },
                {
                    GqlOperationName.vSphereLiveMounts,
                    "Invoke-RscQueryVsphere -LiveMount"
                },
                {
                    GqlOperationName.vSphereMount,
                    "Invoke-RscQueryVsphere -Mount"
                },
                {
                    GqlOperationName.vSphereMountConnection,
                    "Invoke-RscQueryVsphere -MountList"
                },
                {
                    GqlOperationName.vSphereNetwork,
                    "Invoke-RscQueryVsphere -Network"
                },
                {
                    GqlOperationName.vSphereResourcePool,
                    "Invoke-RscQueryVsphere -ResourcePool"
                },
                {
                    GqlOperationName.vSphereRootRecoveryHierarchy,
                    "Invoke-RscQueryVsphere -RootRecoveryHierarchy"
                },
                {
                    GqlOperationName.vSphereTag,
                    "Invoke-RscQueryVsphere -Tag"
                },
                {
                    GqlOperationName.vSphereTagCategory,
                    "Invoke-RscQueryVsphere -TagCategory"
                },
                {
                    GqlOperationName.vSphereTopLevelDescendantsConnection,
                    "Invoke-RscQueryVsphere -TopLevelDescendantsList"
                },
                {
                    GqlOperationName.vSphereVCenter,
                    "Invoke-RscQueryVcenter -Vcenter"
                },
                {
                    GqlOperationName.vSphereVCenterConnection,
                    "Invoke-RscQueryVcenter -List"
                },
                {
                    GqlOperationName.vSphereVMAsyncRequestStatus,
                    "Invoke-RscQueryVsphereVm -AsyncRequestStatus"
                },
                {
                    GqlOperationName.vSphereVMBatchLiveMount,
                    "Invoke-RscMutateVsphereVm -BatchLiveMount"
                },
                {
                    GqlOperationName.vSphereVmNew,
                    "Invoke-RscQueryVsphereVm -New"
                },
                {
                    GqlOperationName.vSphereVmNewConnection,
                    "Invoke-RscQueryVsphereVm -NewList"
                },
                {
                    GqlOperationName.validateAndCreateAwsCloudAccount,
                    "Invoke-RscMutateAws -ValidateAndCreateCloudAccount"
                },
                {
                    GqlOperationName.validateAwsNativeRdsClusterNameForExport,
                    "Invoke-RscQueryAws -ValidateNativeRdsClusterNameForExport"
                },
                {
                    GqlOperationName.validateAwsNativeRdsInstanceNameForExport,
                    "Invoke-RscQueryAws -ValidateNativeRdsInstanceNameForExport"
                },
                {
                    GqlOperationName.validateAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfiguration"
                },
                {
                    GqlOperationName.validateAzureNativeSqlDatabaseDbNameForExport,
                    "Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport"
                },
                {
                    GqlOperationName.validateAzureNativeSqlManagedInstanceDbNameForExport,
                    "Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport"
                },
                {
                    GqlOperationName.validateOracleAcoFile,
                    "Invoke-RscMutateOracle -ValidateAcoFile"
                },
                {
                    GqlOperationName.validateOracleDatabaseBackups,
                    "Invoke-RscMutateOracle -ValidateDatabaseBackup"
                },
                {
                    GqlOperationName.vcdClusters,
                    "Invoke-RscQueryCluster -Vcd"
                },
                {
                    GqlOperationName.verifySLAWithReplicationToCluster,
                    "Invoke-RscQuerySla -VerifyWithReplicationToCluster"
                },
                {
                    GqlOperationName.vsphereBulkOnDemandSnapshot,
                    "Invoke-RscMutateVsphere -BulkOnDemandSnapshot"
                },
                {
                    GqlOperationName.vsphereCreateVCenter,
                    "Invoke-RscMutateVcenter -Create"
                },
                {
                    GqlOperationName.vsphereDeleteVcenter,
                    "Invoke-RscMutateVcenter -Delete"
                },
                {
                    GqlOperationName.vsphereEditVCenter,
                    "Invoke-RscMutateVcenter -Edit"
                },
                {
                    GqlOperationName.vsphereExcludeVmDisks,
                    "Invoke-RscMutateVsphereVm -ExcludeVmDisk"
                },
                {
                    GqlOperationName.vsphereExportSnapshotToStandaloneHost,
                    "Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHost"
                },
                {
                    GqlOperationName.vsphereExportSnapshotToStandaloneHostV2,
                    "Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2"
                },
                {
                    GqlOperationName.vsphereOnDemandSnapshot,
                    "Invoke-RscMutateVsphere -OnDemandSnapshot"
                },
                {
                    GqlOperationName.vsphereRefreshVCenter,
                    "Invoke-RscMutateVcenter -Refresh"
                },
                {
                    GqlOperationName.vsphereVMDeleteLiveMount,
                    "Invoke-RscMutateVsphereVm -DeleteLiveMount"
                },
                {
                    GqlOperationName.vsphereVMExportSnapshot,
                    "Invoke-RscMutateVsphereVm -ExportSnapshot"
                },
                {
                    GqlOperationName.vsphereVMInitiateInstantRecovery,
                    "Invoke-RscMutateVsphereVm -InitiateInstantRecovery"
                },
                {
                    GqlOperationName.vsphereVMInitiateLiveMount,
                    "Invoke-RscMutateVsphereVm -InitiateLiveMount"
                },
                {
                    GqlOperationName.vsphereVMMissedRecoverableRange,
                    "Invoke-RscQueryVsphereVm -MissedRecoverableRange"
                },
                {
                    GqlOperationName.vsphereVMRecoverableRange,
                    "Invoke-RscQueryVsphereVm -RecoverableRange"
                },
                {
                    GqlOperationName.vsphereVMRecoverableRangeInBatch,
                    "Invoke-RscQueryVsphereVm -RecoverableRangeInBatch"
                },
                {
                    GqlOperationName.vsphereVMUpdate,
                    "Invoke-RscMutateVsphereVm -Update"
                },
                {
                    GqlOperationName.vsphereVmBatchExport,
                    "Invoke-RscMutateVsphereVm -BatchExport"
                },
                {
                    GqlOperationName.vsphereVmBatchExportV3,
                    "Invoke-RscMutateVsphereVm -BatchExportV3"
                },
                {
                    GqlOperationName.vsphereVmBatchInPlaceRecovery,
                    "Invoke-RscMutateVsphereVm -BatchInPlaceRecovery"
                },
                {
                    GqlOperationName.vsphereVmDeleteSnapshot,
                    "Invoke-RscMutateVsphereVm -DeleteSnapshot"
                },
                {
                    GqlOperationName.vsphereVmDownloadSnapshot,
                    "Invoke-RscMutateVsphereVm -DownloadSnapshot"
                },
                {
                    GqlOperationName.vsphereVmDownloadSnapshotFiles,
                    "Invoke-RscMutateVsphereVm -DownloadSnapshotFile"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotV2,
                    "Invoke-RscMutateVsphereVm -ExportSnapshotV2"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotV3,
                    "Invoke-RscMutateVsphereVm -ExportSnapshotV3"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotWithDownloadFromCloud,
                    "Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud"
                },
                {
                    GqlOperationName.vsphereVmInitiateBatchInstantRecovery,
                    "Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery"
                },
                {
                    GqlOperationName.vsphereVmInitiateBatchLiveMountV2,
                    "Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2"
                },
                {
                    GqlOperationName.vsphereVmInitiateDiskMount,
                    "Invoke-RscMutateVsphereVm -InitiateDiskMount"
                },
                {
                    GqlOperationName.vsphereVmInitiateInPlaceRecovery,
                    "Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery"
                },
                {
                    GqlOperationName.vsphereVmInitiateInstantRecoveryV2,
                    "Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2"
                },
                {
                    GqlOperationName.vsphereVmInitiateLiveMountV2,
                    "Invoke-RscMutateVsphereVm -InitiateLiveMountV2"
                },
                {
                    GqlOperationName.vsphereVmListEsxiDatastores,
                    "Invoke-RscMutateVsphereVm -ListEsxiDatastore"
                },
                {
                    GqlOperationName.vsphereVmMountRelocate,
                    "Invoke-RscMutateVsphereVm -MountRelocate"
                },
                {
                    GqlOperationName.vsphereVmMountRelocateV2,
                    "Invoke-RscMutateVsphereVm -MountRelocateV2"
                },
                {
                    GqlOperationName.vsphereVmPowerOnOffLiveMount,
                    "Invoke-RscMutateVsphereVm -PowerOnOffLiveMount"
                },
                {
                    GqlOperationName.vsphereVmRecoverFiles,
                    "Invoke-RscMutateVsphereVm -RecoverFile"
                },
                {
                    GqlOperationName.vsphereVmRecoverFilesNew,
                    "Invoke-RscMutateVsphereVm -RecoverFilesNew"
                },
                {
                    GqlOperationName.vsphereVmRegisterAgent,
                    "Invoke-RscMutateVsphereVm -RegisterAgent"
                },
                {
                    GqlOperationName.vsphereVmwareCdpLiveInfo,
                    "Invoke-RscQueryVsphere -VmwareCdpLiveInfo"
                },
                {
                    GqlOperationName.windowsCluster,
                    "Invoke-RscQueryCluster -Window"
                },
            };
            if (OperationLookupDict.TryGetValue(gqlOpName, out var cmdName))
            {
                return cmdName;
            }
            return "Invoke-Rsc -Op " + gqlOpName;
        }
    }
}