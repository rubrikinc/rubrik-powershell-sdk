// Principal.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Principal
    public class Principal: BaseType
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

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public Principal Set(
        PrincipalTypeEnum? PrincipalType = null,
        System.String? AuthDomainId = null,
        System.String? Description = null,
        System.String? Email = null,
        System.String? Id = null,
        System.String? Name = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class Principal
    
    #endregion

    public static class ListPrincipalExtensions
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
            this List<Principal> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Principal> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Principal());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types