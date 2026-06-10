// ProtectionSummaryV2.cs
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
    #region ProtectionSummaryV2
    public class ProtectionSummaryV2: BaseType
    {
        #region members

        //      C# -> System.Int32? NumWorkloadsCoveredByRecoveryPlan
        // GraphQL -> numWorkloadsCoveredByRecoveryPlan: Int! (scalar)
        [JsonProperty("numWorkloadsCoveredByRecoveryPlan")]
        public System.Int32? NumWorkloadsCoveredByRecoveryPlan { get; set; }

        //      C# -> System.Int32? TotalWorkloadsWithSlaProtection
        // GraphQL -> totalWorkloadsWithSlaProtection: Int! (scalar)
        [JsonProperty("totalWorkloadsWithSlaProtection")]
        public System.Int32? TotalWorkloadsWithSlaProtection { get; set; }

        //      C# -> List<AccountRecoveryPlanSummary>? RecoveryPlanSummaries
        // GraphQL -> recoveryPlanSummaries: [AccountRecoveryPlanSummary!]! (type)
        [JsonProperty("recoveryPlanSummaries")]
        public List<AccountRecoveryPlanSummary>? RecoveryPlanSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectionSummaryV2";
    }

    public ProtectionSummaryV2 Set(
        System.Int32? NumWorkloadsCoveredByRecoveryPlan = null,
        System.Int32? TotalWorkloadsWithSlaProtection = null,
        List<AccountRecoveryPlanSummary>? RecoveryPlanSummaries = null
    ) 
    {
        if ( NumWorkloadsCoveredByRecoveryPlan != null ) {
            this.NumWorkloadsCoveredByRecoveryPlan = NumWorkloadsCoveredByRecoveryPlan;
        }
        if ( TotalWorkloadsWithSlaProtection != null ) {
            this.TotalWorkloadsWithSlaProtection = TotalWorkloadsWithSlaProtection;
        }
        if ( RecoveryPlanSummaries != null ) {
            this.RecoveryPlanSummaries = RecoveryPlanSummaries;
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
        //      C# -> System.Int32? NumWorkloadsCoveredByRecoveryPlan
        // GraphQL -> numWorkloadsCoveredByRecoveryPlan: Int! (scalar)
        if (this.NumWorkloadsCoveredByRecoveryPlan != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloadsCoveredByRecoveryPlan\n" ;
            } else {
                s += ind + "numWorkloadsCoveredByRecoveryPlan\n" ;
            }
        }
        //      C# -> System.Int32? TotalWorkloadsWithSlaProtection
        // GraphQL -> totalWorkloadsWithSlaProtection: Int! (scalar)
        if (this.TotalWorkloadsWithSlaProtection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalWorkloadsWithSlaProtection\n" ;
            } else {
                s += ind + "totalWorkloadsWithSlaProtection\n" ;
            }
        }
        //      C# -> List<AccountRecoveryPlanSummary>? RecoveryPlanSummaries
        // GraphQL -> recoveryPlanSummaries: [AccountRecoveryPlanSummary!]! (type)
        if (this.RecoveryPlanSummaries != null) {
            var fspec = this.RecoveryPlanSummaries.AsFieldSpec(conf.Child("recoveryPlanSummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlanSummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? NumWorkloadsCoveredByRecoveryPlan
        // GraphQL -> numWorkloadsCoveredByRecoveryPlan: Int! (scalar)
        if (ec.Includes("numWorkloadsCoveredByRecoveryPlan",true))
        {
            if(this.NumWorkloadsCoveredByRecoveryPlan == null) {

                this.NumWorkloadsCoveredByRecoveryPlan = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumWorkloadsCoveredByRecoveryPlan != null && ec.Excludes("numWorkloadsCoveredByRecoveryPlan",true))
        {
            this.NumWorkloadsCoveredByRecoveryPlan = null;
        }
        //      C# -> System.Int32? TotalWorkloadsWithSlaProtection
        // GraphQL -> totalWorkloadsWithSlaProtection: Int! (scalar)
        if (ec.Includes("totalWorkloadsWithSlaProtection",true))
        {
            if(this.TotalWorkloadsWithSlaProtection == null) {

                this.TotalWorkloadsWithSlaProtection = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalWorkloadsWithSlaProtection != null && ec.Excludes("totalWorkloadsWithSlaProtection",true))
        {
            this.TotalWorkloadsWithSlaProtection = null;
        }
        //      C# -> List<AccountRecoveryPlanSummary>? RecoveryPlanSummaries
        // GraphQL -> recoveryPlanSummaries: [AccountRecoveryPlanSummary!]! (type)
        if (ec.Includes("recoveryPlanSummaries",false))
        {
            if(this.RecoveryPlanSummaries == null) {

                this.RecoveryPlanSummaries = new List<AccountRecoveryPlanSummary>();
                this.RecoveryPlanSummaries.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanSummaries"));

            } else {

                this.RecoveryPlanSummaries.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanSummaries"));

            }
        }
        else if (this.RecoveryPlanSummaries != null && ec.Excludes("recoveryPlanSummaries",false))
        {
            this.RecoveryPlanSummaries = null;
        }
    }


    #endregion

    } // class ProtectionSummaryV2
    
    #endregion

    public static class ListProtectionSummaryV2Extensions
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
            this List<ProtectionSummaryV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProtectionSummaryV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectionSummaryV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectionSummaryV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectionSummaryV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types