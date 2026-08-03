// RecoveryCoverage.cs
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
    #region RecoveryCoverage
    public class RecoveryCoverage: BaseType
    {
        #region members

        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        [JsonProperty("recoveryPoint")]
        public DateTime? RecoveryPoint { get; set; }

        //      C# -> List<RecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [RecoverableRange!]! (type)
        [JsonProperty("missedRecoverableRanges")]
        public List<RecoverableRange>? MissedRecoverableRanges { get; set; }

        //      C# -> List<RecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [RecoverableRange!]! (type)
        [JsonProperty("recoverableRanges")]
        public List<RecoverableRange>? RecoverableRanges { get; set; }

        //      C# -> RecoveryState? RecoveryState
        // GraphQL -> recoveryState: RecoveryState (type)
        [JsonProperty("recoveryState")]
        public RecoveryState? RecoveryState { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryCoverage";
    }

    public RecoveryCoverage Set(
        DateTime? RecoveryPoint = null,
        List<RecoverableRange>? MissedRecoverableRanges = null,
        List<RecoverableRange>? RecoverableRanges = null,
        RecoveryState? RecoveryState = null
    ) 
    {
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( MissedRecoverableRanges != null ) {
            this.MissedRecoverableRanges = MissedRecoverableRanges;
        }
        if ( RecoverableRanges != null ) {
            this.RecoverableRanges = RecoverableRanges;
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
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (this.RecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPoint\n" ;
            } else {
                s += ind + "recoveryPoint\n" ;
            }
        }
        //      C# -> List<RecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [RecoverableRange!]! (type)
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
        //      C# -> List<RecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [RecoverableRange!]! (type)
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
        //      C# -> RecoveryState? RecoveryState
        // GraphQL -> recoveryState: RecoveryState (type)
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (ec.Includes("recoveryPoint",true))
        {
            if(this.RecoveryPoint == null) {

                this.RecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.RecoveryPoint != null && ec.Excludes("recoveryPoint",true))
        {
            this.RecoveryPoint = null;
        }
        //      C# -> List<RecoverableRange>? MissedRecoverableRanges
        // GraphQL -> missedRecoverableRanges: [RecoverableRange!]! (type)
        if (ec.Includes("missedRecoverableRanges",false))
        {
            if(this.MissedRecoverableRanges == null) {

                this.MissedRecoverableRanges = new List<RecoverableRange>();
                this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));

            } else {

                this.MissedRecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("missedRecoverableRanges"));

            }
        }
        else if (this.MissedRecoverableRanges != null && ec.Excludes("missedRecoverableRanges",false))
        {
            this.MissedRecoverableRanges = null;
        }
        //      C# -> List<RecoverableRange>? RecoverableRanges
        // GraphQL -> recoverableRanges: [RecoverableRange!]! (type)
        if (ec.Includes("recoverableRanges",false))
        {
            if(this.RecoverableRanges == null) {

                this.RecoverableRanges = new List<RecoverableRange>();
                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            } else {

                this.RecoverableRanges.ApplyExploratoryFieldSpec(ec.NewChild("recoverableRanges"));

            }
        }
        else if (this.RecoverableRanges != null && ec.Excludes("recoverableRanges",false))
        {
            this.RecoverableRanges = null;
        }
        //      C# -> RecoveryState? RecoveryState
        // GraphQL -> recoveryState: RecoveryState (type)
        if (ec.Includes("recoveryState",false))
        {
            if(this.RecoveryState == null) {

                this.RecoveryState = new RecoveryState();
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

    } // class RecoveryCoverage
    
    #endregion

    public static class ListRecoveryCoverageExtensions
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
            this List<RecoveryCoverage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryCoverage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryCoverage> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryCoverage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryCoverage> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types