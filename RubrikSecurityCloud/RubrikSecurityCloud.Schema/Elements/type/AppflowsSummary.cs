// AppflowsSummary.cs
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
    #region AppflowsSummary
    public class AppflowsSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? NumBlueprintsReady
        // GraphQL -> numBlueprintsReady: Int! (scalar)
        [JsonProperty("numBlueprintsReady")]
        public System.Int32? NumBlueprintsReady { get; set; }

        //      C# -> System.Int32? NumBlueprintsWithIssues
        // GraphQL -> numBlueprintsWithIssues: Int! (scalar)
        [JsonProperty("numBlueprintsWithIssues")]
        public System.Int32? NumBlueprintsWithIssues { get; set; }

        //      C# -> System.Int32? NumBpFailedLastFailover
        // GraphQL -> numBpFailedLastFailover: Int! (scalar)
        [JsonProperty("numBpFailedLastFailover")]
        public System.Int32? NumBpFailedLastFailover { get; set; }

        //      C# -> System.Int32? NumBpFailedLastTestFailover
        // GraphQL -> numBpFailedLastTestFailover: Int! (scalar)
        [JsonProperty("numBpFailedLastTestFailover")]
        public System.Int32? NumBpFailedLastTestFailover { get; set; }

        //      C# -> System.Int32? NumBpFailedTestFailoverLastQuarter
        // GraphQL -> numBpFailedTestFailoverLastQuarter: Int! (scalar)
        [JsonProperty("numBpFailedTestFailoverLastQuarter")]
        public System.Int32? NumBpFailedTestFailoverLastQuarter { get; set; }

        //      C# -> System.Int32? NumBpPassedLastFailover
        // GraphQL -> numBpPassedLastFailover: Int! (scalar)
        [JsonProperty("numBpPassedLastFailover")]
        public System.Int32? NumBpPassedLastFailover { get; set; }

        //      C# -> System.Int32? NumBpPassedLastTestFailover
        // GraphQL -> numBpPassedLastTestFailover: Int! (scalar)
        [JsonProperty("numBpPassedLastTestFailover")]
        public System.Int32? NumBpPassedLastTestFailover { get; set; }

        //      C# -> System.Int32? NumDrPlansReady
        // GraphQL -> numDrPlansReady: Int! (scalar)
        [JsonProperty("numDrPlansReady")]
        public System.Int32? NumDrPlansReady { get; set; }

        //      C# -> System.Int32? NumDrPlansWithIssues
        // GraphQL -> numDrPlansWithIssues: Int! (scalar)
        [JsonProperty("numDrPlansWithIssues")]
        public System.Int32? NumDrPlansWithIssues { get; set; }

        //      C# -> System.Int32? NumVmwareVmsProtected
        // GraphQL -> numVmwareVmsProtected: Int! (scalar)
        [JsonProperty("numVmwareVmsProtected")]
        public System.Int32? NumVmwareVmsProtected { get; set; }

        //      C# -> System.Int32? TotalBlueprints
        // GraphQL -> totalBlueprints: Int! (scalar)
        [JsonProperty("totalBlueprints")]
        public System.Int32? TotalBlueprints { get; set; }

        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        [JsonProperty("totalDrPlans")]
        public System.Int32? TotalDrPlans { get; set; }

        //      C# -> System.Int32? TotalVmwareVms
        // GraphQL -> totalVmwareVms: Int! (scalar)
        [JsonProperty("totalVmwareVms")]
        public System.Int32? TotalVmwareVms { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppflowsSummary";
    }

    public AppflowsSummary Set(
        System.Int32? NumBlueprintsReady = null,
        System.Int32? NumBlueprintsWithIssues = null,
        System.Int32? NumBpFailedLastFailover = null,
        System.Int32? NumBpFailedLastTestFailover = null,
        System.Int32? NumBpFailedTestFailoverLastQuarter = null,
        System.Int32? NumBpPassedLastFailover = null,
        System.Int32? NumBpPassedLastTestFailover = null,
        System.Int32? NumDrPlansReady = null,
        System.Int32? NumDrPlansWithIssues = null,
        System.Int32? NumVmwareVmsProtected = null,
        System.Int32? TotalBlueprints = null,
        System.Int32? TotalDrPlans = null,
        System.Int32? TotalVmwareVms = null
    ) 
    {
        if ( NumBlueprintsReady != null ) {
            this.NumBlueprintsReady = NumBlueprintsReady;
        }
        if ( NumBlueprintsWithIssues != null ) {
            this.NumBlueprintsWithIssues = NumBlueprintsWithIssues;
        }
        if ( NumBpFailedLastFailover != null ) {
            this.NumBpFailedLastFailover = NumBpFailedLastFailover;
        }
        if ( NumBpFailedLastTestFailover != null ) {
            this.NumBpFailedLastTestFailover = NumBpFailedLastTestFailover;
        }
        if ( NumBpFailedTestFailoverLastQuarter != null ) {
            this.NumBpFailedTestFailoverLastQuarter = NumBpFailedTestFailoverLastQuarter;
        }
        if ( NumBpPassedLastFailover != null ) {
            this.NumBpPassedLastFailover = NumBpPassedLastFailover;
        }
        if ( NumBpPassedLastTestFailover != null ) {
            this.NumBpPassedLastTestFailover = NumBpPassedLastTestFailover;
        }
        if ( NumDrPlansReady != null ) {
            this.NumDrPlansReady = NumDrPlansReady;
        }
        if ( NumDrPlansWithIssues != null ) {
            this.NumDrPlansWithIssues = NumDrPlansWithIssues;
        }
        if ( NumVmwareVmsProtected != null ) {
            this.NumVmwareVmsProtected = NumVmwareVmsProtected;
        }
        if ( TotalBlueprints != null ) {
            this.TotalBlueprints = TotalBlueprints;
        }
        if ( TotalDrPlans != null ) {
            this.TotalDrPlans = TotalDrPlans;
        }
        if ( TotalVmwareVms != null ) {
            this.TotalVmwareVms = TotalVmwareVms;
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
        //      C# -> System.Int32? NumBlueprintsReady
        // GraphQL -> numBlueprintsReady: Int! (scalar)
        if (this.NumBlueprintsReady != null) {
            s += ind + "numBlueprintsReady\n" ;
        }
        //      C# -> System.Int32? NumBlueprintsWithIssues
        // GraphQL -> numBlueprintsWithIssues: Int! (scalar)
        if (this.NumBlueprintsWithIssues != null) {
            s += ind + "numBlueprintsWithIssues\n" ;
        }
        //      C# -> System.Int32? NumBpFailedLastFailover
        // GraphQL -> numBpFailedLastFailover: Int! (scalar)
        if (this.NumBpFailedLastFailover != null) {
            s += ind + "numBpFailedLastFailover\n" ;
        }
        //      C# -> System.Int32? NumBpFailedLastTestFailover
        // GraphQL -> numBpFailedLastTestFailover: Int! (scalar)
        if (this.NumBpFailedLastTestFailover != null) {
            s += ind + "numBpFailedLastTestFailover\n" ;
        }
        //      C# -> System.Int32? NumBpFailedTestFailoverLastQuarter
        // GraphQL -> numBpFailedTestFailoverLastQuarter: Int! (scalar)
        if (this.NumBpFailedTestFailoverLastQuarter != null) {
            s += ind + "numBpFailedTestFailoverLastQuarter\n" ;
        }
        //      C# -> System.Int32? NumBpPassedLastFailover
        // GraphQL -> numBpPassedLastFailover: Int! (scalar)
        if (this.NumBpPassedLastFailover != null) {
            s += ind + "numBpPassedLastFailover\n" ;
        }
        //      C# -> System.Int32? NumBpPassedLastTestFailover
        // GraphQL -> numBpPassedLastTestFailover: Int! (scalar)
        if (this.NumBpPassedLastTestFailover != null) {
            s += ind + "numBpPassedLastTestFailover\n" ;
        }
        //      C# -> System.Int32? NumDrPlansReady
        // GraphQL -> numDrPlansReady: Int! (scalar)
        if (this.NumDrPlansReady != null) {
            s += ind + "numDrPlansReady\n" ;
        }
        //      C# -> System.Int32? NumDrPlansWithIssues
        // GraphQL -> numDrPlansWithIssues: Int! (scalar)
        if (this.NumDrPlansWithIssues != null) {
            s += ind + "numDrPlansWithIssues\n" ;
        }
        //      C# -> System.Int32? NumVmwareVmsProtected
        // GraphQL -> numVmwareVmsProtected: Int! (scalar)
        if (this.NumVmwareVmsProtected != null) {
            s += ind + "numVmwareVmsProtected\n" ;
        }
        //      C# -> System.Int32? TotalBlueprints
        // GraphQL -> totalBlueprints: Int! (scalar)
        if (this.TotalBlueprints != null) {
            s += ind + "totalBlueprints\n" ;
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (this.TotalDrPlans != null) {
            s += ind + "totalDrPlans\n" ;
        }
        //      C# -> System.Int32? TotalVmwareVms
        // GraphQL -> totalVmwareVms: Int! (scalar)
        if (this.TotalVmwareVms != null) {
            s += ind + "totalVmwareVms\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? NumBlueprintsReady
        // GraphQL -> numBlueprintsReady: Int! (scalar)
        if (this.NumBlueprintsReady == null && Exploration.Includes(parent + ".numBlueprintsReady", true))
        {
            this.NumBlueprintsReady = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBlueprintsWithIssues
        // GraphQL -> numBlueprintsWithIssues: Int! (scalar)
        if (this.NumBlueprintsWithIssues == null && Exploration.Includes(parent + ".numBlueprintsWithIssues", true))
        {
            this.NumBlueprintsWithIssues = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBpFailedLastFailover
        // GraphQL -> numBpFailedLastFailover: Int! (scalar)
        if (this.NumBpFailedLastFailover == null && Exploration.Includes(parent + ".numBpFailedLastFailover", true))
        {
            this.NumBpFailedLastFailover = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBpFailedLastTestFailover
        // GraphQL -> numBpFailedLastTestFailover: Int! (scalar)
        if (this.NumBpFailedLastTestFailover == null && Exploration.Includes(parent + ".numBpFailedLastTestFailover", true))
        {
            this.NumBpFailedLastTestFailover = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBpFailedTestFailoverLastQuarter
        // GraphQL -> numBpFailedTestFailoverLastQuarter: Int! (scalar)
        if (this.NumBpFailedTestFailoverLastQuarter == null && Exploration.Includes(parent + ".numBpFailedTestFailoverLastQuarter", true))
        {
            this.NumBpFailedTestFailoverLastQuarter = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBpPassedLastFailover
        // GraphQL -> numBpPassedLastFailover: Int! (scalar)
        if (this.NumBpPassedLastFailover == null && Exploration.Includes(parent + ".numBpPassedLastFailover", true))
        {
            this.NumBpPassedLastFailover = Int32.MinValue;
        }
        //      C# -> System.Int32? NumBpPassedLastTestFailover
        // GraphQL -> numBpPassedLastTestFailover: Int! (scalar)
        if (this.NumBpPassedLastTestFailover == null && Exploration.Includes(parent + ".numBpPassedLastTestFailover", true))
        {
            this.NumBpPassedLastTestFailover = Int32.MinValue;
        }
        //      C# -> System.Int32? NumDrPlansReady
        // GraphQL -> numDrPlansReady: Int! (scalar)
        if (this.NumDrPlansReady == null && Exploration.Includes(parent + ".numDrPlansReady", true))
        {
            this.NumDrPlansReady = Int32.MinValue;
        }
        //      C# -> System.Int32? NumDrPlansWithIssues
        // GraphQL -> numDrPlansWithIssues: Int! (scalar)
        if (this.NumDrPlansWithIssues == null && Exploration.Includes(parent + ".numDrPlansWithIssues", true))
        {
            this.NumDrPlansWithIssues = Int32.MinValue;
        }
        //      C# -> System.Int32? NumVmwareVmsProtected
        // GraphQL -> numVmwareVmsProtected: Int! (scalar)
        if (this.NumVmwareVmsProtected == null && Exploration.Includes(parent + ".numVmwareVmsProtected", true))
        {
            this.NumVmwareVmsProtected = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalBlueprints
        // GraphQL -> totalBlueprints: Int! (scalar)
        if (this.TotalBlueprints == null && Exploration.Includes(parent + ".totalBlueprints", true))
        {
            this.TotalBlueprints = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (this.TotalDrPlans == null && Exploration.Includes(parent + ".totalDrPlans", true))
        {
            this.TotalDrPlans = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalVmwareVms
        // GraphQL -> totalVmwareVms: Int! (scalar)
        if (this.TotalVmwareVms == null && Exploration.Includes(parent + ".totalVmwareVms", true))
        {
            this.TotalVmwareVms = Int32.MinValue;
        }
    }


    #endregion

    } // class AppflowsSummary
    
    #endregion

    public static class ListAppflowsSummaryExtensions
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
            this List<AppflowsSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AppflowsSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AppflowsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types