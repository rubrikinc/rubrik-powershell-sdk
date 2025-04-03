// O365GroupsSummary.cs
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
    #region O365GroupsSummary
    public class O365GroupsSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? AdGroupsCount
        // GraphQL -> adGroupsCount: Int! (scalar)
        [JsonProperty("adGroupsCount")]
        public System.Int32? AdGroupsCount { get; set; }

        //      C# -> System.Int32? ConfiguredGroupsCount
        // GraphQL -> configuredGroupsCount: Int! (scalar)
        [JsonProperty("configuredGroupsCount")]
        public System.Int32? ConfiguredGroupsCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365GroupsSummary";
    }

    public O365GroupsSummary Set(
        System.Int32? AdGroupsCount = null,
        System.Int32? ConfiguredGroupsCount = null
    ) 
    {
        if ( AdGroupsCount != null ) {
            this.AdGroupsCount = AdGroupsCount;
        }
        if ( ConfiguredGroupsCount != null ) {
            this.ConfiguredGroupsCount = ConfiguredGroupsCount;
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
        //      C# -> System.Int32? AdGroupsCount
        // GraphQL -> adGroupsCount: Int! (scalar)
        if (this.AdGroupsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adGroupsCount\n" ;
            } else {
                s += ind + "adGroupsCount\n" ;
            }
        }
        //      C# -> System.Int32? ConfiguredGroupsCount
        // GraphQL -> configuredGroupsCount: Int! (scalar)
        if (this.ConfiguredGroupsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredGroupsCount\n" ;
            } else {
                s += ind + "configuredGroupsCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? AdGroupsCount
        // GraphQL -> adGroupsCount: Int! (scalar)
        if (ec.Includes("adGroupsCount",true))
        {
            if(this.AdGroupsCount == null) {

                this.AdGroupsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AdGroupsCount != null && ec.Excludes("adGroupsCount",true))
        {
            this.AdGroupsCount = null;
        }
        //      C# -> System.Int32? ConfiguredGroupsCount
        // GraphQL -> configuredGroupsCount: Int! (scalar)
        if (ec.Includes("configuredGroupsCount",true))
        {
            if(this.ConfiguredGroupsCount == null) {

                this.ConfiguredGroupsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ConfiguredGroupsCount != null && ec.Excludes("configuredGroupsCount",true))
        {
            this.ConfiguredGroupsCount = null;
        }
    }


    #endregion

    } // class O365GroupsSummary
    
    #endregion

    public static class ListO365GroupsSummaryExtensions
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
            this List<O365GroupsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365GroupsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365GroupsSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365GroupsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365GroupsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types