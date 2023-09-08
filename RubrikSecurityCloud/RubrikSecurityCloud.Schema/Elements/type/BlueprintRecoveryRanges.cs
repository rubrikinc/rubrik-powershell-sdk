// BlueprintRecoveryRanges.cs
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
    #region BlueprintRecoveryRanges
    public class BlueprintRecoveryRanges: BaseType
    {
        #region members

        //      C# -> List<BlueprintRecoveryRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [BlueprintRecoveryRange!]! (type)
        [JsonProperty("missedRecoverableRanges")]
        public List<BlueprintRecoveryRange>? MissedRecoverableRanges { get; set; }

        //      C# -> List<BlueprintRecoveryRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [BlueprintRecoveryRange!]! (type)
        [JsonProperty("recoverableRanges")]
        public List<BlueprintRecoveryRange>? RecoverableRanges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintRecoveryRanges";
    }

    public BlueprintRecoveryRanges Set(
        List<BlueprintRecoveryRange>? MissedRecoverableRanges = null,
        List<BlueprintRecoveryRange>? RecoverableRanges = null
    ) 
    {
        if ( MissedRecoverableRanges != null ) {
            this.MissedRecoverableRanges = MissedRecoverableRanges;
        }
        if ( RecoverableRanges != null ) {
            this.RecoverableRanges = RecoverableRanges;
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
        //      C# -> List<BlueprintRecoveryRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.MissedRecoverableRanges != null) {
            var fspec = this.MissedRecoverableRanges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedRecoverableRanges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<BlueprintRecoveryRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.RecoverableRanges != null) {
            var fspec = this.RecoverableRanges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoverableRanges {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<BlueprintRecoveryRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.MissedRecoverableRanges == null && ec.Includes("missedRecoverableRanges",false))
        {
            this.MissedRecoverableRanges = new List<BlueprintRecoveryRange>();
            this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));
        }
        //      C# -> List<BlueprintRecoveryRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.RecoverableRanges == null && ec.Includes("recoverableRanges",false))
        {
            this.RecoverableRanges = new List<BlueprintRecoveryRange>();
            this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));
        }
    }


    #endregion

    } // class BlueprintRecoveryRanges
    
    #endregion

    public static class ListBlueprintRecoveryRangesExtensions
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
            this List<BlueprintRecoveryRanges> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoveryRanges> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoveryRanges());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BlueprintRecoveryRanges> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types