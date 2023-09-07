// GetPrincipalRiskSummaryReply.cs
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
    #region GetPrincipalRiskSummaryReply
    public class GetPrincipalRiskSummaryReply: BaseType
    {
        #region members

        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        [JsonProperty("riskSummary")]
        public RiskSummary? RiskSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetPrincipalRiskSummaryReply";
    }

    public GetPrincipalRiskSummaryReply Set(
        RiskSummary? RiskSummary = null
    ) 
    {
        if ( RiskSummary != null ) {
            this.RiskSummary = RiskSummary;
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
        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        if (this.RiskSummary != null) {
            var fspec = this.RiskSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "riskSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        if (this.RiskSummary == null && ec.Includes("riskSummary",false))
        {
            this.RiskSummary = new RiskSummary();
            this.RiskSummary.ApplyExploratoryFieldSpec(ec.NewChild("riskSummary"));
        }
    }


    #endregion

    } // class GetPrincipalRiskSummaryReply
    
    #endregion

    public static class ListGetPrincipalRiskSummaryReplyExtensions
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
            this List<GetPrincipalRiskSummaryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalRiskSummaryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalRiskSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetPrincipalRiskSummaryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types