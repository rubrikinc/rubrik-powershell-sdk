// Db2WorkloadDataSnapshotMetadata.cs
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
    #region Db2WorkloadDataSnapshotMetadata
    public class Db2WorkloadDataSnapshotMetadata: BaseType
    {
        #region members

        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        [JsonProperty("kvSnapshotFileInstancesInfoList")]
        public List<System.String>? KvSnapshotFileInstancesInfoList { get; set; }


        #endregion

    #region methods

    public Db2WorkloadDataSnapshotMetadata Set(
        List<System.String>? KvSnapshotFileInstancesInfoList = null
    ) 
    {
        if ( KvSnapshotFileInstancesInfoList != null ) {
            this.KvSnapshotFileInstancesInfoList = KvSnapshotFileInstancesInfoList;
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
        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        if (this.KvSnapshotFileInstancesInfoList != null) {
            s += ind + "kvSnapshotFileInstancesInfoList\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? KvSnapshotFileInstancesInfoList
        // GraphQL -> kvSnapshotFileInstancesInfoList: [String!]! (scalar)
        if (this.KvSnapshotFileInstancesInfoList == null && Exploration.Includes(parent + ".kvSnapshotFileInstancesInfoList", true))
        {
            this.KvSnapshotFileInstancesInfoList = new List<System.String>();
        }
    }


    #endregion

    } // class Db2WorkloadDataSnapshotMetadata
    
    #endregion

    public static class ListDb2WorkloadDataSnapshotMetadataExtensions
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
            this List<Db2WorkloadDataSnapshotMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2WorkloadDataSnapshotMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2WorkloadDataSnapshotMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types