// DailyTimelineDetails.cs
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
    #region DailyTimelineDetails
    public class DailyTimelineDetails: BaseType
    {
        #region members

        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        [JsonProperty("anomaliesFound")]
        public System.Int64? AnomaliesFound { get; set; }

        //      C# -> System.Int64? AnomalyDetectionScannedObjects
        // GraphQL -> anomalyDetectionScannedObjects: Long! (scalar)
        [JsonProperty("anomalyDetectionScannedObjects")]
        public System.Int64? AnomalyDetectionScannedObjects { get; set; }

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> System.Int64? ThreatMonitoringScannedObjects
        // GraphQL -> threatMonitoringScannedObjects: Long! (scalar)
        [JsonProperty("threatMonitoringScannedObjects")]
        public System.Int64? ThreatMonitoringScannedObjects { get; set; }

        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        [JsonProperty("threatsFound")]
        public System.Int64? ThreatsFound { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DailyTimelineDetails";
    }

    public DailyTimelineDetails Set(
        System.Int64? AnomaliesFound = null,
        System.Int64? AnomalyDetectionScannedObjects = null,
        System.String? Day = null,
        System.Int64? ThreatMonitoringScannedObjects = null,
        System.Int64? ThreatsFound = null
    ) 
    {
        if ( AnomaliesFound != null ) {
            this.AnomaliesFound = AnomaliesFound;
        }
        if ( AnomalyDetectionScannedObjects != null ) {
            this.AnomalyDetectionScannedObjects = AnomalyDetectionScannedObjects;
        }
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( ThreatMonitoringScannedObjects != null ) {
            this.ThreatMonitoringScannedObjects = ThreatMonitoringScannedObjects;
        }
        if ( ThreatsFound != null ) {
            this.ThreatsFound = ThreatsFound;
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
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomaliesFound\n" ;
            } else {
                s += ind + "anomaliesFound\n" ;
            }
        }
        //      C# -> System.Int64? AnomalyDetectionScannedObjects
        // GraphQL -> anomalyDetectionScannedObjects: Long! (scalar)
        if (this.AnomalyDetectionScannedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyDetectionScannedObjects\n" ;
            } else {
                s += ind + "anomalyDetectionScannedObjects\n" ;
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
        //      C# -> System.Int64? ThreatMonitoringScannedObjects
        // GraphQL -> threatMonitoringScannedObjects: Long! (scalar)
        if (this.ThreatMonitoringScannedObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatMonitoringScannedObjects\n" ;
            } else {
                s += ind + "threatMonitoringScannedObjects\n" ;
            }
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (this.ThreatsFound != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatsFound\n" ;
            } else {
                s += ind + "threatsFound\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (ec.Includes("anomaliesFound",true))
        {
            if(this.AnomaliesFound == null) {

                this.AnomaliesFound = new System.Int64();

            } else {


            }
        }
        else if (this.AnomaliesFound != null && ec.Excludes("anomaliesFound",true))
        {
            this.AnomaliesFound = null;
        }
        //      C# -> System.Int64? AnomalyDetectionScannedObjects
        // GraphQL -> anomalyDetectionScannedObjects: Long! (scalar)
        if (ec.Includes("anomalyDetectionScannedObjects",true))
        {
            if(this.AnomalyDetectionScannedObjects == null) {

                this.AnomalyDetectionScannedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.AnomalyDetectionScannedObjects != null && ec.Excludes("anomalyDetectionScannedObjects",true))
        {
            this.AnomalyDetectionScannedObjects = null;
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
        //      C# -> System.Int64? ThreatMonitoringScannedObjects
        // GraphQL -> threatMonitoringScannedObjects: Long! (scalar)
        if (ec.Includes("threatMonitoringScannedObjects",true))
        {
            if(this.ThreatMonitoringScannedObjects == null) {

                this.ThreatMonitoringScannedObjects = new System.Int64();

            } else {


            }
        }
        else if (this.ThreatMonitoringScannedObjects != null && ec.Excludes("threatMonitoringScannedObjects",true))
        {
            this.ThreatMonitoringScannedObjects = null;
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (ec.Includes("threatsFound",true))
        {
            if(this.ThreatsFound == null) {

                this.ThreatsFound = new System.Int64();

            } else {


            }
        }
        else if (this.ThreatsFound != null && ec.Excludes("threatsFound",true))
        {
            this.ThreatsFound = null;
        }
    }


    #endregion

    } // class DailyTimelineDetails
    
    #endregion

    public static class ListDailyTimelineDetailsExtensions
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
            this List<DailyTimelineDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DailyTimelineDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DailyTimelineDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyTimelineDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DailyTimelineDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types