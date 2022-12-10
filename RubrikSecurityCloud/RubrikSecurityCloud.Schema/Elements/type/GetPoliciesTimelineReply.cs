// GetPoliciesTimelineReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
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
    #region GetPoliciesTimelineReply
    public class GetPoliciesTimelineReply: IFragment
    {
        #region members
        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("highRiskObjects")]
        public List<TimelineEntry>? HighRiskObjects { get; set; }

        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        [JsonProperty("initialAnalysisStatus")]
        public List<TimelineCountEntry>? InitialAnalysisStatus { get; set; }

        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("lowRiskObjects")]
        public List<TimelineEntry>? LowRiskObjects { get; set; }

        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("noRiskObjects")]
        public List<TimelineEntry>? NoRiskObjects { get; set; }

        //      C# -> List<TimelineCountEntry>? OutOfDateStatus
        // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
        [JsonProperty("outOfDateStatus")]
        public List<TimelineCountEntry>? OutOfDateStatus { get; set; }

        //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
        // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("policyFilesHitsEntries")]
        public List<TimelineEntry>? PolicyFilesHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? PolicyHitsEntries
        // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("policyHitsEntries")]
        public List<TimelineEntry>? PolicyHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
        // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("policyOaFilesHitsEntries")]
        public List<TimelineEntry>? PolicyOaFilesHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
        // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("policyStaleFilesHitsEntries")]
        public List<TimelineEntry>? PolicyStaleFilesHitsEntries { get; set; }

        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policySummaries")]
        public List<ClassificationPolicySummary>? PolicySummaries { get; set; }

        //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
        // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalFilesHitsEntries")]
        public List<TimelineEntry>? TotalFilesHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalHitsEntries
        // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalHitsEntries")]
        public List<TimelineEntry>? TotalHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalOaFilesEntries
        // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalOaFilesEntries")]
        public List<TimelineEntry>? TotalOaFilesEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
        // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalOaFilesHitsEntries")]
        public List<TimelineEntry>? TotalOaFilesHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
        // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalOaFoldersEntries")]
        public List<TimelineEntry>? TotalOaFoldersEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
        // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalStaleFilesHitsEntries")]
        public List<TimelineEntry>? TotalStaleFilesHitsEntries { get; set; }

        //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
        // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
        [JsonProperty("totalStaleOaFilesEntries")]
        public List<TimelineEntry>? TotalStaleOaFilesEntries { get; set; }

        //      C# -> List<TimelineCountEntry>? UpToDateStatus
        // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
        [JsonProperty("upToDateStatus")]
        public List<TimelineCountEntry>? UpToDateStatus { get; set; }

        #endregion

    #region methods

    public GetPoliciesTimelineReply Set(
        List<TimelineEntry>? HighRiskObjects = null,
        List<TimelineCountEntry>? InitialAnalysisStatus = null,
        List<TimelineEntry>? LowRiskObjects = null,
        List<TimelineEntry>? NoRiskObjects = null,
        List<TimelineCountEntry>? OutOfDateStatus = null,
        List<TimelineEntry>? PolicyFilesHitsEntries = null,
        List<TimelineEntry>? PolicyHitsEntries = null,
        List<TimelineEntry>? PolicyOaFilesHitsEntries = null,
        List<TimelineEntry>? PolicyStaleFilesHitsEntries = null,
        List<ClassificationPolicySummary>? PolicySummaries = null,
        List<TimelineEntry>? TotalFilesHitsEntries = null,
        List<TimelineEntry>? TotalHitsEntries = null,
        List<TimelineEntry>? TotalOaFilesEntries = null,
        List<TimelineEntry>? TotalOaFilesHitsEntries = null,
        List<TimelineEntry>? TotalOaFoldersEntries = null,
        List<TimelineEntry>? TotalStaleFilesHitsEntries = null,
        List<TimelineEntry>? TotalStaleOaFilesEntries = null,
        List<TimelineCountEntry>? UpToDateStatus = null
    ) 
    {
        if ( HighRiskObjects != null ) {
            this.HighRiskObjects = HighRiskObjects;
        }
        if ( InitialAnalysisStatus != null ) {
            this.InitialAnalysisStatus = InitialAnalysisStatus;
        }
        if ( LowRiskObjects != null ) {
            this.LowRiskObjects = LowRiskObjects;
        }
        if ( NoRiskObjects != null ) {
            this.NoRiskObjects = NoRiskObjects;
        }
        if ( OutOfDateStatus != null ) {
            this.OutOfDateStatus = OutOfDateStatus;
        }
        if ( PolicyFilesHitsEntries != null ) {
            this.PolicyFilesHitsEntries = PolicyFilesHitsEntries;
        }
        if ( PolicyHitsEntries != null ) {
            this.PolicyHitsEntries = PolicyHitsEntries;
        }
        if ( PolicyOaFilesHitsEntries != null ) {
            this.PolicyOaFilesHitsEntries = PolicyOaFilesHitsEntries;
        }
        if ( PolicyStaleFilesHitsEntries != null ) {
            this.PolicyStaleFilesHitsEntries = PolicyStaleFilesHitsEntries;
        }
        if ( PolicySummaries != null ) {
            this.PolicySummaries = PolicySummaries;
        }
        if ( TotalFilesHitsEntries != null ) {
            this.TotalFilesHitsEntries = TotalFilesHitsEntries;
        }
        if ( TotalHitsEntries != null ) {
            this.TotalHitsEntries = TotalHitsEntries;
        }
        if ( TotalOaFilesEntries != null ) {
            this.TotalOaFilesEntries = TotalOaFilesEntries;
        }
        if ( TotalOaFilesHitsEntries != null ) {
            this.TotalOaFilesHitsEntries = TotalOaFilesHitsEntries;
        }
        if ( TotalOaFoldersEntries != null ) {
            this.TotalOaFoldersEntries = TotalOaFoldersEntries;
        }
        if ( TotalStaleFilesHitsEntries != null ) {
            this.TotalStaleFilesHitsEntries = TotalStaleFilesHitsEntries;
        }
        if ( TotalStaleOaFilesEntries != null ) {
            this.TotalStaleOaFilesEntries = TotalStaleOaFilesEntries;
        }
        if ( UpToDateStatus != null ) {
            this.UpToDateStatus = UpToDateStatus;
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
            //      C# -> List<TimelineEntry>? HighRiskObjects
            // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
            if (this.HighRiskObjects != null)
            {
                 s += ind + "highRiskObjects\n";

                 s += ind + "{\n" + 
                 this.HighRiskObjects.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
            // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
            if (this.InitialAnalysisStatus != null)
            {
                 s += ind + "initialAnalysisStatus\n";

                 s += ind + "{\n" + 
                 this.InitialAnalysisStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? LowRiskObjects
            // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
            if (this.LowRiskObjects != null)
            {
                 s += ind + "lowRiskObjects\n";

                 s += ind + "{\n" + 
                 this.LowRiskObjects.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? NoRiskObjects
            // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
            if (this.NoRiskObjects != null)
            {
                 s += ind + "noRiskObjects\n";

                 s += ind + "{\n" + 
                 this.NoRiskObjects.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineCountEntry>? OutOfDateStatus
            // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
            if (this.OutOfDateStatus != null)
            {
                 s += ind + "outOfDateStatus\n";

                 s += ind + "{\n" + 
                 this.OutOfDateStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
            // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyFilesHitsEntries != null)
            {
                 s += ind + "policyFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.PolicyFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? PolicyHitsEntries
            // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyHitsEntries != null)
            {
                 s += ind + "policyHitsEntries\n";

                 s += ind + "{\n" + 
                 this.PolicyHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
            // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyOaFilesHitsEntries != null)
            {
                 s += ind + "policyOaFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.PolicyOaFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
            // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyStaleFilesHitsEntries != null)
            {
                 s += ind + "policyStaleFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.PolicyStaleFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClassificationPolicySummary>? PolicySummaries
            // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
            if (this.PolicySummaries != null)
            {
                 s += ind + "policySummaries\n";

                 s += ind + "{\n" + 
                 this.PolicySummaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
            // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalFilesHitsEntries != null)
            {
                 s += ind + "totalFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.TotalFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalHitsEntries
            // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalHitsEntries != null)
            {
                 s += ind + "totalHitsEntries\n";

                 s += ind + "{\n" + 
                 this.TotalHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalOaFilesEntries
            // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFilesEntries != null)
            {
                 s += ind + "totalOaFilesEntries\n";

                 s += ind + "{\n" + 
                 this.TotalOaFilesEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
            // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFilesHitsEntries != null)
            {
                 s += ind + "totalOaFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.TotalOaFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
            // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFoldersEntries != null)
            {
                 s += ind + "totalOaFoldersEntries\n";

                 s += ind + "{\n" + 
                 this.TotalOaFoldersEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
            // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalStaleFilesHitsEntries != null)
            {
                 s += ind + "totalStaleFilesHitsEntries\n";

                 s += ind + "{\n" + 
                 this.TotalStaleFilesHitsEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
            // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
            if (this.TotalStaleOaFilesEntries != null)
            {
                 s += ind + "totalStaleOaFilesEntries\n";

                 s += ind + "{\n" + 
                 this.TotalStaleOaFilesEntries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TimelineCountEntry>? UpToDateStatus
            // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
            if (this.UpToDateStatus != null)
            {
                 s += ind + "upToDateStatus\n";

                 s += ind + "{\n" + 
                 this.UpToDateStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<TimelineEntry>? HighRiskObjects
            // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
            if (this.HighRiskObjects == null && Exploration.Includes(parent + ".highRiskObjects"))
            {
                this.HighRiskObjects = new List<TimelineEntry>();
                this.HighRiskObjects.ApplyExploratoryFragment(parent + ".highRiskObjects");
            }
            //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
            // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
            if (this.InitialAnalysisStatus == null && Exploration.Includes(parent + ".initialAnalysisStatus"))
            {
                this.InitialAnalysisStatus = new List<TimelineCountEntry>();
                this.InitialAnalysisStatus.ApplyExploratoryFragment(parent + ".initialAnalysisStatus");
            }
            //      C# -> List<TimelineEntry>? LowRiskObjects
            // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
            if (this.LowRiskObjects == null && Exploration.Includes(parent + ".lowRiskObjects"))
            {
                this.LowRiskObjects = new List<TimelineEntry>();
                this.LowRiskObjects.ApplyExploratoryFragment(parent + ".lowRiskObjects");
            }
            //      C# -> List<TimelineEntry>? NoRiskObjects
            // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
            if (this.NoRiskObjects == null && Exploration.Includes(parent + ".noRiskObjects"))
            {
                this.NoRiskObjects = new List<TimelineEntry>();
                this.NoRiskObjects.ApplyExploratoryFragment(parent + ".noRiskObjects");
            }
            //      C# -> List<TimelineCountEntry>? OutOfDateStatus
            // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
            if (this.OutOfDateStatus == null && Exploration.Includes(parent + ".outOfDateStatus"))
            {
                this.OutOfDateStatus = new List<TimelineCountEntry>();
                this.OutOfDateStatus.ApplyExploratoryFragment(parent + ".outOfDateStatus");
            }
            //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
            // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyFilesHitsEntries == null && Exploration.Includes(parent + ".policyFilesHitsEntries"))
            {
                this.PolicyFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyFilesHitsEntries.ApplyExploratoryFragment(parent + ".policyFilesHitsEntries");
            }
            //      C# -> List<TimelineEntry>? PolicyHitsEntries
            // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyHitsEntries == null && Exploration.Includes(parent + ".policyHitsEntries"))
            {
                this.PolicyHitsEntries = new List<TimelineEntry>();
                this.PolicyHitsEntries.ApplyExploratoryFragment(parent + ".policyHitsEntries");
            }
            //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
            // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyOaFilesHitsEntries == null && Exploration.Includes(parent + ".policyOaFilesHitsEntries"))
            {
                this.PolicyOaFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyOaFilesHitsEntries.ApplyExploratoryFragment(parent + ".policyOaFilesHitsEntries");
            }
            //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
            // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.PolicyStaleFilesHitsEntries == null && Exploration.Includes(parent + ".policyStaleFilesHitsEntries"))
            {
                this.PolicyStaleFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyStaleFilesHitsEntries.ApplyExploratoryFragment(parent + ".policyStaleFilesHitsEntries");
            }
            //      C# -> List<ClassificationPolicySummary>? PolicySummaries
            // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
            if (this.PolicySummaries == null && Exploration.Includes(parent + ".policySummaries"))
            {
                this.PolicySummaries = new List<ClassificationPolicySummary>();
                this.PolicySummaries.ApplyExploratoryFragment(parent + ".policySummaries");
            }
            //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
            // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalFilesHitsEntries == null && Exploration.Includes(parent + ".totalFilesHitsEntries"))
            {
                this.TotalFilesHitsEntries = new List<TimelineEntry>();
                this.TotalFilesHitsEntries.ApplyExploratoryFragment(parent + ".totalFilesHitsEntries");
            }
            //      C# -> List<TimelineEntry>? TotalHitsEntries
            // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalHitsEntries == null && Exploration.Includes(parent + ".totalHitsEntries"))
            {
                this.TotalHitsEntries = new List<TimelineEntry>();
                this.TotalHitsEntries.ApplyExploratoryFragment(parent + ".totalHitsEntries");
            }
            //      C# -> List<TimelineEntry>? TotalOaFilesEntries
            // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFilesEntries == null && Exploration.Includes(parent + ".totalOaFilesEntries"))
            {
                this.TotalOaFilesEntries = new List<TimelineEntry>();
                this.TotalOaFilesEntries.ApplyExploratoryFragment(parent + ".totalOaFilesEntries");
            }
            //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
            // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFilesHitsEntries == null && Exploration.Includes(parent + ".totalOaFilesHitsEntries"))
            {
                this.TotalOaFilesHitsEntries = new List<TimelineEntry>();
                this.TotalOaFilesHitsEntries.ApplyExploratoryFragment(parent + ".totalOaFilesHitsEntries");
            }
            //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
            // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
            if (this.TotalOaFoldersEntries == null && Exploration.Includes(parent + ".totalOaFoldersEntries"))
            {
                this.TotalOaFoldersEntries = new List<TimelineEntry>();
                this.TotalOaFoldersEntries.ApplyExploratoryFragment(parent + ".totalOaFoldersEntries");
            }
            //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
            // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
            if (this.TotalStaleFilesHitsEntries == null && Exploration.Includes(parent + ".totalStaleFilesHitsEntries"))
            {
                this.TotalStaleFilesHitsEntries = new List<TimelineEntry>();
                this.TotalStaleFilesHitsEntries.ApplyExploratoryFragment(parent + ".totalStaleFilesHitsEntries");
            }
            //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
            // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
            if (this.TotalStaleOaFilesEntries == null && Exploration.Includes(parent + ".totalStaleOaFilesEntries"))
            {
                this.TotalStaleOaFilesEntries = new List<TimelineEntry>();
                this.TotalStaleOaFilesEntries.ApplyExploratoryFragment(parent + ".totalStaleOaFilesEntries");
            }
            //      C# -> List<TimelineCountEntry>? UpToDateStatus
            // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
            if (this.UpToDateStatus == null && Exploration.Includes(parent + ".upToDateStatus"))
            {
                this.UpToDateStatus = new List<TimelineCountEntry>();
                this.UpToDateStatus.ApplyExploratoryFragment(parent + ".upToDateStatus");
            }
        }


    #endregion

    } // class GetPoliciesTimelineReply
    #endregion

    public static class ListGetPoliciesTimelineReplyExtensions
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
            this List<GetPoliciesTimelineReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetPoliciesTimelineReply> list, 
            String parent = "")
        {
            var item = new GetPoliciesTimelineReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types