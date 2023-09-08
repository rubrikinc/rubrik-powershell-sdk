// MissedSnapshotGroupBy.cs
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
    #region MissedSnapshotGroupBy
    public class MissedSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        [JsonProperty("missedSnapshotGroupBy")]
        public List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField { get; set; }

        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MissedSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissedSnapshotGroupBy";
    }

    public MissedSnapshotGroupBy Set(
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField = null,
        MissedSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByField != null ) {
            this.MissedSnapshotGroupByField = MissedSnapshotGroupByField;
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        if (this.MissedSnapshotGroupByField != null) {
            var fspec = this.MissedSnapshotGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        if (this.MissedSnapshotConnection == null && ec.Includes("missedSnapshotConnection",false))
        {
            this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
            this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));
        }
        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        if (this.MissedSnapshotGroupByField == null && ec.Includes("missedSnapshotGroupBy",false))
        {
            this.MissedSnapshotGroupByField = new List<MissedSnapshotGroupBy>();
            this.MissedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupBy"));
        }
        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<MissedSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (MissedSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class MissedSnapshotGroupBy
    
    #endregion

    public static class ListMissedSnapshotGroupByExtensions
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
            this List<MissedSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MissedSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types