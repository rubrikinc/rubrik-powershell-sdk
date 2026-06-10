// AccountRecoveryPlanSummary.cs
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
    #region AccountRecoveryPlanSummary
    public class AccountRecoveryPlanSummary: BaseType
    {
        #region members

        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        [JsonProperty("recoveryPlanType")]
        public RecoveryPlanType? RecoveryPlanType { get; set; }

        //      C# -> System.Int32? NumRecoveryPlansFailedLastQuarter
        // GraphQL -> numRecoveryPlansFailedLastQuarter: Int! (scalar)
        [JsonProperty("numRecoveryPlansFailedLastQuarter")]
        public System.Int32? NumRecoveryPlansFailedLastQuarter { get; set; }

        //      C# -> System.Int32? NumRecoveryPlansSucceededLastQuarter
        // GraphQL -> numRecoveryPlansSucceededLastQuarter: Int! (scalar)
        [JsonProperty("numRecoveryPlansSucceededLastQuarter")]
        public System.Int32? NumRecoveryPlansSucceededLastQuarter { get; set; }

        //      C# -> System.Int32? NumRecoveryPlansWithConfigError
        // GraphQL -> numRecoveryPlansWithConfigError: Int! (scalar)
        [JsonProperty("numRecoveryPlansWithConfigError")]
        public System.Int32? NumRecoveryPlansWithConfigError { get; set; }

        //      C# -> System.Int32? NumRecoveryPlansWithTestScheduled
        // GraphQL -> numRecoveryPlansWithTestScheduled: Int! (scalar)
        [JsonProperty("numRecoveryPlansWithTestScheduled")]
        public System.Int32? NumRecoveryPlansWithTestScheduled { get; set; }

        //      C# -> System.Int32? TotalRecoveryPlans
        // GraphQL -> totalRecoveryPlans: Int! (scalar)
        [JsonProperty("totalRecoveryPlans")]
        public System.Int32? TotalRecoveryPlans { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AccountRecoveryPlanSummary";
    }

    public AccountRecoveryPlanSummary Set(
        RecoveryPlanType? RecoveryPlanType = null,
        System.Int32? NumRecoveryPlansFailedLastQuarter = null,
        System.Int32? NumRecoveryPlansSucceededLastQuarter = null,
        System.Int32? NumRecoveryPlansWithConfigError = null,
        System.Int32? NumRecoveryPlansWithTestScheduled = null,
        System.Int32? TotalRecoveryPlans = null
    ) 
    {
        if ( RecoveryPlanType != null ) {
            this.RecoveryPlanType = RecoveryPlanType;
        }
        if ( NumRecoveryPlansFailedLastQuarter != null ) {
            this.NumRecoveryPlansFailedLastQuarter = NumRecoveryPlansFailedLastQuarter;
        }
        if ( NumRecoveryPlansSucceededLastQuarter != null ) {
            this.NumRecoveryPlansSucceededLastQuarter = NumRecoveryPlansSucceededLastQuarter;
        }
        if ( NumRecoveryPlansWithConfigError != null ) {
            this.NumRecoveryPlansWithConfigError = NumRecoveryPlansWithConfigError;
        }
        if ( NumRecoveryPlansWithTestScheduled != null ) {
            this.NumRecoveryPlansWithTestScheduled = NumRecoveryPlansWithTestScheduled;
        }
        if ( TotalRecoveryPlans != null ) {
            this.TotalRecoveryPlans = TotalRecoveryPlans;
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
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (this.RecoveryPlanType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanType\n" ;
            } else {
                s += ind + "recoveryPlanType\n" ;
            }
        }
        //      C# -> System.Int32? NumRecoveryPlansFailedLastQuarter
        // GraphQL -> numRecoveryPlansFailedLastQuarter: Int! (scalar)
        if (this.NumRecoveryPlansFailedLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numRecoveryPlansFailedLastQuarter\n" ;
            } else {
                s += ind + "numRecoveryPlansFailedLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumRecoveryPlansSucceededLastQuarter
        // GraphQL -> numRecoveryPlansSucceededLastQuarter: Int! (scalar)
        if (this.NumRecoveryPlansSucceededLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numRecoveryPlansSucceededLastQuarter\n" ;
            } else {
                s += ind + "numRecoveryPlansSucceededLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumRecoveryPlansWithConfigError
        // GraphQL -> numRecoveryPlansWithConfigError: Int! (scalar)
        if (this.NumRecoveryPlansWithConfigError != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numRecoveryPlansWithConfigError\n" ;
            } else {
                s += ind + "numRecoveryPlansWithConfigError\n" ;
            }
        }
        //      C# -> System.Int32? NumRecoveryPlansWithTestScheduled
        // GraphQL -> numRecoveryPlansWithTestScheduled: Int! (scalar)
        if (this.NumRecoveryPlansWithTestScheduled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numRecoveryPlansWithTestScheduled\n" ;
            } else {
                s += ind + "numRecoveryPlansWithTestScheduled\n" ;
            }
        }
        //      C# -> System.Int32? TotalRecoveryPlans
        // GraphQL -> totalRecoveryPlans: Int! (scalar)
        if (this.TotalRecoveryPlans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalRecoveryPlans\n" ;
            } else {
                s += ind + "totalRecoveryPlans\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (ec.Includes("recoveryPlanType",true))
        {
            if(this.RecoveryPlanType == null) {

                this.RecoveryPlanType = new RecoveryPlanType();

            } else {


            }
        }
        else if (this.RecoveryPlanType != null && ec.Excludes("recoveryPlanType",true))
        {
            this.RecoveryPlanType = null;
        }
        //      C# -> System.Int32? NumRecoveryPlansFailedLastQuarter
        // GraphQL -> numRecoveryPlansFailedLastQuarter: Int! (scalar)
        if (ec.Includes("numRecoveryPlansFailedLastQuarter",true))
        {
            if(this.NumRecoveryPlansFailedLastQuarter == null) {

                this.NumRecoveryPlansFailedLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumRecoveryPlansFailedLastQuarter != null && ec.Excludes("numRecoveryPlansFailedLastQuarter",true))
        {
            this.NumRecoveryPlansFailedLastQuarter = null;
        }
        //      C# -> System.Int32? NumRecoveryPlansSucceededLastQuarter
        // GraphQL -> numRecoveryPlansSucceededLastQuarter: Int! (scalar)
        if (ec.Includes("numRecoveryPlansSucceededLastQuarter",true))
        {
            if(this.NumRecoveryPlansSucceededLastQuarter == null) {

                this.NumRecoveryPlansSucceededLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumRecoveryPlansSucceededLastQuarter != null && ec.Excludes("numRecoveryPlansSucceededLastQuarter",true))
        {
            this.NumRecoveryPlansSucceededLastQuarter = null;
        }
        //      C# -> System.Int32? NumRecoveryPlansWithConfigError
        // GraphQL -> numRecoveryPlansWithConfigError: Int! (scalar)
        if (ec.Includes("numRecoveryPlansWithConfigError",true))
        {
            if(this.NumRecoveryPlansWithConfigError == null) {

                this.NumRecoveryPlansWithConfigError = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumRecoveryPlansWithConfigError != null && ec.Excludes("numRecoveryPlansWithConfigError",true))
        {
            this.NumRecoveryPlansWithConfigError = null;
        }
        //      C# -> System.Int32? NumRecoveryPlansWithTestScheduled
        // GraphQL -> numRecoveryPlansWithTestScheduled: Int! (scalar)
        if (ec.Includes("numRecoveryPlansWithTestScheduled",true))
        {
            if(this.NumRecoveryPlansWithTestScheduled == null) {

                this.NumRecoveryPlansWithTestScheduled = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumRecoveryPlansWithTestScheduled != null && ec.Excludes("numRecoveryPlansWithTestScheduled",true))
        {
            this.NumRecoveryPlansWithTestScheduled = null;
        }
        //      C# -> System.Int32? TotalRecoveryPlans
        // GraphQL -> totalRecoveryPlans: Int! (scalar)
        if (ec.Includes("totalRecoveryPlans",true))
        {
            if(this.TotalRecoveryPlans == null) {

                this.TotalRecoveryPlans = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalRecoveryPlans != null && ec.Excludes("totalRecoveryPlans",true))
        {
            this.TotalRecoveryPlans = null;
        }
    }


    #endregion

    } // class AccountRecoveryPlanSummary
    
    #endregion

    public static class ListAccountRecoveryPlanSummaryExtensions
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
            this List<AccountRecoveryPlanSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AccountRecoveryPlanSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AccountRecoveryPlanSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AccountRecoveryPlanSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AccountRecoveryPlanSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types