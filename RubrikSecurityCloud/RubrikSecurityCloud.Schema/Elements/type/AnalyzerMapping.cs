// AnalyzerMapping.cs
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
    #region AnalyzerMapping
    public class AnalyzerMapping: BaseType
    {
        #region members

        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        [JsonProperty("analyzerResult")]
        public AnalyzerResult? AnalyzerResult { get; set; }

        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        [JsonProperty("groups")]
        public List<AnalyzerGroup>? Groups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerMapping";
    }

    public AnalyzerMapping Set(
        AnalyzerResult? AnalyzerResult = null,
        List<AnalyzerGroup>? Groups = null
    ) 
    {
        if ( AnalyzerResult != null ) {
            this.AnalyzerResult = AnalyzerResult;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
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
        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        if (this.AnalyzerResult != null) {
            var fspec = this.AnalyzerResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerResult {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groups {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        if (this.AnalyzerResult == null && ec.Includes("analyzerResult",false))
        {
            this.AnalyzerResult = new AnalyzerResult();
            this.AnalyzerResult.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResult"));
        }
        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        if (this.Groups == null && ec.Includes("groups",false))
        {
            this.Groups = new List<AnalyzerGroup>();
            this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));
        }
    }


    #endregion

    } // class AnalyzerMapping
    
    #endregion

    public static class ListAnalyzerMappingExtensions
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
            this List<AnalyzerMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types