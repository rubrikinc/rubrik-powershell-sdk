// FailoverClusterAppSource.cs
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
    #region FailoverClusterAppSource
    public class FailoverClusterAppSource: IFragment
    {
        #region members
        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        [JsonProperty("vips")]
        public List<System.String>? Vips { get; set; }

        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        [JsonProperty("virtualIps")]
        public List<System.String>? VirtualIps { get; set; }

        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        [JsonProperty("nodeOrders")]
        public List<FailoverClusterNodeOrder>? NodeOrders { get; set; }

        #endregion

    #region methods

    public FailoverClusterAppSource Set(
        List<System.String>? Vips = null,
        List<System.String>? VirtualIps = null,
        List<FailoverClusterNodeOrder>? NodeOrders = null
    ) 
    {
        if ( Vips != null ) {
            this.Vips = Vips;
        }
        if ( VirtualIps != null ) {
            this.VirtualIps = VirtualIps;
        }
        if ( NodeOrders != null ) {
            this.NodeOrders = NodeOrders;
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
            //      C# -> List<System.String>? Vips
            // GraphQL -> vips: [String!]! (scalar)
            if (this.Vips != null)
            {
                 s += ind + "vips\n";

            }
            //      C# -> List<System.String>? VirtualIps
            // GraphQL -> virtualIps: [String!]! (scalar)
            if (this.VirtualIps != null)
            {
                 s += ind + "virtualIps\n";

            }
            //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
            // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
            if (this.NodeOrders != null)
            {
                 s += ind + "nodeOrders\n";

                 s += ind + "{\n" + 
                 this.NodeOrders.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Vips
            // GraphQL -> vips: [String!]! (scalar)
            if (this.Vips == null && Exploration.Includes(parent + ".vips$"))
            {
                this.Vips = new List<System.String>();
            }
            //      C# -> List<System.String>? VirtualIps
            // GraphQL -> virtualIps: [String!]! (scalar)
            if (this.VirtualIps == null && Exploration.Includes(parent + ".virtualIps$"))
            {
                this.VirtualIps = new List<System.String>();
            }
            //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
            // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
            if (this.NodeOrders == null && Exploration.Includes(parent + ".nodeOrders"))
            {
                this.NodeOrders = new List<FailoverClusterNodeOrder>();
                this.NodeOrders.ApplyExploratoryFragment(parent + ".nodeOrders");
            }
        }


    #endregion

    } // class FailoverClusterAppSource
    #endregion

    public static class ListFailoverClusterAppSourceExtensions
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
            this List<FailoverClusterAppSource> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FailoverClusterAppSource> list, 
            String parent = "")
        {
            var item = new FailoverClusterAppSource();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types