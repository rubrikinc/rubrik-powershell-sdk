// KmsEncryptionKey.cs
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
    #region KmsEncryptionKey
    public class KmsEncryptionKey: IFragment
    {
        #region members
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        [JsonProperty("aliases")]
        public List<System.String>? Aliases { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        #endregion

    #region methods

    public KmsEncryptionKey Set(
        List<System.String>? Aliases = null,
        System.String? Arn = null,
        System.String? Id = null
    ) 
    {
        if ( Aliases != null ) {
            this.Aliases = Aliases;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Id != null ) {
            this.Id = Id;
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
            //      C# -> List<System.String>? Aliases
            // GraphQL -> aliases: [String!]! (scalar)
            if (this.Aliases != null)
            {
                 s += ind + "aliases\n";

            }
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn != null)
            {
                 s += ind + "arn\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Aliases
            // GraphQL -> aliases: [String!]! (scalar)
            if (this.Aliases == null && Exploration.Includes(parent + ".aliases$"))
            {
                this.Aliases = new List<System.String>();
            }
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn == null && Exploration.Includes(parent + ".arn$"))
            {
                this.Arn = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
        }


    #endregion

    } // class KmsEncryptionKey
    #endregion

    public static class ListKmsEncryptionKeyExtensions
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
            this List<KmsEncryptionKey> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<KmsEncryptionKey> list, 
            String parent = "")
        {
            var item = new KmsEncryptionKey();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types