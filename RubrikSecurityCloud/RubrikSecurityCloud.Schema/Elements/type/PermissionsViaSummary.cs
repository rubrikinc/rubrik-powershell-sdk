// PermissionsViaSummary.cs
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
    #region PermissionsViaSummary
    public class PermissionsViaSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDirectExists
        // GraphQL -> isDirectExists: Boolean! (scalar)
        [JsonProperty("isDirectExists")]
        public System.Boolean? IsDirectExists { get; set; }

        //      C# -> List<PermissionsPrincipal>? Groups
        // GraphQL -> groups: [PermissionsPrincipal!]! (type)
        [JsonProperty("groups")]
        public List<PermissionsPrincipal>? Groups { get; set; }

        //      C# -> List<PermissionsPrincipal>? Roles
        // GraphQL -> roles: [PermissionsPrincipal!]! (type)
        [JsonProperty("roles")]
        public List<PermissionsPrincipal>? Roles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PermissionsViaSummary";
    }

    public PermissionsViaSummary Set(
        System.Boolean? IsDirectExists = null,
        List<PermissionsPrincipal>? Groups = null,
        List<PermissionsPrincipal>? Roles = null
    ) 
    {
        if ( IsDirectExists != null ) {
            this.IsDirectExists = IsDirectExists;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
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
        //      C# -> System.Boolean? IsDirectExists
        // GraphQL -> isDirectExists: Boolean! (scalar)
        if (this.IsDirectExists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDirectExists\n" ;
            } else {
                s += ind + "isDirectExists\n" ;
            }
        }
        //      C# -> List<PermissionsPrincipal>? Groups
        // GraphQL -> groups: [PermissionsPrincipal!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PermissionsPrincipal>? Roles
        // GraphQL -> roles: [PermissionsPrincipal!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDirectExists
        // GraphQL -> isDirectExists: Boolean! (scalar)
        if (ec.Includes("isDirectExists",true))
        {
            if(this.IsDirectExists == null) {

                this.IsDirectExists = true;

            } else {


            }
        }
        else if (this.IsDirectExists != null && ec.Excludes("isDirectExists",true))
        {
            this.IsDirectExists = null;
        }
        //      C# -> List<PermissionsPrincipal>? Groups
        // GraphQL -> groups: [PermissionsPrincipal!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<PermissionsPrincipal>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
        //      C# -> List<PermissionsPrincipal>? Roles
        // GraphQL -> roles: [PermissionsPrincipal!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<PermissionsPrincipal>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
    }


    #endregion

    } // class PermissionsViaSummary
    
    #endregion

    public static class ListPermissionsViaSummaryExtensions
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
            this List<PermissionsViaSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PermissionsViaSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PermissionsViaSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PermissionsViaSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PermissionsViaSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types