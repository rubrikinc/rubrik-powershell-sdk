// Db2WorkloadDataBackupFile.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region Db2WorkloadDataBackupFile
    public class Db2WorkloadDataBackupFile: IFragment
    {
        #region members
        //      C# -> System.Int32? PartitionNum
        // GraphQL -> partitionNum: Int! (scalar)
        [JsonProperty("partitionNum")]
        public System.Int32? PartitionNum { get; set; }

        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        [JsonProperty("sequenceNum")]
        public System.Int32? SequenceNum { get; set; }

        #endregion

    #region methods

    public Db2WorkloadDataBackupFile Set(
        System.Int32? PartitionNum = null,
        System.Int32? SequenceNum = null
    ) 
    {
        if ( PartitionNum != null ) {
            this.PartitionNum = PartitionNum;
        }
        if ( SequenceNum != null ) {
            this.SequenceNum = SequenceNum;
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
            //      C# -> System.Int32? PartitionNum
            // GraphQL -> partitionNum: Int! (scalar)
            if (this.PartitionNum != null)
            {
                 s += ind + "partitionNum\n";

            }
            //      C# -> System.Int32? SequenceNum
            // GraphQL -> sequenceNum: Int! (scalar)
            if (this.SequenceNum != null)
            {
                 s += ind + "sequenceNum\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? PartitionNum
            // GraphQL -> partitionNum: Int! (scalar)
            if (this.PartitionNum == null && Exploration.Includes(parent + ".partitionNum$"))
            {
                this.PartitionNum = new System.Int32();
            }
            //      C# -> System.Int32? SequenceNum
            // GraphQL -> sequenceNum: Int! (scalar)
            if (this.SequenceNum == null && Exploration.Includes(parent + ".sequenceNum$"))
            {
                this.SequenceNum = new System.Int32();
            }
        }


    #endregion

    } // class Db2WorkloadDataBackupFile
    #endregion

    public static class ListDb2WorkloadDataBackupFileExtensions
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
            this List<Db2WorkloadDataBackupFile> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2WorkloadDataBackupFile> list, 
            String parent = "")
        {
            var item = new Db2WorkloadDataBackupFile();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types