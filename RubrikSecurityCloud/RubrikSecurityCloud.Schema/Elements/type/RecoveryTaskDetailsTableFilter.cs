// RecoveryTaskDetailsTableFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region RecoveryTaskDetailsTableFilter
    public class RecoveryTaskDetailsTableFilter: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<FilterOption>? ClusterLocation
            // GraphQL -> cluster_location: [FilterOption!]! (type)
            if (this.ClusterLocation != null)
            {
                 s += ind + "cluster_location\n";

                 s += ind + "{\n" + 
                 this.ClusterLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? ClusterType
            // GraphQL -> cluster_type: [FilterOption!]! (type)
            if (this.ClusterType != null)
            {
                 s += ind + "cluster_type\n";

                 s += ind + "{\n" + 
                 this.ClusterType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? ObjectType
            // GraphQL -> object_type: [FilterOption!]! (type)
            if (this.ObjectType != null)
            {
                 s += ind + "object_type\n";

                 s += ind + "{\n" + 
                 this.ObjectType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? ReplicationSource
            // GraphQL -> replication_source: [FilterOption!]! (type)
            if (this.ReplicationSource != null)
            {
                 s += ind + "replication_source\n";

                 s += ind + "{\n" + 
                 this.ReplicationSource.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? Status
            // GraphQL -> status: [FilterOption!]! (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? TaskCategory
            // GraphQL -> task_category: [FilterOption!]! (type)
            if (this.TaskCategory != null)
            {
                 s += ind + "task_category\n";

                 s += ind + "{\n" + 
                 this.TaskCategory.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FilterOption>? TaskType
            // GraphQL -> task_type: [FilterOption!]! (type)
            if (this.TaskType != null)
            {
                 s += ind + "task_type\n";

                 s += ind + "{\n" + 
                 this.TaskType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<FilterOption>? ClusterLocation
            // GraphQL -> cluster_location: [FilterOption!]! (type)
            if (this.ClusterLocation == null && Exploration.Includes(parent + ".cluster_location"))
            {
                this.ClusterLocation = new List<FilterOption>();
                this.ClusterLocation.ApplyExploratoryFragment(parent + ".cluster_location");
            }
            //      C# -> List<FilterOption>? ClusterType
            // GraphQL -> cluster_type: [FilterOption!]! (type)
            if (this.ClusterType == null && Exploration.Includes(parent + ".cluster_type"))
            {
                this.ClusterType = new List<FilterOption>();
                this.ClusterType.ApplyExploratoryFragment(parent + ".cluster_type");
            }
            //      C# -> List<FilterOption>? ObjectType
            // GraphQL -> object_type: [FilterOption!]! (type)
            if (this.ObjectType == null && Exploration.Includes(parent + ".object_type"))
            {
                this.ObjectType = new List<FilterOption>();
                this.ObjectType.ApplyExploratoryFragment(parent + ".object_type");
            }
            //      C# -> List<FilterOption>? ReplicationSource
            // GraphQL -> replication_source: [FilterOption!]! (type)
            if (this.ReplicationSource == null && Exploration.Includes(parent + ".replication_source"))
            {
                this.ReplicationSource = new List<FilterOption>();
                this.ReplicationSource.ApplyExploratoryFragment(parent + ".replication_source");
            }
            //      C# -> List<FilterOption>? Status
            // GraphQL -> status: [FilterOption!]! (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new List<FilterOption>();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
            //      C# -> List<FilterOption>? TaskCategory
            // GraphQL -> task_category: [FilterOption!]! (type)
            if (this.TaskCategory == null && Exploration.Includes(parent + ".task_category"))
            {
                this.TaskCategory = new List<FilterOption>();
                this.TaskCategory.ApplyExploratoryFragment(parent + ".task_category");
            }
            //      C# -> List<FilterOption>? TaskType
            // GraphQL -> task_type: [FilterOption!]! (type)
            if (this.TaskType == null && Exploration.Includes(parent + ".task_type"))
            {
                this.TaskType = new List<FilterOption>();
                this.TaskType.ApplyExploratoryFragment(parent + ".task_type");
            }
        }


    #endregion

    } // class RecoveryTaskDetailsTableFilter
    #endregion

    public static class ListRecoveryTaskDetailsTableFilterExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<RecoveryTaskDetailsTableFilter> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RecoveryTaskDetailsTableFilter> list, 
            String parent = "")
        {
            var item = new RecoveryTaskDetailsTableFilter();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types