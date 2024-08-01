// SidPolicyHitsSummary.cs
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
    #region SidPolicyHitsSummary
    public class SidPolicyHitsSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        [JsonProperty("analyzerNames")]
        public List<System.String>? AnalyzerNames { get; set; }

        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        [JsonProperty("principal")]
        public System.String? Principal { get; set; }

        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        [JsonProperty("summary")]
        public List<PolicyHitsSummary>? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SidPolicyHitsSummary";
    }

    public SidPolicyHitsSummary Set(
        List<System.String>? AnalyzerNames = null,
        System.String? Principal = null,
        List<PolicyHitsSummary>? Summary = null
    ) 
    {
        if ( AnalyzerNames != null ) {
            this.AnalyzerNames = AnalyzerNames;
        }
        if ( Principal != null ) {
            this.Principal = Principal;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        if (this.AnalyzerNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerNames\n" ;
            } else {
                s += ind + "analyzerNames\n" ;
            }
        }
        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        if (this.Principal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principal\n" ;
            } else {
                s += ind + "principal\n" ;
            }
        }
        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? AnalyzerNames
        // GraphQL -> analyzerNames: [String!]! (scalar)
        if (ec.Includes("analyzerNames",true))
        {
            if(this.AnalyzerNames == null) {

                this.AnalyzerNames = new List<System.String>();

            } else {


            }
        }
        else if (this.AnalyzerNames != null && ec.Excludes("analyzerNames",true))
        {
            this.AnalyzerNames = null;
        }
        //      C# -> System.String? Principal
        // GraphQL -> principal: String! (scalar)
        if (ec.Includes("principal",true))
        {
            if(this.Principal == null) {

                this.Principal = "FETCH";

            } else {


            }
        }
        else if (this.Principal != null && ec.Excludes("principal",true))
        {
            this.Principal = null;
        }
        //      C# -> List<PolicyHitsSummary>? Summary
        // GraphQL -> summary: [PolicyHitsSummary!]! (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new List<PolicyHitsSummary>();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
    }


    #endregion

    } // class SidPolicyHitsSummary
    
    #endregion

    public static class ListSidPolicyHitsSummaryExtensions
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
            this List<SidPolicyHitsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SidPolicyHitsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SidPolicyHitsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SidPolicyHitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SidPolicyHitsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types