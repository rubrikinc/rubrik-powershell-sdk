// PolarisReportFilter.cs
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
    #region PolarisReportFilter
    public class PolarisReportFilter: BaseType
    {
        #region members

        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        [JsonProperty("dataType")]
        public DataTypeEnum? DataType { get; set; }

        //      C# -> FilterTypeEnum? FilterType
        // GraphQL -> filterType: FilterTypeEnum! (enum)
        [JsonProperty("filterType")]
        public FilterTypeEnum? FilterType { get; set; }

        //      C# -> List<Value>? DefaultValues
        // GraphQL -> defaultValues: [Value!]! (interface)
        [JsonProperty("defaultValues")]
        public List<Value>? DefaultValues { get; set; }

        //      C# -> List<DisplayableValue>? Values
        // GraphQL -> values: [DisplayableValue!]! (interface)
        [JsonProperty("values")]
        public List<DisplayableValue>? Values { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<PolarisReportFilterConfigs>? Configs
        // GraphQL -> configs: [PolarisReportFilterConfigs!]! (type)
        [JsonProperty("configs")]
        public List<PolarisReportFilterConfigs>? Configs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportFilter";
    }

    public PolarisReportFilter Set(
        DataTypeEnum? DataType = null,
        FilterTypeEnum? FilterType = null,
        List<Value>? DefaultValues = null,
        List<DisplayableValue>? Values = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        List<PolarisReportFilterConfigs>? Configs = null
    ) 
    {
        if ( DataType != null ) {
            this.DataType = DataType;
        }
        if ( FilterType != null ) {
            this.FilterType = FilterType;
        }
        if ( DefaultValues != null ) {
            this.DefaultValues = DefaultValues;
        }
        if ( Values != null ) {
            this.Values = Values;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Configs != null ) {
            this.Configs = Configs;
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
        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        if (this.DataType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataType\n" ;
            } else {
                s += ind + "dataType\n" ;
            }
        }
        //      C# -> FilterTypeEnum? FilterType
        // GraphQL -> filterType: FilterTypeEnum! (enum)
        if (this.FilterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterType\n" ;
            } else {
                s += ind + "filterType\n" ;
            }
        }
        //      C# -> List<Value>? DefaultValues
        // GraphQL -> defaultValues: [Value!]! (interface)
        if (this.DefaultValues != null) {
                var fspec = this.DefaultValues.AsFieldSpec(conf.Child("defaultValues"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "defaultValues" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<DisplayableValue>? Values
        // GraphQL -> values: [DisplayableValue!]! (interface)
        if (this.Values != null) {
                var fspec = this.Values.AsFieldSpec(conf.Child("values"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "values" + " " + "{\n" + fspec + ind + "}\n";
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
        //      C# -> List<PolarisReportFilterConfigs>? Configs
        // GraphQL -> configs: [PolarisReportFilterConfigs!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(conf.Child("configs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        if (ec.Includes("dataType",true))
        {
            if(this.DataType == null) {

                this.DataType = new DataTypeEnum();

            } else {


            }
        }
        else if (this.DataType != null && ec.Excludes("dataType",true))
        {
            this.DataType = null;
        }
        //      C# -> FilterTypeEnum? FilterType
        // GraphQL -> filterType: FilterTypeEnum! (enum)
        if (ec.Includes("filterType",true))
        {
            if(this.FilterType == null) {

                this.FilterType = new FilterTypeEnum();

            } else {


            }
        }
        else if (this.FilterType != null && ec.Excludes("filterType",true))
        {
            this.FilterType = null;
        }
        //      C# -> List<Value>? DefaultValues
        // GraphQL -> defaultValues: [Value!]! (interface)
        if (ec.Includes("defaultValues",false))
        {
            if(this.DefaultValues == null) {

                this.DefaultValues = new List<Value>();
                this.DefaultValues.ApplyExploratoryFieldSpec(ec.NewChild("defaultValues"));

            } else {

                this.DefaultValues.ApplyExploratoryFieldSpec(ec.NewChild("defaultValues"));

            }
        }
        else if (this.DefaultValues != null && ec.Excludes("defaultValues",false))
        {
            this.DefaultValues = null;
        }
        //      C# -> List<DisplayableValue>? Values
        // GraphQL -> values: [DisplayableValue!]! (interface)
        if (ec.Includes("values",false))
        {
            if(this.Values == null) {

                this.Values = new List<DisplayableValue>();
                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            } else {

                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            }
        }
        else if (this.Values != null && ec.Excludes("values",false))
        {
            this.Values = null;
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
        //      C# -> List<PolarisReportFilterConfigs>? Configs
        // GraphQL -> configs: [PolarisReportFilterConfigs!]! (type)
        if (ec.Includes("configs",false))
        {
            if(this.Configs == null) {

                this.Configs = new List<PolarisReportFilterConfigs>();
                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            } else {

                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            }
        }
        else if (this.Configs != null && ec.Excludes("configs",false))
        {
            this.Configs = null;
        }
    }


    #endregion

    } // class PolarisReportFilter
    
    #endregion

    public static class ListPolarisReportFilterExtensions
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
            this List<PolarisReportFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportFilter> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types