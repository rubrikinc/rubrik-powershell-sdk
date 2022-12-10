// NcdFilesObjectProtectionStatusData.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    #region NcdFilesObjectProtectionStatusData
    public class NcdFilesObjectProtectionStatusData: IFragment
    {
        #region members
        //      C# -> System.Int64? Protected
        // GraphQL -> protected: Long! (scalar)
        [JsonProperty("protected")]
        public System.Int64? Protected { get; set; }

        //      C# -> System.Int64? TotalSizeInBytes
        // GraphQL -> totalSizeInBytes: Long! (scalar)
        [JsonProperty("totalSizeInBytes")]
        public System.Int64? TotalSizeInBytes { get; set; }

        #endregion

    #region methods

    public NcdFilesObjectProtectionStatusData Set(
        System.Int64? Protected = null,
        System.Int64? TotalSizeInBytes = null
    ) 
    {
        if ( Protected != null ) {
            this.Protected = Protected;
        }
        if ( TotalSizeInBytes != null ) {
            this.TotalSizeInBytes = TotalSizeInBytes;
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
            //      C# -> System.Int64? Protected
            // GraphQL -> protected: Long! (scalar)
            if (this.Protected != null)
            {
                 s += ind + "protected\n";

            }
            //      C# -> System.Int64? TotalSizeInBytes
            // GraphQL -> totalSizeInBytes: Long! (scalar)
            if (this.TotalSizeInBytes != null)
            {
                 s += ind + "totalSizeInBytes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Protected
            // GraphQL -> protected: Long! (scalar)
            if (this.Protected == null && Exploration.Includes(parent + ".protected$"))
            {
                this.Protected = new System.Int64();
            }
            //      C# -> System.Int64? TotalSizeInBytes
            // GraphQL -> totalSizeInBytes: Long! (scalar)
            if (this.TotalSizeInBytes == null && Exploration.Includes(parent + ".totalSizeInBytes$"))
            {
                this.TotalSizeInBytes = new System.Int64();
            }
        }


    #endregion

    } // class NcdFilesObjectProtectionStatusData
    #endregion

    public static class ListNcdFilesObjectProtectionStatusDataExtensions
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
            this List<NcdFilesObjectProtectionStatusData> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdFilesObjectProtectionStatusData> list, 
            String parent = "")
        {
            var item = new NcdFilesObjectProtectionStatusData();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types