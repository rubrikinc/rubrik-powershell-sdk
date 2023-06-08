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
        public static string GraphqlSchemaVersion = "v20230531-17" ;

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
            allObjectsLatestUserNoteAudit,
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
                    "Invoke-RscQueryAws -Cloudaccountlistkmskey"
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
                    "Invoke-RscQueryActivitySeries -Groupbyconnection"
                },
                {
                    GqlOperationName.addAwsAuthenticationServerBasedCloudAccount,
                    "Invoke-RscMutateAws -Addauthenticationserverbasedcloudaccount"
                },
                {
                    GqlOperationName.addAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -Addiamuserbasedcloudaccount"
                },
                {
                    GqlOperationName.addAzureCloudAccount,
                    "Invoke-RscMutateAzure -Addcloudaccount"
                },
                {
                    GqlOperationName.addAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscMutateAzure -Addcloudaccountexocomputeconfiguration"
                },
                {
                    GqlOperationName.addAzureCloudAccountWithoutOauth,
                    "Invoke-RscMutateAzure -Addcloudaccountwithoutoauth"
                },
                {
                    GqlOperationName.addMongoSource,
                    "Invoke-RscMutateMongo -Addsource"
                },
                {
                    GqlOperationName.addNodesToCloudCluster,
                    "Invoke-RscMutateCluster -Addnodestocloud"
                },
                {
                    GqlOperationName.addO365Org,
                    "Invoke-RscMutateO365 -Addorg"
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
                    "Invoke-RscQueryAccount -Swithexocomputemapping"
                },
                {
                    GqlOperationName.allAvailabilityZonesByRegionFromAws,
                    "Invoke-RscQueryAws -Allavailabilityzonesbyregion"
                },
                {
                    GqlOperationName.allAwsCdmVersions,
                    "Invoke-RscQueryAws -Allcdmversion"
                },
                {
                    GqlOperationName.allAwsCloudAccountConfigs,
                    "Invoke-RscQueryAws -Allcloudaccountconfig"
                },
                {
                    GqlOperationName.allAwsCloudAccountsFeaturesWithExoConfigs,
                    "Invoke-RscQueryAws -Allcloudaccountsfeatureswithexoconfig"
                },
                {
                    GqlOperationName.allAwsCloudAccountsWithFeatures,
                    "Invoke-RscQueryAws -Allcloudaccountswithfeature"
                },
                {
                    GqlOperationName.allAwsComputeSettings,
                    "Invoke-RscQueryAws -Allcomputesetting"
                },
                {
                    GqlOperationName.allAwsExocomputeConfigs,
                    "Invoke-RscQueryAws -Allexocomputeconfig"
                },
                {
                    GqlOperationName.allAwsInstanceProfileNames,
                    "Invoke-RscQueryAws -Allinstanceprofilename"
                },
                {
                    GqlOperationName.allAwsRdsAuroraInstanceClasses,
                    "Invoke-RscQueryAws -Allrdsaurorainstanceclass"
                },
                {
                    GqlOperationName.allAwsRegions,
                    "Invoke-RscQueryAws -Allregion"
                },
                {
                    GqlOperationName.allAzureArmTemplatesByFeature,
                    "Invoke-RscQueryAzure -Allarmtemplatesbyfeature"
                },
                {
                    GqlOperationName.allAzureCdmVersions,
                    "Invoke-RscQueryAzure -Allcdmversion"
                },
                {
                    GqlOperationName.allAzureCloudAccountMissingPermissions,
                    "Invoke-RscQueryAzure -Allcloudaccountmissingpermission"
                },
                {
                    GqlOperationName.allAzureCloudAccountSubnetsByRegion,
                    "Invoke-RscQueryAzure -Allcloudaccountsubnetsbyregion"
                },
                {
                    GqlOperationName.allAzureCloudAccountSubscriptionsByFeature,
                    "Invoke-RscQueryAzure -Allcloudaccountsubscriptionsbyfeature"
                },
                {
                    GqlOperationName.allAzureCloudAccountTenants,
                    "Invoke-RscQueryAzure -Allcloudaccounttenant"
                },
                {
                    GqlOperationName.allAzureDiskEncryptionSetsByRegion,
                    "Invoke-RscQueryAzure -Alldiskencryptionsetsbyregion"
                },
                {
                    GqlOperationName.allAzureEncryptionKeys,
                    "Invoke-RscQueryAzure -Allencryptionkey"
                },
                {
                    GqlOperationName.allAzureExocomputeConfigsInAccount,
                    "Invoke-RscQueryAzure -Allexocomputeconfigsinaccount"
                },
                {
                    GqlOperationName.allAzureKeyVaultsByRegion,
                    "Invoke-RscQueryAzure -Allkeyvaultsbyregion"
                },
                {
                    GqlOperationName.allAzureNativeAvailabilitySetsByRegionFromAzure,
                    "Invoke-RscQueryAzure -Allnativeavailabilitysetsbyregionfromazure"
                },
                {
                    GqlOperationName.allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
                    "Invoke-RscQueryAzure -Allnativeexportcompatibledisktypesbyregionfromazure"
                },
                {
                    GqlOperationName.allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
                    "Invoke-RscQueryAzure -Allnativeexportcompatiblevmsizesbyregionfromazure"
                },
                {
                    GqlOperationName.allAzureNativeResourceGroupsInfoIfExist,
                    "Invoke-RscQueryAzure -Allnativeresourcegroupsinfoifexist"
                },
                {
                    GqlOperationName.allAzureNativeSecurityGroupsByRegionFromAzure,
                    "Invoke-RscQueryAzure -Allnativesecuritygroupsbyregionfromazure"
                },
                {
                    GqlOperationName.allAzureNativeStorageAccountsFromAzure,
                    "Invoke-RscQueryAzure -Allnativestorageaccountsfromazure"
                },
                {
                    GqlOperationName.allAzureNativeSubnetsByRegionFromAzure,
                    "Invoke-RscQueryAzure -Allnativesubnetsbyregionfromazure"
                },
                {
                    GqlOperationName.allAzureNativeVirtualMachineSizes,
                    "Invoke-RscQueryAzure -Allnativevirtualmachinesize"
                },
                {
                    GqlOperationName.allAzureNativeVirtualNetworks,
                    "Invoke-RscQueryAzure -Allnativevirtualnetwork"
                },
                {
                    GqlOperationName.allAzureNsgs,
                    "Invoke-RscQueryAzure -Allnsg"
                },
                {
                    GqlOperationName.allAzureRegions,
                    "Invoke-RscQueryAzure -Allregion"
                },
                {
                    GqlOperationName.allAzureResourceGroups,
                    "Invoke-RscQueryAzure -Allresourcegroup"
                },
                {
                    GqlOperationName.allAzureSqlDatabaseServerElasticPools,
                    "Invoke-RscQueryAzure -Allsqldatabaseserverelasticpool"
                },
                {
                    GqlOperationName.allAzureStorageAccounts,
                    "Invoke-RscQueryAzure -Allstorageaccount"
                },
                {
                    GqlOperationName.allAzureSubnets,
                    "Invoke-RscQueryAzure -Allsubnet"
                },
                {
                    GqlOperationName.allAzureSubscriptionWithExocomputeMappings,
                    "Invoke-RscQueryAzure -Allsubscriptionwithexocomputemapping"
                },
                {
                    GqlOperationName.allAzureVnets,
                    "Invoke-RscQueryAzure -Allvnet"
                },
                {
                    GqlOperationName.allCdpSlaVmNames,
                    "Invoke-RscQuerySla -Allcdpvmname"
                },
                {
                    GqlOperationName.allCloudClusters,
                    "Invoke-RscQueryCluster -Cloud"
                },
                {
                    GqlOperationName.allClusterGlobalSlas,
                    "Invoke-RscQuerySla -Allclusterglobal"
                },
                {
                    GqlOperationName.allClusterReplicationTargets,
                    "Invoke-RscQueryCluster -Replicationtarget"
                },
                {
                    GqlOperationName.allClusterWebCertsAndIpmis,
                    "Invoke-RscQueryCluster -Webcertsandipmi"
                },
                {
                    GqlOperationName.allClustersTotpAckStatus,
                    "Invoke-RscQueryCluster -Totpackstatus"
                },
                {
                    GqlOperationName.allConnectedClusters,
                    "Invoke-RscQueryCluster -Connected"
                },
                {
                    GqlOperationName.allDbParameterGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -Alldbparametergroupsbyregion"
                },
                {
                    GqlOperationName.allDbSubnetGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -Alldbsubnetgroupsbyregion"
                },
                {
                    GqlOperationName.allEc2KeyPairsByRegionFromAws,
                    "Invoke-RscQueryAws -Allec2keypairsbyregion"
                },
                {
                    GqlOperationName.allGlobalFileSearchMultipleClusters,
                    "Invoke-RscQueryCluster -Globalfilesearchmultiple"
                },
                {
                    GqlOperationName.allHostedAzureRegions,
                    "Invoke-RscQueryAzure -Allhostedregion"
                },
                {
                    GqlOperationName.allKmsEncryptionKeysByRegionFromAws,
                    "Invoke-RscQueryAws -Allkmsencryptionkeysbyregion"
                },
                {
                    GqlOperationName.allMssqlDatabaseRestoreFiles,
                    "Invoke-RscQueryMssql -Alldatabaserestorefile"
                },
                {
                    GqlOperationName.allNcdSlaComplianceData,
                    "Invoke-RscQuerySla -Allncdcompliancedata"
                },
                {
                    GqlOperationName.allO365AdGroups,
                    "Invoke-RscQueryO365 -Alladgroup"
                },
                {
                    GqlOperationName.allO365OrgStatuses,
                    "Invoke-RscQueryO365 -Allorgstatus"
                },
                {
                    GqlOperationName.allO365SubscriptionsAppTypeCounts,
                    "Invoke-RscQueryO365 -Allsubscriptionsapptypecount"
                },
                {
                    GqlOperationName.allObjectsLatestUserNoteAudit,
                    "Invoke-RscQuerySla -Allobjecttestusernoteaudit"
                },
                {
                    GqlOperationName.allOptionGroupsByRegionFromAws,
                    "Invoke-RscQueryAws -Alloptiongroupsbyregion"
                },
                {
                    GqlOperationName.allResourceGroupsFromAzure,
                    "Invoke-RscQueryAzure -Allresourcegroupsfrom"
                },
                {
                    GqlOperationName.allS3BucketsDetailsFromAws,
                    "Invoke-RscQueryAws -Alls3bucketsdetail"
                },
                {
                    GqlOperationName.allS3BucketsFromAws,
                    "Invoke-RscQueryAws -Alls3bucket"
                },
                {
                    GqlOperationName.allSlaIofilterStatuses,
                    "Invoke-RscQuerySla -Alliofilterstatus"
                },
                {
                    GqlOperationName.allSupportedAwsRdsDatabaseInstanceClasses,
                    "Invoke-RscQueryAws -Allsupportedrdsdatabaseinstanceclass"
                },
                {
                    GqlOperationName.allVcenterHotAddProxyVms,
                    "Invoke-RscQueryVcenter -Hotaddproxy"
                },
                {
                    GqlOperationName.allVpcsByRegionFromAws,
                    "Invoke-RscQueryAws -Allvpcsbyregion"
                },
                {
                    GqlOperationName.allVpcsFromAws,
                    "Invoke-RscQueryAws -Allvpc"
                },
                {
                    GqlOperationName.amiTypeForAwsNativeArchivedSnapshotExport,
                    "Invoke-RscQueryAws -Amitypefornativearchivedsnapshotexport"
                },
                {
                    GqlOperationName.archiveK8sCluster,
                    "Invoke-RscMutateCluster -Archivek8s"
                },
                {
                    GqlOperationName.assignMssqlSlaDomainProperties,
                    "Invoke-RscMutateMssql -Assignsladomainpropertie"
                },
                {
                    GqlOperationName.assignMssqlSlaDomainPropertiesAsync,
                    "Invoke-RscMutateMssql -Assignsladomainpropertiesasync"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnappables,
                    "Invoke-RscMutateSla -Assignretentiontosnappable"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnapshots,
                    "Invoke-RscMutateSla -Assignretentiontosnapshot"
                },
                {
                    GqlOperationName.assignSla,
                    "Invoke-RscMutateSla -Assign"
                },
                {
                    GqlOperationName.assignSlaToMongoDbCollection,
                    "Invoke-RscMutateMongo -Assignslatodbcollection"
                },
                {
                    GqlOperationName.assignSlasForSnappableHierarchies,
                    "Invoke-RscMutateSla -Assignsforsnappablehierarchie"
                },
                {
                    GqlOperationName.awsCloudAccountInitiate,
                    "Invoke-RscMutateAws -Cloudaccountinitiate"
                },
                {
                    GqlOperationName.awsCloudAccountListSecurityGroups,
                    "Invoke-RscQueryAws -Cloudaccountlistsecuritygroup"
                },
                {
                    GqlOperationName.awsCloudAccountListSubnets,
                    "Invoke-RscQueryAws -Cloudaccountlistsubnet"
                },
                {
                    GqlOperationName.awsCloudAccountListVpcs,
                    "Invoke-RscQueryAws -Cloudaccountlistvpc"
                },
                {
                    GqlOperationName.awsCloudAccountUpdateFeature,
                    "Invoke-RscMutateAws -Cloudaccountupdatefeature"
                },
                {
                    GqlOperationName.awsCloudAccountValidate,
                    "Invoke-RscMutateAws -Cloudaccountvalidate"
                },
                {
                    GqlOperationName.awsCloudAccountWithFeatures,
                    "Invoke-RscQueryAws -Cloudaccountwithfeature"
                },
                {
                    GqlOperationName.awsComputeSettings,
                    "Invoke-RscQueryAws -Computesetting"
                },
                {
                    GqlOperationName.awsNativeAccount,
                    "Invoke-RscQueryAws -Nativeaccount"
                },
                {
                    GqlOperationName.awsNativeEbsVolume,
                    "Invoke-RscQueryAws -Nativeebsvolume"
                },
                {
                    GqlOperationName.awsNativeEbsVolumesByName,
                    "Invoke-RscQueryAws -Nativeebsvolumesbyname"
                },
                {
                    GqlOperationName.awsNativeEc2Instance,
                    "Invoke-RscQueryAws -Nativeec2instance"
                },
                {
                    GqlOperationName.awsNativeEc2InstancesByName,
                    "Invoke-RscQueryAws -Nativeec2instancesbyname"
                },
                {
                    GqlOperationName.awsNativeProtectionAccountAdd,
                    "Invoke-RscMutateAws -Nativeprotectionaccountadd"
                },
                {
                    GqlOperationName.awsNativeRdsExportDefaults,
                    "Invoke-RscQueryAws -Nativerdsexportdefault"
                },
                {
                    GqlOperationName.awsNativeRdsInstance,
                    "Invoke-RscQueryAws -Nativerdsinstance"
                },
                {
                    GqlOperationName.awsNativeRdsPointInTimeRestoreWindow,
                    "Invoke-RscQueryAws -Nativerdspointintimerestorewindow"
                },
                {
                    GqlOperationName.awsNativeRoot,
                    "Invoke-RscQueryAws -Nativeroot"
                },
                {
                    GqlOperationName.awsNativeS3Bucket,
                    "Invoke-RscQueryAws -Natives3bucket"
                },
                {
                    GqlOperationName.azureAdDirectories,
                    "Invoke-RscQueryAzure -Addirectorie"
                },
                {
                    GqlOperationName.azureAdDirectory,
                    "Invoke-RscQueryAzure -Addirectory"
                },
                {
                    GqlOperationName.azureCloudAccountPermissionConfig,
                    "Invoke-RscQueryAzure -Cloudaccountpermissionconfig"
                },
                {
                    GqlOperationName.azureCloudAccountSubscriptionWithFeatures,
                    "Invoke-RscQueryAzure -Cloudaccountsubscriptionwithfeature"
                },
                {
                    GqlOperationName.azureCloudAccountTenant,
                    "Invoke-RscQueryAzure -Cloudaccounttenant"
                },
                {
                    GqlOperationName.azureCloudAccountTenantWithExoConfigs,
                    "Invoke-RscQueryAzure -Cloudaccounttenantwithexoconfig"
                },
                {
                    GqlOperationName.azureNativeManagedDisk,
                    "Invoke-RscQueryAzure -Nativemanageddisk"
                },
                {
                    GqlOperationName.azureNativeResourceGroup,
                    "Invoke-RscQueryAzure -Nativeresourcegroup"
                },
                {
                    GqlOperationName.azureNativeRoot,
                    "Invoke-RscQueryAzure -Nativeroot"
                },
                {
                    GqlOperationName.azureNativeSubscription,
                    "Invoke-RscQueryAzure -Nativesubscription"
                },
                {
                    GqlOperationName.azureNativeVirtualMachine,
                    "Invoke-RscQueryAzure -Nativevirtualmachine"
                },
                {
                    GqlOperationName.azureO365CheckNSGOutboundRules,
                    "Invoke-RscQueryAzureO365 -Checknsgoutboundrule"
                },
                {
                    GqlOperationName.azureO365CheckNetworkSubnet,
                    "Invoke-RscQueryAzureO365 -Checknetworksubnet"
                },
                {
                    GqlOperationName.azureO365CheckResourceGroupName,
                    "Invoke-RscQueryAzureO365 -Checkresourcegroupname"
                },
                {
                    GqlOperationName.azureO365CheckStorageAccountAccessibility,
                    "Invoke-RscQueryAzureO365 -Checkstorageaccountaccessibility"
                },
                {
                    GqlOperationName.azureO365CheckStorageAccountName,
                    "Invoke-RscQueryAzureO365 -Checkstorageaccountname"
                },
                {
                    GqlOperationName.azureO365CheckSubscriptionQuota,
                    "Invoke-RscQueryAzureO365 -Checksubscriptionquota"
                },
                {
                    GqlOperationName.azureO365CheckVirtualNetworkName,
                    "Invoke-RscQueryAzureO365 -Checkvirtualnetworkname"
                },
                {
                    GqlOperationName.azureO365Exocompute,
                    "Invoke-RscQueryAzureO365 -Exocompute"
                },
                {
                    GqlOperationName.azureO365GetAzureHostType,
                    "Invoke-RscQueryAzureO365 -Getazurehosttype"
                },
                {
                    GqlOperationName.azureO365GetNetworkSubnetUnusedAddr,
                    "Invoke-RscQueryAzureO365 -Getnetworksubnetunusedaddr"
                },
                {
                    GqlOperationName.azureO365ValidateUserRoles,
                    "Invoke-RscQueryAzureO365 -Validateuserrole"
                },
                {
                    GqlOperationName.azureOauthConsentComplete,
                    "Invoke-RscMutateAzure -Oauthconsentcomplete"
                },
                {
                    GqlOperationName.azureOauthConsentKickoff,
                    "Invoke-RscMutateAzure -Oauthconsentkickoff"
                },
                {
                    GqlOperationName.azureRegions,
                    "Invoke-RscQueryAzure -Region"
                },
                {
                    GqlOperationName.azureResourceGroups,
                    "Invoke-RscQueryAzure -Resourcegroup"
                },
                {
                    GqlOperationName.azureSqlDatabase,
                    "Invoke-RscQueryAzure -Sqldatabase"
                },
                {
                    GqlOperationName.azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
                    "Invoke-RscQueryAzure -Sqldatabasedbpointintimerestorewindowfromazure"
                },
                {
                    GqlOperationName.azureSqlDatabaseServer,
                    "Invoke-RscQueryAzure -Sqldatabaseserver"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDatabase,
                    "Invoke-RscQueryAzure -Sqlmanagedinstancedatabase"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
                    "Invoke-RscQueryAzure -Sqlmanagedinstancedbpointintimerestorewindowfromazure"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceServer,
                    "Invoke-RscQueryAzure -Sqlmanagedinstanceserver"
                },
                {
                    GqlOperationName.azureStorageAccounts,
                    "Invoke-RscQueryAzure -Storageaccount"
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
                    "Invoke-RscQueryAzure -Vnet"
                },
                {
                    GqlOperationName.backupAzureAdDirectory,
                    "Invoke-RscMutateAzure -Backupaddirectory"
                },
                {
                    GqlOperationName.backupO365Mailbox,
                    "Invoke-RscMutateO365 -Backupmailbox"
                },
                {
                    GqlOperationName.backupO365Onedrive,
                    "Invoke-RscMutateO365 -Backuponedrive"
                },
                {
                    GqlOperationName.backupO365SharePointSite,
                    "Invoke-RscMutateO365 -Backupsharepointsite"
                },
                {
                    GqlOperationName.backupO365SharepointDrive,
                    "Invoke-RscMutateO365 -Backupsharepointdrive"
                },
                {
                    GqlOperationName.backupO365SharepointList,
                    "Invoke-RscMutateO365 -Backupsharepointlist"
                },
                {
                    GqlOperationName.backupO365Team,
                    "Invoke-RscMutateO365 -Backupteam"
                },
                {
                    GqlOperationName.batchExportHypervVm,
                    "Invoke-RscMutateHyperv -Batchexportvm"
                },
                {
                    GqlOperationName.batchExportNutanixVm,
                    "Invoke-RscMutateNutanix -Batchexportvm"
                },
                {
                    GqlOperationName.batchInstantRecoverHypervVm,
                    "Invoke-RscMutateHyperv -Batchinstantrecovervm"
                },
                {
                    GqlOperationName.batchMountHypervVm,
                    "Invoke-RscMutateHyperv -Batchmountvm"
                },
                {
                    GqlOperationName.batchMountNutanixVm,
                    "Invoke-RscMutateNutanix -Batchmountvm"
                },
                {
                    GqlOperationName.batchOnDemandBackupHypervVm,
                    "Invoke-RscMutateHyperv -Batchondemandbackupvm"
                },
                {
                    GqlOperationName.browseMssqlDatabaseSnapshot,
                    "Invoke-RscMutateMssql -Browsedatabasesnapshot"
                },
                {
                    GqlOperationName.browseO365TeamConvChannels,
                    "Invoke-RscQueryO365 -Browseteamconvchannel"
                },
                {
                    GqlOperationName.bulkCreateOnDemandMssqlBackup,
                    "Invoke-RscMutateMssql -Bulkcreateondemandbackup"
                },
                {
                    GqlOperationName.bulkDeleteCassandraSources,
                    "Invoke-RscMutateCassandra -Bulkdeletesource"
                },
                {
                    GqlOperationName.bulkDeleteFailoverCluster,
                    "Invoke-RscMutateCluster -Bulkdeletefailover"
                },
                {
                    GqlOperationName.bulkDeleteMongodbSources,
                    "Invoke-RscMutateMongo -Bulkdeletedbsource"
                },
                {
                    GqlOperationName.bulkOnDemandSnapshotNutanixVm,
                    "Invoke-RscMutateNutanix -Bulkondemandsnapshotvm"
                },
                {
                    GqlOperationName.bulkUpdateMssqlDbs,
                    "Invoke-RscMutateMssql -Bulkupdatedb"
                },
                {
                    GqlOperationName.bulkUpdateOracleDatabases,
                    "Invoke-RscMutateOracle -Bulkupdatedatabase"
                },
                {
                    GqlOperationName.bulkUpdateOracleHosts,
                    "Invoke-RscMutateOracle -Bulkupdatehost"
                },
                {
                    GqlOperationName.bulkUpdateOracleRacs,
                    "Invoke-RscMutateOracle -Bulkupdaterac"
                },
                {
                    GqlOperationName.cancelActivitySeries,
                    "Invoke-RscMutateActivitySeries -Cancel"
                },
                {
                    GqlOperationName.cassandraColumnFamilies,
                    "Invoke-RscQueryCassandra -Columnfamily"
                },
                {
                    GqlOperationName.cassandraColumnFamilyRecoverableRange,
                    "Invoke-RscQueryCassandra -Columnfamilyrecoverablerange"
                },
                {
                    GqlOperationName.cassandraColumnFamilySchema,
                    "Invoke-RscQueryCassandra -Columnfamilyschema"
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
                    "Invoke-RscQueryMssql -Cdmlogshippingtarget"
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
                    "Invoke-RscQueryCluster -Defaultgateway"
                },
                {
                    GqlOperationName.clusterDns,
                    "Invoke-RscQueryCluster -Dns"
                },
                {
                    GqlOperationName.clusterEncryptionInfo,
                    "Invoke-RscQueryCluster -Encryptioninfo"
                },
                {
                    GqlOperationName.clusterFloatingIps,
                    "Invoke-RscQueryCluster -Floatingip"
                },
                {
                    GqlOperationName.clusterGroupByConnection,
                    "Invoke-RscQueryCluster -Groupbyconnection"
                },
                {
                    GqlOperationName.clusterIpmi,
                    "Invoke-RscQueryCluster -Ipmi"
                },
                {
                    GqlOperationName.clusterIpv6Mode,
                    "Invoke-RscQueryCluster -Ipv6mode"
                },
                {
                    GqlOperationName.clusterNetworkInterfaces,
                    "Invoke-RscQueryCluster -Networkinterface"
                },
                {
                    GqlOperationName.clusterNodes,
                    "Invoke-RscQueryCluster -Node"
                },
                {
                    GqlOperationName.clusterNtpServers,
                    "Invoke-RscQueryCluster -Ntpserver"
                },
                {
                    GqlOperationName.clusterOperationJobProgress,
                    "Invoke-RscQueryCluster -Operationjobprogress"
                },
                {
                    GqlOperationName.clusterProxy,
                    "Invoke-RscQueryCluster -Proxy"
                },
                {
                    GqlOperationName.clusterRcvLocations,
                    "Invoke-RscQueryCluster -Rcvlocation"
                },
                {
                    GqlOperationName.clusterRegistrationProductInfo,
                    "Invoke-RscQueryCluster -Registrationproductinfo"
                },
                {
                    GqlOperationName.clusterSlaDomainConnection,
                    "Invoke-RscQuerySla -Clusterdomainconnection"
                },
                {
                    GqlOperationName.clusterSlaDomainFilterConnection,
                    "Invoke-RscQuerySla -Clusterdomainfilterconnection"
                },
                {
                    GqlOperationName.clusterTypeList,
                    "Invoke-RscQueryCluster -Typelist"
                },
                {
                    GqlOperationName.clusterVlans,
                    "Invoke-RscQueryCluster -Vlan"
                },
                {
                    GqlOperationName.clusterWebSignedCertificate,
                    "Invoke-RscQueryCluster -Websignedcertificate"
                },
                {
                    GqlOperationName.clusterWithConfigProtectionInfo,
                    "Invoke-RscQueryCluster -Withconfigprotectioninfo"
                },
                {
                    GqlOperationName.clusterWithUpgradesInfo,
                    "Invoke-RscQueryCluster -Withupgradesinfo"
                },
                {
                    GqlOperationName.completeAzureAdAppSetup,
                    "Invoke-RscMutateAzure -Completeadappsetup"
                },
                {
                    GqlOperationName.completeAzureAdAppUpdate,
                    "Invoke-RscMutateAzure -Completeadappupdate"
                },
                {
                    GqlOperationName.completeAzureCloudAccountOauth,
                    "Invoke-RscMutateAzure -Completecloudaccountoauth"
                },
                {
                    GqlOperationName.countOfObjectsProtectedBySlas,
                    "Invoke-RscQuerySla -Countofobjectsprotected"
                },
                {
                    GqlOperationName.createAutomaticAwsTargetMapping,
                    "Invoke-RscMutateAws -Createautomatictargetmapping"
                },
                {
                    GqlOperationName.createAutomaticAzureTargetMapping,
                    "Invoke-RscMutateAzure -Createautomatictargetmapping"
                },
                {
                    GqlOperationName.createAwsAccount,
                    "Invoke-RscMutateAws -Createaccount"
                },
                {
                    GqlOperationName.createAwsCluster,
                    "Invoke-RscMutateAws -Createcluster"
                },
                {
                    GqlOperationName.createAwsComputeSetting,
                    "Invoke-RscMutateAws -Createcomputesetting"
                },
                {
                    GqlOperationName.createAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -Createexocomputeconfig"
                },
                {
                    GqlOperationName.createAwsReaderTarget,
                    "Invoke-RscMutateAws -Createreadertarget"
                },
                {
                    GqlOperationName.createAwsTarget,
                    "Invoke-RscMutateAws -Createtarget"
                },
                {
                    GqlOperationName.createAzureAccount,
                    "Invoke-RscMutateAzure -Createaccount"
                },
                {
                    GqlOperationName.createAzureCluster,
                    "Invoke-RscMutateAzure -Createcluster"
                },
                {
                    GqlOperationName.createAzureReaderTarget,
                    "Invoke-RscMutateAzure -Createreadertarget"
                },
                {
                    GqlOperationName.createAzureSaasAppAad,
                    "Invoke-RscMutateAzure -Createsaasappaad"
                },
                {
                    GqlOperationName.createAzureTarget,
                    "Invoke-RscMutateAzure -Createtarget"
                },
                {
                    GqlOperationName.createCassandraSource,
                    "Invoke-RscMutateCassandra -Createsource"
                },
                {
                    GqlOperationName.createCloudNativeAwsStorageSetting,
                    "Invoke-RscMutateAws -Createcloudnativestoragesetting"
                },
                {
                    GqlOperationName.createCloudNativeAzureStorageSetting,
                    "Invoke-RscMutateAzure -Createcloudnativestoragesetting"
                },
                {
                    GqlOperationName.createCloudNativeRcvAzureStorageSetting,
                    "Invoke-RscMutateAzure -Createcloudnativercvstoragesetting"
                },
                {
                    GqlOperationName.createFailoverCluster,
                    "Invoke-RscMutateCluster -Createfailover"
                },
                {
                    GqlOperationName.createGlobalSla,
                    "Invoke-RscMutateSla -Createglobal"
                },
                {
                    GqlOperationName.createHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -Createvirtualmachinesnapshotmount"
                },
                {
                    GqlOperationName.createK8sCluster,
                    "Invoke-RscMutateCluster -Createk8s"
                },
                {
                    GqlOperationName.createMongodbSource,
                    "Invoke-RscMutateMongo -Createdbsource"
                },
                {
                    GqlOperationName.createMssqlLiveMount,
                    "Invoke-RscMutateMssql -Createlivemount"
                },
                {
                    GqlOperationName.createMssqlLogShippingConfiguration,
                    "Invoke-RscMutateMssql -Createlogshippingconfiguration"
                },
                {
                    GqlOperationName.createNutanixCluster,
                    "Invoke-RscMutateNutanix -Createcluster"
                },
                {
                    GqlOperationName.createNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -Createprismcentral"
                },
                {
                    GqlOperationName.createO365AppComplete,
                    "Invoke-RscMutateO365 -Createappcomplete"
                },
                {
                    GqlOperationName.createO365AppKickoff,
                    "Invoke-RscMutateO365 -Createappkickoff"
                },
                {
                    GqlOperationName.createOnDemandMssqlBackup,
                    "Invoke-RscMutateMssql -Createondemandbackup"
                },
                {
                    GqlOperationName.createOnDemandNutanixBackup,
                    "Invoke-RscMutateNutanix -Createondemandbackup"
                },
                {
                    GqlOperationName.createOraclePdbRestore,
                    "Invoke-RscMutateOracle -Createpdbrestore"
                },
                {
                    GqlOperationName.createVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -Createadvancedtag"
                },
                {
                    GqlOperationName.deleteAllOracleDatabaseSnapshots,
                    "Invoke-RscMutateOracle -Deletealldatabasesnapshot"
                },
                {
                    GqlOperationName.deleteAwsCloudAccountWithoutCft,
                    "Invoke-RscMutateAws -Deletecloudaccountwithoutcft"
                },
                {
                    GqlOperationName.deleteAwsCluster,
                    "Invoke-RscMutateAws -Deletecluster"
                },
                {
                    GqlOperationName.deleteAwsComputeSetting,
                    "Invoke-RscMutateAws -Deletecomputesetting"
                },
                {
                    GqlOperationName.deleteAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -Deleteexocomputeconfig"
                },
                {
                    GqlOperationName.deleteAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -Deleteiamuserbasedcloudaccount"
                },
                {
                    GqlOperationName.deleteAzureAdDirectory,
                    "Invoke-RscMutateAzure -Deleteaddirectory"
                },
                {
                    GqlOperationName.deleteAzureCloudAccount,
                    "Invoke-RscMutateAzure -Deletecloudaccount"
                },
                {
                    GqlOperationName.deleteAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscMutateAzure -Deletecloudaccountexocomputeconfiguration"
                },
                {
                    GqlOperationName.deleteAzureCloudAccountWithoutOauth,
                    "Invoke-RscMutateAzure -Deletecloudaccountwithoutoauth"
                },
                {
                    GqlOperationName.deleteAzureCluster,
                    "Invoke-RscMutateAzure -Deletecluster"
                },
                {
                    GqlOperationName.deleteCassandraSource,
                    "Invoke-RscMutateCassandra -Deletesource"
                },
                {
                    GqlOperationName.deleteFailoverCluster,
                    "Invoke-RscMutateCluster -Deletefailover"
                },
                {
                    GqlOperationName.deleteGlobalSla,
                    "Invoke-RscMutateSla -Deleteglobal"
                },
                {
                    GqlOperationName.deleteHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -Deletevirtualmachinesnapshot"
                },
                {
                    GqlOperationName.deleteHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -Deletevirtualmachinesnapshotmount"
                },
                {
                    GqlOperationName.deleteLdapPrincipals,
                    "Invoke-RscMutateLdap -Deleteprincipal"
                },
                {
                    GqlOperationName.deleteMongoSource,
                    "Invoke-RscMutateMongo -Deletesource"
                },
                {
                    GqlOperationName.deleteMongodbSource,
                    "Invoke-RscMutateMongo -Deletedbsource"
                },
                {
                    GqlOperationName.deleteMssqlDbSnapshots,
                    "Invoke-RscMutateMssql -Deletedbsnapshot"
                },
                {
                    GqlOperationName.deleteMssqlLiveMount,
                    "Invoke-RscMutateMssql -Deletelivemount"
                },
                {
                    GqlOperationName.deleteNutanixCluster,
                    "Invoke-RscMutateNutanix -Deletecluster"
                },
                {
                    GqlOperationName.deleteNutanixMountV1,
                    "Invoke-RscMutateNutanix -Deletemountv1"
                },
                {
                    GqlOperationName.deleteNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -Deleteprismcentral"
                },
                {
                    GqlOperationName.deleteNutanixSnapshots,
                    "Invoke-RscMutateNutanix -Deletesnapshot"
                },
                {
                    GqlOperationName.deleteO365AzureApp,
                    "Invoke-RscMutateO365 -Deleteazureapp"
                },
                {
                    GqlOperationName.deleteO365Org,
                    "Invoke-RscMutateO365 -Deleteorg"
                },
                {
                    GqlOperationName.deleteO365ServiceAccount,
                    "Invoke-RscMutateO365 -Deleteserviceaccount"
                },
                {
                    GqlOperationName.deleteOracleMount,
                    "Invoke-RscMutateOracle -Deletemount"
                },
                {
                    GqlOperationName.deleteVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -Deleteadvancedtag"
                },
                {
                    GqlOperationName.deleteVsphereLiveMount,
                    "Invoke-RscMutateVsphere -Deletelivemount"
                },
                {
                    GqlOperationName.discoverMongoSource,
                    "Invoke-RscMutateMongo -Discoversource"
                },
                {
                    GqlOperationName.doesAzureNativeResourceGroupExist,
                    "Invoke-RscQueryAzure -Doesnativeresourcegroupexist"
                },
                {
                    GqlOperationName.downloadFilesNutanixSnapshot,
                    "Invoke-RscMutateNutanix -Downloadfilessnapshot"
                },
                {
                    GqlOperationName.downloadHypervSnapshotFromLocation,
                    "Invoke-RscMutateHyperv -Downloadsnapshotfromlocation"
                },
                {
                    GqlOperationName.downloadHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -Downloadvirtualmachinesnapshot"
                },
                {
                    GqlOperationName.downloadHypervVirtualMachineSnapshotFiles,
                    "Invoke-RscMutateHyperv -Downloadvirtualmachinesnapshotfile"
                },
                {
                    GqlOperationName.downloadMssqlDatabaseBackupFiles,
                    "Invoke-RscMutateMssql -Downloaddatabasebackupfile"
                },
                {
                    GqlOperationName.downloadMssqlDatabaseFilesFromArchivalLocation,
                    "Invoke-RscMutateMssql -Downloaddatabasefilesfromarchivallocation"
                },
                {
                    GqlOperationName.downloadNutanixSnapshot,
                    "Invoke-RscMutateNutanix -Downloadsnapshot"
                },
                {
                    GqlOperationName.downloadNutanixVmFromLocation,
                    "Invoke-RscMutateNutanix -Downloadvmfromlocation"
                },
                {
                    GqlOperationName.downloadOracleDatabaseSnapshot,
                    "Invoke-RscMutateOracle -Downloaddatabasesnapshot"
                },
                {
                    GqlOperationName.downloadSlaWithReplicationCsv,
                    "Invoke-RscQuerySla -Downloadwithreplicationcsv"
                },
                {
                    GqlOperationName.downloadVsphereVirtualMachineFiles,
                    "Invoke-RscMutateVsphere -Downloadvirtualmachinefile"
                },
                {
                    GqlOperationName.editGlobalSla,
                    "Invoke-RscMutateSla -Editglobal"
                },
                {
                    GqlOperationName.enableO365SharePoint,
                    "Invoke-RscMutateO365 -Enablesharepoint"
                },
                {
                    GqlOperationName.enableO365Teams,
                    "Invoke-RscMutateO365 -Enableteam"
                },
                {
                    GqlOperationName.excludeAwsNativeEbsVolumesFromSnapshot,
                    "Invoke-RscMutateAws -Excludenativeebsvolumesfromsnapshot"
                },
                {
                    GqlOperationName.excludeAzureNativeManagedDisksFromSnapshot,
                    "Invoke-RscMutateAzure -Excludenativemanageddisksfromsnapshot"
                },
                {
                    GqlOperationName.exportHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -Exportvirtualmachine"
                },
                {
                    GqlOperationName.exportMssqlDatabase,
                    "Invoke-RscMutateMssql -Exportdatabase"
                },
                {
                    GqlOperationName.exportNutanixSnapshot,
                    "Invoke-RscMutateNutanix -Exportsnapshot"
                },
                {
                    GqlOperationName.exportO365Mailbox,
                    "Invoke-RscMutateO365 -Exportmailbox"
                },
                {
                    GqlOperationName.exportOracleDatabase,
                    "Invoke-RscMutateOracle -Exportdatabase"
                },
                {
                    GqlOperationName.exportOracleTablespace,
                    "Invoke-RscMutateOracle -Exporttablespace"
                },
                {
                    GqlOperationName.exportSlaManagedVolumeSnapshot,
                    "Invoke-RscMutateSla -Exportmanagedvolumesnapshot"
                },
                {
                    GqlOperationName.finalizeAwsCloudAccountDeletion,
                    "Invoke-RscMutateAws -Finalizecloudaccountdeletion"
                },
                {
                    GqlOperationName.finalizeAwsCloudAccountProtection,
                    "Invoke-RscMutateAws -Finalizecloudaccountprotection"
                },
                {
                    GqlOperationName.getPendingSlaAssignments,
                    "Invoke-RscMutateSla -Getpendingassignment"
                },
                {
                    GqlOperationName.globalSlaFilterConnection,
                    "Invoke-RscQuerySla -Globalfilterconnection"
                },
                {
                    GqlOperationName.globalSlaStatuses,
                    "Invoke-RscQuerySla -Globalstatus"
                },
                {
                    GqlOperationName.hostFailoverCluster,
                    "Invoke-RscQueryCluster -Hostfailover"
                },
                {
                    GqlOperationName.hypervCluster,
                    "Invoke-RscQueryHyperv -Cluster"
                },
                {
                    GqlOperationName.hypervDeleteAllSnapshots,
                    "Invoke-RscMutateHyperv -Deleteallsnapshot"
                },
                {
                    GqlOperationName.hypervHostAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -Hostasyncrequeststatus"
                },
                {
                    GqlOperationName.hypervMounts,
                    "Invoke-RscQueryHyperv -Mount"
                },
                {
                    GqlOperationName.hypervOnDemandSnapshot,
                    "Invoke-RscMutateHyperv -Ondemandsnapshot"
                },
                {
                    GqlOperationName.hypervScvmm,
                    "Invoke-RscQueryHyperv -Scvmm"
                },
                {
                    GqlOperationName.hypervScvmmAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -Scvmmasyncrequeststatus"
                },
                {
                    GqlOperationName.hypervScvmmDelete,
                    "Invoke-RscMutateHyperv -Scvmmdelete"
                },
                {
                    GqlOperationName.hypervScvmmUpdate,
                    "Invoke-RscMutateHyperv -Scvmmupdate"
                },
                {
                    GqlOperationName.hypervServer,
                    "Invoke-RscQueryHyperv -Server"
                },
                {
                    GqlOperationName.hypervTopLevelDescendants,
                    "Invoke-RscQueryHyperv -Topleveldescendant"
                },
                {
                    GqlOperationName.hypervVirtualMachineAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -Virtualmachineasyncrequeststatus"
                },
                {
                    GqlOperationName.hypervVirtualMachines,
                    "Invoke-RscQueryHyperv -Virtualmachine"
                },
                {
                    GqlOperationName.hypervVmDetail,
                    "Invoke-RscQueryHyperv -Vmdetail"
                },
                {
                    GqlOperationName.initiateAzureAdAppUpdate,
                    "Invoke-RscMutateAzure -Initiateadappupdate"
                },
                {
                    GqlOperationName.insertCustomerO365App,
                    "Invoke-RscMutateO365 -Insertcustomerapp"
                },
                {
                    GqlOperationName.instantRecoverHypervVirtualMachineSnapshot,
                    "Invoke-RscMutateHyperv -Instantrecovervirtualmachinesnapshot"
                },
                {
                    GqlOperationName.instantRecoverOracleSnapshot,
                    "Invoke-RscMutateOracle -Instantrecoversnapshot"
                },
                {
                    GqlOperationName.isAwsNativeEbsVolumeSnapshotRestorable,
                    "Invoke-RscQueryAws -Isnativeebsvolumesnapshotrestorable"
                },
                {
                    GqlOperationName.isAwsNativeRdsInstanceLaunchConfigurationValid,
                    "Invoke-RscQueryAws -Isnativerdsinstancelaunchconfigurationvalid"
                },
                {
                    GqlOperationName.isAwsS3BucketNameAvailable,
                    "Invoke-RscQueryAws -Iss3bucketnameavailable"
                },
                {
                    GqlOperationName.isAzureNativeManagedDiskSnapshotRestorable,
                    "Invoke-RscQueryAzure -Isnativemanageddisksnapshotrestorable"
                },
                {
                    GqlOperationName.isAzureNativeSqlDatabaseSnapshotPersistent,
                    "Invoke-RscQueryAzure -Isnativesqldatabasesnapshotpersistent"
                },
                {
                    GqlOperationName.isAzureStorageAccountNameAvailable,
                    "Invoke-RscQueryAzure -Isstorageaccountnameavailable"
                },
                {
                    GqlOperationName.isTotpAckNecessaryForCluster,
                    "Invoke-RscQueryCluster -Istotpacknecessary"
                },
                {
                    GqlOperationName.k8sClusters,
                    "Invoke-RscQueryCluster -K8s"
                },
                {
                    GqlOperationName.kickoffAzureAdAppSetup,
                    "Invoke-RscMutateAzure -Kickoffadappsetup"
                },
                {
                    GqlOperationName.ldapAuthorizedPrincipalConnection,
                    "Invoke-RscQueryLdap -Authorizedprincipalconnection"
                },
                {
                    GqlOperationName.ldapIntegrationConnection,
                    "Invoke-RscQueryLdap -Integrationconnection"
                },
                {
                    GqlOperationName.ldapPrincipalConnection,
                    "Invoke-RscQueryLdap -Principalconnection"
                },
                {
                    GqlOperationName.listO365Apps,
                    "Invoke-RscQueryO365 -Listapp"
                },
                {
                    GqlOperationName.mapAzureCloudAccountExocomputeSubscription,
                    "Invoke-RscMutateAzure -Mapcloudaccountexocomputesubscription"
                },
                {
                    GqlOperationName.mapAzureCloudAccountToPersistentStorageLocation,
                    "Invoke-RscMutateAzure -Mapcloudaccounttopersistentstoragelocation"
                },
                {
                    GqlOperationName.migrateNutanixMountV1,
                    "Invoke-RscMutateNutanix -Migratemountv1"
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
                    "Invoke-RscQueryMongo -Recoverablerange"
                },
                {
                    GqlOperationName.mongoSources,
                    "Invoke-RscQueryMongo -Source"
                },
                {
                    GqlOperationName.mongodbBulkRecoverableRange,
                    "Invoke-RscQueryMongo -Dbbulkrecoverablerange"
                },
                {
                    GqlOperationName.mongodbCollectionRecoverableRange,
                    "Invoke-RscQueryMongo -Dbcollectionrecoverablerange"
                },
                {
                    GqlOperationName.mongodbCollections,
                    "Invoke-RscQueryMongo -Dbcollection"
                },
                {
                    GqlOperationName.mongodbDatabases,
                    "Invoke-RscQueryMongo -Dbdatabase"
                },
                {
                    GqlOperationName.mongodbSources,
                    "Invoke-RscQueryMongo -Dbsource"
                },
                {
                    GqlOperationName.mountNutanixSnapshotV1,
                    "Invoke-RscMutateNutanix -Mountsnapshotv1"
                },
                {
                    GqlOperationName.mountOracleDatabase,
                    "Invoke-RscMutateOracle -Mountdatabase"
                },
                {
                    GqlOperationName.mssqlAvailabilityGroup,
                    "Invoke-RscQueryMssql -Availabilitygroup"
                },
                {
                    GqlOperationName.mssqlCompatibleInstances,
                    "Invoke-RscQueryMssql -Compatibleinstance"
                },
                {
                    GqlOperationName.mssqlDatabaseLiveMounts,
                    "Invoke-RscQueryMssql -Databaselivemount"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedRecoverableRanges,
                    "Invoke-RscQueryMssql -Databasemissedrecoverablerange"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedSnapshots,
                    "Invoke-RscQueryMssql -Databasemissedsnapshot"
                },
                {
                    GqlOperationName.mssqlDatabaseRestoreEstimate,
                    "Invoke-RscQueryMssql -Databaserestoreestimate"
                },
                {
                    GqlOperationName.mssqlDatabases,
                    "Invoke-RscQueryMssql -Database"
                },
                {
                    GqlOperationName.mssqlDefaultProperties,
                    "Invoke-RscQueryMssql -Defaultpropertie"
                },
                {
                    GqlOperationName.mssqlInstance,
                    "Invoke-RscQueryMssql -Instance"
                },
                {
                    GqlOperationName.mssqlLogShippingTargets,
                    "Invoke-RscQueryMssql -Logshippingtarget"
                },
                {
                    GqlOperationName.mssqlRecoverableRanges,
                    "Invoke-RscQueryMssql -Recoverablerange"
                },
                {
                    GqlOperationName.mssqlTopLevelDescendants,
                    "Invoke-RscQueryMssql -Topleveldescendant"
                },
                {
                    GqlOperationName.nutanixBrowseSnapshot,
                    "Invoke-RscQueryNutanix -Browsesnapshot"
                },
                {
                    GqlOperationName.nutanixCategories,
                    "Invoke-RscQueryNutanix -Categorie"
                },
                {
                    GqlOperationName.nutanixCategoryValueVms,
                    "Invoke-RscQueryNutanix -Categoryvaluevm"
                },
                {
                    GqlOperationName.nutanixCategoryValues,
                    "Invoke-RscQueryNutanix -Categoryvalue"
                },
                {
                    GqlOperationName.nutanixCluster,
                    "Invoke-RscQueryNutanix -Cluster"
                },
                {
                    GqlOperationName.nutanixClusterAsyncRequestStatus,
                    "Invoke-RscQueryNutanix -Clusterasyncrequeststatus"
                },
                {
                    GqlOperationName.nutanixClusterContainers,
                    "Invoke-RscQueryNutanix -Clustercontainer"
                },
                {
                    GqlOperationName.nutanixClusterNetworks,
                    "Invoke-RscQueryNutanix -Clusternetwork"
                },
                {
                    GqlOperationName.nutanixMounts,
                    "Invoke-RscQueryNutanix -Mount"
                },
                {
                    GqlOperationName.nutanixPrismCentrals,
                    "Invoke-RscQueryNutanix -Prismcentral"
                },
                {
                    GqlOperationName.nutanixSnapshotDetail,
                    "Invoke-RscQueryNutanix -Snapshotdetail"
                },
                {
                    GqlOperationName.nutanixTopLevelDescendants,
                    "Invoke-RscQueryNutanix -Topleveldescendant"
                },
                {
                    GqlOperationName.nutanixTopLevelDescendantsV2,
                    "Invoke-RscQueryNutanix -Topleveldescendantsv2"
                },
                {
                    GqlOperationName.nutanixVm,
                    "Invoke-RscQueryNutanix -Vm"
                },
                {
                    GqlOperationName.nutanixVmAsyncRequestStatus,
                    "Invoke-RscQueryNutanix -Vmasyncrequeststatus"
                },
                {
                    GqlOperationName.nutanixVmMissedSnapshots,
                    "Invoke-RscQueryNutanix -Vmmissedsnapshot"
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
                    "Invoke-RscMutateO365 -Oauthconsentcomplete"
                },
                {
                    GqlOperationName.o365OauthConsentKickoff,
                    "Invoke-RscMutateO365 -Oauthconsentkickoff"
                },
                {
                    GqlOperationName.o365ObjectAncestors,
                    "Invoke-RscQueryO365 -Objectancestor"
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
                    "Invoke-RscQueryO365 -Orgatsnappablelevel"
                },
                {
                    GqlOperationName.o365OrgSummaries,
                    "Invoke-RscQueryO365 -Orgsummarie"
                },
                {
                    GqlOperationName.o365PdlGroups,
                    "Invoke-RscMutateO365 -Pdlgroup"
                },
                {
                    GqlOperationName.o365SaaSSetupKickoff,
                    "Invoke-RscMutateO365 -Saassetupkickoff"
                },
                {
                    GqlOperationName.o365SaasSetupComplete,
                    "Invoke-RscMutateO365 -Saassetupcomplete"
                },
                {
                    GqlOperationName.o365ServiceAccount,
                    "Invoke-RscQueryO365 -Serviceaccount"
                },
                {
                    GqlOperationName.o365ServiceStatus,
                    "Invoke-RscQueryO365 -Servicestatus"
                },
                {
                    GqlOperationName.o365SetupKickoff,
                    "Invoke-RscMutateO365 -Setupkickoff"
                },
                {
                    GqlOperationName.o365SharepointDrive,
                    "Invoke-RscQueryO365 -Sharepointdrive"
                },
                {
                    GqlOperationName.o365SharepointList,
                    "Invoke-RscQueryO365 -Sharepointlist"
                },
                {
                    GqlOperationName.o365SharepointObjectList,
                    "Invoke-RscQueryO365 -Sharepointobjectlist"
                },
                {
                    GqlOperationName.o365SharepointObjects,
                    "Invoke-RscQueryO365 -Sharepointobject"
                },
                {
                    GqlOperationName.o365SharepointSite,
                    "Invoke-RscQueryO365 -Sharepointsite"
                },
                {
                    GqlOperationName.o365Site,
                    "Invoke-RscQueryO365 -Site"
                },
                {
                    GqlOperationName.o365StorageStats,
                    "Invoke-RscQueryO365 -Storagestat"
                },
                {
                    GqlOperationName.o365Team,
                    "Invoke-RscQueryO365 -Team"
                },
                {
                    GqlOperationName.o365TeamChannels,
                    "Invoke-RscQueryO365 -Teamchannel"
                },
                {
                    GqlOperationName.o365TeamConversationsFolderID,
                    "Invoke-RscQueryO365 -Teamconversationsfolderid"
                },
                {
                    GqlOperationName.o365TeamPostedBy,
                    "Invoke-RscQueryO365 -Teampostedby"
                },
                {
                    GqlOperationName.o365User,
                    "Invoke-RscQueryO365 -User"
                },
                {
                    GqlOperationName.o365UserObjects,
                    "Invoke-RscQueryO365 -Userobject"
                },
                {
                    GqlOperationName.oracleAcoExampleDownloadLink,
                    "Invoke-RscQueryOracle -Acoexampledownloadlink"
                },
                {
                    GqlOperationName.oracleAcoParameters,
                    "Invoke-RscQueryOracle -Acoparameter"
                },
                {
                    GqlOperationName.oracleDataGuardGroup,
                    "Invoke-RscQueryOracle -Dataguardgroup"
                },
                {
                    GqlOperationName.oracleDatabaseLogBackupConfig,
                    "Invoke-RscQueryOracle -Databaselogbackupconfig"
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
                    "Invoke-RscQueryOracle -Hostlogbackupconfig"
                },
                {
                    GqlOperationName.oracleLiveMounts,
                    "Invoke-RscQueryOracle -Livemount"
                },
                {
                    GqlOperationName.oracleMissedRecoverableRanges,
                    "Invoke-RscQueryOracle -Missedrecoverablerange"
                },
                {
                    GqlOperationName.oracleMissedSnapshots,
                    "Invoke-RscQueryOracle -Missedsnapshot"
                },
                {
                    GqlOperationName.oraclePdbDetails,
                    "Invoke-RscQueryOracle -Pdbdetail"
                },
                {
                    GqlOperationName.oracleRac,
                    "Invoke-RscQueryOracle -Rac"
                },
                {
                    GqlOperationName.oracleRacLogBackupConfig,
                    "Invoke-RscQueryOracle -Raclogbackupconfig"
                },
                {
                    GqlOperationName.oracleRecoverableRanges,
                    "Invoke-RscQueryOracle -Recoverablerange"
                },
                {
                    GqlOperationName.oracleTopLevelDescendants,
                    "Invoke-RscQueryOracle -Topleveldescendant"
                },
                {
                    GqlOperationName.patchAwsAuthenticationServerBasedCloudAccount,
                    "Invoke-RscMutateAws -Patchauthenticationserverbasedcloudaccount"
                },
                {
                    GqlOperationName.patchAwsIamUserBasedCloudAccount,
                    "Invoke-RscMutateAws -Patchiamuserbasedcloudaccount"
                },
                {
                    GqlOperationName.patchMongoSource,
                    "Invoke-RscMutateMongo -Patchsource"
                },
                {
                    GqlOperationName.patchNutanixMountV1,
                    "Invoke-RscMutateNutanix -Patchmountv1"
                },
                {
                    GqlOperationName.pauseSla,
                    "Invoke-RscMutateSla -Pause"
                },
                {
                    GqlOperationName.prepareAwsCloudAccountDeletion,
                    "Invoke-RscMutateAws -Preparecloudaccountdeletion"
                },
                {
                    GqlOperationName.prepareFeatureUpdateForAwsCloudAccount,
                    "Invoke-RscMutateAws -Preparefeatureupdateforcloudaccount"
                },
                {
                    GqlOperationName.protectedClustersForGlobalSla,
                    "Invoke-RscQuerySla -Protectedclustersforglobal"
                },
                {
                    GqlOperationName.rdsInstanceDetailsFromAws,
                    "Invoke-RscQueryAws -Rdsinstancedetail"
                },
                {
                    GqlOperationName.recoverCassandraSource,
                    "Invoke-RscMutateCassandra -Recoversource"
                },
                {
                    GqlOperationName.recoverCloudCluster,
                    "Invoke-RscMutateCluster -Recovercloud"
                },
                {
                    GqlOperationName.recoverMongoSource,
                    "Invoke-RscMutateMongo -Recoversource"
                },
                {
                    GqlOperationName.recoverMongodbSource,
                    "Invoke-RscMutateMongo -Recoverdbsource"
                },
                {
                    GqlOperationName.refreshHypervScvmm,
                    "Invoke-RscMutateHyperv -Refreshscvmm"
                },
                {
                    GqlOperationName.refreshHypervServer,
                    "Invoke-RscMutateHyperv -Refreshserver"
                },
                {
                    GqlOperationName.refreshK8sCluster,
                    "Invoke-RscMutateCluster -Refreshk8s"
                },
                {
                    GqlOperationName.refreshNutanixCluster,
                    "Invoke-RscMutateNutanix -Refreshcluster"
                },
                {
                    GqlOperationName.refreshNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -Refreshprismcentral"
                },
                {
                    GqlOperationName.refreshO365Org,
                    "Invoke-RscMutateO365 -Refreshorg"
                },
                {
                    GqlOperationName.refreshOracleDatabase,
                    "Invoke-RscMutateOracle -Refreshdatabase"
                },
                {
                    GqlOperationName.registerAgentHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -Registeragentvirtualmachine"
                },
                {
                    GqlOperationName.registerAgentNutanixVm,
                    "Invoke-RscMutateNutanix -Registeragentvm"
                },
                {
                    GqlOperationName.registerCloudCluster,
                    "Invoke-RscMutateCluster -Registercloud"
                },
                {
                    GqlOperationName.registerHypervScvmm,
                    "Invoke-RscMutateHyperv -Registerscvmm"
                },
                {
                    GqlOperationName.removeCdmCluster,
                    "Invoke-RscMutateCluster -Removecdm"
                },
                {
                    GqlOperationName.removeLdapIntegration,
                    "Invoke-RscMutateLdap -Removeintegration"
                },
                {
                    GqlOperationName.restoreFilesNutanixSnapshot,
                    "Invoke-RscMutateNutanix -Restorefilessnapshot"
                },
                {
                    GqlOperationName.restoreHypervVirtualMachineSnapshotFiles,
                    "Invoke-RscMutateHyperv -Restorevirtualmachinesnapshotfile"
                },
                {
                    GqlOperationName.restoreMssqlDatabase,
                    "Invoke-RscMutateMssql -Restoredatabase"
                },
                {
                    GqlOperationName.restoreO365Mailbox,
                    "Invoke-RscMutateO365 -Restoremailbox"
                },
                {
                    GqlOperationName.restoreO365Snappable,
                    "Invoke-RscMutateO365 -Restoresnappable"
                },
                {
                    GqlOperationName.restoreO365TeamsConversations,
                    "Invoke-RscMutateO365 -Restoreteamsconversation"
                },
                {
                    GqlOperationName.restoreO365TeamsFiles,
                    "Invoke-RscMutateO365 -Restoreteamsfile"
                },
                {
                    GqlOperationName.restoreOracleLogs,
                    "Invoke-RscMutateOracle -Restorelog"
                },
                {
                    GqlOperationName.retryAddMongoSource,
                    "Invoke-RscMutateMongo -Retryaddsource"
                },
                {
                    GqlOperationName.searchNutanixVm,
                    "Invoke-RscQueryNutanix -Searchvm"
                },
                {
                    GqlOperationName.setAzureCloudAccountCustomerAppCredentials,
                    "Invoke-RscMutateAzure -Setcloudaccountcustomerappcredential"
                },
                {
                    GqlOperationName.setLdapMfaSetting,
                    "Invoke-RscMutateLdap -Setmfasetting"
                },
                {
                    GqlOperationName.setO365ServiceAccount,
                    "Invoke-RscMutateO365 -Setserviceaccount"
                },
                {
                    GqlOperationName.setupAzureO365Exocompute,
                    "Invoke-RscMutateAzureO365 -Setupexocompute"
                },
                {
                    GqlOperationName.slaArchivalValidationWarnings,
                    "Invoke-RscQuerySla -Archivalvalidationwarning"
                },
                {
                    GqlOperationName.slaAuditDetail,
                    "Invoke-RscQuerySla -Auditdetail"
                },
                {
                    GqlOperationName.slaConflictObjects,
                    "Invoke-RscQuerySla -Conflictobject"
                },
                {
                    GqlOperationName.slaDomainWithWarnings,
                    "Invoke-RscQuerySla -Domainwithwarning"
                },
                {
                    GqlOperationName.slaDomainWithWarningsList,
                    "Invoke-RscQuerySla -Domainwithwarningslist"
                },
                {
                    GqlOperationName.slaDomains,
                    "Invoke-RscQuerySla -Domain"
                },
                {
                    GqlOperationName.slaManagedVolumes,
                    "Invoke-RscQuerySla -Managedvolume"
                },
                {
                    GqlOperationName.slaSummariesByIds,
                    "Invoke-RscQuerySla -Summariesbyid"
                },
                {
                    GqlOperationName.startAwsExocomputeDisableJob,
                    "Invoke-RscMutateAws -Startexocomputedisablejob"
                },
                {
                    GqlOperationName.startAwsNativeAccountDisableJob,
                    "Invoke-RscMutateAws -Startnativeaccountdisablejob"
                },
                {
                    GqlOperationName.startAwsNativeEc2InstanceSnapshotsJob,
                    "Invoke-RscMutateAws -Startnativeec2instancesnapshotsjob"
                },
                {
                    GqlOperationName.startAwsNativeRdsInstanceSnapshotsJob,
                    "Invoke-RscMutateAws -Startnativerdsinstancesnapshotsjob"
                },
                {
                    GqlOperationName.startAzureCloudAccountOauth,
                    "Invoke-RscMutateAzure -Startcloudaccountoauth"
                },
                {
                    GqlOperationName.startCreateAwsNativeEbsVolumeSnapshotsJob,
                    "Invoke-RscMutateAws -Startcreatenativeebsvolumesnapshotsjob"
                },
                {
                    GqlOperationName.startCreateAzureNativeManagedDiskSnapshotsJob,
                    "Invoke-RscMutateAzure -Startcreatenativemanageddisksnapshotsjob"
                },
                {
                    GqlOperationName.startCreateAzureNativeVirtualMachineSnapshotsJob,
                    "Invoke-RscMutateAzure -Startcreatenativevirtualmachinesnapshotsjob"
                },
                {
                    GqlOperationName.startDisableAzureCloudAccountJob,
                    "Invoke-RscMutateAzure -Startdisablecloudaccountjob"
                },
                {
                    GqlOperationName.startDisableAzureNativeSubscriptionProtectionJob,
                    "Invoke-RscMutateAzure -Startdisablenativesubscriptionprotectionjob"
                },
                {
                    GqlOperationName.startExportAwsNativeEbsVolumeSnapshotJob,
                    "Invoke-RscMutateAws -Startexportnativeebsvolumesnapshotjob"
                },
                {
                    GqlOperationName.startExportAzureNativeManagedDiskJob,
                    "Invoke-RscMutateAzure -Startexportnativemanageddiskjob"
                },
                {
                    GqlOperationName.startExportAzureNativeVirtualMachineJob,
                    "Invoke-RscMutateAzure -Startexportnativevirtualmachinejob"
                },
                {
                    GqlOperationName.startExportAzureSqlDatabaseDbJob,
                    "Invoke-RscMutateAzure -Startexportsqldatabasedbjob"
                },
                {
                    GqlOperationName.startExportAzureSqlManagedInstanceDbJob,
                    "Invoke-RscMutateAzure -Startexportsqlmanagedinstancedbjob"
                },
                {
                    GqlOperationName.startRefreshAwsNativeAccountsJob,
                    "Invoke-RscMutateAws -Startrefreshnativeaccountsjob"
                },
                {
                    GqlOperationName.startRefreshAzureNativeSubscriptionsJob,
                    "Invoke-RscMutateAzure -Startrefreshnativesubscriptionsjob"
                },
                {
                    GqlOperationName.startRestoreAwsNativeEc2InstanceSnapshotJob,
                    "Invoke-RscMutateAws -Startrestorenativeec2instancesnapshotjob"
                },
                {
                    GqlOperationName.startRestoreAzureNativeVirtualMachineJob,
                    "Invoke-RscMutateAzure -Startrestorenativevirtualmachinejob"
                },
                {
                    GqlOperationName.takeMssqlLogBackup,
                    "Invoke-RscMutateMssql -Takelogbackup"
                },
                {
                    GqlOperationName.takeOnDemandOracleDatabaseSnapshot,
                    "Invoke-RscMutateOracle -Takeondemanddatabasesnapshot"
                },
                {
                    GqlOperationName.takeOnDemandOracleLogSnapshot,
                    "Invoke-RscMutateOracle -Takeondemandlogsnapshot"
                },
                {
                    GqlOperationName.uniqueHypervServersCount,
                    "Invoke-RscQueryHyperv -Uniqueserverscount"
                },
                {
                    GqlOperationName.uniqueVSphereVCenterCount,
                    "Invoke-RscQueryVcenter -Uniquecount"
                },
                {
                    GqlOperationName.unmapAzureCloudAccountExocomputeSubscription,
                    "Invoke-RscMutateAzure -Unmapcloudaccountexocomputesubscription"
                },
                {
                    GqlOperationName.updateAutomaticAwsTargetMapping,
                    "Invoke-RscMutateAws -Updateautomatictargetmapping"
                },
                {
                    GqlOperationName.updateAutomaticAzureTargetMapping,
                    "Invoke-RscMutateAzure -Updateautomatictargetmapping"
                },
                {
                    GqlOperationName.updateAwsAccount,
                    "Invoke-RscMutateAws -Updateaccount"
                },
                {
                    GqlOperationName.updateAwsCloudAccount,
                    "Invoke-RscMutateAws -Updatecloudaccount"
                },
                {
                    GqlOperationName.updateAwsCloudAccountFeature,
                    "Invoke-RscMutateAws -Updatecloudaccountfeature"
                },
                {
                    GqlOperationName.updateAwsComputeSetting,
                    "Invoke-RscMutateAws -Updatecomputesetting"
                },
                {
                    GqlOperationName.updateAwsExocomputeConfigs,
                    "Invoke-RscMutateAws -Updateexocomputeconfig"
                },
                {
                    GqlOperationName.updateAwsTarget,
                    "Invoke-RscMutateAws -Updatetarget"
                },
                {
                    GqlOperationName.updateAzureAccount,
                    "Invoke-RscMutateAzure -Updateaccount"
                },
                {
                    GqlOperationName.updateAzureCloudAccount,
                    "Invoke-RscMutateAzure -Updatecloudaccount"
                },
                {
                    GqlOperationName.updateAzureTarget,
                    "Invoke-RscMutateAzure -Updatetarget"
                },
                {
                    GqlOperationName.updateCassandraSource,
                    "Invoke-RscMutateCassandra -Updatesource"
                },
                {
                    GqlOperationName.updateCloudNativeAwsStorageSetting,
                    "Invoke-RscMutateAws -Updatecloudnativestoragesetting"
                },
                {
                    GqlOperationName.updateCloudNativeAzureStorageSetting,
                    "Invoke-RscMutateAzure -Updatecloudnativestoragesetting"
                },
                {
                    GqlOperationName.updateCloudNativeRcvAzureStorageSetting,
                    "Invoke-RscMutateAzure -Updatecloudnativercvstoragesetting"
                },
                {
                    GqlOperationName.updateCustomerAppPermissionForAzureSql,
                    "Invoke-RscMutateAzure -Updatecustomerapppermissionforsql"
                },
                {
                    GqlOperationName.updateFailoverCluster,
                    "Invoke-RscMutateCluster -Updatefailover"
                },
                {
                    GqlOperationName.updateGlobalSla,
                    "Invoke-RscMutateSla -Updateglobal"
                },
                {
                    GqlOperationName.updateHypervVirtualMachine,
                    "Invoke-RscMutateHyperv -Updatevirtualmachine"
                },
                {
                    GqlOperationName.updateHypervVirtualMachineSnapshotMount,
                    "Invoke-RscMutateHyperv -Updatevirtualmachinesnapshotmount"
                },
                {
                    GqlOperationName.updateLdapIntegration,
                    "Invoke-RscMutateLdap -Updateintegration"
                },
                {
                    GqlOperationName.updateMongodbSource,
                    "Invoke-RscMutateMongo -Updatedbsource"
                },
                {
                    GqlOperationName.updateMssqlDefaultProperties,
                    "Invoke-RscMutateMssql -Updatedefaultpropertie"
                },
                {
                    GqlOperationName.updateMssqlLogShippingConfiguration,
                    "Invoke-RscMutateMssql -Updatelogshippingconfiguration"
                },
                {
                    GqlOperationName.updateNutanixCluster,
                    "Invoke-RscMutateNutanix -Updatecluster"
                },
                {
                    GqlOperationName.updateNutanixPrismCentral,
                    "Invoke-RscMutateNutanix -Updateprismcentral"
                },
                {
                    GqlOperationName.updateNutanixVm,
                    "Invoke-RscMutateNutanix -Updatevm"
                },
                {
                    GqlOperationName.updateO365AppAuthStatus,
                    "Invoke-RscMutateO365 -Updateappauthstatus"
                },
                {
                    GqlOperationName.updateO365AppPermissions,
                    "Invoke-RscMutateO365 -Updateapppermission"
                },
                {
                    GqlOperationName.updateO365OrgCustomName,
                    "Invoke-RscMutateO365 -Updateorgcustomname"
                },
                {
                    GqlOperationName.updateOracleDataGuardGroup,
                    "Invoke-RscMutateOracle -Updatedataguardgroup"
                },
                {
                    GqlOperationName.updateVcenter,
                    "Invoke-RscMutateVcenter -Update"
                },
                {
                    GqlOperationName.updateVcenterHotAddBandwidth,
                    "Invoke-RscMutateVcenter -Updatehotaddbandwidth"
                },
                {
                    GqlOperationName.updateVcenterHotAddNetwork,
                    "Invoke-RscMutateVcenter -Updatehotaddnetwork"
                },
                {
                    GqlOperationName.updateVsphereAdvancedTag,
                    "Invoke-RscMutateVsphere -Updateadvancedtag"
                },
                {
                    GqlOperationName.upgradeAwsCloudAccountFeaturesWithoutCft,
                    "Invoke-RscMutateAws -Upgradecloudaccountfeatureswithoutcft"
                },
                {
                    GqlOperationName.upgradeAwsIamUserBasedCloudAccountPermissions,
                    "Invoke-RscMutateAws -Upgradeiamuserbasedcloudaccountpermission"
                },
                {
                    GqlOperationName.upgradeAzureCloudAccount,
                    "Invoke-RscMutateAzure -Upgradecloudaccount"
                },
                {
                    GqlOperationName.upgradeAzureCloudAccountPermissionsWithoutOauth,
                    "Invoke-RscMutateAzure -Upgradecloudaccountpermissionswithoutoauth"
                },
                {
                    GqlOperationName.upgradeSlas,
                    "Invoke-RscMutateSla -Upgrade"
                },
                {
                    GqlOperationName.vCenterAdvancedTagPreview,
                    "Invoke-RscQueryVcenter -Advancedtagpreview"
                },
                {
                    GqlOperationName.vCenterHotAddBandwidth,
                    "Invoke-RscQueryVcenter -Hotaddbandwidth"
                },
                {
                    GqlOperationName.vCenterHotAddNetwork,
                    "Invoke-RscQueryVcenter -Hotaddnetwork"
                },
                {
                    GqlOperationName.vCenterNetworks,
                    "Invoke-RscQueryVcenter -Network"
                },
                {
                    GqlOperationName.vCenterNumProxiesNeeded,
                    "Invoke-RscQueryVcenter -Numproxiesneeded"
                },
                {
                    GqlOperationName.vCenterPreAddInfo,
                    "Invoke-RscQueryVcenter -Preaddinfo"
                },
                {
                    GqlOperationName.vSphereBlueprint,
                    "Invoke-RscQueryVsphere -Blueprint"
                },
                {
                    GqlOperationName.vSphereComputeCluster,
                    "Invoke-RscQueryVsphere -Computecluster"
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
                    "Invoke-RscQueryVsphere -Datastorecluster"
                },
                {
                    GqlOperationName.vSphereDatastoreConnection,
                    "Invoke-RscQueryVsphere -Datastoreconnection"
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
                    "Invoke-RscQueryVsphere -Hostconnection"
                },
                {
                    GqlOperationName.vSphereHostDetails,
                    "Invoke-RscQueryVsphere -Hostdetail"
                },
                {
                    GqlOperationName.vSphereHostsByFids,
                    "Invoke-RscQueryVsphere -Hostsbyfid"
                },
                {
                    GqlOperationName.vSphereLiveMounts,
                    "Invoke-RscQueryVsphere -Livemount"
                },
                {
                    GqlOperationName.vSphereMount,
                    "Invoke-RscQueryVsphere -Mount"
                },
                {
                    GqlOperationName.vSphereMountConnection,
                    "Invoke-RscQueryVsphere -Mountconnection"
                },
                {
                    GqlOperationName.vSphereNetwork,
                    "Invoke-RscQueryVsphere -Network"
                },
                {
                    GqlOperationName.vSphereResourcePool,
                    "Invoke-RscQueryVsphere -Resourcepool"
                },
                {
                    GqlOperationName.vSphereRootRecoveryHierarchy,
                    "Invoke-RscQueryVsphere -Rootrecoveryhierarchy"
                },
                {
                    GqlOperationName.vSphereTag,
                    "Invoke-RscQueryVsphere -Tag"
                },
                {
                    GqlOperationName.vSphereTagCategory,
                    "Invoke-RscQueryVsphere -Tagcategory"
                },
                {
                    GqlOperationName.vSphereTopLevelDescendantsConnection,
                    "Invoke-RscQueryVsphere -Topleveldescendantsconnection"
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
                    "Invoke-RscQueryVsphereVm -Asyncrequeststatus"
                },
                {
                    GqlOperationName.vSphereVMBatchLiveMount,
                    "Invoke-RscMutateVsphereVm -Batchlivemount"
                },
                {
                    GqlOperationName.vSphereVmNew,
                    "Invoke-RscQueryVsphereVm -New"
                },
                {
                    GqlOperationName.vSphereVmNewConnection,
                    "Invoke-RscQueryVsphereVm -Newconnection"
                },
                {
                    GqlOperationName.validateAndCreateAwsCloudAccount,
                    "Invoke-RscMutateAws -Validateandcreatecloudaccount"
                },
                {
                    GqlOperationName.validateAwsNativeRdsClusterNameForExport,
                    "Invoke-RscQueryAws -Validatenativerdsclusternameforexport"
                },
                {
                    GqlOperationName.validateAwsNativeRdsInstanceNameForExport,
                    "Invoke-RscQueryAws -Validatenativerdsinstancenameforexport"
                },
                {
                    GqlOperationName.validateAzureCloudAccountExocomputeConfigurations,
                    "Invoke-RscQueryAzure -Validatecloudaccountexocomputeconfiguration"
                },
                {
                    GqlOperationName.validateAzureNativeSqlDatabaseDbNameForExport,
                    "Invoke-RscQueryAzure -Validatenativesqldatabasedbnameforexport"
                },
                {
                    GqlOperationName.validateAzureNativeSqlManagedInstanceDbNameForExport,
                    "Invoke-RscQueryAzure -Validatenativesqlmanagedinstancedbnameforexport"
                },
                {
                    GqlOperationName.validateOracleAcoFile,
                    "Invoke-RscMutateOracle -Validateacofile"
                },
                {
                    GqlOperationName.validateOracleDatabaseBackups,
                    "Invoke-RscMutateOracle -Validatedatabasebackup"
                },
                {
                    GqlOperationName.vcdClusters,
                    "Invoke-RscQueryCluster -Vcd"
                },
                {
                    GqlOperationName.verifySLAWithReplicationToCluster,
                    "Invoke-RscQuerySla -Verifywithreplicationtocluster"
                },
                {
                    GqlOperationName.vsphereBulkOnDemandSnapshot,
                    "Invoke-RscMutateVsphere -Bulkondemandsnapshot"
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
                    "Invoke-RscMutateVsphereVm -Excludevmdisk"
                },
                {
                    GqlOperationName.vsphereExportSnapshotToStandaloneHost,
                    "Invoke-RscMutateVsphere -Exportsnapshottostandalonehost"
                },
                {
                    GqlOperationName.vsphereExportSnapshotToStandaloneHostV2,
                    "Invoke-RscMutateVsphere -Exportsnapshottostandalonehostv2"
                },
                {
                    GqlOperationName.vsphereOnDemandSnapshot,
                    "Invoke-RscMutateVsphere -Ondemandsnapshot"
                },
                {
                    GqlOperationName.vsphereRefreshVCenter,
                    "Invoke-RscMutateVcenter -Refresh"
                },
                {
                    GqlOperationName.vsphereVMDeleteLiveMount,
                    "Invoke-RscMutateVsphereVm -Deletelivemount"
                },
                {
                    GqlOperationName.vsphereVMExportSnapshot,
                    "Invoke-RscMutateVsphereVm -Exportsnapshot"
                },
                {
                    GqlOperationName.vsphereVMInitiateInstantRecovery,
                    "Invoke-RscMutateVsphereVm -Initiateinstantrecovery"
                },
                {
                    GqlOperationName.vsphereVMInitiateLiveMount,
                    "Invoke-RscMutateVsphereVm -Initiatelivemount"
                },
                {
                    GqlOperationName.vsphereVMMissedRecoverableRange,
                    "Invoke-RscQueryVsphereVm -Missedrecoverablerange"
                },
                {
                    GqlOperationName.vsphereVMRecoverableRange,
                    "Invoke-RscQueryVsphereVm -Recoverablerange"
                },
                {
                    GqlOperationName.vsphereVMRecoverableRangeInBatch,
                    "Invoke-RscQueryVsphereVm -Recoverablerangeinbatch"
                },
                {
                    GqlOperationName.vsphereVMUpdate,
                    "Invoke-RscMutateVsphereVm -Update"
                },
                {
                    GqlOperationName.vsphereVmBatchExport,
                    "Invoke-RscMutateVsphereVm -Batchexport"
                },
                {
                    GqlOperationName.vsphereVmBatchExportV3,
                    "Invoke-RscMutateVsphereVm -Batchexportv3"
                },
                {
                    GqlOperationName.vsphereVmBatchInPlaceRecovery,
                    "Invoke-RscMutateVsphereVm -Batchinplacerecovery"
                },
                {
                    GqlOperationName.vsphereVmDeleteSnapshot,
                    "Invoke-RscMutateVsphereVm -Deletesnapshot"
                },
                {
                    GqlOperationName.vsphereVmDownloadSnapshot,
                    "Invoke-RscMutateVsphereVm -Downloadsnapshot"
                },
                {
                    GqlOperationName.vsphereVmDownloadSnapshotFiles,
                    "Invoke-RscMutateVsphereVm -Downloadsnapshotfile"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotV2,
                    "Invoke-RscMutateVsphereVm -Exportsnapshotv2"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotV3,
                    "Invoke-RscMutateVsphereVm -Exportsnapshotv3"
                },
                {
                    GqlOperationName.vsphereVmExportSnapshotWithDownloadFromCloud,
                    "Invoke-RscMutateVsphereVm -Exportsnapshotwithdownloadfromcloud"
                },
                {
                    GqlOperationName.vsphereVmInitiateBatchInstantRecovery,
                    "Invoke-RscMutateVsphereVm -Initiatebatchinstantrecovery"
                },
                {
                    GqlOperationName.vsphereVmInitiateBatchLiveMountV2,
                    "Invoke-RscMutateVsphereVm -Initiatebatchlivemountv2"
                },
                {
                    GqlOperationName.vsphereVmInitiateDiskMount,
                    "Invoke-RscMutateVsphereVm -Initiatediskmount"
                },
                {
                    GqlOperationName.vsphereVmInitiateInPlaceRecovery,
                    "Invoke-RscMutateVsphereVm -Initiateinplacerecovery"
                },
                {
                    GqlOperationName.vsphereVmInitiateInstantRecoveryV2,
                    "Invoke-RscMutateVsphereVm -Initiateinstantrecoveryv2"
                },
                {
                    GqlOperationName.vsphereVmInitiateLiveMountV2,
                    "Invoke-RscMutateVsphereVm -Initiatelivemountv2"
                },
                {
                    GqlOperationName.vsphereVmListEsxiDatastores,
                    "Invoke-RscMutateVsphereVm -Listesxidatastore"
                },
                {
                    GqlOperationName.vsphereVmMountRelocate,
                    "Invoke-RscMutateVsphereVm -Mountrelocate"
                },
                {
                    GqlOperationName.vsphereVmMountRelocateV2,
                    "Invoke-RscMutateVsphereVm -Mountrelocatev2"
                },
                {
                    GqlOperationName.vsphereVmPowerOnOffLiveMount,
                    "Invoke-RscMutateVsphereVm -Poweronofflivemount"
                },
                {
                    GqlOperationName.vsphereVmRecoverFiles,
                    "Invoke-RscMutateVsphereVm -Recoverfile"
                },
                {
                    GqlOperationName.vsphereVmRecoverFilesNew,
                    "Invoke-RscMutateVsphereVm -Recoverfilesnew"
                },
                {
                    GqlOperationName.vsphereVmRegisterAgent,
                    "Invoke-RscMutateVsphereVm -Registeragent"
                },
                {
                    GqlOperationName.vsphereVmwareCdpLiveInfo,
                    "Invoke-RscQueryVsphere -Vmwarecdpliveinfo"
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