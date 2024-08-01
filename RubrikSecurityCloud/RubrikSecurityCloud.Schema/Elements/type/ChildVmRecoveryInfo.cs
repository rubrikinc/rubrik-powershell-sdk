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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<VmwareRecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.MissedRecoverableRanges != null) {
            var fspec = this.MissedRecoverableRanges.AsFieldSpec(conf.Child("missedRecoverableRanges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedRecoverableRanges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (this.RecoverableRanges != null) {
            var fspec = this.RecoverableRanges.AsFieldSpec(conf.Child("recoverableRanges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverableRanges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareRecoveryPoints? RecoveryPoints
        // GraphQL -> recoveryPoints: VmwareRecoveryPoints! (type)
        if (this.RecoveryPoints != null) {
            var fspec = this.RecoveryPoints.AsFieldSpec(conf.Child("recoveryPoints"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPoints" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareRecoveryState? RecoveryState
        // GraphQL -> recoveryState: VmwareRecoveryState! (type)
        if (this.RecoveryState != null) {
            var fspec = this.RecoveryState.AsFieldSpec(conf.Child("recoveryState"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryState" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<VmwareRecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [VmwareRecoverableRange!]! (type)
        if (ec.Includes("missedRecoverableRanges",false))
        {
            if(this.MissedRecoverableRanges == null) {

                this.MissedRecoverableRanges = new List<VmwareRecoverableRange>();
                this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));

            } else {

                this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));

            }
        }
        else if (this.MissedRecoverableRanges != null && ec.Excludes("missedRecoverableRanges",false))
        {
            this.MissedRecoverableRanges = null;
        }
        //      C# -> List<VmwareRecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [VmwareRecoverableRange!]! (type)
        if (ec.Includes("recoverableRanges",false))
        {
            if(this.RecoverableRanges == null) {

                this.RecoverableRanges = new List<VmwareRecoverableRange>();
                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            } else {

                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            }
        }
        else if (this.RecoverableRanges != null && ec.Excludes("recoverableRanges",false))
        {
            this.RecoverableRanges = null;
        }
        //      C# -> VmwareRecoveryPoints? RecoveryPoints
        // GraphQL -> recoveryPoints: VmwareRecoveryPoints! (type)
        if (ec.Includes("recoveryPoints",false))
        {
            if(this.RecoveryPoints == null) {

                this.RecoveryPoints = new VmwareRecoveryPoints();
                this.RecoveryPoints.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPoints"));

            } else {

                this.RecoveryPoints.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPoints"));

            }
        }
        else if (this.RecoveryPoints != null && ec.Excludes("recoveryPoints",false))
        {
            this.RecoveryPoints = null;
        }
        //      C# -> VmwareRecoveryState? RecoveryState
        // GraphQL -> recoveryState: VmwareRecoveryState! (type)
        if (ec.Includes("recoveryState",false))
        {
            if(this.RecoveryState == null) {

                this.RecoveryState = new VmwareRecoveryState();
                this.RecoveryState.ApplyExploratoryFieldSpec(ec.NewChild("recoveryState"));

            } else {

                this.RecoveryState.ApplyExploratoryFieldSpec(ec.NewChild("recoveryState"));

            }
        }
        else if (this.RecoveryState != null && ec.Excludes("recoveryState",false))
        {
            this.RecoveryState = null;
        }
    }


    #endregion

    } // class ChildVmRecoveryInfo
    
    #endregion

    public static class ListChildVmRecoveryInfoExtensions
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
            this List<ChildVmRecoveryInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChildVmRecoveryInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ChildVmRecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types