// PrincipalSummary.cs
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
    #region PrincipalSummary
    public class PrincipalSummary: BaseType
    {
        #region members

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        [JsonProperty("domainId")]
        public System.String? DomainId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        [JsonProperty("numDescendants")]
        public System.Int32? NumDescendants { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        [JsonProperty("upn")]
        public System.String? Upn { get; set; }

        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        [JsonProperty("deltaSensitiveHits")]
        public SummaryHits? DeltaSensitiveHits { get; set; }

        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        [JsonProperty("riskReasons")]
        public PrincipalRiskReasons? RiskReasons { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        [JsonProperty("sensitiveObjectCount")]
        public SummaryCount? SensitiveObjectCount { get; set; }

        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        [JsonProperty("totalSensitiveHits")]
        public SummaryHits? TotalSensitiveHits { get; set; }


        #endregion

    #region methods

    public PrincipalSummary Set(
        RiskLevelType? RiskLevel = null,
        System.String? DomainId = null,
        System.String? DomainName = null,
        System.String? FullName = null,
        System.Int32? NumDescendants = null,
        System.String? PrincipalId = null,
        System.String? Upn = null,
        SummaryHits? DeltaSensitiveHits = null,
        PrincipalRiskReasons? RiskReasons = null,
        SensitiveFiles? SensitiveFiles = null,
        SummaryCount? SensitiveObjectCount = null,
        SummaryHits? TotalSensitiveHits = null
    ) 
    {
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( DomainId != null ) {
            this.DomainId = DomainId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( FullName != null ) {
            this.FullName = FullName;
        }
        if ( NumDescendants != null ) {
            this.NumDescendants = NumDescendants;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( Upn != null ) {
            this.Upn = Upn;
        }
        if ( DeltaSensitiveHits != null ) {
            this.DeltaSensitiveHits = DeltaSensitiveHits;
        }
        if ( RiskReasons != null ) {
            this.RiskReasons = RiskReasons;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( SensitiveObjectCount != null ) {
            this.SensitiveObjectCount = SensitiveObjectCount;
        }
        if ( TotalSensitiveHits != null ) {
            this.TotalSensitiveHits = TotalSensitiveHits;
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
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (this.DomainId != null) {
            s += ind + "domainId\n" ;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            s += ind + "domainName\n" ;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            s += ind + "fullName\n" ;
        }
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (this.NumDescendants != null) {
            s += ind + "numDescendants\n" ;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            s += ind + "principalId\n" ;
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (this.Upn != null) {
            s += ind + "upn\n" ;
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (this.DeltaSensitiveHits != null) {
            var fspec = this.DeltaSensitiveHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "deltaSensitiveHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (this.RiskReasons != null) {
            var fspec = this.RiskReasons.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "riskReasons {\n" + fspec + ind + "}\n" ;
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
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (this.SensitiveObjectCount != null) {
            var fspec = this.SensitiveObjectCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sensitiveObjectCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalSensitiveHits {\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (this.DomainId == null && Exploration.Includes(parent + ".domainId", true))
        {
            this.DomainId = "FETCH";
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName == null && Exploration.Includes(parent + ".domainName", true))
        {
            this.DomainName = "FETCH";
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName == null && Exploration.Includes(parent + ".fullName", true))
        {
            this.FullName = "FETCH";
        }
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (this.NumDescendants == null && Exploration.Includes(parent + ".numDescendants", true))
        {
            this.NumDescendants = Int32.MinValue;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId == null && Exploration.Includes(parent + ".principalId", true))
        {
            this.PrincipalId = "FETCH";
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (this.Upn == null && Exploration.Includes(parent + ".upn", true))
        {
            this.Upn = "FETCH";
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (this.DeltaSensitiveHits == null && Exploration.Includes(parent + ".deltaSensitiveHits"))
        {
            this.DeltaSensitiveHits = new SummaryHits();
            this.DeltaSensitiveHits.ApplyExploratoryFieldSpec(parent + ".deltaSensitiveHits");
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (this.RiskReasons == null && Exploration.Includes(parent + ".riskReasons"))
        {
            this.RiskReasons = new PrincipalRiskReasons();
            this.RiskReasons.ApplyExploratoryFieldSpec(parent + ".riskReasons");
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && Exploration.Includes(parent + ".sensitiveFiles"))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sensitiveFiles");
        }
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (this.SensitiveObjectCount == null && Exploration.Includes(parent + ".sensitiveObjectCount"))
        {
            this.SensitiveObjectCount = new SummaryCount();
            this.SensitiveObjectCount.ApplyExploratoryFieldSpec(parent + ".sensitiveObjectCount");
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits == null && Exploration.Includes(parent + ".totalSensitiveHits"))
        {
            this.TotalSensitiveHits = new SummaryHits();
            this.TotalSensitiveHits.ApplyExploratoryFieldSpec(parent + ".totalSensitiveHits");
        }
    }


    #endregion

    } // class PrincipalSummary
    
    #endregion

    public static class ListPrincipalSummaryExtensions
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
            this List<PrincipalSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types