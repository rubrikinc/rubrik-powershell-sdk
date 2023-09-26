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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "OauthAccessToken";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (this.CodeVerifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "codeVerifier\n" ;
            } else {
                s += ind + "codeVerifier\n" ;
            }
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (this.ExpiryTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiryTime\n" ;
            } else {
                s += ind + "expiryTime\n" ;
            }
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (this.RedirectUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redirectUri\n" ;
            } else {
                s += ind + "redirectUri\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = "FETCH";

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> System.String? CodeVerifier
        // GraphQL -> codeVerifier: String! (scalar)
        if (ec.Includes("codeVerifier",true))
        {
            if(this.CodeVerifier == null) {

                this.CodeVerifier = "FETCH";

            } else {


            }
        }
        else if (this.CodeVerifier != null && ec.Excludes("codeVerifier",true))
        {
            this.CodeVerifier = null;
        }
        //      C# -> System.String? ExpiryTime
        // GraphQL -> expiryTime: String! (scalar)
        if (ec.Includes("expiryTime",true))
        {
            if(this.ExpiryTime == null) {

                this.ExpiryTime = "FETCH";

            } else {


            }
        }
        else if (this.ExpiryTime != null && ec.Excludes("expiryTime",true))
        {
            this.ExpiryTime = null;
        }
        //      C# -> System.String? RedirectUri
        // GraphQL -> redirectUri: String! (scalar)
        if (ec.Includes("redirectUri",true))
        {
            if(this.RedirectUri == null) {

                this.RedirectUri = "FETCH";

            } else {


            }
        }
        else if (this.RedirectUri != null && ec.Excludes("redirectUri",true))
        {
            this.RedirectUri = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OauthAccessToken> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OauthAccessToken());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OauthAccessToken> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types