// CreateScheduledReportReply.cs
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
    #region CreateScheduledReportReply
    public class CreateScheduledReportReply: BaseType
    {
        #region members

        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport! (type)
        [JsonProperty("scheduledReport")]
        public ScheduledReport? ScheduledReport { get; set; }


        #endregion

    #region methods

    public CreateScheduledReportReply Set(
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
            s += ind + "scheduledReport {\n" + this.ScheduledReport.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ScheduledReport? ScheduledReport
        // GraphQL -> scheduledReport: ScheduledReport! (type)
        if (this.ScheduledReport == null && Exploration.Includes(parent + ".scheduledReport"))
        {
            this.ScheduledReport = new ScheduledReport();
            this.ScheduledReport.ApplyExploratoryFieldSpec(parent + ".scheduledReport");
        }
    }


    #endregion

    } // class CreateScheduledReportReply
    
    #endregion

    public static class ListCreateScheduledReportReplyExtensions
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
            this List<CreateScheduledReportReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateScheduledReportReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateScheduledReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types