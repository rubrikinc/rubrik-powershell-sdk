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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> System.Int64? PolicyCount
        // GraphQL -> policyCount: Long! (scalar)
        if (this.PolicyCount != null) {
            s += ind + "policyCount\n" ;
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName != null) {
            s += ind + "principalName\n" ;
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (this.RiskHits != null) {
            s += ind + "riskHits\n" ;
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid != null) {
            s += ind + "sid\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && ec.Includes("riskLevel",true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> System.Int64? PolicyCount
        // GraphQL -> policyCount: Long! (scalar)
        if (this.PolicyCount == null && ec.Includes("policyCount",true))
        {
            this.PolicyCount = new System.Int64();
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName == null && ec.Includes("principalName",true))
        {
            this.PrincipalName = "FETCH";
        }
        //      C# -> System.Int64? RiskHits
        // GraphQL -> riskHits: Long! (scalar)
        if (this.RiskHits == null && ec.Includes("riskHits",true))
        {
            this.RiskHits = new System.Int64();
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        if (this.Sid == null && ec.Includes("sid",true))
        {
            this.Sid = "FETCH";
        }
    }


    #endregion

    } // class TopRiskPrincipalSummary
    
    #endregion

    public static class ListTopRiskPrincipalSummaryExtensions
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
            this List<TopRiskPrincipalSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<TopRiskPrincipalSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types