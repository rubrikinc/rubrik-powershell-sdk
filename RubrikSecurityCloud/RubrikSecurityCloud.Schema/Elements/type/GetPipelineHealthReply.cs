// GetPipelineHealthReply.cs
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
    #region GetPipelineHealthReply
    public class GetPipelineHealthReply: BaseType
    {
        #region members

        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        [JsonProperty("failedAnalysis")]
        public System.Int64? FailedAnalysis { get; set; }

        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        [JsonProperty("failedBackup")]
        public System.Int64? FailedBackup { get; set; }

        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        [JsonProperty("failedIndexing")]
        public System.Int64? FailedIndexing { get; set; }

        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        [JsonProperty("totalAnalysis")]
        public System.Int64? TotalAnalysis { get; set; }

        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        [JsonProperty("totalBackup")]
        public System.Int64? TotalBackup { get; set; }

        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        [JsonProperty("totalIndexing")]
        public System.Int64? TotalIndexing { get; set; }


        #endregion

    #region methods

    public GetPipelineHealthReply Set(
        System.Int64? FailedAnalysis = null,
        System.Int64? FailedBackup = null,
        System.Int64? FailedIndexing = null,
        System.Int64? TotalAnalysis = null,
        System.Int64? TotalBackup = null,
        System.Int64? TotalIndexing = null
    ) 
    {
        if ( FailedAnalysis != null ) {
            this.FailedAnalysis = FailedAnalysis;
        }
        if ( FailedBackup != null ) {
            this.FailedBackup = FailedBackup;
        }
        if ( FailedIndexing != null ) {
            this.FailedIndexing = FailedIndexing;
        }
        if ( TotalAnalysis != null ) {
            this.TotalAnalysis = TotalAnalysis;
        }
        if ( TotalBackup != null ) {
            this.TotalBackup = TotalBackup;
        }
        if ( TotalIndexing != null ) {
            this.TotalIndexing = TotalIndexing;
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
        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        if (this.FailedAnalysis != null) {
            s += ind + "failedAnalysis\n" ;
        }
        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        if (this.FailedBackup != null) {
            s += ind + "failedBackup\n" ;
        }
        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        if (this.FailedIndexing != null) {
            s += ind + "failedIndexing\n" ;
        }
        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        if (this.TotalAnalysis != null) {
            s += ind + "totalAnalysis\n" ;
        }
        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        if (this.TotalBackup != null) {
            s += ind + "totalBackup\n" ;
        }
        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        if (this.TotalIndexing != null) {
            s += ind + "totalIndexing\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        if (this.FailedAnalysis == null && Exploration.Includes(parent + ".failedAnalysis", true))
        {
            this.FailedAnalysis = new System.Int64();
        }
        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        if (this.FailedBackup == null && Exploration.Includes(parent + ".failedBackup", true))
        {
            this.FailedBackup = new System.Int64();
        }
        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        if (this.FailedIndexing == null && Exploration.Includes(parent + ".failedIndexing", true))
        {
            this.FailedIndexing = new System.Int64();
        }
        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        if (this.TotalAnalysis == null && Exploration.Includes(parent + ".totalAnalysis", true))
        {
            this.TotalAnalysis = new System.Int64();
        }
        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        if (this.TotalBackup == null && Exploration.Includes(parent + ".totalBackup", true))
        {
            this.TotalBackup = new System.Int64();
        }
        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        if (this.TotalIndexing == null && Exploration.Includes(parent + ".totalIndexing", true))
        {
            this.TotalIndexing = new System.Int64();
        }
    }


    #endregion

    } // class GetPipelineHealthReply
    
    #endregion

    public static class ListGetPipelineHealthReplyExtensions
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
            this List<GetPipelineHealthReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPipelineHealthReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPipelineHealthReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types