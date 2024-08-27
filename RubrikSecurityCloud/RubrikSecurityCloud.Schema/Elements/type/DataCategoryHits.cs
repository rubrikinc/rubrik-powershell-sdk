// DataCategoryHits.cs
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
    #region DataCategoryHits
    public class DataCategoryHits: BaseType
    {
        #region members

        //      C# -> System.String? DataCategoryId
        // GraphQL -> dataCategoryId: String! (scalar)
        [JsonProperty("dataCategoryId")]
        public System.String? DataCategoryId { get; set; }

        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        [JsonProperty("totalHits")]
        public System.Int64? TotalHits { get; set; }

        //      C# -> System.Int64? TotalViolatedHits
        // GraphQL -> totalViolatedHits: Long! (scalar)
        [JsonProperty("totalViolatedHits")]
        public System.Int64? TotalViolatedHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataCategoryHits";
    }

    public DataCategoryHits Set(
        System.String? DataCategoryId = null,
        System.Int64? TotalHits = null,
        System.Int64? TotalViolatedHits = null
    ) 
    {
        if ( DataCategoryId != null ) {
            this.DataCategoryId = DataCategoryId;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( TotalViolatedHits != null ) {
            this.TotalViolatedHits = TotalViolatedHits;
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
        //      C# -> System.String? DataCategoryId
        // GraphQL -> dataCategoryId: String! (scalar)
        if (this.DataCategoryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataCategoryId\n" ;
            } else {
                s += ind + "dataCategoryId\n" ;
            }
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalViolatedHits
        // GraphQL -> totalViolatedHits: Long! (scalar)
        if (this.TotalViolatedHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalViolatedHits\n" ;
            } else {
                s += ind + "totalViolatedHits\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DataCategoryId
        // GraphQL -> dataCategoryId: String! (scalar)
        if (ec.Includes("dataCategoryId",true))
        {
            if(this.DataCategoryId == null) {

                this.DataCategoryId = "FETCH";

            } else {


            }
        }
        else if (this.DataCategoryId != null && ec.Excludes("dataCategoryId",true))
        {
            this.DataCategoryId = null;
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
        }
        //      C# -> System.Int64? TotalViolatedHits
        // GraphQL -> totalViolatedHits: Long! (scalar)
        if (ec.Includes("totalViolatedHits",true))
        {
            if(this.TotalViolatedHits == null) {

                this.TotalViolatedHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalViolatedHits != null && ec.Excludes("totalViolatedHits",true))
        {
            this.TotalViolatedHits = null;
        }
    }


    #endregion

    } // class DataCategoryHits
    
    #endregion

    public static class ListDataCategoryHitsExtensions
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
            this List<DataCategoryHits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataCategoryHits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataCategoryHits> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataCategoryHits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataCategoryHits> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types