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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        if (this.AnomalyEventCount != null) {
            s += ind + "anomalyEventCount\n" ;
        }
        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        if (this.CreatedDataBytes != null) {
            s += ind + "createdDataBytes\n" ;
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount != null) {
            s += ind + "createdFileCount\n" ;
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day != null) {
            s += ind + "day\n" ;
        }
        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        if (this.DeletedDataBytes != null) {
            s += ind + "deletedDataBytes\n" ;
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount != null) {
            s += ind + "deletedFileCount\n" ;
        }
        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        if (this.ModifiedDataBytes != null) {
            s += ind + "modifiedDataBytes\n" ;
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount != null) {
            s += ind + "modifiedFileCount\n" ;
        }
        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        if (this.SuspiciousDataBytes != null) {
            s += ind + "suspiciousDataBytes\n" ;
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount != null) {
            s += ind + "suspiciousFileCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        if (this.AnomalyEventCount == null && Exploration.Includes(parent + ".anomalyEventCount", true))
        {
            this.AnomalyEventCount = new System.Int64();
        }
        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        if (this.CreatedDataBytes == null && Exploration.Includes(parent + ".createdDataBytes", true))
        {
            this.CreatedDataBytes = new System.Int64();
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount == null && Exploration.Includes(parent + ".createdFileCount", true))
        {
            this.CreatedFileCount = new System.Int64();
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day == null && Exploration.Includes(parent + ".day", true))
        {
            this.Day = "FETCH";
        }
        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        if (this.DeletedDataBytes == null && Exploration.Includes(parent + ".deletedDataBytes", true))
        {
            this.DeletedDataBytes = new System.Int64();
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount == null && Exploration.Includes(parent + ".deletedFileCount", true))
        {
            this.DeletedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        if (this.ModifiedDataBytes == null && Exploration.Includes(parent + ".modifiedDataBytes", true))
        {
            this.ModifiedDataBytes = new System.Int64();
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount == null && Exploration.Includes(parent + ".modifiedFileCount", true))
        {
            this.ModifiedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        if (this.SuspiciousDataBytes == null && Exploration.Includes(parent + ".suspiciousDataBytes", true))
        {
            this.SuspiciousDataBytes = new System.Int64();
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount == null && Exploration.Includes(parent + ".suspiciousFileCount", true))
        {
            this.SuspiciousFileCount = new System.Int64();
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DailyAnalysisDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyAnalysisDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types