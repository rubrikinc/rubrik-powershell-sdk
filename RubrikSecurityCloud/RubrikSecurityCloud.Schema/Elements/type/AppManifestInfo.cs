// AppManifestInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:38.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region AppManifestInfo
    public class AppManifestInfo: IFragment
    {
        #region members
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

        //      C# -> K8sContentType? ManifestContentType
        // GraphQL -> manifestContentType: K8sContentType! (enum)
        [JsonProperty("manifestContentType")]
        public K8sContentType? ManifestContentType { get; set; }

        #endregion

    #region methods

    public AppManifestInfo Set(
        System.String? Manifest = null,
        System.String? ShaAlgorithm = null,
        System.String? ShaChecksum = null,
        K8sContentType? ManifestContentType = null
    ) 
    {
        if ( Manifest != null ) {
            this.Manifest = Manifest;
        }
        if ( ShaAlgorithm != null ) {
            this.ShaAlgorithm = ShaAlgorithm;
        }
        if ( ShaChecksum != null ) {
            this.ShaChecksum = ShaChecksum;
        }
        if ( ManifestContentType != null ) {
            this.ManifestContentType = ManifestContentType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Manifest
            // GraphQL -> manifest: String! (scalar)
            if (this.Manifest != null)
            {
                 s += ind + "manifest\n";

            }
            //      C# -> System.String? ShaAlgorithm
            // GraphQL -> shaAlgorithm: String! (scalar)
            if (this.ShaAlgorithm != null)
            {
                 s += ind + "shaAlgorithm\n";

            }
            //      C# -> System.String? ShaChecksum
            // GraphQL -> shaChecksum: String! (scalar)
            if (this.ShaChecksum != null)
            {
                 s += ind + "shaChecksum\n";

            }
            //      C# -> K8sContentType? ManifestContentType
            // GraphQL -> manifestContentType: K8sContentType! (enum)
            if (this.ManifestContentType != null)
            {
                 s += ind + "manifestContentType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Manifest
            // GraphQL -> manifest: String! (scalar)
            if (this.Manifest == null && Exploration.Includes(parent + ".manifest$"))
            {
                this.Manifest = new System.String("FETCH");
            }
            //      C# -> System.String? ShaAlgorithm
            // GraphQL -> shaAlgorithm: String! (scalar)
            if (this.ShaAlgorithm == null && Exploration.Includes(parent + ".shaAlgorithm$"))
            {
                this.ShaAlgorithm = new System.String("FETCH");
            }
            //      C# -> System.String? ShaChecksum
            // GraphQL -> shaChecksum: String! (scalar)
            if (this.ShaChecksum == null && Exploration.Includes(parent + ".shaChecksum$"))
            {
                this.ShaChecksum = new System.String("FETCH");
            }
            //      C# -> K8sContentType? ManifestContentType
            // GraphQL -> manifestContentType: K8sContentType! (enum)
            if (this.ManifestContentType == null && Exploration.Includes(parent + ".manifestContentType$"))
            {
                this.ManifestContentType = new K8sContentType();
            }
        }


    #endregion

    } // class AppManifestInfo
    #endregion

    public static class ListAppManifestInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AppManifestInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AppManifestInfo> list, 
            String parent = "")
        {
            var item = new AppManifestInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types