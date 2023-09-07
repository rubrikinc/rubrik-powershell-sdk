// OracleNodeOrder.cs
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
    #region OracleNodeOrder
    public class OracleNodeOrder: BaseType
    {
        #region members

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        [JsonProperty("order")]
        public System.Int32? Order { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleNodeOrder";
    }

    public OracleNodeOrder Set(
        System.String? NodeName = null,
        System.Int32? Order = null
    ) 
    {
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
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName == null && ec.Includes("nodeName",true))
        {
            this.NodeName = "FETCH";
        }
        //      C# -> System.Int32? Order
        // GraphQL -> order: Int! (scalar)
        if (this.Order == null && ec.Includes("order",true))
        {
            this.Order = Int32.MinValue;
        }
    }


    #endregion

    } // class OracleNodeOrder
    
    #endregion

    public static class ListOracleNodeOrderExtensions
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
            this List<OracleNodeOrder> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleNodeOrder> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleNodeOrder());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<OracleNodeOrder> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types