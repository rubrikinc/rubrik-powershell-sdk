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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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

    public PrincipalRisk Set(
        RiskLevelType? RiskLevel = null,
        System.Int64? Date = null,
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> System.Int64? Date
        // GraphQL -> date: Long! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits != null) {
            var fspec = this.AnalyzerHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sensitiveFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sensitiveHits {\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.Int64? Date
        // GraphQL -> date: Long! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new System.Int64();
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits == null && Exploration.Includes(parent + ".analyzerHits"))
        {
            this.AnalyzerHits = new AnalyzerHits();
            this.AnalyzerHits.ApplyExploratoryFieldSpec(parent + ".analyzerHits");
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && Exploration.Includes(parent + ".sensitiveFiles"))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sensitiveFiles");
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits == null && Exploration.Includes(parent + ".sensitiveHits"))
        {
            this.SensitiveHits = new SensitiveHits();
            this.SensitiveHits.ApplyExploratoryFieldSpec(parent + ".sensitiveHits");
        }
    }


    #endregion

    } // class PrincipalRisk
    
    #endregion

    public static class ListPrincipalRiskExtensions
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
            this List<PrincipalRisk> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalRisk> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalRisk());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types