// ClusterGroupBy.cs
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
    #region ClusterGroupBy
    public class ClusterGroupBy: BaseType
    {
        #region members

        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        [JsonProperty("clusterConnection")]
        public ClusterConnection? ClusterConnection { get; set; }

        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        [JsonProperty("clusterGroupBy")]
        public List<ClusterGroupBy>? ClusterGroupByField { get; set; }

        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ClusterGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterGroupBy";
    }

    public ClusterGroupBy Set(
        ClusterConnection? ClusterConnection = null,
        List<ClusterGroupBy>? ClusterGroupByField = null,
        ClusterGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ClusterConnection != null ) {
            this.ClusterConnection = ClusterConnection;
        }
        if ( ClusterGroupByField != null ) {
            this.ClusterGroupByField = ClusterGroupByField;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        if (this.ClusterConnection != null) {
            var fspec = this.ClusterConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (this.ClusterGroupByField != null) {
            var fspec = this.ClusterGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        if (this.ClusterConnection == null && ec.Includes("clusterConnection",false))
        {
            this.ClusterConnection = new ClusterConnection();
            this.ClusterConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterConnection"));
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (this.ClusterGroupByField == null && ec.Includes("clusterGroupBy",false))
        {
            this.ClusterGroupByField = new List<ClusterGroupBy>();
            this.ClusterGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("clusterGroupBy"));
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<ClusterGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (ClusterGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class ClusterGroupBy
    
    #endregion

    public static class ListClusterGroupByExtensions
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
            this List<ClusterGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ClusterGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types