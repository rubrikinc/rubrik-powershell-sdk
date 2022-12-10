// IsCloudNativeTagRuleNameUniqueReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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
    #region IsCloudNativeTagRuleNameUniqueReply
    public class IsCloudNativeTagRuleNameUniqueReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsUnique
        // GraphQL -> isUnique: Boolean! (scalar)
        [JsonProperty("isUnique")]
        public System.Boolean? IsUnique { get; set; }

        #endregion

    #region methods

    public IsCloudNativeTagRuleNameUniqueReply Set(
        System.Boolean? IsUnique = null
    ) 
    {
        if ( IsUnique != null ) {
            this.IsUnique = IsUnique;
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
            //      C# -> System.Boolean? IsUnique
            // GraphQL -> isUnique: Boolean! (scalar)
            if (this.IsUnique != null)
            {
                 s += ind + "isUnique\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsUnique
            // GraphQL -> isUnique: Boolean! (scalar)
            if (this.IsUnique == null && Exploration.Includes(parent + ".isUnique$"))
            {
                this.IsUnique = new System.Boolean();
            }
        }


    #endregion

    } // class IsCloudNativeTagRuleNameUniqueReply
    #endregion

    public static class ListIsCloudNativeTagRuleNameUniqueReplyExtensions
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
            this List<IsCloudNativeTagRuleNameUniqueReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<IsCloudNativeTagRuleNameUniqueReply> list, 
            String parent = "")
        {
            var item = new IsCloudNativeTagRuleNameUniqueReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types