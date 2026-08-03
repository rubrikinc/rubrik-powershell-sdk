// AnalyzedColumn.cs
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
    #region AnalyzedColumn
    public class AnalyzedColumn: BaseType
    {
        #region members

        //      C# -> SchemaFieldType? ColumnType
        // GraphQL -> columnType: SchemaFieldType! (enum)
        [JsonProperty("columnType")]
        public SchemaFieldType? ColumnType { get; set; }

        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String! (scalar)
        [JsonProperty("columnName")]
        public System.String? ColumnName { get; set; }

        //      C# -> List<DataTypeResult>? ColumnDatatypeResults
        // GraphQL -> columnDatatypeResults: [DataTypeResult!]! (type)
        [JsonProperty("columnDatatypeResults")]
        public List<DataTypeResult>? ColumnDatatypeResults { get; set; }

        //      C# -> List<AnalyzedColumn>? ColumnResults
        // GraphQL -> columnResults: [AnalyzedColumn!]! (type)
        [JsonProperty("columnResults")]
        public List<AnalyzedColumn>? ColumnResults { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzedColumn";
    }

    public AnalyzedColumn Set(
        SchemaFieldType? ColumnType = null,
        System.String? ColumnName = null,
        List<DataTypeResult>? ColumnDatatypeResults = null,
        List<AnalyzedColumn>? ColumnResults = null
    ) 
    {
        if ( ColumnType != null ) {
            this.ColumnType = ColumnType;
        }
        if ( ColumnName != null ) {
            this.ColumnName = ColumnName;
        }
        if ( ColumnDatatypeResults != null ) {
            this.ColumnDatatypeResults = ColumnDatatypeResults;
        }
        if ( ColumnResults != null ) {
            this.ColumnResults = ColumnResults;
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
        //      C# -> SchemaFieldType? ColumnType
        // GraphQL -> columnType: SchemaFieldType! (enum)
        if (this.ColumnType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnType\n" ;
            } else {
                s += ind + "columnType\n" ;
            }
        }
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String! (scalar)
        if (this.ColumnName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnName\n" ;
            } else {
                s += ind + "columnName\n" ;
            }
        }
        //      C# -> List<DataTypeResult>? ColumnDatatypeResults
        // GraphQL -> columnDatatypeResults: [DataTypeResult!]! (type)
        if (this.ColumnDatatypeResults != null) {
            var fspec = this.ColumnDatatypeResults.AsFieldSpec(conf.Child("columnDatatypeResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "columnDatatypeResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzedColumn>? ColumnResults
        // GraphQL -> columnResults: [AnalyzedColumn!]! (type)
        if (this.ColumnResults != null) {
            var fspec = this.ColumnResults.AsFieldSpec(conf.Child("columnResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "columnResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SchemaFieldType? ColumnType
        // GraphQL -> columnType: SchemaFieldType! (enum)
        if (ec.Includes("columnType",true))
        {
            if(this.ColumnType == null) {

                this.ColumnType = new SchemaFieldType();

            } else {


            }
        }
        else if (this.ColumnType != null && ec.Excludes("columnType",true))
        {
            this.ColumnType = null;
        }
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String! (scalar)
        if (ec.Includes("columnName",true))
        {
            if(this.ColumnName == null) {

                this.ColumnName = "FETCH";

            } else {


            }
        }
        else if (this.ColumnName != null && ec.Excludes("columnName",true))
        {
            this.ColumnName = null;
        }
        //      C# -> List<DataTypeResult>? ColumnDatatypeResults
        // GraphQL -> columnDatatypeResults: [DataTypeResult!]! (type)
        if (ec.Includes("columnDatatypeResults",false))
        {
            if(this.ColumnDatatypeResults == null) {

                this.ColumnDatatypeResults = new List<DataTypeResult>();
                this.ColumnDatatypeResults.ApplyExploratoryFieldSpec(ec.NewChild("columnDatatypeResults"));

            } else {

                this.ColumnDatatypeResults.ApplyExploratoryFieldSpec(ec.NewChild("columnDatatypeResults"));

            }
        }
        else if (this.ColumnDatatypeResults != null && ec.Excludes("columnDatatypeResults",false))
        {
            this.ColumnDatatypeResults = null;
        }
        //      C# -> List<AnalyzedColumn>? ColumnResults
        // GraphQL -> columnResults: [AnalyzedColumn!]! (type)
        if (ec.Includes("columnResults",false))
        {
            if(this.ColumnResults == null) {

                this.ColumnResults = new List<AnalyzedColumn>();
                this.ColumnResults.ApplyExploratoryFieldSpec(ec.NewChild("columnResults"));

            } else {

                this.ColumnResults.ApplyExploratoryFieldSpec(ec.NewChild("columnResults"));

            }
        }
        else if (this.ColumnResults != null && ec.Excludes("columnResults",false))
        {
            this.ColumnResults = null;
        }
    }


    #endregion

    } // class AnalyzedColumn
    
    #endregion

    public static class ListAnalyzedColumnExtensions
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
            this List<AnalyzedColumn> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzedColumn> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzedColumn> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzedColumn());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzedColumn> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types