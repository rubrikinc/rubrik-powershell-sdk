// PrincipalRisk.cs
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
    #region PrincipalRisk
    public class PrincipalRisk: BaseType
    {
        #region members

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> System.Int64? Date
        // GraphQL -> date: Long! (scalar)
        [JsonProperty("date")]
        public System.Int64? Date { get; set; }

        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        [JsonProperty("hasInsights")]
        public System.Boolean? HasInsights { get; set; }

        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        [JsonProperty("analyzerHits")]
        public AnalyzerHits? AnalyzerHits { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalRisk";
    }

    public PrincipalRisk Set(
        RiskLevelType? RiskLevel = null,
        System.Int64? Date = null,
        System.Boolean? HasInsights = null,
        AnalyzerHits? AnalyzerHits = null,
        SensitiveFiles? SensitiveFiles = null,
        SensitiveHits? SensitiveHits = null
    ) 
    {
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( HasInsights != null ) {
            this.HasInsights = HasInsights;
        }
        if ( AnalyzerHits != null ) {
            this.AnalyzerHits = AnalyzerHits;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
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
        //      C# -> System.Int64? Date
        // GraphQL -> date: Long! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (this.HasInsights != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasInsights\n" ;
            } else {
                s += ind + "hasInsights\n" ;
            }
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits != null) {
            var fspec = this.AnalyzerHits.AsFieldSpec(conf.Child("analyzerHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(conf.Child("sensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(conf.Child("sensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.Int64? Date
        // GraphQL -> date: Long! (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new System.Int64();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (ec.Includes("hasInsights",true))
        {
            if(this.HasInsights == null) {

                this.HasInsights = true;

            } else {


            }
        }
        else if (this.HasInsights != null && ec.Excludes("hasInsights",true))
        {
            this.HasInsights = null;
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (ec.Includes("analyzerHits",false))
        {
            if(this.AnalyzerHits == null) {

                this.AnalyzerHits = new AnalyzerHits();
                this.AnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerHits"));

            } else {

                this.AnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerHits"));

            }
        }
        else if (this.AnalyzerHits != null && ec.Excludes("analyzerHits",false))
        {
            this.AnalyzerHits = null;
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sensitiveFiles",false))
        {
            if(this.SensitiveFiles == null) {

                this.SensitiveFiles = new SensitiveFiles();
                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            } else {

                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            }
        }
        else if (this.SensitiveFiles != null && ec.Excludes("sensitiveFiles",false))
        {
            this.SensitiveFiles = null;
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (ec.Includes("sensitiveHits",false))
        {
            if(this.SensitiveHits == null) {

                this.SensitiveHits = new SensitiveHits();
                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            } else {

                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            }
        }
        else if (this.SensitiveHits != null && ec.Excludes("sensitiveHits",false))
        {
            this.SensitiveHits = null;
        }
    }


    #endregion

    } // class PrincipalRisk
    
    #endregion

    public static class ListPrincipalRiskExtensions
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
            this List<PrincipalRisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalRisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalRisk> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalRisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalRisk> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types