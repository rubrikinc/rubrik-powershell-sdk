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

    public override string GetGqlTypeName() {
        return "DhrcScoreMetric";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        if (this.Metric != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metric\n" ;
            } else {
                s += ind + "metric\n" ;
            }
        }
        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        if (this.Impact != null) {
            if (conf.Flat) {
                s += conf.Prefix + "impact\n" ;
            } else {
                s += ind + "impact\n" ;
            }
        }
        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        if (this.MaxValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxValue\n" ;
            } else {
                s += ind + "maxValue\n" ;
            }
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weight\n" ;
            } else {
                s += ind + "weight\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DhrcMetric? Metric
        // GraphQL -> metric: DhrcMetric! (enum)
        if (ec.Includes("metric",true))
        {
            if(this.Metric == null) {

                this.Metric = new DhrcMetric();

            } else {


            }
        }
        else if (this.Metric != null && ec.Excludes("metric",true))
        {
            this.Metric = null;
        }
        //      C# -> System.Single? Impact
        // GraphQL -> impact: Float! (scalar)
        if (ec.Includes("impact",true))
        {
            if(this.Impact == null) {

                this.Impact = new System.Single();

            } else {


            }
        }
        else if (this.Impact != null && ec.Excludes("impact",true))
        {
            this.Impact = null;
        }
        //      C# -> System.Single? MaxValue
        // GraphQL -> maxValue: Float! (scalar)
        if (ec.Includes("maxValue",true))
        {
            if(this.MaxValue == null) {

                this.MaxValue = new System.Single();

            } else {


            }
        }
        else if (this.MaxValue != null && ec.Excludes("maxValue",true))
        {
            this.MaxValue = null;
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = new System.Single();

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = Int32.MinValue;

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (ec.Includes("weight",true))
        {
            if(this.Weight == null) {

                this.Weight = new System.Single();

            } else {


            }
        }
        else if (this.Weight != null && ec.Excludes("weight",true))
        {
            this.Weight = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DhrcScoreMetric> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScoreMetric> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScoreMetric());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DhrcScoreMetric> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types