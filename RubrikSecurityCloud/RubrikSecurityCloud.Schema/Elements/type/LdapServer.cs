// LdapServer.cs
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
    #region LdapServer
    public class LdapServer: IFragment
    {
        #region members
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.Boolean? UseTls
        // GraphQL -> useTls: Boolean! (scalar)
        [JsonProperty("useTls")]
        public System.Boolean? UseTls { get; set; }

        #endregion

    #region methods

    public LdapServer Set(
        System.String? Hostname = null,
        System.Int32? Port = null,
        System.Boolean? UseTls = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( UseTls != null ) {
            this.UseTls = UseTls;
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
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> System.Boolean? UseTls
            // GraphQL -> useTls: Boolean! (scalar)
            if (this.UseTls != null)
            {
                 s += ind + "useTls\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int32();
            }
            //      C# -> System.Boolean? UseTls
            // GraphQL -> useTls: Boolean! (scalar)
            if (this.UseTls == null && Exploration.Includes(parent + ".useTls$"))
            {
                this.UseTls = new System.Boolean();
            }
        }


    #endregion

    } // class LdapServer
    #endregion

    public static class ListLdapServerExtensions
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
            this List<LdapServer> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LdapServer> list, 
            String parent = "")
        {
            var item = new LdapServer();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types