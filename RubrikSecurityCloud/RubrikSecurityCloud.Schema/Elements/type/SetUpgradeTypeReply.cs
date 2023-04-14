// SetUpgradeTypeReply.cs
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
    #region SetUpgradeTypeReply
    public class SetUpgradeTypeReply: IFragment
    {
        #region members
        //      C# -> System.String? Code
        // GraphQL -> code: String! (scalar)
        [JsonProperty("code")]
        public System.String? Code { get; set; }

        //      C# -> System.String? Excepshuns
        // GraphQL -> excepshuns: String! (scalar)
        [JsonProperty("excepshuns")]
        public System.String? Excepshuns { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        #endregion

    #region methods

    public SetUpgradeTypeReply Set(
        System.String? Code = null,
        System.String? Excepshuns = null,
        System.String? Message = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( Excepshuns != null ) {
            this.Excepshuns = Excepshuns;
        }
        if ( Message != null ) {
            this.Message = Message;
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
            //      C# -> System.String? Code
            // GraphQL -> code: String! (scalar)
            if (this.Code != null)
            {
                 s += ind + "code\n";

            }
            //      C# -> System.String? Excepshuns
            // GraphQL -> excepshuns: String! (scalar)
            if (this.Excepshuns != null)
            {
                 s += ind + "excepshuns\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Code
            // GraphQL -> code: String! (scalar)
            if (this.Code == null && Exploration.Includes(parent + ".code$"))
            {
                this.Code = new System.String("FETCH");
            }
            //      C# -> System.String? Excepshuns
            // GraphQL -> excepshuns: String! (scalar)
            if (this.Excepshuns == null && Exploration.Includes(parent + ".excepshuns$"))
            {
                this.Excepshuns = new System.String("FETCH");
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
        }


    #endregion

    } // class SetUpgradeTypeReply
    #endregion

    public static class ListSetUpgradeTypeReplyExtensions
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
            this List<SetUpgradeTypeReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SetUpgradeTypeReply> list, 
            String parent = "")
        {
            var item = new SetUpgradeTypeReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types