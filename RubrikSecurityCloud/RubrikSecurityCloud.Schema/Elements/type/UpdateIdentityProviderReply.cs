// UpdateIdentityProviderReply.cs
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
    #region UpdateIdentityProviderReply
    public class UpdateIdentityProviderReply: BaseType
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
        // GraphQL -> signInUrl: URL! (scalar)
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateIdentityProviderReply";
    }

    public UpdateIdentityProviderReply Set(
        System.String? EntityId = null,
        DateTime? ExpirationDate = null,
        System.String? Name = null,
        System.String? OwnerOrgId = null,
        System.String? SignInUrl = null
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
        // GraphQL -> signInUrl: URL! (scalar)
        if (this.SignInUrl != null) {
            s += ind + "signInUrl\n" ;
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
        // GraphQL -> signInUrl: URL! (scalar)
        if (this.SignInUrl == null && ec.Includes("signInUrl",true))
        {
            this.SignInUrl = "FETCH";
        }
    }


    #endregion

    } // class UpdateIdentityProviderReply
    
    #endregion

    public static class ListUpdateIdentityProviderReplyExtensions
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
            this List<UpdateIdentityProviderReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateIdentityProviderReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateIdentityProviderReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateIdentityProviderReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types