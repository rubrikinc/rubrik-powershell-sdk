// SidPolicyHitsSummary.cs
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
    #region SidPolicyHitsSummary
    public class SidPolicyHitsSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        [JsonProperty("analyzerNames")]
        public List<System.String>? AnalyzerNames { get; set; }

        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        [JsonProperty("principal")]
        public System.String? Principal { get; set; }

        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        [JsonProperty("summary")]
        public List<PolicyHitsSummary>? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SidPolicyHitsSummary";
    }

    public SidPolicyHitsSummary Set(
        List<System.String>? AnalyzerNames = null,
        System.String? Principal = null,
        List<PolicyHitsSummary>? Summary = null
    ) 
    {
        if ( AnalyzerNames != null ) {
            this.AnalyzerNames = AnalyzerNames;
        }
        if ( Principal != null ) {
            this.Principal = Principal;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        if (this.AnalyzerNames != null) {
            s += ind + "analyzerNames\n" ;
        }
        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        if (this.Principal != null) {
            s += ind + "principal\n" ;
        }
        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "summary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        if (this.AnalyzerNames == null && Exploration.Includes(parent + ".analyzerNames", true))
        {
            this.AnalyzerNames = new List<System.String>();
        }
        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        if (this.Principal == null && Exploration.Includes(parent + ".principal", true))
        {
            this.Principal = "FETCH";
        }
        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        if (this.Summary == null && Exploration.Includes(parent + ".summary"))
        {
            this.Summary = new List<PolicyHitsSummary>();
            this.Summary.ApplyExploratoryFieldSpec(parent + ".summary");
        }
    }


    #endregion

    } // class SidPolicyHitsSummary
    
    #endregion

    public static class ListSidPolicyHitsSummaryExtensions
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
            this List<SidPolicyHitsSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SidPolicyHitsSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SidPolicyHitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types