// GenerateTotpSecretReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
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
    #region GenerateTotpSecretReply
    public class GenerateTotpSecretReply: IFragment
    {
        #region members
        //      C# -> System.String? Secret
        // GraphQL -> secret: String! (scalar)
        [JsonProperty("secret")]
        public System.String? Secret { get; set; }

        //      C# -> System.String? SecretUri
        // GraphQL -> secretUri: String! (scalar)
        [JsonProperty("secretUri")]
        public System.String? SecretUri { get; set; }

        #endregion

    #region methods

    public GenerateTotpSecretReply Set(
        System.String? Secret = null,
        System.String? SecretUri = null
    ) 
    {
        if ( Secret != null ) {
            this.Secret = Secret;
        }
        if ( SecretUri != null ) {
            this.SecretUri = SecretUri;
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
            //      C# -> System.String? Secret
            // GraphQL -> secret: String! (scalar)
            if (this.Secret != null)
            {
                 s += ind + "secret\n";

            }
            //      C# -> System.String? SecretUri
            // GraphQL -> secretUri: String! (scalar)
            if (this.SecretUri != null)
            {
                 s += ind + "secretUri\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Secret
            // GraphQL -> secret: String! (scalar)
            if (this.Secret == null && Exploration.Includes(parent + ".secret$"))
            {
                this.Secret = new System.String("FETCH");
            }
            //      C# -> System.String? SecretUri
            // GraphQL -> secretUri: String! (scalar)
            if (this.SecretUri == null && Exploration.Includes(parent + ".secretUri$"))
            {
                this.SecretUri = new System.String("FETCH");
            }
        }


    #endregion

    } // class GenerateTotpSecretReply
    #endregion

    public static class ListGenerateTotpSecretReplyExtensions
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
            this List<GenerateTotpSecretReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GenerateTotpSecretReply> list, 
            String parent = "")
        {
            var item = new GenerateTotpSecretReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types