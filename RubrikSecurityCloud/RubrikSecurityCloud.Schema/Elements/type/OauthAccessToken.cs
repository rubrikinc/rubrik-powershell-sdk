// OauthAccessToken.cs
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
    #region OauthAccessToken
    public class OauthAccessToken: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        [JsonProperty("codeVerifier")]
        public System.String? CodeVerifier { get; set; }

        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        [JsonProperty("expiryTime")]
        public System.String? ExpiryTime { get; set; }

        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        [JsonProperty("redirectUri")]
        public System.String? RedirectUri { get; set; }


        #endregion

    #region methods

    public OauthAccessToken Set(
        System.String? ClientId = null,
        System.String? Code = null,
        System.String? CodeVerifier = null,
        System.String? ExpiryTime = null,
        System.String? RedirectUri = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( CodeVerifier != null ) {
            this.CodeVerifier = CodeVerifier;
        }
        if ( ExpiryTime != null ) {
            this.ExpiryTime = ExpiryTime;
        }
        if ( RedirectUri != null ) {
            this.RedirectUri = RedirectUri;
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
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code != null) {
            s += ind + "code\n" ;
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (this.CodeVerifier != null) {
            s += ind + "codeVerifier\n" ;
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (this.ExpiryTime != null) {
            s += ind + "expiryTime\n" ;
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (this.RedirectUri != null) {
            s += ind + "redirectUri\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && Exploration.Includes(parent + ".clientId", true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code == null && Exploration.Includes(parent + ".code", true))
        {
            this.Code = "FETCH";
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (this.CodeVerifier == null && Exploration.Includes(parent + ".codeVerifier", true))
        {
            this.CodeVerifier = "FETCH";
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (this.ExpiryTime == null && Exploration.Includes(parent + ".expiryTime", true))
        {
            this.ExpiryTime = "FETCH";
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (this.RedirectUri == null && Exploration.Includes(parent + ".redirectUri", true))
        {
            this.RedirectUri = "FETCH";
        }
    }


    #endregion

    } // class OauthAccessToken
    
    #endregion

    public static class ListOauthAccessTokenExtensions
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
            this List<OauthAccessToken> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OauthAccessToken> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OauthAccessToken());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types