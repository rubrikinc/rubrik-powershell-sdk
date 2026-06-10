// TemplateTableDetail.cs
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
    #region TemplateTableDetail
    public class TemplateTableDetail: BaseType
    {
        #region members

        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        [JsonProperty("tableViewType")]
        public TableViewType? TableViewType { get; set; }

        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        [JsonProperty("tableName")]
        public System.String? TableName { get; set; }

        //      C# -> List<TemplateTableColumn>? Columns
        // GraphQL -> columns: [TemplateTableColumn!]! (type)
        [JsonProperty("columns")]
        public List<TemplateTableColumn>? Columns { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TemplateTableDetail";
    }

    public TemplateTableDetail Set(
        TableViewType? TableViewType = null,
        System.String? TableName = null,
        List<TemplateTableColumn>? Columns = null
    ) 
    {
        if ( TableViewType != null ) {
            this.TableViewType = TableViewType;
        }
        if ( TableName != null ) {
            this.TableName = TableName;
        }
        if ( Columns != null ) {
            this.Columns = Columns;
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
        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        if (this.TableViewType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tableViewType\n" ;
            } else {
                s += ind + "tableViewType\n" ;
            }
        }
        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        if (this.TableName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tableName\n" ;
            } else {
                s += ind + "tableName\n" ;
            }
        }
        //      C# -> List<TemplateTableColumn>? Columns
        // GraphQL -> columns: [TemplateTableColumn!]! (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        if (ec.Includes("tableViewType",true))
        {
            if(this.TableViewType == null) {

                this.TableViewType = new TableViewType();

            } else {


            }
        }
        else if (this.TableViewType != null && ec.Excludes("tableViewType",true))
        {
            this.TableViewType = null;
        }
        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        if (ec.Includes("tableName",true))
        {
            if(this.TableName == null) {

                this.TableName = "FETCH";

            } else {


            }
        }
        else if (this.TableName != null && ec.Excludes("tableName",true))
        {
            this.TableName = null;
        }
        //      C# -> List<TemplateTableColumn>? Columns
        // GraphQL -> columns: [TemplateTableColumn!]! (type)
        if (ec.Includes("columns",false))
        {
            if(this.Columns == null) {

                this.Columns = new List<TemplateTableColumn>();
                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            } else {

                this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));

            }
        }
        else if (this.Columns != null && ec.Excludes("columns",false))
        {
            this.Columns = null;
        }
    }


    #endregion

    } // class TemplateTableDetail
    
    #endregion

    public static class ListTemplateTableDetailExtensions
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
            this List<TemplateTableDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TemplateTableDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TemplateTableDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TemplateTableDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TemplateTableDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types