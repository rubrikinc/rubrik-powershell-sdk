// O365OauthConsentCompleteReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
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
    #region O365OauthConsentCompleteReply
    public class O365OauthConsentCompleteReply: IFragment
    {
        #region members
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? EncryptedRefreshToken
        // GraphQL -> encryptedRefreshToken: String! (scalar)
        [JsonProperty("encryptedRefreshToken")]
        public System.String? EncryptedRefreshToken { get; set; }

        #endregion

    #region methods

    public O365OauthConsentCompleteReply Set(
        System.String? AppId = null,
        System.String? EncryptedRefreshToken = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( EncryptedRefreshToken != null ) {
            this.EncryptedRefreshToken = EncryptedRefreshToken;
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
            //      C# -> System.String? AppId
            // GraphQL -> appId: String! (scalar)
            if (this.AppId != null)
            {
                 s += ind + "appId\n";

            }
            //      C# -> System.String? EncryptedRefreshToken
            // GraphQL -> encryptedRefreshToken: String! (scalar)
            if (this.EncryptedRefreshToken != null)
            {
                 s += ind + "encryptedRefreshToken\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AppId
            // GraphQL -> appId: String! (scalar)
            if (this.AppId == null && Exploration.Includes(parent + ".appId$"))
            {
                this.AppId = new System.String("FETCH");
            }
            //      C# -> System.String? EncryptedRefreshToken
            // GraphQL -> encryptedRefreshToken: String! (scalar)
            if (this.EncryptedRefreshToken == null && Exploration.Includes(parent + ".encryptedRefreshToken$"))
            {
                this.EncryptedRefreshToken = new System.String("FETCH");
            }
        }


    #endregion

    } // class O365OauthConsentCompleteReply
    #endregion

    public static class ListO365OauthConsentCompleteReplyExtensions
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
            this List<O365OauthConsentCompleteReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365OauthConsentCompleteReply> list, 
            String parent = "")
        {
            var item = new O365OauthConsentCompleteReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types