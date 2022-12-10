// Db2LogSnapshotAppMetadata.cs
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
    #region Db2LogSnapshotAppMetadata
    public class Db2LogSnapshotAppMetadata: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<Db2LogBackupFile>? Backups
        // GraphQL -> backups: [Db2LogBackupFile!] (type)
        [JsonProperty("backups")]
        public List<Db2LogBackupFile>? Backups { get; set; }

        #endregion

    #region methods

    public Db2LogSnapshotAppMetadata Set(
        System.String? SnapshotId = null,
        List<Db2LogBackupFile>? Backups = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Backups != null ) {
            this.Backups = Backups;
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
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> List<Db2LogBackupFile>? Backups
            // GraphQL -> backups: [Db2LogBackupFile!] (type)
            if (this.Backups != null)
            {
                 s += ind + "backups\n";

                 s += ind + "{\n" + 
                 this.Backups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> List<Db2LogBackupFile>? Backups
            // GraphQL -> backups: [Db2LogBackupFile!] (type)
            if (this.Backups == null && Exploration.Includes(parent + ".backups"))
            {
                this.Backups = new List<Db2LogBackupFile>();
                this.Backups.ApplyExploratoryFragment(parent + ".backups");
            }
        }


    #endregion

    } // class Db2LogSnapshotAppMetadata
    #endregion

    public static class ListDb2LogSnapshotAppMetadataExtensions
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
            this List<Db2LogSnapshotAppMetadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2LogSnapshotAppMetadata> list, 
            String parent = "")
        {
            var item = new Db2LogSnapshotAppMetadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types