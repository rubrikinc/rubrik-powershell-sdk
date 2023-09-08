// ReportMigrationStatusCountItem.cs
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
    #region ReportMigrationStatusCountItem
    public class ReportMigrationStatusCountItem: BaseType
    {
        #region members

        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        [JsonProperty("status")]
        public CdmReportMigrationStatus? Status { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReportMigrationStatusCountItem";
    }

    public ReportMigrationStatusCountItem Set(
        CdmReportMigrationStatus? Status = null,
        System.Int32? Count = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmReportMigrationStatus? Status
        // GraphQL -> status: CdmReportMigrationStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new CdmReportMigrationStatus();
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
    }


    #endregion

    } // class ReportMigrationStatusCountItem
    
    #endregion

    public static class ListReportMigrationStatusCountItemExtensions
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
            this List<ReportMigrationStatusCountItem> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportMigrationStatusCountItem> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportMigrationStatusCountItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ReportMigrationStatusCountItem> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types