// GetWorkloadAlertSettingReply.cs
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
    #region GetWorkloadAlertSettingReply
    public class GetWorkloadAlertSettingReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        #endregion

    #region methods

    public GetWorkloadAlertSettingReply Set(
        System.Boolean? Enabled = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
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
            //      C# -> System.Boolean? Enabled
            // GraphQL -> enabled: Boolean! (scalar)
            if (this.Enabled != null)
            {
                 s += ind + "enabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? Enabled
            // GraphQL -> enabled: Boolean! (scalar)
            if (this.Enabled == null && Exploration.Includes(parent + ".enabled$"))
            {
                this.Enabled = new System.Boolean();
            }
        }


    #endregion

    } // class GetWorkloadAlertSettingReply
    #endregion

    public static class ListGetWorkloadAlertSettingReplyExtensions
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
            this List<GetWorkloadAlertSettingReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetWorkloadAlertSettingReply> list, 
            String parent = "")
        {
            var item = new GetWorkloadAlertSettingReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types