// AnalyzerGroupResult.cs
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
    #region AnalyzerGroupResult
    public class AnalyzerGroupResult: BaseType
    {
        #region members

        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        [JsonProperty("analyzerGroup")]
        public AnalyzerGroup? AnalyzerGroup { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }


        #endregion

    #region methods

    public AnalyzerGroupResult Set(
        AnalyzerGroup? AnalyzerGroup = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        Hits? Hits = null
    ) 
    {
        if ( AnalyzerGroup != null ) {
            this.AnalyzerGroup = AnalyzerGroup;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
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
        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        if (this.AnalyzerGroup != null) {
            var fspec = this.AnalyzerGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerResults {\n" + fspec + ind + "}\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        if (this.AnalyzerGroup == null && Exploration.Includes(parent + ".analyzerGroup"))
        {
            this.AnalyzerGroup = new AnalyzerGroup();
            this.AnalyzerGroup.ApplyExploratoryFieldSpec(parent + ".analyzerGroup");
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
        {
            this.AnalyzerResults = new List<AnalyzerResult>();
            this.AnalyzerResults.ApplyExploratoryFieldSpec(parent + ".analyzerResults");
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

    } // class AnalyzerGroupResult
    
    #endregion

    public static class ListAnalyzerGroupResultExtensions
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
            this List<AnalyzerGroupResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerGroupResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerGroupResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types