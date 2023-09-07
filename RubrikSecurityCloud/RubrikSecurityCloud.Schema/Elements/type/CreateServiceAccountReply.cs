// CreateServiceAccountReply.cs
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
    #region CreateServiceAccountReply
    public class CreateServiceAccountReply: BaseType
    {
        #region members

        //      C# -> System.String? AccessTokenUri
        // GraphQL -> accessTokenUri: String! (scalar)
        [JsonProperty("accessTokenUri")]
        public System.String? AccessTokenUri { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateServiceAccountReply";
    }

    public CreateServiceAccountReply Set(
        System.String? AccessTokenUri = null,
        System.String? ClientId = null,
        System.String? ClientSecret = null,
        System.String? Name = null
    ) 
    {
        if ( AccessTokenUri != null ) {
            this.AccessTokenUri = AccessTokenUri;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( ClientSecret != null ) {
            this.ClientSecret = ClientSecret;
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
        //      C# -> System.String? AccessTokenUri
        // GraphQL -> accessTokenUri: String! (scalar)
        if (this.AccessTokenUri != null) {
            s += ind + "accessTokenUri\n" ;
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (this.ClientSecret != null) {
            s += ind + "clientSecret\n" ;
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
        //      C# -> System.String? AccessTokenUri
        // GraphQL -> accessTokenUri: String! (scalar)
        if (this.AccessTokenUri == null && ec.Includes("accessTokenUri",true))
        {
            this.AccessTokenUri = "FETCH";
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && ec.Includes("clientId",true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        if (this.ClientSecret == null && ec.Includes("clientSecret",true))
        {
            this.ClientSecret = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class CreateServiceAccountReply
    
    #endregion

    public static class ListCreateServiceAccountReplyExtensions
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
            this List<CreateServiceAccountReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateServiceAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateServiceAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CreateServiceAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types