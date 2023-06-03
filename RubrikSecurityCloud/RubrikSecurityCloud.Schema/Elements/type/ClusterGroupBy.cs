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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "clusterConnection {\n" + this.ClusterConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (this.ClusterGroupByField != null) {
            s += ind + "clusterGroupBy {\n" + this.ClusterGroupByField.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        if (this.ClusterConnection == null && Exploration.Includes(parent + ".clusterConnection"))
        {
            this.ClusterConnection = new ClusterConnection();
            this.ClusterConnection.ApplyExploratoryFieldSpec(parent + ".clusterConnection");
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (this.ClusterGroupByField == null && Exploration.Includes(parent + ".clusterGroupBy"))
        {
            this.ClusterGroupByField = new List<ClusterGroupBy>();
            this.ClusterGroupByField.ApplyExploratoryFieldSpec(parent + ".clusterGroupBy");
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<ClusterGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types