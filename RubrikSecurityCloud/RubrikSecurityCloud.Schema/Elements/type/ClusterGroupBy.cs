// ClusterGroupBy.cs
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
    #region ClusterGroupBy
    public class ClusterGroupBy: BaseType
    {
        #region members

        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        [JsonProperty("clusterConnection")]
        public ClusterConnection? ClusterConnection { get; set; }

        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        [JsonProperty("clusterGroupBy")]
        public List<ClusterGroupBy>? ClusterGroupByField { get; set; }

        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public ClusterGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ClusterConnection { get; set; }

        public RscGqlVars ClusterGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] clusterConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "ClusterSortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.ClusterConnection =
                new RscGqlVars(null, clusterConnectionArgs, null, true);
            Tuple<string, string>[] clusterGroupByArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("groupBy", "ClusterGroupByEnum!"),
                };
            this.ClusterGroupByField =
                new RscGqlVars(null, clusterGroupByArgs, null, true);
        }
    }

    public ClusterGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "ClusterGroupBy";
    }

    public ClusterGroupBy Set(
        ClusterConnection? ClusterConnection = null,
        List<ClusterGroupBy>? ClusterGroupByField = null,
        ClusterGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ClusterConnection != null ) {
            this.ClusterConnection = ClusterConnection;
        }
        if ( ClusterGroupByField != null ) {
            this.ClusterGroupByField = ClusterGroupByField;
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
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        if (this.ClusterConnection != null) {
            var fspec = this.ClusterConnection.AsFieldSpec(conf.Child("clusterConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterConnection" + "\n(" + this.Vars.ClusterConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (this.ClusterGroupByField != null) {
            var fspec = this.ClusterGroupByField.AsFieldSpec(conf.Child("clusterGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterGroupBy" + "\n(" + this.Vars.ClusterGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
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
        //      C# -> ClusterConnection? ClusterConnection
        // GraphQL -> clusterConnection: ClusterConnection! (type)
        if (ec.Includes("clusterConnection",false))
        {
            if(this.ClusterConnection == null) {

                this.ClusterConnection = new ClusterConnection();
                this.ClusterConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterConnection"));

            } else {

                this.ClusterConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterConnection"));

            }
        }
        else if (this.ClusterConnection != null && ec.Excludes("clusterConnection",false))
        {
            this.ClusterConnection = null;
        }
        //      C# -> List<ClusterGroupBy>? ClusterGroupByField
        // GraphQL -> clusterGroupBy: [ClusterGroupBy!]! (type)
        if (ec.Includes("clusterGroupBy",false))
        {
            if(this.ClusterGroupByField == null) {

                this.ClusterGroupByField = new List<ClusterGroupBy>();
                this.ClusterGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("clusterGroupBy"));

            } else {

                this.ClusterGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("clusterGroupBy"));

            }
        }
        else if (this.ClusterGroupByField != null && ec.Excludes("clusterGroupBy",false))
        {
            this.ClusterGroupByField = null;
        }
        //      C# -> ClusterGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ClusterGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new RscList<ClusterGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ClusterGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ClusterGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (ClusterGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class ClusterGroupBy
    
    #endregion

    public static class ListClusterGroupByExtensions
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
            this List<ClusterGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types