// FailoverGroupBy.cs
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
    #region FailoverGroupBy
    public class FailoverGroupBy: BaseType
    {
        #region members

        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        [JsonProperty("failoverConnection")]
        public FailoverConnection? FailoverConnection { get; set; }

        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        [JsonProperty("failoverGroupBy")]
        public List<FailoverGroupBy>? FailoverGroupByField { get; set; }

        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public FailoverGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars FailoverConnection { get; set; }

        public RscGqlVars FailoverGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] failoverConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "FailoverSortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.FailoverConnection =
                new RscGqlVars(null, failoverConnectionArgs, null, true);
            Tuple<string, string>[] failoverGroupByArgs = {
                    Tuple.Create("groupBy", "FailoverGroupByEnum!"),
                };
            this.FailoverGroupByField =
                new RscGqlVars(null, failoverGroupByArgs, null, true);
        }
    }

    public FailoverGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "FailoverGroupBy";
    }

    public FailoverGroupBy Set(
        FailoverConnection? FailoverConnection = null,
        List<FailoverGroupBy>? FailoverGroupByField = null,
        FailoverGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( FailoverConnection != null ) {
            this.FailoverConnection = FailoverConnection;
        }
        if ( FailoverGroupByField != null ) {
            this.FailoverGroupByField = FailoverGroupByField;
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
        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        if (this.FailoverConnection != null) {
            var fspec = this.FailoverConnection.AsFieldSpec(conf.Child("failoverConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failoverConnection" + "\n(" + this.Vars.FailoverConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        if (this.FailoverGroupByField != null) {
            var fspec = this.FailoverGroupByField.AsFieldSpec(conf.Child("failoverGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failoverGroupBy" + "\n(" + this.Vars.FailoverGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
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
        //      C# -> FailoverConnection? FailoverConnection
        // GraphQL -> failoverConnection: FailoverConnection! (type)
        if (ec.Includes("failoverConnection",false))
        {
            if(this.FailoverConnection == null) {

                this.FailoverConnection = new FailoverConnection();
                this.FailoverConnection.ApplyExploratoryFieldSpec(ec.NewChild("failoverConnection"));

            } else {

                this.FailoverConnection.ApplyExploratoryFieldSpec(ec.NewChild("failoverConnection"));

            }
        }
        else if (this.FailoverConnection != null && ec.Excludes("failoverConnection",false))
        {
            this.FailoverConnection = null;
        }
        //      C# -> List<FailoverGroupBy>? FailoverGroupByField
        // GraphQL -> failoverGroupBy: [FailoverGroupBy!]! (type)
        if (ec.Includes("failoverGroupBy",false))
        {
            if(this.FailoverGroupByField == null) {

                this.FailoverGroupByField = new List<FailoverGroupBy>();
                this.FailoverGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("failoverGroupBy"));

            } else {

                this.FailoverGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("failoverGroupBy"));

            }
        }
        else if (this.FailoverGroupByField != null && ec.Excludes("failoverGroupBy",false))
        {
            this.FailoverGroupByField = null;
        }
        //      C# -> FailoverGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: FailoverGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<FailoverGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (FailoverGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<FailoverGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (FailoverGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class FailoverGroupBy
    
    #endregion

    public static class ListFailoverGroupByExtensions
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
            this List<FailoverGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types