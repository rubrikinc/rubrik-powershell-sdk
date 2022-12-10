// ClusterRegistrationToken.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    #region ClusterRegistrationToken
    public class ClusterRegistrationToken: IFragment
    {
        #region members
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        [JsonProperty("productType")]
        public System.String? ProductType { get; set; }

        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        [JsonProperty("pubkey")]
        public System.String? Pubkey { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }

        #endregion

    #region methods

    public ClusterRegistrationToken Set(
        System.String? ProductType = null,
        System.String? Pubkey = null,
        System.String? Token = null
    ) 
    {
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( Pubkey != null ) {
            this.Pubkey = Pubkey;
        }
        if ( Token != null ) {
            this.Token = Token;
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
            //      C# -> System.String? ProductType
            // GraphQL -> productType: String! (scalar)
            if (this.ProductType != null)
            {
                 s += ind + "productType\n";

            }
            //      C# -> System.String? Pubkey
            // GraphQL -> pubkey: String! (scalar)
            if (this.Pubkey != null)
            {
                 s += ind + "pubkey\n";

            }
            //      C# -> System.String? Token
            // GraphQL -> token: String! (scalar)
            if (this.Token != null)
            {
                 s += ind + "token\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ProductType
            // GraphQL -> productType: String! (scalar)
            if (this.ProductType == null && Exploration.Includes(parent + ".productType$"))
            {
                this.ProductType = new System.String("FETCH");
            }
            //      C# -> System.String? Pubkey
            // GraphQL -> pubkey: String! (scalar)
            if (this.Pubkey == null && Exploration.Includes(parent + ".pubkey$"))
            {
                this.Pubkey = new System.String("FETCH");
            }
            //      C# -> System.String? Token
            // GraphQL -> token: String! (scalar)
            if (this.Token == null && Exploration.Includes(parent + ".token$"))
            {
                this.Token = new System.String("FETCH");
            }
        }


    #endregion

    } // class ClusterRegistrationToken
    #endregion

    public static class ListClusterRegistrationTokenExtensions
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
            this List<ClusterRegistrationToken> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterRegistrationToken> list, 
            String parent = "")
        {
            var item = new ClusterRegistrationToken();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types