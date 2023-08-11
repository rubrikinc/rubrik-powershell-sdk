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
        public static string GraphqlSchemaVersion = "v20230802-35" ;

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
                    "KubernetesCluster",
                    "KubernetesResourceSet",
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
                    "KubernetesResourceSet",
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
                    "KubernetesCluster",
                    "KubernetesResourceSet",
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
                    "KubernetesResourceSet",
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
                    "KubernetesClusterDescendant",
                    new HashSet<string> {
                    "KubernetesClusterDescendant",
                    "KubernetesResourceSet",
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
                    "VsphereDatacenter",
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereFolderLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenter",
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
                    "VsphereFolder",
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
                    "ActivitySeriesGroupByInfo",
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
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
                    "M365TrialLicenseParams",
                    new HashSet<string> {
                    "TrialParams",
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
                    "NfAnomalyResultGroupByInfo",
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
            addDb2Instance,
            addK8sCluster,
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
            allAwsPermissionPolicies,
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
            awsCloudAccountInitiate,
            awsCloudAccountListSecurityGroups,
            awsCloudAccountListSubnets,
            awsCloudAccountListVpcs,
            awsCloudAccountUpdateFeature,
            awsCloudAccountValidate,
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
            awsNativeProtectionAccountAdd,
            awsNativeRdsExportDefaults,
            awsNativeRdsInstance,
            awsNativeRdsInstances,
            awsNativeRdsPointInTimeRestoreWindow,
            awsNativeRoot,
            awsNativeS3Bucket,
            awsTrustPolicy,
            azureAdDirectories,
            azureAdDirectory,
            azureAdObjectsByType,
            azureCloudAccountCheckRefreshTokenExistsForRecovery,
            azureCloudAccountGrantedPermissionsGroups,
            azureCloudAccountGrantedPermissionsGroupsForRecovery,
            azureCloudAccountPermissionConfig,
            azureCloudAccountSubscriptionWithFeatures,
            azureCloudAccountTenant,
            azureCloudAccountTenantWithExoConfigs,
            azureNativeLiveMountDisks,
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
            clusterReportMigrationCount,
            clusterReportMigrationJobStatus,
            clusterReportMigrationStatus,
            clusterSlaDomainFilterConnection,
            clusterSlaDomains,
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
            createOnDemandDb2Backup,
            createOnDemandMongoDatabaseBackup,
            createOnDemandMssqlBackup,
            createOnDemandNutanixBackup,
            createOraclePdbRestore,
            createVsphereAdvancedTag,
            db2Database,
            db2Databases,
            db2Instance,
            db2Instances,
            db2LogSnapshot,
            db2LogSnapshots,
            db2RecoverableRange,
            db2RecoverableRanges,
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
            deleteDb2Database,
            deleteDb2Instance,
            deleteFailoverCluster,
            deleteGlobalSla,
            deleteHypervVirtualMachineSnapshot,
            deleteHypervVirtualMachineSnapshotMount,
            deleteK8sCluster,
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
            downloadSlaWithReplicationCsv,
            downloadVsphereVirtualMachineFiles,
            editGlobalSla,
            enableO365SharePoint,
            enableO365Teams,
            excludeAwsNativeEbsVolumesFromSnapshot,
            excludeAzureNativeManagedDisksFromSnapshot,
            expireDownloadedDb2Snapshots,
            exportHypervVirtualMachine,
            exportMssqlDatabase,
            exportNutanixSnapshot,
            exportO365Mailbox,
            exportO365TeamsFiles,
            exportO365Workload,
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
            kubernetesClusters,
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
            nutanixPrismCentralAsyncRequestStatus,
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
            protectedClustersForGlobalSla,
            rdsInstanceDetailsFromAws,
            recoverCassandraSource,
            recoverCloudCluster,
            recoverMongoSource,
            recoverMongodbSource,
            refreshDb2Database,
            refreshHypervScvmm,
            refreshHypervServer,
            refreshK8sCluster,
            refreshK8sV2Cluster,
            refreshNutanixCluster,
            refreshNutanixPrismCentral,
            refreshO365Org,
            refreshOracleDatabase,
            registerAgentHypervVirtualMachine,
            registerAgentNutanixVm,
            registerAwsFeatureArtifacts,
            registerCloudCluster,
            registerHypervScvmm,
            removeCdmCluster,
            removeLdapIntegration,
            restoreAzureAdObjectsWithPassword,
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
            slaDomain,
            slaDomainWithWarnings,
            slaDomainWithWarningsList,
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
            uniqueVSphereVCenterCount,
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
            vSphereComputeClusters,
            vSphereDatacenter,
            vSphereDatastore,
            vSphereDatastoreCluster,
            vSphereDatastoreClusters,
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
            verifySlaWithReplicationToCluster,
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
                    "Invoke-RscQueryAws -CloudAccountListKMSKeys"
                },
                {
                    GqlOperationName.accountId,
                    "Invoke-RscQueryAccount -Id"
                },
                {
                    GqlOperationName.accountSettings,
                    "Invoke-RscQueryAccount -Settings"
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
                    "Invoke-RscMutateAzure -AddCloudAccountExocomputeConfigurations"
                },
                {
                    GqlOperationName.addAzureCloudAccountWithoutOauth,
                    "Invoke-RscMutateAzure -AddCloudAccountWithoutOauth"
                },
                {
                    GqlOperationName.addDb2Instance,
                    "Invoke-RscMutateDb2 -AddInstance"
                },
                {
                    GqlOperationName.addK8sCluster,
                    "Invoke-RscMutateCluster -AddK8s"
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
                    "Invoke-RscQueryAccount -Owners"
                },
                {
                    GqlOperationName.allAccountProducts,
                    "Invoke-RscQueryAccount -Products"
                },
                {
                    GqlOperationName.allAccountsWithExocomputeMappings,
                    "Invoke-RscQueryAccount -SWithExocomputeMappings"
                },
                {
                    GqlOperationName.allAvailabilityZonesByRegionFromAws,
                    "Invoke-RscQueryAws -AllAvailabilityZonesByRegion"
                },
                {
                    GqlOperationName.allAwsCdmVersions,
                    "Invoke-RscQueryAws -AllCdmVersions"
                },
                {
                    GqlOperationName.allAwsCloudAccountConfigs,
                    "Invoke-RscQueryAws -AllCloudAccountConfigs"
                },
                {
                    GqlOperationName.allAwsCloudAccountsFeaturesWithExoConfigs,
                    "Invoke-RscQueryAws -AllCloudAccountsFeaturesWithExoConfigs"
                },
                {
                    GqlOperationName.allAwsCloudAccountsWithFeatures,
                    "Invoke-RscQueryAws -AllCloudAccountsWithFeatures"
                },
                {
                    GqlOperationName.allAwsComputeSettings,
                    "Invoke-RscQueryAws -AllComputeSettings"
                },
                {
                    GqlOperationName.allAwsExocomputeConfigs,
                    "Invoke-RscQueryAws -AllExocomputeConfigs"
                },
                {
                    GqlOperationName.allAwsInstanceProfileNames,
                    "Invoke-RscQueryAws -AllInstanceProfileNames"
                },
                {
                    GqlOperationName.allAwsPermissionPolicies,
                    "Invoke-RscQueryAws -AllPermissionPolicies"
                },
                {
                    GqlOperationName.allAwsRdsAuroraInstanceClasses,
                    "Invoke-RscQueryAws -AllRdsAuroraInstanceClasses"
                },
                {
                    GqlOperationName.allAwsRegions,
                    "Invoke-RscQueryAws -AllRegions"
                },
                {
                    GqlOperationName.allAzureArmTemplatesByFeature,
                    "Invoke-RscQueryAzure -AllArmTemplatesByFeature"
                },
                {
                    GqlOperationName.allAzureCdmVersions,
                    "Invoke-RscQueryAzure -AllCdmVersions"
                },
                {
                    GqlOperationName.allAzureCloudAccountMissingPermissions,
                    "Invoke-RscQueryAzure -AllCloudAccountMissingPermissions"
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
                    "Invoke-RscQueryAzure -AllCloudAccountTenants"
                },
                {
                    GqlOperationName.allAzureCloudAccountTenantsWithExoConfigs,
                    "Invoke-RscQueryAzure -AllCloudAccountTenantsWithExoConfigs"
                },
                {
                    GqlOperationName.allAzureDiskEncryptionSetsByRegion,
                    "Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion"
                },
                {
                    GqlOperationName.allAzureEncryptionKeys,
                    "Invoke-RscQueryAzure -AllEncryptionKeys"
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
                    "Invoke-RscQueryAzure -AllNativeVirtualMachineSizes"
                },
                {
                    GqlOperationName.allAzureNativeVirtualNetworks,
                    "Invoke-RscQueryAzure -AllNativeVirtualNetworks"
                },
                {
                    GqlOperationName.allAzureNsgs,
                    "Invoke-RscQueryAzure -AllNsgs"
                },
                {
                    GqlOperationName.allAzureRegions,
                    "Invoke-RscQueryAzure -AllRegions"
                },
                {
                    GqlOperationName.allAzureResourceGroups,
                    "Invoke-RscQueryAzure -AllResourceGroups"
                },
                {
                    GqlOperationName.allAzureSqlDatabaseServerElasticPools,
                    "Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools"
                },
                {
                    GqlOperationName.allAzureStorageAccounts,
                    "Invoke-RscQueryAzure -AllStorageAccounts"
                },
                {
                    GqlOperationName.allAzureSubnets,
                    "Invoke-RscQueryAzure -AllSubnets"
                },
                {
                    GqlOperationName.allAzureSubscriptionWithExocomputeMappings,
                    "Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings"
                },
                {
                    GqlOperationName.allAzureVnets,
                    "Invoke-RscQueryAzure -AllVnets"
                },
                {
                    GqlOperationName.allCdpSlaVmNames,
                    "Invoke-RscQuerySla -AllCdpVmNames"
                },
                {
                    GqlOperationName.allCloudClusters,
                    "Invoke-RscQueryCluster -Cloud"
                },
                {
                    GqlOperationName.allClusterGlobalSlas,
                    "Invoke-RscQuerySla -AllClusterGlobals"
                },
                {
                    GqlOperationName.allClusterReplicationTargets,
                    "Invoke-RscQueryCluster -ReplicationTargets"
                },
                {
                    GqlOperationName.allClusterWebCertsAndIpmis,
                    "Invoke-RscQueryCluster -WebCertsAndIpmis"
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
                    "Invoke-RscQueryAzure -AllHostedRegions"
                },
                {
                    GqlOperationName.allKmsEncryptionKeysByRegionFromAws,
                    "Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion"
                },
                {
                    GqlOperationName.allMssqlDatabaseRestoreFiles,
                    "Invoke-RscQueryMssql -AllDatabaseRestoreFiles"
                },
                {
                    GqlOperationName.allNcdSlaComplianceData,
                    "Invoke-RscQuerySla -AllNcdComplianceData"
                },
                {
                    GqlOperationName.allO365AdGroups,
                    "Invoke-RscQueryO365 -AllAdGroups"
                },
                {
                    GqlOperationName.allO365OrgStatuses,
                    "Invoke-RscQueryO365 -AllOrgStatuses"
                },
                {
                    GqlOperationName.allO365SubscriptionsAppTypeCounts,
                    "Invoke-RscQueryO365 -AllSubscriptionsAppTypeCounts"
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
                    "Invoke-RscQueryAws -AllS3BucketsDetails"
                },
                {
                    GqlOperationName.allS3BucketsFromAws,
                    "Invoke-RscQueryAws -AllS3Buckets"
                },
                {
                    GqlOperationName.allSlaIofilterStatuses,
                    "Invoke-RscQuerySla -AllIofilterStatuses"
                },
                {
                    GqlOperationName.allSlaSummariesByIds,
                    "Invoke-RscQuerySla -AllSummariesByIds"
                },
                {
                    GqlOperationName.allSupportedAwsRdsDatabaseInstanceClasses,
                    "Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses"
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
                    "Invoke-RscQueryAws -AllVpcs"
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
                    "Invoke-RscMutateMssql -AssignSlaDomainProperties"
                },
                {
                    GqlOperationName.assignMssqlSlaDomainPropertiesAsync,
                    "Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnappables,
                    "Invoke-RscMutateSla -AssignRetentionToSnappables"
                },
                {
                    GqlOperationName.assignRetentionSLAToSnapshots,
                    "Invoke-RscMutateSla -AssignRetentionToSnapshots"
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
                    "Invoke-RscMutateSla -AssignsForSnappableHierarchies"
                },
                {
                    GqlOperationName.awsArtifactsToDelete,
                    "Invoke-RscQueryAws -ArtifactsToDelete"
                },
                {
                    GqlOperationName.awsCloudAccountInitiate,
                    "Invoke-RscMutateAws -CloudAccountInitiate"
                },
                {
                    GqlOperationName.awsCloudAccountListSecurityGroups,
                    "Invoke-RscQueryAws -CloudAccountListSecurityGroups"
                },
                {
                    GqlOperationName.awsCloudAccountListSubnets,
                    "Invoke-RscQueryAws -CloudAccountListSubnets"
                },
                {
                    GqlOperationName.awsCloudAccountListVpcs,
                    "Invoke-RscQueryAws -CloudAccountListVpcs"
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
                    "Invoke-RscQueryAws -CloudAccountWithFeatures"
                },
                {
                    GqlOperationName.awsComputeSettings,
                    "Invoke-RscQueryAws -ComputeSettings"
                },
                {
                    GqlOperationName.awsNativeAccount,
                    "Invoke-RscQueryAws -NativeAccount"
                },
                {
                    GqlOperationName.awsNativeAccounts,
                    "Invoke-RscQueryAws -NativeAccounts"
                },
                {
                    GqlOperationName.awsNativeEbsVolume,
                    "Invoke-RscQueryAws -NativeEbsVolume"
                },
                {
                    GqlOperationName.awsNativeEbsVolumes,
                    "Invoke-RscQueryAws -NativeEbsVolumes"
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
                    GqlOperationName.awsNativeEc2Instances,
                    "Invoke-RscQueryAws -NativeEc2Instances"
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
                    "Invoke-RscQueryAws -NativeRdsExportDefaults"
                },
                {
                    GqlOperationName.awsNativeRdsInstance,
                    "Invoke-RscQueryAws -NativeRdsInstance"
                },
                {
                    GqlOperationName.awsNativeRdsInstances,
                    "Invoke-RscQueryAws -NativeRdsInstances"
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
                    GqlOperationName.awsTrustPolicy,
                    "Invoke-RscQueryAws -TrustPolicy"
                },
                {
                    GqlOperationName.azureAdDirectories,
                    "Invoke-RscQueryAzure -AdDirectories"
                },
                {
                    GqlOperationName.azureAdDirectory,
                    "Invoke-RscQueryAzure -AdDirectory"
                },
                {
                    GqlOperationName.azureAdObjectsByType,
                    "Invoke-RscQueryAzure -AdObjectsByType"
                },
                {
                    GqlOperationName.azureCloudAccountCheckRefreshTokenExistsForRecovery,
                    "Invoke-RscQueryAzure -CloudAccountCheckRefreshTokenExistsForRecovery"
                },
                {
                    GqlOperationName.azureCloudAccountGrantedPermissionsGroups,
                    "Invoke-RscQueryAzure -CloudAccountGrantedPermissionsGroups"
                },
                {
                    GqlOperationName.azureCloudAccountGrantedPermissionsGroupsForRecovery,
                    "Invoke-RscQueryAzure -CloudAccountGrantedPermissionsGroupsForRecovery"
                },
                {
                    GqlOperationName.azureCloudAccountPermissionConfig,
                    "Invoke-RscQueryAzure -CloudAccountPermissionConfig"
                },
                {
                    GqlOperationName.azureCloudAccountSubscriptionWithFeatures,
                    "Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures"
                },
                {
                    GqlOperationName.azureCloudAccountTenant,
                    "Invoke-RscQueryAzure -CloudAccountTenant"
                },
                {
                    GqlOperationName.azureCloudAccountTenantWithExoConfigs,
                    "Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs"
                },
                {
                    GqlOperationName.azureNativeLiveMountDisks,
                    "Invoke-RscQueryAzure -NativeLiveMountDisks"
                },
                {
                    GqlOperationName.azureNativeManagedDisk,
                    "Invoke-RscQueryAzure -NativeManagedDisk"
                },
                {
                    GqlOperationName.azureNativeManagedDisks,
                    "Invoke-RscQueryAzure -NativeManagedDisks"
                },
                {
                    GqlOperationName.azureNativeResourceGroup,
                    "Invoke-RscQueryAzure -NativeResourceGroup"
                },
                {
                    GqlOperationName.azureNativeResourceGroups,
                    "Invoke-RscQueryAzure -NativeResourceGroups"
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
                    GqlOperationName.azureNativeSubscriptions,
                    "Invoke-RscQueryAzure -NativeSubscriptions"
                },
                {
                    GqlOperationName.azureNativeVirtualMachine,
                    "Invoke-RscQueryAzure -NativeVirtualMachine"
                },
                {
                    GqlOperationName.azureNativeVirtualMachines,
                    "Invoke-RscQueryAzure -NativeVirtualMachines"
                },
                {
                    GqlOperationName.azureO365CheckNSGOutboundRules,
                    "Invoke-RscQueryAzureO365 -CheckNSGOutboundRules"
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
                    "Invoke-RscQueryAzureO365 -ValidateUserRoles"
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
                    "Invoke-RscQueryAzure -Regions"
                },
                {
                    GqlOperationName.azureResourceGroups,
                    "Invoke-RscQueryAzure -ResourceGroups"
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
                    GqlOperationName.azureSqlDatabaseServers,
                    "Invoke-RscQueryAzure -SqlDatabaseServers"
                },
                {
                    GqlOperationName.azureSqlDatabases,
                    "Invoke-RscQueryAzure -SqlDatabases"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDatabase,
                    "Invoke-RscQueryAzure -SqlManagedInstanceDatabase"
                },
                {
                    GqlOperationName.azureSqlManagedInstanceDatabases,
                    "Invoke-RscQueryAzure -SqlManagedInstanceDatabases"
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
                    GqlOperationName.azureSqlManagedInstanceServers,
                    "Invoke-RscQueryAzure -SqlManagedInstanceServers"
                },
                {
                    GqlOperationName.azureStorageAccounts,
                    "Invoke-RscQueryAzure -StorageAccounts"
                },
                {
                    GqlOperationName.azureSubnets,
                    "Invoke-RscQueryAzure -Subnets"
                },
                {
                    GqlOperationName.azureSubscriptions,
                    "Invoke-RscQueryAzure -Subscriptions"
                },
                {
                    GqlOperationName.azureVNets,
                    "Invoke-RscQueryAzure -VNets"
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
                    "Invoke-RscQueryO365 -BrowseTeamConvChannels"
                },
                {
                    GqlOperationName.bulkCreateOnDemandMssqlBackup,
                    "Invoke-RscMutateMssql -BulkCreateOnDemandBackup"
                },
                {
                    GqlOperationName.bulkDeleteAwsCloudAccountWithoutCft,
                    "Invoke-RscMutateAws -BulkDeleteCloudAccountWithoutCft"
                },
                {
                    GqlOperationName.bulkDeleteCassandraSources,
                    "Invoke-RscMutateCassandra -BulkDeleteSources"
                },
                {
                    GqlOperationName.bulkDeleteFailoverCluster,
                    "Invoke-RscMutateCluster -BulkDeleteFailover"
                },
                {
                    GqlOperationName.bulkDeleteMongodbSources,
                    "Invoke-RscMutateMongo -BulkDeletedbSources"
                },
                {
                    GqlOperationName.bulkOnDemandSnapshotNutanixVm,
                    "Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm"
                },
                {
                    GqlOperationName.bulkUpdateMssqlDbs,
                    "Invoke-RscMutateMssql -BulkUpdateDbs"
                },
                {
                    GqlOperationName.bulkUpdateOracleDatabases,
                    "Invoke-RscMutateOracle -BulkUpdateDatabases"
                },
                {
                    GqlOperationName.bulkUpdateOracleHosts,
                    "Invoke-RscMutateOracle -BulkUpdateHosts"
                },
                {
                    GqlOperationName.bulkUpdateOracleRacs,
                    "Invoke-RscMutateOracle -BulkUpdateRacs"
                },
                {
                    GqlOperationName.cancelActivitySeries,
                    "Invoke-RscMutateActivitySeries -Cancel"
                },
                {
                    GqlOperationName.cassandraColumnFamilies,
                    "Invoke-RscQueryCassandra -ColumnFamilies"
                },
                {
                    GqlOperationName.cassandraColumnFamily,
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
                    GqlOperationName.cassandraKeyspace,
                    "Invoke-RscQueryCassandra -Keyspace"
                },
                {
                    GqlOperationName.cassandraKeyspaces,
                    "Invoke-RscQueryCassandra -Keyspaces"
                },
                {
                    GqlOperationName.cassandraSource,
                    "Invoke-RscQueryCassandra -Source"
                },
                {
                    GqlOperationName.cassandraSources,
                    "Invoke-RscQueryCassandra -Sources"
                },
                {
                    GqlOperationName.cdmMssqlLogShippingTarget,
                    "Invoke-RscQueryMssql -CdmLogShippingTarget"
                },
                {
                    GqlOperationName.cdmMssqlLogShippingTargets,
                    "Invoke-RscQueryMssql -CdmLogShippingTargets"
                },
                {
                    GqlOperationName.checkAzurePersistentStorageSubscriptionCanUnmap,
                    "Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap"
                },
                {
                    GqlOperationName.cluster,
                    "Invoke-RscQueryCluster -Cluster"
                },
                {
                    GqlOperationName.clusterCertificates,
                    "Invoke-RscQueryCluster -Certificates"
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
                    "Invoke-RscQueryCluster -FloatingIps"
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
                    "Invoke-RscQueryCluster -NetworkInterfaces"
                },
                {
                    GqlOperationName.clusterNodes,
                    "Invoke-RscQueryCluster -Nodes"
                },
                {
                    GqlOperationName.clusterNtpServers,
                    "Invoke-RscQueryCluster -NtpServers"
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
                    "Invoke-RscQueryCluster -RcvLocations"
                },
                {
                    GqlOperationName.clusterRegistrationProductInfo,
                    "Invoke-RscQueryCluster -RegistrationProductInfo"
                },
                {
                    GqlOperationName.clusterReportMigrationCount,
                    "Invoke-RscQueryCluster -ReportMigrationCount"
                },
                {
                    GqlOperationName.clusterReportMigrationJobStatus,
                    "Invoke-RscQueryCluster -ReportMigrationJobStatus"
                },
                {
                    GqlOperationName.clusterReportMigrationStatus,
                    "Invoke-RscQueryCluster -ReportMigrationStatus"
                },
                {
                    GqlOperationName.clusterSlaDomainFilterConnection,
                    "Invoke-RscQuerySla -ClusterDomainFilterList"
                },
                {
                    GqlOperationName.clusterSlaDomains,
                    "Invoke-RscQuerySla -ClusterDomains"
                },
                {
                    GqlOperationName.clusterTypeList,
                    "Invoke-RscQueryCluster -TypeList"
                },
                {
                    GqlOperationName.clusterVlans,
                    "Invoke-RscQueryCluster -Vlans"
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
                    "Invoke-RscMutateAws -CreateExocomputeConfigs"
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
                    GqlOperationName.createOnDemandDb2Backup,
                    "Invoke-RscMutateDb2 -CreateOnDemandBackup"
                },
                {
                    GqlOperationName.createOnDemandMongoDatabaseBackup,
                    "Invoke-RscMutateMongo -CreateOnDemandDatabaseBackup"
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
                    GqlOperationName.db2Database,
                    "Invoke-RscQueryDb2 -Database"
                },
                {
                    GqlOperationName.db2Databases,
                    "Invoke-RscQueryDb2 -Databases"
                },
                {
                    GqlOperationName.db2Instance,
                    "Invoke-RscQueryDb2 -Instance"
                },
                {
                    GqlOperationName.db2Instances,
                    "Invoke-RscQueryDb2 -Instances"
                },
                {
                    GqlOperationName.db2LogSnapshot,
                    "Invoke-RscQueryDb2 -LogSnapshot"
                },
                {
                    GqlOperationName.db2LogSnapshots,
                    "Invoke-RscQueryDb2 -LogSnapshots"
                },
                {
                    GqlOperationName.db2RecoverableRange,
                    "Invoke-RscQueryDb2 -RecoverableRange"
                },
                {
                    GqlOperationName.db2RecoverableRanges,
                    "Invoke-RscQueryDb2 -RecoverableRanges"
                },
                {
                    GqlOperationName.deleteAllOracleDatabaseSnapshots,
                    "Invoke-RscMutateOracle -DeleteAllDatabaseSnapshots"
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
                    "Invoke-RscMutateAws -DeleteExocomputeConfigs"
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
                    "Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfigurations"
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
                    GqlOperationName.deleteDb2Database,
                    "Invoke-RscMutateDb2 -DeleteDatabase"
                },
                {
                    GqlOperationName.deleteDb2Instance,
                    "Invoke-RscMutateDb2 -DeleteInstance"
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
                    GqlOperationName.deleteK8sCluster,
                    "Invoke-RscMutateCluster -DeleteK8s"
                },
                {
                    GqlOperationName.deleteLdapPrincipals,
                    "Invoke-RscMutateLdap -DeletePrincipals"
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
                    "Invoke-RscMutateMssql -DeleteDbSnapshots"
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
                    GqlOperationName.deleteNutanixSnapshot,
                    "Invoke-RscMutateNutanix -DeleteSnapshot"
                },
                {
                    GqlOperationName.deleteNutanixSnapshots,
                    "Invoke-RscMutateNutanix -DeleteSnapshots"
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
                    GqlOperationName.discoverDb2Instance,
                    "Invoke-RscMutateDb2 -DiscoverInstance"
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
                    GqlOperationName.downloadDb2Snapshot,
                    "Invoke-RscMutateDb2 -DownloadSnapshot"
                },
                {
                    GqlOperationName.downloadDb2SnapshotsForPointInTimeRecovery,
                    "Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery"
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
                    "Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFiles"
                },
                {
                    GqlOperationName.downloadMssqlDatabaseBackupFiles,
                    "Invoke-RscMutateMssql -DownloadDatabaseBackupFiles"
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
                    "Invoke-RscMutateVsphere -DownloadVirtualMachineFiles"
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
                    "Invoke-RscMutateO365 -EnableTeams"
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
                    GqlOperationName.expireDownloadedDb2Snapshots,
                    "Invoke-RscMutateDb2 -ExpireDownloadedSnapshots"
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
                    GqlOperationName.exportO365TeamsFiles,
                    "Invoke-RscMutateO365 -ExportTeamsFiles"
                },
                {
                    GqlOperationName.exportO365Workload,
                    "Invoke-RscMutateO365 -ExportWorkload"
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
                    "Invoke-RscMutateSla -GetPendingAssignments"
                },
                {
                    GqlOperationName.globalSlaFilterConnection,
                    "Invoke-RscQuerySla -GlobalFilterList"
                },
                {
                    GqlOperationName.globalSlaStatuses,
                    "Invoke-RscQuerySla -GlobalStatuses"
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
                    "Invoke-RscMutateHyperv -DeleteAllSnapshots"
                },
                {
                    GqlOperationName.hypervHostAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -HostAsyncRequestStatus"
                },
                {
                    GqlOperationName.hypervMounts,
                    "Invoke-RscQueryHyperv -Mounts"
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
                    GqlOperationName.hypervScvmms,
                    "Invoke-RscQueryHyperv -Scvmms"
                },
                {
                    GqlOperationName.hypervServer,
                    "Invoke-RscQueryHyperv -Server"
                },
                {
                    GqlOperationName.hypervServers,
                    "Invoke-RscQueryHyperv -Servers"
                },
                {
                    GqlOperationName.hypervTopLevelDescendants,
                    "Invoke-RscQueryHyperv -TopLevelDescendants"
                },
                {
                    GqlOperationName.hypervVirtualMachine,
                    "Invoke-RscQueryHyperv -VirtualMachine"
                },
                {
                    GqlOperationName.hypervVirtualMachineAsyncRequestStatus,
                    "Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus"
                },
                {
                    GqlOperationName.hypervVirtualMachines,
                    "Invoke-RscQueryHyperv -VirtualMachines"
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
                    GqlOperationName.kubernetesClusters,
                    "Invoke-RscQueryCluster -Kubernetes"
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
                    "Invoke-RscQueryO365 -ListApps"
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
                    GqlOperationName.mongoBulkRecoverableRanges,
                    "Invoke-RscQueryMongo -BulkRecoverableRanges"
                },
                {
                    GqlOperationName.mongoCollection,
                    "Invoke-RscQueryMongo -Collection"
                },
                {
                    GqlOperationName.mongoCollections,
                    "Invoke-RscQueryMongo -Collections"
                },
                {
                    GqlOperationName.mongoDatabase,
                    "Invoke-RscQueryMongo -Database"
                },
                {
                    GqlOperationName.mongoDatabases,
                    "Invoke-RscQueryMongo -Databases"
                },
                {
                    GqlOperationName.mongoRecoverableRanges,
                    "Invoke-RscQueryMongo -RecoverableRanges"
                },
                {
                    GqlOperationName.mongoSource,
                    "Invoke-RscQueryMongo -Source"
                },
                {
                    GqlOperationName.mongoSources,
                    "Invoke-RscQueryMongo -Sources"
                },
                {
                    GqlOperationName.mongodbBulkRecoverableRange,
                    "Invoke-RscQueryMongo -DbBulkRecoverableRange"
                },
                {
                    GqlOperationName.mongodbCollection,
                    "Invoke-RscQueryMongo -DbCollection"
                },
                {
                    GqlOperationName.mongodbCollectionRecoverableRange,
                    "Invoke-RscQueryMongo -DbCollectionRecoverableRange"
                },
                {
                    GqlOperationName.mongodbCollections,
                    "Invoke-RscQueryMongo -DbCollections"
                },
                {
                    GqlOperationName.mongodbDatabase,
                    "Invoke-RscQueryMongo -DbDatabase"
                },
                {
                    GqlOperationName.mongodbDatabases,
                    "Invoke-RscQueryMongo -DbDatabases"
                },
                {
                    GqlOperationName.mongodbSource,
                    "Invoke-RscQueryMongo -DbSource"
                },
                {
                    GqlOperationName.mongodbSources,
                    "Invoke-RscQueryMongo -DbSources"
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
                    "Invoke-RscQueryMssql -CompatibleInstances"
                },
                {
                    GqlOperationName.mssqlDatabase,
                    "Invoke-RscQueryMssql -Database"
                },
                {
                    GqlOperationName.mssqlDatabaseLiveMounts,
                    "Invoke-RscQueryMssql -DatabaseLiveMounts"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedRecoverableRanges,
                    "Invoke-RscQueryMssql -DatabaseMissedRecoverableRanges"
                },
                {
                    GqlOperationName.mssqlDatabaseMissedSnapshots,
                    "Invoke-RscQueryMssql -DatabaseMissedSnapshots"
                },
                {
                    GqlOperationName.mssqlDatabaseRestoreEstimate,
                    "Invoke-RscQueryMssql -DatabaseRestoreEstimate"
                },
                {
                    GqlOperationName.mssqlDatabases,
                    "Invoke-RscQueryMssql -Databases"
                },
                {
                    GqlOperationName.mssqlDefaultProperties,
                    "Invoke-RscQueryMssql -DefaultProperties"
                },
                {
                    GqlOperationName.mssqlInstance,
                    "Invoke-RscQueryMssql -Instance"
                },
                {
                    GqlOperationName.mssqlLogShippingTargets,
                    "Invoke-RscQueryMssql -LogShippingTargets"
                },
                {
                    GqlOperationName.mssqlRecoverableRanges,
                    "Invoke-RscQueryMssql -RecoverableRanges"
                },
                {
                    GqlOperationName.mssqlTopLevelDescendants,
                    "Invoke-RscQueryMssql -TopLevelDescendants"
                },
                {
                    GqlOperationName.nutanixBrowseSnapshot,
                    "Invoke-RscQueryNutanix -BrowseSnapshot"
                },
                {
                    GqlOperationName.nutanixCategory,
                    "Invoke-RscQueryNutanix -Category"
                },
                {
                    GqlOperationName.nutanixCategoryValue,
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
                    "Invoke-RscQueryNutanix -ClusterContainers"
                },
                {
                    GqlOperationName.nutanixClusterNetworks,
                    "Invoke-RscQueryNutanix -ClusterNetworks"
                },
                {
                    GqlOperationName.nutanixClusters,
                    "Invoke-RscQueryNutanix -Clusters"
                },
                {
                    GqlOperationName.nutanixMounts,
                    "Invoke-RscQueryNutanix -Mounts"
                },
                {
                    GqlOperationName.nutanixPrismCentral,
                    "Invoke-RscQueryNutanix -PrismCentral"
                },
                {
                    GqlOperationName.nutanixPrismCentralAsyncRequestStatus,
                    "Invoke-RscMutateNutanix -PrismCentralAsyncRequestStatus"
                },
                {
                    GqlOperationName.nutanixPrismCentrals,
                    "Invoke-RscQueryNutanix -PrismCentrals"
                },
                {
                    GqlOperationName.nutanixSnapshotDetail,
                    "Invoke-RscQueryNutanix -SnapshotDetail"
                },
                {
                    GqlOperationName.nutanixTopLevelDescendants,
                    "Invoke-RscQueryNutanix -TopLevelDescendants"
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
                    "Invoke-RscQueryNutanix -VmMissedSnapshots"
                },
                {
                    GqlOperationName.nutanixVms,
                    "Invoke-RscQueryNutanix -Vms"
                },
                {
                    GqlOperationName.o365Calendar,
                    "Invoke-RscQueryO365 -Calendar"
                },
                {
                    GqlOperationName.o365Groups,
                    "Invoke-RscQueryO365 -Groups"
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
                    "Invoke-RscQueryO365 -Mailboxes"
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
                    "Invoke-RscQueryO365 -ObjectAncestors"
                },
                {
                    GqlOperationName.o365Onedrive,
                    "Invoke-RscQueryO365 -Onedrive"
                },
                {
                    GqlOperationName.o365Onedrives,
                    "Invoke-RscQueryO365 -Onedrives"
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
                    "Invoke-RscQueryO365 -OrgSummaries"
                },
                {
                    GqlOperationName.o365Orgs,
                    "Invoke-RscQueryO365 -Orgs"
                },
                {
                    GqlOperationName.o365PdlGroups,
                    "Invoke-RscMutateO365 -PdlGroups"
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
                    GqlOperationName.o365SharepointDrives,
                    "Invoke-RscQueryO365 -SharepointDrives"
                },
                {
                    GqlOperationName.o365SharepointList,
                    "Invoke-RscQueryO365 -SharepointList"
                },
                {
                    GqlOperationName.o365SharepointLists,
                    "Invoke-RscQueryO365 -SharepointLists"
                },
                {
                    GqlOperationName.o365SharepointObjectList,
                    "Invoke-RscQueryO365 -SharepointObjectList"
                },
                {
                    GqlOperationName.o365SharepointObjects,
                    "Invoke-RscQueryO365 -SharepointObjects"
                },
                {
                    GqlOperationName.o365SharepointSite,
                    "Invoke-RscQueryO365 -SharepointSite"
                },
                {
                    GqlOperationName.o365SharepointSites,
                    "Invoke-RscQueryO365 -SharepointSites"
                },
                {
                    GqlOperationName.o365Site,
                    "Invoke-RscQueryO365 -Site"
                },
                {
                    GqlOperationName.o365Sites,
                    "Invoke-RscQueryO365 -Sites"
                },
                {
                    GqlOperationName.o365StorageStats,
                    "Invoke-RscQueryO365 -StorageStats"
                },
                {
                    GqlOperationName.o365Team,
                    "Invoke-RscQueryO365 -Team"
                },
                {
                    GqlOperationName.o365TeamChannels,
                    "Invoke-RscQueryO365 -TeamChannels"
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
                    GqlOperationName.o365Teams,
                    "Invoke-RscQueryO365 -Teams"
                },
                {
                    GqlOperationName.o365User,
                    "Invoke-RscQueryO365 -User"
                },
                {
                    GqlOperationName.o365UserObjects,
                    "Invoke-RscQueryO365 -UserObjects"
                },
                {
                    GqlOperationName.oracleAcoExampleDownloadLink,
                    "Invoke-RscQueryOracle -AcoExampleDownloadLink"
                },
                {
                    GqlOperationName.oracleAcoParameters,
                    "Invoke-RscQueryOracle -AcoParameters"
                },
                {
                    GqlOperationName.oracleDataGuardGroup,
                    "Invoke-RscQueryOracle -DataGuardGroup"
                },
                {
                    GqlOperationName.oracleDatabase,
                    "Invoke-RscQueryOracle -Database"
                },
                {
                    GqlOperationName.oracleDatabaseLogBackupConfig,
                    "Invoke-RscQueryOracle -DatabaseLogBackupConfig"
                },
                {
                    GqlOperationName.oracleDatabases,
                    "Invoke-RscQueryOracle -Databases"
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
                    "Invoke-RscQueryOracle -LiveMounts"
                },
                {
                    GqlOperationName.oracleMissedRecoverableRanges,
                    "Invoke-RscQueryOracle -MissedRecoverableRanges"
                },
                {
                    GqlOperationName.oracleMissedSnapshots,
                    "Invoke-RscQueryOracle -MissedSnapshots"
                },
                {
                    GqlOperationName.oraclePdbDetails,
                    "Invoke-RscQueryOracle -PdbDetails"
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
                    "Invoke-RscQueryOracle -RecoverableRanges"
                },
                {
                    GqlOperationName.oracleTopLevelDescendants,
                    "Invoke-RscQueryOracle -TopLevelDescendants"
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
                    GqlOperationName.patchDb2Database,
                    "Invoke-RscMutateDb2 -PatchDatabase"
                },
                {
                    GqlOperationName.patchDb2Instance,
                    "Invoke-RscMutateDb2 -PatchInstance"
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
                    "Invoke-RscQueryAws -RdsInstanceDetails"
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
                    GqlOperationName.refreshDb2Database,
                    "Invoke-RscMutateDb2 -RefreshDatabase"
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
                    GqlOperationName.refreshK8sV2Cluster,
                    "Invoke-RscMutateCluster -RefreshK8sV2"
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
                    GqlOperationName.registerAwsFeatureArtifacts,
                    "Invoke-RscMutateAws -RegisterFeatureArtifacts"
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
                    GqlOperationName.restoreAzureAdObjectsWithPassword,
                    "Invoke-RscMutateAzure -RestoreAdObjectsWithPassword"
                },
                {
                    GqlOperationName.restoreFilesNutanixSnapshot,
                    "Invoke-RscMutateNutanix -RestoreFilesSnapshot"
                },
                {
                    GqlOperationName.restoreHypervVirtualMachineSnapshotFiles,
                    "Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFiles"
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
                    "Invoke-RscMutateO365 -RestoreTeamsConversations"
                },
                {
                    GqlOperationName.restoreO365TeamsFiles,
                    "Invoke-RscMutateO365 -RestoreTeamsFiles"
                },
                {
                    GqlOperationName.restoreOracleLogs,
                    "Invoke-RscMutateOracle -RestoreLogs"
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
                    "Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredentials"
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
                    "Invoke-RscQuerySla -ArchivalValidationWarnings"
                },
                {
                    GqlOperationName.slaAuditDetail,
                    "Invoke-RscQuerySla -AuditDetail"
                },
                {
                    GqlOperationName.slaConflictObjects,
                    "Invoke-RscQuerySla -ConflictObjects"
                },
                {
                    GqlOperationName.slaDomain,
                    "Invoke-RscQuerySla -Domain"
                },
                {
                    GqlOperationName.slaDomainWithWarnings,
                    "Invoke-RscQuerySla -DomainWithWarnings"
                },
                {
                    GqlOperationName.slaDomainWithWarningsList,
                    "Invoke-RscQuerySla -DomainWithWarningsList"
                },
                {
                    GqlOperationName.slaDomains,
                    "Invoke-RscQuerySla -Domains"
                },
                {
                    GqlOperationName.slaManagedVolume,
                    "Invoke-RscQuerySla -ManagedVolume"
                },
                {
                    GqlOperationName.slaManagedVolumes,
                    "Invoke-RscQuerySla -ManagedVolumes"
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
                    GqlOperationName.unmapAzurePersistentStorageSubscription,
                    "Invoke-RscMutateAzure -UnmapPersistentStorageSubscription"
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
                    "Invoke-RscMutateAws -UpdateExocomputeConfigs"
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
                    "Invoke-RscMutateMssql -UpdateDefaultProperties"
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
                    "Invoke-RscMutateO365 -UpdateAppPermissions"
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
                    "Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermissions"
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
                    "Invoke-RscMutateSla -Upgrades"
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
                    "Invoke-RscQueryVcenter -Networks"
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
                    GqlOperationName.vSphereComputeClusters,
                    "Invoke-RscQueryVsphere -ComputeClusters"
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
                    GqlOperationName.vSphereDatastoreClusters,
                    "Invoke-RscQueryVsphere -DatastoreClusters"
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
                    "Invoke-RscQueryVsphere -HostDetails"
                },
                {
                    GqlOperationName.vSphereHostsByFids,
                    "Invoke-RscQueryVsphere -HostsByFids"
                },
                {
                    GqlOperationName.vSphereLiveMounts,
                    "Invoke-RscQueryVsphere -LiveMounts"
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
                    "Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations"
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
                    "Invoke-RscMutateOracle -ValidateDatabaseBackups"
                },
                {
                    GqlOperationName.vcdClusters,
                    "Invoke-RscQueryCluster -Vcd"
                },
                {
                    GqlOperationName.verifySlaWithReplicationToCluster,
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
                    "Invoke-RscMutateVsphereVm -ExcludeVmDisks"
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
                    "Invoke-RscMutateVsphereVm -DownloadSnapshotFiles"
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
                    "Invoke-RscMutateVsphereVm -ListEsxiDatastores"
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
                    "Invoke-RscMutateVsphereVm -RecoverFiles"
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
                    "Invoke-RscQueryCluster -Windows"
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