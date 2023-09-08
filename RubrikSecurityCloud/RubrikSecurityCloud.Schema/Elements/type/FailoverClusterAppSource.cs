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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region FailoverClusterAppSource
    public class FailoverClusterAppSource: BaseType
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

    public override string GetGqlTypeName() {
        return "FailoverClusterAppSource";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        if (this.Vips != null) {
            s += ind + "vips\n" ;
        }
        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        if (this.VirtualIps != null) {
            s += ind + "virtualIps\n" ;
        }
        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        if (this.NodeOrders != null) {
            var fspec = this.NodeOrders.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodeOrders {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        if (this.Vips == null && ec.Includes("vips",true))
        {
            this.Vips = new List<System.String>();
        }
        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        if (this.VirtualIps == null && ec.Includes("virtualIps",true))
        {
            this.VirtualIps = new List<System.String>();
        }
        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        if (this.NodeOrders == null && ec.Includes("nodeOrders",false))
        {
            this.NodeOrders = new List<FailoverClusterNodeOrder>();
            this.NodeOrders.ApplyExploratoryFieldSpec(ec.NewChild("nodeOrders"));
        }
    }


    #endregion

    } // class FailoverClusterAppSource
    
    #endregion

    public static class ListFailoverClusterAppSourceExtensions
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
            this List<FailoverClusterAppSource> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterAppSource> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterAppSource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FailoverClusterAppSource> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types