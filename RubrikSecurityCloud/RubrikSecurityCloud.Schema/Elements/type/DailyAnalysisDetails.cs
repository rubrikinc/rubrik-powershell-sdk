// DailyAnalysisDetails.cs
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
    #region DailyAnalysisDetails
    public class DailyAnalysisDetails: BaseType
    {
        #region members

        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        [JsonProperty("anomalyEventCount")]
        public System.Int64? AnomalyEventCount { get; set; }

        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        [JsonProperty("createdDataBytes")]
        public System.Int64? CreatedDataBytes { get; set; }

        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        [JsonProperty("createdFileCount")]
        public System.Int64? CreatedFileCount { get; set; }

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        [JsonProperty("deletedDataBytes")]
        public System.Int64? DeletedDataBytes { get; set; }

        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        [JsonProperty("deletedFileCount")]
        public System.Int64? DeletedFileCount { get; set; }

        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        [JsonProperty("modifiedDataBytes")]
        public System.Int64? ModifiedDataBytes { get; set; }

        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        [JsonProperty("modifiedFileCount")]
        public System.Int64? ModifiedFileCount { get; set; }

        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        [JsonProperty("suspiciousDataBytes")]
        public System.Int64? SuspiciousDataBytes { get; set; }

        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        [JsonProperty("suspiciousFileCount")]
        public System.Int64? SuspiciousFileCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DailyAnalysisDetails";
    }

    public DailyAnalysisDetails Set(
        System.Int64? AnomalyEventCount = null,
        System.Int64? CreatedDataBytes = null,
        System.Int64? CreatedFileCount = null,
        System.String? Day = null,
        System.Int64? DeletedDataBytes = null,
        System.Int64? DeletedFileCount = null,
        System.Int64? ModifiedDataBytes = null,
        System.Int64? ModifiedFileCount = null,
        System.Int64? SuspiciousDataBytes = null,
        System.Int64? SuspiciousFileCount = null
    ) 
    {
        if ( AnomalyEventCount != null ) {
            this.AnomalyEventCount = AnomalyEventCount;
        }
        if ( CreatedDataBytes != null ) {
            this.CreatedDataBytes = CreatedDataBytes;
        }
        if ( CreatedFileCount != null ) {
            this.CreatedFileCount = CreatedFileCount;
        }
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( DeletedDataBytes != null ) {
            this.DeletedDataBytes = DeletedDataBytes;
        }
        if ( DeletedFileCount != null ) {
            this.DeletedFileCount = DeletedFileCount;
        }
        if ( ModifiedDataBytes != null ) {
            this.ModifiedDataBytes = ModifiedDataBytes;
        }
        if ( ModifiedFileCount != null ) {
            this.ModifiedFileCount = ModifiedFileCount;
        }
        if ( SuspiciousDataBytes != null ) {
            this.SuspiciousDataBytes = SuspiciousDataBytes;
        }
        if ( SuspiciousFileCount != null ) {
            this.SuspiciousFileCount = SuspiciousFileCount;
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
        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        if (this.AnomalyEventCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyEventCount\n" ;
            } else {
                s += ind + "anomalyEventCount\n" ;
            }
        }
        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        if (this.CreatedDataBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDataBytes\n" ;
            } else {
                s += ind + "createdDataBytes\n" ;
            }
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdFileCount\n" ;
            } else {
                s += ind + "createdFileCount\n" ;
            }
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day != null) {
            if (conf.Flat) {
                s += conf.Prefix + "day\n" ;
            } else {
                s += ind + "day\n" ;
            }
        }
        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        if (this.DeletedDataBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletedDataBytes\n" ;
            } else {
                s += ind + "deletedDataBytes\n" ;
            }
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletedFileCount\n" ;
            } else {
                s += ind + "deletedFileCount\n" ;
            }
        }
        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        if (this.ModifiedDataBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedDataBytes\n" ;
            } else {
                s += ind + "modifiedDataBytes\n" ;
            }
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedFileCount\n" ;
            } else {
                s += ind + "modifiedFileCount\n" ;
            }
        }
        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        if (this.SuspiciousDataBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "suspiciousDataBytes\n" ;
            } else {
                s += ind + "suspiciousDataBytes\n" ;
            }
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "suspiciousFileCount\n" ;
            } else {
                s += ind + "suspiciousFileCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        if (ec.Includes("anomalyEventCount",true))
        {
            if(this.AnomalyEventCount == null) {

                this.AnomalyEventCount = new System.Int64();

            } else {


            }
        }
        else if (this.AnomalyEventCount != null && ec.Excludes("anomalyEventCount",true))
        {
            this.AnomalyEventCount = null;
        }
        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        if (ec.Includes("createdDataBytes",true))
        {
            if(this.CreatedDataBytes == null) {

                this.CreatedDataBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CreatedDataBytes != null && ec.Excludes("createdDataBytes",true))
        {
            this.CreatedDataBytes = null;
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (ec.Includes("createdFileCount",true))
        {
            if(this.CreatedFileCount == null) {

                this.CreatedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.CreatedFileCount != null && ec.Excludes("createdFileCount",true))
        {
            this.CreatedFileCount = null;
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (ec.Includes("day",true))
        {
            if(this.Day == null) {

                this.Day = "FETCH";

            } else {


            }
        }
        else if (this.Day != null && ec.Excludes("day",true))
        {
            this.Day = null;
        }
        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        if (ec.Includes("deletedDataBytes",true))
        {
            if(this.DeletedDataBytes == null) {

                this.DeletedDataBytes = new System.Int64();

            } else {


            }
        }
        else if (this.DeletedDataBytes != null && ec.Excludes("deletedDataBytes",true))
        {
            this.DeletedDataBytes = null;
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (ec.Includes("deletedFileCount",true))
        {
            if(this.DeletedFileCount == null) {

                this.DeletedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.DeletedFileCount != null && ec.Excludes("deletedFileCount",true))
        {
            this.DeletedFileCount = null;
        }
        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        if (ec.Includes("modifiedDataBytes",true))
        {
            if(this.ModifiedDataBytes == null) {

                this.ModifiedDataBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ModifiedDataBytes != null && ec.Excludes("modifiedDataBytes",true))
        {
            this.ModifiedDataBytes = null;
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (ec.Includes("modifiedFileCount",true))
        {
            if(this.ModifiedFileCount == null) {

                this.ModifiedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.ModifiedFileCount != null && ec.Excludes("modifiedFileCount",true))
        {
            this.ModifiedFileCount = null;
        }
        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        if (ec.Includes("suspiciousDataBytes",true))
        {
            if(this.SuspiciousDataBytes == null) {

                this.SuspiciousDataBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SuspiciousDataBytes != null && ec.Excludes("suspiciousDataBytes",true))
        {
            this.SuspiciousDataBytes = null;
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (ec.Includes("suspiciousFileCount",true))
        {
            if(this.SuspiciousFileCount == null) {

                this.SuspiciousFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.SuspiciousFileCount != null && ec.Excludes("suspiciousFileCount",true))
        {
            this.SuspiciousFileCount = null;
        }
    }


    #endregion

    } // class DailyAnalysisDetails
    
    #endregion

    public static class ListDailyAnalysisDetailsExtensions
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
            this List<DailyAnalysisDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DailyAnalysisDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DailyAnalysisDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyAnalysisDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DailyAnalysisDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types