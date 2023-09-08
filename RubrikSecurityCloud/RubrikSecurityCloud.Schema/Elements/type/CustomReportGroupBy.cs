// CustomReportGroupBy.cs
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
    #region CustomReportGroupBy
    public class CustomReportGroupBy: BaseType
    {
        #region members

        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        [JsonProperty("reportConnection")]
        public CustomReportConnection? ReportConnection { get; set; }

        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        [JsonProperty("reportGroupBy")]
        public List<CustomReportGroupBy>? ReportGroupBy { get; set; }

        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public CustomReportGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomReportGroupBy";
    }

    public CustomReportGroupBy Set(
        CustomReportConnection? ReportConnection = null,
        List<CustomReportGroupBy>? ReportGroupBy = null,
        CustomReportGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( ReportConnection != null ) {
            this.ReportConnection = ReportConnection;
        }
        if ( ReportGroupBy != null ) {
            this.ReportGroupBy = ReportGroupBy;
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
        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        if (this.ReportConnection != null) {
            var fspec = this.ReportConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "reportConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (this.ReportGroupBy != null) {
            var fspec = this.ReportGroupBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "reportGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        if (this.ReportConnection == null && ec.Includes("reportConnection",false))
        {
            this.ReportConnection = new CustomReportConnection();
            this.ReportConnection.ApplyExploratoryFieldSpec(ec.NewChild("reportConnection"));
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (this.ReportGroupBy == null && ec.Includes("reportGroupBy",false))
        {
            this.ReportGroupBy = new List<CustomReportGroupBy>();
            this.ReportGroupBy.ApplyExploratoryFieldSpec(ec.NewChild("reportGroupBy"));
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        if (this.GroupByInfo == null && ec.Includes("groupByInfo",false))
        {
            var impls = new List<CustomReportGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
            this.GroupByInfo = (CustomReportGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class CustomReportGroupBy
    
    #endregion

    public static class ListCustomReportGroupByExtensions
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
            this List<CustomReportGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CustomReportGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomReportGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CustomReportGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types