// ReportFilterDetail.cs
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
    #region ReportFilterDetail
    public class ReportFilterDetail: BaseType
    {
        #region members

        //      C# -> DataTypeEnum? DataType
        // GraphQL -> dataType: DataTypeEnum! (enum)
        [JsonProperty("dataType")]
        public DataTypeEnum? DataType { get; set; }

        //      C# -> FilterTypeEnum? Type
        // GraphQL -> type: FilterTypeEnum! (enum)
        [JsonProperty("type")]
        public FilterTypeEnum? Type { get; set; }

        //      C# -> List<DisplayableValue>? DefaultValues
        // GraphQL -> defaultValues: [DisplayableValue!]! (interface)
        [JsonProperty("defaultValues")]
        public List<DisplayableValue>? DefaultValues { get; set; }

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


        #endregion

    #region methods

    public ReportFilterDetail Set(
        DataTypeEnum? DataType = null,
        FilterTypeEnum? Type = null,
        List<DisplayableValue>? DefaultValues = null,
        List<DisplayableValue>? Values = null,
        System.String? DisplayName = null,
        System.String? Name = null
    ) 
    {
        if ( DataType != null ) {
            this.DataType = DataType;
        }
        if ( Type != null ) {
            this.Type = Type;
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
        //      C# -> FilterTypeEnum? Type
        // GraphQL -> type: FilterTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> List<DisplayableValue>? DefaultValues
        // GraphQL -> defaultValues: [DisplayableValue!]! (interface)
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
        //      C# -> FilterTypeEnum? Type
        // GraphQL -> type: FilterTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new FilterTypeEnum();
        }
        //      C# -> List<DisplayableValue>? DefaultValues
        // GraphQL -> defaultValues: [DisplayableValue!]! (interface)
        if (this.DefaultValues == null && Exploration.Includes(parent + ".defaultValues"))
        {
            this.DefaultValues = new List<DisplayableValue>();
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
    }


    #endregion

    } // class ReportFilterDetail
    
    #endregion

    public static class ListReportFilterDetailExtensions
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
            this List<ReportFilterDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportFilterDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportFilterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types