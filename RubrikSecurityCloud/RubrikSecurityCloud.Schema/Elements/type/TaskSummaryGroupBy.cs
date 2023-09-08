// TaskSummaryGroupBy.cs
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
    #region TaskSummaryGroupBy
    public class TaskSummaryGroupBy: BaseType
    {
        #region members

        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        [JsonProperty("taskSummaryConnection")]
        public TaskSummaryConnection? TaskSummaryConnection { get; set; }

        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        [JsonProperty("taskSummaryGroupBy")]
        public List<TaskSummaryGroupBy>? TaskSummaryGroupByField { get; set; }

        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public TaskSummaryGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskSummaryGroupBy";
    }

    public TaskSummaryGroupBy Set(
        TaskSummaryConnection? TaskSummaryConnection = null,
        List<TaskSummaryGroupBy>? TaskSummaryGroupByField = null,
        TaskSummaryGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( TaskSummaryConnection != null ) {
            this.TaskSummaryConnection = TaskSummaryConnection;
        }
        if ( TaskSummaryGroupByField != null ) {
            this.TaskSummaryGroupByField = TaskSummaryGroupByField;
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
        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        if (this.TaskSummaryConnection != null) {
            var fspec = this.TaskSummaryConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskSummaryConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (this.TaskSummaryGroupByField != null) {
            var fspec = this.TaskSummaryGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskSummaryGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
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
        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        if (this.TaskSummaryConnection == null && ec.Includes("taskSummaryConnection",false))
        {
            this.TaskSummaryConnection = new TaskSummaryConnection();
            this.TaskSummaryConnection.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryConnection"));
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (this.TaskSummaryGroupByField == null && ec.Includes("taskSummaryGroupBy",false))
        {
            this.TaskSummaryGroupByField = new List<TaskSummaryGroupBy>();
            this.TaskSummaryGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryGroupBy"));
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<TaskSummaryGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (TaskSummaryGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class TaskSummaryGroupBy
    
    #endregion

    public static class ListTaskSummaryGroupByExtensions
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
            this List<TaskSummaryGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummaryGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummaryGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TaskSummaryGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types