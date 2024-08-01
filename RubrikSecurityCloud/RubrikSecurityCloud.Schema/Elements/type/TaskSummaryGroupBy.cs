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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars TaskSummaryConnection { get; set; }

        public RscGqlVars TaskSummaryGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] taskSummaryConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "TaskSummarySortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.TaskSummaryConnection =
                new RscGqlVars(null, taskSummaryConnectionArgs, null, true);
            Tuple<string, string>[] taskSummaryGroupByArgs = {
                    Tuple.Create("groupBy", "TaskSummaryGroupByEnum!"),
                };
            this.TaskSummaryGroupByField =
                new RscGqlVars(null, taskSummaryGroupByArgs, null, true);
        }
    }

    public TaskSummaryGroupBy()
    {
        this.Vars = new InlineVars();
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        if (this.TaskSummaryConnection != null) {
            var fspec = this.TaskSummaryConnection.AsFieldSpec(conf.Child("taskSummaryConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "taskSummaryConnection" + "\n(" + this.Vars.TaskSummaryConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (this.TaskSummaryGroupByField != null) {
            var fspec = this.TaskSummaryGroupByField.AsFieldSpec(conf.Child("taskSummaryGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "taskSummaryGroupBy" + "\n(" + this.Vars.TaskSummaryGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TaskSummaryConnection? TaskSummaryConnection
        // GraphQL -> taskSummaryConnection: TaskSummaryConnection! (type)
        if (ec.Includes("taskSummaryConnection",false))
        {
            if(this.TaskSummaryConnection == null) {

                this.TaskSummaryConnection = new TaskSummaryConnection();
                this.TaskSummaryConnection.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryConnection"));

            } else {

                this.TaskSummaryConnection.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryConnection"));

            }
        }
        else if (this.TaskSummaryConnection != null && ec.Excludes("taskSummaryConnection",false))
        {
            this.TaskSummaryConnection = null;
        }
        //      C# -> List<TaskSummaryGroupBy>? TaskSummaryGroupByField
        // GraphQL -> taskSummaryGroupBy: [TaskSummaryGroupBy!]! (type)
        if (ec.Includes("taskSummaryGroupBy",false))
        {
            if(this.TaskSummaryGroupByField == null) {

                this.TaskSummaryGroupByField = new List<TaskSummaryGroupBy>();
                this.TaskSummaryGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryGroupBy"));

            } else {

                this.TaskSummaryGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("taskSummaryGroupBy"));

            }
        }
        else if (this.TaskSummaryGroupByField != null && ec.Excludes("taskSummaryGroupBy",false))
        {
            this.TaskSummaryGroupByField = null;
        }
        //      C# -> TaskSummaryGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: TaskSummaryGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<TaskSummaryGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (TaskSummaryGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<TaskSummaryGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (TaskSummaryGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class TaskSummaryGroupBy
    
    #endregion

    public static class ListTaskSummaryGroupByExtensions
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
            this List<TaskSummaryGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TaskSummaryGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<TaskSummaryGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types