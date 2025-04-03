// MicrosoftMipLabel.cs
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
    #region MicrosoftMipLabel
    public class MicrosoftMipLabel: BaseType
    {
        #region members

        //      C# -> System.String? Color
        // GraphQL -> color: String! (scalar)
        [JsonProperty("color")]
        public System.String? Color { get; set; }

        //      C# -> List<System.String>? ContentFormats
        // GraphQL -> contentFormats: [String!]! (scalar)
        [JsonProperty("contentFormats")]
        public List<System.String>? ContentFormats { get; set; }

        //      C# -> System.String? DescriptionForAdmins
        // GraphQL -> descriptionForAdmins: String! (scalar)
        [JsonProperty("descriptionForAdmins")]
        public System.String? DescriptionForAdmins { get; set; }

        //      C# -> System.String? DescriptionForUsers
        // GraphQL -> descriptionForUsers: String! (scalar)
        [JsonProperty("descriptionForUsers")]
        public System.String? DescriptionForUsers { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? HasProtection
        // GraphQL -> hasProtection: Boolean! (scalar)
        [JsonProperty("hasProtection")]
        public System.Boolean? HasProtection { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsAppliable
        // GraphQL -> isAppliable: Boolean! (scalar)
        [JsonProperty("isAppliable")]
        public System.Boolean? IsAppliable { get; set; }

        //      C# -> System.String? LabelId
        // GraphQL -> labelId: String! (scalar)
        [JsonProperty("labelId")]
        public System.String? LabelId { get; set; }

        //      C# -> System.String? ParentLabelId
        // GraphQL -> parentLabelId: String! (scalar)
        [JsonProperty("parentLabelId")]
        public System.String? ParentLabelId { get; set; }

        //      C# -> System.Int32? Sensitivity
        // GraphQL -> sensitivity: Int! (scalar)
        [JsonProperty("sensitivity")]
        public System.Int32? Sensitivity { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> ParentLabelInfo? ParentInfo
        // GraphQL -> parentInfo: ParentLabelInfo (type)
        [JsonProperty("parentInfo")]
        public ParentLabelInfo? ParentInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MicrosoftMipLabel";
    }

    public MicrosoftMipLabel Set(
        System.String? Color = null,
        List<System.String>? ContentFormats = null,
        System.String? DescriptionForAdmins = null,
        System.String? DescriptionForUsers = null,
        System.String? DisplayName = null,
        System.Boolean? HasProtection = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsAppliable = null,
        System.String? LabelId = null,
        System.String? ParentLabelId = null,
        System.Int32? Sensitivity = null,
        System.String? TenantId = null,
        ParentLabelInfo? ParentInfo = null
    ) 
    {
        if ( Color != null ) {
            this.Color = Color;
        }
        if ( ContentFormats != null ) {
            this.ContentFormats = ContentFormats;
        }
        if ( DescriptionForAdmins != null ) {
            this.DescriptionForAdmins = DescriptionForAdmins;
        }
        if ( DescriptionForUsers != null ) {
            this.DescriptionForUsers = DescriptionForUsers;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( HasProtection != null ) {
            this.HasProtection = HasProtection;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsAppliable != null ) {
            this.IsAppliable = IsAppliable;
        }
        if ( LabelId != null ) {
            this.LabelId = LabelId;
        }
        if ( ParentLabelId != null ) {
            this.ParentLabelId = ParentLabelId;
        }
        if ( Sensitivity != null ) {
            this.Sensitivity = Sensitivity;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( ParentInfo != null ) {
            this.ParentInfo = ParentInfo;
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
        //      C# -> System.String? Color
        // GraphQL -> color: String! (scalar)
        if (this.Color != null) {
            if (conf.Flat) {
                s += conf.Prefix + "color\n" ;
            } else {
                s += ind + "color\n" ;
            }
        }
        //      C# -> List<System.String>? ContentFormats
        // GraphQL -> contentFormats: [String!]! (scalar)
        if (this.ContentFormats != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contentFormats\n" ;
            } else {
                s += ind + "contentFormats\n" ;
            }
        }
        //      C# -> System.String? DescriptionForAdmins
        // GraphQL -> descriptionForAdmins: String! (scalar)
        if (this.DescriptionForAdmins != null) {
            if (conf.Flat) {
                s += conf.Prefix + "descriptionForAdmins\n" ;
            } else {
                s += ind + "descriptionForAdmins\n" ;
            }
        }
        //      C# -> System.String? DescriptionForUsers
        // GraphQL -> descriptionForUsers: String! (scalar)
        if (this.DescriptionForUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "descriptionForUsers\n" ;
            } else {
                s += ind + "descriptionForUsers\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Boolean? HasProtection
        // GraphQL -> hasProtection: Boolean! (scalar)
        if (this.HasProtection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasProtection\n" ;
            } else {
                s += ind + "hasProtection\n" ;
            }
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsAppliable
        // GraphQL -> isAppliable: Boolean! (scalar)
        if (this.IsAppliable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAppliable\n" ;
            } else {
                s += ind + "isAppliable\n" ;
            }
        }
        //      C# -> System.String? LabelId
        // GraphQL -> labelId: String! (scalar)
        if (this.LabelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labelId\n" ;
            } else {
                s += ind + "labelId\n" ;
            }
        }
        //      C# -> System.String? ParentLabelId
        // GraphQL -> parentLabelId: String! (scalar)
        if (this.ParentLabelId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentLabelId\n" ;
            } else {
                s += ind + "parentLabelId\n" ;
            }
        }
        //      C# -> System.Int32? Sensitivity
        // GraphQL -> sensitivity: Int! (scalar)
        if (this.Sensitivity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sensitivity\n" ;
            } else {
                s += ind + "sensitivity\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        //      C# -> ParentLabelInfo? ParentInfo
        // GraphQL -> parentInfo: ParentLabelInfo (type)
        if (this.ParentInfo != null) {
            var fspec = this.ParentInfo.AsFieldSpec(conf.Child("parentInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "parentInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Color
        // GraphQL -> color: String! (scalar)
        if (ec.Includes("color",true))
        {
            if(this.Color == null) {

                this.Color = "FETCH";

            } else {


            }
        }
        else if (this.Color != null && ec.Excludes("color",true))
        {
            this.Color = null;
        }
        //      C# -> List<System.String>? ContentFormats
        // GraphQL -> contentFormats: [String!]! (scalar)
        if (ec.Includes("contentFormats",true))
        {
            if(this.ContentFormats == null) {

                this.ContentFormats = new List<System.String>();

            } else {


            }
        }
        else if (this.ContentFormats != null && ec.Excludes("contentFormats",true))
        {
            this.ContentFormats = null;
        }
        //      C# -> System.String? DescriptionForAdmins
        // GraphQL -> descriptionForAdmins: String! (scalar)
        if (ec.Includes("descriptionForAdmins",true))
        {
            if(this.DescriptionForAdmins == null) {

                this.DescriptionForAdmins = "FETCH";

            } else {


            }
        }
        else if (this.DescriptionForAdmins != null && ec.Excludes("descriptionForAdmins",true))
        {
            this.DescriptionForAdmins = null;
        }
        //      C# -> System.String? DescriptionForUsers
        // GraphQL -> descriptionForUsers: String! (scalar)
        if (ec.Includes("descriptionForUsers",true))
        {
            if(this.DescriptionForUsers == null) {

                this.DescriptionForUsers = "FETCH";

            } else {


            }
        }
        else if (this.DescriptionForUsers != null && ec.Excludes("descriptionForUsers",true))
        {
            this.DescriptionForUsers = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Boolean? HasProtection
        // GraphQL -> hasProtection: Boolean! (scalar)
        if (ec.Includes("hasProtection",true))
        {
            if(this.HasProtection == null) {

                this.HasProtection = true;

            } else {


            }
        }
        else if (this.HasProtection != null && ec.Excludes("hasProtection",true))
        {
            this.HasProtection = null;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> System.Boolean? IsAppliable
        // GraphQL -> isAppliable: Boolean! (scalar)
        if (ec.Includes("isAppliable",true))
        {
            if(this.IsAppliable == null) {

                this.IsAppliable = true;

            } else {


            }
        }
        else if (this.IsAppliable != null && ec.Excludes("isAppliable",true))
        {
            this.IsAppliable = null;
        }
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
        //      C# -> System.String? ParentLabelId
        // GraphQL -> parentLabelId: String! (scalar)
        if (ec.Includes("parentLabelId",true))
        {
            if(this.ParentLabelId == null) {

                this.ParentLabelId = "FETCH";

            } else {


            }
        }
        else if (this.ParentLabelId != null && ec.Excludes("parentLabelId",true))
        {
            this.ParentLabelId = null;
        }
        //      C# -> System.Int32? Sensitivity
        // GraphQL -> sensitivity: Int! (scalar)
        if (ec.Includes("sensitivity",true))
        {
            if(this.Sensitivity == null) {

                this.Sensitivity = Int32.MinValue;

            } else {


            }
        }
        else if (this.Sensitivity != null && ec.Excludes("sensitivity",true))
        {
            this.Sensitivity = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
        //      C# -> ParentLabelInfo? ParentInfo
        // GraphQL -> parentInfo: ParentLabelInfo (type)
        if (ec.Includes("parentInfo",false))
        {
            if(this.ParentInfo == null) {

                this.ParentInfo = new ParentLabelInfo();
                this.ParentInfo.ApplyExploratoryFieldSpec(ec.NewChild("parentInfo"));

            } else {

                this.ParentInfo.ApplyExploratoryFieldSpec(ec.NewChild("parentInfo"));

            }
        }
        else if (this.ParentInfo != null && ec.Excludes("parentInfo",false))
        {
            this.ParentInfo = null;
        }
    }


    #endregion

    } // class MicrosoftMipLabel
    
    #endregion

    public static class ListMicrosoftMipLabelExtensions
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
            this List<MicrosoftMipLabel> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MicrosoftMipLabel> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MicrosoftMipLabel> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MicrosoftMipLabel());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MicrosoftMipLabel> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types