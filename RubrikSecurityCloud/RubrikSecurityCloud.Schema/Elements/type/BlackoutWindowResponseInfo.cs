// BlackoutWindowResponseInfo.cs
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
    #region BlackoutWindowResponseInfo
    public class BlackoutWindowResponseInfo: IFragment
    {
        #region members
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        [JsonProperty("blackoutWindowStatus")]
        public BlackoutWindowStatus? BlackoutWindowStatus { get; set; }

        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        [JsonProperty("blackoutWindows")]
        public BlackoutWindows? BlackoutWindows { get; set; }

        #endregion

    #region methods

    public BlackoutWindowResponseInfo Set(
        BlackoutWindowStatus? BlackoutWindowStatus = null,
        BlackoutWindows? BlackoutWindows = null
    ) 
    {
        if ( BlackoutWindowStatus != null ) {
            this.BlackoutWindowStatus = BlackoutWindowStatus;
        }
        if ( BlackoutWindows != null ) {
            this.BlackoutWindows = BlackoutWindows;
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
            //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
            // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
            if (this.BlackoutWindowStatus != null)
            {
                 s += ind + "blackoutWindowStatus\n";

                 s += ind + "{\n" + 
                 this.BlackoutWindowStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> BlackoutWindows? BlackoutWindows
            // GraphQL -> blackoutWindows: BlackoutWindows (type)
            if (this.BlackoutWindows != null)
            {
                 s += ind + "blackoutWindows\n";

                 s += ind + "{\n" + 
                 this.BlackoutWindows.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
            // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
            if (this.BlackoutWindowStatus == null && Exploration.Includes(parent + ".blackoutWindowStatus"))
            {
                this.BlackoutWindowStatus = new BlackoutWindowStatus();
                this.BlackoutWindowStatus.ApplyExploratoryFragment(parent + ".blackoutWindowStatus");
            }
            //      C# -> BlackoutWindows? BlackoutWindows
            // GraphQL -> blackoutWindows: BlackoutWindows (type)
            if (this.BlackoutWindows == null && Exploration.Includes(parent + ".blackoutWindows"))
            {
                this.BlackoutWindows = new BlackoutWindows();
                this.BlackoutWindows.ApplyExploratoryFragment(parent + ".blackoutWindows");
            }
        }


    #endregion

    } // class BlackoutWindowResponseInfo
    #endregion

    public static class ListBlackoutWindowResponseInfoExtensions
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
            this List<BlackoutWindowResponseInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BlackoutWindowResponseInfo> list, 
            String parent = "")
        {
            var item = new BlackoutWindowResponseInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types