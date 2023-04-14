// HdfsBaseConfig.cs
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
    #region HdfsBaseConfig
    public class HdfsBaseConfig: IFragment
    {
        #region members
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        [JsonProperty("kerberosTicket")]
        public System.String? KerberosTicket { get; set; }

        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        [JsonProperty("nameservices")]
        public System.String? Nameservices { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        [JsonProperty("hosts")]
        public List<HdfsHost>? Hosts { get; set; }

        #endregion

    #region methods

    public HdfsBaseConfig Set(
        System.String? ApiToken = null,
        System.String? KerberosTicket = null,
        System.String? Nameservices = null,
        System.String? Username = null,
        List<HdfsHost>? Hosts = null
    ) 
    {
        if ( ApiToken != null ) {
            this.ApiToken = ApiToken;
        }
        if ( KerberosTicket != null ) {
            this.KerberosTicket = KerberosTicket;
        }
        if ( Nameservices != null ) {
            this.Nameservices = Nameservices;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
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
            //      C# -> System.String? ApiToken
            // GraphQL -> apiToken: String (scalar)
            if (this.ApiToken != null)
            {
                 s += ind + "apiToken\n";

            }
            //      C# -> System.String? KerberosTicket
            // GraphQL -> kerberosTicket: String (scalar)
            if (this.KerberosTicket != null)
            {
                 s += ind + "kerberosTicket\n";

            }
            //      C# -> System.String? Nameservices
            // GraphQL -> nameservices: String (scalar)
            if (this.Nameservices != null)
            {
                 s += ind + "nameservices\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> List<HdfsHost>? Hosts
            // GraphQL -> hosts: [HdfsHost!]! (type)
            if (this.Hosts != null)
            {
                 s += ind + "hosts\n";

                 s += ind + "{\n" + 
                 this.Hosts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ApiToken
            // GraphQL -> apiToken: String (scalar)
            if (this.ApiToken == null && Exploration.Includes(parent + ".apiToken$"))
            {
                this.ApiToken = new System.String("FETCH");
            }
            //      C# -> System.String? KerberosTicket
            // GraphQL -> kerberosTicket: String (scalar)
            if (this.KerberosTicket == null && Exploration.Includes(parent + ".kerberosTicket$"))
            {
                this.KerberosTicket = new System.String("FETCH");
            }
            //      C# -> System.String? Nameservices
            // GraphQL -> nameservices: String (scalar)
            if (this.Nameservices == null && Exploration.Includes(parent + ".nameservices$"))
            {
                this.Nameservices = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> List<HdfsHost>? Hosts
            // GraphQL -> hosts: [HdfsHost!]! (type)
            if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
            {
                this.Hosts = new List<HdfsHost>();
                this.Hosts.ApplyExploratoryFragment(parent + ".hosts");
            }
        }


    #endregion

    } // class HdfsBaseConfig
    #endregion

    public static class ListHdfsBaseConfigExtensions
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
            this List<HdfsBaseConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HdfsBaseConfig> list, 
            String parent = "")
        {
            var item = new HdfsBaseConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types