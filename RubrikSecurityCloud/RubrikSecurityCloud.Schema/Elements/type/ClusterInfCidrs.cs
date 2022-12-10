// ClusterInfCidrs.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
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
    #region ClusterInfCidrs
    public class ClusterInfCidrs: IFragment
    {
        #region members
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        [JsonProperty("interfaceCidr")]
        public List<InterfaceCidr>? InterfaceCidr { get; set; }

        #endregion

    #region methods

    public ClusterInfCidrs Set(
        System.String? ClusterId = null,
        System.String? ClusterName = null,
        List<InterfaceCidr>? InterfaceCidr = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( InterfaceCidr != null ) {
            this.InterfaceCidr = InterfaceCidr;
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
            // GraphQL -> clusterId: String! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName != null)
            {
                 s += ind + "clusterName\n";

            }
            //      C# -> List<InterfaceCidr>? InterfaceCidr
            // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
            if (this.InterfaceCidr != null)
            {
                 s += ind + "interfaceCidr\n";

                 s += ind + "{\n" + 
                 this.InterfaceCidr.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: String! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName$"))
            {
                this.ClusterName = new System.String("FETCH");
            }
            //      C# -> List<InterfaceCidr>? InterfaceCidr
            // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
            if (this.InterfaceCidr == null && Exploration.Includes(parent + ".interfaceCidr"))
            {
                this.InterfaceCidr = new List<InterfaceCidr>();
                this.InterfaceCidr.ApplyExploratoryFragment(parent + ".interfaceCidr");
            }
        }


    #endregion

    } // class ClusterInfCidrs
    #endregion

    public static class ListClusterInfCidrsExtensions
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
            this List<ClusterInfCidrs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterInfCidrs> list, 
            String parent = "")
        {
            var item = new ClusterInfCidrs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types