// CloudInstantiationSpec.cs
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
    #region CloudInstantiationSpec
    public class CloudInstantiationSpec: IFragment
    {
        #region members
        //      C# -> System.Int64? ImageRetentionInSeconds
        // GraphQL -> imageRetentionInSeconds: Long! (scalar)
        [JsonProperty("imageRetentionInSeconds")]
        public System.Int64? ImageRetentionInSeconds { get; set; }

        #endregion

    #region methods

    public CloudInstantiationSpec Set(
        System.Int64? ImageRetentionInSeconds = null
    ) 
    {
        if ( ImageRetentionInSeconds != null ) {
            this.ImageRetentionInSeconds = ImageRetentionInSeconds;
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
            //      C# -> System.Int64? ImageRetentionInSeconds
            // GraphQL -> imageRetentionInSeconds: Long! (scalar)
            if (this.ImageRetentionInSeconds != null)
            {
                 s += ind + "imageRetentionInSeconds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ImageRetentionInSeconds
            // GraphQL -> imageRetentionInSeconds: Long! (scalar)
            if (this.ImageRetentionInSeconds == null && Exploration.Includes(parent + ".imageRetentionInSeconds$"))
            {
                this.ImageRetentionInSeconds = new System.Int64();
            }
        }


    #endregion

    } // class CloudInstantiationSpec
    #endregion

    public static class ListCloudInstantiationSpecExtensions
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
            this List<CloudInstantiationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudInstantiationSpec> list, 
            String parent = "")
        {
            var item = new CloudInstantiationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types