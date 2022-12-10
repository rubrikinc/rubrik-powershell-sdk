// BlackoutWindowStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    #region BlackoutWindowStatus
    public class BlackoutWindowStatus: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsGlobalBlackoutActive
        // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
        [JsonProperty("isGlobalBlackoutActive")]
        public System.Boolean? IsGlobalBlackoutActive { get; set; }

        //      C# -> System.Boolean? IsSnappableBlackoutActive
        // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
        [JsonProperty("isSnappableBlackoutActive")]
        public System.Boolean? IsSnappableBlackoutActive { get; set; }

        #endregion

    #region methods

    public BlackoutWindowStatus Set(
        System.Boolean? IsGlobalBlackoutActive = null,
        System.Boolean? IsSnappableBlackoutActive = null
    ) 
    {
        if ( IsGlobalBlackoutActive != null ) {
            this.IsGlobalBlackoutActive = IsGlobalBlackoutActive;
        }
        if ( IsSnappableBlackoutActive != null ) {
            this.IsSnappableBlackoutActive = IsSnappableBlackoutActive;
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
            //      C# -> System.Boolean? IsGlobalBlackoutActive
            // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
            if (this.IsGlobalBlackoutActive != null)
            {
                 s += ind + "isGlobalBlackoutActive\n";

            }
            //      C# -> System.Boolean? IsSnappableBlackoutActive
            // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
            if (this.IsSnappableBlackoutActive != null)
            {
                 s += ind + "isSnappableBlackoutActive\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsGlobalBlackoutActive
            // GraphQL -> isGlobalBlackoutActive: Boolean! (scalar)
            if (this.IsGlobalBlackoutActive == null && Exploration.Includes(parent + ".isGlobalBlackoutActive$"))
            {
                this.IsGlobalBlackoutActive = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSnappableBlackoutActive
            // GraphQL -> isSnappableBlackoutActive: Boolean (scalar)
            if (this.IsSnappableBlackoutActive == null && Exploration.Includes(parent + ".isSnappableBlackoutActive$"))
            {
                this.IsSnappableBlackoutActive = new System.Boolean();
            }
        }


    #endregion

    } // class BlackoutWindowStatus
    #endregion

    public static class ListBlackoutWindowStatusExtensions
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
            this List<BlackoutWindowStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BlackoutWindowStatus> list, 
            String parent = "")
        {
            var item = new BlackoutWindowStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types