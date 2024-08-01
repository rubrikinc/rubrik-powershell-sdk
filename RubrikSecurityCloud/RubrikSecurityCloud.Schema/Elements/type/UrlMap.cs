// UrlMap.cs
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
    #region UrlMap
    public class UrlMap: BaseType
    {
        #region members

        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        [JsonProperty("urlName")]
        public UrlName? UrlName { get; set; }

        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        [JsonProperty("displayText")]
        public System.String? DisplayText { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UrlMap";
    }

    public UrlMap Set(
        UrlName? UrlName = null,
        System.String? DisplayText = null
    ) 
    {
        if ( UrlName != null ) {
            this.UrlName = UrlName;
        }
        if ( DisplayText != null ) {
            this.DisplayText = DisplayText;
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
        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        if (this.UrlName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "urlName\n" ;
            } else {
                s += ind + "urlName\n" ;
            }
        }
        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        if (this.DisplayText != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayText\n" ;
            } else {
                s += ind + "displayText\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UrlName? UrlName
        // GraphQL -> urlName: UrlName! (enum)
        if (ec.Includes("urlName",true))
        {
            if(this.UrlName == null) {

                this.UrlName = new UrlName();

            } else {


            }
        }
        else if (this.UrlName != null && ec.Excludes("urlName",true))
        {
            this.UrlName = null;
        }
        //      C# -> System.String? DisplayText
        // GraphQL -> displayText: String! (scalar)
        if (ec.Includes("displayText",true))
        {
            if(this.DisplayText == null) {

                this.DisplayText = "FETCH";

            } else {


            }
        }
        else if (this.DisplayText != null && ec.Excludes("displayText",true))
        {
            this.DisplayText = null;
        }
    }


    #endregion

    } // class UrlMap
    
    #endregion

    public static class ListUrlMapExtensions
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
            this List<UrlMap> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UrlMap> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UrlMap> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UrlMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UrlMap> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types