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
        public static string AllAllowedOrgAdminOperations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allAllowedOrgAdminOperations" + args + "\n";
        }
        public static object AllAllowedOrgAdminOperationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<Operation>() ;
        }

        //      C# -> List<Operation>? AllAuthorizationsForGlobalResource
        // GraphQL -> allAuthorizationsForGlobalResource: [Operation!]! (enum)
        public static string AllAuthorizationsForGlobalResource(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allAuthorizationsForGlobalResource" + args + "\n";
        }
        public static object AllAuthorizationsForGlobalResourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<Operation>() ;
        }

        //      C# -> List<Operation>? AllAuthorizationsForObject
        // GraphQL -> allAuthorizationsForObject: [Operation!]! (enum)
        public static string AllAuthorizationsForObject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "allAuthorizationsForObject" + args + "\n";
        }
        public static object AllAuthorizationsForObjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<Operation>() ;
        }

        //      C# -> List<AwsCloudAccountRegion>? AllAwsRegions
        // GraphQL -> allAwsRegions: [AwsCloudAccountRegion!]! (enum)
        public static string AllAwsRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            return "allAwsRegions" + args + "\n";
        }
        public static object AllAwsRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<AwsCloudAccountRegion>() ;
        }

        //      C# -> List<AzureCloudAccountRegion>? AllAzureRegions
        // GraphQL -> allAzureRegions: [AzureCloudAccountRegion!]! (enum)
        public static string AllAzureRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            return "allAzureRegions" + args + "\n";
        }
        public static object AllAzureRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<AzureCloudAccountRegion>() ;
        }

        //      C# -> List<InventoryCard>? AllInventoryWorkloads
        // GraphQL -> allInventoryWorkloads: [InventoryCard!]! (enum)
        public static string AllInventoryWorkloads(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allInventoryWorkloads" + args + "\n";
        }
        public static object AllInventoryWorkloadsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<InventoryCard>() ;
        }

        //      C# -> List<ManagedObjectType>? AllUnmanagedObjectsSupportedTypes
        // GraphQL -> allUnmanagedObjectsSupportedTypes: [ManagedObjectType!]! (enum)
        public static string AllUnmanagedObjectsSupportedTypes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nproductType: $productType\ncloudVendor: $cloudVendor\n)";
            return "allUnmanagedObjectsSupportedTypes" + args + "\n";
        }
        public static object AllUnmanagedObjectsSupportedTypesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<ManagedObjectType>() ;
        }

        //      C# -> TenantAuthDomainConfig? CurrentOrgAuthDomainConfig
        // GraphQL -> currentOrgAuthDomainConfig: TenantAuthDomainConfig! (enum)
        public static string CurrentOrgAuthDomainConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "currentOrgAuthDomainConfig" + args + "\n";
        }
        public static object CurrentOrgAuthDomainConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new TenantAuthDomainConfig() ;
        }

        //      C# -> List<CloudAccount>? AllCloudAccounts
        // GraphQL -> allCloudAccounts: [CloudAccount!]! (interface)
        public static string AllCloudAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfeatures: $features\n)";
            return "allCloudAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCloudAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SlaDomain>? AllSlaSummariesByIds
        // GraphQL -> allSlaSummariesByIds: [SlaDomain!]! (interface)
        public static string AllSlaSummariesByIds(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nslaIds: $slaIds\n)";
            return "allSlaSummariesByIds" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllSlaSummariesByIdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<SlaDomain>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Target>? AllTargets
        // GraphQL -> allTargets: [Target!]! (interface)
        public static string AllTargets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            return "allTargets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllTargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmHierarchySnappableNew? CdmHierarchySnappableNew
        // GraphQL -> cdmHierarchySnappableNew: CdmHierarchySnappableNew! (interface)
        public static string CdmHierarchySnappableNew(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "cdmHierarchySnappableNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmHierarchySnappableNewFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CdmHierarchySnappableNew>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CdmHierarchySnappableNew>? CdmHierarchySnappablesNew
        // GraphQL -> cdmHierarchySnappablesNew: [CdmHierarchySnappableNew!]! (interface)
        public static string CdmHierarchySnappablesNew(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfids: $fids\n)";
            return "cdmHierarchySnappablesNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmHierarchySnappablesNewFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CdmHierarchySnappableNew>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        public static string CloudAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            return "cloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<CloudAccount>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        public static string HierarchyObject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hierarchyObject" + args + "\n{\n" + fs + "}\n";
        }
        public static object HierarchyObjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<HierarchyObject>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HierarchyObject? HierarchyObjectRecoveryTarget
        // GraphQL -> hierarchyObjectRecoveryTarget: HierarchyObject! (interface)
        public static string HierarchyObjectRecoveryTarget(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hierarchyObjectRecoveryTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object HierarchyObjectRecoveryTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<HierarchyObject>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<HierarchyObject>? HierarchyObjects
        // GraphQL -> hierarchyObjects: [HierarchyObject!]! (interface)
        public static string HierarchyObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfids: $fids\nfilter: $filter\n)";
            return "hierarchyObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object HierarchyObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<HierarchyObject>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<HierarchyObject>? SlaConflictObjects
        // GraphQL -> slaConflictObjects: [HierarchyObject!]! (interface)
        public static string SlaConflictObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfids: $fids\n)";
            return "slaConflictObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaConflictObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<HierarchyObject>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain! (interface)
        public static string SlaDomain(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            return "slaDomain" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<SlaDomain>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Target? Target
        // GraphQL -> target: Target! (interface)
        public static string Target(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "target" + args + "\n{\n" + fs + "}\n";
        }
        public static object TargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RscInterface<Target>();
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        public static string AccountId(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "accountId" + args + "\n";
        }
        public static object AccountIdFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> List<System.String>? AllAvailabilityZonesByRegionFromAws
        // GraphQL -> allAvailabilityZonesByRegionFromAws: [String!]! (scalar)
        public static string AllAvailabilityZonesByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allAvailabilityZonesByRegionFromAws" + args + "\n";
        }
        public static object AllAvailabilityZonesByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAwsInstanceProfileNames
        // GraphQL -> allAwsInstanceProfileNames: [String!]! (scalar)
        public static string AllAwsInstanceProfileNames(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            return "allAwsInstanceProfileNames" + args + "\n";
        }
        public static object AllAwsInstanceProfileNamesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureNativeVirtualMachineSizes
        // GraphQL -> allAzureNativeVirtualMachineSizes: [String!]! (scalar)
        public static string AllAzureNativeVirtualMachineSizes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            return "allAzureNativeVirtualMachineSizes" + args + "\n";
        }
        public static object AllAzureNativeVirtualMachineSizesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureNsgs
        // GraphQL -> allAzureNsgs: [String!]! (scalar)
        public static string AllAzureNsgs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nnsgRequest: $nsgRequest\n)";
            return "allAzureNsgs" + args + "\n";
        }
        public static object AllAzureNsgsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureResourceGroups
        // GraphQL -> allAzureResourceGroups: [String!]! (scalar)
        public static string AllAzureResourceGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureRegion: $azureRegion\n)";
            return "allAzureResourceGroups" + args + "\n";
        }
        public static object AllAzureResourceGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureStorageAccounts
        // GraphQL -> allAzureStorageAccounts: [String!]! (scalar)
        public static string AllAzureStorageAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nstorageAccountsRequest: $storageAccountsRequest\n)";
            return "allAzureStorageAccounts" + args + "\n";
        }
        public static object AllAzureStorageAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureSubnets
        // GraphQL -> allAzureSubnets: [String!]! (scalar)
        public static string AllAzureSubnets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsubnetRequest: $subnetRequest\n)";
            return "allAzureSubnets" + args + "\n";
        }
        public static object AllAzureSubnetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllAzureVnets
        // GraphQL -> allAzureVnets: [String!]! (scalar)
        public static string AllAzureVnets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nvnetRequest: $vnetRequest\n)";
            return "allAzureVnets" + args + "\n";
        }
        public static object AllAzureVnetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllCloudNativeFileRecoveryEligibleSnapshots
        // GraphQL -> allCloudNativeFileRecoveryEligibleSnapshots: [String!]! (scalar)
        public static string AllCloudNativeFileRecoveryEligibleSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadId: $workloadId\n)";
            return "allCloudNativeFileRecoveryEligibleSnapshots" + args + "\n";
        }
        public static object AllCloudNativeFileRecoveryEligibleSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllCloudNativeLabelKeys
        // GraphQL -> allCloudNativeLabelKeys: [String!]! (scalar)
        public static string AllCloudNativeLabelKeys(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            return "allCloudNativeLabelKeys" + args + "\n";
        }
        public static object AllCloudNativeLabelKeysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllCloudNativeLabelValues
        // GraphQL -> allCloudNativeLabelValues: [String!]! (scalar)
        public static string AllCloudNativeLabelValues(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            return "allCloudNativeLabelValues" + args + "\n";
        }
        public static object AllCloudNativeLabelValuesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllCloudNativeTagKeys
        // GraphQL -> allCloudNativeTagKeys: [String!]! (scalar)
        public static string AllCloudNativeTagKeys(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nkeySubStr: $keySubStr\nlimit: $limit\nobjectType: $objectType\n)";
            return "allCloudNativeTagKeys" + args + "\n";
        }
        public static object AllCloudNativeTagKeysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllCloudNativeTagValues
        // GraphQL -> allCloudNativeTagValues: [String!]! (scalar)
        public static string AllCloudNativeTagValues(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nvalueSubStr: $valueSubStr\nkey: $key\nlimit: $limit\nobjectType: $objectType\n)";
            return "allCloudNativeTagValues" + args + "\n";
        }
        public static object AllCloudNativeTagValuesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.Boolean>? AllClustersTotpAckStatus
        // GraphQL -> allClustersTotpAckStatus: [Boolean!]! (scalar)
        public static string AllClustersTotpAckStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nlistClusterUuid: $listClusterUuid\n)";
            return "allClustersTotpAckStatus" + args + "\n";
        }
        public static object AllClustersTotpAckStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.Boolean>() ;
        }

        //      C# -> List<System.String>? AllDeploymentIpAddresses
        // GraphQL -> allDeploymentIpAddresses: [String!]! (scalar)
        public static string AllDeploymentIpAddresses(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allDeploymentIpAddresses" + args + "\n";
        }
        public static object AllDeploymentIpAddressesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllEc2KeyPairsByRegionFromAws
        // GraphQL -> allEc2KeyPairsByRegionFromAws: [String!]! (scalar)
        public static string AllEc2KeyPairsByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allEc2KeyPairsByRegionFromAws" + args + "\n";
        }
        public static object AllEc2KeyPairsByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeCompatibleMachineTypes
        // GraphQL -> allGcpNativeCompatibleMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeCompatibleMachineTypes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntargetZone: $targetZone\nsnapshotId: $snapshotId\n)";
            return "allGcpNativeCompatibleMachineTypes" + args + "\n";
        }
        public static object AllGcpNativeCompatibleMachineTypesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypes
        // GraphQL -> allGcpNativeStoredMachineTypes: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allGcpNativeStoredMachineTypes" + args + "\n";
        }
        public static object AllGcpNativeStoredMachineTypesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredMachineTypesInProject
        // GraphQL -> allGcpNativeStoredMachineTypesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredMachineTypesInProject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeStoredMachineTypesInProject" + args + "\n";
        }
        public static object AllGcpNativeStoredMachineTypesInProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNames
        // GraphQL -> allGcpNativeStoredNetworkNames: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNames(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allGcpNativeStoredNetworkNames" + args + "\n";
        }
        public static object AllGcpNativeStoredNetworkNamesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredNetworkNamesInProject
        // GraphQL -> allGcpNativeStoredNetworkNamesInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredNetworkNamesInProject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeStoredNetworkNamesInProject" + args + "\n";
        }
        public static object AllGcpNativeStoredNetworkNamesInProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegions
        // GraphQL -> allGcpNativeStoredRegions: [String!]! (scalar)
        public static string AllGcpNativeStoredRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allGcpNativeStoredRegions" + args + "\n";
        }
        public static object AllGcpNativeStoredRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllGcpNativeStoredRegionsInProject
        // GraphQL -> allGcpNativeStoredRegionsInProject: [String!]! (scalar)
        public static string AllGcpNativeStoredRegionsInProject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeStoredRegionsInProject" + args + "\n";
        }
        public static object AllGcpNativeStoredRegionsInProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllIssuesJobIds
        // GraphQL -> allIssuesJobIds: [String!]! (scalar)
        public static string AllIssuesJobIds(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nqueryIds: $queryIds\n)";
            return "allIssuesJobIds" + args + "\n";
        }
        public static object AllIssuesJobIdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllS3BucketsFromAws
        // GraphQL -> allS3BucketsFromAws: [String!]! (scalar)
        public static string AllS3BucketsFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            return "allS3BucketsFromAws" + args + "\n";
        }
        public static object AllS3BucketsFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> List<System.String>? AllSupportedAwsRdsDatabaseInstanceClasses
        // GraphQL -> allSupportedAwsRdsDatabaseInstanceClasses: [String!]! (scalar)
        public static string AllSupportedAwsRdsDatabaseInstanceClasses(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\n)";
            return "allSupportedAwsRdsDatabaseInstanceClasses" + args + "\n";
        }
        public static object AllSupportedAwsRdsDatabaseInstanceClassesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return new List<System.String>() ;
        }

        //      C# -> System.Boolean? AreMultiGeoBackupsEnabled
        // GraphQL -> areMultiGeoBackupsEnabled: Boolean! (scalar)
        public static string AreMultiGeoBackupsEnabled(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "areMultiGeoBackupsEnabled" + args + "\n";
        }
        public static object AreMultiGeoBackupsEnabledFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? CloudNativeCheckRequiredPermissionsForFeature
        // GraphQL -> cloudNativeCheckRequiredPermissionsForFeature: Boolean! (scalar)
        public static string CloudNativeCheckRequiredPermissionsForFeature(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudNativeAccountId: $cloudNativeAccountId\nfeaturePermissionCheck: $featurePermissionCheck\n)";
            return "cloudNativeCheckRequiredPermissionsForFeature" + args + "\n";
        }
        public static object CloudNativeCheckRequiredPermissionsForFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? CurrentIpAddress
        // GraphQL -> currentIpAddress: String! (scalar)
        public static string CurrentIpAddress(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "currentIpAddress" + args + "\n";
        }
        public static object CurrentIpAddressFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? DeploymentVersion
        // GraphQL -> deploymentVersion: String! (scalar)
        public static string DeploymentVersion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "deploymentVersion" + args + "\n";
        }
        public static object DeploymentVersionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? DoesAzureNativeResourceGroupExist
        // GraphQL -> doesAzureNativeResourceGroupExist: Boolean! (scalar)
        public static string DoesAzureNativeResourceGroupExist(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nresourceGroupName: $resourceGroupName\nfeature: $feature\n)";
            return "doesAzureNativeResourceGroupExist" + args + "\n";
        }
        public static object DoesAzureNativeResourceGroupExistFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? DummyFieldWithAdminOnlyTag
        // GraphQL -> dummyFieldWithAdminOnlyTag: Boolean! (scalar)
        public static string DummyFieldWithAdminOnlyTag(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "dummyFieldWithAdminOnlyTag" + args + "\n";
        }
        public static object DummyFieldWithAdminOnlyTagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.String? ExternalDeploymentName
        // GraphQL -> externalDeploymentName: String! (scalar)
        public static string ExternalDeploymentName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "externalDeploymentName" + args + "\n";
        }
        public static object ExternalDeploymentNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.String? GcpGetDefaultCredentialsServiceAccount
        // GraphQL -> gcpGetDefaultCredentialsServiceAccount: String! (scalar)
        public static string GcpGetDefaultCredentialsServiceAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "gcpGetDefaultCredentialsServiceAccount" + args + "\n";
        }
        public static object GcpGetDefaultCredentialsServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Boolean? HasIdpConfigured
        // GraphQL -> hasIdpConfigured: Boolean! (scalar)
        public static string HasIdpConfigured(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "hasIdpConfigured" + args + "\n";
        }
        public static object HasIdpConfiguredFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsAwsNativeRdsInstanceLaunchConfigurationValid
        // GraphQL -> isAwsNativeRdsInstanceLaunchConfigurationValid: Boolean! (scalar)
        public static string IsAwsNativeRdsInstanceLaunchConfigurationValid(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\ndbClass: $dbClass\ndatabaseInstanceClass: $databaseInstanceClass\nprimaryAz: $primaryAz\nstorageType: $storageType\nisMultiAz: $isMultiAz\nkmsKeyId: $kmsKeyId\niops: $iops\n)";
            return "isAwsNativeRdsInstanceLaunchConfigurationValid" + args + "\n";
        }
        public static object IsAwsNativeRdsInstanceLaunchConfigurationValidFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsAwsS3BucketNameAvailable
        // GraphQL -> isAwsS3BucketNameAvailable: Boolean! (scalar)
        public static string IsAwsS3BucketNameAvailable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            return "isAwsS3BucketNameAvailable" + args + "\n";
        }
        public static object IsAwsS3BucketNameAvailableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsAzureNativeManagedDiskSnapshotRestorable
        // GraphQL -> isAzureNativeManagedDiskSnapshotRestorable: Boolean! (scalar)
        public static string IsAzureNativeManagedDiskSnapshotRestorable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\ndiskSnapshotId: $diskSnapshotId\n)";
            return "isAzureNativeManagedDiskSnapshotRestorable" + args + "\n";
        }
        public static object IsAzureNativeManagedDiskSnapshotRestorableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsAzureNativeSqlDatabaseSnapshotPersistent
        // GraphQL -> isAzureNativeSqlDatabaseSnapshotPersistent: Boolean! (scalar)
        public static string IsAzureNativeSqlDatabaseSnapshotPersistent(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            return "isAzureNativeSqlDatabaseSnapshotPersistent" + args + "\n";
        }
        public static object IsAzureNativeSqlDatabaseSnapshotPersistentFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsAzureStorageAccountNameAvailable
        // GraphQL -> isAzureStorageAccountNameAvailable: Boolean! (scalar)
        public static string IsAzureStorageAccountNameAvailable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nstorageAccountName: $storageAccountName\n)";
            return "isAzureStorageAccountNameAvailable" + args + "\n";
        }
        public static object IsAzureStorageAccountNameAvailableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsOrgServiceAccountDisabled
        // GraphQL -> isOrgServiceAccountDisabled: Boolean! (scalar)
        public static string IsOrgServiceAccountDisabled(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "isOrgServiceAccountDisabled" + args + "\n";
        }
        public static object IsOrgServiceAccountDisabledFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsSfdcReachable
        // GraphQL -> isSfdcReachable: Boolean! (scalar)
        public static string IsSfdcReachable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nhostname: $hostname\norganizationId: $organizationId\n)";
            return "isSfdcReachable" + args + "\n";
        }
        public static object IsSfdcReachableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsTotpAckNecessaryForCluster
        // GraphQL -> isTotpAckNecessaryForCluster: Boolean! (scalar)
        public static string IsTotpAckNecessaryForCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "isTotpAckNecessaryForCluster" + args + "\n";
        }
        public static object IsTotpAckNecessaryForClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsTotpMandatoryInTargetVersion
        // GraphQL -> isTotpMandatoryInTargetVersion: Boolean! (scalar)
        public static string IsTotpMandatoryInTargetVersion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nversion: $version\n)";
            return "isTotpMandatoryInTargetVersion" + args + "\n";
        }
        public static object IsTotpMandatoryInTargetVersionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Boolean? IsVmwareManagementEnabled
        // GraphQL -> isVMwareManagementEnabled: Boolean! (scalar)
        public static string IsVmwareManagementEnabled(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "isVMwareManagementEnabled" + args + "\n";
        }
        public static object IsVmwareManagementEnabledFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Int32? MaxProtectedAppsCount
        // GraphQL -> maxProtectedAppsCount: Int! (scalar)
        public static string MaxProtectedAppsCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "maxProtectedAppsCount" + args + "\n";
        }
        public static object MaxProtectedAppsCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return Int32.MinValue ;
        }

        //      C# -> System.String? O365TeamConversationsFolderId
        // GraphQL -> o365TeamConversationsFolderID: String! (scalar)
        public static string O365TeamConversationsFolderId(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\no365OrgId: $o365OrgId\n)";
            return "o365TeamConversationsFolderID" + args + "\n";
        }
        public static object O365TeamConversationsFolderIdFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return "FETCH" ;
        }

        //      C# -> System.Int32? ProtectedVolumesCount
        // GraphQL -> protectedVolumesCount: Int! (scalar)
        public static string ProtectedVolumesCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\n)";
            return "protectedVolumesCount" + args + "\n";
        }
        public static object ProtectedVolumesCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return Int32.MinValue ;
        }

        //      C# -> System.Boolean? TeamChannelNameAvailable
        // GraphQL -> teamChannelNameAvailable: Boolean! (scalar)
        public static string TeamChannelNameAvailable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nteamUUID: $teamUUID\nchannelName: $channelName\n)";
            return "teamChannelNameAvailable" + args + "\n";
        }
        public static object TeamChannelNameAvailableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return true ;
        }

        //      C# -> System.Int32? UniqueHypervServersCount
        // GraphQL -> uniqueHypervServersCount: Int! (scalar)
        public static string UniqueHypervServersCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\n)";
            return "uniqueHypervServersCount" + args + "\n";
        }
        public static object UniqueHypervServersCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return Int32.MinValue ;
        }

        //      C# -> System.Int32? UniqueVcdCount
        // GraphQL -> uniqueVcdCount: Int! (scalar)
        public static string UniqueVcdCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\n)";
            return "uniqueVcdCount" + args + "\n";
        }
        public static object UniqueVcdCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return Int32.MinValue ;
        }

        //      C# -> System.Int32? VcenterNumProxiesNeeded
        // GraphQL -> vCenterNumProxiesNeeded: Int! (scalar)
        public static string VcenterNumProxiesNeeded(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterNumProxiesNeeded" + args + "\n";
        }
        public static object VcenterNumProxiesNeededFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            // there is no field spec for scalar types, but we still
            // populate the fieldSpec so that caller can see the type 
            return Int32.MinValue ;
        }

        //      C# -> AccountSetting? AccountSettings
        // GraphQL -> accountSettings: AccountSetting! (type)
        public static string AccountSettings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "accountSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AccountSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AccountSetting() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnalyzerConnection? ActiveCustomAnalyzers
        // GraphQL -> activeCustomAnalyzers: AnalyzerConnection! (type)
        public static string ActiveCustomAnalyzers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "activeCustomAnalyzers" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveCustomAnalyzersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnalyzerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActiveDirectoryDomain? ActiveDirectoryDomain
        // GraphQL -> activeDirectoryDomain: ActiveDirectoryDomain! (type)
        public static string ActiveDirectoryDomain(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "activeDirectoryDomain" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveDirectoryDomainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActiveDirectoryDomain() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActiveDirectoryDomainController? ActiveDirectoryDomainController
        // GraphQL -> activeDirectoryDomainController: ActiveDirectoryDomainController! (type)
        public static string ActiveDirectoryDomainController(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "activeDirectoryDomainController" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveDirectoryDomainControllerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActiveDirectoryDomainController() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActiveDirectoryDomainControllerConnection? ActiveDirectoryDomainControllers
        // GraphQL -> activeDirectoryDomainControllers: ActiveDirectoryDomainControllerConnection! (type)
        public static string ActiveDirectoryDomainControllers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "activeDirectoryDomainControllers" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveDirectoryDomainControllersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActiveDirectoryDomainControllerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActiveDirectoryDomainConnection? ActiveDirectoryDomains
        // GraphQL -> activeDirectoryDomains: ActiveDirectoryDomainConnection! (type)
        public static string ActiveDirectoryDomains(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "activeDirectoryDomains" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveDirectoryDomainsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActiveDirectoryDomainConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActiveDirectorySnappableSearchResponseConnection? ActiveDirectorySearchSnapshots
        // GraphQL -> activeDirectorySearchSnapshots: ActiveDirectorySnappableSearchResponseConnection! (type)
        public static string ActiveDirectorySearchSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nid: $id\nsnapshotAfterDate: $snapshotAfterDate\nsnapshotBeforeDate: $snapshotBeforeDate\nname: $name\nactiveDirectoryObjectType: $activeDirectoryObjectType\n)";
            return "activeDirectorySearchSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActiveDirectorySearchSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActiveDirectorySnappableSearchResponseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActivitySeries? ActivitySeries
        // GraphQL -> activitySeries: ActivitySeries! (type)
        public static string ActivitySeries(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "activitySeries" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActivitySeriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActivitySeries() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        public static string ActivitySeriesConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            return "activitySeriesConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object ActivitySeriesConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActivitySeriesConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AdVolumeExportConnection? AdVolumeExports
        // GraphQL -> adVolumeExports: AdVolumeExportConnection! (type)
        public static string AdVolumeExports(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "adVolumeExports" + args + "\n{\n" + fs + "}\n";
        }
        public static object AdVolumeExportsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AdVolumeExportConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AgentDeploymentSettings? AgentDeploymentSetting
        // GraphQL -> agentDeploymentSetting: AgentDeploymentSettings! (type)
        public static string AgentDeploymentSetting(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "agentDeploymentSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object AgentDeploymentSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AgentDeploymentSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<User>? AllAccountOwners
        // GraphQL -> allAccountOwners: [User!]! (type)
        public static string AllAccountOwners(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allAccountOwners" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAccountOwnersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<User>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AccountProduct>? AllAccountProducts
        // GraphQL -> allAccountProducts: [AccountProduct!]! (type)
        public static string AllAccountProducts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nnameFilter: $nameFilter\ntypeFilter: $typeFilter\nstateFilter: $stateFilter\nstartDateArg: $startDateArg\nendDateArg: $endDateArg\n)";
            return "allAccountProducts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAccountProductsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AccountProduct>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CloudAccountWithExocomputeMapping>? AllAccountsWithExocomputeMappings
        // GraphQL -> allAccountsWithExocomputeMappings: [CloudAccountWithExocomputeMapping!]! (type)
        public static string AllAccountsWithExocomputeMappings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudVendor: $cloudVendor\nfeatures: $features\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            return "allAccountsWithExocomputeMappings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAccountsWithExocomputeMappingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CloudAccountWithExocomputeMapping>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AuthorizedOperations>? AllAuthorizationsForObjects
        // GraphQL -> allAuthorizationsForObjects: [AuthorizedOperations!]! (type)
        public static string AllAuthorizationsForObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfids: $fids\n)";
            return "allAuthorizationsForObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAuthorizationsForObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AuthorizedOperations>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsCdmVersion>? AllAwsCdmVersions
        // GraphQL -> allAwsCdmVersions: [AwsCdmVersion!]! (type)
        public static string AllAwsCdmVersions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allAwsCdmVersions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsCdmVersionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsCdmVersion>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsFeatureConfig>? AllAwsCloudAccountConfigs
        // GraphQL -> allAwsCloudAccountConfigs: [AwsFeatureConfig!]! (type)
        public static string AllAwsCloudAccountConfigs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            return "allAwsCloudAccountConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsCloudAccountConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsFeatureConfig>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsCloudAccountWithFeatures>? AllAwsCloudAccountsWithFeatures
        // GraphQL -> allAwsCloudAccountsWithFeatures: [AwsCloudAccountWithFeatures!]! (type)
        public static string AllAwsCloudAccountsWithFeatures(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsCloudAccountsArg: $awsCloudAccountsArg\n)";
            return "allAwsCloudAccountsWithFeatures" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsCloudAccountsWithFeaturesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsCloudAccountWithFeatures>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsComputeSettings>? AllAwsComputeSettings
        // GraphQL -> allAwsComputeSettings: [AwsComputeSettings!]! (type)
        public static string AllAwsComputeSettings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            return "allAwsComputeSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsComputeSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsComputeSettings>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsExocomputeConfig>? AllAwsExocomputeConfigs
        // GraphQL -> allAwsExocomputeConfigs: [AwsExocomputeConfig!]! (type)
        public static string AllAwsExocomputeConfigs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsNativeAccountIdOrNamePrefix: $awsNativeAccountIdOrNamePrefix\n)";
            return "allAwsExocomputeConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsExocomputeConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsExocomputeConfig>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<PermissionPolicy>? AllAwsPermissionPolicies
        // GraphQL -> allAwsPermissionPolicies: [PermissionPolicy!]! (type)
        public static string AllAwsPermissionPolicies(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allAwsPermissionPolicies" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAwsPermissionPoliciesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<PermissionPolicy>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureArmTemplateByFeature>? AllAzureArmTemplatesByFeature
        // GraphQL -> allAzureArmTemplatesByFeature: [AzureArmTemplateByFeature!]! (type)
        public static string AllAzureArmTemplatesByFeature(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allAzureArmTemplatesByFeature" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureArmTemplatesByFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureArmTemplateByFeature>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureCdmVersion>? AllAzureCdmVersions
        // GraphQL -> allAzureCdmVersions: [AzureCdmVersion!]! (type)
        public static string AllAzureCdmVersions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncdmVersionRequest: $cdmVersionRequest\n)";
            return "allAzureCdmVersions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureCdmVersionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureCdmVersion>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureSubscriptionMissingPermissions>? AllAzureCloudAccountMissingPermissions
        // GraphQL -> allAzureCloudAccountMissingPermissions: [AzureSubscriptionMissingPermissions!]! (type)
        public static string AllAzureCloudAccountMissingPermissions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsessionId: $sessionId\nsubscriptionIds: $subscriptionIds\ncloudAccountAction: $cloudAccountAction\n)";
            return "allAzureCloudAccountMissingPermissions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureCloudAccountMissingPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureSubscriptionMissingPermissions>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureCloudAccountSubnetsByRegion
        // GraphQL -> allAzureCloudAccountSubnetsByRegion: [AzureNativeSubnet!]! (type)
        public static string AllAzureCloudAccountSubnetsByRegion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nregion: $region\n)";
            return "allAzureCloudAccountSubnetsByRegion" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureCloudAccountSubnetsByRegionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeSubnet>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureSubscriptionWithFeaturesType>? AllAzureCloudAccountSubscriptionsByFeature
        // GraphQL -> allAzureCloudAccountSubscriptionsByFeature: [AzureSubscriptionWithFeaturesType!]! (type)
        public static string AllAzureCloudAccountSubscriptionsByFeature(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\npermissionsGroupFilters: $permissionsGroupFilters\n)";
            return "allAzureCloudAccountSubscriptionsByFeature" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureCloudAccountSubscriptionsByFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureSubscriptionWithFeaturesType>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureCloudAccountTenant>? AllAzureCloudAccountTenants
        // GraphQL -> allAzureCloudAccountTenants: [AzureCloudAccountTenant!]! (type)
        public static string AllAzureCloudAccountTenants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeatures: $features\nfeature: $feature\nincludeSubscriptionDetails: $includeSubscriptionDetails\n)";
            return "allAzureCloudAccountTenants" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureCloudAccountTenantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureCloudAccountTenant>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeDiskEncryptionSet>? AllAzureDiskEncryptionSetsByRegion
        // GraphQL -> allAzureDiskEncryptionSetsByRegion: [AzureNativeDiskEncryptionSet!]! (type)
        public static string AllAzureDiskEncryptionSetsByRegion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            return "allAzureDiskEncryptionSetsByRegion" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureDiskEncryptionSetsByRegionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeDiskEncryptionSet>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureEncryptionKey>? AllAzureEncryptionKeys
        // GraphQL -> allAzureEncryptionKeys: [AzureEncryptionKey!]! (type)
        public static string AllAzureEncryptionKeys(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureEncryptionKeysInput: $azureEncryptionKeysInput\n)";
            return "allAzureEncryptionKeys" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureEncryptionKeysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureEncryptionKey>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureExocomputeConfigsInAccount>? AllAzureExocomputeConfigsInAccount
        // GraphQL -> allAzureExocomputeConfigsInAccount: [AzureExocomputeConfigsInAccount!]! (type)
        public static string AllAzureExocomputeConfigsInAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureExocomputeSearchQuery: $azureExocomputeSearchQuery\ncloudAccountIDs: $cloudAccountIDs\n)";
            return "allAzureExocomputeConfigsInAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureExocomputeConfigsInAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureExocomputeConfigsInAccount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureKeyVault>? AllAzureKeyVaultsByRegion
        // GraphQL -> allAzureKeyVaultsByRegion: [AzureKeyVault!]! (type)
        public static string AllAzureKeyVaultsByRegion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureKeyVaultsInput: $azureKeyVaultsInput\n)";
            return "allAzureKeyVaultsByRegion" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureKeyVaultsByRegionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureKeyVault>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureManagedIdentity>? AllAzureManagedIdentities
        // GraphQL -> allAzureManagedIdentities: [AzureManagedIdentity!]! (type)
        public static string AllAzureManagedIdentities(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nmanagedIdentitiesRequest: $managedIdentitiesRequest\n)";
            return "allAzureManagedIdentities" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureManagedIdentitiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureManagedIdentity>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeAvailabilitySet>? AllAzureNativeAvailabilitySetsByRegionFromAzure
        // GraphQL -> allAzureNativeAvailabilitySetsByRegionFromAzure: [AzureNativeAvailabilitySet!]! (type)
        public static string AllAzureNativeAvailabilitySetsByRegionFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nresourceGroupName: $resourceGroupName\nregion: $region\n)";
            return "allAzureNativeAvailabilitySetsByRegionFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeAvailabilitySetsByRegionFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeAvailabilitySet>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeExportCompatibleDiskTypes>? AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleDiskTypesByRegionFromAzure: [AzureNativeExportCompatibleDiskTypes!]! (type)
        public static string AllAzureNativeExportCompatibleDiskTypesByRegionFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            return "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeExportCompatibleDiskTypesByRegionFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeExportCompatibleDiskTypes>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeExportCompatibleVmSizes>? AllAzureNativeExportCompatibleVmSizesByRegionFromAzure
        // GraphQL -> allAzureNativeExportCompatibleVmSizesByRegionFromAzure: [AzureNativeExportCompatibleVmSizes!]! (type)
        public static string AllAzureNativeExportCompatibleVmSizesByRegionFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\nvmSnapshotId: $vmSnapshotId\n)";
            return "allAzureNativeExportCompatibleVmSizesByRegionFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeExportCompatibleVmSizesByRegionFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeExportCompatibleVmSizes>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureResourceGroupInfo>? AllAzureNativeResourceGroupsInfoIfExist
        // GraphQL -> allAzureNativeResourceGroupsInfoIfExist: [AzureResourceGroupInfo!]! (type)
        public static string AllAzureNativeResourceGroupsInfoIfExist(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allAzureNativeResourceGroupsInfoIfExist" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeResourceGroupsInfoIfExistFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureResourceGroupInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeSecurityGroup>? AllAzureNativeSecurityGroupsByRegionFromAzure
        // GraphQL -> allAzureNativeSecurityGroupsByRegionFromAzure: [AzureNativeSecurityGroup!]! (type)
        public static string AllAzureNativeSecurityGroupsByRegionFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            return "allAzureNativeSecurityGroupsByRegionFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeSecurityGroupsByRegionFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeSecurityGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeStorageAccount>? AllAzureNativeStorageAccountsFromAzure
        // GraphQL -> allAzureNativeStorageAccountsFromAzure: [AzureNativeStorageAccount!]! (type)
        public static string AllAzureNativeStorageAccountsFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            return "allAzureNativeStorageAccountsFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeStorageAccountsFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeStorageAccount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeSubnet>? AllAzureNativeSubnetsByRegionFromAzure
        // GraphQL -> allAzureNativeSubnetsByRegionFromAzure: [AzureNativeSubnet!]! (type)
        public static string AllAzureNativeSubnetsByRegionFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\nregion: $region\n)";
            return "allAzureNativeSubnetsByRegionFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeSubnetsByRegionFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeSubnet>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureNativeVirtualNetwork>? AllAzureNativeVirtualNetworks
        // GraphQL -> allAzureNativeVirtualNetworks: [AzureNativeVirtualNetwork!]! (type)
        public static string AllAzureNativeVirtualNetworks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            return "allAzureNativeVirtualNetworks" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureNativeVirtualNetworksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureNativeVirtualNetwork>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureSqlDatabaseServerElasticPool>? AllAzureSqlDatabaseServerElasticPools
        // GraphQL -> allAzureSqlDatabaseServerElasticPools: [AzureSqlDatabaseServerElasticPool!]! (type)
        public static string AllAzureSqlDatabaseServerElasticPools(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            return "allAzureSqlDatabaseServerElasticPools" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureSqlDatabaseServerElasticPoolsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureSqlDatabaseServerElasticPool>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureStorageAccountCcprovision>? AllAzureStorageAccountsByRegion
        // GraphQL -> allAzureStorageAccountsByRegion: [AzureStorageAccountCcprovision!]! (type)
        public static string AllAzureStorageAccountsByRegion(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allAzureStorageAccountsByRegion" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureStorageAccountsByRegionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureStorageAccountCcprovision>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureSubscriptionWithExocomputeMapping>? AllAzureSubscriptionWithExocomputeMappings
        // GraphQL -> allAzureSubscriptionWithExocomputeMappings: [AzureSubscriptionWithExocomputeMapping!]! (type)
        public static string AllAzureSubscriptionWithExocomputeMappings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeatures: $features\nexocomputeSubscriptionIdsFilter: $exocomputeSubscriptionIdsFilter\n)";
            return "allAzureSubscriptionWithExocomputeMappings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllAzureSubscriptionWithExocomputeMappingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureSubscriptionWithExocomputeMapping>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CdmGuestCredential>? AllCdmGuestCredentials
        // GraphQL -> allCdmGuestCredentials: [CdmGuestCredential!]! (type)
        public static string AllCdmGuestCredentials(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            return "allCdmGuestCredentials" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCdmGuestCredentialsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CdmGuestCredential>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CdmOvaDetail>? AllCdmOvaDetails
        // GraphQL -> allCdmOvaDetails: [CdmOvaDetail!]! (type)
        public static string AllCdmOvaDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allCdmOvaDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCdmOvaDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CdmOvaDetail>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdpVmInfoConnection? AllCdpVmsInfos
        // GraphQL -> allCdpVmsInfos: CdpVmInfoConnection! (type)
        public static string AllCdpVmsInfos(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nallCdpVmInfoSort: $allCdpVmInfoSort\nallCdpVmInfoFilter: $allCdpVmInfoFilter\n)";
            return "allCdpVmsInfos" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCdpVmsInfosFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdpVmInfoConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CloudAccountsExocomputeAccountMapping>? AllCloudAccountExocomputeMappings
        // GraphQL -> allCloudAccountExocomputeMappings: [CloudAccountsExocomputeAccountMapping!]! (type)
        public static string AllCloudAccountExocomputeMappings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudVendor: $cloudVendor\nexocomputeAccountIdsFilter: $exocomputeAccountIdsFilter\n)";
            return "allCloudAccountExocomputeMappings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCloudAccountExocomputeMappingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CloudAccountsExocomputeAccountMapping>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ShareExportIdPair>? AllCloudDirectShares
        // GraphQL -> allCloudDirectShares: [ShareExportIdPair!]! (type)
        public static string AllCloudDirectShares(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allCloudDirectShares" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCloudDirectSharesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ShareExportIdPair>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CloudDirectSite>? AllCloudDirectSites
        // GraphQL -> allCloudDirectSites: [CloudDirectSite!]! (type)
        public static string AllCloudDirectSites(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allCloudDirectSites" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCloudDirectSitesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CloudDirectSite>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterConnection? AllClusterConnection
        // GraphQL -> allClusterConnection: ClusterConnection! (type)
        public static string AllClusterConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            return "allClusterConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllClusterConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SlaInfo>? AllClusterGlobalSlas
        // GraphQL -> allClusterGlobalSlas: [SlaInfo!]! (type)
        public static string AllClusterGlobalSlas(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\n)";
            return "allClusterGlobalSlas" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllClusterGlobalSlasFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<SlaInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ClusterReplicationTarget>? AllClusterReplicationTargets
        // GraphQL -> allClusterReplicationTargets: [ClusterReplicationTarget!]! (type)
        public static string AllClusterReplicationTargets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "allClusterReplicationTargets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllClusterReplicationTargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ClusterReplicationTarget>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ClusterWebCertAndIpmi>? AllClusterWebCertsAndIpmis
        // GraphQL -> allClusterWebCertsAndIpmis: [ClusterWebCertAndIpmi!]! (type)
        public static string AllClusterWebCertsAndIpmis(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allClusterWebCertsAndIpmis" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllClusterWebCertsAndIpmisFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ClusterWebCertAndIpmi>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DataLocationSupportedCluster>? AllConnectedClusters
        // GraphQL -> allConnectedClusters: [DataLocationSupportedCluster!]! (type)
        public static string AllConnectedClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterFilterArg: $clusterFilterArg\n)";
            return "allConnectedClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllConnectedClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DataLocationSupportedCluster>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllCurrentFeaturePermissionsForCloudAccounts
        // GraphQL -> allCurrentFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllCurrentFeaturePermissionsForCloudAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\n)";
            return "allCurrentFeaturePermissionsForCloudAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCurrentFeaturePermissionsForCloudAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CloudAccountFeaturePermission>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<IdentityProvider>? AllCurrentOrgIdentityProviders
        // GraphQL -> allCurrentOrgIdentityProviders: [IdentityProvider!]! (type)
        public static string AllCurrentOrgIdentityProviders(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allCurrentOrgIdentityProviders" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllCurrentOrgIdentityProvidersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<IdentityProvider>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DbParameterGroup>? AllDbParameterGroupsByRegionFromAws
        // GraphQL -> allDbParameterGroupsByRegionFromAws: [DbParameterGroup!]! (type)
        public static string AllDbParameterGroupsByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nrdsType: $rdsType\n)";
            return "allDbParameterGroupsByRegionFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDbParameterGroupsByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DbParameterGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SubnetGroup>? AllDbSubnetGroupsByRegionFromAws
        // GraphQL -> allDbSubnetGroupsByRegionFromAws: [SubnetGroup!]! (type)
        public static string AllDbSubnetGroupsByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allDbSubnetGroupsByRegionFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDbSubnetGroupsByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<SubnetGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DhrcActiveRecommendation>? AllDhrcActiveRecommendations
        // GraphQL -> allDhrcActiveRecommendations: [DhrcActiveRecommendation!]! (type)
        public static string AllDhrcActiveRecommendations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncategories: $categories\n)";
            return "allDhrcActiveRecommendations" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDhrcActiveRecommendationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DhrcActiveRecommendation>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DhrcCollectedMetric>? AllDhrcLatestMetrics
        // GraphQL -> allDhrcLatestMetrics: [DhrcCollectedMetric!]! (type)
        public static string AllDhrcLatestMetrics(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncategories: $categories\n)";
            return "allDhrcLatestMetrics" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDhrcLatestMetricsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DhrcCollectedMetric>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DhrcScore>? AllDhrcScores
        // GraphQL -> allDhrcScores: [DhrcScore!]! (type)
        public static string AllDhrcScores(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncategories: $categories\nbeginTime: $beginTime\ntimespan: $timespan\n)";
            return "allDhrcScores" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDhrcScoresFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DhrcScore>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<EventDigest>? AllDistributionListDigests
        // GraphQL -> allDistributionListDigests: [EventDigest!]! (type)
        public static string AllDistributionListDigests(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allDistributionListDigests" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllDistributionListDigestsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<EventDigest>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<RbacPermission>? AllEffectiveRbacPermissions
        // GraphQL -> allEffectiveRbacPermissions: [RbacPermission!]! (type)
        public static string AllEffectiveRbacPermissions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nroleId: $roleId\n)";
            return "allEffectiveRbacPermissions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllEffectiveRbacPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<RbacPermission>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AllEnabledFeaturesForAccountReply? AllEnabledFeaturesForAccount
        // GraphQL -> allEnabledFeaturesForAccount: AllEnabledFeaturesForAccountReply! (type)
        public static string AllEnabledFeaturesForAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allEnabledFeaturesForAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllEnabledFeaturesForAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AllEnabledFeaturesForAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<EventDigest>? AllEventDigests
        // GraphQL -> allEventDigests: [EventDigest!]! (type)
        public static string AllEventDigests(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allEventDigests" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllEventDigestsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<EventDigest>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpPermission>? AllFeaturePermissionsForGcpCloudAccount
        // GraphQL -> allFeaturePermissionsForGcpCloudAccount: [GcpPermission!]! (type)
        public static string AllFeaturePermissionsForGcpCloudAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeature: $feature\n)";
            return "allFeaturePermissionsForGcpCloudAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllFeaturePermissionsForGcpCloudAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpPermission>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserActivityResultConnection? AllFileActivities
        // GraphQL -> allFileActivities: UserActivityResultConnection! (type)
        public static string AllFileActivities(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nListFileActivitiesInput: $ListFileActivitiesInput\nFileActivitiesSort: $FileActivitiesSort\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "allFileActivities" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllFileActivitiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserActivityResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpCloudAccountMissingPermissionsForAddition>? AllGcpCloudAccountMissingPermissionsForAddition
        // GraphQL -> allGcpCloudAccountMissingPermissionsForAddition: [GcpCloudAccountMissingPermissionsForAddition!]! (type)
        public static string AllGcpCloudAccountMissingPermissionsForAddition(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsessionId: $sessionId\nprojectIds: $projectIds\n)";
            return "allGcpCloudAccountMissingPermissionsForAddition" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpCloudAccountMissingPermissionsForAdditionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpCloudAccountMissingPermissionsForAddition>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpCloudAccountProjectDetail>? AllGcpCloudAccountProjectsByFeature
        // GraphQL -> allGcpCloudAccountProjectsByFeature: [GcpCloudAccountProjectDetail!]! (type)
        public static string AllGcpCloudAccountProjectsByFeature(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeature: $feature\nprojectStatusFilters: $projectStatusFilters\nprojectSearchText: $projectSearchText\n)";
            return "allGcpCloudAccountProjectsByFeature" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpCloudAccountProjectsByFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpCloudAccountProjectDetail>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpCloudAccountProjectForOauth>? AllGcpCloudAccountProjectsForOauth
        // GraphQL -> allGcpCloudAccountProjectsForOauth: [GcpCloudAccountProjectForOauth!]! (type)
        public static string AllGcpCloudAccountProjectsForOauth(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsessionId: $sessionId\nfeatures: $features\ncheckPermissions: $checkPermissions\n)";
            return "allGcpCloudAccountProjectsForOauth" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpCloudAccountProjectsForOauthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpCloudAccountProjectForOauth>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpNativeKmsCryptoKey>? AllGcpNativeAvailableKmsCryptoKeys
        // GraphQL -> allGcpNativeAvailableKmsCryptoKeys: [GcpNativeKmsCryptoKey!]! (type)
        public static string AllGcpNativeAvailableKmsCryptoKeys(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\nregionName: $regionName\n)";
            return "allGcpNativeAvailableKmsCryptoKeys" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpNativeAvailableKmsCryptoKeysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpNativeKmsCryptoKey>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpNativeNetwork>? AllGcpNativeNetworks
        // GraphQL -> allGcpNativeNetworks: [GcpNativeNetwork!]! (type)
        public static string AllGcpNativeNetworks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeNetworks" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpNativeNetworksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpNativeNetwork>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<NetworkHostProject>? AllGcpNativeProjectsWithAccessibleNetworks
        // GraphQL -> allGcpNativeProjectsWithAccessibleNetworks: [NetworkHostProject!]! (type)
        public static string AllGcpNativeProjectsWithAccessibleNetworks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeProjectsWithAccessibleNetworks" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpNativeProjectsWithAccessibleNetworksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<NetworkHostProject>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GcpNativeRegion>? AllGcpNativeRegions
        // GraphQL -> allGcpNativeRegions: [GcpNativeRegion!]! (type)
        public static string AllGcpNativeRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "allGcpNativeRegions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllGcpNativeRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GcpNativeRegion>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureRegionsResp? AllHostedAzureRegions
        // GraphQL -> allHostedAzureRegions: AzureRegionsResp! (type)
        public static string AllHostedAzureRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allHostedAzureRegions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllHostedAzureRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureRegionsResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListIntegrationsReply? AllIntegrations
        // GraphQL -> allIntegrations: ListIntegrationsReply! (type)
        public static string AllIntegrations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nintegrationTypes: $integrationTypes\nnameFilter: $nameFilter\n)";
            return "allIntegrations" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllIntegrationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListIntegrationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ReplicatedSnapshotInfo>? AllK8sReplicaSnapshotInfos
        // GraphQL -> allK8sReplicaSnapshotInfos: [ReplicatedSnapshotInfo!]! (type)
        public static string AllK8sReplicaSnapshotInfos(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\n)";
            return "allK8sReplicaSnapshotInfos" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllK8sReplicaSnapshotInfosFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ReplicatedSnapshotInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<KmsEncryptionKey>? AllKmsEncryptionKeysByRegionFromAws
        // GraphQL -> allKmsEncryptionKeysByRegionFromAws: [KmsEncryptionKey!]! (type)
        public static string AllKmsEncryptionKeysByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allKmsEncryptionKeysByRegionFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllKmsEncryptionKeysByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<KmsEncryptionKey>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<CloudAccountFeaturePermission>? AllLatestFeaturePermissionsForCloudAccounts
        // GraphQL -> allLatestFeaturePermissionsForCloudAccounts: [CloudAccountFeaturePermission!]! (type)
        public static string AllLatestFeaturePermissionsForCloudAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountIds: $cloudAccountIds\nfeatures: $features\nfeaturesWithPermissionsGroups: $featuresWithPermissionsGroups\n)";
            return "allLatestFeaturePermissionsForCloudAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllLatestFeaturePermissionsForCloudAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<CloudAccountFeaturePermission>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetLicensedProductsInfoReply? AllLicensedProducts
        // GraphQL -> allLicensedProducts: GetLicensedProductsInfoReply! (type)
        public static string AllLicensedProducts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allLicensedProducts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllLicensedProductsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetLicensedProductsInfoReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> V1MssqlGetRestoreFilesV1Response? AllMssqlDatabaseRestoreFiles
        // GraphQL -> allMssqlDatabaseRestoreFiles: V1MssqlGetRestoreFilesV1Response! (type)
        public static string AllMssqlDatabaseRestoreFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allMssqlDatabaseRestoreFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllMssqlDatabaseRestoreFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new V1MssqlGetRestoreFilesV1Response() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<NcdObjectsOverTimeData>? AllNcdObjectsOverTimeData
        // GraphQL -> allNcdObjectsOverTimeData: [NcdObjectsOverTimeData!]! (type)
        public static string AllNcdObjectsOverTimeData(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "allNcdObjectsOverTimeData" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllNcdObjectsOverTimeDataFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<NcdObjectsOverTimeData>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<NcdSlaComplianceData>? AllNcdSlaComplianceData
        // GraphQL -> allNcdSlaComplianceData: [NcdSlaComplianceData!]! (type)
        public static string AllNcdSlaComplianceData(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "allNcdSlaComplianceData" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllNcdSlaComplianceDataFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<NcdSlaComplianceData>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<NcdTaskData>? AllNcdTaskData
        // GraphQL -> allNcdTaskData: [NcdTaskData!]! (type)
        public static string AllNcdTaskData(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "allNcdTaskData" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllNcdTaskDataFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<NcdTaskData>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<NcdUsageOverTimeData>? AllNcdUsageOverTimeData
        // GraphQL -> allNcdUsageOverTimeData: [NcdUsageOverTimeData!]! (type)
        public static string AllNcdUsageOverTimeData(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "allNcdUsageOverTimeData" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllNcdUsageOverTimeDataFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<NcdUsageOverTimeData>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<MosaicStorageLocation>? AllNosqlStorageLocations
        // GraphQL -> allNosqlStorageLocations: [MosaicStorageLocation!]! (type)
        public static string AllNosqlStorageLocations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "allNosqlStorageLocations" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllNosqlStorageLocationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<MosaicStorageLocation>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AdGroup>? AllO365AdGroups
        // GraphQL -> allO365AdGroups: [AdGroup!]! (type)
        public static string AllO365AdGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\nadGroupSearchFilter: $adGroupSearchFilter\n)";
            return "allO365AdGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllO365AdGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AdGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<O365OrgInfo>? AllO365OrgStatuses
        // GraphQL -> allO365OrgStatuses: [O365OrgInfo!]! (type)
        public static string AllO365OrgStatuses(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allO365OrgStatuses" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllO365OrgStatusesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<O365OrgInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<O365SubscriptionAppTypeCounts>? AllO365SubscriptionsAppTypeCounts
        // GraphQL -> allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]! (type)
        public static string AllO365SubscriptionsAppTypeCounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allO365SubscriptionsAppTypeCounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllO365SubscriptionsAppTypeCountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<O365SubscriptionAppTypeCounts>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ObjectIdsForHierarchyType>? AllObjectsAlreadyAssignedToOrgs
        // GraphQL -> allObjectsAlreadyAssignedToOrgs: [ObjectIdsForHierarchyType!]! (type)
        public static string AllObjectsAlreadyAssignedToOrgs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nobjectIdsForHierarchyTypes: $objectIdsForHierarchyTypes\nallowedClusters: $allowedClusters\ntargetOrgId: $targetOrgId\n)";
            return "allObjectsAlreadyAssignedToOrgs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllObjectsAlreadyAssignedToOrgsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ObjectIdsForHierarchyType>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<OptionGroup>? AllOptionGroupsByRegionFromAws
        // GraphQL -> allOptionGroupsByRegionFromAws: [OptionGroup!]! (type)
        public static string AllOptionGroupsByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\ndbEngine: $dbEngine\ndbEngineVersion: $dbEngineVersion\nmajorEngineVersion: $majorEngineVersion\n)";
            return "allOptionGroupsByRegionFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllOptionGroupsByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<OptionGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Org>? AllOrgsByIds
        // GraphQL -> allOrgsByIds: [Org!]! (type)
        public static string AllOrgsByIds(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgIds: $orgIds\n)";
            return "allOrgsByIds" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllOrgsByIdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<Org>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<PendingAction>? AllPendingActions
        // GraphQL -> allPendingActions: [pendingAction!]! (type)
        public static string AllPendingActions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterFilter: $clusterFilter\npendingActionGroupTypeFilter: $pendingActionGroupTypeFilter\npendingActionSubGroupTypeFilter: $pendingActionSubGroupTypeFilter\nstatusFilter: $statusFilter\nobjectIds: $objectIds\nsortedOrder: $sortedOrder\nhistoryOnly: $historyOnly\nlimit: $limit\n)";
            return "allPendingActions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllPendingActionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<PendingAction>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForSnapshots
        // GraphQL -> allQuarantinedDetailsForSnapshots: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            return "allQuarantinedDetailsForSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllQuarantinedDetailsForSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<QuarantineSpec>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<QuarantineSpec>? AllQuarantinedDetailsForWorkload
        // GraphQL -> allQuarantinedDetailsForWorkload: [QuarantineSpec!]! (type)
        public static string AllQuarantinedDetailsForWorkload(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadId: $workloadId\n)";
            return "allQuarantinedDetailsForWorkload" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllQuarantinedDetailsForWorkloadFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<QuarantineSpec>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AllRcvAccountEntitlements? AllRcvAccountEntitlements
        // GraphQL -> allRcvAccountEntitlements: AllRcvAccountEntitlements! (type)
        public static string AllRcvAccountEntitlements(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "allRcvAccountEntitlements" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllRcvAccountEntitlementsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AllRcvAccountEntitlements() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<DetailedPrivateEndpointConnection>? AllRcvPrivateEndpointConnections
        // GraphQL -> allRcvPrivateEndpointConnections: [DetailedPrivateEndpointConnection!]! (type)
        public static string AllRcvPrivateEndpointConnections(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allRcvPrivateEndpointConnections" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllRcvPrivateEndpointConnectionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<DetailedPrivateEndpointConnection>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AzureResourceGroup>? AllResourceGroupsFromAzure
        // GraphQL -> allResourceGroupsFromAzure: [AzureResourceGroup!]! (type)
        public static string AllResourceGroupsFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nazureSubscriptionNativeId: $azureSubscriptionNativeId\nfeature: $feature\n)";
            return "allResourceGroupsFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllResourceGroupsFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AzureResourceGroup>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<S3BucketDetails>? AllS3BucketsDetailsFromAws
        // GraphQL -> allS3BucketsDetailsFromAws: [S3BucketDetails!]! (type)
        public static string AllS3BucketsDetailsFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allS3BucketsDetailsFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllS3BucketsDetailsFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<S3BucketDetails>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<FullSpSiteExclusions>? AllSharepointSiteExclusions
        // GraphQL -> allSharepointSiteExclusions: [FullSpSiteExclusions!]! (type)
        public static string AllSharepointSiteExclusions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\nsiteFids: $siteFids\n)";
            return "allSharepointSiteExclusions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllSharepointSiteExclusionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<FullSpSiteExclusions>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<PvcInformation>? AllSnapshotPvcs
        // GraphQL -> allSnapshotPvcs: [PvcInformation!]! (type)
        public static string AllSnapshotPvcs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\nsnappableId: $snappableId\nisReplica: $isReplica\n)";
            return "allSnapshotPvcs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllSnapshotPvcsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<PvcInformation>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ClosestSnapshotSearchResult>? AllSnapshotsClosestToPointInTime
        // GraphQL -> allSnapshotsClosestToPointInTime: [ClosestSnapshotSearchResult!]! (type)
        public static string AllSnapshotsClosestToPointInTime(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nbeforeTime: $beforeTime\nafterTime: $afterTime\nsnappableIds: $snappableIds\nincludeLinked: $includeLinked\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\nexcludeQuarantined: $excludeQuarantined\nexcludeAnomalous: $excludeAnomalous\n)";
            return "allSnapshotsClosestToPointInTime" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllSnapshotsClosestToPointInTimeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ClosestSnapshotSearchResult>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AllStorageArraysReply? AllStorageArrays
        // GraphQL -> allStorageArrays: AllStorageArraysReply! (type)
        public static string AllStorageArrays(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allStorageArrays" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllStorageArraysFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AllStorageArraysReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<TargetMapping>? AllTargetMappings
        // GraphQL -> allTargetMappings: [TargetMapping!]! (type)
        public static string AllTargetMappings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\nisRcsStatsRequired: $isRcsStatsRequired\n)";
            return "allTargetMappings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllTargetMappingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<TargetMapping>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<PolicySummary>? AllTopRiskPolicySummaries
        // GraphQL -> allTopRiskPolicySummaries: [PolicySummary!]! (type)
        public static string AllTopRiskPolicySummaries(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\nlimit: $limit\nworkloadTypes: $workloadTypes\n)";
            return "allTopRiskPolicySummaries" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllTopRiskPolicySummariesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<PolicySummary>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GetCustomerFacingDownloadsReply>? AllUserFiles
        // GraphQL -> allUserFiles: [GetCustomerFacingDownloadsReply!]! (type)
        public static string AllUserFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "allUserFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllUserFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GetCustomerFacingDownloadsReply>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<User>? AllUsersOnAccount
        // GraphQL -> allUsersOnAccount: [User!]! (type)
        public static string AllUsersOnAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "allUsersOnAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllUsersOnAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<User>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserConnection? AllUsersOnAccountConnection
        // GraphQL -> allUsersOnAccountConnection: UserConnection! (type)
        public static string AllUsersOnAccountConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nemailFilter: $emailFilter\nroleIdsFilter: $roleIdsFilter\nlockoutStateFilter: $lockoutStateFilter\nhiddenStateFilter: $hiddenStateFilter\nshouldGetLocalUsersOnly: $shouldGetLocalUsersOnly\n)";
            return "allUsersOnAccountConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllUsersOnAccountConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidReplicationSourceConnection? AllValidReplicationSources
        // GraphQL -> allValidReplicationSources: ValidReplicationSourceConnection! (type)
        public static string AllValidReplicationSources(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nisCrossAccount: $isCrossAccount\n)";
            return "allValidReplicationSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllValidReplicationSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidReplicationSourceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidReplicationTargetConnection? AllValidReplicationTargets
        // GraphQL -> allValidReplicationTargets: ValidReplicationTargetConnection! (type)
        public static string AllValidReplicationTargets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nisCrossAccount: $isCrossAccount\n)";
            return "allValidReplicationTargets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllValidReplicationTargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidReplicationTargetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<VcenterHotAddProxyVmInfo>? AllVcenterHotAddProxyVms
        // GraphQL -> allVcenterHotAddProxyVms: [VcenterHotAddProxyVmInfo!]! (type)
        public static string AllVcenterHotAddProxyVms(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuids: $clusterUuids\n)";
            return "allVcenterHotAddProxyVms" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVcenterHotAddProxyVmsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<VcenterHotAddProxyVmInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VirtualMachineFilesReply? AllVirtualMachineFiles
        // GraphQL -> allVirtualMachineFiles: VirtualMachineFilesReply! (type)
        public static string AllVirtualMachineFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "allVirtualMachineFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVirtualMachineFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VirtualMachineFilesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<VmRecoveryJobInfo>? AllVmRecoveryJobsInfo
        // GraphQL -> allVmRecoveryJobsInfo: [VmRecoveryJobInfo!]! (type)
        public static string AllVmRecoveryJobsInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\ninput: $input\n)";
            return "allVmRecoveryJobsInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVmRecoveryJobsInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<VmRecoveryJobInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<VmwareCdpStateInfo>? AllVmwareCdpStateInfos
        // GraphQL -> allVmwareCdpStateInfos: [VmwareCdpStateInfo!]! (type)
        public static string AllVmwareCdpStateInfos(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nids: $ids\n)";
            return "allVmwareCdpStateInfos" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVmwareCdpStateInfosFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<VmwareCdpStateInfo>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsVpc>? AllVpcsByRegionFromAws
        // GraphQL -> allVpcsByRegionFromAws: [AwsVpc!]! (type)
        public static string AllVpcsByRegionFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "allVpcsByRegionFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVpcsByRegionFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsVpc>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<AwsVpc>? AllVpcsFromAws
        // GraphQL -> allVpcsFromAws: [AwsVpc!]! (type)
        public static string AllVpcsFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\n)";
            return "allVpcsFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllVpcsFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<AwsVpc>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> WebhookConnection? AllWebhooks
        // GraphQL -> allWebhooks: WebhookConnection! (type)
        public static string AllWebhooks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nname: $name\n)";
            return "allWebhooks" + args + "\n{\n" + fs + "}\n";
        }
        public static object AllWebhooksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new WebhookConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AmiTypeForAwsNativeArchivedSnapshotExportReply? AmiTypeForAwsNativeArchivedSnapshotExport
        // GraphQL -> amiTypeForAwsNativeArchivedSnapshotExport: AmiTypeForAwsNativeArchivedSnapshotExportReply! (type)
        public static string AmiTypeForAwsNativeArchivedSnapshotExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "amiTypeForAwsNativeArchivedSnapshotExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object AmiTypeForAwsNativeArchivedSnapshotExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AmiTypeForAwsNativeArchivedSnapshotExportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnalyzerGroupConnection? AnalyzerGroups
        // GraphQL -> analyzerGroups: AnalyzerGroupConnection! (type)
        public static string AnalyzerGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "analyzerGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object AnalyzerGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnalyzerGroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnalyzerUsageConnection? AnalyzerUsages
        // GraphQL -> analyzerUsages: AnalyzerUsageConnection! (type)
        public static string AnalyzerUsages(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "analyzerUsages" + args + "\n{\n" + fs + "}\n";
        }
        public static object AnalyzerUsagesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnalyzerUsageConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetAnomalyDetailsReply? AnomalyResultOpt
        // GraphQL -> anomalyResultOpt: GetAnomalyDetailsReply (type)
        public static string AnomalyResultOpt(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nsnapshotId: $snapshotId\nworkloadId: $workloadId\nanomalyId: $anomalyId\n)";
            return "anomalyResultOpt" + args + "\n{\n" + fs + "}\n";
        }
        public static object AnomalyResultOptFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetAnomalyDetailsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        public static string AnomalyResults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "anomalyResults" + args + "\n{\n" + fs + "}\n";
        }
        public static object AnomalyResultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnomalyResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnomalyResultGroupedDataConnection? AnomalyResultsGrouped
        // GraphQL -> anomalyResultsGrouped: AnomalyResultGroupedDataConnection! (type)
        public static string AnomalyResultsGrouped(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "anomalyResultsGrouped" + args + "\n{\n" + fs + "}\n";
        }
        public static object AnomalyResultsGroupedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnomalyResultGroupedDataConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<ArchivalStorageUsage>? ArchivalStorageUsage
        // GraphQL -> archivalStorageUsage: [ArchivalStorageUsage!]! (type)
        public static string ArchivalStorageUsage(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "archivalStorageUsage" + args + "\n{\n" + fs + "}\n";
        }
        public static object ArchivalStorageUsageFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<ArchivalStorageUsage>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalCertificateConnection? AssignableGlobalCertificates
        // GraphQL -> assignableGlobalCertificates: GlobalCertificateConnection! (type)
        public static string AssignableGlobalCertificates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\ninput: $input\n)";
            return "assignableGlobalCertificates" + args + "\n{\n" + fs + "}\n";
        }
        public static object AssignableGlobalCertificatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalCertificateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsArtifactsToDelete? AwsArtifactsToDelete
        // GraphQL -> awsArtifactsToDelete: AwsArtifactsToDelete! (type)
        public static string AwsArtifactsToDelete(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "awsArtifactsToDelete" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsArtifactsToDeleteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsArtifactsToDelete() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsCloudAccountListSecurityGroupsResponse? AwsCloudAccountListSecurityGroups
        // GraphQL -> awsCloudAccountListSecurityGroups: AwsCloudAccountListSecurityGroupsResponse! (type)
        public static string AwsCloudAccountListSecurityGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            return "awsCloudAccountListSecurityGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsCloudAccountListSecurityGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsCloudAccountListSecurityGroupsResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsCloudAccountListSubnetsResponse? AwsCloudAccountListSubnets
        // GraphQL -> awsCloudAccountListSubnets: AwsCloudAccountListSubnetsResponse! (type)
        public static string AwsCloudAccountListSubnets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\nvpcID: $vpcID\n)";
            return "awsCloudAccountListSubnets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsCloudAccountListSubnetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsCloudAccountListSubnetsResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsCloudAccountListVpcResponse? AwsCloudAccountListVpcs
        // GraphQL -> awsCloudAccountListVpcs: AwsCloudAccountListVpcResponse! (type)
        public static string AwsCloudAccountListVpcs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountUuid: $cloudAccountUuid\nfeature: $feature\nregion: $region\n)";
            return "awsCloudAccountListVpcs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsCloudAccountListVpcsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsCloudAccountListVpcResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsCloudAccountWithFeatures? AwsCloudAccountWithFeatures
        // GraphQL -> awsCloudAccountWithFeatures: AwsCloudAccountWithFeatures! (type)
        public static string AwsCloudAccountWithFeatures(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nawsCloudAccountArg: $awsCloudAccountArg\n)";
            return "awsCloudAccountWithFeatures" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsCloudAccountWithFeaturesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsCloudAccountWithFeatures() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsComputeSettings? AwsComputeSettings
        // GraphQL -> awsComputeSettings: AwsComputeSettings! (type)
        public static string AwsComputeSettings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncomputeSettingId: $computeSettingId\n)";
            return "awsComputeSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsComputeSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsComputeSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        public static string AwsNativeAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsNativeAccountRubrikId: $awsNativeAccountRubrikId\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            return "awsNativeAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeAccount() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeAccountConnection? AwsNativeAccounts
        // GraphQL -> awsNativeAccounts: AwsNativeAccountConnection! (type)
        public static string AwsNativeAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\naccountFilters: $accountFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nawsNativeProtectionFeature: $awsNativeProtectionFeature\n)";
            return "awsNativeAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeAccountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEbsVolume? AwsNativeEbsVolume
        // GraphQL -> awsNativeEbsVolume: AwsNativeEbsVolume! (type)
        public static string AwsNativeEbsVolume(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nebsVolumeRubrikId: $ebsVolumeRubrikId\n)";
            return "awsNativeEbsVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEbsVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEbsVolume() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeFilters: $ebsVolumeFilters\n)";
            return "awsNativeEbsVolumes" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEbsVolumesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEbsVolumeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumesByName
        // GraphQL -> awsNativeEbsVolumesByName: AwsNativeEbsVolumeConnection! (type)
        public static string AwsNativeEbsVolumesByName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nebsVolumeName: $ebsVolumeName\n)";
            return "awsNativeEbsVolumesByName" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEbsVolumesByNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEbsVolumeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEc2Instance? AwsNativeEc2Instance
        // GraphQL -> awsNativeEc2Instance: AwsNativeEc2Instance! (type)
        public static string AwsNativeEc2Instance(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nec2InstanceRubrikId: $ec2InstanceRubrikId\n)";
            return "awsNativeEc2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEc2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEc2Instance() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2Instances(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nec2InstanceFilters: $ec2InstanceFilters\n)";
            return "awsNativeEc2Instances" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEc2InstancesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEc2InstanceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2InstancesByName
        // GraphQL -> awsNativeEc2InstancesByName: AwsNativeEc2InstanceConnection! (type)
        public static string AwsNativeEc2InstancesByName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nec2InstanceName: $ec2InstanceName\n)";
            return "awsNativeEc2InstancesByName" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeEc2InstancesByNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeEc2InstanceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RdsInstanceExportDefaults? AwsNativeRdsExportDefaults
        // GraphQL -> awsNativeRdsExportDefaults: RdsInstanceExportDefaults! (type)
        public static string AwsNativeRdsExportDefaults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\nsnapshotId: $snapshotId\nisPointInTime: $isPointInTime\n)";
            return "awsNativeRdsExportDefaults" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeRdsExportDefaultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RdsInstanceExportDefaults() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeRdsInstance? AwsNativeRdsInstance
        // GraphQL -> awsNativeRdsInstance: AwsNativeRdsInstance! (type)
        public static string AwsNativeRdsInstance(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrdsInstanceRubrikId: $rdsInstanceRubrikId\n)";
            return "awsNativeRdsInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeRdsInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeRdsInstance() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        public static string AwsNativeRdsInstances(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nrdsInstanceFilters: $rdsInstanceFilters\n)";
            return "awsNativeRdsInstances" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeRdsInstancesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeRdsInstanceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeRdsPointInTimeRestoreWindow? AwsNativeRdsPointInTimeRestoreWindow
        // GraphQL -> awsNativeRdsPointInTimeRestoreWindow: AwsNativeRdsPointInTimeRestoreWindow! (type)
        public static string AwsNativeRdsPointInTimeRestoreWindow(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            return "awsNativeRdsPointInTimeRestoreWindow" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeRdsPointInTimeRestoreWindowFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeRdsPointInTimeRestoreWindow() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeRoot? AwsNativeRoot
        // GraphQL -> awsNativeRoot: AwsNativeRoot! (type)
        public static string AwsNativeRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "awsNativeRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsNativeS3Bucket? AwsNativeS3Bucket
        // GraphQL -> awsNativeS3Bucket: AwsNativeS3Bucket! (type)
        public static string AwsNativeS3Bucket(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ns3BucketRubrikId: $s3BucketRubrikId\n)";
            return "awsNativeS3Bucket" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsNativeS3BucketFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsNativeS3Bucket() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AwsTrustPolicy? AwsTrustPolicy
        // GraphQL -> awsTrustPolicy: AwsTrustPolicy! (type)
        public static string AwsTrustPolicy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "awsTrustPolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object AwsTrustPolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AwsTrustPolicy() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureAdDirectoryConnection? AzureAdDirectories
        // GraphQL -> azureAdDirectories: AzureAdDirectoryConnection! (type)
        public static string AzureAdDirectories(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "azureAdDirectories" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureAdDirectoriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureAdDirectoryConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureAdDirectory? AzureAdDirectory
        // GraphQL -> azureAdDirectory: AzureAdDirectory! (type)
        public static string AzureAdDirectory(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadFid: $workloadFid\n)";
            return "azureAdDirectory" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureAdDirectoryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureAdDirectory() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureAdObjectConnection? AzureAdObjectsByType
        // GraphQL -> azureAdObjectsByType: AzureAdObjectConnection! (type)
        public static string AzureAdObjectsByType(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortByOption: $sortByOption\nsortOrder: $sortOrder\ninput: $input\n)";
            return "azureAdObjectsByType" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureAdObjectsByTypeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureAdObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureCloudAccountDetailsForFeatureReply? AzureCloudAccountDetailsForFeature
        // GraphQL -> azureCloudAccountDetailsForFeature: AzureCloudAccountDetailsForFeatureReply! (type)
        public static string AzureCloudAccountDetailsForFeature(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeatureId: $featureId\n)";
            return "azureCloudAccountDetailsForFeature" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureCloudAccountDetailsForFeatureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureCloudAccountDetailsForFeatureReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureCloudAccountPermissionConfigResponse? AzureCloudAccountPermissionConfig
        // GraphQL -> azureCloudAccountPermissionConfig: AzureCloudAccountPermissionConfigResponse! (type)
        public static string AzureCloudAccountPermissionConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeature: $feature\npermissionsGroups: $permissionsGroups\n)";
            return "azureCloudAccountPermissionConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureCloudAccountPermissionConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureCloudAccountPermissionConfigResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureCloudAccountSubscriptionWithFeatures? AzureCloudAccountSubscriptionWithFeatures
        // GraphQL -> azureCloudAccountSubscriptionWithFeatures: AzureCloudAccountSubscriptionWithFeatures! (type)
        public static string AzureCloudAccountSubscriptionWithFeatures(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\n)";
            return "azureCloudAccountSubscriptionWithFeatures" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureCloudAccountSubscriptionWithFeaturesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureCloudAccountSubscriptionWithFeatures() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureCloudAccountTenant? AzureCloudAccountTenant
        // GraphQL -> azureCloudAccountTenant: AzureCloudAccountTenant! (type)
        public static string AzureCloudAccountTenant(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            return "azureCloudAccountTenant" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureCloudAccountTenantFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureCloudAccountTenant() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureCloudAccountTenantWithExoConfigs? AzureCloudAccountTenantWithExoConfigs
        // GraphQL -> azureCloudAccountTenantWithExoConfigs: AzureCloudAccountTenantWithExoConfigs! (type)
        public static string AzureCloudAccountTenantWithExoConfigs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nfeature: $feature\nsubscriptionStatusFilters: $subscriptionStatusFilters\nsubscriptionSearchText: $subscriptionSearchText\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            return "azureCloudAccountTenantWithExoConfigs" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureCloudAccountTenantWithExoConfigsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureCloudAccountTenantWithExoConfigs() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeManagedDisk? AzureNativeManagedDisk
        // GraphQL -> azureNativeManagedDisk: AzureNativeManagedDisk! (type)
        public static string AzureNativeManagedDisk(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureManagedDiskRubrikId: $azureManagedDiskRubrikId\n)";
            return "azureNativeManagedDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeManagedDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeManagedDisk() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeManagedDiskConnection? AzureNativeManagedDisks
        // GraphQL -> azureNativeManagedDisks: AzureNativeManagedDiskConnection! (type)
        public static string AzureNativeManagedDisks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            return "azureNativeManagedDisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeManagedDisksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeManagedDiskConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        public static string AzureNativeResourceGroup(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nresourceGroupId: $resourceGroupId\n)";
            return "azureNativeResourceGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeResourceGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeResourceGroup() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        public static string AzureNativeResourceGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ncommonResourceGroupFilters: $commonResourceGroupFilters\nprotectedObjectTypes: $protectedObjectTypes\nazureNativeProtectionFeatures: $azureNativeProtectionFeatures\n)";
            return "azureNativeResourceGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeResourceGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeResourceGroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeRoot? AzureNativeRoot
        // GraphQL -> azureNativeRoot: AzureNativeRoot! (type)
        public static string AzureNativeRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "azureNativeRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeSubscription? AzureNativeSubscription
        // GraphQL -> azureNativeSubscription: AzureNativeSubscription! (type)
        public static string AzureNativeSubscription(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSubscriptionRubrikId: $azureSubscriptionRubrikId\n)";
            return "azureNativeSubscription" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeSubscriptionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeSubscription() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeSubscriptionConnection? AzureNativeSubscriptions
        // GraphQL -> azureNativeSubscriptions: AzureNativeSubscriptionConnection! (type)
        public static string AzureNativeSubscriptions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nsubscriptionFilters: $subscriptionFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\nazureNativeProtectionFeature: $azureNativeProtectionFeature\n)";
            return "azureNativeSubscriptions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeSubscriptionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeSubscriptionConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeVirtualMachine? AzureNativeVirtualMachine
        // GraphQL -> azureNativeVirtualMachine: AzureNativeVirtualMachine! (type)
        public static string AzureNativeVirtualMachine(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureVirtualMachineRubrikId: $azureVirtualMachineRubrikId\n)";
            return "azureNativeVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeVirtualMachine() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        public static string AzureNativeVirtualMachines(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndescendantTypeFilter: $descendantTypeFilter\nvirtualMachineFilters: $virtualMachineFilters\n)";
            return "azureNativeVirtualMachines" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureNativeVirtualMachinesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeVirtualMachineConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNetworkSecurityGroupResp? AzureO365CheckNsgOutboundRules
        // GraphQL -> azureO365CheckNSGOutboundRules: AzureNetworkSecurityGroupResp! (type)
        public static string AzureO365CheckNsgOutboundRules(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\n)";
            return "azureO365CheckNSGOutboundRules" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckNsgOutboundRulesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNetworkSecurityGroupResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNetworkSubnetResp? AzureO365CheckNetworkSubnet
        // GraphQL -> azureO365CheckNetworkSubnet: AzureNetworkSubnetResp! (type)
        public static string AzureO365CheckNetworkSubnet(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            return "azureO365CheckNetworkSubnet" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckNetworkSubnetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNetworkSubnetResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckResourceGroupName
        // GraphQL -> azureO365CheckResourceGroupName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckResourceGroupName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\n)";
            return "azureO365CheckResourceGroupName" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckResourceGroupNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureResourceAvailabilityResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountAccessibility
        // GraphQL -> azureO365CheckStorageAccountAccessibility: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountAccessibility(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\ngroupName: $groupName\n)";
            return "azureO365CheckStorageAccountAccessibility" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckStorageAccountAccessibilityFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureResourceAvailabilityResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckStorageAccountName
        // GraphQL -> azureO365CheckStorageAccountName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckStorageAccountName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nstorage_account_name: $storage_account_name\n)";
            return "azureO365CheckStorageAccountName" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckStorageAccountNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureResourceAvailabilityResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckSubscriptionQuota
        // GraphQL -> azureO365CheckSubscriptionQuota: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckSubscriptionQuota(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            return "azureO365CheckSubscriptionQuota" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckSubscriptionQuotaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureResourceAvailabilityResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureResourceAvailabilityResp? AzureO365CheckVirtualNetworkName
        // GraphQL -> azureO365CheckVirtualNetworkName: AzureResourceAvailabilityResp! (type)
        public static string AzureO365CheckVirtualNetworkName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\ngroupName: $groupName\nvnet_name: $vnet_name\n)";
            return "azureO365CheckVirtualNetworkName" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365CheckVirtualNetworkNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureResourceAvailabilityResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetAzureO365ExocomputeResp? AzureO365Exocompute
        // GraphQL -> azureO365Exocompute: GetAzureO365ExocomputeResp! (type)
        public static string AzureO365Exocompute(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\nexocomputeClusterId: $exocomputeClusterId\n)";
            return "azureO365Exocompute" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365ExocomputeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetAzureO365ExocomputeResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetAzureHostTypeResp? AzureO365GetAzureHostType
        // GraphQL -> azureO365GetAzureHostType: GetAzureHostTypeResp! (type)
        public static string AzureO365GetAzureHostType(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "azureO365GetAzureHostType" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365GetAzureHostTypeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetAzureHostTypeResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNetworkSubnetUnusedAddrResp? AzureO365GetNetworkSubnetUnusedAddr
        // GraphQL -> azureO365GetNetworkSubnetUnusedAddr: AzureNetworkSubnetUnusedAddrResp! (type)
        public static string AzureO365GetNetworkSubnetUnusedAddr(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nvnet_name: $vnet_name\nsubnet_name: $subnet_name\nstrict_addr_check: $strict_addr_check\n)";
            return "azureO365GetNetworkSubnetUnusedAddr" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365GetNetworkSubnetUnusedAddrFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNetworkSubnetUnusedAddrResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureUserRoleResp? AzureO365ValidateUserRoles
        // GraphQL -> azureO365ValidateUserRoles: AzureUserRoleResp! (type)
        public static string AzureO365ValidateUserRoles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            return "azureO365ValidateUserRoles" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureO365ValidateUserRolesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureUserRoleResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RegionConnection? AzureRegions
        // GraphQL -> azureRegions: RegionConnection! (type)
        public static string AzureRegions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            return "azureRegions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureRegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RegionConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ResourceGroupConnection? AzureResourceGroups
        // GraphQL -> azureResourceGroups: ResourceGroupConnection! (type)
        public static string AzureResourceGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\n)";
            return "azureResourceGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureResourceGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ResourceGroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlDatabaseDb? AzureSqlDatabase
        // GraphQL -> azureSqlDatabase: AzureSqlDatabaseDb! (type)
        public static string AzureSqlDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlDatabaseRubrikId: $azureSqlDatabaseRubrikId\n)";
            return "azureSqlDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlDatabaseDb() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlDatabaseServerName: $azureSqlDatabaseServerName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            return "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        public static string AzureSqlDatabaseServer(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            return "azureSqlDatabaseServer" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlDatabaseServerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlDatabaseServer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlDatabaseServerConnection? AzureSqlDatabaseServers
        // GraphQL -> azureSqlDatabaseServers: AzureSqlDatabaseServerConnection! (type)
        public static string AzureSqlDatabaseServers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseServerFilters: $azureSqlDatabaseServerFilters\n)";
            return "azureSqlDatabaseServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlDatabaseServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlDatabaseServerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlDatabaseDbConnection? AzureSqlDatabases
        // GraphQL -> azureSqlDatabases: AzureSqlDatabaseDbConnection! (type)
        public static string AzureSqlDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlDatabaseFilters: $azureSqlDatabaseFilters\n)";
            return "azureSqlDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlDatabaseDbConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlManagedInstanceDatabase? AzureSqlManagedInstanceDatabase
        // GraphQL -> azureSqlManagedInstanceDatabase: AzureSqlManagedInstanceDatabase! (type)
        public static string AzureSqlManagedInstanceDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlManagedInstanceDatabaseRubrikId: $azureSqlManagedInstanceDatabaseRubrikId\n)";
            return "azureSqlManagedInstanceDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlManagedInstanceDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlManagedInstanceDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlManagedInstanceDatabaseConnection? AzureSqlManagedInstanceDatabases
        // GraphQL -> azureSqlManagedInstanceDatabases: AzureSqlManagedInstanceDatabaseConnection! (type)
        public static string AzureSqlManagedInstanceDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceDatabaseFilters: $azureSqlManagedInstanceDatabaseFilters\n)";
            return "azureSqlManagedInstanceDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlManagedInstanceDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlManagedInstanceDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureNativeSqlDatabasePointInTimeRestoreWindow? AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
        // GraphQL -> azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure: AzureNativeSqlDatabasePointInTimeRestoreWindow! (type)
        public static string AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsubscriptionId: $subscriptionId\nresourceGroupName: $resourceGroupName\nazureSqlManagedInstanceName: $azureSqlManagedInstanceName\nazureSqlDatabaseName: $azureSqlDatabaseName\n)";
            return "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzureFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureNativeSqlDatabasePointInTimeRestoreWindow() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlManagedInstanceServer? AzureSqlManagedInstanceServer
        // GraphQL -> azureSqlManagedInstanceServer: AzureSqlManagedInstanceServer! (type)
        public static string AzureSqlManagedInstanceServer(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            return "azureSqlManagedInstanceServer" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlManagedInstanceServerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlManagedInstanceServer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSqlManagedInstanceServerConnection? AzureSqlManagedInstanceServers
        // GraphQL -> azureSqlManagedInstanceServers: AzureSqlManagedInstanceServerConnection! (type)
        public static string AzureSqlManagedInstanceServers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nazureSqlManagedInstanceServerFilters: $azureSqlManagedInstanceServerFilters\n)";
            return "azureSqlManagedInstanceServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSqlManagedInstanceServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSqlManagedInstanceServerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> StorageAccountConnection? AzureStorageAccounts
        // GraphQL -> azureStorageAccounts: StorageAccountConnection! (type)
        public static string AzureStorageAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            return "azureStorageAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureStorageAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new StorageAccountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SubnetConnection? AzureSubnets
        // GraphQL -> azureSubnets: SubnetConnection! (type)
        public static string AzureSubnets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nvNetId: $vNetId\n)";
            return "azureSubnets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSubnetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SubnetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureSubscriptionConnection? AzureSubscriptions
        // GraphQL -> azureSubscriptions: AzureSubscriptionConnection! (type)
        public static string AzureSubscriptions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\n)";
            return "azureSubscriptions" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureSubscriptionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureSubscriptionConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VnetConnection? AzureVnets
        // GraphQL -> azureVNets: VnetConnection! (type)
        public static string AzureVnets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntenantId: $tenantId\nsubscriptionId: $subscriptionId\nregionName: $regionName\n)";
            return "azureVNets" + args + "\n{\n" + fs + "}\n";
        }
        public static object AzureVnetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VnetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? BrowseCalendar
        // GraphQL -> browseCalendar: O365ExchangeObjectConnection! (type)
        public static string BrowseCalendar(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            return "browseCalendar" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseCalendarFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? BrowseContacts
        // GraphQL -> browseContacts: O365ExchangeObjectConnection! (type)
        public static string BrowseContacts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            return "browseContacts" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseContactsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? BrowseFolder
        // GraphQL -> browseFolder: O365ExchangeObjectConnection! (type)
        public static string BrowseFolder(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\norgId: $orgId\n)";
            return "browseFolder" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseFolderFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamConvChannelConnection? BrowseO365TeamConvChannels
        // GraphQL -> browseO365TeamConvChannels: O365TeamConvChannelConnection! (type)
        public static string BrowseO365TeamConvChannels(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFidOpt: $snapshotFidOpt\nexcludeArchived: $excludeArchived\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            return "browseO365TeamConvChannels" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseO365TeamConvChannelsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamConvChannelConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? BrowseOnedrive
        // GraphQL -> browseOnedrive: O365OnedriveObjectConnection! (type)
        public static string BrowseOnedrive(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nonedriveSearchFilter: $onedriveSearchFilter\norgId: $orgId\n)";
            return "browseOnedrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseOnedriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointDrive
        // GraphQL -> browseSharepointDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointDrive(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            return "browseSharepointDrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseSharepointDriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? BrowseSharepointList
        // GraphQL -> browseSharepointList: O365OnedriveObjectConnection! (type)
        public static string BrowseSharepointList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\norgId: $orgId\nsiteChildId: $siteChildId\n)";
            return "browseSharepointList" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseSharepointListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotFileConnection? BrowseSnapshotFileConnection
        // GraphQL -> browseSnapshotFileConnection: SnapshotFileConnection! (type)
        public static string BrowseSnapshotFileConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            return "browseSnapshotFileConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseSnapshotFileConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotFileConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamsChannelConnection? BrowseTeamsChannels
        // GraphQL -> browseTeamsChannels: O365TeamsChannelConnection! (type)
        public static string BrowseTeamsChannels(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            return "browseTeamsChannels" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseTeamsChannelsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamsChannelConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? BrowseTeamsDrive
        // GraphQL -> browseTeamsDrive: O365OnedriveObjectConnection! (type)
        public static string BrowseTeamsDrive(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nfolderId: $folderId\nteamsDriveSearchFilter: $teamsDriveSearchFilter\norgId: $orgId\n)";
            return "browseTeamsDrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object BrowseTeamsDriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraColumnFamilyConnection? CassandraColumnFamilies
        // GraphQL -> cassandraColumnFamilies: CassandraColumnFamilyConnection! (type)
        public static string CassandraColumnFamilies(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "cassandraColumnFamilies" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraColumnFamiliesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraColumnFamilyConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraColumnFamily? CassandraColumnFamily
        // GraphQL -> cassandraColumnFamily: CassandraColumnFamily! (type)
        public static string CassandraColumnFamily(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "cassandraColumnFamily" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraColumnFamilyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraColumnFamily() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetMosaicRecoverableRangeResponse? CassandraColumnFamilyRecoverableRange
        // GraphQL -> cassandraColumnFamilyRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string CassandraColumnFamilyRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "cassandraColumnFamilyRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraColumnFamilyRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetMosaicRecoverableRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetSchemaResponse? CassandraColumnFamilySchema
        // GraphQL -> cassandraColumnFamilySchema: GetSchemaResponse! (type)
        public static string CassandraColumnFamilySchema(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "cassandraColumnFamilySchema" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraColumnFamilySchemaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetSchemaResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraKeyspace? CassandraKeyspace
        // GraphQL -> cassandraKeyspace: CassandraKeyspace! (type)
        public static string CassandraKeyspace(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "cassandraKeyspace" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraKeyspaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraKeyspace() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraKeyspaceConnection? CassandraKeyspaces
        // GraphQL -> cassandraKeyspaces: CassandraKeyspaceConnection! (type)
        public static string CassandraKeyspaces(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "cassandraKeyspaces" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraKeyspacesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraKeyspaceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraSource? CassandraSource
        // GraphQL -> cassandraSource: CassandraSource! (type)
        public static string CassandraSource(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "cassandraSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraSource() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CassandraSourceConnection? CassandraSources
        // GraphQL -> cassandraSources: CassandraSourceConnection! (type)
        public static string CassandraSources(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "cassandraSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object CassandraSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CassandraSourceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmInventorySubHierarchyRoot? CdmInventorySubHierarchyRoot
        // GraphQL -> cdmInventorySubHierarchyRoot: CdmInventorySubHierarchyRoot! (type)
        public static string CdmInventorySubHierarchyRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrootEnum: $rootEnum\n)";
            return "cdmInventorySubHierarchyRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmInventorySubHierarchyRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmInventorySubHierarchyRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlLogShippingTarget? CdmMssqlLogShippingTarget
        // GraphQL -> cdmMssqlLogShippingTarget: MssqlLogShippingTarget (type)
        public static string CdmMssqlLogShippingTarget(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "cdmMssqlLogShippingTarget" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmMssqlLogShippingTargetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlLogShippingTarget() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlLogShippingTargetConnection? CdmMssqlLogShippingTargets
        // GraphQL -> cdmMssqlLogShippingTargets: MssqlLogShippingTargetConnection! (type)
        public static string CdmMssqlLogShippingTargets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            return "cdmMssqlLogShippingTargets" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmMssqlLogShippingTargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlLogShippingTargetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FeatureCdmVersionReply? CdmVersionCheck
        // GraphQL -> cdmVersionCheck: FeatureCdmVersionReply! (type)
        public static string CdmVersionCheck(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeatureToCdmVersion: $featureToCdmVersion\n)";
            return "cdmVersionCheck" + args + "\n{\n" + fs + "}\n";
        }
        public static object CdmVersionCheckFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FeatureCdmVersionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetCertificateInfoReply? CertificateInfo
        // GraphQL -> certificateInfo: GetCertificateInfoReply! (type)
        public static string CertificateInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "certificateInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object CertificateInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetCertificateInfoReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Csr? CertificateSigningRequest
        // GraphQL -> certificateSigningRequest: Csr! (type)
        public static string CertificateSigningRequest(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "certificateSigningRequest" + args + "\n{\n" + fs + "}\n";
        }
        public static object CertificateSigningRequestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Csr() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CsrConnection? CertificateSigningRequests
        // GraphQL -> certificateSigningRequests: CsrConnection! (type)
        public static string CertificateSigningRequests(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            return "certificateSigningRequests" + args + "\n{\n" + fs + "}\n";
        }
        public static object CertificateSigningRequestsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CsrConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CertificateConnection? Certificates
        // GraphQL -> certificates: CertificateConnection! (type)
        public static string Certificates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchTerm: $searchTerm\n)";
            return "certificates" + args + "\n{\n" + fs + "}\n";
        }
        public static object CertificatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CertificateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CertificateConnection? CertificatesWithKey
        // GraphQL -> certificatesWithKey: CertificateConnection! (type)
        public static string CertificatesWithKey(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "certificatesWithKey" + args + "\n{\n" + fs + "}\n";
        }
        public static object CertificatesWithKeyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CertificateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CheckAzurePersistentStorageSubscriptionCanUnmapReply? CheckAzurePersistentStorageSubscriptionCanUnmap
        // GraphQL -> checkAzurePersistentStorageSubscriptionCanUnmap: CheckAzurePersistentStorageSubscriptionCanUnmapReply! (type)
        public static string CheckAzurePersistentStorageSubscriptionCanUnmap(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudAccountId: $cloudAccountId\nfeature: $feature\nunmappingValidationType: $unmappingValidationType\n)";
            return "checkAzurePersistentStorageSubscriptionCanUnmap" + args + "\n{\n" + fs + "}\n";
        }
        public static object CheckAzurePersistentStorageSubscriptionCanUnmapFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CheckAzurePersistentStorageSubscriptionCanUnmapReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? CheckCloudComputeConnectivityJobProgress
        // GraphQL -> checkCloudComputeConnectivityJobProgress: AsyncRequestStatus! (type)
        public static string CheckCloudComputeConnectivityJobProgress(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "checkCloudComputeConnectivityJobProgress" + args + "\n{\n" + fs + "}\n";
        }
        public static object CheckCloudComputeConnectivityJobProgressFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeLabelRuleNameUniqueness
        // GraphQL -> checkCloudNativeLabelRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeLabelRuleNameUniqueness(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            return "checkCloudNativeLabelRuleNameUniqueness" + args + "\n{\n" + fs + "}\n";
        }
        public static object CheckCloudNativeLabelRuleNameUniquenessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new IsCloudNativeTagRuleNameUniqueReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> IsCloudNativeTagRuleNameUniqueReply? CheckCloudNativeTagRuleNameUniqueness
        // GraphQL -> checkCloudNativeTagRuleNameUniqueness: IsCloudNativeTagRuleNameUniqueReply! (type)
        public static string CheckCloudNativeTagRuleNameUniqueness(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nruleName: $ruleName\nobjectType: $objectType\n)";
            return "checkCloudNativeTagRuleNameUniqueness" + args + "\n{\n" + fs + "}\n";
        }
        public static object CheckCloudNativeTagRuleNameUniquenessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new IsCloudNativeTagRuleNameUniqueReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CheckLatestVersionMgmtAppExistsReply? CheckLatestVersionMgmtAppExists
        // GraphQL -> checkLatestVersionMgmtAppExists: CheckLatestVersionMgmtAppExistsReply! (type)
        public static string CheckLatestVersionMgmtAppExists(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "checkLatestVersionMgmtAppExists" + args + "\n{\n" + fs + "}\n";
        }
        public static object CheckLatestVersionMgmtAppExistsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CheckLatestVersionMgmtAppExistsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudDirectNasExport? CloudDirectNasExport
        // GraphQL -> cloudDirectNasExport: CloudDirectNasExport! (type)
        public static string CloudDirectNasExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "cloudDirectNasExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudDirectNasExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudDirectNasExport() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudDirectSystems? CloudDirectSystems
        // GraphQL -> cloudDirectSystems: CloudDirectSystems! (type)
        public static string CloudDirectSystems(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "cloudDirectSystems" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudDirectSystemsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudDirectSystems() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CheckArchivedSnapshotsLockedReply? CloudNativeCheckArchivedSnapshotsLocked
        // GraphQL -> cloudNativeCheckArchivedSnapshotsLocked: CheckArchivedSnapshotsLockedReply! (type)
        public static string CloudNativeCheckArchivedSnapshotsLocked(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadId: $workloadId\nsnapshotIds: $snapshotIds\n)";
            return "cloudNativeCheckArchivedSnapshotsLocked" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeCheckArchivedSnapshotsLockedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CheckArchivedSnapshotsLockedReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeCustomerTagsReply? CloudNativeCustomerTags
        // GraphQL -> cloudNativeCustomerTags: CloudNativeCustomerTagsReply! (type)
        public static string CloudNativeCustomerTags(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncloudVendor: $cloudVendor\ncloudAccountId: $cloudAccountId\n)";
            return "cloudNativeCustomerTags" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeCustomerTagsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeCustomerTagsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetCloudNativeLabelRulesReply? CloudNativeLabelRules
        // GraphQL -> cloudNativeLabelRules: GetCloudNativeLabelRulesReply! (type)
        public static string CloudNativeLabelRules(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            return "cloudNativeLabelRules" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeLabelRulesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetCloudNativeLabelRulesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RbaInstallerUrls? CloudNativeRbaInstallers
        // GraphQL -> cloudNativeRbaInstallers: RbaInstallerUrls! (type)
        public static string CloudNativeRbaInstallers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "cloudNativeRbaInstallers" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeRbaInstallersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RbaInstallerUrls() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeSnapshotDetailsForRecoveryReply? CloudNativeSnapshotDetailsForRecovery
        // GraphQL -> cloudNativeSnapshotDetailsForRecovery: CloudNativeSnapshotDetailsForRecoveryReply! (type)
        public static string CloudNativeSnapshotDetailsForRecovery(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            return "cloudNativeSnapshotDetailsForRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeSnapshotDetailsForRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeSnapshotDetailsForRecoveryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeSnapshotTypeDetailsReply? CloudNativeSnapshotTypeDetails
        // GraphQL -> cloudNativeSnapshotTypeDetails: CloudNativeSnapshotTypeDetailsReply! (type)
        public static string CloudNativeSnapshotTypeDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            return "cloudNativeSnapshotTypeDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeSnapshotTypeDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeSnapshotTypeDetailsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotFileConnection? CloudNativeSnapshots
        // GraphQL -> cloudNativeSnapshots: SnapshotFileConnection! (type)
        public static string CloudNativeSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nsearchPrefix: $searchPrefix\n)";
            return "cloudNativeSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotFileConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeSqlServerSetupScript? CloudNativeSqlServerSetupScript
        // GraphQL -> cloudNativeSqlServerSetupScript: CloudNativeSqlServerSetupScript! (type)
        public static string CloudNativeSqlServerSetupScript(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "cloudNativeSqlServerSetupScript" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeSqlServerSetupScriptFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeSqlServerSetupScript() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetCloudNativeTagRulesReply? CloudNativeTagRules
        // GraphQL -> cloudNativeTagRules: GetCloudNativeTagRulesReply! (type)
        public static string CloudNativeTagRules(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nobjectType: $objectType\nfilters: $filters\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            return "cloudNativeTagRules" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeTagRulesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetCloudNativeTagRulesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CloudNativeVersionedFileConnection? CloudNativeWorkloadVersionedFiles
        // GraphQL -> cloudNativeWorkloadVersionedFiles: CloudNativeVersionedFileConnection! (type)
        public static string CloudNativeWorkloadVersionedFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableId: $snappableId\nsearchQuery: $searchQuery\n)";
            return "cloudNativeWorkloadVersionedFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object CloudNativeWorkloadVersionedFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CloudNativeVersionedFileConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        public static string Cluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "cluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Cluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CertificateSummaryListResponse? ClusterCertificates
        // GraphQL -> clusterCertificates: CertificateSummaryListResponse! (type)
        public static string ClusterCertificates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterCertificates" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterCertificatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CertificateSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        public static string ClusterConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            return "clusterConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterCsr? ClusterCsr
        // GraphQL -> clusterCsr: ClusterCsr! (type)
        public static string ClusterCsr(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterCsr" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterCsrFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterCsr() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InternalGetDefaultGatewayResponse? ClusterDefaultGateway
        // GraphQL -> clusterDefaultGateway: InternalGetDefaultGatewayResponse! (type)
        public static string ClusterDefaultGateway(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterDefaultGateway" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterDefaultGatewayFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InternalGetDefaultGatewayResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterDnsReply? ClusterDns
        // GraphQL -> clusterDns: ClusterDnsReply! (type)
        public static string ClusterDns(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "clusterDns" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterDnsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterDnsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InternalGetClusterIpsResponse? ClusterFloatingIps
        // GraphQL -> clusterFloatingIps: InternalGetClusterIpsResponse! (type)
        public static string ClusterFloatingIps(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterFloatingIps" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterFloatingIpsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InternalGetClusterIpsResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterGroupByConnection? ClusterGroupByConnection
        // GraphQL -> clusterGroupByConnection: ClusterGroupByConnection! (type)
        public static string ClusterGroupByConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "clusterGroupByConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterGroupByConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterGroupByConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ModifyIpmiReply? ClusterIpmi
        // GraphQL -> clusterIpmi: ModifyIpmiReply! (type)
        public static string ClusterIpmi(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterIpmi" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterIpmiFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ModifyIpmiReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterIpv6ModeReply? ClusterIpv6Mode
        // GraphQL -> clusterIpv6Mode: ClusterIpv6ModeReply! (type)
        public static string ClusterIpv6Mode(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterIpv6Mode" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterIpv6ModeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterIpv6ModeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NetworkInterfaceListResponse? ClusterNetworkInterfaces
        // GraphQL -> clusterNetworkInterfaces: NetworkInterfaceListResponse! (type)
        public static string ClusterNetworkInterfaces(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterNetworkInterfaces" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterNetworkInterfacesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NetworkInterfaceListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NodeStatusListResponse? ClusterNodes
        // GraphQL -> clusterNodes: NodeStatusListResponse! (type)
        public static string ClusterNodes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterNodes" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterNodesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NodeStatusListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NtpServerConfigurationListResponse? ClusterNtpServers
        // GraphQL -> clusterNtpServers: NtpServerConfigurationListResponse! (type)
        public static string ClusterNtpServers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterNtpServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterNtpServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NtpServerConfigurationListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterOperationJobProgress? ClusterOperationJobProgress
        // GraphQL -> clusterOperationJobProgress: ClusterOperationJobProgress! (type)
        public static string ClusterOperationJobProgress(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterOperationJobProgress" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterOperationJobProgressFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterOperationJobProgress() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterProxyReply? ClusterProxy
        // GraphQL -> clusterProxy: ClusterProxyReply! (type)
        public static string ClusterProxy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "clusterProxy" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterProxyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterProxyReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterRegistrationProductInfoType? ClusterRegistrationProductInfo
        // GraphQL -> clusterRegistrationProductInfo: ClusterRegistrationProductInfoType! (type)
        public static string ClusterRegistrationProductInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "clusterRegistrationProductInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterRegistrationProductInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterRegistrationProductInfoType() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReportsMigrationCount? ClusterReportMigrationCount
        // GraphQL -> clusterReportMigrationCount: ReportsMigrationCount! (type)
        public static string ClusterReportMigrationCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nstatus: $status\n)";
            return "clusterReportMigrationCount" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterReportMigrationCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReportsMigrationCount() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterReportMigrationJobStatus? ClusterReportMigrationJobStatus
        // GraphQL -> clusterReportMigrationJobStatus: ClusterReportMigrationJobStatus! (type)
        public static string ClusterReportMigrationJobStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "clusterReportMigrationJobStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterReportMigrationJobStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterReportMigrationJobStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReportMigrationStatusConnection? ClusterReportMigrationStatus
        // GraphQL -> clusterReportMigrationStatus: ReportMigrationStatusConnection! (type)
        public static string ClusterReportMigrationStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nstatus: $status\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "clusterReportMigrationStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterReportMigrationStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReportMigrationStatusConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterSlaDomainConnection? ClusterSlaDomains
        // GraphQL -> clusterSlaDomains: ClusterSlaDomainConnection! (type)
        public static string ClusterSlaDomains(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "clusterSlaDomains" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterSlaDomainsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterSlaDomainConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? ClusterTypeList
        // GraphQL -> clusterTypeList: [GroupCount!]! (type)
        public static string ClusterTypeList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "clusterTypeList" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterTypeListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VlanConfigListResponse? ClusterVlans
        // GraphQL -> clusterVlans: VlanConfigListResponse! (type)
        public static string ClusterVlans(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterVlans" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterVlansFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VlanConfigListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterWebSignedCertificateReply? ClusterWebSignedCertificate
        // GraphQL -> clusterWebSignedCertificate: ClusterWebSignedCertificateReply! (type)
        public static string ClusterWebSignedCertificate(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "clusterWebSignedCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterWebSignedCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterWebSignedCertificateReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterConnection? ClusterWithUpgradesInfo
        // GraphQL -> clusterWithUpgradesInfo: ClusterConnection! (type)
        public static string ClusterWithUpgradesInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nupgradeFilter: $upgradeFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            return "clusterWithUpgradesInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object ClusterWithUpgradesInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ComputeClusterDetail? ComputeClusterStatus
        // GraphQL -> computeClusterStatus: ComputeClusterDetail! (type)
        public static string ComputeClusterStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "computeClusterStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object ComputeClusterStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ComputeClusterDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ConfiguredGroupMemberConnection? ConfiguredGroupMembers
        // GraphQL -> configuredGroupMembers: O365ConfiguredGroupMemberConnection! (type)
        public static string ConfiguredGroupMembers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\norgId: $orgId\nwildcard: $wildcard\npdls: $pdls\n)";
            return "configuredGroupMembers" + args + "\n{\n" + fs + "}\n";
        }
        public static object ConfiguredGroupMembersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ConfiguredGroupMemberConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CountOfObjectsProtectedBySlAsResult? CountOfObjectsProtectedBySlas
        // GraphQL -> countOfObjectsProtectedBySlas: CountOfObjectsProtectedBySLAsResult! (type)
        public static string CountOfObjectsProtectedBySlas(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\ntypeFilter: $typeFilter\n)";
            return "countOfObjectsProtectedBySlas" + args + "\n{\n" + fs + "}\n";
        }
        public static object CountOfObjectsProtectedBySlasFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CountOfObjectsProtectedBySlAsResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Crawl? Crawl
        // GraphQL -> crawl: Crawl! (type)
        public static string Crawl(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncrawlId: $crawlId\n)";
            return "crawl" + args + "\n{\n" + fs + "}\n";
        }
        public static object CrawlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Crawl() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CrawlConnection? Crawls
        // GraphQL -> crawls: CrawlConnection! (type)
        public static string Crawls(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "crawls" + args + "\n{\n" + fs + "}\n";
        }
        public static object CrawlsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CrawlConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CrossAccountPairInfoConnection? CrossAccountPairs
        // GraphQL -> crossAccountPairs: CrossAccountPairInfoConnection! (type)
        public static string CrossAccountPairs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\nsortOrder: $sortOrder\n)";
            return "crossAccountPairs" + args + "\n{\n" + fs + "}\n";
        }
        public static object CrossAccountPairsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CrossAccountPairInfoConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Org? CurrentOrg
        // GraphQL -> currentOrg: Org! (type)
        public static string CurrentOrg(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "currentOrg" + args + "\n{\n" + fs + "}\n";
        }
        public static object CurrentOrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Org() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> User? CurrentUser
        // GraphQL -> currentUser: User! (type)
        public static string CurrentUser(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "currentUser" + args + "\n{\n" + fs + "}\n";
        }
        public static object CurrentUserFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new User() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserLoginContext? CurrentUserLoginContext
        // GraphQL -> currentUserLoginContext: UserLoginContext! (type)
        public static string CurrentUserLoginContext(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "currentUserLoginContext" + args + "\n{\n" + fs + "}\n";
        }
        public static object CurrentUserLoginContextFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserLoginContext() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Analyzer? CustomAnalyzer
        // GraphQL -> customAnalyzer: Analyzer! (type)
        public static string CustomAnalyzer(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nanalyzerId: $analyzerId\n)";
            return "customAnalyzer" + args + "\n{\n" + fs + "}\n";
        }
        public static object CustomAnalyzerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Analyzer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetDashboardSummaryReply? DashboardSummary
        // GraphQL -> dashboardSummary: GetDashboardSummaryReply! (type)
        public static string DashboardSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ngetWhitelistedResults: $getWhitelistedResults\n)";
            return "dashboardSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object DashboardSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetDashboardSummaryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DbLogReportSummaryListReply? DatabaseLogReportForCluster
        // GraphQL -> databaseLogReportForCluster: DbLogReportSummaryListReply! (type)
        public static string DatabaseLogReportForCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "databaseLogReportForCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object DatabaseLogReportForClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DbLogReportSummaryListReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DbLogReportProperties? DatabaseLogReportingPropertiesForCluster
        // GraphQL -> databaseLogReportingPropertiesForCluster: DbLogReportProperties! (type)
        public static string DatabaseLogReportingPropertiesForCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "databaseLogReportingPropertiesForCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object DatabaseLogReportingPropertiesForClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DbLogReportProperties() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> QuerySddlReply? DatagovSecDesc
        // GraphQL -> datagovSecDesc: QuerySDDLReply! (type)
        public static string DatagovSecDesc(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nstdPath: $stdPath\nskipResolveSids: $skipResolveSids\nfilters: $filters\n)";
            return "datagovSecDesc" + args + "\n{\n" + fs + "}\n";
        }
        public static object DatagovSecDescFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new QuerySddlReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2Database? Db2Database
        // GraphQL -> db2Database: Db2Database! (type)
        public static string Db2Database(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "db2Database" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2DatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2Database() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? Db2DatabaseJobStatus
        // GraphQL -> db2DatabaseJobStatus: AsyncRequestStatus! (type)
        public static string Db2DatabaseJobStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "db2DatabaseJobStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2DatabaseJobStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2DatabaseConnection? Db2Databases
        // GraphQL -> db2Databases: Db2DatabaseConnection! (type)
        public static string Db2Databases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "db2Databases" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2DatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2DatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        public static string Db2Instance(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "db2Instance" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2InstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2Instance() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2InstanceConnection? Db2Instances
        // GraphQL -> db2Instances: Db2InstanceConnection! (type)
        public static string Db2Instances(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "db2Instances" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2InstancesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2InstanceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2LogSnapshot? Db2LogSnapshot
        // GraphQL -> db2LogSnapshot: Db2LogSnapshot! (type)
        public static string Db2LogSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ndb2LogSnapshotFid: $db2LogSnapshotFid\n)";
            return "db2LogSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2LogSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2LogSnapshot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2LogSnapshotConnection? Db2LogSnapshots
        // GraphQL -> db2LogSnapshots: Db2LogSnapshotConnection! (type)
        public static string Db2LogSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "db2LogSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2LogSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2LogSnapshotConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2RecoverableRange? Db2RecoverableRange
        // GraphQL -> db2RecoverableRange: Db2RecoverableRange! (type)
        public static string Db2RecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ndb2RecoverableRangeFid: $db2RecoverableRangeFid\n)";
            return "db2RecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2RecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2RecoverableRange() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Db2RecoverableRangeConnection? Db2RecoverableRanges
        // GraphQL -> db2RecoverableRanges: Db2RecoverableRangeConnection! (type)
        public static string Db2RecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "db2RecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object Db2RecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Db2RecoverableRangeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExportUrlSpecs? DecryptExportUrl
        // GraphQL -> decryptExportUrl: ExportUrlSpecs! (type)
        public static string DecryptExportUrl(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadFid: $workloadFid\nexportUrlSpecsEnc: $exportUrlSpecsEnc\n)";
            return "decryptExportUrl" + args + "\n{\n" + fs + "}\n";
        }
        public static object DecryptExportUrlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExportUrlSpecs() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DiffResult? DiffFmd
        // GraphQL -> diffFmd: DiffResult! (type)
        public static string DiffFmd(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nbrowseDiffPath: $browseDiffPath\n)";
            return "diffFmd" + args + "\n{\n" + fs + "}\n";
        }
        public static object DiffFmdFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DiffResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BootstrappableNodeInfoListResponse? DiscoverNodes
        // GraphQL -> discoverNodes: BootstrappableNodeInfoListResponse! (type)
        public static string DiscoverNodes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "discoverNodes" + args + "\n{\n" + fs + "}\n";
        }
        public static object DiscoverNodesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BootstrappableNodeInfoListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetPoliciesTimelineReply? DiscoveryTimeline
        // GraphQL -> discoveryTimeline: GetPoliciesTimelineReply! (type)
        public static string DiscoveryTimeline(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\ngetWhitelistedResults: $getWhitelistedResults\nworkloadTypes: $workloadTypes\nuseOptimisedDiscoveryTimeline: $useOptimisedDiscoveryTimeline\nsubscriptionIdsFilter: $subscriptionIdsFilter\n)";
            return "discoveryTimeline" + args + "\n{\n" + fs + "}\n";
        }
        public static object DiscoveryTimelineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetPoliciesTimelineReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EventDigest? DistributionListDigest
        // GraphQL -> distributionListDigest: EventDigest! (type)
        public static string DistributionListDigest(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "distributionListDigest" + args + "\n{\n" + fs + "}\n";
        }
        public static object DistributionListDigestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EventDigest() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadCdmUpgradesPdfReply? DownloadCdmUpgradesPdf
        // GraphQL -> downloadCdmUpgradesPdf: DownloadCdmUpgradesPdfReply! (type)
        public static string DownloadCdmUpgradesPdf(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ndownloadFilter: $downloadFilter\n)";
            return "downloadCdmUpgradesPdf" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadCdmUpgradesPdfFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadCdmUpgradesPdfReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadPackageStatusReply? DownloadPackageStatus
        // GraphQL -> downloadPackageStatus: DownloadPackageStatusReply! (type)
        public static string DownloadPackageStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "downloadPackageStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadPackageStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadPackageStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DownloadSlaWithReplicationCsvReply? DownloadSlaWithReplicationCsv
        // GraphQL -> downloadSlaWithReplicationCsv: DownloadSlaWithReplicationCsvReply! (type)
        public static string DownloadSlaWithReplicationCsv(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            return "downloadSlaWithReplicationCsv" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadSlaWithReplicationCsvFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DownloadSlaWithReplicationCsvReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? DownloadedVersionList
        // GraphQL -> downloadedVersionList: [GroupCount!]! (type)
        public static string DownloadedVersionList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "downloadedVersionList" + args + "\n{\n" + fs + "}\n";
        }
        public static object DownloadedVersionListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> EdgeWindowsToolLink? EdgeWindowsToolLink
        // GraphQL -> edgeWindowsToolLink: EdgeWindowsToolLink! (type)
        public static string EdgeWindowsToolLink(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "edgeWindowsToolLink" + args + "\n{\n" + fs + "}\n";
        }
        public static object EdgeWindowsToolLinkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new EdgeWindowsToolLink() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeDag? ExchangeDag
        // GraphQL -> exchangeDag: ExchangeDag! (type)
        public static string ExchangeDag(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "exchangeDag" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeDagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeDag() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeDagConnection? ExchangeDags
        // GraphQL -> exchangeDags: ExchangeDagConnection! (type)
        public static string ExchangeDags(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "exchangeDags" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeDagsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeDagConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeDatabase? ExchangeDatabase
        // GraphQL -> exchangeDatabase: ExchangeDatabase! (type)
        public static string ExchangeDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "exchangeDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeDatabaseConnection? ExchangeDatabases
        // GraphQL -> exchangeDatabases: ExchangeDatabaseConnection! (type)
        public static string ExchangeDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "exchangeDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeLiveMountConnection? ExchangeLiveMounts
        // GraphQL -> exchangeLiveMounts: ExchangeLiveMountConnection! (type)
        public static string ExchangeLiveMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "exchangeLiveMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeLiveMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeServer? ExchangeServer
        // GraphQL -> exchangeServer: ExchangeServer! (type)
        public static string ExchangeServer(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "exchangeServer" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeServerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeServer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ExchangeServerConnection? ExchangeServers
        // GraphQL -> exchangeServers: ExchangeServerConnection! (type)
        public static string ExchangeServers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "exchangeServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object ExchangeServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ExchangeServerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FailedRestoreItemsInfoReply? FailedRestoreItemsInfo
        // GraphQL -> failedRestoreItemsInfo: FailedRestoreItemsInfoReply! (type)
        public static string FailedRestoreItemsInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nworkloadFid: $workloadFid\nfailedItemsInstanceId: $failedItemsInstanceId\n)";
            return "failedRestoreItemsInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object FailedRestoreItemsInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FailedRestoreItemsInfoReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FailoverClusterApp? FailoverClusterApp
        // GraphQL -> failoverClusterApp: FailoverClusterApp! (type)
        public static string FailoverClusterApp(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "failoverClusterApp" + args + "\n{\n" + fs + "}\n";
        }
        public static object FailoverClusterAppFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FailoverClusterApp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FailoverClusterAppConnection? FailoverClusterApps
        // GraphQL -> failoverClusterApps: FailoverClusterAppConnection! (type)
        public static string FailoverClusterApps(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            return "failoverClusterApps" + args + "\n{\n" + fs + "}\n";
        }
        public static object FailoverClusterAppsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FailoverClusterAppConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FailoverClusterTopLevelDescendantTypeConnection? FailoverClusterTopLevelDescendants
        // GraphQL -> failoverClusterTopLevelDescendants: FailoverClusterTopLevelDescendantTypeConnection! (type)
        public static string FailoverClusterTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            return "failoverClusterTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object FailoverClusterTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FailoverClusterTopLevelDescendantTypeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FailuresAndWarningsStatsReply? FailuresAndWarningsStats
        // GraphQL -> failuresAndWarningsStats: FailuresAndWarningsStatsReply! (type)
        public static string FailuresAndWarningsStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "failuresAndWarningsStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object FailuresAndWarningsStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FailuresAndWarningsStatsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FederatedLoginStatus? FederatedLoginStatus
        // GraphQL -> federatedLoginStatus: FederatedLoginStatus! (type)
        public static string FederatedLoginStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "federatedLoginStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object FederatedLoginStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FederatedLoginStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? FilesetRequestStatus
        // GraphQL -> filesetRequestStatus: AsyncRequestStatus! (type)
        public static string FilesetRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "filesetRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FilesetSnapshotDetail? FilesetSnapshot
        // GraphQL -> filesetSnapshot: FilesetSnapshotDetail! (type)
        public static string FilesetSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\nverbose: $verbose\n)";
            return "filesetSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FilesetSnapshotDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BrowseResponseListResponse? FilesetSnapshotFiles
        // GraphQL -> filesetSnapshotFiles: BrowseResponseListResponse! (type)
        public static string FilesetSnapshotFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\nlimit: $limit\noffset: $offset\npath: $path\n)";
            return "filesetSnapshotFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetSnapshotFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BrowseResponseListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FilesetTemplate? FilesetTemplate
        // GraphQL -> filesetTemplate: FilesetTemplate! (type)
        public static string FilesetTemplate(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "filesetTemplate" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetTemplateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FilesetTemplate() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FilesetTemplateConnection? FilesetTemplates
        // GraphQL -> filesetTemplates: FilesetTemplateConnection! (type)
        public static string FilesetTemplates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\n)";
            return "filesetTemplates" + args + "\n{\n" + fs + "}\n";
        }
        public static object FilesetTemplatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FilesetTemplateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeDisk? GcpNativeDisk
        // GraphQL -> gcpNativeDisk: GcpNativeDisk! (type)
        public static string GcpNativeDisk(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "gcpNativeDisk" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeDiskFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeDisk() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeDiskConnection? GcpNativeDisks
        // GraphQL -> gcpNativeDisks: GcpNativeDiskConnection! (type)
        public static string GcpNativeDisks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ndiskFilters: $diskFilters\n)";
            return "gcpNativeDisks" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeDisksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeDiskConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeGceInstance? GcpNativeGceInstance
        // GraphQL -> gcpNativeGceInstance: GcpNativeGceInstance! (type)
        public static string GcpNativeGceInstance(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "gcpNativeGceInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeGceInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeGceInstance() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstances
        // GraphQL -> gcpNativeGceInstances: GcpNativeGceInstanceConnection! (type)
        public static string GcpNativeGceInstances(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\ngceInstanceFilters: $gceInstanceFilters\n)";
            return "gcpNativeGceInstances" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeGceInstancesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeGceInstanceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        public static string GcpNativeProject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "gcpNativeProject" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeProjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeProject() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GcpNativeProjectConnection? GcpNativeProjects
        // GraphQL -> gcpNativeProjects: GcpNativeProjectConnection! (type)
        public static string GcpNativeProjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nprojectFilters: $projectFilters\nauthorizedOperationFilter: $authorizedOperationFilter\nworkloadHierarchy: $workloadHierarchy\n)";
            return "gcpNativeProjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeProjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GcpNativeProjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListStoredDiskLocationsReply? GcpNativeStoredDiskLocations
        // GraphQL -> gcpNativeStoredDiskLocations: ListStoredDiskLocationsReply! (type)
        public static string GcpNativeStoredDiskLocations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nprojectId: $projectId\n)";
            return "gcpNativeStoredDiskLocations" + args + "\n{\n" + fs + "}\n";
        }
        public static object GcpNativeStoredDiskLocationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListStoredDiskLocationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? GeoLocationList
        // GraphQL -> geoLocationList: [GroupCount!]! (type)
        public static string GeoLocationList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "geoLocationList" + args + "\n{\n" + fs + "}\n";
        }
        public static object GeoLocationListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RoleConnection? GetAllRolesInOrgConnection
        // GraphQL -> getAllRolesInOrgConnection: RoleConnection! (type)
        public static string GetAllRolesInOrgConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\nassignedRoleIds: $assignedRoleIds\n)";
            return "getAllRolesInOrgConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetAllRolesInOrgConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RoleConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForClusterFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForClusterFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForClusterFromSupportPortal(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            return "getCdmReleaseDetailsForClusterFromSupportPortal" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetCdmReleaseDetailsForClusterFromSupportPortalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsForVersionFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsForVersionFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsForVersionFromSupportPortal(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nlistClusterUuid: $listClusterUuid\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            return "getCdmReleaseDetailsForVersionFromSupportPortal" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetCdmReleaseDetailsForVersionFromSupportPortalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmUpgradeReleaseDetailsFromSupportPortalReply? GetCdmReleaseDetailsFromSupportPortal
        // GraphQL -> getCdmReleaseDetailsFromSupportPortal: CdmUpgradeReleaseDetailsFromSupportPortalReply! (type)
        public static string GetCdmReleaseDetailsFromSupportPortal(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nplatform: $platform\nnodeCount: $nodeCount\nsourceVersion: $sourceVersion\nfilterVersion: $filterVersion\nfetchLinks: $fetchLinks\nfilterUpgradeable: $filterUpgradeable\nshouldShowAll: $shouldShowAll\nfilterAfterSource: $filterAfterSource\nsortOrder: $sortOrder\n)";
            return "getCdmReleaseDetailsFromSupportPortal" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetCdmReleaseDetailsFromSupportPortalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmUpgradeReleaseDetailsFromSupportPortalReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GroupCountListWithTotal? GetGroupCountByCdmClusterStatus
        // GraphQL -> getGroupCountByCdmClusterStatus: GroupCountListWithTotal! (type)
        public static string GetGroupCountByCdmClusterStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "getGroupCountByCdmClusterStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetGroupCountByCdmClusterStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GroupCountListWithTotal() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? GetGroupCountByPrechecksStatus
        // GraphQL -> getGroupCountByPrechecksStatus: [GroupCount!]! (type)
        public static string GetGroupCountByPrechecksStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "getGroupCountByPrechecksStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetGroupCountByPrechecksStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? GetGroupCountByUpgradeJobStatus
        // GraphQL -> getGroupCountByUpgradeJobStatus: [GroupCount!]! (type)
        public static string GetGroupCountByUpgradeJobStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "getGroupCountByUpgradeJobStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetGroupCountByUpgradeJobStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<GroupCount>? GetGroupCountByVersionStatus
        // GraphQL -> getGroupCountByVersionStatus: [GroupCount!]! (type)
        public static string GetGroupCountByVersionStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "getGroupCountByVersionStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetGroupCountByVersionStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<GroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetTaskchainStatusReply? GetKorgTaskchainStatus
        // GraphQL -> getKorgTaskchainStatus: GetTaskchainStatusReply! (type)
        public static string GetKorgTaskchainStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            return "getKorgTaskchainStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetKorgTaskchainStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetTaskchainStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Permission>? GetPermissions
        // GraphQL -> getPermissions: [Permission!]! (type)
        public static string GetPermissions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nroleId: $roleId\n)";
            return "getPermissions" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetPermissionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<Permission>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Role>? GetRolesByIds
        // GraphQL -> getRolesByIds: [Role!]! (type)
        public static string GetRolesByIds(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nroleIds: $roleIds\n)";
            return "getRolesByIds" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetRolesByIdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<Role>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<UserDownload>? GetUserDownloads
        // GraphQL -> getUserDownloads: [UserDownload!]! (type)
        public static string GetUserDownloads(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "getUserDownloads" + args + "\n{\n" + fs + "}\n";
        }
        public static object GetUserDownloadsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<UserDownload>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalCertificate? GlobalCertificate
        // GraphQL -> globalCertificate: GlobalCertificate! (type)
        public static string GlobalCertificate(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncertificateId: $certificateId\n)";
            return "globalCertificate" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalCertificateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalCertificate() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalCertificateConnection? GlobalCertificates
        // GraphQL -> globalCertificates: GlobalCertificateConnection! (type)
        public static string GlobalCertificates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\ninput: $input\n)";
            return "globalCertificates" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalCertificatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalCertificateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalFileSearchReply? GlobalFileSearch
        // GraphQL -> globalFileSearch: GlobalFileSearchReply! (type)
        public static string GlobalFileSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "globalFileSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalFileSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalFileSearchReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LockoutConfig? GlobalLockoutConfig
        // GraphQL -> globalLockoutConfig: LockoutConfig! (type)
        public static string GlobalLockoutConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "globalLockoutConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalLockoutConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LockoutConfig() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetMfaSettingReply? GlobalMfaSetting
        // GraphQL -> globalMfaSetting: GetMfaSettingReply! (type)
        public static string GlobalMfaSetting(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "globalMfaSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalMfaSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetMfaSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HierarchyObjectConnection? GlobalSearchResults
        // GraphQL -> globalSearchResults: HierarchyObjectConnection! (type)
        public static string GlobalSearchResults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "globalSearchResults" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalSearchResultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HierarchyObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaForFilterConnection? GlobalSlaFilterConnection
        // GraphQL -> globalSlaFilterConnection: GlobalSlaForFilterConnection! (type)
        public static string GlobalSlaFilterConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            return "globalSlaFilterConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalSlaFilterConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalSlaForFilterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GlobalSlaStatusConnection? GlobalSlaStatuses
        // GraphQL -> globalSlaStatuses: GlobalSlaStatusConnection! (type)
        public static string GlobalSlaStatuses(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nSlaId: $SlaId\n)";
            return "globalSlaStatuses" + args + "\n{\n" + fs + "}\n";
        }
        public static object GlobalSlaStatusesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GlobalSlaStatusConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GroupConnection? GroupsInCurrentAndDescendantOrganization
        // GraphQL -> groupsInCurrentAndDescendantOrganization: GroupConnection! (type)
        public static string GroupsInCurrentAndDescendantOrganization(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nshouldIncludeGroupsWithoutRole: $shouldIncludeGroupsWithoutRole\n)";
            return "groupsInCurrentAndDescendantOrganization" + args + "\n{\n" + fs + "}\n";
        }
        public static object GroupsInCurrentAndDescendantOrganizationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GuestCredentialDetailListResponse? GuestCredentials
        // GraphQL -> guestCredentials: GuestCredentialDetailListResponse! (type)
        public static string GuestCredentials(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "guestCredentials" + args + "\n{\n" + fs + "}\n";
        }
        public static object GuestCredentialsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GuestCredentialDetailListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GuestOsCredentialConnection? GuestCredentialsV2
        // GraphQL -> guestCredentialsV2: GuestOsCredentialConnection! (type)
        public static string GuestCredentialsV2(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            return "guestCredentialsV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object GuestCredentialsV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GuestOsCredentialConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HasRelicAzureAdSnapshotReplyType? HasRelicAzureAdSnapshot
        // GraphQL -> hasRelicAzureAdSnapshot: HasRelicAzureAdSnapshotReplyType! (type)
        public static string HasRelicAzureAdSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hasRelicAzureAdSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object HasRelicAzureAdSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HasRelicAzureAdSnapshotReplyType() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HelpContentSnippetConnection? HelpContentSnippets
        // GraphQL -> helpContentSnippets: HelpContentSnippetConnection! (type)
        public static string HelpContentSnippets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            return "helpContentSnippets" + args + "\n{\n" + fs + "}\n";
        }
        public static object HelpContentSnippetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HelpContentSnippetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HierarchySnappableConnection? HierarchySnappables
        // GraphQL -> hierarchySnappables: HierarchySnappableConnection! (type)
        public static string HierarchySnappables(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "hierarchySnappables" + args + "\n{\n" + fs + "}\n";
        }
        public static object HierarchySnappablesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HierarchySnappableConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HostDiagnosisSummary? HostDiagnosis
        // GraphQL -> hostDiagnosis: HostDiagnosisSummary! (type)
        public static string HostDiagnosis(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "hostDiagnosis" + args + "\n{\n" + fs + "}\n";
        }
        public static object HostDiagnosisFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HostDiagnosisSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HostFailoverCluster? HostFailoverCluster
        // GraphQL -> hostFailoverCluster: HostFailoverCluster! (type)
        public static string HostFailoverCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hostFailoverCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object HostFailoverClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HostFailoverCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HostFailoverClusterConnection? HostFailoverClusters
        // GraphQL -> hostFailoverClusters: HostFailoverClusterConnection! (type)
        public static string HostFailoverClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostFailoverClusterRoot: $hostFailoverClusterRoot\n)";
            return "hostFailoverClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object HostFailoverClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HostFailoverClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HostShare? HostShare
        // GraphQL -> hostShare: HostShare! (type)
        public static string HostShare(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hostShare" + args + "\n{\n" + fs + "}\n";
        }
        public static object HostShareFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HostShare() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HostShareConnection? HostShares
        // GraphQL -> hostShares: HostShareConnection! (type)
        public static string HostShares(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "hostShares" + args + "\n{\n" + fs + "}\n";
        }
        public static object HostSharesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HostShareConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVcluster? HypervCluster
        // GraphQL -> hypervCluster: HyperVCluster! (type)
        public static string HypervCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hypervCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVcluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? HypervHostAsyncRequestStatus
        // GraphQL -> hypervHostAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervHostAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervHostAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervHostAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVliveMountConnection? HypervMounts
        // GraphQL -> hypervMounts: HyperVLiveMountConnection! (type)
        public static string HypervMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "hypervMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVliveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVscvmm? HypervScvmm
        // GraphQL -> hypervScvmm: HyperVSCVMM! (type)
        public static string HypervScvmm(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hypervScvmm" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervScvmmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVscvmm() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? HypervScvmmAsyncRequestStatus
        // GraphQL -> hypervScvmmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervScvmmAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervScvmmAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervScvmmAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVscvmmConnection? HypervScvmms
        // GraphQL -> hypervScvmms: HyperVSCVMMConnection! (type)
        public static string HypervScvmms(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "hypervScvmms" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervScvmmsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVscvmmConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervServer? HypervServer
        // GraphQL -> hypervServer: HypervServer! (type)
        public static string HypervServer(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hypervServer" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervServerFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervServer() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervHostSummaryListResponse? HypervServers
        // GraphQL -> hypervServers: HypervHostSummaryListResponse! (type)
        public static string HypervServers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervServers" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervServersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervHostSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervServerConnection? HypervServersPaginated
        // GraphQL -> hypervServersPaginated: HypervServerConnection! (type)
        public static string HypervServersPaginated(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "hypervServersPaginated" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervServersPaginatedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervServerConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervTopLevelDescendantTypeConnection? HypervTopLevelDescendants
        // GraphQL -> hypervTopLevelDescendants: HypervTopLevelDescendantTypeConnection! (type)
        public static string HypervTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "hypervTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervTopLevelDescendantTypeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVvirtualMachine? HypervVirtualMachine
        // GraphQL -> hypervVirtualMachine: HyperVVirtualMachine! (type)
        public static string HypervVirtualMachine(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "hypervVirtualMachine" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervVirtualMachineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVvirtualMachine() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? HypervVirtualMachineAsyncRequestStatus
        // GraphQL -> hypervVirtualMachineAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string HypervVirtualMachineAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervVirtualMachineAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervVirtualMachineAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervVirtualMachineSnapshotFileDetails? HypervVirtualMachineLevelFileInfo
        // GraphQL -> hypervVirtualMachineLevelFileInfo: HypervVirtualMachineSnapshotFileDetails! (type)
        public static string HypervVirtualMachineLevelFileInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervVirtualMachineLevelFileInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervVirtualMachineLevelFileInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervVirtualMachineSnapshotFileDetails() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HyperVvirtualMachineConnection? HypervVirtualMachines
        // GraphQL -> hypervVirtualMachines: HyperVVirtualMachineConnection! (type)
        public static string HypervVirtualMachines(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "hypervVirtualMachines" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervVirtualMachinesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HyperVvirtualMachineConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HypervVirtualMachineDetail? HypervVmDetail
        // GraphQL -> hypervVmDetail: HypervVirtualMachineDetail! (type)
        public static string HypervVmDetail(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "hypervVmDetail" + args + "\n{\n" + fs + "}\n";
        }
        public static object HypervVmDetailFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HypervVirtualMachineDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<InstalledVersionGroupCount>? InstalledVersionList
        // GraphQL -> installedVersionList: [InstalledVersionGroupCount!]! (type)
        public static string InstalledVersionList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "installedVersionList" + args + "\n{\n" + fs + "}\n";
        }
        public static object InstalledVersionListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<InstalledVersionGroupCount>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReadIntegrationReply? Integration
        // GraphQL -> integration: ReadIntegrationReply! (type)
        public static string Integration(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "integration" + args + "\n{\n" + fs + "}\n";
        }
        public static object IntegrationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReadIntegrationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InventoryRoot? InventoryRoot
        // GraphQL -> inventoryRoot: InventoryRoot! (type)
        public static string InventoryRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "inventoryRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object InventoryRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InventoryRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InventorySubHierarchyRoot? InventorySubHierarchyRoot
        // GraphQL -> inventorySubHierarchyRoot: InventorySubHierarchyRoot! (type)
        public static string InventorySubHierarchyRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrootEnum: $rootEnum\n)";
            return "inventorySubHierarchyRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object InventorySubHierarchyRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InventorySubHierarchyRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InvestigationCsvDownloadLinkReply? InvestigationCsvDownloadLink
        // GraphQL -> investigationCsvDownloadLink: InvestigationCsvDownloadLinkReply! (type)
        public static string InvestigationCsvDownloadLink(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\nsnapshotId: $snapshotId\n)";
            return "investigationCsvDownloadLink" + args + "\n{\n" + fs + "}\n";
        }
        public static object InvestigationCsvDownloadLinkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InvestigationCsvDownloadLinkReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetWhitelistReply? IpWhitelist
        // GraphQL -> ipWhitelist: GetWhitelistReply! (type)
        public static string IpWhitelist(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "ipWhitelist" + args + "\n{\n" + fs + "}\n";
        }
        public static object IpWhitelistFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetWhitelistReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> IsVolumeSnapshotRestorableReply? IsAwsNativeEbsVolumeSnapshotRestorable
        // GraphQL -> isAwsNativeEbsVolumeSnapshotRestorable: IsVolumeSnapshotRestorableReply! (type)
        public static string IsAwsNativeEbsVolumeSnapshotRestorable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\n)";
            return "isAwsNativeEbsVolumeSnapshotRestorable" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsAwsNativeEbsVolumeSnapshotRestorableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new IsVolumeSnapshotRestorableReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateCloudNativeFileRecoveryFeasibilityReply? IsCloudNativeFileRecoveryFeasible
        // GraphQL -> isCloudNativeFileRecoveryFeasible: ValidateCloudNativeFileRecoveryFeasibilityReply! (type)
        public static string IsCloudNativeFileRecoveryFeasible(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotIds: $snapshotIds\n)";
            return "isCloudNativeFileRecoveryFeasible" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsCloudNativeFileRecoveryFeasibleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateCloudNativeFileRecoveryFeasibilityReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportPortalStatusReply? IsLoggedIntoRubrikSupportPortal
        // GraphQL -> isLoggedIntoRubrikSupportPortal: SupportPortalStatusReply! (type)
        public static string IsLoggedIntoRubrikSupportPortal(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "isLoggedIntoRubrikSupportPortal" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsLoggedIntoRubrikSupportPortalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SupportPortalStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmUpgradeAvailabilityReply? IsUpgradeAvailable
        // GraphQL -> isUpgradeAvailable: CdmUpgradeAvailabilityReply! (type)
        public static string IsUpgradeAvailable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "isUpgradeAvailable" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsUpgradeAvailableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmUpgradeAvailabilityReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmUpgradeRecommendationReply? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: CdmUpgradeRecommendationReply! (type)
        public static string IsUpgradeRecommended(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "isUpgradeRecommended" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsUpgradeRecommendedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmUpgradeRecommendationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ZrsAvailabilityReply? IsZrsAvailableForLocation
        // GraphQL -> isZrsAvailableForLocation: ZrsAvailabilityReply! (type)
        public static string IsZrsAvailableForLocation(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nserviceTier: $serviceTier\nregion: $region\nsubscriptionId: $subscriptionId\n)";
            return "isZrsAvailableForLocation" + args + "\n{\n" + fs + "}\n";
        }
        public static object IsZrsAvailableForLocationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ZrsAvailabilityReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Issue? Issue
        // GraphQL -> issue: Issue! (type)
        public static string Issue(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nissueId: $issueId\n)";
            return "issue" + args + "\n{\n" + fs + "}\n";
        }
        public static object IssueFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Issue() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> IssueConnection? Issues
        // GraphQL -> issues: IssueConnection! (type)
        public static string Issues(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nstatus: $status\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "issues" + args + "\n{\n" + fs + "}\n";
        }
        public static object IssuesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new IssueConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> JobInfo? JobInfo
        // GraphQL -> jobInfo: JobInfo! (type)
        public static string JobInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "jobInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object JobInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new JobInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sAppManifest? K8sAppManifest
        // GraphQL -> k8sAppManifest: K8sAppManifest! (type)
        public static string K8sAppManifest(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\napp: $app\nversion: $version\nretrieveLatestVersion: $retrieveLatestVersion\ntargetVersion: $targetVersion\nk8sClusterId: $k8sClusterId\n)";
            return "k8sAppManifest" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sAppManifestFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sAppManifest() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sCluster? K8sCluster
        // GraphQL -> k8sCluster: K8sCluster! (type)
        public static string K8sCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "k8sCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sClusterConnection? K8sClusters
        // GraphQL -> k8sClusters: K8sClusterConnection! (type)
        public static string K8sClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "k8sClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sNamespace? K8sNamespace
        // GraphQL -> k8sNamespace: K8sNamespace! (type)
        public static string K8sNamespace(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "k8sNamespace" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sNamespaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sNamespace() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sNamespaceConnection? K8sNamespaces
        // GraphQL -> k8sNamespaces: K8sNamespaceConnection! (type)
        public static string K8sNamespaces(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nk8sClusterId: $k8sClusterId\n)";
            return "k8sNamespaces" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sNamespacesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sNamespaceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sSnapshotSummaryListResponse? K8sProtectionSetSnapshots
        // GraphQL -> k8sProtectionSetSnapshots: K8sSnapshotSummaryListResponse! (type)
        public static string K8sProtectionSetSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "k8sProtectionSetSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sProtectionSetSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sSnapshotSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> K8sSnapshotInfo? K8sSnapshotInfo
        // GraphQL -> k8sSnapshotInfo: K8sSnapshotInfo! (type)
        public static string K8sSnapshotInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotId: $snapshotId\nnamespaceId: $namespaceId\nisReplica: $isReplica\n)";
            return "k8sSnapshotInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object K8sSnapshotInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new K8sSnapshotInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> KnowledgeBaseArticle? KnowledgeBaseArticle
        // GraphQL -> knowledgeBaseArticle: KnowledgeBaseArticle! (type)
        public static string KnowledgeBaseArticle(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "knowledgeBaseArticle" + args + "\n{\n" + fs + "}\n";
        }
        public static object KnowledgeBaseArticleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new KnowledgeBaseArticle() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> KubernetesCluster? KubernetesCluster
        // GraphQL -> kubernetesCluster: KubernetesCluster! (type)
        public static string KubernetesCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "kubernetesCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object KubernetesClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new KubernetesCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> KubernetesClusterConnection? KubernetesClusters
        // GraphQL -> kubernetesClusters: KubernetesClusterConnection! (type)
        public static string KubernetesClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "kubernetesClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object KubernetesClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new KubernetesClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> KubernetesProtectionSet? KubernetesProtectionSet
        // GraphQL -> kubernetesProtectionSet: KubernetesProtectionSet! (type)
        public static string KubernetesProtectionSet(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "kubernetesProtectionSet" + args + "\n{\n" + fs + "}\n";
        }
        public static object KubernetesProtectionSetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new KubernetesProtectionSet() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> KubernetesProtectionSetConnection? KubernetesProtectionSets
        // GraphQL -> kubernetesProtectionSets: KubernetesProtectionSetConnection! (type)
        public static string KubernetesProtectionSets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nk8sClusterOptionalId: $k8sClusterOptionalId\n)";
            return "kubernetesProtectionSets" + args + "\n{\n" + fs + "}\n";
        }
        public static object KubernetesProtectionSetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new KubernetesProtectionSetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LambdaSettings? LambdaSettings
        // GraphQL -> lambdaSettings: LambdaSettings! (type)
        public static string LambdaSettings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "lambdaSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object LambdaSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LambdaSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AuthorizedPrincipalConnection? LdapAuthorizedPrincipalConnection
        // GraphQL -> ldapAuthorizedPrincipalConnection: AuthorizedPrincipalConnection! (type)
        public static string LdapAuthorizedPrincipalConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            return "ldapAuthorizedPrincipalConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object LdapAuthorizedPrincipalConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AuthorizedPrincipalConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LdapIntegrationConnection? LdapIntegrationConnection
        // GraphQL -> ldapIntegrationConnection: LdapIntegrationConnection! (type)
        public static string LdapIntegrationConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            return "ldapIntegrationConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object LdapIntegrationConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LdapIntegrationConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrincipalConnection? LdapPrincipalConnection
        // GraphQL -> ldapPrincipalConnection: PrincipalConnection! (type)
        public static string LdapPrincipalConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nid: $id\nsearchText: $searchText\n)";
            return "ldapPrincipalConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object LdapPrincipalConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrincipalConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LegalHoldSnapshotDetailConnection? LegalHoldSnapshotsForSnappable
        // GraphQL -> legalHoldSnapshotsForSnappable: LegalHoldSnapshotDetailConnection! (type)
        public static string LegalHoldSnapshotsForSnappable(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            return "legalHoldSnapshotsForSnappable" + args + "\n{\n" + fs + "}\n";
        }
        public static object LegalHoldSnapshotsForSnappableFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LegalHoldSnapshotDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LicensesForClusterProductReply? LicensesForClusterProductSummary
        // GraphQL -> licensesForClusterProductSummary: LicensesForClusterProductReply! (type)
        public static string LicensesForClusterProductSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "licensesForClusterProductSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object LicensesForClusterProductSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LicensesForClusterProductReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LinuxFileset? LinuxFileset
        // GraphQL -> linuxFileset: LinuxFileset! (type)
        public static string LinuxFileset(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "linuxFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object LinuxFilesetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LinuxFileset() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365AppConnection? ListO365Apps
        // GraphQL -> listO365Apps: O365AppConnection! (type)
        public static string ListO365Apps(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\no365AppFilters: $o365AppFilters\no365AppSortByParam: $o365AppSortByParam\n)";
            return "listO365Apps" + args + "\n{\n" + fs + "}\n";
        }
        public static object ListO365AppsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365AppConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LockoutConfig? LockoutConfig
        // GraphQL -> lockoutConfig: LockoutConfig! (type)
        public static string LockoutConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "lockoutConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object LockoutConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LockoutConfig() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LookupAccountReply? LookupAccount
        // GraphQL -> lookupAccount: LookupAccountReply! (type)
        public static string LookupAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "lookupAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object LookupAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LookupAccountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DayToDayModeBackupStats? M365DayToDayModeBackupStats
        // GraphQL -> m365DayToDayModeBackupStats: DayToDayModeBackupStats! (type)
        public static string M365DayToDayModeBackupStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\ndashboardWorkloadType: $dashboardWorkloadType\nbackupStatsTimeRange: $backupStatsTimeRange\n)";
            return "m365DayToDayModeBackupStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365DayToDayModeBackupStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DayToDayModeBackupStats() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DayToDayModeStats? M365DayToDayModeStats
        // GraphQL -> m365DayToDayModeStats: DayToDayModeStats! (type)
        public static string M365DayToDayModeStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\ndashboardWorkloadType: $dashboardWorkloadType\n)";
            return "m365DayToDayModeStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365DayToDayModeStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DayToDayModeStats() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OnboardingModeBackupStats? M365OnboardingModeBackupStats
        // GraphQL -> m365OnboardingModeBackupStats: OnboardingModeBackupStats! (type)
        public static string M365OnboardingModeBackupStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\ndashboardWorkloadType: $dashboardWorkloadType\nbackupStatsTimeRange: $backupStatsTimeRange\n)";
            return "m365OnboardingModeBackupStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365OnboardingModeBackupStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OnboardingModeBackupStats() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OnboardingModeStats? M365OnboardingModeStats
        // GraphQL -> m365OnboardingModeStats: OnboardingModeStats! (type)
        public static string M365OnboardingModeStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\ndashboardWorkloadType: $dashboardWorkloadType\n)";
            return "m365OnboardingModeStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365OnboardingModeStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OnboardingModeStats() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> M365OrgBackupLocations? M365OrgBackupLocations
        // GraphQL -> m365OrgBackupLocations: M365OrgBackupLocations! (type)
        public static string M365OrgBackupLocations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "m365OrgBackupLocations" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365OrgBackupLocationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new M365OrgBackupLocations() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> M365OrgOperationModes? M365OrgOperationModes
        // GraphQL -> m365OrgOperationModes: M365OrgOperationModes! (type)
        public static string M365OrgOperationModes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "m365OrgOperationModes" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365OrgOperationModesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new M365OrgOperationModes() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> M365RegionsResp? M365Regions
        // GraphQL -> m365Regions: M365RegionsResp! (type)
        public static string M365Regions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "m365Regions" + args + "\n{\n" + fs + "}\n";
        }
        public static object M365RegionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new M365RegionsResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolume? ManagedVolume
        // GraphQL -> managedVolume: ManagedVolume! (type)
        public static string ManagedVolume(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "managedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object ManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolume() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolumeInventoryStats? ManagedVolumeInventoryStats
        // GraphQL -> managedVolumeInventoryStats: ManagedVolumeInventoryStats! (type)
        public static string ManagedVolumeInventoryStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "managedVolumeInventoryStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object ManagedVolumeInventoryStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolumeInventoryStats() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolumeMountConnection? ManagedVolumeLiveMounts
        // GraphQL -> managedVolumeLiveMounts: ManagedVolumeMountConnection! (type)
        public static string ManagedVolumeLiveMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "managedVolumeLiveMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object ManagedVolumeLiveMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolumeMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolumeConnection? ManagedVolumes
        // GraphQL -> managedVolumes: ManagedVolumeConnection! (type)
        public static string ManagedVolumes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "managedVolumes" + args + "\n{\n" + fs + "}\n";
        }
        public static object ManagedVolumesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolumeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetMfaSettingReply? MfaSetting
        // GraphQL -> mfaSetting: GetMfaSettingReply! (type)
        public static string MfaSetting(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "mfaSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object MfaSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetMfaSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FeatureListMinimumCdmVersionReply? MinimumCdmVersionForFeatureSet
        // GraphQL -> minimumCdmVersionForFeatureSet: FeatureListMinimumCdmVersionReply! (type)
        public static string MinimumCdmVersionForFeatureSet(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfeatureListMinimumCdmVersion: $featureListMinimumCdmVersion\n)";
            return "minimumCdmVersionForFeatureSet" + args + "\n{\n" + fs + "}\n";
        }
        public static object MinimumCdmVersionForFeatureSetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FeatureListMinimumCdmVersionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoRecoverableRanges? MongoBulkRecoverableRanges
        // GraphQL -> mongoBulkRecoverableRanges: MongoRecoverableRanges! (type)
        public static string MongoBulkRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mongoBulkRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoBulkRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoRecoverableRanges() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoCollection? MongoCollection
        // GraphQL -> mongoCollection: MongoCollection! (type)
        public static string MongoCollection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongoCollection" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoCollectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoCollection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoCollectionConnection? MongoCollections
        // GraphQL -> mongoCollections: MongoCollectionConnection! (type)
        public static string MongoCollections(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongoCollections" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoCollectionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoCollectionConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoDatabase? MongoDatabase
        // GraphQL -> mongoDatabase: MongoDatabase! (type)
        public static string MongoDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongoDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoDatabaseConnection? MongoDatabases
        // GraphQL -> mongoDatabases: MongoDatabaseConnection! (type)
        public static string MongoDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongoDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoRecoverableRanges? MongoRecoverableRanges
        // GraphQL -> mongoRecoverableRanges: MongoRecoverableRanges! (type)
        public static string MongoRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mongoRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoRecoverableRanges() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoSource? MongoSource
        // GraphQL -> mongoSource: MongoSource! (type)
        public static string MongoSource(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongoSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoSource() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongoSourceConnection? MongoSources
        // GraphQL -> mongoSources: MongoSourceConnection! (type)
        public static string MongoSources(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongoSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongoSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongoSourceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicRecoveryRangeResponse? MongodbBulkRecoverableRange
        // GraphQL -> mongodbBulkRecoverableRange: MosaicRecoveryRangeResponse! (type)
        public static string MongodbBulkRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mongodbBulkRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbBulkRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicRecoveryRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbCollection? MongodbCollection
        // GraphQL -> mongodbCollection: MongodbCollection! (type)
        public static string MongodbCollection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongodbCollection" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbCollectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbCollection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetMosaicRecoverableRangeResponse? MongodbCollectionRecoverableRange
        // GraphQL -> mongodbCollectionRecoverableRange: GetMosaicRecoverableRangeResponse! (type)
        public static string MongodbCollectionRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mongodbCollectionRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbCollectionRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetMosaicRecoverableRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbCollectionConnection? MongodbCollections
        // GraphQL -> mongodbCollections: MongodbCollectionConnection! (type)
        public static string MongodbCollections(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongodbCollections" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbCollectionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbCollectionConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbDatabase? MongodbDatabase
        // GraphQL -> mongodbDatabase: MongodbDatabase! (type)
        public static string MongodbDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongodbDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbDatabaseConnection? MongodbDatabases
        // GraphQL -> mongodbDatabases: MongodbDatabaseConnection! (type)
        public static string MongodbDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongodbDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbSource? MongodbSource
        // GraphQL -> mongodbSource: MongodbSource! (type)
        public static string MongodbSource(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mongodbSource" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbSourceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbSource() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MongodbSourceConnection? MongodbSources
        // GraphQL -> mongodbSources: MongodbSourceConnection! (type)
        public static string MongodbSources(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mongodbSources" + args + "\n{\n" + fs + "}\n";
        }
        public static object MongodbSourcesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MongodbSourceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MosaicRecoveryRangeResponse? MosaicBulkRecoveryRange
        // GraphQL -> mosaicBulkRecoveryRange: MosaicRecoveryRangeResponse! (type)
        public static string MosaicBulkRecoveryRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mosaicBulkRecoveryRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object MosaicBulkRecoveryRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MosaicRecoveryRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListVersionResponse? MosaicSnapshots
        // GraphQL -> mosaicSnapshots: ListVersionResponse! (type)
        public static string MosaicSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mosaicSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object MosaicSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListVersionResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListStoreResponse? MosaicStores
        // GraphQL -> mosaicStores: ListStoreResponse! (type)
        public static string MosaicStores(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mosaicStores" + args + "\n{\n" + fs + "}\n";
        }
        public static object MosaicStoresFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListStoreResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListVersionResponse? MosaicVersions
        // GraphQL -> mosaicVersions: ListVersionResponse! (type)
        public static string MosaicVersions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mosaicVersions" + args + "\n{\n" + fs + "}\n";
        }
        public static object MosaicVersionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListVersionResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlAvailabilityGroup? MssqlAvailabilityGroup
        // GraphQL -> mssqlAvailabilityGroup: MssqlAvailabilityGroup! (type)
        public static string MssqlAvailabilityGroup(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mssqlAvailabilityGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlAvailabilityGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlAvailabilityGroup() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlInstanceSummaryListResponse? MssqlCompatibleInstances
        // GraphQL -> mssqlCompatibleInstances: MssqlInstanceSummaryListResponse! (type)
        public static string MssqlCompatibleInstances(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\ninput: $input\nsortBy: $sortBy\nfilters: $filters\n)";
            return "mssqlCompatibleInstances" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlCompatibleInstancesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlInstanceSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlDatabase? MssqlDatabase
        // GraphQL -> mssqlDatabase: MssqlDatabase! (type)
        public static string MssqlDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mssqlDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlDatabaseLiveMountConnection? MssqlDatabaseLiveMounts
        // GraphQL -> mssqlDatabaseLiveMounts: MssqlDatabaseLiveMountConnection! (type)
        public static string MssqlDatabaseLiveMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nfilters: $filters\n)";
            return "mssqlDatabaseLiveMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabaseLiveMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlDatabaseLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlMissedRecoverableRangeListResponse? MssqlDatabaseMissedRecoverableRanges
        // GraphQL -> mssqlDatabaseMissedRecoverableRanges: MssqlMissedRecoverableRangeListResponse! (type)
        public static string MssqlDatabaseMissedRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlDatabaseMissedRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabaseMissedRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlMissedRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MissedSnapshotListResponse? MssqlDatabaseMissedSnapshots
        // GraphQL -> mssqlDatabaseMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string MssqlDatabaseMissedSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlDatabaseMissedSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabaseMissedSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MissedSnapshotListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlRestoreEstimateResult? MssqlDatabaseRestoreEstimate
        // GraphQL -> mssqlDatabaseRestoreEstimate: MssqlRestoreEstimateResult! (type)
        public static string MssqlDatabaseRestoreEstimate(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlDatabaseRestoreEstimate" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabaseRestoreEstimateFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlRestoreEstimateResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlDatabaseConnection? MssqlDatabases
        // GraphQL -> mssqlDatabases: MssqlDatabaseConnection! (type)
        public static string MssqlDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "mssqlDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpdateMssqlDefaultPropertiesReply? MssqlDefaultProperties
        // GraphQL -> mssqlDefaultProperties: UpdateMssqlDefaultPropertiesReply! (type)
        public static string MssqlDefaultProperties(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlDefaultProperties" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDefaultPropertiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpdateMssqlDefaultPropertiesReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlDefaultPropertiesOnClusterReply? MssqlDefaultPropertiesOnCluster
        // GraphQL -> mssqlDefaultPropertiesOnCluster: MssqlDefaultPropertiesOnClusterReply! (type)
        public static string MssqlDefaultPropertiesOnCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlDefaultPropertiesOnCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlDefaultPropertiesOnClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlDefaultPropertiesOnClusterReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlInstance? MssqlInstance
        // GraphQL -> mssqlInstance: MssqlInstance! (type)
        public static string MssqlInstance(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "mssqlInstance" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlInstanceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlInstance() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlLogShippingSummaryV2ListResponse? MssqlLogShippingTargets
        // GraphQL -> mssqlLogShippingTargets: MssqlLogShippingSummaryV2ListResponse (type)
        public static string MssqlLogShippingTargets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlLogShippingTargets" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlLogShippingTargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlLogShippingSummaryV2ListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlRecoverableRangeListResponse? MssqlRecoverableRanges
        // GraphQL -> mssqlRecoverableRanges: MssqlRecoverableRangeListResponse! (type)
        public static string MssqlRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "mssqlRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MssqlTopLevelDescendantTypeConnection? MssqlTopLevelDescendants
        // GraphQL -> mssqlTopLevelDescendants: MssqlTopLevelDescendantTypeConnection! (type)
        public static string MssqlTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "mssqlTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object MssqlTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MssqlTopLevelDescendantTypeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasFileset? NasFileset
        // GraphQL -> nasFileset: NasFileset! (type)
        public static string NasFileset(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nasFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasFilesetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasFileset() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasNamespace? NasNamespace
        // GraphQL -> nasNamespace: NasNamespace! (type)
        public static string NasNamespace(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nasNamespace" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasNamespaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasNamespace() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasNamespaceConnection? NasNamespaces
        // GraphQL -> nasNamespaces: NasNamespaceConnection! (type)
        public static string NasNamespaces(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "nasNamespaces" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasNamespacesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasNamespaceConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasShare? NasShare
        // GraphQL -> nasShare: NasShare! (type)
        public static string NasShare(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nasShare" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasShareFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasShare() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasSystem? NasSystem
        // GraphQL -> nasSystem: NasSystem! (type)
        public static string NasSystem(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nasSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasSystem() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasSystemConnection? NasSystems
        // GraphQL -> nasSystems: NasSystemConnection! (type)
        public static string NasSystems(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "nasSystems" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasSystemsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasSystemConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmHierarchyObjectConnection? NasTopLevelDescendants
        // GraphQL -> nasTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NasTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "nasTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmHierarchyObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NasVolume? NasVolume
        // GraphQL -> nasVolume: NasVolume! (type)
        public static string NasVolume(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nasVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object NasVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NasVolume() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NcdBackEndCapacity? NcdBackEndCapacity
        // GraphQL -> ncdBackEndCapacity: NcdBackEndCapacity (type)
        public static string NcdBackEndCapacity(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "ncdBackEndCapacity" + args + "\n{\n" + fs + "}\n";
        }
        public static object NcdBackEndCapacityFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NcdBackEndCapacity() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NcdFrontEndCapacity? NcdFrontEndCapacity
        // GraphQL -> ncdFrontEndCapacity: NcdFrontEndCapacity (type)
        public static string NcdFrontEndCapacity(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "ncdFrontEndCapacity" + args + "\n{\n" + fs + "}\n";
        }
        public static object NcdFrontEndCapacityFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NcdFrontEndCapacity() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NcdObjectProtectionStatus? NcdObjectProtectionStatus
        // GraphQL -> ncdObjectProtectionStatus: NcdObjectProtectionStatus (type)
        public static string NcdObjectProtectionStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusters: $clusters\n)";
            return "ncdObjectProtectionStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object NcdObjectProtectionStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NcdObjectProtectionStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NcdVmImageUrl? NcdVmImageUrl
        // GraphQL -> ncdVmImageUrl: NcdVmImageUrl! (type)
        public static string NcdVmImageUrl(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "ncdVmImageUrl" + args + "\n{\n" + fs + "}\n";
        }
        public static object NcdVmImageUrlFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NcdVmImageUrl() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NetworkThrottleSummaryListResponse? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottleSummaryListResponse! (type)
        public static string NetworkThrottle(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "networkThrottle" + args + "\n{\n" + fs + "}\n";
        }
        public static object NetworkThrottleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NetworkThrottleSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        public static string NfAnomalyResults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "nfAnomalyResults" + args + "\n{\n" + fs + "}\n";
        }
        public static object NfAnomalyResultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NfAnomalyResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NfAnomalyResultGroupedDataConnection? NfAnomalyResultsGrouped
        // GraphQL -> nfAnomalyResultsGrouped: NfAnomalyResultGroupedDataConnection! (type)
        public static string NfAnomalyResultsGrouped(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "nfAnomalyResultsGrouped" + args + "\n{\n" + fs + "}\n";
        }
        public static object NfAnomalyResultsGroupedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NfAnomalyResultGroupedDataConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NodeRemovalCancelPermissionReply? NodeRemovalCancelPermission
        // GraphQL -> nodeRemovalCancelPermission: NodeRemovalCancelPermissionReply! (type)
        public static string NodeRemovalCancelPermission(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nodeRemovalCancelPermission" + args + "\n{\n" + fs + "}\n";
        }
        public static object NodeRemovalCancelPermissionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NodeRemovalCancelPermissionReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NodeToReplaceReply? NodeToReplace
        // GraphQL -> nodeToReplace: NodeToReplaceReply! (type)
        public static string NodeToReplace(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nodeToReplace" + args + "\n{\n" + fs + "}\n";
        }
        public static object NodeToReplaceFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NodeToReplaceReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BrowseResponseListResponse? NutanixBrowseSnapshot
        // GraphQL -> nutanixBrowseSnapshot: BrowseResponseListResponse! (type)
        public static string NutanixBrowseSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixBrowseSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixBrowseSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BrowseResponseListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixCategory? NutanixCategory
        // GraphQL -> nutanixCategory: NutanixCategory! (type)
        public static string NutanixCategory(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nutanixCategory" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixCategoryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixCategory() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixCategoryValue? NutanixCategoryValue
        // GraphQL -> nutanixCategoryValue: NutanixCategoryValue! (type)
        public static string NutanixCategoryValue(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nutanixCategoryValue" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixCategoryValueFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixCategoryValue() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixCluster? NutanixCluster
        // GraphQL -> nutanixCluster: NutanixCluster! (type)
        public static string NutanixCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nutanixCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? NutanixClusterAsyncRequestStatus
        // GraphQL -> nutanixClusterAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixClusterAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixClusterAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixClusterAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixContainerListResponse? NutanixClusterContainers
        // GraphQL -> nutanixClusterContainers: NutanixContainerListResponse! (type)
        public static string NutanixClusterContainers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixClusterContainers" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixClusterContainersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixContainerListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixNetworkListResponse? NutanixClusterNetworks
        // GraphQL -> nutanixClusterNetworks: NutanixNetworkListResponse! (type)
        public static string NutanixClusterNetworks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixClusterNetworks" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixClusterNetworksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixNetworkListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixClusterConnection? NutanixClusters
        // GraphQL -> nutanixClusters: NutanixClusterConnection! (type)
        public static string NutanixClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "nutanixClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixLiveMountConnection? NutanixMounts
        // GraphQL -> nutanixMounts: NutanixLiveMountConnection! (type)
        public static string NutanixMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "nutanixMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixPrismCentral? NutanixPrismCentral
        // GraphQL -> nutanixPrismCentral: NutanixPrismCentral! (type)
        public static string NutanixPrismCentral(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nutanixPrismCentral" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixPrismCentralFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixPrismCentral() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixPrismCentralConnection? NutanixPrismCentrals
        // GraphQL -> nutanixPrismCentrals: NutanixPrismCentralConnection! (type)
        public static string NutanixPrismCentrals(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "nutanixPrismCentrals" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixPrismCentralsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixPrismCentralConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixVmSnapshotDetail? NutanixSnapshotDetail
        // GraphQL -> nutanixSnapshotDetail: NutanixVmSnapshotDetail! (type)
        public static string NutanixSnapshotDetail(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixSnapshotDetail" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixSnapshotDetailFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixVmSnapshotDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmHierarchyObjectConnection? NutanixTopLevelDescendants
        // GraphQL -> nutanixTopLevelDescendants: CdmHierarchyObjectConnection! (type)
        public static string NutanixTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "nutanixTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmHierarchyObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixVm? NutanixVm
        // GraphQL -> nutanixVm: NutanixVm! (type)
        public static string NutanixVm(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "nutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixVm() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? NutanixVmAsyncRequestStatus
        // GraphQL -> nutanixVmAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string NutanixVmAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixVmAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixVmAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MissedSnapshotListResponse? NutanixVmMissedSnapshots
        // GraphQL -> nutanixVmMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string NutanixVmMissedSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "nutanixVmMissedSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixVmMissedSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MissedSnapshotListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NutanixVmConnection? NutanixVms
        // GraphQL -> nutanixVms: NutanixVmConnection! (type)
        public static string NutanixVms(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "nutanixVms" + args + "\n{\n" + fs + "}\n";
        }
        public static object NutanixVmsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NutanixVmConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Calendar? O365Calendar
        // GraphQL -> o365Calendar: O365Calendar! (type)
        public static string O365Calendar(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365Calendar" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365CalendarFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Calendar() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365GroupConnection? O365Groups
        // GraphQL -> o365Groups: O365GroupConnection! (type)
        public static string O365Groups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nsnappableType: $snappableType\n)";
            return "o365Groups" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365GroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365GroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365License? O365License
        // GraphQL -> o365License: O365License! (type)
        public static string O365License(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "o365License" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365LicenseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365License() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Mailbox? O365Mailbox
        // GraphQL -> o365Mailbox: O365Mailbox! (type)
        public static string O365Mailbox(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365Mailbox" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365MailboxFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Mailbox() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365MailboxConnection? O365Mailboxes
        // GraphQL -> o365Mailboxes: O365MailboxConnection! (type)
        public static string O365Mailboxes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365Mailboxes" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365MailboxesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365MailboxConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetImplicitlyAuthorizedAncestorSummariesResponse? O365ObjectAncestors
        // GraphQL -> o365ObjectAncestors: GetImplicitlyAuthorizedAncestorSummariesResponse! (type)
        public static string O365ObjectAncestors(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365ObjectAncestors" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365ObjectAncestorsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetImplicitlyAuthorizedAncestorSummariesResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Onedrive? O365Onedrive
        // GraphQL -> o365Onedrive: O365Onedrive! (type)
        public static string O365Onedrive(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365Onedrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OnedriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Onedrive() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveConnection? O365Onedrives
        // GraphQL -> o365Onedrives: O365OnedriveConnection! (type)
        public static string O365Onedrives(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365Onedrives" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OnedrivesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Org? O365Org
        // GraphQL -> o365Org: O365Org! (type)
        public static string O365Org(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "o365Org" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Org() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Org? O365OrgAtSnappableLevel
        // GraphQL -> o365OrgAtSnappableLevel: O365Org! (type)
        public static string O365OrgAtSnappableLevel(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\nsnappableType: $snappableType\n)";
            return "o365OrgAtSnappableLevel" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OrgAtSnappableLevelFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Org() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetImplicitlyAuthorizedObjectSummariesResponse? O365OrgSummaries
        // GraphQL -> o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse! (type)
        public static string O365OrgSummaries(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "o365OrgSummaries" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OrgSummariesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetImplicitlyAuthorizedObjectSummariesResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OrgConnection? O365Orgs
        // GraphQL -> o365Orgs: O365OrgConnection! (type)
        public static string O365Orgs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nworkloadHierarchy: $workloadHierarchy\n)";
            return "o365Orgs" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365OrgsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OrgConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ServiceAccountStatusResp? O365ServiceAccount
        // GraphQL -> o365ServiceAccount: O365ServiceAccountStatusResp! (type)
        public static string O365ServiceAccount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "o365ServiceAccount" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365ServiceAccountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ServiceAccountStatusResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetO365ServiceStatusResp? O365ServiceStatus
        // GraphQL -> o365ServiceStatus: GetO365ServiceStatusResp! (type)
        public static string O365ServiceStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgID: $orgID\n)";
            return "o365ServiceStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365ServiceStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetO365ServiceStatusResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointDrive? O365SharepointDrive
        // GraphQL -> o365SharepointDrive: O365SharepointDrive! (type)
        public static string O365SharepointDrive(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365SharepointDrive" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointDriveFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointDrive() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointDriveConnection? O365SharepointDrives
        // GraphQL -> o365SharepointDrives: O365SharepointDriveConnection! (type)
        public static string O365SharepointDrives(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365SharepointDrives" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointDrivesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointDriveConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointList? O365SharepointList
        // GraphQL -> o365SharepointList: O365SharepointList! (type)
        public static string O365SharepointList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365SharepointList" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointList() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointListConnection? O365SharepointLists
        // GraphQL -> o365SharepointLists: O365SharepointListConnection! (type)
        public static string O365SharepointLists(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365SharepointLists" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointListsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointListConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjectList
        // GraphQL -> o365SharepointObjectList: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjectList(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nincludeEntireHierarchy: $includeEntireHierarchy\nfid: $fid\n)";
            return "o365SharepointObjectList" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointObjectListFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SharepointObjectConnection? O365SharepointObjects
        // GraphQL -> o365SharepointObjects: O365SharepointObjectConnection! (type)
        public static string O365SharepointObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            return "o365SharepointObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SharepointObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Site? O365SharepointSite
        // GraphQL -> o365SharepointSite: O365Site! (type)
        public static string O365SharepointSite(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsiteFid: $siteFid\n)";
            return "o365SharepointSite" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointSiteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Site() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SiteConnection? O365SharepointSites
        // GraphQL -> o365SharepointSites: O365SiteConnection! (type)
        public static string O365SharepointSites(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365SharepointSites" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SharepointSitesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SiteConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Site? O365Site
        // GraphQL -> o365Site: O365Site! (type)
        public static string O365Site(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365Site" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SiteFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Site() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365SiteConnection? O365Sites
        // GraphQL -> o365Sites: O365SiteConnection! (type)
        public static string O365Sites(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\nexcludeChildSites: $excludeChildSites\n)";
            return "o365Sites" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365SitesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365SiteConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetO365StorageStatsResp? O365StorageStats
        // GraphQL -> o365StorageStats: GetO365StorageStatsResp! (type)
        public static string O365StorageStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgID: $orgID\n)";
            return "o365StorageStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365StorageStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetO365StorageStatsResp() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365Teams? O365Team
        // GraphQL -> o365Team: O365Teams! (type)
        public static string O365Team(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\n)";
            return "o365Team" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365TeamFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365Teams() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamsChannelConnection? O365TeamChannels
        // GraphQL -> o365TeamChannels: O365TeamsChannelConnection! (type)
        public static string O365TeamChannels(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nexcludeArchived: $excludeArchived\nchannelMembershipTypeFilter: $channelMembershipTypeFilter\nnameFilter: $nameFilter\n)";
            return "o365TeamChannels" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365TeamChannelsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamsChannelConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamConversationsSenderConnection? O365TeamPostedBy
        // GraphQL -> o365TeamPostedBy: O365TeamConversationsSenderConnection! (type)
        public static string O365TeamPostedBy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\no365OrgId: $o365OrgId\nnameFilter: $nameFilter\n)";
            return "o365TeamPostedBy" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365TeamPostedByFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamConversationsSenderConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamsConnection? O365Teams
        // GraphQL -> o365Teams: O365TeamsConnection! (type)
        public static string O365Teams(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\no365OrgId: $o365OrgId\n)";
            return "o365Teams" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365TeamsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamsConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365User? O365User
        // GraphQL -> o365User: O365User! (type)
        public static string O365User(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "o365User" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365UserFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365User() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365UserDescendantMetadataConnection? O365UserObjects
        // GraphQL -> o365UserObjects: O365UserDescendantMetadataConnection! (type)
        public static string O365UserObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nfid: $fid\n)";
            return "o365UserObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object O365UserObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365UserDescendantMetadataConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OauthCodesForEdgeRegReply? OauthCodesForEdgeReg
        // GraphQL -> oauthCodesForEdgeReg: OauthCodesForEdgeRegReply! (type)
        public static string OauthCodesForEdgeReg(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nnumberOfEdges: $numberOfEdges\ncdmOvaLink: $cdmOvaLink\n)";
            return "oauthCodesForEdgeReg" + args + "\n{\n" + fs + "}\n";
        }
        public static object OauthCodesForEdgeRegFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OauthCodesForEdgeRegReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FileResultConnection? ObjectFiles
        // GraphQL -> objectFiles: FileResultConnection! (type)
        public static string ObjectFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\nsort: $sort\nday: $day\ntimezone: $timezone\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "objectFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object ObjectFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FileResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ObjectTypeAccessSummaryConnection? ObjectTypeAccessSummary
        // GraphQL -> objectTypeAccessSummary: ObjectTypeAccessSummaryConnection! (type)
        public static string ObjectTypeAccessSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntimelineDate: $timelineDate\nhistoricalDeltaDays: $historicalDeltaDays\nincludeWhitelistedResults: $includeWhitelistedResults\nsortOrder: $sortOrder\nfilter: $filter\nsort: $sort\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "objectTypeAccessSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object ObjectTypeAccessSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ObjectTypeAccessSummaryConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleFileDownloadLink? OracleAcoExampleDownloadLink
        // GraphQL -> oracleAcoExampleDownloadLink: OracleFileDownloadLink! (type)
        public static string OracleAcoExampleDownloadLink(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleAcoExampleDownloadLink" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleAcoExampleDownloadLinkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleFileDownloadLink() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleAcoParameterList? OracleAcoParameters
        // GraphQL -> oracleAcoParameters: OracleAcoParameterList! (type)
        public static string OracleAcoParameters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleAcoParameters" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleAcoParametersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleAcoParameterList() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleDataGuardGroup? OracleDataGuardGroup
        // GraphQL -> oracleDataGuardGroup: OracleDataGuardGroup! (type)
        public static string OracleDataGuardGroup(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "oracleDataGuardGroup" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleDataGuardGroupFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleDataGuardGroup() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleDatabase? OracleDatabase
        // GraphQL -> oracleDatabase: OracleDatabase! (type)
        public static string OracleDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "oracleDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? OracleDatabaseAsyncRequestDetails
        // GraphQL -> oracleDatabaseAsyncRequestDetails: AsyncRequestStatus! (type)
        public static string OracleDatabaseAsyncRequestDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleDatabaseAsyncRequestDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleDatabaseAsyncRequestDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleLogBackupConfig? OracleDatabaseLogBackupConfig
        // GraphQL -> oracleDatabaseLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleDatabaseLogBackupConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleDatabaseLogBackupConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleDatabaseLogBackupConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleLogBackupConfig() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleDatabaseConnection? OracleDatabases
        // GraphQL -> oracleDatabases: OracleDatabaseConnection! (type)
        public static string OracleDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "oracleDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleHost? OracleHost
        // GraphQL -> oracleHost: OracleHost! (type)
        public static string OracleHost(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "oracleHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleHost() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleLogBackupConfig? OracleHostLogBackupConfig
        // GraphQL -> oracleHostLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleHostLogBackupConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleHostLogBackupConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleHostLogBackupConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleLogBackupConfig() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleLiveMountConnection? OracleLiveMounts
        // GraphQL -> oracleLiveMounts: OracleLiveMountConnection! (type)
        public static string OracleLiveMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "oracleLiveMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleLiveMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleMissedRecoverableRangeListResponse? OracleMissedRecoverableRanges
        // GraphQL -> oracleMissedRecoverableRanges: OracleMissedRecoverableRangeListResponse! (type)
        public static string OracleMissedRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleMissedRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleMissedRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleMissedRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> MissedSnapshotListResponse? OracleMissedSnapshots
        // GraphQL -> oracleMissedSnapshots: MissedSnapshotListResponse! (type)
        public static string OracleMissedSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleMissedSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleMissedSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new MissedSnapshotListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OraclePdbDetails? OraclePdbDetails
        // GraphQL -> oraclePdbDetails: OraclePdbDetails! (type)
        public static string OraclePdbDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oraclePdbDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object OraclePdbDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OraclePdbDetails() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleRac? OracleRac
        // GraphQL -> oracleRac: OracleRac! (type)
        public static string OracleRac(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "oracleRac" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleRacFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleRac() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleLogBackupConfig? OracleRacLogBackupConfig
        // GraphQL -> oracleRacLogBackupConfig: OracleLogBackupConfig! (type)
        public static string OracleRacLogBackupConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleRacLogBackupConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleRacLogBackupConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleLogBackupConfig() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleRecoverableRangeListResponse? OracleRecoverableRanges
        // GraphQL -> oracleRecoverableRanges: OracleRecoverableRangeListResponse! (type)
        public static string OracleRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "oracleRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OracleTopLevelDescendantTypeConnection? OracleTopLevelDescendants
        // GraphQL -> oracleTopLevelDescendants: OracleTopLevelDescendantTypeConnection! (type)
        public static string OracleTopLevelDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "oracleTopLevelDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object OracleTopLevelDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OracleTopLevelDescendantTypeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        public static string Org(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "org" + args + "\n{\n" + fs + "}\n";
        }
        public static object OrgFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Org() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OrgSecurityPolicy? OrgSecurityPolicy
        // GraphQL -> orgSecurityPolicy: OrgSecurityPolicy! (type)
        public static string OrgSecurityPolicy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "orgSecurityPolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object OrgSecurityPolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OrgSecurityPolicy() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OrgConnection? Orgs
        // GraphQL -> orgs: OrgConnection! (type)
        public static string Orgs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nnameFilter: $nameFilter\nmfaEnforcedFilter: $mfaEnforcedFilter\ncrossAccountEnabledFilter: $crossAccountEnabledFilter\n)";
            return "orgs" + args + "\n{\n" + fs + "}\n";
        }
        public static object OrgsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OrgConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OrgsForPrincipalReply? OrgsForPrincipal
        // GraphQL -> orgsForPrincipal: OrgsForPrincipalReply! (type)
        public static string OrgsForPrincipal(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgSearchFilter: $orgSearchFilter\n)";
            return "orgsForPrincipal" + args + "\n{\n" + fs + "}\n";
        }
        public static object OrgsForPrincipalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OrgsForPrincipalReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> OverallRansomwareInvestigationSummary? OverallRansomwareInvestigationSummary
        // GraphQL -> overallRansomwareInvestigationSummary: OverallRansomwareInvestigationSummary! (type)
        public static string OverallRansomwareInvestigationSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nhistoryNumHours: $historyNumHours\n)";
            return "overallRansomwareInvestigationSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object OverallRansomwareInvestigationSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new OverallRansomwareInvestigationSummary() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PasswordComplexityPolicy? PasswordComplexityPolicy
        // GraphQL -> passwordComplexityPolicy: PasswordComplexityPolicy! (type)
        public static string PasswordComplexityPolicy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "passwordComplexityPolicy" + args + "\n{\n" + fs + "}\n";
        }
        public static object PasswordComplexityPolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PasswordComplexityPolicy() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PendingAction? PendingAction
        // GraphQL -> pendingAction: pendingAction! (type)
        public static string PendingAction(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\npendingActionId: $pendingActionId\n)";
            return "pendingAction" + args + "\n{\n" + fs + "}\n";
        }
        public static object PendingActionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PendingAction() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PhoenixRolloutProgress? PhoenixRolloutProgress
        // GraphQL -> phoenixRolloutProgress: PhoenixRolloutProgress! (type)
        public static string PhoenixRolloutProgress(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\norgId: $orgId\n)";
            return "phoenixRolloutProgress" + args + "\n{\n" + fs + "}\n";
        }
        public static object PhoenixRolloutProgressFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PhoenixRolloutProgress() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PhysicalHost? PhysicalHost
        // GraphQL -> physicalHost: PhysicalHost! (type)
        public static string PhysicalHost(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "physicalHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object PhysicalHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PhysicalHost() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PhysicalHostConnection? PhysicalHosts
        // GraphQL -> physicalHosts: PhysicalHostConnection! (type)
        public static string PhysicalHosts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nhostRoot: $hostRoot\nisBulkPolicyAssignmentFlow: $isBulkPolicyAssignmentFlow\n)";
            return "physicalHosts" + args + "\n{\n" + fs + "}\n";
        }
        public static object PhysicalHostsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PhysicalHostConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetPipelineHealthReply? PipelineHealthForTimeRange
        // GraphQL -> pipelineHealthForTimeRange: GetPipelineHealthReply! (type)
        public static string PipelineHealthForTimeRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\n)";
            return "pipelineHealthForTimeRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object PipelineHealthForTimeRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetPipelineHealthReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolarisInventorySubHierarchyRoot? PolarisInventorySubHierarchyRoot
        // GraphQL -> polarisInventorySubHierarchyRoot: PolarisInventorySubHierarchyRoot! (type)
        public static string PolarisInventorySubHierarchyRoot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrootEnum: $rootEnum\n)";
            return "polarisInventorySubHierarchyRoot" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolarisInventorySubHierarchyRootFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolarisInventorySubHierarchyRoot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolarisSnapshot? PolarisSnapshot
        // GraphQL -> polarisSnapshot: PolarisSnapshot! (type)
        public static string PolarisSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotFid: $snapshotFid\n)";
            return "polarisSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolarisSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolarisSnapshot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetailConnection? Policies
        // GraphQL -> policies: ClassificationPolicyDetailConnection! (type)
        public static string Policies(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\npolicyObjectFilter: $policyObjectFilter\nexcludeHierarchyObjectList: $excludeHierarchyObjectList\n)";
            return "policies" + args + "\n{\n" + fs + "}\n";
        }
        public static object PoliciesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClassificationPolicyDetail? Policy
        // GraphQL -> policy: ClassificationPolicyDetail! (type)
        public static string Policy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\npolicyId: $policyId\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nclusterIdsFilter: $clusterIdsFilter\nreplicationFilter: $replicationFilter\nsearchObjectName: $searchObjectName\nhierarchyAncestorIdFilter: $hierarchyAncestorIdFilter\npolicyAssignmentType: $policyAssignmentType\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "policy" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolicyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClassificationPolicyDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolicyDetailConnection? PolicyDetails
        // GraphQL -> policyDetails: PolicyDetailConnection! (type)
        public static string PolicyDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "policyDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolicyDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolicyDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolicyObj? PolicyObj
        // GraphQL -> policyObj: PolicyObj! (type)
        public static string PolicyObj(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\nincludeWhitelistedResults: $includeWhitelistedResults\n)";
            return "policyObj" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolicyObjFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolicyObj() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolicyObjectUsageConnection? PolicyObjectUsages
        // GraphQL -> policyObjectUsages: PolicyObjectUsageConnection! (type)
        public static string PolicyObjectUsages(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nobjectIds: $objectIds\n)";
            return "policyObjectUsages" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolicyObjectUsagesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolicyObjectUsageConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PolicyObjConnection? PolicyObjs
        // GraphQL -> policyObjs: PolicyObjConnection! (type)
        public static string PolicyObjs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nsortBy: $sortBy\nsortOrder: $sortOrder\nanalysisStatusesFilter: $analysisStatusesFilter\npolicyIdsFilter: $policyIdsFilter\nriskLevelsFilter: $riskLevelsFilter\nclusterIdsFilter: $clusterIdsFilter\nsearchObjectName: $searchObjectName\nsubscriptionIdsFilter: $subscriptionIdsFilter\nincludeWhitelistedResults: $includeWhitelistedResults\nsids: $sids\ninsightsMetadataId: $insightsMetadataId\nincludeInsightsMarker: $includeInsightsMarker\nuserAccessObjectsFilter: $userAccessObjectsFilter\nobjectIdsFilter: $objectIdsFilter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "policyObjs" + args + "\n{\n" + fs + "}\n";
        }
        public static object PolicyObjsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PolicyObjConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrechecksStatusReply? PrechecksStatus
        // GraphQL -> prechecksStatus: PrechecksStatusReply! (type)
        public static string PrechecksStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "prechecksStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object PrechecksStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrechecksStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrechecksStatusReply? PrechecksStatusWithNextJobInfo
        // GraphQL -> prechecksStatusWithNextJobInfo: PrechecksStatusReply! (type)
        public static string PrechecksStatusWithNextJobInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "prechecksStatusWithNextJobInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object PrechecksStatusWithNextJobInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrechecksStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> PrivateContainerRegistryReplyType? PrivateContainerRegistry
        // GraphQL -> privateContainerRegistry: PrivateContainerRegistryReplyType! (type)
        public static string PrivateContainerRegistry(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "privateContainerRegistry" + args + "\n{\n" + fs + "}\n";
        }
        public static object PrivateContainerRegistryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new PrivateContainerRegistryReplyType() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ProcessedRansomwareInvestigationWorkloadCountReply? ProcessedRansomwareInvestigationWorkloadCount
        // GraphQL -> processedRansomwareInvestigationWorkloadCount: ProcessedRansomwareInvestigationWorkloadCountReply! (type)
        public static string ProcessedRansomwareInvestigationWorkloadCount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "processedRansomwareInvestigationWorkloadCount" + args + "\n{\n" + fs + "}\n";
        }
        public static object ProcessedRansomwareInvestigationWorkloadCountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ProcessedRansomwareInvestigationWorkloadCountReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ProductDocumentation? ProductDocumentation
        // GraphQL -> productDocumentation: ProductDocumentation! (type)
        public static string ProductDocumentation(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "productDocumentation" + args + "\n{\n" + fs + "}\n";
        }
        public static object ProductDocumentationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ProductDocumentation() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ProtectedObjectsConnection? ProtectedObjectsConnection
        // GraphQL -> protectedObjectsConnection: ProtectedObjectsConnection! (type)
        public static string ProtectedObjectsConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrootOptionalFid: $rootOptionalFid\nslaIds: $slaIds\nfilter: $filter\nobjectTypeFilter: $objectTypeFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "protectedObjectsConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object ProtectedObjectsConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ProtectedObjectsConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> QueryDatastoreFreespaceThresholdsReply? QueryDatastoreFreespaceThresholds
        // GraphQL -> queryDatastoreFreespaceThresholds: QueryDatastoreFreespaceThresholdsReply! (type)
        public static string QueryDatastoreFreespaceThresholds(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nqueryDatastoreFreespaceThresholdsInput: $queryDatastoreFreespaceThresholdsInput\n)";
            return "queryDatastoreFreespaceThresholds" + args + "\n{\n" + fs + "}\n";
        }
        public static object QueryDatastoreFreespaceThresholdsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new QueryDatastoreFreespaceThresholdsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterConnection? RadarClusterConnection
        // GraphQL -> radarClusterConnection: ClusterConnection! (type)
        public static string RadarClusterConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortOrder: $sortOrder\nsortBy: $sortBy\n)";
            return "radarClusterConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object RadarClusterConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ListLocationsReply? RansomwareDetectionWorkloadLocations
        // GraphQL -> ransomwareDetectionWorkloadLocations: ListLocationsReply! (type)
        public static string RansomwareDetectionWorkloadLocations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nbeginTime: $beginTime\nendTime: $endTime\nreturnOnlyForAnomalousEntities: $returnOnlyForAnomalousEntities\n)";
            return "ransomwareDetectionWorkloadLocations" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareDetectionWorkloadLocationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ListLocationsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareInvestigationAnalysisSummaryReply? RansomwareInvestigationAnalysisSummary
        // GraphQL -> ransomwareInvestigationAnalysisSummary: RansomwareInvestigationAnalysisSummaryReply! (type)
        public static string RansomwareInvestigationAnalysisSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nstartDay: $startDay\nendDay: $endDay\ntimezone: $timezone\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nhideSuspiciousDataIfNonAnomalous: $hideSuspiciousDataIfNonAnomalous\n)";
            return "ransomwareInvestigationAnalysisSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareInvestigationAnalysisSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareInvestigationAnalysisSummaryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareInvestigationEnablementReply? RansomwareInvestigationEnablement
        // GraphQL -> ransomwareInvestigationEnablement: RansomwareInvestigationEnablementReply! (type)
        public static string RansomwareInvestigationEnablement(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "ransomwareInvestigationEnablement" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareInvestigationEnablementFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareInvestigationEnablementReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult! (type)
        public static string RansomwareResult(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            return "ransomwareResult" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareResultFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareResult? RansomwareResultOpt
        // GraphQL -> ransomwareResultOpt: RansomwareResult (type)
        public static string RansomwareResultOpt(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\n)";
            return "ransomwareResultOpt" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareResultOptFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        public static string RansomwareResults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "ransomwareResults" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareResultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RansomwareResultGroupedDataConnection? RansomwareResultsGrouped
        // GraphQL -> ransomwareResultsGrouped: RansomwareResultGroupedDataConnection! (type)
        public static string RansomwareResultsGrouped(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\n)";
            return "ransomwareResultsGrouped" + args + "\n{\n" + fs + "}\n";
        }
        public static object RansomwareResultsGroupedFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RansomwareResultGroupedDataConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RcsAzureArchivalLocationsConsumptionStatsOutput? RcsArchivalLocationsConsumptionStats
        // GraphQL -> rcsArchivalLocationsConsumptionStats: RcsAzureArchivalLocationsConsumptionStatsOutput! (type)
        public static string RcsArchivalLocationsConsumptionStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrcsAzureTargetConsumptionStatsRequest: $rcsAzureTargetConsumptionStatsRequest\n)";
            return "rcsArchivalLocationsConsumptionStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object RcsArchivalLocationsConsumptionStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RcsAzureArchivalLocationsConsumptionStatsOutput() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RcvAccountEntitlement? RcvAccountEntitlement
        // GraphQL -> rcvAccountEntitlement: RcvAccountEntitlement! (type)
        public static string RcvAccountEntitlement(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "rcvAccountEntitlement" + args + "\n{\n" + fs + "}\n";
        }
        public static object RcvAccountEntitlementFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RcvAccountEntitlement() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RdsInstanceDetailsFromAws? RdsInstanceDetailsFromAws
        // GraphQL -> rdsInstanceDetailsFromAws: RdsInstanceDetailsFromAws! (type)
        public static string RdsInstanceDetailsFromAws(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\nrdsDatabaseRubrikId: $rdsDatabaseRubrikId\n)";
            return "rdsInstanceDetailsFromAws" + args + "\n{\n" + fs + "}\n";
        }
        public static object RdsInstanceDetailsFromAwsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RdsInstanceDetailsFromAws() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RemoveNodeDetailsReply? RemovedNodeDetails
        // GraphQL -> removedNodeDetails: RemoveNodeDetailsReply! (type)
        public static string RemovedNodeDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "removedNodeDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object RemovedNodeDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RemoveNodeDetailsReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InternalReplicationBandwidthIncomingResponse? ReplicationIncomingStats
        // GraphQL -> replicationIncomingStats: InternalReplicationBandwidthIncomingResponse! (type)
        public static string ReplicationIncomingStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "replicationIncomingStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplicationIncomingStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InternalReplicationBandwidthIncomingResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReplicationTargetThrottleBypassSummaryListResponse? ReplicationNetworkThrottleBypass
        // GraphQL -> replicationNetworkThrottleBypass: ReplicationTargetThrottleBypassSummaryListResponse! (type)
        public static string ReplicationNetworkThrottleBypass(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "replicationNetworkThrottleBypass" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplicationNetworkThrottleBypassFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReplicationTargetThrottleBypassSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReplicationNetworkThrottleBypassReply? ReplicationNetworkThrottleBypassById
        // GraphQL -> replicationNetworkThrottleBypassById: ReplicationNetworkThrottleBypassReply! (type)
        public static string ReplicationNetworkThrottleBypassById(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "replicationNetworkThrottleBypassById" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplicationNetworkThrottleBypassByIdFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReplicationNetworkThrottleBypassReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> InternalReplicationBandwidthOutgoingResponse? ReplicationOutgoingStats
        // GraphQL -> replicationOutgoingStats: InternalReplicationBandwidthOutgoingResponse! (type)
        public static string ReplicationOutgoingStats(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "replicationOutgoingStats" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplicationOutgoingStatsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new InternalReplicationBandwidthOutgoingResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ReplicationPairConnection? ReplicationPairs
        // GraphQL -> replicationPairs: ReplicationPairConnection! (type)
        public static string ReplicationPairs(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "replicationPairs" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReplicationPairsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ReplicationPairConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RowConnection? ReportData
        // GraphQL -> reportData: RowConnection! (type)
        public static string ReportData(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ndataView: $dataView\ncolumns: $columns\nfilters: $filters\ngroupBy: $groupBy\nsecondaryGroupBy: $secondaryGroupBy\naggregations: $aggregations\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezone: $timezone\n)";
            return "reportData" + args + "\n{\n" + fs + "}\n";
        }
        public static object ReportDataFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RowConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RoleTemplateConnection? RoleTemplates
        // GraphQL -> roleTemplates: RoleTemplateConnection! (type)
        public static string RoleTemplates(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nnameFilter: $nameFilter\n)";
            return "roleTemplates" + args + "\n{\n" + fs + "}\n";
        }
        public static object RoleTemplatesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RoleTemplateConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetS3BucketStateForRecoveryReply? S3BucketStateForRecovery
        // GraphQL -> s3BucketStateForRecovery: GetS3BucketStateForRecoveryReply! (type)
        public static string S3BucketStateForRecovery(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nbucketName: $bucketName\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\n)";
            return "s3BucketStateForRecovery" + args + "\n{\n" + fs + "}\n";
        }
        public static object S3BucketStateForRecoveryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetS3BucketStateForRecoveryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaDatabase? SapHanaDatabase
        // GraphQL -> sapHanaDatabase: SapHanaDatabase! (type)
        public static string SapHanaDatabase(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "sapHanaDatabase" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaDatabaseFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaDatabase() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaDatabaseConnection? SapHanaDatabases
        // GraphQL -> sapHanaDatabases: SapHanaDatabaseConnection! (type)
        public static string SapHanaDatabases(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "sapHanaDatabases" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaDatabasesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaDatabaseConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaLogSnapshot? SapHanaLogSnapshot
        // GraphQL -> sapHanaLogSnapshot: SapHanaLogSnapshot! (type)
        public static string SapHanaLogSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "sapHanaLogSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaLogSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaLogSnapshot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaLogSnapshotConnection? SapHanaLogSnapshots
        // GraphQL -> sapHanaLogSnapshots: SapHanaLogSnapshotConnection! (type)
        public static string SapHanaLogSnapshots(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "sapHanaLogSnapshots" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaLogSnapshotsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaLogSnapshotConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaRecoverableRange? SapHanaRecoverableRange
        // GraphQL -> sapHanaRecoverableRange: SapHanaRecoverableRange! (type)
        public static string SapHanaRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "sapHanaRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaRecoverableRange() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaRecoverableRangeConnection? SapHanaRecoverableRanges
        // GraphQL -> sapHanaRecoverableRanges: SapHanaRecoverableRangeConnection! (type)
        public static string SapHanaRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "sapHanaRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaRecoverableRangeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaSystem? SapHanaSystem
        // GraphQL -> sapHanaSystem: SapHanaSystem! (type)
        public static string SapHanaSystem(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "sapHanaSystem" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaSystemFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaSystem() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SapHanaSystemConnection? SapHanaSystems
        // GraphQL -> sapHanaSystems: SapHanaSystemConnection! (type)
        public static string SapHanaSystems(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "sapHanaSystems" + args + "\n{\n" + fs + "}\n";
        }
        public static object SapHanaSystemsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SapHanaSystemConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport (type)
        public static string ScheduledReport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\n)";
            return "scheduledReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object ScheduledReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ScheduledReport() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ScheduledReportConnection? ScheduledReports
        // GraphQL -> scheduledReports: ScheduledReportConnection! (type)
        public static string ScheduledReports(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\n)";
            return "scheduledReports" + args + "\n{\n" + fs + "}\n";
        }
        public static object ScheduledReportsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ScheduledReportConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AzureAdObjectConnection? SearchAzureAdSnapshot
        // GraphQL -> searchAzureAdSnapshot: AzureAdObjectConnection! (type)
        public static string SearchAzureAdSnapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\ninput: $input\n)";
            return "searchAzureAdSnapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchAzureAdSnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AzureAdObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> DiffResult? SearchFileByPrefix
        // GraphQL -> searchFileByPrefix: DiffResult! (type)
        public static string SearchFileByPrefix(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nmanagedId: $managedId\nsnapshotId: $snapshotId\nsearchFolderPath: $searchFolderPath\nfilenamePrefix: $filenamePrefix\n)";
            return "searchFileByPrefix" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchFileByPrefixFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new DiffResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SearchResponseListResponse? SearchHost
        // GraphQL -> searchHost: SearchResponseListResponse! (type)
        public static string SearchHost(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nid: $id\npath: $path\n)";
            return "searchHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SearchResponseListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SearchResponseListResponse? SearchNutanixVm
        // GraphQL -> searchNutanixVm: SearchResponseListResponse! (type)
        public static string SearchNutanixVm(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "searchNutanixVm" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchNutanixVmFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SearchResponseListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnappableConnection? SearchSnappableConnection
        // GraphQL -> searchSnappableConnection: SnappableConnection! (type)
        public static string SearchSnappableConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "searchSnappableConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchSnappableConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnappableConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VersionedFileConnection? SearchSnappableVersionedFiles
        // GraphQL -> searchSnappableVersionedFiles: VersionedFileConnection! (type)
        public static string SearchSnappableVersionedFiles(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsearchQuery: $searchQuery\n)";
            return "searchSnappableVersionedFiles" + args + "\n{\n" + fs + "}\n";
        }
        public static object SearchSnappableVersionedFilesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VersionedFileConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ServiceAccountConnection? ServiceAccounts
        // GraphQL -> serviceAccounts: ServiceAccountConnection! (type)
        public static string ServiceAccounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nsearchText: $searchText\nroleIds: $roleIds\n)";
            return "serviceAccounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object ServiceAccountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ServiceAccountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ShareFileset? ShareFileset
        // GraphQL -> shareFileset: ShareFileset! (type)
        public static string ShareFileset(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "shareFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object ShareFilesetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ShareFileset() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteDescendants
        // GraphQL -> sharepointSiteDescendants: O365FullSpObjectConnection! (type)
        public static string SharepointSiteDescendants(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\nsnapshotFid: $snapshotFid\nnaturalId: $naturalId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\norgId: $orgId\n)";
            return "sharepointSiteDescendants" + args + "\n{\n" + fs + "}\n";
        }
        public static object SharepointSiteDescendantsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365FullSpObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365FullSpObjectConnection? SharepointSiteSearch
        // GraphQL -> sharepointSiteSearch: O365FullSpObjectConnection! (type)
        public static string SharepointSiteSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsiteFid: $siteFid\norgId: $orgId\nsharepointSiteSearchFilter: $sharepointSiteSearchFilter\n)";
            return "sharepointSiteSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SharepointSiteSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365FullSpObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<SlaAuditDetail>? SlaAuditDetail
        // GraphQL -> slaAuditDetail: [SlaAuditDetail!]! (type)
        public static string SlaAuditDetail(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nSlaId: $SlaId\nfilter: $filter\ntimezone: $timezone\n)";
            return "slaAuditDetail" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaAuditDetailFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<SlaAuditDetail>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SlaDomainConnection? SlaDomains
        // GraphQL -> slaDomains: SlaDomainConnection! (type)
        public static string SlaDomains(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\ncontextFilterInput: $contextFilterInput\nshouldShowSyncStatus: $shouldShowSyncStatus\nshouldShowProtectedObjectCount: $shouldShowProtectedObjectCount\nshouldShowUpgradeInfo: $shouldShowUpgradeInfo\nshowRemoteSlas: $showRemoteSlas\nshouldShowPausedClusters: $shouldShowPausedClusters\n)";
            return "slaDomains" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaDomainsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SlaDomainConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolume? SlaManagedVolume
        // GraphQL -> slaManagedVolume: ManagedVolume! (type)
        public static string SlaManagedVolume(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "slaManagedVolume" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaManagedVolumeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolume() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ManagedVolumeConnection? SlaManagedVolumes
        // GraphQL -> slaManagedVolumes: ManagedVolumeConnection! (type)
        public static string SlaManagedVolumes(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "slaManagedVolumes" + args + "\n{\n" + fs + "}\n";
        }
        public static object SlaManagedVolumesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ManagedVolumeConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetSmbConfigurationReply? SmbConfiguration
        // GraphQL -> smbConfiguration: GetSmbConfigurationReply! (type)
        public static string SmbConfiguration(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "smbConfiguration" + args + "\n{\n" + fs + "}\n";
        }
        public static object SmbConfigurationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetSmbConfigurationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SmbDomainConnection? SmbDomains
        // GraphQL -> smbDomains: SmbDomainConnection! (type)
        public static string SmbDomains(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "smbDomains" + args + "\n{\n" + fs + "}\n";
        }
        public static object SmbDomainsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SmbDomainConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        public static string SnappableConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilter: $filter\n)";
            return "snappableConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnappableConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? SnappableContactSearch
        // GraphQL -> snappableContactSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableContactSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncontactsSearchFilter: $contactsSearchFilter\n)";
            return "snappableContactSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableContactSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEmailSearch
        // GraphQL -> snappableEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEmailSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            return "snappableEmailSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableEmailSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? SnappableEventSearch
        // GraphQL -> snappableEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnappableEventSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            return "snappableEventSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableEventSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnappableGroupByConnection? SnappableGroupByConnection
        // GraphQL -> snappableGroupByConnection: SnappableGroupByConnection! (type)
        public static string SnappableGroupByConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ngroupBy: $groupBy\nfilter: $filter\ntimezoneOffset: $timezoneOffset\nrequestedAggregations: $requestedAggregations\n)";
            return "snappableGroupByConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableGroupByConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnappableGroupByConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnappableOnedriveSearch
        // GraphQL -> snappableOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableOnedriveSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            return "snappableOnedriveSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableOnedriveSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointDriveSearch
        // GraphQL -> snappableSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointDriveSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\nsiteChildType: $siteChildType\n)";
            return "snappableSharepointDriveSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableSharepointDriveSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnappableSharepointListSearch
        // GraphQL -> snappableSharepointListSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableSharepointListSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\nsiteChildId: $siteChildId\n)";
            return "snappableSharepointListSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableSharepointListSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365TeamsConversationsConnection? SnappableTeamsConversationsSearch
        // GraphQL -> snappableTeamsConversationsSearch: O365TeamsConversationsConnection! (type)
        public static string SnappableTeamsConversationsSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nsnapshotFidOpt: $snapshotFidOpt\nteamConvChannels: $teamConvChannels\nteamsConversationsSearchFilter: $teamsConversationsSearchFilter\n)";
            return "snappableTeamsConversationsSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableTeamsConversationsSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365TeamsConversationsConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnappableTeamsDriveSearch
        // GraphQL -> snappableTeamsDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnappableTeamsDriveSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\norgId: $orgId\nchannelId: $channelId\nchannelFolderName: $channelFolderName\nteamsDriveSearchFilter: $teamsDriveSearchFilter\n)";
            return "snappableTeamsDriveSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappableTeamsDriveSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> LegalHoldSnappableDetailConnection? SnappablesWithLegalHoldSnapshotsSummary
        // GraphQL -> snappablesWithLegalHoldSnapshotsSummary: LegalHoldSnappableDetailConnection! (type)
        public static string SnappablesWithLegalHoldSnapshotsSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            return "snappablesWithLegalHoldSnapshotsSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnappablesWithLegalHoldSnapshotsSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new LegalHoldSnappableDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        public static string Snapshot(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnapshotFid: $snapshotFid\nclusterUuid: $clusterUuid\n)";
            return "snapshot" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmSnapshot() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEmailSearch
        // GraphQL -> snapshotEmailSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEmailSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsearchFilter: $searchFilter\n)";
            return "snapshotEmailSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotEmailSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365ExchangeObjectConnection? SnapshotEventSearch
        // GraphQL -> snapshotEventSearch: O365ExchangeObjectConnection! (type)
        public static string SnapshotEventSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\ncalendarSearchFilter: $calendarSearchFilter\n)";
            return "snapshotEventSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotEventSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365ExchangeObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotFileDeltaConnection? SnapshotFilesDelta
        // GraphQL -> snapshotFilesDelta: SnapshotFileDeltaConnection! (type)
        public static string SnapshotFilesDelta(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            return "snapshotFilesDelta" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotFilesDeltaFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotFileDeltaConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotFileDeltaV2Connection? SnapshotFilesDeltaV2
        // GraphQL -> snapshotFilesDeltaV2: SnapshotFileDeltaV2Connection! (type)
        public static string SnapshotFilesDeltaV2(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\npath: $path\nsnapshotFid: $snapshotFid\nfilter: $filter\nsearchPrefix: $searchPrefix\nquarantineFilters: $quarantineFilters\nworkloadFieldsArg: $workloadFieldsArg\n)";
            return "snapshotFilesDeltaV2" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotFilesDeltaV2FieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotFileDeltaV2Connection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfAsnappableConnection
        // GraphQL -> snapshotOfASnappableConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfAsnappableConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nworkloadId: $workloadId\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            return "snapshotOfASnappableConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotOfAsnappableConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GenericSnapshotConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GenericSnapshotConnection? SnapshotOfSnappablesConnection
        // GraphQL -> snapshotOfSnappablesConnection: GenericSnapshotConnection! (type)
        public static string SnapshotOfSnappablesConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsnappableIds: $snappableIds\nsnapshotFilter: $snapshotFilter\nsortOrder: $sortOrder\nsortBy: $sortBy\ntimeRange: $timeRange\nignoreActiveWorkloadCheck: $ignoreActiveWorkloadCheck\n)";
            return "snapshotOfSnappablesConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotOfSnappablesConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GenericSnapshotConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotOnedriveSearch
        // GraphQL -> snapshotOnedriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotOnedriveSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nonedriveSearchFilter: $onedriveSearchFilter\n)";
            return "snapshotOnedriveSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotOnedriveSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotResultConnection? SnapshotResults
        // GraphQL -> snapshotResults: SnapshotResultConnection! (type)
        public static string SnapshotResults(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nstartTimeMs: $startTimeMs\nendTimeMs: $endTimeMs\n)";
            return "snapshotResults" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotResultsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> O365OnedriveObjectConnection? SnapshotSharepointDriveSearch
        // GraphQL -> snapshotSharepointDriveSearch: O365OnedriveObjectConnection! (type)
        public static string SnapshotSharepointDriveSearch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsnappableFid: $snappableFid\nsnapshotFid: $snapshotFid\norgId: $orgId\nsharepointDriveSearchFilter: $sharepointDriveSearchFilter\n)";
            return "snapshotSharepointDriveSearch" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotSharepointDriveSearchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new O365OnedriveObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnapshotSummaryConnection? SnapshotsForUnmanagedObject
        // GraphQL -> snapshotsForUnmanagedObject: SnapshotSummaryConnection! (type)
        public static string SnapshotsForUnmanagedObject(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            return "snapshotsForUnmanagedObject" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnapshotsForUnmanagedObjectFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnapshotSummaryConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnmpConfiguration? SnmpConfigurations
        // GraphQL -> snmpConfigurations: SnmpConfiguration! (type)
        public static string SnmpConfigurations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "snmpConfigurations" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnmpConfigurationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnmpConfiguration() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SnoozedDirectoryConnection? SnoozedDirectories
        // GraphQL -> snoozedDirectories: SnoozedDirectoryConnection! (type)
        public static string SnoozedDirectories(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsnoozeStatusFilter: $snoozeStatusFilter\ndirectorySearchFilter: $directorySearchFilter\nfalsePositiveTypeFilter: $falsePositiveTypeFilter\n)";
            return "snoozedDirectories" + args + "\n{\n" + fs + "}\n";
        }
        public static object SnoozedDirectoriesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SnoozedDirectoryConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SonarContentReportConnection? SonarContentReport
        // GraphQL -> sonarContentReport: SonarContentReportConnection! (type)
        public static string SonarContentReport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ngroupBy: $groupBy\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\nday: $day\ntimezone: $timezone\nworkloadTypes: $workloadTypes\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "sonarContentReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object SonarContentReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SonarContentReportConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SonarReportConnection? SonarReport
        // GraphQL -> sonarReport: SonarReportConnection! (type)
        public static string SonarReport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsonarReportGroupBy: $sonarReportGroupBy\nfilter: $filter\ntimeFilter: $timeFilter\n)";
            return "sonarReport" + args + "\n{\n" + fs + "}\n";
        }
        public static object SonarReportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SonarReportConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SonarReportRowConnection? SonarReportRow
        // GraphQL -> sonarReportRow: SonarReportRowConnection! (type)
        public static string SonarReportRow(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\nendTime: $endTime\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "sonarReportRow" + args + "\n{\n" + fs + "}\n";
        }
        public static object SonarReportRowFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SonarReportRowConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AccessGroupConnection? SonarUserGroups
        // GraphQL -> sonarUserGroups: AccessGroupConnection! (type)
        public static string SonarUserGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "sonarUserGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object SonarUserGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AccessGroupConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AccessUserConnection? SonarUsers
        // GraphQL -> sonarUsers: AccessUserConnection! (type)
        public static string SonarUsers(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsort: $sort\nfilter: $filter\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "sonarUsers" + args + "\n{\n" + fs + "}\n";
        }
        public static object SonarUsersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AccessUserConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? SupportBundle
        // GraphQL -> supportBundle: AsyncRequestStatus! (type)
        public static string SupportBundle(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "supportBundle" + args + "\n{\n" + fs + "}\n";
        }
        public static object SupportBundleFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportUserAccessConnection? SupportUserAccesses
        // GraphQL -> supportUserAccesses: SupportUserAccessConnection! (type)
        public static string SupportUserAccesses(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilters: $filters\n)";
            return "supportUserAccesses" + args + "\n{\n" + fs + "}\n";
        }
        public static object SupportUserAccessesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SupportUserAccessConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SyslogExportRuleSummaryListResponse? SyslogExportRules
        // GraphQL -> syslogExportRules: SyslogExportRuleSummaryListResponse! (type)
        public static string SyslogExportRules(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "syslogExportRules" + args + "\n{\n" + fs + "}\n";
        }
        public static object SyslogExportRulesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SyslogExportRuleSummaryListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TableFilters? TableFilters
        // GraphQL -> tableFilters: TableFilters! (type)
        public static string TableFilters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "tableFilters" + args + "\n{\n" + fs + "}\n";
        }
        public static object TableFiltersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TableFilters() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        public static string TargetMapping(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntargetMappingId: $targetMappingId\n)";
            return "targetMapping" + args + "\n{\n" + fs + "}\n";
        }
        public static object TargetMappingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetMapping() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TargetConnection? Targets
        // GraphQL -> targets: TargetConnection! (type)
        public static string Targets(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\ncontextFilter: $contextFilter\n)";
            return "targets" + args + "\n{\n" + fs + "}\n";
        }
        public static object TargetsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TargetConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        public static string TaskDetailConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\ntimezoneOffset: $timezoneOffset\n)";
            return "taskDetailConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object TaskDetailConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TaskDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TaskDetailGroupByConnection? TaskDetailGroupByConnection
        // GraphQL -> taskDetailGroupByConnection: TaskDetailGroupByConnection! (type)
        public static string TaskDetailGroupByConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nfilter: $filter\ngroupBy: $groupBy\ntimezoneOffset: $timezoneOffset\n)";
            return "taskDetailGroupByConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object TaskDetailGroupByConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TaskDetailGroupByConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> Taskchain? Taskchain
        // GraphQL -> taskchain: Taskchain! (type)
        public static string Taskchain(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ntaskchainId: $taskchainId\n)";
            return "taskchain" + args + "\n{\n" + fs + "}\n";
        }
        public static object TaskchainFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new Taskchain() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ThreatHunt? ThreatHuntDetail
        // GraphQL -> threatHuntDetail: ThreatHunt! (type)
        public static string ThreatHuntDetail(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nhuntId: $huntId\n)";
            return "threatHuntDetail" + args + "\n{\n" + fs + "}\n";
        }
        public static object ThreatHuntDetailFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ThreatHunt() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ThreatHuntResult? ThreatHuntResult
        // GraphQL -> threatHuntResult: ThreatHuntResult! (type)
        public static string ThreatHuntResult(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nhuntId: $huntId\nobjectId: $objectId\n)";
            return "threatHuntResult" + args + "\n{\n" + fs + "}\n";
        }
        public static object ThreatHuntResultFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ThreatHuntResult() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ThreatHuntSummaryReply? ThreatHuntSummary
        // GraphQL -> threatHuntSummary: ThreatHuntSummaryReply! (type)
        public static string ThreatHuntSummary(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nhuntId: $huntId\n)";
            return "threatHuntSummary" + args + "\n{\n" + fs + "}\n";
        }
        public static object ThreatHuntSummaryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ThreatHuntSummaryReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ThreatHuntConnection? ThreatHunts
        // GraphQL -> threatHunts: ThreatHuntConnection! (type)
        public static string ThreatHunts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nclusterUuidFilter: $clusterUuidFilter\nstatusFilter: $statusFilter\nmatchesFoundFilter: $matchesFoundFilter\nquarantinedMatchesFilter: $quarantinedMatchesFilter\n)";
            return "threatHunts" + args + "\n{\n" + fs + "}\n";
        }
        public static object ThreatHuntsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ThreatHuntConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetTotpStatusReply? TotpConfigStatus
        // GraphQL -> totpConfigStatus: GetTotpStatusReply! (type)
        public static string TotpConfigStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nuserId: $userId\n)";
            return "totpConfigStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object TotpConfigStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetTotpStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> TprStatusForNodeRemoval? TprStatusForNodeRemoval
        // GraphQL -> tprStatusForNodeRemoval: TprStatusForNodeRemoval! (type)
        public static string TprStatusForNodeRemoval(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "tprStatusForNodeRemoval" + args + "\n{\n" + fs + "}\n";
        }
        public static object TprStatusForNodeRemovalFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new TprStatusForNodeRemoval() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> SupportTunnelInfo? TunnelStatus
        // GraphQL -> tunnelStatus: SupportTunnelInfo! (type)
        public static string TunnelStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "tunnelStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object TunnelStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new SupportTunnelInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UnmanagedObjectDetailConnection? UnmanagedObjects
        // GraphQL -> unmanagedObjects: UnmanagedObjectDetailConnection! (type)
        public static string UnmanagedObjects(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\ninput: $input\n)";
            return "unmanagedObjects" + args + "\n{\n" + fs + "}\n";
        }
        public static object UnmanagedObjectsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UnmanagedObjectDetailConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UpgradeStatusReply? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatusReply! (type)
        public static string UpgradeStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\n)";
            return "upgradeStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object UpgradeStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UpgradeStatusReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> FileResultConnection? UserActivities
        // GraphQL -> userActivities: FileResultConnection! (type)
        public static string UserActivities(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfilter: $filter\nsort: $sort\ntimeRange: $timeRange\nuserId: $userId\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\n)";
            return "userActivities" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserActivitiesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new FileResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActivityTimelineResultConnection? UserActivityTimeline
        // GraphQL -> userActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserActivityTimeline(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nuniqueActivities: $uniqueActivities\n)";
            return "userActivityTimeline" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserActivityTimelineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActivityTimelineResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AnalyzerAccessUsageConnection? UserAnalyzerAccess
        // GraphQL -> userAnalyzerAccess: AnalyzerAccessUsageConnection! (type)
        public static string UserAnalyzerAccess(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\nlimit: $limit\n)";
            return "userAnalyzerAccess" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserAnalyzerAccessFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AnalyzerAccessUsageConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserAuditConnection? UserAuditConnection
        // GraphQL -> userAuditConnection: UserAuditConnection! (type)
        public static string UserAuditConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortOrder: $sortOrder\nsortBy: $sortBy\nfilters: $filters\n)";
            return "userAuditConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserAuditConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserAuditConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetUserDetailReply? UserDetail
        // GraphQL -> userDetail: GetUserDetailReply! (type)
        public static string UserDetail(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nuserId: $userId\nstartDay: $startDay\ntimezone: $timezone\n)";
            return "userDetail" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserDetailFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetUserDetailReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ActivityTimelineResultConnection? UserFileActivityTimeline
        // GraphQL -> userFileActivityTimeline: ActivityTimelineResultConnection! (type)
        public static string UserFileActivityTimeline(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nuserId: $userId\nresource: $resource\nnativePath: $nativePath\nstartDay: $startDay\ntimezone: $timezone\ntimeGranularity: $timeGranularity\n)";
            return "userFileActivityTimeline" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserFileActivityTimelineFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ActivityTimelineResultConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<Group>? UserGroups
        // GraphQL -> userGroups: [Group!]! (type)
        public static string UserGroups(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nroleIdsFilter: $roleIdsFilter\n)";
            return "userGroups" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserGroupsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<Group>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserNotifications? UserNotifications
        // GraphQL -> userNotifications: UserNotifications! (type)
        public static string UserNotifications(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "userNotifications" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserNotificationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserNotifications() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetUserSessionManagementConfigReply? UserSessionManagementConfig
        // GraphQL -> userSessionManagementConfig: GetUserSessionManagementConfigReply! (type)
        public static string UserSessionManagementConfig(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "userSessionManagementConfig" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserSessionManagementConfigFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetUserSessionManagementConfigReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserSettings? UserSettings
        // GraphQL -> userSettings: UserSettings! (type)
        public static string UserSettings(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "";
            return "userSettings" + args + "\n{\n" + fs + "}\n";
        }
        public static object UserSettingsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserSettings() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> UserConnection? UsersInCurrentAndDescendantOrganization
        // GraphQL -> usersInCurrentAndDescendantOrganization: UserConnection! (type)
        public static string UsersInCurrentAndDescendantOrganization(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nsortBy: $sortBy\nfilter: $filter\nshouldIncludeUserWithoutRole: $shouldIncludeUserWithoutRole\n)";
            return "usersInCurrentAndDescendantOrganization" + args + "\n{\n" + fs + "}\n";
        }
        public static object UsersInCurrentAndDescendantOrganizationFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new UserConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VcenterAdvancedTagPreviewReply? VcenterAdvancedTagPreview
        // GraphQL -> vCenterAdvancedTagPreview: VcenterAdvancedTagPreviewReply! (type)
        public static string VcenterAdvancedTagPreview(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterAdvancedTagPreview" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterAdvancedTagPreviewFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VcenterAdvancedTagPreviewReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HotAddBandwidthInfo? VcenterHotAddBandwidth
        // GraphQL -> vCenterHotAddBandwidth: HotAddBandwidthInfo! (type)
        public static string VcenterHotAddBandwidth(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterHotAddBandwidth" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterHotAddBandwidthFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HotAddBandwidthInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> HotAddNetworkConfigWithName? VcenterHotAddNetwork
        // GraphQL -> vCenterHotAddNetwork: HotAddNetworkConfigWithName! (type)
        public static string VcenterHotAddNetwork(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterHotAddNetwork" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterHotAddNetworkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new HotAddNetworkConfigWithName() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> NetworkInfoListResponse? VcenterNetworks
        // GraphQL -> vCenterNetworks: NetworkInfoListResponse! (type)
        public static string VcenterNetworks(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterNetworks" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterNetworksFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new NetworkInfoListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VcenterPreAddInfo? VcenterPreAddInfo
        // GraphQL -> vCenterPreAddInfo: VcenterPreAddInfo! (type)
        public static string VcenterPreAddInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vCenterPreAddInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterPreAddInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VcenterPreAddInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereComputeCluster? VsphereComputeCluster
        // GraphQL -> vSphereComputeCluster: VsphereComputeCluster! (type)
        public static string VsphereComputeCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereComputeCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereComputeClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereComputeCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereComputeClusterConnection? VsphereComputeClusters
        // GraphQL -> vSphereComputeClusters: VsphereComputeClusterConnection! (type)
        public static string VsphereComputeClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereComputeClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereComputeClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereComputeClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereDatacenter? VsphereDatacenter
        // GraphQL -> vSphereDatacenter: VsphereDatacenter! (type)
        public static string VsphereDatacenter(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereDatacenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDatacenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereDatacenter() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereDatastore? VsphereDatastore
        // GraphQL -> vSphereDatastore: VsphereDatastore! (type)
        public static string VsphereDatastore(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereDatastore" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDatastoreFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereDatastore() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereDatastoreCluster? VsphereDatastoreCluster
        // GraphQL -> vSphereDatastoreCluster: VsphereDatastoreCluster! (type)
        public static string VsphereDatastoreCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereDatastoreCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDatastoreClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereDatastoreCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereDatastoreClusterConnection? VsphereDatastoreClusters
        // GraphQL -> vSphereDatastoreClusters: VsphereDatastoreClusterConnection! (type)
        public static string VsphereDatastoreClusters(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereDatastoreClusters" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDatastoreClustersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereDatastoreClusterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereDatastoreConnection? VsphereDatastoreConnection
        // GraphQL -> vSphereDatastoreConnection: VsphereDatastoreConnection! (type)
        public static string VsphereDatastoreConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereDatastoreConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereDatastoreConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereDatastoreConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereFolder? VsphereFolder
        // GraphQL -> vSphereFolder: VsphereFolder! (type)
        public static string VsphereFolder(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereFolder" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereFolderFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereFolder() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereFolderConnection? VsphereFolders
        // GraphQL -> vSphereFolders: VsphereFolderConnection! (type)
        public static string VsphereFolders(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereFolders" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereFoldersFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereFolderConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereHost? VsphereHost
        // GraphQL -> vSphereHost: VsphereHost! (type)
        public static string VsphereHost(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereHost" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereHostFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereHost() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereHostConnection? VsphereHostConnection
        // GraphQL -> vSphereHostConnection: VsphereHostConnection! (type)
        public static string VsphereHostConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereHostConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereHostConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereHostConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VmwareHostDetail? VsphereHostDetails
        // GraphQL -> vSphereHostDetails: VmwareHostDetail! (type)
        public static string VsphereHostDetails(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vSphereHostDetails" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereHostDetailsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VmwareHostDetail() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> List<VsphereHost>? VsphereHostsByFids
        // GraphQL -> vSphereHostsByFids: [VsphereHost!]! (type)
        public static string VsphereHostsByFids(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfids: $fids\n)";
            return "vSphereHostsByFids" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereHostsByFidsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new List<VsphereHost>() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        public static string VsphereLiveMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\n)";
            return "vSphereLiveMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereLiveMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereMount? VsphereMount
        // GraphQL -> vSphereMount: VsphereMount! (type)
        public static string VsphereMount(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereMount" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereMountFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereMount() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereMountConnection? VsphereMountConnection
        // GraphQL -> vSphereMountConnection: VsphereMountConnection! (type)
        public static string VsphereMountConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilter: $filter\nsortBy: $sortBy\nsortOrder: $sortOrder\n)";
            return "vSphereMountConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereMountConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereNetwork? VsphereNetwork
        // GraphQL -> vSphereNetwork: VsphereNetwork! (type)
        public static string VsphereNetwork(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereNetwork" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereNetworkFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereNetwork() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereResourcePool? VsphereResourcePool
        // GraphQL -> vSphereResourcePool: VsphereResourcePool! (type)
        public static string VsphereResourcePool(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereResourcePool" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereResourcePoolFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereResourcePool() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereRootRecoveryHierarchy
        // GraphQL -> vSphereRootRecoveryHierarchy: CdmHierarchyObjectConnection! (type)
        public static string VsphereRootRecoveryHierarchy(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereRootRecoveryHierarchy" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereRootRecoveryHierarchyFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmHierarchyObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereTag? VsphereTag
        // GraphQL -> vSphereTag: VsphereTag! (type)
        public static string VsphereTag(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereTag" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereTagFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereTag() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereTagCategory? VsphereTagCategory
        // GraphQL -> vSphereTagCategory: VsphereTagCategory! (type)
        public static string VsphereTagCategory(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereTagCategory" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereTagCategoryFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereTagCategory() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> CdmHierarchyObjectConnection? VsphereTopLevelDescendantsConnection
        // GraphQL -> vSphereTopLevelDescendantsConnection: CdmHierarchyObjectConnection! (type)
        public static string VsphereTopLevelDescendantsConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\ntypeFilter: $typeFilter\nfilter: $filter\n)";
            return "vSphereTopLevelDescendantsConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereTopLevelDescendantsConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new CdmHierarchyObjectConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVcenter? VsphereVcenter
        // GraphQL -> vSphereVCenter: VsphereVcenter! (type)
        public static string VsphereVcenter(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereVCenter" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVcenterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVcenter() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVcenterConnection? VsphereVcenterConnection
        // GraphQL -> vSphereVCenterConnection: VsphereVcenterConnection! (type)
        public static string VsphereVcenterConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereVCenterConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVcenterConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVcenterConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VsphereVmAsyncRequestStatus
        // GraphQL -> vSphereVMAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string VsphereVmAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nid: $id\n)";
            return "vSphereVMAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVm? VsphereVmNew
        // GraphQL -> vSphereVmNew: VsphereVm! (type)
        public static string VsphereVmNew(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "vSphereVmNew" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmNewFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVm() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmConnection? VsphereVmNewConnection
        // GraphQL -> vSphereVmNewConnection: VsphereVmConnection! (type)
        public static string VsphereVmNewConnection(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vSphereVmNewConnection" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmNewConnectionFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVmConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAwsNativeRdsClusterNameForExportReply? ValidateAwsNativeRdsClusterNameForExport
        // GraphQL -> validateAwsNativeRdsClusterNameForExport: ValidateAwsNativeRdsClusterNameForExportReply! (type)
        public static string ValidateAwsNativeRdsClusterNameForExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsClusterName: $rdsClusterName\n)";
            return "validateAwsNativeRdsClusterNameForExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAwsNativeRdsClusterNameForExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAwsNativeRdsClusterNameForExportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAwsNativeRdsInstanceNameForExportReply? ValidateAwsNativeRdsInstanceNameForExport
        // GraphQL -> validateAwsNativeRdsInstanceNameForExport: ValidateAwsNativeRdsInstanceNameForExportReply! (type)
        public static string ValidateAwsNativeRdsInstanceNameForExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nawsAccountRubrikId: $awsAccountRubrikId\nregion: $region\nrdsInstanceName: $rdsInstanceName\n)";
            return "validateAwsNativeRdsInstanceNameForExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAwsNativeRdsInstanceNameForExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAwsNativeRdsInstanceNameForExportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAzureSubnetsForCloudAccountExocomputeReply? ValidateAzureCloudAccountExocomputeConfigurations
        // GraphQL -> validateAzureCloudAccountExocomputeConfigurations: ValidateAzureSubnetsForCloudAccountExocomputeReply! (type)
        public static string ValidateAzureCloudAccountExocomputeConfigurations(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "validateAzureCloudAccountExocomputeConfigurations" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAzureCloudAccountExocomputeConfigurationsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAzureSubnetsForCloudAccountExocomputeReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAzureNativeSqlDatabaseDbNameForExportReply? ValidateAzureNativeSqlDatabaseDbNameForExport
        // GraphQL -> validateAzureNativeSqlDatabaseDbNameForExport: ValidateAzureNativeSqlDatabaseDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlDatabaseDbNameForExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlDatabaseServerRubrikId: $azureSqlDatabaseServerRubrikId\n)";
            return "validateAzureNativeSqlDatabaseDbNameForExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAzureNativeSqlDatabaseDbNameForExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAzureNativeSqlDatabaseDbNameForExportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateAzureNativeSqlManagedInstanceDbNameForExportReply? ValidateAzureNativeSqlManagedInstanceDbNameForExport
        // GraphQL -> validateAzureNativeSqlManagedInstanceDbNameForExport: ValidateAzureNativeSqlManagedInstanceDbNameForExportReply! (type)
        public static string ValidateAzureNativeSqlManagedInstanceDbNameForExport(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nazureSqlDatabaseName: $azureSqlDatabaseName\nazureSqlManagedInstanceServerRubrikId: $azureSqlManagedInstanceServerRubrikId\n)";
            return "validateAzureNativeSqlManagedInstanceDbNameForExport" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateAzureNativeSqlManagedInstanceDbNameForExportFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateAzureNativeSqlManagedInstanceDbNameForExportReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ClusterLicenseCapacityValidations? ValidateClusterLicenseCapacity
        // GraphQL -> validateClusterLicenseCapacity: ClusterLicenseCapacityValidations! (type)
        public static string ValidateClusterLicenseCapacity(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "validateClusterLicenseCapacity" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateClusterLicenseCapacityFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ClusterLicenseCapacityValidations() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidationReply? ValidateCreateAwsClusterInput
        // GraphQL -> validateCreateAwsClusterInput: ValidationReply! (type)
        public static string ValidateCreateAwsClusterInput(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "validateCreateAwsClusterInput" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateCreateAwsClusterInputFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidationReply? ValidateCreateAzureClusterInput
        // GraphQL -> validateCreateAzureClusterInput: ValidationReply! (type)
        public static string ValidateCreateAzureClusterInput(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "validateCreateAzureClusterInput" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateCreateAzureClusterInputFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidationReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> ValidateOrgNameReply? ValidateOrgName
        // GraphQL -> validateOrgName: ValidateOrgNameReply! (type)
        public static string ValidateOrgName(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "validateOrgName" + args + "\n{\n" + fs + "}\n";
        }
        public static object ValidateOrgNameFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new ValidateOrgNameReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VappInstantRecoveryOptions? VappSnapshotInstantRecoveryOptions
        // GraphQL -> vappSnapshotInstantRecoveryOptions: VappInstantRecoveryOptions! (type)
        public static string VappSnapshotInstantRecoveryOptions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vappSnapshotInstantRecoveryOptions" + args + "\n{\n" + fs + "}\n";
        }
        public static object VappSnapshotInstantRecoveryOptionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VappInstantRecoveryOptions() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VappTemplateExportOptionsUnion? VappTemplateSnapshotExportOptions
        // GraphQL -> vappTemplateSnapshotExportOptions: VappTemplateExportOptionsUnion! (type)
        public static string VappTemplateSnapshotExportOptions(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vappTemplateSnapshotExportOptions" + args + "\n{\n" + fs + "}\n";
        }
        public static object VappTemplateSnapshotExportOptionsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VappTemplateExportOptionsUnion() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VsphereVmConnection? VcdVappVms
        // GraphQL -> vcdVappVms: VsphereVmConnection! (type)
        public static string VcdVappVms(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nsortBy: $sortBy\nsortOrder: $sortOrder\nfilter: $filter\n)";
            return "vcdVappVms" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcdVappVmsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VsphereVmConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> AsyncRequestStatus? VcenterAsyncRequestStatus
        // GraphQL -> vcenterAsyncRequestStatus: AsyncRequestStatus! (type)
        public static string VcenterAsyncRequestStatus(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vcenterAsyncRequestStatus" + args + "\n{\n" + fs + "}\n";
        }
        public static object VcenterAsyncRequestStatusFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new AsyncRequestStatus() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VerifySlaWithReplicationToClusterResponse? VerifySlaWithReplicationToCluster
        // GraphQL -> verifySlaWithReplicationToCluster: VerifySlaWithReplicationToClusterResponse! (type)
        public static string VerifySlaWithReplicationToCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ncdmClusterUUID: $cdmClusterUUID\nincludeArchived: $includeArchived\n)";
            return "verifySlaWithReplicationToCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object VerifySlaWithReplicationToClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VerifySlaWithReplicationToClusterResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VmwareRecoverableRangeListResponse? VmwareMissedRecoverableRanges
        // GraphQL -> vmwareMissedRecoverableRanges: VmwareRecoverableRangeListResponse! (type)
        public static string VmwareMissedRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vmwareMissedRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object VmwareMissedRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VmwareRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VmwareRecoverableRangeListResponse? VmwareRecoverableRanges
        // GraphQL -> vmwareRecoverableRanges: VmwareRecoverableRangeListResponse! (type)
        public static string VmwareRecoverableRanges(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\ninput: $input\n)";
            return "vmwareRecoverableRanges" + args + "\n{\n" + fs + "}\n";
        }
        public static object VmwareRecoverableRangesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VmwareRecoverableRangeListResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> VolumeGroupLiveMountConnection? VolumeGroupMounts
        // GraphQL -> volumeGroupMounts: VolumeGroupLiveMountConnection! (type)
        public static string VolumeGroupMounts(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nfilters: $filters\nsortBy: $sortBy\n)";
            return "volumeGroupMounts" + args + "\n{\n" + fs + "}\n";
        }
        public static object VolumeGroupMountsFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new VolumeGroupLiveMountConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RecoverableRangeResponse? VsphereVmMissedRecoverableRange
        // GraphQL -> vsphereVMMissedRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmMissedRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            return "vsphereVMMissedRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmMissedRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RecoverableRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> RecoverableRangeResponse? VsphereVmRecoverableRange
        // GraphQL -> vsphereVMRecoverableRange: RecoverableRangeResponse! (type)
        public static string VsphereVmRecoverableRange(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nsnappableFid: $snappableFid\nbeforeTime: $beforeTime\nafterTime: $afterTime\n)";
            return "vsphereVMRecoverableRange" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRecoverableRangeFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new RecoverableRangeResponse() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchVmwareVmRecoverableRanges? VsphereVmRecoverableRangeInBatch
        // GraphQL -> vsphereVMRecoverableRangeInBatch: BatchVmwareVmRecoverableRanges! (type)
        public static string VsphereVmRecoverableRangeInBatch(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nrequestInfo: $requestInfo\n)";
            return "vsphereVMRecoverableRangeInBatch" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmRecoverableRangeInBatchFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchVmwareVmRecoverableRanges() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> BatchVmwareCdpLiveInfo? VsphereVmwareCdpLiveInfo
        // GraphQL -> vsphereVmwareCdpLiveInfo: BatchVmwareCdpLiveInfo! (type)
        public static string VsphereVmwareCdpLiveInfo(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nids: $ids\n)";
            return "vsphereVmwareCdpLiveInfo" + args + "\n{\n" + fs + "}\n";
        }
        public static object VsphereVmwareCdpLiveInfoFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new BatchVmwareCdpLiveInfo() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> WindowsCluster? WindowsCluster
        // GraphQL -> windowsCluster: WindowsCluster! (type)
        public static string WindowsCluster(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "windowsCluster" + args + "\n{\n" + fs + "}\n";
        }
        public static object WindowsClusterFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new WindowsCluster() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> WindowsFileset? WindowsFileset
        // GraphQL -> windowsFileset: WindowsFileset! (type)
        public static string WindowsFileset(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfid: $fid\n)";
            return "windowsFileset" + args + "\n{\n" + fs + "}\n";
        }
        public static object WindowsFilesetFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new WindowsFileset() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> GetWorkloadAlertSettingReply? WorkloadAlertSetting
        // GraphQL -> workloadAlertSetting: GetWorkloadAlertSettingReply! (type)
        public static string WorkloadAlertSetting(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nclusterUuid: $clusterUuid\nworkloadId: $workloadId\n)";
            return "workloadAlertSetting" + args + "\n{\n" + fs + "}\n";
        }
        public static object WorkloadAlertSettingFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new GetWorkloadAlertSettingReply() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        //      C# -> WorkloadAnomalyConnection? WorkloadAnomalies
        // GraphQL -> workloadAnomalies: WorkloadAnomalyConnection! (type)
        public static string WorkloadAnomalies(object fsObj)
        {
            var fs = fsObj is IFieldSpec f ? f.AsFieldSpec() : fsObj.ToString();
            string args = "\n(\nfirst: $first\nafter: $after\nlast: $last\nbefore: $before\nbeginTime: $beginTime\nendTime: $endTime\nworkloadNameSearch: $workloadNameSearch\nobjectTypeFilter: $objectTypeFilter\nclusterUuidFilter: $clusterUuidFilter\nslaFidFilter: $slaFidFilter\nencryptionFilter: $encryptionFilter\nseverityFilter: $severityFilter\nanalyzerGroupFilter: $analyzerGroupFilter\nsortBy: $sortBy\nsortOrder: $sortOrder\norderParentsFirst: $orderParentsFirst\nblueprintRecoveryTypes: $blueprintRecoveryTypes\nlocationsFilter: $locationsFilter\nresolutionStatusFilter: $resolutionStatusFilter\n)";
            return "workloadAnomalies" + args + "\n{\n" + fs + "}\n";
        }
        public static object WorkloadAnomaliesFieldSpec(ExplorationContext? ec=null)
        {
            if(ec==null) {
                ec = new ExplorationContext();
            }
            var fieldSpecObj = new WorkloadAnomalyConnection() ;
            fieldSpecObj.ApplyExploratoryFieldSpec(ec);
            return fieldSpecObj;
        }

        #endregion

    } // class Query
    #endregion
}