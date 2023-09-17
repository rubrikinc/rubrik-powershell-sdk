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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        if (this.ManifestContentType != null) {
            s += ind + "manifestContentType\n" ;
        }
        //      C# -> System.String? Manifest
        // GraphQL -> manifest: String! (scalar)
        if (this.Manifest != null) {
            s += ind + "manifest\n" ;
        }
        //      C# -> System.String? ShaAlgorithm
        // GraphQL -> shaAlgorithm: String! (scalar)
        if (this.ShaAlgorithm != null) {
            s += ind + "shaAlgorithm\n" ;
        }
        //      C# -> System.String? ShaChecksum
        // GraphQL -> shaChecksum: String! (scalar)
        if (this.ShaChecksum != null) {
            s += ind + "shaChecksum\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        if (this.ManifestContentType == null && ec.Includes("manifestContentType",true))
        {
            this.ManifestContentType = new K8sContentType();
        }
        //      C# -> System.String? Manifest
        // GraphQL -> manifest: String! (scalar)
        if (this.Manifest == null && ec.Includes("manifest",true))
        {
            this.Manifest = "FETCH";
        }
        //      C# -> System.String? ShaAlgorithm
        // GraphQL -> shaAlgorithm: String! (scalar)
        if (this.ShaAlgorithm == null && ec.Includes("shaAlgorithm",true))
        {
            this.ShaAlgorithm = "FETCH";
        }
        //      C# -> System.String? ShaChecksum
        // GraphQL -> shaChecksum: String! (scalar)
        if (this.ShaChecksum == null && ec.Includes("shaChecksum",true))
        {
            this.ShaChecksum = "FETCH";
        }
    }


    #endregion

    } // class AppManifestInfo
    
    #endregion

    public static class ListAppManifestInfoExtensions
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
            this List<AppManifestInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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