// FailoverClusterDetail.cs
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
    #region FailoverClusterDetail
    public class FailoverClusterDetail: BaseType
    {
        #region members

        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        [JsonProperty("numApps")]
        public System.Int32? NumApps { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        [JsonProperty("failoverClusterSummary")]
        public FailoverClusterSummary? FailoverClusterSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterDetail";
    }

    public FailoverClusterDetail Set(
        System.Int32? NumApps = null,
        System.Int32? NumNodes = null,
        FailoverClusterSummary? FailoverClusterSummary = null
    ) 
    {
        if ( NumApps != null ) {
            this.NumApps = NumApps;
        }
        if ( NumNodes != null ) {
            this.NumNodes = NumNodes;
        }
        if ( FailoverClusterSummary != null ) {
            this.FailoverClusterSummary = FailoverClusterSummary;
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
        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        if (this.NumApps != null) {
            s += ind + "numApps\n" ;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes != null) {
            s += ind + "numNodes\n" ;
        }
        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        if (this.FailoverClusterSummary != null) {
            var fspec = this.FailoverClusterSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverClusterSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        if (this.NumApps == null && ec.Includes("numApps",true))
        {
            this.NumApps = Int32.MinValue;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes == null && ec.Includes("numNodes",true))
        {
            this.NumNodes = Int32.MinValue;
        }
        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        if (this.FailoverClusterSummary == null && ec.Includes("failoverClusterSummary",false))
        {
            this.FailoverClusterSummary = new FailoverClusterSummary();
            this.FailoverClusterSummary.ApplyExploratoryFieldSpec(ec.NewChild("failoverClusterSummary"));
        }
    }


    #endregion

    } // class FailoverClusterDetail
    
    #endregion

    public static class ListFailoverClusterDetailExtensions
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
            this List<FailoverClusterDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FailoverClusterDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types