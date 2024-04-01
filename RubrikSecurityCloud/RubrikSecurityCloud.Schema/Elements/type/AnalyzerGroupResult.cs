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

    public override string GetGqlTypeName() {
        return "AnalyzerGroupResult";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        if (this.AnalyzerGroup != null) {
            var fspec = this.AnalyzerGroup.AsFieldSpec(conf.Child("analyzerGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerGroup {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(conf.Child("analyzerResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(conf.Child("hits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hits {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        if (ec.Includes("analyzerGroup",false))
        {
            if(this.AnalyzerGroup == null) {

                this.AnalyzerGroup = new AnalyzerGroup();
                this.AnalyzerGroup.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroup"));

            } else {

                this.AnalyzerGroup.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroup"));

            }
        }
        else if (this.AnalyzerGroup != null && ec.Excludes("analyzerGroup",false))
        {
            this.AnalyzerGroup = null;
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (ec.Includes("analyzerResults",false))
        {
            if(this.AnalyzerResults == null) {

                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            } else {

                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            }
        }
        else if (this.AnalyzerResults != null && ec.Excludes("analyzerResults",false))
        {
            this.AnalyzerResults = null;
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (ec.Includes("hits",false))
        {
            if(this.Hits == null) {

                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            } else {

                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            }
        }
        else if (this.Hits != null && ec.Excludes("hits",false))
        {
            this.Hits = null;
        }
    }


    #endregion

    } // class AnalyzerGroupResult
    
    #endregion

    public static class ListAnalyzerGroupResultExtensions
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
            this List<AnalyzerGroupResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerGroupResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerGroupResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerGroupResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerGroupResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types