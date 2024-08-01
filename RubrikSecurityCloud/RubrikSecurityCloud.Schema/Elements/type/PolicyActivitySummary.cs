// PolicyActivitySummary.cs
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
    #region PolicyActivitySummary
    public class PolicyActivitySummary: BaseType
    {
        #region members

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        [JsonProperty("currentActivitySummary")]
        public ActivitySummary? CurrentActivitySummary { get; set; }

        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        [JsonProperty("deltaActivitySummary")]
        public ActivitySummary? DeltaActivitySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyActivitySummary";
    }

    public PolicyActivitySummary Set(
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        ActivitySummary? CurrentActivitySummary = null,
        ActivitySummary? DeltaActivitySummary = null
    ) 
    {
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( CurrentActivitySummary != null ) {
            this.CurrentActivitySummary = CurrentActivitySummary;
        }
        if ( DeltaActivitySummary != null ) {
            this.DeltaActivitySummary = DeltaActivitySummary;
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
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (this.CurrentActivitySummary != null) {
            var fspec = this.CurrentActivitySummary.AsFieldSpec(conf.Child("currentActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (this.DeltaActivitySummary != null) {
            var fspec = this.DeltaActivitySummary.AsFieldSpec(conf.Child("deltaActivitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaActivitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> ActivitySummary? CurrentActivitySummary
        // GraphQL -> currentActivitySummary: ActivitySummary (type)
        if (ec.Includes("currentActivitySummary",false))
        {
            if(this.CurrentActivitySummary == null) {

                this.CurrentActivitySummary = new ActivitySummary();
                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            } else {

                this.CurrentActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("currentActivitySummary"));

            }
        }
        else if (this.CurrentActivitySummary != null && ec.Excludes("currentActivitySummary",false))
        {
            this.CurrentActivitySummary = null;
        }
        //      C# -> ActivitySummary? DeltaActivitySummary
        // GraphQL -> deltaActivitySummary: ActivitySummary (type)
        if (ec.Includes("deltaActivitySummary",false))
        {
            if(this.DeltaActivitySummary == null) {

                this.DeltaActivitySummary = new ActivitySummary();
                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            } else {

                this.DeltaActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaActivitySummary"));

            }
        }
        else if (this.DeltaActivitySummary != null && ec.Excludes("deltaActivitySummary",false))
        {
            this.DeltaActivitySummary = null;
        }
    }


    #endregion

    } // class PolicyActivitySummary
    
    #endregion

    public static class ListPolicyActivitySummaryExtensions
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
            this List<PolicyActivitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyActivitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyActivitySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyActivitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyActivitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types