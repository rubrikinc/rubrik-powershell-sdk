// ChildVmRecoveryInfo.cs
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
    #region ChildVmRecoveryInfo
    public class ChildVmRecoveryInfo: BaseType
    {
        #region members

        //      C# -> List<VmwareRecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [VmwareRecoverableRange!]! (type)
        [JsonProperty("missedRecoverableRanges")]
        public List<VmwareRecoverableRange>? MissedRecoverableRanges { get; set; }

        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        [JsonProperty("recoverableRanges")]
        public List<VmwareRecoverableRange>? RecoverableRanges { get; set; }

        //      C# -> VmwareRecoveryPoints? RecoveryPoints
        // GraphQL -> recoveryPoints: VmwareRecoveryPoints! (type)
        [JsonProperty("recoveryPoints")]
        public VmwareRecoveryPoints? RecoveryPoints { get; set; }

        //      C# -> VmwareRecoveryState? RecoveryState
        // GraphQL -> recoveryState: VmwareRecoveryState! (type)
        [JsonProperty("recoveryState")]
        public VmwareRecoveryState? RecoveryState { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChildVmRecoveryInfo";
    }

    public ChildVmRecoveryInfo Set(
        List<VmwareRecoverableRange>? MissedRecoverableRanges = null,
        List<VmwareRecoverableRange>? RecoverableRanges = null,
        VmwareRecoveryPoints? RecoveryPoints = null,
        VmwareRecoveryState? RecoveryState = null
    ) 
    {
        if ( MissedRecoverableRanges != null ) {
            this.MissedRecoverableRanges = MissedRecoverableRanges;
        }
        if ( RecoverableRanges != null ) {
            this.RecoverableRanges = RecoverableRanges;
        }
        if ( RecoveryPoints != null ) {
            this.RecoveryPoints = RecoveryPoints;
        }
        if ( RecoveryState != null ) {
            this.RecoveryState = RecoveryState;
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
        //      C# -> List<VmwareRecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.MissedRecoverableRanges != null) {
            var fspec = this.MissedRecoverableRanges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedRecoverableRanges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.RecoverableRanges != null) {
            var fspec = this.RecoverableRanges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoverableRanges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareRecoveryPoints? RecoveryPoints
        // GraphQL -> recoveryPoints: VmwareRecoveryPoints! (type)
        if (this.RecoveryPoints != null) {
            var fspec = this.RecoveryPoints.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryPoints {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareRecoveryState? RecoveryState
        // GraphQL -> recoveryState: VmwareRecoveryState! (type)
        if (this.RecoveryState != null) {
            var fspec = this.RecoveryState.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryState {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VmwareRecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.MissedRecoverableRanges == null && ec.Includes("missedRecoverableRanges",false))
        {
            this.MissedRecoverableRanges = new List<VmwareRecoverableRange>();
            this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.RecoverableRanges == null && ec.Includes("recoverableRanges",false))
        {
            this.RecoverableRanges = new List<VmwareRecoverableRange>();
            this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));
        }
        //      C# -> VmwareRecoveryPoints? RecoveryPoints
        // GraphQL -> recoveryPoints: VmwareRecoveryPoints! (type)
        if (this.RecoveryPoints == null && ec.Includes("recoveryPoints",false))
        {
            this.RecoveryPoints = new VmwareRecoveryPoints();
            this.RecoveryPoints.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPoints"));
        }
        //      C# -> VmwareRecoveryState? RecoveryState
        // GraphQL -> recoveryState: VmwareRecoveryState! (type)
        if (this.RecoveryState == null && ec.Includes("recoveryState",false))
        {
            this.RecoveryState = new VmwareRecoveryState();
            this.RecoveryState.ApplyExploratoryFieldSpec(ec.NewChild("recoveryState"));
        }
    }


    #endregion

    } // class ChildVmRecoveryInfo
    
    #endregion

    public static class ListChildVmRecoveryInfoExtensions
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
            this List<ChildVmRecoveryInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChildVmRecoveryInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChildVmRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ChildVmRecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types