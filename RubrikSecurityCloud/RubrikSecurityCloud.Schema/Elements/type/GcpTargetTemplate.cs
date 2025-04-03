// GcpTargetTemplate.cs
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
    #region GcpTargetTemplate
 
    public class GcpTargetTemplate: BaseType, TargetTemplate
    {
        #region members

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        [JsonProperty("region")]
        public GcpRegion? Region { get; set; }

        //      C# -> GcpStorageClass? StorageClass
        // GraphQL -> storageClass: GcpStorageClass! (enum)
        [JsonProperty("storageClass")]
        public GcpStorageClass? StorageClass { get; set; }

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

        //      C# -> List<GcpCmk>? CmkInfo
        // GraphQL -> cmkInfo: [GcpCmk!]! (type)
        [JsonProperty("cmkInfo")]
        public List<GcpCmk>? CmkInfo { get; set; }

        //      C# -> List<TagObject>? Labels
        // GraphQL -> labels: [TagObject!]! (type)
        [JsonProperty("labels")]
        public List<TagObject>? Labels { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpTargetTemplate";
    }

    public GcpTargetTemplate Set(
        CloudNativeLocTemplateType? CloudNativeLocTemplateType = null,
        GcpRegion? Region = null,
        GcpStorageClass? StorageClass = null,
        TargetType? TargetType = null,
        CloudAccount? CloudAccount = null,
        System.String? BucketPrefix = null,
        List<GcpCmk>? CmkInfo = null,
        List<TagObject>? Labels = null
    ) 
    {
        if ( CloudNativeLocTemplateType != null ) {
            this.CloudNativeLocTemplateType = CloudNativeLocTemplateType;
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
        if ( CmkInfo != null ) {
            this.CmkInfo = CmkInfo;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
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
        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> GcpStorageClass? StorageClass
        // GraphQL -> storageClass: GcpStorageClass! (enum)
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
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.CloudAccount, conf.Child("cloudAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccount" + " " + "{\n" + fspec + ind + "}\n";
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
        //      C# -> List<GcpCmk>? CmkInfo
        // GraphQL -> cmkInfo: [GcpCmk!]! (type)
        if (this.CmkInfo != null) {
            var fspec = this.CmkInfo.AsFieldSpec(conf.Child("cmkInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cmkInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TagObject>? Labels
        // GraphQL -> labels: [TagObject!]! (type)
        if (this.Labels != null) {
            var fspec = this.Labels.AsFieldSpec(conf.Child("labels"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "labels" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new GcpRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> GcpStorageClass? StorageClass
        // GraphQL -> storageClass: GcpStorageClass! (enum)
        if (ec.Includes("storageClass",true))
        {
            if(this.StorageClass == null) {

                this.StorageClass = new GcpStorageClass();

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
        //      C# -> List<GcpCmk>? CmkInfo
        // GraphQL -> cmkInfo: [GcpCmk!]! (type)
        if (ec.Includes("cmkInfo",false))
        {
            if(this.CmkInfo == null) {

                this.CmkInfo = new List<GcpCmk>();
                this.CmkInfo.ApplyExploratoryFieldSpec(ec.NewChild("cmkInfo"));

            } else {

                this.CmkInfo.ApplyExploratoryFieldSpec(ec.NewChild("cmkInfo"));

            }
        }
        else if (this.CmkInfo != null && ec.Excludes("cmkInfo",false))
        {
            this.CmkInfo = null;
        }
        //      C# -> List<TagObject>? Labels
        // GraphQL -> labels: [TagObject!]! (type)
        if (ec.Includes("labels",false))
        {
            if(this.Labels == null) {

                this.Labels = new List<TagObject>();
                this.Labels.ApplyExploratoryFieldSpec(ec.NewChild("labels"));

            } else {

                this.Labels.ApplyExploratoryFieldSpec(ec.NewChild("labels"));

            }
        }
        else if (this.Labels != null && ec.Excludes("labels",false))
        {
            this.Labels = null;
        }
    }


    #endregion

    } // class GcpTargetTemplate
    
    #endregion

    public static class ListGcpTargetTemplateExtensions
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
            this List<GcpTargetTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpTargetTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpTargetTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpTargetTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types