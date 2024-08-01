// PartialSlaSummaries.cs
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
    #region PartialSlaSummaries
    public class PartialSlaSummaries: BaseType
    {
        #region members

        //      C# -> System.Int32? NumMatchingRows
        // GraphQL -> numMatchingRows: Int! (scalar)
        [JsonProperty("numMatchingRows")]
        public System.Int32? NumMatchingRows { get; set; }

        //      C# -> List<PartialSlaSummary>? PartialSlaSummary
        // GraphQL -> partialSlaSummary: [PartialSlaSummary!]! (type)
        [JsonProperty("partialSlaSummary")]
        public List<PartialSlaSummary>? PartialSlaSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PartialSlaSummaries";
    }

    public PartialSlaSummaries Set(
        System.Int32? NumMatchingRows = null,
        List<PartialSlaSummary>? PartialSlaSummary = null
    ) 
    {
        if ( NumMatchingRows != null ) {
            this.NumMatchingRows = NumMatchingRows;
        }
        if ( PartialSlaSummary != null ) {
            this.PartialSlaSummary = PartialSlaSummary;
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
        //      C# -> System.Int32? NumMatchingRows
        // GraphQL -> numMatchingRows: Int! (scalar)
        if (this.NumMatchingRows != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMatchingRows\n" ;
            } else {
                s += ind + "numMatchingRows\n" ;
            }
        }
        //      C# -> List<PartialSlaSummary>? PartialSlaSummary
        // GraphQL -> partialSlaSummary: [PartialSlaSummary!]! (type)
        if (this.PartialSlaSummary != null) {
            var fspec = this.PartialSlaSummary.AsFieldSpec(conf.Child("partialSlaSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "partialSlaSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumMatchingRows
        // GraphQL -> numMatchingRows: Int! (scalar)
        if (ec.Includes("numMatchingRows",true))
        {
            if(this.NumMatchingRows == null) {

                this.NumMatchingRows = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMatchingRows != null && ec.Excludes("numMatchingRows",true))
        {
            this.NumMatchingRows = null;
        }
        //      C# -> List<PartialSlaSummary>? PartialSlaSummary
        // GraphQL -> partialSlaSummary: [PartialSlaSummary!]! (type)
        if (ec.Includes("partialSlaSummary",false))
        {
            if(this.PartialSlaSummary == null) {

                this.PartialSlaSummary = new List<PartialSlaSummary>();
                this.PartialSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("partialSlaSummary"));

            } else {

                this.PartialSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("partialSlaSummary"));

            }
        }
        else if (this.PartialSlaSummary != null && ec.Excludes("partialSlaSummary",false))
        {
            this.PartialSlaSummary = null;
        }
    }


    #endregion

    } // class PartialSlaSummaries
    
    #endregion

    public static class ListPartialSlaSummariesExtensions
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
            this List<PartialSlaSummaries> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PartialSlaSummaries> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PartialSlaSummaries> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PartialSlaSummaries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PartialSlaSummaries> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types