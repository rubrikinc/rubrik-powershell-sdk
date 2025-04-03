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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> DateTime? CollectedAt
        // GraphQL -> collectedAt: DateTime (scalar)
        if (this.CollectedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "collectedAt\n" ;
            } else {
                s += ind + "collectedAt\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> DateTime? CollectedAt
        // GraphQL -> collectedAt: DateTime (scalar)
        if (ec.Includes("collectedAt",true))
        {
            if(this.CollectedAt == null) {

                this.CollectedAt = new DateTime();

            } else {


            }
        }
        else if (this.CollectedAt != null && ec.Excludes("collectedAt",true))
        {
            this.CollectedAt = null;
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
    }


    #endregion

    } // class DhrcCollectedMetric
    
    #endregion

    public static class ListDhrcCollectedMetricExtensions
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
            this List<DhrcCollectedMetric> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DhrcCollectedMetric> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DhrcCollectedMetric> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcCollectedMetric());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DhrcCollectedMetric> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types