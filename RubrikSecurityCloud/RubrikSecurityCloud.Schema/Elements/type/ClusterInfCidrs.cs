// ClusterInfCidrs.cs
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
    #region ClusterInfCidrs
    public class ClusterInfCidrs: BaseType
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

    public override string GetGqlTypeName() {
        return "ClusterInfCidrs";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        if (this.InterfaceCidr != null) {
            var fspec = this.InterfaceCidr.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "interfaceCidr {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        if (this.InterfaceCidr == null && Exploration.Includes(parent + ".interfaceCidr"))
        {
            this.InterfaceCidr = new List<InterfaceCidr>();
            this.InterfaceCidr.ApplyExploratoryFieldSpec(parent + ".interfaceCidr");
        }
    }


    #endregion

    } // class ClusterInfCidrs
    
    #endregion

    public static class ListClusterInfCidrsExtensions
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
            this List<ClusterInfCidrs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterInfCidrs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterInfCidrs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types