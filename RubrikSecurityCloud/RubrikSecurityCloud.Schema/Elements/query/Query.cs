// Query.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Query
    public class Query
    {
        #region members
        //      C# -> List<Operation>? AllAllowedOrgAdminOperations
        // GraphQL -> allAllowedOrgAdminOperations: [Operation!]! (enum)
        public static string AllAllowedOrgAdminOperations(
            ref List<Operation>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAllowedOrgAdminOperations" + args + "\n");
        }

        //      C# -> List<Operation>? AllAuthorizationsForGlobalResource
        // GraphQL -> allAuthorizationsForGlobalResource: [Operation!]! (enum)
        public static string AllAuthorizationsForGlobalResource(
            ref List<Operation>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAuthorizationsForGlobalResource" + args + "\n");
        }

        //      C# -> List<Operation>? AllAuthorizationsForObject
        // GraphQL -> allAuthorizationsForObject: [Operation!]! (enum)
        public static string AllAuthorizationsForObject(
            ref List<Operation>? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAuthorizationsForObject" + args + "\n");
        }

        //      C# -> List<AwsCloudAccountRegion>? AllAwsRegions
        // GraphQL -> allAwsRegions: [AwsCloudAccountRegion!]! (enum)
        public static string AllAwsRegions(
            ref List<AwsCloudAccountRegion>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAwsRegions" + args + "\n");
        }

        //      C# -> List<AzureCloudAccountRegion>? AllAzureRegions
        // GraphQL -> allAzureRegions: [AzureCloudAccountRegion!]! (enum)
        public static string AllAzureRegions(
            ref List<AzureCloudAccountRegion>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureRegions" + args + "\n");
        }

        //      C# -> List<InventoryCard>? AllInventoryWorkloads
        // GraphQL -> allInventoryWorkloads: [InventoryCard!]! (enum)
        public static string AllInventoryWorkloads(
            ref List<InventoryCard>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allInventoryWorkloads" + args + "\n");
        }

        //      C# -> List<ManagedObjectType>? AllUnmanagedObjectsSupportedTypes
        // GraphQL -> allUnmanagedObjectsSupportedTypes: [ManagedObjectType!]! (enum)
        public static string AllUnmanagedObjectsSupportedTypes(
            ref List<ManagedObjectType>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allUnmanagedObjectsSupportedTypes" + args + "\n");
        }

        //      C# -> TenantAuthDomainConfig? CurrentOrgAuthDomainConfig
        // GraphQL -> currentOrgAuthDomainConfig: TenantAuthDomainConfig! (enum)
        public static string CurrentOrgAuthDomainConfig(
            ref TenantAuthDomainConfig? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("currentOrgAuthDomainConfig" + args + "\n");
        }

        //      C# -> List<FeatureName>? ToggleableFeaturesEnabled
        // GraphQL -> toggleableFeaturesEnabled: [FeatureName!]! (enum)
        public static string ToggleableFeaturesEnabled(
            ref List<FeatureName>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("toggleableFeaturesEnabled" + args + "\n");
        }

        //      C# -> List<ResourceSpec>? AllBlueprintResourceSpecs
        // GraphQL -> allBlueprintResourceSpecs: [ResourceSpec!]! (interface)
        public static string AllBlueprintResourceSpecs(
            ref List<ResourceSpec>? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nsnappableInfos: $snappableInfos\nfailoverId: $failoverId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ResourceSpec>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allBlueprintResourceSpecs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccount>? AllCloudAccounts
        // GraphQL -> allCloudAccounts: [CloudAccount!]! (interface)
        public static string AllCloudAccounts(
            ref List<CloudAccount>? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfeatures: $features\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudAccount>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ResourceSpec>? AllSnappableResourceSpecs
        // GraphQL -> allSnappableResourceSpecs: [ResourceSpec!]! (interface)
        public static string AllSnappableResourceSpecs(
            ref List<ResourceSpec>? cmdletReply
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ResourceSpec>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnappableResourceSpecs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Target>? AllTargets
        // GraphQL -> allTargets: [Target!]! (interface)
        public static string AllTargets(
            ref List<Target>? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Target>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTargets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Blueprint? Blueprint
        // GraphQL -> blueprint: Blueprint! (interface)
        public static string Blueprint(
            ref Blueprint? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                var list = new List<Blueprint>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Blueprint?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Blueprint? composite object");
                }
            }
            return new string(
                "blueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNew? BlueprintNew
        // GraphQL -> blueprintNew: BlueprintNew! (interface)
        public static string BlueprintNew(
            ref BlueprintNew? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                var list = new List<BlueprintNew>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (BlueprintNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create BlueprintNew? composite object");
                }
            }
            return new string(
                "blueprintNew" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchySnappableNew? CdmHierarchySnappableNew
        // GraphQL -> cdmHierarchySnappableNew: CdmHierarchySnappableNew! (interface)
        public static string CdmHierarchySnappableNew(
            ref CdmHierarchySnappableNew? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                var list = new List<CdmHierarchySnappableNew>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CdmHierarchySnappableNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CdmHierarchySnappableNew? composite object");
                }
            }
            return new string(
                "cdmHierarchySnappableNew" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmHierarchySnappableNew>? CdmHierarchySnappablesNew
        // GraphQL -> cdmHierarchySnappablesNew: [CdmHierarchySnappableNew!]! (interface)
        public static string CdmHierarchySnappablesNew(
            ref List<CdmHierarchySnappableNew>? cmdletReply
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CdmHierarchySnappableNew>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmHierarchySnappablesNew" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        public static string CloudAccount(
            ref CloudAccount? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if (cmdletReply == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "cloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        public static string HierarchyObject(
            ref HierarchyObject? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                var list = new List<HierarchyObject>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (HierarchyObject?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create HierarchyObject? composite object");
                }
            }
            return new string(
                "hierarchyObject" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject!]! (interface)
        public static string HierarchyObjects(
            ref List<HierarchyObject>? cmdletReply
        )
        {
            string args = "\n(\nfids: $fids\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<HierarchyObject>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hierarchyObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<HierarchyObject>? SlaConflictObjects
        // GraphQL -> slaConflictObjects: [HierarchyObject!]! (interface)
        public static string SlaConflictObjects(
            ref List<HierarchyObject>? cmdletReply
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<HierarchyObject>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaConflictObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        public static string SlaDomain(
            ref SlaDomain? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (cmdletReply == null)
            {
                var list = new List<SlaDomain>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (SlaDomain?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create SlaDomain? composite object");
                }
            }
            return new string(
                "slaDomain" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaDomain>? SlaSummariesByIds
        // GraphQL -> slaSummariesByIds: [SlaDomain!]! (interface)
        public static string SlaSummariesByIds(
            ref List<SlaDomain>? cmdletReply
        )
        {
            string args = "\n(\nslaIds: $slaIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SlaDomain>();
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaSummariesByIds" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        public static string Target(
            ref Target? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                cmdletReply = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (cmdletReply == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "target" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        public static string AccountId(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("accountId" + args + "\n");
        }

        //      C# -> List<System.String>? AllAvailabilityZonesByRegionFromAws
        // GraphQL -> allAvailabilityZonesByRegionFromAws: [String!]! (scalar)
        public static string AllAvailabilityZonesByRegionFromAws(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAvailabilityZonesByRegionFromAws" + args + "\n");
        }

        //      C# -> List<System.String>? AllAwsInstanceProfileNames
        // GraphQL -> allAwsInstanceProfileNames: [String!]! (scalar)
        public static string AllAwsInstanceProfileNames(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAwsInstanceProfileNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureNativeVirtualMachineSizes
        // GraphQL -> allAzureNativeVirtualMachineSizes: [String!]! (scalar)
        public static string AllAzureNativeVirtualMachineSizes(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureNativeVirtualMachineSizes" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureNsgs
        // GraphQL -> allAzureNsgs: [String!]! (scalar)
        public static string AllAzureNsgs(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nnsgRequest: $nsgRequest\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureNsgs" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureResourceGroups
        // GraphQL -> allAzureResourceGroups: [String!]! (scalar)
        public static string AllAzureResourceGroups(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureRegion: $azureRegion\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureResourceGroups" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureStorageAccounts
        // GraphQL -> allAzureStorageAccounts: [String!]! (scalar)
        public static string AllAzureStorageAccounts(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nstorageAccountsRequest: $storageAccountsRequest\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureStorageAccounts" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureSubnets
        // GraphQL -> allAzureSubnets: [String!]! (scalar)
        public static string AllAzureSubnets(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nsubnetRequest: $subnetRequest\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureSubnets" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureVnets
        // GraphQL -> allAzureVnets: [String!]! (scalar)
        public static string AllAzureVnets(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nvnetRequest: $vnetRequest\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allAzureVnets" + args + "\n");
        }

        //      C# -> List<System.String>? AllCdpSlaVmNames
        // GraphQL -> allCdpSlaVmNames: [String!]! (scalar)
        public static string AllCdpSlaVmNames(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCdpSlaVmNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeFileRecoveryEligibleSnapshots
        // GraphQL -> allCloudNativeFileRecoveryEligibleSnapshots: [String!]! (scalar)
        public static string AllCloudNativeFileRecoveryEligibleSnapshots(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCloudNativeFileRecoveryEligibleSnapshots" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeLabelKeys
        // GraphQL -> allCloudNativeLabelKeys: [String!]! (scalar)
        public static string AllCloudNativeLabelKeys(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCloudNativeLabelKeys" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeLabelValues
        // GraphQL -> allCloudNativeLabelValues: [String!]! (scalar)
        public static string AllCloudNativeLabelValues(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCloudNativeLabelValues" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeTagKeys
        // GraphQL -> allCloudNativeTagKeys: [String!]! (scalar)
        public static string AllCloudNativeTagKeys(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCloudNativeTagKeys" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeTagValues
        // GraphQL -> allCloudNativeTagValues: [String!]! (scalar)
        public static string AllCloudNativeTagValues(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allCloudNativeTagValues" + args + "\n");
        }

        //      C# -> List<System.Boolean>? AllClustersTotpAckStatus
        // GraphQL -> allClustersTotpAckStatus: [Boolean!]! (scalar)
        public static string AllClustersTotpAckStatus(
            ref List<System.Boolean>? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allClustersTotpAckStatus" + args + "\n");
        }

        //      C# -> List<System.String>? AllDeploymentIpAddresses
        // GraphQL -> allDeploymentIpAddresses: [String!]! (scalar)
        public static string AllDeploymentIpAddresses(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allDeploymentIpAddresses" + args + "\n");
        }

        //      C# -> List<System.String>? AllEc2KeyPairsByRegionFromAws
        // GraphQL -> allEc2KeyPairsByRegionFromAws: [String!]! (scalar)
        public static string AllEc2KeyPairsByRegionFromAws(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allEc2KeyPairsByRegionFromAws" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeCompatibleMachineTypes
        // GraphQL -> allGcpNativeCompatibleMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeCompatibleMachineTypes(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\ntargetZone: $targetZone\nsnapshotId: $snapshotId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeCompatibleMachineTypes" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypes
        // GraphQL -> allGcpNativeStoredMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypes(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredMachineTypes" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypesInProject
        // GraphQL -> allGcpNativeStoredMachineTypesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypesInProject(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredMachineTypesInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNames
        // GraphQL -> allGcpNativeStoredNetworkNames: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNames(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredNetworkNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNamesInProject
        // GraphQL -> allGcpNativeStoredNetworkNamesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNamesInProject(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredNetworkNamesInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegions
        // GraphQL -> allGcpNativeStoredRegions: [String!]! (scalar)
        public static string AllGcpNativeStoredRegions(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredRegions" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegionsInProject
        // GraphQL -> allGcpNativeStoredRegionsInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredRegionsInProject(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allGcpNativeStoredRegionsInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllIssuesJobIds
        // GraphQL -> allIssuesJobIds: [String!]! (scalar)
        public static string AllIssuesJobIds(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nqueryIds: $queryIds\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allIssuesJobIds" + args + "\n");
        }

        //      C# -> List<System.String>? AllS3BucketsFromAws
        // GraphQL -> allS3BucketsFromAws: [String!]! (scalar)
        public static string AllS3BucketsFromAws(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("allS3BucketsFromAws" + args + "\n");
        }

        //      C# -> System.Boolean? AreMultiGeoBackupsEnabled
        // GraphQL -> areMultiGeoBackupsEnabled: Boolean! (scalar)
        public static string AreMultiGeoBackupsEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("areMultiGeoBackupsEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? CloudNativeCheckRequiredPermissionsForFeature
        // GraphQL -> cloudNativeCheckRequiredPermissionsForFeature: Boolean! (scalar)
        public static string CloudNativeCheckRequiredPermissionsForFeature(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ncloudNativeAccountId: $cloudNativeAccountId\nfeaturePermissionCheck: $featurePermissionCheck\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("cloudNativeCheckRequiredPermissionsForFeature" + args + "\n");
        }

        //      C# -> System.String? CurrentIpAddress
        // GraphQL -> currentIpAddress: String! (scalar)
        public static string CurrentIpAddress(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("currentIpAddress" + args + "\n");
        }

        //      C# -> System.String? DeploymentVersion
        // GraphQL -> deploymentVersion: String! (scalar)
        public static string DeploymentVersion(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("deploymentVersion" + args + "\n");
        }

        //      C# -> System.Boolean? DoesAzureNativeResourceGroupExist
        // GraphQL -> doesAzureNativeResourceGroupExist: Boolean! (scalar)
        public static string DoesAzureNativeResourceGroupExist(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nresourceGroupName: $resourceGroupName\nfeature: $feature\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("doesAzureNativeResourceGroupExist" + args + "\n");
        }

        //      C# -> System.Boolean? DummyFieldWithAdminOnlyTag
        // GraphQL -> dummyFieldWithAdminOnlyTag: Boolean! (scalar)
        public static string DummyFieldWithAdminOnlyTag(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("dummyFieldWithAdminOnlyTag" + args + "\n");
        }

        //      C# -> System.String? ExternalDeploymentName
        // GraphQL -> externalDeploymentName: String! (scalar)
        public static string ExternalDeploymentName(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("externalDeploymentName" + args + "\n");
        }

        //      C# -> List<System.String>? FeatureFlagNames
        // GraphQL -> featureFlagNames: [String!]! (scalar)
        public static string FeatureFlagNames(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("featureFlagNames" + args + "\n");
        }

        //      C# -> List<System.String>? FlagrFeatureFlagNames
        // GraphQL -> flagrFeatureFlagNames: [String!]! (scalar)
        public static string FlagrFeatureFlagNames(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("flagrFeatureFlagNames" + args + "\n");
        }

        //      C# -> System.String? GcpGetDefaultCredentialsServiceAccount
        // GraphQL -> gcpGetDefaultCredentialsServiceAccount: String! (scalar)
        public static string GcpGetDefaultCredentialsServiceAccount(
            ref System.String? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("gcpGetDefaultCredentialsServiceAccount" + args + "\n");
        }

        //      C# -> List<System.String>? GetDns
        // GraphQL -> getDns: [String!]! (scalar)
        public static string GetDns(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("getDns" + args + "\n");
        }

        //      C# -> List<System.String>? GetNtp
        // GraphQL -> getNtp: [String!]! (scalar)
        public static string GetNtp(
            ref List<System.String>? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("getNtp" + args + "\n");
        }

        //      C# -> System.Boolean? HasIdpConfigured
        // GraphQL -> hasIdpConfigured: Boolean! (scalar)
        public static string HasIdpConfigured(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("hasIdpConfigured" + args + "\n");
        }

        //      C# -> System.Int32? HostVolumesCount
        // GraphQL -> hostVolumesCount: Int! (scalar)
        public static string HostVolumesCount(
            ref System.Int32? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("hostVolumesCount" + args + "\n");
        }

        //      C# -> System.Boolean? IsAwsNativeRdsInstanceLaunchConfigurationValid
        // GraphQL -> isAwsNativeRdsInstanceLaunchConfigurationValid: Boolean! (scalar)
        public static string IsAwsNativeRdsInstanceLaunchConfigurationValid(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\ndbClass: $dbClass\nprimaryAz: $primaryAz\nstorageType: $storageType\nisMultiAz: $isMultiAz\nkmsKeyId: $kmsKeyId\niops: $iops\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isAwsNativeRdsInstanceLaunchConfigurationValid" + args + "\n");
        }

        //      C# -> System.Boolean? IsAwsS3BucketNameAvailable
        // GraphQL -> isAwsS3BucketNameAvailable: Boolean! (scalar)
        public static string IsAwsS3BucketNameAvailable(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isAwsS3BucketNameAvailable" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureNativeManagedDiskSnapshotRestorable
        // GraphQL -> isAzureNativeManagedDiskSnapshotRestorable: Boolean! (scalar)
        public static string IsAzureNativeManagedDiskSnapshotRestorable(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\ndiskSnapshotId: $diskSnapshotId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isAzureNativeManagedDiskSnapshotRestorable" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureNativeSqlDatabaseSnapshotPersistent
        // GraphQL -> isAzureNativeSqlDatabaseSnapshotPersistent: Boolean! (scalar)
        public static string IsAzureNativeSqlDatabaseSnapshotPersistent(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isAzureNativeSqlDatabaseSnapshotPersistent" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureStorageAccountNameAvailable
        // GraphQL -> isAzureStorageAccountNameAvailable: Boolean! (scalar)
        public static string IsAzureStorageAccountNameAvailable(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nstorageAccountName: $storageAccountName\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isAzureStorageAccountNameAvailable" + args + "\n");
        }

        //      C# -> System.Boolean? IsSfdcReachable
        // GraphQL -> isSfdcReachable: Boolean! (scalar)
        public static string IsSfdcReachable(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nhostname: $hostname\norganizationId: $organizationId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isSfdcReachable" + args + "\n");
        }

        //      C# -> System.Boolean? IsTotpAckNecessaryForCluster
        // GraphQL -> isTotpAckNecessaryForCluster: Boolean! (scalar)
        public static string IsTotpAckNecessaryForCluster(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isTotpAckNecessaryForCluster" + args + "\n");
        }

        //      C# -> System.Boolean? IsTotpMandatoryInTargetVersion
        // GraphQL -> isTotpMandatoryInTargetVersion: Boolean! (scalar)
        public static string IsTotpMandatoryInTargetVersion(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nversion: $version\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isTotpMandatoryInTargetVersion" + args + "\n");
        }

        //      C# -> System.Boolean? IsVmwareManagementEnabled
        // GraphQL -> isVMwareManagementEnabled: Boolean! (scalar)
        public static string IsVmwareManagementEnabled(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("isVMwareManagementEnabled" + args + "\n");
        }

        //      C# -> System.Int32? MaxProtectedAppsCount
        // GraphQL -> maxProtectedAppsCount: Int! (scalar)
        public static string MaxProtectedAppsCount(
            ref System.Int32? cmdletReply
        )
        {
            string args = "";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("maxProtectedAppsCount" + args + "\n");
        }

        //      C# -> System.String? O365TeamConversationsFolderId
        // GraphQL -> o365TeamConversationsFolderID: String! (scalar)
        public static string O365TeamConversationsFolderId(
            ref System.String? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\no365OrgId: $o365OrgId\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("o365TeamConversationsFolderID" + args + "\n");
        }

        //      C# -> System.Boolean? TeamChannelNameAvailable
        // GraphQL -> teamChannelNameAvailable: Boolean! (scalar)
        public static string TeamChannelNameAvailable(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\nteamUUID: $teamUUID\nchannelName: $channelName\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("teamChannelNameAvailable" + args + "\n");
        }

        //      C# -> System.Int32? UniqueHypervServersCount
        // GraphQL -> uniqueHypervServersCount: Int! (scalar)
        public static string UniqueHypervServersCount(
            ref System.Int32? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("uniqueHypervServersCount" + args + "\n");
        }

        //      C# -> System.Int32? UniqueVsphereVcenterCount
        // GraphQL -> uniqueVSphereVCenterCount: Int! (scalar)
        public static string UniqueVsphereVcenterCount(
            ref System.Int32? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("uniqueVSphereVCenterCount" + args + "\n");
        }

        //      C# -> System.Int32? UniqueVcdCount
        // GraphQL -> uniqueVcdCount: Int! (scalar)
        public static string UniqueVcdCount(
            ref System.Int32? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("uniqueVcdCount" + args + "\n");
        }

        //      C# -> System.Int32? VcenterNumProxiesNeeded
        // GraphQL -> vCenterNumProxiesNeeded: Int! (scalar)
        public static string VcenterNumProxiesNeeded(
            ref System.Int32? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("vCenterNumProxiesNeeded" + args + "\n");
        }

        //      C# -> System.Boolean? VerifyVappTemplateName
        // GraphQL -> verifyVappTemplateName: Boolean! (scalar)
        public static string VerifyVappTemplateName(
            ref System.Boolean? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            // TODO: SPARK-195026 function signature for scalar types?
            return new string("verifyVappTemplateName" + args + "\n");
        }

        //      C# -> AwsCloudAccountListKmsKeysResponse? AwsCloudAccountListKmsKeys
        // GraphQL -> AwsCloudAccountListKMSKeys: AwsCloudAccountListKMSKeysResponse! (type)
        public static string AwsCloudAccountListKmsKeys(
            ref AwsCloudAccountListKmsKeysResponse? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountListKmsKeysResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "AwsCloudAccountListKMSKeys" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccountSetting? AccountSettings
        // GraphQL -> accountSettings: AccountSetting! (type)
        public static string AccountSettings(
            ref AccountSetting? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AccountSetting() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "accountSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerConnection? ActiveCustomAnalyzers
        // GraphQL -> activeCustomAnalyzers: AnalyzerConnection! (type)
        public static string ActiveCustomAnalyzers(
            ref AnalyzerConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AnalyzerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeCustomAnalyzers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomain? ActiveDirectoryDomain
        // GraphQL -> activeDirectoryDomain: ActiveDirectoryDomain! (type)
        public static string ActiveDirectoryDomain(
            ref ActiveDirectoryDomain? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActiveDirectoryDomain() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomain" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainController? ActiveDirectoryDomainController
        // GraphQL -> activeDirectoryDomainController: ActiveDirectoryDomainController! (type)
        public static string ActiveDirectoryDomainController(
            ref ActiveDirectoryDomainController? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActiveDirectoryDomainController() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomainController" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainControllerConnection? ActiveDirectoryDomainControllers
        // GraphQL -> activeDirectoryDomainControllers: ActiveDirectoryDomainControllerConnection! (type)
        public static string ActiveDirectoryDomainControllers(
            ref ActiveDirectoryDomainControllerConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActiveDirectoryDomainControllerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomainControllers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainConnection? ActiveDirectoryDomains
        // GraphQL -> activeDirectoryDomains: ActiveDirectoryDomainConnection! (type)
        public static string ActiveDirectoryDomains(
            ref ActiveDirectoryDomainConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActiveDirectoryDomainConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomains" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        public static string ActivitySeries(
            ref ActivitySeries? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActivitySeries() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        public static string ActivitySeriesConnection(
            ref ActivitySeriesConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActivitySeriesConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeriesConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeriesGroupByConnection? ActivitySeriesGroupByConnection
        // GraphQL -> activitySeriesGroupByConnection: ActivitySeriesGroupByConnection! (type)
        public static string ActivitySeriesGroupByConnection(
            ref ActivitySeriesGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilters: $filters\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActivitySeriesGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeriesGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<User>? AllAccountOwners
        // GraphQL -> allAccountOwners: [User!]! (type)
        public static string AllAccountOwners(
            ref List<User>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<User>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountOwners" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AccountProduct>? AllAccountProducts
        // GraphQL -> allAccountProducts: [AccountProduct!]! (type)
        public static string AllAccountProducts(
            ref List<AccountProduct>? cmdletReply
        )
        {
            string args = "\n(\nnameFilter: $nameFilter\ntypeFilter: $typeFilter\nstateFilter: $stateFilter\nstartDateArg: $startDateArg\nendDateArg: $endDateArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AccountProduct>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountProducts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountWithExocomputeMapping>? AllAccountsWithExocomputeMappings
        // GraphQL -> allAccountsWithExocomputeMappings: [CloudAccountWithExocomputeMapping!]! (type)
        public static string AllAccountsWithExocomputeMappings(
            ref List<CloudAccountWithExocomputeMapping>? cmdletReply
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\nfeatures: $features\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudAccountWithExocomputeMapping>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountsWithExocomputeMappings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsCdmVersion>? AllAwsCdmVersions
        // GraphQL -> allAwsCdmVersions: [AwsCdmVersion!]! (type)
        public static string AllAwsCdmVersions(
            ref List<AwsCdmVersion>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsCdmVersion>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCdmVersions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsFeatureConfig>? AllAwsCloudAccountConfigs
        // GraphQL -> allAwsCloudAccountConfigs: [AwsFeatureConfig!]! (type)
        public static string AllAwsCloudAccountConfigs(
            ref List<AwsFeatureConfig>? cmdletReply
        )
        {
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsFeatureConfig>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCloudAccountConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsCloudAccountWithFeatures>? AllAwsCloudAccountsWithFeatures
        // GraphQL -> allAwsCloudAccountsWithFeatures: [AwsCloudAccountWithFeatures!]! (type)
        public static string AllAwsCloudAccountsWithFeatures(
            ref List<AwsCloudAccountWithFeatures>? cmdletReply
        )
        {
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsCloudAccountWithFeatures>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCloudAccountsWithFeatures" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsComputeSettings>? AllAwsComputeSettings
        // GraphQL -> allAwsComputeSettings: [AwsComputeSettings!]! (type)
        public static string AllAwsComputeSettings(
            ref List<AwsComputeSettings>? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsComputeSettings>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsComputeSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsExocomputeConfig>? AllAwsExocomputeConfigs
        // GraphQL -> allAwsExocomputeConfigs: [AwsExocomputeConfig!]! (type)
        public static string AllAwsExocomputeConfigs(
            ref List<AwsExocomputeConfig>? cmdletReply
        )
        {
            string args = "\n(\nawsNativeAccountIdOrNamePrefix: $awsNativeAccountIdOrNamePrefix\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsExocomputeConfig>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsExocomputeConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsAuroraInstanceClassesReply? AllAwsRdsAuroraInstanceClasses
        // GraphQL -> allAwsRdsAuroraInstanceClasses: AwsNativeRdsAuroraInstanceClassesReply! (type)
        public static string AllAwsRdsAuroraInstanceClasses(
            ref AwsNativeRdsAuroraInstanceClassesReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeRdsAuroraInstanceClassesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsRdsAuroraInstanceClasses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureArmTemplateByFeature>? AllAzureArmTemplatesByFeature
        // GraphQL -> allAzureArmTemplatesByFeature: [AzureArmTemplateByFeature!]! (type)
        public static string AllAzureArmTemplatesByFeature(
            ref List<AzureArmTemplateByFeature>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureArmTemplateByFeature>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureArmTemplatesByFeature" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureCdmVersion>? AllAzureCdmVersions
        // GraphQL -> allAzureCdmVersions: [AzureCdmVersion!]! (type)
        public static string AllAzureCdmVersions(
            ref List<AzureCdmVersion>? cmdletReply
        )
        {
            string args = "\n(\ncdmVersionRequest: $cdmVersionRequest\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureCdmVersion>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCdmVersions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionMissingPermissions>? AllAzureCloudAccountMissingPermissions
        // GraphQL -> allAzureCloudAccountMissingPermissions: [AzureSubscriptionMissingPermissions!]! (type)
        public static string AllAzureCloudAccountMissingPermissions(
            ref List<AzureSubscriptionMissingPermissions>? cmdletReply
        )
        {
            string args = "\n(\nsessionId: $sessionId\nsubscriptionIds: $subscriptionIds\ncloudAccountAction: $cloudAccountAction\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureSubscriptionMissingPermissions>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountMissingPermissions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureCloudAccountSubnetsByRegion
        // GraphQL -> allAzureCloudAccountSubnetsByRegion: [AzureNativeSubnet!]! (type)
        public static string AllAzureCloudAccountSubnetsByRegion(
            ref List<AzureNativeSubnet>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeSubnet>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountSubnetsByRegion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionWithFeaturesType>? AllAzureCloudAccountSubscriptionsByFeature
        // GraphQL -> allAzureCloudAccountSubscriptionsByFeature: [AzureSubscriptionWithFeaturesType!]! (type)
        public static string AllAzureCloudAccountSubscriptionsByFeature(
            ref List<AzureSubscriptionWithFeaturesType>? cmdletReply
        )
        {
            string args = "\n(\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureSubscriptionWithFeaturesType>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountSubscriptionsByFeature" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureCloudAccountTenant>? AllAzureCloudAccountTenants
        // GraphQL -> allAzureCloudAccountTenants: [AzureCloudAccountTenant!]! (type)
        public static string AllAzureCloudAccountTenants(
            ref List<AzureCloudAccountTenant>? cmdletReply
        )
        {
            string args = "\n(\nfeatures: $features\nfeature: $feature\nincludeSubscriptionDetails: $includeSubscriptionDetails\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureCloudAccountTenant>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountTenants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeDiskEncryptionSet>? AllAzureDiskEncryptionSetsByRegion
        // GraphQL -> allAzureDiskEncryptionSetsByRegion: [AzureNativeDiskEncryptionSet!]! (type)
        public static string AllAzureDiskEncryptionSetsByRegion(
            ref List<AzureNativeDiskEncryptionSet>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeDiskEncryptionSet>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureDiskEncryptionSetsByRegion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureEncryptionKey>? AllAzureEncryptionKeys
        // GraphQL -> allAzureEncryptionKeys: [AzureEncryptionKey!]! (type)
        public static string AllAzureEncryptionKeys(
            ref List<AzureEncryptionKey>? cmdletReply
        )
        {
            string args = "\n(\nazureEncryptionKeysInput: $azureEncryptionKeysInput\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureEncryptionKey>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureEncryptionKeys" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureExocomputeConfigsInAccount>? AllAzureExocomputeConfigsInAccount
        // GraphQL -> allAzureExocomputeConfigsInAccount: [AzureExocomputeConfigsInAccount!]! (type)
        public static string AllAzureExocomputeConfigsInAccount(
            ref List<AzureExocomputeConfigsInAccount>? cmdletReply
        )
        {
            string args = "\n(\nazureExocomputeSearchQuery: $azureExocomputeSearchQuery\ncloudAccountIDs: $cloudAccountIDs\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureExocomputeConfigsInAccount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureExocomputeConfigsInAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureKeyVault>? AllAzureKeyVaultsByRegion
        // GraphQL -> allAzureKeyVaultsByRegion: [AzureKeyVault!]! (type)
        public static string AllAzureKeyVaultsByRegion(
            ref List<AzureKeyVault>? cmdletReply
        )
        {
            string args = "\n(\nazureKeyVaultsInput: $azureKeyVaultsInput\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureKeyVault>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureKeyVaultsByRegion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeAvailabilitySet>? AllAzureNativeAvailabilitySetsByRegionFromAzure
        // GraphQL -> allAzureNativeAvailabilitySetsByRegionFromAzure: [AzureNativeAvailabilitySet!]! (type)
        public static string AllAzureNativeAvailabilitySetsByRegionFromAzure(
            ref List<AzureNativeAvailabilitySet>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nresourceGroupName: $resourceGroupName\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeAvailabilitySet>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeAvailabilitySetsByRegionFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeExportCompatibleDiskTypes>? AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleDiskTypesByRegionFromAzure: [AzureNativeExportCompatibleDiskTypes!]! (type)
        public static string AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(
            ref List<AzureNativeExportCompatibleDiskTypes>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeExportCompatibleDiskTypes>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeExportCompatibleVmSizes>? AllAzureNativeExportCompatibleVmSizesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleVmSizesByRegionFromAzure: [AzureNativeExportCompatibleVmSizes!]! (type)
        public static string AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(
            ref List<AzureNativeExportCompatibleVmSizes>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\nvmSnapshotId: $vmSnapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeExportCompatibleVmSizes>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeExportCompatibleVmSizesByRegionFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureResourceGroupInfo>? AllAzureNativeResourceGroupsInfoIfExist
        // GraphQL -> allAzureNativeResourceGroupsInfoIfExist: [AzureResourceGroupInfo!]! (type)
        public static string AllAzureNativeResourceGroupsInfoIfExist(
            ref List<AzureResourceGroupInfo>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureResourceGroupInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeResourceGroupsInfoIfExist" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSecurityGroup>? AllAzureNativeSecurityGroupsByRegionFromAzure
        // GraphQL -> allAzureNativeSecurityGroupsByRegionFromAzure: [AzureNativeSecurityGroup!]! (type)
        public static string AllAzureNativeSecurityGroupsByRegionFromAzure(
            ref List<AzureNativeSecurityGroup>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeSecurityGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeSecurityGroupsByRegionFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeStorageAccount>? AllAzureNativeStorageAccountsFromAzure
        // GraphQL -> allAzureNativeStorageAccountsFromAzure: [AzureNativeStorageAccount!]! (type)
        public static string AllAzureNativeStorageAccountsFromAzure(
            ref List<AzureNativeStorageAccount>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeStorageAccount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeStorageAccountsFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureNativeSubnetsByRegionFromAzure
        // GraphQL -> allAzureNativeSubnetsByRegionFromAzure: [AzureNativeSubnet!]! (type)
        public static string AllAzureNativeSubnetsByRegionFromAzure(
            ref List<AzureNativeSubnet>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeSubnet>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeSubnetsByRegionFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeVirtualNetwork>? AllAzureNativeVirtualNetworks
        // GraphQL -> allAzureNativeVirtualNetworks: [AzureNativeVirtualNetwork!]! (type)
        public static string AllAzureNativeVirtualNetworks(
            ref List<AzureNativeVirtualNetwork>? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureNativeVirtualNetwork>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeVirtualNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSqlDatabaseServerElasticPool>? AllAzureSqlDatabaseServerElasticPools
        // GraphQL -> allAzureSqlDatabaseServerElasticPools: [AzureSqlDatabaseServerElasticPool!]! (type)
        public static string AllAzureSqlDatabaseServerElasticPools(
            ref List<AzureSqlDatabaseServerElasticPool>? cmdletReply
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureSqlDatabaseServerElasticPool>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureSqlDatabaseServerElasticPools" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionWithExocomputeMapping>? AllAzureSubscriptionWithExocomputeMappings
        // GraphQL -> allAzureSubscriptionWithExocomputeMappings: [AzureSubscriptionWithExocomputeMapping!]! (type)
        public static string AllAzureSubscriptionWithExocomputeMappings(
            ref List<AzureSubscriptionWithExocomputeMapping>? cmdletReply
        )
        {
            string args = "\n(\nfeatures: $features\nexocomputeSubscriptionIdsFilter: $exocomputeSubscriptionIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureSubscriptionWithExocomputeMapping>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureSubscriptionWithExocomputeMappings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNewConnection? AllBlueprints
        // GraphQL -> allBlueprints: BlueprintNewConnection! (type)
        public static string AllBlueprints(
            ref BlueprintNewConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nsourceLocationIdOpt: $sourceLocationIdOpt\ntargetLocationIdOpt: $targetLocationIdOpt\nstatusOpt: $statusOpt\nfailoverStatusOpt: $failoverStatusOpt\nblueprintRecoveryTypes: $blueprintRecoveryTypes\nisBlueprintVisible: $isBlueprintVisible\nblueprintIds: $blueprintIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BlueprintNewConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allBlueprints" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmGuestCredential>? AllCdmGuestCredentials
        // GraphQL -> allCdmGuestCredentials: [CdmGuestCredential!]! (type)
        public static string AllCdmGuestCredentials(
            ref List<CdmGuestCredential>? cmdletReply
        )
        {
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CdmGuestCredential>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdmGuestCredentials" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmOvaDetail>? AllCdmOvaDetails
        // GraphQL -> allCdmOvaDetails: [CdmOvaDetail!]! (type)
        public static string AllCdmOvaDetails(
            ref List<CdmOvaDetail>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CdmOvaDetail>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdmOvaDetails" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdpVmInfoConnection? AllCdpVmsInfos
        // GraphQL -> allCdpVmsInfos: CdpVmInfoConnection! (type)
        public static string AllCdpVmsInfos(
            ref CdpVmInfoConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nallCdpVmInfoSort: $allCdpVmInfoSort\nallCdpVmInfoFilter: $allCdpVmInfoFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdpVmInfoConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdpVmsInfos" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountsExocomputeAccountMapping>? AllCloudAccountExocomputeMappings
        // GraphQL -> allCloudAccountExocomputeMappings: [CloudAccountsExocomputeAccountMapping!]! (type)
        public static string AllCloudAccountExocomputeMappings(
            ref List<CloudAccountsExocomputeAccountMapping>? cmdletReply
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudAccountsExocomputeAccountMapping>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudAccountExocomputeMappings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CcWithCloudInfo>? AllCloudClusters
        // GraphQL -> allCloudClusters: [CcWithCloudInfo!]! (type)
        public static string AllCloudClusters(
            ref List<CcWithCloudInfo>? cmdletReply
        )
        {
            string args = "\n(\ncloudVendorType: $cloudVendorType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CcWithCloudInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ShareExportIdPair>? AllCloudDirectShares
        // GraphQL -> allCloudDirectShares: [ShareExportIdPair!]! (type)
        public static string AllCloudDirectShares(
            ref List<ShareExportIdPair>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ShareExportIdPair>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudDirectShares" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudDirectSite>? AllCloudDirectSites
        // GraphQL -> allCloudDirectSites: [CloudDirectSite!]! (type)
        public static string AllCloudDirectSites(
            ref List<CloudDirectSite>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudDirectSite>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudDirectSites" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? AllClusterConnection
        // GraphQL -> allClusterConnection: ClusterConnection! (type)
        public static string AllClusterConnection(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaInfo>? AllClusterGlobalSlas
        // GraphQL -> allClusterGlobalSlas: [SlaInfo!]! (type)
        public static string AllClusterGlobalSlas(
            ref List<SlaInfo>? cmdletReply
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SlaInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterGlobalSlas" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClusterReplicationTarget>? AllClusterReplicationTargets
        // GraphQL -> allClusterReplicationTargets: [ClusterReplicationTarget!]! (type)
        public static string AllClusterReplicationTargets(
            ref List<ClusterReplicationTarget>? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ClusterReplicationTarget>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterReplicationTargets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClusterWebCertAndIpmi>? AllClusterWebCertsAndIpmis
        // GraphQL -> allClusterWebCertsAndIpmis: [ClusterWebCertAndIpmi!]! (type)
        public static string AllClusterWebCertsAndIpmis(
            ref List<ClusterWebCertAndIpmi>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ClusterWebCertAndIpmi>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterWebCertsAndIpmis" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DailyComplianceStats>? AllComplianceTimeSeries
        // GraphQL -> allComplianceTimeSeries: [DailyComplianceStats!]! (type)
        public static string AllComplianceTimeSeries(
            ref List<DailyComplianceStats>? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nlookbackPeriod: $lookbackPeriod\nobjectTypes: $objectTypes\norgIds: $orgIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DailyComplianceStats>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allComplianceTimeSeries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ConfigProtectionBackupsConnection? AllConfigProtectionBackups
        // GraphQL -> allConfigProtectionBackups: ConfigProtectionBackupsConnection! (type)
        public static string AllConfigProtectionBackups(
            ref ConfigProtectionBackupsConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ConfigProtectionBackupsConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allConfigProtectionBackups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DataLocationSupportedCluster>? AllConnectedClusters
        // GraphQL -> allConnectedClusters: [DataLocationSupportedCluster!]! (type)
        public static string AllConnectedClusters(
            ref List<DataLocationSupportedCluster>? cmdletReply
        )
        {
            string args = "\n(\nclusterFilterArg: $clusterFilterArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DataLocationSupportedCluster>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allConnectedClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllCurrentFeaturePermissionsForCloudAccounts
        // GraphQL -> allCurrentFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllCurrentFeaturePermissionsForCloudAccounts(
            ref List<CloudAccountFeaturePermission>? cmdletReply
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudAccountFeaturePermission>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCurrentFeaturePermissionsForCloudAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<IdentityProvider>? AllCurrentOrgIdentityProviders
        // GraphQL -> allCurrentOrgIdentityProviders: [IdentityProvider!]! (type)
        public static string AllCurrentOrgIdentityProviders(
            ref List<IdentityProvider>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<IdentityProvider>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCurrentOrgIdentityProviders" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DbParameterGroup>? AllDbParameterGroupsByRegionFromAws
        // GraphQL -> allDbParameterGroupsByRegionFromAws: [DbParameterGroup!]! (type)
        public static string AllDbParameterGroupsByRegionFromAws(
            ref List<DbParameterGroup>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nrdsType: $rdsType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DbParameterGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDbParameterGroupsByRegionFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SubnetGroup>? AllDbSubnetGroupsByRegionFromAws
        // GraphQL -> allDbSubnetGroupsByRegionFromAws: [SubnetGroup!]! (type)
        public static string AllDbSubnetGroupsByRegionFromAws(
            ref List<SubnetGroup>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SubnetGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDbSubnetGroupsByRegionFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcActiveRecommendation>? AllDhrcActiveRecommendations
        // GraphQL -> allDhrcActiveRecommendations: [DhrcActiveRecommendation!]! (type)
        public static string AllDhrcActiveRecommendations(
            ref List<DhrcActiveRecommendation>? cmdletReply
        )
        {
            string args = "\n(\ncategories: $categories\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DhrcActiveRecommendation>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcActiveRecommendations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcCollectedMetric>? AllDhrcLatestMetrics
        // GraphQL -> allDhrcLatestMetrics: [DhrcCollectedMetric!]! (type)
        public static string AllDhrcLatestMetrics(
            ref List<DhrcCollectedMetric>? cmdletReply
        )
        {
            string args = "\n(\ncategories: $categories\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DhrcCollectedMetric>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcLatestMetrics" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcScore>? AllDhrcScores
        // GraphQL -> allDhrcScores: [DhrcScore!]! (type)
        public static string AllDhrcScores(
            ref List<DhrcScore>? cmdletReply
        )
        {
            string args = "\n(\ncategories: $categories\nbeginTime: $beginTime\ntimespan: $timespan\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DhrcScore>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcScores" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<RbacPermission>? AllEffectiveRbacPermissions
        // GraphQL -> allEffectiveRbacPermissions: [RbacPermission!]! (type)
        public static string AllEffectiveRbacPermissions(
            ref List<RbacPermission>? cmdletReply
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<RbacPermission>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allEffectiveRbacPermissions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<EventDigest>? AllEventDigests
        // GraphQL -> allEventDigests: [EventDigest!]! (type)
        public static string AllEventDigests(
            ref List<EventDigest>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<EventDigest>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allEventDigests" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<FailoverJobReport>? AllFailoverJobReports
        // GraphQL -> allFailoverJobReports: [FailoverJobReport!]! (type)
        public static string AllFailoverJobReports(
            ref List<FailoverJobReport>? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\nrecoveryJobID: $recoveryJobID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<FailoverJobReport>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFailoverJobReports" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpPermission>? AllFeaturePermissionsForGcpCloudAccount
        // GraphQL -> allFeaturePermissionsForGcpCloudAccount: [GcpPermission!]! (type)
        public static string AllFeaturePermissionsForGcpCloudAccount(
            ref List<GcpPermission>? cmdletReply
        )
        {
            string args = "\n(\nfeature: $feature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpPermission>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFeaturePermissionsForGcpCloudAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserActivityResultConnection? AllFileActivities
        // GraphQL -> allFileActivities: UserActivityResultConnection! (type)
        public static string AllFileActivities(
            ref UserActivityResultConnection? cmdletReply
        )
        {
            string args = "\n(\nListFileActivitiesInput: $ListFileActivitiesInput\nFileActivitiesSort: $FileActivitiesSort\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserActivityResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFileActivities" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountMissingPermissionsForAddition>? AllGcpCloudAccountMissingPermissionsForAddition
        // GraphQL -> allGcpCloudAccountMissingPermissionsForAddition: [GcpCloudAccountMissingPermissionsForAddition!]! (type)
        public static string AllGcpCloudAccountMissingPermissionsForAddition(
            ref List<GcpCloudAccountMissingPermissionsForAddition>? cmdletReply
        )
        {
            string args = "\n(\nsessionId: $sessionId\nprojectIds: $projectIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpCloudAccountMissingPermissionsForAddition>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountMissingPermissionsForAddition" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountProjectDetail>? AllGcpCloudAccountProjectsByFeature
        // GraphQL -> allGcpCloudAccountProjectsByFeature: [GcpCloudAccountProjectDetail!]! (type)
        public static string AllGcpCloudAccountProjectsByFeature(
            ref List<GcpCloudAccountProjectDetail>? cmdletReply
        )
        {
            string args = "\n(\nfeature: $feature\nprojectStatusFilters: $projectStatusFilters\nprojectSearchText: $projectSearchText\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpCloudAccountProjectDetail>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountProjectsByFeature" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountProjectForOauth>? AllGcpCloudAccountProjectsForOauth
        // GraphQL -> allGcpCloudAccountProjectsForOauth: [GcpCloudAccountProjectForOauth!]! (type)
        public static string AllGcpCloudAccountProjectsForOauth(
            ref List<GcpCloudAccountProjectForOauth>? cmdletReply
        )
        {
            string args = "\n(\nsessionId: $sessionId\nfeatures: $features\ncheckPermissions: $checkPermissions\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpCloudAccountProjectForOauth>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountProjectsForOauth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeKmsCryptoKey>? AllGcpNativeAvailableKmsCryptoKeys
        // GraphQL -> allGcpNativeAvailableKmsCryptoKeys: [GcpNativeKmsCryptoKey!]! (type)
        public static string AllGcpNativeAvailableKmsCryptoKeys(
            ref List<GcpNativeKmsCryptoKey>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\nregionName: $regionName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpNativeKmsCryptoKey>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeAvailableKmsCryptoKeys" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeNetwork>? AllGcpNativeNetworks
        // GraphQL -> allGcpNativeNetworks: [GcpNativeNetwork!]! (type)
        public static string AllGcpNativeNetworks(
            ref List<GcpNativeNetwork>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpNativeNetwork>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NetworkHostProject>? AllGcpNativeProjectsWithAccessibleNetworks
        // GraphQL -> allGcpNativeProjectsWithAccessibleNetworks: [NetworkHostProject!]! (type)
        public static string AllGcpNativeProjectsWithAccessibleNetworks(
            ref List<NetworkHostProject>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<NetworkHostProject>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeProjectsWithAccessibleNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeRegion>? AllGcpNativeRegions
        // GraphQL -> allGcpNativeRegions: [GcpNativeRegion!]! (type)
        public static string AllGcpNativeRegions(
            ref List<GcpNativeRegion>? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GcpNativeRegion>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeRegions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalFileSearchReplyType? AllGlobalFileSearchMultipleClusters
        // GraphQL -> allGlobalFileSearchMultipleClusters: GlobalFileSearchReplyType! (type)
        public static string AllGlobalFileSearchMultipleClusters(
            ref GlobalFileSearchReplyType? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\nregex: $regex\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalFileSearchReplyType() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGlobalFileSearchMultipleClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureRegionsResp? AllHostedAzureRegions
        // GraphQL -> allHostedAzureRegions: AzureRegionsResp! (type)
        public static string AllHostedAzureRegions(
            ref AzureRegionsResp? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureRegionsResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allHostedAzureRegions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<JiraIssueType>? AllJiraIssueTypes
        // GraphQL -> allJiraIssueTypes: [JiraIssueType!]! (type)
        public static string AllJiraIssueTypes(
            ref List<JiraIssueType>? cmdletReply
        )
        {
            string args = "\n(\njiraProjectId: $jiraProjectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<JiraIssueType>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allJiraIssueTypes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReplicatedSnapshotInfo>? AllK8sReplicaSnapshotInfos
        // GraphQL -> allK8sReplicaSnapshotInfos: [ReplicatedSnapshotInfo!]! (type)
        public static string AllK8sReplicaSnapshotInfos(
            ref List<ReplicatedSnapshotInfo>? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ReplicatedSnapshotInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allK8sReplicaSnapshotInfos" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<KmsEncryptionKey>? AllKmsEncryptionKeysByRegionFromAws
        // GraphQL -> allKmsEncryptionKeysByRegionFromAws: [KmsEncryptionKey!]! (type)
        public static string AllKmsEncryptionKeysByRegionFromAws(
            ref List<KmsEncryptionKey>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<KmsEncryptionKey>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allKmsEncryptionKeysByRegionFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<LatestConfigProtectionBackups>? AllLatestConfigProtectionBackupsByVersion
        // GraphQL -> allLatestConfigProtectionBackupsByVersion: [LatestConfigProtectionBackups!]! (type)
        public static string AllLatestConfigProtectionBackupsByVersion(
            ref List<LatestConfigProtectionBackups>? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<LatestConfigProtectionBackups>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLatestConfigProtectionBackupsByVersion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllLatestFeaturePermissionsForCloudAccounts
        // GraphQL -> allLatestFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllLatestFeaturePermissionsForCloudAccounts(
            ref List<CloudAccountFeaturePermission>? cmdletReply
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\nfeatures: $features\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<CloudAccountFeaturePermission>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLatestFeaturePermissionsForCloudAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetLicensedProductsInfoReply? AllLicensedProducts
        // GraphQL -> allLicensedProducts: GetLicensedProductsInfoReply! (type)
        public static string AllLicensedProducts(
            ref GetLicensedProductsInfoReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetLicensedProductsInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLicensedProducts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> V1MssqlGetRestoreFilesV1Response? AllMssqlDatabaseRestoreFiles
        // GraphQL -> allMssqlDatabaseRestoreFiles: V1MssqlGetRestoreFilesV1Response! (type)
        public static string AllMssqlDatabaseRestoreFiles(
            ref V1MssqlGetRestoreFilesV1Response? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new V1MssqlGetRestoreFilesV1Response() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allMssqlDatabaseRestoreFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdObjectsOverTimeData>? AllNcdObjectsOverTimeData
        // GraphQL -> allNcdObjectsOverTimeData: [NcdObjectsOverTimeData!]! (type)
        public static string AllNcdObjectsOverTimeData(
            ref List<NcdObjectsOverTimeData>? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<NcdObjectsOverTimeData>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdObjectsOverTimeData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdSlaComplianceData>? AllNcdSlaComplianceData
        // GraphQL -> allNcdSlaComplianceData: [NcdSlaComplianceData!]! (type)
        public static string AllNcdSlaComplianceData(
            ref List<NcdSlaComplianceData>? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<NcdSlaComplianceData>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdSlaComplianceData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdTaskData>? AllNcdTaskData
        // GraphQL -> allNcdTaskData: [NcdTaskData!]! (type)
        public static string AllNcdTaskData(
            ref List<NcdTaskData>? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<NcdTaskData>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdTaskData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdUsageOverTimeData>? AllNcdUsageOverTimeData
        // GraphQL -> allNcdUsageOverTimeData: [NcdUsageOverTimeData!]! (type)
        public static string AllNcdUsageOverTimeData(
            ref List<NcdUsageOverTimeData>? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<NcdUsageOverTimeData>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdUsageOverTimeData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<MosaicStorageLocation>? AllNosqlStorageLocations
        // GraphQL -> allNosqlStorageLocations: [MosaicStorageLocation!]! (type)
        public static string AllNosqlStorageLocations(
            ref List<MosaicStorageLocation>? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<MosaicStorageLocation>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNosqlStorageLocations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AdGroup>? AllO365AdGroups
        // GraphQL -> allO365AdGroups: [AdGroup!]! (type)
        public static string AllO365AdGroups(
            ref List<AdGroup>? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\nadGroupSearchFilter: $adGroupSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AdGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365AdGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<O365OrgInfo>? AllO365OrgStatuses
        // GraphQL -> allO365OrgStatuses: [O365OrgInfo!]! (type)
        public static string AllO365OrgStatuses(
            ref List<O365OrgInfo>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<O365OrgInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365OrgStatuses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<O365SubscriptionAppTypeCounts>? AllO365SubscriptionsAppTypeCounts
        // GraphQL -> allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]! (type)
        public static string AllO365SubscriptionsAppTypeCounts(
            ref List<O365SubscriptionAppTypeCounts>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<O365SubscriptionAppTypeCounts>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365SubscriptionsAppTypeCounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ObjectIdsForHierarchyType>? AllObjectsAlreadyAssignedToOrgs
        // GraphQL -> allObjectsAlreadyAssignedToOrgs: [ObjectIdsForHierarchyType!]! (type)
        public static string AllObjectsAlreadyAssignedToOrgs(
            ref List<ObjectIdsForHierarchyType>? cmdletReply
        )
        {
            string args = "\n(\nobjectIdsForHierarchyTypes: $objectIdsForHierarchyTypes\nallowedClusters: $allowedClusters\ntargetOrgId: $targetOrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ObjectIdsForHierarchyType>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allObjectsAlreadyAssignedToOrgs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<LatestUserNote>? AllObjectsLatestUserNoteAudit
        // GraphQL -> allObjectsLatestUserNoteAudit: [LatestUserNote!]! (type)
        public static string AllObjectsLatestUserNoteAudit(
            ref List<LatestUserNote>? cmdletReply
        )
        {
            string args = "\n(\nobjectIds: $objectIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<LatestUserNote>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allObjectsLatestUserNoteAudit" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<OptionGroup>? AllOptionGroupsByRegionFromAws
        // GraphQL -> allOptionGroupsByRegionFromAws: [OptionGroup!]! (type)
        public static string AllOptionGroupsByRegionFromAws(
            ref List<OptionGroup>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nmajorEngineVersion: $majorEngineVersion\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<OptionGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allOptionGroupsByRegionFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Org>? AllOrgsByIds
        // GraphQL -> allOrgsByIds: [Org!]! (type)
        public static string AllOrgsByIds(
            ref List<Org>? cmdletReply
        )
        {
            string args = "\n(\norgIds: $orgIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Org>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allOrgsByIds" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PendingAction>? AllPendingActions
        // GraphQL -> allPendingActions: [pendingAction!]! (type)
        public static string AllPendingActions(
            ref List<PendingAction>? cmdletReply
        )
        {
            string args = "\n(\nclusterFilter: $clusterFilter\npendingActionGroupTypeFilter: $pendingActionGroupTypeFilter\npendingActionSubGroupTypeFilter: $pendingActionSubGroupTypeFilter\nstatusFilter: $statusFilter\nobjectIds: $objectIds\nsortedOrder: $sortedOrder\nhistoryOnly: $historyOnly\nlimit: $limit\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<PendingAction>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPendingActions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolicyRiskSummary>? AllPolicyRiskSummaries
        // GraphQL -> allPolicyRiskSummaries: [PolicyRiskSummary!]! (type)
        public static string AllPolicyRiskSummaries(
            ref List<PolicyRiskSummary>? cmdletReply
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nsummaryDate: $summaryDate\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<PolicyRiskSummary>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPolicyRiskSummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskSummaryReply? AllPrincipalRiskSummaries
        // GraphQL -> allPrincipalRiskSummaries: GetPrincipalRiskSummaryReply! (type)
        public static string AllPrincipalRiskSummaries(
            ref GetPrincipalRiskSummaryReply? cmdletReply
        )
        {
            string args = "\n(\nqueryDate: $queryDate\nhistoricalDeltaDays: $historicalDeltaDays\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetPrincipalRiskSummaryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPrincipalRiskSummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForSnapshots
        // GraphQL -> allQuarantinedDetailsForSnapshots: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForSnapshots(
            ref List<QuarantineSpec>? cmdletReply
        )
        {
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<QuarantineSpec>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allQuarantinedDetailsForSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForWorkload
        // GraphQL -> allQuarantinedDetailsForWorkload: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForWorkload(
            ref List<QuarantineSpec>? cmdletReply
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<QuarantineSpec>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allQuarantinedDetailsForWorkload" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReportConfig>? AllReportConfigs
        // GraphQL -> allReportConfigs: [ReportConfig!]! (type)
        public static string AllReportConfigs(
            ref List<ReportConfig>? cmdletReply
        )
        {
            string args = "\n(\ndataView: $dataView\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ReportConfig>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allReportConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReportMetadata>? AllReportMetadata
        // GraphQL -> allReportMetadata: [ReportMetadata!]! (type)
        public static string AllReportMetadata(
            ref List<ReportMetadata>? cmdletReply
        )
        {
            string args = "\n(\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ReportMetadata>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allReportMetadata" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureResourceGroup>? AllResourceGroupsFromAzure
        // GraphQL -> allResourceGroupsFromAzure: [AzureResourceGroup!]! (type)
        public static string AllResourceGroupsFromAzure(
            ref List<AzureResourceGroup>? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nfeature: $feature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AzureResourceGroup>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allResourceGroupsFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolarisReportConfig>? AllRscReportConfigs
        // GraphQL -> allRscReportConfigs: [PolarisReportConfig!]! (type)
        public static string AllRscReportConfigs(
            ref List<PolarisReportConfig>? cmdletReply
        )
        {
            string args = "\n(\nreportView: $reportView\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<PolarisReportConfig>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allRscReportConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<S3BucketDetails>? AllS3BucketsDetailsFromAws
        // GraphQL -> allS3BucketsDetailsFromAws: [S3BucketDetails!]! (type)
        public static string AllS3BucketsDetailsFromAws(
            ref List<S3BucketDetails>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<S3BucketDetails>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allS3BucketsDetailsFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<FullSpSiteExclusions>? AllSharepointSiteExclusions
        // GraphQL -> allSharepointSiteExclusions: [FullSpSiteExclusions!]! (type)
        public static string AllSharepointSiteExclusions(
            ref List<FullSpSiteExclusions>? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\nsiteFids: $siteFids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<FullSpSiteExclusions>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSharepointSiteExclusions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ComputeClusterIofilterStatus>? AllSlaIofilterStatuses
        // GraphQL -> allSlaIofilterStatuses: [ComputeClusterIofilterStatus!]! (type)
        public static string AllSlaIofilterStatuses(
            ref List<ComputeClusterIofilterStatus>? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ComputeClusterIofilterStatus>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSlaIofilterStatuses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PvcInformation>? AllSnapshotPvcs
        // GraphQL -> allSnapshotPvcs: [PvcInformation!]! (type)
        public static string AllSnapshotPvcs(
            ref List<PvcInformation>? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\nisReplica: $isReplica\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<PvcInformation>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnapshotPvcs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClosestSnapshotSearchResult>? AllSnapshotsClosestToPointInTime
        // GraphQL -> allSnapshotsClosestToPointInTime: [ClosestSnapshotSearchResult!]! (type)
        public static string AllSnapshotsClosestToPointInTime(
            ref List<ClosestSnapshotSearchResult>? cmdletReply
        )
        {
            string args = "\n(\nbeforeTime: $beforeTime\nafterTime: $afterTime\nsnappableIds: $snappableIds\nincludeLinked: $includeLinked\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\nexcludeQuarantined: $excludeQuarantined\nexcludeAnomalous: $excludeAnomalous\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ClosestSnapshotSearchResult>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnapshotsClosestToPointInTime" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SourceRecoverySpecsReply>? AllSourceRecoverySpecs
        // GraphQL -> allSourceRecoverySpecs: [SourceRecoverySpecsReply!]! (type)
        public static string AllSourceRecoverySpecs(
            ref List<SourceRecoverySpecsReply>? cmdletReply
        )
        {
            string args = "\n(\nworkloadInfos: $workloadInfos\nsourceLocation: $sourceLocation\nblueprintId: $blueprintId\nplanType: $planType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SourceRecoverySpecsReply>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSourceRecoverySpecs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AllStorageArraysReply? AllStorageArrays
        // GraphQL -> allStorageArrays: AllStorageArraysReply! (type)
        public static string AllStorageArrays(
            ref AllStorageArraysReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AllStorageArraysReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allStorageArrays" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<TargetMapping>? AllTargetMappings
        // GraphQL -> allTargetMappings: [TargetMapping!]! (type)
        public static string AllTargetMappings(
            ref List<TargetMapping>? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\nisRcsStatsRequired: $isRcsStatsRequired\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<TargetMapping>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTargetMappings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolicySummary>? AllTopRiskPolicySummaries
        // GraphQL -> allTopRiskPolicySummaries: [PolicySummary!]! (type)
        public static string AllTopRiskPolicySummaries(
            ref List<PolicySummary>? cmdletReply
        )
        {
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\nlimit: $limit\nworkloadTypes: $workloadTypes\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<PolicySummary>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTopRiskPolicySummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UnifiedFeatureFlag>? AllUnifiedFeatureFlags
        // GraphQL -> allUnifiedFeatureFlags: [UnifiedFeatureFlag!]! (type)
        public static string AllUnifiedFeatureFlags(
            ref List<UnifiedFeatureFlag>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<UnifiedFeatureFlag>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUnifiedFeatureFlags" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<User>? AllUsersOnAccount
        // GraphQL -> allUsersOnAccount: [User!]! (type)
        public static string AllUsersOnAccount(
            ref List<User>? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<User>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUsersOnAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserConnection? AllUsersOnAccountConnection
        // GraphQL -> allUsersOnAccountConnection: UserConnection! (type)
        public static string AllUsersOnAccountConnection(
            ref UserConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nemailFilter: $emailFilter\nroleIdsFilter: $roleIdsFilter\nlockoutStateFilter: $lockoutStateFilter\nhiddenStateFilter: $hiddenStateFilter\nshouldGetLocalUsersOnly: $shouldGetLocalUsersOnly\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUsersOnAccountConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidReplicationTargetConnection? AllValidReplicationTargets
        // GraphQL -> allValidReplicationTargets: ValidReplicationTargetConnection! (type)
        public static string AllValidReplicationTargets(
            ref ValidReplicationTargetConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidReplicationTargetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allValidReplicationTargets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VcenterHotAddProxyVmInfo>? AllVcenterHotAddProxyVms
        // GraphQL -> allVcenterHotAddProxyVms: [VcenterHotAddProxyVmInfo!]! (type)
        public static string AllVcenterHotAddProxyVms(
            ref List<VcenterHotAddProxyVmInfo>? cmdletReply
        )
        {
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<VcenterHotAddProxyVmInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVcenterHotAddProxyVms" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VirtualMachineFilesReply? AllVirtualMachineFiles
        // GraphQL -> allVirtualMachineFiles: VirtualMachineFilesReply! (type)
        public static string AllVirtualMachineFiles(
            ref VirtualMachineFilesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VirtualMachineFilesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVirtualMachineFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ComputeClusterIofilterStatus>? AllVmIofilterStatuses
        // GraphQL -> allVmIofilterStatuses: [ComputeClusterIofilterStatus!]! (type)
        public static string AllVmIofilterStatuses(
            ref List<ComputeClusterIofilterStatus>? cmdletReply
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<ComputeClusterIofilterStatus>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVmIofilterStatuses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VmwareCdpStateInfo>? AllVmwareCdpStateInfos
        // GraphQL -> allVmwareCdpStateInfos: [VmwareCdpStateInfo!]! (type)
        public static string AllVmwareCdpStateInfos(
            ref List<VmwareCdpStateInfo>? cmdletReply
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<VmwareCdpStateInfo>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVmwareCdpStateInfos" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsVpc>? AllVpcsByRegionFromAws
        // GraphQL -> allVpcsByRegionFromAws: [AwsVpc!]! (type)
        public static string AllVpcsByRegionFromAws(
            ref List<AwsVpc>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsVpc>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVpcsByRegionFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsVpc>? AllVpcsFromAws
        // GraphQL -> allVpcsFromAws: [AwsVpc!]! (type)
        public static string AllVpcsFromAws(
            ref List<AwsVpc>? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<AwsVpc>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVpcsFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WebhookConnection? AllWebhooks
        // GraphQL -> allWebhooks: WebhookConnection! (type)
        public static string AllWebhooks(
            ref WebhookConnection? cmdletReply
        )
        {
            string args = "\n(\nname: $name\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new WebhookConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allWebhooks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AmiTypeForAwsNativeArchivedSnapshotExportReply? AmiTypeForAwsNativeArchivedSnapshotExport
        // GraphQL -> amiTypeForAwsNativeArchivedSnapshotExport: AmiTypeForAwsNativeArchivedSnapshotExportReply! (type)
        public static string AmiTypeForAwsNativeArchivedSnapshotExport(
            ref AmiTypeForAwsNativeArchivedSnapshotExportReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AmiTypeForAwsNativeArchivedSnapshotExportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "amiTypeForAwsNativeArchivedSnapshotExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerGroupConnection? AnalyzerGroups
        // GraphQL -> analyzerGroups: AnalyzerGroupConnection! (type)
        public static string AnalyzerGroups(
            ref AnalyzerGroupConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AnalyzerGroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "analyzerGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerUsageConnection? AnalyzerUsages
        // GraphQL -> analyzerUsages: AnalyzerUsageConnection! (type)
        public static string AnalyzerUsages(
            ref AnalyzerUsageConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AnalyzerUsageConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "analyzerUsages" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAnomalyDetailsReply? AnomalyResultOpt
        // GraphQL -> anomalyResultOpt: GetAnomalyDetailsReply (type)
        public static string AnomalyResultOpt(
            ref GetAnomalyDetailsReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetAnomalyDetailsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResultOpt" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        public static string AnomalyResults(
            ref AnomalyResultConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AnomalyResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResults" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnomalyResultGroupedDataConnection? AnomalyResultsGrouped
        // GraphQL -> anomalyResultsGrouped: AnomalyResultGroupedDataConnection! (type)
        public static string AnomalyResultsGrouped(
            ref AnomalyResultGroupedDataConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AnomalyResultGroupedDataConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResultsGrouped" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AppflowsSummary? AppflowsSummary
        // GraphQL -> appflowsSummary: AppflowsSummary! (type)
        public static string AppflowsSummary(
            ref AppflowsSummary? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AppflowsSummary() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "appflowsSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ArchivalEntityConnection? ArchivalEntities
        // GraphQL -> archivalEntities: ArchivalEntityConnection! (type)
        public static string ArchivalEntities(
            ref ArchivalEntityConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ArchivalEntityConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "archivalEntities" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AtlassianSiteConnection? AtlassianSites
        // GraphQL -> atlassianSites: AtlassianSiteConnection! (type)
        public static string AtlassianSites(
            ref AtlassianSiteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AtlassianSiteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "atlassianSites" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListSecurityGroupsResponse? AwsCloudAccountListSecurityGroups
        // GraphQL -> awsCloudAccountListSecurityGroups: AwsCloudAccountListSecurityGroupsResponse! (type)
        public static string AwsCloudAccountListSecurityGroups(
            ref AwsCloudAccountListSecurityGroupsResponse? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountListSecurityGroupsResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListSecurityGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListSubnetsResponse? AwsCloudAccountListSubnets
        // GraphQL -> awsCloudAccountListSubnets: AwsCloudAccountListSubnetsResponse! (type)
        public static string AwsCloudAccountListSubnets(
            ref AwsCloudAccountListSubnetsResponse? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountListSubnetsResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListSubnets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListVpcResponse? AwsCloudAccountListVpcs
        // GraphQL -> awsCloudAccountListVpcs: AwsCloudAccountListVpcResponse! (type)
        public static string AwsCloudAccountListVpcs(
            ref AwsCloudAccountListVpcResponse? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountListVpcResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListVpcs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountWithFeatures? AwsCloudAccountWithFeatures
        // GraphQL -> awsCloudAccountWithFeatures: AwsCloudAccountWithFeatures! (type)
        public static string AwsCloudAccountWithFeatures(
            ref AwsCloudAccountWithFeatures? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nawsCloudAccountArg: $awsCloudAccountArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsCloudAccountWithFeatures() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountWithFeatures" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsComputeSettings? AwsComputeSettings
        // GraphQL -> awsComputeSettings: AwsComputeSettings! (type)
        public static string AwsComputeSettings(
            ref AwsComputeSettings? cmdletReply
        )
        {
            string args = "\n(\ncomputeSettingId: $computeSettingId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsComputeSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsComputeSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        public static string AwsNativeAccount(
            ref AwsNativeAccount? cmdletReply
        )
        {
            string args = "\n(\nawsNativeAccountRubrikId: $awsNativeAccountRubrikId\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeAccount() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeAccountConnection? AwsNativeAccounts
        // GraphQL -> awsNativeAccounts: AwsNativeAccountConnection! (type)
        public static string AwsNativeAccounts(
            ref AwsNativeAccountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\naccountFilters: $accountFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeAccountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolume? AwsNativeEbsVolume
        // GraphQL -> awsNativeEbsVolume: AwsNativeEbsVolume! (type)
        public static string AwsNativeEbsVolume(
            ref AwsNativeEbsVolume? cmdletReply
        )
        {
            string args = "\n(\nebsVolumeRubrikId: $ebsVolumeRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEbsVolume() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumes(
            ref AwsNativeEbsVolumeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeFilters: $ebsVolumeFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEbsVolumeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolumes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumesByName
        // GraphQL -> awsNativeEbsVolumesByName: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumesByName(
            ref AwsNativeEbsVolumeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeName: $ebsVolumeName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEbsVolumeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolumesByName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2Instance? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsNativeEc2Instance! (type)
        public static string AwsNativeEc2Instance(
            ref AwsNativeEc2Instance? cmdletReply
        )
        {
            string args = "\n(\nec2InstanceRubrikId: $ec2InstanceRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEc2Instance() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2Instances(
            ref AwsNativeEc2InstanceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nec2InstanceFilters: $ec2InstanceFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEc2InstanceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2Instances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2InstancesByName
        // GraphQL -> awsNativeEc2InstancesByName: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2InstancesByName(
            ref AwsNativeEc2InstanceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nec2InstanceName: $ec2InstanceName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeEc2InstanceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2InstancesByName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RdsInstanceExportDefaults? AwsNativeRdsExportDefaults
        // GraphQL -> awsNativeRdsExportDefaults: RdsInstanceExportDefaults! (type)
        public static string AwsNativeRdsExportDefaults(
            ref RdsInstanceExportDefaults? cmdletReply
        )
        {
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\nsnapshotId: $snapshotId\nisPointInTime: $isPointInTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RdsInstanceExportDefaults() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsExportDefaults" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsInstance? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsNativeRdsInstance! (type)
        public static string AwsNativeRdsInstance(
            ref AwsNativeRdsInstance? cmdletReply
        )
        {
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeRdsInstance() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        public static string AwsNativeRdsInstances(
            ref AwsNativeRdsInstanceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nrdsInstanceFilters: $rdsInstanceFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeRdsInstanceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsPointInTimeRestoreWindow? AwsNativeRdsPointInTimeRestoreWindow
        // GraphQL -> awsNativeRdsPointInTimeRestoreWindow: AwsNativeRdsPointInTimeRestoreWindow! (type)
        public static string AwsNativeRdsPointInTimeRestoreWindow(
            ref AwsNativeRdsPointInTimeRestoreWindow? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeRdsPointInTimeRestoreWindow() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsPointInTimeRestoreWindow" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRoot? AwsNativeRoot
        // GraphQL -> awsNativeRoot: AwsNativeRoot! (type)
        public static string AwsNativeRoot(
            ref AwsNativeRoot? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeS3Bucket? AwsNativeS3Bucket
        // GraphQL -> awsNativeS3Bucket: AwsNativeS3Bucket! (type)
        public static string AwsNativeS3Bucket(
            ref AwsNativeS3Bucket? cmdletReply
        )
        {
            string args = "\n(\ns3BucketRubrikId: $s3BucketRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AwsNativeS3Bucket() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeS3Bucket" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureAdDirectoryConnection? AzureAdDirectories
        // GraphQL -> azureAdDirectories: AzureAdDirectoryConnection! (type)
        public static string AzureAdDirectories(
            ref AzureAdDirectoryConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureAdDirectoryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureAdDirectories" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureAdDirectory? AzureAdDirectory
        // GraphQL -> azureAdDirectory: AzureAdDirectory! (type)
        public static string AzureAdDirectory(
            ref AzureAdDirectory? cmdletReply
        )
        {
            string args = "\n(\nworkloadFid: $workloadFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureAdDirectory() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureAdDirectory" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountPermissionConfigResponse? AzureCloudAccountPermissionConfig
        // GraphQL -> azureCloudAccountPermissionConfig: AzureCloudAccountPermissionConfigResponse! (type)
        public static string AzureCloudAccountPermissionConfig(
            ref AzureCloudAccountPermissionConfigResponse? cmdletReply
        )
        {
            string args = "\n(\nfeature: $feature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureCloudAccountPermissionConfigResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountPermissionConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountSubscriptionWithFeatures? AzureCloudAccountSubscriptionWithFeatures
        // GraphQL -> azureCloudAccountSubscriptionWithFeatures: AzureCloudAccountSubscriptionWithFeatures! (type)
        public static string AzureCloudAccountSubscriptionWithFeatures(
            ref AzureCloudAccountSubscriptionWithFeatures? cmdletReply
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureCloudAccountSubscriptionWithFeatures() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountSubscriptionWithFeatures" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountTenant? AzureCloudAccountTenant
        // GraphQL -> azureCloudAccountTenant: AzureCloudAccountTenant! (type)
        public static string AzureCloudAccountTenant(
            ref AzureCloudAccountTenant? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureCloudAccountTenant() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountTenant" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountTenantWithExoConfigs? AzureCloudAccountTenantWithExoConfigs
        // GraphQL -> azureCloudAccountTenantWithExoConfigs: AzureCloudAccountTenantWithExoConfigs! (type)
        public static string AzureCloudAccountTenantWithExoConfigs(
            ref AzureCloudAccountTenantWithExoConfigs? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureCloudAccountTenantWithExoConfigs() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountTenantWithExoConfigs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeManagedDisk? AzureNativeManagedDisk
        // GraphQL -> azureNativeManagedDisk: AzureNativeManagedDisk! (type)
        public static string AzureNativeManagedDisk(
            ref AzureNativeManagedDisk? cmdletReply
        )
        {
            string args = "\n(\nazureManagedDiskRubrikId: $azureManagedDiskRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeManagedDisk() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeManagedDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeManagedDiskConnection? AzureNativeManagedDisks
        // GraphQL -> azureNativeManagedDisks: AzureNativeManagedDiskConnection! (type)
        public static string AzureNativeManagedDisks(
            ref AzureNativeManagedDiskConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeManagedDiskConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeManagedDisks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        public static string AzureNativeResourceGroup(
            ref AzureNativeResourceGroup? cmdletReply
        )
        {
            string args = "\n(\nresourceGroupId: $resourceGroupId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeResourceGroup() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeResourceGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        public static string AzureNativeResourceGroups(
            ref AzureNativeResourceGroupConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ncommonResourceGroupFilters: $commonResourceGroupFilters\nprotectedObjectTypes: $protectedObjectTypes\nazureNativeProtectionFeatures: $azureNativeProtectionFeatures\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeResourceGroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeResourceGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeRoot? AzureNativeRoot
        // GraphQL -> azureNativeRoot: AzureNativeRoot! (type)
        public static string AzureNativeRoot(
            ref AzureNativeRoot? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSubscription? AzureNativeSubscription
        // GraphQL -> azureNativeSubscription: AzureNativeSubscription! (type)
        public static string AzureNativeSubscription(
            ref AzureNativeSubscription? cmdletReply
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeSubscription() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeSubscription" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSubscriptionConnection? AzureNativeSubscriptions
        // GraphQL -> azureNativeSubscriptions: AzureNativeSubscriptionConnection! (type)
        public static string AzureNativeSubscriptions(
            ref AzureNativeSubscriptionConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nsubscriptionFilters: $subscriptionFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\nazureNativeProtectionFeature: $azureNativeProtectionFeature\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeSubscriptionConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeSubscriptions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeVirtualMachine? AzureNativeVirtualMachine
        // GraphQL -> azureNativeVirtualMachine: AzureNativeVirtualMachine! (type)
        public static string AzureNativeVirtualMachine(
            ref AzureNativeVirtualMachine? cmdletReply
        )
        {
            string args = "\n(\nazureVirtualMachineRubrikId: $azureVirtualMachineRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeVirtualMachine() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeVirtualMachine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        public static string AzureNativeVirtualMachines(
            ref AzureNativeVirtualMachineConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nvirtualMachineFilters: $virtualMachineFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeVirtualMachineConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeVirtualMachines" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSecurityGroupResp? AzureO365CheckNsgOutboundRules
        // GraphQL -> azureO365CheckNSGOutboundRules: AzureNetworkSecurityGroupResp! (type)
        public static string AzureO365CheckNsgOutboundRules(
            ref AzureNetworkSecurityGroupResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNetworkSecurityGroupResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckNSGOutboundRules" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSubnetResp? AzureO365CheckNetworkSubnet
        // GraphQL -> azureO365CheckNetworkSubnet: AzureNetworkSubnetResp! (type)
        public static string AzureO365CheckNetworkSubnet(
            ref AzureNetworkSubnetResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNetworkSubnetResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckNetworkSubnet" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckResourceGroupName
        // GraphQL -> azureO365CheckResourceGroupName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckResourceGroupName(
            ref AzureResourceAvailabilityResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureResourceAvailabilityResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckResourceGroupName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountAccessibility
        // GraphQL -> azureO365CheckStorageAccountAccessibility: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountAccessibility(
            ref AzureResourceAvailabilityResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\ngroupName: $groupName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureResourceAvailabilityResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckStorageAccountAccessibility" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountName
        // GraphQL -> azureO365CheckStorageAccountName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountName(
            ref AzureResourceAvailabilityResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureResourceAvailabilityResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckStorageAccountName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckSubscriptionQuota
        // GraphQL -> azureO365CheckSubscriptionQuota: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckSubscriptionQuota(
            ref AzureResourceAvailabilityResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureResourceAvailabilityResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckSubscriptionQuota" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckVirtualNetworkName
        // GraphQL -> azureO365CheckVirtualNetworkName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckVirtualNetworkName(
            ref AzureResourceAvailabilityResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\nvnet_name: $vnet_name\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureResourceAvailabilityResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckVirtualNetworkName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAzureO365ExocomputeResp? AzureO365Exocompute
        // GraphQL -> azureO365Exocompute: GetAzureO365ExocomputeResp! (type)
        public static string AzureO365Exocompute(
            ref GetAzureO365ExocomputeResp? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\nexocomputeClusterId: $exocomputeClusterId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetAzureO365ExocomputeResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365Exocompute" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAzureHostTypeResp? AzureO365GetAzureHostType
        // GraphQL -> azureO365GetAzureHostType: GetAzureHostTypeResp! (type)
        public static string AzureO365GetAzureHostType(
            ref GetAzureHostTypeResp? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetAzureHostTypeResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365GetAzureHostType" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSubnetUnusedAddrResp? AzureO365GetNetworkSubnetUnusedAddr
        // GraphQL -> azureO365GetNetworkSubnetUnusedAddr: AzureNetworkSubnetUnusedAddrResp! (type)
        public static string AzureO365GetNetworkSubnetUnusedAddr(
            ref AzureNetworkSubnetUnusedAddrResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNetworkSubnetUnusedAddrResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365GetNetworkSubnetUnusedAddr" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureUserRoleResp? AzureO365ValidateUserRoles
        // GraphQL -> azureO365ValidateUserRoles: AzureUserRoleResp! (type)
        public static string AzureO365ValidateUserRoles(
            ref AzureUserRoleResp? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureUserRoleResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365ValidateUserRoles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RegionConnection? AzureRegions
        // GraphQL -> azureRegions: RegionConnection! (type)
        public static string AzureRegions(
            ref RegionConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RegionConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureRegions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResourceGroupConnection? AzureResourceGroups
        // GraphQL -> azureResourceGroups: ResourceGroupConnection! (type)
        public static string AzureResourceGroups(
            ref ResourceGroupConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ResourceGroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureResourceGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseDb? AzureSqlDatabase
        // GraphQL -> azureSqlDatabase: AzureSqlDatabaseDb! (type)
        public static string AzureSqlDatabase(
            ref AzureSqlDatabaseDb? cmdletReply
        )
        {
            string args = "\n(\nazureSqlDatabaseRubrikId: $azureSqlDatabaseRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlDatabaseDb() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
            ref AzureNativeSqlDatabasePointInTimeRestoreWindow? cmdletReply
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        public static string AzureSqlDatabaseServer(
            ref AzureSqlDatabaseServer? cmdletReply
        )
        {
            string args = "\n(\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlDatabaseServer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseServerConnection? AzureSqlDatabaseServers
        // GraphQL -> azureSqlDatabaseServers: AzureSqlDatabaseServerConnection! (type)
        public static string AzureSqlDatabaseServers(
            ref AzureSqlDatabaseServerConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseServerFilters: $azureSqlDatabaseServerFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlDatabaseServerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseDbConnection? AzureSqlDatabases
        // GraphQL -> azureSqlDatabases: AzureSqlDatabaseDbConnection! (type)
        public static string AzureSqlDatabases(
            ref AzureSqlDatabaseDbConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseFilters: $azureSqlDatabaseFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlDatabaseDbConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceDatabase? AzureSqlManagedInstanceDatabase
        // GraphQL -> azureSqlManagedInstanceDatabase: AzureSqlManagedInstanceDatabase! (type)
        public static string AzureSqlManagedInstanceDatabase(
            ref AzureSqlManagedInstanceDatabase? cmdletReply
        )
        {
            string args = "\n(\nazureSqlManagedInstanceDatabaseRubrikId: $azureSqlManagedInstanceDatabaseRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlManagedInstanceDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceDatabaseConnection? AzureSqlManagedInstanceDatabases
        // GraphQL -> azureSqlManagedInstanceDatabases: AzureSqlManagedInstanceDatabaseConnection! (type)
        public static string AzureSqlManagedInstanceDatabases(
            ref AzureSqlManagedInstanceDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceDatabaseFilters: $azureSqlManagedInstanceDatabaseFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlManagedInstanceDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
            ref AzureNativeSqlDatabasePointInTimeRestoreWindow? cmdletReply
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlManagedInstanceName: $azureSqlManagedInstanceName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceServer? AzureSqlManagedInstanceServer
        // GraphQL -> azureSqlManagedInstanceServer: AzureSqlManagedInstanceServer! (type)
        public static string AzureSqlManagedInstanceServer(
            ref AzureSqlManagedInstanceServer? cmdletReply
        )
        {
            string args = "\n(\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlManagedInstanceServer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceServerConnection? AzureSqlManagedInstanceServers
        // GraphQL -> azureSqlManagedInstanceServers: AzureSqlManagedInstanceServerConnection! (type)
        public static string AzureSqlManagedInstanceServers(
            ref AzureSqlManagedInstanceServerConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceServerFilters: $azureSqlManagedInstanceServerFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSqlManagedInstanceServerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StorageAccountConnection? AzureStorageAccounts
        // GraphQL -> azureStorageAccounts: StorageAccountConnection! (type)
        public static string AzureStorageAccounts(
            ref StorageAccountConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new StorageAccountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureStorageAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SubnetConnection? AzureSubnets
        // GraphQL -> azureSubnets: SubnetConnection! (type)
        public static string AzureSubnets(
            ref SubnetConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nvNetId: $vNetId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SubnetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSubnets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSubscriptionConnection? AzureSubscriptions
        // GraphQL -> azureSubscriptions: AzureSubscriptionConnection! (type)
        public static string AzureSubscriptions(
            ref AzureSubscriptionConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AzureSubscriptionConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSubscriptions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VnetConnection? AzureVnets
        // GraphQL -> azureVNets: VnetConnection! (type)
        public static string AzureVnets(
            ref VnetConnection? cmdletReply
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VnetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureVNets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintConnection? BlueprintConnection
        // GraphQL -> blueprintConnection: BlueprintConnection! (type)
        public static string BlueprintConnection(
            ref BlueprintConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BlueprintConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "blueprintConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintRecoverySpecs? BlueprintRecoverySpecs
        // GraphQL -> blueprintRecoverySpecs: BlueprintRecoverySpecs! (type)
        public static string BlueprintRecoverySpecs(
            ref BlueprintRecoverySpecs? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nignoreErrors: $ignoreErrors\nvalidate: $validate\ngetInvalidSpecs: $getInvalidSpecs\nsnappableInfos: $snappableInfos\nfailoverId: $failoverId\nresourceSpecType: $resourceSpecType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BlueprintRecoverySpecs() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "blueprintRecoverySpecs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseCalendar
        // GraphQL -> browseCalendar: O365ExchangeObjectConnection! (type)
        public static string BrowseCalendar(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseCalendar" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseContacts
        // GraphQL -> browseContacts: O365ExchangeObjectConnection! (type)
        public static string BrowseContacts(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseContacts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseFolder
        // GraphQL -> browseFolder: O365ExchangeObjectConnection! (type)
        public static string BrowseFolder(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseFolder" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamConvChannelConnection? BrowseO365TeamConvChannels
        // GraphQL -> browseO365TeamConvChannels: O365TeamConvChannelConnection! (type)
        public static string BrowseO365TeamConvChannels(
            ref O365TeamConvChannelConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFidOpt: $snapshotFidOpt\nexcludeArchived: $excludeArchived\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamConvChannelConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseO365TeamConvChannels" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseOnedrive
        // GraphQL -> browseOnedrive: O365OnedriveObjectConnection! (type)
        public static string BrowseOnedrive(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nonedriveSearchFilter: $onedriveSearchFilter\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseOnedrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointDrive
        // GraphQL -> browseSharepointDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointDrive(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSharepointDrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointList
        // GraphQL -> browseSharepointList: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointList(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSharepointList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileConnection? BrowseSnapshotFileConnection
        // GraphQL -> browseSnapshotFileConnection: SnapshotFileConnection! (type)
        public static string BrowseSnapshotFileConnection(
            ref SnapshotFileConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotFileConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSnapshotFileConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsChannelConnection? BrowseTeamsChannels
        // GraphQL -> browseTeamsChannels: O365TeamsChannelConnection! (type)
        public static string BrowseTeamsChannels(
            ref O365TeamsChannelConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamsChannelConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseTeamsChannels" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseTeamsDrive
        // GraphQL -> browseTeamsDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseTeamsDrive(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nteamsDriveSearchFilter: $teamsDriveSearchFilter\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseTeamsDrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkRecoveryProgressReply? BulkRecoveryProgress
        // GraphQL -> bulkRecoveryProgress: BulkRecoveryProgressReply! (type)
        public static string BulkRecoveryProgress(
            ref BulkRecoveryProgressReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BulkRecoveryProgressReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkRecoveryProgress" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraColumnFamilyConnection? CassandraColumnFamilies
        // GraphQL -> cassandraColumnFamilies: CassandraColumnFamilyConnection! (type)
        public static string CassandraColumnFamilies(
            ref CassandraColumnFamilyConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraColumnFamilyConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraColumnFamily? CassandraColumnFamily
        // GraphQL -> cassandraColumnFamily: CassandraColumnFamily! (type)
        public static string CassandraColumnFamily(
            ref CassandraColumnFamily? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraColumnFamily() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamily" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMosaicRecoverableRangeResponse? CassandraColumnFamilyRecoverableRange
        // GraphQL -> cassandraColumnFamilyRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string CassandraColumnFamilyRecoverableRange(
            ref GetMosaicRecoverableRangeResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetMosaicRecoverableRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilyRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSchemaResponse? CassandraColumnFamilySchema
        // GraphQL -> cassandraColumnFamilySchema: GetSchemaResponse! (type)
        public static string CassandraColumnFamilySchema(
            ref GetSchemaResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetSchemaResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilySchema" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraKeyspace? CassandraKeyspace
        // GraphQL -> cassandraKeyspace: CassandraKeyspace! (type)
        public static string CassandraKeyspace(
            ref CassandraKeyspace? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraKeyspace() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraKeyspace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraKeyspaceConnection? CassandraKeyspaces
        // GraphQL -> cassandraKeyspaces: CassandraKeyspaceConnection! (type)
        public static string CassandraKeyspaces(
            ref CassandraKeyspaceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraKeyspaceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraKeyspaces" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraSource? CassandraSource
        // GraphQL -> cassandraSource: CassandraSource! (type)
        public static string CassandraSource(
            ref CassandraSource? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraSource() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraSourceConnection? CassandraSources
        // GraphQL -> cassandraSources: CassandraSourceConnection! (type)
        public static string CassandraSources(
            ref CassandraSourceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CassandraSourceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraSources" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmInventorySubHierarchyRoot? CdmInventorySubHierarchyRoot
        // GraphQL -> cdmInventorySubHierarchyRoot: CdmInventorySubHierarchyRoot! (type)
        public static string CdmInventorySubHierarchyRoot(
            ref CdmInventorySubHierarchyRoot? cmdletReply
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmInventorySubHierarchyRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmInventorySubHierarchyRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingTarget? CdmMssqlLogShippingTarget
        // GraphQL -> cdmMssqlLogShippingTarget: MssqlLogShippingTarget (type)
        public static string CdmMssqlLogShippingTarget(
            ref MssqlLogShippingTarget? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlLogShippingTarget() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmMssqlLogShippingTarget" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingTargetConnection? CdmMssqlLogShippingTargets
        // GraphQL -> cdmMssqlLogShippingTargets: MssqlLogShippingTargetConnection! (type)
        public static string CdmMssqlLogShippingTargets(
            ref MssqlLogShippingTargetConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlLogShippingTargetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmMssqlLogShippingTargets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureCdmVersionReply? CdmVersionCheck
        // GraphQL -> cdmVersionCheck: FeatureCdmVersionReply! (type)
        public static string CdmVersionCheck(
            ref FeatureCdmVersionReply? cmdletReply
        )
        {
            string args = "\n(\nfeatureToCdmVersion: $featureToCdmVersion\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FeatureCdmVersionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmVersionCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCertificateInfoReply? CertificateInfo
        // GraphQL -> certificateInfo: GetCertificateInfoReply! (type)
        public static string CertificateInfo(
            ref GetCertificateInfoReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetCertificateInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Csr? CertificateSigningRequest
        // GraphQL -> certificateSigningRequest: Csr! (type)
        public static string CertificateSigningRequest(
            ref Csr? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Csr() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateSigningRequest" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CsrConnection? CertificateSigningRequests
        // GraphQL -> certificateSigningRequests: CsrConnection! (type)
        public static string CertificateSigningRequests(
            ref CsrConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CsrConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateSigningRequests" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateConnection? Certificates
        // GraphQL -> certificates: CertificateConnection! (type)
        public static string Certificates(
            ref CertificateConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CertificateConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateConnection? CertificatesWithKey
        // GraphQL -> certificatesWithKey: CertificateConnection! (type)
        public static string CertificatesWithKey(
            ref CertificateConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new CertificateConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificatesWithKey" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CheckCloudComputeConnectivityJobProgress
        // GraphQL -> checkCloudComputeConnectivityJobProgress: AsyncRequestStatus! (type)
        public static string CheckCloudComputeConnectivityJobProgress(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudComputeConnectivityJobProgress" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeLabelRuleNameUniqueness
        // GraphQL -> checkCloudNativeLabelRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeLabelRuleNameUniqueness(
            ref IsCloudNativeTagRuleNameUniqueReply? cmdletReply
        )
        {
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new IsCloudNativeTagRuleNameUniqueReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudNativeLabelRuleNameUniqueness" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeTagRuleNameUniqueness
        // GraphQL -> checkCloudNativeTagRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeTagRuleNameUniqueness(
            ref IsCloudNativeTagRuleNameUniqueReply? cmdletReply
        )
        {
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new IsCloudNativeTagRuleNameUniqueReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudNativeTagRuleNameUniqueness" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckGuestOsReply? CheckGuestOsForAppBlueprint
        // GraphQL -> checkGuestOsForAppBlueprint: CheckGuestOsReply! (type)
        public static string CheckGuestOsForAppBlueprint(
            ref CheckGuestOsReply? cmdletReply
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CheckGuestOsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkGuestOsForAppBlueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationBannerSettings? ClassificationBannerSettings
        // GraphQL -> classificationBannerSettings: ClassificationBannerSettings! (type)
        public static string ClassificationBannerSettings(
            ref ClassificationBannerSettings? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationBannerSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "classificationBannerSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationLoginSettings? ClassificationLoginSettings
        // GraphQL -> classificationLoginSettings: ClassificationLoginSettings! (type)
        public static string ClassificationLoginSettings(
            ref ClassificationLoginSettings? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationLoginSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "classificationLoginSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectNasExport? CloudDirectNasExport
        // GraphQL -> cloudDirectNasExport: CloudDirectNasExport! (type)
        public static string CloudDirectNasExport(
            ref CloudDirectNasExport? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudDirectNasExport() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectNasExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSnapshot? CloudDirectSnapshot
        // GraphQL -> cloudDirectSnapshot: CloudDirectSnapshot! (type)
        public static string CloudDirectSnapshot(
            ref CloudDirectSnapshot? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudDirectSnapshot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSnapshotConnection? CloudDirectSnapshots
        // GraphQL -> cloudDirectSnapshots: CloudDirectSnapshotConnection! (type)
        public static string CloudDirectSnapshots(
            ref CloudDirectSnapshotConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudDirectSnapshotConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSystems? CloudDirectSystems
        // GraphQL -> cloudDirectSystems: CloudDirectSystems! (type)
        public static string CloudDirectSystems(
            ref CloudDirectSystems? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudDirectSystems() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSystems" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckArchivedSnapshotsLockedReply? CloudNativeCheckArchivedSnapshotsLocked
        // GraphQL -> cloudNativeCheckArchivedSnapshotsLocked: CheckArchivedSnapshotsLockedReply! (type)
        public static string CloudNativeCheckArchivedSnapshotsLocked(
            ref CheckArchivedSnapshotsLockedReply? cmdletReply
        )
        {
            string args = "\n(\nworkloadId: $workloadId\nsnapshotIds: $snapshotIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CheckArchivedSnapshotsLockedReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeCheckArchivedSnapshotsLocked" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCloudNativeLabelRulesReply? CloudNativeLabelRules
        // GraphQL -> cloudNativeLabelRules: GetCloudNativeLabelRulesReply! (type)
        public static string CloudNativeLabelRules(
            ref GetCloudNativeLabelRulesReply? cmdletReply
        )
        {
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetCloudNativeLabelRulesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeLabelRules" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RbaInstallerUrls? CloudNativeRbaInstallers
        // GraphQL -> cloudNativeRbaInstallers: RbaInstallerUrls! (type)
        public static string CloudNativeRbaInstallers(
            ref RbaInstallerUrls? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new RbaInstallerUrls() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeRbaInstallers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeSnapshotDetailsForRecoveryReply? CloudNativeSnapshotDetailsForRecovery
        // GraphQL -> cloudNativeSnapshotDetailsForRecovery: CloudNativeSnapshotDetailsForRecoveryReply! (type)
        public static string CloudNativeSnapshotDetailsForRecovery(
            ref CloudNativeSnapshotDetailsForRecoveryReply? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudNativeSnapshotDetailsForRecoveryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSnapshotDetailsForRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileConnection? CloudNativeSnapshots
        // GraphQL -> cloudNativeSnapshots: SnapshotFileConnection! (type)
        public static string CloudNativeSnapshots(
            ref SnapshotFileConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotFileConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeSqlServerSetupScript? CloudNativeSqlServerSetupScript
        // GraphQL -> cloudNativeSqlServerSetupScript: CloudNativeSqlServerSetupScript! (type)
        public static string CloudNativeSqlServerSetupScript(
            ref CloudNativeSqlServerSetupScript? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudNativeSqlServerSetupScript() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSqlServerSetupScript" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCloudNativeTagRulesReply? CloudNativeTagRules
        // GraphQL -> cloudNativeTagRules: GetCloudNativeTagRulesReply! (type)
        public static string CloudNativeTagRules(
            ref GetCloudNativeTagRulesReply? cmdletReply
        )
        {
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetCloudNativeTagRulesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeTagRules" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeVersionedFileConnection? CloudNativeWorkloadVersionedFiles
        // GraphQL -> cloudNativeWorkloadVersionedFiles: CloudNativeVersionedFileConnection! (type)
        public static string CloudNativeWorkloadVersionedFiles(
            ref CloudNativeVersionedFileConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableId: $snappableId\nsearchQuery: $searchQuery\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CloudNativeVersionedFileConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeWorkloadVersionedFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        public static string Cluster(
            ref Cluster? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Cluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateSummaryListResponse? ClusterCertificates
        // GraphQL -> clusterCertificates: CertificateSummaryListResponse! (type)
        public static string ClusterCertificates(
            ref CertificateSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CertificateSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterCertificates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        public static string ClusterConnection(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterCsr? ClusterCsr
        // GraphQL -> clusterCsr: ClusterCsr! (type)
        public static string ClusterCsr(
            ref ClusterCsr? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterCsr() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterCsr" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalGetDefaultGatewayResponse? ClusterDefaultGateway
        // GraphQL -> clusterDefaultGateway: InternalGetDefaultGatewayResponse! (type)
        public static string ClusterDefaultGateway(
            ref InternalGetDefaultGatewayResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InternalGetDefaultGatewayResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterDefaultGateway" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterDnsReply? ClusterDns
        // GraphQL -> clusterDns: ClusterDnsReply! (type)
        public static string ClusterDns(
            ref ClusterDnsReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterDnsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterDns" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterEncryptionInfoConnection? ClusterEncryptionInfo
        // GraphQL -> clusterEncryptionInfo: ClusterEncryptionInfoConnection! (type)
        public static string ClusterEncryptionInfo(
            ref ClusterEncryptionInfoConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nclusterName: $clusterName\nencryptionStatusFilter: $encryptionStatusFilter\nkeyProtection: $keyProtection\nclusters: $clusters\nencryptionTypes: $encryptionTypes\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterEncryptionInfoConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterEncryptionInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalGetClusterIpsResponse? ClusterFloatingIps
        // GraphQL -> clusterFloatingIps: InternalGetClusterIpsResponse! (type)
        public static string ClusterFloatingIps(
            ref InternalGetClusterIpsResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InternalGetClusterIpsResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterFloatingIps" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterGroupByConnection? ClusterGroupByConnection
        // GraphQL -> clusterGroupByConnection: ClusterGroupByConnection! (type)
        public static string ClusterGroupByConnection(
            ref ClusterGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ModifyIpmiReply? ClusterIpmi
        // GraphQL -> clusterIpmi: ModifyIpmiReply! (type)
        public static string ClusterIpmi(
            ref ModifyIpmiReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ModifyIpmiReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterIpmi" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterIpv6ModeReply? ClusterIpv6Mode
        // GraphQL -> clusterIpv6Mode: ClusterIpv6ModeReply! (type)
        public static string ClusterIpv6Mode(
            ref ClusterIpv6ModeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterIpv6ModeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterIpv6Mode" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkInterfaceListResponse? ClusterNetworkInterfaces
        // GraphQL -> clusterNetworkInterfaces: NetworkInterfaceListResponse! (type)
        public static string ClusterNetworkInterfaces(
            ref NetworkInterfaceListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NetworkInterfaceListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNetworkInterfaces" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeStatusListResponse? ClusterNodes
        // GraphQL -> clusterNodes: NodeStatusListResponse! (type)
        public static string ClusterNodes(
            ref NodeStatusListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NodeStatusListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNodes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NtpServerConfigurationListResponse? ClusterNtpServers
        // GraphQL -> clusterNtpServers: NtpServerConfigurationListResponse! (type)
        public static string ClusterNtpServers(
            ref NtpServerConfigurationListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NtpServerConfigurationListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNtpServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterOperationJobProgress? ClusterOperationJobProgress
        // GraphQL -> clusterOperationJobProgress: ClusterOperationJobProgress! (type)
        public static string ClusterOperationJobProgress(
            ref ClusterOperationJobProgress? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterOperationJobProgress() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterOperationJobProgress" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterProxyReply? ClusterProxy
        // GraphQL -> clusterProxy: ClusterProxyReply! (type)
        public static string ClusterProxy(
            ref ClusterProxyReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterProxyReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterProxy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcvLocationBasicInfoConnection? ClusterRcvLocations
        // GraphQL -> clusterRcvLocations: RcvLocationBasicInfoConnection! (type)
        public static string ClusterRcvLocations(
            ref RcvLocationBasicInfoConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\ncdmClusterUUID: $cdmClusterUUID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RcvLocationBasicInfoConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterRcvLocations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterRegistrationProductInfoType? ClusterRegistrationProductInfo
        // GraphQL -> clusterRegistrationProductInfo: ClusterRegistrationProductInfoType! (type)
        public static string ClusterRegistrationProductInfo(
            ref ClusterRegistrationProductInfoType? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterRegistrationProductInfoType() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterRegistrationProductInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterSlaDomainConnection? ClusterSlaDomainConnection
        // GraphQL -> clusterSlaDomainConnection: ClusterSlaDomainConnection! (type)
        public static string ClusterSlaDomainConnection(
            ref ClusterSlaDomainConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterSlaDomainConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterSlaDomainConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterSlaDomainForFilterConnection? ClusterSlaDomainFilterConnection
        // GraphQL -> clusterSlaDomainFilterConnection: ClusterSlaDomainForFilterConnection! (type)
        public static string ClusterSlaDomainFilterConnection(
            ref ClusterSlaDomainForFilterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterSlaDomainForFilterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterSlaDomainFilterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? ClusterTypeList
        // GraphQL -> clusterTypeList: [GroupCount!]! (type)
        public static string ClusterTypeList(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterTypeList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VlanConfigListResponse? ClusterVlans
        // GraphQL -> clusterVlans: VlanConfigListResponse! (type)
        public static string ClusterVlans(
            ref VlanConfigListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VlanConfigListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterVlans" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterWebSignedCertificateReply? ClusterWebSignedCertificate
        // GraphQL -> clusterWebSignedCertificate: ClusterWebSignedCertificateReply! (type)
        public static string ClusterWebSignedCertificate(
            ref ClusterWebSignedCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterWebSignedCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWebSignedCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterWithConfigProtectionInfo
        // GraphQL -> clusterWithConfigProtectionInfo: ClusterConnection! (type)
        public static string ClusterWithConfigProtectionInfo(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nconfigProtectionFilter: $configProtectionFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWithConfigProtectionInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterWithUpgradesInfo
        // GraphQL -> clusterWithUpgradesInfo: ClusterConnection! (type)
        public static string ClusterWithUpgradesInfo(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nupgradeFilter: $upgradeFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWithUpgradesInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ComputeClusterDetail? ComputeClusterStatus
        // GraphQL -> computeClusterStatus: ComputeClusterDetail! (type)
        public static string ComputeClusterStatus(
            ref ComputeClusterDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ComputeClusterDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "computeClusterStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ConfigProtectionSetupInfo? ConfigProtectionSetupInfo
        // GraphQL -> configProtectionSetupInfo: ConfigProtectionSetupInfo! (type)
        public static string ConfigProtectionSetupInfo(
            ref ConfigProtectionSetupInfo? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ConfigProtectionSetupInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "configProtectionSetupInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ConfiguredGroupMemberConnection? ConfiguredGroupMembers
        // GraphQL -> configuredGroupMembers: O365ConfiguredGroupMemberConnection! (type)
        public static string ConfiguredGroupMembers(
            ref O365ConfiguredGroupMemberConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\norgId: $orgId\nwildcard: $wildcard\npdls: $pdls\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ConfiguredGroupMemberConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "configuredGroupMembers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CountOfObjectsProtectedBySlAsResult? CountOfObjectsProtectedBySlas
        // GraphQL -> countOfObjectsProtectedBySlas: CountOfObjectsProtectedBySLAsResult! (type)
        public static string CountOfObjectsProtectedBySlas(
            ref CountOfObjectsProtectedBySlAsResult? cmdletReply
        )
        {
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\ntypeFilter: $typeFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CountOfObjectsProtectedBySlAsResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "countOfObjectsProtectedBySlas" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Crawl? Crawl
        // GraphQL -> crawl: Crawl! (type)
        public static string Crawl(
            ref Crawl? cmdletReply
        )
        {
            string args = "\n(\ncrawlId: $crawlId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Crawl() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "crawl" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CrawlConnection? Crawls
        // GraphQL -> crawls: CrawlConnection! (type)
        public static string Crawls(
            ref CrawlConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new CrawlConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "crawls" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Org? CurrentOrg
        // GraphQL -> currentOrg: Org! (type)
        public static string CurrentOrg(
            ref Org? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new Org() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentOrg" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> User? CurrentUser
        // GraphQL -> currentUser: User! (type)
        public static string CurrentUser(
            ref User? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new User() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentUser" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserLoginContext? CurrentUserLoginContext
        // GraphQL -> currentUserLoginContext: UserLoginContext! (type)
        public static string CurrentUserLoginContext(
            ref UserLoginContext? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new UserLoginContext() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentUserLoginContext" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Analyzer? CustomAnalyzer
        // GraphQL -> customAnalyzer: Analyzer! (type)
        public static string CustomAnalyzer(
            ref Analyzer? cmdletReply
        )
        {
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Analyzer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "customAnalyzer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CyberRecoveryObjectConnection? CyberRecoveryObjects
        // GraphQL -> cyberRecoveryObjects: CyberRecoveryObjectConnection! (type)
        public static string CyberRecoveryObjects(
            ref CyberRecoveryObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ncyberRecoveryObjectsFilter: $cyberRecoveryObjectsFilter\ncyberRecoveryObjectsSort: $cyberRecoveryObjectsSort\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CyberRecoveryObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cyberRecoveryObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetDashboardSummaryReply? DashboardSummary
        // GraphQL -> dashboardSummary: GetDashboardSummaryReply! (type)
        public static string DashboardSummary(
            ref GetDashboardSummaryReply? cmdletReply
        )
        {
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetDashboardSummaryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dashboardSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DataDiscoveryObjectsCount? DataDiscoveryObjectsCount
        // GraphQL -> dataDiscoveryObjectsCount: DataDiscoveryObjectsCount! (type)
        public static string DataDiscoveryObjectsCount(
            ref DataDiscoveryObjectsCount? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new DataDiscoveryObjectsCount() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dataDiscoveryObjectsCount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DataViewMetadata>? DataViewMetadata
        // GraphQL -> dataViewMetadata: [dataViewMetadata!]! (type)
        public static string DataViewMetadata(
            ref List<DataViewMetadata>? cmdletReply
        )
        {
            string args = "\n(\nsearchTerm: $searchTerm\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<DataViewMetadata>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dataViewMetadata" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> QuerySddlReply? DatagovSecDesc
        // GraphQL -> datagovSecDesc: QuerySDDLReply! (type)
        public static string DatagovSecDesc(
            ref QuerySddlReply? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nstdPath: $stdPath\nskipResolveSids: $skipResolveSids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new QuerySddlReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "datagovSecDesc" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2Database? Db2Database
        // GraphQL -> db2Database: Db2Database! (type)
        public static string Db2Database(
            ref Db2Database? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2Database() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Database" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2DatabaseConnection? Db2Databases
        // GraphQL -> db2Databases: Db2DatabaseConnection! (type)
        public static string Db2Databases(
            ref Db2DatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2DatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Databases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        public static string Db2Instance(
            ref Db2Instance? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2Instance() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Instance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2InstanceConnection? Db2Instances
        // GraphQL -> db2Instances: Db2InstanceConnection! (type)
        public static string Db2Instances(
            ref Db2InstanceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2InstanceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Instances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2LogSnapshot? Db2LogSnapshot
        // GraphQL -> db2LogSnapshot: Db2LogSnapshot! (type)
        public static string Db2LogSnapshot(
            ref Db2LogSnapshot? cmdletReply
        )
        {
            string args = "\n(\ndb2LogSnapshotFid: $db2LogSnapshotFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2LogSnapshot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2LogSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2LogSnapshotConnection? Db2LogSnapshots
        // GraphQL -> db2LogSnapshots: Db2LogSnapshotConnection! (type)
        public static string Db2LogSnapshots(
            ref Db2LogSnapshotConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2LogSnapshotConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2LogSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2RecoverableRange? Db2RecoverableRange
        // GraphQL -> db2RecoverableRange: Db2RecoverableRange! (type)
        public static string Db2RecoverableRange(
            ref Db2RecoverableRange? cmdletReply
        )
        {
            string args = "\n(\ndb2RecoverableRangeFid: $db2RecoverableRangeFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2RecoverableRange() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2RecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2RecoverableRangeConnection? Db2RecoverableRanges
        // GraphQL -> db2RecoverableRanges: Db2RecoverableRangeConnection! (type)
        public static string Db2RecoverableRanges(
            ref Db2RecoverableRangeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Db2RecoverableRangeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2RecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExportUrlSpecs? DecryptExportUrl
        // GraphQL -> decryptExportUrl: ExportUrlSpecs! (type)
        public static string DecryptExportUrl(
            ref ExportUrlSpecs? cmdletReply
        )
        {
            string args = "\n(\nexportUrlSpecsEnc: $exportUrlSpecsEnc\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExportUrlSpecs() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "decryptExportUrl" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DiffResult? DiffFmd
        // GraphQL -> diffFmd: DiffResult! (type)
        public static string DiffFmd(
            ref DiffResult? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nbrowseDiffPath: $browseDiffPath\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DiffResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "diffFmd" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BootstrappableNodeInfoListResponse? DiscoverNodes
        // GraphQL -> discoverNodes: BootstrappableNodeInfoListResponse! (type)
        public static string DiscoverNodes(
            ref BootstrappableNodeInfoListResponse? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BootstrappableNodeInfoListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoverNodes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPoliciesTimelineReply? DiscoveryTimeline
        // GraphQL -> discoveryTimeline: GetPoliciesTimelineReply! (type)
        public static string DiscoveryTimeline(
            ref GetPoliciesTimelineReply? cmdletReply
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\ngetWhitelistedResults: $getWhitelistedResults\nworkloadTypes: $workloadTypes\nuseOptimisedDiscoveryTimeline: $useOptimisedDiscoveryTimeline\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetPoliciesTimelineReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoveryTimeline" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCdmUpgradesPdfReply? DownloadCdmUpgradesPdf
        // GraphQL -> downloadCdmUpgradesPdf: DownloadCdmUpgradesPdfReply! (type)
        public static string DownloadCdmUpgradesPdf(
            ref DownloadCdmUpgradesPdfReply? cmdletReply
        )
        {
            string args = "\n(\ndownloadFilter: $downloadFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadCdmUpgradesPdfReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadCdmUpgradesPdf" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadPackageStatusReply? DownloadPackageStatus
        // GraphQL -> downloadPackageStatus: DownloadPackageStatusReply! (type)
        public static string DownloadPackageStatus(
            ref DownloadPackageStatusReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadPackageStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadPackageStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadLink? DownloadReportLink
        // GraphQL -> downloadReportLink: DownloadLink! (type)
        public static string DownloadReportLink(
            ref DownloadLink? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nconfig: $config\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadLink() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportLink" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadLink? DownloadReportPdfLink
        // GraphQL -> downloadReportPdfLink: DownloadLink! (type)
        public static string DownloadReportPdfLink(
            ref DownloadLink? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nconfig: $config\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadLink() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportPdfLink" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadSlaWithReplicationCsvReply? DownloadSlaWithReplicationCsv
        // GraphQL -> downloadSlaWithReplicationCsv: DownloadSlaWithReplicationCsvReply! (type)
        public static string DownloadSlaWithReplicationCsv(
            ref DownloadSlaWithReplicationCsvReply? cmdletReply
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DownloadSlaWithReplicationCsvReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSlaWithReplicationCsv" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? DownloadedVersionList
        // GraphQL -> downloadedVersionList: [GroupCount!]! (type)
        public static string DownloadedVersionList(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadedVersionList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EdgeWindowsToolLink? EdgeWindowsToolLink
        // GraphQL -> edgeWindowsToolLink: EdgeWindowsToolLink! (type)
        public static string EdgeWindowsToolLink(
            ref EdgeWindowsToolLink? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new EdgeWindowsToolLink() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "edgeWindowsToolLink" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnvoyRegistrationToken? EnvoyRegistrationToken
        // GraphQL -> envoyRegistrationToken: EnvoyRegistrationToken! (type)
        public static string EnvoyRegistrationToken(
            ref EnvoyRegistrationToken? cmdletReply
        )
        {
            string args = "\n(\ntenantNetworkId: $tenantNetworkId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new EnvoyRegistrationToken() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "envoyRegistrationToken" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDag? ExchangeDag
        // GraphQL -> exchangeDag: ExchangeDag! (type)
        public static string ExchangeDag(
            ref ExchangeDag? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeDag() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDagConnection? ExchangeDags
        // GraphQL -> exchangeDags: ExchangeDagConnection! (type)
        public static string ExchangeDags(
            ref ExchangeDagConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeDagConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDags" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDatabase? ExchangeDatabase
        // GraphQL -> exchangeDatabase: ExchangeDatabase! (type)
        public static string ExchangeDatabase(
            ref ExchangeDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDatabaseConnection? ExchangeDatabases
        // GraphQL -> exchangeDatabases: ExchangeDatabaseConnection! (type)
        public static string ExchangeDatabases(
            ref ExchangeDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeLiveMountConnection? ExchangeLiveMounts
        // GraphQL -> exchangeLiveMounts: ExchangeLiveMountConnection! (type)
        public static string ExchangeLiveMounts(
            ref ExchangeLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeLiveMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeServer? ExchangeServer
        // GraphQL -> exchangeServer: ExchangeServer! (type)
        public static string ExchangeServer(
            ref ExchangeServer? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeServer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeServerConnection? ExchangeServers
        // GraphQL -> exchangeServers: ExchangeServerConnection! (type)
        public static string ExchangeServers(
            ref ExchangeServerConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ExchangeServerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Failover? Failover
        // GraphQL -> failover: Failover (type)
        public static string Failover(
            ref Failover? cmdletReply
        )
        {
            string args = "\n(\nfailoverId: $failoverId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Failover() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failover" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverSourceConnection? FailoverAllSourceConnection
        // GraphQL -> failoverAllSourceConnection: FailoverSourceConnection! (type)
        public static string FailoverAllSourceConnection(
            ref FailoverSourceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverSourceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverAllSourceConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverTargetSiteConnection? FailoverAllTargetSiteConnection
        // GraphQL -> failoverAllTargetSiteConnection: FailoverTargetSiteConnection! (type)
        public static string FailoverAllTargetSiteConnection(
            ref FailoverTargetSiteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverTargetSiteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverAllTargetSiteConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterApp? FailoverClusterApp
        // GraphQL -> failoverClusterApp: FailoverClusterApp! (type)
        public static string FailoverClusterApp(
            ref FailoverClusterApp? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverClusterApp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterApp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterAppConnection? FailoverClusterApps
        // GraphQL -> failoverClusterApps: FailoverClusterAppConnection! (type)
        public static string FailoverClusterApps(
            ref FailoverClusterAppConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverClusterAppConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterApps" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterTopLevelDescendantTypeConnection? FailoverClusterTopLevelDescendants
        // GraphQL -> failoverClusterTopLevelDescendants: FailoverClusterTopLevelDescendantTypeConnection! (type)
        public static string FailoverClusterTopLevelDescendants(
            ref FailoverClusterTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverClusterTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        public static string FailoverConnection(
            ref FailoverConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverGroupByConnection? FailoverGroupByConnection
        // GraphQL -> failoverGroupByConnection: FailoverGroupByConnection! (type)
        public static string FailoverGroupByConnection(
            ref FailoverGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverJobReportConnection? FailoverJobReports
        // GraphQL -> failoverJobReports: FailoverJobReportConnection! (type)
        public static string FailoverJobReports(
            ref FailoverJobReportConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfailoverType: $failoverType\nstartTimeMs: $startTimeMs\nendTimeMs: $endTimeMs\nrecoveryNames: $recoveryNames\nplanNames: $planNames\nworkloadIDs: $workloadIDs\nRecoveryStatus: $RecoveryStatus\nSortParams: $SortParams\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverJobReportConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverJobReports" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverReport? FailoverReport
        // GraphQL -> failoverReport: FailoverReport (type)
        public static string FailoverReport(
            ref FailoverReport? cmdletReply
        )
        {
            string args = "\n(\nfailoverReportId: $failoverReportId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FailoverReport() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureFlag? FeatureFlag
        // GraphQL -> featureFlag: FeatureFlag! (type)
        public static string FeatureFlag(
            ref FeatureFlag? cmdletReply
        )
        {
            string args = "\n(\nflagName: $flagName\nentityType: $entityType\nentityContext: $entityContext\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FeatureFlag() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "featureFlag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureFlagAll? FeatureFlagAll
        // GraphQL -> featureFlagAll: FeatureFlagAll! (type)
        public static string FeatureFlagAll(
            ref FeatureFlagAll? cmdletReply
        )
        {
            string args = "\n(\nentityType: $entityType\nentityContext: $entityContext\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FeatureFlagAll() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "featureFlagAll" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FederatedLoginStatus? FederatedLoginStatus
        // GraphQL -> federatedLoginStatus: FederatedLoginStatus! (type)
        public static string FederatedLoginStatus(
            ref FederatedLoginStatus? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new FederatedLoginStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "federatedLoginStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FakeDataConnection? FetchFakeData
        // GraphQL -> fetchFakeData: FakeDataConnection! (type)
        public static string FetchFakeData(
            ref FakeDataConnection? cmdletReply
        )
        {
            string args = "\n(\nresponsePeriodMs: $responsePeriodMs\nshouldBlock: $shouldBlock\npreProcessingBufferBytes: $preProcessingBufferBytes\nresponseSizeBytes: $responseSizeBytes\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FakeDataConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "fetchFakeData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetSnapshotDetail? FilesetSnapshot
        // GraphQL -> filesetSnapshot: FilesetSnapshotDetail! (type)
        public static string FilesetSnapshot(
            ref FilesetSnapshotDetail? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nverbose: $verbose\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FilesetSnapshotDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? FilesetSnapshotFiles
        // GraphQL -> filesetSnapshotFiles: BrowseResponseListResponse! (type)
        public static string FilesetSnapshotFiles(
            ref BrowseResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nlimit: $limit\noffset: $offset\npath: $path\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BrowseResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetTemplate? FilesetTemplate
        // GraphQL -> filesetTemplate: FilesetTemplate! (type)
        public static string FilesetTemplate(
            ref FilesetTemplate? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FilesetTemplate() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetTemplate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetTemplateConnection? FilesetTemplates
        // GraphQL -> filesetTemplates: FilesetTemplateConnection! (type)
        public static string FilesetTemplates(
            ref FilesetTemplateConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FilesetTemplateConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetTemplates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeDisk? GcpNativeDisk
        // GraphQL -> gcpNativeDisk: GcpNativeDisk! (type)
        public static string GcpNativeDisk(
            ref GcpNativeDisk? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeDisk() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeDisk" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeDiskConnection? GcpNativeDisks
        // GraphQL -> gcpNativeDisks: GcpNativeDiskConnection! (type)
        public static string GcpNativeDisks(
            ref GcpNativeDiskConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeDiskConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeDisks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeGceInstance? GcpNativeGceInstance
        // GraphQL -> gcpNativeGceInstance: GcpNativeGceInstance! (type)
        public static string GcpNativeGceInstance(
            ref GcpNativeGceInstance? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeGceInstance() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeGceInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstances
        // GraphQL -> gcpNativeGceInstances: GcpNativeGceInstanceConnection! (type)
        public static string GcpNativeGceInstances(
            ref GcpNativeGceInstanceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ngceInstanceFilters: $gceInstanceFilters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeGceInstanceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeGceInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        public static string GcpNativeProject(
            ref GcpNativeProject? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeProject() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeProject" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeProjectConnection? GcpNativeProjects
        // GraphQL -> gcpNativeProjects: GcpNativeProjectConnection! (type)
        public static string GcpNativeProjects(
            ref GcpNativeProjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nprojectFilters: $projectFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GcpNativeProjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListStoredDiskLocationsReply? GcpNativeStoredDiskLocations
        // GraphQL -> gcpNativeStoredDiskLocations: ListStoredDiskLocationsReply! (type)
        public static string GcpNativeStoredDiskLocations(
            ref ListStoredDiskLocationsReply? cmdletReply
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListStoredDiskLocationsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeStoredDiskLocations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GeoLocationList
        // GraphQL -> geoLocationList: [GroupCount!]! (type)
        public static string GeoLocationList(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "geoLocationList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AspValue? GetAccountSettingValue
        // GraphQL -> getAccountSettingValue: ASPValue! (type)
        public static string GetAccountSettingValue(
            ref AspValue? cmdletReply
        )
        {
            string args = "\n(\naspName: $aspName\naspComponent: $aspComponent\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AspValue() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getAccountSettingValue" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RoleConnection? GetAllRolesInOrgConnection
        // GraphQL -> getAllRolesInOrgConnection: RoleConnection! (type)
        public static string GetAllRolesInOrgConnection(
            ref RoleConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RoleConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getAllRolesInOrgConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForClusterFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForClusterFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForClusterFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsForClusterFromSupportPortal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForVersionFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForVersionFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForVersionFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? cmdletReply
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsForVersionFromSupportPortal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? cmdletReply
        )
        {
            string args = "\n(\nplatform: $platform\nnodeCount: $nodeCount\nsourceVersion: $sourceVersion\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsFromSupportPortal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupCountListWithTotal? GetGroupCountByCdmClusterStatus
        // GraphQL -> getGroupCountByCdmClusterStatus: GroupCountListWithTotal! (type)
        public static string GetGroupCountByCdmClusterStatus(
            ref GroupCountListWithTotal? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GroupCountListWithTotal() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByCdmClusterStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByPrechecksStatus
        // GraphQL -> getGroupCountByPrechecksStatus: [GroupCount!]! (type)
        public static string GetGroupCountByPrechecksStatus(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByPrechecksStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByUpgradeJobStatus
        // GraphQL -> getGroupCountByUpgradeJobStatus: [GroupCount!]! (type)
        public static string GetGroupCountByUpgradeJobStatus(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByUpgradeJobStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByVersionStatus
        // GraphQL -> getGroupCountByVersionStatus: [GroupCount!]! (type)
        public static string GetGroupCountByVersionStatus(
            ref List<GroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<GroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByVersionStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetTaskchainStatusReply? GetKorgTaskchainStatus
        // GraphQL -> getKorgTaskchainStatus: GetTaskchainStatusReply! (type)
        public static string GetKorgTaskchainStatus(
            ref GetTaskchainStatusReply? cmdletReply
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetTaskchainStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getKorgTaskchainStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Permission>? GetPermissions
        // GraphQL -> getPermissions: [Permission!]! (type)
        public static string GetPermissions(
            ref List<Permission>? cmdletReply
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Permission>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getPermissions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Role>? GetRolesByIds
        // GraphQL -> getRolesByIds: [Role!]! (type)
        public static string GetRolesByIds(
            ref List<Role>? cmdletReply
        )
        {
            string args = "\n(\nroleIds: $roleIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Role>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getRolesByIds" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UserDownload>? GetUserDownloads
        // GraphQL -> getUserDownloads: [UserDownload!]! (type)
        public static string GetUserDownloads(
            ref List<UserDownload>? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<UserDownload>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getUserDownloads" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalCertificate? GlobalCertificate
        // GraphQL -> globalCertificate: GlobalCertificate! (type)
        public static string GlobalCertificate(
            ref GlobalCertificate? cmdletReply
        )
        {
            string args = "\n(\ncertificateId: $certificateId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalCertificate() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalCertificateConnection? GlobalCertificates
        // GraphQL -> globalCertificates: GlobalCertificateConnection! (type)
        public static string GlobalCertificates(
            ref GlobalCertificateConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalCertificateConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalCertificates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalFileSearchReply? GlobalFileSearch
        // GraphQL -> globalFileSearch: GlobalFileSearchReply! (type)
        public static string GlobalFileSearch(
            ref GlobalFileSearchReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalFileSearchReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalFileSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LockoutConfig? GlobalLockoutConfig
        // GraphQL -> globalLockoutConfig: LockoutConfig! (type)
        public static string GlobalLockoutConfig(
            ref LockoutConfig? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new LockoutConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalLockoutConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMfaSettingReply? GlobalMfaSetting
        // GraphQL -> globalMfaSetting: GetMfaSettingReply! (type)
        public static string GlobalMfaSetting(
            ref GetMfaSettingReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetMfaSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalMfaSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchyObjectConnection? GlobalSearchResults
        // GraphQL -> globalSearchResults: HierarchyObjectConnection! (type)
        public static string GlobalSearchResults(
            ref HierarchyObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HierarchyObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSearchResults" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaForFilterConnection? GlobalSlaFilterConnection
        // GraphQL -> globalSlaFilterConnection: GlobalSlaForFilterConnection! (type)
        public static string GlobalSlaFilterConnection(
            ref GlobalSlaForFilterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GlobalSlaForFilterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSlaFilterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisSlaStatusConnection? GlobalSlaStatuses
        // GraphQL -> globalSlaStatuses: PolarisSlaStatusConnection! (type)
        public static string GlobalSlaStatuses(
            ref PolarisSlaStatusConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nSlaId: $SlaId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisSlaStatusConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSlaStatuses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupedReleaseNoteConnection? GroupedReleasesNotes
        // GraphQL -> groupedReleasesNotes: GroupedReleaseNoteConnection! (type)
        public static string GroupedReleasesNotes(
            ref GroupedReleaseNoteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GroupedReleaseNoteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "groupedReleasesNotes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupConnection? GroupsInCurrentAndDescendantOrganization
        // GraphQL -> groupsInCurrentAndDescendantOrganization: GroupConnection! (type)
        public static string GroupsInCurrentAndDescendantOrganization(
            ref GroupConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nshouldIncludeGroupsWithoutRole: $shouldIncludeGroupsWithoutRole\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "groupsInCurrentAndDescendantOrganization" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GuestCredentialDetailListResponse? GuestCredentials
        // GraphQL -> guestCredentials: GuestCredentialDetailListResponse! (type)
        public static string GuestCredentials(
            ref GuestCredentialDetailListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GuestCredentialDetailListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "guestCredentials" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HelpContentSnippetConnection? HelpContentSnippets
        // GraphQL -> helpContentSnippets: HelpContentSnippetConnection! (type)
        public static string HelpContentSnippets(
            ref HelpContentSnippetConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HelpContentSnippetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "helpContentSnippets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchySnappableConnection? HierarchySnappables
        // GraphQL -> hierarchySnappables: HierarchySnappableConnection! (type)
        public static string HierarchySnappables(
            ref HierarchySnappableConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HierarchySnappableConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hierarchySnappables" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostDiagnosisSummary? HostDiagnosis
        // GraphQL -> hostDiagnosis: HostDiagnosisSummary! (type)
        public static string HostDiagnosis(
            ref HostDiagnosisSummary? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HostDiagnosisSummary() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostDiagnosis" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostFailoverCluster? HostFailoverCluster
        // GraphQL -> hostFailoverCluster: HostFailoverCluster! (type)
        public static string HostFailoverCluster(
            ref HostFailoverCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HostFailoverCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostFailoverCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostFailoverClusterConnection? HostFailoverClusters
        // GraphQL -> hostFailoverClusters: HostFailoverClusterConnection! (type)
        public static string HostFailoverClusters(
            ref HostFailoverClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HostFailoverClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostFailoverClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostShare? HostShare
        // GraphQL -> hostShare: HostShare! (type)
        public static string HostShare(
            ref HostShare? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HostShare() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostShare" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostShareConnection? HostShares
        // GraphQL -> hostShares: HostShareConnection! (type)
        public static string HostShares(
            ref HostShareConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HostShareConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostShares" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVcluster? HypervCluster
        // GraphQL -> hypervCluster: HyperVCluster! (type)
        public static string HypervCluster(
            ref HyperVcluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVcluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervHostAsyncRequestStatus
        // GraphQL -> hypervHostAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervHostAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervHostAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVliveMountConnection? HypervMounts
        // GraphQL -> hypervMounts: HyperVLiveMountConnection! (type)
        public static string HypervMounts(
            ref HyperVliveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVliveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVscvmm? HypervScvmm
        // GraphQL -> hypervScvmm: HyperVSCVMM! (type)
        public static string HypervScvmm(
            ref HyperVscvmm? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVscvmm() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervScvmmAsyncRequestStatus
        // GraphQL -> hypervScvmmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervScvmmAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmmAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVscvmmConnection? HypervScvmms
        // GraphQL -> hypervScvmms: HyperVSCVMMConnection! (type)
        public static string HypervScvmms(
            ref HyperVscvmmConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVscvmmConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmms" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervServer? HypervServer
        // GraphQL -> hypervServer: HypervServer! (type)
        public static string HypervServer(
            ref HypervServer? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HypervServer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervHostSummaryListResponse? HypervServers
        // GraphQL -> hypervServers: HypervHostSummaryListResponse! (type)
        public static string HypervServers(
            ref HypervHostSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HypervHostSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervTopLevelDescendantTypeConnection? HypervTopLevelDescendants
        // GraphQL -> hypervTopLevelDescendants: HypervTopLevelDescendantTypeConnection! (type)
        public static string HypervTopLevelDescendants(
            ref HypervTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HypervTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVvirtualMachine? HypervVirtualMachine
        // GraphQL -> hypervVirtualMachine: HyperVVirtualMachine! (type)
        public static string HypervVirtualMachine(
            ref HyperVvirtualMachine? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVvirtualMachine() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachine" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervVirtualMachineAsyncRequestStatus
        // GraphQL -> hypervVirtualMachineAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervVirtualMachineAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachineAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVvirtualMachineConnection? HypervVirtualMachines
        // GraphQL -> hypervVirtualMachines: HyperVVirtualMachineConnection! (type)
        public static string HypervVirtualMachines(
            ref HyperVvirtualMachineConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HyperVvirtualMachineConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachines" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervVirtualMachineDetail? HypervVmDetail
        // GraphQL -> hypervVmDetail: HypervVirtualMachineDetail! (type)
        public static string HypervVmDetail(
            ref HypervVirtualMachineDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HypervVirtualMachineDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVmDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<InstalledVersionGroupCount>? InstalledVersionList
        // GraphQL -> installedVersionList: [InstalledVersionGroupCount!]! (type)
        public static string InstalledVersionList(
            ref List<InstalledVersionGroupCount>? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new List<InstalledVersionGroupCount>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "installedVersionList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InventoryRoot? InventoryRoot
        // GraphQL -> inventoryRoot: InventoryRoot! (type)
        public static string InventoryRoot(
            ref InventoryRoot? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new InventoryRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "inventoryRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InventorySubHierarchyRoot? InventorySubHierarchyRoot
        // GraphQL -> inventorySubHierarchyRoot: InventorySubHierarchyRoot! (type)
        public static string InventorySubHierarchyRoot(
            ref InventorySubHierarchyRoot? cmdletReply
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InventorySubHierarchyRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "inventorySubHierarchyRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InvestigationCsvDownloadLinkReply? InvestigationCsvDownloadLink
        // GraphQL -> investigationCsvDownloadLink: InvestigationCsvDownloadLinkReply! (type)
        public static string InvestigationCsvDownloadLink(
            ref InvestigationCsvDownloadLinkReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InvestigationCsvDownloadLinkReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "investigationCsvDownloadLink" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetWhitelistReply? IpWhitelist
        // GraphQL -> ipWhitelist: GetWhitelistReply! (type)
        public static string IpWhitelist(
            ref GetWhitelistReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetWhitelistReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ipWhitelist" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsVolumeSnapshotRestorableReply? IsAwsNativeEbsVolumeSnapshotRestorable
        // GraphQL -> isAwsNativeEbsVolumeSnapshotRestorable: IsVolumeSnapshotRestorableReply! (type)
        public static string IsAwsNativeEbsVolumeSnapshotRestorable(
            ref IsVolumeSnapshotRestorableReply? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new IsVolumeSnapshotRestorableReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isAwsNativeEbsVolumeSnapshotRestorable" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateCloudNativeFileRecoveryFeasibilityReply? IsCloudNativeFileRecoveryFeasible
        // GraphQL -> isCloudNativeFileRecoveryFeasible: ValidateCloudNativeFileRecoveryFeasibilityReply! (type)
        public static string IsCloudNativeFileRecoveryFeasible(
            ref ValidateCloudNativeFileRecoveryFeasibilityReply? cmdletReply
        )
        {
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateCloudNativeFileRecoveryFeasibilityReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isCloudNativeFileRecoveryFeasible" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalStatusReply? IsLoggedIntoRubrikSupportPortal
        // GraphQL -> isLoggedIntoRubrikSupportPortal: SupportPortalStatusReply! (type)
        public static string IsLoggedIntoRubrikSupportPortal(
            ref SupportPortalStatusReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isLoggedIntoRubrikSupportPortal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeAvailabilityReply? IsUpgradeAvailable
        // GraphQL -> isUpgradeAvailable: CdmUpgradeAvailabilityReply! (type)
        public static string IsUpgradeAvailable(
            ref CdmUpgradeAvailabilityReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmUpgradeAvailabilityReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isUpgradeAvailable" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeRecommendationReply? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: CdmUpgradeRecommendationReply! (type)
        public static string IsUpgradeRecommended(
            ref CdmUpgradeRecommendationReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmUpgradeRecommendationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isUpgradeRecommended" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ZrsAvailabilityReply? IsZrsAvailableForLocation
        // GraphQL -> isZrsAvailableForLocation: ZrsAvailabilityReply! (type)
        public static string IsZrsAvailableForLocation(
            ref ZrsAvailabilityReply? cmdletReply
        )
        {
            string args = "\n(\nserviceTier: $serviceTier\nregion: $region\nsubscriptionId: $subscriptionId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ZrsAvailabilityReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isZrsAvailableForLocation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Issue? Issue
        // GraphQL -> issue: Issue! (type)
        public static string Issue(
            ref Issue? cmdletReply
        )
        {
            string args = "\n(\nissueId: $issueId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Issue() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "issue" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IssueConnection? Issues
        // GraphQL -> issues: IssueConnection! (type)
        public static string Issues(
            ref IssueConnection? cmdletReply
        )
        {
            string args = "\n(\nstatus: $status\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new IssueConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "issues" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraIssueConnection? JiraIssues
        // GraphQL -> jiraIssues: JiraIssueConnection! (type)
        public static string JiraIssues(
            ref JiraIssueConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\njiraProjectId: $jiraProjectId\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new JiraIssueConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraIssues" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraProjectConnection? JiraProjects
        // GraphQL -> jiraProjects: JiraProjectConnection! (type)
        public static string JiraProjects(
            ref JiraProjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsiteId: $siteId\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new JiraProjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraProjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraSettingsConnection? JiraSettings
        // GraphQL -> jiraSettings: JiraSettingsConnection! (type)
        public static string JiraSettings(
            ref JiraSettingsConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\njiraSettingsId: $jiraSettingsId\njiraSettingsType: $jiraSettingsType\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new JiraSettingsConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sAppManifest? K8sAppManifest
        // GraphQL -> k8sAppManifest: K8sAppManifest! (type)
        public static string K8sAppManifest(
            ref K8sAppManifest? cmdletReply
        )
        {
            string args = "\n(\napp: $app\nversion: $version\nretrieveLatestVersion: $retrieveLatestVersion\ntargetVersion: $targetVersion\nk8sClusterId: $k8sClusterId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sAppManifest() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sAppManifest" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sCluster? K8sCluster
        // GraphQL -> k8sCluster: K8sCluster! (type)
        public static string K8sCluster(
            ref K8sCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sClusterConnection? K8sClusters
        // GraphQL -> k8sClusters: K8sClusterConnection! (type)
        public static string K8sClusters(
            ref K8sClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sNamespace? K8sNamespace
        // GraphQL -> k8sNamespace: K8sNamespace! (type)
        public static string K8sNamespace(
            ref K8sNamespace? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sNamespace() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sNamespace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sNamespaceConnection? K8sNamespaces
        // GraphQL -> k8sNamespaces: K8sNamespaceConnection! (type)
        public static string K8sNamespaces(
            ref K8sNamespaceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nk8sClusterId: $k8sClusterId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sNamespaceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sNamespaces" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sSnapshotInfo? K8sSnapshotInfo
        // GraphQL -> k8sSnapshotInfo: K8sSnapshotInfo! (type)
        public static string K8sSnapshotInfo(
            ref K8sSnapshotInfo? cmdletReply
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nnamespaceId: $namespaceId\nisReplica: $isReplica\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new K8sSnapshotInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sSnapshotInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KmipServerConnection? KmipServerConnection
        // GraphQL -> kmipServerConnection: KmipServerConnection! (type)
        public static string KmipServerConnection(
            ref KmipServerConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nserverAddressArg: $serverAddressArg\nkmipServerClustersArg: $kmipServerClustersArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new KmipServerConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kmipServerConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KnowledgeBaseArticle? KnowledgeBaseArticle
        // GraphQL -> knowledgeBaseArticle: KnowledgeBaseArticle! (type)
        public static string KnowledgeBaseArticle(
            ref KnowledgeBaseArticle? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new KnowledgeBaseArticle() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "knowledgeBaseArticle" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LambdaSettings? LambdaSettings
        // GraphQL -> lambdaSettings: LambdaSettings! (type)
        public static string LambdaSettings(
            ref LambdaSettings? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new LambdaSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lambdaSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AuthorizedPrincipalConnection? LdapAuthorizedPrincipalConnection
        // GraphQL -> ldapAuthorizedPrincipalConnection: AuthorizedPrincipalConnection! (type)
        public static string LdapAuthorizedPrincipalConnection(
            ref AuthorizedPrincipalConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AuthorizedPrincipalConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapAuthorizedPrincipalConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LdapIntegrationConnection? LdapIntegrationConnection
        // GraphQL -> ldapIntegrationConnection: LdapIntegrationConnection! (type)
        public static string LdapIntegrationConnection(
            ref LdapIntegrationConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LdapIntegrationConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapIntegrationConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalConnection? LdapPrincipalConnection
        // GraphQL -> ldapPrincipalConnection: PrincipalConnection! (type)
        public static string LdapPrincipalConnection(
            ref PrincipalConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nid: $id\nsearchText: $searchText\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrincipalConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapPrincipalConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LegalHoldSnapshotDetailConnection? LegalHoldSnapshotsForSnappable
        // GraphQL -> legalHoldSnapshotsForSnappable: LegalHoldSnapshotDetailConnection! (type)
        public static string LegalHoldSnapshotsForSnappable(
            ref LegalHoldSnapshotDetailConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LegalHoldSnapshotDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "legalHoldSnapshotsForSnappable" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LicensesForClusterProductReply? LicensesForClusterProductSummary
        // GraphQL -> licensesForClusterProductSummary: LicensesForClusterProductReply! (type)
        public static string LicensesForClusterProductSummary(
            ref LicensesForClusterProductReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LicensesForClusterProductReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "licensesForClusterProductSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LinuxFileset? LinuxFileset
        // GraphQL -> linuxFileset: LinuxFileset! (type)
        public static string LinuxFileset(
            ref LinuxFileset? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LinuxFileset() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "linuxFileset" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365AppConnection? ListO365Apps
        // GraphQL -> listO365Apps: O365AppConnection! (type)
        public static string ListO365Apps(
            ref O365AppConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\no365AppFilters: $o365AppFilters\no365AppSortByParam: $o365AppSortByParam\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365AppConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "listO365Apps" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LockoutConfig? LockoutConfig
        // GraphQL -> lockoutConfig: LockoutConfig! (type)
        public static string LockoutConfig(
            ref LockoutConfig? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new LockoutConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lockoutConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LookupAccountReply? LookupAccount
        // GraphQL -> lookupAccount: LookupAccountReply! (type)
        public static string LookupAccount(
            ref LookupAccountReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LookupAccountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lookupAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> M365RegionsResp? M365Regions
        // GraphQL -> m365Regions: M365RegionsResp! (type)
        public static string M365Regions(
            ref M365RegionsResp? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new M365RegionsResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "m365Regions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MalwareScanResults? MalwareDetectionTaskResult
        // GraphQL -> malwareDetectionTaskResult: MalwareScanResults! (type)
        public static string MalwareDetectionTaskResult(
            ref MalwareScanResults? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MalwareScanResults() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareDetectionTaskResult" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MalwareDetectionTaskStatus
        // GraphQL -> malwareDetectionTaskStatus: AsyncRequestStatus! (type)
        public static string MalwareDetectionTaskStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareDetectionTaskStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetLambdaMalwareScanDetailReply? MalwareScanDetail
        // GraphQL -> malwareScanDetail: GetLambdaMalwareScanDetailReply! (type)
        public static string MalwareScanDetail(
            ref GetLambdaMalwareScanDetailReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetLambdaMalwareScanDetailReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareScanDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MalwareScanDetailListResponse? MalwareScans
        // GraphQL -> malwareScans: MalwareScanDetailListResponse! (type)
        public static string MalwareScans(
            ref MalwareScanDetailListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MalwareScanDetailListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareScans" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolume? ManagedVolume
        // GraphQL -> managedVolume: ManagedVolume! (type)
        public static string ManagedVolume(
            ref ManagedVolume? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolume() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeInventoryStats? ManagedVolumeInventoryStats
        // GraphQL -> managedVolumeInventoryStats: ManagedVolumeInventoryStats! (type)
        public static string ManagedVolumeInventoryStats(
            ref ManagedVolumeInventoryStats? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolumeInventoryStats() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumeInventoryStats" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeMountConnection? ManagedVolumeLiveMounts
        // GraphQL -> managedVolumeLiveMounts: ManagedVolumeMountConnection! (type)
        public static string ManagedVolumeLiveMounts(
            ref ManagedVolumeMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolumeMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumeLiveMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeConnection? ManagedVolumes
        // GraphQL -> managedVolumes: ManagedVolumeConnection! (type)
        public static string ManagedVolumes(
            ref ManagedVolumeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolumeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MandatoryTotpGracePeriod? MandatoryTotpGracePeriod
        // GraphQL -> mandatoryTotpGracePeriod: mandatoryTotpGracePeriod! (type)
        public static string MandatoryTotpGracePeriod(
            ref MandatoryTotpGracePeriod? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new MandatoryTotpGracePeriod() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mandatoryTotpGracePeriod" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMfaSettingReply? MfaSetting
        // GraphQL -> mfaSetting: GetMfaSettingReply! (type)
        public static string MfaSetting(
            ref GetMfaSettingReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetMfaSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mfaSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureListMinimumCdmVersionReply? MinimumCdmVersionForFeatureSet
        // GraphQL -> minimumCdmVersionForFeatureSet: FeatureListMinimumCdmVersionReply! (type)
        public static string MinimumCdmVersionForFeatureSet(
            ref FeatureListMinimumCdmVersionReply? cmdletReply
        )
        {
            string args = "\n(\nfeatureListMinimumCdmVersion: $featureListMinimumCdmVersion\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FeatureListMinimumCdmVersionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "minimumCdmVersionForFeatureSet" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoCollection? MongoCollection
        // GraphQL -> mongoCollection: MongoCollection! (type)
        public static string MongoCollection(
            ref MongoCollection? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoCollection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoCollection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoCollectionConnection? MongoCollections
        // GraphQL -> mongoCollections: MongoCollectionConnection! (type)
        public static string MongoCollections(
            ref MongoCollectionConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoCollectionConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoCollections" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoDatabase? MongoDatabase
        // GraphQL -> mongoDatabase: MongoDatabase! (type)
        public static string MongoDatabase(
            ref MongoDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoDatabaseConnection? MongoDatabases
        // GraphQL -> mongoDatabases: MongoDatabaseConnection! (type)
        public static string MongoDatabases(
            ref MongoDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoRecoverableRanges? MongoRecoverableRanges
        // GraphQL -> mongoRecoverableRanges: MongoRecoverableRanges! (type)
        public static string MongoRecoverableRanges(
            ref MongoRecoverableRanges? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoRecoverableRanges() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoSource? MongoSource
        // GraphQL -> mongoSource: MongoSource! (type)
        public static string MongoSource(
            ref MongoSource? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoSource() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoSourceConnection? MongoSources
        // GraphQL -> mongoSources: MongoSourceConnection! (type)
        public static string MongoSources(
            ref MongoSourceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongoSourceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoSources" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicRecoveryRangeResponse? MongodbBulkRecoverableRange
        // GraphQL -> mongodbBulkRecoverableRange: MosaicRecoveryRangeResponse! (type)
        public static string MongodbBulkRecoverableRange(
            ref MosaicRecoveryRangeResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicRecoveryRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbBulkRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbCollection? MongodbCollection
        // GraphQL -> mongodbCollection: MongodbCollection! (type)
        public static string MongodbCollection(
            ref MongodbCollection? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbCollection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMosaicRecoverableRangeResponse? MongodbCollectionRecoverableRange
        // GraphQL -> mongodbCollectionRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string MongodbCollectionRecoverableRange(
            ref GetMosaicRecoverableRangeResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetMosaicRecoverableRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollectionRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbCollectionConnection? MongodbCollections
        // GraphQL -> mongodbCollections: MongodbCollectionConnection! (type)
        public static string MongodbCollections(
            ref MongodbCollectionConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbCollectionConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollections" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbDatabase? MongodbDatabase
        // GraphQL -> mongodbDatabase: MongodbDatabase! (type)
        public static string MongodbDatabase(
            ref MongodbDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbDatabaseConnection? MongodbDatabases
        // GraphQL -> mongodbDatabases: MongodbDatabaseConnection! (type)
        public static string MongodbDatabases(
            ref MongodbDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbSource? MongodbSource
        // GraphQL -> mongodbSource: MongodbSource! (type)
        public static string MongodbSource(
            ref MongodbSource? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbSource() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbSource" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbSourceConnection? MongodbSources
        // GraphQL -> mongodbSources: MongodbSourceConnection! (type)
        public static string MongodbSources(
            ref MongodbSourceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MongodbSourceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbSources" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicRecoveryRangeResponse? MosaicBulkRecoveryRange
        // GraphQL -> mosaicBulkRecoveryRange: MosaicRecoveryRangeResponse! (type)
        public static string MosaicBulkRecoveryRange(
            ref MosaicRecoveryRangeResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MosaicRecoveryRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicBulkRecoveryRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListVersionResponse? MosaicSnapshots
        // GraphQL -> mosaicSnapshots: ListVersionResponse! (type)
        public static string MosaicSnapshots(
            ref ListVersionResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListVersionResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListStoreResponse? MosaicStores
        // GraphQL -> mosaicStores: ListStoreResponse! (type)
        public static string MosaicStores(
            ref ListStoreResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListStoreResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicStores" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListVersionResponse? MosaicVersions
        // GraphQL -> mosaicVersions: ListVersionResponse! (type)
        public static string MosaicVersions(
            ref ListVersionResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListVersionResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicVersions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlAvailabilityGroup? MssqlAvailabilityGroup
        // GraphQL -> mssqlAvailabilityGroup: MssqlAvailabilityGroup! (type)
        public static string MssqlAvailabilityGroup(
            ref MssqlAvailabilityGroup? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlAvailabilityGroup() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlAvailabilityGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlInstanceSummaryListResponse? MssqlCompatibleInstances
        // GraphQL -> mssqlCompatibleInstances: MssqlInstanceSummaryListResponse! (type)
        public static string MssqlCompatibleInstances(
            ref MssqlInstanceSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlInstanceSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlCompatibleInstances" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabase? MssqlDatabase
        // GraphQL -> mssqlDatabase: MssqlDatabase! (type)
        public static string MssqlDatabase(
            ref MssqlDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabaseLiveMountConnection? MssqlDatabaseLiveMounts
        // GraphQL -> mssqlDatabaseLiveMounts: MssqlDatabaseLiveMountConnection! (type)
        public static string MssqlDatabaseLiveMounts(
            ref MssqlDatabaseLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlDatabaseLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseLiveMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlMissedRecoverableRangeListResponse? MssqlDatabaseMissedRecoverableRanges
        // GraphQL -> mssqlDatabaseMissedRecoverableRanges: MssqlMissedRecoverableRangeListResponse! (type)
        public static string MssqlDatabaseMissedRecoverableRanges(
            ref MssqlMissedRecoverableRangeListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlMissedRecoverableRangeListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseMissedRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? MssqlDatabaseMissedSnapshots
        // GraphQL -> mssqlDatabaseMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string MssqlDatabaseMissedSnapshots(
            ref MissedSnapshotListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MissedSnapshotListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseMissedSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlRestoreEstimateResult? MssqlDatabaseRestoreEstimate
        // GraphQL -> mssqlDatabaseRestoreEstimate: MssqlRestoreEstimateResult! (type)
        public static string MssqlDatabaseRestoreEstimate(
            ref MssqlRestoreEstimateResult? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlRestoreEstimateResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseRestoreEstimate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabaseConnection? MssqlDatabases
        // GraphQL -> mssqlDatabases: MssqlDatabaseConnection! (type)
        public static string MssqlDatabases(
            ref MssqlDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? MssqlDefaultProperties
        // GraphQL -> mssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string MssqlDefaultProperties(
            ref UpdateMssqlDefaultPropertiesReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpdateMssqlDefaultPropertiesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDefaultProperties" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlInstance? MssqlInstance
        // GraphQL -> mssqlInstance: MssqlInstance! (type)
        public static string MssqlInstance(
            ref MssqlInstance? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlInstance() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlInstance" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingSummaryV2ListResponse? MssqlLogShippingTargets
        // GraphQL -> mssqlLogShippingTargets: MssqlLogShippingSummaryV2ListResponse (type)
        public static string MssqlLogShippingTargets(
            ref MssqlLogShippingSummaryV2ListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlLogShippingSummaryV2ListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlLogShippingTargets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlRecoverableRangeListResponse? MssqlRecoverableRanges
        // GraphQL -> mssqlRecoverableRanges: MssqlRecoverableRangeListResponse! (type)
        public static string MssqlRecoverableRanges(
            ref MssqlRecoverableRangeListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlRecoverableRangeListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlTopLevelDescendantTypeConnection? MssqlTopLevelDescendants
        // GraphQL -> mssqlTopLevelDescendants: MssqlTopLevelDescendantTypeConnection! (type)
        public static string MssqlTopLevelDescendants(
            ref MssqlTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MssqlTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasFileset? NasFileset
        // GraphQL -> nasFileset: NasFileset! (type)
        public static string NasFileset(
            ref NasFileset? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasFileset() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasFileset" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasNamespace? NasNamespace
        // GraphQL -> nasNamespace: NasNamespace! (type)
        public static string NasNamespace(
            ref NasNamespace? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasNamespace() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasNamespace" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasNamespaceConnection? NasNamespaces
        // GraphQL -> nasNamespaces: NasNamespaceConnection! (type)
        public static string NasNamespaces(
            ref NasNamespaceConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasNamespaceConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasNamespaces" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasShare? NasShare
        // GraphQL -> nasShare: NasShare! (type)
        public static string NasShare(
            ref NasShare? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasShare() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasShare" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasSystem? NasSystem
        // GraphQL -> nasSystem: NasSystem! (type)
        public static string NasSystem(
            ref NasSystem? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasSystem() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasSystemConnection? NasSystems
        // GraphQL -> nasSystems: NasSystemConnection! (type)
        public static string NasSystems(
            ref NasSystemConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasSystemConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasSystems" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? NasTopLevelDescendants
        // GraphQL -> nasTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NasTopLevelDescendants(
            ref CdmHierarchyObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmHierarchyObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasVolume? NasVolume
        // GraphQL -> nasVolume: NasVolume! (type)
        public static string NasVolume(
            ref NasVolume? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NasVolume() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdBackEndCapacity? NcdBackEndCapacity
        // GraphQL -> ncdBackEndCapacity: NcdBackEndCapacity (type)
        public static string NcdBackEndCapacity(
            ref NcdBackEndCapacity? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NcdBackEndCapacity() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdBackEndCapacity" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdFrontEndCapacity? NcdFrontEndCapacity
        // GraphQL -> ncdFrontEndCapacity: NcdFrontEndCapacity (type)
        public static string NcdFrontEndCapacity(
            ref NcdFrontEndCapacity? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NcdFrontEndCapacity() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdFrontEndCapacity" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdObjectProtectionStatus? NcdObjectProtectionStatus
        // GraphQL -> ncdObjectProtectionStatus: NcdObjectProtectionStatus (type)
        public static string NcdObjectProtectionStatus(
            ref NcdObjectProtectionStatus? cmdletReply
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NcdObjectProtectionStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdObjectProtectionStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkThrottleSummaryListResponse? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottleSummaryListResponse! (type)
        public static string NetworkThrottle(
            ref NetworkThrottleSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NetworkThrottleSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "networkThrottle" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeKeyRotationConnection? NodeKeyRotation
        // GraphQL -> nodeKeyRotation: NodeKeyRotationConnection! (type)
        public static string NodeKeyRotation(
            ref NodeKeyRotationConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nclusterID: $clusterID\nnodeID: $nodeID\nrotationStates: $rotationStates\nnodeSortBy: $nodeSortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NodeKeyRotationConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nodeKeyRotation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeRemovalCancelPermissionReply? NodeRemovalCancelPermission
        // GraphQL -> nodeRemovalCancelPermission: NodeRemovalCancelPermissionReply! (type)
        public static string NodeRemovalCancelPermission(
            ref NodeRemovalCancelPermissionReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NodeRemovalCancelPermissionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nodeRemovalCancelPermission" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? NutanixBrowseSnapshot
        // GraphQL -> nutanixBrowseSnapshot: BrowseResponseListResponse! (type)
        public static string NutanixBrowseSnapshot(
            ref BrowseResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BrowseResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixBrowseSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCategoryConnection? NutanixCategories
        // GraphQL -> nutanixCategories: NutanixCategoryConnection! (type)
        public static string NutanixCategories(
            ref NutanixCategoryConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixCategoryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCategories" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVmConnection? NutanixCategoryValueVms
        // GraphQL -> nutanixCategoryValueVms: NutanixVmConnection! (type)
        public static string NutanixCategoryValueVms(
            ref NutanixVmConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixVmConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCategoryValueVms" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCategoryValueConnection? NutanixCategoryValues
        // GraphQL -> nutanixCategoryValues: NutanixCategoryValueConnection! (type)
        public static string NutanixCategoryValues(
            ref NutanixCategoryValueConnection? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixCategoryValueConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCategoryValues" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCluster? NutanixCluster
        // GraphQL -> nutanixCluster: NutanixCluster! (type)
        public static string NutanixCluster(
            ref NutanixCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? NutanixClusterAsyncRequestStatus
        // GraphQL -> nutanixClusterAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixClusterAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixContainerListResponse? NutanixClusterContainers
        // GraphQL -> nutanixClusterContainers: NutanixContainerListResponse! (type)
        public static string NutanixClusterContainers(
            ref NutanixContainerListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixContainerListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterContainers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixNetworkListResponse? NutanixClusterNetworks
        // GraphQL -> nutanixClusterNetworks: NutanixNetworkListResponse! (type)
        public static string NutanixClusterNetworks(
            ref NutanixNetworkListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixNetworkListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixClusterConnection? NutanixClusters
        // GraphQL -> nutanixClusters: NutanixClusterConnection! (type)
        public static string NutanixClusters(
            ref NutanixClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixLiveMountConnection? NutanixMounts
        // GraphQL -> nutanixMounts: NutanixLiveMountConnection! (type)
        public static string NutanixMounts(
            ref NutanixLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixPrismCentralConnection? NutanixPrismCentrals
        // GraphQL -> nutanixPrismCentrals: NutanixPrismCentralConnection! (type)
        public static string NutanixPrismCentrals(
            ref NutanixPrismCentralConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixPrismCentralConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixPrismCentrals" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVmSnapshotDetail? NutanixSnapshotDetail
        // GraphQL -> nutanixSnapshotDetail: NutanixVmSnapshotDetail! (type)
        public static string NutanixSnapshotDetail(
            ref NutanixVmSnapshotDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixVmSnapshotDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixSnapshotDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? NutanixTopLevelDescendants
        // GraphQL -> nutanixTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NutanixTopLevelDescendants(
            ref CdmHierarchyObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmHierarchyObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixTopLevelDescendantTypeConnection? NutanixTopLevelDescendantsV2
        // GraphQL -> nutanixTopLevelDescendantsV2: NutanixTopLevelDescendantTypeConnection! (type)
        public static string NutanixTopLevelDescendantsV2(
            ref NutanixTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixTopLevelDescendantsV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVm? NutanixVm
        // GraphQL -> nutanixVm: NutanixVm! (type)
        public static string NutanixVm(
            ref NutanixVm? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixVm() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? NutanixVmAsyncRequestStatus
        // GraphQL -> nutanixVmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixVmAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVmAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? NutanixVmMissedSnapshots
        // GraphQL -> nutanixVmMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string NutanixVmMissedSnapshots(
            ref MissedSnapshotListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MissedSnapshotListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVmMissedSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVmConnection? NutanixVms
        // GraphQL -> nutanixVms: NutanixVmConnection! (type)
        public static string NutanixVms(
            ref NutanixVmConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NutanixVmConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVms" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Calendar? O365Calendar
        // GraphQL -> o365Calendar: O365Calendar! (type)
        public static string O365Calendar(
            ref O365Calendar? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Calendar() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Calendar" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365GroupConnection? O365Groups
        // GraphQL -> o365Groups: O365GroupConnection! (type)
        public static string O365Groups(
            ref O365GroupConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nsnappableType: $snappableType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365GroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Groups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365License? O365License
        // GraphQL -> o365License: O365License! (type)
        public static string O365License(
            ref O365License? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new O365License() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365License" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Mailbox? O365Mailbox
        // GraphQL -> o365Mailbox: O365Mailbox! (type)
        public static string O365Mailbox(
            ref O365Mailbox? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Mailbox() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Mailbox" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365MailboxConnection? O365Mailboxes
        // GraphQL -> o365Mailboxes: O365MailboxConnection! (type)
        public static string O365Mailboxes(
            ref O365MailboxConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365MailboxConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Mailboxes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetImplicitlyAuthorizedAncestorSummariesResponse? O365ObjectAncestors
        // GraphQL -> o365ObjectAncestors: GetImplicitlyAuthorizedAncestorSummariesResponse! (type)
        public static string O365ObjectAncestors(
            ref GetImplicitlyAuthorizedAncestorSummariesResponse? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetImplicitlyAuthorizedAncestorSummariesResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ObjectAncestors" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Onedrive? O365Onedrive
        // GraphQL -> o365Onedrive: O365Onedrive! (type)
        public static string O365Onedrive(
            ref O365Onedrive? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Onedrive() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Onedrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveConnection? O365Onedrives
        // GraphQL -> o365Onedrives: O365OnedriveConnection! (type)
        public static string O365Onedrives(
            ref O365OnedriveConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Onedrives" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Org? O365Org
        // GraphQL -> o365Org: O365Org! (type)
        public static string O365Org(
            ref O365Org? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Org() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Org" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Org? O365OrgAtSnappableLevel
        // GraphQL -> o365OrgAtSnappableLevel: O365Org! (type)
        public static string O365OrgAtSnappableLevel(
            ref O365Org? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\nsnappableType: $snappableType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Org() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OrgAtSnappableLevel" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetImplicitlyAuthorizedObjectSummariesResponse? O365OrgSummaries
        // GraphQL -> o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse! (type)
        public static string O365OrgSummaries(
            ref GetImplicitlyAuthorizedObjectSummariesResponse? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetImplicitlyAuthorizedObjectSummariesResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OrgSummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OrgConnection? O365Orgs
        // GraphQL -> o365Orgs: O365OrgConnection! (type)
        public static string O365Orgs(
            ref O365OrgConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nworkloadHierarchy: $workloadHierarchy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OrgConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Orgs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ServiceAccountStatusResp? O365ServiceAccount
        // GraphQL -> o365ServiceAccount: O365ServiceAccountStatusResp! (type)
        public static string O365ServiceAccount(
            ref O365ServiceAccountStatusResp? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ServiceAccountStatusResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ServiceAccount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetO365ServiceStatusResp? O365ServiceStatus
        // GraphQL -> o365ServiceStatus: GetO365ServiceStatusResp! (type)
        public static string O365ServiceStatus(
            ref GetO365ServiceStatusResp? cmdletReply
        )
        {
            string args = "\n(\norgID: $orgID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetO365ServiceStatusResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ServiceStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointDrive? O365SharepointDrive
        // GraphQL -> o365SharepointDrive: O365SharepointDrive! (type)
        public static string O365SharepointDrive(
            ref O365SharepointDrive? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointDrive() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointDrive" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointDriveConnection? O365SharepointDrives
        // GraphQL -> o365SharepointDrives: O365SharepointDriveConnection! (type)
        public static string O365SharepointDrives(
            ref O365SharepointDriveConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointDriveConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointDrives" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointList? O365SharepointList
        // GraphQL -> o365SharepointList: O365SharepointList! (type)
        public static string O365SharepointList(
            ref O365SharepointList? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointList() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointListConnection? O365SharepointLists
        // GraphQL -> o365SharepointLists: O365SharepointListConnection! (type)
        public static string O365SharepointLists(
            ref O365SharepointListConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointListConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointLists" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjectList
        // GraphQL -> o365SharepointObjectList: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjectList(
            ref O365SharepointObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nincludeEntireHierarchy: $includeEntireHierarchy\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointObjectList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjects
        // GraphQL -> o365SharepointObjects: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjects(
            ref O365SharepointObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SharepointObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Site? O365SharepointSite
        // GraphQL -> o365SharepointSite: O365Site! (type)
        public static string O365SharepointSite(
            ref O365Site? cmdletReply
        )
        {
            string args = "\n(\nsiteFid: $siteFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Site() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointSite" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SiteConnection? O365SharepointSites
        // GraphQL -> o365SharepointSites: O365SiteConnection! (type)
        public static string O365SharepointSites(
            ref O365SiteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SiteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointSites" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Site? O365Site
        // GraphQL -> o365Site: O365Site! (type)
        public static string O365Site(
            ref O365Site? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Site() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Site" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SiteConnection? O365Sites
        // GraphQL -> o365Sites: O365SiteConnection! (type)
        public static string O365Sites(
            ref O365SiteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nexcludeChildSites: $excludeChildSites\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365SiteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Sites" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetO365StorageStatsResp? O365StorageStats
        // GraphQL -> o365StorageStats: GetO365StorageStatsResp! (type)
        public static string O365StorageStats(
            ref GetO365StorageStatsResp? cmdletReply
        )
        {
            string args = "\n(\norgID: $orgID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetO365StorageStatsResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365StorageStats" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Teams? O365Team
        // GraphQL -> o365Team: O365Teams! (type)
        public static string O365Team(
            ref O365Teams? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365Teams() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Team" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsChannelConnection? O365TeamChannels
        // GraphQL -> o365TeamChannels: O365TeamsChannelConnection! (type)
        public static string O365TeamChannels(
            ref O365TeamsChannelConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nexcludeArchived: $excludeArchived\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamsChannelConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365TeamChannels" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamConversationsSenderConnection? O365TeamPostedBy
        // GraphQL -> o365TeamPostedBy: O365TeamConversationsSenderConnection! (type)
        public static string O365TeamPostedBy(
            ref O365TeamConversationsSenderConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\no365OrgId: $o365OrgId\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamConversationsSenderConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365TeamPostedBy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsConnection? O365Teams
        // GraphQL -> o365Teams: O365TeamsConnection! (type)
        public static string O365Teams(
            ref O365TeamsConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamsConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Teams" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365User? O365User
        // GraphQL -> o365User: O365User! (type)
        public static string O365User(
            ref O365User? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365User() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365User" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365UserDescendantMetadataConnection? O365UserObjects
        // GraphQL -> o365UserObjects: O365UserDescendantMetadataConnection! (type)
        public static string O365UserObjects(
            ref O365UserDescendantMetadataConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365UserDescendantMetadataConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365UserObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OauthCodesForEdgeRegReply? OauthCodesForEdgeReg
        // GraphQL -> oauthCodesForEdgeReg: OauthCodesForEdgeRegReply! (type)
        public static string OauthCodesForEdgeReg(
            ref OauthCodesForEdgeRegReply? cmdletReply
        )
        {
            string args = "\n(\nnumberOfEdges: $numberOfEdges\ncdmOvaLink: $cdmOvaLink\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OauthCodesForEdgeRegReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oauthCodesForEdgeReg" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileResultConnection? ObjectFiles
        // GraphQL -> objectFiles: FileResultConnection! (type)
        public static string ObjectFiles(
            ref FileResultConnection? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\nsort: $sort\nday: $day\ntimezone: $timezone\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FileResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "objectFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleFileDownloadLink? OracleAcoExampleDownloadLink
        // GraphQL -> oracleAcoExampleDownloadLink: OracleFileDownloadLink! (type)
        public static string OracleAcoExampleDownloadLink(
            ref OracleFileDownloadLink? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleFileDownloadLink() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleAcoExampleDownloadLink" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleAcoParameterList? OracleAcoParameters
        // GraphQL -> oracleAcoParameters: OracleAcoParameterList! (type)
        public static string OracleAcoParameters(
            ref OracleAcoParameterList? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleAcoParameterList() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleAcoParameters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDataGuardGroup? OracleDataGuardGroup
        // GraphQL -> oracleDataGuardGroup: OracleDataGuardGroup! (type)
        public static string OracleDataGuardGroup(
            ref OracleDataGuardGroup? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleDataGuardGroup() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDataGuardGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDatabase? OracleDatabase
        // GraphQL -> oracleDatabase: OracleDatabase! (type)
        public static string OracleDatabase(
            ref OracleDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleDatabaseLogBackupConfig
        // GraphQL -> oracleDatabaseLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleDatabaseLogBackupConfig(
            ref OracleLogBackupConfig? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleLogBackupConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabaseLogBackupConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDatabaseConnection? OracleDatabases
        // GraphQL -> oracleDatabases: OracleDatabaseConnection! (type)
        public static string OracleDatabases(
            ref OracleDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleHost? OracleHost
        // GraphQL -> oracleHost: OracleHost! (type)
        public static string OracleHost(
            ref OracleHost? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleHost() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleHostLogBackupConfig
        // GraphQL -> oracleHostLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleHostLogBackupConfig(
            ref OracleLogBackupConfig? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleLogBackupConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleHostLogBackupConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLiveMountConnection? OracleLiveMounts
        // GraphQL -> oracleLiveMounts: OracleLiveMountConnection! (type)
        public static string OracleLiveMounts(
            ref OracleLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleLiveMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleMissedRecoverableRangeListResponse? OracleMissedRecoverableRanges
        // GraphQL -> oracleMissedRecoverableRanges: OracleMissedRecoverableRangeListResponse! (type)
        public static string OracleMissedRecoverableRanges(
            ref OracleMissedRecoverableRangeListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleMissedRecoverableRangeListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleMissedRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? OracleMissedSnapshots
        // GraphQL -> oracleMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string OracleMissedSnapshots(
            ref MissedSnapshotListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new MissedSnapshotListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleMissedSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OraclePdbDetails? OraclePdbDetails
        // GraphQL -> oraclePdbDetails: OraclePdbDetails! (type)
        public static string OraclePdbDetails(
            ref OraclePdbDetails? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OraclePdbDetails() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oraclePdbDetails" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleRac? OracleRac
        // GraphQL -> oracleRac: OracleRac! (type)
        public static string OracleRac(
            ref OracleRac? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleRac() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRac" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleRacLogBackupConfig
        // GraphQL -> oracleRacLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleRacLogBackupConfig(
            ref OracleLogBackupConfig? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleLogBackupConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRacLogBackupConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleRecoverableRangeListResponse? OracleRecoverableRanges
        // GraphQL -> oracleRecoverableRanges: OracleRecoverableRangeListResponse! (type)
        public static string OracleRecoverableRanges(
            ref OracleRecoverableRangeListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleRecoverableRangeListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleTopLevelDescendantTypeConnection? OracleTopLevelDescendants
        // GraphQL -> oracleTopLevelDescendants: OracleTopLevelDescendantTypeConnection! (type)
        public static string OracleTopLevelDescendants(
            ref OracleTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OracleTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        public static string Org(
            ref Org? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Org() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "org" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgNetwork? OrgNetwork
        // GraphQL -> orgNetwork: OrgNetwork! (type)
        public static string OrgNetwork(
            ref OrgNetwork? cmdletReply
        )
        {
            string args = "\n(\ntenantNetworkId: $tenantNetworkId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OrgNetwork() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgNetwork" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgNetworkConnection? OrgNetworks
        // GraphQL -> orgNetworks: OrgNetworkConnection! (type)
        public static string OrgNetworks(
            ref OrgNetworkConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OrgNetworkConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgSecurityPolicy? OrgSecurityPolicy
        // GraphQL -> orgSecurityPolicy: OrgSecurityPolicy! (type)
        public static string OrgSecurityPolicy(
            ref OrgSecurityPolicy? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new OrgSecurityPolicy() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgSecurityPolicy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgConnection? Orgs
        // GraphQL -> orgs: OrgConnection! (type)
        public static string Orgs(
            ref OrgConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\nmfaEnforcedFilter: $mfaEnforcedFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OrgConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgsForPrincipalReply? OrgsForPrincipal
        // GraphQL -> orgsForPrincipal: OrgsForPrincipalReply! (type)
        public static string OrgsForPrincipal(
            ref OrgsForPrincipalReply? cmdletReply
        )
        {
            string args = "\n(\norgSearchFilter: $orgSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OrgsForPrincipalReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgsForPrincipal" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OverallRansomwareInvestigationSummary? OverallRansomwareInvestigationSummary
        // GraphQL -> overallRansomwareInvestigationSummary: OverallRansomwareInvestigationSummary! (type)
        public static string OverallRansomwareInvestigationSummary(
            ref OverallRansomwareInvestigationSummary? cmdletReply
        )
        {
            string args = "\n(\nhistoryNumHours: $historyNumHours\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new OverallRansomwareInvestigationSummary() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "overallRansomwareInvestigationSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PactsafeContract? PactsafeContract
        // GraphQL -> pactsafeContract: PactsafeContract! (type)
        public static string PactsafeContract(
            ref PactsafeContract? cmdletReply
        )
        {
            string args = "\n(\ncontractType: $contractType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PactsafeContract() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pactsafeContract" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PactsafeEulaState? PactsafeEulaState
        // GraphQL -> pactsafeEulaState: PactsafeEulaState! (type)
        public static string PactsafeEulaState(
            ref PactsafeEulaState? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new PactsafeEulaState() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pactsafeEulaState" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PasswordComplexityPolicy? PasswordComplexityPolicy
        // GraphQL -> passwordComplexityPolicy: PasswordComplexityPolicy! (type)
        public static string PasswordComplexityPolicy(
            ref PasswordComplexityPolicy? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new PasswordComplexityPolicy() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "passwordComplexityPolicy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PendingAction? PendingAction
        // GraphQL -> pendingAction: pendingAction! (type)
        public static string PendingAction(
            ref PendingAction? cmdletReply
        )
        {
            string args = "\n(\npendingActionId: $pendingActionId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PendingAction() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pendingAction" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PendingEvaluationResultsReply? PendingRansomwareInvestigationResultsCount
        // GraphQL -> pendingRansomwareInvestigationResultsCount: PendingEvaluationResultsReply! (type)
        public static string PendingRansomwareInvestigationResultsCount(
            ref PendingEvaluationResultsReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new PendingEvaluationResultsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pendingRansomwareInvestigationResultsCount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhoenixRolloutProgress? PhoenixRolloutProgress
        // GraphQL -> phoenixRolloutProgress: PhoenixRolloutProgress! (type)
        public static string PhoenixRolloutProgress(
            ref PhoenixRolloutProgress? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PhoenixRolloutProgress() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "phoenixRolloutProgress" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhysicalHost? PhysicalHost
        // GraphQL -> physicalHost: PhysicalHost! (type)
        public static string PhysicalHost(
            ref PhysicalHost? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PhysicalHost() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "physicalHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhysicalHostConnection? PhysicalHosts
        // GraphQL -> physicalHosts: PhysicalHostConnection! (type)
        public static string PhysicalHosts(
            ref PhysicalHostConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PhysicalHostConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "physicalHosts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPipelineHealthReply? PipelineHealthForTimeRange
        // GraphQL -> pipelineHealthForTimeRange: GetPipelineHealthReply! (type)
        public static string PipelineHealthForTimeRange(
            ref GetPipelineHealthReply? cmdletReply
        )
        {
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetPipelineHealthReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pipelineHealthForTimeRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisInventorySubHierarchyRoot? PolarisInventorySubHierarchyRoot
        // GraphQL -> polarisInventorySubHierarchyRoot: PolarisInventorySubHierarchyRoot! (type)
        public static string PolarisInventorySubHierarchyRoot(
            ref PolarisInventorySubHierarchyRoot? cmdletReply
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisInventorySubHierarchyRoot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisInventorySubHierarchyRoot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportConfig? PolarisReportConfig
        // GraphQL -> polarisReportConfig: PolarisReportConfig! (type)
        public static string PolarisReportConfig(
            ref PolarisReportConfig? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisReportConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportSchema? PolarisReportSchema
        // GraphQL -> polarisReportSchema: PolarisReportSchema! (type)
        public static string PolarisReportSchema(
            ref PolarisReportSchema? cmdletReply
        )
        {
            string args = "\n(\npolarisReportViewType: $polarisReportViewType\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisReportSchema() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportSchema" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportTableIntrospection? PolarisReportTableIntrospection
        // GraphQL -> polarisReportTableIntrospection: PolarisReportTableIntrospection! (type)
        public static string PolarisReportTableIntrospection(
            ref PolarisReportTableIntrospection? cmdletReply
        )
        {
            string args = "\n(\ntableView: $tableView\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisReportTableIntrospection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportTableIntrospection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisSnapshot? PolarisSnapshot
        // GraphQL -> polarisSnapshot: PolarisSnapshot! (type)
        public static string PolarisSnapshot(
            ref PolarisSnapshot? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolarisSnapshot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetailConnection? Policies
        // GraphQL -> policies: ClassificationPolicyDetailConnection! (type)
        public static string Policies(
            ref ClassificationPolicyDetailConnection? cmdletReply
        )
        {
            string args = "\n(\npolicyObjectFilter: $policyObjectFilter\nexcludeHierarchyObjectList: $excludeHierarchyObjectList\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? Policy
        // GraphQL -> policy: ClassificationPolicyDetail! (type)
        public static string Policy(
            ref ClassificationPolicyDetail? cmdletReply
        )
        {
            string args = "\n(\npolicyId: $policyId\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nclusterIdsFilter: $clusterIdsFilter\nreplicationFilter: $replicationFilter\nsearchObjectName: $searchObjectName\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClassificationPolicyDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyDetailConnection? PolicyDetails
        // GraphQL -> policyDetails: PolicyDetailConnection! (type)
        public static string PolicyDetails(
            ref PolicyDetailConnection? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new PolicyDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyDetails" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObj? PolicyObj
        // GraphQL -> policyObj: PolicyObj! (type)
        public static string PolicyObj(
            ref PolicyObj? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolicyObj() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObj" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObj? PolicyObjOpt
        // GraphQL -> policyObjOpt: PolicyObj (type)
        public static string PolicyObjOpt(
            ref PolicyObj? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolicyObj() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjOpt" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObjectUsageConnection? PolicyObjectUsages
        // GraphQL -> policyObjectUsages: PolicyObjectUsageConnection! (type)
        public static string PolicyObjectUsages(
            ref PolicyObjectUsageConnection? cmdletReply
        )
        {
            string args = "\n(\nobjectIds: $objectIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolicyObjectUsageConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjectUsages" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObjConnection? PolicyObjs
        // GraphQL -> policyObjs: PolicyObjConnection! (type)
        public static string PolicyObjs(
            ref PolicyObjConnection? cmdletReply
        )
        {
            string args = "\n(\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nanalysisStatusesFilter: $analysisStatusesFilter\npolicyIdsFilter: $policyIdsFilter\nriskLevelsFilter: $riskLevelsFilter\nclusterIdsFilter: $clusterIdsFilter\nsearchObjectName: $searchObjectName\nsubscriptionIdsFilter: $subscriptionIdsFilter\nincludeWhitelistedResults: $includeWhitelistedResults\nsids: $sids\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PolicyObjConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrechecksStatusReply? PrechecksStatus
        // GraphQL -> prechecksStatus: PrechecksStatusReply! (type)
        public static string PrechecksStatus(
            ref PrechecksStatusReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrechecksStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prechecksStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrechecksStatusReply? PrechecksStatusWithNextJobInfo
        // GraphQL -> prechecksStatusWithNextJobInfo: PrechecksStatusReply! (type)
        public static string PrechecksStatusWithNextJobInfo(
            ref PrechecksStatusReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrechecksStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prechecksStatusWithNextJobInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalObjectSummaryConnection? PrincipalObjectSummaries
        // GraphQL -> principalObjectSummaries: PrincipalObjectSummaryConnection! (type)
        public static string PrincipalObjectSummaries(
            ref PrincipalObjectSummaryConnection? cmdletReply
        )
        {
            string args = "\n(\nsids: $sids\nfilter: $filter\ntimelineDate: $timelineDate\nincludeCount: $includeCount\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrincipalObjectSummaryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalObjectSummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskChangesReply? PrincipalRiskChanges
        // GraphQL -> principalRiskChanges: GetPrincipalRiskChangesReply! (type)
        public static string PrincipalRiskChanges(
            ref GetPrincipalRiskChangesReply? cmdletReply
        )
        {
            string args = "\n(\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nstartTime: $startTime\nendTime: $endTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetPrincipalRiskChangesReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalRiskChanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskTrendReply? PrincipalRiskTrend
        // GraphQL -> principalRiskTrend: GetPrincipalRiskTrendReply! (type)
        public static string PrincipalRiskTrend(
            ref GetPrincipalRiskTrendReply? cmdletReply
        )
        {
            string args = "\n(\nsid: $sid\nstartTime: $startTime\nendTime: $endTime\npolicyId: $policyId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetPrincipalRiskTrendReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalRiskTrend" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalSummaryConnection? PrincipalSummaries
        // GraphQL -> principalSummaries: PrincipalSummaryConnection! (type)
        public static string PrincipalSummaries(
            ref PrincipalSummaryConnection? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\ntimelineDate: $timelineDate\nsort: $sort\nincludeCount: $includeCount\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new PrincipalSummaryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalSummaries" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProcessedRansomwareInvestigationWorkloadCountReply? ProcessedRansomwareInvestigationWorkloadCount
        // GraphQL -> processedRansomwareInvestigationWorkloadCount: ProcessedRansomwareInvestigationWorkloadCountReply! (type)
        public static string ProcessedRansomwareInvestigationWorkloadCount(
            ref ProcessedRansomwareInvestigationWorkloadCountReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ProcessedRansomwareInvestigationWorkloadCountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "processedRansomwareInvestigationWorkloadCount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProductDocumentation? ProductDocumentation
        // GraphQL -> productDocumentation: ProductDocumentation! (type)
        public static string ProductDocumentation(
            ref ProductDocumentation? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ProductDocumentation() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "productDocumentation" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ProtectedClustersForGlobalSla
        // GraphQL -> protectedClustersForGlobalSla: ClusterConnection! (type)
        public static string ProtectedClustersForGlobalSla(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nslaId: $slaId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedClustersForGlobalSla" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProtectedObjectsConnection? ProtectedObjectsConnection
        // GraphQL -> protectedObjectsConnection: ProtectedObjectsConnection! (type)
        public static string ProtectedObjectsConnection(
            ref ProtectedObjectsConnection? cmdletReply
        )
        {
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ProtectedObjectsConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedObjectsConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProtectedRansomwareInvestigationWorkloadCountReply? ProtectedRansomwareInvestigationWorkloadCount
        // GraphQL -> protectedRansomwareInvestigationWorkloadCount: ProtectedRansomwareInvestigationWorkloadCountReply! (type)
        public static string ProtectedRansomwareInvestigationWorkloadCount(
            ref ProtectedRansomwareInvestigationWorkloadCountReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new ProtectedRansomwareInvestigationWorkloadCountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedRansomwareInvestigationWorkloadCount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> QueryDatastoreFreespaceThresholdsReply? QueryDatastoreFreespaceThresholds
        // GraphQL -> queryDatastoreFreespaceThresholds: QueryDatastoreFreespaceThresholdsReply! (type)
        public static string QueryDatastoreFreespaceThresholds(
            ref QueryDatastoreFreespaceThresholdsReply? cmdletReply
        )
        {
            string args = "\n(\nqueryDatastoreFreespaceThresholdsInput: $queryDatastoreFreespaceThresholdsInput\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new QueryDatastoreFreespaceThresholdsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "queryDatastoreFreespaceThresholds" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? RadarClusterConnection
        // GraphQL -> radarClusterConnection: ClusterConnection! (type)
        public static string RadarClusterConnection(
            ref ClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "radarClusterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListLocationsReply? RansomwareDetectionWorkloadLocations
        // GraphQL -> ransomwareDetectionWorkloadLocations: ListLocationsReply! (type)
        public static string RansomwareDetectionWorkloadLocations(
            ref ListLocationsReply? cmdletReply
        )
        {
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\nreturnOnlyForAnomalousEntities: $returnOnlyForAnomalousEntities\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ListLocationsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareDetectionWorkloadLocations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationAnalysisSummaryReply? RansomwareInvestigationAnalysisSummary
        // GraphQL -> ransomwareInvestigationAnalysisSummary: RansomwareInvestigationAnalysisSummaryReply! (type)
        public static string RansomwareInvestigationAnalysisSummary(
            ref RansomwareInvestigationAnalysisSummaryReply? cmdletReply
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nhideSuspiciousDataIfNonAnomalous: $hideSuspiciousDataIfNonAnomalous\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareInvestigationAnalysisSummaryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationAnalysisSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationEnablementReply? RansomwareInvestigationEnablement
        // GraphQL -> ransomwareInvestigationEnablement: RansomwareInvestigationEnablementReply! (type)
        public static string RansomwareInvestigationEnablement(
            ref RansomwareInvestigationEnablementReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareInvestigationEnablementReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationEnablement" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationWorkloadScannedCountReply? RansomwareInvestigationWorkloadScannedCount
        // GraphQL -> ransomwareInvestigationWorkloadScannedCount: RansomwareInvestigationWorkloadScannedCountReply! (type)
        public static string RansomwareInvestigationWorkloadScannedCount(
            ref RansomwareInvestigationWorkloadScannedCountReply? cmdletReply
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareInvestigationWorkloadScannedCountReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationWorkloadScannedCount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult! (type)
        public static string RansomwareResult(
            ref RansomwareResult? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResult" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResult? RansomwareResultOpt
        // GraphQL -> ransomwareResultOpt: RansomwareResult (type)
        public static string RansomwareResultOpt(
            ref RansomwareResult? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResultOpt" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        public static string RansomwareResults(
            ref RansomwareResultConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResults" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResultGroupedDataConnection? RansomwareResultsGrouped
        // GraphQL -> ransomwareResultsGrouped: RansomwareResultGroupedDataConnection! (type)
        public static string RansomwareResultsGrouped(
            ref RansomwareResultGroupedDataConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RansomwareResultGroupedDataConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResultsGrouped" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcsAzureArchivalLocationsConsumptionStatsOutput? RcsArchivalLocationsConsumptionStats
        // GraphQL -> rcsArchivalLocationsConsumptionStats: RcsAzureArchivalLocationsConsumptionStatsOutput! (type)
        public static string RcsArchivalLocationsConsumptionStats(
            ref RcsAzureArchivalLocationsConsumptionStatsOutput? cmdletReply
        )
        {
            string args = "\n(\nrcsAzureTargetConsumptionStatsRequest: $rcsAzureTargetConsumptionStatsRequest\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RcsAzureArchivalLocationsConsumptionStatsOutput() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rcsArchivalLocationsConsumptionStats" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcvAccountEntitlement? RcvAccountEntitlement
        // GraphQL -> rcvAccountEntitlement: RcvAccountEntitlement! (type)
        public static string RcvAccountEntitlement(
            ref RcvAccountEntitlement? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new RcvAccountEntitlement() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rcvAccountEntitlement" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RdsInstanceDetailsFromAws? RdsInstanceDetailsFromAws
        // GraphQL -> rdsInstanceDetailsFromAws: RdsInstanceDetailsFromAws! (type)
        public static string RdsInstanceDetailsFromAws(
            ref RdsInstanceDetailsFromAws? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RdsInstanceDetailsFromAws() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rdsInstanceDetailsFromAws" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoveryPermissionCheckReply? RecoveryPermissionCheck
        // GraphQL -> recoveryPermissionCheck: RecoveryPermissionCheckReply! (type)
        public static string RecoveryPermissionCheck(
            ref RecoveryPermissionCheckReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RecoveryPermissionCheckReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoveryPermissionCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoveryPlanPermissionCheckReply? RecoveryPlanPermissionCheck
        // GraphQL -> recoveryPlanPermissionCheck: RecoveryPlanPermissionCheckReply! (type)
        public static string RecoveryPlanPermissionCheck(
            ref RecoveryPlanPermissionCheckReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RecoveryPlanPermissionCheckReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoveryPlanPermissionCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReleaseNoteConnection? ReleasesNotes
        // GraphQL -> releasesNotes: ReleaseNoteConnection! (type)
        public static string ReleasesNotes(
            ref ReleaseNoteConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nquery: $query\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ReleaseNoteConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "releasesNotes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalReplicationBandwidthIncomingResponse? ReplicationIncomingStats
        // GraphQL -> replicationIncomingStats: InternalReplicationBandwidthIncomingResponse! (type)
        public static string ReplicationIncomingStats(
            ref InternalReplicationBandwidthIncomingResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InternalReplicationBandwidthIncomingResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationIncomingStats" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalReplicationBandwidthOutgoingResponse? ReplicationOutgoingStats
        // GraphQL -> replicationOutgoingStats: InternalReplicationBandwidthOutgoingResponse! (type)
        public static string ReplicationOutgoingStats(
            ref InternalReplicationBandwidthOutgoingResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new InternalReplicationBandwidthOutgoingResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationOutgoingStats" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReplicationPairConnection? ReplicationPairs
        // GraphQL -> replicationPairs: ReplicationPairConnection! (type)
        public static string ReplicationPairs(
            ref ReplicationPairConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ReplicationPairConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationPairs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReport? Report
        // GraphQL -> report: CustomReport! (type)
        public static string Report(
            ref CustomReport? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CustomReport() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "report" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ChartDataResult? ReportChartData
        // GraphQL -> reportChartData: ChartDataResult! (type)
        public static string ReportChartData(
            ref ChartDataResult? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nchartView: $chartView\nfilters: $filters\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ChartDataResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportChartData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportConfig? ReportConfig
        // GraphQL -> reportConfig: ReportConfig! (type)
        public static string ReportConfig(
            ref ReportConfig? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ReportConfig() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        public static string ReportConnection(
            ref CustomReportConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CustomReportConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RowConnection? ReportData
        // GraphQL -> reportData: RowConnection! (type)
        public static string ReportData(
            ref RowConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ndataView: $dataView\ncolumns: $columns\nfilters: $filters\ngroupBy: $groupBy\nsecondaryGroupBy: $secondaryGroupBy\naggregations: $aggregations\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RowConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReport? ReportFromConfig
        // GraphQL -> reportFromConfig: CustomReport! (type)
        public static string ReportFromConfig(
            ref CustomReport? cmdletReply
        )
        {
            string args = "\n(\nconfig: $config\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CustomReport() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportFromConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReportGroupByConnection? ReportGroupByConnection
        // GraphQL -> reportGroupByConnection: CustomReportGroupByConnection! (type)
        public static string ReportGroupByConnection(
            ref CustomReportGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CustomReportGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportSchema? ReportSchema
        // GraphQL -> reportSchema: ReportSchema! (type)
        public static string ReportSchema(
            ref ReportSchema? cmdletReply
        )
        {
            string args = "\n(\ndataView: $dataView\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ReportSchema() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportSchema" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RowConnection? ReportTableData
        // GraphQL -> reportTableData: RowConnection! (type)
        public static string ReportTableData(
            ref RowConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ntableView: $tableView\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RowConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportTableData" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportVersion? ReportVersion
        // GraphQL -> reportVersion: ReportVersion! (type)
        public static string ReportVersion(
            ref ReportVersion? cmdletReply
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ReportVersion() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportVersion" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RoleTemplateConnection? RoleTemplates
        // GraphQL -> roleTemplates: RoleTemplateConnection! (type)
        public static string RoleTemplates(
            ref RoleTemplateConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nnameFilter: $nameFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RoleTemplateConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "roleTemplates" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RscAutoUpgradeInfo? RscAutoUpgradeInfo
        // GraphQL -> rscAutoUpgradeInfo: RscAutoUpgradeInfo! (type)
        public static string RscAutoUpgradeInfo(
            ref RscAutoUpgradeInfo? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new RscAutoUpgradeInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rscAutoUpgradeInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RunningJobsReply? RunningJobsStatus
        // GraphQL -> runningJobsStatus: RunningJobsReply! (type)
        public static string RunningJobsStatus(
            ref RunningJobsReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new RunningJobsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "runningJobsStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetS3BucketStateForRecoveryReply? S3BucketStateForRecovery
        // GraphQL -> s3BucketStateForRecovery: GetS3BucketStateForRecoveryReply! (type)
        public static string S3BucketStateForRecovery(
            ref GetS3BucketStateForRecoveryReply? cmdletReply
        )
        {
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetS3BucketStateForRecoveryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "s3BucketStateForRecovery" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaDatabase? SapHanaDatabase
        // GraphQL -> sapHanaDatabase: SapHanaDatabase! (type)
        public static string SapHanaDatabase(
            ref SapHanaDatabase? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaDatabase() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaDatabase" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaDatabaseConnection? SapHanaDatabases
        // GraphQL -> sapHanaDatabases: SapHanaDatabaseConnection! (type)
        public static string SapHanaDatabases(
            ref SapHanaDatabaseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaDatabaseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaDatabases" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaLogSnapshot? SapHanaLogSnapshot
        // GraphQL -> sapHanaLogSnapshot: SapHanaLogSnapshot! (type)
        public static string SapHanaLogSnapshot(
            ref SapHanaLogSnapshot? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaLogSnapshot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaLogSnapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaLogSnapshotConnection? SapHanaLogSnapshots
        // GraphQL -> sapHanaLogSnapshots: SapHanaLogSnapshotConnection! (type)
        public static string SapHanaLogSnapshots(
            ref SapHanaLogSnapshotConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaLogSnapshotConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaLogSnapshots" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaRecoverableRange? SapHanaRecoverableRange
        // GraphQL -> sapHanaRecoverableRange: SapHanaRecoverableRange! (type)
        public static string SapHanaRecoverableRange(
            ref SapHanaRecoverableRange? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaRecoverableRange() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaRecoverableRangeConnection? SapHanaRecoverableRanges
        // GraphQL -> sapHanaRecoverableRanges: SapHanaRecoverableRangeConnection! (type)
        public static string SapHanaRecoverableRanges(
            ref SapHanaRecoverableRangeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaRecoverableRangeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaRecoverableRanges" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaSystem? SapHanaSystem
        // GraphQL -> sapHanaSystem: SapHanaSystem! (type)
        public static string SapHanaSystem(
            ref SapHanaSystem? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaSystem() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaSystem" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaSystemConnection? SapHanaSystems
        // GraphQL -> sapHanaSystems: SapHanaSystemConnection! (type)
        public static string SapHanaSystems(
            ref SapHanaSystemConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SapHanaSystemConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaSystems" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport (type)
        public static string ScheduledReport(
            ref ScheduledReport? cmdletReply
        )
        {
            string args = "\n(\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ScheduledReport() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "scheduledReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ScheduledReportConnection? ScheduledReports
        // GraphQL -> scheduledReports: ScheduledReportConnection! (type)
        public static string ScheduledReports(
            ref ScheduledReportConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ScheduledReportConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "scheduledReports" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TakeScreenshotReply? ScreenshotReport
        // GraphQL -> screenshotReport: TakeScreenshotReply! (type)
        public static string ScreenshotReport(
            ref TakeScreenshotReply? cmdletReply
        )
        {
            string args = "\n(\nreportId: $reportId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TakeScreenshotReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "screenshotReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DiffResult? SearchFileByPrefix
        // GraphQL -> searchFileByPrefix: DiffResult! (type)
        public static string SearchFileByPrefix(
            ref DiffResult? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nsearchFolderPath: $searchFolderPath\nfilenamePrefix: $filenamePrefix\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new DiffResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchFileByPrefix" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchHost
        // GraphQL -> searchHost: SearchResponseListResponse! (type)
        public static string SearchHost(
            ref SearchResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\nid: $id\npath: $path\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SearchResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchNutanixVm
        // GraphQL -> searchNutanixVm: SearchResponseListResponse! (type)
        public static string SearchNutanixVm(
            ref SearchResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SearchResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchNutanixVm" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchSnapMirrorCloud
        // GraphQL -> searchSnapMirrorCloud: SearchResponseListResponse! (type)
        public static string SearchSnapMirrorCloud(
            ref SearchResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SearchResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableConnection? SearchSnappableConnection
        // GraphQL -> searchSnappableConnection: SnappableConnection! (type)
        public static string SearchSnappableConnection(
            ref SnappableConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnappableConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnappableConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VersionedFileConnection? SearchSnappableVersionedFiles
        // GraphQL -> searchSnappableVersionedFiles: VersionedFileConnection! (type)
        public static string SearchSnappableVersionedFiles(
            ref VersionedFileConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsearchQuery: $searchQuery\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VersionedFileConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnappableVersionedFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AppSearchResponseConnection? SearchVappFiles
        // GraphQL -> searchVappFiles: AppSearchResponseConnection! (type)
        public static string SearchVappFiles(
            ref AppSearchResponseConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AppSearchResponseConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchVappFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ServiceAccountConnection? ServiceAccounts
        // GraphQL -> serviceAccounts: ServiceAccountConnection! (type)
        public static string ServiceAccounts(
            ref ServiceAccountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ServiceAccountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "serviceAccounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSpExplicitReply? ServiceProviderMetadataFields
        // GraphQL -> serviceProviderMetadataFields: GetSPExplicitReply! (type)
        public static string ServiceProviderMetadataFields(
            ref GetSpExplicitReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetSpExplicitReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "serviceProviderMetadataFields" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ShareFileset? ShareFileset
        // GraphQL -> shareFileset: ShareFileset! (type)
        public static string ShareFileset(
            ref ShareFileset? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ShareFileset() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "shareFileset" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteDescendants
        // GraphQL -> sharepointSiteDescendants: O365FullSpObjectConnection! (type)
        public static string SharepointSiteDescendants(
            ref O365FullSpObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\nsnapshotFid: $snapshotFid\nnaturalId: $naturalId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365FullSpObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sharepointSiteDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteSearch
        // GraphQL -> sharepointSiteSearch: O365FullSpObjectConnection! (type)
        public static string SharepointSiteSearch(
            ref O365FullSpObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\norgId: $orgId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365FullSpObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sharepointSiteSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SidsPolicyHitsSummaries? SidsPolicyHitsSummary
        // GraphQL -> sidsPolicyHitsSummary: SidsPolicyHitsSummaries! (type)
        public static string SidsPolicyHitsSummary(
            ref SidsPolicyHitsSummaries? cmdletReply
        )
        {
            string args = "\n(\nsids: $sids\nday: $day\nhistoricalDeltaDays: $historicalDeltaDays\npolicyId: $policyId\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SidsPolicyHitsSummaries() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sidsPolicyHitsSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnifiedFeatureFlag? SingleUnifiedFeatureFlag
        // GraphQL -> singleUnifiedFeatureFlag: UnifiedFeatureFlag! (type)
        public static string SingleUnifiedFeatureFlag(
            ref UnifiedFeatureFlag? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UnifiedFeatureFlag() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "singleUnifiedFeatureFlag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaArchivalValidationWithWarnings? SlaArchivalValidationWarnings
        // GraphQL -> slaArchivalValidationWarnings: SlaArchivalValidationWithWarnings! (type)
        public static string SlaArchivalValidationWarnings(
            ref SlaArchivalValidationWithWarnings? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SlaArchivalValidationWithWarnings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaArchivalValidationWarnings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaAuditDetail>? SlaAuditDetail
        // GraphQL -> slaAuditDetail: [SlaAuditDetail!]! (type)
        public static string SlaAuditDetail(
            ref List<SlaAuditDetail>? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nSlaId: $SlaId\nfilter: $filter\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SlaAuditDetail>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaAuditDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomainWithWarnings? SlaDomainWithWarnings
        // GraphQL -> slaDomainWithWarnings: SlaDomainWithWarnings! (type)
        public static string SlaDomainWithWarnings(
            ref SlaDomainWithWarnings? cmdletReply
        )
        {
            string args = "\n(\nid: $id\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SlaDomainWithWarnings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomainWithWarnings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaDomainWithWarnings>? SlaDomainWithWarningsList
        // GraphQL -> slaDomainWithWarningsList: [SlaDomainWithWarnings!]! (type)
        public static string SlaDomainWithWarningsList(
            ref List<SlaDomainWithWarnings>? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nsnapshotIds: $snapshotIds\noperation: $operation\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<SlaDomainWithWarnings>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomainWithWarningsList" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomainConnection? SlaDomains
        // GraphQL -> slaDomains: SlaDomainConnection! (type)
        public static string SlaDomains(
            ref SlaDomainConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SlaDomainConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomains" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolume? SlaManagedVolume
        // GraphQL -> slaManagedVolume: ManagedVolume! (type)
        public static string SlaManagedVolume(
            ref ManagedVolume? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolume() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaManagedVolume" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeConnection? SlaManagedVolumes
        // GraphQL -> slaManagedVolumes: ManagedVolumeConnection! (type)
        public static string SlaManagedVolumes(
            ref ManagedVolumeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ManagedVolumeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaManagedVolumes" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSmbConfigurationReply? SmbConfiguration
        // GraphQL -> smbConfiguration: GetSmbConfigurationReply! (type)
        public static string SmbConfiguration(
            ref GetSmbConfigurationReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetSmbConfigurationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smbConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SmbDomainConnection? SmbDomains
        // GraphQL -> smbDomains: SmbDomainConnection! (type)
        public static string SmbDomains(
            ref SmbDomainConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SmbDomainConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smbDomains" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSmtpConfigurationReply? SmtpConfiguration
        // GraphQL -> smtpConfiguration: GetSMTPConfigurationReply! (type)
        public static string SmtpConfiguration(
            ref GetSmtpConfigurationReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetSmtpConfigurationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smtpConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapMirrorCloud? SnapMirrorCloud
        // GraphQL -> snapMirrorCloud: SnapMirrorCloud! (type)
        public static string SnapMirrorCloud(
            ref SnapMirrorCloud? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapMirrorCloud() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapMirrorCloud" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? SnapMirrorCloudSnapshotFiles
        // GraphQL -> snapMirrorCloudSnapshotFiles: BrowseResponseListResponse! (type)
        public static string SnapMirrorCloudSnapshotFiles(
            ref BrowseResponseListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BrowseResponseListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapMirrorCloudSnapshotFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        public static string SnappableConnection(
            ref SnappableConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnappableConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableContactSearch
        // GraphQL -> snappableContactSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableContactSearch(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableContactSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEmailSearch
        // GraphQL -> snappableEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEmailSearch(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableEmailSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEventSearch
        // GraphQL -> snappableEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEventSearch(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableEventSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableGroupByAtSpecifiedTimeConnection? SnappableGroupByAtSpecifiedTimeConnection
        // GraphQL -> snappableGroupByAtSpecifiedTimeConnection: SnappableGroupByAtSpecifiedTimeConnection! (type)
        public static string SnappableGroupByAtSpecifiedTimeConnection(
            ref SnappableGroupByAtSpecifiedTimeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\nspecifiedTime: $specifiedTime\nrequestedAggregations: $requestedAggregations\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnappableGroupByAtSpecifiedTimeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableGroupByAtSpecifiedTimeConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableGroupByConnection? SnappableGroupByConnection
        // GraphQL -> snappableGroupByConnection: SnappableGroupByConnection! (type)
        public static string SnappableGroupByConnection(
            ref SnappableGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\nrequestedAggregations: $requestedAggregations\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnappableGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableOnedriveSearch
        // GraphQL -> snappableOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableOnedriveSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableOnedriveSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointDriveSearch
        // GraphQL -> snappableSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointDriveSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableSharepointDriveSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointListSearch
        // GraphQL -> snappableSharepointListSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointListSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableSharepointListSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsConversationsConnection? SnappableTeamsConversationsSearch
        // GraphQL -> snappableTeamsConversationsSearch: O365TeamsConversationsConnection! (type)
        public static string SnappableTeamsConversationsSearch(
            ref O365TeamsConversationsConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsnapshotFidOpt: $snapshotFidOpt\nteamConvChannels: $teamConvChannels\nteamsConversationsSearchFilter: $teamsConversationsSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365TeamsConversationsConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableTeamsConversationsSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableTeamsDriveSearch
        // GraphQL -> snappableTeamsDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableTeamsDriveSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nchannelId: $channelId\nchannelFolderName: $channelFolderName\nteamsDriveSearchFilter: $teamsDriveSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableTeamsDriveSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LegalHoldSnappableDetailConnection? SnappablesWithLegalHoldSnapshotsSummary
        // GraphQL -> snappablesWithLegalHoldSnapshotsSummary: LegalHoldSnappableDetailConnection! (type)
        public static string SnappablesWithLegalHoldSnapshotsSummary(
            ref LegalHoldSnappableDetailConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new LegalHoldSnappableDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappablesWithLegalHoldSnapshotsSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        public static string Snapshot(
            ref CdmSnapshot? cmdletReply
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmSnapshot() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshot" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEmailSearch
        // GraphQL -> snapshotEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEmailSearch(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotEmailSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEventSearch
        // GraphQL -> snapshotEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEventSearch(
            ref O365ExchangeObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365ExchangeObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotEventSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileDeltaConnection? SnapshotFilesDelta
        // GraphQL -> snapshotFilesDelta: SnapshotFileDeltaConnection! (type)
        public static string SnapshotFilesDelta(
            ref SnapshotFileDeltaConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotFileDeltaConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotFilesDelta" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileDeltaV2Connection? SnapshotFilesDeltaV2
        // GraphQL -> snapshotFilesDeltaV2: SnapshotFileDeltaV2Connection! (type)
        public static string SnapshotFilesDeltaV2(
            ref SnapshotFileDeltaV2Connection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotFileDeltaV2Connection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotFilesDeltaV2" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfAsnappableConnection
        // GraphQL -> snapshotOfASnappableConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfAsnappableConnection(
            ref GenericSnapshotConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nworkloadId: $workloadId\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GenericSnapshotConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOfASnappableConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfSnappablesConnection
        // GraphQL -> snapshotOfSnappablesConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfSnappablesConnection(
            ref GenericSnapshotConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsnappableIds: $snappableIds\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GenericSnapshotConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOfSnappablesConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotOnedriveSearch
        // GraphQL -> snapshotOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotOnedriveSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOnedriveSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotResultConnection? SnapshotResults
        // GraphQL -> snapshotResults: SnapshotResultConnection! (type)
        public static string SnapshotResults(
            ref SnapshotResultConnection? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nstartTimeMs: $startTimeMs\nendTimeMs: $endTimeMs\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotResults" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotSharepointDriveSearch
        // GraphQL -> snapshotSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotSharepointDriveSearch(
            ref O365OnedriveObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new O365OnedriveObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotSharepointDriveSearch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotsMalwareInfoReply? SnapshotsAnomalyInfo
        // GraphQL -> snapshotsAnomalyInfo: SnapshotsMalwareInfoReply! (type)
        public static string SnapshotsAnomalyInfo(
            ref SnapshotsMalwareInfoReply? cmdletReply
        )
        {
            string args = "\n(\nsnapshotMalware: $snapshotMalware\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotsMalwareInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsAnomalyInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotSummaryConnection? SnapshotsForUnmanagedObject
        // GraphQL -> snapshotsForUnmanagedObject: SnapshotSummaryConnection! (type)
        public static string SnapshotsForUnmanagedObject(
            ref SnapshotSummaryConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotSummaryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsForUnmanagedObject" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotsMalwareInfoReply? SnapshotsMalwareInfo
        // GraphQL -> snapshotsMalwareInfo: SnapshotsMalwareInfoReply! (type)
        public static string SnapshotsMalwareInfo(
            ref SnapshotsMalwareInfoReply? cmdletReply
        )
        {
            string args = "\n(\nsnapshotMalware: $snapshotMalware\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnapshotsMalwareInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsMalwareInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnmpConfiguration? SnmpConfigurations
        // GraphQL -> snmpConfigurations: SnmpConfiguration! (type)
        public static string SnmpConfigurations(
            ref SnmpConfiguration? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SnmpConfiguration() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snmpConfigurations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarContentReportConnection? SonarContentReport
        // GraphQL -> sonarContentReport: SonarContentReportConnection! (type)
        public static string SonarContentReport(
            ref SonarContentReportConnection? cmdletReply
        )
        {
            string args = "\n(\ngroupBy: $groupBy\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SonarContentReportConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarContentReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarReportConnection? SonarReport
        // GraphQL -> sonarReport: SonarReportConnection! (type)
        public static string SonarReport(
            ref SonarReportConnection? cmdletReply
        )
        {
            string args = "\n(\nsonarReportGroupBy: $sonarReportGroupBy\nfilter: $filter\ntimeFilter: $timeFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SonarReportConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarReport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarReportRowConnection? SonarReportRow
        // GraphQL -> sonarReportRow: SonarReportRowConnection! (type)
        public static string SonarReportRow(
            ref SonarReportRowConnection? cmdletReply
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nendTime: $endTime\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SonarReportRowConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarReportRow" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccessGroupConnection? SonarUserGroups
        // GraphQL -> sonarUserGroups: AccessGroupConnection! (type)
        public static string SonarUserGroups(
            ref AccessGroupConnection? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AccessGroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarUserGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccessUserConnection? SonarUsers
        // GraphQL -> sonarUsers: AccessUserConnection! (type)
        public static string SonarUsers(
            ref AccessUserConnection? cmdletReply
        )
        {
            string args = "\n(\nsort: $sort\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AccessUserConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarUsers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SourceBlueprintInfo? SourceBlueprintInfo
        // GraphQL -> sourceBlueprintInfo: SourceBlueprintInfo! (type)
        public static string SourceBlueprintInfo(
            ref SourceBlueprintInfo? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SourceBlueprintInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sourceBlueprintInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? SupportBundle
        // GraphQL -> supportBundle: AsyncRequestStatus! (type)
        public static string SupportBundle(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportBundle" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalRole? SupportPortalRole
        // GraphQL -> supportPortalRole: SupportPortalRole! (type)
        public static string SupportPortalRole(
            ref SupportPortalRole? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportPortalRole() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportPortalRole" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportUserAccessConnection? SupportUserAccesses
        // GraphQL -> supportUserAccesses: SupportUserAccessConnection! (type)
        public static string SupportUserAccesses(
            ref SupportUserAccessConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportUserAccessConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportUserAccesses" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSyslogConfigurationReply? SyslogConfiguration
        // GraphQL -> syslogConfiguration: GetSyslogConfigurationReply! (type)
        public static string SyslogConfiguration(
            ref GetSyslogConfigurationReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetSyslogConfigurationReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "syslogConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SyslogExportRuleSummaryListResponse? SyslogExportRules
        // GraphQL -> syslogExportRules: SyslogExportRuleSummaryListResponse! (type)
        public static string SyslogExportRules(
            ref SyslogExportRuleSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SyslogExportRuleSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "syslogExportRules" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TableFilters? TableFilters
        // GraphQL -> tableFilters: TableFilters! (type)
        public static string TableFilters(
            ref TableFilters? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new TableFilters() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tableFilters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        public static string TargetMapping(
            ref TargetMapping? cmdletReply
        )
        {
            string args = "\n(\ntargetMappingId: $targetMappingId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetMapping() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "targetMapping" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetConnection? Targets
        // GraphQL -> targets: TargetConnection! (type)
        public static string Targets(
            ref TargetConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TargetConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "targets" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        public static string TaskDetailConnection(
            ref TaskDetailConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TaskDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskDetailConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskDetailGroupByConnection? TaskDetailGroupByConnection
        // GraphQL -> taskDetailGroupByConnection: TaskDetailGroupByConnection! (type)
        public static string TaskDetailGroupByConnection(
            ref TaskDetailGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TaskDetailGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskDetailGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        public static string TaskSummaryConnection(
            ref TaskSummaryConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TaskSummaryConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskSummaryConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskSummaryGroupByConnection? TaskSummaryGroupByConnection
        // GraphQL -> taskSummaryGroupByConnection: TaskSummaryGroupByConnection! (type)
        public static string TaskSummaryGroupByConnection(
            ref TaskSummaryGroupByConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TaskSummaryGroupByConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskSummaryGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskchainInfoReply? TaskchainInfo
        // GraphQL -> taskchainInfo: TaskchainInfoReply! (type)
        public static string TaskchainInfo(
            ref TaskchainInfoReply? cmdletReply
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\njobType: $jobType\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TaskchainInfoReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskchainInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHunt? ThreatHuntDetail
        // GraphQL -> threatHuntDetail: ThreatHunt! (type)
        public static string ThreatHuntDetail(
            ref ThreatHunt? cmdletReply
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatHunt() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntResult? ThreatHuntResult
        // GraphQL -> threatHuntResult: ThreatHuntResult! (type)
        public static string ThreatHuntResult(
            ref ThreatHuntResult? cmdletReply
        )
        {
            string args = "\n(\nhuntId: $huntId\nobjectId: $objectId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatHuntResult() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntResult" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ThreatHuntStatus
        // GraphQL -> threatHuntStatus: AsyncRequestStatus! (type)
        public static string ThreatHuntStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntSummaryReply? ThreatHuntSummary
        // GraphQL -> threatHuntSummary: ThreatHuntSummaryReply! (type)
        public static string ThreatHuntSummary(
            ref ThreatHuntSummaryReply? cmdletReply
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatHuntSummaryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntConnection? ThreatHunts
        // GraphQL -> threatHunts: ThreatHuntConnection! (type)
        public static string ThreatHunts(
            ref ThreatHuntConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nclusterUuidFilter: $clusterUuidFilter\nstatusFilter: $statusFilter\nmatchesFoundFilter: $matchesFoundFilter\nquarantinedMatchesFilter: $quarantinedMatchesFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatHuntConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHunts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatMonitoringFileMatchDetailsReply? ThreatMonitoringMatchedFileDetails
        // GraphQL -> threatMonitoringMatchedFileDetails: ThreatMonitoringFileMatchDetailsReply! (type)
        public static string ThreatMonitoringMatchedFileDetails(
            ref ThreatMonitoringFileMatchDetailsReply? cmdletReply
        )
        {
            string args = "\n(\nobjectFid: $objectFid\nfilename: $filename\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatMonitoringFileMatchDetailsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedFileDetails" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileMatchConnection? ThreatMonitoringMatchedFiles
        // GraphQL -> threatMonitoringMatchedFiles: FileMatchConnection! (type)
        public static string ThreatMonitoringMatchedFiles(
            ref FileMatchConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nobjectFid: $objectFid\nfilenameSearchFilter: $filenameSearchFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FileMatchConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedFiles" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatMonitoringMatchedObjectConnection? ThreatMonitoringMatchedObjects
        // GraphQL -> threatMonitoringMatchedObjects: ThreatMonitoringMatchedObjectConnection! (type)
        public static string ThreatMonitoringMatchedObjects(
            ref ThreatMonitoringMatchedObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nclusterUuidFilter: $clusterUuidFilter\nobjectTypeFilter: $objectTypeFilter\nworkloadNameSearch: $workloadNameSearch\nmatchTypeFilter: $matchTypeFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ThreatMonitoringMatchedObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TopRiskPrincipalsReply? TopRiskPrincipals
        // GraphQL -> topRiskPrincipals: TopRiskPrincipalsReply! (type)
        public static string TopRiskPrincipals(
            ref TopRiskPrincipalsReply? cmdletReply
        )
        {
            string args = "\n(\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nlimit: $limit\npolicyId: $policyId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TopRiskPrincipalsReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "topRiskPrincipals" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetTotpStatusReply? TotpConfigStatus
        // GraphQL -> totpConfigStatus: GetTotpStatusReply! (type)
        public static string TotpConfigStatus(
            ref GetTotpStatusReply? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetTotpStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "totpConfigStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprConfigurationType? TprConfiguration
        // GraphQL -> tprConfiguration: TprConfigurationType! (type)
        public static string TprConfiguration(
            ref TprConfigurationType? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TprConfigurationType() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprConfiguration" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRequestDetailReply? TprRequestDetail
        // GraphQL -> tprRequestDetail: TprRequestDetailReply! (type)
        public static string TprRequestDetail(
            ref TprRequestDetailReply? cmdletReply
        )
        {
            string args = "\n(\ntprRequestId: $tprRequestId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TprRequestDetailReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRequestDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRoleEligibilityType? TprRoleEligibility
        // GraphQL -> tprRoleEligibility: TprRoleEligibilityType! (type)
        public static string TprRoleEligibility(
            ref TprRoleEligibilityType? cmdletReply
        )
        {
            string args = "\n(\norgId: $orgId\nemail: $email\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new TprRoleEligibilityType() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRoleEligibility" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportTunnelInfo? TunnelStatus
        // GraphQL -> tunnelStatus: SupportTunnelInfo! (type)
        public static string TunnelStatus(
            ref SupportTunnelInfo? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new SupportTunnelInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tunnelStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnmanagedObjectDetailConnection? UnmanagedObjects
        // GraphQL -> unmanagedObjects: UnmanagedObjectDetailConnection! (type)
        public static string UnmanagedObjects(
            ref UnmanagedObjectDetailConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UnmanagedObjectDetailConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "unmanagedObjects" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeStatusReply? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatusReply! (type)
        public static string UpgradeStatus(
            ref UpgradeStatusReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UpgradeStatusReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileResultConnection? UserActivities
        // GraphQL -> userActivities: FileResultConnection! (type)
        public static string UserActivities(
            ref FileResultConnection? cmdletReply
        )
        {
            string args = "\n(\nfilter: $filter\nsort: $sort\ntimeRange: $timeRange\nuserId: $userId\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new FileResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userActivities" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivityTimelineResultConnection? UserActivityTimeline
        // GraphQL -> userActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserActivityTimeline(
            ref ActivityTimelineResultConnection? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nuniqueActivities: $uniqueActivities\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActivityTimelineResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userActivityTimeline" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerAccessUsageConnection? UserAnalyzerAccess
        // GraphQL -> userAnalyzerAccess: AnalyzerAccessUsageConnection! (type)
        public static string UserAnalyzerAccess(
            ref AnalyzerAccessUsageConnection? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nlimit: $limit\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AnalyzerAccessUsageConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAnalyzerAccess" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserAuditConnection? UserAuditConnection
        // GraphQL -> userAuditConnection: UserAuditConnection! (type)
        public static string UserAuditConnection(
            ref UserAuditConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserAuditConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAuditConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserAuditGroupByInfoConnection? UserAuditGroupByConnection
        // GraphQL -> userAuditGroupByConnection: UserAuditGroupByInfoConnection! (type)
        public static string UserAuditGroupByConnection(
            ref UserAuditGroupByInfoConnection? cmdletReply
        )
        {
            string args = "\n(\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\nprimaryGroupBy: $primaryGroupBy\nsecondaryGroupBy: $secondaryGroupBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserAuditGroupByInfoConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAuditGroupByConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUserDetailReply? UserDetail
        // GraphQL -> userDetail: GetUserDetailReply! (type)
        public static string UserDetail(
            ref GetUserDetailReply? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetUserDetailReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userDetail" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivityTimelineResultConnection? UserFileActivityTimeline
        // GraphQL -> userFileActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserFileActivityTimeline(
            ref ActivityTimelineResultConnection? cmdletReply
        )
        {
            string args = "\n(\nuserId: $userId\nresource: $resource\nnativePath: $nativePath\nstartDay: $startDay\ntimezone: $timezone\ntimeGranularity: $timeGranularity\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ActivityTimelineResultConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userFileActivityTimeline" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Group>? UserGroups
        // GraphQL -> userGroups: [Group!]! (type)
        public static string UserGroups(
            ref List<Group>? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nroleIdsFilter: $roleIdsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<Group>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userGroups" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserNotifications? UserNotifications
        // GraphQL -> userNotifications: UserNotifications! (type)
        public static string UserNotifications(
            ref UserNotifications? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new UserNotifications() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userNotifications" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUserSessionManagementConfigReply? UserSessionManagementConfig
        // GraphQL -> userSessionManagementConfig: GetUserSessionManagementConfigReply! (type)
        public static string UserSessionManagementConfig(
            ref GetUserSessionManagementConfigReply? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new GetUserSessionManagementConfigReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userSessionManagementConfig" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserSettings? UserSettings
        // GraphQL -> userSettings: UserSettings! (type)
        public static string UserSettings(
            ref UserSettings? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new UserSettings() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userSettings" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserConnection? UsersInCurrentAndDescendantOrganization
        // GraphQL -> usersInCurrentAndDescendantOrganization: UserConnection! (type)
        public static string UsersInCurrentAndDescendantOrganization(
            ref UserConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\nshouldIncludeUserWithoutRole: $shouldIncludeUserWithoutRole\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new UserConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "usersInCurrentAndDescendantOrganization" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUsersSummaryReply? UsersSummary
        // GraphQL -> usersSummary: GetUsersSummaryReply! (type)
        public static string UsersSummary(
            ref GetUsersSummaryReply? cmdletReply
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetUsersSummaryReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "usersSummary" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcenterAdvancedTagPreviewReply? VcenterAdvancedTagPreview
        // GraphQL -> vCenterAdvancedTagPreview: VcenterAdvancedTagPreviewReply! (type)
        public static string VcenterAdvancedTagPreview(
            ref VcenterAdvancedTagPreviewReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcenterAdvancedTagPreviewReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterAdvancedTagPreview" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HotAddBandwidthInfo? VcenterHotAddBandwidth
        // GraphQL -> vCenterHotAddBandwidth: HotAddBandwidthInfo! (type)
        public static string VcenterHotAddBandwidth(
            ref HotAddBandwidthInfo? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HotAddBandwidthInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterHotAddBandwidth" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HotAddNetworkConfigWithName? VcenterHotAddNetwork
        // GraphQL -> vCenterHotAddNetwork: HotAddNetworkConfigWithName! (type)
        public static string VcenterHotAddNetwork(
            ref HotAddNetworkConfigWithName? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new HotAddNetworkConfigWithName() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterHotAddNetwork" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkInfoListResponse? VcenterNetworks
        // GraphQL -> vCenterNetworks: NetworkInfoListResponse! (type)
        public static string VcenterNetworks(
            ref NetworkInfoListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new NetworkInfoListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterNetworks" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcenterPreAddInfo? VcenterPreAddInfo
        // GraphQL -> vCenterPreAddInfo: VcenterPreAddInfo! (type)
        public static string VcenterPreAddInfo(
            ref VcenterPreAddInfo? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcenterPreAddInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterPreAddInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereBlueprint? VsphereBlueprint
        // GraphQL -> vSphereBlueprint: VSphereBlueprint! (type)
        public static string VsphereBlueprint(
            ref VsphereBlueprint? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereBlueprint() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereBlueprint" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereComputeCluster? VsphereComputeCluster
        // GraphQL -> vSphereComputeCluster: VsphereComputeCluster! (type)
        public static string VsphereComputeCluster(
            ref VsphereComputeCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereComputeCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereComputeCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereComputeClusterConnection? VsphereComputeClusters
        // GraphQL -> vSphereComputeClusters: VsphereComputeClusterConnection! (type)
        public static string VsphereComputeClusters(
            ref VsphereComputeClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereComputeClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereComputeClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatacenter? VsphereDatacenter
        // GraphQL -> vSphereDatacenter: VsphereDatacenter! (type)
        public static string VsphereDatacenter(
            ref VsphereDatacenter? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereDatacenter() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatacenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastore? VsphereDatastore
        // GraphQL -> vSphereDatastore: VsphereDatastore! (type)
        public static string VsphereDatastore(
            ref VsphereDatastore? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereDatastore() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastore" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreCluster? VsphereDatastoreCluster
        // GraphQL -> vSphereDatastoreCluster: VsphereDatastoreCluster! (type)
        public static string VsphereDatastoreCluster(
            ref VsphereDatastoreCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereDatastoreCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreClusterConnection? VsphereDatastoreClusters
        // GraphQL -> vSphereDatastoreClusters: VsphereDatastoreClusterConnection! (type)
        public static string VsphereDatastoreClusters(
            ref VsphereDatastoreClusterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereDatastoreClusterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreConnection? VsphereDatastoreConnection
        // GraphQL -> vSphereDatastoreConnection: VsphereDatastoreConnection! (type)
        public static string VsphereDatastoreConnection(
            ref VsphereDatastoreConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereDatastoreConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereFolder? VsphereFolder
        // GraphQL -> vSphereFolder: VsphereFolder! (type)
        public static string VsphereFolder(
            ref VsphereFolder? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereFolder() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereFolder" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereHost? VsphereHost
        // GraphQL -> vSphereHost: VsphereHost! (type)
        public static string VsphereHost(
            ref VsphereHost? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereHost() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHost" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereHostConnection? VsphereHostConnection
        // GraphQL -> vSphereHostConnection: VsphereHostConnection! (type)
        public static string VsphereHostConnection(
            ref VsphereHostConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereHostConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VmwareHostDetail? VsphereHostDetails
        // GraphQL -> vSphereHostDetails: VmwareHostDetail! (type)
        public static string VsphereHostDetails(
            ref VmwareHostDetail? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VmwareHostDetail() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostDetails" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VsphereHost>? VsphereHostsByFids
        // GraphQL -> vSphereHostsByFids: [VsphereHost!]! (type)
        public static string VsphereHostsByFids(
            ref List<VsphereHost>? cmdletReply
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new List<VsphereHost>() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostsByFids" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        public static string VsphereLiveMounts(
            ref VsphereLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereLiveMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereMount? VsphereMount
        // GraphQL -> vSphereMount: VsphereMount! (type)
        public static string VsphereMount(
            ref VsphereMount? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereMount() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereMount" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereMountConnection? VsphereMountConnection
        // GraphQL -> vSphereMountConnection: VsphereMountConnection! (type)
        public static string VsphereMountConnection(
            ref VsphereMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereMountConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereNetwork? VsphereNetwork
        // GraphQL -> vSphereNetwork: VsphereNetwork! (type)
        public static string VsphereNetwork(
            ref VsphereNetwork? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereNetwork() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereNetwork" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereResourcePool? VsphereResourcePool
        // GraphQL -> vSphereResourcePool: VsphereResourcePool! (type)
        public static string VsphereResourcePool(
            ref VsphereResourcePool? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereResourcePool() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereResourcePool" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereRootRecoveryHierarchy
        // GraphQL -> vSphereRootRecoveryHierarchy: CdmHierarchyObjectConnection! (type)
        public static string VsphereRootRecoveryHierarchy(
            ref CdmHierarchyObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmHierarchyObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereRootRecoveryHierarchy" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereTag? VsphereTag
        // GraphQL -> vSphereTag: VsphereTag! (type)
        public static string VsphereTag(
            ref VsphereTag? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereTag() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTag" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereTagCategory? VsphereTagCategory
        // GraphQL -> vSphereTagCategory: VsphereTagCategory! (type)
        public static string VsphereTagCategory(
            ref VsphereTagCategory? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereTagCategory() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTagCategory" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereTopLevelDescendantsConnection
        // GraphQL -> vSphereTopLevelDescendantsConnection: CdmHierarchyObjectConnection! (type)
        public static string VsphereTopLevelDescendantsConnection(
            ref CdmHierarchyObjectConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CdmHierarchyObjectConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTopLevelDescendantsConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVcenter? VsphereVcenter
        // GraphQL -> vSphereVCenter: VsphereVcenter! (type)
        public static string VsphereVcenter(
            ref VsphereVcenter? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVcenter() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVCenter" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVcenterConnection? VsphereVcenterConnection
        // GraphQL -> vSphereVCenterConnection: VsphereVcenterConnection! (type)
        public static string VsphereVcenterConnection(
            ref VsphereVcenterConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVcenterConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVCenterConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmAsyncRequestStatus
        // GraphQL -> vSphereVMAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string VsphereVmAsyncRequestStatus(
            ref AsyncRequestStatus? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nid: $id\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new AsyncRequestStatus() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVMAsyncRequestStatus" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVm? VsphereVmNew
        // GraphQL -> vSphereVmNew: VsphereVm! (type)
        public static string VsphereVmNew(
            ref VsphereVm? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVm() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVmNew" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmConnection? VsphereVmNewConnection
        // GraphQL -> vSphereVmNewConnection: VsphereVmConnection! (type)
        public static string VsphereVmNewConnection(
            ref VsphereVmConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVmNewConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAwsNativeRdsClusterNameForExportReply? ValidateAwsNativeRdsClusterNameForExport
        // GraphQL -> validateAwsNativeRdsClusterNameForExport: ValidateAwsNativeRdsClusterNameForExportReply! (type)
        public static string ValidateAwsNativeRdsClusterNameForExport(
            ref ValidateAwsNativeRdsClusterNameForExportReply? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsClusterName: $rdsClusterName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAwsNativeRdsClusterNameForExportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAwsNativeRdsClusterNameForExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAwsNativeRdsInstanceNameForExportReply? ValidateAwsNativeRdsInstanceNameForExport
        // GraphQL -> validateAwsNativeRdsInstanceNameForExport: ValidateAwsNativeRdsInstanceNameForExportReply! (type)
        public static string ValidateAwsNativeRdsInstanceNameForExport(
            ref ValidateAwsNativeRdsInstanceNameForExportReply? cmdletReply
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAwsNativeRdsInstanceNameForExportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAwsNativeRdsInstanceNameForExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureSubnetsForCloudAccountExocomputeReply? ValidateAzureCloudAccountExocomputeConfigurations
        // GraphQL -> validateAzureCloudAccountExocomputeConfigurations: ValidateAzureSubnetsForCloudAccountExocomputeReply! (type)
        public static string ValidateAzureCloudAccountExocomputeConfigurations(
            ref ValidateAzureSubnetsForCloudAccountExocomputeReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAzureSubnetsForCloudAccountExocomputeReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureCloudAccountExocomputeConfigurations" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureNativeSqlDatabaseDbNameForExportReply? ValidateAzureNativeSqlDatabaseDbNameForExport
        // GraphQL -> validateAzureNativeSqlDatabaseDbNameForExport: ValidateAzureNativeSqlDatabaseDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlDatabaseDbNameForExport(
            ref ValidateAzureNativeSqlDatabaseDbNameForExportReply? cmdletReply
        )
        {
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAzureNativeSqlDatabaseDbNameForExportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureNativeSqlDatabaseDbNameForExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? ValidateAzureNativeSqlManagedInstanceDbNameForExport
        // GraphQL -> validateAzureNativeSqlManagedInstanceDbNameForExport: ValidateAzureNativeSqlManagedInstanceDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlManagedInstanceDbNameForExport(
            ref ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? cmdletReply
        )
        {
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateAzureNativeSqlManagedInstanceDbNameForExportReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureNativeSqlManagedInstanceDbNameForExport" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateCertificateReply? ValidateCertificate
        // GraphQL -> validateCertificate: ValidateCertificateReply! (type)
        public static string ValidateCertificate(
            ref ValidateCertificateReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateCertificateReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateCertificate" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterLicenseCapacityValidations? ValidateClusterLicenseCapacity
        // GraphQL -> validateClusterLicenseCapacity: ClusterLicenseCapacityValidations! (type)
        public static string ValidateClusterLicenseCapacity(
            ref ClusterLicenseCapacityValidations? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ClusterLicenseCapacityValidations() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateClusterLicenseCapacity" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateOrgNameReply? ValidateOrgName
        // GraphQL -> validateOrgName: ValidateOrgNameReply! (type)
        public static string ValidateOrgName(
            ref ValidateOrgNameReply? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new ValidateOrgNameReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateOrgName" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappExportOptions? VappSnapshotExportOptions
        // GraphQL -> vappSnapshotExportOptions: VappExportOptions! (type)
        public static string VappSnapshotExportOptions(
            ref VappExportOptions? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VappExportOptions() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappSnapshotExportOptions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappInstantRecoveryOptions? VappSnapshotInstantRecoveryOptions
        // GraphQL -> vappSnapshotInstantRecoveryOptions: VappInstantRecoveryOptions! (type)
        public static string VappSnapshotInstantRecoveryOptions(
            ref VappInstantRecoveryOptions? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VappInstantRecoveryOptions() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappSnapshotInstantRecoveryOptions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappTemplateExportOptionsUnion? VappTemplateSnapshotExportOptions
        // GraphQL -> vappTemplateSnapshotExportOptions: VappTemplateExportOptionsUnion! (type)
        public static string VappTemplateSnapshotExportOptions(
            ref VappTemplateExportOptionsUnion? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VappTemplateExportOptionsUnion() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappTemplateSnapshotExportOptions" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Vcd? Vcd
        // GraphQL -> vcd: Vcd! (type)
        public static string Vcd(
            ref Vcd? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new Vcd() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcd" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdCatalog? VcdCatalog
        // GraphQL -> vcdCatalog: VcdCatalog! (type)
        public static string VcdCatalog(
            ref VcdCatalog? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdCatalog() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdCatalog" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdClusterSummaryListResponse? VcdClusters
        // GraphQL -> vcdClusters: VcdClusterSummaryListResponse! (type)
        public static string VcdClusters(
            ref VcdClusterSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdClusterSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdClusters" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrg? VcdOrg
        // GraphQL -> vcdOrg: VcdOrg! (type)
        public static string VcdOrg(
            ref VcdOrg? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdOrg() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrg" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrgVdc? VcdOrgVdc
        // GraphQL -> vcdOrgVdc: VcdOrgVdc! (type)
        public static string VcdOrgVdc(
            ref VcdOrgVdc? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdOrgVdc() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrgVdc" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrgConnection? VcdOrgs
        // GraphQL -> vcdOrgs: VcdOrgConnection! (type)
        public static string VcdOrgs(
            ref VcdOrgConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdOrgConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrgs" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdTopLevelDescendantTypeConnection? VcdTopLevelDescendants
        // GraphQL -> vcdTopLevelDescendants: VcdTopLevelDescendantTypeConnection! (type)
        public static string VcdTopLevelDescendants(
            ref VcdTopLevelDescendantTypeConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdTopLevelDescendantTypeConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdTopLevelDescendants" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVapp? VcdVapp
        // GraphQL -> vcdVapp: VcdVapp! (type)
        public static string VcdVapp(
            ref VcdVapp? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdVapp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVapp" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmConnection? VcdVappVms
        // GraphQL -> vcdVappVms: VsphereVmConnection! (type)
        public static string VcdVappVms(
            ref VsphereVmConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VsphereVmConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVappVms" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVappConnection? VcdVapps
        // GraphQL -> vcdVapps: VcdVappConnection! (type)
        public static string VcdVapps(
            ref VcdVappConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdVappConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVapps" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVimServer? VcdVimServer
        // GraphQL -> vcdVimServer: VcdVimServer! (type)
        public static string VcdVimServer(
            ref VcdVimServer? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VcdVimServer() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVimServer" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VimserverSummaryListResponse? VcdVimServers
        // GraphQL -> vcdVimServers: VimserverSummaryListResponse! (type)
        public static string VcdVimServers(
            ref VimserverSummaryListResponse? cmdletReply
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VimserverSummaryListResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVimServers" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VerifySlaWithReplicationToClusterResp? VerifySlaWithReplicationToCluster
        // GraphQL -> verifySLAWithReplicationToCluster: VerifySLAWithReplicationToClusterResp! (type)
        public static string VerifySlaWithReplicationToCluster(
            ref VerifySlaWithReplicationToClusterResp? cmdletReply
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VerifySlaWithReplicationToClusterResp() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "verifySLAWithReplicationToCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckVmwareVmsRecoveryPermissionReply? VmwareVmsRecoveryPermissionCheck
        // GraphQL -> vmwareVmsRecoveryPermissionCheck: CheckVmwareVmsRecoveryPermissionReply! (type)
        public static string VmwareVmsRecoveryPermissionCheck(
            ref CheckVmwareVmsRecoveryPermissionReply? cmdletReply
        )
        {
            string args = "\n(\ncheckVmwareVmsRecoveryPermission: $checkVmwareVmsRecoveryPermission\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new CheckVmwareVmsRecoveryPermissionReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vmwareVmsRecoveryPermissionCheck" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroup? VolumeGroup
        // GraphQL -> volumeGroup: VolumeGroup! (type)
        public static string VolumeGroup(
            ref VolumeGroup? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VolumeGroup() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroup" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroupConnection? VolumeGroupConnection
        // GraphQL -> volumeGroupConnection: VolumeGroupConnection! (type)
        public static string VolumeGroupConnection(
            ref VolumeGroupConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VolumeGroupConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroupConnection" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroupLiveMountConnection? VolumeGroupMounts
        // GraphQL -> volumeGroupMounts: VolumeGroupLiveMountConnection! (type)
        public static string VolumeGroupMounts(
            ref VolumeGroupLiveMountConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new VolumeGroupLiveMountConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroupMounts" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoverableRangeResponse? VsphereVmMissedRecoverableRange
        // GraphQL -> vsphereVMMissedRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmMissedRecoverableRange(
            ref RecoverableRangeResponse? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RecoverableRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMMissedRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoverableRangeResponse? VsphereVmRecoverableRange
        // GraphQL -> vsphereVMRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmRecoverableRange(
            ref RecoverableRangeResponse? cmdletReply
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new RecoverableRangeResponse() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMRecoverableRange" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchVmwareVmRecoverableRanges? VsphereVmRecoverableRangeInBatch
        // GraphQL -> vsphereVMRecoverableRangeInBatch: BatchVmwareVmRecoverableRanges! (type)
        public static string VsphereVmRecoverableRangeInBatch(
            ref BatchVmwareVmRecoverableRanges? cmdletReply
        )
        {
            string args = "\n(\nrequestInfo: $requestInfo\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchVmwareVmRecoverableRanges() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMRecoverableRangeInBatch" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchVmwareCdpLiveInfo? VsphereVmwareCdpLiveInfo
        // GraphQL -> vsphereVmwareCdpLiveInfo: BatchVmwareCdpLiveInfo! (type)
        public static string VsphereVmwareCdpLiveInfo(
            ref BatchVmwareCdpLiveInfo? cmdletReply
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new BatchVmwareCdpLiveInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmwareCdpLiveInfo" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WindowsCluster? WindowsCluster
        // GraphQL -> windowsCluster: WindowsCluster! (type)
        public static string WindowsCluster(
            ref WindowsCluster? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new WindowsCluster() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "windowsCluster" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WindowsFileset? WindowsFileset
        // GraphQL -> windowsFileset: WindowsFileset! (type)
        public static string WindowsFileset(
            ref WindowsFileset? cmdletReply
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new WindowsFileset() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "windowsFileset" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetWorkloadAlertSettingReply? WorkloadAlertSetting
        // GraphQL -> workloadAlertSetting: GetWorkloadAlertSettingReply! (type)
        public static string WorkloadAlertSetting(
            ref GetWorkloadAlertSettingReply? cmdletReply
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new GetWorkloadAlertSettingReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadAlertSetting" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WorkloadAnomalyConnection? WorkloadAnomalies
        // GraphQL -> workloadAnomalies: WorkloadAnomalyConnection! (type)
        public static string WorkloadAnomalies(
            ref WorkloadAnomalyConnection? cmdletReply
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nworkloadNameSearch: $workloadNameSearch\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nencryptionFilter: $encryptionFilter\nseverityFilter: $severityFilter\nanalyzerGroupFilter: $analyzerGroupFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\norderParentsFirst: $orderParentsFirst\nblueprintRecoveryTypes: $blueprintRecoveryTypes\nlocationsFilter: $locationsFilter\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new WorkloadAnomalyConnection() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadAnomalies" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WorkloadGroupByReply? WorkloadGroupByAtSpecifiedTime
        // GraphQL -> workloadGroupByAtSpecifiedTime: WorkloadGroupByReply! (type)
        public static string WorkloadGroupByAtSpecifiedTime(
            ref WorkloadGroupByReply? cmdletReply
        )
        {
            string args = "\n(\nfilters: $filters\nprimaryGroupBy: $primaryGroupBy\nsecondaryGroupBy: $secondaryGroupBy\nspecifiedTime: $specifiedTime\n)";
            if (cmdletReply == null)
            {
                cmdletReply = new WorkloadGroupByReply() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadGroupByAtSpecifiedTime" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateInfo? WwwTlsCert
        // GraphQL -> wwwTlsCert: CertificateInfo! (type)
        public static string WwwTlsCert(
            ref CertificateInfo? cmdletReply
        )
        {
            string args = "";
            if (cmdletReply == null)
            {
                cmdletReply = new CertificateInfo() ;
                cmdletReply.ApplyExploratoryFieldSpec();
            }
            return new string(
                "wwwTlsCert" + args + "{\n" +
                cmdletReply.AsFieldSpec(1) +
                "}\n");
        }

        #endregion

    } // class Query
    #endregion
}