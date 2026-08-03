// AnalyzerResults.cs
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
    #region AnalyzerResults
    public class AnalyzerResults: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.String? AnalyzerName
        // GraphQL -> analyzerName: String! (scalar)
        [JsonProperty("analyzerName")]
        public System.String? AnalyzerName { get; set; }

        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        [JsonProperty("violatedHits")]
        public System.Int64? ViolatedHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerResults";
    }

    public AnalyzerResults Set(
        RiskLevelType? Risk = null,
        System.String? AnalyzerId = null,
        System.String? AnalyzerName = null,
        System.Int64? ViolatedHits = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( AnalyzerName != null ) {
            this.AnalyzerName = AnalyzerName;
        }
        if ( ViolatedHits != null ) {
            this.ViolatedHits = ViolatedHits;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "risk\n" ;
            } else {
                s += ind + "risk\n" ;
            }
        }
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (this.AnalyzerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerId\n" ;
            } else {
                s += ind + "analyzerId\n" ;
            }
        }
        //      C# -> System.String? AnalyzerName
        // GraphQL -> analyzerName: String! (scalar)
        if (this.AnalyzerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerName\n" ;
            } else {
                s += ind + "analyzerName\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        if (this.ViolatedHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedHits\n" ;
            } else {
                s += ind + "violatedHits\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (ec.Includes("risk",true))
        {
            if(this.Risk == null) {

                this.Risk = new RiskLevelType();

            } else {


            }
        }
        else if (this.Risk != null && ec.Excludes("risk",true))
        {
            this.Risk = null;
        }
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (ec.Includes("analyzerId",true))
        {
            if(this.AnalyzerId == null) {

                this.AnalyzerId = "FETCH";

            } else {


            }
        }
        else if (this.AnalyzerId != null && ec.Excludes("analyzerId",true))
        {
            this.AnalyzerId = null;
        }
        //      C# -> System.String? AnalyzerName
        // GraphQL -> analyzerName: String! (scalar)
        if (ec.Includes("analyzerName",true))
        {
            if(this.AnalyzerName == null) {

                this.AnalyzerName = "FETCH";

            } else {


            }
        }
        else if (this.AnalyzerName != null && ec.Excludes("analyzerName",true))
        {
            this.AnalyzerName = null;
        }
        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        if (ec.Includes("violatedHits",true))
        {
            if(this.ViolatedHits == null) {

                this.ViolatedHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedHits != null && ec.Excludes("violatedHits",true))
        {
            this.ViolatedHits = null;
        }
    }


    #endregion

    } // class AnalyzerResults
    
    #endregion

    public static class ListAnalyzerResultsExtensions
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
            this List<AnalyzerResults> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerResults> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerResults> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerResults());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerResults> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types