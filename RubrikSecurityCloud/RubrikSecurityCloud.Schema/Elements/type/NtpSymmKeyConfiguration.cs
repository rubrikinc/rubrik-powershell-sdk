// NtpSymmKeyConfiguration.cs
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
    #region NtpSymmKeyConfiguration
    public class NtpSymmKeyConfiguration: IFragment
    {
        #region members
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Int32? KeyId
        // GraphQL -> keyId: Int! (scalar)
        [JsonProperty("keyId")]
        public System.Int32? KeyId { get; set; }

        //      C# -> System.String? KeyType
        // GraphQL -> keyType: String! (scalar)
        [JsonProperty("keyType")]
        public System.String? KeyType { get; set; }

        #endregion

    #region methods

    public NtpSymmKeyConfiguration Set(
        System.String? Key = null,
        System.Int32? KeyId = null,
        System.String? KeyType = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyId != null ) {
            this.KeyId = KeyId;
        }
        if ( KeyType != null ) {
            this.KeyType = KeyType;
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
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
            //      C# -> System.Int32? KeyId
            // GraphQL -> keyId: Int! (scalar)
            if (this.KeyId != null)
            {
                 s += ind + "keyId\n";

            }
            //      C# -> System.String? KeyType
            // GraphQL -> keyType: String! (scalar)
            if (this.KeyType != null)
            {
                 s += ind + "keyType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new System.String("FETCH");
            }
            //      C# -> System.Int32? KeyId
            // GraphQL -> keyId: Int! (scalar)
            if (this.KeyId == null && Exploration.Includes(parent + ".keyId$"))
            {
                this.KeyId = new System.Int32();
            }
            //      C# -> System.String? KeyType
            // GraphQL -> keyType: String! (scalar)
            if (this.KeyType == null && Exploration.Includes(parent + ".keyType$"))
            {
                this.KeyType = new System.String("FETCH");
            }
        }


    #endregion

    } // class NtpSymmKeyConfiguration
    #endregion

    public static class ListNtpSymmKeyConfigurationExtensions
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
            this List<NtpSymmKeyConfiguration> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NtpSymmKeyConfiguration> list, 
            String parent = "")
        {
            var item = new NtpSymmKeyConfiguration();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types