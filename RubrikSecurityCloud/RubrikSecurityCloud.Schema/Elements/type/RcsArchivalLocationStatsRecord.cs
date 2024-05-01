// RcsArchivalLocationStatsRecord.cs
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
    #region RcsArchivalLocationStatsRecord
    public class RcsArchivalLocationStatsRecord: BaseType
    {
        #region members

        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        [JsonProperty("metricName")]
        public RcsConsumptionMetricOutputNameType? MetricName { get; set; }

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }

        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        [JsonProperty("metricValue")]
        public System.Single? MetricValue { get; set; }

        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        [JsonProperty("timestamp")]
        public System.String? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcsArchivalLocationStatsRecord";
    }

    public RcsArchivalLocationStatsRecord Set(
        RcsConsumptionMetricOutputNameType? MetricName = null,
        RcsTierEnumType? Tier = null,
        System.Single? MetricValue = null,
        System.String? Timestamp = null
    ) 
    {
        if ( MetricName != null ) {
            this.MetricName = MetricName;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( MetricValue != null ) {
            this.MetricValue = MetricValue;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        if (this.MetricName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metricName\n" ;
            } else {
                s += ind + "metricName\n" ;
            }
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        if (this.MetricValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metricValue\n" ;
            } else {
                s += ind + "metricValue\n" ;
            }
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        if (ec.Includes("metricName",true))
        {
            if(this.MetricName == null) {

                this.MetricName = new RcsConsumptionMetricOutputNameType();

            } else {


            }
        }
        else if (this.MetricName != null && ec.Excludes("metricName",true))
        {
            this.MetricName = null;
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcsTierEnumType();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        if (ec.Includes("metricValue",true))
        {
            if(this.MetricValue == null) {

                this.MetricValue = new System.Single();

            } else {


            }
        }
        else if (this.MetricValue != null && ec.Excludes("metricValue",true))
        {
            this.MetricValue = null;
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = "FETCH";

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
    }


    #endregion

    } // class RcsArchivalLocationStatsRecord
    
    #endregion

    public static class ListRcsArchivalLocationStatsRecordExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RcsArchivalLocationStatsRecord> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcsArchivalLocationStatsRecord> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcsArchivalLocationStatsRecord> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsArchivalLocationStatsRecord());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcsArchivalLocationStatsRecord> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types