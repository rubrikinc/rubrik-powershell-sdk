// CdmLabelSelector.cs
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
    #region CdmLabelSelector
    public class CdmLabelSelector: BaseType
    {
        #region members

        //      C# -> System.String? MatchLabels
        // GraphQL -> matchLabels: String (scalar)
        [JsonProperty("matchLabels")]
        public System.String? MatchLabels { get; set; }

        //      C# -> List<CdmLabelSelectorRequirement>? MatchExpressions
        // GraphQL -> matchExpressions: [CdmLabelSelectorRequirement!]! (type)
        [JsonProperty("matchExpressions")]
        public List<CdmLabelSelectorRequirement>? MatchExpressions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmLabelSelector";
    }

    public CdmLabelSelector Set(
        System.String? MatchLabels = null,
        List<CdmLabelSelectorRequirement>? MatchExpressions = null
    ) 
    {
        if ( MatchLabels != null ) {
            this.MatchLabels = MatchLabels;
        }
        if ( MatchExpressions != null ) {
            this.MatchExpressions = MatchExpressions;
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
        //      C# -> System.String? MatchLabels
        // GraphQL -> matchLabels: String (scalar)
        if (this.MatchLabels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchLabels\n" ;
            } else {
                s += ind + "matchLabels\n" ;
            }
        }
        //      C# -> List<CdmLabelSelectorRequirement>? MatchExpressions
        // GraphQL -> matchExpressions: [CdmLabelSelectorRequirement!]! (type)
        if (this.MatchExpressions != null) {
            var fspec = this.MatchExpressions.AsFieldSpec(conf.Child("matchExpressions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matchExpressions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MatchLabels
        // GraphQL -> matchLabels: String (scalar)
        if (ec.Includes("matchLabels",true))
        {
            if(this.MatchLabels == null) {

                this.MatchLabels = "FETCH";

            } else {


            }
        }
        else if (this.MatchLabels != null && ec.Excludes("matchLabels",true))
        {
            this.MatchLabels = null;
        }
        //      C# -> List<CdmLabelSelectorRequirement>? MatchExpressions
        // GraphQL -> matchExpressions: [CdmLabelSelectorRequirement!]! (type)
        if (ec.Includes("matchExpressions",false))
        {
            if(this.MatchExpressions == null) {

                this.MatchExpressions = new List<CdmLabelSelectorRequirement>();
                this.MatchExpressions.ApplyExploratoryFieldSpec(ec.NewChild("matchExpressions"));

            } else {

                this.MatchExpressions.ApplyExploratoryFieldSpec(ec.NewChild("matchExpressions"));

            }
        }
        else if (this.MatchExpressions != null && ec.Excludes("matchExpressions",false))
        {
            this.MatchExpressions = null;
        }
    }


    #endregion

    } // class CdmLabelSelector
    
    #endregion

    public static class ListCdmLabelSelectorExtensions
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
            this List<CdmLabelSelector> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmLabelSelector> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmLabelSelector> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmLabelSelector());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmLabelSelector> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types