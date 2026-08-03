// AdAttributeSchemaMetadata.cs
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
    #region AdAttributeSchemaMetadata
 
    public class AdAttributeSchemaMetadata: BaseType, OnPremAdPrincipalTypeSpecificMetadata
    {
        #region members

        //      C# -> System.String? AdminDisplayName
        // GraphQL -> adminDisplayName: String! (scalar)
        [JsonProperty("adminDisplayName")]
        public System.String? AdminDisplayName { get; set; }

        //      C# -> System.String? AttrId
        // GraphQL -> attrId: String! (scalar)
        [JsonProperty("attrId")]
        public System.String? AttrId { get; set; }

        //      C# -> System.String? LdapName
        // GraphQL -> ldapName: String! (scalar)
        [JsonProperty("ldapName")]
        public System.String? LdapName { get; set; }

        //      C# -> System.String? OmSyntax
        // GraphQL -> omSyntax: String! (scalar)
        [JsonProperty("omSyntax")]
        public System.String? OmSyntax { get; set; }

        //      C# -> System.String? Syntax
        // GraphQL -> syntax: String! (scalar)
        [JsonProperty("syntax")]
        public System.String? Syntax { get; set; }

        //      C# -> System.String? SystemFlags
        // GraphQL -> systemFlags: String! (scalar)
        [JsonProperty("systemFlags")]
        public System.String? SystemFlags { get; set; }

        //      C# -> System.Boolean? SystemOnly
        // GraphQL -> systemOnly: Boolean! (scalar)
        [JsonProperty("systemOnly")]
        public System.Boolean? SystemOnly { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdAttributeSchemaMetadata";
    }

    public AdAttributeSchemaMetadata Set(
        System.String? AdminDisplayName = null,
        System.String? AttrId = null,
        System.String? LdapName = null,
        System.String? OmSyntax = null,
        System.String? Syntax = null,
        System.String? SystemFlags = null,
        System.Boolean? SystemOnly = null
    ) 
    {
        if ( AdminDisplayName != null ) {
            this.AdminDisplayName = AdminDisplayName;
        }
        if ( AttrId != null ) {
            this.AttrId = AttrId;
        }
        if ( LdapName != null ) {
            this.LdapName = LdapName;
        }
        if ( OmSyntax != null ) {
            this.OmSyntax = OmSyntax;
        }
        if ( Syntax != null ) {
            this.Syntax = Syntax;
        }
        if ( SystemFlags != null ) {
            this.SystemFlags = SystemFlags;
        }
        if ( SystemOnly != null ) {
            this.SystemOnly = SystemOnly;
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
        //      C# -> System.String? AdminDisplayName
        // GraphQL -> adminDisplayName: String! (scalar)
        if (this.AdminDisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adminDisplayName\n" ;
            } else {
                s += ind + "adminDisplayName\n" ;
            }
        }
        //      C# -> System.String? AttrId
        // GraphQL -> attrId: String! (scalar)
        if (this.AttrId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attrId\n" ;
            } else {
                s += ind + "attrId\n" ;
            }
        }
        //      C# -> System.String? LdapName
        // GraphQL -> ldapName: String! (scalar)
        if (this.LdapName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ldapName\n" ;
            } else {
                s += ind + "ldapName\n" ;
            }
        }
        //      C# -> System.String? OmSyntax
        // GraphQL -> omSyntax: String! (scalar)
        if (this.OmSyntax != null) {
            if (conf.Flat) {
                s += conf.Prefix + "omSyntax\n" ;
            } else {
                s += ind + "omSyntax\n" ;
            }
        }
        //      C# -> System.String? Syntax
        // GraphQL -> syntax: String! (scalar)
        if (this.Syntax != null) {
            if (conf.Flat) {
                s += conf.Prefix + "syntax\n" ;
            } else {
                s += ind + "syntax\n" ;
            }
        }
        //      C# -> System.String? SystemFlags
        // GraphQL -> systemFlags: String! (scalar)
        if (this.SystemFlags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemFlags\n" ;
            } else {
                s += ind + "systemFlags\n" ;
            }
        }
        //      C# -> System.Boolean? SystemOnly
        // GraphQL -> systemOnly: Boolean! (scalar)
        if (this.SystemOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemOnly\n" ;
            } else {
                s += ind + "systemOnly\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AdminDisplayName
        // GraphQL -> adminDisplayName: String! (scalar)
        if (ec.Includes("adminDisplayName",true))
        {
            if(this.AdminDisplayName == null) {

                this.AdminDisplayName = "FETCH";

            } else {


            }
        }
        else if (this.AdminDisplayName != null && ec.Excludes("adminDisplayName",true))
        {
            this.AdminDisplayName = null;
        }
        //      C# -> System.String? AttrId
        // GraphQL -> attrId: String! (scalar)
        if (ec.Includes("attrId",true))
        {
            if(this.AttrId == null) {

                this.AttrId = "FETCH";

            } else {


            }
        }
        else if (this.AttrId != null && ec.Excludes("attrId",true))
        {
            this.AttrId = null;
        }
        //      C# -> System.String? LdapName
        // GraphQL -> ldapName: String! (scalar)
        if (ec.Includes("ldapName",true))
        {
            if(this.LdapName == null) {

                this.LdapName = "FETCH";

            } else {


            }
        }
        else if (this.LdapName != null && ec.Excludes("ldapName",true))
        {
            this.LdapName = null;
        }
        //      C# -> System.String? OmSyntax
        // GraphQL -> omSyntax: String! (scalar)
        if (ec.Includes("omSyntax",true))
        {
            if(this.OmSyntax == null) {

                this.OmSyntax = "FETCH";

            } else {


            }
        }
        else if (this.OmSyntax != null && ec.Excludes("omSyntax",true))
        {
            this.OmSyntax = null;
        }
        //      C# -> System.String? Syntax
        // GraphQL -> syntax: String! (scalar)
        if (ec.Includes("syntax",true))
        {
            if(this.Syntax == null) {

                this.Syntax = "FETCH";

            } else {


            }
        }
        else if (this.Syntax != null && ec.Excludes("syntax",true))
        {
            this.Syntax = null;
        }
        //      C# -> System.String? SystemFlags
        // GraphQL -> systemFlags: String! (scalar)
        if (ec.Includes("systemFlags",true))
        {
            if(this.SystemFlags == null) {

                this.SystemFlags = "FETCH";

            } else {


            }
        }
        else if (this.SystemFlags != null && ec.Excludes("systemFlags",true))
        {
            this.SystemFlags = null;
        }
        //      C# -> System.Boolean? SystemOnly
        // GraphQL -> systemOnly: Boolean! (scalar)
        if (ec.Includes("systemOnly",true))
        {
            if(this.SystemOnly == null) {

                this.SystemOnly = true;

            } else {


            }
        }
        else if (this.SystemOnly != null && ec.Excludes("systemOnly",true))
        {
            this.SystemOnly = null;
        }
    }


    #endregion

    } // class AdAttributeSchemaMetadata
    
    #endregion

    public static class ListAdAttributeSchemaMetadataExtensions
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
            this List<AdAttributeSchemaMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdAttributeSchemaMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdAttributeSchemaMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdAttributeSchemaMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdAttributeSchemaMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types