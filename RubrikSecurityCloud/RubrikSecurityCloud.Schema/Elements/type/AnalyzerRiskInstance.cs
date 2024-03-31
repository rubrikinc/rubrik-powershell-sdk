// AnalyzerRiskInstance.cs
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
    #region AnalyzerRiskInstance
    public class AnalyzerRiskInstance: BaseType
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

        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        [JsonProperty("riskVersion")]
        public System.Int32? RiskVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerRiskInstance";
    }

    public AnalyzerRiskInstance Set(
        RiskLevelType? Risk = null,
        System.String? AnalyzerId = null,
        System.Int32? RiskVersion = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( RiskVersion != null ) {
            this.RiskVersion = RiskVersion;
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
        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        if (this.RiskVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskVersion\n" ;
            } else {
                s += ind + "riskVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        if (ec.Includes("riskVersion",true))
        {
            if(this.RiskVersion == null) {

                this.RiskVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.RiskVersion != null && ec.Excludes("riskVersion",true))
        {
            this.RiskVersion = null;
        }
    }


    #endregion

    } // class AnalyzerRiskInstance
    
    #endregion

    public static class ListAnalyzerRiskInstanceExtensions
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
            this List<AnalyzerRiskInstance> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerRiskInstance> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerRiskInstance> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerRiskInstance());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerRiskInstance> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types