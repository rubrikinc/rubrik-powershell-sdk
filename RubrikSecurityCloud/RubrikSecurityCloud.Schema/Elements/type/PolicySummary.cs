// PolicySummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region PolicySummary
    public class PolicySummary: IFragment
    {
        #region members
        //      C# -> TimelineEntry? HighRiskFiles
        // GraphQL -> highRiskFiles: TimelineEntry (type)
        [JsonProperty("highRiskFiles")]
        public TimelineEntry? HighRiskFiles { get; set; }

        //      C# -> TimelineEntry? LowRiskFiles
        // GraphQL -> lowRiskFiles: TimelineEntry (type)
        [JsonProperty("lowRiskFiles")]
        public TimelineEntry? LowRiskFiles { get; set; }

        //      C# -> ClassificationPolicySummary? Summary
        // GraphQL -> summary: ClassificationPolicySummary (type)
        [JsonProperty("summary")]
        public ClassificationPolicySummary? Summary { get; set; }

        #endregion

    #region methods

    public PolicySummary Set(
        TimelineEntry? HighRiskFiles = null,
        TimelineEntry? LowRiskFiles = null,
        ClassificationPolicySummary? Summary = null
    ) 
    {
        if ( HighRiskFiles != null ) {
            this.HighRiskFiles = HighRiskFiles;
        }
        if ( LowRiskFiles != null ) {
            this.LowRiskFiles = LowRiskFiles;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> TimelineEntry? HighRiskFiles
            // GraphQL -> highRiskFiles: TimelineEntry (type)
            if (this.HighRiskFiles != null)
            {
                 s += ind + "highRiskFiles\n";

                 s += ind + "{\n" + 
                 this.HighRiskFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TimelineEntry? LowRiskFiles
            // GraphQL -> lowRiskFiles: TimelineEntry (type)
            if (this.LowRiskFiles != null)
            {
                 s += ind + "lowRiskFiles\n";

                 s += ind + "{\n" + 
                 this.LowRiskFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClassificationPolicySummary? Summary
            // GraphQL -> summary: ClassificationPolicySummary (type)
            if (this.Summary != null)
            {
                 s += ind + "summary\n";

                 s += ind + "{\n" + 
                 this.Summary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> TimelineEntry? HighRiskFiles
            // GraphQL -> highRiskFiles: TimelineEntry (type)
            if (this.HighRiskFiles == null && Exploration.Includes(parent + ".highRiskFiles"))
            {
                this.HighRiskFiles = new TimelineEntry();
                this.HighRiskFiles.ApplyExploratoryFragment(parent + ".highRiskFiles");
            }
            //      C# -> TimelineEntry? LowRiskFiles
            // GraphQL -> lowRiskFiles: TimelineEntry (type)
            if (this.LowRiskFiles == null && Exploration.Includes(parent + ".lowRiskFiles"))
            {
                this.LowRiskFiles = new TimelineEntry();
                this.LowRiskFiles.ApplyExploratoryFragment(parent + ".lowRiskFiles");
            }
            //      C# -> ClassificationPolicySummary? Summary
            // GraphQL -> summary: ClassificationPolicySummary (type)
            if (this.Summary == null && Exploration.Includes(parent + ".summary"))
            {
                this.Summary = new ClassificationPolicySummary();
                this.Summary.ApplyExploratoryFragment(parent + ".summary");
            }
        }


    #endregion

    } // class PolicySummary
    #endregion

    public static class ListPolicySummaryExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<PolicySummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolicySummary> list, 
            String parent = "")
        {
            var item = new PolicySummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types