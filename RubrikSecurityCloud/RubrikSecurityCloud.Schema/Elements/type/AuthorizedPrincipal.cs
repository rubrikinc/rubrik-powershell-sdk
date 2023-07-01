// AuthorizedPrincipal.cs
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
    #region AuthorizedPrincipal
    public class AuthorizedPrincipal: BaseType
    {
        #region members

        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        [JsonProperty("principalType")]
        public PrincipalTypeEnum? PrincipalType { get; set; }

        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        [JsonProperty("authDomainId")]
        public System.String? AuthDomainId { get; set; }

        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        [JsonProperty("authDomainName")]
        public System.String? AuthDomainName { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }

        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        [JsonProperty("totpStatus")]
        public LdapTotpStatus? TotpStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthorizedPrincipal";
    }

    public AuthorizedPrincipal Set(
        PrincipalTypeEnum? PrincipalType = null,
        System.String? AuthDomainId = null,
        System.String? AuthDomainName = null,
        System.String? Email = null,
        System.String? Id = null,
        DateTime? LastLogin = null,
        System.String? Name = null,
        List<Role>? Roles = null,
        LdapTotpStatus? TotpStatus = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( AuthDomainName != null ) {
            this.AuthDomainName = AuthDomainName;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( TotpStatus != null ) {
            this.TotpStatus = TotpStatus;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        if (this.PrincipalType != null) {
            s += ind + "principalType\n" ;
        }
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        if (this.AuthDomainId != null) {
            s += ind + "authDomainId\n" ;
        }
        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        if (this.AuthDomainName != null) {
            s += ind + "authDomainName\n" ;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        if (this.Email != null) {
            s += ind + "email\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin != null) {
            s += ind + "lastLogin\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "roles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        if (this.TotpStatus != null) {
            var fspec = this.TotpStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totpStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        if (this.PrincipalType == null && Exploration.Includes(parent + ".principalType", true))
        {
            this.PrincipalType = new PrincipalTypeEnum();
        }
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        if (this.AuthDomainId == null && Exploration.Includes(parent + ".authDomainId", true))
        {
            this.AuthDomainId = "FETCH";
        }
        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        if (this.AuthDomainName == null && Exploration.Includes(parent + ".authDomainName", true))
        {
            this.AuthDomainName = "FETCH";
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        if (this.Email == null && Exploration.Includes(parent + ".email", true))
        {
            this.Email = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin == null && Exploration.Includes(parent + ".lastLogin", true))
        {
            this.LastLogin = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles == null && Exploration.Includes(parent + ".roles"))
        {
            this.Roles = new List<Role>();
            this.Roles.ApplyExploratoryFieldSpec(parent + ".roles");
        }
        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        if (this.TotpStatus == null && Exploration.Includes(parent + ".totpStatus"))
        {
            this.TotpStatus = new LdapTotpStatus();
            this.TotpStatus.ApplyExploratoryFieldSpec(parent + ".totpStatus");
        }
    }


    #endregion

    } // class AuthorizedPrincipal
    
    #endregion

    public static class ListAuthorizedPrincipalExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AuthorizedPrincipal> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedPrincipal> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedPrincipal());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types