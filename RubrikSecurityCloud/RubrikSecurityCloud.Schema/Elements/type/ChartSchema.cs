// ChartSchema.cs
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
    #region ChartSchema
    public class ChartSchema: BaseType
    {
        #region members

        //      C# -> List<ReportAttributeSet>? AttributeSets
        // GraphQL -> attributeSets: [ReportAttributeSet!]! (type)
        [JsonProperty("attributeSets")]
        public List<ReportAttributeSet>? AttributeSets { get; set; }

        //      C# -> List<DefaultReportChartConfig>? DefaultChartConfigs
        // GraphQL -> defaultChartConfigs: [DefaultReportChartConfig!]! (type)
        [JsonProperty("defaultChartConfigs")]
        public List<DefaultReportChartConfig>? DefaultChartConfigs { get; set; }

        //      C# -> List<InvalidAttributeMeasureSetMatch>? InvalidMatches
        // GraphQL -> invalidMatches: [InvalidAttributeMeasureSetMatch!]! (type)
        [JsonProperty("invalidMatches")]
        public List<InvalidAttributeMeasureSetMatch>? InvalidMatches { get; set; }

        //      C# -> List<ReportMeasureSet>? MeasureSets
        // GraphQL -> measureSets: [ReportMeasureSet!]! (type)
        [JsonProperty("measureSets")]
        public List<ReportMeasureSet>? MeasureSets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChartSchema";
    }

    public ChartSchema Set(
        List<ReportAttributeSet>? AttributeSets = null,
        List<DefaultReportChartConfig>? DefaultChartConfigs = null,
        List<InvalidAttributeMeasureSetMatch>? InvalidMatches = null,
        List<ReportMeasureSet>? MeasureSets = null
    ) 
    {
        if ( AttributeSets != null ) {
            this.AttributeSets = AttributeSets;
        }
        if ( DefaultChartConfigs != null ) {
            this.DefaultChartConfigs = DefaultChartConfigs;
        }
        if ( InvalidMatches != null ) {
            this.InvalidMatches = InvalidMatches;
        }
        if ( MeasureSets != null ) {
            this.MeasureSets = MeasureSets;
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
        //      C# -> List<ReportAttributeSet>? AttributeSets
        // GraphQL -> attributeSets: [ReportAttributeSet!]! (type)
        if (this.AttributeSets != null) {
            var fspec = this.AttributeSets.AsFieldSpec(conf.Child("attributeSets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "attributeSets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DefaultReportChartConfig>? DefaultChartConfigs
        // GraphQL -> defaultChartConfigs: [DefaultReportChartConfig!]! (type)
        if (this.DefaultChartConfigs != null) {
            var fspec = this.DefaultChartConfigs.AsFieldSpec(conf.Child("defaultChartConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "defaultChartConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<InvalidAttributeMeasureSetMatch>? InvalidMatches
        // GraphQL -> invalidMatches: [InvalidAttributeMeasureSetMatch!]! (type)
        if (this.InvalidMatches != null) {
            var fspec = this.InvalidMatches.AsFieldSpec(conf.Child("invalidMatches"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "invalidMatches" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReportMeasureSet>? MeasureSets
        // GraphQL -> measureSets: [ReportMeasureSet!]! (type)
        if (this.MeasureSets != null) {
            var fspec = this.MeasureSets.AsFieldSpec(conf.Child("measureSets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "measureSets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ReportAttributeSet>? AttributeSets
        // GraphQL -> attributeSets: [ReportAttributeSet!]! (type)
        if (ec.Includes("attributeSets",false))
        {
            if(this.AttributeSets == null) {

                this.AttributeSets = new List<ReportAttributeSet>();
                this.AttributeSets.ApplyExploratoryFieldSpec(ec.NewChild("attributeSets"));

            } else {

                this.AttributeSets.ApplyExploratoryFieldSpec(ec.NewChild("attributeSets"));

            }
        }
        else if (this.AttributeSets != null && ec.Excludes("attributeSets",false))
        {
            this.AttributeSets = null;
        }
        //      C# -> List<DefaultReportChartConfig>? DefaultChartConfigs
        // GraphQL -> defaultChartConfigs: [DefaultReportChartConfig!]! (type)
        if (ec.Includes("defaultChartConfigs",false))
        {
            if(this.DefaultChartConfigs == null) {

                this.DefaultChartConfigs = new List<DefaultReportChartConfig>();
                this.DefaultChartConfigs.ApplyExploratoryFieldSpec(ec.NewChild("defaultChartConfigs"));

            } else {

                this.DefaultChartConfigs.ApplyExploratoryFieldSpec(ec.NewChild("defaultChartConfigs"));

            }
        }
        else if (this.DefaultChartConfigs != null && ec.Excludes("defaultChartConfigs",false))
        {
            this.DefaultChartConfigs = null;
        }
        //      C# -> List<InvalidAttributeMeasureSetMatch>? InvalidMatches
        // GraphQL -> invalidMatches: [InvalidAttributeMeasureSetMatch!]! (type)
        if (ec.Includes("invalidMatches",false))
        {
            if(this.InvalidMatches == null) {

                this.InvalidMatches = new List<InvalidAttributeMeasureSetMatch>();
                this.InvalidMatches.ApplyExploratoryFieldSpec(ec.NewChild("invalidMatches"));

            } else {

                this.InvalidMatches.ApplyExploratoryFieldSpec(ec.NewChild("invalidMatches"));

            }
        }
        else if (this.InvalidMatches != null && ec.Excludes("invalidMatches",false))
        {
            this.InvalidMatches = null;
        }
        //      C# -> List<ReportMeasureSet>? MeasureSets
        // GraphQL -> measureSets: [ReportMeasureSet!]! (type)
        if (ec.Includes("measureSets",false))
        {
            if(this.MeasureSets == null) {

                this.MeasureSets = new List<ReportMeasureSet>();
                this.MeasureSets.ApplyExploratoryFieldSpec(ec.NewChild("measureSets"));

            } else {

                this.MeasureSets.ApplyExploratoryFieldSpec(ec.NewChild("measureSets"));

            }
        }
        else if (this.MeasureSets != null && ec.Excludes("measureSets",false))
        {
            this.MeasureSets = null;
        }
    }


    #endregion

    } // class ChartSchema
    
    #endregion

    public static class ListChartSchemaExtensions
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
            this List<ChartSchema> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChartSchema> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChartSchema> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartSchema());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChartSchema> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types