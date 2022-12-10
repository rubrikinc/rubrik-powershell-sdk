// ManagedVolumePatchConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:28.
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
    #region ManagedVolumePatchConfig
    public class ManagedVolumePatchConfig: IFragment
    {
        #region members
        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!]! (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!]! (scalar)
        [JsonProperty("nodeHint")]
        public List<System.String>? NodeHint { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!]! (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!]! (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }

        #endregion

    #region methods

    public ManagedVolumePatchConfig Set(
        List<System.String>? HostPatterns = null,
        List<System.String>? NodeHint = null,
        System.String? SmbDomainName = null,
        List<System.String>? SmbValidIps = null,
        List<System.String>? SmbValidUsers = null
    ) 
    {
        if ( HostPatterns != null ) {
            this.HostPatterns = HostPatterns;
        }
        if ( NodeHint != null ) {
            this.NodeHint = NodeHint;
        }
        if ( SmbDomainName != null ) {
            this.SmbDomainName = SmbDomainName;
        }
        if ( SmbValidIps != null ) {
            this.SmbValidIps = SmbValidIps;
        }
        if ( SmbValidUsers != null ) {
            this.SmbValidUsers = SmbValidUsers;
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
            //      C# -> List<System.String>? HostPatterns
            // GraphQL -> hostPatterns: [String!]! (scalar)
            if (this.HostPatterns != null)
            {
                 s += ind + "hostPatterns\n";

            }
            //      C# -> List<System.String>? NodeHint
            // GraphQL -> nodeHint: [String!]! (scalar)
            if (this.NodeHint != null)
            {
                 s += ind + "nodeHint\n";

            }
            //      C# -> System.String? SmbDomainName
            // GraphQL -> smbDomainName: String (scalar)
            if (this.SmbDomainName != null)
            {
                 s += ind + "smbDomainName\n";

            }
            //      C# -> List<System.String>? SmbValidIps
            // GraphQL -> smbValidIps: [String!]! (scalar)
            if (this.SmbValidIps != null)
            {
                 s += ind + "smbValidIps\n";

            }
            //      C# -> List<System.String>? SmbValidUsers
            // GraphQL -> smbValidUsers: [String!]! (scalar)
            if (this.SmbValidUsers != null)
            {
                 s += ind + "smbValidUsers\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? HostPatterns
            // GraphQL -> hostPatterns: [String!]! (scalar)
            if (this.HostPatterns == null && Exploration.Includes(parent + ".hostPatterns$"))
            {
                this.HostPatterns = new List<System.String>();
            }
            //      C# -> List<System.String>? NodeHint
            // GraphQL -> nodeHint: [String!]! (scalar)
            if (this.NodeHint == null && Exploration.Includes(parent + ".nodeHint$"))
            {
                this.NodeHint = new List<System.String>();
            }
            //      C# -> System.String? SmbDomainName
            // GraphQL -> smbDomainName: String (scalar)
            if (this.SmbDomainName == null && Exploration.Includes(parent + ".smbDomainName$"))
            {
                this.SmbDomainName = new System.String("FETCH");
            }
            //      C# -> List<System.String>? SmbValidIps
            // GraphQL -> smbValidIps: [String!]! (scalar)
            if (this.SmbValidIps == null && Exploration.Includes(parent + ".smbValidIps$"))
            {
                this.SmbValidIps = new List<System.String>();
            }
            //      C# -> List<System.String>? SmbValidUsers
            // GraphQL -> smbValidUsers: [String!]! (scalar)
            if (this.SmbValidUsers == null && Exploration.Includes(parent + ".smbValidUsers$"))
            {
                this.SmbValidUsers = new List<System.String>();
            }
        }


    #endregion

    } // class ManagedVolumePatchConfig
    #endregion

    public static class ListManagedVolumePatchConfigExtensions
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
            this List<ManagedVolumePatchConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumePatchConfig> list, 
            String parent = "")
        {
            var item = new ManagedVolumePatchConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types