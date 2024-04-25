// DhrcScore.cs
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
    #region DhrcScore
    public class DhrcScore: BaseType
    {
        #region members

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        [JsonProperty("calculatedAt")]
        public DateTime? CalculatedAt { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        [JsonProperty("earliestMetric")]
        public DateTime? EarliestMetric { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }

        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        [JsonProperty("context")]
        public DhrcScoreContext? Context { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DhrcScore";
    }

    public DhrcScore Set(
        DhrcCategory? Category = null,
        DateTime? CalculatedAt = null,
        DateTime? Date = null,
        DateTime? EarliestMetric = null,
        System.Single? Value = null,
        DhrcScoreContext? Context = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( CalculatedAt != null ) {
            this.CalculatedAt = CalculatedAt;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( EarliestMetric != null ) {
            this.EarliestMetric = EarliestMetric;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Context != null ) {
            this.Context = Context;
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
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        if (this.CalculatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "calculatedAt\n" ;
            } else {
                s += ind + "calculatedAt\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestMetric\n" ;
            } else {
                s += ind + "earliestMetric\n" ;
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
        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        if (this.Context != null) {
            var fspec = this.Context.AsFieldSpec(conf.Child("context"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "context" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new DhrcCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        if (ec.Includes("calculatedAt",true))
        {
            if(this.CalculatedAt == null) {

                this.CalculatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CalculatedAt != null && ec.Excludes("calculatedAt",true))
        {
            this.CalculatedAt = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (ec.Includes("earliestMetric",true))
        {
            if(this.EarliestMetric == null) {

                this.EarliestMetric = new DateTime();

            } else {


            }
        }
        else if (this.EarliestMetric != null && ec.Excludes("earliestMetric",true))
        {
            this.EarliestMetric = null;
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
        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        if (ec.Includes("context",false))
        {
            if(this.Context == null) {

                this.Context = new DhrcScoreContext();
                this.Context.ApplyExploratoryFieldSpec(ec.NewChild("context"));

            } else {

                this.Context.ApplyExploratoryFieldSpec(ec.NewChild("context"));

            }
        }
        else if (this.Context != null && ec.Excludes("context",false))
        {
            this.Context = null;
        }
    }


    #endregion

    } // class DhrcScore
    
    #endregion

    public static class ListDhrcScoreExtensions
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
            this List<DhrcScore> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DhrcScore> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScore> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScore());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DhrcScore> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types