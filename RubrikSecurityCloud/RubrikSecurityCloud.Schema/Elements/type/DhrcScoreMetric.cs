// DhrcScoreMetric.cs
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
    #region DhrcScoreMetric
    public class DhrcScoreMetric: BaseType
    {
        #region members

        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        [JsonProperty("metric")]
        public DhrcMetric? Metric { get; set; }

        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        [JsonProperty("impact")]
        public System.Single? Impact { get; set; }

        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        [JsonProperty("maxValue")]
        public System.Single? MaxValue { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        [JsonProperty("weight")]
        public System.Single? Weight { get; set; }


        #endregion

    #region methods

    public DhrcScoreMetric Set(
        DhrcMetric? Metric = null,
        System.Single? Impact = null,
        System.Single? MaxValue = null,
        System.Single? Value = null,
        System.Int32? Version = null,
        System.Single? Weight = null
    ) 
    {
        if ( Metric != null ) {
            this.Metric = Metric;
        }
        if ( Impact != null ) {
            this.Impact = Impact;
        }
        if ( MaxValue != null ) {
            this.MaxValue = MaxValue;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
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
        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        if (this.Metric != null) {
            s += ind + "metric\n" ;
        }
        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        if (this.Impact != null) {
            s += ind + "impact\n" ;
        }
        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        if (this.MaxValue != null) {
            s += ind + "maxValue\n" ;
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight != null) {
            s += ind + "weight\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        if (this.Metric == null && Exploration.Includes(parent + ".metric", true))
        {
            this.Metric = new DhrcMetric();
        }
        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        if (this.Impact == null && Exploration.Includes(parent + ".impact", true))
        {
            this.Impact = new System.Single();
        }
        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        if (this.MaxValue == null && Exploration.Includes(parent + ".maxValue", true))
        {
            this.MaxValue = new System.Single();
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = new System.Single();
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = Int32.MinValue;
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight == null && Exploration.Includes(parent + ".weight", true))
        {
            this.Weight = new System.Single();
        }
    }


    #endregion

    } // class DhrcScoreMetric
    
    #endregion

    public static class ListDhrcScoreMetricExtensions
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
            this List<DhrcScoreMetric> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScoreMetric> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScoreMetric());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types