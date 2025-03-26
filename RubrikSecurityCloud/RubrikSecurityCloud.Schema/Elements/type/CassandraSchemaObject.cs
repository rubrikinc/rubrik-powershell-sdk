// CassandraSchemaObject.cs
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
    #region CassandraSchemaObject
    public class CassandraSchemaObject: BaseType
    {
        #region members

        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        [JsonProperty("primaryKeys")]
        public List<System.String>? PrimaryKeys { get; set; }

        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
        [JsonProperty("columns")]
        public List<CassandraColumnObject>? Columns { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CassandraSchemaObject";
    }

    public CassandraSchemaObject Set(
        List<System.String>? PrimaryKeys = null,
        List<CassandraColumnObject>? Columns = null
    ) 
    {
        if ( PrimaryKeys != null ) {
            this.PrimaryKeys = PrimaryKeys;
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
        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        if (this.PrimaryKeys != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryKeys\n" ;
            } else {
                s += ind + "primaryKeys\n" ;
            }
        }
        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
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
        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        if (ec.Includes("primaryKeys",true))
        {
            if(this.PrimaryKeys == null) {

                this.PrimaryKeys = new List<System.String>();

            } else {


            }
        }
        else if (this.PrimaryKeys != null && ec.Excludes("primaryKeys",true))
        {
            this.PrimaryKeys = null;
        }
        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
        if (ec.Includes("columns",false))
        {
            if(this.Columns == null) {

                this.Columns = new List<CassandraColumnObject>();
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

    } // class CassandraSchemaObject
    
    #endregion

    public static class ListCassandraSchemaObjectExtensions
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
            this List<CassandraSchemaObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CassandraSchemaObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CassandraSchemaObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraSchemaObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CassandraSchemaObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types