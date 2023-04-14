// ClusterVisibilityConfig.cs
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
    #region ClusterVisibilityConfig
    public class ClusterVisibilityConfig: IFragment
    {
        #region members
        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        [JsonProperty("hostGroupFilter")]
        public List<System.String>? HostGroupFilter { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        [JsonProperty("isVmwareMetroStorageCluster")]
        public System.Boolean? IsVmwareMetroStorageCluster { get; set; }

        #endregion

    #region methods

    public ClusterVisibilityConfig Set(
        List<System.String>? HostGroupFilter = null,
        System.String? Id = null,
        System.Boolean? IsVmwareMetroStorageCluster = null
    ) 
    {
        if ( HostGroupFilter != null ) {
            this.HostGroupFilter = HostGroupFilter;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVmwareMetroStorageCluster != null ) {
            this.IsVmwareMetroStorageCluster = IsVmwareMetroStorageCluster;
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
            //      C# -> List<System.String>? HostGroupFilter
            // GraphQL -> hostGroupFilter: [String!]! (scalar)
            if (this.HostGroupFilter != null)
            {
                 s += ind + "hostGroupFilter\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsVmwareMetroStorageCluster
            // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
            if (this.IsVmwareMetroStorageCluster != null)
            {
                 s += ind + "isVmwareMetroStorageCluster\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? HostGroupFilter
            // GraphQL -> hostGroupFilter: [String!]! (scalar)
            if (this.HostGroupFilter == null && Exploration.Includes(parent + ".hostGroupFilter$"))
            {
                this.HostGroupFilter = new List<System.String>();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsVmwareMetroStorageCluster
            // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
            if (this.IsVmwareMetroStorageCluster == null && Exploration.Includes(parent + ".isVmwareMetroStorageCluster$"))
            {
                this.IsVmwareMetroStorageCluster = new System.Boolean();
            }
        }


    #endregion

    } // class ClusterVisibilityConfig
    #endregion

    public static class ListClusterVisibilityConfigExtensions
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
            this List<ClusterVisibilityConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterVisibilityConfig> list, 
            String parent = "")
        {
            var item = new ClusterVisibilityConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types