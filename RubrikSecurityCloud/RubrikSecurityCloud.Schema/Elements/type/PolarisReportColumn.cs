// PolarisReportColumn.cs
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
    #region PolarisReportColumn
    public class PolarisReportColumn: BaseType
    {
        #region members

        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        [JsonProperty("columnWidth")]
        public System.Int32? ColumnWidth { get; set; }

        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        [JsonProperty("default")]
        public System.Boolean? Default { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        [JsonProperty("sortable")]
        public System.Boolean? Sortable { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportColumn";
    }

    public PolarisReportColumn Set(
        System.Int32? ColumnWidth = null,
        System.Boolean? Default = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        System.Boolean? Sortable = null,
        List<Metadata>? Metadata = null
    ) 
    {
        if ( ColumnWidth != null ) {
            this.ColumnWidth = ColumnWidth;
        }
        if ( Default != null ) {
            this.Default = Default;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Sortable != null ) {
            this.Sortable = Sortable;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        if (this.ColumnWidth != null) {
            s += ind + "columnWidth\n" ;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default != null) {
            s += ind + "default\n" ;
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
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable != null) {
            s += ind + "sortable\n" ;
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metadata {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        if (this.ColumnWidth == null && ec.Includes("columnWidth",true))
        {
            this.ColumnWidth = Int32.MinValue;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default == null && ec.Includes("default",true))
        {
            this.Default = true;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && ec.Includes("displayName",true))
        {
            this.DisplayName = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable == null && ec.Includes("sortable",true))
        {
            this.Sortable = true;
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata == null && ec.Includes("metadata",false))
        {
            this.Metadata = new List<Metadata>();
            this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));
        }
    }


    #endregion

    } // class PolarisReportColumn
    
    #endregion

    public static class ListPolarisReportColumnExtensions
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
            this List<PolarisReportColumn> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportColumn> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportColumn());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PolarisReportColumn> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types