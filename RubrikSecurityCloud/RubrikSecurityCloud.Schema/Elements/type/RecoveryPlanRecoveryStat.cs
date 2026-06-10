// RecoveryPlanRecoveryStat.cs
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
    #region RecoveryPlanRecoveryStat
    public class RecoveryPlanRecoveryStat: BaseType
    {
        #region members

        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        [JsonProperty("recoveryPlanType")]
        public RecoveryPlanType? RecoveryPlanType { get; set; }

        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        [JsonProperty("recoveryType")]
        public RecoveryType? RecoveryType { get; set; }

        //      C# -> System.Int64? TotalFailedRecoveryCount
        // GraphQL -> totalFailedRecoveryCount: Long! (scalar)
        [JsonProperty("totalFailedRecoveryCount")]
        public System.Int64? TotalFailedRecoveryCount { get; set; }

        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        [JsonProperty("totalRecoveryCount")]
        public System.Int64? TotalRecoveryCount { get; set; }

        //      C# -> System.Int64? TotalSuccessfulRecoveryCount
        // GraphQL -> totalSuccessfulRecoveryCount: Long! (scalar)
        [JsonProperty("totalSuccessfulRecoveryCount")]
        public System.Int64? TotalSuccessfulRecoveryCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanRecoveryStat";
    }

    public RecoveryPlanRecoveryStat Set(
        RecoveryPlanType? RecoveryPlanType = null,
        RecoveryType? RecoveryType = null,
        System.Int64? TotalFailedRecoveryCount = null,
        System.Int64? TotalRecoveryCount = null,
        System.Int64? TotalSuccessfulRecoveryCount = null
    ) 
    {
        if ( RecoveryPlanType != null ) {
            this.RecoveryPlanType = RecoveryPlanType;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
        }
        if ( TotalFailedRecoveryCount != null ) {
            this.TotalFailedRecoveryCount = TotalFailedRecoveryCount;
        }
        if ( TotalRecoveryCount != null ) {
            this.TotalRecoveryCount = TotalRecoveryCount;
        }
        if ( TotalSuccessfulRecoveryCount != null ) {
            this.TotalSuccessfulRecoveryCount = TotalSuccessfulRecoveryCount;
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
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (this.RecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryType\n" ;
            } else {
                s += ind + "recoveryType\n" ;
            }
        }
        //      C# -> System.Int64? TotalFailedRecoveryCount
        // GraphQL -> totalFailedRecoveryCount: Long! (scalar)
        if (this.TotalFailedRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalFailedRecoveryCount\n" ;
            } else {
                s += ind + "totalFailedRecoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        if (this.TotalRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalRecoveryCount\n" ;
            } else {
                s += ind + "totalRecoveryCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalSuccessfulRecoveryCount
        // GraphQL -> totalSuccessfulRecoveryCount: Long! (scalar)
        if (this.TotalSuccessfulRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSuccessfulRecoveryCount\n" ;
            } else {
                s += ind + "totalSuccessfulRecoveryCount\n" ;
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
        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType! (enum)
        if (ec.Includes("recoveryType",true))
        {
            if(this.RecoveryType == null) {

                this.RecoveryType = new RecoveryType();

            } else {


            }
        }
        else if (this.RecoveryType != null && ec.Excludes("recoveryType",true))
        {
            this.RecoveryType = null;
        }
        //      C# -> System.Int64? TotalFailedRecoveryCount
        // GraphQL -> totalFailedRecoveryCount: Long! (scalar)
        if (ec.Includes("totalFailedRecoveryCount",true))
        {
            if(this.TotalFailedRecoveryCount == null) {

                this.TotalFailedRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalFailedRecoveryCount != null && ec.Excludes("totalFailedRecoveryCount",true))
        {
            this.TotalFailedRecoveryCount = null;
        }
        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        if (ec.Includes("totalRecoveryCount",true))
        {
            if(this.TotalRecoveryCount == null) {

                this.TotalRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalRecoveryCount != null && ec.Excludes("totalRecoveryCount",true))
        {
            this.TotalRecoveryCount = null;
        }
        //      C# -> System.Int64? TotalSuccessfulRecoveryCount
        // GraphQL -> totalSuccessfulRecoveryCount: Long! (scalar)
        if (ec.Includes("totalSuccessfulRecoveryCount",true))
        {
            if(this.TotalSuccessfulRecoveryCount == null) {

                this.TotalSuccessfulRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSuccessfulRecoveryCount != null && ec.Excludes("totalSuccessfulRecoveryCount",true))
        {
            this.TotalSuccessfulRecoveryCount = null;
        }
    }


    #endregion

    } // class RecoveryPlanRecoveryStat
    
    #endregion

    public static class ListRecoveryPlanRecoveryStatExtensions
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
            this List<RecoveryPlanRecoveryStat> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanRecoveryStat> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanRecoveryStat> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanRecoveryStat());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanRecoveryStat> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types