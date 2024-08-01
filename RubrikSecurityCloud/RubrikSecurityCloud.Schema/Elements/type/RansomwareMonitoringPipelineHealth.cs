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

        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringHashIocStatus
        // GraphQL -> threatMonitoringHashIocStatus: [ThreatFeedScanStatus!]! (type)
        [JsonProperty("threatMonitoringHashIocStatus")]
        public List<ThreatFeedScanStatus>? ThreatMonitoringHashIocStatus { get; set; }

        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringYaraIocStatus
        // GraphQL -> threatMonitoringYaraIocStatus: [ThreatFeedScanStatus!]! (type)
        [JsonProperty("threatMonitoringYaraIocStatus")]
        public List<ThreatFeedScanStatus>? ThreatMonitoringYaraIocStatus { get; set; }


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
        System.Int64? ThreatsFound = null,
        List<ThreatFeedScanStatus>? ThreatMonitoringHashIocStatus = null,
        List<ThreatFeedScanStatus>? ThreatMonitoringYaraIocStatus = null
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
        if ( ThreatMonitoringHashIocStatus != null ) {
            this.ThreatMonitoringHashIocStatus = ThreatMonitoringHashIocStatus;
        }
        if ( ThreatMonitoringYaraIocStatus != null ) {
            this.ThreatMonitoringYaraIocStatus = ThreatMonitoringYaraIocStatus;
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
        //      C# -> System.Int64? ActiveHunts
        // GraphQL -> activeHunts: Long! (scalar)
        if (this.ActiveHunts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeHunts\n" ;
            } else {
                s += ind + "activeHunts\n" ;
            }
        }
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomaliesFound\n" ;
            } else {
                s += ind + "anomaliesFound\n" ;
            }
        }
        //      C# -> System.Int64? FailedBackups
        // GraphQL -> failedBackups: Long! (scalar)
        if (this.FailedBackups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedBackups\n" ;
            } else {
                s += ind + "failedBackups\n" ;
            }
        }
        //      C# -> System.Int64? MatchedHunts
        // GraphQL -> matchedHunts: Long! (scalar)
        if (this.MatchedHunts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedHunts\n" ;
            } else {
                s += ind + "matchedHunts\n" ;
            }
        }
        //      C# -> System.Int64? SuccessfulBackups
        // GraphQL -> successfulBackups: Long! (scalar)
        if (this.SuccessfulBackups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successfulBackups\n" ;
            } else {
                s += ind + "successfulBackups\n" ;
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
        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringHashIocStatus
        // GraphQL -> threatMonitoringHashIocStatus: [ThreatFeedScanStatus!]! (type)
        if (this.ThreatMonitoringHashIocStatus != null) {
            var fspec = this.ThreatMonitoringHashIocStatus.AsFieldSpec(conf.Child("threatMonitoringHashIocStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "threatMonitoringHashIocStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringYaraIocStatus
        // GraphQL -> threatMonitoringYaraIocStatus: [ThreatFeedScanStatus!]! (type)
        if (this.ThreatMonitoringYaraIocStatus != null) {
            var fspec = this.ThreatMonitoringYaraIocStatus.AsFieldSpec(conf.Child("threatMonitoringYaraIocStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "threatMonitoringYaraIocStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ActiveHunts
        // GraphQL -> activeHunts: Long! (scalar)
        if (ec.Includes("activeHunts",true))
        {
            if(this.ActiveHunts == null) {

                this.ActiveHunts = new System.Int64();

            } else {


            }
        }
        else if (this.ActiveHunts != null && ec.Excludes("activeHunts",true))
        {
            this.ActiveHunts = null;
        }
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
        //      C# -> System.Int64? FailedBackups
        // GraphQL -> failedBackups: Long! (scalar)
        if (ec.Includes("failedBackups",true))
        {
            if(this.FailedBackups == null) {

                this.FailedBackups = new System.Int64();

            } else {


            }
        }
        else if (this.FailedBackups != null && ec.Excludes("failedBackups",true))
        {
            this.FailedBackups = null;
        }
        //      C# -> System.Int64? MatchedHunts
        // GraphQL -> matchedHunts: Long! (scalar)
        if (ec.Includes("matchedHunts",true))
        {
            if(this.MatchedHunts == null) {

                this.MatchedHunts = new System.Int64();

            } else {


            }
        }
        else if (this.MatchedHunts != null && ec.Excludes("matchedHunts",true))
        {
            this.MatchedHunts = null;
        }
        //      C# -> System.Int64? SuccessfulBackups
        // GraphQL -> successfulBackups: Long! (scalar)
        if (ec.Includes("successfulBackups",true))
        {
            if(this.SuccessfulBackups == null) {

                this.SuccessfulBackups = new System.Int64();

            } else {


            }
        }
        else if (this.SuccessfulBackups != null && ec.Excludes("successfulBackups",true))
        {
            this.SuccessfulBackups = null;
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
        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringHashIocStatus
        // GraphQL -> threatMonitoringHashIocStatus: [ThreatFeedScanStatus!]! (type)
        if (ec.Includes("threatMonitoringHashIocStatus",false))
        {
            if(this.ThreatMonitoringHashIocStatus == null) {

                this.ThreatMonitoringHashIocStatus = new List<ThreatFeedScanStatus>();
                this.ThreatMonitoringHashIocStatus.ApplyExploratoryFieldSpec(ec.NewChild("threatMonitoringHashIocStatus"));

            } else {

                this.ThreatMonitoringHashIocStatus.ApplyExploratoryFieldSpec(ec.NewChild("threatMonitoringHashIocStatus"));

            }
        }
        else if (this.ThreatMonitoringHashIocStatus != null && ec.Excludes("threatMonitoringHashIocStatus",false))
        {
            this.ThreatMonitoringHashIocStatus = null;
        }
        //      C# -> List<ThreatFeedScanStatus>? ThreatMonitoringYaraIocStatus
        // GraphQL -> threatMonitoringYaraIocStatus: [ThreatFeedScanStatus!]! (type)
        if (ec.Includes("threatMonitoringYaraIocStatus",false))
        {
            if(this.ThreatMonitoringYaraIocStatus == null) {

                this.ThreatMonitoringYaraIocStatus = new List<ThreatFeedScanStatus>();
                this.ThreatMonitoringYaraIocStatus.ApplyExploratoryFieldSpec(ec.NewChild("threatMonitoringYaraIocStatus"));

            } else {

                this.ThreatMonitoringYaraIocStatus.ApplyExploratoryFieldSpec(ec.NewChild("threatMonitoringYaraIocStatus"));

            }
        }
        else if (this.ThreatMonitoringYaraIocStatus != null && ec.Excludes("threatMonitoringYaraIocStatus",false))
        {
            this.ThreatMonitoringYaraIocStatus = null;
        }
    }


    #endregion

    } // class RansomwareMonitoringPipelineHealth
    
    #endregion

    public static class ListRansomwareMonitoringPipelineHealthExtensions
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
            this List<RansomwareMonitoringPipelineHealth> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RansomwareMonitoringPipelineHealth> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<RansomwareMonitoringPipelineHealth> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types