// ProtectionTaskDetailsTableFilter.cs
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
    #region ProtectionTaskDetailsTableFilter
    public class ProtectionTaskDetailsTableFilter: BaseType
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

    public override string GetGqlTypeName() {
        return "ProtectionTaskDetailsTableFilter";
    }

    public ProtectionTaskDetailsTableFilter Set(
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<FilterOption>? ClusterLocation
        // GraphQL -> cluster_location: [FilterOption!]! (type)
        if (this.ClusterLocation != null) {
            var fspec = this.ClusterLocation.AsFieldSpec(conf.Child("cluster_location"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster_location {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? ClusterType
        // GraphQL -> cluster_type: [FilterOption!]! (type)
        if (this.ClusterType != null) {
            var fspec = this.ClusterType.AsFieldSpec(conf.Child("cluster_type"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster_type {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? ObjectType
        // GraphQL -> object_type: [FilterOption!]! (type)
        if (this.ObjectType != null) {
            var fspec = this.ObjectType.AsFieldSpec(conf.Child("object_type"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "object_type {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? ReplicationSource
        // GraphQL -> replication_source: [FilterOption!]! (type)
        if (this.ReplicationSource != null) {
            var fspec = this.ReplicationSource.AsFieldSpec(conf.Child("replication_source"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replication_source {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? Status
        // GraphQL -> status: [FilterOption!]! (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? TaskCategory
        // GraphQL -> task_category: [FilterOption!]! (type)
        if (this.TaskCategory != null) {
            var fspec = this.TaskCategory.AsFieldSpec(conf.Child("task_category"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "task_category {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterOption>? TaskType
        // GraphQL -> task_type: [FilterOption!]! (type)
        if (this.TaskType != null) {
            var fspec = this.TaskType.AsFieldSpec(conf.Child("task_type"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "task_type {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<FilterOption>? ClusterLocation
        // GraphQL -> cluster_location: [FilterOption!]! (type)
        if (ec.Includes("cluster_location",false))
        {
            if(this.ClusterLocation == null) {

                this.ClusterLocation = new List<FilterOption>();
                this.ClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("cluster_location"));

            } else {

                this.ClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("cluster_location"));

            }
        }
        else if (this.ClusterLocation != null && ec.Excludes("cluster_location",false))
        {
            this.ClusterLocation = null;
        }
        //      C# -> List<FilterOption>? ClusterType
        // GraphQL -> cluster_type: [FilterOption!]! (type)
        if (ec.Includes("cluster_type",false))
        {
            if(this.ClusterType == null) {

                this.ClusterType = new List<FilterOption>();
                this.ClusterType.ApplyExploratoryFieldSpec(ec.NewChild("cluster_type"));

            } else {

                this.ClusterType.ApplyExploratoryFieldSpec(ec.NewChild("cluster_type"));

            }
        }
        else if (this.ClusterType != null && ec.Excludes("cluster_type",false))
        {
            this.ClusterType = null;
        }
        //      C# -> List<FilterOption>? ObjectType
        // GraphQL -> object_type: [FilterOption!]! (type)
        if (ec.Includes("object_type",false))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new List<FilterOption>();
                this.ObjectType.ApplyExploratoryFieldSpec(ec.NewChild("object_type"));

            } else {

                this.ObjectType.ApplyExploratoryFieldSpec(ec.NewChild("object_type"));

            }
        }
        else if (this.ObjectType != null && ec.Excludes("object_type",false))
        {
            this.ObjectType = null;
        }
        //      C# -> List<FilterOption>? ReplicationSource
        // GraphQL -> replication_source: [FilterOption!]! (type)
        if (ec.Includes("replication_source",false))
        {
            if(this.ReplicationSource == null) {

                this.ReplicationSource = new List<FilterOption>();
                this.ReplicationSource.ApplyExploratoryFieldSpec(ec.NewChild("replication_source"));

            } else {

                this.ReplicationSource.ApplyExploratoryFieldSpec(ec.NewChild("replication_source"));

            }
        }
        else if (this.ReplicationSource != null && ec.Excludes("replication_source",false))
        {
            this.ReplicationSource = null;
        }
        //      C# -> List<FilterOption>? Status
        // GraphQL -> status: [FilterOption!]! (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new List<FilterOption>();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
        //      C# -> List<FilterOption>? TaskCategory
        // GraphQL -> task_category: [FilterOption!]! (type)
        if (ec.Includes("task_category",false))
        {
            if(this.TaskCategory == null) {

                this.TaskCategory = new List<FilterOption>();
                this.TaskCategory.ApplyExploratoryFieldSpec(ec.NewChild("task_category"));

            } else {

                this.TaskCategory.ApplyExploratoryFieldSpec(ec.NewChild("task_category"));

            }
        }
        else if (this.TaskCategory != null && ec.Excludes("task_category",false))
        {
            this.TaskCategory = null;
        }
        //      C# -> List<FilterOption>? TaskType
        // GraphQL -> task_type: [FilterOption!]! (type)
        if (ec.Includes("task_type",false))
        {
            if(this.TaskType == null) {

                this.TaskType = new List<FilterOption>();
                this.TaskType.ApplyExploratoryFieldSpec(ec.NewChild("task_type"));

            } else {

                this.TaskType.ApplyExploratoryFieldSpec(ec.NewChild("task_type"));

            }
        }
        else if (this.TaskType != null && ec.Excludes("task_type",false))
        {
            this.TaskType = null;
        }
    }


    #endregion

    } // class ProtectionTaskDetailsTableFilter
    
    #endregion

    public static class ListProtectionTaskDetailsTableFilterExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ProtectionTaskDetailsTableFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProtectionTaskDetailsTableFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectionTaskDetailsTableFilter> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectionTaskDetailsTableFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectionTaskDetailsTableFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types