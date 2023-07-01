// DhrcCollectedMetric.cs
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
    #region DhrcCollectedMetric
    public class DhrcCollectedMetric: BaseType
    {
        #region members

        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        [JsonProperty("metric")]
        public DhrcMetric? Metric { get; set; }

        //      C# -> DateTime? CollectedAt
        // GraphQL -> collectedAt: DateTime (scalar)
        [JsonProperty("collectedAt")]
        public DateTime? CollectedAt { get; set; }

        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        [JsonProperty("maxValue")]
        public System.Single? MaxValue { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DhrcCollectedMetric";
    }

    public DhrcCollectedMetric Set(
        DhrcMetric? Metric = null,
        DateTime? CollectedAt = null,
        System.Single? MaxValue = null,
        System.Single? Value = null
    ) 
    {
        if ( Metric != null ) {
            this.Metric = Metric;
        }
        if ( CollectedAt != null ) {
            this.CollectedAt = CollectedAt;
        }
        if ( MaxValue != null ) {
            this.MaxValue = MaxValue;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> DateTime? CollectedAt
        // GraphQL -> collectedAt: DateTime (scalar)
        if (this.CollectedAt != null) {
            s += ind + "collectedAt\n" ;
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
        //      C# -> DateTime? CollectedAt
        // GraphQL -> collectedAt: DateTime (scalar)
        if (this.CollectedAt == null && Exploration.Includes(parent + ".collectedAt", true))
        {
            this.CollectedAt = new DateTime();
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
    }


    #endregion

    } // class DhrcCollectedMetric
    
    #endregion

    public static class ListDhrcCollectedMetricExtensions
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
            this List<DhrcCollectedMetric> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DhrcCollectedMetric> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcCollectedMetric());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types