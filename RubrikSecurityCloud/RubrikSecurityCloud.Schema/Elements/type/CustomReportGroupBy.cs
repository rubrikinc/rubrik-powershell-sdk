// CustomReportGroupBy.cs
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
    #region CustomReportGroupBy
    public class CustomReportGroupBy: BaseType
    {
        #region members

        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        [JsonProperty("reportConnection")]
        public CustomReportConnection? ReportConnection { get; set; }

        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        [JsonProperty("reportGroupBy")]
        public List<CustomReportGroupBy>? ReportGroupBy { get; set; }

        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public CustomReportGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ReportConnection { get; set; }

        public RscGqlVars ReportGroupBy { get; set; }


        public InlineVars() {
            Tuple<string, string>[] reportConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "CustomReportSortByEnum"),
                };
            this.ReportConnection =
                new RscGqlVars(null, reportConnectionArgs, null, true);
            Tuple<string, string>[] reportGroupByArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("groupBy", "CustomReportGroupByEnum!"),
                };
            this.ReportGroupBy =
                new RscGqlVars(null, reportGroupByArgs, null, true);
        }
    }

    public CustomReportGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "CustomReportGroupBy";
    }

    public CustomReportGroupBy Set(
        CustomReportConnection? ReportConnection = null,
        List<CustomReportGroupBy>? ReportGroupBy = null,
        CustomReportGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ReportConnection != null ) {
            this.ReportConnection = ReportConnection;
        }
        if ( ReportGroupBy != null ) {
            this.ReportGroupBy = ReportGroupBy;
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
        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        if (this.ReportConnection != null) {
            var fspec = this.ReportConnection.AsFieldSpec(conf.Child("reportConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reportConnection" + "\n(" + this.Vars.ReportConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (this.ReportGroupBy != null) {
            var fspec = this.ReportGroupBy.AsFieldSpec(conf.Child("reportGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reportGroupBy" + "\n(" + this.Vars.ReportGroupBy.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
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
        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        if (ec.Includes("reportConnection",false))
        {
            if(this.ReportConnection == null) {

                this.ReportConnection = new CustomReportConnection();
                this.ReportConnection.ApplyExploratoryFieldSpec(ec.NewChild("reportConnection"));

            } else {

                this.ReportConnection.ApplyExploratoryFieldSpec(ec.NewChild("reportConnection"));

            }
        }
        else if (this.ReportConnection != null && ec.Excludes("reportConnection",false))
        {
            this.ReportConnection = null;
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (ec.Includes("reportGroupBy",false))
        {
            if(this.ReportGroupBy == null) {

                this.ReportGroupBy = new List<CustomReportGroupBy>();
                this.ReportGroupBy.ApplyExploratoryFieldSpec(ec.NewChild("reportGroupBy"));

            } else {

                this.ReportGroupBy.ApplyExploratoryFieldSpec(ec.NewChild("reportGroupBy"));

            }
        }
        else if (this.ReportGroupBy != null && ec.Excludes("reportGroupBy",false))
        {
            this.ReportGroupBy = null;
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<CustomReportGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (CustomReportGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CustomReportGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (CustomReportGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class CustomReportGroupBy
    
    #endregion

    public static class ListCustomReportGroupByExtensions
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
            this List<CustomReportGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CustomReportGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomReportGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomReportGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomReportGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types