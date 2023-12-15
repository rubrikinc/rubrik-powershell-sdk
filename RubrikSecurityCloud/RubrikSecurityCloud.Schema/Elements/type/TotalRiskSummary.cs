// TotalRiskSummary.cs
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
    #region TotalRiskSummary
    public class TotalRiskSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalHighRiskHits
        // GraphQL -> totalHighRiskHits: Long! (scalar)
        [JsonProperty("totalHighRiskHits")]
        public System.Int64? TotalHighRiskHits { get; set; }

        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        [JsonProperty("totalHits")]
        public System.Int64? TotalHits { get; set; }

        //      C# -> System.Int64? TotalLowRiskHits
        // GraphQL -> totalLowRiskHits: Long! (scalar)
        [JsonProperty("totalLowRiskHits")]
        public System.Int64? TotalLowRiskHits { get; set; }

        //      C# -> System.Int64? TotalMediumRiskHits
        // GraphQL -> totalMediumRiskHits: Long! (scalar)
        [JsonProperty("totalMediumRiskHits")]
        public System.Int64? TotalMediumRiskHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TotalRiskSummary";
    }

    public TotalRiskSummary Set(
        System.Int64? TotalHighRiskHits = null,
        System.Int64? TotalHits = null,
        System.Int64? TotalLowRiskHits = null,
        System.Int64? TotalMediumRiskHits = null
    ) 
    {
        if ( TotalHighRiskHits != null ) {
            this.TotalHighRiskHits = TotalHighRiskHits;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( TotalLowRiskHits != null ) {
            this.TotalLowRiskHits = TotalLowRiskHits;
        }
        if ( TotalMediumRiskHits != null ) {
            this.TotalMediumRiskHits = TotalMediumRiskHits;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? TotalHighRiskHits
        // GraphQL -> totalHighRiskHits: Long! (scalar)
        if (this.TotalHighRiskHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHighRiskHits\n" ;
            } else {
                s += ind + "totalHighRiskHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalLowRiskHits
        // GraphQL -> totalLowRiskHits: Long! (scalar)
        if (this.TotalLowRiskHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalLowRiskHits\n" ;
            } else {
                s += ind + "totalLowRiskHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalMediumRiskHits
        // GraphQL -> totalMediumRiskHits: Long! (scalar)
        if (this.TotalMediumRiskHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalMediumRiskHits\n" ;
            } else {
                s += ind + "totalMediumRiskHits\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? TotalHighRiskHits
        // GraphQL -> totalHighRiskHits: Long! (scalar)
        if (ec.Includes("totalHighRiskHits",true))
        {
            if(this.TotalHighRiskHits == null) {

                this.TotalHighRiskHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHighRiskHits != null && ec.Excludes("totalHighRiskHits",true))
        {
            this.TotalHighRiskHits = null;
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
        }
        //      C# -> System.Int64? TotalLowRiskHits
        // GraphQL -> totalLowRiskHits: Long! (scalar)
        if (ec.Includes("totalLowRiskHits",true))
        {
            if(this.TotalLowRiskHits == null) {

                this.TotalLowRiskHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalLowRiskHits != null && ec.Excludes("totalLowRiskHits",true))
        {
            this.TotalLowRiskHits = null;
        }
        //      C# -> System.Int64? TotalMediumRiskHits
        // GraphQL -> totalMediumRiskHits: Long! (scalar)
        if (ec.Includes("totalMediumRiskHits",true))
        {
            if(this.TotalMediumRiskHits == null) {

                this.TotalMediumRiskHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalMediumRiskHits != null && ec.Excludes("totalMediumRiskHits",true))
        {
            this.TotalMediumRiskHits = null;
        }
    }


    #endregion

    } // class TotalRiskSummary
    
    #endregion

    public static class ListTotalRiskSummaryExtensions
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
            this List<TotalRiskSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TotalRiskSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TotalRiskSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TotalRiskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TotalRiskSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types