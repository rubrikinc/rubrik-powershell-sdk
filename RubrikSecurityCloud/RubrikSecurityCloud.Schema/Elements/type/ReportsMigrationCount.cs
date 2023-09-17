// ReportsMigrationCount.cs
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
    #region ReportsMigrationCount
    public class ReportsMigrationCount: BaseType
    {
        #region members

        //      C# -> List<ReportMigrationStatusCountItem>? Counts
        // GraphQL -> counts: [ReportMigrationStatusCountItem!]! (type)
        [JsonProperty("counts")]
        public List<ReportMigrationStatusCountItem>? Counts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReportsMigrationCount";
    }

    public ReportsMigrationCount Set(
        List<ReportMigrationStatusCountItem>? Counts = null
    ) 
    {
        if ( Counts != null ) {
            this.Counts = Counts;
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
        //      C# -> List<ReportMigrationStatusCountItem>? Counts
        // GraphQL -> counts: [ReportMigrationStatusCountItem!]! (type)
        if (this.Counts != null) {
            var fspec = this.Counts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "counts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ReportMigrationStatusCountItem>? Counts
        // GraphQL -> counts: [ReportMigrationStatusCountItem!]! (type)
        if (this.Counts == null && ec.Includes("counts",false))
        {
            this.Counts = new List<ReportMigrationStatusCountItem>();
            this.Counts.ApplyExploratoryFieldSpec(ec.NewChild("counts"));
        }
    }


    #endregion

    } // class ReportsMigrationCount
    
    #endregion

    public static class ListReportsMigrationCountExtensions
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
            this List<ReportsMigrationCount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportsMigrationCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportsMigrationCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportsMigrationCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types