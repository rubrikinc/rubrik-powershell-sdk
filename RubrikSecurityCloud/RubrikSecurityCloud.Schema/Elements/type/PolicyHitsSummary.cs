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

    public override string GetGqlTypeName() {
        return "PolicyHitsSummary";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskLevel\n" ;
            } else {
                s += ind + "riskLevel\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
            }
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (this.RiskHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskHits\n" ;
            } else {
                s += ind + "riskHits\n" ;
            }
        }
        //      C# -> SensitiveHits? SidAnalyzerHits
        // GraphQL -> sidAnalyzerHits: SensitiveHits (type)
        if (this.SidAnalyzerHits != null) {
            var fspec = this.SidAnalyzerHits.AsFieldSpec(conf.Child("sidAnalyzerHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidAnalyzerHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SidDeltaAnalyzerHits
        // GraphQL -> sidDeltaAnalyzerHits: SensitiveHits (type)
        if (this.SidDeltaAnalyzerHits != null) {
            var fspec = this.SidDeltaAnalyzerHits.AsFieldSpec(conf.Child("sidDeltaAnalyzerHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidDeltaAnalyzerHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveObjects? SidDeltaObjectCount
        // GraphQL -> sidDeltaObjectCount: SensitiveObjects (type)
        if (this.SidDeltaObjectCount != null) {
            var fspec = this.SidDeltaObjectCount.AsFieldSpec(conf.Child("sidDeltaObjectCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidDeltaObjectCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SidDeltaRiskHits
        // GraphQL -> sidDeltaRiskHits: SensitiveHits (type)
        if (this.SidDeltaRiskHits != null) {
            var fspec = this.SidDeltaRiskHits.AsFieldSpec(conf.Child("sidDeltaRiskHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidDeltaRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SidDeltaSensitiveFiles
        // GraphQL -> sidDeltaSensitiveFiles: SensitiveFiles (type)
        if (this.SidDeltaSensitiveFiles != null) {
            var fspec = this.SidDeltaSensitiveFiles.AsFieldSpec(conf.Child("sidDeltaSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidDeltaSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveObjects? SidObjectCount
        // GraphQL -> sidObjectCount: SensitiveObjects (type)
        if (this.SidObjectCount != null) {
            var fspec = this.SidObjectCount.AsFieldSpec(conf.Child("sidObjectCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidObjectCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SidRiskHits
        // GraphQL -> sidRiskHits: SensitiveHits (type)
        if (this.SidRiskHits != null) {
            var fspec = this.SidRiskHits.AsFieldSpec(conf.Child("sidRiskHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SidSensitiveFiles
        // GraphQL -> sidSensitiveFiles: SensitiveFiles (type)
        if (this.SidSensitiveFiles != null) {
            var fspec = this.SidSensitiveFiles.AsFieldSpec(conf.Child("sidSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sidSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (ec.Includes("riskLevel",true))
        {
            if(this.RiskLevel == null) {

                this.RiskLevel = new RiskLevelType();

            } else {


            }
        }
        else if (this.RiskLevel != null && ec.Excludes("riskLevel",true))
        {
            this.RiskLevel = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (ec.Includes("riskHits",true))
        {
            if(this.RiskHits == null) {

                this.RiskHits = new System.Int64();

            } else {


            }
        }
        else if (this.RiskHits != null && ec.Excludes("riskHits",true))
        {
            this.RiskHits = null;
        }
        //      C# -> SensitiveHits? SidAnalyzerHits
        // GraphQL -> sidAnalyzerHits: SensitiveHits (type)
        if (ec.Includes("sidAnalyzerHits",false))
        {
            if(this.SidAnalyzerHits == null) {

                this.SidAnalyzerHits = new SensitiveHits();
                this.SidAnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("sidAnalyzerHits"));

            } else {

                this.SidAnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("sidAnalyzerHits"));

            }
        }
        else if (this.SidAnalyzerHits != null && ec.Excludes("sidAnalyzerHits",false))
        {
            this.SidAnalyzerHits = null;
        }
        //      C# -> SensitiveHits? SidDeltaAnalyzerHits
        // GraphQL -> sidDeltaAnalyzerHits: SensitiveHits (type)
        if (ec.Includes("sidDeltaAnalyzerHits",false))
        {
            if(this.SidDeltaAnalyzerHits == null) {

                this.SidDeltaAnalyzerHits = new SensitiveHits();
                this.SidDeltaAnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaAnalyzerHits"));

            } else {

                this.SidDeltaAnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaAnalyzerHits"));

            }
        }
        else if (this.SidDeltaAnalyzerHits != null && ec.Excludes("sidDeltaAnalyzerHits",false))
        {
            this.SidDeltaAnalyzerHits = null;
        }
        //      C# -> SensitiveObjects? SidDeltaObjectCount
        // GraphQL -> sidDeltaObjectCount: SensitiveObjects (type)
        if (ec.Includes("sidDeltaObjectCount",false))
        {
            if(this.SidDeltaObjectCount == null) {

                this.SidDeltaObjectCount = new SensitiveObjects();
                this.SidDeltaObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaObjectCount"));

            } else {

                this.SidDeltaObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaObjectCount"));

            }
        }
        else if (this.SidDeltaObjectCount != null && ec.Excludes("sidDeltaObjectCount",false))
        {
            this.SidDeltaObjectCount = null;
        }
        //      C# -> SensitiveHits? SidDeltaRiskHits
        // GraphQL -> sidDeltaRiskHits: SensitiveHits (type)
        if (ec.Includes("sidDeltaRiskHits",false))
        {
            if(this.SidDeltaRiskHits == null) {

                this.SidDeltaRiskHits = new SensitiveHits();
                this.SidDeltaRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaRiskHits"));

            } else {

                this.SidDeltaRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaRiskHits"));

            }
        }
        else if (this.SidDeltaRiskHits != null && ec.Excludes("sidDeltaRiskHits",false))
        {
            this.SidDeltaRiskHits = null;
        }
        //      C# -> SensitiveFiles? SidDeltaSensitiveFiles
        // GraphQL -> sidDeltaSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sidDeltaSensitiveFiles",false))
        {
            if(this.SidDeltaSensitiveFiles == null) {

                this.SidDeltaSensitiveFiles = new SensitiveFiles();
                this.SidDeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaSensitiveFiles"));

            } else {

                this.SidDeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sidDeltaSensitiveFiles"));

            }
        }
        else if (this.SidDeltaSensitiveFiles != null && ec.Excludes("sidDeltaSensitiveFiles",false))
        {
            this.SidDeltaSensitiveFiles = null;
        }
        //      C# -> SensitiveObjects? SidObjectCount
        // GraphQL -> sidObjectCount: SensitiveObjects (type)
        if (ec.Includes("sidObjectCount",false))
        {
            if(this.SidObjectCount == null) {

                this.SidObjectCount = new SensitiveObjects();
                this.SidObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sidObjectCount"));

            } else {

                this.SidObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sidObjectCount"));

            }
        }
        else if (this.SidObjectCount != null && ec.Excludes("sidObjectCount",false))
        {
            this.SidObjectCount = null;
        }
        //      C# -> SensitiveHits? SidRiskHits
        // GraphQL -> sidRiskHits: SensitiveHits (type)
        if (ec.Includes("sidRiskHits",false))
        {
            if(this.SidRiskHits == null) {

                this.SidRiskHits = new SensitiveHits();
                this.SidRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("sidRiskHits"));

            } else {

                this.SidRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("sidRiskHits"));

            }
        }
        else if (this.SidRiskHits != null && ec.Excludes("sidRiskHits",false))
        {
            this.SidRiskHits = null;
        }
        //      C# -> SensitiveFiles? SidSensitiveFiles
        // GraphQL -> sidSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sidSensitiveFiles",false))
        {
            if(this.SidSensitiveFiles == null) {

                this.SidSensitiveFiles = new SensitiveFiles();
                this.SidSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sidSensitiveFiles"));

            } else {

                this.SidSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sidSensitiveFiles"));

            }
        }
        else if (this.SidSensitiveFiles != null && ec.Excludes("sidSensitiveFiles",false))
        {
            this.SidSensitiveFiles = null;
        }
    }


    #endregion

    } // class PolicyHitsSummary
    
    #endregion

    public static class ListPolicyHitsSummaryExtensions
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
            this List<PolicyHitsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyHitsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyHitsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyHitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyHitsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types