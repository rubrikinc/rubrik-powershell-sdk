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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<ValidateFailureReason>? Errors
        // GraphQL -> errors: [ValidateFailureReason!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "errors {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<BlueprintRecoverySpec>? Specs
        // GraphQL -> specs: [BlueprintRecoverySpec!]! (type)
        if (this.Specs != null) {
            var fspec = this.Specs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "specs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ValidateFailureReason>? Errors
        // GraphQL -> errors: [ValidateFailureReason!]! (type)
        if (this.Errors == null && ec.Includes("errors",false))
        {
            this.Errors = new List<ValidateFailureReason>();
            this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));
        }
        //      C# -> List<BlueprintRecoverySpec>? Specs
        // GraphQL -> specs: [BlueprintRecoverySpec!]! (type)
        if (this.Specs == null && ec.Includes("specs",false))
        {
            this.Specs = new List<BlueprintRecoverySpec>();
            this.Specs.ApplyExploratoryFieldSpec(ec.NewChild("specs"));
        }
    }


    #endregion

    } // class BlueprintRecoverySpecs
    
    #endregion

    public static class ListBlueprintRecoverySpecsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<BlueprintRecoverySpecs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<BlueprintRecoverySpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types