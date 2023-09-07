// RansomwareMonitoringPipelineHealth.cs
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
    #region RansomwareMonitoringPipelineHealth
    public class RansomwareMonitoringPipelineHealth: BaseType
    {
        #region members

        //      C# -> System.Int64? ActiveHunts
        // GraphQL -> activeHunts: Long! (scalar)
        [JsonProperty("activeHunts")]
        public System.Int64? ActiveHunts { get; set; }

        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        [JsonProperty("anomaliesFound")]
        public System.Int64? AnomaliesFound { get; set; }

        //      C# -> System.Int64? FailedBackups
        // GraphQL -> failedBackups: Long! (scalar)
        [JsonProperty("failedBackups")]
        public System.Int64? FailedBackups { get; set; }

        //      C# -> System.Int64? MatchedHunts
        // GraphQL -> matchedHunts: Long! (scalar)
        [JsonProperty("matchedHunts")]
        public System.Int64? MatchedHunts { get; set; }

        //      C# -> System.Int64? SuccessfulBackups
        // GraphQL -> successfulBackups: Long! (scalar)
        [JsonProperty("successfulBackups")]
        public System.Int64? SuccessfulBackups { get; set; }

        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        [JsonProperty("threatsFound")]
        public System.Int64? ThreatsFound { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareMonitoringPipelineHealth";
    }

    public RansomwareMonitoringPipelineHealth Set(
        System.Int64? ActiveHunts = null,
        System.Int64? AnomaliesFound = null,
        System.Int64? FailedBackups = null,
        System.Int64? MatchedHunts = null,
        System.Int64? SuccessfulBackups = null,
        System.Int64? ThreatsFound = null
    ) 
    {
        if ( ActiveHunts != null ) {
            this.ActiveHunts = ActiveHunts;
        }
        if ( AnomaliesFound != null ) {
            this.AnomaliesFound = AnomaliesFound;
        }
        if ( FailedBackups != null ) {
            this.FailedBackups = FailedBackups;
        }
        if ( MatchedHunts != null ) {
            this.MatchedHunts = MatchedHunts;
        }
        if ( SuccessfulBackups != null ) {
            this.SuccessfulBackups = SuccessfulBackups;
        }
        if ( ThreatsFound != null ) {
            this.ThreatsFound = ThreatsFound;
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
        //      C# -> System.Int64? ActiveHunts
        // GraphQL -> activeHunts: Long! (scalar)
        if (this.ActiveHunts != null) {
            s += ind + "activeHunts\n" ;
        }
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound != null) {
            s += ind + "anomaliesFound\n" ;
        }
        //      C# -> System.Int64? FailedBackups
        // GraphQL -> failedBackups: Long! (scalar)
        if (this.FailedBackups != null) {
            s += ind + "failedBackups\n" ;
        }
        //      C# -> System.Int64? MatchedHunts
        // GraphQL -> matchedHunts: Long! (scalar)
        if (this.MatchedHunts != null) {
            s += ind + "matchedHunts\n" ;
        }
        //      C# -> System.Int64? SuccessfulBackups
        // GraphQL -> successfulBackups: Long! (scalar)
        if (this.SuccessfulBackups != null) {
            s += ind + "successfulBackups\n" ;
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (this.ThreatsFound != null) {
            s += ind + "threatsFound\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ActiveHunts
        // GraphQL -> activeHunts: Long! (scalar)
        if (this.ActiveHunts == null && ec.Includes("activeHunts",true))
        {
            this.ActiveHunts = new System.Int64();
        }
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound == null && ec.Includes("anomaliesFound",true))
        {
            this.AnomaliesFound = new System.Int64();
        }
        //      C# -> System.Int64? FailedBackups
        // GraphQL -> failedBackups: Long! (scalar)
        if (this.FailedBackups == null && ec.Includes("failedBackups",true))
        {
            this.FailedBackups = new System.Int64();
        }
        //      C# -> System.Int64? MatchedHunts
        // GraphQL -> matchedHunts: Long! (scalar)
        if (this.MatchedHunts == null && ec.Includes("matchedHunts",true))
        {
            this.MatchedHunts = new System.Int64();
        }
        //      C# -> System.Int64? SuccessfulBackups
        // GraphQL -> successfulBackups: Long! (scalar)
        if (this.SuccessfulBackups == null && ec.Includes("successfulBackups",true))
        {
            this.SuccessfulBackups = new System.Int64();
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (this.ThreatsFound == null && ec.Includes("threatsFound",true))
        {
            this.ThreatsFound = new System.Int64();
        }
    }


    #endregion

    } // class RansomwareMonitoringPipelineHealth
    
    #endregion

    public static class ListRansomwareMonitoringPipelineHealthExtensions
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
            this List<RansomwareMonitoringPipelineHealth> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareMonitoringPipelineHealth> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareMonitoringPipelineHealth());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RansomwareMonitoringPipelineHealth> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types