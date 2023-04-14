// ClusterProxyReply.cs
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
    #region ClusterProxyReply
    public class ClusterProxyReply: IFragment
    {
        #region members
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        [JsonProperty("server")]
        public System.String? Server { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> ProxyProtocol? Protocol
        // GraphQL -> protocol: ProxyProtocol! (enum)
        [JsonProperty("protocol")]
        public ProxyProtocol? Protocol { get; set; }

        #endregion

    #region methods

    public ClusterProxyReply Set(
        System.Int32? Port = null,
        System.String? Server = null,
        System.String? Username = null,
        ProxyProtocol? Protocol = null
    ) 
    {
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( Server != null ) {
            this.Server = Server;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
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
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> System.String? Server
            // GraphQL -> server: String! (scalar)
            if (this.Server != null)
            {
                 s += ind + "server\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> ProxyProtocol? Protocol
            // GraphQL -> protocol: ProxyProtocol! (enum)
            if (this.Protocol != null)
            {
                 s += ind + "protocol\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int32();
            }
            //      C# -> System.String? Server
            // GraphQL -> server: String! (scalar)
            if (this.Server == null && Exploration.Includes(parent + ".server$"))
            {
                this.Server = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> ProxyProtocol? Protocol
            // GraphQL -> protocol: ProxyProtocol! (enum)
            if (this.Protocol == null && Exploration.Includes(parent + ".protocol$"))
            {
                this.Protocol = new ProxyProtocol();
            }
        }


    #endregion

    } // class ClusterProxyReply
    #endregion

    public static class ListClusterProxyReplyExtensions
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
            this List<ClusterProxyReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterProxyReply> list, 
            String parent = "")
        {
            var item = new ClusterProxyReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types