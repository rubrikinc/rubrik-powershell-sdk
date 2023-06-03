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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "managedVolumeQueuedSnapshotConnection {\n" + this.ManagedVolumeQueuedSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField != null) {
            s += ind + "managedVolumeQueuedSnapshotGroupBy {\n" + this.ManagedVolumeQueuedSnapshotGroupByField.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (this.ManagedVolumeQueuedSnapshotConnection == null && Exploration.Includes(parent + ".managedVolumeQueuedSnapshotConnection"))
        {
            this.ManagedVolumeQueuedSnapshotConnection = new ManagedVolumeQueuedSnapshotConnection();
            this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".managedVolumeQueuedSnapshotConnection");
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField == null && Exploration.Includes(parent + ".managedVolumeQueuedSnapshotGroupBy"))
        {
            this.ManagedVolumeQueuedSnapshotGroupByField = new List<ManagedVolumeQueuedSnapshotGroupBy>();
            this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(parent + ".managedVolumeQueuedSnapshotGroupBy");
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<ManagedVolumeQueuedSnapshotGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeQueuedSnapshotGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeQueuedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types