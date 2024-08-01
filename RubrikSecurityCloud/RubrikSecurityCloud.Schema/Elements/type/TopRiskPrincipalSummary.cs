// TopRiskPrincipalSummary.cs
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
    #region TopRiskPrincipalSummary
    public class TopRiskPrincipalSummary: BaseType
    {
        #region members

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> System.Int64? PolicyCount
        // GraphQL -> policyCount: Long! (scalar)
        [JsonProperty("policyCount")]
        public System.Int64? PolicyCount { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }

        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        [JsonProperty("riskHits")]
        public System.Int64? RiskHits { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TopRiskPrincipalSummary";
    }

    public TopRiskPrincipalSummary Set(
        RiskLevelType? RiskLevel = null,
        System.Int64? PolicyCount = null,
        System.String? PrincipalName = null,
        System.Int64? RiskHits = null,
        System.String? Sid = null
    ) 
    {
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( PolicyCount != null ) {
            this.PolicyCount = PolicyCount;
        }
        if ( PrincipalName != null ) {
            this.PrincipalName = PrincipalName;
        }
        if ( RiskHits != null ) {
            this.RiskHits = RiskHits;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
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
        //      C# -> System.Int64? PolicyCount
        // GraphQL -> policyCount: Long! (scalar)
        if (this.PolicyCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyCount\n" ;
            } else {
                s += ind + "policyCount\n" ;
            }
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalName\n" ;
            } else {
                s += ind + "principalName\n" ;
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
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sid\n" ;
            } else {
                s += ind + "sid\n" ;
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
        //      C# -> System.Int64? PolicyCount
        // GraphQL -> policyCount: Long! (scalar)
        if (ec.Includes("policyCount",true))
        {
            if(this.PolicyCount == null) {

                this.PolicyCount = new System.Int64();

            } else {


            }
        }
        else if (this.PolicyCount != null && ec.Excludes("policyCount",true))
        {
            this.PolicyCount = null;
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (ec.Includes("principalName",true))
        {
            if(this.PrincipalName == null) {

                this.PrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalName != null && ec.Excludes("principalName",true))
        {
            this.PrincipalName = null;
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
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (ec.Includes("sid",true))
        {
            if(this.Sid == null) {

                this.Sid = "FETCH";

            } else {


            }
        }
        else if (this.Sid != null && ec.Excludes("sid",true))
        {
            this.Sid = null;
        }
    }


    #endregion

    } // class TopRiskPrincipalSummary
    
    #endregion

    public static class ListTopRiskPrincipalSummaryExtensions
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
            this List<TopRiskPrincipalSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TopRiskPrincipalSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TopRiskPrincipalSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TopRiskPrincipalSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TopRiskPrincipalSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types