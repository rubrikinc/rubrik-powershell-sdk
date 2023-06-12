// ReportGroupByDetail.cs
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
    #region ReportGroupByDetail
    public class ReportGroupByDetail: BaseType
    {
        #region members

        //      C# -> List<DisplayableValue>? Aggregations
        // GraphQL -> aggregations: [DisplayableValue!]! (interface)
        [JsonProperty("aggregations")]
        public List<DisplayableValue>? Aggregations { get; set; }

        //      C# -> List<DisplayableValue>? AllValues
        // GraphQL -> allValues: [DisplayableValue!]! (interface)
        [JsonProperty("allValues")]
        public List<DisplayableValue>? AllValues { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryGroupBy
        // GraphQL -> primaryGroupBy: String! (scalar)
        [JsonProperty("primaryGroupBy")]
        public System.String? PrimaryGroupBy { get; set; }

        //      C# -> System.String? SecondaryAggregation
        // GraphQL -> secondaryAggregation: String (scalar)
        [JsonProperty("secondaryAggregation")]
        public System.String? SecondaryAggregation { get; set; }

        //      C# -> System.String? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: String (scalar)
        [JsonProperty("secondaryGroupBy")]
        public System.String? SecondaryGroupBy { get; set; }


        #endregion

    #region methods

    public ReportGroupByDetail Set(
        List<DisplayableValue>? Aggregations = null,
        List<DisplayableValue>? AllValues = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        System.String? PrimaryGroupBy = null,
        System.String? SecondaryAggregation = null,
        System.String? SecondaryGroupBy = null
    ) 
    {
        if ( Aggregations != null ) {
            this.Aggregations = Aggregations;
        }
        if ( AllValues != null ) {
            this.AllValues = AllValues;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryGroupBy != null ) {
            this.PrimaryGroupBy = PrimaryGroupBy;
        }
        if ( SecondaryAggregation != null ) {
            this.SecondaryAggregation = SecondaryAggregation;
        }
        if ( SecondaryGroupBy != null ) {
            this.SecondaryGroupBy = SecondaryGroupBy;
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
        //      C# -> List<DisplayableValue>? Aggregations
        // GraphQL -> aggregations: [DisplayableValue!]! (interface)
        if (this.Aggregations != null) {
                var fspec = this.Aggregations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "aggregations {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<DisplayableValue>? AllValues
        // GraphQL -> allValues: [DisplayableValue!]! (interface)
        if (this.AllValues != null) {
                var fspec = this.AllValues.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allValues {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            s += ind + "displayName\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PrimaryGroupBy
        // GraphQL -> primaryGroupBy: String! (scalar)
        if (this.PrimaryGroupBy != null) {
            s += ind + "primaryGroupBy\n" ;
        }
        //      C# -> System.String? SecondaryAggregation
        // GraphQL -> secondaryAggregation: String (scalar)
        if (this.SecondaryAggregation != null) {
            s += ind + "secondaryAggregation\n" ;
        }
        //      C# -> System.String? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: String (scalar)
        if (this.SecondaryGroupBy != null) {
            s += ind + "secondaryGroupBy\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DisplayableValue>? Aggregations
        // GraphQL -> aggregations: [DisplayableValue!]! (interface)
        if (this.Aggregations == null && Exploration.Includes(parent + ".aggregations"))
        {
            this.Aggregations = new List<DisplayableValue>();
            this.Aggregations.ApplyExploratoryFieldSpec(parent + ".aggregations");
        }
        //      C# -> List<DisplayableValue>? AllValues
        // GraphQL -> allValues: [DisplayableValue!]! (interface)
        if (this.AllValues == null && Exploration.Includes(parent + ".allValues"))
        {
            this.AllValues = new List<DisplayableValue>();
            this.AllValues.ApplyExploratoryFieldSpec(parent + ".allValues");
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && Exploration.Includes(parent + ".displayName", true))
        {
            this.DisplayName = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PrimaryGroupBy
        // GraphQL -> primaryGroupBy: String! (scalar)
        if (this.PrimaryGroupBy == null && Exploration.Includes(parent + ".primaryGroupBy", true))
        {
            this.PrimaryGroupBy = "FETCH";
        }
        //      C# -> System.String? SecondaryAggregation
        // GraphQL -> secondaryAggregation: String (scalar)
        if (this.SecondaryAggregation == null && Exploration.Includes(parent + ".secondaryAggregation", true))
        {
            this.SecondaryAggregation = "FETCH";
        }
        //      C# -> System.String? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: String (scalar)
        if (this.SecondaryGroupBy == null && Exploration.Includes(parent + ".secondaryGroupBy", true))
        {
            this.SecondaryGroupBy = "FETCH";
        }
    }


    #endregion

    } // class ReportGroupByDetail
    
    #endregion

    public static class ListReportGroupByDetailExtensions
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
            this List<ReportGroupByDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportGroupByDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportGroupByDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types