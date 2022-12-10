// FilesetUpdate.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    #region FilesetUpdate
    public class FilesetUpdate: IFragment
    {
        #region members
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> List<System.Int32>? ForceFullPartitionIds
        // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
        [JsonProperty("forceFullPartitionIds")]
        public List<System.Int32>? ForceFullPartitionIds { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }

        #endregion

    #region methods

    public FilesetUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        System.Boolean? ForceFull = null,
        List<System.Int32>? ForceFullPartitionIds = null,
        System.String? SnapMirrorLabelForFullBackup = null,
        System.String? SnapMirrorLabelForIncrementalBackup = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ForceFull != null ) {
            this.ForceFull = ForceFull;
        }
        if ( ForceFullPartitionIds != null ) {
            this.ForceFullPartitionIds = ForceFullPartitionIds;
        }
        if ( SnapMirrorLabelForFullBackup != null ) {
            this.SnapMirrorLabelForFullBackup = SnapMirrorLabelForFullBackup;
        }
        if ( SnapMirrorLabelForIncrementalBackup != null ) {
            this.SnapMirrorLabelForIncrementalBackup = SnapMirrorLabelForIncrementalBackup;
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
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> System.Boolean? ForceFull
            // GraphQL -> forceFull: Boolean (scalar)
            if (this.ForceFull != null)
            {
                 s += ind + "forceFull\n";

            }
            //      C# -> List<System.Int32>? ForceFullPartitionIds
            // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
            if (this.ForceFullPartitionIds != null)
            {
                 s += ind + "forceFullPartitionIds\n";

            }
            //      C# -> System.String? SnapMirrorLabelForFullBackup
            // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
            if (this.SnapMirrorLabelForFullBackup != null)
            {
                 s += ind + "snapMirrorLabelForFullBackup\n";

            }
            //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
            // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
            if (this.SnapMirrorLabelForIncrementalBackup != null)
            {
                 s += ind + "snapMirrorLabelForIncrementalBackup\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? ForceFull
            // GraphQL -> forceFull: Boolean (scalar)
            if (this.ForceFull == null && Exploration.Includes(parent + ".forceFull$"))
            {
                this.ForceFull = new System.Boolean();
            }
            //      C# -> List<System.Int32>? ForceFullPartitionIds
            // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
            if (this.ForceFullPartitionIds == null && Exploration.Includes(parent + ".forceFullPartitionIds$"))
            {
                this.ForceFullPartitionIds = new List<System.Int32>();
            }
            //      C# -> System.String? SnapMirrorLabelForFullBackup
            // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
            if (this.SnapMirrorLabelForFullBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForFullBackup$"))
            {
                this.SnapMirrorLabelForFullBackup = new System.String("FETCH");
            }
            //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
            // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
            if (this.SnapMirrorLabelForIncrementalBackup == null && Exploration.Includes(parent + ".snapMirrorLabelForIncrementalBackup$"))
            {
                this.SnapMirrorLabelForIncrementalBackup = new System.String("FETCH");
            }
        }


    #endregion

    } // class FilesetUpdate
    #endregion

    public static class ListFilesetUpdateExtensions
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
            this List<FilesetUpdate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetUpdate> list, 
            String parent = "")
        {
            var item = new FilesetUpdate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types