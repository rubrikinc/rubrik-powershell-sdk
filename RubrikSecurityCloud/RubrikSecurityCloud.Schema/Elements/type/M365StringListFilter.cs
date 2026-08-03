// M365StringListFilter.cs
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
    #region M365StringListFilter
    public class M365StringListFilter: BaseType
    {
        #region members

        //      C# -> List<System.String>? Exclude
        // GraphQL -> exclude: [String!]! (scalar)
        [JsonProperty("exclude")]
        public List<System.String>? Exclude { get; set; }

        //      C# -> List<System.String>? Include
        // GraphQL -> include: [String!]! (scalar)
        [JsonProperty("include")]
        public List<System.String>? Include { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365StringListFilter";
    }

    public M365StringListFilter Set(
        List<System.String>? Exclude = null,
        List<System.String>? Include = null
    ) 
    {
        if ( Exclude != null ) {
            this.Exclude = Exclude;
        }
        if ( Include != null ) {
            this.Include = Include;
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
        //      C# -> List<System.String>? Exclude
        // GraphQL -> exclude: [String!]! (scalar)
        if (this.Exclude != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exclude\n" ;
            } else {
                s += ind + "exclude\n" ;
            }
        }
        //      C# -> List<System.String>? Include
        // GraphQL -> include: [String!]! (scalar)
        if (this.Include != null) {
            if (conf.Flat) {
                s += conf.Prefix + "include\n" ;
            } else {
                s += ind + "include\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? Exclude
        // GraphQL -> exclude: [String!]! (scalar)
        if (ec.Includes("exclude",true))
        {
            if(this.Exclude == null) {

                this.Exclude = new List<System.String>();

            } else {


            }
        }
        else if (this.Exclude != null && ec.Excludes("exclude",true))
        {
            this.Exclude = null;
        }
        //      C# -> List<System.String>? Include
        // GraphQL -> include: [String!]! (scalar)
        if (ec.Includes("include",true))
        {
            if(this.Include == null) {

                this.Include = new List<System.String>();

            } else {


            }
        }
        else if (this.Include != null && ec.Excludes("include",true))
        {
            this.Include = null;
        }
    }


    #endregion

    } // class M365StringListFilter
    
    #endregion

    public static class ListM365StringListFilterExtensions
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
            this List<M365StringListFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365StringListFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365StringListFilter> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365StringListFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365StringListFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types