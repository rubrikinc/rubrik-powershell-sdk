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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Principal";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        if (this.PrincipalType == null && ec.Includes("principalType",true))
        {
            this.PrincipalType = new PrincipalTypeEnum();
        }
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        if (this.AuthDomainId == null && ec.Includes("authDomainId",true))
        {
            this.AuthDomainId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        if (this.Email == null && ec.Includes("email",true))
        {
            this.Email = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Principal> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Principal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Principal> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types