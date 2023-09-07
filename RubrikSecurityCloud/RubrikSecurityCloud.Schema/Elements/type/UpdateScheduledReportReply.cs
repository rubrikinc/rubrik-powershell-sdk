// UpdateScheduledReportReply.cs
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
    #region UpdateScheduledReportReply
    public class UpdateScheduledReportReply: BaseType
    {
        #region members

        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport! (type)
        [JsonProperty("scheduledReport")]
        public ScheduledReport? ScheduledReport { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateScheduledReportReply";
    }

    public UpdateScheduledReportReply Set(
        ScheduledReport? ScheduledReport = null
    ) 
    {
        if ( ScheduledReport != null ) {
            this.ScheduledReport = ScheduledReport;
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
        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport! (type)
        if (this.ScheduledReport != null) {
            var fspec = this.ScheduledReport.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "scheduledReport {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport! (type)
        if (this.ScheduledReport == null && ec.Includes("scheduledReport",false))
        {
            this.ScheduledReport = new ScheduledReport();
            this.ScheduledReport.ApplyExploratoryFieldSpec(ec.NewChild("scheduledReport"));
        }
    }


    #endregion

    } // class UpdateScheduledReportReply
    
    #endregion

    public static class ListUpdateScheduledReportReplyExtensions
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
            this List<UpdateScheduledReportReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateScheduledReportReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateScheduledReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateScheduledReportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types