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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType != null) {
            s += ind + "chartType\n" ;
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            s += ind + "aggregations\n" ;
        }
        //      C# -> System.String? ChartViewId
        // GraphQL -> chartViewId: String! (scalar)
        if (this.ChartViewId != null) {
            s += ind + "chartViewId\n" ;
        }
        //      C# -> System.Boolean? DefaultChart
        // GraphQL -> defaultChart: Boolean! (scalar)
        if (this.DefaultChart != null) {
            s += ind + "defaultChart\n" ;
        }
        //      C# -> List<System.String>? GroupBys
        // GraphQL -> groupBys: [String!]! (scalar)
        if (this.GroupBys != null) {
            s += ind + "groupBys\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType == null && ec.Includes("chartType",true))
        {
            this.ChartType = new ChartType();
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations == null && ec.Includes("aggregations",true))
        {
            this.Aggregations = new List<System.String>();
        }
        //      C# -> System.String? ChartViewId
        // GraphQL -> chartViewId: String! (scalar)
        if (this.ChartViewId == null && ec.Includes("chartViewId",true))
        {
            this.ChartViewId = "FETCH";
        }
        //      C# -> System.Boolean? DefaultChart
        // GraphQL -> defaultChart: Boolean! (scalar)
        if (this.DefaultChart == null && ec.Includes("defaultChart",true))
        {
            this.DefaultChart = true;
        }
        //      C# -> List<System.String>? GroupBys
        // GraphQL -> groupBys: [String!]! (scalar)
        if (this.GroupBys == null && ec.Includes("groupBys",true))
        {
            this.GroupBys = new List<System.String>();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class ChartConfig
    
    #endregion

    public static class ListChartConfigExtensions
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
            this List<ChartConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ChartConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types