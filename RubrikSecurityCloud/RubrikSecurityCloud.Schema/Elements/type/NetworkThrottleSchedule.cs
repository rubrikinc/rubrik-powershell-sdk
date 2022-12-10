// NetworkThrottleSchedule.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    #region NetworkThrottleSchedule
    public class NetworkThrottleSchedule: IFragment
    {
        #region members
        //      C# -> System.Int32? EndHour
        // GraphQL -> endHour: Int! (scalar)
        [JsonProperty("endHour")]
        public System.Int32? EndHour { get; set; }

        //      C# -> System.Int32? StartHour
        // GraphQL -> startHour: Int! (scalar)
        [JsonProperty("startHour")]
        public System.Int32? StartHour { get; set; }

        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        [JsonProperty("throttleLimit")]
        public System.Single? ThrottleLimit { get; set; }

        //      C# -> List<DayOfWeek>? DaysOfWeek
        // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
        [JsonProperty("daysOfWeek")]
        public List<DayOfWeek>? DaysOfWeek { get; set; }

        #endregion

    #region methods

    public NetworkThrottleSchedule Set(
        System.Int32? EndHour = null,
        System.Int32? StartHour = null,
        System.Single? ThrottleLimit = null,
        List<DayOfWeek>? DaysOfWeek = null
    ) 
    {
        if ( EndHour != null ) {
            this.EndHour = EndHour;
        }
        if ( StartHour != null ) {
            this.StartHour = StartHour;
        }
        if ( ThrottleLimit != null ) {
            this.ThrottleLimit = ThrottleLimit;
        }
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
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
            //      C# -> System.Int32? EndHour
            // GraphQL -> endHour: Int! (scalar)
            if (this.EndHour != null)
            {
                 s += ind + "endHour\n";

            }
            //      C# -> System.Int32? StartHour
            // GraphQL -> startHour: Int! (scalar)
            if (this.StartHour != null)
            {
                 s += ind + "startHour\n";

            }
            //      C# -> System.Single? ThrottleLimit
            // GraphQL -> throttleLimit: Float! (scalar)
            if (this.ThrottleLimit != null)
            {
                 s += ind + "throttleLimit\n";

            }
            //      C# -> List<DayOfWeek>? DaysOfWeek
            // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
            if (this.DaysOfWeek != null)
            {
                 s += ind + "daysOfWeek\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? EndHour
            // GraphQL -> endHour: Int! (scalar)
            if (this.EndHour == null && Exploration.Includes(parent + ".endHour$"))
            {
                this.EndHour = new System.Int32();
            }
            //      C# -> System.Int32? StartHour
            // GraphQL -> startHour: Int! (scalar)
            if (this.StartHour == null && Exploration.Includes(parent + ".startHour$"))
            {
                this.StartHour = new System.Int32();
            }
            //      C# -> System.Single? ThrottleLimit
            // GraphQL -> throttleLimit: Float! (scalar)
            if (this.ThrottleLimit == null && Exploration.Includes(parent + ".throttleLimit$"))
            {
                this.ThrottleLimit = new System.Single();
            }
            //      C# -> List<DayOfWeek>? DaysOfWeek
            // GraphQL -> daysOfWeek: [DayOfWeek!]! (enum)
            if (this.DaysOfWeek == null && Exploration.Includes(parent + ".daysOfWeek$"))
            {
                this.DaysOfWeek = new List<DayOfWeek>();
            }
        }


    #endregion

    } // class NetworkThrottleSchedule
    #endregion

    public static class ListNetworkThrottleScheduleExtensions
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
            this List<NetworkThrottleSchedule> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NetworkThrottleSchedule> list, 
            String parent = "")
        {
            var item = new NetworkThrottleSchedule();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types