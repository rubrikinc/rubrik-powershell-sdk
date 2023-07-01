// GetPoliciesTimelineReply.cs
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
    #region GetPoliciesTimelineReply
    public class GetPoliciesTimelineReply: BaseType
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

        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("mediumRiskObjects")]
        public List<TimelineEntry>? MediumRiskObjects { get; set; }

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

    public override string GetGqlTypeName() {
        return "GetPoliciesTimelineReply";
    }

    public GetPoliciesTimelineReply Set(
        List<TimelineEntry>? HighRiskObjects = null,
        List<TimelineCountEntry>? InitialAnalysisStatus = null,
        List<TimelineEntry>? LowRiskObjects = null,
        List<TimelineEntry>? MediumRiskObjects = null,
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
        if ( MediumRiskObjects != null ) {
            this.MediumRiskObjects = MediumRiskObjects;
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        if (this.HighRiskObjects != null) {
            var fspec = this.HighRiskObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "highRiskObjects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        if (this.InitialAnalysisStatus != null) {
            var fspec = this.InitialAnalysisStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "initialAnalysisStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        if (this.LowRiskObjects != null) {
            var fspec = this.LowRiskObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowRiskObjects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        if (this.MediumRiskObjects != null) {
            var fspec = this.MediumRiskObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mediumRiskObjects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        if (this.NoRiskObjects != null) {
            var fspec = this.NoRiskObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "noRiskObjects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineCountEntry>? OutOfDateStatus
        // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
        if (this.OutOfDateStatus != null) {
            var fspec = this.OutOfDateStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "outOfDateStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
        // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyFilesHitsEntries != null) {
            var fspec = this.PolicyFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? PolicyHitsEntries
        // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyHitsEntries != null) {
            var fspec = this.PolicyHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
        // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyOaFilesHitsEntries != null) {
            var fspec = this.PolicyOaFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyOaFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
        // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyStaleFilesHitsEntries != null) {
            var fspec = this.PolicyStaleFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyStaleFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries != null) {
            var fspec = this.PolicySummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policySummaries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
        // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalFilesHitsEntries != null) {
            var fspec = this.TotalFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalHitsEntries
        // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalHitsEntries != null) {
            var fspec = this.TotalHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesEntries
        // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesEntries != null) {
            var fspec = this.TotalOaFilesEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalOaFilesEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
        // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesHitsEntries != null) {
            var fspec = this.TotalOaFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalOaFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
        // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFoldersEntries != null) {
            var fspec = this.TotalOaFoldersEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalOaFoldersEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
        // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleFilesHitsEntries != null) {
            var fspec = this.TotalStaleFilesHitsEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalStaleFilesHitsEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
        // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleOaFilesEntries != null) {
            var fspec = this.TotalStaleOaFilesEntries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalStaleOaFilesEntries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TimelineCountEntry>? UpToDateStatus
        // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
        if (this.UpToDateStatus != null) {
            var fspec = this.UpToDateStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "upToDateStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        if (this.HighRiskObjects == null && Exploration.Includes(parent + ".highRiskObjects"))
        {
            this.HighRiskObjects = new List<TimelineEntry>();
            this.HighRiskObjects.ApplyExploratoryFieldSpec(parent + ".highRiskObjects");
        }
        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        if (this.InitialAnalysisStatus == null && Exploration.Includes(parent + ".initialAnalysisStatus"))
        {
            this.InitialAnalysisStatus = new List<TimelineCountEntry>();
            this.InitialAnalysisStatus.ApplyExploratoryFieldSpec(parent + ".initialAnalysisStatus");
        }
        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        if (this.LowRiskObjects == null && Exploration.Includes(parent + ".lowRiskObjects"))
        {
            this.LowRiskObjects = new List<TimelineEntry>();
            this.LowRiskObjects.ApplyExploratoryFieldSpec(parent + ".lowRiskObjects");
        }
        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        if (this.MediumRiskObjects == null && Exploration.Includes(parent + ".mediumRiskObjects"))
        {
            this.MediumRiskObjects = new List<TimelineEntry>();
            this.MediumRiskObjects.ApplyExploratoryFieldSpec(parent + ".mediumRiskObjects");
        }
        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        if (this.NoRiskObjects == null && Exploration.Includes(parent + ".noRiskObjects"))
        {
            this.NoRiskObjects = new List<TimelineEntry>();
            this.NoRiskObjects.ApplyExploratoryFieldSpec(parent + ".noRiskObjects");
        }
        //      C# -> List<TimelineCountEntry>? OutOfDateStatus
        // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
        if (this.OutOfDateStatus == null && Exploration.Includes(parent + ".outOfDateStatus"))
        {
            this.OutOfDateStatus = new List<TimelineCountEntry>();
            this.OutOfDateStatus.ApplyExploratoryFieldSpec(parent + ".outOfDateStatus");
        }
        //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
        // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyFilesHitsEntries == null && Exploration.Includes(parent + ".policyFilesHitsEntries"))
        {
            this.PolicyFilesHitsEntries = new List<TimelineEntry>();
            this.PolicyFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".policyFilesHitsEntries");
        }
        //      C# -> List<TimelineEntry>? PolicyHitsEntries
        // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyHitsEntries == null && Exploration.Includes(parent + ".policyHitsEntries"))
        {
            this.PolicyHitsEntries = new List<TimelineEntry>();
            this.PolicyHitsEntries.ApplyExploratoryFieldSpec(parent + ".policyHitsEntries");
        }
        //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
        // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyOaFilesHitsEntries == null && Exploration.Includes(parent + ".policyOaFilesHitsEntries"))
        {
            this.PolicyOaFilesHitsEntries = new List<TimelineEntry>();
            this.PolicyOaFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".policyOaFilesHitsEntries");
        }
        //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
        // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyStaleFilesHitsEntries == null && Exploration.Includes(parent + ".policyStaleFilesHitsEntries"))
        {
            this.PolicyStaleFilesHitsEntries = new List<TimelineEntry>();
            this.PolicyStaleFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".policyStaleFilesHitsEntries");
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries == null && Exploration.Includes(parent + ".policySummaries"))
        {
            this.PolicySummaries = new List<ClassificationPolicySummary>();
            this.PolicySummaries.ApplyExploratoryFieldSpec(parent + ".policySummaries");
        }
        //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
        // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalFilesHitsEntries == null && Exploration.Includes(parent + ".totalFilesHitsEntries"))
        {
            this.TotalFilesHitsEntries = new List<TimelineEntry>();
            this.TotalFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".totalFilesHitsEntries");
        }
        //      C# -> List<TimelineEntry>? TotalHitsEntries
        // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalHitsEntries == null && Exploration.Includes(parent + ".totalHitsEntries"))
        {
            this.TotalHitsEntries = new List<TimelineEntry>();
            this.TotalHitsEntries.ApplyExploratoryFieldSpec(parent + ".totalHitsEntries");
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesEntries
        // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesEntries == null && Exploration.Includes(parent + ".totalOaFilesEntries"))
        {
            this.TotalOaFilesEntries = new List<TimelineEntry>();
            this.TotalOaFilesEntries.ApplyExploratoryFieldSpec(parent + ".totalOaFilesEntries");
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
        // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesHitsEntries == null && Exploration.Includes(parent + ".totalOaFilesHitsEntries"))
        {
            this.TotalOaFilesHitsEntries = new List<TimelineEntry>();
            this.TotalOaFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".totalOaFilesHitsEntries");
        }
        //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
        // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFoldersEntries == null && Exploration.Includes(parent + ".totalOaFoldersEntries"))
        {
            this.TotalOaFoldersEntries = new List<TimelineEntry>();
            this.TotalOaFoldersEntries.ApplyExploratoryFieldSpec(parent + ".totalOaFoldersEntries");
        }
        //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
        // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleFilesHitsEntries == null && Exploration.Includes(parent + ".totalStaleFilesHitsEntries"))
        {
            this.TotalStaleFilesHitsEntries = new List<TimelineEntry>();
            this.TotalStaleFilesHitsEntries.ApplyExploratoryFieldSpec(parent + ".totalStaleFilesHitsEntries");
        }
        //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
        // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleOaFilesEntries == null && Exploration.Includes(parent + ".totalStaleOaFilesEntries"))
        {
            this.TotalStaleOaFilesEntries = new List<TimelineEntry>();
            this.TotalStaleOaFilesEntries.ApplyExploratoryFieldSpec(parent + ".totalStaleOaFilesEntries");
        }
        //      C# -> List<TimelineCountEntry>? UpToDateStatus
        // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
        if (this.UpToDateStatus == null && Exploration.Includes(parent + ".upToDateStatus"))
        {
            this.UpToDateStatus = new List<TimelineCountEntry>();
            this.UpToDateStatus.ApplyExploratoryFieldSpec(parent + ".upToDateStatus");
        }
    }


    #endregion

    } // class GetPoliciesTimelineReply
    
    #endregion

    public static class ListGetPoliciesTimelineReplyExtensions
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
            this List<GetPoliciesTimelineReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPoliciesTimelineReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPoliciesTimelineReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types