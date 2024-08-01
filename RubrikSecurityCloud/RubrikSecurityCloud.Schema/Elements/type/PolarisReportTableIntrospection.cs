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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> SecondaryTableConfig? SecondaryTableConfig
        // GraphQL -> secondaryTableConfig: SecondaryTableConfig (type)
        [JsonProperty("secondaryTableConfig")]
        public SecondaryTableConfig? SecondaryTableConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportTableIntrospection";
    }

    public PolarisReportTableIntrospection Set(
        SortOrder? DefaultSortByOrder = null,
        System.String? DefaultSortByColumn = null,
        System.Int32? PageSize = null,
        List<PolarisReportColumn>? Columns = null,
        SecondaryTableConfig? SecondaryTableConfig = null
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
        if ( SecondaryTableConfig != null ) {
            this.SecondaryTableConfig = SecondaryTableConfig;
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
        //      C# -> SortOrder? DefaultSortByOrder
        // GraphQL -> defaultSortByOrder: SortOrder! (enum)
        if (this.DefaultSortByOrder != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultSortByOrder\n" ;
            } else {
                s += ind + "defaultSortByOrder\n" ;
            }
        }
        //      C# -> System.String? DefaultSortByColumn
        // GraphQL -> defaultSortByColumn: String! (scalar)
        if (this.DefaultSortByColumn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultSortByColumn\n" ;
            } else {
                s += ind + "defaultSortByColumn\n" ;
            }
        }
        //      C# -> System.Int32? PageSize
        // GraphQL -> pageSize: Int! (scalar)
        if (this.PageSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pageSize\n" ;
            } else {
                s += ind + "pageSize\n" ;
            }
        }
        //      C# -> List<PolarisReportColumn>? Columns
        // GraphQL -> columns: [PolarisReportColumn!]! (type)
        if (this.Columns != null) {
            var fspec = this.Columns.AsFieldSpec(conf.Child("columns"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "columns" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SecondaryTableConfig? SecondaryTableConfig
        // GraphQL -> secondaryTableConfig: SecondaryTableConfig (type)
        if (this.SecondaryTableConfig != null) {
            var fspec = this.SecondaryTableConfig.AsFieldSpec(conf.Child("secondaryTableConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryTableConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SortOrder? DefaultSortByOrder
        // GraphQL -> defaultSortByOrder: SortOrder! (enum)
        if (ec.Includes("defaultSortByOrder",true))
        {
            if(this.DefaultSortByOrder == null) {

                this.DefaultSortByOrder = new SortOrder();

            } else {


            }
        }
        else if (this.DefaultSortByOrder != null && ec.Excludes("defaultSortByOrder",true))
        {
            this.DefaultSortByOrder = null;
        }
        //      C# -> System.String? DefaultSortByColumn
        // GraphQL -> defaultSortByColumn: String! (scalar)
        if (ec.Includes("defaultSortByColumn",true))
        {
            if(this.DefaultSortByColumn == null) {

                this.DefaultSortByColumn = "FETCH";

            } else {


            }
        }
        else if (this.DefaultSortByColumn != null && ec.Excludes("defaultSortByColumn",true))
        {
            this.DefaultSortByColumn = null;
        }
        //      C# -> System.Int32? PageSize
        // GraphQL -> pageSize: Int! (scalar)
        if (ec.Includes("pageSize",true))
        {
            if(this.PageSize == null) {

                this.PageSize = Int32.MinValue;

            } else {


            }
        }
        else if (this.PageSize != null && ec.Excludes("pageSize",true))
        {
            this.PageSize = null;
        }
        //      C# -> List<PolarisReportColumn>? Columns
        // GraphQL -> columns: [PolarisReportColumn!]! (type)
        if (ec.Includes("columns",false))
        {
            if(this.Columns == null) {

                this.Columns = new List<PolarisReportColumn>();
                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            } else {

                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            }
        }
        else if (this.Columns != null && ec.Excludes("columns",false))
        {
            this.Columns = null;
        }
        //      C# -> SecondaryTableConfig? SecondaryTableConfig
        // GraphQL -> secondaryTableConfig: SecondaryTableConfig (type)
        if (ec.Includes("secondaryTableConfig",false))
        {
            if(this.SecondaryTableConfig == null) {

                this.SecondaryTableConfig = new SecondaryTableConfig();
                this.SecondaryTableConfig.ApplyExploratoryFieldSpec(ec.NewChild("secondaryTableConfig"));

            } else {

                this.SecondaryTableConfig.ApplyExploratoryFieldSpec(ec.NewChild("secondaryTableConfig"));

            }
        }
        else if (this.SecondaryTableConfig != null && ec.Excludes("secondaryTableConfig",false))
        {
            this.SecondaryTableConfig = null;
        }
    }


    #endregion

    } // class PolarisReportTableIntrospection
    
    #endregion

    public static class ListPolarisReportTableIntrospectionExtensions
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
            this List<PolarisReportTableIntrospection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportTableIntrospection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportTableIntrospection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportTableIntrospection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportTableIntrospection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types