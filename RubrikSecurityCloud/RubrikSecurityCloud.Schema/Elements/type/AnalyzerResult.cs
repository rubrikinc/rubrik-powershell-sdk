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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "analyzer {\n" + this.Analyzer.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits != null) {
            s += ind + "hits {\n" + this.Hits.AsFieldSpec(indent+1) + ind + "}\n" ;
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
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits == null && Exploration.Includes(parent + ".hits"))
        {
            this.Hits = new Hits();
            this.Hits.ApplyExploratoryFieldSpec(parent + ".hits");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types