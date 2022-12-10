// ManagedVolumeSmbShare.cs
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
    #region ManagedVolumeSmbShare
    public class ManagedVolumeSmbShare: IFragment
    {
        #region members
        //      C# -> List<System.String>? ActiveDirectoryGroups
        // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
        [JsonProperty("activeDirectoryGroups")]
        public List<System.String>? ActiveDirectoryGroups { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!]! (scalar)
        [JsonProperty("validIps")]
        public List<System.String>? ValidIps { get; set; }

        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!]! (scalar)
        [JsonProperty("validUsers")]
        public List<System.String>? ValidUsers { get; set; }

        #endregion

    #region methods

    public ManagedVolumeSmbShare Set(
        List<System.String>? ActiveDirectoryGroups = null,
        System.String? DomainName = null,
        List<System.String>? ValidIps = null,
        List<System.String>? ValidUsers = null
    ) 
    {
        if ( ActiveDirectoryGroups != null ) {
            this.ActiveDirectoryGroups = ActiveDirectoryGroups;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( ValidIps != null ) {
            this.ValidIps = ValidIps;
        }
        if ( ValidUsers != null ) {
            this.ValidUsers = ValidUsers;
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
            //      C# -> List<System.String>? ActiveDirectoryGroups
            // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
            if (this.ActiveDirectoryGroups != null)
            {
                 s += ind + "activeDirectoryGroups\n";

            }
            //      C# -> System.String? DomainName
            // GraphQL -> domainName: String! (scalar)
            if (this.DomainName != null)
            {
                 s += ind + "domainName\n";

            }
            //      C# -> List<System.String>? ValidIps
            // GraphQL -> validIps: [String!]! (scalar)
            if (this.ValidIps != null)
            {
                 s += ind + "validIps\n";

            }
            //      C# -> List<System.String>? ValidUsers
            // GraphQL -> validUsers: [String!]! (scalar)
            if (this.ValidUsers != null)
            {
                 s += ind + "validUsers\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ActiveDirectoryGroups
            // GraphQL -> activeDirectoryGroups: [String!]! (scalar)
            if (this.ActiveDirectoryGroups == null && Exploration.Includes(parent + ".activeDirectoryGroups$"))
            {
                this.ActiveDirectoryGroups = new List<System.String>();
            }
            //      C# -> System.String? DomainName
            // GraphQL -> domainName: String! (scalar)
            if (this.DomainName == null && Exploration.Includes(parent + ".domainName$"))
            {
                this.DomainName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? ValidIps
            // GraphQL -> validIps: [String!]! (scalar)
            if (this.ValidIps == null && Exploration.Includes(parent + ".validIps$"))
            {
                this.ValidIps = new List<System.String>();
            }
            //      C# -> List<System.String>? ValidUsers
            // GraphQL -> validUsers: [String!]! (scalar)
            if (this.ValidUsers == null && Exploration.Includes(parent + ".validUsers$"))
            {
                this.ValidUsers = new List<System.String>();
            }
        }


    #endregion

    } // class ManagedVolumeSmbShare
    #endregion

    public static class ListManagedVolumeSmbShareExtensions
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
            this List<ManagedVolumeSmbShare> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSmbShare> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSmbShare();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types