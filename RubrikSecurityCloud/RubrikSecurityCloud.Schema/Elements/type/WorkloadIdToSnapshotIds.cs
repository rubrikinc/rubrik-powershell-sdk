// WorkloadIdToSnapshotIds.cs
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
    #region WorkloadIdToSnapshotIds
    public class WorkloadIdToSnapshotIds: BaseType
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        [JsonProperty("snapshotIds")]
        public List<System.String>? SnapshotIds { get; set; }

        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        [JsonProperty("snapshotTimestamps")]
        public List<DateTime>? SnapshotTimestamps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadIdToSnapshotIds";
    }

    public WorkloadIdToSnapshotIds Set(
        System.String? ObjectId = null,
        List<System.String>? SnapshotIds = null,
        List<DateTime>? SnapshotTimestamps = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotIds != null ) {
            this.SnapshotIds = SnapshotIds;
        }
        if ( SnapshotTimestamps != null ) {
            this.SnapshotTimestamps = SnapshotTimestamps;
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
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds != null) {
            s += ind + "snapshotIds\n" ;
        }
        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        if (this.SnapshotTimestamps != null) {
            s += ind + "snapshotTimestamps\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        if (this.SnapshotIds == null && Exploration.Includes(parent + ".snapshotIds", true))
        {
            this.SnapshotIds = new List<System.String>();
        }
        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        if (this.SnapshotTimestamps == null && Exploration.Includes(parent + ".snapshotTimestamps", true))
        {
            this.SnapshotTimestamps = new List<DateTime>();
        }
    }


    #endregion

    } // class WorkloadIdToSnapshotIds
    
    #endregion

    public static class ListWorkloadIdToSnapshotIdsExtensions
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
            this List<WorkloadIdToSnapshotIds> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadIdToSnapshotIds> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadIdToSnapshotIds());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types