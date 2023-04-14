// MongoDatabasePhysicalChildTypeConnection.cs
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
    #region MongoDatabasePhysicalChildTypeConnection
    public class MongoDatabasePhysicalChildTypeConnection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
        // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<MongoDatabasePhysicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
        // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<MongoDatabasePhysicalChildType>? Nodes { get; set; }

        #endregion

    #region methods

    public MongoDatabasePhysicalChildTypeConnection Set(
        System.Int32? Count = null,
        List<MongoDatabasePhysicalChildTypeEdge>? Edges = null,
        PageInfo? PageInfo = null,
        List<MongoDatabasePhysicalChildType>? Nodes = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
            // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
            // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
            if (this.Nodes != null)
            {
                s += ind + "nodes\n";
                s += ind + "{\n";

                s += this.Nodes.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> List<MongoDatabasePhysicalChildTypeEdge>? Edges
            // GraphQL -> edges: [MongoDatabasePhysicalChildTypeEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<MongoDatabasePhysicalChildTypeEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> List<MongoDatabasePhysicalChildType>? Nodes
            // GraphQL -> nodes: [MongoDatabasePhysicalChildType!]! (interface)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<MongoDatabasePhysicalChildType>();
                this.Nodes.ApplyExploratoryFragment(parent + ".nodes");
            }
        }


    #endregion

    } // class MongoDatabasePhysicalChildTypeConnection
    #endregion

    public static class ListMongoDatabasePhysicalChildTypeConnectionExtensions
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
            this List<MongoDatabasePhysicalChildTypeConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MongoDatabasePhysicalChildTypeConnection> list, 
            String parent = "")
        {
            var item = new MongoDatabasePhysicalChildTypeConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types