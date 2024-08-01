// PcrConfig.cs
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
    #region PcrConfig
    public class PcrConfig: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        [JsonProperty("hasPcr")]
        public System.Boolean? HasPcr { get; set; }

        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String! (scalar)
        [JsonProperty("pcrImagePullAwsNativeId")]
        public System.String? PcrImagePullAwsNativeId { get; set; }

        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
        [JsonProperty("pcrLatestApprovedBundleVersion")]
        public System.String? PcrLatestApprovedBundleVersion { get; set; }

        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        [JsonProperty("pcrUrl")]
        public System.String? PcrUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PcrConfig";
    }

    public PcrConfig Set(
        System.Boolean? HasPcr = null,
        System.String? PcrImagePullAwsNativeId = null,
        System.String? PcrLatestApprovedBundleVersion = null,
        System.String? PcrUrl = null
    ) 
    {
        if ( HasPcr != null ) {
            this.HasPcr = HasPcr;
        }
        if ( PcrImagePullAwsNativeId != null ) {
            this.PcrImagePullAwsNativeId = PcrImagePullAwsNativeId;
        }
        if ( PcrLatestApprovedBundleVersion != null ) {
            this.PcrLatestApprovedBundleVersion = PcrLatestApprovedBundleVersion;
        }
        if ( PcrUrl != null ) {
            this.PcrUrl = PcrUrl;
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
        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        if (this.HasPcr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPcr\n" ;
            } else {
                s += ind + "hasPcr\n" ;
            }
        }
        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String! (scalar)
        if (this.PcrImagePullAwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrImagePullAwsNativeId\n" ;
            } else {
                s += ind + "pcrImagePullAwsNativeId\n" ;
            }
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
        if (this.PcrLatestApprovedBundleVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrLatestApprovedBundleVersion\n" ;
            } else {
                s += ind + "pcrLatestApprovedBundleVersion\n" ;
            }
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        if (this.PcrUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pcrUrl\n" ;
            } else {
                s += ind + "pcrUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasPcr
        // GraphQL -> hasPcr: Boolean! (scalar)
        if (ec.Includes("hasPcr",true))
        {
            if(this.HasPcr == null) {

                this.HasPcr = true;

            } else {


            }
        }
        else if (this.HasPcr != null && ec.Excludes("hasPcr",true))
        {
            this.HasPcr = null;
        }
        //      C# -> System.String? PcrImagePullAwsNativeId
        // GraphQL -> pcrImagePullAwsNativeId: String! (scalar)
        if (ec.Includes("pcrImagePullAwsNativeId",true))
        {
            if(this.PcrImagePullAwsNativeId == null) {

                this.PcrImagePullAwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.PcrImagePullAwsNativeId != null && ec.Excludes("pcrImagePullAwsNativeId",true))
        {
            this.PcrImagePullAwsNativeId = null;
        }
        //      C# -> System.String? PcrLatestApprovedBundleVersion
        // GraphQL -> pcrLatestApprovedBundleVersion: String! (scalar)
        if (ec.Includes("pcrLatestApprovedBundleVersion",true))
        {
            if(this.PcrLatestApprovedBundleVersion == null) {

                this.PcrLatestApprovedBundleVersion = "FETCH";

            } else {


            }
        }
        else if (this.PcrLatestApprovedBundleVersion != null && ec.Excludes("pcrLatestApprovedBundleVersion",true))
        {
            this.PcrLatestApprovedBundleVersion = null;
        }
        //      C# -> System.String? PcrUrl
        // GraphQL -> pcrUrl: String! (scalar)
        if (ec.Includes("pcrUrl",true))
        {
            if(this.PcrUrl == null) {

                this.PcrUrl = "FETCH";

            } else {


            }
        }
        else if (this.PcrUrl != null && ec.Excludes("pcrUrl",true))
        {
            this.PcrUrl = null;
        }
    }


    #endregion

    } // class PcrConfig
    
    #endregion

    public static class ListPcrConfigExtensions
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
            this List<PcrConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PcrConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PcrConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PcrConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PcrConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types