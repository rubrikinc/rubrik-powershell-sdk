// RegionPair.cs
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
    #region RegionPair
    public class RegionPair: BaseType
    {
        #region members

        //      C# -> AzureRegion? Primary
        // GraphQL -> primary: AzureRegion! (enum)
        [JsonProperty("primary")]
        public AzureRegion? Primary { get; set; }

        //      C# -> AzureRegion? Secondary
        // GraphQL -> secondary: AzureRegion! (enum)
        [JsonProperty("secondary")]
        public AzureRegion? Secondary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegionPair";
    }

    public RegionPair Set(
        AzureRegion? Primary = null,
        AzureRegion? Secondary = null
    ) 
    {
        if ( Primary != null ) {
            this.Primary = Primary;
        }
        if ( Secondary != null ) {
            this.Secondary = Secondary;
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
        //      C# -> AzureRegion? Primary
        // GraphQL -> primary: AzureRegion! (enum)
        if (this.Primary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primary\n" ;
            } else {
                s += ind + "primary\n" ;
            }
        }
        //      C# -> AzureRegion? Secondary
        // GraphQL -> secondary: AzureRegion! (enum)
        if (this.Secondary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondary\n" ;
            } else {
                s += ind + "secondary\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureRegion? Primary
        // GraphQL -> primary: AzureRegion! (enum)
        if (ec.Includes("primary",true))
        {
            if(this.Primary == null) {

                this.Primary = new AzureRegion();

            } else {


            }
        }
        else if (this.Primary != null && ec.Excludes("primary",true))
        {
            this.Primary = null;
        }
        //      C# -> AzureRegion? Secondary
        // GraphQL -> secondary: AzureRegion! (enum)
        if (ec.Includes("secondary",true))
        {
            if(this.Secondary == null) {

                this.Secondary = new AzureRegion();

            } else {


            }
        }
        else if (this.Secondary != null && ec.Excludes("secondary",true))
        {
            this.Secondary = null;
        }
    }


    #endregion

    } // class RegionPair
    
    #endregion

    public static class ListRegionPairExtensions
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
            this List<RegionPair> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RegionPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegionPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegionPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegionPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types