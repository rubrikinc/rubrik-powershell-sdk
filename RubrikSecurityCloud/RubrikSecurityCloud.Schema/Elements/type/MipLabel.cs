// MipLabel.cs
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
    #region MipLabel
    public class MipLabel: BaseType
    {
        #region members

        //      C# -> System.String? LabelId
        // GraphQL -> labelId: String! (scalar)
        [JsonProperty("labelId")]
        public System.String? LabelId { get; set; }

        //      C# -> System.String? LabelName
        // GraphQL -> labelName: String! (scalar)
        [JsonProperty("labelName")]
        public System.String? LabelName { get; set; }

        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        [JsonProperty("siteId")]
        public System.String? SiteId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MipLabel";
    }

    public MipLabel Set(
        System.String? LabelId = null,
        System.String? LabelName = null,
        System.String? SiteId = null
    ) 
    {
        if ( LabelId != null ) {
            this.LabelId = LabelId;
        }
        if ( LabelName != null ) {
            this.LabelName = LabelName;
        }
        if ( SiteId != null ) {
            this.SiteId = SiteId;
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
        //      C# -> System.String? LabelId
        // GraphQL -> labelId: String! (scalar)
        if (this.LabelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labelId\n" ;
            } else {
                s += ind + "labelId\n" ;
            }
        }
        //      C# -> System.String? LabelName
        // GraphQL -> labelName: String! (scalar)
        if (this.LabelName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labelName\n" ;
            } else {
                s += ind + "labelName\n" ;
            }
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (this.SiteId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "siteId\n" ;
            } else {
                s += ind + "siteId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LabelId
        // GraphQL -> labelId: String! (scalar)
        if (ec.Includes("labelId",true))
        {
            if(this.LabelId == null) {

                this.LabelId = "FETCH";

            } else {


            }
        }
        else if (this.LabelId != null && ec.Excludes("labelId",true))
        {
            this.LabelId = null;
        }
        //      C# -> System.String? LabelName
        // GraphQL -> labelName: String! (scalar)
        if (ec.Includes("labelName",true))
        {
            if(this.LabelName == null) {

                this.LabelName = "FETCH";

            } else {


            }
        }
        else if (this.LabelName != null && ec.Excludes("labelName",true))
        {
            this.LabelName = null;
        }
        //      C# -> System.String? SiteId
        // GraphQL -> siteId: String! (scalar)
        if (ec.Includes("siteId",true))
        {
            if(this.SiteId == null) {

                this.SiteId = "FETCH";

            } else {


            }
        }
        else if (this.SiteId != null && ec.Excludes("siteId",true))
        {
            this.SiteId = null;
        }
    }


    #endregion

    } // class MipLabel
    
    #endregion

    public static class ListMipLabelExtensions
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
            this List<MipLabel> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MipLabel> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MipLabel> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MipLabel());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MipLabel> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types