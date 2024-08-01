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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? NumBlueprintsReady
        // GraphQL -> numBlueprintsReady: Int! (scalar)
        if (this.NumBlueprintsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBlueprintsReady\n" ;
            } else {
                s += ind + "numBlueprintsReady\n" ;
            }
        }
        //      C# -> System.Int32? NumBlueprintsWithIssues
        // GraphQL -> numBlueprintsWithIssues: Int! (scalar)
        if (this.NumBlueprintsWithIssues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBlueprintsWithIssues\n" ;
            } else {
                s += ind + "numBlueprintsWithIssues\n" ;
            }
        }
        //      C# -> System.Int32? NumBpFailedLastFailover
        // GraphQL -> numBpFailedLastFailover: Int! (scalar)
        if (this.NumBpFailedLastFailover != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBpFailedLastFailover\n" ;
            } else {
                s += ind + "numBpFailedLastFailover\n" ;
            }
        }
        //      C# -> System.Int32? NumBpFailedLastTestFailover
        // GraphQL -> numBpFailedLastTestFailover: Int! (scalar)
        if (this.NumBpFailedLastTestFailover != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBpFailedLastTestFailover\n" ;
            } else {
                s += ind + "numBpFailedLastTestFailover\n" ;
            }
        }
        //      C# -> System.Int32? NumBpFailedTestFailoverLastQuarter
        // GraphQL -> numBpFailedTestFailoverLastQuarter: Int! (scalar)
        if (this.NumBpFailedTestFailoverLastQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBpFailedTestFailoverLastQuarter\n" ;
            } else {
                s += ind + "numBpFailedTestFailoverLastQuarter\n" ;
            }
        }
        //      C# -> System.Int32? NumBpPassedLastFailover
        // GraphQL -> numBpPassedLastFailover: Int! (scalar)
        if (this.NumBpPassedLastFailover != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBpPassedLastFailover\n" ;
            } else {
                s += ind + "numBpPassedLastFailover\n" ;
            }
        }
        //      C# -> System.Int32? NumBpPassedLastTestFailover
        // GraphQL -> numBpPassedLastTestFailover: Int! (scalar)
        if (this.NumBpPassedLastTestFailover != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBpPassedLastTestFailover\n" ;
            } else {
                s += ind + "numBpPassedLastTestFailover\n" ;
            }
        }
        //      C# -> System.Int32? NumDrPlansReady
        // GraphQL -> numDrPlansReady: Int! (scalar)
        if (this.NumDrPlansReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDrPlansReady\n" ;
            } else {
                s += ind + "numDrPlansReady\n" ;
            }
        }
        //      C# -> System.Int32? NumDrPlansWithIssues
        // GraphQL -> numDrPlansWithIssues: Int! (scalar)
        if (this.NumDrPlansWithIssues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDrPlansWithIssues\n" ;
            } else {
                s += ind + "numDrPlansWithIssues\n" ;
            }
        }
        //      C# -> System.Int32? NumVmwareVmsProtected
        // GraphQL -> numVmwareVmsProtected: Int! (scalar)
        if (this.NumVmwareVmsProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numVmwareVmsProtected\n" ;
            } else {
                s += ind + "numVmwareVmsProtected\n" ;
            }
        }
        //      C# -> System.Int32? TotalBlueprints
        // GraphQL -> totalBlueprints: Int! (scalar)
        if (this.TotalBlueprints != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalBlueprints\n" ;
            } else {
                s += ind + "totalBlueprints\n" ;
            }
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (this.TotalDrPlans != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalDrPlans\n" ;
            } else {
                s += ind + "totalDrPlans\n" ;
            }
        }
        //      C# -> System.Int32? TotalVmwareVms
        // GraphQL -> totalVmwareVms: Int! (scalar)
        if (this.TotalVmwareVms != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalVmwareVms\n" ;
            } else {
                s += ind + "totalVmwareVms\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumBlueprintsReady
        // GraphQL -> numBlueprintsReady: Int! (scalar)
        if (ec.Includes("numBlueprintsReady",true))
        {
            if(this.NumBlueprintsReady == null) {

                this.NumBlueprintsReady = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBlueprintsReady != null && ec.Excludes("numBlueprintsReady",true))
        {
            this.NumBlueprintsReady = null;
        }
        //      C# -> System.Int32? NumBlueprintsWithIssues
        // GraphQL -> numBlueprintsWithIssues: Int! (scalar)
        if (ec.Includes("numBlueprintsWithIssues",true))
        {
            if(this.NumBlueprintsWithIssues == null) {

                this.NumBlueprintsWithIssues = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBlueprintsWithIssues != null && ec.Excludes("numBlueprintsWithIssues",true))
        {
            this.NumBlueprintsWithIssues = null;
        }
        //      C# -> System.Int32? NumBpFailedLastFailover
        // GraphQL -> numBpFailedLastFailover: Int! (scalar)
        if (ec.Includes("numBpFailedLastFailover",true))
        {
            if(this.NumBpFailedLastFailover == null) {

                this.NumBpFailedLastFailover = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBpFailedLastFailover != null && ec.Excludes("numBpFailedLastFailover",true))
        {
            this.NumBpFailedLastFailover = null;
        }
        //      C# -> System.Int32? NumBpFailedLastTestFailover
        // GraphQL -> numBpFailedLastTestFailover: Int! (scalar)
        if (ec.Includes("numBpFailedLastTestFailover",true))
        {
            if(this.NumBpFailedLastTestFailover == null) {

                this.NumBpFailedLastTestFailover = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBpFailedLastTestFailover != null && ec.Excludes("numBpFailedLastTestFailover",true))
        {
            this.NumBpFailedLastTestFailover = null;
        }
        //      C# -> System.Int32? NumBpFailedTestFailoverLastQuarter
        // GraphQL -> numBpFailedTestFailoverLastQuarter: Int! (scalar)
        if (ec.Includes("numBpFailedTestFailoverLastQuarter",true))
        {
            if(this.NumBpFailedTestFailoverLastQuarter == null) {

                this.NumBpFailedTestFailoverLastQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBpFailedTestFailoverLastQuarter != null && ec.Excludes("numBpFailedTestFailoverLastQuarter",true))
        {
            this.NumBpFailedTestFailoverLastQuarter = null;
        }
        //      C# -> System.Int32? NumBpPassedLastFailover
        // GraphQL -> numBpPassedLastFailover: Int! (scalar)
        if (ec.Includes("numBpPassedLastFailover",true))
        {
            if(this.NumBpPassedLastFailover == null) {

                this.NumBpPassedLastFailover = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBpPassedLastFailover != null && ec.Excludes("numBpPassedLastFailover",true))
        {
            this.NumBpPassedLastFailover = null;
        }
        //      C# -> System.Int32? NumBpPassedLastTestFailover
        // GraphQL -> numBpPassedLastTestFailover: Int! (scalar)
        if (ec.Includes("numBpPassedLastTestFailover",true))
        {
            if(this.NumBpPassedLastTestFailover == null) {

                this.NumBpPassedLastTestFailover = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumBpPassedLastTestFailover != null && ec.Excludes("numBpPassedLastTestFailover",true))
        {
            this.NumBpPassedLastTestFailover = null;
        }
        //      C# -> System.Int32? NumDrPlansReady
        // GraphQL -> numDrPlansReady: Int! (scalar)
        if (ec.Includes("numDrPlansReady",true))
        {
            if(this.NumDrPlansReady == null) {

                this.NumDrPlansReady = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDrPlansReady != null && ec.Excludes("numDrPlansReady",true))
        {
            this.NumDrPlansReady = null;
        }
        //      C# -> System.Int32? NumDrPlansWithIssues
        // GraphQL -> numDrPlansWithIssues: Int! (scalar)
        if (ec.Includes("numDrPlansWithIssues",true))
        {
            if(this.NumDrPlansWithIssues == null) {

                this.NumDrPlansWithIssues = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDrPlansWithIssues != null && ec.Excludes("numDrPlansWithIssues",true))
        {
            this.NumDrPlansWithIssues = null;
        }
        //      C# -> System.Int32? NumVmwareVmsProtected
        // GraphQL -> numVmwareVmsProtected: Int! (scalar)
        if (ec.Includes("numVmwareVmsProtected",true))
        {
            if(this.NumVmwareVmsProtected == null) {

                this.NumVmwareVmsProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumVmwareVmsProtected != null && ec.Excludes("numVmwareVmsProtected",true))
        {
            this.NumVmwareVmsProtected = null;
        }
        //      C# -> System.Int32? TotalBlueprints
        // GraphQL -> totalBlueprints: Int! (scalar)
        if (ec.Includes("totalBlueprints",true))
        {
            if(this.TotalBlueprints == null) {

                this.TotalBlueprints = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalBlueprints != null && ec.Excludes("totalBlueprints",true))
        {
            this.TotalBlueprints = null;
        }
        //      C# -> System.Int32? TotalDrPlans
        // GraphQL -> totalDrPlans: Int! (scalar)
        if (ec.Includes("totalDrPlans",true))
        {
            if(this.TotalDrPlans == null) {

                this.TotalDrPlans = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalDrPlans != null && ec.Excludes("totalDrPlans",true))
        {
            this.TotalDrPlans = null;
        }
        //      C# -> System.Int32? TotalVmwareVms
        // GraphQL -> totalVmwareVms: Int! (scalar)
        if (ec.Includes("totalVmwareVms",true))
        {
            if(this.TotalVmwareVms == null) {

                this.TotalVmwareVms = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalVmwareVms != null && ec.Excludes("totalVmwareVms",true))
        {
            this.TotalVmwareVms = null;
        }
    }


    #endregion

    } // class AppflowsSummary
    
    #endregion

    public static class ListAppflowsSummaryExtensions
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
            this List<AppflowsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppflowsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppflowsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppflowsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppflowsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types