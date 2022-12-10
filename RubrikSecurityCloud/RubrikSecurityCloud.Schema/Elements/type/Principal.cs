// Principal.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:41.
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
    #region Principal
    public class Principal: IFragment
    {
        #region members
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        [JsonProperty("authDomainId")]
        public System.String? AuthDomainId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        [JsonProperty("principalType")]
        public PrincipalTypeEnum? PrincipalType { get; set; }

        #endregion

    #region methods

    public Principal Set(
        System.String? AuthDomainId = null,
        System.String? Description = null,
        System.String? Email = null,
        System.String? Id = null,
        System.String? Name = null,
        PrincipalTypeEnum? PrincipalType = null
    ) 
    {
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
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
            //      C# -> System.String? AuthDomainId
            // GraphQL -> authDomainId: String! (scalar)
            if (this.AuthDomainId != null)
            {
                 s += ind + "authDomainId\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Email
            // GraphQL -> email: String (scalar)
            if (this.Email != null)
            {
                 s += ind + "email\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> PrincipalTypeEnum? PrincipalType
            // GraphQL -> principalType: PrincipalTypeEnum! (enum)
            if (this.PrincipalType != null)
            {
                 s += ind + "principalType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AuthDomainId
            // GraphQL -> authDomainId: String! (scalar)
            if (this.AuthDomainId == null && Exploration.Includes(parent + ".authDomainId$"))
            {
                this.AuthDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Email
            // GraphQL -> email: String (scalar)
            if (this.Email == null && Exploration.Includes(parent + ".email$"))
            {
                this.Email = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> PrincipalTypeEnum? PrincipalType
            // GraphQL -> principalType: PrincipalTypeEnum! (enum)
            if (this.PrincipalType == null && Exploration.Includes(parent + ".principalType$"))
            {
                this.PrincipalType = new PrincipalTypeEnum();
            }
        }


    #endregion

    } // class Principal
    #endregion

    public static class ListPrincipalExtensions
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
            this List<Principal> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Principal> list, 
            String parent = "")
        {
            var item = new Principal();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types