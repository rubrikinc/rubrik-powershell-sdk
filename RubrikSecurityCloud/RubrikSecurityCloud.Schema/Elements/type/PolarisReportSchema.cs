// PolarisReportSchema.cs
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
    #region PolarisReportSchema
    public class PolarisReportSchema: BaseType
    {
        #region members

        //      C# -> List<ChartViewWithName>? Charts
        // GraphQL -> charts: [ChartViewWithName!]! (type)
        [JsonProperty("charts")]
        public List<ChartViewWithName>? Charts { get; set; }

        //      C# -> PolarisReportSchemaConfig? Config
        // GraphQL -> config: PolarisReportSchemaConfig! (type)
        [JsonProperty("config")]
        public PolarisReportSchemaConfig? Config { get; set; }

        //      C# -> List<PolarisReportFilter>? Filters
        // GraphQL -> filters: [PolarisReportFilter!]! (type)
        [JsonProperty("filters")]
        public List<PolarisReportFilter>? Filters { get; set; }

        //      C# -> List<TableViewWithName>? Tables
        // GraphQL -> tables: [TableViewWithName!]! (type)
        [JsonProperty("tables")]
        public List<TableViewWithName>? Tables { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportSchema";
    }

    public PolarisReportSchema Set(
        List<ChartViewWithName>? Charts = null,
        PolarisReportSchemaConfig? Config = null,
        List<PolarisReportFilter>? Filters = null,
        List<TableViewWithName>? Tables = null
    ) 
    {
        if ( Charts != null ) {
            this.Charts = Charts;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( Tables != null ) {
            this.Tables = Tables;
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
        //      C# -> List<ChartViewWithName>? Charts
        // GraphQL -> charts: [ChartViewWithName!]! (type)
        if (this.Charts != null) {
            var fspec = this.Charts.AsFieldSpec(conf.Child("charts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "charts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisReportSchemaConfig? Config
        // GraphQL -> config: PolarisReportSchemaConfig! (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PolarisReportFilter>? Filters
        // GraphQL -> filters: [PolarisReportFilter!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(conf.Child("filters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TableViewWithName>? Tables
        // GraphQL -> tables: [TableViewWithName!]! (type)
        if (this.Tables != null) {
            var fspec = this.Tables.AsFieldSpec(conf.Child("tables"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tables" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ChartViewWithName>? Charts
        // GraphQL -> charts: [ChartViewWithName!]! (type)
        if (ec.Includes("charts",false))
        {
            if(this.Charts == null) {

                this.Charts = new List<ChartViewWithName>();
                this.Charts.ApplyExploratoryFieldSpec(ec.NewChild("charts"));

            } else {

                this.Charts.ApplyExploratoryFieldSpec(ec.NewChild("charts"));

            }
        }
        else if (this.Charts != null && ec.Excludes("charts",false))
        {
            this.Charts = null;
        }
        //      C# -> PolarisReportSchemaConfig? Config
        // GraphQL -> config: PolarisReportSchemaConfig! (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new PolarisReportSchemaConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
        //      C# -> List<PolarisReportFilter>? Filters
        // GraphQL -> filters: [PolarisReportFilter!]! (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new List<PolarisReportFilter>();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
        //      C# -> List<TableViewWithName>? Tables
        // GraphQL -> tables: [TableViewWithName!]! (type)
        if (ec.Includes("tables",false))
        {
            if(this.Tables == null) {

                this.Tables = new List<TableViewWithName>();
                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            } else {

                this.Tables.ApplyExploratoryFieldSpec(ec.NewChild("tables"));

            }
        }
        else if (this.Tables != null && ec.Excludes("tables",false))
        {
            this.Tables = null;
        }
    }


    #endregion

    } // class PolarisReportSchema
    
    #endregion

    public static class ListPolarisReportSchemaExtensions
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
            this List<PolarisReportSchema> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportSchema> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportSchema> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportSchema());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportSchema> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types