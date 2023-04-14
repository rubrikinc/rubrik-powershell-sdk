// O365SaasSetupKickoffReply.cs
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
    #region O365SaasSetupKickoffReply
    public class O365SaasSetupKickoffReply: IFragment
    {
        #region members
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> List<AppIdForType>? AppClientIdsPerType
        // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
        [JsonProperty("appClientIdsPerType")]
        public List<AppIdForType>? AppClientIdsPerType { get; set; }

        #endregion

    #region methods

    public O365SaasSetupKickoffReply Set(
        System.String? CsrfToken = null,
        List<AppIdForType>? AppClientIdsPerType = null
    ) 
    {
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( AppClientIdsPerType != null ) {
            this.AppClientIdsPerType = AppClientIdsPerType;
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
            //      C# -> System.String? CsrfToken
            // GraphQL -> csrfToken: String! (scalar)
            if (this.CsrfToken != null)
            {
                 s += ind + "csrfToken\n";

            }
            //      C# -> List<AppIdForType>? AppClientIdsPerType
            // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
            if (this.AppClientIdsPerType != null)
            {
                 s += ind + "appClientIdsPerType\n";

                 s += ind + "{\n" + 
                 this.AppClientIdsPerType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CsrfToken
            // GraphQL -> csrfToken: String! (scalar)
            if (this.CsrfToken == null && Exploration.Includes(parent + ".csrfToken$"))
            {
                this.CsrfToken = new System.String("FETCH");
            }
            //      C# -> List<AppIdForType>? AppClientIdsPerType
            // GraphQL -> appClientIdsPerType: [AppIdForType!]! (type)
            if (this.AppClientIdsPerType == null && Exploration.Includes(parent + ".appClientIdsPerType"))
            {
                this.AppClientIdsPerType = new List<AppIdForType>();
                this.AppClientIdsPerType.ApplyExploratoryFragment(parent + ".appClientIdsPerType");
            }
        }


    #endregion

    } // class O365SaasSetupKickoffReply
    #endregion

    public static class ListO365SaasSetupKickoffReplyExtensions
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
            this List<O365SaasSetupKickoffReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365SaasSetupKickoffReply> list, 
            String parent = "")
        {
            var item = new O365SaasSetupKickoffReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types