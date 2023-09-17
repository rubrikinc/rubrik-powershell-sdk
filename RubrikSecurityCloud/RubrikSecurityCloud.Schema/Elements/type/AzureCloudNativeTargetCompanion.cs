// AzureCloudNativeTargetCompanion.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureCloudNativeTargetCompanion
    public class AzureCloudNativeTargetCompanion: BaseType
    {
        #region members

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        [JsonProperty("redundancy")]
        public AzureRedundancy? Redundancy { get; set; }

        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion! (enum)
        [JsonProperty("storageAccountRegion")]
        public AzureRegion? StorageAccountRegion { get; set; }

        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        [JsonProperty("storageTier")]
        public AzureStorageTier? StorageTier { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> List<AzureCmk>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmk!]! (type)
        [JsonProperty("cmkInfo")]
        public List<AzureCmk>? CmkInfo { get; set; }

        //      C# -> List<TagObject>? StorageAccountTags
        // GraphQL -> storageAccountTags: [TagObject!]! (type)
        [JsonProperty("storageAccountTags")]
        public List<TagObject>? StorageAccountTags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudNativeTargetCompanion";
    }

    public AzureCloudNativeTargetCompanion Set(
        CloudNativeLocTemplateType? CloudNativeLocTemplateType = null,
        AzureRedundancy? Redundancy = null,
        AzureRegion? StorageAccountRegion = null,
        AzureStorageTier? StorageTier = null,
        System.String? SubscriptionNativeId = null,
        List<AzureCmk>? CmkInfo = null,
        List<TagObject>? StorageAccountTags = null
    ) 
    {
        if ( CloudNativeLocTemplateType != null ) {
            this.CloudNativeLocTemplateType = CloudNativeLocTemplateType;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( StorageAccountRegion != null ) {
            this.StorageAccountRegion = StorageAccountRegion;
        }
        if ( StorageTier != null ) {
            this.StorageTier = StorageTier;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
        }
        if ( CmkInfo != null ) {
            this.CmkInfo = CmkInfo;
        }
        if ( StorageAccountTags != null ) {
            this.StorageAccountTags = StorageAccountTags;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType != null) {
            s += ind + "cloudNativeLocTemplateType\n" ;
        }
        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        if (this.Redundancy != null) {
            s += ind + "redundancy\n" ;
        }
        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion! (enum)
        if (this.StorageAccountRegion != null) {
            s += ind + "storageAccountRegion\n" ;
        }
        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        if (this.StorageTier != null) {
            s += ind + "storageTier\n" ;
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId != null) {
            s += ind + "subscriptionNativeId\n" ;
        }
        //      C# -> List<AzureCmk>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmk!]! (type)
        if (this.CmkInfo != null) {
            var fspec = this.CmkInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cmkInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TagObject>? StorageAccountTags
        // GraphQL -> storageAccountTags: [TagObject!]! (type)
        if (this.StorageAccountTags != null) {
            var fspec = this.StorageAccountTags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storageAccountTags {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType == null && ec.Includes("cloudNativeLocTemplateType",true))
        {
            this.CloudNativeLocTemplateType = new CloudNativeLocTemplateType();
        }
        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        if (this.Redundancy == null && ec.Includes("redundancy",true))
        {
            this.Redundancy = new AzureRedundancy();
        }
        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion! (enum)
        if (this.StorageAccountRegion == null && ec.Includes("storageAccountRegion",true))
        {
            this.StorageAccountRegion = new AzureRegion();
        }
        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        if (this.StorageTier == null && ec.Includes("storageTier",true))
        {
            this.StorageTier = new AzureStorageTier();
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId == null && ec.Includes("subscriptionNativeId",true))
        {
            this.SubscriptionNativeId = "FETCH";
        }
        //      C# -> List<AzureCmk>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmk!]! (type)
        if (this.CmkInfo == null && ec.Includes("cmkInfo",false))
        {
            this.CmkInfo = new List<AzureCmk>();
            this.CmkInfo.ApplyExploratoryFieldSpec(ec.NewChild("cmkInfo"));
        }
        //      C# -> List<TagObject>? StorageAccountTags
        // GraphQL -> storageAccountTags: [TagObject!]! (type)
        if (this.StorageAccountTags == null && ec.Includes("storageAccountTags",false))
        {
            this.StorageAccountTags = new List<TagObject>();
            this.StorageAccountTags.ApplyExploratoryFieldSpec(ec.NewChild("storageAccountTags"));
        }
    }


    #endregion

    } // class AzureCloudNativeTargetCompanion
    
    #endregion

    public static class ListAzureCloudNativeTargetCompanionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureCloudNativeTargetCompanion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudNativeTargetCompanion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudNativeTargetCompanion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudNativeTargetCompanion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types