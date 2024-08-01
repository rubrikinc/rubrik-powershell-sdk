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

        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        [JsonProperty("previousRiskLevel")]
        public RiskLevelType? PreviousRiskLevel { get; set; }

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

        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        [JsonProperty("hasInsights")]
        public System.Boolean? HasInsights { get; set; }

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

        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("deltaSensitiveFiles")]
        public SensitiveFiles? DeltaSensitiveFiles { get; set; }

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

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }

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

    public override string GetGqlTypeName() {
        return "PrincipalSummary";
    }

    public PrincipalSummary Set(
        RiskLevelType? PreviousRiskLevel = null,
        RiskLevelType? RiskLevel = null,
        System.String? DomainId = null,
        System.String? DomainName = null,
        System.String? FullName = null,
        System.Boolean? HasInsights = null,
        System.Int32? NumDescendants = null,
        System.String? PrincipalId = null,
        System.String? Upn = null,
        SensitiveFiles? DeltaSensitiveFiles = null,
        SummaryHits? DeltaSensitiveHits = null,
        PrincipalRiskReasons? RiskReasons = null,
        SensitiveFiles? SensitiveFiles = null,
        SensitiveHits? SensitiveHits = null,
        SummaryCount? SensitiveObjectCount = null,
        SummaryHits? TotalSensitiveHits = null
    ) 
    {
        if ( PreviousRiskLevel != null ) {
            this.PreviousRiskLevel = PreviousRiskLevel;
        }
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
        if ( HasInsights != null ) {
            this.HasInsights = HasInsights;
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
        if ( DeltaSensitiveFiles != null ) {
            this.DeltaSensitiveFiles = DeltaSensitiveFiles;
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
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        if (this.PreviousRiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousRiskLevel\n" ;
            } else {
                s += ind + "previousRiskLevel\n" ;
            }
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskLevel\n" ;
            } else {
                s += ind + "riskLevel\n" ;
            }
        }
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (this.DomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainId\n" ;
            } else {
                s += ind + "domainId\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fullName\n" ;
            } else {
                s += ind + "fullName\n" ;
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
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (this.NumDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendants\n" ;
            } else {
                s += ind + "numDescendants\n" ;
            }
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (this.Upn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upn\n" ;
            } else {
                s += ind + "upn\n" ;
            }
        }
        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        if (this.DeltaSensitiveFiles != null) {
            var fspec = this.DeltaSensitiveFiles.AsFieldSpec(conf.Child("deltaSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (this.DeltaSensitiveHits != null) {
            var fspec = this.DeltaSensitiveHits.AsFieldSpec(conf.Child("deltaSensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaSensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (this.RiskReasons != null) {
            var fspec = this.RiskReasons.AsFieldSpec(conf.Child("riskReasons"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "riskReasons" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (this.SensitiveObjectCount != null) {
            var fspec = this.SensitiveObjectCount.AsFieldSpec(conf.Child("sensitiveObjectCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveObjectCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(conf.Child("totalSensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalSensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        if (ec.Includes("previousRiskLevel",true))
        {
            if(this.PreviousRiskLevel == null) {

                this.PreviousRiskLevel = new RiskLevelType();

            } else {


            }
        }
        else if (this.PreviousRiskLevel != null && ec.Excludes("previousRiskLevel",true))
        {
            this.PreviousRiskLevel = null;
        }
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
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (ec.Includes("domainId",true))
        {
            if(this.DomainId == null) {

                this.DomainId = "FETCH";

            } else {


            }
        }
        else if (this.DomainId != null && ec.Excludes("domainId",true))
        {
            this.DomainId = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (ec.Includes("fullName",true))
        {
            if(this.FullName == null) {

                this.FullName = "FETCH";

            } else {


            }
        }
        else if (this.FullName != null && ec.Excludes("fullName",true))
        {
            this.FullName = null;
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
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (ec.Includes("numDescendants",true))
        {
            if(this.NumDescendants == null) {

                this.NumDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDescendants != null && ec.Excludes("numDescendants",true))
        {
            this.NumDescendants = null;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (ec.Includes("upn",true))
        {
            if(this.Upn == null) {

                this.Upn = "FETCH";

            } else {


            }
        }
        else if (this.Upn != null && ec.Excludes("upn",true))
        {
            this.Upn = null;
        }
        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("deltaSensitiveFiles",false))
        {
            if(this.DeltaSensitiveFiles == null) {

                this.DeltaSensitiveFiles = new SensitiveFiles();
                this.DeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveFiles"));

            } else {

                this.DeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveFiles"));

            }
        }
        else if (this.DeltaSensitiveFiles != null && ec.Excludes("deltaSensitiveFiles",false))
        {
            this.DeltaSensitiveFiles = null;
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (ec.Includes("deltaSensitiveHits",false))
        {
            if(this.DeltaSensitiveHits == null) {

                this.DeltaSensitiveHits = new SummaryHits();
                this.DeltaSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveHits"));

            } else {

                this.DeltaSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveHits"));

            }
        }
        else if (this.DeltaSensitiveHits != null && ec.Excludes("deltaSensitiveHits",false))
        {
            this.DeltaSensitiveHits = null;
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (ec.Includes("riskReasons",false))
        {
            if(this.RiskReasons == null) {

                this.RiskReasons = new PrincipalRiskReasons();
                this.RiskReasons.ApplyExploratoryFieldSpec(ec.NewChild("riskReasons"));

            } else {

                this.RiskReasons.ApplyExploratoryFieldSpec(ec.NewChild("riskReasons"));

            }
        }
        else if (this.RiskReasons != null && ec.Excludes("riskReasons",false))
        {
            this.RiskReasons = null;
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
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (ec.Includes("sensitiveObjectCount",false))
        {
            if(this.SensitiveObjectCount == null) {

                this.SensitiveObjectCount = new SummaryCount();
                this.SensitiveObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveObjectCount"));

            } else {

                this.SensitiveObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveObjectCount"));

            }
        }
        else if (this.SensitiveObjectCount != null && ec.Excludes("sensitiveObjectCount",false))
        {
            this.SensitiveObjectCount = null;
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (ec.Includes("totalSensitiveHits",false))
        {
            if(this.TotalSensitiveHits == null) {

                this.TotalSensitiveHits = new SummaryHits();
                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            } else {

                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            }
        }
        else if (this.TotalSensitiveHits != null && ec.Excludes("totalSensitiveHits",false))
        {
            this.TotalSensitiveHits = null;
        }
    }


    #endregion

    } // class PrincipalSummary
    
    #endregion

    public static class ListPrincipalSummaryExtensions
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
            this List<PrincipalSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types