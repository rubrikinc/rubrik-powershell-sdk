// AzureNativeSqlDatabasePointInTimeRestoreWindow.cs
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
    #region AzureNativeSqlDatabasePointInTimeRestoreWindow
    public class AzureNativeSqlDatabasePointInTimeRestoreWindow: IFragment
    {
        #region members
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        [JsonProperty("earliestTime")]
        public DateTime? EarliestTime { get; set; }

        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        [JsonProperty("latestTime")]
        public DateTime? LatestTime { get; set; }

        #endregion

    #region methods

    public AzureNativeSqlDatabasePointInTimeRestoreWindow Set(
        DateTime? EarliestTime = null,
        DateTime? LatestTime = null
    ) 
    {
        if ( EarliestTime != null ) {
            this.EarliestTime = EarliestTime;
        }
        if ( LatestTime != null ) {
            this.LatestTime = LatestTime;
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
            //      C# -> DateTime? EarliestTime
            // GraphQL -> earliestTime: DateTime (scalar)
            if (this.EarliestTime != null)
            {
                 s += ind + "earliestTime\n";

            }
            //      C# -> DateTime? LatestTime
            // GraphQL -> latestTime: DateTime (scalar)
            if (this.LatestTime != null)
            {
                 s += ind + "latestTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? EarliestTime
            // GraphQL -> earliestTime: DateTime (scalar)
            if (this.EarliestTime == null && Exploration.Includes(parent + ".earliestTime$"))
            {
                this.EarliestTime = new DateTime();
            }
            //      C# -> DateTime? LatestTime
            // GraphQL -> latestTime: DateTime (scalar)
            if (this.LatestTime == null && Exploration.Includes(parent + ".latestTime$"))
            {
                this.LatestTime = new DateTime();
            }
        }


    #endregion

    } // class AzureNativeSqlDatabasePointInTimeRestoreWindow
    #endregion

    public static class ListAzureNativeSqlDatabasePointInTimeRestoreWindowExtensions
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
            this List<AzureNativeSqlDatabasePointInTimeRestoreWindow> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeSqlDatabasePointInTimeRestoreWindow> list, 
            String parent = "")
        {
            var item = new AzureNativeSqlDatabasePointInTimeRestoreWindow();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types