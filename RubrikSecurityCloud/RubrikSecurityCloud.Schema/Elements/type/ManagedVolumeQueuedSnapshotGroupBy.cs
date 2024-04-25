// ManagedVolumeQueuedSnapshotGroupBy.cs
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
    #region ManagedVolumeQueuedSnapshotGroupBy
    public class ManagedVolumeQueuedSnapshotGroupBy: BaseType
    {
        #region members

        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        [JsonProperty("managedVolumeQueuedSnapshotConnection")]
        public ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection { get; set; }

        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        [JsonProperty("managedVolumeQueuedSnapshotGroupBy")]
        public List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public RscInterface<ManagedVolumeQueuedSnapshotGroupByInfo> GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ManagedVolumeQueuedSnapshotConnection { get; set; }

        public RscGqlVars ManagedVolumeQueuedSnapshotGroupByField { get; set; }


        public InlineVars() {
            Tuple<string, string>[] managedVolumeQueuedSnapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "ManagedVolumeQueuedSnapshotSortBy"),
                };
            this.ManagedVolumeQueuedSnapshotConnection =
                new RscGqlVars(null, managedVolumeQueuedSnapshotConnectionArgs, null, true);
            Tuple<string, string>[] managedVolumeQueuedSnapshotGroupByArgs = {
                    Tuple.Create("groupBy", "ManagedVolumeQueuedSnapshotGroupByTime!"),
                };
            this.ManagedVolumeQueuedSnapshotGroupByField =
                new RscGqlVars(null, managedVolumeQueuedSnapshotGroupByArgs, null, true);
        }
    }

    public ManagedVolumeQueuedSnapshotGroupBy()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "ManagedVolumeQueuedSnapshotGroupBy";
    }

    public ManagedVolumeQueuedSnapshotGroupBy Set(
        ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection = null,
        List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField = null,
        RscInterface<ManagedVolumeQueuedSnapshotGroupByInfo> GroupByInfo = null
    ) 
    {
        if ( ManagedVolumeQueuedSnapshotConnection != null ) {
            this.ManagedVolumeQueuedSnapshotConnection = ManagedVolumeQueuedSnapshotConnection;
        }
        if ( ManagedVolumeQueuedSnapshotGroupByField != null ) {
            this.ManagedVolumeQueuedSnapshotGroupByField = ManagedVolumeQueuedSnapshotGroupByField;
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (this.ManagedVolumeQueuedSnapshotConnection != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotConnection.AsFieldSpec(conf.Child("managedVolumeQueuedSnapshotConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeQueuedSnapshotConnection" + "\n(" + this.Vars.ManagedVolumeQueuedSnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (this.ManagedVolumeQueuedSnapshotGroupByField != null) {
            var fspec = this.ManagedVolumeQueuedSnapshotGroupByField.AsFieldSpec(conf.Child("managedVolumeQueuedSnapshotGroupBy"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeQueuedSnapshotGroupBy" + "\n(" + this.Vars.ManagedVolumeQueuedSnapshotGroupByField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
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
        //      C# -> ManagedVolumeQueuedSnapshotConnection? ManagedVolumeQueuedSnapshotConnection
        // GraphQL -> managedVolumeQueuedSnapshotConnection: ManagedVolumeQueuedSnapshotConnection! (type)
        if (ec.Includes("managedVolumeQueuedSnapshotConnection",false))
        {
            if(this.ManagedVolumeQueuedSnapshotConnection == null) {

                this.ManagedVolumeQueuedSnapshotConnection = new ManagedVolumeQueuedSnapshotConnection();
                this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotConnection"));

            } else {

                this.ManagedVolumeQueuedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotConnection"));

            }
        }
        else if (this.ManagedVolumeQueuedSnapshotConnection != null && ec.Excludes("managedVolumeQueuedSnapshotConnection",false))
        {
            this.ManagedVolumeQueuedSnapshotConnection = null;
        }
        //      C# -> List<ManagedVolumeQueuedSnapshotGroupBy>? ManagedVolumeQueuedSnapshotGroupByField
        // GraphQL -> managedVolumeQueuedSnapshotGroupBy: [ManagedVolumeQueuedSnapshotGroupBy!]! (type)
        if (ec.Includes("managedVolumeQueuedSnapshotGroupBy",false))
        {
            if(this.ManagedVolumeQueuedSnapshotGroupByField == null) {

                this.ManagedVolumeQueuedSnapshotGroupByField = new List<ManagedVolumeQueuedSnapshotGroupBy>();
                this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotGroupBy"));

            } else {

                this.ManagedVolumeQueuedSnapshotGroupByField.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeQueuedSnapshotGroupBy"));

            }
        }
        else if (this.ManagedVolumeQueuedSnapshotGroupByField != null && ec.Excludes("managedVolumeQueuedSnapshotGroupBy",false))
        {
            this.ManagedVolumeQueuedSnapshotGroupByField = null;
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: ManagedVolumeQueuedSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new RscInterface<ManagedVolumeQueuedSnapshotGroupByInfo>();
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

    } // class ManagedVolumeQueuedSnapshotGroupBy
    
    #endregion

    public static class ListManagedVolumeQueuedSnapshotGroupByExtensions
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
            this List<ManagedVolumeQueuedSnapshotGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeQueuedSnapshotGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeQueuedSnapshotGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeQueuedSnapshotGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeQueuedSnapshotGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types