// HuntScanPathFilters.cs
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
    #region HuntScanPathFilters
    public class HuntScanPathFilters: BaseType
    {
        #region members

        //      C# -> List<System.String>? Exclusions
        // GraphQL -> exclusions: [String!]! (scalar)
        [JsonProperty("exclusions")]
        public List<System.String>? Exclusions { get; set; }

        //      C# -> List<System.String>? Exemptions
        // GraphQL -> exemptions: [String!]! (scalar)
        [JsonProperty("exemptions")]
        public List<System.String>? Exemptions { get; set; }

        //      C# -> List<System.String>? Inclusions
        // GraphQL -> inclusions: [String!]! (scalar)
        [JsonProperty("inclusions")]
        public List<System.String>? Inclusions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HuntScanPathFilters";
    }

    public HuntScanPathFilters Set(
        List<System.String>? Exclusions = null,
        List<System.String>? Exemptions = null,
        List<System.String>? Inclusions = null
    ) 
    {
        if ( Exclusions != null ) {
            this.Exclusions = Exclusions;
        }
        if ( Exemptions != null ) {
            this.Exemptions = Exemptions;
        }
        if ( Inclusions != null ) {
            this.Inclusions = Inclusions;
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
        //      C# -> List<System.String>? Exclusions
        // GraphQL -> exclusions: [String!]! (scalar)
        if (this.Exclusions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exclusions\n" ;
            } else {
                s += ind + "exclusions\n" ;
            }
        }
        //      C# -> List<System.String>? Exemptions
        // GraphQL -> exemptions: [String!]! (scalar)
        if (this.Exemptions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exemptions\n" ;
            } else {
                s += ind + "exemptions\n" ;
            }
        }
        //      C# -> List<System.String>? Inclusions
        // GraphQL -> inclusions: [String!]! (scalar)
        if (this.Inclusions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inclusions\n" ;
            } else {
                s += ind + "inclusions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Exclusions
        // GraphQL -> exclusions: [String!]! (scalar)
        if (ec.Includes("exclusions",true))
        {
            if(this.Exclusions == null) {

                this.Exclusions = new List<System.String>();

            } else {


            }
        }
        else if (this.Exclusions != null && ec.Excludes("exclusions",true))
        {
            this.Exclusions = null;
        }
        //      C# -> List<System.String>? Exemptions
        // GraphQL -> exemptions: [String!]! (scalar)
        if (ec.Includes("exemptions",true))
        {
            if(this.Exemptions == null) {

                this.Exemptions = new List<System.String>();

            } else {


            }
        }
        else if (this.Exemptions != null && ec.Excludes("exemptions",true))
        {
            this.Exemptions = null;
        }
        //      C# -> List<System.String>? Inclusions
        // GraphQL -> inclusions: [String!]! (scalar)
        if (ec.Includes("inclusions",true))
        {
            if(this.Inclusions == null) {

                this.Inclusions = new List<System.String>();

            } else {


            }
        }
        else if (this.Inclusions != null && ec.Excludes("inclusions",true))
        {
            this.Inclusions = null;
        }
    }


    #endregion

    } // class HuntScanPathFilters
    
    #endregion

    public static class ListHuntScanPathFiltersExtensions
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
            this List<HuntScanPathFilters> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HuntScanPathFilters> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HuntScanPathFilters> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HuntScanPathFilters());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HuntScanPathFilters> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types