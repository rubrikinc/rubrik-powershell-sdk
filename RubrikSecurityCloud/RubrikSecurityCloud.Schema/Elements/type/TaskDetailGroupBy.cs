// TaskDetailGroupBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:20.
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
    #region TaskDetailGroupBy
    public class TaskDetailGroupBy: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> TaskDetailConnection? TaskDetailConnection
            // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
            if (this.TaskDetailConnection != null)
            {
                 s += ind + "taskDetailConnection\n";

                 s += ind + "{\n" + 
                 this.TaskDetailConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TaskDetailGroupBy>? TaskDetailGroupByField
            // GraphQL -> taskDetailGroupBy: [TaskDetailGroupBy!]! (type)
            if (this.TaskDetailGroupByField != null)
            {
                 s += ind + "taskDetailGroupBy\n";

                 s += ind + "{\n" + 
                 this.TaskDetailGroupByField.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TaskDetailGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: TaskDetailGroupByInfo! (union)
            if (this.GroupByInfo != null)
            {
                 s += ind + "groupByInfo\n";

                 s += ind + "{\n" + 
                 this.GroupByInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> TaskDetailConnection? TaskDetailConnection
            // GraphQL -> taskDetailConnection: TaskDetailConnection! (type)
            if (this.TaskDetailConnection == null && Exploration.Includes(parent + ".taskDetailConnection"))
            {
                this.TaskDetailConnection = new TaskDetailConnection();
                this.TaskDetailConnection.ApplyExploratoryFragment(parent + ".taskDetailConnection");
            }
            //      C# -> List<TaskDetailGroupBy>? TaskDetailGroupByField
            // GraphQL -> taskDetailGroupBy: [TaskDetailGroupBy!]! (type)
            if (this.TaskDetailGroupByField == null && Exploration.Includes(parent + ".taskDetailGroupBy"))
            {
                this.TaskDetailGroupByField = new List<TaskDetailGroupBy>();
                this.TaskDetailGroupByField.ApplyExploratoryFragment(parent + ".taskDetailGroupBy");
            }
            //      C# -> TaskDetailGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: TaskDetailGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (TaskDetailGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(TaskDetailGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class TaskDetailGroupBy
    #endregion

    public static class ListTaskDetailGroupByExtensions
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
            this List<TaskDetailGroupBy> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TaskDetailGroupBy> list, 
            String parent = "")
        {
            var item = new TaskDetailGroupBy();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types