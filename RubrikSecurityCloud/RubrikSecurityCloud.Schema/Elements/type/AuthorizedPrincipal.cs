// AuthorizedPrincipal.cs
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
    #region AuthorizedPrincipal
    public class AuthorizedPrincipal: IFragment
    {
        #region members
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        [JsonProperty("authDomainId")]
        public System.String? AuthDomainId { get; set; }

        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        [JsonProperty("authDomainName")]
        public System.String? AuthDomainName { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }

        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        [JsonProperty("totpStatus")]
        public LdapTotpStatus? TotpStatus { get; set; }

        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        [JsonProperty("principalType")]
        public PrincipalTypeEnum? PrincipalType { get; set; }

        #endregion

    #region methods

    public AuthorizedPrincipal Set(
        System.String? AuthDomainId = null,
        System.String? AuthDomainName = null,
        System.String? Email = null,
        System.String? Id = null,
        DateTime? LastLogin = null,
        System.String? Name = null,
        List<Role>? Roles = null,
        LdapTotpStatus? TotpStatus = null,
        PrincipalTypeEnum? PrincipalType = null
    ) 
    {
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( AuthDomainName != null ) {
            this.AuthDomainName = AuthDomainName;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( TotpStatus != null ) {
            this.TotpStatus = TotpStatus;
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
            //      C# -> System.String? AuthDomainName
            // GraphQL -> authDomainName: String! (scalar)
            if (this.AuthDomainName != null)
            {
                 s += ind + "authDomainName\n";

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
            //      C# -> DateTime? LastLogin
            // GraphQL -> lastLogin: DateTime (scalar)
            if (this.LastLogin != null)
            {
                 s += ind + "lastLogin\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<Role>? Roles
            // GraphQL -> roles: [Role!]! (type)
            if (this.Roles != null)
            {
                 s += ind + "roles\n";

                 s += ind + "{\n" + 
                 this.Roles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> LdapTotpStatus? TotpStatus
            // GraphQL -> totpStatus: LdapTotpStatus (type)
            if (this.TotpStatus != null)
            {
                 s += ind + "totpStatus\n";

                 s += ind + "{\n" + 
                 this.TotpStatus.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.String? AuthDomainName
            // GraphQL -> authDomainName: String! (scalar)
            if (this.AuthDomainName == null && Exploration.Includes(parent + ".authDomainName$"))
            {
                this.AuthDomainName = new System.String("FETCH");
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
            //      C# -> DateTime? LastLogin
            // GraphQL -> lastLogin: DateTime (scalar)
            if (this.LastLogin == null && Exploration.Includes(parent + ".lastLogin$"))
            {
                this.LastLogin = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<Role>? Roles
            // GraphQL -> roles: [Role!]! (type)
            if (this.Roles == null && Exploration.Includes(parent + ".roles"))
            {
                this.Roles = new List<Role>();
                this.Roles.ApplyExploratoryFragment(parent + ".roles");
            }
            //      C# -> LdapTotpStatus? TotpStatus
            // GraphQL -> totpStatus: LdapTotpStatus (type)
            if (this.TotpStatus == null && Exploration.Includes(parent + ".totpStatus"))
            {
                this.TotpStatus = new LdapTotpStatus();
                this.TotpStatus.ApplyExploratoryFragment(parent + ".totpStatus");
            }
            //      C# -> PrincipalTypeEnum? PrincipalType
            // GraphQL -> principalType: PrincipalTypeEnum! (enum)
            if (this.PrincipalType == null && Exploration.Includes(parent + ".principalType$"))
            {
                this.PrincipalType = new PrincipalTypeEnum();
            }
        }


    #endregion

    } // class AuthorizedPrincipal
    #endregion

    public static class ListAuthorizedPrincipalExtensions
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
            this List<AuthorizedPrincipal> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AuthorizedPrincipal> list, 
            String parent = "")
        {
            var item = new AuthorizedPrincipal();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types