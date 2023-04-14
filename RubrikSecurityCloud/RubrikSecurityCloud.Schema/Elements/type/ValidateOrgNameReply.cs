// ValidateOrgNameReply.cs
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
    #region ValidateOrgNameReply
    public class ValidateOrgNameReply: IFragment
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> NameValidity? NameValidity
        // GraphQL -> nameValidity: NameValidity! (enum)
        [JsonProperty("nameValidity")]
        public NameValidity? NameValidity { get; set; }

        #endregion

    #region methods

    public ValidateOrgNameReply Set(
        System.String? Name = null,
        System.String? Url = null,
        NameValidity? NameValidity = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Url != null ) {
            this.Url = Url;
        }
        if ( NameValidity != null ) {
            this.NameValidity = NameValidity;
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url != null)
            {
                 s += ind + "url\n";

            }
            //      C# -> NameValidity? NameValidity
            // GraphQL -> nameValidity: NameValidity! (enum)
            if (this.NameValidity != null)
            {
                 s += ind + "nameValidity\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url == null && Exploration.Includes(parent + ".url$"))
            {
                this.Url = new System.String("FETCH");
            }
            //      C# -> NameValidity? NameValidity
            // GraphQL -> nameValidity: NameValidity! (enum)
            if (this.NameValidity == null && Exploration.Includes(parent + ".nameValidity$"))
            {
                this.NameValidity = new NameValidity();
            }
        }


    #endregion

    } // class ValidateOrgNameReply
    #endregion

    public static class ListValidateOrgNameReplyExtensions
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
            this List<ValidateOrgNameReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ValidateOrgNameReply> list, 
            String parent = "")
        {
            var item = new ValidateOrgNameReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types