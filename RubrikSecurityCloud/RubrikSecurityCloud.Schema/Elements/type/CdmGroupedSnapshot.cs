// CdmGroupedSnapshot.cs
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
    #region CdmGroupedSnapshot
    public class CdmGroupedSnapshot: BaseType
    {
        #region members

        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmWorkloadSnapshotConnection? CdmSnapshots { get; set; }

        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        [JsonProperty("groupByInfo")]
        public CdmGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmGroupedSnapshot";
    }

    public CdmGroupedSnapshot Set(
        CdmWorkloadSnapshotConnection? CdmSnapshots = null,
        CdmGroupByInfo? GroupByInfo = null
    ) 
    {
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (this.CdmSnapshots != null) {
            var fspec = this.CdmSnapshots.AsFieldSpec(conf.Child("cdmSnapshots"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmSnapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (ec.Includes("cdmSnapshots",false))
        {
            if(this.CdmSnapshots == null) {

                this.CdmSnapshots = new CdmWorkloadSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            } else {

                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            }
        }
        else if (this.CdmSnapshots != null && ec.Excludes("cdmSnapshots",false))
        {
            this.CdmSnapshots = null;
        }
        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new CdmGroupByInfo();
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

    } // class CdmGroupedSnapshot
    
    #endregion

    public static class ListCdmGroupedSnapshotExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CdmGroupedSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmGroupedSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmGroupedSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmGroupedSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmGroupedSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types