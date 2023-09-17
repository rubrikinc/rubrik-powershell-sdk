// AnalyzerAccessUsage.cs
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
    #region AnalyzerAccessUsage
    public class AnalyzerAccessUsage: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        [JsonProperty("countDelta")]
        public System.Int32? CountDelta { get; set; }

        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        [JsonProperty("topFiles")]
        public List<FileAccessResult>? TopFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerAccessUsage";
    }

    public AnalyzerAccessUsage Set(
        System.Int32? Count = null,
        System.Int32? CountDelta = null,
        Analyzer? Analyzer = null,
        List<FileAccessResult>? TopFiles = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CountDelta != null ) {
            this.CountDelta = CountDelta;
        }
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( TopFiles != null ) {
            this.TopFiles = TopFiles;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        if (this.CountDelta != null) {
            s += ind + "countDelta\n" ;
        }
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        if (this.Analyzer != null) {
            var fspec = this.Analyzer.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzer {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles != null) {
            var fspec = this.TopFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "topFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        if (this.CountDelta == null && ec.Includes("countDelta",true))
        {
            this.CountDelta = Int32.MinValue;
        }
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        if (this.Analyzer == null && ec.Includes("analyzer",false))
        {
            this.Analyzer = new Analyzer();
            this.Analyzer.ApplyExploratoryFieldSpec(ec.NewChild("analyzer"));
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles == null && ec.Includes("topFiles",false))
        {
            this.TopFiles = new List<FileAccessResult>();
            this.TopFiles.ApplyExploratoryFieldSpec(ec.NewChild("topFiles"));
        }
    }


    #endregion

    } // class AnalyzerAccessUsage
    
    #endregion

    public static class ListAnalyzerAccessUsageExtensions
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
            this List<AnalyzerAccessUsage> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerAccessUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerAccessUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerAccessUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types