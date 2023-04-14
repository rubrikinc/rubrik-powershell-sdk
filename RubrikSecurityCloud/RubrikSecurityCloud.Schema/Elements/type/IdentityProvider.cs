// IdentityProvider.cs
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
    #region IdentityProvider
    public class IdentityProvider: IFragment
    {
        #region members
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OwnerOrgId
        // GraphQL -> ownerOrgId: String! (scalar)
        [JsonProperty("ownerOrgId")]
        public System.String? OwnerOrgId { get; set; }

        //      C# -> System.String? SignInUrl
        // GraphQL -> signInUrl: String! (scalar)
        [JsonProperty("signInUrl")]
        public System.String? SignInUrl { get; set; }

        //      C# -> System.String? SignOutUrl
        // GraphQL -> signOutUrl: String! (scalar)
        [JsonProperty("signOutUrl")]
        public System.String? SignOutUrl { get; set; }

        //      C# -> System.String? SpInitiatedSignInUrl
        // GraphQL -> spInitiatedSignInUrl: String! (scalar)
        [JsonProperty("spInitiatedSignInUrl")]
        public System.String? SpInitiatedSignInUrl { get; set; }

        //      C# -> System.String? SpInitiatedTestUrl
        // GraphQL -> spInitiatedTestUrl: String! (scalar)
        [JsonProperty("spInitiatedTestUrl")]
        public System.String? SpInitiatedTestUrl { get; set; }

        #endregion

    #region methods

    public IdentityProvider Set(
        System.String? EntityId = null,
        DateTime? ExpirationDate = null,
        System.String? Name = null,
        System.String? OwnerOrgId = null,
        System.String? SignInUrl = null,
        System.String? SignOutUrl = null,
        System.String? SpInitiatedSignInUrl = null,
        System.String? SpInitiatedTestUrl = null
    ) 
    {
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OwnerOrgId != null ) {
            this.OwnerOrgId = OwnerOrgId;
        }
        if ( SignInUrl != null ) {
            this.SignInUrl = SignInUrl;
        }
        if ( SignOutUrl != null ) {
            this.SignOutUrl = SignOutUrl;
        }
        if ( SpInitiatedSignInUrl != null ) {
            this.SpInitiatedSignInUrl = SpInitiatedSignInUrl;
        }
        if ( SpInitiatedTestUrl != null ) {
            this.SpInitiatedTestUrl = SpInitiatedTestUrl;
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
            //      C# -> System.String? EntityId
            // GraphQL -> entityId: String! (scalar)
            if (this.EntityId != null)
            {
                 s += ind + "entityId\n";

            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate != null)
            {
                 s += ind + "expirationDate\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OwnerOrgId
            // GraphQL -> ownerOrgId: String! (scalar)
            if (this.OwnerOrgId != null)
            {
                 s += ind + "ownerOrgId\n";

            }
            //      C# -> System.String? SignInUrl
            // GraphQL -> signInUrl: String! (scalar)
            if (this.SignInUrl != null)
            {
                 s += ind + "signInUrl\n";

            }
            //      C# -> System.String? SignOutUrl
            // GraphQL -> signOutUrl: String! (scalar)
            if (this.SignOutUrl != null)
            {
                 s += ind + "signOutUrl\n";

            }
            //      C# -> System.String? SpInitiatedSignInUrl
            // GraphQL -> spInitiatedSignInUrl: String! (scalar)
            if (this.SpInitiatedSignInUrl != null)
            {
                 s += ind + "spInitiatedSignInUrl\n";

            }
            //      C# -> System.String? SpInitiatedTestUrl
            // GraphQL -> spInitiatedTestUrl: String! (scalar)
            if (this.SpInitiatedTestUrl != null)
            {
                 s += ind + "spInitiatedTestUrl\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EntityId
            // GraphQL -> entityId: String! (scalar)
            if (this.EntityId == null && Exploration.Includes(parent + ".entityId$"))
            {
                this.EntityId = new System.String("FETCH");
            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate$"))
            {
                this.ExpirationDate = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OwnerOrgId
            // GraphQL -> ownerOrgId: String! (scalar)
            if (this.OwnerOrgId == null && Exploration.Includes(parent + ".ownerOrgId$"))
            {
                this.OwnerOrgId = new System.String("FETCH");
            }
            //      C# -> System.String? SignInUrl
            // GraphQL -> signInUrl: String! (scalar)
            if (this.SignInUrl == null && Exploration.Includes(parent + ".signInUrl$"))
            {
                this.SignInUrl = new System.String("FETCH");
            }
            //      C# -> System.String? SignOutUrl
            // GraphQL -> signOutUrl: String! (scalar)
            if (this.SignOutUrl == null && Exploration.Includes(parent + ".signOutUrl$"))
            {
                this.SignOutUrl = new System.String("FETCH");
            }
            //      C# -> System.String? SpInitiatedSignInUrl
            // GraphQL -> spInitiatedSignInUrl: String! (scalar)
            if (this.SpInitiatedSignInUrl == null && Exploration.Includes(parent + ".spInitiatedSignInUrl$"))
            {
                this.SpInitiatedSignInUrl = new System.String("FETCH");
            }
            //      C# -> System.String? SpInitiatedTestUrl
            // GraphQL -> spInitiatedTestUrl: String! (scalar)
            if (this.SpInitiatedTestUrl == null && Exploration.Includes(parent + ".spInitiatedTestUrl$"))
            {
                this.SpInitiatedTestUrl = new System.String("FETCH");
            }
        }


    #endregion

    } // class IdentityProvider
    #endregion

    public static class ListIdentityProviderExtensions
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
            this List<IdentityProvider> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<IdentityProvider> list, 
            String parent = "")
        {
            var item = new IdentityProvider();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types