// ChartConfig.cs
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
    #region ChartConfig
    public class ChartConfig: BaseType
    {
        #region members

        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        [JsonProperty("chartType")]
        public ChartType? ChartType { get; set; }

        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        [JsonProperty("aggregations")]
        public List<System.String>? Aggregations { get; set; }

        //      C# -> System.String? ChartViewId
        // GraphQL -> chartViewId: String! (scalar)
        [JsonProperty("chartViewId")]
        public System.String? ChartViewId { get; set; }

        //      C# -> System.Boolean? DefaultChart
        // GraphQL -> defaultChart: Boolean! (scalar)
        [JsonProperty("defaultChart")]
        public System.Boolean? DefaultChart { get; set; }

        //      C# -> List<System.String>? GroupBys
        // GraphQL -> groupBys: [String!]! (scalar)
        [JsonProperty("groupBys")]
        public List<System.String>? GroupBys { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChartConfig";
    }

    public ChartConfig Set(
        ChartType? ChartType = null,
        List<System.String>? Aggregations = null,
        System.String? ChartViewId = null,
        System.Boolean? DefaultChart = null,
        List<System.String>? GroupBys = null,
        System.String? Name = null
    ) 
    {
        if ( ChartType != null ) {
            this.ChartType = ChartType;
        }
        if ( Aggregations != null ) {
            this.Aggregations = Aggregations;
        }
        if ( ChartViewId != null ) {
            this.ChartViewId = ChartViewId;
        }
        if ( DefaultChart != null ) {
            this.DefaultChart = DefaultChart;
        }
        if ( GroupBys != null ) {
            this.GroupBys = GroupBys;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartType\n" ;
            } else {
                s += ind + "chartType\n" ;
            }
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregations\n" ;
            } else {
                s += ind + "aggregations\n" ;
            }
        }
        //      C# -> System.String? ChartViewId
        // GraphQL -> chartViewId: String! (scalar)
        if (this.ChartViewId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartViewId\n" ;
            } else {
                s += ind + "chartViewId\n" ;
            }
        }
        //      C# -> System.Boolean? DefaultChart
        // GraphQL -> defaultChart: Boolean! (scalar)
        if (this.DefaultChart != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultChart\n" ;
            } else {
                s += ind + "defaultChart\n" ;
            }
        }
        //      C# -> List<System.String>? GroupBys
        // GraphQL -> groupBys: [String!]! (scalar)
        if (this.GroupBys != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupBys\n" ;
            } else {
                s += ind + "groupBys\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (ec.Includes("chartType",true))
        {
            if(this.ChartType == null) {

                this.ChartType = new ChartType();

            } else {


            }
        }
        else if (this.ChartType != null && ec.Excludes("chartType",true))
        {
            this.ChartType = null;
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (ec.Includes("aggregations",true))
        {
            if(this.Aggregations == null) {

                this.Aggregations = new List<System.String>();

            } else {


            }
        }
        else if (this.Aggregations != null && ec.Excludes("aggregations",true))
        {
            this.Aggregations = null;
        }
        //      C# -> System.String? ChartViewId
        // GraphQL -> chartViewId: String! (scalar)
        if (ec.Includes("chartViewId",true))
        {
            if(this.ChartViewId == null) {

                this.ChartViewId = "FETCH";

            } else {


            }
        }
        else if (this.ChartViewId != null && ec.Excludes("chartViewId",true))
        {
            this.ChartViewId = null;
        }
        //      C# -> System.Boolean? DefaultChart
        // GraphQL -> defaultChart: Boolean! (scalar)
        if (ec.Includes("defaultChart",true))
        {
            if(this.DefaultChart == null) {

                this.DefaultChart = true;

            } else {


            }
        }
        else if (this.DefaultChart != null && ec.Excludes("defaultChart",true))
        {
            this.DefaultChart = null;
        }
        //      C# -> List<System.String>? GroupBys
        // GraphQL -> groupBys: [String!]! (scalar)
        if (ec.Includes("groupBys",true))
        {
            if(this.GroupBys == null) {

                this.GroupBys = new List<System.String>();

            } else {


            }
        }
        else if (this.GroupBys != null && ec.Excludes("groupBys",true))
        {
            this.GroupBys = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class ChartConfig
    
    #endregion

    public static class ListChartConfigExtensions
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
            this List<ChartConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChartConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChartConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChartConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types