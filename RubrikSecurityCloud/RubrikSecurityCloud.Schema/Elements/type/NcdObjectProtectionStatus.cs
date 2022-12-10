// NcdObjectProtectionStatus.cs
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
    #region NcdObjectProtectionStatus
    public class NcdObjectProtectionStatus: IFragment
    {
        #region members
        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        [JsonProperty("averageFileSize")]
        public System.Int64? AverageFileSize { get; set; }

        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        [JsonProperty("throughput")]
        public System.Int64? Throughput { get; set; }

        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        [JsonProperty("files")]
        public NcdFilesObjectProtectionStatusData? Files { get; set; }

        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        [JsonProperty("shares")]
        public NcdSharesObjectProtectionStatusData? Shares { get; set; }

        #endregion

    #region methods

    public NcdObjectProtectionStatus Set(
        System.Int64? AverageFileSize = null,
        System.Int64? Throughput = null,
        NcdFilesObjectProtectionStatusData? Files = null,
        NcdSharesObjectProtectionStatusData? Shares = null
    ) 
    {
        if ( AverageFileSize != null ) {
            this.AverageFileSize = AverageFileSize;
        }
        if ( Throughput != null ) {
            this.Throughput = Throughput;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Shares != null ) {
            this.Shares = Shares;
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
            //      C# -> System.Int64? AverageFileSize
            // GraphQL -> averageFileSize: Long! (scalar)
            if (this.AverageFileSize != null)
            {
                 s += ind + "averageFileSize\n";

            }
            //      C# -> System.Int64? Throughput
            // GraphQL -> throughput: Long! (scalar)
            if (this.Throughput != null)
            {
                 s += ind + "throughput\n";

            }
            //      C# -> NcdFilesObjectProtectionStatusData? Files
            // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
            if (this.Files != null)
            {
                 s += ind + "files\n";

                 s += ind + "{\n" + 
                 this.Files.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NcdSharesObjectProtectionStatusData? Shares
            // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
            if (this.Shares != null)
            {
                 s += ind + "shares\n";

                 s += ind + "{\n" + 
                 this.Shares.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? AverageFileSize
            // GraphQL -> averageFileSize: Long! (scalar)
            if (this.AverageFileSize == null && Exploration.Includes(parent + ".averageFileSize$"))
            {
                this.AverageFileSize = new System.Int64();
            }
            //      C# -> System.Int64? Throughput
            // GraphQL -> throughput: Long! (scalar)
            if (this.Throughput == null && Exploration.Includes(parent + ".throughput$"))
            {
                this.Throughput = new System.Int64();
            }
            //      C# -> NcdFilesObjectProtectionStatusData? Files
            // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
            if (this.Files == null && Exploration.Includes(parent + ".files"))
            {
                this.Files = new NcdFilesObjectProtectionStatusData();
                this.Files.ApplyExploratoryFragment(parent + ".files");
            }
            //      C# -> NcdSharesObjectProtectionStatusData? Shares
            // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
            if (this.Shares == null && Exploration.Includes(parent + ".shares"))
            {
                this.Shares = new NcdSharesObjectProtectionStatusData();
                this.Shares.ApplyExploratoryFragment(parent + ".shares");
            }
        }


    #endregion

    } // class NcdObjectProtectionStatus
    #endregion

    public static class ListNcdObjectProtectionStatusExtensions
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
            this List<NcdObjectProtectionStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NcdObjectProtectionStatus> list, 
            String parent = "")
        {
            var item = new NcdObjectProtectionStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types