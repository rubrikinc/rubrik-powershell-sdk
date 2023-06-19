// PolicyHitsSummary.cs
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
    #region PolicyHitsSummary
    public class PolicyHitsSummary: BaseType
    {
        #region members

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        [JsonProperty("riskHits")]
        public System.Int64? RiskHits { get; set; }

        //      C# -> SensitiveHits? SidAnalyzerHits
        // GraphQL -> sidAnalyzerHits: SensitiveHits (type)
        [JsonProperty("sidAnalyzerHits")]
        public SensitiveHits? SidAnalyzerHits { get; set; }

        //      C# -> SensitiveHits? SidDeltaAnalyzerHits
        // GraphQL -> sidDeltaAnalyzerHits: SensitiveHits (type)
        [JsonProperty("sidDeltaAnalyzerHits")]
        public SensitiveHits? SidDeltaAnalyzerHits { get; set; }

        //      C# -> SensitiveObjects? SidDeltaObjectCount
        // GraphQL -> sidDeltaObjectCount: SensitiveObjects (type)
        [JsonProperty("sidDeltaObjectCount")]
        public SensitiveObjects? SidDeltaObjectCount { get; set; }

        //      C# -> SensitiveHits? SidDeltaRiskHits
        // GraphQL -> sidDeltaRiskHits: SensitiveHits (type)
        [JsonProperty("sidDeltaRiskHits")]
        public SensitiveHits? SidDeltaRiskHits { get; set; }

        //      C# -> SensitiveFiles? SidDeltaSensitiveFiles
        // GraphQL -> sidDeltaSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sidDeltaSensitiveFiles")]
        public SensitiveFiles? SidDeltaSensitiveFiles { get; set; }

        //      C# -> SensitiveObjects? SidObjectCount
        // GraphQL -> sidObjectCount: SensitiveObjects (type)
        [JsonProperty("sidObjectCount")]
        public SensitiveObjects? SidObjectCount { get; set; }

        //      C# -> SensitiveHits? SidRiskHits
        // GraphQL -> sidRiskHits: SensitiveHits (type)
        [JsonProperty("sidRiskHits")]
        public SensitiveHits? SidRiskHits { get; set; }

        //      C# -> SensitiveFiles? SidSensitiveFiles
        // GraphQL -> sidSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sidSensitiveFiles")]
        public SensitiveFiles? SidSensitiveFiles { get; set; }


        #endregion

    #region methods

    public PolicyHitsSummary Set(
        RiskLevelType? RiskLevel = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        System.Int64? RiskHits = null,
        SensitiveHits? SidAnalyzerHits = null,
        SensitiveHits? SidDeltaAnalyzerHits = null,
        SensitiveObjects? SidDeltaObjectCount = null,
        SensitiveHits? SidDeltaRiskHits = null,
        SensitiveFiles? SidDeltaSensitiveFiles = null,
        SensitiveObjects? SidObjectCount = null,
        SensitiveHits? SidRiskHits = null,
        SensitiveFiles? SidSensitiveFiles = null
    ) 
    {
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( RiskHits != null ) {
            this.RiskHits = RiskHits;
        }
        if ( SidAnalyzerHits != null ) {
            this.SidAnalyzerHits = SidAnalyzerHits;
        }
        if ( SidDeltaAnalyzerHits != null ) {
            this.SidDeltaAnalyzerHits = SidDeltaAnalyzerHits;
        }
        if ( SidDeltaObjectCount != null ) {
            this.SidDeltaObjectCount = SidDeltaObjectCount;
        }
        if ( SidDeltaRiskHits != null ) {
            this.SidDeltaRiskHits = SidDeltaRiskHits;
        }
        if ( SidDeltaSensitiveFiles != null ) {
            this.SidDeltaSensitiveFiles = SidDeltaSensitiveFiles;
        }
        if ( SidObjectCount != null ) {
            this.SidObjectCount = SidObjectCount;
        }
        if ( SidRiskHits != null ) {
            this.SidRiskHits = SidRiskHits;
        }
        if ( SidSensitiveFiles != null ) {
            this.SidSensitiveFiles = SidSensitiveFiles;
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
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            s += ind + "policyName\n" ;
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (this.RiskHits != null) {
            s += ind + "riskHits\n" ;
        }
        //      C# -> SensitiveHits? SidAnalyzerHits
        // GraphQL -> sidAnalyzerHits: SensitiveHits (type)
        if (this.SidAnalyzerHits != null) {
            var fspec = this.SidAnalyzerHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidAnalyzerHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? SidDeltaAnalyzerHits
        // GraphQL -> sidDeltaAnalyzerHits: SensitiveHits (type)
        if (this.SidDeltaAnalyzerHits != null) {
            var fspec = this.SidDeltaAnalyzerHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidDeltaAnalyzerHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveObjects? SidDeltaObjectCount
        // GraphQL -> sidDeltaObjectCount: SensitiveObjects (type)
        if (this.SidDeltaObjectCount != null) {
            var fspec = this.SidDeltaObjectCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidDeltaObjectCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? SidDeltaRiskHits
        // GraphQL -> sidDeltaRiskHits: SensitiveHits (type)
        if (this.SidDeltaRiskHits != null) {
            var fspec = this.SidDeltaRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidDeltaRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveFiles? SidDeltaSensitiveFiles
        // GraphQL -> sidDeltaSensitiveFiles: SensitiveFiles (type)
        if (this.SidDeltaSensitiveFiles != null) {
            var fspec = this.SidDeltaSensitiveFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidDeltaSensitiveFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveObjects? SidObjectCount
        // GraphQL -> sidObjectCount: SensitiveObjects (type)
        if (this.SidObjectCount != null) {
            var fspec = this.SidObjectCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidObjectCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? SidRiskHits
        // GraphQL -> sidRiskHits: SensitiveHits (type)
        if (this.SidRiskHits != null) {
            var fspec = this.SidRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveFiles? SidSensitiveFiles
        // GraphQL -> sidSensitiveFiles: SensitiveFiles (type)
        if (this.SidSensitiveFiles != null) {
            var fspec = this.SidSensitiveFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidSensitiveFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && Exploration.Includes(parent + ".riskLevel", true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = "FETCH";
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName == null && Exploration.Includes(parent + ".policyName", true))
        {
            this.PolicyName = "FETCH";
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (this.RiskHits == null && Exploration.Includes(parent + ".riskHits", true))
        {
            this.RiskHits = new System.Int64();
        }
        //      C# -> SensitiveHits? SidAnalyzerHits
        // GraphQL -> sidAnalyzerHits: SensitiveHits (type)
        if (this.SidAnalyzerHits == null && Exploration.Includes(parent + ".sidAnalyzerHits"))
        {
            this.SidAnalyzerHits = new SensitiveHits();
            this.SidAnalyzerHits.ApplyExploratoryFieldSpec(parent + ".sidAnalyzerHits");
        }
        //      C# -> SensitiveHits? SidDeltaAnalyzerHits
        // GraphQL -> sidDeltaAnalyzerHits: SensitiveHits (type)
        if (this.SidDeltaAnalyzerHits == null && Exploration.Includes(parent + ".sidDeltaAnalyzerHits"))
        {
            this.SidDeltaAnalyzerHits = new SensitiveHits();
            this.SidDeltaAnalyzerHits.ApplyExploratoryFieldSpec(parent + ".sidDeltaAnalyzerHits");
        }
        //      C# -> SensitiveObjects? SidDeltaObjectCount
        // GraphQL -> sidDeltaObjectCount: SensitiveObjects (type)
        if (this.SidDeltaObjectCount == null && Exploration.Includes(parent + ".sidDeltaObjectCount"))
        {
            this.SidDeltaObjectCount = new SensitiveObjects();
            this.SidDeltaObjectCount.ApplyExploratoryFieldSpec(parent + ".sidDeltaObjectCount");
        }
        //      C# -> SensitiveHits? SidDeltaRiskHits
        // GraphQL -> sidDeltaRiskHits: SensitiveHits (type)
        if (this.SidDeltaRiskHits == null && Exploration.Includes(parent + ".sidDeltaRiskHits"))
        {
            this.SidDeltaRiskHits = new SensitiveHits();
            this.SidDeltaRiskHits.ApplyExploratoryFieldSpec(parent + ".sidDeltaRiskHits");
        }
        //      C# -> SensitiveFiles? SidDeltaSensitiveFiles
        // GraphQL -> sidDeltaSensitiveFiles: SensitiveFiles (type)
        if (this.SidDeltaSensitiveFiles == null && Exploration.Includes(parent + ".sidDeltaSensitiveFiles"))
        {
            this.SidDeltaSensitiveFiles = new SensitiveFiles();
            this.SidDeltaSensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sidDeltaSensitiveFiles");
        }
        //      C# -> SensitiveObjects? SidObjectCount
        // GraphQL -> sidObjectCount: SensitiveObjects (type)
        if (this.SidObjectCount == null && Exploration.Includes(parent + ".sidObjectCount"))
        {
            this.SidObjectCount = new SensitiveObjects();
            this.SidObjectCount.ApplyExploratoryFieldSpec(parent + ".sidObjectCount");
        }
        //      C# -> SensitiveHits? SidRiskHits
        // GraphQL -> sidRiskHits: SensitiveHits (type)
        if (this.SidRiskHits == null && Exploration.Includes(parent + ".sidRiskHits"))
        {
            this.SidRiskHits = new SensitiveHits();
            this.SidRiskHits.ApplyExploratoryFieldSpec(parent + ".sidRiskHits");
        }
        //      C# -> SensitiveFiles? SidSensitiveFiles
        // GraphQL -> sidSensitiveFiles: SensitiveFiles (type)
        if (this.SidSensitiveFiles == null && Exploration.Includes(parent + ".sidSensitiveFiles"))
        {
            this.SidSensitiveFiles = new SensitiveFiles();
            this.SidSensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sidSensitiveFiles");
        }
    }


    #endregion

    } // class PolicyHitsSummary
    
    #endregion

    public static class ListPolicyHitsSummaryExtensions
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
            this List<PolicyHitsSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyHitsSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyHitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types