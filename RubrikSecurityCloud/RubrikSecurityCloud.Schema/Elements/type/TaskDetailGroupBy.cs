// TaskDetailGroupBy.cs
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
    #region TaskDetailGroupBy
    public class TaskDetailGroupBy: BaseType
    {
        #region members

        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        [JsonProperty("taskDetailConnection")]
        public TaskDetailConnection? TaskDetailConnection { get; set; }

        //      C# -> List<TaskDetailGroupBy>? TaskDetailGroupByField
        // GraphQL -> taskDetailGroupBy: [TaskDetailGroupBy!]! (type)
        [JsonProperty("taskDetailGroupBy")]
        public List<TaskDetailGroupBy>? TaskDetailGroupByField { get; set; }

        //      C# -> TaskDetailGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskDetailGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public TaskDetailGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskDetailGroupBy";
    }

    public TaskDetailGroupBy Set(
        TaskDetailConnection? TaskDetailConnection = null,
        List<TaskDetailGroupBy>? TaskDetailGroupByField = null,
        TaskDetailGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( TaskDetailConnection != null ) {
            this.TaskDetailConnection = TaskDetailConnection;
        }
        if ( TaskDetailGroupByField != null ) {
            this.TaskDetailGroupByField = TaskDetailGroupByField;
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
        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        if (this.TaskDetailConnection != null) {
            var fspec = this.TaskDetailConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskDetailConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TaskDetailGroupBy>? TaskDetailGroupByField
        // GraphQL -> taskDetailGroupBy: [TaskDetailGroupBy!]! (type)
        if (this.TaskDetailGroupByField != null) {
            var fspec = this.TaskDetailGroupByField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "taskDetailGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TaskDetailGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskDetailGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TaskDetailConnection? TaskDetailConnection
        // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
        if (this.TaskDetailConnection == null && Exploration.Includes(parent + ".taskDetailConnection"))
        {
            this.TaskDetailConnection = new TaskDetailConnection();
            this.TaskDetailConnection.ApplyExploratoryFieldSpec(parent + ".taskDetailConnection");
        }
        //      C# -> List<TaskDetailGroupBy>? TaskDetailGroupByField
        // GraphQL -> taskDetailGroupBy: [TaskDetailGroupBy!]! (type)
        if (this.TaskDetailGroupByField == null && Exploration.Includes(parent + ".taskDetailGroupBy"))
        {
            this.TaskDetailGroupByField = new List<TaskDetailGroupBy>();
            this.TaskDetailGroupByField.ApplyExploratoryFieldSpec(parent + ".taskDetailGroupBy");
        }
        //      C# -> TaskDetailGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskDetailGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<TaskDetailGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (TaskDetailGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class TaskDetailGroupBy
    
    #endregion

    public static class ListTaskDetailGroupByExtensions
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
            this List<TaskDetailGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskDetailGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskDetailGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types