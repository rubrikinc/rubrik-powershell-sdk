// MissedSnapshotGroupBy.cs
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
    #region MissedSnapshotGroupBy
    public class MissedSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        [JsonProperty("missedSnapshotGroupBy")]
        public List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField { get; set; }

        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public RscInterface<MissedSnapshotGroupByInfo> GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars MissedSnapshotConnection { get; set; }

        public RscGqlVars MissedSnapshotGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] missedSnapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "MissedSnapshotSortByEnum"),
                };
            this.MissedSnapshotConnection =
                new RscGqlVars(null, missedSnapshotConnectionArgs, null, true);
            Tuple<string, string>[] missedSnapshotGroupByArgs = {
                    Tuple.Create("groupBy", "MissedSnapshotGroupByTime!"),
                };
            this.MissedSnapshotGroupByField =
                new RscGqlVars(null, missedSnapshotGroupByArgs, null, true);
        }
    }

    public MissedSnapshotGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "MissedSnapshotGroupBy";
    }

    public MissedSnapshotGroupBy Set(
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField = null,
        RscInterface<MissedSnapshotGroupByInfo> GroupByInfo = null
    ) 
    {
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByField != null ) {
            this.MissedSnapshotGroupByField = MissedSnapshotGroupByField;
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(conf.Child("missedSnapshotConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotConnection" + "\n(" + this.Vars.MissedSnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        if (this.MissedSnapshotGroupByField != null) {
            var fspec = this.MissedSnapshotGroupByField.AsFieldSpec(conf.Child("missedSnapshotGroupBy"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotGroupBy" + "\n(" + this.Vars.MissedSnapshotGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection! (type)
        if (ec.Includes("missedSnapshotConnection",false))
        {
            if(this.MissedSnapshotConnection == null) {

                this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            } else {

                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            }
        }
        else if (this.MissedSnapshotConnection != null && ec.Excludes("missedSnapshotConnection",false))
        {
            this.MissedSnapshotConnection = null;
        }
        //      C# -> List<MissedSnapshotGroupBy>? MissedSnapshotGroupByField
        // GraphQL -> missedSnapshotGroupBy: [MissedSnapshotGroupBy!]! (type)
        if (ec.Includes("missedSnapshotGroupBy",false))
        {
            if(this.MissedSnapshotGroupByField == null) {

                this.MissedSnapshotGroupByField = new List<MissedSnapshotGroupBy>();
                this.MissedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupBy"));

            } else {

                this.MissedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupBy"));

            }
        }
        else if (this.MissedSnapshotGroupByField != null && ec.Excludes("missedSnapshotGroupBy",false))
        {
            this.MissedSnapshotGroupByField = null;
        }
        //      C# -> MissedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MissedSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new RscInterface<MissedSnapshotGroupByInfo>();
                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            } else {

                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class MissedSnapshotGroupBy
    
    #endregion

    public static class ListMissedSnapshotGroupByExtensions
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
            this List<MissedSnapshotGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MissedSnapshotGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MissedSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types