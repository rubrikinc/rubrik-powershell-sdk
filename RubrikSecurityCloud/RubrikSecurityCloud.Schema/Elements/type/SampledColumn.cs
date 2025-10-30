// SampledColumn.cs
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
    #region SampledColumn
    public class SampledColumn: BaseType
    {
        #region members

        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String! (scalar)
        [JsonProperty("columnName")]
        public System.String? ColumnName { get; set; }

        //      C# -> System.String? DataTypeDisplayName
        // GraphQL -> dataTypeDisplayName: String! (scalar)
        [JsonProperty("dataTypeDisplayName")]
        public System.String? DataTypeDisplayName { get; set; }

        //      C# -> System.String? DataTypeId
        // GraphQL -> dataTypeId: String! (scalar)
        [JsonProperty("dataTypeId")]
        public System.String? DataTypeId { get; set; }

        //      C# -> List<ClassificationPreview>? Preview
        // GraphQL -> preview: [ClassificationPreview!]! (type)
        [JsonProperty("preview")]
        public List<ClassificationPreview>? Preview { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SampledColumn";
    }

    public SampledColumn Set(
        System.String? ColumnName = null,
        System.String? DataTypeDisplayName = null,
        System.String? DataTypeId = null,
        List<ClassificationPreview>? Preview = null
    ) 
    {
        if ( ColumnName != null ) {
            this.ColumnName = ColumnName;
        }
        if ( DataTypeDisplayName != null ) {
            this.DataTypeDisplayName = DataTypeDisplayName;
        }
        if ( DataTypeId != null ) {
            this.DataTypeId = DataTypeId;
        }
        if ( Preview != null ) {
            this.Preview = Preview;
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
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String! (scalar)
        if (this.ColumnName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnName\n" ;
            } else {
                s += ind + "columnName\n" ;
            }
        }
        //      C# -> System.String? DataTypeDisplayName
        // GraphQL -> dataTypeDisplayName: String! (scalar)
        if (this.DataTypeDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTypeDisplayName\n" ;
            } else {
                s += ind + "dataTypeDisplayName\n" ;
            }
        }
        //      C# -> System.String? DataTypeId
        // GraphQL -> dataTypeId: String! (scalar)
        if (this.DataTypeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTypeId\n" ;
            } else {
                s += ind + "dataTypeId\n" ;
            }
        }
        //      C# -> List<ClassificationPreview>? Preview
        // GraphQL -> preview: [ClassificationPreview!]! (type)
        if (this.Preview != null) {
            var fspec = this.Preview.AsFieldSpec(conf.Child("preview"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preview" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? DataTypeDisplayName
        // GraphQL -> dataTypeDisplayName: String! (scalar)
        if (ec.Includes("dataTypeDisplayName",true))
        {
            if(this.DataTypeDisplayName == null) {

                this.DataTypeDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DataTypeDisplayName != null && ec.Excludes("dataTypeDisplayName",true))
        {
            this.DataTypeDisplayName = null;
        }
        //      C# -> System.String? DataTypeId
        // GraphQL -> dataTypeId: String! (scalar)
        if (ec.Includes("dataTypeId",true))
        {
            if(this.DataTypeId == null) {

                this.DataTypeId = "FETCH";

            } else {


            }
        }
        else if (this.DataTypeId != null && ec.Excludes("dataTypeId",true))
        {
            this.DataTypeId = null;
        }
        //      C# -> List<ClassificationPreview>? Preview
        // GraphQL -> preview: [ClassificationPreview!]! (type)
        if (ec.Includes("preview",false))
        {
            if(this.Preview == null) {

                this.Preview = new List<ClassificationPreview>();
                this.Preview.ApplyExploratoryFieldSpec(ec.NewChild("preview"));

            } else {

                this.Preview.ApplyExploratoryFieldSpec(ec.NewChild("preview"));

            }
        }
        else if (this.Preview != null && ec.Excludes("preview",false))
        {
            this.Preview = null;
        }
    }


    #endregion

    } // class SampledColumn
    
    #endregion

    public static class ListSampledColumnExtensions
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
            this List<SampledColumn> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SampledColumn> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SampledColumn> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SampledColumn());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SampledColumn> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types