// AppManifestInfo.cs
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
    #region AppManifestInfo
    public class AppManifestInfo: BaseType
    {
        #region members

        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        [JsonProperty("manifestContentType")]
        public K8sContentType? ManifestContentType { get; set; }

        //      C# -> System.String? Manifest
        // GraphQL -> manifest: String! (scalar)
        [JsonProperty("manifest")]
        public System.String? Manifest { get; set; }

        //      C# -> System.String? ShaAlgorithm
        // GraphQL -> shaAlgorithm: String! (scalar)
        [JsonProperty("shaAlgorithm")]
        public System.String? ShaAlgorithm { get; set; }

        //      C# -> System.String? ShaChecksum
        // GraphQL -> shaChecksum: String! (scalar)
        [JsonProperty("shaChecksum")]
        public System.String? ShaChecksum { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppManifestInfo";
    }

    public AppManifestInfo Set(
        K8sContentType? ManifestContentType = null,
        System.String? Manifest = null,
        System.String? ShaAlgorithm = null,
        System.String? ShaChecksum = null
    ) 
    {
        if ( ManifestContentType != null ) {
            this.ManifestContentType = ManifestContentType;
        }
        if ( Manifest != null ) {
            this.Manifest = Manifest;
        }
        if ( ShaAlgorithm != null ) {
            this.ShaAlgorithm = ShaAlgorithm;
        }
        if ( ShaChecksum != null ) {
            this.ShaChecksum = ShaChecksum;
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
        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        if (this.ManifestContentType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "manifestContentType\n" ;
            } else {
                s += ind + "manifestContentType\n" ;
            }
        }
        //      C# -> System.String? Manifest
        // GraphQL -> manifest: String! (scalar)
        if (this.Manifest != null) {
            if (conf.Flat) {
                s += conf.Prefix + "manifest\n" ;
            } else {
                s += ind + "manifest\n" ;
            }
        }
        //      C# -> System.String? ShaAlgorithm
        // GraphQL -> shaAlgorithm: String! (scalar)
        if (this.ShaAlgorithm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shaAlgorithm\n" ;
            } else {
                s += ind + "shaAlgorithm\n" ;
            }
        }
        //      C# -> System.String? ShaChecksum
        // GraphQL -> shaChecksum: String! (scalar)
        if (this.ShaChecksum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shaChecksum\n" ;
            } else {
                s += ind + "shaChecksum\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        if (ec.Includes("manifestContentType",true))
        {
            if(this.ManifestContentType == null) {

                this.ManifestContentType = new K8sContentType();

            } else {


            }
        }
        else if (this.ManifestContentType != null && ec.Excludes("manifestContentType",true))
        {
            this.ManifestContentType = null;
        }
        //      C# -> System.String? Manifest
        // GraphQL -> manifest: String! (scalar)
        if (ec.Includes("manifest",true))
        {
            if(this.Manifest == null) {

                this.Manifest = "FETCH";

            } else {


            }
        }
        else if (this.Manifest != null && ec.Excludes("manifest",true))
        {
            this.Manifest = null;
        }
        //      C# -> System.String? ShaAlgorithm
        // GraphQL -> shaAlgorithm: String! (scalar)
        if (ec.Includes("shaAlgorithm",true))
        {
            if(this.ShaAlgorithm == null) {

                this.ShaAlgorithm = "FETCH";

            } else {


            }
        }
        else if (this.ShaAlgorithm != null && ec.Excludes("shaAlgorithm",true))
        {
            this.ShaAlgorithm = null;
        }
        //      C# -> System.String? ShaChecksum
        // GraphQL -> shaChecksum: String! (scalar)
        if (ec.Includes("shaChecksum",true))
        {
            if(this.ShaChecksum == null) {

                this.ShaChecksum = "FETCH";

            } else {


            }
        }
        else if (this.ShaChecksum != null && ec.Excludes("shaChecksum",true))
        {
            this.ShaChecksum = null;
        }
    }


    #endregion

    } // class AppManifestInfo
    
    #endregion

    public static class ListAppManifestInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AppManifestInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppManifestInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppManifestInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppManifestInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppManifestInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types