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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "taskSummaryConnection {\n" + this.TaskSummaryConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (this.TaskSummaryGroupByField != null) {
            s += ind + "taskSummaryGroupBy {\n" + this.TaskSummaryGroupByField.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        if (this.TaskSummaryConnection == null && Exploration.Includes(parent + ".taskSummaryConnection"))
        {
            this.TaskSummaryConnection = new TaskSummaryConnection();
            this.TaskSummaryConnection.ApplyExploratoryFieldSpec(parent + ".taskSummaryConnection");
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (this.TaskSummaryGroupByField == null && Exploration.Includes(parent + ".taskSummaryGroupBy"))
        {
            this.TaskSummaryGroupByField = new List<TaskSummaryGroupBy>();
            this.TaskSummaryGroupByField.ApplyExploratoryFieldSpec(parent + ".taskSummaryGroupBy");
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<TaskSummaryGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskSummaryGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskSummaryGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types