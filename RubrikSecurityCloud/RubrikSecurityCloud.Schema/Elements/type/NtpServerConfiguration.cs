// NtpServerConfiguration.cs
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
    #region NtpServerConfiguration
    public class NtpServerConfiguration: IFragment
    {
        #region members
        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        [JsonProperty("server")]
        public System.String? Server { get; set; }

        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        [JsonProperty("symmetricKey")]
        public NtpSymmKeyConfiguration? SymmetricKey { get; set; }

        #endregion

    #region methods

    public NtpServerConfiguration Set(
        System.String? Server = null,
        NtpSymmKeyConfiguration? SymmetricKey = null
    ) 
    {
        if ( Server != null ) {
            this.Server = Server;
        }
        if ( SymmetricKey != null ) {
            this.SymmetricKey = SymmetricKey;
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
            //      C# -> System.String? Server
            // GraphQL -> server: String! (scalar)
            if (this.Server != null)
            {
                 s += ind + "server\n";

            }
            //      C# -> NtpSymmKeyConfiguration? SymmetricKey
            // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
            if (this.SymmetricKey != null)
            {
                 s += ind + "symmetricKey\n";

                 s += ind + "{\n" + 
                 this.SymmetricKey.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Server
            // GraphQL -> server: String! (scalar)
            if (this.Server == null && Exploration.Includes(parent + ".server$"))
            {
                this.Server = new System.String("FETCH");
            }
            //      C# -> NtpSymmKeyConfiguration? SymmetricKey
            // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
            if (this.SymmetricKey == null && Exploration.Includes(parent + ".symmetricKey"))
            {
                this.SymmetricKey = new NtpSymmKeyConfiguration();
                this.SymmetricKey.ApplyExploratoryFragment(parent + ".symmetricKey");
            }
        }


    #endregion

    } // class NtpServerConfiguration
    #endregion

    public static class ListNtpServerConfigurationExtensions
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
            this List<NtpServerConfiguration> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NtpServerConfiguration> list, 
            String parent = "")
        {
            var item = new NtpServerConfiguration();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types