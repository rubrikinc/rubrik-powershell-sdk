// PolarisReportTableIntrospection.cs
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
    #region PolarisReportTableIntrospection
    public class PolarisReportTableIntrospection: BaseType
    {
        #region members

        //      C# -> SortOrder? DefaultSortByOrder
        // GraphQL -> defaultSortByOrder: SortOrder! (enum)
        [JsonProperty("defaultSortByOrder")]
        public SortOrder? DefaultSortByOrder { get; set; }

        //      C# -> System.String? DefaultSortByColumn
        // GraphQL -> defaultSortByColumn: String! (scalar)
        [JsonProperty("defaultSortByColumn")]
        public System.String? DefaultSortByColumn { get; set; }

        //      C# -> System.Int32? PageSize
        // GraphQL -> pageSize: Int! (scalar)
        [JsonProperty("pageSize")]
        public System.Int32? PageSize { get; set; }

        //      C# -> List<PolarisReportColumn>? Columns
        // GraphQL -> columns: [PolarisReportColumn!]! (type)
        [JsonProperty("columns")]
        public List<PolarisReportColumn>? Columns { get; set; }


        #endregion

    #region methods

    public PolarisReportTableIntrospection Set(
        SortOrder? DefaultSortByOrder = null,
        System.String? DefaultSortByColumn = null,
        System.Int32? PageSize = null,
        List<PolarisReportColumn>? Columns = null
    ) 
    {
        if ( DefaultSortByOrder != null ) {
            this.DefaultSortByOrder = DefaultSortByOrder;
        }
        if ( DefaultSortByColumn != null ) {
            this.DefaultSortByColumn = DefaultSortByColumn;
        }
        if ( PageSize != null ) {
            this.PageSize = PageSize;
        }
        if ( Columns != null ) {
            this.Columns = Columns;
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
        //      C# -> SortOrder? DefaultSortByOrder
        // GraphQL -> defaultSortByOrder: SortOrder! (enum)
        if (this.DefaultSortByOrder != null) {
            s += ind + "defaultSortByOrder\n" ;
        }
        //      C# -> System.String? DefaultSortByColumn
        // GraphQL -> defaultSortByColumn: String! (scalar)
        if (this.DefaultSortByColumn != null) {
            s += ind + "defaultSortByColumn\n" ;
        }
        //      C# -> System.Int32? PageSize
        // GraphQL -> pageSize: Int! (scalar)
        if (this.PageSize != null) {
            s += ind + "pageSize\n" ;
        }
        //      C# -> List<PolarisReportColumn>? Columns
        // GraphQL -> columns: [PolarisReportColumn!]! (type)
        if (this.Columns != null) {
            s += ind + "columns {\n" + this.Columns.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SortOrder? DefaultSortByOrder
        // GraphQL -> defaultSortByOrder: SortOrder! (enum)
        if (this.DefaultSortByOrder == null && Exploration.Includes(parent + ".defaultSortByOrder", true))
        {
            this.DefaultSortByOrder = new SortOrder();
        }
        //      C# -> System.String? DefaultSortByColumn
        // GraphQL -> defaultSortByColumn: String! (scalar)
        if (this.DefaultSortByColumn == null && Exploration.Includes(parent + ".defaultSortByColumn", true))
        {
            this.DefaultSortByColumn = new System.String("FETCH");
        }
        //      C# -> System.Int32? PageSize
        // GraphQL -> pageSize: Int! (scalar)
        if (this.PageSize == null && Exploration.Includes(parent + ".pageSize", true))
        {
            this.PageSize = new System.Int32();
        }
        //      C# -> List<PolarisReportColumn>? Columns
        // GraphQL -> columns: [PolarisReportColumn!]! (type)
        if (this.Columns == null && Exploration.Includes(parent + ".columns"))
        {
            this.Columns = new List<PolarisReportColumn>();
            this.Columns.ApplyExploratoryFieldSpec(parent + ".columns");
        }
    }


    #endregion

    } // class PolarisReportTableIntrospection
    
    #endregion

    public static class ListPolarisReportTableIntrospectionExtensions
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
            this List<PolarisReportTableIntrospection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportTableIntrospection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportTableIntrospection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types