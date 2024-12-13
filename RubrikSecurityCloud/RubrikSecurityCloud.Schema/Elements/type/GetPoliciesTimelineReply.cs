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

        //      C# -> List<TimelineEntry>? HighRiskCloudObjects
        // GraphQL -> highRiskCloudObjects: [TimelineEntry!]! (type)
        [JsonProperty("highRiskCloudObjects")]
        public List<TimelineEntry>? HighRiskCloudObjects { get; set; }

        //      C# -> List<TimelineEntry>? HighRiskDatacenterObjects
        // GraphQL -> highRiskDatacenterObjects: [TimelineEntry!]! (type)
        [JsonProperty("highRiskDatacenterObjects")]
        public List<TimelineEntry>? HighRiskDatacenterObjects { get; set; }

        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("highRiskObjects")]
        public List<TimelineEntry>? HighRiskObjects { get; set; }

        //      C# -> List<TimelineEntry>? HighRiskSaasObjects
        // GraphQL -> highRiskSaasObjects: [TimelineEntry!]! (type)
        [JsonProperty("highRiskSaasObjects")]
        public List<TimelineEntry>? HighRiskSaasObjects { get; set; }

        //      C# -> List<TimelineEntry>? HighRiskSensitiveFiles
        // GraphQL -> highRiskSensitiveFiles: [TimelineEntry!]! (type)
        [JsonProperty("highRiskSensitiveFiles")]
        public List<TimelineEntry>? HighRiskSensitiveFiles { get; set; }

        //      C# -> List<TimelineEntry>? HighSensitivityHits
        // GraphQL -> highSensitivityHits: [TimelineEntry!]! (type)
        [JsonProperty("highSensitivityHits")]
        public List<TimelineEntry>? HighSensitivityHits { get; set; }

        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        [JsonProperty("initialAnalysisStatus")]
        public List<TimelineCountEntry>? InitialAnalysisStatus { get; set; }

        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("lowRiskObjects")]
        public List<TimelineEntry>? LowRiskObjects { get; set; }

        //      C# -> List<TimelineEntry>? LowRiskSensitiveFiles
        // GraphQL -> lowRiskSensitiveFiles: [TimelineEntry!]! (type)
        [JsonProperty("lowRiskSensitiveFiles")]
        public List<TimelineEntry>? LowRiskSensitiveFiles { get; set; }

        //      C# -> List<TimelineEntry>? LowSensitivityHits
        // GraphQL -> lowSensitivityHits: [TimelineEntry!]! (type)
        [JsonProperty("lowSensitivityHits")]
        public List<TimelineEntry>? LowSensitivityHits { get; set; }

        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("mediumRiskObjects")]
        public List<TimelineEntry>? MediumRiskObjects { get; set; }

        //      C# -> List<TimelineEntry>? MediumRiskSensitiveFiles
        // GraphQL -> mediumRiskSensitiveFiles: [TimelineEntry!]! (type)
        [JsonProperty("mediumRiskSensitiveFiles")]
        public List<TimelineEntry>? MediumRiskSensitiveFiles { get; set; }

        //      C# -> List<TimelineEntry>? MediumSensitivityHits
        // GraphQL -> mediumSensitivityHits: [TimelineEntry!]! (type)
        [JsonProperty("mediumSensitivityHits")]
        public List<TimelineEntry>? MediumSensitivityHits { get; set; }

        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("noRiskObjects")]
        public List<TimelineEntry>? NoRiskObjects { get; set; }

        //      C# -> List<TimelineEntry>? NoRiskSensitiveFiles
        // GraphQL -> noRiskSensitiveFiles: [TimelineEntry!]! (type)
        [JsonProperty("noRiskSensitiveFiles")]
        public List<TimelineEntry>? NoRiskSensitiveFiles { get; set; }

        //      C# -> List<TimelineEntry>? NonSensitivityHits
        // GraphQL -> nonSensitivityHits: [TimelineEntry!]! (type)
        [JsonProperty("nonSensitivityHits")]
        public List<TimelineEntry>? NonSensitivityHits { get; set; }

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

        //      C# -> List<TimelineEntry>? TotalRiskObjects
        // GraphQL -> totalRiskObjects: [TimelineEntry!]! (type)
        [JsonProperty("totalRiskObjects")]
        public List<TimelineEntry>? TotalRiskObjects { get; set; }

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
        List<TimelineEntry>? HighRiskCloudObjects = null,
        List<TimelineEntry>? HighRiskDatacenterObjects = null,
        List<TimelineEntry>? HighRiskObjects = null,
        List<TimelineEntry>? HighRiskSaasObjects = null,
        List<TimelineEntry>? HighRiskSensitiveFiles = null,
        List<TimelineEntry>? HighSensitivityHits = null,
        List<TimelineCountEntry>? InitialAnalysisStatus = null,
        List<TimelineEntry>? LowRiskObjects = null,
        List<TimelineEntry>? LowRiskSensitiveFiles = null,
        List<TimelineEntry>? LowSensitivityHits = null,
        List<TimelineEntry>? MediumRiskObjects = null,
        List<TimelineEntry>? MediumRiskSensitiveFiles = null,
        List<TimelineEntry>? MediumSensitivityHits = null,
        List<TimelineEntry>? NoRiskObjects = null,
        List<TimelineEntry>? NoRiskSensitiveFiles = null,
        List<TimelineEntry>? NonSensitivityHits = null,
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
        List<TimelineEntry>? TotalRiskObjects = null,
        List<TimelineEntry>? TotalStaleFilesHitsEntries = null,
        List<TimelineEntry>? TotalStaleOaFilesEntries = null,
        List<TimelineCountEntry>? UpToDateStatus = null
    ) 
    {
        if ( HighRiskCloudObjects != null ) {
            this.HighRiskCloudObjects = HighRiskCloudObjects;
        }
        if ( HighRiskDatacenterObjects != null ) {
            this.HighRiskDatacenterObjects = HighRiskDatacenterObjects;
        }
        if ( HighRiskObjects != null ) {
            this.HighRiskObjects = HighRiskObjects;
        }
        if ( HighRiskSaasObjects != null ) {
            this.HighRiskSaasObjects = HighRiskSaasObjects;
        }
        if ( HighRiskSensitiveFiles != null ) {
            this.HighRiskSensitiveFiles = HighRiskSensitiveFiles;
        }
        if ( HighSensitivityHits != null ) {
            this.HighSensitivityHits = HighSensitivityHits;
        }
        if ( InitialAnalysisStatus != null ) {
            this.InitialAnalysisStatus = InitialAnalysisStatus;
        }
        if ( LowRiskObjects != null ) {
            this.LowRiskObjects = LowRiskObjects;
        }
        if ( LowRiskSensitiveFiles != null ) {
            this.LowRiskSensitiveFiles = LowRiskSensitiveFiles;
        }
        if ( LowSensitivityHits != null ) {
            this.LowSensitivityHits = LowSensitivityHits;
        }
        if ( MediumRiskObjects != null ) {
            this.MediumRiskObjects = MediumRiskObjects;
        }
        if ( MediumRiskSensitiveFiles != null ) {
            this.MediumRiskSensitiveFiles = MediumRiskSensitiveFiles;
        }
        if ( MediumSensitivityHits != null ) {
            this.MediumSensitivityHits = MediumSensitivityHits;
        }
        if ( NoRiskObjects != null ) {
            this.NoRiskObjects = NoRiskObjects;
        }
        if ( NoRiskSensitiveFiles != null ) {
            this.NoRiskSensitiveFiles = NoRiskSensitiveFiles;
        }
        if ( NonSensitivityHits != null ) {
            this.NonSensitivityHits = NonSensitivityHits;
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
        if ( TotalRiskObjects != null ) {
            this.TotalRiskObjects = TotalRiskObjects;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<TimelineEntry>? HighRiskCloudObjects
        // GraphQL -> highRiskCloudObjects: [TimelineEntry!]! (type)
        if (this.HighRiskCloudObjects != null) {
            var fspec = this.HighRiskCloudObjects.AsFieldSpec(conf.Child("highRiskCloudObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskCloudObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? HighRiskDatacenterObjects
        // GraphQL -> highRiskDatacenterObjects: [TimelineEntry!]! (type)
        if (this.HighRiskDatacenterObjects != null) {
            var fspec = this.HighRiskDatacenterObjects.AsFieldSpec(conf.Child("highRiskDatacenterObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskDatacenterObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        if (this.HighRiskObjects != null) {
            var fspec = this.HighRiskObjects.AsFieldSpec(conf.Child("highRiskObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? HighRiskSaasObjects
        // GraphQL -> highRiskSaasObjects: [TimelineEntry!]! (type)
        if (this.HighRiskSaasObjects != null) {
            var fspec = this.HighRiskSaasObjects.AsFieldSpec(conf.Child("highRiskSaasObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskSaasObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? HighRiskSensitiveFiles
        // GraphQL -> highRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (this.HighRiskSensitiveFiles != null) {
            var fspec = this.HighRiskSensitiveFiles.AsFieldSpec(conf.Child("highRiskSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? HighSensitivityHits
        // GraphQL -> highSensitivityHits: [TimelineEntry!]! (type)
        if (this.HighSensitivityHits != null) {
            var fspec = this.HighSensitivityHits.AsFieldSpec(conf.Child("highSensitivityHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highSensitivityHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        if (this.InitialAnalysisStatus != null) {
            var fspec = this.InitialAnalysisStatus.AsFieldSpec(conf.Child("initialAnalysisStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "initialAnalysisStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        if (this.LowRiskObjects != null) {
            var fspec = this.LowRiskObjects.AsFieldSpec(conf.Child("lowRiskObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? LowRiskSensitiveFiles
        // GraphQL -> lowRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (this.LowRiskSensitiveFiles != null) {
            var fspec = this.LowRiskSensitiveFiles.AsFieldSpec(conf.Child("lowRiskSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? LowSensitivityHits
        // GraphQL -> lowSensitivityHits: [TimelineEntry!]! (type)
        if (this.LowSensitivityHits != null) {
            var fspec = this.LowSensitivityHits.AsFieldSpec(conf.Child("lowSensitivityHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowSensitivityHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        if (this.MediumRiskObjects != null) {
            var fspec = this.MediumRiskObjects.AsFieldSpec(conf.Child("mediumRiskObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? MediumRiskSensitiveFiles
        // GraphQL -> mediumRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (this.MediumRiskSensitiveFiles != null) {
            var fspec = this.MediumRiskSensitiveFiles.AsFieldSpec(conf.Child("mediumRiskSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? MediumSensitivityHits
        // GraphQL -> mediumSensitivityHits: [TimelineEntry!]! (type)
        if (this.MediumSensitivityHits != null) {
            var fspec = this.MediumSensitivityHits.AsFieldSpec(conf.Child("mediumSensitivityHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumSensitivityHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        if (this.NoRiskObjects != null) {
            var fspec = this.NoRiskObjects.AsFieldSpec(conf.Child("noRiskObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "noRiskObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? NoRiskSensitiveFiles
        // GraphQL -> noRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (this.NoRiskSensitiveFiles != null) {
            var fspec = this.NoRiskSensitiveFiles.AsFieldSpec(conf.Child("noRiskSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "noRiskSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? NonSensitivityHits
        // GraphQL -> nonSensitivityHits: [TimelineEntry!]! (type)
        if (this.NonSensitivityHits != null) {
            var fspec = this.NonSensitivityHits.AsFieldSpec(conf.Child("nonSensitivityHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nonSensitivityHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineCountEntry>? OutOfDateStatus
        // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
        if (this.OutOfDateStatus != null) {
            var fspec = this.OutOfDateStatus.AsFieldSpec(conf.Child("outOfDateStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "outOfDateStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
        // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyFilesHitsEntries != null) {
            var fspec = this.PolicyFilesHitsEntries.AsFieldSpec(conf.Child("policyFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? PolicyHitsEntries
        // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyHitsEntries != null) {
            var fspec = this.PolicyHitsEntries.AsFieldSpec(conf.Child("policyHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
        // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyOaFilesHitsEntries != null) {
            var fspec = this.PolicyOaFilesHitsEntries.AsFieldSpec(conf.Child("policyOaFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyOaFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
        // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.PolicyStaleFilesHitsEntries != null) {
            var fspec = this.PolicyStaleFilesHitsEntries.AsFieldSpec(conf.Child("policyStaleFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyStaleFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries != null) {
            var fspec = this.PolicySummaries.AsFieldSpec(conf.Child("policySummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policySummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
        // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalFilesHitsEntries != null) {
            var fspec = this.TotalFilesHitsEntries.AsFieldSpec(conf.Child("totalFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalHitsEntries
        // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalHitsEntries != null) {
            var fspec = this.TotalHitsEntries.AsFieldSpec(conf.Child("totalHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesEntries
        // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesEntries != null) {
            var fspec = this.TotalOaFilesEntries.AsFieldSpec(conf.Child("totalOaFilesEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalOaFilesEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
        // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFilesHitsEntries != null) {
            var fspec = this.TotalOaFilesHitsEntries.AsFieldSpec(conf.Child("totalOaFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalOaFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
        // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
        if (this.TotalOaFoldersEntries != null) {
            var fspec = this.TotalOaFoldersEntries.AsFieldSpec(conf.Child("totalOaFoldersEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalOaFoldersEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalRiskObjects
        // GraphQL -> totalRiskObjects: [TimelineEntry!]! (type)
        if (this.TotalRiskObjects != null) {
            var fspec = this.TotalRiskObjects.AsFieldSpec(conf.Child("totalRiskObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalRiskObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
        // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleFilesHitsEntries != null) {
            var fspec = this.TotalStaleFilesHitsEntries.AsFieldSpec(conf.Child("totalStaleFilesHitsEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalStaleFilesHitsEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
        // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
        if (this.TotalStaleOaFilesEntries != null) {
            var fspec = this.TotalStaleOaFilesEntries.AsFieldSpec(conf.Child("totalStaleOaFilesEntries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalStaleOaFilesEntries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TimelineCountEntry>? UpToDateStatus
        // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
        if (this.UpToDateStatus != null) {
            var fspec = this.UpToDateStatus.AsFieldSpec(conf.Child("upToDateStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "upToDateStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TimelineEntry>? HighRiskCloudObjects
        // GraphQL -> highRiskCloudObjects: [TimelineEntry!]! (type)
        if (ec.Includes("highRiskCloudObjects",false))
        {
            if(this.HighRiskCloudObjects == null) {

                this.HighRiskCloudObjects = new List<TimelineEntry>();
                this.HighRiskCloudObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskCloudObjects"));

            } else {

                this.HighRiskCloudObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskCloudObjects"));

            }
        }
        else if (this.HighRiskCloudObjects != null && ec.Excludes("highRiskCloudObjects",false))
        {
            this.HighRiskCloudObjects = null;
        }
        //      C# -> List<TimelineEntry>? HighRiskDatacenterObjects
        // GraphQL -> highRiskDatacenterObjects: [TimelineEntry!]! (type)
        if (ec.Includes("highRiskDatacenterObjects",false))
        {
            if(this.HighRiskDatacenterObjects == null) {

                this.HighRiskDatacenterObjects = new List<TimelineEntry>();
                this.HighRiskDatacenterObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskDatacenterObjects"));

            } else {

                this.HighRiskDatacenterObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskDatacenterObjects"));

            }
        }
        else if (this.HighRiskDatacenterObjects != null && ec.Excludes("highRiskDatacenterObjects",false))
        {
            this.HighRiskDatacenterObjects = null;
        }
        //      C# -> List<TimelineEntry>? HighRiskObjects
        // GraphQL -> highRiskObjects: [TimelineEntry!]! (type)
        if (ec.Includes("highRiskObjects",false))
        {
            if(this.HighRiskObjects == null) {

                this.HighRiskObjects = new List<TimelineEntry>();
                this.HighRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskObjects"));

            } else {

                this.HighRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskObjects"));

            }
        }
        else if (this.HighRiskObjects != null && ec.Excludes("highRiskObjects",false))
        {
            this.HighRiskObjects = null;
        }
        //      C# -> List<TimelineEntry>? HighRiskSaasObjects
        // GraphQL -> highRiskSaasObjects: [TimelineEntry!]! (type)
        if (ec.Includes("highRiskSaasObjects",false))
        {
            if(this.HighRiskSaasObjects == null) {

                this.HighRiskSaasObjects = new List<TimelineEntry>();
                this.HighRiskSaasObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskSaasObjects"));

            } else {

                this.HighRiskSaasObjects.ApplyExploratoryFieldSpec(ec.NewChild("highRiskSaasObjects"));

            }
        }
        else if (this.HighRiskSaasObjects != null && ec.Excludes("highRiskSaasObjects",false))
        {
            this.HighRiskSaasObjects = null;
        }
        //      C# -> List<TimelineEntry>? HighRiskSensitiveFiles
        // GraphQL -> highRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (ec.Includes("highRiskSensitiveFiles",false))
        {
            if(this.HighRiskSensitiveFiles == null) {

                this.HighRiskSensitiveFiles = new List<TimelineEntry>();
                this.HighRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("highRiskSensitiveFiles"));

            } else {

                this.HighRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("highRiskSensitiveFiles"));

            }
        }
        else if (this.HighRiskSensitiveFiles != null && ec.Excludes("highRiskSensitiveFiles",false))
        {
            this.HighRiskSensitiveFiles = null;
        }
        //      C# -> List<TimelineEntry>? HighSensitivityHits
        // GraphQL -> highSensitivityHits: [TimelineEntry!]! (type)
        if (ec.Includes("highSensitivityHits",false))
        {
            if(this.HighSensitivityHits == null) {

                this.HighSensitivityHits = new List<TimelineEntry>();
                this.HighSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("highSensitivityHits"));

            } else {

                this.HighSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("highSensitivityHits"));

            }
        }
        else if (this.HighSensitivityHits != null && ec.Excludes("highSensitivityHits",false))
        {
            this.HighSensitivityHits = null;
        }
        //      C# -> List<TimelineCountEntry>? InitialAnalysisStatus
        // GraphQL -> initialAnalysisStatus: [TimelineCountEntry!]! (type)
        if (ec.Includes("initialAnalysisStatus",false))
        {
            if(this.InitialAnalysisStatus == null) {

                this.InitialAnalysisStatus = new List<TimelineCountEntry>();
                this.InitialAnalysisStatus.ApplyExploratoryFieldSpec(ec.NewChild("initialAnalysisStatus"));

            } else {

                this.InitialAnalysisStatus.ApplyExploratoryFieldSpec(ec.NewChild("initialAnalysisStatus"));

            }
        }
        else if (this.InitialAnalysisStatus != null && ec.Excludes("initialAnalysisStatus",false))
        {
            this.InitialAnalysisStatus = null;
        }
        //      C# -> List<TimelineEntry>? LowRiskObjects
        // GraphQL -> lowRiskObjects: [TimelineEntry!]! (type)
        if (ec.Includes("lowRiskObjects",false))
        {
            if(this.LowRiskObjects == null) {

                this.LowRiskObjects = new List<TimelineEntry>();
                this.LowRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskObjects"));

            } else {

                this.LowRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskObjects"));

            }
        }
        else if (this.LowRiskObjects != null && ec.Excludes("lowRiskObjects",false))
        {
            this.LowRiskObjects = null;
        }
        //      C# -> List<TimelineEntry>? LowRiskSensitiveFiles
        // GraphQL -> lowRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (ec.Includes("lowRiskSensitiveFiles",false))
        {
            if(this.LowRiskSensitiveFiles == null) {

                this.LowRiskSensitiveFiles = new List<TimelineEntry>();
                this.LowRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskSensitiveFiles"));

            } else {

                this.LowRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskSensitiveFiles"));

            }
        }
        else if (this.LowRiskSensitiveFiles != null && ec.Excludes("lowRiskSensitiveFiles",false))
        {
            this.LowRiskSensitiveFiles = null;
        }
        //      C# -> List<TimelineEntry>? LowSensitivityHits
        // GraphQL -> lowSensitivityHits: [TimelineEntry!]! (type)
        if (ec.Includes("lowSensitivityHits",false))
        {
            if(this.LowSensitivityHits == null) {

                this.LowSensitivityHits = new List<TimelineEntry>();
                this.LowSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("lowSensitivityHits"));

            } else {

                this.LowSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("lowSensitivityHits"));

            }
        }
        else if (this.LowSensitivityHits != null && ec.Excludes("lowSensitivityHits",false))
        {
            this.LowSensitivityHits = null;
        }
        //      C# -> List<TimelineEntry>? MediumRiskObjects
        // GraphQL -> mediumRiskObjects: [TimelineEntry!]! (type)
        if (ec.Includes("mediumRiskObjects",false))
        {
            if(this.MediumRiskObjects == null) {

                this.MediumRiskObjects = new List<TimelineEntry>();
                this.MediumRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskObjects"));

            } else {

                this.MediumRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskObjects"));

            }
        }
        else if (this.MediumRiskObjects != null && ec.Excludes("mediumRiskObjects",false))
        {
            this.MediumRiskObjects = null;
        }
        //      C# -> List<TimelineEntry>? MediumRiskSensitiveFiles
        // GraphQL -> mediumRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (ec.Includes("mediumRiskSensitiveFiles",false))
        {
            if(this.MediumRiskSensitiveFiles == null) {

                this.MediumRiskSensitiveFiles = new List<TimelineEntry>();
                this.MediumRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskSensitiveFiles"));

            } else {

                this.MediumRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskSensitiveFiles"));

            }
        }
        else if (this.MediumRiskSensitiveFiles != null && ec.Excludes("mediumRiskSensitiveFiles",false))
        {
            this.MediumRiskSensitiveFiles = null;
        }
        //      C# -> List<TimelineEntry>? MediumSensitivityHits
        // GraphQL -> mediumSensitivityHits: [TimelineEntry!]! (type)
        if (ec.Includes("mediumSensitivityHits",false))
        {
            if(this.MediumSensitivityHits == null) {

                this.MediumSensitivityHits = new List<TimelineEntry>();
                this.MediumSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("mediumSensitivityHits"));

            } else {

                this.MediumSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("mediumSensitivityHits"));

            }
        }
        else if (this.MediumSensitivityHits != null && ec.Excludes("mediumSensitivityHits",false))
        {
            this.MediumSensitivityHits = null;
        }
        //      C# -> List<TimelineEntry>? NoRiskObjects
        // GraphQL -> noRiskObjects: [TimelineEntry!]! (type)
        if (ec.Includes("noRiskObjects",false))
        {
            if(this.NoRiskObjects == null) {

                this.NoRiskObjects = new List<TimelineEntry>();
                this.NoRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("noRiskObjects"));

            } else {

                this.NoRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("noRiskObjects"));

            }
        }
        else if (this.NoRiskObjects != null && ec.Excludes("noRiskObjects",false))
        {
            this.NoRiskObjects = null;
        }
        //      C# -> List<TimelineEntry>? NoRiskSensitiveFiles
        // GraphQL -> noRiskSensitiveFiles: [TimelineEntry!]! (type)
        if (ec.Includes("noRiskSensitiveFiles",false))
        {
            if(this.NoRiskSensitiveFiles == null) {

                this.NoRiskSensitiveFiles = new List<TimelineEntry>();
                this.NoRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("noRiskSensitiveFiles"));

            } else {

                this.NoRiskSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("noRiskSensitiveFiles"));

            }
        }
        else if (this.NoRiskSensitiveFiles != null && ec.Excludes("noRiskSensitiveFiles",false))
        {
            this.NoRiskSensitiveFiles = null;
        }
        //      C# -> List<TimelineEntry>? NonSensitivityHits
        // GraphQL -> nonSensitivityHits: [TimelineEntry!]! (type)
        if (ec.Includes("nonSensitivityHits",false))
        {
            if(this.NonSensitivityHits == null) {

                this.NonSensitivityHits = new List<TimelineEntry>();
                this.NonSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("nonSensitivityHits"));

            } else {

                this.NonSensitivityHits.ApplyExploratoryFieldSpec(ec.NewChild("nonSensitivityHits"));

            }
        }
        else if (this.NonSensitivityHits != null && ec.Excludes("nonSensitivityHits",false))
        {
            this.NonSensitivityHits = null;
        }
        //      C# -> List<TimelineCountEntry>? OutOfDateStatus
        // GraphQL -> outOfDateStatus: [TimelineCountEntry!]! (type)
        if (ec.Includes("outOfDateStatus",false))
        {
            if(this.OutOfDateStatus == null) {

                this.OutOfDateStatus = new List<TimelineCountEntry>();
                this.OutOfDateStatus.ApplyExploratoryFieldSpec(ec.NewChild("outOfDateStatus"));

            } else {

                this.OutOfDateStatus.ApplyExploratoryFieldSpec(ec.NewChild("outOfDateStatus"));

            }
        }
        else if (this.OutOfDateStatus != null && ec.Excludes("outOfDateStatus",false))
        {
            this.OutOfDateStatus = null;
        }
        //      C# -> List<TimelineEntry>? PolicyFilesHitsEntries
        // GraphQL -> policyFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("policyFilesHitsEntries",false))
        {
            if(this.PolicyFilesHitsEntries == null) {

                this.PolicyFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyFilesHitsEntries"));

            } else {

                this.PolicyFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyFilesHitsEntries"));

            }
        }
        else if (this.PolicyFilesHitsEntries != null && ec.Excludes("policyFilesHitsEntries",false))
        {
            this.PolicyFilesHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? PolicyHitsEntries
        // GraphQL -> policyHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("policyHitsEntries",false))
        {
            if(this.PolicyHitsEntries == null) {

                this.PolicyHitsEntries = new List<TimelineEntry>();
                this.PolicyHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyHitsEntries"));

            } else {

                this.PolicyHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyHitsEntries"));

            }
        }
        else if (this.PolicyHitsEntries != null && ec.Excludes("policyHitsEntries",false))
        {
            this.PolicyHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? PolicyOaFilesHitsEntries
        // GraphQL -> policyOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("policyOaFilesHitsEntries",false))
        {
            if(this.PolicyOaFilesHitsEntries == null) {

                this.PolicyOaFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyOaFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyOaFilesHitsEntries"));

            } else {

                this.PolicyOaFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyOaFilesHitsEntries"));

            }
        }
        else if (this.PolicyOaFilesHitsEntries != null && ec.Excludes("policyOaFilesHitsEntries",false))
        {
            this.PolicyOaFilesHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? PolicyStaleFilesHitsEntries
        // GraphQL -> policyStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("policyStaleFilesHitsEntries",false))
        {
            if(this.PolicyStaleFilesHitsEntries == null) {

                this.PolicyStaleFilesHitsEntries = new List<TimelineEntry>();
                this.PolicyStaleFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyStaleFilesHitsEntries"));

            } else {

                this.PolicyStaleFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("policyStaleFilesHitsEntries"));

            }
        }
        else if (this.PolicyStaleFilesHitsEntries != null && ec.Excludes("policyStaleFilesHitsEntries",false))
        {
            this.PolicyStaleFilesHitsEntries = null;
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (ec.Includes("policySummaries",false))
        {
            if(this.PolicySummaries == null) {

                this.PolicySummaries = new List<ClassificationPolicySummary>();
                this.PolicySummaries.ApplyExploratoryFieldSpec(ec.NewChild("policySummaries"));

            } else {

                this.PolicySummaries.ApplyExploratoryFieldSpec(ec.NewChild("policySummaries"));

            }
        }
        else if (this.PolicySummaries != null && ec.Excludes("policySummaries",false))
        {
            this.PolicySummaries = null;
        }
        //      C# -> List<TimelineEntry>? TotalFilesHitsEntries
        // GraphQL -> totalFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalFilesHitsEntries",false))
        {
            if(this.TotalFilesHitsEntries == null) {

                this.TotalFilesHitsEntries = new List<TimelineEntry>();
                this.TotalFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalFilesHitsEntries"));

            } else {

                this.TotalFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalFilesHitsEntries"));

            }
        }
        else if (this.TotalFilesHitsEntries != null && ec.Excludes("totalFilesHitsEntries",false))
        {
            this.TotalFilesHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalHitsEntries
        // GraphQL -> totalHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalHitsEntries",false))
        {
            if(this.TotalHitsEntries == null) {

                this.TotalHitsEntries = new List<TimelineEntry>();
                this.TotalHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalHitsEntries"));

            } else {

                this.TotalHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalHitsEntries"));

            }
        }
        else if (this.TotalHitsEntries != null && ec.Excludes("totalHitsEntries",false))
        {
            this.TotalHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesEntries
        // GraphQL -> totalOaFilesEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalOaFilesEntries",false))
        {
            if(this.TotalOaFilesEntries == null) {

                this.TotalOaFilesEntries = new List<TimelineEntry>();
                this.TotalOaFilesEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFilesEntries"));

            } else {

                this.TotalOaFilesEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFilesEntries"));

            }
        }
        else if (this.TotalOaFilesEntries != null && ec.Excludes("totalOaFilesEntries",false))
        {
            this.TotalOaFilesEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalOaFilesHitsEntries
        // GraphQL -> totalOaFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalOaFilesHitsEntries",false))
        {
            if(this.TotalOaFilesHitsEntries == null) {

                this.TotalOaFilesHitsEntries = new List<TimelineEntry>();
                this.TotalOaFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFilesHitsEntries"));

            } else {

                this.TotalOaFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFilesHitsEntries"));

            }
        }
        else if (this.TotalOaFilesHitsEntries != null && ec.Excludes("totalOaFilesHitsEntries",false))
        {
            this.TotalOaFilesHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalOaFoldersEntries
        // GraphQL -> totalOaFoldersEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalOaFoldersEntries",false))
        {
            if(this.TotalOaFoldersEntries == null) {

                this.TotalOaFoldersEntries = new List<TimelineEntry>();
                this.TotalOaFoldersEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFoldersEntries"));

            } else {

                this.TotalOaFoldersEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalOaFoldersEntries"));

            }
        }
        else if (this.TotalOaFoldersEntries != null && ec.Excludes("totalOaFoldersEntries",false))
        {
            this.TotalOaFoldersEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalRiskObjects
        // GraphQL -> totalRiskObjects: [TimelineEntry!]! (type)
        if (ec.Includes("totalRiskObjects",false))
        {
            if(this.TotalRiskObjects == null) {

                this.TotalRiskObjects = new List<TimelineEntry>();
                this.TotalRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("totalRiskObjects"));

            } else {

                this.TotalRiskObjects.ApplyExploratoryFieldSpec(ec.NewChild("totalRiskObjects"));

            }
        }
        else if (this.TotalRiskObjects != null && ec.Excludes("totalRiskObjects",false))
        {
            this.TotalRiskObjects = null;
        }
        //      C# -> List<TimelineEntry>? TotalStaleFilesHitsEntries
        // GraphQL -> totalStaleFilesHitsEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalStaleFilesHitsEntries",false))
        {
            if(this.TotalStaleFilesHitsEntries == null) {

                this.TotalStaleFilesHitsEntries = new List<TimelineEntry>();
                this.TotalStaleFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalStaleFilesHitsEntries"));

            } else {

                this.TotalStaleFilesHitsEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalStaleFilesHitsEntries"));

            }
        }
        else if (this.TotalStaleFilesHitsEntries != null && ec.Excludes("totalStaleFilesHitsEntries",false))
        {
            this.TotalStaleFilesHitsEntries = null;
        }
        //      C# -> List<TimelineEntry>? TotalStaleOaFilesEntries
        // GraphQL -> totalStaleOaFilesEntries: [TimelineEntry!]! (type)
        if (ec.Includes("totalStaleOaFilesEntries",false))
        {
            if(this.TotalStaleOaFilesEntries == null) {

                this.TotalStaleOaFilesEntries = new List<TimelineEntry>();
                this.TotalStaleOaFilesEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalStaleOaFilesEntries"));

            } else {

                this.TotalStaleOaFilesEntries.ApplyExploratoryFieldSpec(ec.NewChild("totalStaleOaFilesEntries"));

            }
        }
        else if (this.TotalStaleOaFilesEntries != null && ec.Excludes("totalStaleOaFilesEntries",false))
        {
            this.TotalStaleOaFilesEntries = null;
        }
        //      C# -> List<TimelineCountEntry>? UpToDateStatus
        // GraphQL -> upToDateStatus: [TimelineCountEntry!]! (type)
        if (ec.Includes("upToDateStatus",false))
        {
            if(this.UpToDateStatus == null) {

                this.UpToDateStatus = new List<TimelineCountEntry>();
                this.UpToDateStatus.ApplyExploratoryFieldSpec(ec.NewChild("upToDateStatus"));

            } else {

                this.UpToDateStatus.ApplyExploratoryFieldSpec(ec.NewChild("upToDateStatus"));

            }
        }
        else if (this.UpToDateStatus != null && ec.Excludes("upToDateStatus",false))
        {
            this.UpToDateStatus = null;
        }
    }


    #endregion

    } // class GetPoliciesTimelineReply
    
    #endregion

    public static class ListGetPoliciesTimelineReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<GetPoliciesTimelineReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetPoliciesTimelineReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetPoliciesTimelineReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPoliciesTimelineReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetPoliciesTimelineReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types