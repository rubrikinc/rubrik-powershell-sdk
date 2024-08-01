// BlueprintRecoverySpecs.cs
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
    #region BlueprintRecoverySpecs
    public class BlueprintRecoverySpecs: BaseType
    {
        #region members

        //      C# -> List<ValidateFailureReason>? Errors
        // GraphQL -> errors: [ValidateFailureReason!]! (type)
        [JsonProperty("errors")]
        public List<ValidateFailureReason>? Errors { get; set; }

        //      C# -> List<BlueprintRecoverySpec>? Specs
        // GraphQL -> specs: [BlueprintRecoverySpec!]! (type)
        [JsonProperty("specs")]
        public List<BlueprintRecoverySpec>? Specs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintRecoverySpecs";
    }

    public BlueprintRecoverySpecs Set(
        List<ValidateFailureReason>? Errors = null,
        List<BlueprintRecoverySpec>? Specs = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( Specs != null ) {
            this.Specs = Specs;
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
        //      C# -> List<ValidateFailureReason>? Errors
        // GraphQL -> errors: [ValidateFailureReason!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(conf.Child("errors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<BlueprintRecoverySpec>? Specs
        // GraphQL -> specs: [BlueprintRecoverySpec!]! (type)
        if (this.Specs != null) {
            var fspec = this.Specs.AsFieldSpec(conf.Child("specs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "specs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ValidateFailureReason>? Errors
        // GraphQL -> errors: [ValidateFailureReason!]! (type)
        if (ec.Includes("errors",false))
        {
            if(this.Errors == null) {

                this.Errors = new List<ValidateFailureReason>();
                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            } else {

                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            }
        }
        else if (this.Errors != null && ec.Excludes("errors",false))
        {
            this.Errors = null;
        }
        //      C# -> List<BlueprintRecoverySpec>? Specs
        // GraphQL -> specs: [BlueprintRecoverySpec!]! (type)
        if (ec.Includes("specs",false))
        {
            if(this.Specs == null) {

                this.Specs = new List<BlueprintRecoverySpec>();
                this.Specs.ApplyExploratoryFieldSpec(ec.NewChild("specs"));

            } else {

                this.Specs.ApplyExploratoryFieldSpec(ec.NewChild("specs"));

            }
        }
        else if (this.Specs != null && ec.Excludes("specs",false))
        {
            this.Specs = null;
        }
    }


    #endregion

    } // class BlueprintRecoverySpecs
    
    #endregion

    public static class ListBlueprintRecoverySpecsExtensions
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
            this List<BlueprintRecoverySpecs> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BlueprintRecoverySpecs> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoverySpecs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoverySpecs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BlueprintRecoverySpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types