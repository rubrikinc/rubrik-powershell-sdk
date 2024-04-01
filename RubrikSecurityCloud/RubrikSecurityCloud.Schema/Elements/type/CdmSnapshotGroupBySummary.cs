// CdmSnapshotGroupBySummary.cs
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
    #region CdmSnapshotGroupBySummary
    public class CdmSnapshotGroupBySummary: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmSnapshotConnection? CdmSnapshots { get; set; }

        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        [JsonProperty("groupByInfo")]
        public TimeRangeWithUnit? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmSnapshotGroupBySummary";
    }

    public CdmSnapshotGroupBySummary Set(
        System.Int32? Count = null,
        CdmSnapshotConnection? CdmSnapshots = null,
        TimeRangeWithUnit? GroupByInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CdmSnapshots != null ) {
            this.CdmSnapshots = CdmSnapshots;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        if (this.CdmSnapshots != null) {
            var fspec = this.CdmSnapshots.AsFieldSpec(conf.Child("cdmSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmSnapshots {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> CdmSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmSnapshotConnection! (type)
        if (ec.Includes("cdmSnapshots",false))
        {
            if(this.CdmSnapshots == null) {

                this.CdmSnapshots = new CdmSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            } else {

                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            }
        }
        else if (this.CdmSnapshots != null && ec.Excludes("cdmSnapshots",false))
        {
            this.CdmSnapshots = null;
        }
        //      C# -> TimeRangeWithUnit? GroupByInfo
        // GraphQL -> groupByInfo: TimeRangeWithUnit! (type)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new TimeRangeWithUnit();
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

    } // class CdmSnapshotGroupBySummary
    
    #endregion

    public static class ListCdmSnapshotGroupBySummaryExtensions
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
            this List<CdmSnapshotGroupBySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmSnapshotGroupBySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotGroupBySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotGroupBySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmSnapshotGroupBySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types