// EntraIdRoleProperties.cs
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
    #region EntraIdRoleProperties
 
    public class EntraIdRoleProperties: BaseType, PrincipalMetadata
    {
        #region members

        //      C# -> EntraIdRoleType? Type
        // GraphQL -> type: EntraIDRoleType! (enum)
        [JsonProperty("type")]
        public EntraIdRoleType? Type { get; set; }

        //      C# -> System.Boolean? HasRiskyPermissions
        // GraphQL -> hasRiskyPermissions: Boolean! (scalar)
        [JsonProperty("hasRiskyPermissions")]
        public System.Boolean? HasRiskyPermissions { get; set; }

        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        [JsonProperty("isPrivileged")]
        public System.Boolean? IsPrivileged { get; set; }

        //      C# -> System.String? RoleDescription
        // GraphQL -> roleDescription: String! (scalar)
        [JsonProperty("roleDescription")]
        public System.String? RoleDescription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDRoleProperties";
    }

    public EntraIdRoleProperties Set(
        EntraIdRoleType? Type = null,
        System.Boolean? HasRiskyPermissions = null,
        System.Boolean? IsPrivileged = null,
        System.String? RoleDescription = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( HasRiskyPermissions != null ) {
            this.HasRiskyPermissions = HasRiskyPermissions;
        }
        if ( IsPrivileged != null ) {
            this.IsPrivileged = IsPrivileged;
        }
        if ( RoleDescription != null ) {
            this.RoleDescription = RoleDescription;
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
        //      C# -> EntraIdRoleType? Type
        // GraphQL -> type: EntraIDRoleType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.Boolean? HasRiskyPermissions
        // GraphQL -> hasRiskyPermissions: Boolean! (scalar)
        if (this.HasRiskyPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasRiskyPermissions\n" ;
            } else {
                s += ind + "hasRiskyPermissions\n" ;
            }
        }
        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        if (this.IsPrivileged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPrivileged\n" ;
            } else {
                s += ind + "isPrivileged\n" ;
            }
        }
        //      C# -> System.String? RoleDescription
        // GraphQL -> roleDescription: String! (scalar)
        if (this.RoleDescription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDescription\n" ;
            } else {
                s += ind + "roleDescription\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdRoleType? Type
        // GraphQL -> type: EntraIDRoleType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new EntraIdRoleType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.Boolean? HasRiskyPermissions
        // GraphQL -> hasRiskyPermissions: Boolean! (scalar)
        if (ec.Includes("hasRiskyPermissions",true))
        {
            if(this.HasRiskyPermissions == null) {

                this.HasRiskyPermissions = true;

            } else {


            }
        }
        else if (this.HasRiskyPermissions != null && ec.Excludes("hasRiskyPermissions",true))
        {
            this.HasRiskyPermissions = null;
        }
        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        if (ec.Includes("isPrivileged",true))
        {
            if(this.IsPrivileged == null) {

                this.IsPrivileged = true;

            } else {


            }
        }
        else if (this.IsPrivileged != null && ec.Excludes("isPrivileged",true))
        {
            this.IsPrivileged = null;
        }
        //      C# -> System.String? RoleDescription
        // GraphQL -> roleDescription: String! (scalar)
        if (ec.Includes("roleDescription",true))
        {
            if(this.RoleDescription == null) {

                this.RoleDescription = "FETCH";

            } else {


            }
        }
        else if (this.RoleDescription != null && ec.Excludes("roleDescription",true))
        {
            this.RoleDescription = null;
        }
    }


    #endregion

    } // class EntraIdRoleProperties
    
    #endregion

    public static class ListEntraIdRolePropertiesExtensions
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
            this List<EntraIdRoleProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdRoleProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdRoleProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdRoleProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdRoleProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types