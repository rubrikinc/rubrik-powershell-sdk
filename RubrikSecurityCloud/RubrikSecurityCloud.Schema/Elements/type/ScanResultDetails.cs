// ScanResultDetails.cs
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
    #region ScanResultDetails
    public class ScanResultDetails: BaseType
    {
        #region members

        //      C# -> ScanResultCategory? Category
        // GraphQL -> category: ScanResultCategory! (enum)
        [JsonProperty("category")]
        public ScanResultCategory? Category { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Boolean? SupportsVariables
        // GraphQL -> supportsVariables: Boolean! (scalar)
        [JsonProperty("supportsVariables")]
        public System.Boolean? SupportsVariables { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScanResultDetails";
    }

    public ScanResultDetails Set(
        ScanResultCategory? Category = null,
        System.String? Description = null,
        System.Boolean? SupportsVariables = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( SupportsVariables != null ) {
            this.SupportsVariables = SupportsVariables;
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
        //      C# -> ScanResultCategory? Category
        // GraphQL -> category: ScanResultCategory! (enum)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Boolean? SupportsVariables
        // GraphQL -> supportsVariables: Boolean! (scalar)
        if (this.SupportsVariables != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportsVariables\n" ;
            } else {
                s += ind + "supportsVariables\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ScanResultCategory? Category
        // GraphQL -> category: ScanResultCategory! (enum)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = new ScanResultCategory();

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Boolean? SupportsVariables
        // GraphQL -> supportsVariables: Boolean! (scalar)
        if (ec.Includes("supportsVariables",true))
        {
            if(this.SupportsVariables == null) {

                this.SupportsVariables = true;

            } else {


            }
        }
        else if (this.SupportsVariables != null && ec.Excludes("supportsVariables",true))
        {
            this.SupportsVariables = null;
        }
    }


    #endregion

    } // class ScanResultDetails
    
    #endregion

    public static class ListScanResultDetailsExtensions
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
            this List<ScanResultDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScanResultDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScanResultDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScanResultDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScanResultDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types