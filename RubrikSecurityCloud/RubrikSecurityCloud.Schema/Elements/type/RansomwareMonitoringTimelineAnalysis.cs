// RansomwareMonitoringTimelineAnalysis.cs
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
    #region RansomwareMonitoringTimelineAnalysis
    public class RansomwareMonitoringTimelineAnalysis: BaseType
    {
        #region members

        //      C# -> List<DailyTimelineDetails>? TimelineDetails
        // GraphQL -> timelineDetails: [DailyTimelineDetails!]! (type)
        [JsonProperty("timelineDetails")]
        public List<DailyTimelineDetails>? TimelineDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareMonitoringTimelineAnalysis";
    }

    public RansomwareMonitoringTimelineAnalysis Set(
        List<DailyTimelineDetails>? TimelineDetails = null
    ) 
    {
        if ( TimelineDetails != null ) {
            this.TimelineDetails = TimelineDetails;
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
        //      C# -> List<DailyTimelineDetails>? TimelineDetails
        // GraphQL -> timelineDetails: [DailyTimelineDetails!]! (type)
        if (this.TimelineDetails != null) {
            var fspec = this.TimelineDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "timelineDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DailyTimelineDetails>? TimelineDetails
        // GraphQL -> timelineDetails: [DailyTimelineDetails!]! (type)
        if (this.TimelineDetails == null && Exploration.Includes(parent + ".timelineDetails"))
        {
            this.TimelineDetails = new List<DailyTimelineDetails>();
            this.TimelineDetails.ApplyExploratoryFieldSpec(parent + ".timelineDetails");
        }
    }


    #endregion

    } // class RansomwareMonitoringTimelineAnalysis
    
    #endregion

    public static class ListRansomwareMonitoringTimelineAnalysisExtensions
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
            this List<RansomwareMonitoringTimelineAnalysis> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareMonitoringTimelineAnalysis> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareMonitoringTimelineAnalysis());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types