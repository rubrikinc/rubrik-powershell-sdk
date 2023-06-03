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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        if (this.MaxCreatedFileCount != null) {
            s += ind + "maxCreatedFileCount\n" ;
        }
        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        if (this.MaxDeletedFileCount != null) {
            s += ind + "maxDeletedFileCount\n" ;
        }
        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        if (this.MaxModifiedFileCount != null) {
            s += ind + "maxModifiedFileCount\n" ;
        }
        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        if (this.MaxSuspiciousFileCount != null) {
            s += ind + "maxSuspiciousFileCount\n" ;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        if (this.MaxCreatedFileCount == null && Exploration.Includes(parent + ".maxCreatedFileCount", true))
        {
            this.MaxCreatedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        if (this.MaxDeletedFileCount == null && Exploration.Includes(parent + ".maxDeletedFileCount", true))
        {
            this.MaxDeletedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        if (this.MaxModifiedFileCount == null && Exploration.Includes(parent + ".maxModifiedFileCount", true))
        {
            this.MaxModifiedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        if (this.MaxSuspiciousFileCount == null && Exploration.Includes(parent + ".maxSuspiciousFileCount", true))
        {
            this.MaxSuspiciousFileCount = new System.Int64();
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (this.Total == null && Exploration.Includes(parent + ".total", true))
        {
            this.Total = new System.Int64();
        }
    }


    #endregion

    } // class AggregatedValues
    
    #endregion

    public static class ListAggregatedValuesExtensions
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
            this List<AggregatedValues> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AggregatedValues> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AggregatedValues());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types