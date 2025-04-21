// UpgradeStatusV2.cs
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
    #region UpgradeStatusV2
    public class UpgradeStatusV2: BaseType
    {
        #region members

        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        [JsonProperty("rscClusterUpgradeStatus")]
        public RscUpgradeStatusType? RscClusterUpgradeStatus { get; set; }

        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        [JsonProperty("uiStatus")]
        public System.String? UiStatus { get; set; }

        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes! (type)
        [JsonProperty("uiStatusAttributes")]
        public UiStatusAttributes? UiStatusAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeStatusV2";
    }

    public UpgradeStatusV2 Set(
        RscUpgradeStatusType? RscClusterUpgradeStatus = null,
        System.String? UiStatus = null,
        UiStatusAttributes? UiStatusAttributes = null
    ) 
    {
        if ( RscClusterUpgradeStatus != null ) {
            this.RscClusterUpgradeStatus = RscClusterUpgradeStatus;
        }
        if ( UiStatus != null ) {
            this.UiStatus = UiStatus;
        }
        if ( UiStatusAttributes != null ) {
            this.UiStatusAttributes = UiStatusAttributes;
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
        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        if (this.RscClusterUpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscClusterUpgradeStatus\n" ;
            } else {
                s += ind + "rscClusterUpgradeStatus\n" ;
            }
        }
        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        if (this.UiStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uiStatus\n" ;
            } else {
                s += ind + "uiStatus\n" ;
            }
        }
        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes! (type)
        if (this.UiStatusAttributes != null) {
            var fspec = this.UiStatusAttributes.AsFieldSpec(conf.Child("uiStatusAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "uiStatusAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RscUpgradeStatusType? RscClusterUpgradeStatus
        // GraphQL -> rscClusterUpgradeStatus: RscUpgradeStatusType! (enum)
        if (ec.Includes("rscClusterUpgradeStatus",true))
        {
            if(this.RscClusterUpgradeStatus == null) {

                this.RscClusterUpgradeStatus = new RscUpgradeStatusType();

            } else {


            }
        }
        else if (this.RscClusterUpgradeStatus != null && ec.Excludes("rscClusterUpgradeStatus",true))
        {
            this.RscClusterUpgradeStatus = null;
        }
        //      C# -> System.String? UiStatus
        // GraphQL -> uiStatus: String! (scalar)
        if (ec.Includes("uiStatus",true))
        {
            if(this.UiStatus == null) {

                this.UiStatus = "FETCH";

            } else {


            }
        }
        else if (this.UiStatus != null && ec.Excludes("uiStatus",true))
        {
            this.UiStatus = null;
        }
        //      C# -> UiStatusAttributes? UiStatusAttributes
        // GraphQL -> uiStatusAttributes: UiStatusAttributes! (type)
        if (ec.Includes("uiStatusAttributes",false))
        {
            if(this.UiStatusAttributes == null) {

                this.UiStatusAttributes = new UiStatusAttributes();
                this.UiStatusAttributes.ApplyExploratoryFieldSpec(ec.NewChild("uiStatusAttributes"));

            } else {

                this.UiStatusAttributes.ApplyExploratoryFieldSpec(ec.NewChild("uiStatusAttributes"));

            }
        }
        else if (this.UiStatusAttributes != null && ec.Excludes("uiStatusAttributes",false))
        {
            this.UiStatusAttributes = null;
        }
    }


    #endregion

    } // class UpgradeStatusV2
    
    #endregion

    public static class ListUpgradeStatusV2Extensions
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
            this List<UpgradeStatusV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeStatusV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeStatusV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeStatusV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeStatusV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types