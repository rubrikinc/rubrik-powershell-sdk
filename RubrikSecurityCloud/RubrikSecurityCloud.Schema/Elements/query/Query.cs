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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region Query
    public class Query
    {
        #region members
        //      C# -> List<Operation>? AllAllowedOrgAdminOperations
        // GraphQL -> allAllowedOrgAdminOperations: [Operation!]! (enum)
        public static string AllAllowedOrgAdminOperations(
            ref List<Operation>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<Operation>() ;
            }
            return new string("allAllowedOrgAdminOperations" + args + "\n");
        }

        //      C# -> List<Operation>? AllAuthorizationsForGlobalResource
        // GraphQL -> allAuthorizationsForGlobalResource: [Operation!]! (enum)
        public static string AllAuthorizationsForGlobalResource(
            ref List<Operation>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<Operation>() ;
            }
            return new string("allAuthorizationsForGlobalResource" + args + "\n");
        }

        //      C# -> List<Operation>? AllAuthorizationsForObject
        // GraphQL -> allAuthorizationsForObject: [Operation!]! (enum)
        public static string AllAuthorizationsForObject(
            ref List<Operation>? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<Operation>() ;
            }
            return new string("allAuthorizationsForObject" + args + "\n");
        }

        //      C# -> List<AwsCloudAccountRegion>? AllAwsRegions
        // GraphQL -> allAwsRegions: [AwsCloudAccountRegion!]! (enum)
        public static string AllAwsRegions(
            ref List<AwsCloudAccountRegion>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<AwsCloudAccountRegion>() ;
            }
            return new string("allAwsRegions" + args + "\n");
        }

        //      C# -> List<AzureCloudAccountRegion>? AllAzureRegions
        // GraphQL -> allAzureRegions: [AzureCloudAccountRegion!]! (enum)
        public static string AllAzureRegions(
            ref List<AzureCloudAccountRegion>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<AzureCloudAccountRegion>() ;
            }
            return new string("allAzureRegions" + args + "\n");
        }

        //      C# -> List<InventoryCard>? AllInventoryWorkloads
        // GraphQL -> allInventoryWorkloads: [InventoryCard!]! (enum)
        public static string AllInventoryWorkloads(
            ref List<InventoryCard>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<InventoryCard>() ;
            }
            return new string("allInventoryWorkloads" + args + "\n");
        }

        //      C# -> List<ManagedObjectType>? AllUnmanagedObjectsSupportedTypes
        // GraphQL -> allUnmanagedObjectsSupportedTypes: [ManagedObjectType!]! (enum)
        public static string AllUnmanagedObjectsSupportedTypes(
            ref List<ManagedObjectType>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<ManagedObjectType>() ;
            }
            return new string("allUnmanagedObjectsSupportedTypes" + args + "\n");
        }

        //      C# -> TenantAuthDomainConfig? CurrentOrgAuthDomainConfig
        // GraphQL -> currentOrgAuthDomainConfig: TenantAuthDomainConfig! (enum)
        public static string CurrentOrgAuthDomainConfig(
            ref TenantAuthDomainConfig? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new TenantAuthDomainConfig() ;
            }
            return new string("currentOrgAuthDomainConfig" + args + "\n");
        }

        //      C# -> List<FeatureName>? ToggleableFeaturesEnabled
        // GraphQL -> toggleableFeaturesEnabled: [FeatureName!]! (enum)
        public static string ToggleableFeaturesEnabled(
            ref List<FeatureName>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<FeatureName>() ;
            }
            return new string("toggleableFeaturesEnabled" + args + "\n");
        }

        //      C# -> List<ResourceSpec>? AllBlueprintResourceSpecs
        // GraphQL -> allBlueprintResourceSpecs: [ResourceSpec!]! (interface)
        public static string AllBlueprintResourceSpecs(
            ref List<ResourceSpec>? fieldSpec
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nsnappableInfos: $snappableInfos\nfailoverId: $failoverId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ResourceSpec>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allBlueprintResourceSpecs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccount>? AllCloudAccounts
        // GraphQL -> allCloudAccounts: [CloudAccount!]! (interface)
        public static string AllCloudAccounts(
            ref List<CloudAccount>? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfeatures: $features\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudAccount>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaDomain>? AllSlaSummariesByIds
        // GraphQL -> allSlaSummariesByIds: [SlaDomain!]! (interface)
        public static string AllSlaSummariesByIds(
            ref List<SlaDomain>? fieldSpec
        )
        {
            string args = "\n(\nslaIds: $slaIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SlaDomain>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSlaSummariesByIds" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ResourceSpec>? AllSnappableResourceSpecs
        // GraphQL -> allSnappableResourceSpecs: [ResourceSpec!]! (interface)
        public static string AllSnappableResourceSpecs(
            ref List<ResourceSpec>? fieldSpec
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ResourceSpec>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnappableResourceSpecs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Target>? AllTargets
        // GraphQL -> allTargets: [Target!]! (interface)
        public static string AllTargets(
            ref List<Target>? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Target>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTargets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Blueprint? Blueprint
        // GraphQL -> blueprint: Blueprint! (interface)
        public static string Blueprint(
            ref Blueprint? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                var list = new List<Blueprint>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (Blueprint?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Blueprint? composite object");
                }
            }
            return new string(
                "blueprint" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNew? BlueprintNew
        // GraphQL -> blueprintNew: BlueprintNew! (interface)
        public static string BlueprintNew(
            ref BlueprintNew? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                var list = new List<BlueprintNew>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (BlueprintNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create BlueprintNew? composite object");
                }
            }
            return new string(
                "blueprintNew" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchySnappableNew? CdmHierarchySnappableNew
        // GraphQL -> cdmHierarchySnappableNew: CdmHierarchySnappableNew! (interface)
        public static string CdmHierarchySnappableNew(
            ref CdmHierarchySnappableNew? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                var list = new List<CdmHierarchySnappableNew>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (CdmHierarchySnappableNew?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CdmHierarchySnappableNew? composite object");
                }
            }
            return new string(
                "cdmHierarchySnappableNew" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmHierarchySnappableNew>? CdmHierarchySnappablesNew
        // GraphQL -> cdmHierarchySnappablesNew: [CdmHierarchySnappableNew!]! (interface)
        public static string CdmHierarchySnappablesNew(
            ref List<CdmHierarchySnappableNew>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CdmHierarchySnappableNew>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmHierarchySnappablesNew" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        public static string CloudAccount(
            ref CloudAccount? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if (fieldSpec == null)
            {
                var list = new List<CloudAccount>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (CloudAccount?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create CloudAccount? composite object");
                }
            }
            return new string(
                "cloudAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        public static string HierarchyObject(
            ref HierarchyObject? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                var list = new List<HierarchyObject>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (HierarchyObject?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create HierarchyObject? composite object");
                }
            }
            return new string(
                "hierarchyObject" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject!]! (interface)
        public static string HierarchyObjects(
            ref List<HierarchyObject>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<HierarchyObject>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hierarchyObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<HierarchyObject>? SlaConflictObjects
        // GraphQL -> slaConflictObjects: [HierarchyObject!]! (interface)
        public static string SlaConflictObjects(
            ref List<HierarchyObject>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<HierarchyObject>();
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaConflictObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        public static string SlaDomain(
            ref SlaDomain? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (fieldSpec == null)
            {
                var list = new List<SlaDomain>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (SlaDomain?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create SlaDomain? composite object");
                }
            }
            return new string(
                "slaDomain" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        public static string Target(
            ref Target? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                var list = new List<Target>();
                list.ApplyExploratoryFieldSpec();
                fieldSpec = (Target?)InterfaceHelper.MakeCompositeFromList(list);
                if (fieldSpec == null)
                {
                    throw new InvalidOperationException("Could not create Target? composite object");
                }
            }
            return new string(
                "target" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        public static string AccountId(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("accountId" + args + "\n");
        }

        //      C# -> List<System.String>? AllAvailabilityZonesByRegionFromAws
        // GraphQL -> allAvailabilityZonesByRegionFromAws: [String!]! (scalar)
        public static string AllAvailabilityZonesByRegionFromAws(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAvailabilityZonesByRegionFromAws" + args + "\n");
        }

        //      C# -> List<System.String>? AllAwsInstanceProfileNames
        // GraphQL -> allAwsInstanceProfileNames: [String!]! (scalar)
        public static string AllAwsInstanceProfileNames(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAwsInstanceProfileNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureNativeVirtualMachineSizes
        // GraphQL -> allAzureNativeVirtualMachineSizes: [String!]! (scalar)
        public static string AllAzureNativeVirtualMachineSizes(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureNativeVirtualMachineSizes" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureNsgs
        // GraphQL -> allAzureNsgs: [String!]! (scalar)
        public static string AllAzureNsgs(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nnsgRequest: $nsgRequest\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureNsgs" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureResourceGroups
        // GraphQL -> allAzureResourceGroups: [String!]! (scalar)
        public static string AllAzureResourceGroups(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureRegion: $azureRegion\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureResourceGroups" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureStorageAccounts
        // GraphQL -> allAzureStorageAccounts: [String!]! (scalar)
        public static string AllAzureStorageAccounts(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nstorageAccountsRequest: $storageAccountsRequest\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureStorageAccounts" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureSubnets
        // GraphQL -> allAzureSubnets: [String!]! (scalar)
        public static string AllAzureSubnets(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nsubnetRequest: $subnetRequest\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureSubnets" + args + "\n");
        }

        //      C# -> List<System.String>? AllAzureVnets
        // GraphQL -> allAzureVnets: [String!]! (scalar)
        public static string AllAzureVnets(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nvnetRequest: $vnetRequest\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allAzureVnets" + args + "\n");
        }

        //      C# -> List<System.String>? AllCdpSlaVmNames
        // GraphQL -> allCdpSlaVmNames: [String!]! (scalar)
        public static string AllCdpSlaVmNames(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCdpSlaVmNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeFileRecoveryEligibleSnapshots
        // GraphQL -> allCloudNativeFileRecoveryEligibleSnapshots: [String!]! (scalar)
        public static string AllCloudNativeFileRecoveryEligibleSnapshots(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCloudNativeFileRecoveryEligibleSnapshots" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeLabelKeys
        // GraphQL -> allCloudNativeLabelKeys: [String!]! (scalar)
        public static string AllCloudNativeLabelKeys(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCloudNativeLabelKeys" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeLabelValues
        // GraphQL -> allCloudNativeLabelValues: [String!]! (scalar)
        public static string AllCloudNativeLabelValues(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCloudNativeLabelValues" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeTagKeys
        // GraphQL -> allCloudNativeTagKeys: [String!]! (scalar)
        public static string AllCloudNativeTagKeys(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCloudNativeTagKeys" + args + "\n");
        }

        //      C# -> List<System.String>? AllCloudNativeTagValues
        // GraphQL -> allCloudNativeTagValues: [String!]! (scalar)
        public static string AllCloudNativeTagValues(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allCloudNativeTagValues" + args + "\n");
        }

        //      C# -> List<System.Boolean>? AllClustersTotpAckStatus
        // GraphQL -> allClustersTotpAckStatus: [Boolean!]! (scalar)
        public static string AllClustersTotpAckStatus(
            ref List<System.Boolean>? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.Boolean>() ;
            }
            return new string("allClustersTotpAckStatus" + args + "\n");
        }

        //      C# -> List<System.String>? AllDeploymentIpAddresses
        // GraphQL -> allDeploymentIpAddresses: [String!]! (scalar)
        public static string AllDeploymentIpAddresses(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allDeploymentIpAddresses" + args + "\n");
        }

        //      C# -> List<System.String>? AllEc2KeyPairsByRegionFromAws
        // GraphQL -> allEc2KeyPairsByRegionFromAws: [String!]! (scalar)
        public static string AllEc2KeyPairsByRegionFromAws(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allEc2KeyPairsByRegionFromAws" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeCompatibleMachineTypes
        // GraphQL -> allGcpNativeCompatibleMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeCompatibleMachineTypes(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\ntargetZone: $targetZone\nsnapshotId: $snapshotId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeCompatibleMachineTypes" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypes
        // GraphQL -> allGcpNativeStoredMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypes(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredMachineTypes" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypesInProject
        // GraphQL -> allGcpNativeStoredMachineTypesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypesInProject(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredMachineTypesInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNames
        // GraphQL -> allGcpNativeStoredNetworkNames: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNames(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredNetworkNames" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNamesInProject
        // GraphQL -> allGcpNativeStoredNetworkNamesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNamesInProject(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredNetworkNamesInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegions
        // GraphQL -> allGcpNativeStoredRegions: [String!]! (scalar)
        public static string AllGcpNativeStoredRegions(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredRegions" + args + "\n");
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegionsInProject
        // GraphQL -> allGcpNativeStoredRegionsInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredRegionsInProject(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allGcpNativeStoredRegionsInProject" + args + "\n");
        }

        //      C# -> List<System.String>? AllIssuesJobIds
        // GraphQL -> allIssuesJobIds: [String!]! (scalar)
        public static string AllIssuesJobIds(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nqueryIds: $queryIds\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allIssuesJobIds" + args + "\n");
        }

        //      C# -> List<System.String>? AllS3BucketsFromAws
        // GraphQL -> allS3BucketsFromAws: [String!]! (scalar)
        public static string AllS3BucketsFromAws(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allS3BucketsFromAws" + args + "\n");
        }

        //      C# -> List<System.String>? AllSupportedAwsRdsDatabaseInstanceClasses
        // GraphQL -> allSupportedAwsRdsDatabaseInstanceClasses: [String!]! (scalar)
        public static string AllSupportedAwsRdsDatabaseInstanceClasses(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("allSupportedAwsRdsDatabaseInstanceClasses" + args + "\n");
        }

        //      C# -> System.Boolean? AreClusterAlertsPaused
        // GraphQL -> areClusterAlertsPaused: Boolean! (scalar)
        public static string AreClusterAlertsPaused(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("areClusterAlertsPaused" + args + "\n");
        }

        //      C# -> System.Boolean? AreMultiGeoBackupsEnabled
        // GraphQL -> areMultiGeoBackupsEnabled: Boolean! (scalar)
        public static string AreMultiGeoBackupsEnabled(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("areMultiGeoBackupsEnabled" + args + "\n");
        }

        //      C# -> System.Boolean? CloudNativeCheckRequiredPermissionsForFeature
        // GraphQL -> cloudNativeCheckRequiredPermissionsForFeature: Boolean! (scalar)
        public static string CloudNativeCheckRequiredPermissionsForFeature(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ncloudNativeAccountId: $cloudNativeAccountId\nfeaturePermissionCheck: $featurePermissionCheck\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("cloudNativeCheckRequiredPermissionsForFeature" + args + "\n");
        }

        //      C# -> System.String? CurrentIpAddress
        // GraphQL -> currentIpAddress: String! (scalar)
        public static string CurrentIpAddress(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("currentIpAddress" + args + "\n");
        }

        //      C# -> System.String? DeploymentVersion
        // GraphQL -> deploymentVersion: String! (scalar)
        public static string DeploymentVersion(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("deploymentVersion" + args + "\n");
        }

        //      C# -> System.Boolean? DoesAzureNativeResourceGroupExist
        // GraphQL -> doesAzureNativeResourceGroupExist: Boolean! (scalar)
        public static string DoesAzureNativeResourceGroupExist(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nresourceGroupName: $resourceGroupName\nfeature: $feature\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("doesAzureNativeResourceGroupExist" + args + "\n");
        }

        //      C# -> System.Boolean? DummyFieldWithAdminOnlyTag
        // GraphQL -> dummyFieldWithAdminOnlyTag: Boolean! (scalar)
        public static string DummyFieldWithAdminOnlyTag(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("dummyFieldWithAdminOnlyTag" + args + "\n");
        }

        //      C# -> System.String? ExternalDeploymentName
        // GraphQL -> externalDeploymentName: String! (scalar)
        public static string ExternalDeploymentName(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("externalDeploymentName" + args + "\n");
        }

        //      C# -> List<System.String>? FeatureFlagNames
        // GraphQL -> featureFlagNames: [String!]! (scalar)
        public static string FeatureFlagNames(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("featureFlagNames" + args + "\n");
        }

        //      C# -> List<System.String>? FlagrFeatureFlagNames
        // GraphQL -> flagrFeatureFlagNames: [String!]! (scalar)
        public static string FlagrFeatureFlagNames(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("flagrFeatureFlagNames" + args + "\n");
        }

        //      C# -> System.String? GcpGetDefaultCredentialsServiceAccount
        // GraphQL -> gcpGetDefaultCredentialsServiceAccount: String! (scalar)
        public static string GcpGetDefaultCredentialsServiceAccount(
            ref System.String? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("gcpGetDefaultCredentialsServiceAccount" + args + "\n");
        }

        //      C# -> List<System.String>? GetDns
        // GraphQL -> getDns: [String!]! (scalar)
        public static string GetDns(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("getDns" + args + "\n");
        }

        //      C# -> List<System.String>? GetNtp
        // GraphQL -> getNtp: [String!]! (scalar)
        public static string GetNtp(
            ref List<System.String>? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = new List<System.String>() ;
            }
            return new string("getNtp" + args + "\n");
        }

        //      C# -> System.Boolean? HasIdpConfigured
        // GraphQL -> hasIdpConfigured: Boolean! (scalar)
        public static string HasIdpConfigured(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("hasIdpConfigured" + args + "\n");
        }

        //      C# -> System.Int32? HostVolumesCount
        // GraphQL -> hostVolumesCount: Int! (scalar)
        public static string HostVolumesCount(
            ref System.Int32? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("hostVolumesCount" + args + "\n");
        }

        //      C# -> System.Boolean? IsAwsNativeRdsInstanceLaunchConfigurationValid
        // GraphQL -> isAwsNativeRdsInstanceLaunchConfigurationValid: Boolean! (scalar)
        public static string IsAwsNativeRdsInstanceLaunchConfigurationValid(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\ndbClass: $dbClass\ndatabaseInstanceClass: $databaseInstanceClass\nprimaryAz: $primaryAz\nstorageType: $storageType\nisMultiAz: $isMultiAz\nkmsKeyId: $kmsKeyId\niops: $iops\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isAwsNativeRdsInstanceLaunchConfigurationValid" + args + "\n");
        }

        //      C# -> System.Boolean? IsAwsS3BucketNameAvailable
        // GraphQL -> isAwsS3BucketNameAvailable: Boolean! (scalar)
        public static string IsAwsS3BucketNameAvailable(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isAwsS3BucketNameAvailable" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureNativeManagedDiskSnapshotRestorable
        // GraphQL -> isAzureNativeManagedDiskSnapshotRestorable: Boolean! (scalar)
        public static string IsAzureNativeManagedDiskSnapshotRestorable(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\ndiskSnapshotId: $diskSnapshotId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isAzureNativeManagedDiskSnapshotRestorable" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureNativeSqlDatabaseSnapshotPersistent
        // GraphQL -> isAzureNativeSqlDatabaseSnapshotPersistent: Boolean! (scalar)
        public static string IsAzureNativeSqlDatabaseSnapshotPersistent(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isAzureNativeSqlDatabaseSnapshotPersistent" + args + "\n");
        }

        //      C# -> System.Boolean? IsAzureStorageAccountNameAvailable
        // GraphQL -> isAzureStorageAccountNameAvailable: Boolean! (scalar)
        public static string IsAzureStorageAccountNameAvailable(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nstorageAccountName: $storageAccountName\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isAzureStorageAccountNameAvailable" + args + "\n");
        }

        //      C# -> System.Boolean? IsSfdcReachable
        // GraphQL -> isSfdcReachable: Boolean! (scalar)
        public static string IsSfdcReachable(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nhostname: $hostname\norganizationId: $organizationId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isSfdcReachable" + args + "\n");
        }

        //      C# -> System.Boolean? IsTotpAckNecessaryForCluster
        // GraphQL -> isTotpAckNecessaryForCluster: Boolean! (scalar)
        public static string IsTotpAckNecessaryForCluster(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isTotpAckNecessaryForCluster" + args + "\n");
        }

        //      C# -> System.Boolean? IsTotpMandatoryInTargetVersion
        // GraphQL -> isTotpMandatoryInTargetVersion: Boolean! (scalar)
        public static string IsTotpMandatoryInTargetVersion(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nversion: $version\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isTotpMandatoryInTargetVersion" + args + "\n");
        }

        //      C# -> System.Boolean? IsVmwareManagementEnabled
        // GraphQL -> isVMwareManagementEnabled: Boolean! (scalar)
        public static string IsVmwareManagementEnabled(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("isVMwareManagementEnabled" + args + "\n");
        }

        //      C# -> System.String? K8sObjectFid
        // GraphQL -> k8sObjectFid: UUID! (scalar)
        public static string K8sObjectFid(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nK8sObjectInternalIDArg: $K8sObjectInternalIDArg\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("k8sObjectFid" + args + "\n");
        }

        //      C# -> System.String? K8sObjectInternalId
        // GraphQL -> k8sObjectInternalId: UUID! (scalar)
        public static string K8sObjectInternalId(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("k8sObjectInternalId" + args + "\n");
        }

        //      C# -> System.Int32? MaxProtectedAppsCount
        // GraphQL -> maxProtectedAppsCount: Int! (scalar)
        public static string MaxProtectedAppsCount(
            ref System.Int32? fieldSpec
        )
        {
            string args = "";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("maxProtectedAppsCount" + args + "\n");
        }

        //      C# -> System.String? O365TeamConversationsFolderId
        // GraphQL -> o365TeamConversationsFolderID: String! (scalar)
        public static string O365TeamConversationsFolderId(
            ref System.String? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\no365OrgId: $o365OrgId\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = "FETCH" ;
            }
            return new string("o365TeamConversationsFolderID" + args + "\n");
        }

        //      C# -> System.Boolean? TeamChannelNameAvailable
        // GraphQL -> teamChannelNameAvailable: Boolean! (scalar)
        public static string TeamChannelNameAvailable(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\nteamUUID: $teamUUID\nchannelName: $channelName\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("teamChannelNameAvailable" + args + "\n");
        }

        //      C# -> System.Int32? UniqueHypervServersCount
        // GraphQL -> uniqueHypervServersCount: Int! (scalar)
        public static string UniqueHypervServersCount(
            ref System.Int32? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("uniqueHypervServersCount" + args + "\n");
        }

        //      C# -> System.Int32? UniqueVsphereVcenterCount
        // GraphQL -> uniqueVSphereVCenterCount: Int! (scalar)
        public static string UniqueVsphereVcenterCount(
            ref System.Int32? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("uniqueVSphereVCenterCount" + args + "\n");
        }

        //      C# -> System.Int32? UniqueVcdCount
        // GraphQL -> uniqueVcdCount: Int! (scalar)
        public static string UniqueVcdCount(
            ref System.Int32? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("uniqueVcdCount" + args + "\n");
        }

        //      C# -> System.Int32? VcenterNumProxiesNeeded
        // GraphQL -> vCenterNumProxiesNeeded: Int! (scalar)
        public static string VcenterNumProxiesNeeded(
            ref System.Int32? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = Int32.MinValue ;
            }
            return new string("vCenterNumProxiesNeeded" + args + "\n");
        }

        //      C# -> System.Boolean? VerifyVappTemplateName
        // GraphQL -> verifyVappTemplateName: Boolean! (scalar)
        public static string VerifyVappTemplateName(
            ref System.Boolean? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if ( fieldSpec == null ) {
                // there is no field spec for scalar types, but we still
                // populate the fieldSpec so that caller can see the type 
                fieldSpec = true ;
            }
            return new string("verifyVappTemplateName" + args + "\n");
        }

        //      C# -> AwsCloudAccountListKmsKeysResponse? AwsCloudAccountListKmsKeys
        // GraphQL -> AwsCloudAccountListKMSKeys: AwsCloudAccountListKMSKeysResponse! (type)
        public static string AwsCloudAccountListKmsKeys(
            ref AwsCloudAccountListKmsKeysResponse? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsCloudAccountListKmsKeysResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "AwsCloudAccountListKMSKeys" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMountDetailsReply? GetMountDetails
        // GraphQL -> GetMountDetails: GetMountDetailsReply! (type)
        public static string GetMountDetails(
            ref GetMountDetailsReply? fieldSpec
        )
        {
            string args = "\n(\nliveMountId: $liveMountId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetMountDetailsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "GetMountDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccountSetting? AccountSettings
        // GraphQL -> accountSettings: AccountSetting! (type)
        public static string AccountSettings(
            ref AccountSetting? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AccountSetting() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "accountSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerConnection? ActiveCustomAnalyzers
        // GraphQL -> activeCustomAnalyzers: AnalyzerConnection! (type)
        public static string ActiveCustomAnalyzers(
            ref AnalyzerConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AnalyzerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeCustomAnalyzers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ActiveDirectoryAsyncRequestStatus
        // GraphQL -> activeDirectoryAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string ActiveDirectoryAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomain? ActiveDirectoryDomain
        // GraphQL -> activeDirectoryDomain: ActiveDirectoryDomain! (type)
        public static string ActiveDirectoryDomain(
            ref ActiveDirectoryDomain? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActiveDirectoryDomain() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomain" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainController? ActiveDirectoryDomainController
        // GraphQL -> activeDirectoryDomainController: ActiveDirectoryDomainController! (type)
        public static string ActiveDirectoryDomainController(
            ref ActiveDirectoryDomainController? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActiveDirectoryDomainController() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomainController" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainControllerConnection? ActiveDirectoryDomainControllers
        // GraphQL -> activeDirectoryDomainControllers: ActiveDirectoryDomainControllerConnection! (type)
        public static string ActiveDirectoryDomainControllers(
            ref ActiveDirectoryDomainControllerConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActiveDirectoryDomainControllerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomainControllers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveDirectoryDomainConnection? ActiveDirectoryDomains
        // GraphQL -> activeDirectoryDomains: ActiveDirectoryDomainConnection! (type)
        public static string ActiveDirectoryDomains(
            ref ActiveDirectoryDomainConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActiveDirectoryDomainConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeDirectoryDomains" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActiveInsightConnection? ActiveInsights
        // GraphQL -> activeInsights: ActiveInsightConnection! (type)
        public static string ActiveInsights(
            ref ActiveInsightConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nclusterUUIDs: $clusterUUIDs\nseverities: $severities\nincludeClusterLevelInsights: $includeClusterLevelInsights\nincludeAccountLevelInsights: $includeAccountLevelInsights\nincludeDismissedInsights: $includeDismissedInsights\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActiveInsightConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activeInsights" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        public static string ActivitySeries(
            ref ActivitySeries? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActivitySeries() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        public static string ActivitySeriesConnection(
            ref ActivitySeriesConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActivitySeriesConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeriesConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivitySeriesGroupByConnection? ActivitySeriesGroupByConnection
        // GraphQL -> activitySeriesGroupByConnection: ActivitySeriesGroupByConnection! (type)
        public static string ActivitySeriesGroupByConnection(
            ref ActivitySeriesGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilters: $filters\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActivitySeriesGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "activitySeriesGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AdVolumeExportConnection? AdVolumeExports
        // GraphQL -> adVolumeExports: AdVolumeExportConnection! (type)
        public static string AdVolumeExports(
            ref AdVolumeExportConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AdVolumeExportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "adVolumeExports" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<User>? AllAccountOwners
        // GraphQL -> allAccountOwners: [User!]! (type)
        public static string AllAccountOwners(
            ref List<User>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<User>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountOwners" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AccountProduct>? AllAccountProducts
        // GraphQL -> allAccountProducts: [AccountProduct!]! (type)
        public static string AllAccountProducts(
            ref List<AccountProduct>? fieldSpec
        )
        {
            string args = "\n(\nnameFilter: $nameFilter\ntypeFilter: $typeFilter\nstateFilter: $stateFilter\nstartDateArg: $startDateArg\nendDateArg: $endDateArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AccountProduct>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountProducts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountWithExocomputeMapping>? AllAccountsWithExocomputeMappings
        // GraphQL -> allAccountsWithExocomputeMappings: [CloudAccountWithExocomputeMapping!]! (type)
        public static string AllAccountsWithExocomputeMappings(
            ref List<CloudAccountWithExocomputeMapping>? fieldSpec
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\nfeatures: $features\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudAccountWithExocomputeMapping>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAccountsWithExocomputeMappings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AuthorizedOperations>? AllAuthorizationsForObjects
        // GraphQL -> allAuthorizationsForObjects: [AuthorizedOperations!]! (type)
        public static string AllAuthorizationsForObjects(
            ref List<AuthorizedOperations>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AuthorizedOperations>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAuthorizationsForObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsCdmVersion>? AllAwsCdmVersions
        // GraphQL -> allAwsCdmVersions: [AwsCdmVersion!]! (type)
        public static string AllAwsCdmVersions(
            ref List<AwsCdmVersion>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsCdmVersion>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCdmVersions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsFeatureConfig>? AllAwsCloudAccountConfigs
        // GraphQL -> allAwsCloudAccountConfigs: [AwsFeatureConfig!]! (type)
        public static string AllAwsCloudAccountConfigs(
            ref List<AwsFeatureConfig>? fieldSpec
        )
        {
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsFeatureConfig>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCloudAccountConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsCloudAccountFeaturesWithExoConfigs>? AllAwsCloudAccountsFeaturesWithExoConfigs
        // GraphQL -> allAwsCloudAccountsFeaturesWithExoConfigs: [AwsCloudAccountFeaturesWithExoConfigs!]! (type)
        public static string AllAwsCloudAccountsFeaturesWithExoConfigs(
            ref List<AwsCloudAccountFeaturesWithExoConfigs>? fieldSpec
        )
        {
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsCloudAccountFeaturesWithExoConfigs>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCloudAccountsFeaturesWithExoConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsCloudAccountWithFeatures>? AllAwsCloudAccountsWithFeatures
        // GraphQL -> allAwsCloudAccountsWithFeatures: [AwsCloudAccountWithFeatures!]! (type)
        public static string AllAwsCloudAccountsWithFeatures(
            ref List<AwsCloudAccountWithFeatures>? fieldSpec
        )
        {
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsCloudAccountWithFeatures>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsCloudAccountsWithFeatures" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsComputeSettings>? AllAwsComputeSettings
        // GraphQL -> allAwsComputeSettings: [AwsComputeSettings!]! (type)
        public static string AllAwsComputeSettings(
            ref List<AwsComputeSettings>? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsComputeSettings>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsComputeSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsExocomputeConfig>? AllAwsExocomputeConfigs
        // GraphQL -> allAwsExocomputeConfigs: [AwsExocomputeConfig!]! (type)
        public static string AllAwsExocomputeConfigs(
            ref List<AwsExocomputeConfig>? fieldSpec
        )
        {
            string args = "\n(\nawsNativeAccountIdOrNamePrefix: $awsNativeAccountIdOrNamePrefix\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsExocomputeConfig>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsExocomputeConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PermissionPolicy>? AllAwsPermissionPolicies
        // GraphQL -> allAwsPermissionPolicies: [PermissionPolicy!]! (type)
        public static string AllAwsPermissionPolicies(
            ref List<PermissionPolicy>? fieldSpec
        )
        {
            string args = "\n(\nawsCloudType: $awsCloudType\nfeatures: $features\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PermissionPolicy>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsPermissionPolicies" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsAuroraInstanceClassesReply? AllAwsRdsAuroraInstanceClasses
        // GraphQL -> allAwsRdsAuroraInstanceClasses: AwsNativeRdsAuroraInstanceClassesReply! (type)
        public static string AllAwsRdsAuroraInstanceClasses(
            ref AwsNativeRdsAuroraInstanceClassesReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeRdsAuroraInstanceClassesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAwsRdsAuroraInstanceClasses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureArmTemplateByFeature>? AllAzureArmTemplatesByFeature
        // GraphQL -> allAzureArmTemplatesByFeature: [AzureArmTemplateByFeature!]! (type)
        public static string AllAzureArmTemplatesByFeature(
            ref List<AzureArmTemplateByFeature>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureArmTemplateByFeature>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureArmTemplatesByFeature" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureCdmVersion>? AllAzureCdmVersions
        // GraphQL -> allAzureCdmVersions: [AzureCdmVersion!]! (type)
        public static string AllAzureCdmVersions(
            ref List<AzureCdmVersion>? fieldSpec
        )
        {
            string args = "\n(\ncdmVersionRequest: $cdmVersionRequest\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureCdmVersion>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCdmVersions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionMissingPermissions>? AllAzureCloudAccountMissingPermissions
        // GraphQL -> allAzureCloudAccountMissingPermissions: [AzureSubscriptionMissingPermissions!]! (type)
        public static string AllAzureCloudAccountMissingPermissions(
            ref List<AzureSubscriptionMissingPermissions>? fieldSpec
        )
        {
            string args = "\n(\nsessionId: $sessionId\nsubscriptionIds: $subscriptionIds\ncloudAccountAction: $cloudAccountAction\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureSubscriptionMissingPermissions>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountMissingPermissions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureCloudAccountSubnetsByRegion
        // GraphQL -> allAzureCloudAccountSubnetsByRegion: [AzureNativeSubnet!]! (type)
        public static string AllAzureCloudAccountSubnetsByRegion(
            ref List<AzureNativeSubnet>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeSubnet>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountSubnetsByRegion" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionWithFeaturesType>? AllAzureCloudAccountSubscriptionsByFeature
        // GraphQL -> allAzureCloudAccountSubscriptionsByFeature: [AzureSubscriptionWithFeaturesType!]! (type)
        public static string AllAzureCloudAccountSubscriptionsByFeature(
            ref List<AzureSubscriptionWithFeaturesType>? fieldSpec
        )
        {
            string args = "\n(\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureSubscriptionWithFeaturesType>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountSubscriptionsByFeature" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureCloudAccountTenant>? AllAzureCloudAccountTenants
        // GraphQL -> allAzureCloudAccountTenants: [AzureCloudAccountTenant!]! (type)
        public static string AllAzureCloudAccountTenants(
            ref List<AzureCloudAccountTenant>? fieldSpec
        )
        {
            string args = "\n(\nfeatures: $features\nfeature: $feature\nincludeSubscriptionDetails: $includeSubscriptionDetails\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureCloudAccountTenant>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountTenants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureCloudAccountTenantWithExoConfigs>? AllAzureCloudAccountTenantsWithExoConfigs
        // GraphQL -> allAzureCloudAccountTenantsWithExoConfigs: [AzureCloudAccountTenantWithExoConfigs!]! (type)
        public static string AllAzureCloudAccountTenantsWithExoConfigs(
            ref List<AzureCloudAccountTenantWithExoConfigs>? fieldSpec
        )
        {
            string args = "\n(\nfeatures: $features\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureCloudAccountTenantWithExoConfigs>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureCloudAccountTenantsWithExoConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeDiskEncryptionSet>? AllAzureDiskEncryptionSetsByRegion
        // GraphQL -> allAzureDiskEncryptionSetsByRegion: [AzureNativeDiskEncryptionSet!]! (type)
        public static string AllAzureDiskEncryptionSetsByRegion(
            ref List<AzureNativeDiskEncryptionSet>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeDiskEncryptionSet>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureDiskEncryptionSetsByRegion" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureEncryptionKey>? AllAzureEncryptionKeys
        // GraphQL -> allAzureEncryptionKeys: [AzureEncryptionKey!]! (type)
        public static string AllAzureEncryptionKeys(
            ref List<AzureEncryptionKey>? fieldSpec
        )
        {
            string args = "\n(\nazureEncryptionKeysInput: $azureEncryptionKeysInput\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureEncryptionKey>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureEncryptionKeys" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureExocomputeConfigsInAccount>? AllAzureExocomputeConfigsInAccount
        // GraphQL -> allAzureExocomputeConfigsInAccount: [AzureExocomputeConfigsInAccount!]! (type)
        public static string AllAzureExocomputeConfigsInAccount(
            ref List<AzureExocomputeConfigsInAccount>? fieldSpec
        )
        {
            string args = "\n(\nazureExocomputeSearchQuery: $azureExocomputeSearchQuery\ncloudAccountIDs: $cloudAccountIDs\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureExocomputeConfigsInAccount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureExocomputeConfigsInAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureKeyVault>? AllAzureKeyVaultsByRegion
        // GraphQL -> allAzureKeyVaultsByRegion: [AzureKeyVault!]! (type)
        public static string AllAzureKeyVaultsByRegion(
            ref List<AzureKeyVault>? fieldSpec
        )
        {
            string args = "\n(\nazureKeyVaultsInput: $azureKeyVaultsInput\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureKeyVault>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureKeyVaultsByRegion" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeAvailabilitySet>? AllAzureNativeAvailabilitySetsByRegionFromAzure
        // GraphQL -> allAzureNativeAvailabilitySetsByRegionFromAzure: [AzureNativeAvailabilitySet!]! (type)
        public static string AllAzureNativeAvailabilitySetsByRegionFromAzure(
            ref List<AzureNativeAvailabilitySet>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nresourceGroupName: $resourceGroupName\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeAvailabilitySet>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeAvailabilitySetsByRegionFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeExportCompatibleDiskTypes>? AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleDiskTypesByRegionFromAzure: [AzureNativeExportCompatibleDiskTypes!]! (type)
        public static string AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(
            ref List<AzureNativeExportCompatibleDiskTypes>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeExportCompatibleDiskTypes>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeExportCompatibleVmSizes>? AllAzureNativeExportCompatibleVmSizesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleVmSizesByRegionFromAzure: [AzureNativeExportCompatibleVmSizes!]! (type)
        public static string AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(
            ref List<AzureNativeExportCompatibleVmSizes>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\nvmSnapshotId: $vmSnapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeExportCompatibleVmSizes>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeExportCompatibleVmSizesByRegionFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureResourceGroupInfo>? AllAzureNativeResourceGroupsInfoIfExist
        // GraphQL -> allAzureNativeResourceGroupsInfoIfExist: [AzureResourceGroupInfo!]! (type)
        public static string AllAzureNativeResourceGroupsInfoIfExist(
            ref List<AzureResourceGroupInfo>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureResourceGroupInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeResourceGroupsInfoIfExist" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSecurityGroup>? AllAzureNativeSecurityGroupsByRegionFromAzure
        // GraphQL -> allAzureNativeSecurityGroupsByRegionFromAzure: [AzureNativeSecurityGroup!]! (type)
        public static string AllAzureNativeSecurityGroupsByRegionFromAzure(
            ref List<AzureNativeSecurityGroup>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeSecurityGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeSecurityGroupsByRegionFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeStorageAccount>? AllAzureNativeStorageAccountsFromAzure
        // GraphQL -> allAzureNativeStorageAccountsFromAzure: [AzureNativeStorageAccount!]! (type)
        public static string AllAzureNativeStorageAccountsFromAzure(
            ref List<AzureNativeStorageAccount>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeStorageAccount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeStorageAccountsFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureNativeSubnetsByRegionFromAzure
        // GraphQL -> allAzureNativeSubnetsByRegionFromAzure: [AzureNativeSubnet!]! (type)
        public static string AllAzureNativeSubnetsByRegionFromAzure(
            ref List<AzureNativeSubnet>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeSubnet>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeSubnetsByRegionFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureNativeVirtualNetwork>? AllAzureNativeVirtualNetworks
        // GraphQL -> allAzureNativeVirtualNetworks: [AzureNativeVirtualNetwork!]! (type)
        public static string AllAzureNativeVirtualNetworks(
            ref List<AzureNativeVirtualNetwork>? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureNativeVirtualNetwork>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureNativeVirtualNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSqlDatabaseServerElasticPool>? AllAzureSqlDatabaseServerElasticPools
        // GraphQL -> allAzureSqlDatabaseServerElasticPools: [AzureSqlDatabaseServerElasticPool!]! (type)
        public static string AllAzureSqlDatabaseServerElasticPools(
            ref List<AzureSqlDatabaseServerElasticPool>? fieldSpec
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureSqlDatabaseServerElasticPool>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureSqlDatabaseServerElasticPools" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureSubscriptionWithExocomputeMapping>? AllAzureSubscriptionWithExocomputeMappings
        // GraphQL -> allAzureSubscriptionWithExocomputeMappings: [AzureSubscriptionWithExocomputeMapping!]! (type)
        public static string AllAzureSubscriptionWithExocomputeMappings(
            ref List<AzureSubscriptionWithExocomputeMapping>? fieldSpec
        )
        {
            string args = "\n(\nfeatures: $features\nexocomputeSubscriptionIdsFilter: $exocomputeSubscriptionIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureSubscriptionWithExocomputeMapping>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allAzureSubscriptionWithExocomputeMappings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintNewConnection? AllBlueprints
        // GraphQL -> allBlueprints: BlueprintNewConnection! (type)
        public static string AllBlueprints(
            ref BlueprintNewConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nsourceLocationIdOpt: $sourceLocationIdOpt\ntargetLocationIdOpt: $targetLocationIdOpt\nstatusOpt: $statusOpt\nfailoverStatusOpt: $failoverStatusOpt\nblueprintRecoveryTypes: $blueprintRecoveryTypes\nisBlueprintVisible: $isBlueprintVisible\nblueprintIds: $blueprintIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BlueprintNewConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allBlueprints" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmGuestCredential>? AllCdmGuestCredentials
        // GraphQL -> allCdmGuestCredentials: [CdmGuestCredential!]! (type)
        public static string AllCdmGuestCredentials(
            ref List<CdmGuestCredential>? fieldSpec
        )
        {
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CdmGuestCredential>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdmGuestCredentials" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CdmOvaDetail>? AllCdmOvaDetails
        // GraphQL -> allCdmOvaDetails: [CdmOvaDetail!]! (type)
        public static string AllCdmOvaDetails(
            ref List<CdmOvaDetail>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CdmOvaDetail>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdmOvaDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdpVmInfoConnection? AllCdpVmsInfos
        // GraphQL -> allCdpVmsInfos: CdpVmInfoConnection! (type)
        public static string AllCdpVmsInfos(
            ref CdpVmInfoConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nallCdpVmInfoSort: $allCdpVmInfoSort\nallCdpVmInfoFilter: $allCdpVmInfoFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdpVmInfoConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCdpVmsInfos" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountsExocomputeAccountMapping>? AllCloudAccountExocomputeMappings
        // GraphQL -> allCloudAccountExocomputeMappings: [CloudAccountsExocomputeAccountMapping!]! (type)
        public static string AllCloudAccountExocomputeMappings(
            ref List<CloudAccountsExocomputeAccountMapping>? fieldSpec
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudAccountsExocomputeAccountMapping>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudAccountExocomputeMappings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CcWithCloudInfo>? AllCloudClusters
        // GraphQL -> allCloudClusters: [CcWithCloudInfo!]! (type)
        public static string AllCloudClusters(
            ref List<CcWithCloudInfo>? fieldSpec
        )
        {
            string args = "\n(\ncloudVendorType: $cloudVendorType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CcWithCloudInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ShareExportIdPair>? AllCloudDirectShares
        // GraphQL -> allCloudDirectShares: [ShareExportIdPair!]! (type)
        public static string AllCloudDirectShares(
            ref List<ShareExportIdPair>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ShareExportIdPair>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudDirectShares" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudDirectSite>? AllCloudDirectSites
        // GraphQL -> allCloudDirectSites: [CloudDirectSite!]! (type)
        public static string AllCloudDirectSites(
            ref List<CloudDirectSite>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudDirectSite>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCloudDirectSites" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? AllClusterConnection
        // GraphQL -> allClusterConnection: ClusterConnection! (type)
        public static string AllClusterConnection(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaInfo>? AllClusterGlobalSlas
        // GraphQL -> allClusterGlobalSlas: [SlaInfo!]! (type)
        public static string AllClusterGlobalSlas(
            ref List<SlaInfo>? fieldSpec
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SlaInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterGlobalSlas" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClusterReplicationTarget>? AllClusterReplicationTargets
        // GraphQL -> allClusterReplicationTargets: [ClusterReplicationTarget!]! (type)
        public static string AllClusterReplicationTargets(
            ref List<ClusterReplicationTarget>? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ClusterReplicationTarget>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterReplicationTargets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClusterWebCertAndIpmi>? AllClusterWebCertsAndIpmis
        // GraphQL -> allClusterWebCertsAndIpmis: [ClusterWebCertAndIpmi!]! (type)
        public static string AllClusterWebCertsAndIpmis(
            ref List<ClusterWebCertAndIpmi>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ClusterWebCertAndIpmi>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allClusterWebCertsAndIpmis" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ItemDiffBetweenSnapshotAndLiveEnvironment? AllComparisonsBetweenSaasAppSnapshotAndLive
        // GraphQL -> allComparisonsBetweenSaasAppSnapshotAndLive: ItemDiffBetweenSnapshotAndLiveEnvironment! (type)
        public static string AllComparisonsBetweenSaasAppSnapshotAndLive(
            ref ItemDiffBetweenSnapshotAndLiveEnvironment? fieldSpec
        )
        {
            string args = "\n(\nworkloadId: $workloadId\nitemId: $itemId\nsnapshotId: $snapshotId\nappItemTypeToken: $appItemTypeToken\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ItemDiffBetweenSnapshotAndLiveEnvironment() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allComparisonsBetweenSaasAppSnapshotAndLive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DailyComplianceStats>? AllComplianceTimeSeries
        // GraphQL -> allComplianceTimeSeries: [DailyComplianceStats!]! (type)
        public static string AllComplianceTimeSeries(
            ref List<DailyComplianceStats>? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nlookbackPeriod: $lookbackPeriod\nobjectTypes: $objectTypes\norgIds: $orgIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DailyComplianceStats>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allComplianceTimeSeries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ConfigProtectionBackupsConnection? AllConfigProtectionBackups
        // GraphQL -> allConfigProtectionBackups: ConfigProtectionBackupsConnection! (type)
        public static string AllConfigProtectionBackups(
            ref ConfigProtectionBackupsConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ConfigProtectionBackupsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allConfigProtectionBackups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DataLocationSupportedCluster>? AllConnectedClusters
        // GraphQL -> allConnectedClusters: [DataLocationSupportedCluster!]! (type)
        public static string AllConnectedClusters(
            ref List<DataLocationSupportedCluster>? fieldSpec
        )
        {
            string args = "\n(\nclusterFilterArg: $clusterFilterArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DataLocationSupportedCluster>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allConnectedClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllCurrentFeaturePermissionsForCloudAccounts
        // GraphQL -> allCurrentFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllCurrentFeaturePermissionsForCloudAccounts(
            ref List<CloudAccountFeaturePermission>? fieldSpec
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudAccountFeaturePermission>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCurrentFeaturePermissionsForCloudAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<IdentityProvider>? AllCurrentOrgIdentityProviders
        // GraphQL -> allCurrentOrgIdentityProviders: [IdentityProvider!]! (type)
        public static string AllCurrentOrgIdentityProviders(
            ref List<IdentityProvider>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<IdentityProvider>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allCurrentOrgIdentityProviders" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DbParameterGroup>? AllDbParameterGroupsByRegionFromAws
        // GraphQL -> allDbParameterGroupsByRegionFromAws: [DbParameterGroup!]! (type)
        public static string AllDbParameterGroupsByRegionFromAws(
            ref List<DbParameterGroup>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nrdsType: $rdsType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DbParameterGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDbParameterGroupsByRegionFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SubnetGroup>? AllDbSubnetGroupsByRegionFromAws
        // GraphQL -> allDbSubnetGroupsByRegionFromAws: [SubnetGroup!]! (type)
        public static string AllDbSubnetGroupsByRegionFromAws(
            ref List<SubnetGroup>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SubnetGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDbSubnetGroupsByRegionFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcActiveRecommendation>? AllDhrcActiveRecommendations
        // GraphQL -> allDhrcActiveRecommendations: [DhrcActiveRecommendation!]! (type)
        public static string AllDhrcActiveRecommendations(
            ref List<DhrcActiveRecommendation>? fieldSpec
        )
        {
            string args = "\n(\ncategories: $categories\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DhrcActiveRecommendation>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcActiveRecommendations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcCollectedMetric>? AllDhrcLatestMetrics
        // GraphQL -> allDhrcLatestMetrics: [DhrcCollectedMetric!]! (type)
        public static string AllDhrcLatestMetrics(
            ref List<DhrcCollectedMetric>? fieldSpec
        )
        {
            string args = "\n(\ncategories: $categories\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DhrcCollectedMetric>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcLatestMetrics" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DhrcScore>? AllDhrcScores
        // GraphQL -> allDhrcScores: [DhrcScore!]! (type)
        public static string AllDhrcScores(
            ref List<DhrcScore>? fieldSpec
        )
        {
            string args = "\n(\ncategories: $categories\nbeginTime: $beginTime\ntimespan: $timespan\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DhrcScore>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allDhrcScores" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<RbacPermission>? AllEffectiveRbacPermissions
        // GraphQL -> allEffectiveRbacPermissions: [RbacPermission!]! (type)
        public static string AllEffectiveRbacPermissions(
            ref List<RbacPermission>? fieldSpec
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<RbacPermission>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allEffectiveRbacPermissions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AllEnabledFeaturesForAccountReply? AllEnabledFeaturesForAccount
        // GraphQL -> allEnabledFeaturesForAccount: AllEnabledFeaturesForAccountReply! (type)
        public static string AllEnabledFeaturesForAccount(
            ref AllEnabledFeaturesForAccountReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AllEnabledFeaturesForAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allEnabledFeaturesForAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<EventDigest>? AllEventDigests
        // GraphQL -> allEventDigests: [EventDigest!]! (type)
        public static string AllEventDigests(
            ref List<EventDigest>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<EventDigest>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allEventDigests" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<FailoverJobReport>? AllFailoverJobReports
        // GraphQL -> allFailoverJobReports: [FailoverJobReport!]! (type)
        public static string AllFailoverJobReports(
            ref List<FailoverJobReport>? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\nrecoveryJobID: $recoveryJobID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<FailoverJobReport>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFailoverJobReports" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpPermission>? AllFeaturePermissionsForGcpCloudAccount
        // GraphQL -> allFeaturePermissionsForGcpCloudAccount: [GcpPermission!]! (type)
        public static string AllFeaturePermissionsForGcpCloudAccount(
            ref List<GcpPermission>? fieldSpec
        )
        {
            string args = "\n(\nfeature: $feature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpPermission>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFeaturePermissionsForGcpCloudAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserActivityResultConnection? AllFileActivities
        // GraphQL -> allFileActivities: UserActivityResultConnection! (type)
        public static string AllFileActivities(
            ref UserActivityResultConnection? fieldSpec
        )
        {
            string args = "\n(\nListFileActivitiesInput: $ListFileActivitiesInput\nFileActivitiesSort: $FileActivitiesSort\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UserActivityResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allFileActivities" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountMissingPermissionsForAddition>? AllGcpCloudAccountMissingPermissionsForAddition
        // GraphQL -> allGcpCloudAccountMissingPermissionsForAddition: [GcpCloudAccountMissingPermissionsForAddition!]! (type)
        public static string AllGcpCloudAccountMissingPermissionsForAddition(
            ref List<GcpCloudAccountMissingPermissionsForAddition>? fieldSpec
        )
        {
            string args = "\n(\nsessionId: $sessionId\nprojectIds: $projectIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpCloudAccountMissingPermissionsForAddition>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountMissingPermissionsForAddition" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountProjectDetail>? AllGcpCloudAccountProjectsByFeature
        // GraphQL -> allGcpCloudAccountProjectsByFeature: [GcpCloudAccountProjectDetail!]! (type)
        public static string AllGcpCloudAccountProjectsByFeature(
            ref List<GcpCloudAccountProjectDetail>? fieldSpec
        )
        {
            string args = "\n(\nfeature: $feature\nprojectStatusFilters: $projectStatusFilters\nprojectSearchText: $projectSearchText\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpCloudAccountProjectDetail>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountProjectsByFeature" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpCloudAccountProjectForOauth>? AllGcpCloudAccountProjectsForOauth
        // GraphQL -> allGcpCloudAccountProjectsForOauth: [GcpCloudAccountProjectForOauth!]! (type)
        public static string AllGcpCloudAccountProjectsForOauth(
            ref List<GcpCloudAccountProjectForOauth>? fieldSpec
        )
        {
            string args = "\n(\nsessionId: $sessionId\nfeatures: $features\ncheckPermissions: $checkPermissions\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpCloudAccountProjectForOauth>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpCloudAccountProjectsForOauth" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeKmsCryptoKey>? AllGcpNativeAvailableKmsCryptoKeys
        // GraphQL -> allGcpNativeAvailableKmsCryptoKeys: [GcpNativeKmsCryptoKey!]! (type)
        public static string AllGcpNativeAvailableKmsCryptoKeys(
            ref List<GcpNativeKmsCryptoKey>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\nregionName: $regionName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpNativeKmsCryptoKey>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeAvailableKmsCryptoKeys" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeNetwork>? AllGcpNativeNetworks
        // GraphQL -> allGcpNativeNetworks: [GcpNativeNetwork!]! (type)
        public static string AllGcpNativeNetworks(
            ref List<GcpNativeNetwork>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpNativeNetwork>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NetworkHostProject>? AllGcpNativeProjectsWithAccessibleNetworks
        // GraphQL -> allGcpNativeProjectsWithAccessibleNetworks: [NetworkHostProject!]! (type)
        public static string AllGcpNativeProjectsWithAccessibleNetworks(
            ref List<NetworkHostProject>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<NetworkHostProject>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeProjectsWithAccessibleNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GcpNativeRegion>? AllGcpNativeRegions
        // GraphQL -> allGcpNativeRegions: [GcpNativeRegion!]! (type)
        public static string AllGcpNativeRegions(
            ref List<GcpNativeRegion>? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GcpNativeRegion>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGcpNativeRegions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalFileSearchReplyType? AllGlobalFileSearchMultipleClusters
        // GraphQL -> allGlobalFileSearchMultipleClusters: GlobalFileSearchReplyType! (type)
        public static string AllGlobalFileSearchMultipleClusters(
            ref GlobalFileSearchReplyType? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\nregex: $regex\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalFileSearchReplyType() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allGlobalFileSearchMultipleClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureRegionsResp? AllHostedAzureRegions
        // GraphQL -> allHostedAzureRegions: AzureRegionsResp! (type)
        public static string AllHostedAzureRegions(
            ref AzureRegionsResp? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureRegionsResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allHostedAzureRegions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListIntegrationsReply? AllIntegrations
        // GraphQL -> allIntegrations: ListIntegrationsReply! (type)
        public static string AllIntegrations(
            ref ListIntegrationsReply? fieldSpec
        )
        {
            string args = "\n(\nintegrationTypes: $integrationTypes\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListIntegrationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allIntegrations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<JiraIssueType>? AllJiraIssueTypes
        // GraphQL -> allJiraIssueTypes: [JiraIssueType!]! (type)
        public static string AllJiraIssueTypes(
            ref List<JiraIssueType>? fieldSpec
        )
        {
            string args = "\n(\njiraProjectId: $jiraProjectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<JiraIssueType>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allJiraIssueTypes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReplicatedSnapshotInfo>? AllK8sReplicaSnapshotInfos
        // GraphQL -> allK8sReplicaSnapshotInfos: [ReplicatedSnapshotInfo!]! (type)
        public static string AllK8sReplicaSnapshotInfos(
            ref List<ReplicatedSnapshotInfo>? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ReplicatedSnapshotInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allK8sReplicaSnapshotInfos" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<KmsEncryptionKey>? AllKmsEncryptionKeysByRegionFromAws
        // GraphQL -> allKmsEncryptionKeysByRegionFromAws: [KmsEncryptionKey!]! (type)
        public static string AllKmsEncryptionKeysByRegionFromAws(
            ref List<KmsEncryptionKey>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<KmsEncryptionKey>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allKmsEncryptionKeysByRegionFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<LatestConfigProtectionBackups>? AllLatestConfigProtectionBackupsByVersion
        // GraphQL -> allLatestConfigProtectionBackupsByVersion: [LatestConfigProtectionBackups!]! (type)
        public static string AllLatestConfigProtectionBackupsByVersion(
            ref List<LatestConfigProtectionBackups>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<LatestConfigProtectionBackups>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLatestConfigProtectionBackupsByVersion" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllLatestFeaturePermissionsForCloudAccounts
        // GraphQL -> allLatestFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllLatestFeaturePermissionsForCloudAccounts(
            ref List<CloudAccountFeaturePermission>? fieldSpec
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\nfeatures: $features\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<CloudAccountFeaturePermission>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLatestFeaturePermissionsForCloudAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetLicensedProductsInfoReply? AllLicensedProducts
        // GraphQL -> allLicensedProducts: GetLicensedProductsInfoReply! (type)
        public static string AllLicensedProducts(
            ref GetLicensedProductsInfoReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetLicensedProductsInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allLicensedProducts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<MigrationMetadata>? AllMigrationMetadata
        // GraphQL -> allMigrationMetadata: [MigrationMetadata!]! (type)
        public static string AllMigrationMetadata(
            ref List<MigrationMetadata>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<MigrationMetadata>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allMigrationMetadata" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Prechecks>? AllMigrationPrechecks
        // GraphQL -> allMigrationPrechecks: [Prechecks!]! (type)
        public static string AllMigrationPrechecks(
            ref List<Prechecks>? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Prechecks>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allMigrationPrechecks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> V1MssqlGetRestoreFilesV1Response? AllMssqlDatabaseRestoreFiles
        // GraphQL -> allMssqlDatabaseRestoreFiles: V1MssqlGetRestoreFilesV1Response! (type)
        public static string AllMssqlDatabaseRestoreFiles(
            ref V1MssqlGetRestoreFilesV1Response? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new V1MssqlGetRestoreFilesV1Response() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allMssqlDatabaseRestoreFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdObjectsOverTimeData>? AllNcdObjectsOverTimeData
        // GraphQL -> allNcdObjectsOverTimeData: [NcdObjectsOverTimeData!]! (type)
        public static string AllNcdObjectsOverTimeData(
            ref List<NcdObjectsOverTimeData>? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<NcdObjectsOverTimeData>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdObjectsOverTimeData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdSlaComplianceData>? AllNcdSlaComplianceData
        // GraphQL -> allNcdSlaComplianceData: [NcdSlaComplianceData!]! (type)
        public static string AllNcdSlaComplianceData(
            ref List<NcdSlaComplianceData>? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<NcdSlaComplianceData>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdSlaComplianceData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdTaskData>? AllNcdTaskData
        // GraphQL -> allNcdTaskData: [NcdTaskData!]! (type)
        public static string AllNcdTaskData(
            ref List<NcdTaskData>? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<NcdTaskData>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdTaskData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<NcdUsageOverTimeData>? AllNcdUsageOverTimeData
        // GraphQL -> allNcdUsageOverTimeData: [NcdUsageOverTimeData!]! (type)
        public static string AllNcdUsageOverTimeData(
            ref List<NcdUsageOverTimeData>? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<NcdUsageOverTimeData>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNcdUsageOverTimeData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<MosaicStorageLocation>? AllNosqlStorageLocations
        // GraphQL -> allNosqlStorageLocations: [MosaicStorageLocation!]! (type)
        public static string AllNosqlStorageLocations(
            ref List<MosaicStorageLocation>? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<MosaicStorageLocation>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allNosqlStorageLocations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AdGroup>? AllO365AdGroups
        // GraphQL -> allO365AdGroups: [AdGroup!]! (type)
        public static string AllO365AdGroups(
            ref List<AdGroup>? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\nadGroupSearchFilter: $adGroupSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AdGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365AdGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<O365OrgInfo>? AllO365OrgStatuses
        // GraphQL -> allO365OrgStatuses: [O365OrgInfo!]! (type)
        public static string AllO365OrgStatuses(
            ref List<O365OrgInfo>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<O365OrgInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365OrgStatuses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<O365SubscriptionAppTypeCounts>? AllO365SubscriptionsAppTypeCounts
        // GraphQL -> allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]! (type)
        public static string AllO365SubscriptionsAppTypeCounts(
            ref List<O365SubscriptionAppTypeCounts>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<O365SubscriptionAppTypeCounts>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allO365SubscriptionsAppTypeCounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ObjectIdsForHierarchyType>? AllObjectsAlreadyAssignedToOrgs
        // GraphQL -> allObjectsAlreadyAssignedToOrgs: [ObjectIdsForHierarchyType!]! (type)
        public static string AllObjectsAlreadyAssignedToOrgs(
            ref List<ObjectIdsForHierarchyType>? fieldSpec
        )
        {
            string args = "\n(\nobjectIdsForHierarchyTypes: $objectIdsForHierarchyTypes\nallowedClusters: $allowedClusters\ntargetOrgId: $targetOrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ObjectIdsForHierarchyType>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allObjectsAlreadyAssignedToOrgs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<OptionGroup>? AllOptionGroupsByRegionFromAws
        // GraphQL -> allOptionGroupsByRegionFromAws: [OptionGroup!]! (type)
        public static string AllOptionGroupsByRegionFromAws(
            ref List<OptionGroup>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nmajorEngineVersion: $majorEngineVersion\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<OptionGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allOptionGroupsByRegionFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Org>? AllOrgsByIds
        // GraphQL -> allOrgsByIds: [Org!]! (type)
        public static string AllOrgsByIds(
            ref List<Org>? fieldSpec
        )
        {
            string args = "\n(\norgIds: $orgIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Org>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allOrgsByIds" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PendingAction>? AllPendingActions
        // GraphQL -> allPendingActions: [pendingAction!]! (type)
        public static string AllPendingActions(
            ref List<PendingAction>? fieldSpec
        )
        {
            string args = "\n(\nclusterFilter: $clusterFilter\npendingActionGroupTypeFilter: $pendingActionGroupTypeFilter\npendingActionSubGroupTypeFilter: $pendingActionSubGroupTypeFilter\nstatusFilter: $statusFilter\nobjectIds: $objectIds\nsortedOrder: $sortedOrder\nhistoryOnly: $historyOnly\nlimit: $limit\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PendingAction>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPendingActions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolicyRiskSummary>? AllPolicyRiskSummaries
        // GraphQL -> allPolicyRiskSummaries: [PolicyRiskSummary!]! (type)
        public static string AllPolicyRiskSummaries(
            ref List<PolicyRiskSummary>? fieldSpec
        )
        {
            string args = "\n(\npolicyIds: $policyIds\nsummaryDate: $summaryDate\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PolicyRiskSummary>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPolicyRiskSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskSummaryReply? AllPrincipalRiskSummaries
        // GraphQL -> allPrincipalRiskSummaries: GetPrincipalRiskSummaryReply! (type)
        public static string AllPrincipalRiskSummaries(
            ref GetPrincipalRiskSummaryReply? fieldSpec
        )
        {
            string args = "\n(\nqueryDate: $queryDate\nhistoricalDeltaDays: $historicalDeltaDays\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetPrincipalRiskSummaryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allPrincipalRiskSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForSnapshots
        // GraphQL -> allQuarantinedDetailsForSnapshots: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForSnapshots(
            ref List<QuarantineSpec>? fieldSpec
        )
        {
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<QuarantineSpec>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allQuarantinedDetailsForSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForWorkload
        // GraphQL -> allQuarantinedDetailsForWorkload: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForWorkload(
            ref List<QuarantineSpec>? fieldSpec
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<QuarantineSpec>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allQuarantinedDetailsForWorkload" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReportConfig>? AllReportConfigs
        // GraphQL -> allReportConfigs: [ReportConfig!]! (type)
        public static string AllReportConfigs(
            ref List<ReportConfig>? fieldSpec
        )
        {
            string args = "\n(\ndataView: $dataView\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ReportConfig>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allReportConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ReportMetadata>? AllReportMetadata
        // GraphQL -> allReportMetadata: [ReportMetadata!]! (type)
        public static string AllReportMetadata(
            ref List<ReportMetadata>? fieldSpec
        )
        {
            string args = "\n(\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ReportMetadata>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allReportMetadata" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AzureResourceGroup>? AllResourceGroupsFromAzure
        // GraphQL -> allResourceGroupsFromAzure: [AzureResourceGroup!]! (type)
        public static string AllResourceGroupsFromAzure(
            ref List<AzureResourceGroup>? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nfeature: $feature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AzureResourceGroup>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allResourceGroupsFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolarisReportConfig>? AllRscReportConfigs
        // GraphQL -> allRscReportConfigs: [PolarisReportConfig!]! (type)
        public static string AllRscReportConfigs(
            ref List<PolarisReportConfig>? fieldSpec
        )
        {
            string args = "\n(\nreportView: $reportView\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PolarisReportConfig>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allRscReportConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<S3BucketDetails>? AllS3BucketsDetailsFromAws
        // GraphQL -> allS3BucketsDetailsFromAws: [S3BucketDetails!]! (type)
        public static string AllS3BucketsDetailsFromAws(
            ref List<S3BucketDetails>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<S3BucketDetails>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allS3BucketsDetailsFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<FullSpSiteExclusions>? AllSharepointSiteExclusions
        // GraphQL -> allSharepointSiteExclusions: [FullSpSiteExclusions!]! (type)
        public static string AllSharepointSiteExclusions(
            ref List<FullSpSiteExclusions>? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\nsiteFids: $siteFids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<FullSpSiteExclusions>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSharepointSiteExclusions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ComputeClusterIofilterStatus>? AllSlaIofilterStatuses
        // GraphQL -> allSlaIofilterStatuses: [ComputeClusterIofilterStatus!]! (type)
        public static string AllSlaIofilterStatuses(
            ref List<ComputeClusterIofilterStatus>? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ComputeClusterIofilterStatus>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSlaIofilterStatuses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PvcInformation>? AllSnapshotPvcs
        // GraphQL -> allSnapshotPvcs: [PvcInformation!]! (type)
        public static string AllSnapshotPvcs(
            ref List<PvcInformation>? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\nisReplica: $isReplica\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PvcInformation>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnapshotPvcs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ClosestSnapshotSearchResult>? AllSnapshotsClosestToPointInTime
        // GraphQL -> allSnapshotsClosestToPointInTime: [ClosestSnapshotSearchResult!]! (type)
        public static string AllSnapshotsClosestToPointInTime(
            ref List<ClosestSnapshotSearchResult>? fieldSpec
        )
        {
            string args = "\n(\nbeforeTime: $beforeTime\nafterTime: $afterTime\nsnappableIds: $snappableIds\nincludeLinked: $includeLinked\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\nexcludeQuarantined: $excludeQuarantined\nexcludeAnomalous: $excludeAnomalous\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ClosestSnapshotSearchResult>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSnapshotsClosestToPointInTime" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SourceRecoverySpecsReply>? AllSourceRecoverySpecs
        // GraphQL -> allSourceRecoverySpecs: [SourceRecoverySpecsReply!]! (type)
        public static string AllSourceRecoverySpecs(
            ref List<SourceRecoverySpecsReply>? fieldSpec
        )
        {
            string args = "\n(\nworkloadInfos: $workloadInfos\nsourceLocation: $sourceLocation\nblueprintId: $blueprintId\nplanType: $planType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SourceRecoverySpecsReply>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allSourceRecoverySpecs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AllStorageArraysReply? AllStorageArrays
        // GraphQL -> allStorageArrays: AllStorageArraysReply! (type)
        public static string AllStorageArrays(
            ref AllStorageArraysReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AllStorageArraysReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allStorageArrays" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<TargetMapping>? AllTargetMappings
        // GraphQL -> allTargetMappings: [TargetMapping!]! (type)
        public static string AllTargetMappings(
            ref List<TargetMapping>? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\nisRcsStatsRequired: $isRcsStatsRequired\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<TargetMapping>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTargetMappings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<PolicySummary>? AllTopRiskPolicySummaries
        // GraphQL -> allTopRiskPolicySummaries: [PolicySummary!]! (type)
        public static string AllTopRiskPolicySummaries(
            ref List<PolicySummary>? fieldSpec
        )
        {
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\nlimit: $limit\nworkloadTypes: $workloadTypes\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<PolicySummary>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allTopRiskPolicySummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UnifiedFeatureFlag>? AllUnifiedFeatureFlags
        // GraphQL -> allUnifiedFeatureFlags: [UnifiedFeatureFlag!]! (type)
        public static string AllUnifiedFeatureFlags(
            ref List<UnifiedFeatureFlag>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<UnifiedFeatureFlag>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUnifiedFeatureFlags" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<User>? AllUsersOnAccount
        // GraphQL -> allUsersOnAccount: [User!]! (type)
        public static string AllUsersOnAccount(
            ref List<User>? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<User>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUsersOnAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserConnection? AllUsersOnAccountConnection
        // GraphQL -> allUsersOnAccountConnection: UserConnection! (type)
        public static string AllUsersOnAccountConnection(
            ref UserConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nemailFilter: $emailFilter\nroleIdsFilter: $roleIdsFilter\nlockoutStateFilter: $lockoutStateFilter\nhiddenStateFilter: $hiddenStateFilter\nshouldGetLocalUsersOnly: $shouldGetLocalUsersOnly\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UserConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allUsersOnAccountConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidReplicationTargetConnection? AllValidReplicationTargets
        // GraphQL -> allValidReplicationTargets: ValidReplicationTargetConnection! (type)
        public static string AllValidReplicationTargets(
            ref ValidReplicationTargetConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidReplicationTargetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allValidReplicationTargets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VcenterHotAddProxyVmInfo>? AllVcenterHotAddProxyVms
        // GraphQL -> allVcenterHotAddProxyVms: [VcenterHotAddProxyVmInfo!]! (type)
        public static string AllVcenterHotAddProxyVms(
            ref List<VcenterHotAddProxyVmInfo>? fieldSpec
        )
        {
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<VcenterHotAddProxyVmInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVcenterHotAddProxyVms" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VirtualMachineFilesReply? AllVirtualMachineFiles
        // GraphQL -> allVirtualMachineFiles: VirtualMachineFilesReply! (type)
        public static string AllVirtualMachineFiles(
            ref VirtualMachineFilesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VirtualMachineFilesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVirtualMachineFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<ComputeClusterIofilterStatus>? AllVmIofilterStatuses
        // GraphQL -> allVmIofilterStatuses: [ComputeClusterIofilterStatus!]! (type)
        public static string AllVmIofilterStatuses(
            ref List<ComputeClusterIofilterStatus>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<ComputeClusterIofilterStatus>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVmIofilterStatuses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VmRecoveryJobInfo>? AllVmRecoveryJobsInfo
        // GraphQL -> allVmRecoveryJobsInfo: [VmRecoveryJobInfo!]! (type)
        public static string AllVmRecoveryJobsInfo(
            ref List<VmRecoveryJobInfo>? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<VmRecoveryJobInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVmRecoveryJobsInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VmwareCdpStateInfo>? AllVmwareCdpStateInfos
        // GraphQL -> allVmwareCdpStateInfos: [VmwareCdpStateInfo!]! (type)
        public static string AllVmwareCdpStateInfos(
            ref List<VmwareCdpStateInfo>? fieldSpec
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<VmwareCdpStateInfo>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVmwareCdpStateInfos" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsVpc>? AllVpcsByRegionFromAws
        // GraphQL -> allVpcsByRegionFromAws: [AwsVpc!]! (type)
        public static string AllVpcsByRegionFromAws(
            ref List<AwsVpc>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsVpc>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVpcsByRegionFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AwsVpc>? AllVpcsFromAws
        // GraphQL -> allVpcsFromAws: [AwsVpc!]! (type)
        public static string AllVpcsFromAws(
            ref List<AwsVpc>? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AwsVpc>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allVpcsFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WebhookConnection? AllWebhooks
        // GraphQL -> allWebhooks: WebhookConnection! (type)
        public static string AllWebhooks(
            ref WebhookConnection? fieldSpec
        )
        {
            string args = "\n(\nname: $name\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new WebhookConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "allWebhooks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AmiTypeForAwsNativeArchivedSnapshotExportReply? AmiTypeForAwsNativeArchivedSnapshotExport
        // GraphQL -> amiTypeForAwsNativeArchivedSnapshotExport: AmiTypeForAwsNativeArchivedSnapshotExportReply! (type)
        public static string AmiTypeForAwsNativeArchivedSnapshotExport(
            ref AmiTypeForAwsNativeArchivedSnapshotExportReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AmiTypeForAwsNativeArchivedSnapshotExportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "amiTypeForAwsNativeArchivedSnapshotExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerGroupConnection? AnalyzerGroups
        // GraphQL -> analyzerGroups: AnalyzerGroupConnection! (type)
        public static string AnalyzerGroups(
            ref AnalyzerGroupConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AnalyzerGroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "analyzerGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerUsageConnection? AnalyzerUsages
        // GraphQL -> analyzerUsages: AnalyzerUsageConnection! (type)
        public static string AnalyzerUsages(
            ref AnalyzerUsageConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AnalyzerUsageConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "analyzerUsages" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAnomalyDetailsReply? AnomalyResultOpt
        // GraphQL -> anomalyResultOpt: GetAnomalyDetailsReply (type)
        public static string AnomalyResultOpt(
            ref GetAnomalyDetailsReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nsnapshotId: $snapshotId\nworkloadId: $workloadId\nanomalyId: $anomalyId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetAnomalyDetailsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResultOpt" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        public static string AnomalyResults(
            ref AnomalyResultConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AnomalyResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResults" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnomalyResultGroupedDataConnection? AnomalyResultsGrouped
        // GraphQL -> anomalyResultsGrouped: AnomalyResultGroupedDataConnection! (type)
        public static string AnomalyResultsGrouped(
            ref AnomalyResultGroupedDataConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AnomalyResultGroupedDataConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "anomalyResultsGrouped" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AppflowsSummary? AppflowsSummary
        // GraphQL -> appflowsSummary: AppflowsSummary! (type)
        public static string AppflowsSummary(
            ref AppflowsSummary? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AppflowsSummary() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "appflowsSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ArchivalEntityConnection? ArchivalEntities
        // GraphQL -> archivalEntities: ArchivalEntityConnection! (type)
        public static string ArchivalEntities(
            ref ArchivalEntityConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ArchivalEntityConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "archivalEntities" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalCertificateConnection? AssignableGlobalCertificates
        // GraphQL -> assignableGlobalCertificates: GlobalCertificateConnection! (type)
        public static string AssignableGlobalCertificates(
            ref GlobalCertificateConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalCertificateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "assignableGlobalCertificates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AtlassianSiteConnection? AtlassianSites
        // GraphQL -> atlassianSites: AtlassianSiteConnection! (type)
        public static string AtlassianSites(
            ref AtlassianSiteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AtlassianSiteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "atlassianSites" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AttributedFeatureFlag? AttributedFeatureFlag
        // GraphQL -> attributedFeatureFlag: AttributedFeatureFlag! (type)
        public static string AttributedFeatureFlag(
            ref AttributedFeatureFlag? fieldSpec
        )
        {
            string args = "\n(\nkey: $key\nattributes: $attributes\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AttributedFeatureFlag() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "attributedFeatureFlag" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsArtifactsToDelete? AwsArtifactsToDelete
        // GraphQL -> awsArtifactsToDelete: AwsArtifactsToDelete! (type)
        public static string AwsArtifactsToDelete(
            ref AwsArtifactsToDelete? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsArtifactsToDelete() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsArtifactsToDelete" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListSecurityGroupsResponse? AwsCloudAccountListSecurityGroups
        // GraphQL -> awsCloudAccountListSecurityGroups: AwsCloudAccountListSecurityGroupsResponse! (type)
        public static string AwsCloudAccountListSecurityGroups(
            ref AwsCloudAccountListSecurityGroupsResponse? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsCloudAccountListSecurityGroupsResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListSecurityGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListSubnetsResponse? AwsCloudAccountListSubnets
        // GraphQL -> awsCloudAccountListSubnets: AwsCloudAccountListSubnetsResponse! (type)
        public static string AwsCloudAccountListSubnets(
            ref AwsCloudAccountListSubnetsResponse? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsCloudAccountListSubnetsResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListSubnets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountListVpcResponse? AwsCloudAccountListVpcs
        // GraphQL -> awsCloudAccountListVpcs: AwsCloudAccountListVpcResponse! (type)
        public static string AwsCloudAccountListVpcs(
            ref AwsCloudAccountListVpcResponse? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsCloudAccountListVpcResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountListVpcs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsCloudAccountWithFeatures? AwsCloudAccountWithFeatures
        // GraphQL -> awsCloudAccountWithFeatures: AwsCloudAccountWithFeatures! (type)
        public static string AwsCloudAccountWithFeatures(
            ref AwsCloudAccountWithFeatures? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nawsCloudAccountArg: $awsCloudAccountArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsCloudAccountWithFeatures() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsCloudAccountWithFeatures" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsComputeSettings? AwsComputeSettings
        // GraphQL -> awsComputeSettings: AwsComputeSettings! (type)
        public static string AwsComputeSettings(
            ref AwsComputeSettings? fieldSpec
        )
        {
            string args = "\n(\ncomputeSettingId: $computeSettingId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsComputeSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsComputeSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        public static string AwsNativeAccount(
            ref AwsNativeAccount? fieldSpec
        )
        {
            string args = "\n(\nawsNativeAccountRubrikId: $awsNativeAccountRubrikId\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeAccount() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeAccountConnection? AwsNativeAccounts
        // GraphQL -> awsNativeAccounts: AwsNativeAccountConnection! (type)
        public static string AwsNativeAccounts(
            ref AwsNativeAccountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\naccountFilters: $accountFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeAccountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolume? AwsNativeEbsVolume
        // GraphQL -> awsNativeEbsVolume: AwsNativeEbsVolume! (type)
        public static string AwsNativeEbsVolume(
            ref AwsNativeEbsVolume? fieldSpec
        )
        {
            string args = "\n(\nebsVolumeRubrikId: $ebsVolumeRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEbsVolume() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolume" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumes(
            ref AwsNativeEbsVolumeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeFilters: $ebsVolumeFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEbsVolumeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolumes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumesByName
        // GraphQL -> awsNativeEbsVolumesByName: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumesByName(
            ref AwsNativeEbsVolumeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeName: $ebsVolumeName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEbsVolumeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEbsVolumesByName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2Instance? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsNativeEc2Instance! (type)
        public static string AwsNativeEc2Instance(
            ref AwsNativeEc2Instance? fieldSpec
        )
        {
            string args = "\n(\nec2InstanceRubrikId: $ec2InstanceRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEc2Instance() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2Instance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2Instances(
            ref AwsNativeEc2InstanceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nec2InstanceFilters: $ec2InstanceFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEc2InstanceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2Instances" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2InstancesByName
        // GraphQL -> awsNativeEc2InstancesByName: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2InstancesByName(
            ref AwsNativeEc2InstanceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nec2InstanceName: $ec2InstanceName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeEc2InstanceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeEc2InstancesByName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RdsInstanceExportDefaults? AwsNativeRdsExportDefaults
        // GraphQL -> awsNativeRdsExportDefaults: RdsInstanceExportDefaults! (type)
        public static string AwsNativeRdsExportDefaults(
            ref RdsInstanceExportDefaults? fieldSpec
        )
        {
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\nsnapshotId: $snapshotId\nisPointInTime: $isPointInTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RdsInstanceExportDefaults() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsExportDefaults" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsInstance? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsNativeRdsInstance! (type)
        public static string AwsNativeRdsInstance(
            ref AwsNativeRdsInstance? fieldSpec
        )
        {
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeRdsInstance() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsInstance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        public static string AwsNativeRdsInstances(
            ref AwsNativeRdsInstanceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nrdsInstanceFilters: $rdsInstanceFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeRdsInstanceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsInstances" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRdsPointInTimeRestoreWindow? AwsNativeRdsPointInTimeRestoreWindow
        // GraphQL -> awsNativeRdsPointInTimeRestoreWindow: AwsNativeRdsPointInTimeRestoreWindow! (type)
        public static string AwsNativeRdsPointInTimeRestoreWindow(
            ref AwsNativeRdsPointInTimeRestoreWindow? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeRdsPointInTimeRestoreWindow() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRdsPointInTimeRestoreWindow" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeRoot? AwsNativeRoot
        // GraphQL -> awsNativeRoot: AwsNativeRoot! (type)
        public static string AwsNativeRoot(
            ref AwsNativeRoot? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsNativeS3Bucket? AwsNativeS3Bucket
        // GraphQL -> awsNativeS3Bucket: AwsNativeS3Bucket! (type)
        public static string AwsNativeS3Bucket(
            ref AwsNativeS3Bucket? fieldSpec
        )
        {
            string args = "\n(\ns3BucketRubrikId: $s3BucketRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsNativeS3Bucket() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsNativeS3Bucket" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AwsTrustPolicy? AwsTrustPolicy
        // GraphQL -> awsTrustPolicy: AwsTrustPolicy! (type)
        public static string AwsTrustPolicy(
            ref AwsTrustPolicy? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AwsTrustPolicy() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "awsTrustPolicy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureAdDirectoryConnection? AzureAdDirectories
        // GraphQL -> azureAdDirectories: AzureAdDirectoryConnection! (type)
        public static string AzureAdDirectories(
            ref AzureAdDirectoryConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureAdDirectoryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureAdDirectories" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureAdDirectory? AzureAdDirectory
        // GraphQL -> azureAdDirectory: AzureAdDirectory! (type)
        public static string AzureAdDirectory(
            ref AzureAdDirectory? fieldSpec
        )
        {
            string args = "\n(\nworkloadFid: $workloadFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureAdDirectory() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureAdDirectory" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureAdObjectConnection? AzureAdObjectsByType
        // GraphQL -> azureAdObjectsByType: AzureAdObjectConnection! (type)
        public static string AzureAdObjectsByType(
            ref AzureAdObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortByOption: $sortByOption\nsortOrder: $sortOrder\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureAdObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureAdObjectsByType" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountCheckRefreshTokenExistsReply? AzureCloudAccountCheckRefreshTokenExistsForRecovery
        // GraphQL -> azureCloudAccountCheckRefreshTokenExistsForRecovery: AzureCloudAccountCheckRefreshTokenExistsReply! (type)
        public static string AzureCloudAccountCheckRefreshTokenExistsForRecovery(
            ref AzureCloudAccountCheckRefreshTokenExistsReply? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureNativeSubscriptionId: $azureNativeSubscriptionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountCheckRefreshTokenExistsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountCheckRefreshTokenExistsForRecovery" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountGrantedPermissionsGroupsReply? AzureCloudAccountGrantedPermissionsGroups
        // GraphQL -> azureCloudAccountGrantedPermissionsGroups: AzureCloudAccountGrantedPermissionsGroupsReply! (type)
        public static string AzureCloudAccountGrantedPermissionsGroups(
            ref AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nfeature: $feature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountGrantedPermissionsGroupsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountGrantedPermissionsGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountGrantedPermissionsGroupsReply? AzureCloudAccountGrantedPermissionsGroupsForRecovery
        // GraphQL -> azureCloudAccountGrantedPermissionsGroupsForRecovery: AzureCloudAccountGrantedPermissionsGroupsReply! (type)
        public static string AzureCloudAccountGrantedPermissionsGroupsForRecovery(
            ref AzureCloudAccountGrantedPermissionsGroupsReply? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureNativeSubscriptionId: $azureNativeSubscriptionId\nfeature: $feature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountGrantedPermissionsGroupsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountGrantedPermissionsGroupsForRecovery" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountPermissionConfigResponse? AzureCloudAccountPermissionConfig
        // GraphQL -> azureCloudAccountPermissionConfig: AzureCloudAccountPermissionConfigResponse! (type)
        public static string AzureCloudAccountPermissionConfig(
            ref AzureCloudAccountPermissionConfigResponse? fieldSpec
        )
        {
            string args = "\n(\nfeature: $feature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountPermissionConfigResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountPermissionConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountSubscriptionWithFeatures? AzureCloudAccountSubscriptionWithFeatures
        // GraphQL -> azureCloudAccountSubscriptionWithFeatures: AzureCloudAccountSubscriptionWithFeatures! (type)
        public static string AzureCloudAccountSubscriptionWithFeatures(
            ref AzureCloudAccountSubscriptionWithFeatures? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountSubscriptionWithFeatures() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountSubscriptionWithFeatures" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountTenant? AzureCloudAccountTenant
        // GraphQL -> azureCloudAccountTenant: AzureCloudAccountTenant! (type)
        public static string AzureCloudAccountTenant(
            ref AzureCloudAccountTenant? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountTenant() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountTenant" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureCloudAccountTenantWithExoConfigs? AzureCloudAccountTenantWithExoConfigs
        // GraphQL -> azureCloudAccountTenantWithExoConfigs: AzureCloudAccountTenantWithExoConfigs! (type)
        public static string AzureCloudAccountTenantWithExoConfigs(
            ref AzureCloudAccountTenantWithExoConfigs? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureCloudAccountTenantWithExoConfigs() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureCloudAccountTenantWithExoConfigs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LiveMountDetailsConnection? AzureNativeLiveMountDisks
        // GraphQL -> azureNativeLiveMountDisks: LiveMountDetailsConnection! (type)
        public static string AzureNativeLiveMountDisks(
            ref LiveMountDetailsConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ncloudNativeObjectType: $cloudNativeObjectType\nliveMountFilters: $liveMountFilters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LiveMountDetailsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeLiveMountDisks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeManagedDisk? AzureNativeManagedDisk
        // GraphQL -> azureNativeManagedDisk: AzureNativeManagedDisk! (type)
        public static string AzureNativeManagedDisk(
            ref AzureNativeManagedDisk? fieldSpec
        )
        {
            string args = "\n(\nazureManagedDiskRubrikId: $azureManagedDiskRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeManagedDisk() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeManagedDisk" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeManagedDiskConnection? AzureNativeManagedDisks
        // GraphQL -> azureNativeManagedDisks: AzureNativeManagedDiskConnection! (type)
        public static string AzureNativeManagedDisks(
            ref AzureNativeManagedDiskConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeManagedDiskConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeManagedDisks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        public static string AzureNativeResourceGroup(
            ref AzureNativeResourceGroup? fieldSpec
        )
        {
            string args = "\n(\nresourceGroupId: $resourceGroupId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeResourceGroup() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeResourceGroup" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        public static string AzureNativeResourceGroups(
            ref AzureNativeResourceGroupConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ncommonResourceGroupFilters: $commonResourceGroupFilters\nprotectedObjectTypes: $protectedObjectTypes\nazureNativeProtectionFeatures: $azureNativeProtectionFeatures\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeResourceGroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeResourceGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeRoot? AzureNativeRoot
        // GraphQL -> azureNativeRoot: AzureNativeRoot! (type)
        public static string AzureNativeRoot(
            ref AzureNativeRoot? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSubscription? AzureNativeSubscription
        // GraphQL -> azureNativeSubscription: AzureNativeSubscription! (type)
        public static string AzureNativeSubscription(
            ref AzureNativeSubscription? fieldSpec
        )
        {
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeSubscription() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeSubscription" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSubscriptionConnection? AzureNativeSubscriptions
        // GraphQL -> azureNativeSubscriptions: AzureNativeSubscriptionConnection! (type)
        public static string AzureNativeSubscriptions(
            ref AzureNativeSubscriptionConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nsubscriptionFilters: $subscriptionFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\nazureNativeProtectionFeature: $azureNativeProtectionFeature\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeSubscriptionConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeSubscriptions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeVirtualMachine? AzureNativeVirtualMachine
        // GraphQL -> azureNativeVirtualMachine: AzureNativeVirtualMachine! (type)
        public static string AzureNativeVirtualMachine(
            ref AzureNativeVirtualMachine? fieldSpec
        )
        {
            string args = "\n(\nazureVirtualMachineRubrikId: $azureVirtualMachineRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeVirtualMachine() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeVirtualMachine" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        public static string AzureNativeVirtualMachines(
            ref AzureNativeVirtualMachineConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nvirtualMachineFilters: $virtualMachineFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeVirtualMachineConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureNativeVirtualMachines" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSecurityGroupResp? AzureO365CheckNsgOutboundRules
        // GraphQL -> azureO365CheckNSGOutboundRules: AzureNetworkSecurityGroupResp! (type)
        public static string AzureO365CheckNsgOutboundRules(
            ref AzureNetworkSecurityGroupResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNetworkSecurityGroupResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckNSGOutboundRules" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSubnetResp? AzureO365CheckNetworkSubnet
        // GraphQL -> azureO365CheckNetworkSubnet: AzureNetworkSubnetResp! (type)
        public static string AzureO365CheckNetworkSubnet(
            ref AzureNetworkSubnetResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNetworkSubnetResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckNetworkSubnet" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckResourceGroupName
        // GraphQL -> azureO365CheckResourceGroupName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckResourceGroupName(
            ref AzureResourceAvailabilityResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureResourceAvailabilityResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckResourceGroupName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountAccessibility
        // GraphQL -> azureO365CheckStorageAccountAccessibility: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountAccessibility(
            ref AzureResourceAvailabilityResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\ngroupName: $groupName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureResourceAvailabilityResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckStorageAccountAccessibility" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountName
        // GraphQL -> azureO365CheckStorageAccountName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountName(
            ref AzureResourceAvailabilityResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureResourceAvailabilityResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckStorageAccountName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckSubscriptionQuota
        // GraphQL -> azureO365CheckSubscriptionQuota: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckSubscriptionQuota(
            ref AzureResourceAvailabilityResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureResourceAvailabilityResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckSubscriptionQuota" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckVirtualNetworkName
        // GraphQL -> azureO365CheckVirtualNetworkName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckVirtualNetworkName(
            ref AzureResourceAvailabilityResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\nvnet_name: $vnet_name\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureResourceAvailabilityResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365CheckVirtualNetworkName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAzureO365ExocomputeResp? AzureO365Exocompute
        // GraphQL -> azureO365Exocompute: GetAzureO365ExocomputeResp! (type)
        public static string AzureO365Exocompute(
            ref GetAzureO365ExocomputeResp? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\nexocomputeClusterId: $exocomputeClusterId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetAzureO365ExocomputeResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365Exocompute" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetAzureHostTypeResp? AzureO365GetAzureHostType
        // GraphQL -> azureO365GetAzureHostType: GetAzureHostTypeResp! (type)
        public static string AzureO365GetAzureHostType(
            ref GetAzureHostTypeResp? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetAzureHostTypeResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365GetAzureHostType" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNetworkSubnetUnusedAddrResp? AzureO365GetNetworkSubnetUnusedAddr
        // GraphQL -> azureO365GetNetworkSubnetUnusedAddr: AzureNetworkSubnetUnusedAddrResp! (type)
        public static string AzureO365GetNetworkSubnetUnusedAddr(
            ref AzureNetworkSubnetUnusedAddrResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNetworkSubnetUnusedAddrResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365GetNetworkSubnetUnusedAddr" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureUserRoleResp? AzureO365ValidateUserRoles
        // GraphQL -> azureO365ValidateUserRoles: AzureUserRoleResp! (type)
        public static string AzureO365ValidateUserRoles(
            ref AzureUserRoleResp? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureUserRoleResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureO365ValidateUserRoles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RegionConnection? AzureRegions
        // GraphQL -> azureRegions: RegionConnection! (type)
        public static string AzureRegions(
            ref RegionConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RegionConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureRegions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ResourceGroupConnection? AzureResourceGroups
        // GraphQL -> azureResourceGroups: ResourceGroupConnection! (type)
        public static string AzureResourceGroups(
            ref ResourceGroupConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ResourceGroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureResourceGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseDb? AzureSqlDatabase
        // GraphQL -> azureSqlDatabase: AzureSqlDatabaseDb! (type)
        public static string AzureSqlDatabase(
            ref AzureSqlDatabaseDb? fieldSpec
        )
        {
            string args = "\n(\nazureSqlDatabaseRubrikId: $azureSqlDatabaseRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlDatabaseDb() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
            ref AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpec
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        public static string AzureSqlDatabaseServer(
            ref AzureSqlDatabaseServer? fieldSpec
        )
        {
            string args = "\n(\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlDatabaseServer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseServer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseServerConnection? AzureSqlDatabaseServers
        // GraphQL -> azureSqlDatabaseServers: AzureSqlDatabaseServerConnection! (type)
        public static string AzureSqlDatabaseServers(
            ref AzureSqlDatabaseServerConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseServerFilters: $azureSqlDatabaseServerFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlDatabaseServerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabaseServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlDatabaseDbConnection? AzureSqlDatabases
        // GraphQL -> azureSqlDatabases: AzureSqlDatabaseDbConnection! (type)
        public static string AzureSqlDatabases(
            ref AzureSqlDatabaseDbConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseFilters: $azureSqlDatabaseFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlDatabaseDbConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceDatabase? AzureSqlManagedInstanceDatabase
        // GraphQL -> azureSqlManagedInstanceDatabase: AzureSqlManagedInstanceDatabase! (type)
        public static string AzureSqlManagedInstanceDatabase(
            ref AzureSqlManagedInstanceDatabase? fieldSpec
        )
        {
            string args = "\n(\nazureSqlManagedInstanceDatabaseRubrikId: $azureSqlManagedInstanceDatabaseRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlManagedInstanceDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceDatabaseConnection? AzureSqlManagedInstanceDatabases
        // GraphQL -> azureSqlManagedInstanceDatabases: AzureSqlManagedInstanceDatabaseConnection! (type)
        public static string AzureSqlManagedInstanceDatabases(
            ref AzureSqlManagedInstanceDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceDatabaseFilters: $azureSqlManagedInstanceDatabaseFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlManagedInstanceDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
            ref AzureNativeSqlDatabasePointInTimeRestoreWindow? fieldSpec
        )
        {
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlManagedInstanceName: $azureSqlManagedInstanceName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceServer? AzureSqlManagedInstanceServer
        // GraphQL -> azureSqlManagedInstanceServer: AzureSqlManagedInstanceServer! (type)
        public static string AzureSqlManagedInstanceServer(
            ref AzureSqlManagedInstanceServer? fieldSpec
        )
        {
            string args = "\n(\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlManagedInstanceServer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceServer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSqlManagedInstanceServerConnection? AzureSqlManagedInstanceServers
        // GraphQL -> azureSqlManagedInstanceServers: AzureSqlManagedInstanceServerConnection! (type)
        public static string AzureSqlManagedInstanceServers(
            ref AzureSqlManagedInstanceServerConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceServerFilters: $azureSqlManagedInstanceServerFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSqlManagedInstanceServerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSqlManagedInstanceServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> StorageAccountConnection? AzureStorageAccounts
        // GraphQL -> azureStorageAccounts: StorageAccountConnection! (type)
        public static string AzureStorageAccounts(
            ref StorageAccountConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new StorageAccountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureStorageAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SubnetConnection? AzureSubnets
        // GraphQL -> azureSubnets: SubnetConnection! (type)
        public static string AzureSubnets(
            ref SubnetConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nvNetId: $vNetId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SubnetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSubnets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AzureSubscriptionConnection? AzureSubscriptions
        // GraphQL -> azureSubscriptions: AzureSubscriptionConnection! (type)
        public static string AzureSubscriptions(
            ref AzureSubscriptionConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AzureSubscriptionConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureSubscriptions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VnetConnection? AzureVnets
        // GraphQL -> azureVNets: VnetConnection! (type)
        public static string AzureVnets(
            ref VnetConnection? fieldSpec
        )
        {
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VnetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "azureVNets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintConnection? BlueprintConnection
        // GraphQL -> blueprintConnection: BlueprintConnection! (type)
        public static string BlueprintConnection(
            ref BlueprintConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BlueprintConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "blueprintConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BlueprintRecoverySpecs? BlueprintRecoverySpecs
        // GraphQL -> blueprintRecoverySpecs: BlueprintRecoverySpecs! (type)
        public static string BlueprintRecoverySpecs(
            ref BlueprintRecoverySpecs? fieldSpec
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\nignoreErrors: $ignoreErrors\nvalidate: $validate\ngetInvalidSpecs: $getInvalidSpecs\nsnappableInfos: $snappableInfos\nfailoverId: $failoverId\nresourceSpecType: $resourceSpecType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BlueprintRecoverySpecs() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "blueprintRecoverySpecs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseCalendar
        // GraphQL -> browseCalendar: O365ExchangeObjectConnection! (type)
        public static string BrowseCalendar(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseCalendar" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseContacts
        // GraphQL -> browseContacts: O365ExchangeObjectConnection! (type)
        public static string BrowseContacts(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseContacts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? BrowseFolder
        // GraphQL -> browseFolder: O365ExchangeObjectConnection! (type)
        public static string BrowseFolder(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseFolder" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamConvChannelConnection? BrowseO365TeamConvChannels
        // GraphQL -> browseO365TeamConvChannels: O365TeamConvChannelConnection! (type)
        public static string BrowseO365TeamConvChannels(
            ref O365TeamConvChannelConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFidOpt: $snapshotFidOpt\nexcludeArchived: $excludeArchived\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamConvChannelConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseO365TeamConvChannels" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseOnedrive
        // GraphQL -> browseOnedrive: O365OnedriveObjectConnection! (type)
        public static string BrowseOnedrive(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nonedriveSearchFilter: $onedriveSearchFilter\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseOnedrive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointDrive
        // GraphQL -> browseSharepointDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointDrive(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSharepointDrive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointList
        // GraphQL -> browseSharepointList: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointList(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSharepointList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileConnection? BrowseSnapshotFileConnection
        // GraphQL -> browseSnapshotFileConnection: SnapshotFileConnection! (type)
        public static string BrowseSnapshotFileConnection(
            ref SnapshotFileConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotFileConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseSnapshotFileConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsChannelConnection? BrowseTeamsChannels
        // GraphQL -> browseTeamsChannels: O365TeamsChannelConnection! (type)
        public static string BrowseTeamsChannels(
            ref O365TeamsChannelConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamsChannelConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseTeamsChannels" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? BrowseTeamsDrive
        // GraphQL -> browseTeamsDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseTeamsDrive(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nteamsDriveSearchFilter: $teamsDriveSearchFilter\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "browseTeamsDrive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BulkRecoveryProgressReply? BulkRecoveryProgress
        // GraphQL -> bulkRecoveryProgress: BulkRecoveryProgressReply! (type)
        public static string BulkRecoveryProgress(
            ref BulkRecoveryProgressReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BulkRecoveryProgressReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "bulkRecoveryProgress" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraColumnFamilyConnection? CassandraColumnFamilies
        // GraphQL -> cassandraColumnFamilies: CassandraColumnFamilyConnection! (type)
        public static string CassandraColumnFamilies(
            ref CassandraColumnFamilyConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraColumnFamilyConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilies" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraColumnFamily? CassandraColumnFamily
        // GraphQL -> cassandraColumnFamily: CassandraColumnFamily! (type)
        public static string CassandraColumnFamily(
            ref CassandraColumnFamily? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraColumnFamily() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamily" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMosaicRecoverableRangeResponse? CassandraColumnFamilyRecoverableRange
        // GraphQL -> cassandraColumnFamilyRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string CassandraColumnFamilyRecoverableRange(
            ref GetMosaicRecoverableRangeResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetMosaicRecoverableRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilyRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSchemaResponse? CassandraColumnFamilySchema
        // GraphQL -> cassandraColumnFamilySchema: GetSchemaResponse! (type)
        public static string CassandraColumnFamilySchema(
            ref GetSchemaResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetSchemaResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraColumnFamilySchema" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraKeyspace? CassandraKeyspace
        // GraphQL -> cassandraKeyspace: CassandraKeyspace! (type)
        public static string CassandraKeyspace(
            ref CassandraKeyspace? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraKeyspace() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraKeyspace" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraKeyspaceConnection? CassandraKeyspaces
        // GraphQL -> cassandraKeyspaces: CassandraKeyspaceConnection! (type)
        public static string CassandraKeyspaces(
            ref CassandraKeyspaceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraKeyspaceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraKeyspaces" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraSource? CassandraSource
        // GraphQL -> cassandraSource: CassandraSource! (type)
        public static string CassandraSource(
            ref CassandraSource? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraSource() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraSource" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CassandraSourceConnection? CassandraSources
        // GraphQL -> cassandraSources: CassandraSourceConnection! (type)
        public static string CassandraSources(
            ref CassandraSourceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CassandraSourceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cassandraSources" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmInventorySubHierarchyRoot? CdmInventorySubHierarchyRoot
        // GraphQL -> cdmInventorySubHierarchyRoot: CdmInventorySubHierarchyRoot! (type)
        public static string CdmInventorySubHierarchyRoot(
            ref CdmInventorySubHierarchyRoot? fieldSpec
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmInventorySubHierarchyRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmInventorySubHierarchyRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingTarget? CdmMssqlLogShippingTarget
        // GraphQL -> cdmMssqlLogShippingTarget: MssqlLogShippingTarget (type)
        public static string CdmMssqlLogShippingTarget(
            ref MssqlLogShippingTarget? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlLogShippingTarget() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmMssqlLogShippingTarget" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingTargetConnection? CdmMssqlLogShippingTargets
        // GraphQL -> cdmMssqlLogShippingTargets: MssqlLogShippingTargetConnection! (type)
        public static string CdmMssqlLogShippingTargets(
            ref MssqlLogShippingTargetConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlLogShippingTargetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmMssqlLogShippingTargets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureCdmVersionReply? CdmVersionCheck
        // GraphQL -> cdmVersionCheck: FeatureCdmVersionReply! (type)
        public static string CdmVersionCheck(
            ref FeatureCdmVersionReply? fieldSpec
        )
        {
            string args = "\n(\nfeatureToCdmVersion: $featureToCdmVersion\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FeatureCdmVersionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cdmVersionCheck" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCertificateInfoReply? CertificateInfo
        // GraphQL -> certificateInfo: GetCertificateInfoReply! (type)
        public static string CertificateInfo(
            ref GetCertificateInfoReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetCertificateInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Csr? CertificateSigningRequest
        // GraphQL -> certificateSigningRequest: Csr! (type)
        public static string CertificateSigningRequest(
            ref Csr? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Csr() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateSigningRequest" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CsrConnection? CertificateSigningRequests
        // GraphQL -> certificateSigningRequests: CsrConnection! (type)
        public static string CertificateSigningRequests(
            ref CsrConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CsrConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificateSigningRequests" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateConnection? Certificates
        // GraphQL -> certificates: CertificateConnection! (type)
        public static string Certificates(
            ref CertificateConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CertificateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateConnection? CertificatesWithKey
        // GraphQL -> certificatesWithKey: CertificateConnection! (type)
        public static string CertificatesWithKey(
            ref CertificateConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new CertificateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "certificatesWithKey" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckAzurePersistentStorageSubscriptionCanUnmapReply? CheckAzurePersistentStorageSubscriptionCanUnmap
        // GraphQL -> checkAzurePersistentStorageSubscriptionCanUnmap: CheckAzurePersistentStorageSubscriptionCanUnmapReply! (type)
        public static string CheckAzurePersistentStorageSubscriptionCanUnmap(
            ref CheckAzurePersistentStorageSubscriptionCanUnmapReply? fieldSpec
        )
        {
            string args = "\n(\ncloudAccountId: $cloudAccountId\nfeature: $feature\nunmappingValidationType: $unmappingValidationType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CheckAzurePersistentStorageSubscriptionCanUnmapReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkAzurePersistentStorageSubscriptionCanUnmap" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? CheckCloudComputeConnectivityJobProgress
        // GraphQL -> checkCloudComputeConnectivityJobProgress: AsyncRequestStatus! (type)
        public static string CheckCloudComputeConnectivityJobProgress(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudComputeConnectivityJobProgress" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeLabelRuleNameUniqueness
        // GraphQL -> checkCloudNativeLabelRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeLabelRuleNameUniqueness(
            ref IsCloudNativeTagRuleNameUniqueReply? fieldSpec
        )
        {
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new IsCloudNativeTagRuleNameUniqueReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudNativeLabelRuleNameUniqueness" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeTagRuleNameUniqueness
        // GraphQL -> checkCloudNativeTagRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeTagRuleNameUniqueness(
            ref IsCloudNativeTagRuleNameUniqueReply? fieldSpec
        )
        {
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new IsCloudNativeTagRuleNameUniqueReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkCloudNativeTagRuleNameUniqueness" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckGuestOsReply? CheckGuestOsForAppBlueprint
        // GraphQL -> checkGuestOsForAppBlueprint: CheckGuestOsReply! (type)
        public static string CheckGuestOsForAppBlueprint(
            ref CheckGuestOsReply? fieldSpec
        )
        {
            string args = "\n(\nblueprintId: $blueprintId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CheckGuestOsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "checkGuestOsForAppBlueprint" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationBannerSettings? ClassificationBannerSettings
        // GraphQL -> classificationBannerSettings: ClassificationBannerSettings! (type)
        public static string ClassificationBannerSettings(
            ref ClassificationBannerSettings? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ClassificationBannerSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "classificationBannerSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationLoginSettings? ClassificationLoginSettings
        // GraphQL -> classificationLoginSettings: ClassificationLoginSettings! (type)
        public static string ClassificationLoginSettings(
            ref ClassificationLoginSettings? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ClassificationLoginSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "classificationLoginSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectNasExport? CloudDirectNasExport
        // GraphQL -> cloudDirectNasExport: CloudDirectNasExport! (type)
        public static string CloudDirectNasExport(
            ref CloudDirectNasExport? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudDirectNasExport() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectNasExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSnapshot? CloudDirectSnapshot
        // GraphQL -> cloudDirectSnapshot: CloudDirectSnapshot! (type)
        public static string CloudDirectSnapshot(
            ref CloudDirectSnapshot? fieldSpec
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudDirectSnapshot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSnapshotConnection? CloudDirectSnapshots
        // GraphQL -> cloudDirectSnapshots: CloudDirectSnapshotConnection! (type)
        public static string CloudDirectSnapshots(
            ref CloudDirectSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudDirectSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudDirectSystems? CloudDirectSystems
        // GraphQL -> cloudDirectSystems: CloudDirectSystems! (type)
        public static string CloudDirectSystems(
            ref CloudDirectSystems? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudDirectSystems() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudDirectSystems" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckArchivedSnapshotsLockedReply? CloudNativeCheckArchivedSnapshotsLocked
        // GraphQL -> cloudNativeCheckArchivedSnapshotsLocked: CheckArchivedSnapshotsLockedReply! (type)
        public static string CloudNativeCheckArchivedSnapshotsLocked(
            ref CheckArchivedSnapshotsLockedReply? fieldSpec
        )
        {
            string args = "\n(\nworkloadId: $workloadId\nsnapshotIds: $snapshotIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CheckArchivedSnapshotsLockedReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeCheckArchivedSnapshotsLocked" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeCustomerTagsReply? CloudNativeCustomerTags
        // GraphQL -> cloudNativeCustomerTags: CloudNativeCustomerTagsReply! (type)
        public static string CloudNativeCustomerTags(
            ref CloudNativeCustomerTagsReply? fieldSpec
        )
        {
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountId: $cloudAccountId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudNativeCustomerTagsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeCustomerTags" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCloudNativeLabelRulesReply? CloudNativeLabelRules
        // GraphQL -> cloudNativeLabelRules: GetCloudNativeLabelRulesReply! (type)
        public static string CloudNativeLabelRules(
            ref GetCloudNativeLabelRulesReply? fieldSpec
        )
        {
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetCloudNativeLabelRulesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeLabelRules" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RbaInstallerUrls? CloudNativeRbaInstallers
        // GraphQL -> cloudNativeRbaInstallers: RbaInstallerUrls! (type)
        public static string CloudNativeRbaInstallers(
            ref RbaInstallerUrls? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new RbaInstallerUrls() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeRbaInstallers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeSnapshotDetailsForRecoveryReply? CloudNativeSnapshotDetailsForRecovery
        // GraphQL -> cloudNativeSnapshotDetailsForRecovery: CloudNativeSnapshotDetailsForRecoveryReply! (type)
        public static string CloudNativeSnapshotDetailsForRecovery(
            ref CloudNativeSnapshotDetailsForRecoveryReply? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudNativeSnapshotDetailsForRecoveryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSnapshotDetailsForRecovery" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileConnection? CloudNativeSnapshots
        // GraphQL -> cloudNativeSnapshots: SnapshotFileConnection! (type)
        public static string CloudNativeSnapshots(
            ref SnapshotFileConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotFileConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeSqlServerSetupScript? CloudNativeSqlServerSetupScript
        // GraphQL -> cloudNativeSqlServerSetupScript: CloudNativeSqlServerSetupScript! (type)
        public static string CloudNativeSqlServerSetupScript(
            ref CloudNativeSqlServerSetupScript? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudNativeSqlServerSetupScript() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeSqlServerSetupScript" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetCloudNativeTagRulesReply? CloudNativeTagRules
        // GraphQL -> cloudNativeTagRules: GetCloudNativeTagRulesReply! (type)
        public static string CloudNativeTagRules(
            ref GetCloudNativeTagRulesReply? fieldSpec
        )
        {
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetCloudNativeTagRulesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeTagRules" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CloudNativeVersionedFileConnection? CloudNativeWorkloadVersionedFiles
        // GraphQL -> cloudNativeWorkloadVersionedFiles: CloudNativeVersionedFileConnection! (type)
        public static string CloudNativeWorkloadVersionedFiles(
            ref CloudNativeVersionedFileConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableId: $snappableId\nsearchQuery: $searchQuery\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CloudNativeVersionedFileConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cloudNativeWorkloadVersionedFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        public static string Cluster(
            ref Cluster? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Cluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateSummaryListResponse? ClusterCertificates
        // GraphQL -> clusterCertificates: CertificateSummaryListResponse! (type)
        public static string ClusterCertificates(
            ref CertificateSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CertificateSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterCertificates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        public static string ClusterConnection(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterCsr? ClusterCsr
        // GraphQL -> clusterCsr: ClusterCsr! (type)
        public static string ClusterCsr(
            ref ClusterCsr? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterCsr() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterCsr" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalGetDefaultGatewayResponse? ClusterDefaultGateway
        // GraphQL -> clusterDefaultGateway: InternalGetDefaultGatewayResponse! (type)
        public static string ClusterDefaultGateway(
            ref InternalGetDefaultGatewayResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InternalGetDefaultGatewayResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterDefaultGateway" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterDnsReply? ClusterDns
        // GraphQL -> clusterDns: ClusterDnsReply! (type)
        public static string ClusterDns(
            ref ClusterDnsReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterDnsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterDns" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterEncryptionInfoConnection? ClusterEncryptionInfo
        // GraphQL -> clusterEncryptionInfo: ClusterEncryptionInfoConnection! (type)
        public static string ClusterEncryptionInfo(
            ref ClusterEncryptionInfoConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nclusterName: $clusterName\nencryptionStatusFilter: $encryptionStatusFilter\nkeyProtection: $keyProtection\nclusters: $clusters\nencryptionTypes: $encryptionTypes\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterEncryptionInfoConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterEncryptionInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalGetClusterIpsResponse? ClusterFloatingIps
        // GraphQL -> clusterFloatingIps: InternalGetClusterIpsResponse! (type)
        public static string ClusterFloatingIps(
            ref InternalGetClusterIpsResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InternalGetClusterIpsResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterFloatingIps" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterGroupByConnection? ClusterGroupByConnection
        // GraphQL -> clusterGroupByConnection: ClusterGroupByConnection! (type)
        public static string ClusterGroupByConnection(
            ref ClusterGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ModifyIpmiReply? ClusterIpmi
        // GraphQL -> clusterIpmi: ModifyIpmiReply! (type)
        public static string ClusterIpmi(
            ref ModifyIpmiReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ModifyIpmiReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterIpmi" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterIpv6ModeReply? ClusterIpv6Mode
        // GraphQL -> clusterIpv6Mode: ClusterIpv6ModeReply! (type)
        public static string ClusterIpv6Mode(
            ref ClusterIpv6ModeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterIpv6ModeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterIpv6Mode" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkInterfaceListResponse? ClusterNetworkInterfaces
        // GraphQL -> clusterNetworkInterfaces: NetworkInterfaceListResponse! (type)
        public static string ClusterNetworkInterfaces(
            ref NetworkInterfaceListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NetworkInterfaceListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNetworkInterfaces" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeStatusListResponse? ClusterNodes
        // GraphQL -> clusterNodes: NodeStatusListResponse! (type)
        public static string ClusterNodes(
            ref NodeStatusListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NodeStatusListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNodes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NtpServerConfigurationListResponse? ClusterNtpServers
        // GraphQL -> clusterNtpServers: NtpServerConfigurationListResponse! (type)
        public static string ClusterNtpServers(
            ref NtpServerConfigurationListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NtpServerConfigurationListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterNtpServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterOperationJobProgress? ClusterOperationJobProgress
        // GraphQL -> clusterOperationJobProgress: ClusterOperationJobProgress! (type)
        public static string ClusterOperationJobProgress(
            ref ClusterOperationJobProgress? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterOperationJobProgress() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterOperationJobProgress" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterProxyReply? ClusterProxy
        // GraphQL -> clusterProxy: ClusterProxyReply! (type)
        public static string ClusterProxy(
            ref ClusterProxyReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterProxyReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterProxy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcvLocationBasicInfoConnection? ClusterRcvLocations
        // GraphQL -> clusterRcvLocations: RcvLocationBasicInfoConnection! (type)
        public static string ClusterRcvLocations(
            ref RcvLocationBasicInfoConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\ncdmClusterUUID: $cdmClusterUUID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RcvLocationBasicInfoConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterRcvLocations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterRegistrationProductInfoType? ClusterRegistrationProductInfo
        // GraphQL -> clusterRegistrationProductInfo: ClusterRegistrationProductInfoType! (type)
        public static string ClusterRegistrationProductInfo(
            ref ClusterRegistrationProductInfoType? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterRegistrationProductInfoType() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterRegistrationProductInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportsMigrationCount? ClusterReportMigrationCount
        // GraphQL -> clusterReportMigrationCount: ReportsMigrationCount! (type)
        public static string ClusterReportMigrationCount(
            ref ReportsMigrationCount? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nstatus: $status\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReportsMigrationCount() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterReportMigrationCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterReportMigrationJobStatus? ClusterReportMigrationJobStatus
        // GraphQL -> clusterReportMigrationJobStatus: ClusterReportMigrationJobStatus! (type)
        public static string ClusterReportMigrationJobStatus(
            ref ClusterReportMigrationJobStatus? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterReportMigrationJobStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterReportMigrationJobStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportMigrationStatusConnection? ClusterReportMigrationStatus
        // GraphQL -> clusterReportMigrationStatus: ReportMigrationStatusConnection! (type)
        public static string ClusterReportMigrationStatus(
            ref ReportMigrationStatusConnection? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nstatus: $status\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReportMigrationStatusConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterReportMigrationStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterSlaDomainForFilterConnection? ClusterSlaDomainFilterConnection
        // GraphQL -> clusterSlaDomainFilterConnection: ClusterSlaDomainForFilterConnection! (type)
        public static string ClusterSlaDomainFilterConnection(
            ref ClusterSlaDomainForFilterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterSlaDomainForFilterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterSlaDomainFilterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterSlaDomainConnection? ClusterSlaDomains
        // GraphQL -> clusterSlaDomains: ClusterSlaDomainConnection! (type)
        public static string ClusterSlaDomains(
            ref ClusterSlaDomainConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterSlaDomainConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterSlaDomains" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? ClusterTypeList
        // GraphQL -> clusterTypeList: [GroupCount!]! (type)
        public static string ClusterTypeList(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterTypeList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VlanConfigListResponse? ClusterVlans
        // GraphQL -> clusterVlans: VlanConfigListResponse! (type)
        public static string ClusterVlans(
            ref VlanConfigListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VlanConfigListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterVlans" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterWebSignedCertificateReply? ClusterWebSignedCertificate
        // GraphQL -> clusterWebSignedCertificate: ClusterWebSignedCertificateReply! (type)
        public static string ClusterWebSignedCertificate(
            ref ClusterWebSignedCertificateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterWebSignedCertificateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWebSignedCertificate" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterWithConfigProtectionInfo
        // GraphQL -> clusterWithConfigProtectionInfo: ClusterConnection! (type)
        public static string ClusterWithConfigProtectionInfo(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nconfigProtectionFilter: $configProtectionFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWithConfigProtectionInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ClusterWithUpgradesInfo
        // GraphQL -> clusterWithUpgradesInfo: ClusterConnection! (type)
        public static string ClusterWithUpgradesInfo(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nupgradeFilter: $upgradeFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "clusterWithUpgradesInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ComputeClusterDetail? ComputeClusterStatus
        // GraphQL -> computeClusterStatus: ComputeClusterDetail! (type)
        public static string ComputeClusterStatus(
            ref ComputeClusterDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ComputeClusterDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "computeClusterStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ConfigProtectionSetupInfo? ConfigProtectionSetupInfo
        // GraphQL -> configProtectionSetupInfo: ConfigProtectionSetupInfo! (type)
        public static string ConfigProtectionSetupInfo(
            ref ConfigProtectionSetupInfo? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ConfigProtectionSetupInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "configProtectionSetupInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ConfiguredGroupMemberConnection? ConfiguredGroupMembers
        // GraphQL -> configuredGroupMembers: O365ConfiguredGroupMemberConnection! (type)
        public static string ConfiguredGroupMembers(
            ref O365ConfiguredGroupMemberConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\norgId: $orgId\nwildcard: $wildcard\npdls: $pdls\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ConfiguredGroupMemberConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "configuredGroupMembers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CountOfObjectsProtectedBySlAsResult? CountOfObjectsProtectedBySlas
        // GraphQL -> countOfObjectsProtectedBySlas: CountOfObjectsProtectedBySLAsResult! (type)
        public static string CountOfObjectsProtectedBySlas(
            ref CountOfObjectsProtectedBySlAsResult? fieldSpec
        )
        {
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\ntypeFilter: $typeFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CountOfObjectsProtectedBySlAsResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "countOfObjectsProtectedBySlas" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Crawl? Crawl
        // GraphQL -> crawl: Crawl! (type)
        public static string Crawl(
            ref Crawl? fieldSpec
        )
        {
            string args = "\n(\ncrawlId: $crawlId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Crawl() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "crawl" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CrawlConnection? Crawls
        // GraphQL -> crawls: CrawlConnection! (type)
        public static string Crawls(
            ref CrawlConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new CrawlConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "crawls" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Org? CurrentOrg
        // GraphQL -> currentOrg: Org! (type)
        public static string CurrentOrg(
            ref Org? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new Org() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentOrg" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> User? CurrentUser
        // GraphQL -> currentUser: User! (type)
        public static string CurrentUser(
            ref User? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new User() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentUser" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserLoginContext? CurrentUserLoginContext
        // GraphQL -> currentUserLoginContext: UserLoginContext! (type)
        public static string CurrentUserLoginContext(
            ref UserLoginContext? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new UserLoginContext() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "currentUserLoginContext" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Analyzer? CustomAnalyzer
        // GraphQL -> customAnalyzer: Analyzer! (type)
        public static string CustomAnalyzer(
            ref Analyzer? fieldSpec
        )
        {
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Analyzer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "customAnalyzer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomTprPolicyConnection? CustomTprPolicies
        // GraphQL -> customTprPolicies: CustomTprPolicyConnection! (type)
        public static string CustomTprPolicies(
            ref CustomTprPolicyConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CustomTprPolicyConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "customTprPolicies" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CyberRecoveryObjectConnection? CyberRecoveryObjects
        // GraphQL -> cyberRecoveryObjects: CyberRecoveryObjectConnection! (type)
        public static string CyberRecoveryObjects(
            ref CyberRecoveryObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ncyberRecoveryObjectsFilter: $cyberRecoveryObjectsFilter\ncyberRecoveryObjectsSort: $cyberRecoveryObjectsSort\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CyberRecoveryObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "cyberRecoveryObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetDashboardSummaryReply? DashboardSummary
        // GraphQL -> dashboardSummary: GetDashboardSummaryReply! (type)
        public static string DashboardSummary(
            ref GetDashboardSummaryReply? fieldSpec
        )
        {
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetDashboardSummaryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dashboardSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DataDiscoveryObjectsCount? DataDiscoveryObjectsCount
        // GraphQL -> dataDiscoveryObjectsCount: DataDiscoveryObjectsCount! (type)
        public static string DataDiscoveryObjectsCount(
            ref DataDiscoveryObjectsCount? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new DataDiscoveryObjectsCount() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dataDiscoveryObjectsCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<DataViewMetadata>? DataViewMetadata
        // GraphQL -> dataViewMetadata: [dataViewMetadata!]! (type)
        public static string DataViewMetadata(
            ref List<DataViewMetadata>? fieldSpec
        )
        {
            string args = "\n(\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<DataViewMetadata>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "dataViewMetadata" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> QuerySddlReply? DatagovSecDesc
        // GraphQL -> datagovSecDesc: QuerySDDLReply! (type)
        public static string DatagovSecDesc(
            ref QuerySddlReply? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nstdPath: $stdPath\nskipResolveSids: $skipResolveSids\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new QuerySddlReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "datagovSecDesc" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2Database? Db2Database
        // GraphQL -> db2Database: Db2Database! (type)
        public static string Db2Database(
            ref Db2Database? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2Database() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Database" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2DatabaseConnection? Db2Databases
        // GraphQL -> db2Databases: Db2DatabaseConnection! (type)
        public static string Db2Databases(
            ref Db2DatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2DatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Databases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        public static string Db2Instance(
            ref Db2Instance? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2Instance() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Instance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2InstanceConnection? Db2Instances
        // GraphQL -> db2Instances: Db2InstanceConnection! (type)
        public static string Db2Instances(
            ref Db2InstanceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2InstanceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2Instances" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2LogSnapshot? Db2LogSnapshot
        // GraphQL -> db2LogSnapshot: Db2LogSnapshot! (type)
        public static string Db2LogSnapshot(
            ref Db2LogSnapshot? fieldSpec
        )
        {
            string args = "\n(\ndb2LogSnapshotFid: $db2LogSnapshotFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2LogSnapshot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2LogSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2LogSnapshotConnection? Db2LogSnapshots
        // GraphQL -> db2LogSnapshots: Db2LogSnapshotConnection! (type)
        public static string Db2LogSnapshots(
            ref Db2LogSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2LogSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2LogSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2RecoverableRange? Db2RecoverableRange
        // GraphQL -> db2RecoverableRange: Db2RecoverableRange! (type)
        public static string Db2RecoverableRange(
            ref Db2RecoverableRange? fieldSpec
        )
        {
            string args = "\n(\ndb2RecoverableRangeFid: $db2RecoverableRangeFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2RecoverableRange() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2RecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Db2RecoverableRangeConnection? Db2RecoverableRanges
        // GraphQL -> db2RecoverableRanges: Db2RecoverableRangeConnection! (type)
        public static string Db2RecoverableRanges(
            ref Db2RecoverableRangeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Db2RecoverableRangeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "db2RecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExportUrlSpecs? DecryptExportUrl
        // GraphQL -> decryptExportUrl: ExportUrlSpecs! (type)
        public static string DecryptExportUrl(
            ref ExportUrlSpecs? fieldSpec
        )
        {
            string args = "\n(\nworkloadFid: $workloadFid\nexportUrlSpecsEnc: $exportUrlSpecsEnc\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExportUrlSpecs() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "decryptExportUrl" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DiffResult? DiffFmd
        // GraphQL -> diffFmd: DiffResult! (type)
        public static string DiffFmd(
            ref DiffResult? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nbrowseDiffPath: $browseDiffPath\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DiffResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "diffFmd" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BootstrappableNodeInfoListResponse? DiscoverNodes
        // GraphQL -> discoverNodes: BootstrappableNodeInfoListResponse! (type)
        public static string DiscoverNodes(
            ref BootstrappableNodeInfoListResponse? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BootstrappableNodeInfoListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoverNodes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPoliciesTimelineReply? DiscoveryTimeline
        // GraphQL -> discoveryTimeline: GetPoliciesTimelineReply! (type)
        public static string DiscoveryTimeline(
            ref GetPoliciesTimelineReply? fieldSpec
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\ngetWhitelistedResults: $getWhitelistedResults\nworkloadTypes: $workloadTypes\nuseOptimisedDiscoveryTimeline: $useOptimisedDiscoveryTimeline\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetPoliciesTimelineReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "discoveryTimeline" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadCdmUpgradesPdfReply? DownloadCdmUpgradesPdf
        // GraphQL -> downloadCdmUpgradesPdf: DownloadCdmUpgradesPdfReply! (type)
        public static string DownloadCdmUpgradesPdf(
            ref DownloadCdmUpgradesPdfReply? fieldSpec
        )
        {
            string args = "\n(\ndownloadFilter: $downloadFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DownloadCdmUpgradesPdfReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadCdmUpgradesPdf" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadPackageStatusReply? DownloadPackageStatus
        // GraphQL -> downloadPackageStatus: DownloadPackageStatusReply! (type)
        public static string DownloadPackageStatus(
            ref DownloadPackageStatusReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DownloadPackageStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadPackageStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadLink? DownloadReportLink
        // GraphQL -> downloadReportLink: DownloadLink! (type)
        public static string DownloadReportLink(
            ref DownloadLink? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nconfig: $config\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DownloadLink() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportLink" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadLink? DownloadReportPdfLink
        // GraphQL -> downloadReportPdfLink: DownloadLink! (type)
        public static string DownloadReportPdfLink(
            ref DownloadLink? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nconfig: $config\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DownloadLink() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadReportPdfLink" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DownloadSlaWithReplicationCsvReply? DownloadSlaWithReplicationCsv
        // GraphQL -> downloadSlaWithReplicationCsv: DownloadSlaWithReplicationCsvReply! (type)
        public static string DownloadSlaWithReplicationCsv(
            ref DownloadSlaWithReplicationCsvReply? fieldSpec
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DownloadSlaWithReplicationCsvReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadSlaWithReplicationCsv" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? DownloadedVersionList
        // GraphQL -> downloadedVersionList: [GroupCount!]! (type)
        public static string DownloadedVersionList(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "downloadedVersionList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EdgeWindowsToolLink? EdgeWindowsToolLink
        // GraphQL -> edgeWindowsToolLink: EdgeWindowsToolLink! (type)
        public static string EdgeWindowsToolLink(
            ref EdgeWindowsToolLink? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new EdgeWindowsToolLink() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "edgeWindowsToolLink" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> EnvoyRegistrationToken? EnvoyRegistrationToken
        // GraphQL -> envoyRegistrationToken: EnvoyRegistrationToken! (type)
        public static string EnvoyRegistrationToken(
            ref EnvoyRegistrationToken? fieldSpec
        )
        {
            string args = "\n(\ntenantNetworkId: $tenantNetworkId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new EnvoyRegistrationToken() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "envoyRegistrationToken" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDag? ExchangeDag
        // GraphQL -> exchangeDag: ExchangeDag! (type)
        public static string ExchangeDag(
            ref ExchangeDag? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeDag() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDag" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDagConnection? ExchangeDags
        // GraphQL -> exchangeDags: ExchangeDagConnection! (type)
        public static string ExchangeDags(
            ref ExchangeDagConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeDagConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDags" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDatabase? ExchangeDatabase
        // GraphQL -> exchangeDatabase: ExchangeDatabase! (type)
        public static string ExchangeDatabase(
            ref ExchangeDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeDatabaseConnection? ExchangeDatabases
        // GraphQL -> exchangeDatabases: ExchangeDatabaseConnection! (type)
        public static string ExchangeDatabases(
            ref ExchangeDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeLiveMountConnection? ExchangeLiveMounts
        // GraphQL -> exchangeLiveMounts: ExchangeLiveMountConnection! (type)
        public static string ExchangeLiveMounts(
            ref ExchangeLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeLiveMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeServer? ExchangeServer
        // GraphQL -> exchangeServer: ExchangeServer! (type)
        public static string ExchangeServer(
            ref ExchangeServer? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeServer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeServer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ExchangeServerConnection? ExchangeServers
        // GraphQL -> exchangeServers: ExchangeServerConnection! (type)
        public static string ExchangeServers(
            ref ExchangeServerConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ExchangeServerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "exchangeServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Failover? Failover
        // GraphQL -> failover: Failover (type)
        public static string Failover(
            ref Failover? fieldSpec
        )
        {
            string args = "\n(\nfailoverId: $failoverId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Failover() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failover" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverSourceConnection? FailoverAllSourceConnection
        // GraphQL -> failoverAllSourceConnection: FailoverSourceConnection! (type)
        public static string FailoverAllSourceConnection(
            ref FailoverSourceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverSourceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverAllSourceConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverTargetSiteConnection? FailoverAllTargetSiteConnection
        // GraphQL -> failoverAllTargetSiteConnection: FailoverTargetSiteConnection! (type)
        public static string FailoverAllTargetSiteConnection(
            ref FailoverTargetSiteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverTargetSiteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverAllTargetSiteConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterApp? FailoverClusterApp
        // GraphQL -> failoverClusterApp: FailoverClusterApp! (type)
        public static string FailoverClusterApp(
            ref FailoverClusterApp? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverClusterApp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterApp" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterAppConnection? FailoverClusterApps
        // GraphQL -> failoverClusterApps: FailoverClusterAppConnection! (type)
        public static string FailoverClusterApps(
            ref FailoverClusterAppConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverClusterAppConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterApps" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverClusterTopLevelDescendantTypeConnection? FailoverClusterTopLevelDescendants
        // GraphQL -> failoverClusterTopLevelDescendants: FailoverClusterTopLevelDescendantTypeConnection! (type)
        public static string FailoverClusterTopLevelDescendants(
            ref FailoverClusterTopLevelDescendantTypeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverClusterTopLevelDescendantTypeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverClusterTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        public static string FailoverConnection(
            ref FailoverConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverGroupByConnection? FailoverGroupByConnection
        // GraphQL -> failoverGroupByConnection: FailoverGroupByConnection! (type)
        public static string FailoverGroupByConnection(
            ref FailoverGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverJobReportConnection? FailoverJobReports
        // GraphQL -> failoverJobReports: FailoverJobReportConnection! (type)
        public static string FailoverJobReports(
            ref FailoverJobReportConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfailoverType: $failoverType\nstartTimeMs: $startTimeMs\nendTimeMs: $endTimeMs\nrecoveryNames: $recoveryNames\nplanNames: $planNames\nworkloadIDs: $workloadIDs\nRecoveryStatus: $RecoveryStatus\nSortParams: $SortParams\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverJobReportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverJobReports" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FailoverReport? FailoverReport
        // GraphQL -> failoverReport: FailoverReport (type)
        public static string FailoverReport(
            ref FailoverReport? fieldSpec
        )
        {
            string args = "\n(\nfailoverReportId: $failoverReportId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FailoverReport() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "failoverReport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureFlag? FeatureFlag
        // GraphQL -> featureFlag: FeatureFlag! (type)
        public static string FeatureFlag(
            ref FeatureFlag? fieldSpec
        )
        {
            string args = "\n(\nflagName: $flagName\nentityType: $entityType\nentityContext: $entityContext\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FeatureFlag() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "featureFlag" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureFlagAll? FeatureFlagAll
        // GraphQL -> featureFlagAll: FeatureFlagAll! (type)
        public static string FeatureFlagAll(
            ref FeatureFlagAll? fieldSpec
        )
        {
            string args = "\n(\nentityType: $entityType\nentityContext: $entityContext\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FeatureFlagAll() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "featureFlagAll" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FederatedLoginStatus? FederatedLoginStatus
        // GraphQL -> federatedLoginStatus: FederatedLoginStatus! (type)
        public static string FederatedLoginStatus(
            ref FederatedLoginStatus? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new FederatedLoginStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "federatedLoginStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FakeDataConnection? FetchFakeData
        // GraphQL -> fetchFakeData: FakeDataConnection! (type)
        public static string FetchFakeData(
            ref FakeDataConnection? fieldSpec
        )
        {
            string args = "\n(\nresponsePeriodMs: $responsePeriodMs\nshouldBlock: $shouldBlock\npreProcessingBufferBytes: $preProcessingBufferBytes\nresponseSizeBytes: $responseSizeBytes\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FakeDataConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "fetchFakeData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetSnapshotDetail? FilesetSnapshot
        // GraphQL -> filesetSnapshot: FilesetSnapshotDetail! (type)
        public static string FilesetSnapshot(
            ref FilesetSnapshotDetail? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nverbose: $verbose\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FilesetSnapshotDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? FilesetSnapshotFiles
        // GraphQL -> filesetSnapshotFiles: BrowseResponseListResponse! (type)
        public static string FilesetSnapshotFiles(
            ref BrowseResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nlimit: $limit\noffset: $offset\npath: $path\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BrowseResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetSnapshotFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetTemplate? FilesetTemplate
        // GraphQL -> filesetTemplate: FilesetTemplate! (type)
        public static string FilesetTemplate(
            ref FilesetTemplate? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FilesetTemplate() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetTemplate" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FilesetTemplateConnection? FilesetTemplates
        // GraphQL -> filesetTemplates: FilesetTemplateConnection! (type)
        public static string FilesetTemplates(
            ref FilesetTemplateConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FilesetTemplateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "filesetTemplates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeDisk? GcpNativeDisk
        // GraphQL -> gcpNativeDisk: GcpNativeDisk! (type)
        public static string GcpNativeDisk(
            ref GcpNativeDisk? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeDisk() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeDisk" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeDiskConnection? GcpNativeDisks
        // GraphQL -> gcpNativeDisks: GcpNativeDiskConnection! (type)
        public static string GcpNativeDisks(
            ref GcpNativeDiskConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeDiskConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeDisks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeGceInstance? GcpNativeGceInstance
        // GraphQL -> gcpNativeGceInstance: GcpNativeGceInstance! (type)
        public static string GcpNativeGceInstance(
            ref GcpNativeGceInstance? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeGceInstance() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeGceInstance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstances
        // GraphQL -> gcpNativeGceInstances: GcpNativeGceInstanceConnection! (type)
        public static string GcpNativeGceInstances(
            ref GcpNativeGceInstanceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ngceInstanceFilters: $gceInstanceFilters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeGceInstanceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeGceInstances" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        public static string GcpNativeProject(
            ref GcpNativeProject? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeProject() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeProject" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GcpNativeProjectConnection? GcpNativeProjects
        // GraphQL -> gcpNativeProjects: GcpNativeProjectConnection! (type)
        public static string GcpNativeProjects(
            ref GcpNativeProjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nprojectFilters: $projectFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GcpNativeProjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeProjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListStoredDiskLocationsReply? GcpNativeStoredDiskLocations
        // GraphQL -> gcpNativeStoredDiskLocations: ListStoredDiskLocationsReply! (type)
        public static string GcpNativeStoredDiskLocations(
            ref ListStoredDiskLocationsReply? fieldSpec
        )
        {
            string args = "\n(\nprojectId: $projectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListStoredDiskLocationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "gcpNativeStoredDiskLocations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GeoLocationList
        // GraphQL -> geoLocationList: [GroupCount!]! (type)
        public static string GeoLocationList(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "geoLocationList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AspValue? GetAccountSettingValue
        // GraphQL -> getAccountSettingValue: ASPValue! (type)
        public static string GetAccountSettingValue(
            ref AspValue? fieldSpec
        )
        {
            string args = "\n(\naspName: $aspName\naspComponent: $aspComponent\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AspValue() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getAccountSettingValue" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RoleConnection? GetAllRolesInOrgConnection
        // GraphQL -> getAllRolesInOrgConnection: RoleConnection! (type)
        public static string GetAllRolesInOrgConnection(
            ref RoleConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RoleConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getAllRolesInOrgConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForClusterFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForClusterFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForClusterFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsForClusterFromSupportPortal" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForVersionFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForVersionFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForVersionFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? fieldSpec
        )
        {
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsForVersionFromSupportPortal" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsFromSupportPortal(
            ref CdmUpgradeReleaseDetailsFromSupportPortalReply? fieldSpec
        )
        {
            string args = "\n(\nplatform: $platform\nnodeCount: $nodeCount\nsourceVersion: $sourceVersion\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getCdmReleaseDetailsFromSupportPortal" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupCountListWithTotal? GetGroupCountByCdmClusterStatus
        // GraphQL -> getGroupCountByCdmClusterStatus: GroupCountListWithTotal! (type)
        public static string GetGroupCountByCdmClusterStatus(
            ref GroupCountListWithTotal? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GroupCountListWithTotal() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByCdmClusterStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByPrechecksStatus
        // GraphQL -> getGroupCountByPrechecksStatus: [GroupCount!]! (type)
        public static string GetGroupCountByPrechecksStatus(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByPrechecksStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByUpgradeJobStatus
        // GraphQL -> getGroupCountByUpgradeJobStatus: [GroupCount!]! (type)
        public static string GetGroupCountByUpgradeJobStatus(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByUpgradeJobStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<GroupCount>? GetGroupCountByVersionStatus
        // GraphQL -> getGroupCountByVersionStatus: [GroupCount!]! (type)
        public static string GetGroupCountByVersionStatus(
            ref List<GroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<GroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getGroupCountByVersionStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetTaskchainStatusReply? GetKorgTaskchainStatus
        // GraphQL -> getKorgTaskchainStatus: GetTaskchainStatusReply! (type)
        public static string GetKorgTaskchainStatus(
            ref GetTaskchainStatusReply? fieldSpec
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetTaskchainStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getKorgTaskchainStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Permission>? GetPermissions
        // GraphQL -> getPermissions: [Permission!]! (type)
        public static string GetPermissions(
            ref List<Permission>? fieldSpec
        )
        {
            string args = "\n(\nroleId: $roleId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Permission>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getPermissions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Role>? GetRolesByIds
        // GraphQL -> getRolesByIds: [Role!]! (type)
        public static string GetRolesByIds(
            ref List<Role>? fieldSpec
        )
        {
            string args = "\n(\nroleIds: $roleIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Role>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getRolesByIds" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<UserDownload>? GetUserDownloads
        // GraphQL -> getUserDownloads: [UserDownload!]! (type)
        public static string GetUserDownloads(
            ref List<UserDownload>? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<UserDownload>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "getUserDownloads" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalCertificate? GlobalCertificate
        // GraphQL -> globalCertificate: GlobalCertificate! (type)
        public static string GlobalCertificate(
            ref GlobalCertificate? fieldSpec
        )
        {
            string args = "\n(\ncertificateId: $certificateId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalCertificate() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalCertificate" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalCertificateConnection? GlobalCertificates
        // GraphQL -> globalCertificates: GlobalCertificateConnection! (type)
        public static string GlobalCertificates(
            ref GlobalCertificateConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalCertificateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalCertificates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalFileSearchReply? GlobalFileSearch
        // GraphQL -> globalFileSearch: GlobalFileSearchReply! (type)
        public static string GlobalFileSearch(
            ref GlobalFileSearchReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalFileSearchReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalFileSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LockoutConfig? GlobalLockoutConfig
        // GraphQL -> globalLockoutConfig: LockoutConfig! (type)
        public static string GlobalLockoutConfig(
            ref LockoutConfig? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new LockoutConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalLockoutConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMfaSettingReply? GlobalMfaSetting
        // GraphQL -> globalMfaSetting: GetMfaSettingReply! (type)
        public static string GlobalMfaSetting(
            ref GetMfaSettingReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetMfaSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalMfaSetting" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchyObjectConnection? GlobalSearchResults
        // GraphQL -> globalSearchResults: HierarchyObjectConnection! (type)
        public static string GlobalSearchResults(
            ref HierarchyObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HierarchyObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSearchResults" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaForFilterConnection? GlobalSlaFilterConnection
        // GraphQL -> globalSlaFilterConnection: GlobalSlaForFilterConnection! (type)
        public static string GlobalSlaFilterConnection(
            ref GlobalSlaForFilterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalSlaForFilterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSlaFilterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GlobalSlaStatusConnection? GlobalSlaStatuses
        // GraphQL -> globalSlaStatuses: GlobalSlaStatusConnection! (type)
        public static string GlobalSlaStatuses(
            ref GlobalSlaStatusConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nSlaId: $SlaId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GlobalSlaStatusConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "globalSlaStatuses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupedReleaseNoteConnection? GroupedReleasesNotes
        // GraphQL -> groupedReleasesNotes: GroupedReleaseNoteConnection! (type)
        public static string GroupedReleasesNotes(
            ref GroupedReleaseNoteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GroupedReleaseNoteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "groupedReleasesNotes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GroupConnection? GroupsInCurrentAndDescendantOrganization
        // GraphQL -> groupsInCurrentAndDescendantOrganization: GroupConnection! (type)
        public static string GroupsInCurrentAndDescendantOrganization(
            ref GroupConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nshouldIncludeGroupsWithoutRole: $shouldIncludeGroupsWithoutRole\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "groupsInCurrentAndDescendantOrganization" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GuestCredentialDetailListResponse? GuestCredentials
        // GraphQL -> guestCredentials: GuestCredentialDetailListResponse! (type)
        public static string GuestCredentials(
            ref GuestCredentialDetailListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GuestCredentialDetailListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "guestCredentials" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HelpContentSnippetConnection? HelpContentSnippets
        // GraphQL -> helpContentSnippets: HelpContentSnippetConnection! (type)
        public static string HelpContentSnippets(
            ref HelpContentSnippetConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HelpContentSnippetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "helpContentSnippets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HierarchySnappableConnection? HierarchySnappables
        // GraphQL -> hierarchySnappables: HierarchySnappableConnection! (type)
        public static string HierarchySnappables(
            ref HierarchySnappableConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HierarchySnappableConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hierarchySnappables" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostDiagnosisSummary? HostDiagnosis
        // GraphQL -> hostDiagnosis: HostDiagnosisSummary! (type)
        public static string HostDiagnosis(
            ref HostDiagnosisSummary? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HostDiagnosisSummary() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostDiagnosis" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostFailoverCluster? HostFailoverCluster
        // GraphQL -> hostFailoverCluster: HostFailoverCluster! (type)
        public static string HostFailoverCluster(
            ref HostFailoverCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HostFailoverCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostFailoverCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostFailoverClusterConnection? HostFailoverClusters
        // GraphQL -> hostFailoverClusters: HostFailoverClusterConnection! (type)
        public static string HostFailoverClusters(
            ref HostFailoverClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HostFailoverClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostFailoverClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostShare? HostShare
        // GraphQL -> hostShare: HostShare! (type)
        public static string HostShare(
            ref HostShare? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HostShare() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostShare" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HostShareConnection? HostShares
        // GraphQL -> hostShares: HostShareConnection! (type)
        public static string HostShares(
            ref HostShareConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HostShareConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hostShares" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVcluster? HypervCluster
        // GraphQL -> hypervCluster: HyperVCluster! (type)
        public static string HypervCluster(
            ref HyperVcluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVcluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervHostAsyncRequestStatus
        // GraphQL -> hypervHostAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervHostAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervHostAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVliveMountConnection? HypervMounts
        // GraphQL -> hypervMounts: HyperVLiveMountConnection! (type)
        public static string HypervMounts(
            ref HyperVliveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVliveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVscvmm? HypervScvmm
        // GraphQL -> hypervScvmm: HyperVSCVMM! (type)
        public static string HypervScvmm(
            ref HyperVscvmm? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVscvmm() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmm" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervScvmmAsyncRequestStatus
        // GraphQL -> hypervScvmmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervScvmmAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmmAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVscvmmConnection? HypervScvmms
        // GraphQL -> hypervScvmms: HyperVSCVMMConnection! (type)
        public static string HypervScvmms(
            ref HyperVscvmmConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVscvmmConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervScvmms" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervServer? HypervServer
        // GraphQL -> hypervServer: HypervServer! (type)
        public static string HypervServer(
            ref HypervServer? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HypervServer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervServer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervHostSummaryListResponse? HypervServers
        // GraphQL -> hypervServers: HypervHostSummaryListResponse! (type)
        public static string HypervServers(
            ref HypervHostSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HypervHostSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervTopLevelDescendantTypeConnection? HypervTopLevelDescendants
        // GraphQL -> hypervTopLevelDescendants: HypervTopLevelDescendantTypeConnection! (type)
        public static string HypervTopLevelDescendants(
            ref HypervTopLevelDescendantTypeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HypervTopLevelDescendantTypeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVvirtualMachine? HypervVirtualMachine
        // GraphQL -> hypervVirtualMachine: HyperVVirtualMachine! (type)
        public static string HypervVirtualMachine(
            ref HyperVvirtualMachine? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVvirtualMachine() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachine" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? HypervVirtualMachineAsyncRequestStatus
        // GraphQL -> hypervVirtualMachineAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervVirtualMachineAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachineAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HyperVvirtualMachineConnection? HypervVirtualMachines
        // GraphQL -> hypervVirtualMachines: HyperVVirtualMachineConnection! (type)
        public static string HypervVirtualMachines(
            ref HyperVvirtualMachineConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HyperVvirtualMachineConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVirtualMachines" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HypervVirtualMachineDetail? HypervVmDetail
        // GraphQL -> hypervVmDetail: HypervVirtualMachineDetail! (type)
        public static string HypervVmDetail(
            ref HypervVirtualMachineDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HypervVirtualMachineDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "hypervVmDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<InstalledVersionGroupCount>? InstalledVersionList
        // GraphQL -> installedVersionList: [InstalledVersionGroupCount!]! (type)
        public static string InstalledVersionList(
            ref List<InstalledVersionGroupCount>? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new List<InstalledVersionGroupCount>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "installedVersionList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReadIntegrationReply? Integration
        // GraphQL -> integration: ReadIntegrationReply! (type)
        public static string Integration(
            ref ReadIntegrationReply? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReadIntegrationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "integration" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InventoryRoot? InventoryRoot
        // GraphQL -> inventoryRoot: InventoryRoot! (type)
        public static string InventoryRoot(
            ref InventoryRoot? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new InventoryRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "inventoryRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InventorySubHierarchyRoot? InventorySubHierarchyRoot
        // GraphQL -> inventorySubHierarchyRoot: InventorySubHierarchyRoot! (type)
        public static string InventorySubHierarchyRoot(
            ref InventorySubHierarchyRoot? fieldSpec
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InventorySubHierarchyRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "inventorySubHierarchyRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InvestigationCsvDownloadLinkReply? InvestigationCsvDownloadLink
        // GraphQL -> investigationCsvDownloadLink: InvestigationCsvDownloadLinkReply! (type)
        public static string InvestigationCsvDownloadLink(
            ref InvestigationCsvDownloadLinkReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\nsnapshotId: $snapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InvestigationCsvDownloadLinkReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "investigationCsvDownloadLink" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetWhitelistReply? IpWhitelist
        // GraphQL -> ipWhitelist: GetWhitelistReply! (type)
        public static string IpWhitelist(
            ref GetWhitelistReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetWhitelistReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ipWhitelist" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IsVolumeSnapshotRestorableReply? IsAwsNativeEbsVolumeSnapshotRestorable
        // GraphQL -> isAwsNativeEbsVolumeSnapshotRestorable: IsVolumeSnapshotRestorableReply! (type)
        public static string IsAwsNativeEbsVolumeSnapshotRestorable(
            ref IsVolumeSnapshotRestorableReply? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new IsVolumeSnapshotRestorableReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isAwsNativeEbsVolumeSnapshotRestorable" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateCloudNativeFileRecoveryFeasibilityReply? IsCloudNativeFileRecoveryFeasible
        // GraphQL -> isCloudNativeFileRecoveryFeasible: ValidateCloudNativeFileRecoveryFeasibilityReply! (type)
        public static string IsCloudNativeFileRecoveryFeasible(
            ref ValidateCloudNativeFileRecoveryFeasibilityReply? fieldSpec
        )
        {
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateCloudNativeFileRecoveryFeasibilityReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isCloudNativeFileRecoveryFeasible" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalStatusReply? IsLoggedIntoRubrikSupportPortal
        // GraphQL -> isLoggedIntoRubrikSupportPortal: SupportPortalStatusReply! (type)
        public static string IsLoggedIntoRubrikSupportPortal(
            ref SupportPortalStatusReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new SupportPortalStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isLoggedIntoRubrikSupportPortal" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeAvailabilityReply? IsUpgradeAvailable
        // GraphQL -> isUpgradeAvailable: CdmUpgradeAvailabilityReply! (type)
        public static string IsUpgradeAvailable(
            ref CdmUpgradeAvailabilityReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmUpgradeAvailabilityReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isUpgradeAvailable" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmUpgradeRecommendationReply? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: CdmUpgradeRecommendationReply! (type)
        public static string IsUpgradeRecommended(
            ref CdmUpgradeRecommendationReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmUpgradeRecommendationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isUpgradeRecommended" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ZrsAvailabilityReply? IsZrsAvailableForLocation
        // GraphQL -> isZrsAvailableForLocation: ZrsAvailabilityReply! (type)
        public static string IsZrsAvailableForLocation(
            ref ZrsAvailabilityReply? fieldSpec
        )
        {
            string args = "\n(\nserviceTier: $serviceTier\nregion: $region\nsubscriptionId: $subscriptionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ZrsAvailabilityReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "isZrsAvailableForLocation" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Issue? Issue
        // GraphQL -> issue: Issue! (type)
        public static string Issue(
            ref Issue? fieldSpec
        )
        {
            string args = "\n(\nissueId: $issueId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Issue() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "issue" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> IssueConnection? Issues
        // GraphQL -> issues: IssueConnection! (type)
        public static string Issues(
            ref IssueConnection? fieldSpec
        )
        {
            string args = "\n(\nstatus: $status\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new IssueConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "issues" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraUserConnection? JiraIssueAssignees
        // GraphQL -> jiraIssueAssignees: JiraUserConnection! (type)
        public static string JiraIssueAssignees(
            ref JiraUserConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\njiraProjectId: $jiraProjectId\nsortBy: $sortBy\nsortOrder: $sortOrder\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new JiraUserConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraIssueAssignees" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraIssueConnection? JiraIssues
        // GraphQL -> jiraIssues: JiraIssueConnection! (type)
        public static string JiraIssues(
            ref JiraIssueConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\njiraProjectId: $jiraProjectId\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new JiraIssueConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraIssues" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraUserConnection? JiraProjectLeads
        // GraphQL -> jiraProjectLeads: JiraUserConnection! (type)
        public static string JiraProjectLeads(
            ref JiraUserConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsiteId: $siteId\nsortBy: $sortBy\nsortOrder: $sortOrder\nsearchTerm: $searchTerm\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new JiraUserConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraProjectLeads" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraProjectConnection? JiraProjects
        // GraphQL -> jiraProjects: JiraProjectConnection! (type)
        public static string JiraProjects(
            ref JiraProjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsiteId: $siteId\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new JiraProjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraProjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> JiraSettingsConnection? JiraSettings
        // GraphQL -> jiraSettings: JiraSettingsConnection! (type)
        public static string JiraSettings(
            ref JiraSettingsConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\njiraSettingsId: $jiraSettingsId\njiraSettingsType: $jiraSettingsType\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new JiraSettingsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jiraSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalJobInstanceDetail? JobInstance
        // GraphQL -> jobInstance: InternalJobInstanceDetail! (type)
        public static string JobInstance(
            ref InternalJobInstanceDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InternalJobInstanceDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "jobInstance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sAppManifest? K8sAppManifest
        // GraphQL -> k8sAppManifest: K8sAppManifest! (type)
        public static string K8sAppManifest(
            ref K8sAppManifest? fieldSpec
        )
        {
            string args = "\n(\napp: $app\nversion: $version\nretrieveLatestVersion: $retrieveLatestVersion\ntargetVersion: $targetVersion\nk8sClusterId: $k8sClusterId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sAppManifest() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sAppManifest" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sCluster? K8sCluster
        // GraphQL -> k8sCluster: K8sCluster! (type)
        public static string K8sCluster(
            ref K8sCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sClusterConnection? K8sClusters
        // GraphQL -> k8sClusters: K8sClusterConnection! (type)
        public static string K8sClusters(
            ref K8sClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sNamespace? K8sNamespace
        // GraphQL -> k8sNamespace: K8sNamespace! (type)
        public static string K8sNamespace(
            ref K8sNamespace? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sNamespace() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sNamespace" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sNamespaceConnection? K8sNamespaces
        // GraphQL -> k8sNamespaces: K8sNamespaceConnection! (type)
        public static string K8sNamespaces(
            ref K8sNamespaceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nk8sClusterId: $k8sClusterId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sNamespaceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sNamespaces" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> K8sSnapshotInfo? K8sSnapshotInfo
        // GraphQL -> k8sSnapshotInfo: K8sSnapshotInfo! (type)
        public static string K8sSnapshotInfo(
            ref K8sSnapshotInfo? fieldSpec
        )
        {
            string args = "\n(\nsnapshotId: $snapshotId\nnamespaceId: $namespaceId\nisReplica: $isReplica\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new K8sSnapshotInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "k8sSnapshotInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KmipServerConnection? KmipServerConnection
        // GraphQL -> kmipServerConnection: KmipServerConnection! (type)
        public static string KmipServerConnection(
            ref KmipServerConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nserverAddressArg: $serverAddressArg\nkmipServerClustersArg: $kmipServerClustersArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KmipServerConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kmipServerConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KnowledgeBaseArticle? KnowledgeBaseArticle
        // GraphQL -> knowledgeBaseArticle: KnowledgeBaseArticle! (type)
        public static string KnowledgeBaseArticle(
            ref KnowledgeBaseArticle? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KnowledgeBaseArticle() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "knowledgeBaseArticle" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KubernetesCluster? KubernetesCluster
        // GraphQL -> kubernetesCluster: KubernetesCluster! (type)
        public static string KubernetesCluster(
            ref KubernetesCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KubernetesCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kubernetesCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KubernetesClusterConnection? KubernetesClusters
        // GraphQL -> kubernetesClusters: KubernetesClusterConnection! (type)
        public static string KubernetesClusters(
            ref KubernetesClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KubernetesClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kubernetesClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KubernetesResourceSet? KubernetesResourceSet
        // GraphQL -> kubernetesResourceSet: KubernetesResourceSet! (type)
        public static string KubernetesResourceSet(
            ref KubernetesResourceSet? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KubernetesResourceSet() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kubernetesResourceSet" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> KubernetesResourceSetConnection? KubernetesResourceSets
        // GraphQL -> kubernetesResourceSets: KubernetesResourceSetConnection! (type)
        public static string KubernetesResourceSets(
            ref KubernetesResourceSetConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nk8sClusterId: $k8sClusterId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new KubernetesResourceSetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "kubernetesResourceSets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LambdaSettings? LambdaSettings
        // GraphQL -> lambdaSettings: LambdaSettings! (type)
        public static string LambdaSettings(
            ref LambdaSettings? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new LambdaSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lambdaSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetLastInsightSyncReply? LatestInsightSync
        // GraphQL -> latestInsightSync: GetLastInsightSyncReply! (type)
        public static string LatestInsightSync(
            ref GetLastInsightSyncReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetLastInsightSyncReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "latestInsightSync" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AuthorizedPrincipalConnection? LdapAuthorizedPrincipalConnection
        // GraphQL -> ldapAuthorizedPrincipalConnection: AuthorizedPrincipalConnection! (type)
        public static string LdapAuthorizedPrincipalConnection(
            ref AuthorizedPrincipalConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AuthorizedPrincipalConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapAuthorizedPrincipalConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LdapIntegrationConnection? LdapIntegrationConnection
        // GraphQL -> ldapIntegrationConnection: LdapIntegrationConnection! (type)
        public static string LdapIntegrationConnection(
            ref LdapIntegrationConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LdapIntegrationConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapIntegrationConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalConnection? LdapPrincipalConnection
        // GraphQL -> ldapPrincipalConnection: PrincipalConnection! (type)
        public static string LdapPrincipalConnection(
            ref PrincipalConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nid: $id\nsearchText: $searchText\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrincipalConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ldapPrincipalConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LegalHoldSnapshotDetailConnection? LegalHoldSnapshotsForSnappable
        // GraphQL -> legalHoldSnapshotsForSnappable: LegalHoldSnapshotDetailConnection! (type)
        public static string LegalHoldSnapshotsForSnappable(
            ref LegalHoldSnapshotDetailConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LegalHoldSnapshotDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "legalHoldSnapshotsForSnappable" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LicensesForClusterProductReply? LicensesForClusterProductSummary
        // GraphQL -> licensesForClusterProductSummary: LicensesForClusterProductReply! (type)
        public static string LicensesForClusterProductSummary(
            ref LicensesForClusterProductReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LicensesForClusterProductReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "licensesForClusterProductSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LinuxFileset? LinuxFileset
        // GraphQL -> linuxFileset: LinuxFileset! (type)
        public static string LinuxFileset(
            ref LinuxFileset? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LinuxFileset() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "linuxFileset" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365AppConnection? ListO365Apps
        // GraphQL -> listO365Apps: O365AppConnection! (type)
        public static string ListO365Apps(
            ref O365AppConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\no365AppFilters: $o365AppFilters\no365AppSortByParam: $o365AppSortByParam\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365AppConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "listO365Apps" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LockoutConfig? LockoutConfig
        // GraphQL -> lockoutConfig: LockoutConfig! (type)
        public static string LockoutConfig(
            ref LockoutConfig? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new LockoutConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lockoutConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LookupAccountReply? LookupAccount
        // GraphQL -> lookupAccount: LookupAccountReply! (type)
        public static string LookupAccount(
            ref LookupAccountReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LookupAccountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "lookupAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> M365RegionsResp? M365Regions
        // GraphQL -> m365Regions: M365RegionsResp! (type)
        public static string M365Regions(
            ref M365RegionsResp? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new M365RegionsResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "m365Regions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MalwareScanResults? MalwareDetectionTaskResult
        // GraphQL -> malwareDetectionTaskResult: MalwareScanResults! (type)
        public static string MalwareDetectionTaskResult(
            ref MalwareScanResults? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MalwareScanResults() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareDetectionTaskResult" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? MalwareDetectionTaskStatus
        // GraphQL -> malwareDetectionTaskStatus: AsyncRequestStatus! (type)
        public static string MalwareDetectionTaskStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareDetectionTaskStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetLambdaMalwareScanDetailReply? MalwareScanDetail
        // GraphQL -> malwareScanDetail: GetLambdaMalwareScanDetailReply! (type)
        public static string MalwareScanDetail(
            ref GetLambdaMalwareScanDetailReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetLambdaMalwareScanDetailReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareScanDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MalwareScanDetailListResponse? MalwareScans
        // GraphQL -> malwareScans: MalwareScanDetailListResponse! (type)
        public static string MalwareScans(
            ref MalwareScanDetailListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MalwareScanDetailListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "malwareScans" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolume? ManagedVolume
        // GraphQL -> managedVolume: ManagedVolume! (type)
        public static string ManagedVolume(
            ref ManagedVolume? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolume() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolume" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeInventoryStats? ManagedVolumeInventoryStats
        // GraphQL -> managedVolumeInventoryStats: ManagedVolumeInventoryStats! (type)
        public static string ManagedVolumeInventoryStats(
            ref ManagedVolumeInventoryStats? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolumeInventoryStats() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumeInventoryStats" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeMountConnection? ManagedVolumeLiveMounts
        // GraphQL -> managedVolumeLiveMounts: ManagedVolumeMountConnection! (type)
        public static string ManagedVolumeLiveMounts(
            ref ManagedVolumeMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolumeMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumeLiveMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeConnection? ManagedVolumes
        // GraphQL -> managedVolumes: ManagedVolumeConnection! (type)
        public static string ManagedVolumes(
            ref ManagedVolumeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolumeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "managedVolumes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MandatoryTotpGracePeriod? MandatoryTotpGracePeriod
        // GraphQL -> mandatoryTotpGracePeriod: mandatoryTotpGracePeriod! (type)
        public static string MandatoryTotpGracePeriod(
            ref MandatoryTotpGracePeriod? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new MandatoryTotpGracePeriod() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mandatoryTotpGracePeriod" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMfaSettingReply? MfaSetting
        // GraphQL -> mfaSetting: GetMfaSettingReply! (type)
        public static string MfaSetting(
            ref GetMfaSettingReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetMfaSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mfaSetting" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FeatureListMinimumCdmVersionReply? MinimumCdmVersionForFeatureSet
        // GraphQL -> minimumCdmVersionForFeatureSet: FeatureListMinimumCdmVersionReply! (type)
        public static string MinimumCdmVersionForFeatureSet(
            ref FeatureListMinimumCdmVersionReply? fieldSpec
        )
        {
            string args = "\n(\nfeatureListMinimumCdmVersion: $featureListMinimumCdmVersion\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FeatureListMinimumCdmVersionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "minimumCdmVersionForFeatureSet" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoRecoverableRanges? MongoBulkRecoverableRanges
        // GraphQL -> mongoBulkRecoverableRanges: MongoRecoverableRanges! (type)
        public static string MongoBulkRecoverableRanges(
            ref MongoRecoverableRanges? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoRecoverableRanges() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoBulkRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoCollection? MongoCollection
        // GraphQL -> mongoCollection: MongoCollection! (type)
        public static string MongoCollection(
            ref MongoCollection? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoCollection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoCollection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoCollectionConnection? MongoCollections
        // GraphQL -> mongoCollections: MongoCollectionConnection! (type)
        public static string MongoCollections(
            ref MongoCollectionConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoCollectionConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoCollections" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoDatabase? MongoDatabase
        // GraphQL -> mongoDatabase: MongoDatabase! (type)
        public static string MongoDatabase(
            ref MongoDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoDatabaseConnection? MongoDatabases
        // GraphQL -> mongoDatabases: MongoDatabaseConnection! (type)
        public static string MongoDatabases(
            ref MongoDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoRecoverableRanges? MongoRecoverableRanges
        // GraphQL -> mongoRecoverableRanges: MongoRecoverableRanges! (type)
        public static string MongoRecoverableRanges(
            ref MongoRecoverableRanges? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoRecoverableRanges() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoSource? MongoSource
        // GraphQL -> mongoSource: MongoSource! (type)
        public static string MongoSource(
            ref MongoSource? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoSource() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoSource" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongoSourceConnection? MongoSources
        // GraphQL -> mongoSources: MongoSourceConnection! (type)
        public static string MongoSources(
            ref MongoSourceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongoSourceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongoSources" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicRecoveryRangeResponse? MongodbBulkRecoverableRange
        // GraphQL -> mongodbBulkRecoverableRange: MosaicRecoveryRangeResponse! (type)
        public static string MongodbBulkRecoverableRange(
            ref MosaicRecoveryRangeResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MosaicRecoveryRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbBulkRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbCollection? MongodbCollection
        // GraphQL -> mongodbCollection: MongodbCollection! (type)
        public static string MongodbCollection(
            ref MongodbCollection? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbCollection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetMosaicRecoverableRangeResponse? MongodbCollectionRecoverableRange
        // GraphQL -> mongodbCollectionRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string MongodbCollectionRecoverableRange(
            ref GetMosaicRecoverableRangeResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetMosaicRecoverableRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollectionRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbCollectionConnection? MongodbCollections
        // GraphQL -> mongodbCollections: MongodbCollectionConnection! (type)
        public static string MongodbCollections(
            ref MongodbCollectionConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbCollectionConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbCollections" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbDatabase? MongodbDatabase
        // GraphQL -> mongodbDatabase: MongodbDatabase! (type)
        public static string MongodbDatabase(
            ref MongodbDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbDatabaseConnection? MongodbDatabases
        // GraphQL -> mongodbDatabases: MongodbDatabaseConnection! (type)
        public static string MongodbDatabases(
            ref MongodbDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbSource? MongodbSource
        // GraphQL -> mongodbSource: MongodbSource! (type)
        public static string MongodbSource(
            ref MongodbSource? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbSource() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbSource" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MongodbSourceConnection? MongodbSources
        // GraphQL -> mongodbSources: MongodbSourceConnection! (type)
        public static string MongodbSources(
            ref MongodbSourceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MongodbSourceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mongodbSources" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MosaicRecoveryRangeResponse? MosaicBulkRecoveryRange
        // GraphQL -> mosaicBulkRecoveryRange: MosaicRecoveryRangeResponse! (type)
        public static string MosaicBulkRecoveryRange(
            ref MosaicRecoveryRangeResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MosaicRecoveryRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicBulkRecoveryRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListVersionResponse? MosaicSnapshots
        // GraphQL -> mosaicSnapshots: ListVersionResponse! (type)
        public static string MosaicSnapshots(
            ref ListVersionResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListVersionResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListStoreResponse? MosaicStores
        // GraphQL -> mosaicStores: ListStoreResponse! (type)
        public static string MosaicStores(
            ref ListStoreResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListStoreResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicStores" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListVersionResponse? MosaicVersions
        // GraphQL -> mosaicVersions: ListVersionResponse! (type)
        public static string MosaicVersions(
            ref ListVersionResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListVersionResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mosaicVersions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlAvailabilityGroup? MssqlAvailabilityGroup
        // GraphQL -> mssqlAvailabilityGroup: MssqlAvailabilityGroup! (type)
        public static string MssqlAvailabilityGroup(
            ref MssqlAvailabilityGroup? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlAvailabilityGroup() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlAvailabilityGroup" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlInstanceSummaryListResponse? MssqlCompatibleInstances
        // GraphQL -> mssqlCompatibleInstances: MssqlInstanceSummaryListResponse! (type)
        public static string MssqlCompatibleInstances(
            ref MssqlInstanceSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlInstanceSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlCompatibleInstances" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabase? MssqlDatabase
        // GraphQL -> mssqlDatabase: MssqlDatabase! (type)
        public static string MssqlDatabase(
            ref MssqlDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabaseLiveMountConnection? MssqlDatabaseLiveMounts
        // GraphQL -> mssqlDatabaseLiveMounts: MssqlDatabaseLiveMountConnection! (type)
        public static string MssqlDatabaseLiveMounts(
            ref MssqlDatabaseLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlDatabaseLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseLiveMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlMissedRecoverableRangeListResponse? MssqlDatabaseMissedRecoverableRanges
        // GraphQL -> mssqlDatabaseMissedRecoverableRanges: MssqlMissedRecoverableRangeListResponse! (type)
        public static string MssqlDatabaseMissedRecoverableRanges(
            ref MssqlMissedRecoverableRangeListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlMissedRecoverableRangeListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseMissedRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? MssqlDatabaseMissedSnapshots
        // GraphQL -> mssqlDatabaseMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string MssqlDatabaseMissedSnapshots(
            ref MissedSnapshotListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MissedSnapshotListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseMissedSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlRestoreEstimateResult? MssqlDatabaseRestoreEstimate
        // GraphQL -> mssqlDatabaseRestoreEstimate: MssqlRestoreEstimateResult! (type)
        public static string MssqlDatabaseRestoreEstimate(
            ref MssqlRestoreEstimateResult? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlRestoreEstimateResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabaseRestoreEstimate" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlDatabaseConnection? MssqlDatabases
        // GraphQL -> mssqlDatabases: MssqlDatabaseConnection! (type)
        public static string MssqlDatabases(
            ref MssqlDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? MssqlDefaultProperties
        // GraphQL -> mssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string MssqlDefaultProperties(
            ref UpdateMssqlDefaultPropertiesReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UpdateMssqlDefaultPropertiesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlDefaultProperties" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlInstance? MssqlInstance
        // GraphQL -> mssqlInstance: MssqlInstance! (type)
        public static string MssqlInstance(
            ref MssqlInstance? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlInstance() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlInstance" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlLogShippingSummaryV2ListResponse? MssqlLogShippingTargets
        // GraphQL -> mssqlLogShippingTargets: MssqlLogShippingSummaryV2ListResponse (type)
        public static string MssqlLogShippingTargets(
            ref MssqlLogShippingSummaryV2ListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlLogShippingSummaryV2ListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlLogShippingTargets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlRecoverableRangeListResponse? MssqlRecoverableRanges
        // GraphQL -> mssqlRecoverableRanges: MssqlRecoverableRangeListResponse! (type)
        public static string MssqlRecoverableRanges(
            ref MssqlRecoverableRangeListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlRecoverableRangeListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MssqlTopLevelDescendantTypeConnection? MssqlTopLevelDescendants
        // GraphQL -> mssqlTopLevelDescendants: MssqlTopLevelDescendantTypeConnection! (type)
        public static string MssqlTopLevelDescendants(
            ref MssqlTopLevelDescendantTypeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MssqlTopLevelDescendantTypeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "mssqlTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasFileset? NasFileset
        // GraphQL -> nasFileset: NasFileset! (type)
        public static string NasFileset(
            ref NasFileset? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasFileset() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasFileset" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasNamespace? NasNamespace
        // GraphQL -> nasNamespace: NasNamespace! (type)
        public static string NasNamespace(
            ref NasNamespace? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasNamespace() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasNamespace" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasNamespaceConnection? NasNamespaces
        // GraphQL -> nasNamespaces: NasNamespaceConnection! (type)
        public static string NasNamespaces(
            ref NasNamespaceConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasNamespaceConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasNamespaces" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasShare? NasShare
        // GraphQL -> nasShare: NasShare! (type)
        public static string NasShare(
            ref NasShare? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasShare() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasShare" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasSystem? NasSystem
        // GraphQL -> nasSystem: NasSystem! (type)
        public static string NasSystem(
            ref NasSystem? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasSystem() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasSystem" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasSystemConnection? NasSystems
        // GraphQL -> nasSystems: NasSystemConnection! (type)
        public static string NasSystems(
            ref NasSystemConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasSystemConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasSystems" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? NasTopLevelDescendants
        // GraphQL -> nasTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NasTopLevelDescendants(
            ref CdmHierarchyObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmHierarchyObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NasVolume? NasVolume
        // GraphQL -> nasVolume: NasVolume! (type)
        public static string NasVolume(
            ref NasVolume? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NasVolume() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nasVolume" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdBackEndCapacity? NcdBackEndCapacity
        // GraphQL -> ncdBackEndCapacity: NcdBackEndCapacity (type)
        public static string NcdBackEndCapacity(
            ref NcdBackEndCapacity? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NcdBackEndCapacity() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdBackEndCapacity" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdFrontEndCapacity? NcdFrontEndCapacity
        // GraphQL -> ncdFrontEndCapacity: NcdFrontEndCapacity (type)
        public static string NcdFrontEndCapacity(
            ref NcdFrontEndCapacity? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NcdFrontEndCapacity() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdFrontEndCapacity" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NcdObjectProtectionStatus? NcdObjectProtectionStatus
        // GraphQL -> ncdObjectProtectionStatus: NcdObjectProtectionStatus (type)
        public static string NcdObjectProtectionStatus(
            ref NcdObjectProtectionStatus? fieldSpec
        )
        {
            string args = "\n(\nclusters: $clusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NcdObjectProtectionStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ncdObjectProtectionStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkThrottleSummaryListResponse? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottleSummaryListResponse! (type)
        public static string NetworkThrottle(
            ref NetworkThrottleSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NetworkThrottleSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "networkThrottle" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeKeyRotationConnection? NodeKeyRotation
        // GraphQL -> nodeKeyRotation: NodeKeyRotationConnection! (type)
        public static string NodeKeyRotation(
            ref NodeKeyRotationConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nclusterID: $clusterID\nnodeID: $nodeID\nrotationStates: $rotationStates\nnodeSortBy: $nodeSortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NodeKeyRotationConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nodeKeyRotation" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NodeRemovalCancelPermissionReply? NodeRemovalCancelPermission
        // GraphQL -> nodeRemovalCancelPermission: NodeRemovalCancelPermissionReply! (type)
        public static string NodeRemovalCancelPermission(
            ref NodeRemovalCancelPermissionReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NodeRemovalCancelPermissionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nodeRemovalCancelPermission" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? NutanixBrowseSnapshot
        // GraphQL -> nutanixBrowseSnapshot: BrowseResponseListResponse! (type)
        public static string NutanixBrowseSnapshot(
            ref BrowseResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BrowseResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixBrowseSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCategory? NutanixCategory
        // GraphQL -> nutanixCategory: NutanixCategory! (type)
        public static string NutanixCategory(
            ref NutanixCategory? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixCategory() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCategory" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCategoryValue? NutanixCategoryValue
        // GraphQL -> nutanixCategoryValue: NutanixCategoryValue! (type)
        public static string NutanixCategoryValue(
            ref NutanixCategoryValue? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixCategoryValue() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCategoryValue" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixCluster? NutanixCluster
        // GraphQL -> nutanixCluster: NutanixCluster! (type)
        public static string NutanixCluster(
            ref NutanixCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? NutanixClusterAsyncRequestStatus
        // GraphQL -> nutanixClusterAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixClusterAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixContainerListResponse? NutanixClusterContainers
        // GraphQL -> nutanixClusterContainers: NutanixContainerListResponse! (type)
        public static string NutanixClusterContainers(
            ref NutanixContainerListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixContainerListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterContainers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixNetworkListResponse? NutanixClusterNetworks
        // GraphQL -> nutanixClusterNetworks: NutanixNetworkListResponse! (type)
        public static string NutanixClusterNetworks(
            ref NutanixNetworkListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixNetworkListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusterNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixClusterConnection? NutanixClusters
        // GraphQL -> nutanixClusters: NutanixClusterConnection! (type)
        public static string NutanixClusters(
            ref NutanixClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixLiveMountConnection? NutanixMounts
        // GraphQL -> nutanixMounts: NutanixLiveMountConnection! (type)
        public static string NutanixMounts(
            ref NutanixLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixPrismCentral? NutanixPrismCentral
        // GraphQL -> nutanixPrismCentral: NutanixPrismCentral! (type)
        public static string NutanixPrismCentral(
            ref NutanixPrismCentral? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixPrismCentral() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixPrismCentral" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixPrismCentralConnection? NutanixPrismCentrals
        // GraphQL -> nutanixPrismCentrals: NutanixPrismCentralConnection! (type)
        public static string NutanixPrismCentrals(
            ref NutanixPrismCentralConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixPrismCentralConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixPrismCentrals" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVmSnapshotDetail? NutanixSnapshotDetail
        // GraphQL -> nutanixSnapshotDetail: NutanixVmSnapshotDetail! (type)
        public static string NutanixSnapshotDetail(
            ref NutanixVmSnapshotDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixVmSnapshotDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixSnapshotDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? NutanixTopLevelDescendants
        // GraphQL -> nutanixTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NutanixTopLevelDescendants(
            ref CdmHierarchyObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmHierarchyObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVm? NutanixVm
        // GraphQL -> nutanixVm: NutanixVm! (type)
        public static string NutanixVm(
            ref NutanixVm? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixVm() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVm" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? NutanixVmAsyncRequestStatus
        // GraphQL -> nutanixVmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixVmAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVmAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? NutanixVmMissedSnapshots
        // GraphQL -> nutanixVmMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string NutanixVmMissedSnapshots(
            ref MissedSnapshotListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MissedSnapshotListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVmMissedSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NutanixVmConnection? NutanixVms
        // GraphQL -> nutanixVms: NutanixVmConnection! (type)
        public static string NutanixVms(
            ref NutanixVmConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NutanixVmConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "nutanixVms" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Calendar? O365Calendar
        // GraphQL -> o365Calendar: O365Calendar! (type)
        public static string O365Calendar(
            ref O365Calendar? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Calendar() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Calendar" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365GroupConnection? O365Groups
        // GraphQL -> o365Groups: O365GroupConnection! (type)
        public static string O365Groups(
            ref O365GroupConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nsnappableType: $snappableType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365GroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Groups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365License? O365License
        // GraphQL -> o365License: O365License! (type)
        public static string O365License(
            ref O365License? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new O365License() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365License" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Mailbox? O365Mailbox
        // GraphQL -> o365Mailbox: O365Mailbox! (type)
        public static string O365Mailbox(
            ref O365Mailbox? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Mailbox() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Mailbox" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365MailboxConnection? O365Mailboxes
        // GraphQL -> o365Mailboxes: O365MailboxConnection! (type)
        public static string O365Mailboxes(
            ref O365MailboxConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365MailboxConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Mailboxes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetImplicitlyAuthorizedAncestorSummariesResponse? O365ObjectAncestors
        // GraphQL -> o365ObjectAncestors: GetImplicitlyAuthorizedAncestorSummariesResponse! (type)
        public static string O365ObjectAncestors(
            ref GetImplicitlyAuthorizedAncestorSummariesResponse? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetImplicitlyAuthorizedAncestorSummariesResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ObjectAncestors" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Onedrive? O365Onedrive
        // GraphQL -> o365Onedrive: O365Onedrive! (type)
        public static string O365Onedrive(
            ref O365Onedrive? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Onedrive() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Onedrive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveConnection? O365Onedrives
        // GraphQL -> o365Onedrives: O365OnedriveConnection! (type)
        public static string O365Onedrives(
            ref O365OnedriveConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Onedrives" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Org? O365Org
        // GraphQL -> o365Org: O365Org! (type)
        public static string O365Org(
            ref O365Org? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Org() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Org" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Org? O365OrgAtSnappableLevel
        // GraphQL -> o365OrgAtSnappableLevel: O365Org! (type)
        public static string O365OrgAtSnappableLevel(
            ref O365Org? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\nsnappableType: $snappableType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Org() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OrgAtSnappableLevel" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetImplicitlyAuthorizedObjectSummariesResponse? O365OrgSummaries
        // GraphQL -> o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse! (type)
        public static string O365OrgSummaries(
            ref GetImplicitlyAuthorizedObjectSummariesResponse? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetImplicitlyAuthorizedObjectSummariesResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365OrgSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OrgConnection? O365Orgs
        // GraphQL -> o365Orgs: O365OrgConnection! (type)
        public static string O365Orgs(
            ref O365OrgConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nworkloadHierarchy: $workloadHierarchy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OrgConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Orgs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ServiceAccountStatusResp? O365ServiceAccount
        // GraphQL -> o365ServiceAccount: O365ServiceAccountStatusResp! (type)
        public static string O365ServiceAccount(
            ref O365ServiceAccountStatusResp? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ServiceAccountStatusResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ServiceAccount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetO365ServiceStatusResp? O365ServiceStatus
        // GraphQL -> o365ServiceStatus: GetO365ServiceStatusResp! (type)
        public static string O365ServiceStatus(
            ref GetO365ServiceStatusResp? fieldSpec
        )
        {
            string args = "\n(\norgID: $orgID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetO365ServiceStatusResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365ServiceStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointDrive? O365SharepointDrive
        // GraphQL -> o365SharepointDrive: O365SharepointDrive! (type)
        public static string O365SharepointDrive(
            ref O365SharepointDrive? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointDrive() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointDrive" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointDriveConnection? O365SharepointDrives
        // GraphQL -> o365SharepointDrives: O365SharepointDriveConnection! (type)
        public static string O365SharepointDrives(
            ref O365SharepointDriveConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointDriveConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointDrives" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointList? O365SharepointList
        // GraphQL -> o365SharepointList: O365SharepointList! (type)
        public static string O365SharepointList(
            ref O365SharepointList? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointList() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointListConnection? O365SharepointLists
        // GraphQL -> o365SharepointLists: O365SharepointListConnection! (type)
        public static string O365SharepointLists(
            ref O365SharepointListConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointListConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointLists" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjectList
        // GraphQL -> o365SharepointObjectList: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjectList(
            ref O365SharepointObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nincludeEntireHierarchy: $includeEntireHierarchy\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointObjectList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjects
        // GraphQL -> o365SharepointObjects: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjects(
            ref O365SharepointObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SharepointObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Site? O365SharepointSite
        // GraphQL -> o365SharepointSite: O365Site! (type)
        public static string O365SharepointSite(
            ref O365Site? fieldSpec
        )
        {
            string args = "\n(\nsiteFid: $siteFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Site() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointSite" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SiteConnection? O365SharepointSites
        // GraphQL -> o365SharepointSites: O365SiteConnection! (type)
        public static string O365SharepointSites(
            ref O365SiteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SiteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365SharepointSites" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Site? O365Site
        // GraphQL -> o365Site: O365Site! (type)
        public static string O365Site(
            ref O365Site? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Site() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Site" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365SiteConnection? O365Sites
        // GraphQL -> o365Sites: O365SiteConnection! (type)
        public static string O365Sites(
            ref O365SiteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nexcludeChildSites: $excludeChildSites\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365SiteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Sites" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetO365StorageStatsResp? O365StorageStats
        // GraphQL -> o365StorageStats: GetO365StorageStatsResp! (type)
        public static string O365StorageStats(
            ref GetO365StorageStatsResp? fieldSpec
        )
        {
            string args = "\n(\norgID: $orgID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetO365StorageStatsResp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365StorageStats" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365Teams? O365Team
        // GraphQL -> o365Team: O365Teams! (type)
        public static string O365Team(
            ref O365Teams? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365Teams() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Team" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsChannelConnection? O365TeamChannels
        // GraphQL -> o365TeamChannels: O365TeamsChannelConnection! (type)
        public static string O365TeamChannels(
            ref O365TeamsChannelConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nexcludeArchived: $excludeArchived\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamsChannelConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365TeamChannels" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamConversationsSenderConnection? O365TeamPostedBy
        // GraphQL -> o365TeamPostedBy: O365TeamConversationsSenderConnection! (type)
        public static string O365TeamPostedBy(
            ref O365TeamConversationsSenderConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\no365OrgId: $o365OrgId\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamConversationsSenderConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365TeamPostedBy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsConnection? O365Teams
        // GraphQL -> o365Teams: O365TeamsConnection! (type)
        public static string O365Teams(
            ref O365TeamsConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365Teams" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365User? O365User
        // GraphQL -> o365User: O365User! (type)
        public static string O365User(
            ref O365User? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365User() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365User" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365UserDescendantMetadataConnection? O365UserObjects
        // GraphQL -> o365UserObjects: O365UserDescendantMetadataConnection! (type)
        public static string O365UserObjects(
            ref O365UserDescendantMetadataConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365UserDescendantMetadataConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "o365UserObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OauthCodesForEdgeRegReply? OauthCodesForEdgeReg
        // GraphQL -> oauthCodesForEdgeReg: OauthCodesForEdgeRegReply! (type)
        public static string OauthCodesForEdgeReg(
            ref OauthCodesForEdgeRegReply? fieldSpec
        )
        {
            string args = "\n(\nnumberOfEdges: $numberOfEdges\ncdmOvaLink: $cdmOvaLink\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OauthCodesForEdgeRegReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oauthCodesForEdgeReg" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileResultConnection? ObjectFiles
        // GraphQL -> objectFiles: FileResultConnection! (type)
        public static string ObjectFiles(
            ref FileResultConnection? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\nsort: $sort\nday: $day\ntimezone: $timezone\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FileResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "objectFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleFileDownloadLink? OracleAcoExampleDownloadLink
        // GraphQL -> oracleAcoExampleDownloadLink: OracleFileDownloadLink! (type)
        public static string OracleAcoExampleDownloadLink(
            ref OracleFileDownloadLink? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleFileDownloadLink() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleAcoExampleDownloadLink" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleAcoParameterList? OracleAcoParameters
        // GraphQL -> oracleAcoParameters: OracleAcoParameterList! (type)
        public static string OracleAcoParameters(
            ref OracleAcoParameterList? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleAcoParameterList() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleAcoParameters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDataGuardGroup? OracleDataGuardGroup
        // GraphQL -> oracleDataGuardGroup: OracleDataGuardGroup! (type)
        public static string OracleDataGuardGroup(
            ref OracleDataGuardGroup? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleDataGuardGroup() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDataGuardGroup" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDatabase? OracleDatabase
        // GraphQL -> oracleDatabase: OracleDatabase! (type)
        public static string OracleDatabase(
            ref OracleDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleDatabaseLogBackupConfig
        // GraphQL -> oracleDatabaseLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleDatabaseLogBackupConfig(
            ref OracleLogBackupConfig? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleLogBackupConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabaseLogBackupConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleDatabaseConnection? OracleDatabases
        // GraphQL -> oracleDatabases: OracleDatabaseConnection! (type)
        public static string OracleDatabases(
            ref OracleDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleHost? OracleHost
        // GraphQL -> oracleHost: OracleHost! (type)
        public static string OracleHost(
            ref OracleHost? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleHost() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleHost" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleHostLogBackupConfig
        // GraphQL -> oracleHostLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleHostLogBackupConfig(
            ref OracleLogBackupConfig? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleLogBackupConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleHostLogBackupConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLiveMountConnection? OracleLiveMounts
        // GraphQL -> oracleLiveMounts: OracleLiveMountConnection! (type)
        public static string OracleLiveMounts(
            ref OracleLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleLiveMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleMissedRecoverableRangeListResponse? OracleMissedRecoverableRanges
        // GraphQL -> oracleMissedRecoverableRanges: OracleMissedRecoverableRangeListResponse! (type)
        public static string OracleMissedRecoverableRanges(
            ref OracleMissedRecoverableRangeListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleMissedRecoverableRangeListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleMissedRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> MissedSnapshotListResponse? OracleMissedSnapshots
        // GraphQL -> oracleMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string OracleMissedSnapshots(
            ref MissedSnapshotListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new MissedSnapshotListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleMissedSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OraclePdbDetails? OraclePdbDetails
        // GraphQL -> oraclePdbDetails: OraclePdbDetails! (type)
        public static string OraclePdbDetails(
            ref OraclePdbDetails? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OraclePdbDetails() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oraclePdbDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleRac? OracleRac
        // GraphQL -> oracleRac: OracleRac! (type)
        public static string OracleRac(
            ref OracleRac? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleRac() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRac" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleLogBackupConfig? OracleRacLogBackupConfig
        // GraphQL -> oracleRacLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleRacLogBackupConfig(
            ref OracleLogBackupConfig? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleLogBackupConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRacLogBackupConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleRecoverableRangeListResponse? OracleRecoverableRanges
        // GraphQL -> oracleRecoverableRanges: OracleRecoverableRangeListResponse! (type)
        public static string OracleRecoverableRanges(
            ref OracleRecoverableRangeListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleRecoverableRangeListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OracleTopLevelDescendantTypeConnection? OracleTopLevelDescendants
        // GraphQL -> oracleTopLevelDescendants: OracleTopLevelDescendantTypeConnection! (type)
        public static string OracleTopLevelDescendants(
            ref OracleTopLevelDescendantTypeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OracleTopLevelDescendantTypeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "oracleTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        public static string Org(
            ref Org? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Org() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "org" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgNetwork? OrgNetwork
        // GraphQL -> orgNetwork: OrgNetwork! (type)
        public static string OrgNetwork(
            ref OrgNetwork? fieldSpec
        )
        {
            string args = "\n(\ntenantNetworkId: $tenantNetworkId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OrgNetwork() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgNetwork" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgNetworkConnection? OrgNetworks
        // GraphQL -> orgNetworks: OrgNetworkConnection! (type)
        public static string OrgNetworks(
            ref OrgNetworkConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OrgNetworkConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgSecurityPolicy? OrgSecurityPolicy
        // GraphQL -> orgSecurityPolicy: OrgSecurityPolicy! (type)
        public static string OrgSecurityPolicy(
            ref OrgSecurityPolicy? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new OrgSecurityPolicy() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgSecurityPolicy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgConnection? Orgs
        // GraphQL -> orgs: OrgConnection! (type)
        public static string Orgs(
            ref OrgConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\nmfaEnforcedFilter: $mfaEnforcedFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OrgConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OrgsForPrincipalReply? OrgsForPrincipal
        // GraphQL -> orgsForPrincipal: OrgsForPrincipalReply! (type)
        public static string OrgsForPrincipal(
            ref OrgsForPrincipalReply? fieldSpec
        )
        {
            string args = "\n(\norgSearchFilter: $orgSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OrgsForPrincipalReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "orgsForPrincipal" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> OverallRansomwareInvestigationSummary? OverallRansomwareInvestigationSummary
        // GraphQL -> overallRansomwareInvestigationSummary: OverallRansomwareInvestigationSummary! (type)
        public static string OverallRansomwareInvestigationSummary(
            ref OverallRansomwareInvestigationSummary? fieldSpec
        )
        {
            string args = "\n(\nhistoryNumHours: $historyNumHours\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new OverallRansomwareInvestigationSummary() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "overallRansomwareInvestigationSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PactsafeContract? PactsafeContract
        // GraphQL -> pactsafeContract: PactsafeContract! (type)
        public static string PactsafeContract(
            ref PactsafeContract? fieldSpec
        )
        {
            string args = "\n(\ncontractType: $contractType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PactsafeContract() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pactsafeContract" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PactsafeEulaState? PactsafeEulaState
        // GraphQL -> pactsafeEulaState: PactsafeEulaState! (type)
        public static string PactsafeEulaState(
            ref PactsafeEulaState? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new PactsafeEulaState() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pactsafeEulaState" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PasswordComplexityPolicy? PasswordComplexityPolicy
        // GraphQL -> passwordComplexityPolicy: PasswordComplexityPolicy! (type)
        public static string PasswordComplexityPolicy(
            ref PasswordComplexityPolicy? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new PasswordComplexityPolicy() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "passwordComplexityPolicy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PendingAction? PendingAction
        // GraphQL -> pendingAction: pendingAction! (type)
        public static string PendingAction(
            ref PendingAction? fieldSpec
        )
        {
            string args = "\n(\npendingActionId: $pendingActionId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PendingAction() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pendingAction" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PendingEvaluationResultsReply? PendingRansomwareInvestigationResultsCount
        // GraphQL -> pendingRansomwareInvestigationResultsCount: PendingEvaluationResultsReply! (type)
        public static string PendingRansomwareInvestigationResultsCount(
            ref PendingEvaluationResultsReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new PendingEvaluationResultsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pendingRansomwareInvestigationResultsCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhoenixRolloutProgress? PhoenixRolloutProgress
        // GraphQL -> phoenixRolloutProgress: PhoenixRolloutProgress! (type)
        public static string PhoenixRolloutProgress(
            ref PhoenixRolloutProgress? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PhoenixRolloutProgress() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "phoenixRolloutProgress" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhysicalHost? PhysicalHost
        // GraphQL -> physicalHost: PhysicalHost! (type)
        public static string PhysicalHost(
            ref PhysicalHost? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PhysicalHost() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "physicalHost" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PhysicalHostConnection? PhysicalHosts
        // GraphQL -> physicalHosts: PhysicalHostConnection! (type)
        public static string PhysicalHosts(
            ref PhysicalHostConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\nisBulkPolicyAssignmentFlow: $isBulkPolicyAssignmentFlow\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PhysicalHostConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "physicalHosts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPipelineHealthReply? PipelineHealthForTimeRange
        // GraphQL -> pipelineHealthForTimeRange: GetPipelineHealthReply! (type)
        public static string PipelineHealthForTimeRange(
            ref GetPipelineHealthReply? fieldSpec
        )
        {
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetPipelineHealthReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "pipelineHealthForTimeRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisInventorySubHierarchyRoot? PolarisInventorySubHierarchyRoot
        // GraphQL -> polarisInventorySubHierarchyRoot: PolarisInventorySubHierarchyRoot! (type)
        public static string PolarisInventorySubHierarchyRoot(
            ref PolarisInventorySubHierarchyRoot? fieldSpec
        )
        {
            string args = "\n(\nrootEnum: $rootEnum\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolarisInventorySubHierarchyRoot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisInventorySubHierarchyRoot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportConfig? PolarisReportConfig
        // GraphQL -> polarisReportConfig: PolarisReportConfig! (type)
        public static string PolarisReportConfig(
            ref PolarisReportConfig? fieldSpec
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolarisReportConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportSchema? PolarisReportSchema
        // GraphQL -> polarisReportSchema: PolarisReportSchema! (type)
        public static string PolarisReportSchema(
            ref PolarisReportSchema? fieldSpec
        )
        {
            string args = "\n(\npolarisReportViewType: $polarisReportViewType\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolarisReportSchema() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportSchema" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisReportTableIntrospection? PolarisReportTableIntrospection
        // GraphQL -> polarisReportTableIntrospection: PolarisReportTableIntrospection! (type)
        public static string PolarisReportTableIntrospection(
            ref PolarisReportTableIntrospection? fieldSpec
        )
        {
            string args = "\n(\ntableView: $tableView\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolarisReportTableIntrospection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisReportTableIntrospection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolarisSnapshot? PolarisSnapshot
        // GraphQL -> polarisSnapshot: PolarisSnapshot! (type)
        public static string PolarisSnapshot(
            ref PolarisSnapshot? fieldSpec
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolarisSnapshot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "polarisSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetailConnection? Policies
        // GraphQL -> policies: ClassificationPolicyDetailConnection! (type)
        public static string Policies(
            ref ClassificationPolicyDetailConnection? fieldSpec
        )
        {
            string args = "\n(\npolicyObjectFilter: $policyObjectFilter\nexcludeHierarchyObjectList: $excludeHierarchyObjectList\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClassificationPolicyDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policies" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClassificationPolicyDetail? Policy
        // GraphQL -> policy: ClassificationPolicyDetail! (type)
        public static string Policy(
            ref ClassificationPolicyDetail? fieldSpec
        )
        {
            string args = "\n(\npolicyId: $policyId\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nclusterIdsFilter: $clusterIdsFilter\nreplicationFilter: $replicationFilter\nsearchObjectName: $searchObjectName\nhierarchyAncestorIdFilter: $hierarchyAncestorIdFilter\npolicyAssignmentType: $policyAssignmentType\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClassificationPolicyDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyDetailConnection? PolicyDetails
        // GraphQL -> policyDetails: PolicyDetailConnection! (type)
        public static string PolicyDetails(
            ref PolicyDetailConnection? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new PolicyDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObj? PolicyObj
        // GraphQL -> policyObj: PolicyObj! (type)
        public static string PolicyObj(
            ref PolicyObj? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolicyObj() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObj" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObj? PolicyObjOpt
        // GraphQL -> policyObjOpt: PolicyObj (type)
        public static string PolicyObjOpt(
            ref PolicyObj? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolicyObj() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjOpt" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObjectUsageConnection? PolicyObjectUsages
        // GraphQL -> policyObjectUsages: PolicyObjectUsageConnection! (type)
        public static string PolicyObjectUsages(
            ref PolicyObjectUsageConnection? fieldSpec
        )
        {
            string args = "\n(\nobjectIds: $objectIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolicyObjectUsageConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjectUsages" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PolicyObjConnection? PolicyObjs
        // GraphQL -> policyObjs: PolicyObjConnection! (type)
        public static string PolicyObjs(
            ref PolicyObjConnection? fieldSpec
        )
        {
            string args = "\n(\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nanalysisStatusesFilter: $analysisStatusesFilter\npolicyIdsFilter: $policyIdsFilter\nriskLevelsFilter: $riskLevelsFilter\nclusterIdsFilter: $clusterIdsFilter\nsearchObjectName: $searchObjectName\nsubscriptionIdsFilter: $subscriptionIdsFilter\nincludeWhitelistedResults: $includeWhitelistedResults\nsids: $sids\nuserAccessObjectsFilter: $userAccessObjectsFilter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PolicyObjConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "policyObjs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrechecksStatusReply? PrechecksStatus
        // GraphQL -> prechecksStatus: PrechecksStatusReply! (type)
        public static string PrechecksStatus(
            ref PrechecksStatusReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrechecksStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prechecksStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrechecksStatusReply? PrechecksStatusWithNextJobInfo
        // GraphQL -> prechecksStatusWithNextJobInfo: PrechecksStatusReply! (type)
        public static string PrechecksStatusWithNextJobInfo(
            ref PrechecksStatusReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrechecksStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "prechecksStatusWithNextJobInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalDetails? PrincipalDetails
        // GraphQL -> principalDetails: PrincipalDetails! (type)
        public static string PrincipalDetails(
            ref PrincipalDetails? fieldSpec
        )
        {
            string args = "\n(\nsid: $sid\ntimelineDate: $timelineDate\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrincipalDetails() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalObjectSummaryConnection? PrincipalObjectSummaries
        // GraphQL -> principalObjectSummaries: PrincipalObjectSummaryConnection! (type)
        public static string PrincipalObjectSummaries(
            ref PrincipalObjectSummaryConnection? fieldSpec
        )
        {
            string args = "\n(\nsids: $sids\nfilter: $filter\ntimelineDate: $timelineDate\nincludeCount: $includeCount\nincludeWhitelistedResults: $includeWhitelistedResults\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrincipalObjectSummaryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalObjectSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskChangesReply? PrincipalRiskChanges
        // GraphQL -> principalRiskChanges: GetPrincipalRiskChangesReply! (type)
        public static string PrincipalRiskChanges(
            ref GetPrincipalRiskChangesReply? fieldSpec
        )
        {
            string args = "\n(\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nlimit: $limit\nstartTime: $startTime\nendTime: $endTime\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetPrincipalRiskChangesReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalRiskChanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetPrincipalRiskTrendReply? PrincipalRiskTrend
        // GraphQL -> principalRiskTrend: GetPrincipalRiskTrendReply! (type)
        public static string PrincipalRiskTrend(
            ref GetPrincipalRiskTrendReply? fieldSpec
        )
        {
            string args = "\n(\nsid: $sid\nstartTime: $startTime\nendTime: $endTime\npolicyId: $policyId\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetPrincipalRiskTrendReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalRiskTrend" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalSummaryConnection? PrincipalSummaries
        // GraphQL -> principalSummaries: PrincipalSummaryConnection! (type)
        public static string PrincipalSummaries(
            ref PrincipalSummaryConnection? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\ntimelineDate: $timelineDate\nsort: $sort\nincludeCount: $includeCount\nhistoricalDeltaDays: $historicalDeltaDays\nincludeWhitelistedResults: $includeWhitelistedResults\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrincipalSummaryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "principalSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProcessedRansomwareInvestigationWorkloadCountReply? ProcessedRansomwareInvestigationWorkloadCount
        // GraphQL -> processedRansomwareInvestigationWorkloadCount: ProcessedRansomwareInvestigationWorkloadCountReply! (type)
        public static string ProcessedRansomwareInvestigationWorkloadCount(
            ref ProcessedRansomwareInvestigationWorkloadCountReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ProcessedRansomwareInvestigationWorkloadCountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "processedRansomwareInvestigationWorkloadCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProductDocumentation? ProductDocumentation
        // GraphQL -> productDocumentation: ProductDocumentation! (type)
        public static string ProductDocumentation(
            ref ProductDocumentation? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ProductDocumentation() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "productDocumentation" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? ProtectedClustersForGlobalSla
        // GraphQL -> protectedClustersForGlobalSla: ClusterConnection! (type)
        public static string ProtectedClustersForGlobalSla(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nslaId: $slaId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedClustersForGlobalSla" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProtectedObjectsConnection? ProtectedObjectsConnection
        // GraphQL -> protectedObjectsConnection: ProtectedObjectsConnection! (type)
        public static string ProtectedObjectsConnection(
            ref ProtectedObjectsConnection? fieldSpec
        )
        {
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ProtectedObjectsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedObjectsConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ProtectedRansomwareInvestigationWorkloadCountReply? ProtectedRansomwareInvestigationWorkloadCount
        // GraphQL -> protectedRansomwareInvestigationWorkloadCount: ProtectedRansomwareInvestigationWorkloadCountReply! (type)
        public static string ProtectedRansomwareInvestigationWorkloadCount(
            ref ProtectedRansomwareInvestigationWorkloadCountReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new ProtectedRansomwareInvestigationWorkloadCountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "protectedRansomwareInvestigationWorkloadCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> QueryDatastoreFreespaceThresholdsReply? QueryDatastoreFreespaceThresholds
        // GraphQL -> queryDatastoreFreespaceThresholds: QueryDatastoreFreespaceThresholdsReply! (type)
        public static string QueryDatastoreFreespaceThresholds(
            ref QueryDatastoreFreespaceThresholdsReply? fieldSpec
        )
        {
            string args = "\n(\nqueryDatastoreFreespaceThresholdsInput: $queryDatastoreFreespaceThresholdsInput\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new QueryDatastoreFreespaceThresholdsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "queryDatastoreFreespaceThresholds" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterConnection? RadarClusterConnection
        // GraphQL -> radarClusterConnection: ClusterConnection! (type)
        public static string RadarClusterConnection(
            ref ClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "radarClusterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ListLocationsReply? RansomwareDetectionWorkloadLocations
        // GraphQL -> ransomwareDetectionWorkloadLocations: ListLocationsReply! (type)
        public static string RansomwareDetectionWorkloadLocations(
            ref ListLocationsReply? fieldSpec
        )
        {
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\nreturnOnlyForAnomalousEntities: $returnOnlyForAnomalousEntities\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ListLocationsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareDetectionWorkloadLocations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationAnalysisSummaryReply? RansomwareInvestigationAnalysisSummary
        // GraphQL -> ransomwareInvestigationAnalysisSummary: RansomwareInvestigationAnalysisSummaryReply! (type)
        public static string RansomwareInvestigationAnalysisSummary(
            ref RansomwareInvestigationAnalysisSummaryReply? fieldSpec
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nhideSuspiciousDataIfNonAnomalous: $hideSuspiciousDataIfNonAnomalous\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareInvestigationAnalysisSummaryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationAnalysisSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationEnablementReply? RansomwareInvestigationEnablement
        // GraphQL -> ransomwareInvestigationEnablement: RansomwareInvestigationEnablementReply! (type)
        public static string RansomwareInvestigationEnablement(
            ref RansomwareInvestigationEnablementReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareInvestigationEnablementReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationEnablement" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationObjectsReply? RansomwareInvestigationObjects
        // GraphQL -> ransomwareInvestigationObjects: RansomwareInvestigationObjectsReply! (type)
        public static string RansomwareInvestigationObjects(
            ref RansomwareInvestigationObjectsReply? fieldSpec
        )
        {
            string args = "\n(\nbeginTime: $beginTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareInvestigationObjectsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareInvestigationWorkloadScannedCountReply? RansomwareInvestigationWorkloadScannedCount
        // GraphQL -> ransomwareInvestigationWorkloadScannedCount: RansomwareInvestigationWorkloadScannedCountReply! (type)
        public static string RansomwareInvestigationWorkloadScannedCount(
            ref RansomwareInvestigationWorkloadScannedCountReply? fieldSpec
        )
        {
            string args = "\n(\nworkloadId: $workloadId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareInvestigationWorkloadScannedCountReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareInvestigationWorkloadScannedCount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareMonitoringPipelineHealth? RansomwareMonitoringPipelineHealth
        // GraphQL -> ransomwareMonitoringPipelineHealth: RansomwareMonitoringPipelineHealth! (type)
        public static string RansomwareMonitoringPipelineHealth(
            ref RansomwareMonitoringPipelineHealth? fieldSpec
        )
        {
            string args = "\n(\nbeginTime: $beginTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareMonitoringPipelineHealth() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareMonitoringPipelineHealth" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareMonitoringTimelineAnalysis? RansomwareMonitoringTimelineAnalysis
        // GraphQL -> ransomwareMonitoringTimelineAnalysis: RansomwareMonitoringTimelineAnalysis! (type)
        public static string RansomwareMonitoringTimelineAnalysis(
            ref RansomwareMonitoringTimelineAnalysis? fieldSpec
        )
        {
            string args = "\n(\nbeginTime: $beginTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareMonitoringTimelineAnalysis() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareMonitoringTimelineAnalysis" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult! (type)
        public static string RansomwareResult(
            ref RansomwareResult? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResult" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResult? RansomwareResultOpt
        // GraphQL -> ransomwareResultOpt: RansomwareResult (type)
        public static string RansomwareResultOpt(
            ref RansomwareResult? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResultOpt" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        public static string RansomwareResults(
            ref RansomwareResultConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResults" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RansomwareResultGroupedDataConnection? RansomwareResultsGrouped
        // GraphQL -> ransomwareResultsGrouped: RansomwareResultGroupedDataConnection! (type)
        public static string RansomwareResultsGrouped(
            ref RansomwareResultGroupedDataConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RansomwareResultGroupedDataConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "ransomwareResultsGrouped" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcsAzureArchivalLocationsConsumptionStatsOutput? RcsArchivalLocationsConsumptionStats
        // GraphQL -> rcsArchivalLocationsConsumptionStats: RcsAzureArchivalLocationsConsumptionStatsOutput! (type)
        public static string RcsArchivalLocationsConsumptionStats(
            ref RcsAzureArchivalLocationsConsumptionStatsOutput? fieldSpec
        )
        {
            string args = "\n(\nrcsAzureTargetConsumptionStatsRequest: $rcsAzureTargetConsumptionStatsRequest\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RcsAzureArchivalLocationsConsumptionStatsOutput() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rcsArchivalLocationsConsumptionStats" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RcvAccountEntitlement? RcvAccountEntitlement
        // GraphQL -> rcvAccountEntitlement: RcvAccountEntitlement! (type)
        public static string RcvAccountEntitlement(
            ref RcvAccountEntitlement? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new RcvAccountEntitlement() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rcvAccountEntitlement" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RdsInstanceDetailsFromAws? RdsInstanceDetailsFromAws
        // GraphQL -> rdsInstanceDetailsFromAws: RdsInstanceDetailsFromAws! (type)
        public static string RdsInstanceDetailsFromAws(
            ref RdsInstanceDetailsFromAws? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RdsInstanceDetailsFromAws() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rdsInstanceDetailsFromAws" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoveryPermissionCheckReply? RecoveryPermissionCheck
        // GraphQL -> recoveryPermissionCheck: RecoveryPermissionCheckReply! (type)
        public static string RecoveryPermissionCheck(
            ref RecoveryPermissionCheckReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RecoveryPermissionCheckReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoveryPermissionCheck" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoveryPlanPermissionCheckReply? RecoveryPlanPermissionCheck
        // GraphQL -> recoveryPlanPermissionCheck: RecoveryPlanPermissionCheckReply! (type)
        public static string RecoveryPlanPermissionCheck(
            ref RecoveryPlanPermissionCheckReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RecoveryPlanPermissionCheckReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "recoveryPlanPermissionCheck" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReleaseNoteConnection? ReleasesNotes
        // GraphQL -> releasesNotes: ReleaseNoteConnection! (type)
        public static string ReleasesNotes(
            ref ReleaseNoteConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nquery: $query\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReleaseNoteConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "releasesNotes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalReplicationBandwidthIncomingResponse? ReplicationIncomingStats
        // GraphQL -> replicationIncomingStats: InternalReplicationBandwidthIncomingResponse! (type)
        public static string ReplicationIncomingStats(
            ref InternalReplicationBandwidthIncomingResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InternalReplicationBandwidthIncomingResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationIncomingStats" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> InternalReplicationBandwidthOutgoingResponse? ReplicationOutgoingStats
        // GraphQL -> replicationOutgoingStats: InternalReplicationBandwidthOutgoingResponse! (type)
        public static string ReplicationOutgoingStats(
            ref InternalReplicationBandwidthOutgoingResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new InternalReplicationBandwidthOutgoingResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationOutgoingStats" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReplicationPairConnection? ReplicationPairs
        // GraphQL -> replicationPairs: ReplicationPairConnection! (type)
        public static string ReplicationPairs(
            ref ReplicationPairConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReplicationPairConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "replicationPairs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReport? Report
        // GraphQL -> report: CustomReport! (type)
        public static string Report(
            ref CustomReport? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CustomReport() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "report" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ChartDataResult? ReportChartData
        // GraphQL -> reportChartData: ChartDataResult! (type)
        public static string ReportChartData(
            ref ChartDataResult? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nchartView: $chartView\nfilters: $filters\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ChartDataResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportChartData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportConfig? ReportConfig
        // GraphQL -> reportConfig: ReportConfig! (type)
        public static string ReportConfig(
            ref ReportConfig? fieldSpec
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReportConfig() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        public static string ReportConnection(
            ref CustomReportConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CustomReportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RowConnection? ReportData
        // GraphQL -> reportData: RowConnection! (type)
        public static string ReportData(
            ref RowConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ndataView: $dataView\ncolumns: $columns\nfilters: $filters\ngroupBy: $groupBy\nsecondaryGroupBy: $secondaryGroupBy\naggregations: $aggregations\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RowConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReport? ReportFromConfig
        // GraphQL -> reportFromConfig: CustomReport! (type)
        public static string ReportFromConfig(
            ref CustomReport? fieldSpec
        )
        {
            string args = "\n(\nconfig: $config\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CustomReport() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportFromConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CustomReportGroupByConnection? ReportGroupByConnection
        // GraphQL -> reportGroupByConnection: CustomReportGroupByConnection! (type)
        public static string ReportGroupByConnection(
            ref CustomReportGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CustomReportGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportSchema? ReportSchema
        // GraphQL -> reportSchema: ReportSchema! (type)
        public static string ReportSchema(
            ref ReportSchema? fieldSpec
        )
        {
            string args = "\n(\ndataView: $dataView\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReportSchema() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportSchema" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RowConnection? ReportTableData
        // GraphQL -> reportTableData: RowConnection! (type)
        public static string ReportTableData(
            ref RowConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ntableView: $tableView\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RowConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportTableData" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ReportVersion? ReportVersion
        // GraphQL -> reportVersion: ReportVersion! (type)
        public static string ReportVersion(
            ref ReportVersion? fieldSpec
        )
        {
            string args = "\n(\nreportID: $reportID\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ReportVersion() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "reportVersion" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RoleTemplateConnection? RoleTemplates
        // GraphQL -> roleTemplates: RoleTemplateConnection! (type)
        public static string RoleTemplates(
            ref RoleTemplateConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nnameFilter: $nameFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RoleTemplateConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "roleTemplates" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RscAutoUpgradeInfo? RscAutoUpgradeInfo
        // GraphQL -> rscAutoUpgradeInfo: RscAutoUpgradeInfo! (type)
        public static string RscAutoUpgradeInfo(
            ref RscAutoUpgradeInfo? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new RscAutoUpgradeInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "rscAutoUpgradeInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RunningJobsReply? RunningJobsStatus
        // GraphQL -> runningJobsStatus: RunningJobsReply! (type)
        public static string RunningJobsStatus(
            ref RunningJobsReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new RunningJobsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "runningJobsStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetS3BucketStateForRecoveryReply? S3BucketStateForRecovery
        // GraphQL -> s3BucketStateForRecovery: GetS3BucketStateForRecoveryReply! (type)
        public static string S3BucketStateForRecovery(
            ref GetS3BucketStateForRecoveryReply? fieldSpec
        )
        {
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetS3BucketStateForRecoveryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "s3BucketStateForRecovery" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<AppItemWithCascadingImpact>? SaasAppCascadingImpact
        // GraphQL -> saasAppCascadingImpact: [AppItemWithCascadingImpact!]! (type)
        public static string SaasAppCascadingImpact(
            ref List<AppItemWithCascadingImpact>? fieldSpec
        )
        {
            string args = "\n(\nrestoreConfig: $restoreConfig\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<AppItemWithCascadingImpact>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "saasAppCascadingImpact" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SaasAppSnapshotConnection? SaasAppItemOverlappingSnapshots
        // GraphQL -> saasAppItemOverlappingSnapshots: SaasAppSnapshotConnection! (type)
        public static string SaasAppItemOverlappingSnapshots(
            ref SaasAppSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nworkloadId: $workloadId\nitemId: $itemId\nappItemTypeToken: $appItemTypeToken\ntimeFilter: $timeFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SaasAppSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "saasAppItemOverlappingSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaDatabase? SapHanaDatabase
        // GraphQL -> sapHanaDatabase: SapHanaDatabase! (type)
        public static string SapHanaDatabase(
            ref SapHanaDatabase? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaDatabase() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaDatabase" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaDatabaseConnection? SapHanaDatabases
        // GraphQL -> sapHanaDatabases: SapHanaDatabaseConnection! (type)
        public static string SapHanaDatabases(
            ref SapHanaDatabaseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaDatabaseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaDatabases" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaLogSnapshot? SapHanaLogSnapshot
        // GraphQL -> sapHanaLogSnapshot: SapHanaLogSnapshot! (type)
        public static string SapHanaLogSnapshot(
            ref SapHanaLogSnapshot? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaLogSnapshot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaLogSnapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaLogSnapshotConnection? SapHanaLogSnapshots
        // GraphQL -> sapHanaLogSnapshots: SapHanaLogSnapshotConnection! (type)
        public static string SapHanaLogSnapshots(
            ref SapHanaLogSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaLogSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaLogSnapshots" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaRecoverableRange? SapHanaRecoverableRange
        // GraphQL -> sapHanaRecoverableRange: SapHanaRecoverableRange! (type)
        public static string SapHanaRecoverableRange(
            ref SapHanaRecoverableRange? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaRecoverableRange() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaRecoverableRangeConnection? SapHanaRecoverableRanges
        // GraphQL -> sapHanaRecoverableRanges: SapHanaRecoverableRangeConnection! (type)
        public static string SapHanaRecoverableRanges(
            ref SapHanaRecoverableRangeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaRecoverableRangeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaRecoverableRanges" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaSystem? SapHanaSystem
        // GraphQL -> sapHanaSystem: SapHanaSystem! (type)
        public static string SapHanaSystem(
            ref SapHanaSystem? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaSystem() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaSystem" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SapHanaSystemConnection? SapHanaSystems
        // GraphQL -> sapHanaSystems: SapHanaSystemConnection! (type)
        public static string SapHanaSystems(
            ref SapHanaSystemConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SapHanaSystemConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sapHanaSystems" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport (type)
        public static string ScheduledReport(
            ref ScheduledReport? fieldSpec
        )
        {
            string args = "\n(\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ScheduledReport() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "scheduledReport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ScheduledReportConnection? ScheduledReports
        // GraphQL -> scheduledReports: ScheduledReportConnection! (type)
        public static string ScheduledReports(
            ref ScheduledReportConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ScheduledReportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "scheduledReports" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TakeScreenshotReply? ScreenshotReport
        // GraphQL -> screenshotReport: TakeScreenshotReply! (type)
        public static string ScreenshotReport(
            ref TakeScreenshotReply? fieldSpec
        )
        {
            string args = "\n(\nreportId: $reportId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TakeScreenshotReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "screenshotReport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> DiffResult? SearchFileByPrefix
        // GraphQL -> searchFileByPrefix: DiffResult! (type)
        public static string SearchFileByPrefix(
            ref DiffResult? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nsearchFolderPath: $searchFolderPath\nfilenamePrefix: $filenamePrefix\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new DiffResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchFileByPrefix" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchHost
        // GraphQL -> searchHost: SearchResponseListResponse! (type)
        public static string SearchHost(
            ref SearchResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\nid: $id\npath: $path\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SearchResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchHost" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchNutanixVm
        // GraphQL -> searchNutanixVm: SearchResponseListResponse! (type)
        public static string SearchNutanixVm(
            ref SearchResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SearchResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchNutanixVm" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SearchResponseListResponse? SearchSnapMirrorCloud
        // GraphQL -> searchSnapMirrorCloud: SearchResponseListResponse! (type)
        public static string SearchSnapMirrorCloud(
            ref SearchResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SearchResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnapMirrorCloud" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableConnection? SearchSnappableConnection
        // GraphQL -> searchSnappableConnection: SnappableConnection! (type)
        public static string SearchSnappableConnection(
            ref SnappableConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnappableConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnappableConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VersionedFileConnection? SearchSnappableVersionedFiles
        // GraphQL -> searchSnappableVersionedFiles: VersionedFileConnection! (type)
        public static string SearchSnappableVersionedFiles(
            ref VersionedFileConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsearchQuery: $searchQuery\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VersionedFileConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchSnappableVersionedFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AppSearchResponseConnection? SearchVappFiles
        // GraphQL -> searchVappFiles: AppSearchResponseConnection! (type)
        public static string SearchVappFiles(
            ref AppSearchResponseConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AppSearchResponseConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "searchVappFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ServiceAccountConnection? ServiceAccounts
        // GraphQL -> serviceAccounts: ServiceAccountConnection! (type)
        public static string ServiceAccounts(
            ref ServiceAccountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ServiceAccountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "serviceAccounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSpExplicitReply? ServiceProviderMetadataFields
        // GraphQL -> serviceProviderMetadataFields: GetSPExplicitReply! (type)
        public static string ServiceProviderMetadataFields(
            ref GetSpExplicitReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetSpExplicitReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "serviceProviderMetadataFields" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ShareFileset? ShareFileset
        // GraphQL -> shareFileset: ShareFileset! (type)
        public static string ShareFileset(
            ref ShareFileset? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ShareFileset() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "shareFileset" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteDescendants
        // GraphQL -> sharepointSiteDescendants: O365FullSpObjectConnection! (type)
        public static string SharepointSiteDescendants(
            ref O365FullSpObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\nsnapshotFid: $snapshotFid\nnaturalId: $naturalId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365FullSpObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sharepointSiteDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteSearch
        // GraphQL -> sharepointSiteSearch: O365FullSpObjectConnection! (type)
        public static string SharepointSiteSearch(
            ref O365FullSpObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\norgId: $orgId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365FullSpObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sharepointSiteSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SidsPolicyHitsSummaries? SidsPolicyHitsSummary
        // GraphQL -> sidsPolicyHitsSummary: SidsPolicyHitsSummaries! (type)
        public static string SidsPolicyHitsSummary(
            ref SidsPolicyHitsSummaries? fieldSpec
        )
        {
            string args = "\n(\nsids: $sids\nday: $day\nhistoricalDeltaDays: $historicalDeltaDays\npolicyId: $policyId\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SidsPolicyHitsSummaries() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sidsPolicyHitsSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnifiedFeatureFlag? SingleUnifiedFeatureFlag
        // GraphQL -> singleUnifiedFeatureFlag: UnifiedFeatureFlag! (type)
        public static string SingleUnifiedFeatureFlag(
            ref UnifiedFeatureFlag? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UnifiedFeatureFlag() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "singleUnifiedFeatureFlag" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> M365SkippedItemInfo? SkippedItemInfo
        // GraphQL -> skippedItemInfo: M365SkippedItemInfo! (type)
        public static string SkippedItemInfo(
            ref M365SkippedItemInfo? fieldSpec
        )
        {
            string args = "\n(\nworkloadFid: $workloadFid\nsnapshotFid: $snapshotFid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new M365SkippedItemInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "skippedItemInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaArchivalValidationWithWarnings? SlaArchivalValidationWarnings
        // GraphQL -> slaArchivalValidationWarnings: SlaArchivalValidationWithWarnings! (type)
        public static string SlaArchivalValidationWarnings(
            ref SlaArchivalValidationWithWarnings? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SlaArchivalValidationWithWarnings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaArchivalValidationWarnings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaAuditDetail>? SlaAuditDetail
        // GraphQL -> slaAuditDetail: [SlaAuditDetail!]! (type)
        public static string SlaAuditDetail(
            ref List<SlaAuditDetail>? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nSlaId: $SlaId\nfilter: $filter\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SlaAuditDetail>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaAuditDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomainWithWarnings? SlaDomainWithWarnings
        // GraphQL -> slaDomainWithWarnings: SlaDomainWithWarnings! (type)
        public static string SlaDomainWithWarnings(
            ref SlaDomainWithWarnings? fieldSpec
        )
        {
            string args = "\n(\nid: $id\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SlaDomainWithWarnings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomainWithWarnings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<SlaDomainWithWarnings>? SlaDomainWithWarningsList
        // GraphQL -> slaDomainWithWarningsList: [SlaDomainWithWarnings!]! (type)
        public static string SlaDomainWithWarningsList(
            ref List<SlaDomainWithWarnings>? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\nobjectIds: $objectIds\napplicableSnappableTypes: $applicableSnappableTypes\nsnapshotIds: $snapshotIds\noperation: $operation\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<SlaDomainWithWarnings>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomainWithWarningsList" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SlaDomainConnection? SlaDomains
        // GraphQL -> slaDomains: SlaDomainConnection! (type)
        public static string SlaDomains(
            ref SlaDomainConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SlaDomainConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaDomains" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolume? SlaManagedVolume
        // GraphQL -> slaManagedVolume: ManagedVolume! (type)
        public static string SlaManagedVolume(
            ref ManagedVolume? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolume() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaManagedVolume" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ManagedVolumeConnection? SlaManagedVolumes
        // GraphQL -> slaManagedVolumes: ManagedVolumeConnection! (type)
        public static string SlaManagedVolumes(
            ref ManagedVolumeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ManagedVolumeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "slaManagedVolumes" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSmbConfigurationReply? SmbConfiguration
        // GraphQL -> smbConfiguration: GetSmbConfigurationReply! (type)
        public static string SmbConfiguration(
            ref GetSmbConfigurationReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetSmbConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smbConfiguration" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SmbDomainConnection? SmbDomains
        // GraphQL -> smbDomains: SmbDomainConnection! (type)
        public static string SmbDomains(
            ref SmbDomainConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SmbDomainConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smbDomains" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSmtpConfigurationReply? SmtpConfiguration
        // GraphQL -> smtpConfiguration: GetSMTPConfigurationReply! (type)
        public static string SmtpConfiguration(
            ref GetSmtpConfigurationReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetSmtpConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "smtpConfiguration" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapMirrorCloud? SnapMirrorCloud
        // GraphQL -> snapMirrorCloud: SnapMirrorCloud! (type)
        public static string SnapMirrorCloud(
            ref SnapMirrorCloud? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapMirrorCloud() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapMirrorCloud" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BrowseResponseListResponse? SnapMirrorCloudSnapshotFiles
        // GraphQL -> snapMirrorCloudSnapshotFiles: BrowseResponseListResponse! (type)
        public static string SnapMirrorCloudSnapshotFiles(
            ref BrowseResponseListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BrowseResponseListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapMirrorCloudSnapshotFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        public static string SnappableConnection(
            ref SnappableConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnappableConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableContactSearch
        // GraphQL -> snappableContactSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableContactSearch(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableContactSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEmailSearch
        // GraphQL -> snappableEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEmailSearch(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableEmailSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEventSearch
        // GraphQL -> snappableEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEventSearch(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableEventSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableGroupByAtSpecifiedTimeConnection? SnappableGroupByAtSpecifiedTimeConnection
        // GraphQL -> snappableGroupByAtSpecifiedTimeConnection: SnappableGroupByAtSpecifiedTimeConnection! (type)
        public static string SnappableGroupByAtSpecifiedTimeConnection(
            ref SnappableGroupByAtSpecifiedTimeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\nspecifiedTime: $specifiedTime\nrequestedAggregations: $requestedAggregations\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnappableGroupByAtSpecifiedTimeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableGroupByAtSpecifiedTimeConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnappableGroupByConnection? SnappableGroupByConnection
        // GraphQL -> snappableGroupByConnection: SnappableGroupByConnection! (type)
        public static string SnappableGroupByConnection(
            ref SnappableGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\nrequestedAggregations: $requestedAggregations\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnappableGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableOnedriveSearch
        // GraphQL -> snappableOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableOnedriveSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableOnedriveSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointDriveSearch
        // GraphQL -> snappableSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointDriveSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableSharepointDriveSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointListSearch
        // GraphQL -> snappableSharepointListSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointListSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableSharepointListSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365TeamsConversationsConnection? SnappableTeamsConversationsSearch
        // GraphQL -> snappableTeamsConversationsSearch: O365TeamsConversationsConnection! (type)
        public static string SnappableTeamsConversationsSearch(
            ref O365TeamsConversationsConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsnapshotFidOpt: $snapshotFidOpt\nteamConvChannels: $teamConvChannels\nteamsConversationsSearchFilter: $teamsConversationsSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365TeamsConversationsConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableTeamsConversationsSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnappableTeamsDriveSearch
        // GraphQL -> snappableTeamsDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableTeamsDriveSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nchannelId: $channelId\nchannelFolderName: $channelFolderName\nteamsDriveSearchFilter: $teamsDriveSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappableTeamsDriveSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> LegalHoldSnappableDetailConnection? SnappablesWithLegalHoldSnapshotsSummary
        // GraphQL -> snappablesWithLegalHoldSnapshotsSummary: LegalHoldSnappableDetailConnection! (type)
        public static string SnappablesWithLegalHoldSnapshotsSummary(
            ref LegalHoldSnappableDetailConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new LegalHoldSnappableDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snappablesWithLegalHoldSnapshotsSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        public static string Snapshot(
            ref CdmSnapshot? fieldSpec
        )
        {
            string args = "\n(\nsnapshotFid: $snapshotFid\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmSnapshot() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshot" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEmailSearch
        // GraphQL -> snapshotEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEmailSearch(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotEmailSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEventSearch
        // GraphQL -> snapshotEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEventSearch(
            ref O365ExchangeObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365ExchangeObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotEventSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileDeltaConnection? SnapshotFilesDelta
        // GraphQL -> snapshotFilesDelta: SnapshotFileDeltaConnection! (type)
        public static string SnapshotFilesDelta(
            ref SnapshotFileDeltaConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotFileDeltaConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotFilesDelta" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotFileDeltaV2Connection? SnapshotFilesDeltaV2
        // GraphQL -> snapshotFilesDeltaV2: SnapshotFileDeltaV2Connection! (type)
        public static string SnapshotFilesDeltaV2(
            ref SnapshotFileDeltaV2Connection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotFileDeltaV2Connection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotFilesDeltaV2" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfAsnappableConnection
        // GraphQL -> snapshotOfASnappableConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfAsnappableConnection(
            ref GenericSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nworkloadId: $workloadId\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GenericSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOfASnappableConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfSnappablesConnection
        // GraphQL -> snapshotOfSnappablesConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfSnappablesConnection(
            ref GenericSnapshotConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsnappableIds: $snappableIds\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GenericSnapshotConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOfSnappablesConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotOnedriveSearch
        // GraphQL -> snapshotOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotOnedriveSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotOnedriveSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotResultConnection? SnapshotResults
        // GraphQL -> snapshotResults: SnapshotResultConnection! (type)
        public static string SnapshotResults(
            ref SnapshotResultConnection? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nstartTimeMs: $startTimeMs\nendTimeMs: $endTimeMs\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotResults" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotSharepointDriveSearch
        // GraphQL -> snapshotSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotSharepointDriveSearch(
            ref O365OnedriveObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new O365OnedriveObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotSharepointDriveSearch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotsMalwareInfoReply? SnapshotsAnomalyInfo
        // GraphQL -> snapshotsAnomalyInfo: SnapshotsMalwareInfoReply! (type)
        public static string SnapshotsAnomalyInfo(
            ref SnapshotsMalwareInfoReply? fieldSpec
        )
        {
            string args = "\n(\nsnapshotMalware: $snapshotMalware\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotsMalwareInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsAnomalyInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotSummaryConnection? SnapshotsForUnmanagedObject
        // GraphQL -> snapshotsForUnmanagedObject: SnapshotSummaryConnection! (type)
        public static string SnapshotsForUnmanagedObject(
            ref SnapshotSummaryConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotSummaryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsForUnmanagedObject" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnapshotsMalwareInfoReply? SnapshotsMalwareInfo
        // GraphQL -> snapshotsMalwareInfo: SnapshotsMalwareInfoReply! (type)
        public static string SnapshotsMalwareInfo(
            ref SnapshotsMalwareInfoReply? fieldSpec
        )
        {
            string args = "\n(\nsnapshotMalware: $snapshotMalware\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnapshotsMalwareInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snapshotsMalwareInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SnmpConfiguration? SnmpConfigurations
        // GraphQL -> snmpConfigurations: SnmpConfiguration! (type)
        public static string SnmpConfigurations(
            ref SnmpConfiguration? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SnmpConfiguration() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "snmpConfigurations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarContentReportConnection? SonarContentReport
        // GraphQL -> sonarContentReport: SonarContentReportConnection! (type)
        public static string SonarContentReport(
            ref SonarContentReportConnection? fieldSpec
        )
        {
            string args = "\n(\ngroupBy: $groupBy\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SonarContentReportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarContentReport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarReportConnection? SonarReport
        // GraphQL -> sonarReport: SonarReportConnection! (type)
        public static string SonarReport(
            ref SonarReportConnection? fieldSpec
        )
        {
            string args = "\n(\nsonarReportGroupBy: $sonarReportGroupBy\nfilter: $filter\ntimeFilter: $timeFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SonarReportConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarReport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SonarReportRowConnection? SonarReportRow
        // GraphQL -> sonarReportRow: SonarReportRowConnection! (type)
        public static string SonarReportRow(
            ref SonarReportRowConnection? fieldSpec
        )
        {
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nendTime: $endTime\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SonarReportRowConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarReportRow" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccessGroupConnection? SonarUserGroups
        // GraphQL -> sonarUserGroups: AccessGroupConnection! (type)
        public static string SonarUserGroups(
            ref AccessGroupConnection? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AccessGroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarUserGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AccessUserConnection? SonarUsers
        // GraphQL -> sonarUsers: AccessUserConnection! (type)
        public static string SonarUsers(
            ref AccessUserConnection? fieldSpec
        )
        {
            string args = "\n(\nsort: $sort\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AccessUserConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sonarUsers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SourceBlueprintInfo? SourceBlueprintInfo
        // GraphQL -> sourceBlueprintInfo: SourceBlueprintInfo! (type)
        public static string SourceBlueprintInfo(
            ref SourceBlueprintInfo? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SourceBlueprintInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "sourceBlueprintInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? SupportBundle
        // GraphQL -> supportBundle: AsyncRequestStatus! (type)
        public static string SupportBundle(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportBundle" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportPortalRole? SupportPortalRole
        // GraphQL -> supportPortalRole: SupportPortalRole! (type)
        public static string SupportPortalRole(
            ref SupportPortalRole? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new SupportPortalRole() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportPortalRole" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportUserAccessConnection? SupportUserAccesses
        // GraphQL -> supportUserAccesses: SupportUserAccessConnection! (type)
        public static string SupportUserAccesses(
            ref SupportUserAccessConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SupportUserAccessConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "supportUserAccesses" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetSyslogConfigurationReply? SyslogConfiguration
        // GraphQL -> syslogConfiguration: GetSyslogConfigurationReply! (type)
        public static string SyslogConfiguration(
            ref GetSyslogConfigurationReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetSyslogConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "syslogConfiguration" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SyslogExportRuleSummaryListResponse? SyslogExportRules
        // GraphQL -> syslogExportRules: SyslogExportRuleSummaryListResponse! (type)
        public static string SyslogExportRules(
            ref SyslogExportRuleSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SyslogExportRuleSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "syslogExportRules" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TableFilters? TableFilters
        // GraphQL -> tableFilters: TableFilters! (type)
        public static string TableFilters(
            ref TableFilters? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new TableFilters() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tableFilters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        public static string TargetMapping(
            ref TargetMapping? fieldSpec
        )
        {
            string args = "\n(\ntargetMappingId: $targetMappingId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TargetMapping() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "targetMapping" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TargetConnection? Targets
        // GraphQL -> targets: TargetConnection! (type)
        public static string Targets(
            ref TargetConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TargetConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "targets" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        public static string TaskDetailConnection(
            ref TaskDetailConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TaskDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskDetailConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskDetailGroupByConnection? TaskDetailGroupByConnection
        // GraphQL -> taskDetailGroupByConnection: TaskDetailGroupByConnection! (type)
        public static string TaskDetailGroupByConnection(
            ref TaskDetailGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TaskDetailGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskDetailGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        public static string TaskSummaryConnection(
            ref TaskSummaryConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TaskSummaryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskSummaryConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskSummaryGroupByConnection? TaskSummaryGroupByConnection
        // GraphQL -> taskSummaryGroupByConnection: TaskSummaryGroupByConnection! (type)
        public static string TaskSummaryGroupByConnection(
            ref TaskSummaryGroupByConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TaskSummaryGroupByConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskSummaryGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TaskchainInfoReply? TaskchainInfo
        // GraphQL -> taskchainInfo: TaskchainInfoReply! (type)
        public static string TaskchainInfo(
            ref TaskchainInfoReply? fieldSpec
        )
        {
            string args = "\n(\ntaskchainId: $taskchainId\njobType: $jobType\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TaskchainInfoReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "taskchainInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHunt? ThreatHuntDetail
        // GraphQL -> threatHuntDetail: ThreatHunt! (type)
        public static string ThreatHuntDetail(
            ref ThreatHunt? fieldSpec
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatHunt() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntResult? ThreatHuntResult
        // GraphQL -> threatHuntResult: ThreatHuntResult! (type)
        public static string ThreatHuntResult(
            ref ThreatHuntResult? fieldSpec
        )
        {
            string args = "\n(\nhuntId: $huntId\nobjectId: $objectId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatHuntResult() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntResult" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? ThreatHuntStatus
        // GraphQL -> threatHuntStatus: AsyncRequestStatus! (type)
        public static string ThreatHuntStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntSummaryReply? ThreatHuntSummary
        // GraphQL -> threatHuntSummary: ThreatHuntSummaryReply! (type)
        public static string ThreatHuntSummary(
            ref ThreatHuntSummaryReply? fieldSpec
        )
        {
            string args = "\n(\nhuntId: $huntId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatHuntSummaryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHuntSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatHuntConnection? ThreatHunts
        // GraphQL -> threatHunts: ThreatHuntConnection! (type)
        public static string ThreatHunts(
            ref ThreatHuntConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nclusterUuidFilter: $clusterUuidFilter\nstatusFilter: $statusFilter\nmatchesFoundFilter: $matchesFoundFilter\nquarantinedMatchesFilter: $quarantinedMatchesFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatHuntConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatHunts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatMonitoringFileMatchDetailsReply? ThreatMonitoringMatchedFileDetails
        // GraphQL -> threatMonitoringMatchedFileDetails: ThreatMonitoringFileMatchDetailsReply! (type)
        public static string ThreatMonitoringMatchedFileDetails(
            ref ThreatMonitoringFileMatchDetailsReply? fieldSpec
        )
        {
            string args = "\n(\nmatchId: $matchId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatMonitoringFileMatchDetailsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedFileDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileMatchConnection? ThreatMonitoringMatchedFiles
        // GraphQL -> threatMonitoringMatchedFiles: FileMatchConnection! (type)
        public static string ThreatMonitoringMatchedFiles(
            ref FileMatchConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nobjectFid: $objectFid\nfilenameSearchFilter: $filenameSearchFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FileMatchConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedFiles" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ThreatMonitoringMatchedObjectConnection? ThreatMonitoringMatchedObjects
        // GraphQL -> threatMonitoringMatchedObjects: ThreatMonitoringMatchedObjectConnection! (type)
        public static string ThreatMonitoringMatchedObjects(
            ref ThreatMonitoringMatchedObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nclusterUuidFilter: $clusterUuidFilter\nobjectTypeFilter: $objectTypeFilter\nworkloadNameSearch: $workloadNameSearch\nmatchTypeFilter: $matchTypeFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ThreatMonitoringMatchedObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "threatMonitoringMatchedObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TopRiskPrincipalsReply? TopRiskPrincipals
        // GraphQL -> topRiskPrincipals: TopRiskPrincipalsReply! (type)
        public static string TopRiskPrincipals(
            ref TopRiskPrincipalsReply? fieldSpec
        )
        {
            string args = "\n(\nprincipalRiskSummaryPrincipalType: $principalRiskSummaryPrincipalType\nlimit: $limit\npolicyId: $policyId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TopRiskPrincipalsReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "topRiskPrincipals" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetTotpStatusReply? TotpConfigStatus
        // GraphQL -> totpConfigStatus: GetTotpStatusReply! (type)
        public static string TotpConfigStatus(
            ref GetTotpStatusReply? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetTotpStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "totpConfigStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetTprConfigurationReply? TprConfiguration
        // GraphQL -> tprConfiguration: GetTprConfigurationReply! (type)
        public static string TprConfiguration(
            ref GetTprConfigurationReply? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetTprConfigurationReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprConfiguration" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprPolicyDetail? TprPolicyDetail
        // GraphQL -> tprPolicyDetail: TprPolicyDetail! (type)
        public static string TprPolicyDetail(
            ref TprPolicyDetail? fieldSpec
        )
        {
            string args = "\n(\ntprPolicyId: $tprPolicyId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TprPolicyDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprPolicyDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRequestDetailReply? TprRequestDetail
        // GraphQL -> tprRequestDetail: TprRequestDetailReply! (type)
        public static string TprRequestDetail(
            ref TprRequestDetailReply? fieldSpec
        )
        {
            string args = "\n(\ntprRequestId: $tprRequestId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TprRequestDetailReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRequestDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRequestSummaryConnection? TprRequestSummaries
        // GraphQL -> tprRequestSummaries: TprRequestSummaryConnection! (type)
        public static string TprRequestSummaries(
            ref TprRequestSummaryConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TprRequestSummaryConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRequestSummaries" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRoleEligibilityType? TprRoleEligibility
        // GraphQL -> tprRoleEligibility: TprRoleEligibilityType! (type)
        public static string TprRoleEligibility(
            ref TprRoleEligibilityType? fieldSpec
        )
        {
            string args = "\n(\norgId: $orgId\nemail: $email\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new TprRoleEligibilityType() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRoleEligibility" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> TprRulesMap? TprRulesMap
        // GraphQL -> tprRulesMap: TprRulesMap! (type)
        public static string TprRulesMap(
            ref TprRulesMap? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new TprRulesMap() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tprRulesMap" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> SupportTunnelInfo? TunnelStatus
        // GraphQL -> tunnelStatus: SupportTunnelInfo! (type)
        public static string TunnelStatus(
            ref SupportTunnelInfo? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new SupportTunnelInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "tunnelStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UnmanagedObjectDetailConnection? UnmanagedObjects
        // GraphQL -> unmanagedObjects: UnmanagedObjectDetailConnection! (type)
        public static string UnmanagedObjects(
            ref UnmanagedObjectDetailConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UnmanagedObjectDetailConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "unmanagedObjects" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UpgradeStatusReply? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatusReply! (type)
        public static string UpgradeStatus(
            ref UpgradeStatusReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UpgradeStatusReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "upgradeStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> PrincipalInsightConnection? UserAccessInsights
        // GraphQL -> userAccessInsights: PrincipalInsightConnection! (type)
        public static string UserAccessInsights(
            ref PrincipalInsightConnection? fieldSpec
        )
        {
            string args = "\n(\nstartTime: $startTime\nendTime: $endTime\nincludeWhitelistedResults: $includeWhitelistedResults\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new PrincipalInsightConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAccessInsights" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> FileResultConnection? UserActivities
        // GraphQL -> userActivities: FileResultConnection! (type)
        public static string UserActivities(
            ref FileResultConnection? fieldSpec
        )
        {
            string args = "\n(\nfilter: $filter\nsort: $sort\ntimeRange: $timeRange\nuserId: $userId\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new FileResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userActivities" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivityTimelineResultConnection? UserActivityTimeline
        // GraphQL -> userActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserActivityTimeline(
            ref ActivityTimelineResultConnection? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nuniqueActivities: $uniqueActivities\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActivityTimelineResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userActivityTimeline" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AnalyzerAccessUsageConnection? UserAnalyzerAccess
        // GraphQL -> userAnalyzerAccess: AnalyzerAccessUsageConnection! (type)
        public static string UserAnalyzerAccess(
            ref AnalyzerAccessUsageConnection? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nlimit: $limit\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AnalyzerAccessUsageConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAnalyzerAccess" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserAuditConnection? UserAuditConnection
        // GraphQL -> userAuditConnection: UserAuditConnection! (type)
        public static string UserAuditConnection(
            ref UserAuditConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UserAuditConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAuditConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserAuditGroupByInfoConnection? UserAuditGroupByConnection
        // GraphQL -> userAuditGroupByConnection: UserAuditGroupByInfoConnection! (type)
        public static string UserAuditGroupByConnection(
            ref UserAuditGroupByInfoConnection? fieldSpec
        )
        {
            string args = "\n(\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\nprimaryGroupBy: $primaryGroupBy\nsecondaryGroupBy: $secondaryGroupBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UserAuditGroupByInfoConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userAuditGroupByConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUserDetailReply? UserDetail
        // GraphQL -> userDetail: GetUserDetailReply! (type)
        public static string UserDetail(
            ref GetUserDetailReply? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetUserDetailReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userDetail" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ActivityTimelineResultConnection? UserFileActivityTimeline
        // GraphQL -> userFileActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserFileActivityTimeline(
            ref ActivityTimelineResultConnection? fieldSpec
        )
        {
            string args = "\n(\nuserId: $userId\nresource: $resource\nnativePath: $nativePath\nstartDay: $startDay\ntimezone: $timezone\ntimeGranularity: $timeGranularity\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ActivityTimelineResultConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userFileActivityTimeline" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<Group>? UserGroups
        // GraphQL -> userGroups: [Group!]! (type)
        public static string UserGroups(
            ref List<Group>? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nroleIdsFilter: $roleIdsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<Group>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userGroups" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserNotifications? UserNotifications
        // GraphQL -> userNotifications: UserNotifications! (type)
        public static string UserNotifications(
            ref UserNotifications? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new UserNotifications() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userNotifications" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUserSessionManagementConfigReply? UserSessionManagementConfig
        // GraphQL -> userSessionManagementConfig: GetUserSessionManagementConfigReply! (type)
        public static string UserSessionManagementConfig(
            ref GetUserSessionManagementConfigReply? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new GetUserSessionManagementConfigReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userSessionManagementConfig" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserSettings? UserSettings
        // GraphQL -> userSettings: UserSettings! (type)
        public static string UserSettings(
            ref UserSettings? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new UserSettings() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "userSettings" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> UserConnection? UsersInCurrentAndDescendantOrganization
        // GraphQL -> usersInCurrentAndDescendantOrganization: UserConnection! (type)
        public static string UsersInCurrentAndDescendantOrganization(
            ref UserConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\nshouldIncludeUserWithoutRole: $shouldIncludeUserWithoutRole\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new UserConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "usersInCurrentAndDescendantOrganization" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetUsersSummaryReply? UsersSummary
        // GraphQL -> usersSummary: GetUsersSummaryReply! (type)
        public static string UsersSummary(
            ref GetUsersSummaryReply? fieldSpec
        )
        {
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetUsersSummaryReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "usersSummary" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcenterAdvancedTagPreviewReply? VcenterAdvancedTagPreview
        // GraphQL -> vCenterAdvancedTagPreview: VcenterAdvancedTagPreviewReply! (type)
        public static string VcenterAdvancedTagPreview(
            ref VcenterAdvancedTagPreviewReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcenterAdvancedTagPreviewReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterAdvancedTagPreview" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HotAddBandwidthInfo? VcenterHotAddBandwidth
        // GraphQL -> vCenterHotAddBandwidth: HotAddBandwidthInfo! (type)
        public static string VcenterHotAddBandwidth(
            ref HotAddBandwidthInfo? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HotAddBandwidthInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterHotAddBandwidth" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> HotAddNetworkConfigWithName? VcenterHotAddNetwork
        // GraphQL -> vCenterHotAddNetwork: HotAddNetworkConfigWithName! (type)
        public static string VcenterHotAddNetwork(
            ref HotAddNetworkConfigWithName? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new HotAddNetworkConfigWithName() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterHotAddNetwork" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> NetworkInfoListResponse? VcenterNetworks
        // GraphQL -> vCenterNetworks: NetworkInfoListResponse! (type)
        public static string VcenterNetworks(
            ref NetworkInfoListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new NetworkInfoListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterNetworks" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcenterPreAddInfo? VcenterPreAddInfo
        // GraphQL -> vCenterPreAddInfo: VcenterPreAddInfo! (type)
        public static string VcenterPreAddInfo(
            ref VcenterPreAddInfo? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcenterPreAddInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vCenterPreAddInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereBlueprint? VsphereBlueprint
        // GraphQL -> vSphereBlueprint: VSphereBlueprint! (type)
        public static string VsphereBlueprint(
            ref VsphereBlueprint? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereBlueprint() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereBlueprint" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereComputeCluster? VsphereComputeCluster
        // GraphQL -> vSphereComputeCluster: VsphereComputeCluster! (type)
        public static string VsphereComputeCluster(
            ref VsphereComputeCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereComputeCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereComputeCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereComputeClusterConnection? VsphereComputeClusters
        // GraphQL -> vSphereComputeClusters: VsphereComputeClusterConnection! (type)
        public static string VsphereComputeClusters(
            ref VsphereComputeClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereComputeClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereComputeClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatacenter? VsphereDatacenter
        // GraphQL -> vSphereDatacenter: VsphereDatacenter! (type)
        public static string VsphereDatacenter(
            ref VsphereDatacenter? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereDatacenter() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatacenter" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastore? VsphereDatastore
        // GraphQL -> vSphereDatastore: VsphereDatastore! (type)
        public static string VsphereDatastore(
            ref VsphereDatastore? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereDatastore() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastore" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreCluster? VsphereDatastoreCluster
        // GraphQL -> vSphereDatastoreCluster: VsphereDatastoreCluster! (type)
        public static string VsphereDatastoreCluster(
            ref VsphereDatastoreCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereDatastoreCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreClusterConnection? VsphereDatastoreClusters
        // GraphQL -> vSphereDatastoreClusters: VsphereDatastoreClusterConnection! (type)
        public static string VsphereDatastoreClusters(
            ref VsphereDatastoreClusterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereDatastoreClusterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereDatastoreConnection? VsphereDatastoreConnection
        // GraphQL -> vSphereDatastoreConnection: VsphereDatastoreConnection! (type)
        public static string VsphereDatastoreConnection(
            ref VsphereDatastoreConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereDatastoreConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereDatastoreConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereFolder? VsphereFolder
        // GraphQL -> vSphereFolder: VsphereFolder! (type)
        public static string VsphereFolder(
            ref VsphereFolder? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereFolder() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereFolder" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereHost? VsphereHost
        // GraphQL -> vSphereHost: VsphereHost! (type)
        public static string VsphereHost(
            ref VsphereHost? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereHost() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHost" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereHostConnection? VsphereHostConnection
        // GraphQL -> vSphereHostConnection: VsphereHostConnection! (type)
        public static string VsphereHostConnection(
            ref VsphereHostConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereHostConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VmwareHostDetail? VsphereHostDetails
        // GraphQL -> vSphereHostDetails: VmwareHostDetail! (type)
        public static string VsphereHostDetails(
            ref VmwareHostDetail? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VmwareHostDetail() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostDetails" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> List<VsphereHost>? VsphereHostsByFids
        // GraphQL -> vSphereHostsByFids: [VsphereHost!]! (type)
        public static string VsphereHostsByFids(
            ref List<VsphereHost>? fieldSpec
        )
        {
            string args = "\n(\nfids: $fids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new List<VsphereHost>() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereHostsByFids" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        public static string VsphereLiveMounts(
            ref VsphereLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereLiveMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereMount? VsphereMount
        // GraphQL -> vSphereMount: VsphereMount! (type)
        public static string VsphereMount(
            ref VsphereMount? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereMount() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereMount" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereMountConnection? VsphereMountConnection
        // GraphQL -> vSphereMountConnection: VsphereMountConnection! (type)
        public static string VsphereMountConnection(
            ref VsphereMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereMountConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereNetwork? VsphereNetwork
        // GraphQL -> vSphereNetwork: VsphereNetwork! (type)
        public static string VsphereNetwork(
            ref VsphereNetwork? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereNetwork() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereNetwork" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereResourcePool? VsphereResourcePool
        // GraphQL -> vSphereResourcePool: VsphereResourcePool! (type)
        public static string VsphereResourcePool(
            ref VsphereResourcePool? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereResourcePool() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereResourcePool" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereRootRecoveryHierarchy
        // GraphQL -> vSphereRootRecoveryHierarchy: CdmHierarchyObjectConnection! (type)
        public static string VsphereRootRecoveryHierarchy(
            ref CdmHierarchyObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmHierarchyObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereRootRecoveryHierarchy" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereTag? VsphereTag
        // GraphQL -> vSphereTag: VsphereTag! (type)
        public static string VsphereTag(
            ref VsphereTag? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereTag() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTag" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereTagCategory? VsphereTagCategory
        // GraphQL -> vSphereTagCategory: VsphereTagCategory! (type)
        public static string VsphereTagCategory(
            ref VsphereTagCategory? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereTagCategory() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTagCategory" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereTopLevelDescendantsConnection
        // GraphQL -> vSphereTopLevelDescendantsConnection: CdmHierarchyObjectConnection! (type)
        public static string VsphereTopLevelDescendantsConnection(
            ref CdmHierarchyObjectConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CdmHierarchyObjectConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereTopLevelDescendantsConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVcenter? VsphereVcenter
        // GraphQL -> vSphereVCenter: VsphereVcenter! (type)
        public static string VsphereVcenter(
            ref VsphereVcenter? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereVcenter() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVCenter" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVcenterConnection? VsphereVcenterConnection
        // GraphQL -> vSphereVCenterConnection: VsphereVcenterConnection! (type)
        public static string VsphereVcenterConnection(
            ref VsphereVcenterConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereVcenterConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVCenterConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> AsyncRequestStatus? VsphereVmAsyncRequestStatus
        // GraphQL -> vSphereVMAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string VsphereVmAsyncRequestStatus(
            ref AsyncRequestStatus? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nid: $id\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new AsyncRequestStatus() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVMAsyncRequestStatus" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVm? VsphereVmNew
        // GraphQL -> vSphereVmNew: VsphereVm! (type)
        public static string VsphereVmNew(
            ref VsphereVm? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereVm() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVmNew" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmConnection? VsphereVmNewConnection
        // GraphQL -> vSphereVmNewConnection: VsphereVmConnection! (type)
        public static string VsphereVmNewConnection(
            ref VsphereVmConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereVmConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vSphereVmNewConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAwsNativeRdsClusterNameForExportReply? ValidateAwsNativeRdsClusterNameForExport
        // GraphQL -> validateAwsNativeRdsClusterNameForExport: ValidateAwsNativeRdsClusterNameForExportReply! (type)
        public static string ValidateAwsNativeRdsClusterNameForExport(
            ref ValidateAwsNativeRdsClusterNameForExportReply? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsClusterName: $rdsClusterName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateAwsNativeRdsClusterNameForExportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAwsNativeRdsClusterNameForExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAwsNativeRdsInstanceNameForExportReply? ValidateAwsNativeRdsInstanceNameForExport
        // GraphQL -> validateAwsNativeRdsInstanceNameForExport: ValidateAwsNativeRdsInstanceNameForExportReply! (type)
        public static string ValidateAwsNativeRdsInstanceNameForExport(
            ref ValidateAwsNativeRdsInstanceNameForExportReply? fieldSpec
        )
        {
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateAwsNativeRdsInstanceNameForExportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAwsNativeRdsInstanceNameForExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureSubnetsForCloudAccountExocomputeReply? ValidateAzureCloudAccountExocomputeConfigurations
        // GraphQL -> validateAzureCloudAccountExocomputeConfigurations: ValidateAzureSubnetsForCloudAccountExocomputeReply! (type)
        public static string ValidateAzureCloudAccountExocomputeConfigurations(
            ref ValidateAzureSubnetsForCloudAccountExocomputeReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateAzureSubnetsForCloudAccountExocomputeReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureNativeSqlDatabaseDbNameForExportReply? ValidateAzureNativeSqlDatabaseDbNameForExport
        // GraphQL -> validateAzureNativeSqlDatabaseDbNameForExport: ValidateAzureNativeSqlDatabaseDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlDatabaseDbNameForExport(
            ref ValidateAzureNativeSqlDatabaseDbNameForExportReply? fieldSpec
        )
        {
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateAzureNativeSqlDatabaseDbNameForExportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureNativeSqlDatabaseDbNameForExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? ValidateAzureNativeSqlManagedInstanceDbNameForExport
        // GraphQL -> validateAzureNativeSqlManagedInstanceDbNameForExport: ValidateAzureNativeSqlManagedInstanceDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlManagedInstanceDbNameForExport(
            ref ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? fieldSpec
        )
        {
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateAzureNativeSqlManagedInstanceDbNameForExportReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateAzureNativeSqlManagedInstanceDbNameForExport" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateCertificateReply? ValidateCertificate
        // GraphQL -> validateCertificate: ValidateCertificateReply! (type)
        public static string ValidateCertificate(
            ref ValidateCertificateReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateCertificateReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateCertificate" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ClusterLicenseCapacityValidations? ValidateClusterLicenseCapacity
        // GraphQL -> validateClusterLicenseCapacity: ClusterLicenseCapacityValidations! (type)
        public static string ValidateClusterLicenseCapacity(
            ref ClusterLicenseCapacityValidations? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ClusterLicenseCapacityValidations() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateClusterLicenseCapacity" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> ValidateOrgNameReply? ValidateOrgName
        // GraphQL -> validateOrgName: ValidateOrgNameReply! (type)
        public static string ValidateOrgName(
            ref ValidateOrgNameReply? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new ValidateOrgNameReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "validateOrgName" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappExportOptions? VappSnapshotExportOptions
        // GraphQL -> vappSnapshotExportOptions: VappExportOptions! (type)
        public static string VappSnapshotExportOptions(
            ref VappExportOptions? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VappExportOptions() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappSnapshotExportOptions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappInstantRecoveryOptions? VappSnapshotInstantRecoveryOptions
        // GraphQL -> vappSnapshotInstantRecoveryOptions: VappInstantRecoveryOptions! (type)
        public static string VappSnapshotInstantRecoveryOptions(
            ref VappInstantRecoveryOptions? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VappInstantRecoveryOptions() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappSnapshotInstantRecoveryOptions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VappTemplateExportOptionsUnion? VappTemplateSnapshotExportOptions
        // GraphQL -> vappTemplateSnapshotExportOptions: VappTemplateExportOptionsUnion! (type)
        public static string VappTemplateSnapshotExportOptions(
            ref VappTemplateExportOptionsUnion? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VappTemplateExportOptionsUnion() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vappTemplateSnapshotExportOptions" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> Vcd? Vcd
        // GraphQL -> vcd: Vcd! (type)
        public static string Vcd(
            ref Vcd? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new Vcd() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcd" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdCatalog? VcdCatalog
        // GraphQL -> vcdCatalog: VcdCatalog! (type)
        public static string VcdCatalog(
            ref VcdCatalog? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdCatalog() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdCatalog" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdClusterSummaryListResponse? VcdClusters
        // GraphQL -> vcdClusters: VcdClusterSummaryListResponse! (type)
        public static string VcdClusters(
            ref VcdClusterSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdClusterSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdClusters" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrg? VcdOrg
        // GraphQL -> vcdOrg: VcdOrg! (type)
        public static string VcdOrg(
            ref VcdOrg? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdOrg() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrg" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrgVdc? VcdOrgVdc
        // GraphQL -> vcdOrgVdc: VcdOrgVdc! (type)
        public static string VcdOrgVdc(
            ref VcdOrgVdc? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdOrgVdc() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrgVdc" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdOrgConnection? VcdOrgs
        // GraphQL -> vcdOrgs: VcdOrgConnection! (type)
        public static string VcdOrgs(
            ref VcdOrgConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdOrgConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdOrgs" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdTopLevelDescendantTypeConnection? VcdTopLevelDescendants
        // GraphQL -> vcdTopLevelDescendants: VcdTopLevelDescendantTypeConnection! (type)
        public static string VcdTopLevelDescendants(
            ref VcdTopLevelDescendantTypeConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdTopLevelDescendantTypeConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdTopLevelDescendants" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVapp? VcdVapp
        // GraphQL -> vcdVapp: VcdVapp! (type)
        public static string VcdVapp(
            ref VcdVapp? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdVapp() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVapp" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VsphereVmConnection? VcdVappVms
        // GraphQL -> vcdVappVms: VsphereVmConnection! (type)
        public static string VcdVappVms(
            ref VsphereVmConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VsphereVmConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVappVms" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVappConnection? VcdVapps
        // GraphQL -> vcdVapps: VcdVappConnection! (type)
        public static string VcdVapps(
            ref VcdVappConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdVappConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVapps" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VcdVimServer? VcdVimServer
        // GraphQL -> vcdVimServer: VcdVimServer! (type)
        public static string VcdVimServer(
            ref VcdVimServer? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VcdVimServer() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVimServer" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VimserverSummaryListResponse? VcdVimServers
        // GraphQL -> vcdVimServers: VimserverSummaryListResponse! (type)
        public static string VcdVimServers(
            ref VimserverSummaryListResponse? fieldSpec
        )
        {
            string args = "\n(\ninput: $input\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VimserverSummaryListResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vcdVimServers" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VerifySlaWithReplicationToClusterResponse? VerifySlaWithReplicationToCluster
        // GraphQL -> verifySlaWithReplicationToCluster: VerifySlaWithReplicationToClusterResponse! (type)
        public static string VerifySlaWithReplicationToCluster(
            ref VerifySlaWithReplicationToClusterResponse? fieldSpec
        )
        {
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VerifySlaWithReplicationToClusterResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "verifySlaWithReplicationToCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CheckVmwareVmsRecoveryPermissionReply? VmwareVmsRecoveryPermissionCheck
        // GraphQL -> vmwareVmsRecoveryPermissionCheck: CheckVmwareVmsRecoveryPermissionReply! (type)
        public static string VmwareVmsRecoveryPermissionCheck(
            ref CheckVmwareVmsRecoveryPermissionReply? fieldSpec
        )
        {
            string args = "\n(\ncheckVmwareVmsRecoveryPermission: $checkVmwareVmsRecoveryPermission\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new CheckVmwareVmsRecoveryPermissionReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vmwareVmsRecoveryPermissionCheck" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroup? VolumeGroup
        // GraphQL -> volumeGroup: VolumeGroup! (type)
        public static string VolumeGroup(
            ref VolumeGroup? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VolumeGroup() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroup" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroupConnection? VolumeGroupConnection
        // GraphQL -> volumeGroupConnection: VolumeGroupConnection! (type)
        public static string VolumeGroupConnection(
            ref VolumeGroupConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VolumeGroupConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroupConnection" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> VolumeGroupLiveMountConnection? VolumeGroupMounts
        // GraphQL -> volumeGroupMounts: VolumeGroupLiveMountConnection! (type)
        public static string VolumeGroupMounts(
            ref VolumeGroupLiveMountConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new VolumeGroupLiveMountConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "volumeGroupMounts" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoverableRangeResponse? VsphereVmMissedRecoverableRange
        // GraphQL -> vsphereVMMissedRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmMissedRecoverableRange(
            ref RecoverableRangeResponse? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RecoverableRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMMissedRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> RecoverableRangeResponse? VsphereVmRecoverableRange
        // GraphQL -> vsphereVMRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmRecoverableRange(
            ref RecoverableRangeResponse? fieldSpec
        )
        {
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new RecoverableRangeResponse() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMRecoverableRange" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchVmwareVmRecoverableRanges? VsphereVmRecoverableRangeInBatch
        // GraphQL -> vsphereVMRecoverableRangeInBatch: BatchVmwareVmRecoverableRanges! (type)
        public static string VsphereVmRecoverableRangeInBatch(
            ref BatchVmwareVmRecoverableRanges? fieldSpec
        )
        {
            string args = "\n(\nrequestInfo: $requestInfo\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BatchVmwareVmRecoverableRanges() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVMRecoverableRangeInBatch" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> BatchVmwareCdpLiveInfo? VsphereVmwareCdpLiveInfo
        // GraphQL -> vsphereVmwareCdpLiveInfo: BatchVmwareCdpLiveInfo! (type)
        public static string VsphereVmwareCdpLiveInfo(
            ref BatchVmwareCdpLiveInfo? fieldSpec
        )
        {
            string args = "\n(\nids: $ids\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new BatchVmwareCdpLiveInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "vsphereVmwareCdpLiveInfo" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WindowsCluster? WindowsCluster
        // GraphQL -> windowsCluster: WindowsCluster! (type)
        public static string WindowsCluster(
            ref WindowsCluster? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new WindowsCluster() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "windowsCluster" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WindowsFileset? WindowsFileset
        // GraphQL -> windowsFileset: WindowsFileset! (type)
        public static string WindowsFileset(
            ref WindowsFileset? fieldSpec
        )
        {
            string args = "\n(\nfid: $fid\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new WindowsFileset() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "windowsFileset" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> GetWorkloadAlertSettingReply? WorkloadAlertSetting
        // GraphQL -> workloadAlertSetting: GetWorkloadAlertSettingReply! (type)
        public static string WorkloadAlertSetting(
            ref GetWorkloadAlertSettingReply? fieldSpec
        )
        {
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new GetWorkloadAlertSettingReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadAlertSetting" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WorkloadAnomalyConnection? WorkloadAnomalies
        // GraphQL -> workloadAnomalies: WorkloadAnomalyConnection! (type)
        public static string WorkloadAnomalies(
            ref WorkloadAnomalyConnection? fieldSpec
        )
        {
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nworkloadNameSearch: $workloadNameSearch\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nencryptionFilter: $encryptionFilter\nseverityFilter: $severityFilter\nanalyzerGroupFilter: $analyzerGroupFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\norderParentsFirst: $orderParentsFirst\nblueprintRecoveryTypes: $blueprintRecoveryTypes\nlocationsFilter: $locationsFilter\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new WorkloadAnomalyConnection() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadAnomalies" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> WorkloadGroupByReply? WorkloadGroupByAtSpecifiedTime
        // GraphQL -> workloadGroupByAtSpecifiedTime: WorkloadGroupByReply! (type)
        public static string WorkloadGroupByAtSpecifiedTime(
            ref WorkloadGroupByReply? fieldSpec
        )
        {
            string args = "\n(\nfilters: $filters\nprimaryGroupBy: $primaryGroupBy\nsecondaryGroupBy: $secondaryGroupBy\nspecifiedTime: $specifiedTime\n)";
            if (fieldSpec == null)
            {
                fieldSpec = new WorkloadGroupByReply() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "workloadGroupByAtSpecifiedTime" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        //      C# -> CertificateInfo? WwwTlsCert
        // GraphQL -> wwwTlsCert: CertificateInfo! (type)
        public static string WwwTlsCert(
            ref CertificateInfo? fieldSpec
        )
        {
            string args = "";
            if (fieldSpec == null)
            {
                fieldSpec = new CertificateInfo() ;
                fieldSpec.ApplyExploratoryFieldSpec();
            }
            return new string(
                "wwwTlsCert" + args + "\n{\n" +
                fieldSpec.AsFieldSpec(1) +
                "}\n");
        }

        #endregion

    } // class Query
    #endregion
}