// NodeIp.cs
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
    #region NodeIp
    public class NodeIp: BaseType
    {
        #region members

        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        [JsonProperty("node")]
        public System.String? Node { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeIp";
    }

    public NodeIp Set(
        System.String? Ip = null,
        System.String? Node = null
    ) 
    {
        if ( Ip != null ) {
            this.Ip = Ip;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (this.Ip != null) {
            s += ind + "ip\n" ;
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        if (this.Node != null) {
            s += ind + "node\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (this.Ip == null && ec.Includes("ip",true))
        {
            this.Ip = "FETCH";
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        if (this.Node == null && ec.Includes("node",true))
        {
            this.Node = "FETCH";
        }
    }


    #endregion

    } // class NodeIp
    
    #endregion

    public static class ListNodeIpExtensions
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
            this List<NodeIp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NodeIp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeIp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NodeIp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types