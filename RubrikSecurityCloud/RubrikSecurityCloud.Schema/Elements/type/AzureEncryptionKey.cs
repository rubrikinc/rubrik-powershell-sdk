// AzureEncryptionKey.cs
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
    #region AzureEncryptionKey
    public class AzureEncryptionKey: IFragment
    {
        #region members
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        #endregion

    #region methods

    public AzureEncryptionKey Set(
        System.String? KeyName = null
    ) 
    {
        if ( KeyName != null ) {
            this.KeyName = KeyName;
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
            //      C# -> System.String? KeyName
            // GraphQL -> keyName: String! (scalar)
            if (this.KeyName != null)
            {
                 s += ind + "keyName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? KeyName
            // GraphQL -> keyName: String! (scalar)
            if (this.KeyName == null && Exploration.Includes(parent + ".keyName$"))
            {
                this.KeyName = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureEncryptionKey
    #endregion

    public static class ListAzureEncryptionKeyExtensions
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
            this List<AzureEncryptionKey> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureEncryptionKey> list, 
            String parent = "")
        {
            var item = new AzureEncryptionKey();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types