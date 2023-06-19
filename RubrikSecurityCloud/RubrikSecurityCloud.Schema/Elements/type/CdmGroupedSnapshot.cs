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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (this.CdmSnapshots != null) {
            var fspec = this.CdmSnapshots.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmSnapshots {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (this.CdmSnapshots == null && Exploration.Includes(parent + ".cdmSnapshots"))
        {
            this.CdmSnapshots = new CdmWorkloadSnapshotConnection();
            this.CdmSnapshots.ApplyExploratoryFieldSpec(parent + ".cdmSnapshots");
        }
        //      C# -> CdmGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CdmGroupByInfo (type)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            this.GroupByInfo = new CdmGroupByInfo();
            this.GroupByInfo.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
        }
    }


    #endregion

    } // class CdmGroupedSnapshot
    
    #endregion

    public static class ListCdmGroupedSnapshotExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CdmGroupedSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmGroupedSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmGroupedSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types