// PolicySummaryDetails.cs
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
    #region PolicySummaryDetails
    public class PolicySummaryDetails: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAnomalousPolicy
        // GraphQL -> isAnomalousPolicy: Boolean! (scalar)
        [JsonProperty("isAnomalousPolicy")]
        public System.Boolean? IsAnomalousPolicy { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> HitsSummary? HitsSummary
        // GraphQL -> hitsSummary: HitsSummary (type)
        [JsonProperty("hitsSummary")]
        public HitsSummary? HitsSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicySummaryDetails";
    }

    public PolicySummaryDetails Set(
        System.Boolean? IsAnomalousPolicy = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        HitsSummary? HitsSummary = null
    ) 
    {
        if ( IsAnomalousPolicy != null ) {
            this.IsAnomalousPolicy = IsAnomalousPolicy;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( HitsSummary != null ) {
            this.HitsSummary = HitsSummary;
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
        //      C# -> System.Boolean? IsAnomalousPolicy
        // GraphQL -> isAnomalousPolicy: Boolean! (scalar)
        if (this.IsAnomalousPolicy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomalousPolicy\n" ;
            } else {
                s += ind + "isAnomalousPolicy\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
            }
        }
        //      C# -> HitsSummary? HitsSummary
        // GraphQL -> hitsSummary: HitsSummary (type)
        if (this.HitsSummary != null) {
            var fspec = this.HitsSummary.AsFieldSpec(conf.Child("hitsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hitsSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAnomalousPolicy
        // GraphQL -> isAnomalousPolicy: Boolean! (scalar)
        if (ec.Includes("isAnomalousPolicy",true))
        {
            if(this.IsAnomalousPolicy == null) {

                this.IsAnomalousPolicy = true;

            } else {


            }
        }
        else if (this.IsAnomalousPolicy != null && ec.Excludes("isAnomalousPolicy",true))
        {
            this.IsAnomalousPolicy = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
        }
        //      C# -> HitsSummary? HitsSummary
        // GraphQL -> hitsSummary: HitsSummary (type)
        if (ec.Includes("hitsSummary",false))
        {
            if(this.HitsSummary == null) {

                this.HitsSummary = new HitsSummary();
                this.HitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("hitsSummary"));

            } else {

                this.HitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("hitsSummary"));

            }
        }
        else if (this.HitsSummary != null && ec.Excludes("hitsSummary",false))
        {
            this.HitsSummary = null;
        }
    }


    #endregion

    } // class PolicySummaryDetails
    
    #endregion

    public static class ListPolicySummaryDetailsExtensions
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
            this List<PolicySummaryDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicySummaryDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicySummaryDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicySummaryDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicySummaryDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types