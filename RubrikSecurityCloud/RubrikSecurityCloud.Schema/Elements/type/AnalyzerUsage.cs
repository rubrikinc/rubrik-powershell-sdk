// AnalyzerUsage.cs
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
    #region AnalyzerUsage
    public class AnalyzerUsage: BaseType
    {
        #region members

        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicySummary>? Policies { get; set; }


        #endregion

    #region methods

    public AnalyzerUsage Set(
        Analyzer? Analyzer = null,
        List<ClassificationPolicySummary>? Policies = null
    ) 
    {
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
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
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        if (this.Analyzer != null) {
            var fspec = this.Analyzer.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzer {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policies {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        if (this.Analyzer == null && Exploration.Includes(parent + ".analyzer"))
        {
            this.Analyzer = new Analyzer();
            this.Analyzer.ApplyExploratoryFieldSpec(parent + ".analyzer");
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies == null && Exploration.Includes(parent + ".policies"))
        {
            this.Policies = new List<ClassificationPolicySummary>();
            this.Policies.ApplyExploratoryFieldSpec(parent + ".policies");
        }
    }


    #endregion

    } // class AnalyzerUsage
    
    #endregion

    public static class ListAnalyzerUsageExtensions
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
            this List<AnalyzerUsage> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerUsage> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerUsage());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types