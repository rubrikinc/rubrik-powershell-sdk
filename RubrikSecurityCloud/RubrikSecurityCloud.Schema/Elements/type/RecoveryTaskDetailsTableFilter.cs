// RecoveryTaskDetailsTableFilter.cs
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
    #region RecoveryTaskDetailsTableFilter
    public class RecoveryTaskDetailsTableFilter: BaseType
    {
        #region members

        //      C# -> List<FilterOption>? ClusterLocation
        // GraphQL -> cluster_location: [FilterOption!]! (type)
        [JsonProperty("cluster_location")]
        public List<FilterOption>? ClusterLocation { get; set; }

        //      C# -> List<FilterOption>? ClusterType
        // GraphQL -> cluster_type: [FilterOption!]! (type)
        [JsonProperty("cluster_type")]
        public List<FilterOption>? ClusterType { get; set; }

        //      C# -> List<FilterOption>? ObjectType
        // GraphQL -> object_type: [FilterOption!]! (type)
        [JsonProperty("object_type")]
        public List<FilterOption>? ObjectType { get; set; }

        //      C# -> List<FilterOption>? ReplicationSource
        // GraphQL -> replication_source: [FilterOption!]! (type)
        [JsonProperty("replication_source")]
        public List<FilterOption>? ReplicationSource { get; set; }

        //      C# -> List<FilterOption>? Status
        // GraphQL -> status: [FilterOption!]! (type)
        [JsonProperty("status")]
        public List<FilterOption>? Status { get; set; }

        //      C# -> List<FilterOption>? TaskCategory
        // GraphQL -> task_category: [FilterOption!]! (type)
        [JsonProperty("task_category")]
        public List<FilterOption>? TaskCategory { get; set; }

        //      C# -> List<FilterOption>? TaskType
        // GraphQL -> task_type: [FilterOption!]! (type)
        [JsonProperty("task_type")]
        public List<FilterOption>? TaskType { get; set; }


        #endregion

    #region methods

    public RecoveryTaskDetailsTableFilter Set(
        List<FilterOption>? ClusterLocation = null,
        List<FilterOption>? ClusterType = null,
        List<FilterOption>? ObjectType = null,
        List<FilterOption>? ReplicationSource = null,
        List<FilterOption>? Status = null,
        List<FilterOption>? TaskCategory = null,
        List<FilterOption>? TaskType = null
    ) 
    {
        if ( ClusterLocation != null ) {
            this.ClusterLocation = ClusterLocation;
        }
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ReplicationSource != null ) {
            this.ReplicationSource = ReplicationSource;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TaskCategory != null ) {
            this.TaskCategory = TaskCategory;
        }
        if ( TaskType != null ) {
            this.TaskType = TaskType;
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
        //      C# -> List<FilterOption>? ClusterLocation
        // GraphQL -> cluster_location: [FilterOption!]! (type)
        if (this.ClusterLocation != null) {
            var fspec = this.ClusterLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster_location {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? ClusterType
        // GraphQL -> cluster_type: [FilterOption!]! (type)
        if (this.ClusterType != null) {
            var fspec = this.ClusterType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster_type {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? ObjectType
        // GraphQL -> object_type: [FilterOption!]! (type)
        if (this.ObjectType != null) {
            var fspec = this.ObjectType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "object_type {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? ReplicationSource
        // GraphQL -> replication_source: [FilterOption!]! (type)
        if (this.ReplicationSource != null) {
            var fspec = this.ReplicationSource.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replication_source {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? Status
        // GraphQL -> status: [FilterOption!]! (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "status {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? TaskCategory
        // GraphQL -> task_category: [FilterOption!]! (type)
        if (this.TaskCategory != null) {
            var fspec = this.TaskCategory.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "task_category {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FilterOption>? TaskType
        // GraphQL -> task_type: [FilterOption!]! (type)
        if (this.TaskType != null) {
            var fspec = this.TaskType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "task_type {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<FilterOption>? ClusterLocation
        // GraphQL -> cluster_location: [FilterOption!]! (type)
        if (this.ClusterLocation == null && Exploration.Includes(parent + ".cluster_location"))
        {
            this.ClusterLocation = new List<FilterOption>();
            this.ClusterLocation.ApplyExploratoryFieldSpec(parent + ".cluster_location");
        }
        //      C# -> List<FilterOption>? ClusterType
        // GraphQL -> cluster_type: [FilterOption!]! (type)
        if (this.ClusterType == null && Exploration.Includes(parent + ".cluster_type"))
        {
            this.ClusterType = new List<FilterOption>();
            this.ClusterType.ApplyExploratoryFieldSpec(parent + ".cluster_type");
        }
        //      C# -> List<FilterOption>? ObjectType
        // GraphQL -> object_type: [FilterOption!]! (type)
        if (this.ObjectType == null && Exploration.Includes(parent + ".object_type"))
        {
            this.ObjectType = new List<FilterOption>();
            this.ObjectType.ApplyExploratoryFieldSpec(parent + ".object_type");
        }
        //      C# -> List<FilterOption>? ReplicationSource
        // GraphQL -> replication_source: [FilterOption!]! (type)
        if (this.ReplicationSource == null && Exploration.Includes(parent + ".replication_source"))
        {
            this.ReplicationSource = new List<FilterOption>();
            this.ReplicationSource.ApplyExploratoryFieldSpec(parent + ".replication_source");
        }
        //      C# -> List<FilterOption>? Status
        // GraphQL -> status: [FilterOption!]! (type)
        if (this.Status == null && Exploration.Includes(parent + ".status"))
        {
            this.Status = new List<FilterOption>();
            this.Status.ApplyExploratoryFieldSpec(parent + ".status");
        }
        //      C# -> List<FilterOption>? TaskCategory
        // GraphQL -> task_category: [FilterOption!]! (type)
        if (this.TaskCategory == null && Exploration.Includes(parent + ".task_category"))
        {
            this.TaskCategory = new List<FilterOption>();
            this.TaskCategory.ApplyExploratoryFieldSpec(parent + ".task_category");
        }
        //      C# -> List<FilterOption>? TaskType
        // GraphQL -> task_type: [FilterOption!]! (type)
        if (this.TaskType == null && Exploration.Includes(parent + ".task_type"))
        {
            this.TaskType = new List<FilterOption>();
            this.TaskType.ApplyExploratoryFieldSpec(parent + ".task_type");
        }
    }


    #endregion

    } // class RecoveryTaskDetailsTableFilter
    
    #endregion

    public static class ListRecoveryTaskDetailsTableFilterExtensions
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
            this List<RecoveryTaskDetailsTableFilter> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryTaskDetailsTableFilter> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryTaskDetailsTableFilter());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types