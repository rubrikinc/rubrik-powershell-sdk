// LdapIntegration.cs
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
    #region LdapIntegration
    public class LdapIntegration: IFragment
    {
        #region members
        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        [JsonProperty("baseDn")]
        public System.String? BaseDn { get; set; }

        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        [JsonProperty("bindUserName")]
        public System.String? BindUserName { get; set; }

        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        [JsonProperty("dynamicDnsName")]
        public System.String? DynamicDnsName { get; set; }

        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        [JsonProperty("groupMemberAttr")]
        public System.String? GroupMemberAttr { get; set; }

        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        [JsonProperty("groupMembershipAttr")]
        public System.String? GroupMembershipAttr { get; set; }

        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        [JsonProperty("groupSearchFilter")]
        public System.String? GroupSearchFilter { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        [JsonProperty("isTotpEnforced")]
        public System.Boolean? IsTotpEnforced { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        [JsonProperty("trustedCerts")]
        public System.String? TrustedCerts { get; set; }

        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        [JsonProperty("userNameAttr")]
        public System.String? UserNameAttr { get; set; }

        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        [JsonProperty("userSearchFilter")]
        public System.String? UserSearchFilter { get; set; }

        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        [JsonProperty("ldapServers")]
        public List<LdapServer>? LdapServers { get; set; }

        #endregion

    #region methods

    public LdapIntegration Set(
        System.String? BaseDn = null,
        System.String? BindUserName = null,
        System.String? DynamicDnsName = null,
        System.String? GroupMemberAttr = null,
        System.String? GroupMembershipAttr = null,
        System.String? GroupSearchFilter = null,
        System.String? Id = null,
        System.Boolean? IsTotpEnforced = null,
        System.String? Name = null,
        System.String? TrustedCerts = null,
        System.String? UserNameAttr = null,
        System.String? UserSearchFilter = null,
        List<LdapServer>? LdapServers = null
    ) 
    {
        if ( BaseDn != null ) {
            this.BaseDn = BaseDn;
        }
        if ( BindUserName != null ) {
            this.BindUserName = BindUserName;
        }
        if ( DynamicDnsName != null ) {
            this.DynamicDnsName = DynamicDnsName;
        }
        if ( GroupMemberAttr != null ) {
            this.GroupMemberAttr = GroupMemberAttr;
        }
        if ( GroupMembershipAttr != null ) {
            this.GroupMembershipAttr = GroupMembershipAttr;
        }
        if ( GroupSearchFilter != null ) {
            this.GroupSearchFilter = GroupSearchFilter;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsTotpEnforced != null ) {
            this.IsTotpEnforced = IsTotpEnforced;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TrustedCerts != null ) {
            this.TrustedCerts = TrustedCerts;
        }
        if ( UserNameAttr != null ) {
            this.UserNameAttr = UserNameAttr;
        }
        if ( UserSearchFilter != null ) {
            this.UserSearchFilter = UserSearchFilter;
        }
        if ( LdapServers != null ) {
            this.LdapServers = LdapServers;
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
            //      C# -> System.String? BaseDn
            // GraphQL -> baseDn: String! (scalar)
            if (this.BaseDn != null)
            {
                 s += ind + "baseDn\n";

            }
            //      C# -> System.String? BindUserName
            // GraphQL -> bindUserName: String! (scalar)
            if (this.BindUserName != null)
            {
                 s += ind + "bindUserName\n";

            }
            //      C# -> System.String? DynamicDnsName
            // GraphQL -> dynamicDnsName: String! (scalar)
            if (this.DynamicDnsName != null)
            {
                 s += ind + "dynamicDnsName\n";

            }
            //      C# -> System.String? GroupMemberAttr
            // GraphQL -> groupMemberAttr: String (scalar)
            if (this.GroupMemberAttr != null)
            {
                 s += ind + "groupMemberAttr\n";

            }
            //      C# -> System.String? GroupMembershipAttr
            // GraphQL -> groupMembershipAttr: String (scalar)
            if (this.GroupMembershipAttr != null)
            {
                 s += ind + "groupMembershipAttr\n";

            }
            //      C# -> System.String? GroupSearchFilter
            // GraphQL -> groupSearchFilter: String (scalar)
            if (this.GroupSearchFilter != null)
            {
                 s += ind + "groupSearchFilter\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsTotpEnforced
            // GraphQL -> isTotpEnforced: Boolean! (scalar)
            if (this.IsTotpEnforced != null)
            {
                 s += ind + "isTotpEnforced\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? TrustedCerts
            // GraphQL -> trustedCerts: String (scalar)
            if (this.TrustedCerts != null)
            {
                 s += ind + "trustedCerts\n";

            }
            //      C# -> System.String? UserNameAttr
            // GraphQL -> userNameAttr: String (scalar)
            if (this.UserNameAttr != null)
            {
                 s += ind + "userNameAttr\n";

            }
            //      C# -> System.String? UserSearchFilter
            // GraphQL -> userSearchFilter: String (scalar)
            if (this.UserSearchFilter != null)
            {
                 s += ind + "userSearchFilter\n";

            }
            //      C# -> List<LdapServer>? LdapServers
            // GraphQL -> ldapServers: [LdapServer!]! (type)
            if (this.LdapServers != null)
            {
                 s += ind + "ldapServers\n";

                 s += ind + "{\n" + 
                 this.LdapServers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BaseDn
            // GraphQL -> baseDn: String! (scalar)
            if (this.BaseDn == null && Exploration.Includes(parent + ".baseDn$"))
            {
                this.BaseDn = new System.String("FETCH");
            }
            //      C# -> System.String? BindUserName
            // GraphQL -> bindUserName: String! (scalar)
            if (this.BindUserName == null && Exploration.Includes(parent + ".bindUserName$"))
            {
                this.BindUserName = new System.String("FETCH");
            }
            //      C# -> System.String? DynamicDnsName
            // GraphQL -> dynamicDnsName: String! (scalar)
            if (this.DynamicDnsName == null && Exploration.Includes(parent + ".dynamicDnsName$"))
            {
                this.DynamicDnsName = new System.String("FETCH");
            }
            //      C# -> System.String? GroupMemberAttr
            // GraphQL -> groupMemberAttr: String (scalar)
            if (this.GroupMemberAttr == null && Exploration.Includes(parent + ".groupMemberAttr$"))
            {
                this.GroupMemberAttr = new System.String("FETCH");
            }
            //      C# -> System.String? GroupMembershipAttr
            // GraphQL -> groupMembershipAttr: String (scalar)
            if (this.GroupMembershipAttr == null && Exploration.Includes(parent + ".groupMembershipAttr$"))
            {
                this.GroupMembershipAttr = new System.String("FETCH");
            }
            //      C# -> System.String? GroupSearchFilter
            // GraphQL -> groupSearchFilter: String (scalar)
            if (this.GroupSearchFilter == null && Exploration.Includes(parent + ".groupSearchFilter$"))
            {
                this.GroupSearchFilter = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsTotpEnforced
            // GraphQL -> isTotpEnforced: Boolean! (scalar)
            if (this.IsTotpEnforced == null && Exploration.Includes(parent + ".isTotpEnforced$"))
            {
                this.IsTotpEnforced = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? TrustedCerts
            // GraphQL -> trustedCerts: String (scalar)
            if (this.TrustedCerts == null && Exploration.Includes(parent + ".trustedCerts$"))
            {
                this.TrustedCerts = new System.String("FETCH");
            }
            //      C# -> System.String? UserNameAttr
            // GraphQL -> userNameAttr: String (scalar)
            if (this.UserNameAttr == null && Exploration.Includes(parent + ".userNameAttr$"))
            {
                this.UserNameAttr = new System.String("FETCH");
            }
            //      C# -> System.String? UserSearchFilter
            // GraphQL -> userSearchFilter: String (scalar)
            if (this.UserSearchFilter == null && Exploration.Includes(parent + ".userSearchFilter$"))
            {
                this.UserSearchFilter = new System.String("FETCH");
            }
            //      C# -> List<LdapServer>? LdapServers
            // GraphQL -> ldapServers: [LdapServer!]! (type)
            if (this.LdapServers == null && Exploration.Includes(parent + ".ldapServers"))
            {
                this.LdapServers = new List<LdapServer>();
                this.LdapServers.ApplyExploratoryFragment(parent + ".ldapServers");
            }
        }


    #endregion

    } // class LdapIntegration
    #endregion

    public static class ListLdapIntegrationExtensions
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
            this List<LdapIntegration> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LdapIntegration> list, 
            String parent = "")
        {
            var item = new LdapIntegration();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types