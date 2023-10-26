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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
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
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionType\n" ;
            } else {
                s += ind + "encryptionType\n" ;
            }
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClass\n" ;
            } else {
                s += ind + "storageClass\n" ;
            }
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(conf.Child("cloudAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (this.BucketPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucketPrefix\n" ;
            } else {
                s += ind + "bucketPrefix\n" ;
            }
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConsolidationEnabled\n" ;
            } else {
                s += ind + "isConsolidationEnabled\n" ;
            }
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        if (this.KmsMasterKeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsMasterKeyId\n" ;
            } else {
                s += ind + "kmsMasterKeyId\n" ;
            }
        }
        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        if (this.BucketTags != null) {
            var fspec = this.BucketTags.AsFieldSpec(conf.Child("bucketTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "bucketTags {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings != null) {
            var fspec = this.ComputeSettings.AsFieldSpec(conf.Child("computeSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeSettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(conf.Child("proxySettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
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
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (ec.Includes("encryptionType",true))
        {
            if(this.EncryptionType == null) {

                this.EncryptionType = new TargetEncryptionTypeEnum();

            } else {


            }
        }
        else if (this.EncryptionType != null && ec.Excludes("encryptionType",true))
        {
            this.EncryptionType = null;
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (ec.Includes("storageClass",true))
        {
            if(this.StorageClass == null) {

                this.StorageClass = new AwsStorageClass();

            } else {


            }
        }
        else if (this.StorageClass != null && ec.Excludes("storageClass",true))
        {
            this.StorageClass = null;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new TargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (ec.Includes("cloudAccount",false))
        {
            if(this.CloudAccount == null) {

                var impls = new List<CloudAccount>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));
                this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CloudAccount>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));
                this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.CloudAccount != null && ec.Excludes("cloudAccount",false))
        {
            this.CloudAccount = null;
        }
        //      C# -> System.String? BucketPrefix
        // GraphQL -> bucketPrefix: String! (scalar)
        if (ec.Includes("bucketPrefix",true))
        {
            if(this.BucketPrefix == null) {

                this.BucketPrefix = "FETCH";

            } else {


            }
        }
        else if (this.BucketPrefix != null && ec.Excludes("bucketPrefix",true))
        {
            this.BucketPrefix = null;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (ec.Includes("isConsolidationEnabled",true))
        {
            if(this.IsConsolidationEnabled == null) {

                this.IsConsolidationEnabled = true;

            } else {


            }
        }
        else if (this.IsConsolidationEnabled != null && ec.Excludes("isConsolidationEnabled",true))
        {
            this.IsConsolidationEnabled = null;
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        if (ec.Includes("kmsMasterKeyId",true))
        {
            if(this.KmsMasterKeyId == null) {

                this.KmsMasterKeyId = "FETCH";

            } else {


            }
        }
        else if (this.KmsMasterKeyId != null && ec.Excludes("kmsMasterKeyId",true))
        {
            this.KmsMasterKeyId = null;
        }
        //      C# -> List<TagObject>? BucketTags
        // GraphQL -> bucketTags: [TagObject!]! (type)
        if (ec.Includes("bucketTags",false))
        {
            if(this.BucketTags == null) {

                this.BucketTags = new List<TagObject>();
                this.BucketTags.ApplyExploratoryFieldSpec(ec.NewChild("bucketTags"));

            } else {

                this.BucketTags.ApplyExploratoryFieldSpec(ec.NewChild("bucketTags"));

            }
        }
        else if (this.BucketTags != null && ec.Excludes("bucketTags",false))
        {
            this.BucketTags = null;
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (ec.Includes("computeSettings",false))
        {
            if(this.ComputeSettings == null) {

                this.ComputeSettings = new AwsComputeSettings();
                this.ComputeSettings.ApplyExploratoryFieldSpec(ec.NewChild("computeSettings"));

            } else {

                this.ComputeSettings.ApplyExploratoryFieldSpec(ec.NewChild("computeSettings"));

            }
        }
        else if (this.ComputeSettings != null && ec.Excludes("computeSettings",false))
        {
            this.ComputeSettings = null;
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (ec.Includes("proxySettings",false))
        {
            if(this.ProxySettings == null) {

                this.ProxySettings = new ProxySettings();
                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            } else {

                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            }
        }
        else if (this.ProxySettings != null && ec.Excludes("proxySettings",false))
        {
            this.ProxySettings = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsTargetTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AwsTargetTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types