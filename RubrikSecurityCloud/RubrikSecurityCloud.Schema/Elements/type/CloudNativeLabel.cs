// CloudNativeLabel.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
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
    #region CloudNativeLabel
    public class CloudNativeLabel: IFragment
    {
        #region members
        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        [JsonProperty("labelKey")]
        public System.String? LabelKey { get; set; }

        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        [JsonProperty("labelValue")]
        public System.String? LabelValue { get; set; }

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }

        #endregion

    #region methods

    public CloudNativeLabel Set(
        System.String? LabelKey = null,
        System.String? LabelValue = null,
        System.Boolean? MatchAllValues = null
    ) 
    {
        if ( LabelKey != null ) {
            this.LabelKey = LabelKey;
        }
        if ( LabelValue != null ) {
            this.LabelValue = LabelValue;
        }
        if ( MatchAllValues != null ) {
            this.MatchAllValues = MatchAllValues;
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
            //      C# -> System.String? LabelKey
            // GraphQL -> labelKey: String! (scalar)
            if (this.LabelKey != null)
            {
                 s += ind + "labelKey\n";

            }
            //      C# -> System.String? LabelValue
            // GraphQL -> labelValue: String! (scalar)
            if (this.LabelValue != null)
            {
                 s += ind + "labelValue\n";

            }
            //      C# -> System.Boolean? MatchAllValues
            // GraphQL -> matchAllValues: Boolean! (scalar)
            if (this.MatchAllValues != null)
            {
                 s += ind + "matchAllValues\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? LabelKey
            // GraphQL -> labelKey: String! (scalar)
            if (this.LabelKey == null && Exploration.Includes(parent + ".labelKey$"))
            {
                this.LabelKey = new System.String("FETCH");
            }
            //      C# -> System.String? LabelValue
            // GraphQL -> labelValue: String! (scalar)
            if (this.LabelValue == null && Exploration.Includes(parent + ".labelValue$"))
            {
                this.LabelValue = new System.String("FETCH");
            }
            //      C# -> System.Boolean? MatchAllValues
            // GraphQL -> matchAllValues: Boolean! (scalar)
            if (this.MatchAllValues == null && Exploration.Includes(parent + ".matchAllValues$"))
            {
                this.MatchAllValues = new System.Boolean();
            }
        }


    #endregion

    } // class CloudNativeLabel
    #endregion

    public static class ListCloudNativeLabelExtensions
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
            this List<CloudNativeLabel> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeLabel> list, 
            String parent = "")
        {
            var item = new CloudNativeLabel();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types