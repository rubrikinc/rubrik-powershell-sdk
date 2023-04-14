// ClusterDnsReply.cs
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
    #region ClusterDnsReply
    public class ClusterDnsReply: IFragment
    {
        #region members
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }

        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        [JsonProperty("servers")]
        public List<System.String>? Servers { get; set; }

        #endregion

    #region methods

    public ClusterDnsReply Set(
        List<System.String>? Domains = null,
        List<System.String>? Servers = null
    ) 
    {
        if ( Domains != null ) {
            this.Domains = Domains;
        }
        if ( Servers != null ) {
            this.Servers = Servers;
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
            //      C# -> List<System.String>? Domains
            // GraphQL -> domains: [String!]! (scalar)
            if (this.Domains != null)
            {
                 s += ind + "domains\n";

            }
            //      C# -> List<System.String>? Servers
            // GraphQL -> servers: [String!]! (scalar)
            if (this.Servers != null)
            {
                 s += ind + "servers\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Domains
            // GraphQL -> domains: [String!]! (scalar)
            if (this.Domains == null && Exploration.Includes(parent + ".domains$"))
            {
                this.Domains = new List<System.String>();
            }
            //      C# -> List<System.String>? Servers
            // GraphQL -> servers: [String!]! (scalar)
            if (this.Servers == null && Exploration.Includes(parent + ".servers$"))
            {
                this.Servers = new List<System.String>();
            }
        }


    #endregion

    } // class ClusterDnsReply
    #endregion

    public static class ListClusterDnsReplyExtensions
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
            this List<ClusterDnsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterDnsReply> list, 
            String parent = "")
        {
            var item = new ClusterDnsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types