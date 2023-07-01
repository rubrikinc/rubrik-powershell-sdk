// FailoverClusterNodeOrder.cs
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
    #region FailoverClusterNodeOrder
    public class FailoverClusterNodeOrder: BaseType
    {
        #region members

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        [JsonProperty("order")]
        public System.Int32? Order { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterNodeOrder";
    }

    public FailoverClusterNodeOrder Set(
        System.String? NodeId = null,
        System.String? NodeName = null,
        System.Int32? Order = null
    ) 
    {
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( Order != null ) {
            this.Order = Order;
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
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName != null) {
            s += ind + "nodeName\n" ;
        }
        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        if (this.Order != null) {
            s += ind + "order\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String (scalar)
        if (this.NodeName == null && Exploration.Includes(parent + ".nodeName", true))
        {
            this.NodeName = "FETCH";
        }
        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        if (this.Order == null && Exploration.Includes(parent + ".order", true))
        {
            this.Order = Int32.MinValue;
        }
    }


    #endregion

    } // class FailoverClusterNodeOrder
    
    #endregion

    public static class ListFailoverClusterNodeOrderExtensions
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
            this List<FailoverClusterNodeOrder> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterNodeOrder> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterNodeOrder());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types