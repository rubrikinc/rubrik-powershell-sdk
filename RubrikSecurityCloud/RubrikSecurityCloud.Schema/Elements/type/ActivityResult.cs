// ActivityResult.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    #region ActivityResult
    public class ActivityResult: IFragment
    {
        #region members
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.Int64? CountDelta
        // GraphQL -> countDelta: Long! (scalar)
        [JsonProperty("countDelta")]
        public System.Int64? CountDelta { get; set; }

        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        [JsonProperty("accessType")]
        public ActivityAccessType? AccessType { get; set; }

        #endregion

    #region methods

    public ActivityResult Set(
        System.Int64? Count = null,
        System.Int64? CountDelta = null,
        ActivityAccessType? AccessType = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CountDelta != null ) {
            this.CountDelta = CountDelta;
        }
        if ( AccessType != null ) {
            this.AccessType = AccessType;
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
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.Int64? CountDelta
            // GraphQL -> countDelta: Long! (scalar)
            if (this.CountDelta != null)
            {
                 s += ind + "countDelta\n";

            }
            //      C# -> ActivityAccessType? AccessType
            // GraphQL -> accessType: ActivityAccessType! (enum)
            if (this.AccessType != null)
            {
                 s += ind + "accessType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int64();
            }
            //      C# -> System.Int64? CountDelta
            // GraphQL -> countDelta: Long! (scalar)
            if (this.CountDelta == null && Exploration.Includes(parent + ".countDelta$"))
            {
                this.CountDelta = new System.Int64();
            }
            //      C# -> ActivityAccessType? AccessType
            // GraphQL -> accessType: ActivityAccessType! (enum)
            if (this.AccessType == null && Exploration.Includes(parent + ".accessType$"))
            {
                this.AccessType = new ActivityAccessType();
            }
        }


    #endregion

    } // class ActivityResult
    #endregion

    public static class ListActivityResultExtensions
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
            this List<ActivityResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ActivityResult> list, 
            String parent = "")
        {
            var item = new ActivityResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types