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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        if (this.DataType != null) {
            s += ind + "dataType\n" ;
        }
        //      C# -> FilterTypeEnum? FilterType
        // GraphQL -> filterType: FilterTypeEnum! (enum)
        if (this.FilterType != null) {
            s += ind + "filterType\n" ;
        }
        //      C# -> List<Value>? DefaultValues
        // GraphQL -> defaultValues: [Value!]! (interface)
        if (this.DefaultValues != null) {
                var fspec = this.DefaultValues.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "defaultValues {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<DisplayableValue>? Values
        // GraphQL -> values: [DisplayableValue!]! (interface)
        if (this.Values != null) {
                var fspec = this.Values.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "values {\n" + fspec + ind + "}\n";
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
        //      C# -> List<PolarisReportFilterConfigs>? Configs
        // GraphQL -> configs: [PolarisReportFilterConfigs!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        if (this.DataType == null && Exploration.Includes(parent + ".dataType", true))
        {
            this.DataType = new DataTypeEnum();
        }
        //      C# -> FilterTypeEnum? FilterType
        // GraphQL -> filterType: FilterTypeEnum! (enum)
        if (this.FilterType == null && Exploration.Includes(parent + ".filterType", true))
        {
            this.FilterType = new FilterTypeEnum();
        }
        //      C# -> List<Value>? DefaultValues
        // GraphQL -> defaultValues: [Value!]! (interface)
        if (this.DefaultValues == null && Exploration.Includes(parent + ".defaultValues"))
        {
            this.DefaultValues = new List<Value>();
            this.DefaultValues.ApplyExploratoryFieldSpec(parent + ".defaultValues");
        }
        //      C# -> List<DisplayableValue>? Values
        // GraphQL -> values: [DisplayableValue!]! (interface)
        if (this.Values == null && Exploration.Includes(parent + ".values"))
        {
            this.Values = new List<DisplayableValue>();
            this.Values.ApplyExploratoryFieldSpec(parent + ".values");
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
        //      C# -> List<PolarisReportFilterConfigs>? Configs
        // GraphQL -> configs: [PolarisReportFilterConfigs!]! (type)
        if (this.Configs == null && Exploration.Includes(parent + ".configs"))
        {
            this.Configs = new List<PolarisReportFilterConfigs>();
            this.Configs.ApplyExploratoryFieldSpec(parent + ".configs");
        }
    }


    #endregion

    } // class PolarisReportFilter
    
    #endregion

    public static class ListPolarisReportFilterExtensions
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
            this List<PolarisReportFilter> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportFilter> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportFilter());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types