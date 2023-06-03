// SchemaMeta.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

using System;
using System.Collections;
using System.Collections.Generic;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    public static class SchemaMeta
    {
        public static string GraphqlSchemaVersion = "v20230524-16" ;

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
                    "AwsNativeHierarchyObject",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AzureNativeHierarchyObjectType",
                    new HashSet<string> {
                    "AzureNativeHierarchyObjectType",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    }
                },
                {
                    "BlueprintChild",
                    new HashSet<string> {
                    "BlueprintChild",
                    }
                },
                {
                    "CassandraKeyspaceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    "CassandraKeyspaceDescendantType",
                    }
                },
                {
                    "CassandraKeyspacePhysicalChildType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    "CassandraKeyspacePhysicalChildType",
                    }
                },
                {
                    "CassandraSourceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    "CassandraSourceDescendantType",
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
                    "CloudAccount",
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
                    "DisplayableValue",
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
                    "FailoverClusterTopLevelDescendantType",
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
                    "GcpNativeProjectLogicalChildType",
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
                    "HostFailoverClusterDescendantType",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "HostFailoverClusterPhysicalChildType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "HostFailoverClusterPhysicalChildType",
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
                    "HypervTopLevelDescendantType",
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
                    "MongoDatabaseDescendantType",
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
                    "MongodbDatabaseDescendantType",
                    }
                },
                {
                    "MongodbDatabasePhysicalChildType",
                    new HashSet<string> {
                    "MongodbCollection",
                    "MongodbDatabasePhysicalChildType",
                    }
                },
                {
                    "MongodbSourceDescendantType",
                    new HashSet<string> {
                    "MongodbCollection",
                    "MongodbDatabase",
                    "MongodbSourceDescendantType",
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
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlAvailabilityGroupLogicalChildType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlInstanceDescendantType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlInstanceLogicalChildType",
                    new HashSet<string> {
                    "MssqlDatabase",
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
                    }
                },
                {
                    "NasShareLogicalChildType",
                    new HashSet<string> {
                    "NasFileset",
                    }
                },
                {
                    "NasSystemDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasSystemDescendantType",
                    "NasVolume",
                    "SnapMirrorCloud",
                    }
                },
                {
                    "NasSystemLogicalChildType",
                    new HashSet<string> {
                    "NasNamespace",
                    "NasShare",
                    "NasSystemLogicalChildType",
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
                    "NutanixTopLevelDescendantType",
                    new HashSet<string> {
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    "NutanixTopLevelDescendantType",
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
                    "O365ExchangeObject",
                    }
                },
                {
                    "O365FullSpObject",
                    new HashSet<string> {
                    "O365FullSpObject",
                    }
                },
                {
                    "O365OnedriveObject",
                    new HashSet<string> {
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
                    "O365UserDescendant",
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
                    }
                },
                {
                    "OracleDataGuardGroupLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
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
                    "OracleTopLevelDescendantType",
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
                    "ProtectedObjectSummary",
                    new HashSet<string> {
                    "ProtectedObjects",
                    }
                },
                {
                    "RecoverySpec",
                    new HashSet<string> {
                    "RecoverySpec",
                    }
                },
                {
                    "RequestedChangesTemplate",
                    new HashSet<string> {
                    "RequestedChangesTemplate",
                    }
                },
                {
                    "ResourceSpec",
                    new HashSet<string> {
                    "ResourceSpec",
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
                    "Target",
                    }
                },
                {
                    "Value",
                    new HashSet<string> {
                    "Value",
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
    }
}