// K8sAgentManifestInfo.cs
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
    #region K8sAgentManifestInfo
    public class K8sAgentManifestInfo: IFragment
    {
        #region members
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? SignedUrl
        // GraphQL -> signedUrl: String! (scalar)
        [JsonProperty("signedUrl")]
        public System.String? SignedUrl { get; set; }

        #endregion

    #region methods

    public K8sAgentManifestInfo Set(
        System.String? ClusterId = null,
        System.String? SignedUrl = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( SignedUrl != null ) {
            this.SignedUrl = SignedUrl;
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
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? SignedUrl
            // GraphQL -> signedUrl: String! (scalar)
            if (this.SignedUrl != null)
            {
                 s += ind + "signedUrl\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? SignedUrl
            // GraphQL -> signedUrl: String! (scalar)
            if (this.SignedUrl == null && Exploration.Includes(parent + ".signedUrl$"))
            {
                this.SignedUrl = new System.String("FETCH");
            }
        }


    #endregion

    } // class K8sAgentManifestInfo
    #endregion

    public static class ListK8sAgentManifestInfoExtensions
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
            this List<K8sAgentManifestInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<K8sAgentManifestInfo> list, 
            String parent = "")
        {
            var item = new K8sAgentManifestInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types