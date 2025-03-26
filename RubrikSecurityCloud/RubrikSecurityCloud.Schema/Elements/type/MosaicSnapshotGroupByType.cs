// MosaicSnapshotGroupByType.cs
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
    #region MosaicSnapshotGroupByType
    public class MosaicSnapshotGroupByType: BaseType
    {
        #region members

        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        [JsonProperty("allSnapshotGroupBys")]
        public List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys { get; set; }

        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        [JsonProperty("snapshots")]
        public MosaicSnapshotConnection? Snapshots { get; set; }

        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public MosaicSnapshotGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars AllSnapshotGroupBys { get; set; }

        public RscGqlVars Snapshots { get; set; }


        public InlineVars() {
            Tuple<string, string>[] allSnapshotGroupBysArgs = {
                    Tuple.Create("groupBy", "MosaicSnapshotGroupBy!"),
                };
            this.AllSnapshotGroupBys =
                new RscGqlVars(null, allSnapshotGroupBysArgs, null, true);
            Tuple<string, string>[] snapshotsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "MosaicSnapshotSortBy"),
                };
            this.Snapshots =
                new RscGqlVars(null, snapshotsArgs, null, true);
        }
    }

    public MosaicSnapshotGroupByType()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "MosaicSnapshotGroupByType";
    }

    public MosaicSnapshotGroupByType Set(
        List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys = null,
        MosaicSnapshotConnection? Snapshots = null,
        MosaicSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( AllSnapshotGroupBys != null ) {
            this.AllSnapshotGroupBys = AllSnapshotGroupBys;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (this.AllSnapshotGroupBys != null) {
            var fspec = this.AllSnapshotGroupBys.AsFieldSpec(conf.Child("allSnapshotGroupBys"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allSnapshotGroupBys" + "\n(" + this.Vars.AllSnapshotGroupBys.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (this.Snapshots != null) {
            var fspec = this.Snapshots.AsFieldSpec(conf.Child("snapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshots" + "\n(" + this.Vars.Snapshots.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<MosaicSnapshotGroupByType>? AllSnapshotGroupBys
        // GraphQL -> allSnapshotGroupBys: [MosaicSnapshotGroupByType!]! (type)
        if (ec.Includes("allSnapshotGroupBys",false))
        {
            if(this.AllSnapshotGroupBys == null) {

                this.AllSnapshotGroupBys = new List<MosaicSnapshotGroupByType>();
                this.AllSnapshotGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("allSnapshotGroupBys"));

            } else {

                this.AllSnapshotGroupBys.ApplyExploratoryFieldSpec(ec.NewChild("allSnapshotGroupBys"));

            }
        }
        else if (this.AllSnapshotGroupBys != null && ec.Excludes("allSnapshotGroupBys",false))
        {
            this.AllSnapshotGroupBys = null;
        }
        //      C# -> MosaicSnapshotConnection? Snapshots
        // GraphQL -> snapshots: MosaicSnapshotConnection! (type)
        if (ec.Includes("snapshots",false))
        {
            if(this.Snapshots == null) {

                this.Snapshots = new MosaicSnapshotConnection();
                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            } else {

                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            }
        }
        else if (this.Snapshots != null && ec.Excludes("snapshots",false))
        {
            this.Snapshots = null;
        }
        //      C# -> MosaicSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: MosaicSnapshotGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<MosaicSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<MosaicSnapshotGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (MosaicSnapshotGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class MosaicSnapshotGroupByType
    
    #endregion

    public static class ListMosaicSnapshotGroupByTypeExtensions
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
            this List<MosaicSnapshotGroupByType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MosaicSnapshotGroupByType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicSnapshotGroupByType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicSnapshotGroupByType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicSnapshotGroupByType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types