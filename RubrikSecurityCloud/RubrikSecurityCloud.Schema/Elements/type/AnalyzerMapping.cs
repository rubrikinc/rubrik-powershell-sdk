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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        if (this.AnalyzerResult != null) {
            var fspec = this.AnalyzerResult.AsFieldSpec(conf.Child("analyzerResult"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        if (ec.Includes("analyzerResult",false))
        {
            if(this.AnalyzerResult == null) {

                this.AnalyzerResult = new AnalyzerResult();
                this.AnalyzerResult.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResult"));

            } else {

                this.AnalyzerResult.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResult"));

            }
        }
        else if (this.AnalyzerResult != null && ec.Excludes("analyzerResult",false))
        {
            this.AnalyzerResult = null;
        }
        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<AnalyzerGroup>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
    }


    #endregion

    } // class AnalyzerMapping
    
    #endregion

    public static class ListAnalyzerMappingExtensions
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
            this List<AnalyzerMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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