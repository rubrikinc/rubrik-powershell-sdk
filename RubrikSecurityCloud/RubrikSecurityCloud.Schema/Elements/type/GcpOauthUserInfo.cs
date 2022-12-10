// GcpOauthUserInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:22.
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
    #region GcpOauthUserInfo
    public class GcpOauthUserInfo: IFragment
    {
        #region members
        //      C# -> System.String? Domain
        // GraphQL -> domain: String! (scalar)
        [JsonProperty("domain")]
        public System.String? Domain { get; set; }

        //      C# -> System.String? EmailId
        // GraphQL -> emailId: String! (scalar)
        [JsonProperty("emailId")]
        public System.String? EmailId { get; set; }

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String! (scalar)
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }

        #endregion

    #region methods

    public GcpOauthUserInfo Set(
        System.String? Domain = null,
        System.String? EmailId = null,
        System.String? FirstName = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( EmailId != null ) {
            this.EmailId = EmailId;
        }
        if ( FirstName != null ) {
            this.FirstName = FirstName;
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
            //      C# -> System.String? Domain
            // GraphQL -> domain: String! (scalar)
            if (this.Domain != null)
            {
                 s += ind + "domain\n";

            }
            //      C# -> System.String? EmailId
            // GraphQL -> emailId: String! (scalar)
            if (this.EmailId != null)
            {
                 s += ind + "emailId\n";

            }
            //      C# -> System.String? FirstName
            // GraphQL -> firstName: String! (scalar)
            if (this.FirstName != null)
            {
                 s += ind + "firstName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Domain
            // GraphQL -> domain: String! (scalar)
            if (this.Domain == null && Exploration.Includes(parent + ".domain$"))
            {
                this.Domain = new System.String("FETCH");
            }
            //      C# -> System.String? EmailId
            // GraphQL -> emailId: String! (scalar)
            if (this.EmailId == null && Exploration.Includes(parent + ".emailId$"))
            {
                this.EmailId = new System.String("FETCH");
            }
            //      C# -> System.String? FirstName
            // GraphQL -> firstName: String! (scalar)
            if (this.FirstName == null && Exploration.Includes(parent + ".firstName$"))
            {
                this.FirstName = new System.String("FETCH");
            }
        }


    #endregion

    } // class GcpOauthUserInfo
    #endregion

    public static class ListGcpOauthUserInfoExtensions
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
            this List<GcpOauthUserInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpOauthUserInfo> list, 
            String parent = "")
        {
            var item = new GcpOauthUserInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types