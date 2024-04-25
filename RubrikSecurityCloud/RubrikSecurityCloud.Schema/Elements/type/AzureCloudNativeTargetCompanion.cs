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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeLocTemplateType\n" ;
            } else {
                s += ind + "cloudNativeLocTemplateType\n" ;
            }
        }
        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion! (enum)
        if (this.StorageAccountRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountRegion\n" ;
            } else {
                s += ind + "storageAccountRegion\n" ;
            }
        }
        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        if (this.StorageTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageTier\n" ;
            } else {
                s += ind + "storageTier\n" ;
            }
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (this.SubscriptionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionNativeId\n" ;
            } else {
                s += ind + "subscriptionNativeId\n" ;
            }
        }
        //      C# -> List<AzureCmk>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmk!]! (type)
        if (this.CmkInfo != null) {
            var fspec = this.CmkInfo.AsFieldSpec(conf.Child("cmkInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cmkInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TagObject>? StorageAccountTags
        // GraphQL -> storageAccountTags: [TagObject!]! (type)
        if (this.StorageAccountTags != null) {
            var fspec = this.StorageAccountTags.AsFieldSpec(conf.Child("storageAccountTags"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storageAccountTags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (ec.Includes("cloudNativeLocTemplateType",true))
        {
            if(this.CloudNativeLocTemplateType == null) {

                this.CloudNativeLocTemplateType = new CloudNativeLocTemplateType();

            } else {


            }
        }
        else if (this.CloudNativeLocTemplateType != null && ec.Excludes("cloudNativeLocTemplateType",true))
        {
            this.CloudNativeLocTemplateType = null;
        }
        //      C# -> AzureRedundancy? Redundancy
        // GraphQL -> redundancy: AzureRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new AzureRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> AzureRegion? StorageAccountRegion
        // GraphQL -> storageAccountRegion: AzureRegion! (enum)
        if (ec.Includes("storageAccountRegion",true))
        {
            if(this.StorageAccountRegion == null) {

                this.StorageAccountRegion = new AzureRegion();

            } else {


            }
        }
        else if (this.StorageAccountRegion != null && ec.Excludes("storageAccountRegion",true))
        {
            this.StorageAccountRegion = null;
        }
        //      C# -> AzureStorageTier? StorageTier
        // GraphQL -> storageTier: AzureStorageTier! (enum)
        if (ec.Includes("storageTier",true))
        {
            if(this.StorageTier == null) {

                this.StorageTier = new AzureStorageTier();

            } else {


            }
        }
        else if (this.StorageTier != null && ec.Excludes("storageTier",true))
        {
            this.StorageTier = null;
        }
        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        if (ec.Includes("subscriptionNativeId",true))
        {
            if(this.SubscriptionNativeId == null) {

                this.SubscriptionNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionNativeId != null && ec.Excludes("subscriptionNativeId",true))
        {
            this.SubscriptionNativeId = null;
        }
        //      C# -> List<AzureCmk>? CmkInfo
        // GraphQL -> cmkInfo: [AzureCmk!]! (type)
        if (ec.Includes("cmkInfo",false))
        {
            if(this.CmkInfo == null) {

                this.CmkInfo = new List<AzureCmk>();
                this.CmkInfo.ApplyExploratoryFieldSpec(ec.NewChild("cmkInfo"));

            } else {

                this.CmkInfo.ApplyExploratoryFieldSpec(ec.NewChild("cmkInfo"));

            }
        }
        else if (this.CmkInfo != null && ec.Excludes("cmkInfo",false))
        {
            this.CmkInfo = null;
        }
        //      C# -> List<TagObject>? StorageAccountTags
        // GraphQL -> storageAccountTags: [TagObject!]! (type)
        if (ec.Includes("storageAccountTags",false))
        {
            if(this.StorageAccountTags == null) {

                this.StorageAccountTags = new List<TagObject>();
                this.StorageAccountTags.ApplyExploratoryFieldSpec(ec.NewChild("storageAccountTags"));

            } else {

                this.StorageAccountTags.ApplyExploratoryFieldSpec(ec.NewChild("storageAccountTags"));

            }
        }
        else if (this.StorageAccountTags != null && ec.Excludes("storageAccountTags",false))
        {
            this.StorageAccountTags = null;
        }
    }


    #endregion

    } // class AzureCloudNativeTargetCompanion
    
    #endregion

    public static class ListAzureCloudNativeTargetCompanionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureCloudNativeTargetCompanion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudNativeTargetCompanion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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