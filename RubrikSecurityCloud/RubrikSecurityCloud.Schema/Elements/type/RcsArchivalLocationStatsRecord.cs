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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        if (this.MetricName != null) {
            s += ind + "metricName\n" ;
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            s += ind + "tier\n" ;
        }
        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        if (this.MetricValue != null) {
            s += ind + "metricValue\n" ;
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RcsConsumptionMetricOutputNameType? MetricName
        // GraphQL -> metricName: RcsConsumptionMetricOutputNameType! (enum)
        if (this.MetricName == null && Exploration.Includes(parent + ".metricName", true))
        {
            this.MetricName = new RcsConsumptionMetricOutputNameType();
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier == null && Exploration.Includes(parent + ".tier", true))
        {
            this.Tier = new RcsTierEnumType();
        }
        //      C# -> System.Single? MetricValue
        // GraphQL -> metricValue: Float! (scalar)
        if (this.MetricValue == null && Exploration.Includes(parent + ".metricValue", true))
        {
            this.MetricValue = new System.Single();
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = "FETCH";
        }
    }


    #endregion

    } // class RcsArchivalLocationStatsRecord
    
    #endregion

    public static class ListRcsArchivalLocationStatsRecordExtensions
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
            this List<RcsArchivalLocationStatsRecord> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RcsArchivalLocationStatsRecord> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsArchivalLocationStatsRecord());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types