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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType == null && Exploration.Includes(parent + ".cloudNativeLocTemplateType", true))
        {
            this.CloudNativeLocTemplateType = new CloudNativeLocTemplateType();
        }
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType == null && Exploration.Includes(parent + ".encryptionType", true))
        {
            this.EncryptionType = new TargetEncryptionTypeEnum();
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AwsRegion();
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass == null && Exploration.Includes(parent + ".storageClass", true))
        {
            this.StorageClass = new AwsStorageClass();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount"))
        {
            var impls = new List<CloudAccount>();
            impls.ApplyExploratoryFieldSpec(parent + ".cloudAccount");
            this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (this.BucketPrefix == null && Exploration.Includes(parent + ".bucketPrefix", true))
        {
            this.BucketPrefix = "FETCH";
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled == null && Exploration.Includes(parent + ".isConsolidationEnabled", true))
        {
            this.IsConsolidationEnabled = true;
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        if (this.KmsMasterKeyId == null && Exploration.Includes(parent + ".kmsMasterKeyId", true))
        {
            this.KmsMasterKeyId = "FETCH";
        }
        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        if (this.BucketTags == null && Exploration.Includes(parent + ".bucketTags"))
        {
            this.BucketTags = new List<TagObject>();
            this.BucketTags.ApplyExploratoryFieldSpec(parent + ".bucketTags");
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings == null && Exploration.Includes(parent + ".computeSettings"))
        {
            this.ComputeSettings = new AwsComputeSettings();
            this.ComputeSettings.ApplyExploratoryFieldSpec(parent + ".computeSettings");
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings == null && Exploration.Includes(parent + ".proxySettings"))
        {
            this.ProxySettings = new ProxySettings();
            this.ProxySettings.ApplyExploratoryFieldSpec(parent + ".proxySettings");
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types