// PolicyResult.cs
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
    #region PolicyResult
    public class PolicyResult: BaseType
    {
        #region members

        //      C# -> List<System.String>? ViolationNames
        // GraphQL -> violationNames: [String!]! (scalar)
        [JsonProperty("violationNames")]
        public List<System.String>? ViolationNames { get; set; }

        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        [JsonProperty("policy")]
        public DspmPolicy? Policy { get; set; }

        //      C# -> ViolationsSummary? ViolationsSummary
        // GraphQL -> violationsSummary: ViolationsSummary! (type)
        [JsonProperty("violationsSummary")]
        public ViolationsSummary? ViolationsSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyResult";
    }

    public PolicyResult Set(
        List<System.String>? ViolationNames = null,
        DspmPolicy? Policy = null,
        ViolationsSummary? ViolationsSummary = null
    ) 
    {
        if ( ViolationNames != null ) {
            this.ViolationNames = ViolationNames;
        }
        if ( Policy != null ) {
            this.Policy = Policy;
        }
        if ( ViolationsSummary != null ) {
            this.ViolationsSummary = ViolationsSummary;
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
        //      C# -> List<System.String>? ViolationNames
        // GraphQL -> violationNames: [String!]! (scalar)
        if (this.ViolationNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationNames\n" ;
            } else {
                s += ind + "violationNames\n" ;
            }
        }
        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        if (this.Policy != null) {
            var fspec = this.Policy.AsFieldSpec(conf.Child("policy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationsSummary? ViolationsSummary
        // GraphQL -> violationsSummary: ViolationsSummary! (type)
        if (this.ViolationsSummary != null) {
            var fspec = this.ViolationsSummary.AsFieldSpec(conf.Child("violationsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationsSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ViolationNames
        // GraphQL -> violationNames: [String!]! (scalar)
        if (ec.Includes("violationNames",true))
        {
            if(this.ViolationNames == null) {

                this.ViolationNames = new List<System.String>();

            } else {


            }
        }
        else if (this.ViolationNames != null && ec.Excludes("violationNames",true))
        {
            this.ViolationNames = null;
        }
        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        if (ec.Includes("policy",false))
        {
            if(this.Policy == null) {

                this.Policy = new DspmPolicy();
                this.Policy.ApplyExploratoryFieldSpec(ec.NewChild("policy"));

            } else {

                this.Policy.ApplyExploratoryFieldSpec(ec.NewChild("policy"));

            }
        }
        else if (this.Policy != null && ec.Excludes("policy",false))
        {
            this.Policy = null;
        }
        //      C# -> ViolationsSummary? ViolationsSummary
        // GraphQL -> violationsSummary: ViolationsSummary! (type)
        if (ec.Includes("violationsSummary",false))
        {
            if(this.ViolationsSummary == null) {

                this.ViolationsSummary = new ViolationsSummary();
                this.ViolationsSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsSummary"));

            } else {

                this.ViolationsSummary.ApplyExploratoryFieldSpec(ec.NewChild("violationsSummary"));

            }
        }
        else if (this.ViolationsSummary != null && ec.Excludes("violationsSummary",false))
        {
            this.ViolationsSummary = null;
        }
    }


    #endregion

    } // class PolicyResult
    
    #endregion

    public static class ListPolicyResultExtensions
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
            this List<PolicyResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types