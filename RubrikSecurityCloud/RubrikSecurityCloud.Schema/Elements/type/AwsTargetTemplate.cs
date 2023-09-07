// AwsTargetTemplate.cs
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
    #region AwsTargetTemplate
 
    public class AwsTargetTemplate: BaseType, TargetTemplate
    {
        #region members

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        [JsonProperty("encryptionType")]
        public TargetEncryptionTypeEnum? EncryptionType { get; set; }

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        [JsonProperty("cloudAccount")]
        public CloudAccount? CloudAccount { get; set; }

        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        [JsonProperty("bucketPrefix")]
        public System.String? BucketPrefix { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        [JsonProperty("bucketTags")]
        public List<TagObject>? BucketTags { get; set; }

        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        [JsonProperty("computeSettings")]
        public AwsComputeSettings? ComputeSettings { get; set; }

        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        [JsonProperty("proxySettings")]
        public ProxySettings? ProxySettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsTargetTemplate";
    }

    public AwsTargetTemplate Set(
        CloudNativeLocTemplateType? CloudNativeLocTemplateType = null,
        TargetEncryptionTypeEnum? EncryptionType = null,
        AwsRegion? Region = null,
        AwsStorageClass? StorageClass = null,
        TargetType? TargetType = null,
        CloudAccount? CloudAccount = null,
        System.String? BucketPrefix = null,
        System.Boolean? IsConsolidationEnabled = null,
        System.String? KmsMasterKeyId = null,
        List<TagObject>? BucketTags = null,
        AwsComputeSettings? ComputeSettings = null,
        ProxySettings? ProxySettings = null
    ) 
    {
        if ( CloudNativeLocTemplateType != null ) {
            this.CloudNativeLocTemplateType = CloudNativeLocTemplateType;
        }
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( StorageClass != null ) {
            this.StorageClass = StorageClass;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        if ( BucketPrefix != null ) {
            this.BucketPrefix = BucketPrefix;
        }
        if ( IsConsolidationEnabled != null ) {
            this.IsConsolidationEnabled = IsConsolidationEnabled;
        }
        if ( KmsMasterKeyId != null ) {
            this.KmsMasterKeyId = KmsMasterKeyId;
        }
        if ( BucketTags != null ) {
            this.BucketTags = BucketTags;
        }
        if ( ComputeSettings != null ) {
            this.ComputeSettings = ComputeSettings;
        }
        if ( ProxySettings != null ) {
            this.ProxySettings = ProxySettings;
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
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType != null) {
            s += ind + "encryptionType\n" ;
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass != null) {
            s += ind + "storageClass\n" ;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (this.BucketPrefix != null) {
            s += ind + "bucketPrefix\n" ;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled != null) {
            s += ind + "isConsolidationEnabled\n" ;
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        if (this.KmsMasterKeyId != null) {
            s += ind + "kmsMasterKeyId\n" ;
        }
        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        if (this.BucketTags != null) {
            var fspec = this.BucketTags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "bucketTags {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings != null) {
            var fspec = this.ComputeSettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeSettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
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
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType == null && ec.Includes("encryptionType",true))
        {
            this.EncryptionType = new TargetEncryptionTypeEnum();
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AwsRegion();
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass == null && ec.Includes("storageClass",true))
        {
            this.StorageClass = new AwsStorageClass();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && ec.Includes("targetType",true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount == null && ec.Includes("cloudAccount",false))
        {
            var impls = new List<CloudAccount>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));
            this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (this.BucketPrefix == null && ec.Includes("bucketPrefix",true))
        {
            this.BucketPrefix = "FETCH";
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled == null && ec.Includes("isConsolidationEnabled",true))
        {
            this.IsConsolidationEnabled = true;
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        if (this.KmsMasterKeyId == null && ec.Includes("kmsMasterKeyId",true))
        {
            this.KmsMasterKeyId = "FETCH";
        }
        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        if (this.BucketTags == null && ec.Includes("bucketTags",false))
        {
            this.BucketTags = new List<TagObject>();
            this.BucketTags.ApplyExploratoryFieldSpec(ec.NewChild("bucketTags"));
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings == null && ec.Includes("computeSettings",false))
        {
            this.ComputeSettings = new AwsComputeSettings();
            this.ComputeSettings.ApplyExploratoryFieldSpec(ec.NewChild("computeSettings"));
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings == null && ec.Includes("proxySettings",false))
        {
            this.ProxySettings = new ProxySettings();
            this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));
        }
    }


    #endregion

    } // class AwsTargetTemplate
    
    #endregion

    public static class ListAwsTargetTemplateExtensions
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
            this List<AwsTargetTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsTargetTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AwsTargetTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types