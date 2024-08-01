// ProtectionSummary.cs
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
    #region ProtectionSummary
    public class ProtectionSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? NumDrPlansFailedLastQuarter
        // GraphQL -> numDrPlansFailedLastQuarter: Int! (scalar)
        [JsonProperty("numDrPlansFailedLastQuarter")]
        public System.Int32? NumDrPlansFailedLastQuarter { get; set; }

        //      C# -> System.Int32? NumDrPlansHasConfigError
        // GraphQL -> numDrPlansHasConfigError: Int! (scalar)
        [JsonProperty("numDrPlansHasConfigError")]
        public System.Int32? NumDrPlansHasConfigError { get; set; }

        //      C# -> System.Int32? NumDrPlansSucceededLastQuarter
        // GraphQL -> numDrPlansSucceededLastQuarter: Int! (scalar)
        [JsonProperty("numDrPlansSucceededLastQuarter")]
        public System.Int32? NumDrPlansSucceededLastQuarter { get; set; }

        //      C# -> System.Int32? NumIrPlansFailedLastQuarter
        // GraphQL -> numIrPlansFailedLastQuarter: Int! (scalar)
        [JsonProperty("numIrPlansFailedLastQuarter")]
        public System.Int32? NumIrPlansFailedLastQuarter { get; set; }

        //      C# -> System.Int32? NumIrPlansSucceededLastQuarter
        // GraphQL -> numIrPlansSucceededLastQuarter: Int! (scalar)
        [JsonProperty("numIrPlansSucceededLastQuarter")]
        public System.Int32? NumIrPlansSucceededLastQuarter { get; set; }

        //      C# -> System.Int32? NumLrPlansFailedLastQuarter
        // GraphQL -> numLrPlansFailedLastQuarter: Int! (scalar)
        [JsonProperty("numLrPlansFailedLastQuarter")]
        public System.Int32? NumLrPlansFailedLastQuarter { get; set; }

        //      C# -> System.Int32? NumLrPlansSucceededLastQuarter
        // GraphQL -> numLrPlansSucceededLastQuarter: Int! (scalar)
        [JsonProperty("numLrPlansSucceededLastQuarter")]
        public System.Int32? NumLrPlansSucceededLastQuarter { get; set; }

        //      C# -> System.Int32? NumVmwareVmsCoveredByRecoveryPlan
        // GraphQL -> numVmwareVmsCoveredByRecoveryPlan: Int! (scalar)
        [JsonProperty("numVmwareVmsCoveredByRecoveryPlan")]
        public System.Int32? NumVmwareVmsCoveredByRecoveryPlan { get; set; }

        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        [JsonProperty("totalDrPlans")]
        public System.Int32? TotalDrPlans { get; set; }

        //      C# -> System.Int32? TotalDrPlansWithTestScheduled
        // GraphQL -> totalDrPlansWithTestScheduled: Int! (scalar)
        [JsonProperty("totalDrPlansWithTestScheduled")]
        public System.Int32? TotalDrPlansWithTestScheduled { get; set; }

        //      C# -> System.Int32? TotalIrPlans
        // GraphQL -> totalIrPlans: Int! (scalar)
        [JsonProperty("totalIrPlans")]
        public System.Int32? TotalIrPlans { get; set; }

        //      C# -> System.Int32? TotalIrPlansWithTestScheduled
        // GraphQL -> totalIrPlansWithTestScheduled: Int! (scalar)
        [JsonProperty("totalIrPlansWithTestScheduled")]
        public System.Int32? TotalIrPlansWithTestScheduled { get; set; }

        //      C# -> System.Int32? TotalLrPlans
        // GraphQL -> totalLrPlans: Int! (scalar)
        [JsonProperty("totalLrPlans")]
        public System.Int32? TotalLrPlans { get; set; }

        //      C# -> System.Int32? TotalVmwareVmsWithSlaProtection
        // GraphQL -> totalVmwareVmsWithSlaProtection: Int! (scalar)
        [JsonProperty("totalVmwareVmsWithSlaProtection")]
        public System.Int32? TotalVmwareVmsWithSlaProtection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectionSummary";
    }

    public ProtectionSummary Set(
        System.Int32? NumDrPlansFailedLastQuarter = null,
        System.Int32? NumDrPlansHasConfigError = null,
        System.Int32? NumDrPlansSucceededLastQuarter = null,
        System.Int32? NumIrPlansFailedLastQuarter = null,
        System.Int32? NumIrPlansSucceededLastQuarter = null,
        System.Int32? NumLrPlansFailedLastQuarter = null,
        System.Int32? NumLrPlansSucceededLastQuarter = null,
        System.Int32? NumVmwareVmsCoveredByRecoveryPlan = null,
        System.Int32? TotalDrPlans = null,
        System.Int32? TotalDrPlansWithTestScheduled = null,
        System.Int32? TotalIrPlans = null,
        System.Int32? TotalIrPlansWithTestScheduled = null,
        System.Int32? TotalLrPlans = null,
        System.Int32? TotalVmwareVmsWithSlaProtection = null
    ) 
    {
        if ( NumDrPlansFailedLastQuarter != null ) {
            this.NumDrPlansFailedLastQuarter = NumDrPlansFailedLastQuarter;
        }
        if ( NumDrPlansHasConfigError != null ) {
            this.NumDrPlansHasConfigError = NumDrPlansHasConfigError;
        }
        if ( NumDrPlansSucceededLastQuarter != null ) {
            this.NumDrPlansSucceededLastQuarter = NumDrPlansSucceededLastQuarter;
        }
        if ( NumIrPlansFailedLastQuarter != null ) {
            this.NumIrPlansFailedLastQuarter = NumIrPlansFailedLastQuarter;
        }
        if ( NumIrPlansSucceededLastQuarter != null ) {
            this.NumIrPlansSucceededLastQuarter = NumIrPlansSucceededLastQuarter;
        }
        if ( NumLrPlansFailedLastQuarter != null ) {
            this.NumLrPlansFailedLastQuarter = NumLrPlansFailedLastQuarter;
        }
        if ( NumLrPlansSucceededLastQuarter != null ) {
            this.NumLrPlansSucceededLastQuarter = NumLrPlansSucceededLastQuarter;
        }
        if ( NumVmwareVmsCoveredByRecoveryPlan != null ) {
            this.NumVmwareVmsCoveredByRecoveryPlan = NumVmwareVmsCoveredByRecoveryPlan;
        }
        if ( TotalDrPlans != null ) {
            this.TotalDrPlans = TotalDrPlans;
        }
        if ( TotalDrPlansWithTestScheduled != null ) {
            this.TotalDrPlansWithTestScheduled = TotalDrPlansWithTestScheduled;
        }
        if ( TotalIrPlans != null ) {
            this.TotalIrPlans = TotalIrPlans;
        }
        if ( TotalIrPlansWithTestScheduled != null ) {
            this.TotalIrPlansWithTestScheduled = TotalIrPlansWithTestScheduled;
        }
        if ( TotalLrPlans != null ) {
            this.TotalLrPlans = TotalLrPlans;
        }
        if ( TotalVmwareVmsWithSlaProtection != null ) {
            this.TotalVmwareVmsWithSlaProtection = TotalVmwareVmsWithSlaProtection;
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
        //      C# -> System.Int32? NumDrPlansFailedLastQuarter
        // GraphQL -> numDrPlansFailedLastQuarter: Int! (scalar)
        if (this.NumDrPlansFailedLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDrPlansFailedLastQuarter\n" ;
            } else {
                s += ind + "numDrPlansFailedLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumDrPlansHasConfigError
        // GraphQL -> numDrPlansHasConfigError: Int! (scalar)
        if (this.NumDrPlansHasConfigError != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDrPlansHasConfigError\n" ;
            } else {
                s += ind + "numDrPlansHasConfigError\n" ;
            }
        }
        //      C# -> System.Int32? NumDrPlansSucceededLastQuarter
        // GraphQL -> numDrPlansSucceededLastQuarter: Int! (scalar)
        if (this.NumDrPlansSucceededLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDrPlansSucceededLastQuarter\n" ;
            } else {
                s += ind + "numDrPlansSucceededLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumIrPlansFailedLastQuarter
        // GraphQL -> numIrPlansFailedLastQuarter: Int! (scalar)
        if (this.NumIrPlansFailedLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numIrPlansFailedLastQuarter\n" ;
            } else {
                s += ind + "numIrPlansFailedLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumIrPlansSucceededLastQuarter
        // GraphQL -> numIrPlansSucceededLastQuarter: Int! (scalar)
        if (this.NumIrPlansSucceededLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numIrPlansSucceededLastQuarter\n" ;
            } else {
                s += ind + "numIrPlansSucceededLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumLrPlansFailedLastQuarter
        // GraphQL -> numLrPlansFailedLastQuarter: Int! (scalar)
        if (this.NumLrPlansFailedLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLrPlansFailedLastQuarter\n" ;
            } else {
                s += ind + "numLrPlansFailedLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumLrPlansSucceededLastQuarter
        // GraphQL -> numLrPlansSucceededLastQuarter: Int! (scalar)
        if (this.NumLrPlansSucceededLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLrPlansSucceededLastQuarter\n" ;
            } else {
                s += ind + "numLrPlansSucceededLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumVmwareVmsCoveredByRecoveryPlan
        // GraphQL -> numVmwareVmsCoveredByRecoveryPlan: Int! (scalar)
        if (this.NumVmwareVmsCoveredByRecoveryPlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numVmwareVmsCoveredByRecoveryPlan\n" ;
            } else {
                s += ind + "numVmwareVmsCoveredByRecoveryPlan\n" ;
            }
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (this.TotalDrPlans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalDrPlans\n" ;
            } else {
                s += ind + "totalDrPlans\n" ;
            }
        }
        //      C# -> System.Int32? TotalDrPlansWithTestScheduled
        // GraphQL -> totalDrPlansWithTestScheduled: Int! (scalar)
        if (this.TotalDrPlansWithTestScheduled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalDrPlansWithTestScheduled\n" ;
            } else {
                s += ind + "totalDrPlansWithTestScheduled\n" ;
            }
        }
        //      C# -> System.Int32? TotalIrPlans
        // GraphQL -> totalIrPlans: Int! (scalar)
        if (this.TotalIrPlans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalIrPlans\n" ;
            } else {
                s += ind + "totalIrPlans\n" ;
            }
        }
        //      C# -> System.Int32? TotalIrPlansWithTestScheduled
        // GraphQL -> totalIrPlansWithTestScheduled: Int! (scalar)
        if (this.TotalIrPlansWithTestScheduled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalIrPlansWithTestScheduled\n" ;
            } else {
                s += ind + "totalIrPlansWithTestScheduled\n" ;
            }
        }
        //      C# -> System.Int32? TotalLrPlans
        // GraphQL -> totalLrPlans: Int! (scalar)
        if (this.TotalLrPlans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalLrPlans\n" ;
            } else {
                s += ind + "totalLrPlans\n" ;
            }
        }
        //      C# -> System.Int32? TotalVmwareVmsWithSlaProtection
        // GraphQL -> totalVmwareVmsWithSlaProtection: Int! (scalar)
        if (this.TotalVmwareVmsWithSlaProtection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalVmwareVmsWithSlaProtection\n" ;
            } else {
                s += ind + "totalVmwareVmsWithSlaProtection\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumDrPlansFailedLastQuarter
        // GraphQL -> numDrPlansFailedLastQuarter: Int! (scalar)
        if (ec.Includes("numDrPlansFailedLastQuarter",true))
        {
            if(this.NumDrPlansFailedLastQuarter == null) {

                this.NumDrPlansFailedLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDrPlansFailedLastQuarter != null && ec.Excludes("numDrPlansFailedLastQuarter",true))
        {
            this.NumDrPlansFailedLastQuarter = null;
        }
        //      C# -> System.Int32? NumDrPlansHasConfigError
        // GraphQL -> numDrPlansHasConfigError: Int! (scalar)
        if (ec.Includes("numDrPlansHasConfigError",true))
        {
            if(this.NumDrPlansHasConfigError == null) {

                this.NumDrPlansHasConfigError = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDrPlansHasConfigError != null && ec.Excludes("numDrPlansHasConfigError",true))
        {
            this.NumDrPlansHasConfigError = null;
        }
        //      C# -> System.Int32? NumDrPlansSucceededLastQuarter
        // GraphQL -> numDrPlansSucceededLastQuarter: Int! (scalar)
        if (ec.Includes("numDrPlansSucceededLastQuarter",true))
        {
            if(this.NumDrPlansSucceededLastQuarter == null) {

                this.NumDrPlansSucceededLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDrPlansSucceededLastQuarter != null && ec.Excludes("numDrPlansSucceededLastQuarter",true))
        {
            this.NumDrPlansSucceededLastQuarter = null;
        }
        //      C# -> System.Int32? NumIrPlansFailedLastQuarter
        // GraphQL -> numIrPlansFailedLastQuarter: Int! (scalar)
        if (ec.Includes("numIrPlansFailedLastQuarter",true))
        {
            if(this.NumIrPlansFailedLastQuarter == null) {

                this.NumIrPlansFailedLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumIrPlansFailedLastQuarter != null && ec.Excludes("numIrPlansFailedLastQuarter",true))
        {
            this.NumIrPlansFailedLastQuarter = null;
        }
        //      C# -> System.Int32? NumIrPlansSucceededLastQuarter
        // GraphQL -> numIrPlansSucceededLastQuarter: Int! (scalar)
        if (ec.Includes("numIrPlansSucceededLastQuarter",true))
        {
            if(this.NumIrPlansSucceededLastQuarter == null) {

                this.NumIrPlansSucceededLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumIrPlansSucceededLastQuarter != null && ec.Excludes("numIrPlansSucceededLastQuarter",true))
        {
            this.NumIrPlansSucceededLastQuarter = null;
        }
        //      C# -> System.Int32? NumLrPlansFailedLastQuarter
        // GraphQL -> numLrPlansFailedLastQuarter: Int! (scalar)
        if (ec.Includes("numLrPlansFailedLastQuarter",true))
        {
            if(this.NumLrPlansFailedLastQuarter == null) {

                this.NumLrPlansFailedLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLrPlansFailedLastQuarter != null && ec.Excludes("numLrPlansFailedLastQuarter",true))
        {
            this.NumLrPlansFailedLastQuarter = null;
        }
        //      C# -> System.Int32? NumLrPlansSucceededLastQuarter
        // GraphQL -> numLrPlansSucceededLastQuarter: Int! (scalar)
        if (ec.Includes("numLrPlansSucceededLastQuarter",true))
        {
            if(this.NumLrPlansSucceededLastQuarter == null) {

                this.NumLrPlansSucceededLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLrPlansSucceededLastQuarter != null && ec.Excludes("numLrPlansSucceededLastQuarter",true))
        {
            this.NumLrPlansSucceededLastQuarter = null;
        }
        //      C# -> System.Int32? NumVmwareVmsCoveredByRecoveryPlan
        // GraphQL -> numVmwareVmsCoveredByRecoveryPlan: Int! (scalar)
        if (ec.Includes("numVmwareVmsCoveredByRecoveryPlan",true))
        {
            if(this.NumVmwareVmsCoveredByRecoveryPlan == null) {

                this.NumVmwareVmsCoveredByRecoveryPlan = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumVmwareVmsCoveredByRecoveryPlan != null && ec.Excludes("numVmwareVmsCoveredByRecoveryPlan",true))
        {
            this.NumVmwareVmsCoveredByRecoveryPlan = null;
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (ec.Includes("totalDrPlans",true))
        {
            if(this.TotalDrPlans == null) {

                this.TotalDrPlans = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalDrPlans != null && ec.Excludes("totalDrPlans",true))
        {
            this.TotalDrPlans = null;
        }
        //      C# -> System.Int32? TotalDrPlansWithTestScheduled
        // GraphQL -> totalDrPlansWithTestScheduled: Int! (scalar)
        if (ec.Includes("totalDrPlansWithTestScheduled",true))
        {
            if(this.TotalDrPlansWithTestScheduled == null) {

                this.TotalDrPlansWithTestScheduled = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalDrPlansWithTestScheduled != null && ec.Excludes("totalDrPlansWithTestScheduled",true))
        {
            this.TotalDrPlansWithTestScheduled = null;
        }
        //      C# -> System.Int32? TotalIrPlans
        // GraphQL -> totalIrPlans: Int! (scalar)
        if (ec.Includes("totalIrPlans",true))
        {
            if(this.TotalIrPlans == null) {

                this.TotalIrPlans = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalIrPlans != null && ec.Excludes("totalIrPlans",true))
        {
            this.TotalIrPlans = null;
        }
        //      C# -> System.Int32? TotalIrPlansWithTestScheduled
        // GraphQL -> totalIrPlansWithTestScheduled: Int! (scalar)
        if (ec.Includes("totalIrPlansWithTestScheduled",true))
        {
            if(this.TotalIrPlansWithTestScheduled == null) {

                this.TotalIrPlansWithTestScheduled = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalIrPlansWithTestScheduled != null && ec.Excludes("totalIrPlansWithTestScheduled",true))
        {
            this.TotalIrPlansWithTestScheduled = null;
        }
        //      C# -> System.Int32? TotalLrPlans
        // GraphQL -> totalLrPlans: Int! (scalar)
        if (ec.Includes("totalLrPlans",true))
        {
            if(this.TotalLrPlans == null) {

                this.TotalLrPlans = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalLrPlans != null && ec.Excludes("totalLrPlans",true))
        {
            this.TotalLrPlans = null;
        }
        //      C# -> System.Int32? TotalVmwareVmsWithSlaProtection
        // GraphQL -> totalVmwareVmsWithSlaProtection: Int! (scalar)
        if (ec.Includes("totalVmwareVmsWithSlaProtection",true))
        {
            if(this.TotalVmwareVmsWithSlaProtection == null) {

                this.TotalVmwareVmsWithSlaProtection = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalVmwareVmsWithSlaProtection != null && ec.Excludes("totalVmwareVmsWithSlaProtection",true))
        {
            this.TotalVmwareVmsWithSlaProtection = null;
        }
    }


    #endregion

    } // class ProtectionSummary
    
    #endregion

    public static class ListProtectionSummaryExtensions
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
            this List<ProtectionSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProtectionSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectionSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectionSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectionSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types