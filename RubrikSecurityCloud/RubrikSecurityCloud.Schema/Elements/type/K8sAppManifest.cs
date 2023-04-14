// K8sAppManifest.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region K8sAppManifest
    public class K8sAppManifest: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> AppManifestInfo? ToApply
        // GraphQL -> toApply: AppManifestInfo (type)
        [JsonProperty("toApply")]
        public AppManifestInfo? ToApply { get; set; }

        //      C# -> AppManifestInfo? ToDelete
        // GraphQL -> toDelete: AppManifestInfo (type)
        [JsonProperty("toDelete")]
        public AppManifestInfo? ToDelete { get; set; }

        #endregion

    #region methods

    public K8sAppManifest Set(
        System.Boolean? IsSuccessful = null,
        System.String? Version = null,
        AppManifestInfo? ToApply = null,
        AppManifestInfo? ToDelete = null
    ) 
    {
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ToApply != null ) {
            this.ToApply = ToApply;
        }
        if ( ToDelete != null ) {
            this.ToDelete = ToDelete;
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
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful != null)
            {
                 s += ind + "isSuccessful\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> AppManifestInfo? ToApply
            // GraphQL -> toApply: AppManifestInfo (type)
            if (this.ToApply != null)
            {
                 s += ind + "toApply\n";

                 s += ind + "{\n" + 
                 this.ToApply.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AppManifestInfo? ToDelete
            // GraphQL -> toDelete: AppManifestInfo (type)
            if (this.ToDelete != null)
            {
                 s += ind + "toDelete\n";

                 s += ind + "{\n" + 
                 this.ToDelete.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful$"))
            {
                this.IsSuccessful = new System.Boolean();
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> AppManifestInfo? ToApply
            // GraphQL -> toApply: AppManifestInfo (type)
            if (this.ToApply == null && Exploration.Includes(parent + ".toApply"))
            {
                this.ToApply = new AppManifestInfo();
                this.ToApply.ApplyExploratoryFragment(parent + ".toApply");
            }
            //      C# -> AppManifestInfo? ToDelete
            // GraphQL -> toDelete: AppManifestInfo (type)
            if (this.ToDelete == null && Exploration.Includes(parent + ".toDelete"))
            {
                this.ToDelete = new AppManifestInfo();
                this.ToDelete.ApplyExploratoryFragment(parent + ".toDelete");
            }
        }


    #endregion

    } // class K8sAppManifest
    #endregion

    public static class ListK8sAppManifestExtensions
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
            this List<K8sAppManifest> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<K8sAppManifest> list, 
            String parent = "")
        {
            var item = new K8sAppManifest();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types