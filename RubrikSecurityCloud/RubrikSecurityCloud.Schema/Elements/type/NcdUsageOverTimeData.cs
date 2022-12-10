// NcdUsageOverTimeData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:12.
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
    #region NcdUsageOverTimeData
    public class NcdUsageOverTimeData: IFragment
    {
        #region members
        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        [JsonProperty("changeInBytes")]
        public System.Int64? ChangeInBytes { get; set; }

        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        [JsonProperty("newInBytes")]
        public System.Int64? NewInBytes { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }

        #endregion

    #region methods

    public NcdUsageOverTimeData Set(
        System.Int64? ChangeInBytes = null,
        System.Int64? NewInBytes = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( ChangeInBytes != null ) {
            this.ChangeInBytes = ChangeInBytes;
        }
        if ( NewInBytes != null ) {
            this.NewInBytes = NewInBytes;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
            //      C# -> System.Int64? ChangeInBytes
            // GraphQL -> changeInBytes: Long! (scalar)
            if (this.ChangeInBytes != null)
            {
                 s += ind + "changeInBytes\n";

            }
            //      C# -> System.Int64? NewInBytes
            // GraphQL -> newInBytes: Long! (scalar)
            if (this.NewInBytes != null)
            {
                 s += ind + "newInBytes\n";

            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ChangeInBytes
            // GraphQL -> changeInBytes: Long! (scalar)
            if (this.ChangeInBytes == null && Exploration.Includes(parent + ".changeInBytes$"))
            {
                this.ChangeInBytes = new System.Int64();
            }
            //      C# -> System.Int64? NewInBytes
            // GraphQL -> newInBytes: Long! (scalar)
            if (this.NewInBytes == null && Exploration.Includes(parent + ".newInBytes$"))
            {
                this.NewInBytes = new System.Int64();
            }
            //      C# -> DateTime? Timestamp
            // GraphQL -> timestamp: DateTime (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new DateTime();
            }
        }


    #endregion

    } // class NcdUsageOverTimeData
    #endregion

    public static class ListNcdUsageOverTimeDataExtensions
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
            this List<NcdUsageOverTimeData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdUsageOverTimeData> list, 
            String parent = "")
        {
            var item = new NcdUsageOverTimeData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types