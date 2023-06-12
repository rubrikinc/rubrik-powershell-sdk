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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<ChartViewWithName>? Charts
        // GraphQL -> charts: [ChartViewWithName!]! (type)
        if (this.Charts != null) {
            var fspec = this.Charts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "charts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisReportSchemaConfig? Config
        // GraphQL -> config: PolarisReportSchemaConfig! (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "config {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PolarisReportFilter>? Filters
        // GraphQL -> filters: [PolarisReportFilter!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filters {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TableViewWithName>? Tables
        // GraphQL -> tables: [TableViewWithName!]! (type)
        if (this.Tables != null) {
            var fspec = this.Tables.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tables {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ChartViewWithName>? Charts
        // GraphQL -> charts: [ChartViewWithName!]! (type)
        if (this.Charts == null && Exploration.Includes(parent + ".charts"))
        {
            this.Charts = new List<ChartViewWithName>();
            this.Charts.ApplyExploratoryFieldSpec(parent + ".charts");
        }
        //      C# -> PolarisReportSchemaConfig? Config
        // GraphQL -> config: PolarisReportSchemaConfig! (type)
        if (this.Config == null && Exploration.Includes(parent + ".config"))
        {
            this.Config = new PolarisReportSchemaConfig();
            this.Config.ApplyExploratoryFieldSpec(parent + ".config");
        }
        //      C# -> List<PolarisReportFilter>? Filters
        // GraphQL -> filters: [PolarisReportFilter!]! (type)
        if (this.Filters == null && Exploration.Includes(parent + ".filters"))
        {
            this.Filters = new List<PolarisReportFilter>();
            this.Filters.ApplyExploratoryFieldSpec(parent + ".filters");
        }
        //      C# -> List<TableViewWithName>? Tables
        // GraphQL -> tables: [TableViewWithName!]! (type)
        if (this.Tables == null && Exploration.Includes(parent + ".tables"))
        {
            this.Tables = new List<TableViewWithName>();
            this.Tables.ApplyExploratoryFieldSpec(parent + ".tables");
        }
    }


    #endregion

    } // class PolarisReportSchema
    
    #endregion

    public static class ListPolarisReportSchemaExtensions
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
            this List<PolarisReportSchema> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportSchema> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportSchema());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types