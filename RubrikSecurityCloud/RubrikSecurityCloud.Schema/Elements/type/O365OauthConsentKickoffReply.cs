// O365OauthConsentKickoffReply.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region O365OauthConsentKickoffReply
    public class O365OauthConsentKickoffReply: IFragment
    {
        #region members
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        [JsonProperty("appClientId")]
        public System.String? AppClientId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        #endregion

    #region methods

    public O365OauthConsentKickoffReply Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        System.String? TenantId = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
            //      C# -> System.String? AppClientId
            // GraphQL -> appClientId: String! (scalar)
            if (this.AppClientId != null)
            {
                 s += ind + "appClientId\n";

            }
            //      C# -> System.String? CsrfToken
            // GraphQL -> csrfToken: String! (scalar)
            if (this.CsrfToken != null)
            {
                 s += ind + "csrfToken\n";

            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId != null)
            {
                 s += ind + "tenantId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AppClientId
            // GraphQL -> appClientId: String! (scalar)
            if (this.AppClientId == null && Exploration.Includes(parent + ".appClientId$"))
            {
                this.AppClientId = new System.String("FETCH");
            }
            //      C# -> System.String? CsrfToken
            // GraphQL -> csrfToken: String! (scalar)
            if (this.CsrfToken == null && Exploration.Includes(parent + ".csrfToken$"))
            {
                this.CsrfToken = new System.String("FETCH");
            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId == null && Exploration.Includes(parent + ".tenantId$"))
            {
                this.TenantId = new System.String("FETCH");
            }
        }


    #endregion

    } // class O365OauthConsentKickoffReply
    #endregion

    public static class ListO365OauthConsentKickoffReplyExtensions
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
            this List<O365OauthConsentKickoffReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365OauthConsentKickoffReply> list, 
            String parent = "")
        {
            var item = new O365OauthConsentKickoffReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types