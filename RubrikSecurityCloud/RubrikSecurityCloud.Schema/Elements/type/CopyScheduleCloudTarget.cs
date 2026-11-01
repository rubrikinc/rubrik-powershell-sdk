// CopyScheduleCloudTarget.cs
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
    #region CopyScheduleCloudTarget
    public class CopyScheduleCloudTarget: BaseType
    {
        #region members

        //      C# -> CopyScheduleCloudProvider? Provider
        // GraphQL -> provider: CopyScheduleCloudProvider! (enum)
        [JsonProperty("provider")]
        public CopyScheduleCloudProvider? Provider { get; set; }

        //      C# -> CopyScheduleStorageTier? Tier
        // GraphQL -> tier: CopyScheduleStorageTier! (enum)
        [JsonProperty("tier")]
        public CopyScheduleStorageTier? Tier { get; set; }

        //      C# -> System.String? AccessKeyId
        // GraphQL -> accessKeyId: String! (scalar)
        [JsonProperty("accessKeyId")]
        public System.String? AccessKeyId { get; set; }

        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        [JsonProperty("dataBucket")]
        public System.String? DataBucket { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CopyScheduleCloudTarget";
    }

    public CopyScheduleCloudTarget Set(
        CopyScheduleCloudProvider? Provider = null,
        CopyScheduleStorageTier? Tier = null,
        System.String? AccessKeyId = null,
        System.String? DataBucket = null,
        System.String? Host = null,
        System.String? Path = null,
        System.String? Region = null,
        System.String? StorageAccountName = null
    ) 
    {
        if ( Provider != null ) {
            this.Provider = Provider;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( AccessKeyId != null ) {
            this.AccessKeyId = AccessKeyId;
        }
        if ( DataBucket != null ) {
            this.DataBucket = DataBucket;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( StorageAccountName != null ) {
            this.StorageAccountName = StorageAccountName;
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
        //      C# -> CopyScheduleCloudProvider? Provider
        // GraphQL -> provider: CopyScheduleCloudProvider! (enum)
        if (this.Provider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provider\n" ;
            } else {
                s += ind + "provider\n" ;
            }
        }
        //      C# -> CopyScheduleStorageTier? Tier
        // GraphQL -> tier: CopyScheduleStorageTier! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> System.String? AccessKeyId
        // GraphQL -> accessKeyId: String! (scalar)
        if (this.AccessKeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessKeyId\n" ;
            } else {
                s += ind + "accessKeyId\n" ;
            }
        }
        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        if (this.DataBucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataBucket\n" ;
            } else {
                s += ind + "dataBucket\n" ;
            }
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            if (conf.Flat) {
                s += conf.Prefix + "host\n" ;
            } else {
                s += ind + "host\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (this.StorageAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountName\n" ;
            } else {
                s += ind + "storageAccountName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CopyScheduleCloudProvider? Provider
        // GraphQL -> provider: CopyScheduleCloudProvider! (enum)
        if (ec.Includes("provider",true))
        {
            if(this.Provider == null) {

                this.Provider = new CopyScheduleCloudProvider();

            } else {


            }
        }
        else if (this.Provider != null && ec.Excludes("provider",true))
        {
            this.Provider = null;
        }
        //      C# -> CopyScheduleStorageTier? Tier
        // GraphQL -> tier: CopyScheduleStorageTier! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new CopyScheduleStorageTier();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> System.String? AccessKeyId
        // GraphQL -> accessKeyId: String! (scalar)
        if (ec.Includes("accessKeyId",true))
        {
            if(this.AccessKeyId == null) {

                this.AccessKeyId = "FETCH";

            } else {


            }
        }
        else if (this.AccessKeyId != null && ec.Excludes("accessKeyId",true))
        {
            this.AccessKeyId = null;
        }
        //      C# -> System.String? DataBucket
        // GraphQL -> dataBucket: String! (scalar)
        if (ec.Includes("dataBucket",true))
        {
            if(this.DataBucket == null) {

                this.DataBucket = "FETCH";

            } else {


            }
        }
        else if (this.DataBucket != null && ec.Excludes("dataBucket",true))
        {
            this.DataBucket = null;
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (ec.Includes("host",true))
        {
            if(this.Host == null) {

                this.Host = "FETCH";

            } else {


            }
        }
        else if (this.Host != null && ec.Excludes("host",true))
        {
            this.Host = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (ec.Includes("storageAccountName",true))
        {
            if(this.StorageAccountName == null) {

                this.StorageAccountName = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountName != null && ec.Excludes("storageAccountName",true))
        {
            this.StorageAccountName = null;
        }
    }


    #endregion

    } // class CopyScheduleCloudTarget
    
    #endregion

    public static class ListCopyScheduleCloudTargetExtensions
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
            this List<CopyScheduleCloudTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CopyScheduleCloudTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CopyScheduleCloudTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CopyScheduleCloudTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CopyScheduleCloudTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types