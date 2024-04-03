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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        if (this.CountDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countDelta\n" ;
            } else {
                s += ind + "countDelta\n" ;
            }
        }
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        if (this.Analyzer != null) {
            var fspec = this.Analyzer.AsFieldSpec(conf.Child("analyzer"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzer" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles != null) {
            var fspec = this.TopFiles.AsFieldSpec(conf.Child("topFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "topFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        if (ec.Includes("countDelta",true))
        {
            if(this.CountDelta == null) {

                this.CountDelta = Int32.MinValue;

            } else {


            }
        }
        else if (this.CountDelta != null && ec.Excludes("countDelta",true))
        {
            this.CountDelta = null;
        }
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        if (ec.Includes("analyzer",false))
        {
            if(this.Analyzer == null) {

                this.Analyzer = new Analyzer();
                this.Analyzer.ApplyExploratoryFieldSpec(ec.NewChild("analyzer"));

            } else {

                this.Analyzer.ApplyExploratoryFieldSpec(ec.NewChild("analyzer"));

            }
        }
        else if (this.Analyzer != null && ec.Excludes("analyzer",false))
        {
            this.Analyzer = null;
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (ec.Includes("topFiles",false))
        {
            if(this.TopFiles == null) {

                this.TopFiles = new List<FileAccessResult>();
                this.TopFiles.ApplyExploratoryFieldSpec(ec.NewChild("topFiles"));

            } else {

                this.TopFiles.ApplyExploratoryFieldSpec(ec.NewChild("topFiles"));

            }
        }
        else if (this.TopFiles != null && ec.Excludes("topFiles",false))
        {
            this.TopFiles = null;
        }
    }


    #endregion

    } // class AnalyzerAccessUsage
    
    #endregion

    public static class ListAnalyzerAccessUsageExtensions
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
            this List<AnalyzerAccessUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerAccessUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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