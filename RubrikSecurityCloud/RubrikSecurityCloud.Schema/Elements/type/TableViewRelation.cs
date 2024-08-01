// TableViewRelation.cs
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
    #region TableViewRelation
    public class TableViewRelation: BaseType
    {
        #region members

        //      C# -> List<System.String>? PrimaryTableColumnNames
        // GraphQL -> primaryTableColumnNames: [String!]! (scalar)
        [JsonProperty("primaryTableColumnNames")]
        public List<System.String>? PrimaryTableColumnNames { get; set; }

        //      C# -> System.String? SecondaryTableFilterName
        // GraphQL -> secondaryTableFilterName: String! (scalar)
        [JsonProperty("secondaryTableFilterName")]
        public System.String? SecondaryTableFilterName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TableViewRelation";
    }

    public TableViewRelation Set(
        List<System.String>? PrimaryTableColumnNames = null,
        System.String? SecondaryTableFilterName = null
    ) 
    {
        if ( PrimaryTableColumnNames != null ) {
            this.PrimaryTableColumnNames = PrimaryTableColumnNames;
        }
        if ( SecondaryTableFilterName != null ) {
            this.SecondaryTableFilterName = SecondaryTableFilterName;
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
        //      C# -> List<System.String>? PrimaryTableColumnNames
        // GraphQL -> primaryTableColumnNames: [String!]! (scalar)
        if (this.PrimaryTableColumnNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryTableColumnNames\n" ;
            } else {
                s += ind + "primaryTableColumnNames\n" ;
            }
        }
        //      C# -> System.String? SecondaryTableFilterName
        // GraphQL -> secondaryTableFilterName: String! (scalar)
        if (this.SecondaryTableFilterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryTableFilterName\n" ;
            } else {
                s += ind + "secondaryTableFilterName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? PrimaryTableColumnNames
        // GraphQL -> primaryTableColumnNames: [String!]! (scalar)
        if (ec.Includes("primaryTableColumnNames",true))
        {
            if(this.PrimaryTableColumnNames == null) {

                this.PrimaryTableColumnNames = new List<System.String>();

            } else {


            }
        }
        else if (this.PrimaryTableColumnNames != null && ec.Excludes("primaryTableColumnNames",true))
        {
            this.PrimaryTableColumnNames = null;
        }
        //      C# -> System.String? SecondaryTableFilterName
        // GraphQL -> secondaryTableFilterName: String! (scalar)
        if (ec.Includes("secondaryTableFilterName",true))
        {
            if(this.SecondaryTableFilterName == null) {

                this.SecondaryTableFilterName = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryTableFilterName != null && ec.Excludes("secondaryTableFilterName",true))
        {
            this.SecondaryTableFilterName = null;
        }
    }


    #endregion

    } // class TableViewRelation
    
    #endregion

    public static class ListTableViewRelationExtensions
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
            this List<TableViewRelation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TableViewRelation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TableViewRelation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TableViewRelation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TableViewRelation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types