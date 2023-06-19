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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<BlueprintRecoveryRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.MissedRecoverableRanges == null && Exploration.Includes(parent + ".missedRecoverableRanges"))
        {
            this.MissedRecoverableRanges = new List<BlueprintRecoveryRange>();
            this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(parent + ".missedRecoverableRanges");
        }
        //      C# -> List<BlueprintRecoveryRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [BlueprintRecoveryRange!]! (type)
        if (this.RecoverableRanges == null && Exploration.Includes(parent + ".recoverableRanges"))
        {
            this.RecoverableRanges = new List<BlueprintRecoveryRange>();
            this.RecoverableRanges.ApplyExploratoryFieldSpec(parent + ".recoverableRanges");
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoveryRanges());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types