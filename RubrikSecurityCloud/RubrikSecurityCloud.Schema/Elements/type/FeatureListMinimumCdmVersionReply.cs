// FeatureListMinimumCdmVersionReply.cs
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
    #region FeatureListMinimumCdmVersionReply
    public class FeatureListMinimumCdmVersionReply: IFragment
    {
        #region members
        //      C# -> System.String? MinimumVersion
        // GraphQL -> minimumVersion: String! (scalar)
        [JsonProperty("minimumVersion")]
        public System.String? MinimumVersion { get; set; }

        #endregion

    #region methods

    public FeatureListMinimumCdmVersionReply Set(
        System.String? MinimumVersion = null
    ) 
    {
        if ( MinimumVersion != null ) {
            this.MinimumVersion = MinimumVersion;
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
            //      C# -> System.String? MinimumVersion
            // GraphQL -> minimumVersion: String! (scalar)
            if (this.MinimumVersion != null)
            {
                 s += ind + "minimumVersion\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? MinimumVersion
            // GraphQL -> minimumVersion: String! (scalar)
            if (this.MinimumVersion == null && Exploration.Includes(parent + ".minimumVersion$"))
            {
                this.MinimumVersion = new System.String("FETCH");
            }
        }


    #endregion

    } // class FeatureListMinimumCdmVersionReply
    #endregion

    public static class ListFeatureListMinimumCdmVersionReplyExtensions
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
            this List<FeatureListMinimumCdmVersionReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FeatureListMinimumCdmVersionReply> list, 
            String parent = "")
        {
            var item = new FeatureListMinimumCdmVersionReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types