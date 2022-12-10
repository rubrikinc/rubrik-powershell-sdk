// OauthAccessToken.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region OauthAccessToken
    public class OauthAccessToken: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId != null)
            {
                 s += ind + "clientId\n";

            }
            //      C# -> System.String? Code
            // GraphQL -> code: String! (scalar)
            if (this.Code != null)
            {
                 s += ind + "code\n";

            }
            //      C# -> System.String? CodeVerifier
            // GraphQL -> codeVerifier: String! (scalar)
            if (this.CodeVerifier != null)
            {
                 s += ind + "codeVerifier\n";

            }
            //      C# -> System.String? ExpiryTime
            // GraphQL -> expiryTime: String! (scalar)
            if (this.ExpiryTime != null)
            {
                 s += ind + "expiryTime\n";

            }
            //      C# -> System.String? RedirectUri
            // GraphQL -> redirectUri: String! (scalar)
            if (this.RedirectUri != null)
            {
                 s += ind + "redirectUri\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId == null && Exploration.Includes(parent + ".clientId$"))
            {
                this.ClientId = new System.String("FETCH");
            }
            //      C# -> System.String? Code
            // GraphQL -> code: String! (scalar)
            if (this.Code == null && Exploration.Includes(parent + ".code$"))
            {
                this.Code = new System.String("FETCH");
            }
            //      C# -> System.String? CodeVerifier
            // GraphQL -> codeVerifier: String! (scalar)
            if (this.CodeVerifier == null && Exploration.Includes(parent + ".codeVerifier$"))
            {
                this.CodeVerifier = new System.String("FETCH");
            }
            //      C# -> System.String? ExpiryTime
            // GraphQL -> expiryTime: String! (scalar)
            if (this.ExpiryTime == null && Exploration.Includes(parent + ".expiryTime$"))
            {
                this.ExpiryTime = new System.String("FETCH");
            }
            //      C# -> System.String? RedirectUri
            // GraphQL -> redirectUri: String! (scalar)
            if (this.RedirectUri == null && Exploration.Includes(parent + ".redirectUri$"))
            {
                this.RedirectUri = new System.String("FETCH");
            }
        }


    #endregion

    } // class OauthAccessToken
    #endregion

    public static class ListOauthAccessTokenExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<OauthAccessToken> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OauthAccessToken> list, 
            String parent = "")
        {
            var item = new OauthAccessToken();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types