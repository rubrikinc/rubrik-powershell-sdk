// AnalyzerResult.cs
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
    #region AnalyzerResult
    public class AnalyzerResult: BaseType
    {
        #region members

        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerResult";
    }

    public AnalyzerResult Set(
        Analyzer? Analyzer = null,
        Hits? Hits = null
    ) 
    {
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
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
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        if (this.Analyzer == null && ec.Includes("analyzer",false))
        {
            this.Analyzer = new Analyzer();
            this.Analyzer.ApplyExploratoryFieldSpec(ec.NewChild("analyzer"));
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits == null && ec.Includes("hits",false))
        {
            this.Hits = new Hits();
            this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));
        }
    }


    #endregion

    } // class AnalyzerResult
    
    #endregion

    public static class ListAnalyzerResultExtensions
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
            this List<AnalyzerResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AnalyzerResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types