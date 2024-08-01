// ActivitySeriesGroupBy.cs
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
    #region ActivitySeriesGroupBy
    public class ActivitySeriesGroupBy: BaseType
    {
        #region members

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        [JsonProperty("activitySeriesConnection")]
        public ActivitySeriesConnection? ActivitySeriesConnection { get; set; }

        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        [JsonProperty("activitySeriesGroupBy")]
        public List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField { get; set; }

        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ActivitySeriesGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ActivitySeriesConnection { get; set; }

        public RscGqlVars ActivitySeriesGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] activitySeriesConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "ActivitySeriesSortByEnum"),
                };
            this.ActivitySeriesConnection =
                new RscGqlVars(null, activitySeriesConnectionArgs, null, true);
            Tuple<string, string>[] activitySeriesGroupByArgs = {
                    Tuple.Create("groupBy", "ActivitySeriesGroupByEnum!"),
                };
            this.ActivitySeriesGroupByField =
                new RscGqlVars(null, activitySeriesGroupByArgs, null, true);
        }
    }

    public ActivitySeriesGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "ActivitySeriesGroupBy";
    }

    public ActivitySeriesGroupBy Set(
        ActivitySeriesConnection? ActivitySeriesConnection = null,
        List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField = null,
        ActivitySeriesGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ActivitySeriesConnection != null ) {
            this.ActivitySeriesConnection = ActivitySeriesConnection;
        }
        if ( ActivitySeriesGroupByField != null ) {
            this.ActivitySeriesGroupByField = ActivitySeriesGroupByField;
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
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection != null) {
            var fspec = this.ActivitySeriesConnection.AsFieldSpec(conf.Child("activitySeriesConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySeriesConnection" + "\n(" + this.Vars.ActivitySeriesConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        if (this.ActivitySeriesGroupByField != null) {
            var fspec = this.ActivitySeriesGroupByField.AsFieldSpec(conf.Child("activitySeriesGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySeriesGroupBy" + "\n(" + this.Vars.ActivitySeriesGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
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
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (ec.Includes("activitySeriesConnection",false))
        {
            if(this.ActivitySeriesConnection == null) {

                this.ActivitySeriesConnection = new ActivitySeriesConnection();
                this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesConnection"));

            } else {

                this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesConnection"));

            }
        }
        else if (this.ActivitySeriesConnection != null && ec.Excludes("activitySeriesConnection",false))
        {
            this.ActivitySeriesConnection = null;
        }
        //      C# -> List<ActivitySeriesGroupBy>? ActivitySeriesGroupByField
        // GraphQL -> activitySeriesGroupBy: [ActivitySeriesGroupBy!]! (type)
        if (ec.Includes("activitySeriesGroupBy",false))
        {
            if(this.ActivitySeriesGroupByField == null) {

                this.ActivitySeriesGroupByField = new List<ActivitySeriesGroupBy>();
                this.ActivitySeriesGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesGroupBy"));

            } else {

                this.ActivitySeriesGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesGroupBy"));

            }
        }
        else if (this.ActivitySeriesGroupByField != null && ec.Excludes("activitySeriesGroupBy",false))
        {
            this.ActivitySeriesGroupByField = null;
        }
        //      C# -> ActivitySeriesGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ActivitySeriesGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<ActivitySeriesGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ActivitySeriesGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ActivitySeriesGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ActivitySeriesGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class ActivitySeriesGroupBy
    
    #endregion

    public static class ListActivitySeriesGroupByExtensions
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
            this List<ActivitySeriesGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivitySeriesGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySeriesGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySeriesGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivitySeriesGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types