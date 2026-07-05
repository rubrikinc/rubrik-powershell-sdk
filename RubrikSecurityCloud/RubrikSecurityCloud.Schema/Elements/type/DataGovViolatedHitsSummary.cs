// DataGovViolatedHitsSummary.cs
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
    #region DataGovViolatedHitsSummary
 
    public class DataGovViolatedHitsSummary: BaseType, ViolationsInsights
    {
        #region members

        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedHighRiskSensitiveHits")]
        public System.Int64? ViolatedHighRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedLowRiskSensitiveHits")]
        public System.Int64? ViolatedLowRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedMediumRiskSensitiveHits")]
        public System.Int64? ViolatedMediumRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedNoRiskSensitiveHits")]
        public System.Int64? ViolatedNoRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        [JsonProperty("violatedSensitiveFiles")]
        public System.Int64? ViolatedSensitiveFiles { get; set; }

        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        [JsonProperty("violatedSensitiveHits")]
        public System.Int64? ViolatedSensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataGovViolatedHitsSummary";
    }

    public DataGovViolatedHitsSummary Set(
        System.Int64? ViolatedHighRiskSensitiveHits = null,
        System.Int64? ViolatedLowRiskSensitiveHits = null,
        System.Int64? ViolatedMediumRiskSensitiveHits = null,
        System.Int64? ViolatedNoRiskSensitiveHits = null,
        System.Int64? ViolatedSensitiveFiles = null,
        System.Int64? ViolatedSensitiveHits = null
    ) 
    {
        if ( ViolatedHighRiskSensitiveHits != null ) {
            this.ViolatedHighRiskSensitiveHits = ViolatedHighRiskSensitiveHits;
        }
        if ( ViolatedLowRiskSensitiveHits != null ) {
            this.ViolatedLowRiskSensitiveHits = ViolatedLowRiskSensitiveHits;
        }
        if ( ViolatedMediumRiskSensitiveHits != null ) {
            this.ViolatedMediumRiskSensitiveHits = ViolatedMediumRiskSensitiveHits;
        }
        if ( ViolatedNoRiskSensitiveHits != null ) {
            this.ViolatedNoRiskSensitiveHits = ViolatedNoRiskSensitiveHits;
        }
        if ( ViolatedSensitiveFiles != null ) {
            this.ViolatedSensitiveFiles = ViolatedSensitiveFiles;
        }
        if ( ViolatedSensitiveHits != null ) {
            this.ViolatedSensitiveHits = ViolatedSensitiveHits;
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
        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedHighRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedHighRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedHighRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedLowRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedLowRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedLowRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedMediumRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedMediumRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedMediumRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedNoRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedNoRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedNoRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        if (this.ViolatedSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedSensitiveFiles\n" ;
            } else {
                s += ind + "violatedSensitiveFiles\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        if (this.ViolatedSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedSensitiveHits\n" ;
            } else {
                s += ind + "violatedSensitiveHits\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedHighRiskSensitiveHits",true))
        {
            if(this.ViolatedHighRiskSensitiveHits == null) {

                this.ViolatedHighRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedHighRiskSensitiveHits != null && ec.Excludes("violatedHighRiskSensitiveHits",true))
        {
            this.ViolatedHighRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedLowRiskSensitiveHits",true))
        {
            if(this.ViolatedLowRiskSensitiveHits == null) {

                this.ViolatedLowRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedLowRiskSensitiveHits != null && ec.Excludes("violatedLowRiskSensitiveHits",true))
        {
            this.ViolatedLowRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedMediumRiskSensitiveHits",true))
        {
            if(this.ViolatedMediumRiskSensitiveHits == null) {

                this.ViolatedMediumRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedMediumRiskSensitiveHits != null && ec.Excludes("violatedMediumRiskSensitiveHits",true))
        {
            this.ViolatedMediumRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedNoRiskSensitiveHits",true))
        {
            if(this.ViolatedNoRiskSensitiveHits == null) {

                this.ViolatedNoRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedNoRiskSensitiveHits != null && ec.Excludes("violatedNoRiskSensitiveHits",true))
        {
            this.ViolatedNoRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        if (ec.Includes("violatedSensitiveFiles",true))
        {
            if(this.ViolatedSensitiveFiles == null) {

                this.ViolatedSensitiveFiles = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedSensitiveFiles != null && ec.Excludes("violatedSensitiveFiles",true))
        {
            this.ViolatedSensitiveFiles = null;
        }
        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedSensitiveHits",true))
        {
            if(this.ViolatedSensitiveHits == null) {

                this.ViolatedSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedSensitiveHits != null && ec.Excludes("violatedSensitiveHits",true))
        {
            this.ViolatedSensitiveHits = null;
        }
    }


    #endregion

    } // class DataGovViolatedHitsSummary
    
    #endregion

    public static class ListDataGovViolatedHitsSummaryExtensions
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
            this List<DataGovViolatedHitsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataGovViolatedHitsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataGovViolatedHitsSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataGovViolatedHitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataGovViolatedHitsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types