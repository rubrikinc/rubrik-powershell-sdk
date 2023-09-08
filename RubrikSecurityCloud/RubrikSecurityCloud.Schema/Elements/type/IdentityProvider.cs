// IdentityProvider.cs
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
    #region IdentityProvider
    public class IdentityProvider: BaseType
    {
        #region members

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        [JsonProperty("ownerOrgId")]
        public System.String? OwnerOrgId { get; set; }

        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }

        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        [JsonProperty("signOutUrl")]
        public System.String? SignOutUrl { get; set; }

        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        [JsonProperty("spInitiatedSignInUrl")]
        public System.String? SpInitiatedSignInUrl { get; set; }

        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        [JsonProperty("spInitiatedTestUrl")]
        public System.String? SpInitiatedTestUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityProvider";
    }

    public IdentityProvider Set(
        System.String? EntityId = null,
        DateTime? ExpirationDate = null,
        System.String? Name = null,
        System.String? OwnerOrgId = null,
        System.String? SignInUrl = null,
        System.String? SignOutUrl = null,
        System.String? SpInitiatedSignInUrl = null,
        System.String? SpInitiatedTestUrl = null
    ) 
    {
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OwnerOrgId != null ) {
            this.OwnerOrgId = OwnerOrgId;
        }
        if ( SignInUrl != null ) {
            this.SignInUrl = SignInUrl;
        }
        if ( SignOutUrl != null ) {
            this.SignOutUrl = SignOutUrl;
        }
        if ( SpInitiatedSignInUrl != null ) {
            this.SpInitiatedSignInUrl = SpInitiatedSignInUrl;
        }
        if ( SpInitiatedTestUrl != null ) {
            this.SpInitiatedTestUrl = SpInitiatedTestUrl;
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
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId != null) {
            s += ind + "entityId\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        if (this.OwnerOrgId != null) {
            s += ind + "ownerOrgId\n" ;
        }
        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        if (this.SignInUrl != null) {
            s += ind + "signInUrl\n" ;
        }
        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        if (this.SignOutUrl != null) {
            s += ind + "signOutUrl\n" ;
        }
        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        if (this.SpInitiatedSignInUrl != null) {
            s += ind + "spInitiatedSignInUrl\n" ;
        }
        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        if (this.SpInitiatedTestUrl != null) {
            s += ind + "spInitiatedTestUrl\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId == null && ec.Includes("entityId",true))
        {
            this.EntityId = "FETCH";
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && ec.Includes("expirationDate",true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        if (this.OwnerOrgId == null && ec.Includes("ownerOrgId",true))
        {
            this.OwnerOrgId = "FETCH";
        }
        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        if (this.SignInUrl == null && ec.Includes("signInUrl",true))
        {
            this.SignInUrl = "FETCH";
        }
        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        if (this.SignOutUrl == null && ec.Includes("signOutUrl",true))
        {
            this.SignOutUrl = "FETCH";
        }
        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        if (this.SpInitiatedSignInUrl == null && ec.Includes("spInitiatedSignInUrl",true))
        {
            this.SpInitiatedSignInUrl = "FETCH";
        }
        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        if (this.SpInitiatedTestUrl == null && ec.Includes("spInitiatedTestUrl",true))
        {
            this.SpInitiatedTestUrl = "FETCH";
        }
    }


    #endregion

    } // class IdentityProvider
    
    #endregion

    public static class ListIdentityProviderExtensions
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
            this List<IdentityProvider> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IdentityProvider> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityProvider());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<IdentityProvider> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types