// DataCategoryResult.cs
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
    #region DataCategoryResult
    public class DataCategoryResult: BaseType
    {
        #region members

        //      C# -> DataCategoryHits? DataCategoryHits
        // GraphQL -> dataCategoryHits: DataCategoryHits (type)
        [JsonProperty("dataCategoryHits")]
        public DataCategoryHits? DataCategoryHits { get; set; }

        //      C# -> List<DataTypeHits>? DataTypeHits
        // GraphQL -> dataTypeHits: [DataTypeHits!]! (type)
        [JsonProperty("dataTypeHits")]
        public List<DataTypeHits>? DataTypeHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataCategoryResult";
    }

    public DataCategoryResult Set(
        DataCategoryHits? DataCategoryHits = null,
        List<DataTypeHits>? DataTypeHits = null
    ) 
    {
        if ( DataCategoryHits != null ) {
            this.DataCategoryHits = DataCategoryHits;
        }
        if ( DataTypeHits != null ) {
            this.DataTypeHits = DataTypeHits;
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
        //      C# -> DataCategoryHits? DataCategoryHits
        // GraphQL -> dataCategoryHits: DataCategoryHits (type)
        if (this.DataCategoryHits != null) {
            var fspec = this.DataCategoryHits.AsFieldSpec(conf.Child("dataCategoryHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategoryHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataTypeHits>? DataTypeHits
        // GraphQL -> dataTypeHits: [DataTypeHits!]! (type)
        if (this.DataTypeHits != null) {
            var fspec = this.DataTypeHits.AsFieldSpec(conf.Child("dataTypeHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataTypeHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataCategoryHits? DataCategoryHits
        // GraphQL -> dataCategoryHits: DataCategoryHits (type)
        if (ec.Includes("dataCategoryHits",false))
        {
            if(this.DataCategoryHits == null) {

                this.DataCategoryHits = new DataCategoryHits();
                this.DataCategoryHits.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryHits"));

            } else {

                this.DataCategoryHits.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryHits"));

            }
        }
        else if (this.DataCategoryHits != null && ec.Excludes("dataCategoryHits",false))
        {
            this.DataCategoryHits = null;
        }
        //      C# -> List<DataTypeHits>? DataTypeHits
        // GraphQL -> dataTypeHits: [DataTypeHits!]! (type)
        if (ec.Includes("dataTypeHits",false))
        {
            if(this.DataTypeHits == null) {

                this.DataTypeHits = new List<DataTypeHits>();
                this.DataTypeHits.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeHits"));

            } else {

                this.DataTypeHits.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeHits"));

            }
        }
        else if (this.DataTypeHits != null && ec.Excludes("dataTypeHits",false))
        {
            this.DataTypeHits = null;
        }
    }


    #endregion

    } // class DataCategoryResult
    
    #endregion

    public static class ListDataCategoryResultExtensions
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
            this List<DataCategoryResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataCategoryResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataCategoryResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataCategoryResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataCategoryResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types