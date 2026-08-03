// PrincipalApiPermissionGrant.cs
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
    #region PrincipalApiPermissionGrant
    public class PrincipalApiPermissionGrant: BaseType
    {
        #region members

        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        [JsonProperty("creationDate")]
        public DateTime? CreationDate { get; set; }

        //      C# -> System.String? Identifier
        // GraphQL -> identifier: String! (scalar)
        [JsonProperty("identifier")]
        public System.String? Identifier { get; set; }

        //      C# -> System.Boolean? IsPrivileged
        // GraphQL -> isPrivileged: Boolean! (scalar)
        [JsonProperty("isPrivileged")]
        public System.Boolean? IsPrivileged { get; set; }

        //      C# -> System.String? Permission
        // GraphQL -> permission: String! (scalar)
        [JsonProperty("permission")]
        public System.String? Permission { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalAPIPermissionGrant";
    }

    public PrincipalApiPermissionGrant Set(
        DateTime? CreationDate = null,
        System.String? Identifier = null,
        System.Boolean? IsPrivileged = null,
        System.String? Permission = null
    ) 
    {
        if ( CreationDate != null ) {
            this.CreationDate = CreationDate;
        }
        if ( Identifier != null ) {
            this.Identifier = Identifier;
        }
        if ( IsPrivileged != null ) {
            this.IsPrivileged = IsPrivileged;
        }
        if ( Permission != null ) {
            this.Permission = Permission;
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
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (this.CreationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationDate\n" ;
            } else {
                s += ind + "creationDate\n" ;
            }
        }
        //      C# -> System.String? Identifier
        // GraphQL -> identifier: String! (scalar)
        if (this.Identifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identifier\n" ;
            } else {
                s += ind + "identifier\n" ;
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
        //      C# -> System.String? Permission
        // GraphQL -> permission: String! (scalar)
        if (this.Permission != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permission\n" ;
            } else {
                s += ind + "permission\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (ec.Includes("creationDate",true))
        {
            if(this.CreationDate == null) {

                this.CreationDate = new DateTime();

            } else {


            }
        }
        else if (this.CreationDate != null && ec.Excludes("creationDate",true))
        {
            this.CreationDate = null;
        }
        //      C# -> System.String? Identifier
        // GraphQL -> identifier: String! (scalar)
        if (ec.Includes("identifier",true))
        {
            if(this.Identifier == null) {

                this.Identifier = "FETCH";

            } else {


            }
        }
        else if (this.Identifier != null && ec.Excludes("identifier",true))
        {
            this.Identifier = null;
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
        //      C# -> System.String? Permission
        // GraphQL -> permission: String! (scalar)
        if (ec.Includes("permission",true))
        {
            if(this.Permission == null) {

                this.Permission = "FETCH";

            } else {


            }
        }
        else if (this.Permission != null && ec.Excludes("permission",true))
        {
            this.Permission = null;
        }
    }


    #endregion

    } // class PrincipalApiPermissionGrant
    
    #endregion

    public static class ListPrincipalApiPermissionGrantExtensions
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
            this List<PrincipalApiPermissionGrant> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalApiPermissionGrant> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalApiPermissionGrant> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalApiPermissionGrant());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalApiPermissionGrant> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types