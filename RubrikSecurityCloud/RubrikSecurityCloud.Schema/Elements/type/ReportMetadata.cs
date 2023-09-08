// ReportMetadata.cs
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
    #region ReportMetadata
    public class ReportMetadata: BaseType
    {
        #region members

        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        [JsonProperty("reportViewType")]
        public PolarisReportViewType? ReportViewType { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReportMetadata";
    }

    public ReportMetadata Set(
        PolarisReportViewType? ReportViewType = null,
        System.Int64? Count = null
    ) 
    {
        if ( ReportViewType != null ) {
            this.ReportViewType = ReportViewType;
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
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType != null) {
            s += ind + "reportViewType\n" ;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType == null && ec.Includes("reportViewType",true))
        {
            this.ReportViewType = new PolarisReportViewType();
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = new System.Int64();
        }
    }


    #endregion

    } // class ReportMetadata
    
    #endregion

    public static class ListReportMetadataExtensions
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
            this List<ReportMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ReportMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types