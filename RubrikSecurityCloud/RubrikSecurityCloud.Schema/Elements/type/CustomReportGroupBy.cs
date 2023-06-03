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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "reportConnection {\n" + this.ReportConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (this.ReportGroupBy != null) {
            s += ind + "reportGroupBy {\n" + this.ReportGroupBy.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            s += ind + "groupByInfo {\n" + this.GroupByInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CustomReportConnection? ReportConnection
        // GraphQL -> reportConnection: CustomReportConnection! (type)
        if (this.ReportConnection == null && Exploration.Includes(parent + ".reportConnection"))
        {
            this.ReportConnection = new CustomReportConnection();
            this.ReportConnection.ApplyExploratoryFieldSpec(parent + ".reportConnection");
        }
        //      C# -> List<CustomReportGroupBy>? ReportGroupBy
        // GraphQL -> reportGroupBy: [CustomReportGroupBy!]! (type)
        if (this.ReportGroupBy == null && Exploration.Includes(parent + ".reportGroupBy"))
        {
            this.ReportGroupBy = new List<CustomReportGroupBy>();
            this.ReportGroupBy.ApplyExploratoryFieldSpec(parent + ".reportGroupBy");
        }
        //      C# -> CustomReportGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: CustomReportGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<CustomReportGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CustomReportGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomReportGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types