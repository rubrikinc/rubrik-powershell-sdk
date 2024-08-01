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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ReportGroupByDetail";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<DisplayableValue>? Aggregations
        // GraphQL -> aggregations: [DisplayableValue!]! (interface)
        if (this.Aggregations != null) {
                var fspec = this.Aggregations.AsFieldSpec(conf.Child("aggregations"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregations" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<DisplayableValue>? AllValues
        // GraphQL -> allValues: [DisplayableValue!]! (interface)
        if (this.AllValues != null) {
                var fspec = this.AllValues.AsFieldSpec(conf.Child("allValues"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allValues" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
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
        //      C# -> System.String? PrimaryGroupBy
        // GraphQL -> primaryGroupBy: String! (scalar)
        if (this.PrimaryGroupBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryGroupBy\n" ;
            } else {
                s += ind + "primaryGroupBy\n" ;
            }
        }
        //      C# -> System.String? SecondaryAggregation
        // GraphQL -> secondaryAggregation: String (scalar)
        if (this.SecondaryAggregation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryAggregation\n" ;
            } else {
                s += ind + "secondaryAggregation\n" ;
            }
        }
        //      C# -> System.String? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: String (scalar)
        if (this.SecondaryGroupBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryGroupBy\n" ;
            } else {
                s += ind + "secondaryGroupBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DisplayableValue>? Aggregations
        // GraphQL -> aggregations: [DisplayableValue!]! (interface)
        if (ec.Includes("aggregations",false))
        {
            if(this.Aggregations == null) {

                this.Aggregations = new List<DisplayableValue>();
                this.Aggregations.ApplyExploratoryFieldSpec(ec.NewChild("aggregations"));

            } else {

                this.Aggregations.ApplyExploratoryFieldSpec(ec.NewChild("aggregations"));

            }
        }
        else if (this.Aggregations != null && ec.Excludes("aggregations",false))
        {
            this.Aggregations = null;
        }
        //      C# -> List<DisplayableValue>? AllValues
        // GraphQL -> allValues: [DisplayableValue!]! (interface)
        if (ec.Includes("allValues",false))
        {
            if(this.AllValues == null) {

                this.AllValues = new List<DisplayableValue>();
                this.AllValues.ApplyExploratoryFieldSpec(ec.NewChild("allValues"));

            } else {

                this.AllValues.ApplyExploratoryFieldSpec(ec.NewChild("allValues"));

            }
        }
        else if (this.AllValues != null && ec.Excludes("allValues",false))
        {
            this.AllValues = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
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
        //      C# -> System.String? PrimaryGroupBy
        // GraphQL -> primaryGroupBy: String! (scalar)
        if (ec.Includes("primaryGroupBy",true))
        {
            if(this.PrimaryGroupBy == null) {

                this.PrimaryGroupBy = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryGroupBy != null && ec.Excludes("primaryGroupBy",true))
        {
            this.PrimaryGroupBy = null;
        }
        //      C# -> System.String? SecondaryAggregation
        // GraphQL -> secondaryAggregation: String (scalar)
        if (ec.Includes("secondaryAggregation",true))
        {
            if(this.SecondaryAggregation == null) {

                this.SecondaryAggregation = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryAggregation != null && ec.Excludes("secondaryAggregation",true))
        {
            this.SecondaryAggregation = null;
        }
        //      C# -> System.String? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: String (scalar)
        if (ec.Includes("secondaryGroupBy",true))
        {
            if(this.SecondaryGroupBy == null) {

                this.SecondaryGroupBy = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryGroupBy != null && ec.Excludes("secondaryGroupBy",true))
        {
            this.SecondaryGroupBy = null;
        }
    }


    #endregion

    } // class ReportGroupByDetail
    
    #endregion

    public static class ListReportGroupByDetailExtensions
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
            this List<ReportGroupByDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReportGroupByDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReportGroupByDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportGroupByDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportGroupByDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types