// AggregatedValues.cs
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
    #region AggregatedValues
    public class AggregatedValues: BaseType
    {
        #region members

        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        [JsonProperty("maxCreatedFileCount")]
        public System.Int64? MaxCreatedFileCount { get; set; }

        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        [JsonProperty("maxDeletedFileCount")]
        public System.Int64? MaxDeletedFileCount { get; set; }

        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        [JsonProperty("maxModifiedFileCount")]
        public System.Int64? MaxModifiedFileCount { get; set; }

        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        [JsonProperty("maxSuspiciousFileCount")]
        public System.Int64? MaxSuspiciousFileCount { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AggregatedValues";
    }

    public AggregatedValues Set(
        System.Int64? MaxCreatedFileCount = null,
        System.Int64? MaxDeletedFileCount = null,
        System.Int64? MaxModifiedFileCount = null,
        System.Int64? MaxSuspiciousFileCount = null,
        System.Int64? Total = null
    ) 
    {
        if ( MaxCreatedFileCount != null ) {
            this.MaxCreatedFileCount = MaxCreatedFileCount;
        }
        if ( MaxDeletedFileCount != null ) {
            this.MaxDeletedFileCount = MaxDeletedFileCount;
        }
        if ( MaxModifiedFileCount != null ) {
            this.MaxModifiedFileCount = MaxModifiedFileCount;
        }
        if ( MaxSuspiciousFileCount != null ) {
            this.MaxSuspiciousFileCount = MaxSuspiciousFileCount;
        }
        if ( Total != null ) {
            this.Total = Total;
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
        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        if (this.MaxCreatedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxCreatedFileCount\n" ;
            } else {
                s += ind + "maxCreatedFileCount\n" ;
            }
        }
        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        if (this.MaxDeletedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxDeletedFileCount\n" ;
            } else {
                s += ind + "maxDeletedFileCount\n" ;
            }
        }
        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        if (this.MaxModifiedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxModifiedFileCount\n" ;
            } else {
                s += ind + "maxModifiedFileCount\n" ;
            }
        }
        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        if (this.MaxSuspiciousFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxSuspiciousFileCount\n" ;
            } else {
                s += ind + "maxSuspiciousFileCount\n" ;
            }
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        if (ec.Includes("maxCreatedFileCount",true))
        {
            if(this.MaxCreatedFileCount == null) {

                this.MaxCreatedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.MaxCreatedFileCount != null && ec.Excludes("maxCreatedFileCount",true))
        {
            this.MaxCreatedFileCount = null;
        }
        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        if (ec.Includes("maxDeletedFileCount",true))
        {
            if(this.MaxDeletedFileCount == null) {

                this.MaxDeletedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.MaxDeletedFileCount != null && ec.Excludes("maxDeletedFileCount",true))
        {
            this.MaxDeletedFileCount = null;
        }
        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        if (ec.Includes("maxModifiedFileCount",true))
        {
            if(this.MaxModifiedFileCount == null) {

                this.MaxModifiedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.MaxModifiedFileCount != null && ec.Excludes("maxModifiedFileCount",true))
        {
            this.MaxModifiedFileCount = null;
        }
        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        if (ec.Includes("maxSuspiciousFileCount",true))
        {
            if(this.MaxSuspiciousFileCount == null) {

                this.MaxSuspiciousFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.MaxSuspiciousFileCount != null && ec.Excludes("maxSuspiciousFileCount",true))
        {
            this.MaxSuspiciousFileCount = null;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = new System.Int64();

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
    }


    #endregion

    } // class AggregatedValues
    
    #endregion

    public static class ListAggregatedValuesExtensions
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
            this List<AggregatedValues> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AggregatedValues> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AggregatedValues> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AggregatedValues());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AggregatedValues> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types