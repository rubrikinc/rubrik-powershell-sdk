// ManagedVolumeQueuedSnapshotGroupBy.cs
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
    #region ManagedVolumeQueuedSnapshotGroupBy
    public class ManagedVolumeQueuedSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        [JsonProperty("managedVolumeQueuedSnapshotConnection")]
        public ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection { get; set; }

        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        [JsonProperty("managedVolumeQueuedSnapshotGroupBy")]
        public List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeQueuedSnapshotGroupBy";
    }

    public ManagedVolumeQueuedSnapshotGroupBy Set(
        ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection = null,
        List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField = null,
        ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ManagedVolumeQueuedSnapshotConnection != null ) {
            this.ManagedVolumeQueuedSnapshotConnection = ManagedVolumeQueuedSnapshotConnection;
        }
        if ( ManagedVolumeQueuedSnapshotGroupByField != null ) {
            this.ManagedVolumeQueuedSnapshotGroupByField = ManagedVolumeQueuedSnapshotGroupByField;
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (this.ManagedVolumeQueuedSnapshotConnection != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumeQueuedSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumeQueuedSnapshotGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (this.ManagedVolumeQueuedSnapshotConnection == null && ec.Includes("managedVolumeQueuedSnapshotConnection",false))
        {
            this.ManagedVolumeQueuedSnapshotConnection = new ManagedVolumeQueuedSnapshotConnection();
            this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotConnection"));
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField == null && ec.Includes("managedVolumeQueuedSnapshotGroupBy",false))
        {
            this.ManagedVolumeQueuedSnapshotGroupByField = new List<ManagedVolumeQueuedSnapshotGroupBy>();
            this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotGroupBy"));
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<ManagedVolumeQueuedSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (ManagedVolumeQueuedSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class ManagedVolumeQueuedSnapshotGroupBy
    
    #endregion

    public static class ListManagedVolumeQueuedSnapshotGroupByExtensions
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
            this List<ManagedVolumeQueuedSnapshotGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeQueuedSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeQueuedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ManagedVolumeQueuedSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types